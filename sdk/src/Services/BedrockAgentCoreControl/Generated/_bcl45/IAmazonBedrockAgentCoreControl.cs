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
 * Do not modify this file. This file is generated from the bedrock-agentcore-control-2023-06-05.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.BedrockAgentCoreControl.Model;

#pragma warning disable CS1570
namespace Amazon.BedrockAgentCoreControl
{
    /// <summary>
    /// <para>Interface for accessing BedrockAgentCoreControl</para>
    ///
    /// <note> 
    /// <para>
    ///  is in preview release and is subject to change.
    /// 
    ///  </note> 
    /// <para>
    /// Welcome to the Amazon Bedrock AgentCore Control plane API reference. Control plane
    /// actions configure, create, modify, and monitor Amazon Web Services resources.
    /// </para>
    /// 
    /// </para>
    /// </summary>
    public partial interface IAmazonBedrockAgentCoreControl : IAmazonService, IDisposable
    {

        /// <summary>
        /// Paginators for the service
        /// </summary>
        IBedrockAgentCoreControlPaginatorFactory Paginators { get; }

        
        #region  CreateAgentRuntime


        /// <summary>
        /// Creates an Amazon Bedrock AgentCore Runtime.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAgentRuntime service method.</param>
        /// 
        /// <returns>The response from the CreateAgentRuntime service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ConflictException">
        /// This exception is thrown when there is a conflict performing an operation
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ServiceQuotaExceededException">
        /// This exception is thrown when a request is made beyond the service quota
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/CreateAgentRuntime">REST API Reference for CreateAgentRuntime Operation</seealso>
        CreateAgentRuntimeResponse CreateAgentRuntime(CreateAgentRuntimeRequest request);



