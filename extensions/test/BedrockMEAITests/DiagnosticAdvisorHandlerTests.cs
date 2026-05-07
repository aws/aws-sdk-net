/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

using System;
using System.Collections.Generic;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using Amazon.BedrockRuntime;
using Amazon.BedrockRuntime.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Moq;
using Xunit;

namespace BedrockMEAITests
{
    public class DiagnosticAdvisorHandlerTests
    {
        private readonly Mock<IAmazonBedrockRuntime> _mockBedrock;
        private readonly DiagnosticAdvisorHandler _handler;

        public DiagnosticAdvisorHandlerTests()
        {
            _mockBedrock = new Mock<IAmazonBedrockRuntime>();
            _handler = new DiagnosticAdvisorHandler(_mockBedrock.Object);
        }

        [Fact]
        public void Constructor_NullBedrockRuntime_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new DiagnosticAdvisorHandler(null!));
        }

        [Fact]
        public async Task InvokeAsync_WhenNoException_PassesThrough()
        {
            var mockInnerHandler = new Mock<IPipelineHandler>();
            var executionContext = CreateExecutionContext();
            var expectedResponse = new AmazonWebServiceResponse();

            mockInnerHandler
                .Setup(h => h.InvokeAsync<AmazonWebServiceResponse>(executionContext))
                .ReturnsAsync(expectedResponse);

            _handler.InnerHandler = mockInnerHandler.Object;

            var result = await _handler.InvokeAsync<AmazonWebServiceResponse>(executionContext);

            Assert.Same(expectedResponse, result);
            _mockBedrock.Verify(
                b => b.ConverseAsync(It.IsAny<ConverseRequest>(), It.IsAny<CancellationToken>()),
                Times.Never);
        }

        [Fact]
        public async Task InvokeAsync_WhenServiceException_AttachesDiagnosticAdvice()
        {
            var mockInnerHandler = new Mock<IPipelineHandler>();
            var executionContext = CreateExecutionContext();
            var serviceException = new AmazonServiceException(
                "Access Denied",
                ErrorType.Sender,
                "AccessDeniedException",
                "req-123",
                HttpStatusCode.Forbidden);

            mockInnerHandler
                .Setup(h => h.InvokeAsync<AmazonWebServiceResponse>(executionContext))
                .ThrowsAsync(serviceException);

            SetupBedrockResponse("Check your IAM permissions for s3:PutObject.");

            _handler.InnerHandler = mockInnerHandler.Object;

            var thrown = await Assert.ThrowsAsync<AmazonServiceException>(
                () => _handler.InvokeAsync<AmazonWebServiceResponse>(executionContext));

            Assert.Same(serviceException, thrown);
            Assert.True(thrown.Data.Contains(DiagnosticAdvisorHandler.DiagnosticAdviceKey));
            Assert.Equal("Check your IAM permissions for s3:PutObject.", thrown.Data[DiagnosticAdvisorHandler.DiagnosticAdviceKey]);
        }

        [Fact]
        public async Task InvokeAsync_WhenBedrockFails_StillRethrowsOriginalException()
        {
            var mockInnerHandler = new Mock<IPipelineHandler>();
            var executionContext = CreateExecutionContext();
            var serviceException = new AmazonServiceException(
                "Throttled",
                ErrorType.Sender,
                "ThrottlingException",
                "req-456",
                HttpStatusCode.TooManyRequests);

            mockInnerHandler
                .Setup(h => h.InvokeAsync<AmazonWebServiceResponse>(executionContext))
                .ThrowsAsync(serviceException);

            _mockBedrock
                .Setup(b => b.ConverseAsync(It.IsAny<ConverseRequest>(), It.IsAny<CancellationToken>()))
                .ThrowsAsync(new Exception("Bedrock is down"));

            _handler.InnerHandler = mockInnerHandler.Object;

            var thrown = await Assert.ThrowsAsync<AmazonServiceException>(
                () => _handler.InvokeAsync<AmazonWebServiceResponse>(executionContext));

            Assert.Same(serviceException, thrown);
            Assert.False(thrown.Data.Contains(DiagnosticAdvisorHandler.DiagnosticAdviceKey));
        }

        [Fact]
        public async Task InvokeAsync_WhenNonServiceException_DoesNotCallBedrock()
        {
            var mockInnerHandler = new Mock<IPipelineHandler>();
            var executionContext = CreateExecutionContext();

            mockInnerHandler
                .Setup(h => h.InvokeAsync<AmazonWebServiceResponse>(executionContext))
                .ThrowsAsync(new InvalidOperationException("Something else"));

            _handler.InnerHandler = mockInnerHandler.Object;

            await Assert.ThrowsAsync<InvalidOperationException>(
                () => _handler.InvokeAsync<AmazonWebServiceResponse>(executionContext));

            _mockBedrock.Verify(
                b => b.ConverseAsync(It.IsAny<ConverseRequest>(), It.IsAny<CancellationToken>()),
                Times.Never);
        }

        [Fact]
        public async Task InvokeAsync_SendsCorrectPromptToBedrock()
        {
            var mockInnerHandler = new Mock<IPipelineHandler>();
            var executionContext = CreateExecutionContext("S3", "PutObjectRequest");
            var serviceException = new AmazonServiceException(
                "Access Denied",
                ErrorType.Sender,
                "AccessDeniedException",
                "req-789",
                HttpStatusCode.Forbidden);

            mockInnerHandler
                .Setup(h => h.InvokeAsync<AmazonWebServiceResponse>(executionContext))
                .ThrowsAsync(serviceException);

            ConverseRequest capturedRequest = null;
            _mockBedrock
                .Setup(b => b.ConverseAsync(It.IsAny<ConverseRequest>(), It.IsAny<CancellationToken>()))
                .Callback<ConverseRequest, CancellationToken>((req, _) => capturedRequest = req)
                .ReturnsAsync(CreateConverseResponse("Fix IAM."));

            _handler.InnerHandler = mockInnerHandler.Object;

            await Assert.ThrowsAsync<AmazonServiceException>(
                () => _handler.InvokeAsync<AmazonWebServiceResponse>(executionContext));

            Assert.NotNull(capturedRequest);
            Assert.Equal("anthropic.claude-3-haiku-20240307-v1:0", capturedRequest.ModelId);

            var userMessage = capturedRequest.Messages[0].Content[0].Text;
            Assert.Contains("S3", userMessage);
            Assert.Contains("PutObjectRequest", userMessage);
            Assert.Contains("AccessDeniedException", userMessage);
            Assert.Contains("403", userMessage);
        }

        [Fact]
        public async Task InvokeAsync_CustomModelId_IsUsed()
        {
            var handler = new DiagnosticAdvisorHandler(_mockBedrock.Object, "anthropic.claude-3-sonnet-20240229-v1:0");
            var mockInnerHandler = new Mock<IPipelineHandler>();
            var executionContext = CreateExecutionContext();

            mockInnerHandler
                .Setup(h => h.InvokeAsync<AmazonWebServiceResponse>(executionContext))
                .ThrowsAsync(new AmazonServiceException("Error", ErrorType.Sender, "SomeError", "req-000", HttpStatusCode.BadRequest));

            ConverseRequest capturedRequest = null;
            _mockBedrock
                .Setup(b => b.ConverseAsync(It.IsAny<ConverseRequest>(), It.IsAny<CancellationToken>()))
                .Callback<ConverseRequest, CancellationToken>((req, _) => capturedRequest = req)
                .ReturnsAsync(CreateConverseResponse("Advice."));

            handler.InnerHandler = mockInnerHandler.Object;

            await Assert.ThrowsAsync<AmazonServiceException>(
                () => handler.InvokeAsync<AmazonWebServiceResponse>(executionContext));

            Assert.Equal("anthropic.claude-3-sonnet-20240229-v1:0", capturedRequest.ModelId);
        }

        #region Helpers

        private void SetupBedrockResponse(string adviceText)
        {
            _mockBedrock
                .Setup(b => b.ConverseAsync(It.IsAny<ConverseRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(CreateConverseResponse(adviceText));
        }

        private static ConverseResponse CreateConverseResponse(string text)
        {
            return new ConverseResponse
            {
                Output = new ConverseOutput
                {
                    Message = new Message
                    {
                        Role = ConversationRole.Assistant,
                        Content = new List<ContentBlock>
                        {
                            new ContentBlock { Text = text }
                        }
                    }
                }
            };
        }

        private static IExecutionContext CreateExecutionContext(string serviceName = "S3", string requestName = "PutObjectRequest")
        {
            var mockRequest = new Mock<IRequest>();
            mockRequest.Setup(r => r.ServiceName).Returns(serviceName);

            var requestContext = new Mock<IRequestContext>();
            requestContext.Setup(r => r.Request).Returns(mockRequest.Object);
            requestContext.Setup(r => r.RequestName).Returns(requestName);

            var responseContext = new Mock<IResponseContext>();

            var executionContext = new Mock<IExecutionContext>();
            executionContext.Setup(e => e.RequestContext).Returns(requestContext.Object);
            executionContext.Setup(e => e.ResponseContext).Returns(responseContext.Object);

            return executionContext.Object;
        }

        #endregion
    }
}
