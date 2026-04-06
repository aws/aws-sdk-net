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

/*
 * Do not modify this file. This file is generated from the sagemaker-runtime-http2-2025-10-01.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.SageMakerRuntimeHTTP2.Model;

#pragma warning disable CS1570
namespace Amazon.SageMakerRuntimeHTTP2
{
    /// <summary>
    /// <para>Interface for accessing SageMakerRuntimeHTTP2</para>
    ///
    /// The Amazon SageMaker AI runtime HTTP/2 API.
    /// </summary>
    public partial interface IAmazonSageMakerRuntimeHTTP2 : IAmazonService, IDisposable
    {
                
        #region  InvokeEndpointWithBidirectionalStream

#if NET8_0_OR_GREATER


        /// <summary>
        /// Invokes a model endpoint with bidirectional streaming capabilities. This operation
        /// establishes a persistent connection that allows you to send multiple requests and
        /// receive streaming responses from the model in real-time.
        /// 
        ///  
        /// <para>
        /// Bidirectional streaming is useful for interactive applications such as chatbots, real-time
        /// translation, or any scenario where you need to maintain a conversation-like interaction
        /// with the model. The connection remains open, allowing you to send additional input
        /// and receive responses without establishing a new connection for each request.
        /// </para>
        ///  
        /// <para>
        /// For an overview of Amazon SageMaker AI, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/how-it-works.html">How
        /// It Works</a>.
        /// </para>
        ///  
        /// <para>
        /// Amazon SageMaker AI strips all POST headers except those supported by the API. Amazon
        /// SageMaker AI might add additional headers. You should not rely on the behavior of
        /// headers outside those enumerated in the request syntax. 
        /// </para>
        ///  
        /// <para>
        /// Calls to <c>InvokeEndpointWithBidirectionalStream</c> are authenticated by using Amazon
        /// Web Services Signature Version 4. For information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/sig-v4-authenticating-requests.html">Authenticating
        /// Requests (Amazon Web Services Signature Version 4)</a> in the <i>Amazon S3 API Reference</i>.
        /// </para>
        ///  
        /// <para>
        /// The bidirectional stream maintains the connection until either the client closes it
        /// or the model indicates completion. Each request and response in the stream is sent
        /// as an event with optional headers for data type and completion state.
        /// </para>
        ///  <note> 
        /// <para>
        /// Endpoints are scoped to an individual account, and are not public. The URL does not
        /// contain the account ID, but Amazon SageMaker AI determines the account ID from the
        /// authentication token that is supplied by the caller.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InvokeEndpointWithBidirectionalStream service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the InvokeEndpointWithBidirectionalStream service method, as returned by SageMakerRuntimeHTTP2.</returns>
        /// <exception cref="Amazon.SageMakerRuntimeHTTP2.Model.InputValidationErrorException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <exception cref="Amazon.SageMakerRuntimeHTTP2.Model.InternalServerErrorException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.SageMakerRuntimeHTTP2.Model.InternalStreamFailureException">
        /// Internal stream failure that occurs during streaming.
        /// </exception>
        /// <exception cref="Amazon.SageMakerRuntimeHTTP2.Model.ModelErrorException">
        /// An error occurred while processing the model.
        /// </exception>
        /// <exception cref="Amazon.SageMakerRuntimeHTTP2.Model.ModelStreamErrorException">
        /// Model stream error that occurs during streaming.
        /// </exception>
        /// <exception cref="Amazon.SageMakerRuntimeHTTP2.Model.ServiceUnavailableErrorException">
        /// The request has failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-runtime-http2-2025-10-01/InvokeEndpointWithBidirectionalStream">REST API Reference for InvokeEndpointWithBidirectionalStream Operation</seealso>
        Task<InvokeEndpointWithBidirectionalStreamResponse> InvokeEndpointWithBidirectionalStreamAsync(InvokeEndpointWithBidirectionalStreamRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

#endif
        #endregion
                
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request);
        
        #endregion

        #region Static factory interface methods
#if NET8_0_OR_GREATER
// Warning CA1033 is issued when the child types can not call the method defined in parent types.
// In this use case the intended caller is only meant to be the interface as a factory
// method to create the child types. Given the SDK use case the warning can be ignored.
#pragma warning disable CA1033
        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.DynamicDependency(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties, typeof(AmazonSageMakerRuntimeHTTP2Config))]
        static ClientConfig IAmazonService.CreateDefaultClientConfig() => new AmazonSageMakerRuntimeHTTP2Config();

        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("AssemblyLoadTrimming", "IL2026:RequiresUnreferencedCode",
    Justification = "This suppression is here to ignore the warnings caused by CognitoSync. See justification in IAmazonService.")]
        static IAmazonService IAmazonService.CreateDefaultServiceClient(AWSCredentials awsCredentials, ClientConfig clientConfig)
        {
            var serviceClientConfig = clientConfig as AmazonSageMakerRuntimeHTTP2Config;
            if (serviceClientConfig == null)
            {
                throw new AmazonClientException("ClientConfig is not of type AmazonSageMakerRuntimeHTTP2Config to create AmazonSageMakerRuntimeHTTP2Client");
            }

            return awsCredentials == null ? 
                    new AmazonSageMakerRuntimeHTTP2Client(serviceClientConfig) :
                    new AmazonSageMakerRuntimeHTTP2Client(awsCredentials, serviceClientConfig);
        }
#pragma warning restore CA1033
#endif
        #endregion
    }
}