        /// <summary>
        /// Creates an Amazon Bedrock AgentCore Runtime.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAgentRuntime service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAgentRuntime service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ConflictException">
        /// This exception is thrown when there is a conflict performing an operation
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ServiceQuotaExceededException">
        /// This exception is thrown when a request is made beyond the service quota
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/CreateAgentRuntime">REST API Reference for CreateAgentRuntime Operation</seealso>
        Task<CreateAgentRuntimeResponse> CreateAgentRuntimeAsync(CreateAgentRuntimeRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateAgentRuntimeEndpoint


        /// <summary>
        /// Creates an AgentCore Runtime endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAgentRuntimeEndpoint service method.</param>
        /// 
        /// <returns>The response from the CreateAgentRuntimeEndpoint service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ConflictException">
        /// This exception is thrown when there is a conflict performing an operation
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ServiceQuotaExceededException">
        /// This exception is thrown when a request is made beyond the service quota
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/CreateAgentRuntimeEndpoint">REST API Reference for CreateAgentRuntimeEndpoint Operation</seealso>
        CreateAgentRuntimeEndpointResponse CreateAgentRuntimeEndpoint(CreateAgentRuntimeEndpointRequest request);



        /// <summary>
        /// Creates an AgentCore Runtime endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAgentRuntimeEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAgentRuntimeEndpoint service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ConflictException">
        /// This exception is thrown when there is a conflict performing an operation
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ServiceQuotaExceededException">
        /// This exception is thrown when a request is made beyond the service quota
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/CreateAgentRuntimeEndpoint">REST API Reference for CreateAgentRuntimeEndpoint Operation</seealso>
        Task<CreateAgentRuntimeEndpointResponse> CreateAgentRuntimeEndpointAsync(CreateAgentRuntimeEndpointRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateApiKeyCredentialProvider


        /// <summary>
        /// Creates a new API key credential provider.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateApiKeyCredentialProvider service method.</param>
        /// 
        /// <returns>The response from the CreateApiKeyCredentialProvider service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ConflictException">
        /// This exception is thrown when there is a conflict performing an operation
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.DecryptionFailureException">
        /// Exception thrown when decryption of a secret fails.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.EncryptionFailureException">
        /// Exception thrown when encryption of a secret fails.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ResourceLimitExceededException">
        /// Exception thrown when a resource limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ServiceQuotaExceededException">
        /// This exception is thrown when a request is made beyond the service quota
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.UnauthorizedException">
        /// This exception is thrown when the JWT bearer token is invalid or not found for OAuth
        /// bearer token based access
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/CreateApiKeyCredentialProvider">REST API Reference for CreateApiKeyCredentialProvider Operation</seealso>
        CreateApiKeyCredentialProviderResponse CreateApiKeyCredentialProvider(CreateApiKeyCredentialProviderRequest request);



        /// <summary>
        /// Creates a new API key credential provider.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateApiKeyCredentialProvider service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateApiKeyCredentialProvider service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ConflictException">
        /// This exception is thrown when there is a conflict performing an operation
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.DecryptionFailureException">
        /// Exception thrown when decryption of a secret fails.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.EncryptionFailureException">
        /// Exception thrown when encryption of a secret fails.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ResourceLimitExceededException">
        /// Exception thrown when a resource limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ServiceQuotaExceededException">
        /// This exception is thrown when a request is made beyond the service quota
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.UnauthorizedException">
        /// This exception is thrown when the JWT bearer token is invalid or not found for OAuth
        /// bearer token based access
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/CreateApiKeyCredentialProvider">REST API Reference for CreateApiKeyCredentialProvider Operation</seealso>
        Task<CreateApiKeyCredentialProviderResponse> CreateApiKeyCredentialProviderAsync(CreateApiKeyCredentialProviderRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateBrowser


        /// <summary>
        /// Creates a custom browser.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBrowser service method.</param>
        /// 
        /// <returns>The response from the CreateBrowser service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ConflictException">
        /// This exception is thrown when there is a conflict performing an operation
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ServiceQuotaExceededException">
        /// This exception is thrown when a request is made beyond the service quota
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/CreateBrowser">REST API Reference for CreateBrowser Operation</seealso>
        CreateBrowserResponse CreateBrowser(CreateBrowserRequest request);



        /// <summary>
        /// Creates a custom browser.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBrowser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateBrowser service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ConflictException">
        /// This exception is thrown when there is a conflict performing an operation
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ServiceQuotaExceededException">
        /// This exception is thrown when a request is made beyond the service quota
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/CreateBrowser">REST API Reference for CreateBrowser Operation</seealso>
        Task<CreateBrowserResponse> CreateBrowserAsync(CreateBrowserRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateCodeInterpreter


        /// <summary>
        /// Creates a custom code interpreter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCodeInterpreter service method.</param>
        /// 
        /// <returns>The response from the CreateCodeInterpreter service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ConflictException">
        /// This exception is thrown when there is a conflict performing an operation
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ServiceQuotaExceededException">
        /// This exception is thrown when a request is made beyond the service quota
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/CreateCodeInterpreter">REST API Reference for CreateCodeInterpreter Operation</seealso>
        CreateCodeInterpreterResponse CreateCodeInterpreter(CreateCodeInterpreterRequest request);



        /// <summary>
        /// Creates a custom code interpreter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCodeInterpreter service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateCodeInterpreter service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ConflictException">
        /// This exception is thrown when there is a conflict performing an operation
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ServiceQuotaExceededException">
        /// This exception is thrown when a request is made beyond the service quota
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/CreateCodeInterpreter">REST API Reference for CreateCodeInterpreter Operation</seealso>
        Task<CreateCodeInterpreterResponse> CreateCodeInterpreterAsync(CreateCodeInterpreterRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateGateway


        /// <summary>
        /// Creates a gateway for Amazon Bedrock Agent. A gateway serves as an integration point
        /// between your agent and external services.
        /// 
        ///  
        /// <para>
        /// To create a gateway, you must specify a name, protocol type, and IAM role. The role
        /// grants the gateway permission to access Amazon Web Services services and resources.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGateway service method.</param>
        /// 
        /// <returns>The response from the CreateGateway service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ConflictException">
        /// This exception is thrown when there is a conflict performing an operation
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ServiceQuotaExceededException">
        /// This exception is thrown when a request is made beyond the service quota
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/CreateGateway">REST API Reference for CreateGateway Operation</seealso>
        CreateGatewayResponse CreateGateway(CreateGatewayRequest request);



        /// <summary>
        /// Creates a gateway for Amazon Bedrock Agent. A gateway serves as an integration point
        /// between your agent and external services.
        /// 
        ///  
        /// <para>
        /// To create a gateway, you must specify a name, protocol type, and IAM role. The role
        /// grants the gateway permission to access Amazon Web Services services and resources.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGateway service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateGateway service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ConflictException">
        /// This exception is thrown when there is a conflict performing an operation
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ServiceQuotaExceededException">
        /// This exception is thrown when a request is made beyond the service quota
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/CreateGateway">REST API Reference for CreateGateway Operation</seealso>
        Task<CreateGatewayResponse> CreateGatewayAsync(CreateGatewayRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateGatewayTarget


        /// <summary>
        /// Creates a target for a gateway. A target defines an endpoint that the gateway can
        /// connect to.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGatewayTarget service method.</param>
        /// 
        /// <returns>The response from the CreateGatewayTarget service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ConflictException">
        /// This exception is thrown when there is a conflict performing an operation
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ServiceQuotaExceededException">
        /// This exception is thrown when a request is made beyond the service quota
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/CreateGatewayTarget">REST API Reference for CreateGatewayTarget Operation</seealso>
        CreateGatewayTargetResponse CreateGatewayTarget(CreateGatewayTargetRequest request);



        /// <summary>
        /// Creates a target for a gateway. A target defines an endpoint that the gateway can
        /// connect to.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGatewayTarget service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateGatewayTarget service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ConflictException">
        /// This exception is thrown when there is a conflict performing an operation
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ServiceQuotaExceededException">
        /// This exception is thrown when a request is made beyond the service quota
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/CreateGatewayTarget">REST API Reference for CreateGatewayTarget Operation</seealso>
        Task<CreateGatewayTargetResponse> CreateGatewayTargetAsync(CreateGatewayTargetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateMemory


        /// <summary>
        /// Creates a new Amazon Bedrock AgentCore Memory resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMemory service method.</param>
        /// 
        /// <returns>The response from the CreateMemory service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ConflictException">
        /// This exception is thrown when there is a conflict performing an operation
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ServiceException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ServiceQuotaExceededException">
        /// This exception is thrown when a request is made beyond the service quota
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottledException">
        /// API rate limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/CreateMemory">REST API Reference for CreateMemory Operation</seealso>
        CreateMemoryResponse CreateMemory(CreateMemoryRequest request);



        /// <summary>
        /// Creates a new Amazon Bedrock AgentCore Memory resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMemory service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateMemory service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ConflictException">
        /// This exception is thrown when there is a conflict performing an operation
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ServiceException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ServiceQuotaExceededException">
        /// This exception is thrown when a request is made beyond the service quota
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottledException">
        /// API rate limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/CreateMemory">REST API Reference for CreateMemory Operation</seealso>
        Task<CreateMemoryResponse> CreateMemoryAsync(CreateMemoryRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateOauth2CredentialProvider


        /// <summary>
        /// Creates a new OAuth2 credential provider.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateOauth2CredentialProvider service method.</param>
        /// 
        /// <returns>The response from the CreateOauth2CredentialProvider service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ConflictException">
        /// This exception is thrown when there is a conflict performing an operation
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.DecryptionFailureException">
        /// Exception thrown when decryption of a secret fails.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.EncryptionFailureException">
        /// Exception thrown when encryption of a secret fails.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ResourceLimitExceededException">
        /// Exception thrown when a resource limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ServiceQuotaExceededException">
        /// This exception is thrown when a request is made beyond the service quota
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.UnauthorizedException">
        /// This exception is thrown when the JWT bearer token is invalid or not found for OAuth
        /// bearer token based access
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/CreateOauth2CredentialProvider">REST API Reference for CreateOauth2CredentialProvider Operation</seealso>
        CreateOauth2CredentialProviderResponse CreateOauth2CredentialProvider(CreateOauth2CredentialProviderRequest request);



        /// <summary>
        /// Creates a new OAuth2 credential provider.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateOauth2CredentialProvider service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateOauth2CredentialProvider service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ConflictException">
        /// This exception is thrown when there is a conflict performing an operation
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.DecryptionFailureException">
        /// Exception thrown when decryption of a secret fails.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.EncryptionFailureException">
        /// Exception thrown when encryption of a secret fails.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ResourceLimitExceededException">
        /// Exception thrown when a resource limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ServiceQuotaExceededException">
        /// This exception is thrown when a request is made beyond the service quota
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.UnauthorizedException">
        /// This exception is thrown when the JWT bearer token is invalid or not found for OAuth
        /// bearer token based access
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/CreateOauth2CredentialProvider">REST API Reference for CreateOauth2CredentialProvider Operation</seealso>
        Task<CreateOauth2CredentialProviderResponse> CreateOauth2CredentialProviderAsync(CreateOauth2CredentialProviderRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateWorkloadIdentity


        /// <summary>
        /// Creates a new workload identity.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkloadIdentity service method.</param>
        /// 
        /// <returns>The response from the CreateWorkloadIdentity service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.UnauthorizedException">
        /// This exception is thrown when the JWT bearer token is invalid or not found for OAuth
        /// bearer token based access
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/CreateWorkloadIdentity">REST API Reference for CreateWorkloadIdentity Operation</seealso>
        CreateWorkloadIdentityResponse CreateWorkloadIdentity(CreateWorkloadIdentityRequest request);



        /// <summary>
        /// Creates a new workload identity.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkloadIdentity service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateWorkloadIdentity service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.UnauthorizedException">
        /// This exception is thrown when the JWT bearer token is invalid or not found for OAuth
        /// bearer token based access
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/CreateWorkloadIdentity">REST API Reference for CreateWorkloadIdentity Operation</seealso>
        Task<CreateWorkloadIdentityResponse> CreateWorkloadIdentityAsync(CreateWorkloadIdentityRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteAgentRuntime


        /// <summary>
        /// Deletes an Amazon Bedrock AgentCore Runtime.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAgentRuntime service method.</param>
        /// 
        /// <returns>The response from the DeleteAgentRuntime service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ConflictException">
        /// This exception is thrown when there is a conflict performing an operation
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/DeleteAgentRuntime">REST API Reference for DeleteAgentRuntime Operation</seealso>
        DeleteAgentRuntimeResponse DeleteAgentRuntime(DeleteAgentRuntimeRequest request);



        /// <summary>
        /// Deletes an Amazon Bedrock AgentCore Runtime.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAgentRuntime service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAgentRuntime service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ConflictException">
        /// This exception is thrown when there is a conflict performing an operation
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/DeleteAgentRuntime">REST API Reference for DeleteAgentRuntime Operation</seealso>
        Task<DeleteAgentRuntimeResponse> DeleteAgentRuntimeAsync(DeleteAgentRuntimeRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteAgentRuntimeEndpoint


        /// <summary>
        /// Deletes an AAgentCore Runtime endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAgentRuntimeEndpoint service method.</param>
        /// 
        /// <returns>The response from the DeleteAgentRuntimeEndpoint service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ConflictException">
        /// This exception is thrown when there is a conflict performing an operation
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/DeleteAgentRuntimeEndpoint">REST API Reference for DeleteAgentRuntimeEndpoint Operation</seealso>
        DeleteAgentRuntimeEndpointResponse DeleteAgentRuntimeEndpoint(DeleteAgentRuntimeEndpointRequest request);



        /// <summary>
        /// Deletes an AAgentCore Runtime endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAgentRuntimeEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAgentRuntimeEndpoint service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ConflictException">
        /// This exception is thrown when there is a conflict performing an operation
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/DeleteAgentRuntimeEndpoint">REST API Reference for DeleteAgentRuntimeEndpoint Operation</seealso>
        Task<DeleteAgentRuntimeEndpointResponse> DeleteAgentRuntimeEndpointAsync(DeleteAgentRuntimeEndpointRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteApiKeyCredentialProvider


        /// <summary>
        /// Deletes an API key credential provider.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApiKeyCredentialProvider service method.</param>
        /// 
        /// <returns>The response from the DeleteApiKeyCredentialProvider service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.UnauthorizedException">
        /// This exception is thrown when the JWT bearer token is invalid or not found for OAuth
        /// bearer token based access
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/DeleteApiKeyCredentialProvider">REST API Reference for DeleteApiKeyCredentialProvider Operation</seealso>
        DeleteApiKeyCredentialProviderResponse DeleteApiKeyCredentialProvider(DeleteApiKeyCredentialProviderRequest request);



        /// <summary>
        /// Deletes an API key credential provider.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApiKeyCredentialProvider service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteApiKeyCredentialProvider service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.UnauthorizedException">
        /// This exception is thrown when the JWT bearer token is invalid or not found for OAuth
        /// bearer token based access
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/DeleteApiKeyCredentialProvider">REST API Reference for DeleteApiKeyCredentialProvider Operation</seealso>
        Task<DeleteApiKeyCredentialProviderResponse> DeleteApiKeyCredentialProviderAsync(DeleteApiKeyCredentialProviderRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteBrowser


        /// <summary>
        /// Deletes a custom browser.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBrowser service method.</param>
        /// 
        /// <returns>The response from the DeleteBrowser service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ConflictException">
        /// This exception is thrown when there is a conflict performing an operation
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ServiceQuotaExceededException">
        /// This exception is thrown when a request is made beyond the service quota
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/DeleteBrowser">REST API Reference for DeleteBrowser Operation</seealso>
        DeleteBrowserResponse DeleteBrowser(DeleteBrowserRequest request);



        /// <summary>
        /// Deletes a custom browser.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBrowser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteBrowser service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ConflictException">
        /// This exception is thrown when there is a conflict performing an operation
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ServiceQuotaExceededException">
        /// This exception is thrown when a request is made beyond the service quota
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/DeleteBrowser">REST API Reference for DeleteBrowser Operation</seealso>
        Task<DeleteBrowserResponse> DeleteBrowserAsync(DeleteBrowserRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteCodeInterpreter


        /// <summary>
        /// Deletes a custom code interpreter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCodeInterpreter service method.</param>
        /// 
        /// <returns>The response from the DeleteCodeInterpreter service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ConflictException">
        /// This exception is thrown when there is a conflict performing an operation
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ServiceQuotaExceededException">
        /// This exception is thrown when a request is made beyond the service quota
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/DeleteCodeInterpreter">REST API Reference for DeleteCodeInterpreter Operation</seealso>
        DeleteCodeInterpreterResponse DeleteCodeInterpreter(DeleteCodeInterpreterRequest request);



        /// <summary>
        /// Deletes a custom code interpreter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCodeInterpreter service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteCodeInterpreter service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ConflictException">
        /// This exception is thrown when there is a conflict performing an operation
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ServiceQuotaExceededException">
        /// This exception is thrown when a request is made beyond the service quota
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/DeleteCodeInterpreter">REST API Reference for DeleteCodeInterpreter Operation</seealso>
        Task<DeleteCodeInterpreterResponse> DeleteCodeInterpreterAsync(DeleteCodeInterpreterRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteGateway


        /// <summary>
        /// Deletes a gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGateway service method.</param>
        /// 
        /// <returns>The response from the DeleteGateway service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ConflictException">
        /// This exception is thrown when there is a conflict performing an operation
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/DeleteGateway">REST API Reference for DeleteGateway Operation</seealso>
        DeleteGatewayResponse DeleteGateway(DeleteGatewayRequest request);



        /// <summary>
        /// Deletes a gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGateway service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteGateway service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ConflictException">
        /// This exception is thrown when there is a conflict performing an operation
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/DeleteGateway">REST API Reference for DeleteGateway Operation</seealso>
        Task<DeleteGatewayResponse> DeleteGatewayAsync(DeleteGatewayRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteGatewayTarget


        /// <summary>
        /// Deletes a gateway target.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGatewayTarget service method.</param>
        /// 
        /// <returns>The response from the DeleteGatewayTarget service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ConflictException">
        /// This exception is thrown when there is a conflict performing an operation
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/DeleteGatewayTarget">REST API Reference for DeleteGatewayTarget Operation</seealso>
        DeleteGatewayTargetResponse DeleteGatewayTarget(DeleteGatewayTargetRequest request);



        /// <summary>
        /// Deletes a gateway target.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGatewayTarget service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteGatewayTarget service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ConflictException">
        /// This exception is thrown when there is a conflict performing an operation
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/DeleteGatewayTarget">REST API Reference for DeleteGatewayTarget Operation</seealso>
        Task<DeleteGatewayTargetResponse> DeleteGatewayTargetAsync(DeleteGatewayTargetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteMemory


        /// <summary>
        /// Deletes an Amazon Bedrock AgentCore Memory resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMemory service method.</param>
        /// 
        /// <returns>The response from the DeleteMemory service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ServiceException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottledException">
        /// API rate limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/DeleteMemory">REST API Reference for DeleteMemory Operation</seealso>
        DeleteMemoryResponse DeleteMemory(DeleteMemoryRequest request);



        /// <summary>
        /// Deletes an Amazon Bedrock AgentCore Memory resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMemory service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteMemory service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ServiceException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottledException">
        /// API rate limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/DeleteMemory">REST API Reference for DeleteMemory Operation</seealso>
        Task<DeleteMemoryResponse> DeleteMemoryAsync(DeleteMemoryRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteOauth2CredentialProvider


        /// <summary>
        /// Deletes an OAuth2 credential provider.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteOauth2CredentialProvider service method.</param>
        /// 
        /// <returns>The response from the DeleteOauth2CredentialProvider service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.UnauthorizedException">
        /// This exception is thrown when the JWT bearer token is invalid or not found for OAuth
        /// bearer token based access
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/DeleteOauth2CredentialProvider">REST API Reference for DeleteOauth2CredentialProvider Operation</seealso>
        DeleteOauth2CredentialProviderResponse DeleteOauth2CredentialProvider(DeleteOauth2CredentialProviderRequest request);



        /// <summary>
        /// Deletes an OAuth2 credential provider.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteOauth2CredentialProvider service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteOauth2CredentialProvider service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.UnauthorizedException">
        /// This exception is thrown when the JWT bearer token is invalid or not found for OAuth
        /// bearer token based access
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/DeleteOauth2CredentialProvider">REST API Reference for DeleteOauth2CredentialProvider Operation</seealso>
        Task<DeleteOauth2CredentialProviderResponse> DeleteOauth2CredentialProviderAsync(DeleteOauth2CredentialProviderRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteWorkloadIdentity


        /// <summary>
        /// Deletes a workload identity.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkloadIdentity service method.</param>
        /// 
        /// <returns>The response from the DeleteWorkloadIdentity service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.UnauthorizedException">
        /// This exception is thrown when the JWT bearer token is invalid or not found for OAuth
        /// bearer token based access
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/DeleteWorkloadIdentity">REST API Reference for DeleteWorkloadIdentity Operation</seealso>
        DeleteWorkloadIdentityResponse DeleteWorkloadIdentity(DeleteWorkloadIdentityRequest request);



        /// <summary>
        /// Deletes a workload identity.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkloadIdentity service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteWorkloadIdentity service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.UnauthorizedException">
        /// This exception is thrown when the JWT bearer token is invalid or not found for OAuth
        /// bearer token based access
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/DeleteWorkloadIdentity">REST API Reference for DeleteWorkloadIdentity Operation</seealso>
        Task<DeleteWorkloadIdentityResponse> DeleteWorkloadIdentityAsync(DeleteWorkloadIdentityRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetAgentRuntime


        /// <summary>
        /// Gets an Amazon Bedrock AgentCore Runtime.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAgentRuntime service method.</param>
        /// 
        /// <returns>The response from the GetAgentRuntime service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/GetAgentRuntime">REST API Reference for GetAgentRuntime Operation</seealso>
        GetAgentRuntimeResponse GetAgentRuntime(GetAgentRuntimeRequest request);



        /// <summary>
        /// Gets an Amazon Bedrock AgentCore Runtime.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAgentRuntime service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAgentRuntime service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/GetAgentRuntime">REST API Reference for GetAgentRuntime Operation</seealso>
        Task<GetAgentRuntimeResponse> GetAgentRuntimeAsync(GetAgentRuntimeRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetAgentRuntimeEndpoint


        /// <summary>
        /// Gets information about an Amazon Secure AgentEndpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAgentRuntimeEndpoint service method.</param>
        /// 
        /// <returns>The response from the GetAgentRuntimeEndpoint service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/GetAgentRuntimeEndpoint">REST API Reference for GetAgentRuntimeEndpoint Operation</seealso>
        GetAgentRuntimeEndpointResponse GetAgentRuntimeEndpoint(GetAgentRuntimeEndpointRequest request);



        /// <summary>
        /// Gets information about an Amazon Secure AgentEndpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAgentRuntimeEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAgentRuntimeEndpoint service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/GetAgentRuntimeEndpoint">REST API Reference for GetAgentRuntimeEndpoint Operation</seealso>
        Task<GetAgentRuntimeEndpointResponse> GetAgentRuntimeEndpointAsync(GetAgentRuntimeEndpointRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetApiKeyCredentialProvider


        /// <summary>
        /// Retrieves information about an API key credential provider.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApiKeyCredentialProvider service method.</param>
        /// 
        /// <returns>The response from the GetApiKeyCredentialProvider service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.DecryptionFailureException">
        /// Exception thrown when decryption of a secret fails.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.UnauthorizedException">
        /// This exception is thrown when the JWT bearer token is invalid or not found for OAuth
        /// bearer token based access
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/GetApiKeyCredentialProvider">REST API Reference for GetApiKeyCredentialProvider Operation</seealso>
        GetApiKeyCredentialProviderResponse GetApiKeyCredentialProvider(GetApiKeyCredentialProviderRequest request);



        /// <summary>
        /// Retrieves information about an API key credential provider.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApiKeyCredentialProvider service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetApiKeyCredentialProvider service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.DecryptionFailureException">
        /// Exception thrown when decryption of a secret fails.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.UnauthorizedException">
        /// This exception is thrown when the JWT bearer token is invalid or not found for OAuth
        /// bearer token based access
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/GetApiKeyCredentialProvider">REST API Reference for GetApiKeyCredentialProvider Operation</seealso>
        Task<GetApiKeyCredentialProviderResponse> GetApiKeyCredentialProviderAsync(GetApiKeyCredentialProviderRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetBrowser


        /// <summary>
        /// Gets information about a custom browser.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBrowser service method.</param>
        /// 
        /// <returns>The response from the GetBrowser service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ServiceQuotaExceededException">
        /// This exception is thrown when a request is made beyond the service quota
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/GetBrowser">REST API Reference for GetBrowser Operation</seealso>
        GetBrowserResponse GetBrowser(GetBrowserRequest request);



        /// <summary>
        /// Gets information about a custom browser.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBrowser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetBrowser service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ServiceQuotaExceededException">
        /// This exception is thrown when a request is made beyond the service quota
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/GetBrowser">REST API Reference for GetBrowser Operation</seealso>
        Task<GetBrowserResponse> GetBrowserAsync(GetBrowserRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetCodeInterpreter


        /// <summary>
        /// Gets information about a custom code interpreter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCodeInterpreter service method.</param>
        /// 
        /// <returns>The response from the GetCodeInterpreter service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ServiceQuotaExceededException">
        /// This exception is thrown when a request is made beyond the service quota
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/GetCodeInterpreter">REST API Reference for GetCodeInterpreter Operation</seealso>
        GetCodeInterpreterResponse GetCodeInterpreter(GetCodeInterpreterRequest request);



        /// <summary>
        /// Gets information about a custom code interpreter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCodeInterpreter service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCodeInterpreter service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ServiceQuotaExceededException">
        /// This exception is thrown when a request is made beyond the service quota
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/GetCodeInterpreter">REST API Reference for GetCodeInterpreter Operation</seealso>
        Task<GetCodeInterpreterResponse> GetCodeInterpreterAsync(GetCodeInterpreterRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetGateway


        /// <summary>
        /// Retrieves information about a specific Gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGateway service method.</param>
        /// 
        /// <returns>The response from the GetGateway service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/GetGateway">REST API Reference for GetGateway Operation</seealso>
        GetGatewayResponse GetGateway(GetGatewayRequest request);



        /// <summary>
        /// Retrieves information about a specific Gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGateway service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetGateway service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/GetGateway">REST API Reference for GetGateway Operation</seealso>
        Task<GetGatewayResponse> GetGatewayAsync(GetGatewayRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetGatewayTarget


        /// <summary>
        /// Retrieves information about a specific gateway target.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGatewayTarget service method.</param>
        /// 
        /// <returns>The response from the GetGatewayTarget service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/GetGatewayTarget">REST API Reference for GetGatewayTarget Operation</seealso>
        GetGatewayTargetResponse GetGatewayTarget(GetGatewayTargetRequest request);



        /// <summary>
        /// Retrieves information about a specific gateway target.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGatewayTarget service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetGatewayTarget service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/GetGatewayTarget">REST API Reference for GetGatewayTarget Operation</seealso>
        Task<GetGatewayTargetResponse> GetGatewayTargetAsync(GetGatewayTargetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetMemory


        /// <summary>
        /// Retrieve an existing Amazon Bedrock AgentCore Memory resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMemory service method.</param>
        /// 
        /// <returns>The response from the GetMemory service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ServiceException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottledException">
        /// API rate limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/GetMemory">REST API Reference for GetMemory Operation</seealso>
        GetMemoryResponse GetMemory(GetMemoryRequest request);



        /// <summary>
        /// Retrieve an existing Amazon Bedrock AgentCore Memory resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMemory service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetMemory service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ServiceException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottledException">
        /// API rate limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/GetMemory">REST API Reference for GetMemory Operation</seealso>
        Task<GetMemoryResponse> GetMemoryAsync(GetMemoryRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetOauth2CredentialProvider


        /// <summary>
        /// Retrieves information about an OAuth2 credential provider.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOauth2CredentialProvider service method.</param>
        /// 
        /// <returns>The response from the GetOauth2CredentialProvider service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.DecryptionFailureException">
        /// Exception thrown when decryption of a secret fails.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.UnauthorizedException">
        /// This exception is thrown when the JWT bearer token is invalid or not found for OAuth
        /// bearer token based access
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/GetOauth2CredentialProvider">REST API Reference for GetOauth2CredentialProvider Operation</seealso>
        GetOauth2CredentialProviderResponse GetOauth2CredentialProvider(GetOauth2CredentialProviderRequest request);



        /// <summary>
        /// Retrieves information about an OAuth2 credential provider.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOauth2CredentialProvider service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetOauth2CredentialProvider service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.DecryptionFailureException">
        /// Exception thrown when decryption of a secret fails.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.UnauthorizedException">
        /// This exception is thrown when the JWT bearer token is invalid or not found for OAuth
        /// bearer token based access
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/GetOauth2CredentialProvider">REST API Reference for GetOauth2CredentialProvider Operation</seealso>
        Task<GetOauth2CredentialProviderResponse> GetOauth2CredentialProviderAsync(GetOauth2CredentialProviderRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetTokenVault


        /// <summary>
        /// Retrieves information about a token vault.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTokenVault service method.</param>
        /// 
        /// <returns>The response from the GetTokenVault service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.UnauthorizedException">
        /// This exception is thrown when the JWT bearer token is invalid or not found for OAuth
        /// bearer token based access
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/GetTokenVault">REST API Reference for GetTokenVault Operation</seealso>
        GetTokenVaultResponse GetTokenVault(GetTokenVaultRequest request);



        /// <summary>
        /// Retrieves information about a token vault.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTokenVault service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTokenVault service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.UnauthorizedException">
        /// This exception is thrown when the JWT bearer token is invalid or not found for OAuth
        /// bearer token based access
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/GetTokenVault">REST API Reference for GetTokenVault Operation</seealso>
        Task<GetTokenVaultResponse> GetTokenVaultAsync(GetTokenVaultRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetWorkloadIdentity


        /// <summary>
        /// Retrieves information about a workload identity.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWorkloadIdentity service method.</param>
        /// 
        /// <returns>The response from the GetWorkloadIdentity service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.UnauthorizedException">
        /// This exception is thrown when the JWT bearer token is invalid or not found for OAuth
        /// bearer token based access
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/GetWorkloadIdentity">REST API Reference for GetWorkloadIdentity Operation</seealso>
        GetWorkloadIdentityResponse GetWorkloadIdentity(GetWorkloadIdentityRequest request);



        /// <summary>
        /// Retrieves information about a workload identity.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWorkloadIdentity service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetWorkloadIdentity service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.UnauthorizedException">
        /// This exception is thrown when the JWT bearer token is invalid or not found for OAuth
        /// bearer token based access
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/GetWorkloadIdentity">REST API Reference for GetWorkloadIdentity Operation</seealso>
        Task<GetWorkloadIdentityResponse> GetWorkloadIdentityAsync(GetWorkloadIdentityRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListAgentRuntimeEndpoints


        /// <summary>
        /// Lists all endpoints for a specific Amazon Secure Agent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAgentRuntimeEndpoints service method.</param>
        /// 
        /// <returns>The response from the ListAgentRuntimeEndpoints service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/ListAgentRuntimeEndpoints">REST API Reference for ListAgentRuntimeEndpoints Operation</seealso>
        ListAgentRuntimeEndpointsResponse ListAgentRuntimeEndpoints(ListAgentRuntimeEndpointsRequest request);



        /// <summary>
        /// Lists all endpoints for a specific Amazon Secure Agent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAgentRuntimeEndpoints service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAgentRuntimeEndpoints service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/ListAgentRuntimeEndpoints">REST API Reference for ListAgentRuntimeEndpoints Operation</seealso>
        Task<ListAgentRuntimeEndpointsResponse> ListAgentRuntimeEndpointsAsync(ListAgentRuntimeEndpointsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListAgentRuntimes


        /// <summary>
        /// Lists all Amazon Secure Agents in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAgentRuntimes service method.</param>
        /// 
        /// <returns>The response from the ListAgentRuntimes service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/ListAgentRuntimes">REST API Reference for ListAgentRuntimes Operation</seealso>
        ListAgentRuntimesResponse ListAgentRuntimes(ListAgentRuntimesRequest request);



        /// <summary>
        /// Lists all Amazon Secure Agents in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAgentRuntimes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAgentRuntimes service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/ListAgentRuntimes">REST API Reference for ListAgentRuntimes Operation</seealso>
        Task<ListAgentRuntimesResponse> ListAgentRuntimesAsync(ListAgentRuntimesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListAgentRuntimeVersions


        /// <summary>
        /// Lists all versions of a specific Amazon Secure Agent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAgentRuntimeVersions service method.</param>
        /// 
        /// <returns>The response from the ListAgentRuntimeVersions service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/ListAgentRuntimeVersions">REST API Reference for ListAgentRuntimeVersions Operation</seealso>
        ListAgentRuntimeVersionsResponse ListAgentRuntimeVersions(ListAgentRuntimeVersionsRequest request);



        /// <summary>
        /// Lists all versions of a specific Amazon Secure Agent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAgentRuntimeVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAgentRuntimeVersions service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/ListAgentRuntimeVersions">REST API Reference for ListAgentRuntimeVersions Operation</seealso>
        Task<ListAgentRuntimeVersionsResponse> ListAgentRuntimeVersionsAsync(ListAgentRuntimeVersionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListApiKeyCredentialProviders


        /// <summary>
        /// Lists all API key credential providers in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApiKeyCredentialProviders service method.</param>
        /// 
        /// <returns>The response from the ListApiKeyCredentialProviders service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.UnauthorizedException">
        /// This exception is thrown when the JWT bearer token is invalid or not found for OAuth
        /// bearer token based access
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/ListApiKeyCredentialProviders">REST API Reference for ListApiKeyCredentialProviders Operation</seealso>
        ListApiKeyCredentialProvidersResponse ListApiKeyCredentialProviders(ListApiKeyCredentialProvidersRequest request);



        /// <summary>
        /// Lists all API key credential providers in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApiKeyCredentialProviders service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListApiKeyCredentialProviders service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.UnauthorizedException">
        /// This exception is thrown when the JWT bearer token is invalid or not found for OAuth
        /// bearer token based access
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/ListApiKeyCredentialProviders">REST API Reference for ListApiKeyCredentialProviders Operation</seealso>
        Task<ListApiKeyCredentialProvidersResponse> ListApiKeyCredentialProvidersAsync(ListApiKeyCredentialProvidersRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListBrowsers


        /// <summary>
        /// Lists all custom browsers in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBrowsers service method.</param>
        /// 
        /// <returns>The response from the ListBrowsers service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/ListBrowsers">REST API Reference for ListBrowsers Operation</seealso>
        ListBrowsersResponse ListBrowsers(ListBrowsersRequest request);



        /// <summary>
        /// Lists all custom browsers in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBrowsers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListBrowsers service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/ListBrowsers">REST API Reference for ListBrowsers Operation</seealso>
        Task<ListBrowsersResponse> ListBrowsersAsync(ListBrowsersRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListCodeInterpreters


        /// <summary>
        /// Lists all custom code interpreters in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCodeInterpreters service method.</param>
        /// 
        /// <returns>The response from the ListCodeInterpreters service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/ListCodeInterpreters">REST API Reference for ListCodeInterpreters Operation</seealso>
        ListCodeInterpretersResponse ListCodeInterpreters(ListCodeInterpretersRequest request);



        /// <summary>
        /// Lists all custom code interpreters in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCodeInterpreters service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCodeInterpreters service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/ListCodeInterpreters">REST API Reference for ListCodeInterpreters Operation</seealso>
        Task<ListCodeInterpretersResponse> ListCodeInterpretersAsync(ListCodeInterpretersRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListGateways


        /// <summary>
        /// Lists all gateways in the account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGateways service method.</param>
        /// 
        /// <returns>The response from the ListGateways service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/ListGateways">REST API Reference for ListGateways Operation</seealso>
        ListGatewaysResponse ListGateways(ListGatewaysRequest request);



        /// <summary>
        /// Lists all gateways in the account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGateways service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListGateways service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/ListGateways">REST API Reference for ListGateways Operation</seealso>
        Task<ListGatewaysResponse> ListGatewaysAsync(ListGatewaysRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListGatewayTargets


        /// <summary>
        /// Lists all targets for a specific gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGatewayTargets service method.</param>
        /// 
        /// <returns>The response from the ListGatewayTargets service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/ListGatewayTargets">REST API Reference for ListGatewayTargets Operation</seealso>
        ListGatewayTargetsResponse ListGatewayTargets(ListGatewayTargetsRequest request);



        /// <summary>
        /// Lists all targets for a specific gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGatewayTargets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListGatewayTargets service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/ListGatewayTargets">REST API Reference for ListGatewayTargets Operation</seealso>
        Task<ListGatewayTargetsResponse> ListGatewayTargetsAsync(ListGatewayTargetsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListMemories


        /// <summary>
        /// Lists the available Amazon Bedrock AgentCore Memory resources in the current Amazon
        /// Web Services Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMemories service method.</param>
        /// 
        /// <returns>The response from the ListMemories service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ServiceException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottledException">
        /// API rate limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/ListMemories">REST API Reference for ListMemories Operation</seealso>
        ListMemoriesResponse ListMemories(ListMemoriesRequest request);



        /// <summary>
        /// Lists the available Amazon Bedrock AgentCore Memory resources in the current Amazon
        /// Web Services Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMemories service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListMemories service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ServiceException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottledException">
        /// API rate limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/ListMemories">REST API Reference for ListMemories Operation</seealso>
        Task<ListMemoriesResponse> ListMemoriesAsync(ListMemoriesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListOauth2CredentialProviders


        /// <summary>
        /// Lists all OAuth2 credential providers in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOauth2CredentialProviders service method.</param>
        /// 
        /// <returns>The response from the ListOauth2CredentialProviders service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.UnauthorizedException">
        /// This exception is thrown when the JWT bearer token is invalid or not found for OAuth
        /// bearer token based access
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/ListOauth2CredentialProviders">REST API Reference for ListOauth2CredentialProviders Operation</seealso>
        ListOauth2CredentialProvidersResponse ListOauth2CredentialProviders(ListOauth2CredentialProvidersRequest request);



        /// <summary>
        /// Lists all OAuth2 credential providers in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOauth2CredentialProviders service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListOauth2CredentialProviders service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.UnauthorizedException">
        /// This exception is thrown when the JWT bearer token is invalid or not found for OAuth
        /// bearer token based access
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/ListOauth2CredentialProviders">REST API Reference for ListOauth2CredentialProviders Operation</seealso>
        Task<ListOauth2CredentialProvidersResponse> ListOauth2CredentialProvidersAsync(ListOauth2CredentialProvidersRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists the tags associated with the specified resource.
        /// 
        ///  <note> 
        /// <para>
        /// This feature is currently available only for AgentCore Runtime, Browser, Code Interpreter
        /// tool, and Gateway.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);



        /// <summary>
        /// Lists the tags associated with the specified resource.
        /// 
        ///  <note> 
        /// <para>
        /// This feature is currently available only for AgentCore Runtime, Browser, Code Interpreter
        /// tool, and Gateway.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListWorkloadIdentities


        /// <summary>
        /// Lists all workload identities in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorkloadIdentities service method.</param>
        /// 
        /// <returns>The response from the ListWorkloadIdentities service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.UnauthorizedException">
        /// This exception is thrown when the JWT bearer token is invalid or not found for OAuth
        /// bearer token based access
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/ListWorkloadIdentities">REST API Reference for ListWorkloadIdentities Operation</seealso>
        ListWorkloadIdentitiesResponse ListWorkloadIdentities(ListWorkloadIdentitiesRequest request);



        /// <summary>
        /// Lists all workload identities in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorkloadIdentities service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListWorkloadIdentities service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.UnauthorizedException">
        /// This exception is thrown when the JWT bearer token is invalid or not found for OAuth
        /// bearer token based access
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/ListWorkloadIdentities">REST API Reference for ListWorkloadIdentities Operation</seealso>
        Task<ListWorkloadIdentitiesResponse> ListWorkloadIdentitiesAsync(ListWorkloadIdentitiesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  SetTokenVaultCMK


        /// <summary>
        /// Sets the customer master key (CMK) for a token vault.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetTokenVaultCMK service method.</param>
        /// 
        /// <returns>The response from the SetTokenVaultCMK service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ConcurrentModificationException">
        /// Exception thrown when a resource is modified concurrently by multiple requests.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.UnauthorizedException">
        /// This exception is thrown when the JWT bearer token is invalid or not found for OAuth
        /// bearer token based access
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/SetTokenVaultCMK">REST API Reference for SetTokenVaultCMK Operation</seealso>
        SetTokenVaultCMKResponse SetTokenVaultCMK(SetTokenVaultCMKRequest request);



        /// <summary>
        /// Sets the customer master key (CMK) for a token vault.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetTokenVaultCMK service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SetTokenVaultCMK service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ConcurrentModificationException">
        /// Exception thrown when a resource is modified concurrently by multiple requests.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.UnauthorizedException">
        /// This exception is thrown when the JWT bearer token is invalid or not found for OAuth
        /// bearer token based access
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/SetTokenVaultCMK">REST API Reference for SetTokenVaultCMK Operation</seealso>
        Task<SetTokenVaultCMKResponse> SetTokenVaultCMKAsync(SetTokenVaultCMKRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Associates the specified tags to a resource with the specified resourceArn. If existing
        /// tags on a resource are not specified in the request parameters, they are not changed.
        /// When a resource is deleted, the tags associated with that resource are also deleted.
        /// 
        ///  <note> 
        /// <para>
        /// This feature is currently available only for AgentCore Runtime, Browser, Code Interpreter
        /// tool, and Gateway.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ServiceQuotaExceededException">
        /// This exception is thrown when a request is made beyond the service quota
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);



        /// <summary>
        /// Associates the specified tags to a resource with the specified resourceArn. If existing
        /// tags on a resource are not specified in the request parameters, they are not changed.
        /// When a resource is deleted, the tags associated with that resource are also deleted.
        /// 
        ///  <note> 
        /// <para>
        /// This feature is currently available only for AgentCore Runtime, Browser, Code Interpreter
        /// tool, and Gateway.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ServiceQuotaExceededException">
        /// This exception is thrown when a request is made beyond the service quota
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes the specified tags from the specified resource.
        /// 
        ///  <note> 
        /// <para>
        /// This feature is currently available only for AgentCore Runtime, Browser, Code Interpreter
        /// tool, and Gateway.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);



        /// <summary>
        /// Removes the specified tags from the specified resource.
        /// 
        ///  <note> 
        /// <para>
        /// This feature is currently available only for AgentCore Runtime, Browser, Code Interpreter
        /// tool, and Gateway.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateAgentRuntime


        /// <summary>
        /// Updates an existing Amazon Secure Agent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAgentRuntime service method.</param>
        /// 
        /// <returns>The response from the UpdateAgentRuntime service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ConflictException">
        /// This exception is thrown when there is a conflict performing an operation
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ServiceQuotaExceededException">
        /// This exception is thrown when a request is made beyond the service quota
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/UpdateAgentRuntime">REST API Reference for UpdateAgentRuntime Operation</seealso>
        UpdateAgentRuntimeResponse UpdateAgentRuntime(UpdateAgentRuntimeRequest request);



        /// <summary>
        /// Updates an existing Amazon Secure Agent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAgentRuntime service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAgentRuntime service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ConflictException">
        /// This exception is thrown when there is a conflict performing an operation
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ServiceQuotaExceededException">
        /// This exception is thrown when a request is made beyond the service quota
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/UpdateAgentRuntime">REST API Reference for UpdateAgentRuntime Operation</seealso>
        Task<UpdateAgentRuntimeResponse> UpdateAgentRuntimeAsync(UpdateAgentRuntimeRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateAgentRuntimeEndpoint


        /// <summary>
        /// Updates an existing Amazon Bedrock AgentCore Runtime endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAgentRuntimeEndpoint service method.</param>
        /// 
        /// <returns>The response from the UpdateAgentRuntimeEndpoint service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ConflictException">
        /// This exception is thrown when there is a conflict performing an operation
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ServiceQuotaExceededException">
        /// This exception is thrown when a request is made beyond the service quota
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/UpdateAgentRuntimeEndpoint">REST API Reference for UpdateAgentRuntimeEndpoint Operation</seealso>
        UpdateAgentRuntimeEndpointResponse UpdateAgentRuntimeEndpoint(UpdateAgentRuntimeEndpointRequest request);



        /// <summary>
        /// Updates an existing Amazon Bedrock AgentCore Runtime endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAgentRuntimeEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAgentRuntimeEndpoint service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ConflictException">
        /// This exception is thrown when there is a conflict performing an operation
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ServiceQuotaExceededException">
        /// This exception is thrown when a request is made beyond the service quota
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/UpdateAgentRuntimeEndpoint">REST API Reference for UpdateAgentRuntimeEndpoint Operation</seealso>
        Task<UpdateAgentRuntimeEndpointResponse> UpdateAgentRuntimeEndpointAsync(UpdateAgentRuntimeEndpointRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateApiKeyCredentialProvider


        /// <summary>
        /// Updates an existing API key credential provider.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApiKeyCredentialProvider service method.</param>
        /// 
        /// <returns>The response from the UpdateApiKeyCredentialProvider service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ConflictException">
        /// This exception is thrown when there is a conflict performing an operation
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.DecryptionFailureException">
        /// Exception thrown when decryption of a secret fails.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.EncryptionFailureException">
        /// Exception thrown when encryption of a secret fails.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ServiceQuotaExceededException">
        /// This exception is thrown when a request is made beyond the service quota
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.UnauthorizedException">
        /// This exception is thrown when the JWT bearer token is invalid or not found for OAuth
        /// bearer token based access
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/UpdateApiKeyCredentialProvider">REST API Reference for UpdateApiKeyCredentialProvider Operation</seealso>
        UpdateApiKeyCredentialProviderResponse UpdateApiKeyCredentialProvider(UpdateApiKeyCredentialProviderRequest request);



        /// <summary>
        /// Updates an existing API key credential provider.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApiKeyCredentialProvider service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateApiKeyCredentialProvider service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ConflictException">
        /// This exception is thrown when there is a conflict performing an operation
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.DecryptionFailureException">
        /// Exception thrown when decryption of a secret fails.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.EncryptionFailureException">
        /// Exception thrown when encryption of a secret fails.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ServiceQuotaExceededException">
        /// This exception is thrown when a request is made beyond the service quota
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.UnauthorizedException">
        /// This exception is thrown when the JWT bearer token is invalid or not found for OAuth
        /// bearer token based access
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/UpdateApiKeyCredentialProvider">REST API Reference for UpdateApiKeyCredentialProvider Operation</seealso>
        Task<UpdateApiKeyCredentialProviderResponse> UpdateApiKeyCredentialProviderAsync(UpdateApiKeyCredentialProviderRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateGateway


        /// <summary>
        /// Updates an existing gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGateway service method.</param>
        /// 
        /// <returns>The response from the UpdateGateway service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ConflictException">
        /// This exception is thrown when there is a conflict performing an operation
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ServiceQuotaExceededException">
        /// This exception is thrown when a request is made beyond the service quota
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/UpdateGateway">REST API Reference for UpdateGateway Operation</seealso>
        UpdateGatewayResponse UpdateGateway(UpdateGatewayRequest request);



        /// <summary>
        /// Updates an existing gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGateway service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateGateway service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ConflictException">
        /// This exception is thrown when there is a conflict performing an operation
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ServiceQuotaExceededException">
        /// This exception is thrown when a request is made beyond the service quota
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/UpdateGateway">REST API Reference for UpdateGateway Operation</seealso>
        Task<UpdateGatewayResponse> UpdateGatewayAsync(UpdateGatewayRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateGatewayTarget


        /// <summary>
        /// Updates an existing gateway target.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGatewayTarget service method.</param>
        /// 
        /// <returns>The response from the UpdateGatewayTarget service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ConflictException">
        /// This exception is thrown when there is a conflict performing an operation
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ServiceQuotaExceededException">
        /// This exception is thrown when a request is made beyond the service quota
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/UpdateGatewayTarget">REST API Reference for UpdateGatewayTarget Operation</seealso>
        UpdateGatewayTargetResponse UpdateGatewayTarget(UpdateGatewayTargetRequest request);



        /// <summary>
        /// Updates an existing gateway target.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGatewayTarget service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateGatewayTarget service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ConflictException">
        /// This exception is thrown when there is a conflict performing an operation
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ServiceQuotaExceededException">
        /// This exception is thrown when a request is made beyond the service quota
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/UpdateGatewayTarget">REST API Reference for UpdateGatewayTarget Operation</seealso>
        Task<UpdateGatewayTargetResponse> UpdateGatewayTargetAsync(UpdateGatewayTargetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateMemory


        /// <summary>
        /// Update an Amazon Bedrock AgentCore Memory resource memory.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMemory service method.</param>
        /// 
        /// <returns>The response from the UpdateMemory service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ConflictException">
        /// This exception is thrown when there is a conflict performing an operation
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ServiceException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ServiceQuotaExceededException">
        /// This exception is thrown when a request is made beyond the service quota
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottledException">
        /// API rate limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/UpdateMemory">REST API Reference for UpdateMemory Operation</seealso>
        UpdateMemoryResponse UpdateMemory(UpdateMemoryRequest request);



        /// <summary>
        /// Update an Amazon Bedrock AgentCore Memory resource memory.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMemory service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateMemory service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ConflictException">
        /// This exception is thrown when there is a conflict performing an operation
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ServiceException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ServiceQuotaExceededException">
        /// This exception is thrown when a request is made beyond the service quota
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottledException">
        /// API rate limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/UpdateMemory">REST API Reference for UpdateMemory Operation</seealso>
        Task<UpdateMemoryResponse> UpdateMemoryAsync(UpdateMemoryRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateOauth2CredentialProvider


        /// <summary>
        /// Updates an existing OAuth2 credential provider.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateOauth2CredentialProvider service method.</param>
        /// 
        /// <returns>The response from the UpdateOauth2CredentialProvider service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ConflictException">
        /// This exception is thrown when there is a conflict performing an operation
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.DecryptionFailureException">
        /// Exception thrown when decryption of a secret fails.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.EncryptionFailureException">
        /// Exception thrown when encryption of a secret fails.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ServiceQuotaExceededException">
        /// This exception is thrown when a request is made beyond the service quota
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.UnauthorizedException">
        /// This exception is thrown when the JWT bearer token is invalid or not found for OAuth
        /// bearer token based access
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/UpdateOauth2CredentialProvider">REST API Reference for UpdateOauth2CredentialProvider Operation</seealso>
        UpdateOauth2CredentialProviderResponse UpdateOauth2CredentialProvider(UpdateOauth2CredentialProviderRequest request);



        /// <summary>
        /// Updates an existing OAuth2 credential provider.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateOauth2CredentialProvider service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateOauth2CredentialProvider service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ConflictException">
        /// This exception is thrown when there is a conflict performing an operation
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.DecryptionFailureException">
        /// Exception thrown when decryption of a secret fails.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.EncryptionFailureException">
        /// Exception thrown when encryption of a secret fails.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ServiceQuotaExceededException">
        /// This exception is thrown when a request is made beyond the service quota
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.UnauthorizedException">
        /// This exception is thrown when the JWT bearer token is invalid or not found for OAuth
        /// bearer token based access
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/UpdateOauth2CredentialProvider">REST API Reference for UpdateOauth2CredentialProvider Operation</seealso>
        Task<UpdateOauth2CredentialProviderResponse> UpdateOauth2CredentialProviderAsync(UpdateOauth2CredentialProviderRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateWorkloadIdentity


        /// <summary>
        /// Updates an existing workload identity.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorkloadIdentity service method.</param>
        /// 
        /// <returns>The response from the UpdateWorkloadIdentity service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.UnauthorizedException">
        /// This exception is thrown when the JWT bearer token is invalid or not found for OAuth
        /// bearer token based access
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/UpdateWorkloadIdentity">REST API Reference for UpdateWorkloadIdentity Operation</seealso>
        UpdateWorkloadIdentityResponse UpdateWorkloadIdentity(UpdateWorkloadIdentityRequest request);



        /// <summary>
        /// Updates an existing workload identity.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorkloadIdentity service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateWorkloadIdentity service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.UnauthorizedException">
        /// This exception is thrown when the JWT bearer token is invalid or not found for OAuth
        /// bearer token based access
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/UpdateWorkloadIdentity">REST API Reference for UpdateWorkloadIdentity Operation</seealso>
        Task<UpdateWorkloadIdentityResponse> UpdateWorkloadIdentityAsync(UpdateWorkloadIdentityRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request);
        
        #endregion

    }
}