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
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.BedrockAgentCoreControl.Model;

#pragma warning disable CS1570
namespace Amazon.BedrockAgentCoreControl
{
    /// <summary>
    /// <para>Interface for accessing BedrockAgentCoreControl</para>
    ///
    /// Welcome to the Amazon Bedrock AgentCore Control plane API reference. Control plane
    /// actions configure, create, modify, and monitor Amazon Web Services resources.
    /// </summary>
    public partial interface IAmazonBedrockAgentCoreControl : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IBedrockAgentCoreControlPaginatorFactory Paginators { get; }
#endif


        
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
        /// Initiates the asynchronous execution of the CreateAgentRuntime operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAgentRuntime operation on AmazonBedrockAgentCoreControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAgentRuntime
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/CreateAgentRuntime">REST API Reference for CreateAgentRuntime Operation</seealso>
        IAsyncResult BeginCreateAgentRuntime(CreateAgentRuntimeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAgentRuntime operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAgentRuntime.</param>
        /// 
        /// <returns>Returns a  CreateAgentRuntimeResult from BedrockAgentCoreControl.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/CreateAgentRuntime">REST API Reference for CreateAgentRuntime Operation</seealso>
        CreateAgentRuntimeResponse EndCreateAgentRuntime(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the CreateAgentRuntimeEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAgentRuntimeEndpoint operation on AmazonBedrockAgentCoreControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAgentRuntimeEndpoint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/CreateAgentRuntimeEndpoint">REST API Reference for CreateAgentRuntimeEndpoint Operation</seealso>
        IAsyncResult BeginCreateAgentRuntimeEndpoint(CreateAgentRuntimeEndpointRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAgentRuntimeEndpoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAgentRuntimeEndpoint.</param>
        /// 
        /// <returns>Returns a  CreateAgentRuntimeEndpointResult from BedrockAgentCoreControl.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/CreateAgentRuntimeEndpoint">REST API Reference for CreateAgentRuntimeEndpoint Operation</seealso>
        CreateAgentRuntimeEndpointResponse EndCreateAgentRuntimeEndpoint(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the CreateApiKeyCredentialProvider operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateApiKeyCredentialProvider operation on AmazonBedrockAgentCoreControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateApiKeyCredentialProvider
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/CreateApiKeyCredentialProvider">REST API Reference for CreateApiKeyCredentialProvider Operation</seealso>
        IAsyncResult BeginCreateApiKeyCredentialProvider(CreateApiKeyCredentialProviderRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateApiKeyCredentialProvider operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateApiKeyCredentialProvider.</param>
        /// 
        /// <returns>Returns a  CreateApiKeyCredentialProviderResult from BedrockAgentCoreControl.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/CreateApiKeyCredentialProvider">REST API Reference for CreateApiKeyCredentialProvider Operation</seealso>
        CreateApiKeyCredentialProviderResponse EndCreateApiKeyCredentialProvider(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the CreateBrowser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateBrowser operation on AmazonBedrockAgentCoreControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateBrowser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/CreateBrowser">REST API Reference for CreateBrowser Operation</seealso>
        IAsyncResult BeginCreateBrowser(CreateBrowserRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateBrowser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateBrowser.</param>
        /// 
        /// <returns>Returns a  CreateBrowserResult from BedrockAgentCoreControl.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/CreateBrowser">REST API Reference for CreateBrowser Operation</seealso>
        CreateBrowserResponse EndCreateBrowser(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the CreateCodeInterpreter operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCodeInterpreter operation on AmazonBedrockAgentCoreControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateCodeInterpreter
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/CreateCodeInterpreter">REST API Reference for CreateCodeInterpreter Operation</seealso>
        IAsyncResult BeginCreateCodeInterpreter(CreateCodeInterpreterRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateCodeInterpreter operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCodeInterpreter.</param>
        /// 
        /// <returns>Returns a  CreateCodeInterpreterResult from BedrockAgentCoreControl.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/CreateCodeInterpreter">REST API Reference for CreateCodeInterpreter Operation</seealso>
        CreateCodeInterpreterResponse EndCreateCodeInterpreter(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateEvaluator


        /// <summary>
        /// Creates a custom evaluator for agent quality assessment. Custom evaluators use LLM-as-a-Judge
        /// configurations with user-defined prompts, rating scales, and model settings to evaluate
        /// agent performance at tool call, trace, or session levels.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEvaluator service method.</param>
        /// 
        /// <returns>The response from the CreateEvaluator service method, as returned by BedrockAgentCoreControl.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/CreateEvaluator">REST API Reference for CreateEvaluator Operation</seealso>
        CreateEvaluatorResponse CreateEvaluator(CreateEvaluatorRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateEvaluator operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateEvaluator operation on AmazonBedrockAgentCoreControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateEvaluator
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/CreateEvaluator">REST API Reference for CreateEvaluator Operation</seealso>
        IAsyncResult BeginCreateEvaluator(CreateEvaluatorRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateEvaluator operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateEvaluator.</param>
        /// 
        /// <returns>Returns a  CreateEvaluatorResult from BedrockAgentCoreControl.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/CreateEvaluator">REST API Reference for CreateEvaluator Operation</seealso>
        CreateEvaluatorResponse EndCreateEvaluator(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateGateway


        /// <summary>
        /// Creates a gateway for Amazon Bedrock Agent. A gateway serves as an integration point
        /// between your agent and external services.
        /// 
        ///  
        /// <para>
        /// If you specify <c>CUSTOM_JWT</c> as the <c>authorizerType</c>, you must provide an
        /// <c>authorizerConfiguration</c>.
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
        /// Initiates the asynchronous execution of the CreateGateway operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateGateway operation on AmazonBedrockAgentCoreControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateGateway
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/CreateGateway">REST API Reference for CreateGateway Operation</seealso>
        IAsyncResult BeginCreateGateway(CreateGatewayRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateGateway operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateGateway.</param>
        /// 
        /// <returns>Returns a  CreateGatewayResult from BedrockAgentCoreControl.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/CreateGateway">REST API Reference for CreateGateway Operation</seealso>
        CreateGatewayResponse EndCreateGateway(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the CreateGatewayTarget operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateGatewayTarget operation on AmazonBedrockAgentCoreControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateGatewayTarget
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/CreateGatewayTarget">REST API Reference for CreateGatewayTarget Operation</seealso>
        IAsyncResult BeginCreateGatewayTarget(CreateGatewayTargetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateGatewayTarget operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateGatewayTarget.</param>
        /// 
        /// <returns>Returns a  CreateGatewayTargetResult from BedrockAgentCoreControl.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/CreateGatewayTarget">REST API Reference for CreateGatewayTarget Operation</seealso>
        CreateGatewayTargetResponse EndCreateGatewayTarget(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the CreateMemory operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateMemory operation on AmazonBedrockAgentCoreControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateMemory
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/CreateMemory">REST API Reference for CreateMemory Operation</seealso>
        IAsyncResult BeginCreateMemory(CreateMemoryRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateMemory operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateMemory.</param>
        /// 
        /// <returns>Returns a  CreateMemoryResult from BedrockAgentCoreControl.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/CreateMemory">REST API Reference for CreateMemory Operation</seealso>
        CreateMemoryResponse EndCreateMemory(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the CreateOauth2CredentialProvider operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateOauth2CredentialProvider operation on AmazonBedrockAgentCoreControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateOauth2CredentialProvider
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/CreateOauth2CredentialProvider">REST API Reference for CreateOauth2CredentialProvider Operation</seealso>
        IAsyncResult BeginCreateOauth2CredentialProvider(CreateOauth2CredentialProviderRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateOauth2CredentialProvider operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateOauth2CredentialProvider.</param>
        /// 
        /// <returns>Returns a  CreateOauth2CredentialProviderResult from BedrockAgentCoreControl.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/CreateOauth2CredentialProvider">REST API Reference for CreateOauth2CredentialProvider Operation</seealso>
        CreateOauth2CredentialProviderResponse EndCreateOauth2CredentialProvider(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateOnlineEvaluationConfig


        /// <summary>
        /// Creates an online evaluation configuration for continuous monitoring of agent performance.
        /// Online evaluation automatically samples live traffic from CloudWatch logs at specified
        /// rates and applies evaluators to assess agent quality in production.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateOnlineEvaluationConfig service method.</param>
        /// 
        /// <returns>The response from the CreateOnlineEvaluationConfig service method, as returned by BedrockAgentCoreControl.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/CreateOnlineEvaluationConfig">REST API Reference for CreateOnlineEvaluationConfig Operation</seealso>
        CreateOnlineEvaluationConfigResponse CreateOnlineEvaluationConfig(CreateOnlineEvaluationConfigRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateOnlineEvaluationConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateOnlineEvaluationConfig operation on AmazonBedrockAgentCoreControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateOnlineEvaluationConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/CreateOnlineEvaluationConfig">REST API Reference for CreateOnlineEvaluationConfig Operation</seealso>
        IAsyncResult BeginCreateOnlineEvaluationConfig(CreateOnlineEvaluationConfigRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateOnlineEvaluationConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateOnlineEvaluationConfig.</param>
        /// 
        /// <returns>Returns a  CreateOnlineEvaluationConfigResult from BedrockAgentCoreControl.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/CreateOnlineEvaluationConfig">REST API Reference for CreateOnlineEvaluationConfig Operation</seealso>
        CreateOnlineEvaluationConfigResponse EndCreateOnlineEvaluationConfig(IAsyncResult asyncResult);

        #endregion
        
        #region  CreatePolicy


        /// <summary>
        /// Creates a policy within the AgentCore Policy system. Policies provide real-time, deterministic
        /// control over agentic interactions with AgentCore Gateway. Using the Cedar policy language,
        /// you can define fine-grained policies that specify which interactions with Gateway
        /// tools are permitted based on input parameters and OAuth claims, ensuring agents operate
        /// within defined boundaries and business rules. The policy is validated during creation
        /// against the Cedar schema generated from the Gateway's tools' input schemas, which
        /// defines the available tools, their parameters, and expected data types. This is an
        /// asynchronous operation. Use the <a href="https://docs.aws.amazon.com/bedrock-agentcore/latest/devguide/API_GetPolicy.html">GetPolicy</a>
        /// operation to poll the <c>status</c> field to track completion.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePolicy service method.</param>
        /// 
        /// <returns>The response from the CreatePolicy service method, as returned by BedrockAgentCoreControl.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/CreatePolicy">REST API Reference for CreatePolicy Operation</seealso>
        CreatePolicyResponse CreatePolicy(CreatePolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePolicy operation on AmazonBedrockAgentCoreControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreatePolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/CreatePolicy">REST API Reference for CreatePolicy Operation</seealso>
        IAsyncResult BeginCreatePolicy(CreatePolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreatePolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreatePolicy.</param>
        /// 
        /// <returns>Returns a  CreatePolicyResult from BedrockAgentCoreControl.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/CreatePolicy">REST API Reference for CreatePolicy Operation</seealso>
        CreatePolicyResponse EndCreatePolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  CreatePolicyEngine


        /// <summary>
        /// Creates a new policy engine within the AgentCore Policy system. A policy engine is
        /// a collection of policies that evaluates and authorizes agent tool calls. When associated
        /// with Gateways (each Gateway can be associated with at most one policy engine, but
        /// multiple Gateways can be associated with the same engine), the policy engine intercepts
        /// all agent requests and determines whether to allow or deny each action based on the
        /// defined policies. This is an asynchronous operation. Use the <a href="https://docs.aws.amazon.com/bedrock-agentcore/latest/devguide/API_GetPolicyEngine.html">GetPolicyEngine</a>
        /// operation to poll the <c>status</c> field to track completion.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePolicyEngine service method.</param>
        /// 
        /// <returns>The response from the CreatePolicyEngine service method, as returned by BedrockAgentCoreControl.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/CreatePolicyEngine">REST API Reference for CreatePolicyEngine Operation</seealso>
        CreatePolicyEngineResponse CreatePolicyEngine(CreatePolicyEngineRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePolicyEngine operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePolicyEngine operation on AmazonBedrockAgentCoreControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreatePolicyEngine
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/CreatePolicyEngine">REST API Reference for CreatePolicyEngine Operation</seealso>
        IAsyncResult BeginCreatePolicyEngine(CreatePolicyEngineRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreatePolicyEngine operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreatePolicyEngine.</param>
        /// 
        /// <returns>Returns a  CreatePolicyEngineResult from BedrockAgentCoreControl.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/CreatePolicyEngine">REST API Reference for CreatePolicyEngine Operation</seealso>
        CreatePolicyEngineResponse EndCreatePolicyEngine(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the CreateWorkloadIdentity operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkloadIdentity operation on AmazonBedrockAgentCoreControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateWorkloadIdentity
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/CreateWorkloadIdentity">REST API Reference for CreateWorkloadIdentity Operation</seealso>
        IAsyncResult BeginCreateWorkloadIdentity(CreateWorkloadIdentityRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateWorkloadIdentity operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateWorkloadIdentity.</param>
        /// 
        /// <returns>Returns a  CreateWorkloadIdentityResult from BedrockAgentCoreControl.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/CreateWorkloadIdentity">REST API Reference for CreateWorkloadIdentity Operation</seealso>
        CreateWorkloadIdentityResponse EndCreateWorkloadIdentity(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the DeleteAgentRuntime operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAgentRuntime operation on AmazonBedrockAgentCoreControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAgentRuntime
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/DeleteAgentRuntime">REST API Reference for DeleteAgentRuntime Operation</seealso>
        IAsyncResult BeginDeleteAgentRuntime(DeleteAgentRuntimeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAgentRuntime operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAgentRuntime.</param>
        /// 
        /// <returns>Returns a  DeleteAgentRuntimeResult from BedrockAgentCoreControl.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/DeleteAgentRuntime">REST API Reference for DeleteAgentRuntime Operation</seealso>
        DeleteAgentRuntimeResponse EndDeleteAgentRuntime(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the DeleteAgentRuntimeEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAgentRuntimeEndpoint operation on AmazonBedrockAgentCoreControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAgentRuntimeEndpoint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/DeleteAgentRuntimeEndpoint">REST API Reference for DeleteAgentRuntimeEndpoint Operation</seealso>
        IAsyncResult BeginDeleteAgentRuntimeEndpoint(DeleteAgentRuntimeEndpointRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAgentRuntimeEndpoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAgentRuntimeEndpoint.</param>
        /// 
        /// <returns>Returns a  DeleteAgentRuntimeEndpointResult from BedrockAgentCoreControl.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/DeleteAgentRuntimeEndpoint">REST API Reference for DeleteAgentRuntimeEndpoint Operation</seealso>
        DeleteAgentRuntimeEndpointResponse EndDeleteAgentRuntimeEndpoint(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the DeleteApiKeyCredentialProvider operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteApiKeyCredentialProvider operation on AmazonBedrockAgentCoreControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteApiKeyCredentialProvider
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/DeleteApiKeyCredentialProvider">REST API Reference for DeleteApiKeyCredentialProvider Operation</seealso>
        IAsyncResult BeginDeleteApiKeyCredentialProvider(DeleteApiKeyCredentialProviderRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteApiKeyCredentialProvider operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteApiKeyCredentialProvider.</param>
        /// 
        /// <returns>Returns a  DeleteApiKeyCredentialProviderResult from BedrockAgentCoreControl.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/DeleteApiKeyCredentialProvider">REST API Reference for DeleteApiKeyCredentialProvider Operation</seealso>
        DeleteApiKeyCredentialProviderResponse EndDeleteApiKeyCredentialProvider(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the DeleteBrowser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBrowser operation on AmazonBedrockAgentCoreControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteBrowser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/DeleteBrowser">REST API Reference for DeleteBrowser Operation</seealso>
        IAsyncResult BeginDeleteBrowser(DeleteBrowserRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteBrowser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteBrowser.</param>
        /// 
        /// <returns>Returns a  DeleteBrowserResult from BedrockAgentCoreControl.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/DeleteBrowser">REST API Reference for DeleteBrowser Operation</seealso>
        DeleteBrowserResponse EndDeleteBrowser(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the DeleteCodeInterpreter operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCodeInterpreter operation on AmazonBedrockAgentCoreControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteCodeInterpreter
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/DeleteCodeInterpreter">REST API Reference for DeleteCodeInterpreter Operation</seealso>
        IAsyncResult BeginDeleteCodeInterpreter(DeleteCodeInterpreterRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteCodeInterpreter operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCodeInterpreter.</param>
        /// 
        /// <returns>Returns a  DeleteCodeInterpreterResult from BedrockAgentCoreControl.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/DeleteCodeInterpreter">REST API Reference for DeleteCodeInterpreter Operation</seealso>
        DeleteCodeInterpreterResponse EndDeleteCodeInterpreter(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteEvaluator


        /// <summary>
        /// Deletes a custom evaluator. Builtin evaluators cannot be deleted. The evaluator must
        /// not be referenced by any active online evaluation configurations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEvaluator service method.</param>
        /// 
        /// <returns>The response from the DeleteEvaluator service method, as returned by BedrockAgentCoreControl.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/DeleteEvaluator">REST API Reference for DeleteEvaluator Operation</seealso>
        DeleteEvaluatorResponse DeleteEvaluator(DeleteEvaluatorRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEvaluator operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEvaluator operation on AmazonBedrockAgentCoreControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteEvaluator
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/DeleteEvaluator">REST API Reference for DeleteEvaluator Operation</seealso>
        IAsyncResult BeginDeleteEvaluator(DeleteEvaluatorRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteEvaluator operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteEvaluator.</param>
        /// 
        /// <returns>Returns a  DeleteEvaluatorResult from BedrockAgentCoreControl.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/DeleteEvaluator">REST API Reference for DeleteEvaluator Operation</seealso>
        DeleteEvaluatorResponse EndDeleteEvaluator(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the DeleteGateway operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteGateway operation on AmazonBedrockAgentCoreControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteGateway
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/DeleteGateway">REST API Reference for DeleteGateway Operation</seealso>
        IAsyncResult BeginDeleteGateway(DeleteGatewayRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteGateway operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteGateway.</param>
        /// 
        /// <returns>Returns a  DeleteGatewayResult from BedrockAgentCoreControl.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/DeleteGateway">REST API Reference for DeleteGateway Operation</seealso>
        DeleteGatewayResponse EndDeleteGateway(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the DeleteGatewayTarget operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteGatewayTarget operation on AmazonBedrockAgentCoreControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteGatewayTarget
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/DeleteGatewayTarget">REST API Reference for DeleteGatewayTarget Operation</seealso>
        IAsyncResult BeginDeleteGatewayTarget(DeleteGatewayTargetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteGatewayTarget operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteGatewayTarget.</param>
        /// 
        /// <returns>Returns a  DeleteGatewayTargetResult from BedrockAgentCoreControl.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/DeleteGatewayTarget">REST API Reference for DeleteGatewayTarget Operation</seealso>
        DeleteGatewayTargetResponse EndDeleteGatewayTarget(IAsyncResult asyncResult);

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
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ConflictException">
        /// This exception is thrown when there is a conflict performing an operation
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
        /// Initiates the asynchronous execution of the DeleteMemory operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteMemory operation on AmazonBedrockAgentCoreControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteMemory
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/DeleteMemory">REST API Reference for DeleteMemory Operation</seealso>
        IAsyncResult BeginDeleteMemory(DeleteMemoryRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteMemory operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteMemory.</param>
        /// 
        /// <returns>Returns a  DeleteMemoryResult from BedrockAgentCoreControl.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/DeleteMemory">REST API Reference for DeleteMemory Operation</seealso>
        DeleteMemoryResponse EndDeleteMemory(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the DeleteOauth2CredentialProvider operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteOauth2CredentialProvider operation on AmazonBedrockAgentCoreControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteOauth2CredentialProvider
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/DeleteOauth2CredentialProvider">REST API Reference for DeleteOauth2CredentialProvider Operation</seealso>
        IAsyncResult BeginDeleteOauth2CredentialProvider(DeleteOauth2CredentialProviderRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteOauth2CredentialProvider operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteOauth2CredentialProvider.</param>
        /// 
        /// <returns>Returns a  DeleteOauth2CredentialProviderResult from BedrockAgentCoreControl.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/DeleteOauth2CredentialProvider">REST API Reference for DeleteOauth2CredentialProvider Operation</seealso>
        DeleteOauth2CredentialProviderResponse EndDeleteOauth2CredentialProvider(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteOnlineEvaluationConfig


        /// <summary>
        /// Deletes an online evaluation configuration and stops any ongoing evaluation processes
        /// associated with it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteOnlineEvaluationConfig service method.</param>
        /// 
        /// <returns>The response from the DeleteOnlineEvaluationConfig service method, as returned by BedrockAgentCoreControl.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/DeleteOnlineEvaluationConfig">REST API Reference for DeleteOnlineEvaluationConfig Operation</seealso>
        DeleteOnlineEvaluationConfigResponse DeleteOnlineEvaluationConfig(DeleteOnlineEvaluationConfigRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteOnlineEvaluationConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteOnlineEvaluationConfig operation on AmazonBedrockAgentCoreControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteOnlineEvaluationConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/DeleteOnlineEvaluationConfig">REST API Reference for DeleteOnlineEvaluationConfig Operation</seealso>
        IAsyncResult BeginDeleteOnlineEvaluationConfig(DeleteOnlineEvaluationConfigRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteOnlineEvaluationConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteOnlineEvaluationConfig.</param>
        /// 
        /// <returns>Returns a  DeleteOnlineEvaluationConfigResult from BedrockAgentCoreControl.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/DeleteOnlineEvaluationConfig">REST API Reference for DeleteOnlineEvaluationConfig Operation</seealso>
        DeleteOnlineEvaluationConfigResponse EndDeleteOnlineEvaluationConfig(IAsyncResult asyncResult);

        #endregion
        
        #region  DeletePolicy


        /// <summary>
        /// Deletes an existing policy from the AgentCore Policy system. Once deleted, the policy
        /// can no longer be used for agent behavior control and all references to it become invalid.
        /// This is an asynchronous operation. Use the <c>GetPolicy</c> operation to poll the
        /// <c>status</c> field to track completion.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePolicy service method.</param>
        /// 
        /// <returns>The response from the DeletePolicy service method, as returned by BedrockAgentCoreControl.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/DeletePolicy">REST API Reference for DeletePolicy Operation</seealso>
        DeletePolicyResponse DeletePolicy(DeletePolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeletePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePolicy operation on AmazonBedrockAgentCoreControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeletePolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/DeletePolicy">REST API Reference for DeletePolicy Operation</seealso>
        IAsyncResult BeginDeletePolicy(DeletePolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeletePolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeletePolicy.</param>
        /// 
        /// <returns>Returns a  DeletePolicyResult from BedrockAgentCoreControl.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/DeletePolicy">REST API Reference for DeletePolicy Operation</seealso>
        DeletePolicyResponse EndDeletePolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  DeletePolicyEngine


        /// <summary>
        /// Deletes an existing policy engine from the AgentCore Policy system. The policy engine
        /// must not have any associated policies before deletion. Once deleted, the policy engine
        /// and all its configurations become unavailable for policy management and evaluation.
        /// This is an asynchronous operation. Use the <c>GetPolicyEngine</c> operation to poll
        /// the <c>status</c> field to track completion.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePolicyEngine service method.</param>
        /// 
        /// <returns>The response from the DeletePolicyEngine service method, as returned by BedrockAgentCoreControl.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/DeletePolicyEngine">REST API Reference for DeletePolicyEngine Operation</seealso>
        DeletePolicyEngineResponse DeletePolicyEngine(DeletePolicyEngineRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeletePolicyEngine operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePolicyEngine operation on AmazonBedrockAgentCoreControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeletePolicyEngine
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/DeletePolicyEngine">REST API Reference for DeletePolicyEngine Operation</seealso>
        IAsyncResult BeginDeletePolicyEngine(DeletePolicyEngineRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeletePolicyEngine operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeletePolicyEngine.</param>
        /// 
        /// <returns>Returns a  DeletePolicyEngineResult from BedrockAgentCoreControl.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/DeletePolicyEngine">REST API Reference for DeletePolicyEngine Operation</seealso>
        DeletePolicyEngineResponse EndDeletePolicyEngine(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteResourcePolicy


        /// <summary>
        /// Deletes the resource-based policy for a specified resource.
        /// 
        ///  <note> 
        /// <para>
        /// This feature is currently available only for AgentCore Runtime and Gateway.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourcePolicy service method.</param>
        /// 
        /// <returns>The response from the DeleteResourcePolicy service method, as returned by BedrockAgentCoreControl.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/DeleteResourcePolicy">REST API Reference for DeleteResourcePolicy Operation</seealso>
        DeleteResourcePolicyResponse DeleteResourcePolicy(DeleteResourcePolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourcePolicy operation on AmazonBedrockAgentCoreControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteResourcePolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/DeleteResourcePolicy">REST API Reference for DeleteResourcePolicy Operation</seealso>
        IAsyncResult BeginDeleteResourcePolicy(DeleteResourcePolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteResourcePolicy.</param>
        /// 
        /// <returns>Returns a  DeleteResourcePolicyResult from BedrockAgentCoreControl.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/DeleteResourcePolicy">REST API Reference for DeleteResourcePolicy Operation</seealso>
        DeleteResourcePolicyResponse EndDeleteResourcePolicy(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the DeleteWorkloadIdentity operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkloadIdentity operation on AmazonBedrockAgentCoreControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteWorkloadIdentity
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/DeleteWorkloadIdentity">REST API Reference for DeleteWorkloadIdentity Operation</seealso>
        IAsyncResult BeginDeleteWorkloadIdentity(DeleteWorkloadIdentityRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteWorkloadIdentity operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteWorkloadIdentity.</param>
        /// 
        /// <returns>Returns a  DeleteWorkloadIdentityResult from BedrockAgentCoreControl.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/DeleteWorkloadIdentity">REST API Reference for DeleteWorkloadIdentity Operation</seealso>
        DeleteWorkloadIdentityResponse EndDeleteWorkloadIdentity(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the GetAgentRuntime operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAgentRuntime operation on AmazonBedrockAgentCoreControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAgentRuntime
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/GetAgentRuntime">REST API Reference for GetAgentRuntime Operation</seealso>
        IAsyncResult BeginGetAgentRuntime(GetAgentRuntimeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetAgentRuntime operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAgentRuntime.</param>
        /// 
        /// <returns>Returns a  GetAgentRuntimeResult from BedrockAgentCoreControl.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/GetAgentRuntime">REST API Reference for GetAgentRuntime Operation</seealso>
        GetAgentRuntimeResponse EndGetAgentRuntime(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the GetAgentRuntimeEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAgentRuntimeEndpoint operation on AmazonBedrockAgentCoreControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAgentRuntimeEndpoint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/GetAgentRuntimeEndpoint">REST API Reference for GetAgentRuntimeEndpoint Operation</seealso>
        IAsyncResult BeginGetAgentRuntimeEndpoint(GetAgentRuntimeEndpointRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetAgentRuntimeEndpoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAgentRuntimeEndpoint.</param>
        /// 
        /// <returns>Returns a  GetAgentRuntimeEndpointResult from BedrockAgentCoreControl.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/GetAgentRuntimeEndpoint">REST API Reference for GetAgentRuntimeEndpoint Operation</seealso>
        GetAgentRuntimeEndpointResponse EndGetAgentRuntimeEndpoint(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the GetApiKeyCredentialProvider operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetApiKeyCredentialProvider operation on AmazonBedrockAgentCoreControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetApiKeyCredentialProvider
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/GetApiKeyCredentialProvider">REST API Reference for GetApiKeyCredentialProvider Operation</seealso>
        IAsyncResult BeginGetApiKeyCredentialProvider(GetApiKeyCredentialProviderRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetApiKeyCredentialProvider operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetApiKeyCredentialProvider.</param>
        /// 
        /// <returns>Returns a  GetApiKeyCredentialProviderResult from BedrockAgentCoreControl.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/GetApiKeyCredentialProvider">REST API Reference for GetApiKeyCredentialProvider Operation</seealso>
        GetApiKeyCredentialProviderResponse EndGetApiKeyCredentialProvider(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the GetBrowser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBrowser operation on AmazonBedrockAgentCoreControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetBrowser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/GetBrowser">REST API Reference for GetBrowser Operation</seealso>
        IAsyncResult BeginGetBrowser(GetBrowserRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetBrowser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBrowser.</param>
        /// 
        /// <returns>Returns a  GetBrowserResult from BedrockAgentCoreControl.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/GetBrowser">REST API Reference for GetBrowser Operation</seealso>
        GetBrowserResponse EndGetBrowser(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the GetCodeInterpreter operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCodeInterpreter operation on AmazonBedrockAgentCoreControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCodeInterpreter
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/GetCodeInterpreter">REST API Reference for GetCodeInterpreter Operation</seealso>
        IAsyncResult BeginGetCodeInterpreter(GetCodeInterpreterRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetCodeInterpreter operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCodeInterpreter.</param>
        /// 
        /// <returns>Returns a  GetCodeInterpreterResult from BedrockAgentCoreControl.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/GetCodeInterpreter">REST API Reference for GetCodeInterpreter Operation</seealso>
        GetCodeInterpreterResponse EndGetCodeInterpreter(IAsyncResult asyncResult);

        #endregion
        
        #region  GetEvaluator


        /// <summary>
        /// Retrieves detailed information about an evaluator, including its configuration, status,
        /// and metadata. Works with both built-in and custom evaluators.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEvaluator service method.</param>
        /// 
        /// <returns>The response from the GetEvaluator service method, as returned by BedrockAgentCoreControl.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/GetEvaluator">REST API Reference for GetEvaluator Operation</seealso>
        GetEvaluatorResponse GetEvaluator(GetEvaluatorRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetEvaluator operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetEvaluator operation on AmazonBedrockAgentCoreControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetEvaluator
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/GetEvaluator">REST API Reference for GetEvaluator Operation</seealso>
        IAsyncResult BeginGetEvaluator(GetEvaluatorRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetEvaluator operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetEvaluator.</param>
        /// 
        /// <returns>Returns a  GetEvaluatorResult from BedrockAgentCoreControl.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/GetEvaluator">REST API Reference for GetEvaluator Operation</seealso>
        GetEvaluatorResponse EndGetEvaluator(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the GetGateway operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetGateway operation on AmazonBedrockAgentCoreControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetGateway
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/GetGateway">REST API Reference for GetGateway Operation</seealso>
        IAsyncResult BeginGetGateway(GetGatewayRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetGateway operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetGateway.</param>
        /// 
        /// <returns>Returns a  GetGatewayResult from BedrockAgentCoreControl.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/GetGateway">REST API Reference for GetGateway Operation</seealso>
        GetGatewayResponse EndGetGateway(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the GetGatewayTarget operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetGatewayTarget operation on AmazonBedrockAgentCoreControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetGatewayTarget
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/GetGatewayTarget">REST API Reference for GetGatewayTarget Operation</seealso>
        IAsyncResult BeginGetGatewayTarget(GetGatewayTargetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetGatewayTarget operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetGatewayTarget.</param>
        /// 
        /// <returns>Returns a  GetGatewayTargetResult from BedrockAgentCoreControl.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/GetGatewayTarget">REST API Reference for GetGatewayTarget Operation</seealso>
        GetGatewayTargetResponse EndGetGatewayTarget(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the GetMemory operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMemory operation on AmazonBedrockAgentCoreControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetMemory
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/GetMemory">REST API Reference for GetMemory Operation</seealso>
        IAsyncResult BeginGetMemory(GetMemoryRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetMemory operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetMemory.</param>
        /// 
        /// <returns>Returns a  GetMemoryResult from BedrockAgentCoreControl.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/GetMemory">REST API Reference for GetMemory Operation</seealso>
        GetMemoryResponse EndGetMemory(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the GetOauth2CredentialProvider operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetOauth2CredentialProvider operation on AmazonBedrockAgentCoreControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetOauth2CredentialProvider
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/GetOauth2CredentialProvider">REST API Reference for GetOauth2CredentialProvider Operation</seealso>
        IAsyncResult BeginGetOauth2CredentialProvider(GetOauth2CredentialProviderRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetOauth2CredentialProvider operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetOauth2CredentialProvider.</param>
        /// 
        /// <returns>Returns a  GetOauth2CredentialProviderResult from BedrockAgentCoreControl.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/GetOauth2CredentialProvider">REST API Reference for GetOauth2CredentialProvider Operation</seealso>
        GetOauth2CredentialProviderResponse EndGetOauth2CredentialProvider(IAsyncResult asyncResult);

        #endregion
        
        #region  GetOnlineEvaluationConfig


        /// <summary>
        /// Retrieves detailed information about an online evaluation configuration, including
        /// its rules, data sources, evaluators, and execution status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOnlineEvaluationConfig service method.</param>
        /// 
        /// <returns>The response from the GetOnlineEvaluationConfig service method, as returned by BedrockAgentCoreControl.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/GetOnlineEvaluationConfig">REST API Reference for GetOnlineEvaluationConfig Operation</seealso>
        GetOnlineEvaluationConfigResponse GetOnlineEvaluationConfig(GetOnlineEvaluationConfigRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetOnlineEvaluationConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetOnlineEvaluationConfig operation on AmazonBedrockAgentCoreControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetOnlineEvaluationConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/GetOnlineEvaluationConfig">REST API Reference for GetOnlineEvaluationConfig Operation</seealso>
        IAsyncResult BeginGetOnlineEvaluationConfig(GetOnlineEvaluationConfigRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetOnlineEvaluationConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetOnlineEvaluationConfig.</param>
        /// 
        /// <returns>Returns a  GetOnlineEvaluationConfigResult from BedrockAgentCoreControl.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/GetOnlineEvaluationConfig">REST API Reference for GetOnlineEvaluationConfig Operation</seealso>
        GetOnlineEvaluationConfigResponse EndGetOnlineEvaluationConfig(IAsyncResult asyncResult);

        #endregion
        
        #region  GetPolicy


        /// <summary>
        /// Retrieves detailed information about a specific policy within the AgentCore Policy
        /// system. This operation returns the complete policy definition, metadata, and current
        /// status, allowing administrators to review and manage policy configurations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPolicy service method.</param>
        /// 
        /// <returns>The response from the GetPolicy service method, as returned by BedrockAgentCoreControl.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/GetPolicy">REST API Reference for GetPolicy Operation</seealso>
        GetPolicyResponse GetPolicy(GetPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPolicy operation on AmazonBedrockAgentCoreControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/GetPolicy">REST API Reference for GetPolicy Operation</seealso>
        IAsyncResult BeginGetPolicy(GetPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPolicy.</param>
        /// 
        /// <returns>Returns a  GetPolicyResult from BedrockAgentCoreControl.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/GetPolicy">REST API Reference for GetPolicy Operation</seealso>
        GetPolicyResponse EndGetPolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  GetPolicyEngine


        /// <summary>
        /// Retrieves detailed information about a specific policy engine within the AgentCore
        /// Policy system. This operation returns the complete policy engine configuration, metadata,
        /// and current status, allowing administrators to review and manage policy engine settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPolicyEngine service method.</param>
        /// 
        /// <returns>The response from the GetPolicyEngine service method, as returned by BedrockAgentCoreControl.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/GetPolicyEngine">REST API Reference for GetPolicyEngine Operation</seealso>
        GetPolicyEngineResponse GetPolicyEngine(GetPolicyEngineRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetPolicyEngine operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPolicyEngine operation on AmazonBedrockAgentCoreControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPolicyEngine
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/GetPolicyEngine">REST API Reference for GetPolicyEngine Operation</seealso>
        IAsyncResult BeginGetPolicyEngine(GetPolicyEngineRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetPolicyEngine operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPolicyEngine.</param>
        /// 
        /// <returns>Returns a  GetPolicyEngineResult from BedrockAgentCoreControl.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/GetPolicyEngine">REST API Reference for GetPolicyEngine Operation</seealso>
        GetPolicyEngineResponse EndGetPolicyEngine(IAsyncResult asyncResult);

        #endregion
        
        #region  GetPolicyGeneration


        /// <summary>
        /// Retrieves information about a policy generation request within the AgentCore Policy
        /// system. Policy generation converts natural language descriptions into Cedar policy
        /// statements using AI-powered translation, enabling non-technical users to create policies.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPolicyGeneration service method.</param>
        /// 
        /// <returns>The response from the GetPolicyGeneration service method, as returned by BedrockAgentCoreControl.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/GetPolicyGeneration">REST API Reference for GetPolicyGeneration Operation</seealso>
        GetPolicyGenerationResponse GetPolicyGeneration(GetPolicyGenerationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetPolicyGeneration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPolicyGeneration operation on AmazonBedrockAgentCoreControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPolicyGeneration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/GetPolicyGeneration">REST API Reference for GetPolicyGeneration Operation</seealso>
        IAsyncResult BeginGetPolicyGeneration(GetPolicyGenerationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetPolicyGeneration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPolicyGeneration.</param>
        /// 
        /// <returns>Returns a  GetPolicyGenerationResult from BedrockAgentCoreControl.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/GetPolicyGeneration">REST API Reference for GetPolicyGeneration Operation</seealso>
        GetPolicyGenerationResponse EndGetPolicyGeneration(IAsyncResult asyncResult);

        #endregion
        
        #region  GetResourcePolicy


        /// <summary>
        /// Retrieves the resource-based policy for a specified resource.
        /// 
        ///  <note> 
        /// <para>
        /// This feature is currently available only for AgentCore Runtime and Gateway.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourcePolicy service method.</param>
        /// 
        /// <returns>The response from the GetResourcePolicy service method, as returned by BedrockAgentCoreControl.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/GetResourcePolicy">REST API Reference for GetResourcePolicy Operation</seealso>
        GetResourcePolicyResponse GetResourcePolicy(GetResourcePolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetResourcePolicy operation on AmazonBedrockAgentCoreControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetResourcePolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/GetResourcePolicy">REST API Reference for GetResourcePolicy Operation</seealso>
        IAsyncResult BeginGetResourcePolicy(GetResourcePolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetResourcePolicy.</param>
        /// 
        /// <returns>Returns a  GetResourcePolicyResult from BedrockAgentCoreControl.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/GetResourcePolicy">REST API Reference for GetResourcePolicy Operation</seealso>
        GetResourcePolicyResponse EndGetResourcePolicy(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the GetTokenVault operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTokenVault operation on AmazonBedrockAgentCoreControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTokenVault
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/GetTokenVault">REST API Reference for GetTokenVault Operation</seealso>
        IAsyncResult BeginGetTokenVault(GetTokenVaultRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetTokenVault operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTokenVault.</param>
        /// 
        /// <returns>Returns a  GetTokenVaultResult from BedrockAgentCoreControl.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/GetTokenVault">REST API Reference for GetTokenVault Operation</seealso>
        GetTokenVaultResponse EndGetTokenVault(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the GetWorkloadIdentity operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetWorkloadIdentity operation on AmazonBedrockAgentCoreControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetWorkloadIdentity
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/GetWorkloadIdentity">REST API Reference for GetWorkloadIdentity Operation</seealso>
        IAsyncResult BeginGetWorkloadIdentity(GetWorkloadIdentityRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetWorkloadIdentity operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetWorkloadIdentity.</param>
        /// 
        /// <returns>Returns a  GetWorkloadIdentityResult from BedrockAgentCoreControl.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/GetWorkloadIdentity">REST API Reference for GetWorkloadIdentity Operation</seealso>
        GetWorkloadIdentityResponse EndGetWorkloadIdentity(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the ListAgentRuntimeEndpoints operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAgentRuntimeEndpoints operation on AmazonBedrockAgentCoreControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAgentRuntimeEndpoints
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/ListAgentRuntimeEndpoints">REST API Reference for ListAgentRuntimeEndpoints Operation</seealso>
        IAsyncResult BeginListAgentRuntimeEndpoints(ListAgentRuntimeEndpointsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAgentRuntimeEndpoints operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAgentRuntimeEndpoints.</param>
        /// 
        /// <returns>Returns a  ListAgentRuntimeEndpointsResult from BedrockAgentCoreControl.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/ListAgentRuntimeEndpoints">REST API Reference for ListAgentRuntimeEndpoints Operation</seealso>
        ListAgentRuntimeEndpointsResponse EndListAgentRuntimeEndpoints(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the ListAgentRuntimes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAgentRuntimes operation on AmazonBedrockAgentCoreControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAgentRuntimes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/ListAgentRuntimes">REST API Reference for ListAgentRuntimes Operation</seealso>
        IAsyncResult BeginListAgentRuntimes(ListAgentRuntimesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAgentRuntimes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAgentRuntimes.</param>
        /// 
        /// <returns>Returns a  ListAgentRuntimesResult from BedrockAgentCoreControl.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/ListAgentRuntimes">REST API Reference for ListAgentRuntimes Operation</seealso>
        ListAgentRuntimesResponse EndListAgentRuntimes(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the ListAgentRuntimeVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAgentRuntimeVersions operation on AmazonBedrockAgentCoreControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAgentRuntimeVersions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/ListAgentRuntimeVersions">REST API Reference for ListAgentRuntimeVersions Operation</seealso>
        IAsyncResult BeginListAgentRuntimeVersions(ListAgentRuntimeVersionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAgentRuntimeVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAgentRuntimeVersions.</param>
        /// 
        /// <returns>Returns a  ListAgentRuntimeVersionsResult from BedrockAgentCoreControl.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/ListAgentRuntimeVersions">REST API Reference for ListAgentRuntimeVersions Operation</seealso>
        ListAgentRuntimeVersionsResponse EndListAgentRuntimeVersions(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the ListApiKeyCredentialProviders operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListApiKeyCredentialProviders operation on AmazonBedrockAgentCoreControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListApiKeyCredentialProviders
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/ListApiKeyCredentialProviders">REST API Reference for ListApiKeyCredentialProviders Operation</seealso>
        IAsyncResult BeginListApiKeyCredentialProviders(ListApiKeyCredentialProvidersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListApiKeyCredentialProviders operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListApiKeyCredentialProviders.</param>
        /// 
        /// <returns>Returns a  ListApiKeyCredentialProvidersResult from BedrockAgentCoreControl.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/ListApiKeyCredentialProviders">REST API Reference for ListApiKeyCredentialProviders Operation</seealso>
        ListApiKeyCredentialProvidersResponse EndListApiKeyCredentialProviders(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the ListBrowsers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListBrowsers operation on AmazonBedrockAgentCoreControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListBrowsers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/ListBrowsers">REST API Reference for ListBrowsers Operation</seealso>
        IAsyncResult BeginListBrowsers(ListBrowsersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListBrowsers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListBrowsers.</param>
        /// 
        /// <returns>Returns a  ListBrowsersResult from BedrockAgentCoreControl.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/ListBrowsers">REST API Reference for ListBrowsers Operation</seealso>
        ListBrowsersResponse EndListBrowsers(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the ListCodeInterpreters operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCodeInterpreters operation on AmazonBedrockAgentCoreControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListCodeInterpreters
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/ListCodeInterpreters">REST API Reference for ListCodeInterpreters Operation</seealso>
        IAsyncResult BeginListCodeInterpreters(ListCodeInterpretersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListCodeInterpreters operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCodeInterpreters.</param>
        /// 
        /// <returns>Returns a  ListCodeInterpretersResult from BedrockAgentCoreControl.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/ListCodeInterpreters">REST API Reference for ListCodeInterpreters Operation</seealso>
        ListCodeInterpretersResponse EndListCodeInterpreters(IAsyncResult asyncResult);

        #endregion
        
        #region  ListEvaluators


        /// <summary>
        /// Lists all available evaluators, including both builtin evaluators provided by the
        /// service and custom evaluators created by the user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEvaluators service method.</param>
        /// 
        /// <returns>The response from the ListEvaluators service method, as returned by BedrockAgentCoreControl.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/ListEvaluators">REST API Reference for ListEvaluators Operation</seealso>
        ListEvaluatorsResponse ListEvaluators(ListEvaluatorsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListEvaluators operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListEvaluators operation on AmazonBedrockAgentCoreControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListEvaluators
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/ListEvaluators">REST API Reference for ListEvaluators Operation</seealso>
        IAsyncResult BeginListEvaluators(ListEvaluatorsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListEvaluators operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListEvaluators.</param>
        /// 
        /// <returns>Returns a  ListEvaluatorsResult from BedrockAgentCoreControl.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/ListEvaluators">REST API Reference for ListEvaluators Operation</seealso>
        ListEvaluatorsResponse EndListEvaluators(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the ListGateways operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListGateways operation on AmazonBedrockAgentCoreControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListGateways
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/ListGateways">REST API Reference for ListGateways Operation</seealso>
        IAsyncResult BeginListGateways(ListGatewaysRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListGateways operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListGateways.</param>
        /// 
        /// <returns>Returns a  ListGatewaysResult from BedrockAgentCoreControl.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/ListGateways">REST API Reference for ListGateways Operation</seealso>
        ListGatewaysResponse EndListGateways(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the ListGatewayTargets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListGatewayTargets operation on AmazonBedrockAgentCoreControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListGatewayTargets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/ListGatewayTargets">REST API Reference for ListGatewayTargets Operation</seealso>
        IAsyncResult BeginListGatewayTargets(ListGatewayTargetsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListGatewayTargets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListGatewayTargets.</param>
        /// 
        /// <returns>Returns a  ListGatewayTargetsResult from BedrockAgentCoreControl.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/ListGatewayTargets">REST API Reference for ListGatewayTargets Operation</seealso>
        ListGatewayTargetsResponse EndListGatewayTargets(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the ListMemories operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMemories operation on AmazonBedrockAgentCoreControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListMemories
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/ListMemories">REST API Reference for ListMemories Operation</seealso>
        IAsyncResult BeginListMemories(ListMemoriesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListMemories operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListMemories.</param>
        /// 
        /// <returns>Returns a  ListMemoriesResult from BedrockAgentCoreControl.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/ListMemories">REST API Reference for ListMemories Operation</seealso>
        ListMemoriesResponse EndListMemories(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the ListOauth2CredentialProviders operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListOauth2CredentialProviders operation on AmazonBedrockAgentCoreControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListOauth2CredentialProviders
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/ListOauth2CredentialProviders">REST API Reference for ListOauth2CredentialProviders Operation</seealso>
        IAsyncResult BeginListOauth2CredentialProviders(ListOauth2CredentialProvidersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListOauth2CredentialProviders operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListOauth2CredentialProviders.</param>
        /// 
        /// <returns>Returns a  ListOauth2CredentialProvidersResult from BedrockAgentCoreControl.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/ListOauth2CredentialProviders">REST API Reference for ListOauth2CredentialProviders Operation</seealso>
        ListOauth2CredentialProvidersResponse EndListOauth2CredentialProviders(IAsyncResult asyncResult);

        #endregion
        
        #region  ListOnlineEvaluationConfigs


        /// <summary>
        /// Lists all online evaluation configurations in the account, providing summary information
        /// about each configuration's status and settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOnlineEvaluationConfigs service method.</param>
        /// 
        /// <returns>The response from the ListOnlineEvaluationConfigs service method, as returned by BedrockAgentCoreControl.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/ListOnlineEvaluationConfigs">REST API Reference for ListOnlineEvaluationConfigs Operation</seealso>
        ListOnlineEvaluationConfigsResponse ListOnlineEvaluationConfigs(ListOnlineEvaluationConfigsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListOnlineEvaluationConfigs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListOnlineEvaluationConfigs operation on AmazonBedrockAgentCoreControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListOnlineEvaluationConfigs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/ListOnlineEvaluationConfigs">REST API Reference for ListOnlineEvaluationConfigs Operation</seealso>
        IAsyncResult BeginListOnlineEvaluationConfigs(ListOnlineEvaluationConfigsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListOnlineEvaluationConfigs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListOnlineEvaluationConfigs.</param>
        /// 
        /// <returns>Returns a  ListOnlineEvaluationConfigsResult from BedrockAgentCoreControl.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/ListOnlineEvaluationConfigs">REST API Reference for ListOnlineEvaluationConfigs Operation</seealso>
        ListOnlineEvaluationConfigsResponse EndListOnlineEvaluationConfigs(IAsyncResult asyncResult);

        #endregion
        
        #region  ListPolicies


        /// <summary>
        /// Retrieves a list of policies within the AgentCore Policy engine. This operation supports
        /// pagination and filtering to help administrators manage and discover policies across
        /// policy engines. Results can be filtered by policy engine or resource associations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPolicies service method.</param>
        /// 
        /// <returns>The response from the ListPolicies service method, as returned by BedrockAgentCoreControl.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/ListPolicies">REST API Reference for ListPolicies Operation</seealso>
        ListPoliciesResponse ListPolicies(ListPoliciesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListPolicies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPolicies operation on AmazonBedrockAgentCoreControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPolicies
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/ListPolicies">REST API Reference for ListPolicies Operation</seealso>
        IAsyncResult BeginListPolicies(ListPoliciesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListPolicies operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPolicies.</param>
        /// 
        /// <returns>Returns a  ListPoliciesResult from BedrockAgentCoreControl.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/ListPolicies">REST API Reference for ListPolicies Operation</seealso>
        ListPoliciesResponse EndListPolicies(IAsyncResult asyncResult);

        #endregion
        
        #region  ListPolicyEngines


        /// <summary>
        /// Retrieves a list of policy engines within the AgentCore Policy system. This operation
        /// supports pagination to help administrators discover and manage policy engines across
        /// their account. Each policy engine serves as a container for related policies.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPolicyEngines service method.</param>
        /// 
        /// <returns>The response from the ListPolicyEngines service method, as returned by BedrockAgentCoreControl.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/ListPolicyEngines">REST API Reference for ListPolicyEngines Operation</seealso>
        ListPolicyEnginesResponse ListPolicyEngines(ListPolicyEnginesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListPolicyEngines operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPolicyEngines operation on AmazonBedrockAgentCoreControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPolicyEngines
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/ListPolicyEngines">REST API Reference for ListPolicyEngines Operation</seealso>
        IAsyncResult BeginListPolicyEngines(ListPolicyEnginesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListPolicyEngines operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPolicyEngines.</param>
        /// 
        /// <returns>Returns a  ListPolicyEnginesResult from BedrockAgentCoreControl.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/ListPolicyEngines">REST API Reference for ListPolicyEngines Operation</seealso>
        ListPolicyEnginesResponse EndListPolicyEngines(IAsyncResult asyncResult);

        #endregion
        
        #region  ListPolicyGenerationAssets


        /// <summary>
        /// Retrieves a list of generated policy assets from a policy generation request within
        /// the AgentCore Policy system. This operation returns the actual Cedar policies and
        /// related artifacts produced by the AI-powered policy generation process, allowing users
        /// to review and select from multiple generated policy options.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPolicyGenerationAssets service method.</param>
        /// 
        /// <returns>The response from the ListPolicyGenerationAssets service method, as returned by BedrockAgentCoreControl.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/ListPolicyGenerationAssets">REST API Reference for ListPolicyGenerationAssets Operation</seealso>
        ListPolicyGenerationAssetsResponse ListPolicyGenerationAssets(ListPolicyGenerationAssetsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListPolicyGenerationAssets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPolicyGenerationAssets operation on AmazonBedrockAgentCoreControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPolicyGenerationAssets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/ListPolicyGenerationAssets">REST API Reference for ListPolicyGenerationAssets Operation</seealso>
        IAsyncResult BeginListPolicyGenerationAssets(ListPolicyGenerationAssetsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListPolicyGenerationAssets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPolicyGenerationAssets.</param>
        /// 
        /// <returns>Returns a  ListPolicyGenerationAssetsResult from BedrockAgentCoreControl.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/ListPolicyGenerationAssets">REST API Reference for ListPolicyGenerationAssets Operation</seealso>
        ListPolicyGenerationAssetsResponse EndListPolicyGenerationAssets(IAsyncResult asyncResult);

        #endregion
        
        #region  ListPolicyGenerations


        /// <summary>
        /// Retrieves a list of policy generation requests within the AgentCore Policy system.
        /// This operation supports pagination and filtering to help track and manage AI-powered
        /// policy generation operations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPolicyGenerations service method.</param>
        /// 
        /// <returns>The response from the ListPolicyGenerations service method, as returned by BedrockAgentCoreControl.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/ListPolicyGenerations">REST API Reference for ListPolicyGenerations Operation</seealso>
        ListPolicyGenerationsResponse ListPolicyGenerations(ListPolicyGenerationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListPolicyGenerations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPolicyGenerations operation on AmazonBedrockAgentCoreControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPolicyGenerations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/ListPolicyGenerations">REST API Reference for ListPolicyGenerations Operation</seealso>
        IAsyncResult BeginListPolicyGenerations(ListPolicyGenerationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListPolicyGenerations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPolicyGenerations.</param>
        /// 
        /// <returns>Returns a  ListPolicyGenerationsResult from BedrockAgentCoreControl.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/ListPolicyGenerations">REST API Reference for ListPolicyGenerations Operation</seealso>
        ListPolicyGenerationsResponse EndListPolicyGenerations(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonBedrockAgentCoreControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from BedrockAgentCoreControl.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the ListWorkloadIdentities operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListWorkloadIdentities operation on AmazonBedrockAgentCoreControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListWorkloadIdentities
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/ListWorkloadIdentities">REST API Reference for ListWorkloadIdentities Operation</seealso>
        IAsyncResult BeginListWorkloadIdentities(ListWorkloadIdentitiesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListWorkloadIdentities operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListWorkloadIdentities.</param>
        /// 
        /// <returns>Returns a  ListWorkloadIdentitiesResult from BedrockAgentCoreControl.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/ListWorkloadIdentities">REST API Reference for ListWorkloadIdentities Operation</seealso>
        ListWorkloadIdentitiesResponse EndListWorkloadIdentities(IAsyncResult asyncResult);

        #endregion
        
        #region  PutResourcePolicy


        /// <summary>
        /// Creates or updates a resource-based policy for a resource with the specified resourceArn.
        /// 
        ///  <note> 
        /// <para>
        /// This feature is currently available only for AgentCore Runtime and Gateway.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutResourcePolicy service method.</param>
        /// 
        /// <returns>The response from the PutResourcePolicy service method, as returned by BedrockAgentCoreControl.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/PutResourcePolicy">REST API Reference for PutResourcePolicy Operation</seealso>
        PutResourcePolicyResponse PutResourcePolicy(PutResourcePolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutResourcePolicy operation on AmazonBedrockAgentCoreControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutResourcePolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/PutResourcePolicy">REST API Reference for PutResourcePolicy Operation</seealso>
        IAsyncResult BeginPutResourcePolicy(PutResourcePolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutResourcePolicy.</param>
        /// 
        /// <returns>Returns a  PutResourcePolicyResult from BedrockAgentCoreControl.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/PutResourcePolicy">REST API Reference for PutResourcePolicy Operation</seealso>
        PutResourcePolicyResponse EndPutResourcePolicy(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the SetTokenVaultCMK operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetTokenVaultCMK operation on AmazonBedrockAgentCoreControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSetTokenVaultCMK
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/SetTokenVaultCMK">REST API Reference for SetTokenVaultCMK Operation</seealso>
        IAsyncResult BeginSetTokenVaultCMK(SetTokenVaultCMKRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SetTokenVaultCMK operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetTokenVaultCMK.</param>
        /// 
        /// <returns>Returns a  SetTokenVaultCMKResult from BedrockAgentCoreControl.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/SetTokenVaultCMK">REST API Reference for SetTokenVaultCMK Operation</seealso>
        SetTokenVaultCMKResponse EndSetTokenVaultCMK(IAsyncResult asyncResult);

        #endregion
        
        #region  StartPolicyGeneration


        /// <summary>
        /// Initiates the AI-powered generation of Cedar policies from natural language descriptions
        /// within the AgentCore Policy system. This feature enables both technical and non-technical
        /// users to create policies by describing their authorization requirements in plain English,
        /// which is then automatically translated into formal Cedar policy statements. The generation
        /// process analyzes the natural language input along with the Gateway's tool context
        /// to produce validated policy options. Generated policy assets are automatically deleted
        /// after 7 days, so you should review and create policies from the generated assets within
        /// this timeframe. Once created, policies are permanent and not subject to this expiration.
        /// Generated policies should be reviewed and tested in log-only mode before deploying
        /// to production. Use this when you want to describe policy intent naturally rather than
        /// learning Cedar syntax, though generated policies may require refinement for complex
        /// scenarios.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartPolicyGeneration service method.</param>
        /// 
        /// <returns>The response from the StartPolicyGeneration service method, as returned by BedrockAgentCoreControl.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/StartPolicyGeneration">REST API Reference for StartPolicyGeneration Operation</seealso>
        StartPolicyGenerationResponse StartPolicyGeneration(StartPolicyGenerationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartPolicyGeneration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartPolicyGeneration operation on AmazonBedrockAgentCoreControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartPolicyGeneration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/StartPolicyGeneration">REST API Reference for StartPolicyGeneration Operation</seealso>
        IAsyncResult BeginStartPolicyGeneration(StartPolicyGenerationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartPolicyGeneration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartPolicyGeneration.</param>
        /// 
        /// <returns>Returns a  StartPolicyGenerationResult from BedrockAgentCoreControl.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/StartPolicyGeneration">REST API Reference for StartPolicyGeneration Operation</seealso>
        StartPolicyGenerationResponse EndStartPolicyGeneration(IAsyncResult asyncResult);

        #endregion
        
        #region  SynchronizeGatewayTargets


        /// <summary>
        /// The gateway targets.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SynchronizeGatewayTargets service method.</param>
        /// 
        /// <returns>The response from the SynchronizeGatewayTargets service method, as returned by BedrockAgentCoreControl.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/SynchronizeGatewayTargets">REST API Reference for SynchronizeGatewayTargets Operation</seealso>
        SynchronizeGatewayTargetsResponse SynchronizeGatewayTargets(SynchronizeGatewayTargetsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the SynchronizeGatewayTargets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SynchronizeGatewayTargets operation on AmazonBedrockAgentCoreControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSynchronizeGatewayTargets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/SynchronizeGatewayTargets">REST API Reference for SynchronizeGatewayTargets Operation</seealso>
        IAsyncResult BeginSynchronizeGatewayTargets(SynchronizeGatewayTargetsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SynchronizeGatewayTargets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSynchronizeGatewayTargets.</param>
        /// 
        /// <returns>Returns a  SynchronizeGatewayTargetsResult from BedrockAgentCoreControl.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/SynchronizeGatewayTargets">REST API Reference for SynchronizeGatewayTargets Operation</seealso>
        SynchronizeGatewayTargetsResponse EndSynchronizeGatewayTargets(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonBedrockAgentCoreControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from BedrockAgentCoreControl.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonBedrockAgentCoreControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from BedrockAgentCoreControl.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the UpdateAgentRuntime operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAgentRuntime operation on AmazonBedrockAgentCoreControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAgentRuntime
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/UpdateAgentRuntime">REST API Reference for UpdateAgentRuntime Operation</seealso>
        IAsyncResult BeginUpdateAgentRuntime(UpdateAgentRuntimeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAgentRuntime operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAgentRuntime.</param>
        /// 
        /// <returns>Returns a  UpdateAgentRuntimeResult from BedrockAgentCoreControl.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/UpdateAgentRuntime">REST API Reference for UpdateAgentRuntime Operation</seealso>
        UpdateAgentRuntimeResponse EndUpdateAgentRuntime(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the UpdateAgentRuntimeEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAgentRuntimeEndpoint operation on AmazonBedrockAgentCoreControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAgentRuntimeEndpoint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/UpdateAgentRuntimeEndpoint">REST API Reference for UpdateAgentRuntimeEndpoint Operation</seealso>
        IAsyncResult BeginUpdateAgentRuntimeEndpoint(UpdateAgentRuntimeEndpointRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAgentRuntimeEndpoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAgentRuntimeEndpoint.</param>
        /// 
        /// <returns>Returns a  UpdateAgentRuntimeEndpointResult from BedrockAgentCoreControl.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/UpdateAgentRuntimeEndpoint">REST API Reference for UpdateAgentRuntimeEndpoint Operation</seealso>
        UpdateAgentRuntimeEndpointResponse EndUpdateAgentRuntimeEndpoint(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the UpdateApiKeyCredentialProvider operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateApiKeyCredentialProvider operation on AmazonBedrockAgentCoreControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateApiKeyCredentialProvider
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/UpdateApiKeyCredentialProvider">REST API Reference for UpdateApiKeyCredentialProvider Operation</seealso>
        IAsyncResult BeginUpdateApiKeyCredentialProvider(UpdateApiKeyCredentialProviderRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateApiKeyCredentialProvider operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateApiKeyCredentialProvider.</param>
        /// 
        /// <returns>Returns a  UpdateApiKeyCredentialProviderResult from BedrockAgentCoreControl.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/UpdateApiKeyCredentialProvider">REST API Reference for UpdateApiKeyCredentialProvider Operation</seealso>
        UpdateApiKeyCredentialProviderResponse EndUpdateApiKeyCredentialProvider(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateEvaluator


        /// <summary>
        /// Updates a custom evaluator's configuration, description, or evaluation level. Built-in
        /// evaluators cannot be updated. The evaluator must not be locked for modification.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEvaluator service method.</param>
        /// 
        /// <returns>The response from the UpdateEvaluator service method, as returned by BedrockAgentCoreControl.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/UpdateEvaluator">REST API Reference for UpdateEvaluator Operation</seealso>
        UpdateEvaluatorResponse UpdateEvaluator(UpdateEvaluatorRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateEvaluator operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateEvaluator operation on AmazonBedrockAgentCoreControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateEvaluator
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/UpdateEvaluator">REST API Reference for UpdateEvaluator Operation</seealso>
        IAsyncResult BeginUpdateEvaluator(UpdateEvaluatorRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateEvaluator operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateEvaluator.</param>
        /// 
        /// <returns>Returns a  UpdateEvaluatorResult from BedrockAgentCoreControl.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/UpdateEvaluator">REST API Reference for UpdateEvaluator Operation</seealso>
        UpdateEvaluatorResponse EndUpdateEvaluator(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the UpdateGateway operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateGateway operation on AmazonBedrockAgentCoreControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateGateway
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/UpdateGateway">REST API Reference for UpdateGateway Operation</seealso>
        IAsyncResult BeginUpdateGateway(UpdateGatewayRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateGateway operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateGateway.</param>
        /// 
        /// <returns>Returns a  UpdateGatewayResult from BedrockAgentCoreControl.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/UpdateGateway">REST API Reference for UpdateGateway Operation</seealso>
        UpdateGatewayResponse EndUpdateGateway(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the UpdateGatewayTarget operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateGatewayTarget operation on AmazonBedrockAgentCoreControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateGatewayTarget
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/UpdateGatewayTarget">REST API Reference for UpdateGatewayTarget Operation</seealso>
        IAsyncResult BeginUpdateGatewayTarget(UpdateGatewayTargetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateGatewayTarget operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateGatewayTarget.</param>
        /// 
        /// <returns>Returns a  UpdateGatewayTargetResult from BedrockAgentCoreControl.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/UpdateGatewayTarget">REST API Reference for UpdateGatewayTarget Operation</seealso>
        UpdateGatewayTargetResponse EndUpdateGatewayTarget(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the UpdateMemory operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateMemory operation on AmazonBedrockAgentCoreControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateMemory
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/UpdateMemory">REST API Reference for UpdateMemory Operation</seealso>
        IAsyncResult BeginUpdateMemory(UpdateMemoryRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateMemory operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateMemory.</param>
        /// 
        /// <returns>Returns a  UpdateMemoryResult from BedrockAgentCoreControl.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/UpdateMemory">REST API Reference for UpdateMemory Operation</seealso>
        UpdateMemoryResponse EndUpdateMemory(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the UpdateOauth2CredentialProvider operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateOauth2CredentialProvider operation on AmazonBedrockAgentCoreControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateOauth2CredentialProvider
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/UpdateOauth2CredentialProvider">REST API Reference for UpdateOauth2CredentialProvider Operation</seealso>
        IAsyncResult BeginUpdateOauth2CredentialProvider(UpdateOauth2CredentialProviderRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateOauth2CredentialProvider operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateOauth2CredentialProvider.</param>
        /// 
        /// <returns>Returns a  UpdateOauth2CredentialProviderResult from BedrockAgentCoreControl.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/UpdateOauth2CredentialProvider">REST API Reference for UpdateOauth2CredentialProvider Operation</seealso>
        UpdateOauth2CredentialProviderResponse EndUpdateOauth2CredentialProvider(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateOnlineEvaluationConfig


        /// <summary>
        /// Updates an online evaluation configuration's settings, including rules, data sources,
        /// evaluators, and execution status. Changes take effect immediately for ongoing evaluations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateOnlineEvaluationConfig service method.</param>
        /// 
        /// <returns>The response from the UpdateOnlineEvaluationConfig service method, as returned by BedrockAgentCoreControl.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/UpdateOnlineEvaluationConfig">REST API Reference for UpdateOnlineEvaluationConfig Operation</seealso>
        UpdateOnlineEvaluationConfigResponse UpdateOnlineEvaluationConfig(UpdateOnlineEvaluationConfigRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateOnlineEvaluationConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateOnlineEvaluationConfig operation on AmazonBedrockAgentCoreControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateOnlineEvaluationConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/UpdateOnlineEvaluationConfig">REST API Reference for UpdateOnlineEvaluationConfig Operation</seealso>
        IAsyncResult BeginUpdateOnlineEvaluationConfig(UpdateOnlineEvaluationConfigRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateOnlineEvaluationConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateOnlineEvaluationConfig.</param>
        /// 
        /// <returns>Returns a  UpdateOnlineEvaluationConfigResult from BedrockAgentCoreControl.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/UpdateOnlineEvaluationConfig">REST API Reference for UpdateOnlineEvaluationConfig Operation</seealso>
        UpdateOnlineEvaluationConfigResponse EndUpdateOnlineEvaluationConfig(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdatePolicy


        /// <summary>
        /// Updates an existing policy within the AgentCore Policy system. This operation allows
        /// modification of the policy description and definition while maintaining the policy's
        /// identity. The updated policy is validated against the Cedar schema before being applied.
        /// This is an asynchronous operation. Use the <c>GetPolicy</c> operation to poll the
        /// <c>status</c> field to track completion.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePolicy service method.</param>
        /// 
        /// <returns>The response from the UpdatePolicy service method, as returned by BedrockAgentCoreControl.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/UpdatePolicy">REST API Reference for UpdatePolicy Operation</seealso>
        UpdatePolicyResponse UpdatePolicy(UpdatePolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdatePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdatePolicy operation on AmazonBedrockAgentCoreControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdatePolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/UpdatePolicy">REST API Reference for UpdatePolicy Operation</seealso>
        IAsyncResult BeginUpdatePolicy(UpdatePolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdatePolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdatePolicy.</param>
        /// 
        /// <returns>Returns a  UpdatePolicyResult from BedrockAgentCoreControl.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/UpdatePolicy">REST API Reference for UpdatePolicy Operation</seealso>
        UpdatePolicyResponse EndUpdatePolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdatePolicyEngine


        /// <summary>
        /// Updates an existing policy engine within the AgentCore Policy system. This operation
        /// allows modification of the policy engine description while maintaining its identity.
        /// This is an asynchronous operation. Use the <c>GetPolicyEngine</c> operation to poll
        /// the <c>status</c> field to track completion.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePolicyEngine service method.</param>
        /// 
        /// <returns>The response from the UpdatePolicyEngine service method, as returned by BedrockAgentCoreControl.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/UpdatePolicyEngine">REST API Reference for UpdatePolicyEngine Operation</seealso>
        UpdatePolicyEngineResponse UpdatePolicyEngine(UpdatePolicyEngineRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdatePolicyEngine operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdatePolicyEngine operation on AmazonBedrockAgentCoreControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdatePolicyEngine
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/UpdatePolicyEngine">REST API Reference for UpdatePolicyEngine Operation</seealso>
        IAsyncResult BeginUpdatePolicyEngine(UpdatePolicyEngineRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdatePolicyEngine operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdatePolicyEngine.</param>
        /// 
        /// <returns>Returns a  UpdatePolicyEngineResult from BedrockAgentCoreControl.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/UpdatePolicyEngine">REST API Reference for UpdatePolicyEngine Operation</seealso>
        UpdatePolicyEngineResponse EndUpdatePolicyEngine(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the UpdateWorkloadIdentity operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorkloadIdentity operation on AmazonBedrockAgentCoreControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateWorkloadIdentity
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/UpdateWorkloadIdentity">REST API Reference for UpdateWorkloadIdentity Operation</seealso>
        IAsyncResult BeginUpdateWorkloadIdentity(UpdateWorkloadIdentityRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateWorkloadIdentity operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateWorkloadIdentity.</param>
        /// 
        /// <returns>Returns a  UpdateWorkloadIdentityResult from BedrockAgentCoreControl.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/UpdateWorkloadIdentity">REST API Reference for UpdateWorkloadIdentity Operation</seealso>
        UpdateWorkloadIdentityResponse EndUpdateWorkloadIdentity(IAsyncResult asyncResult);

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