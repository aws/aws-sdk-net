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
 * Do not modify this file. This file is generated from the apigateway-2015-07-09.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.APIGateway.Model;

namespace Amazon.APIGateway
{
    /// <summary>
    /// Interface for accessing APIGateway
    ///
    /// Amazon API Gateway 
    /// <para>
    /// Amazon API Gateway helps developers deliver robust, secure, and scalable mobile and
    /// web application back ends. API Gateway allows developers to securely connect mobile
    /// and web applications to APIs that run on AWS Lambda, Amazon EC2, or other publicly
    /// addressable web services that are hosted outside of AWS.
    /// </para>
    /// </summary>
    public partial interface IAmazonAPIGateway : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IAPIGatewayPaginatorFactory Paginators { get; }
#endif


        
        #region  CreateApiKey


        /// <summary>
        /// Create an <a>ApiKey</a> resource. 
        /// 
        ///  <div class="seeAlso"><a href="https://docs.aws.amazon.com/cli/latest/reference/apigateway/create-api-key.html">AWS
        /// CLI</a></div>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateApiKey service method.</param>
        /// 
        /// <returns>The response from the CreateApiKey service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// The request exceeded the rate limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/CreateApiKey">REST API Reference for CreateApiKey Operation</seealso>
        CreateApiKeyResponse CreateApiKey(CreateApiKeyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateApiKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateApiKey operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateApiKey
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/CreateApiKey">REST API Reference for CreateApiKey Operation</seealso>
        IAsyncResult BeginCreateApiKey(CreateApiKeyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateApiKey operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateApiKey.</param>
        /// 
        /// <returns>Returns a  CreateApiKeyResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/CreateApiKey">REST API Reference for CreateApiKey Operation</seealso>
        CreateApiKeyResponse EndCreateApiKey(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateAuthorizer


        /// <summary>
        /// Adds a new <a>Authorizer</a> resource to an existing <a>RestApi</a> resource.
        /// 
        ///  <div class="seeAlso"><a href="https://docs.aws.amazon.com/cli/latest/reference/apigateway/create-authorizer.html">AWS
        /// CLI</a></div>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAuthorizer service method.</param>
        /// 
        /// <returns>The response from the CreateAuthorizer service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// The request exceeded the rate limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/CreateAuthorizer">REST API Reference for CreateAuthorizer Operation</seealso>
        CreateAuthorizerResponse CreateAuthorizer(CreateAuthorizerRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAuthorizer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAuthorizer operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAuthorizer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/CreateAuthorizer">REST API Reference for CreateAuthorizer Operation</seealso>
        IAsyncResult BeginCreateAuthorizer(CreateAuthorizerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAuthorizer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAuthorizer.</param>
        /// 
        /// <returns>Returns a  CreateAuthorizerResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/CreateAuthorizer">REST API Reference for CreateAuthorizer Operation</seealso>
        CreateAuthorizerResponse EndCreateAuthorizer(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateBasePathMapping


        /// <summary>
        /// Creates a new <a>BasePathMapping</a> resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBasePathMapping service method.</param>
        /// 
        /// <returns>The response from the CreateBasePathMapping service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/CreateBasePathMapping">REST API Reference for CreateBasePathMapping Operation</seealso>
        CreateBasePathMappingResponse CreateBasePathMapping(CreateBasePathMappingRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateBasePathMapping operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateBasePathMapping operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateBasePathMapping
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/CreateBasePathMapping">REST API Reference for CreateBasePathMapping Operation</seealso>
        IAsyncResult BeginCreateBasePathMapping(CreateBasePathMappingRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateBasePathMapping operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateBasePathMapping.</param>
        /// 
        /// <returns>Returns a  CreateBasePathMappingResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/CreateBasePathMapping">REST API Reference for CreateBasePathMapping Operation</seealso>
        CreateBasePathMappingResponse EndCreateBasePathMapping(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateDeployment


        /// <summary>
        /// Creates a <a>Deployment</a> resource, which makes a specified <a>RestApi</a> callable
        /// over the internet.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDeployment service method.</param>
        /// 
        /// <returns>The response from the CreateDeployment service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// The request exceeded the rate limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ServiceUnavailableException">
        /// The requested service is not available. For details see the accompanying error message.
        /// Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/CreateDeployment">REST API Reference for CreateDeployment Operation</seealso>
        CreateDeploymentResponse CreateDeployment(CreateDeploymentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDeployment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDeployment operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDeployment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/CreateDeployment">REST API Reference for CreateDeployment Operation</seealso>
        IAsyncResult BeginCreateDeployment(CreateDeploymentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDeployment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDeployment.</param>
        /// 
        /// <returns>Returns a  CreateDeploymentResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/CreateDeployment">REST API Reference for CreateDeployment Operation</seealso>
        CreateDeploymentResponse EndCreateDeployment(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateDocumentationPart


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDocumentationPart service method.</param>
        /// 
        /// <returns>The response from the CreateDocumentationPart service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// The request exceeded the rate limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/CreateDocumentationPart">REST API Reference for CreateDocumentationPart Operation</seealso>
        CreateDocumentationPartResponse CreateDocumentationPart(CreateDocumentationPartRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDocumentationPart operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDocumentationPart operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDocumentationPart
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/CreateDocumentationPart">REST API Reference for CreateDocumentationPart Operation</seealso>
        IAsyncResult BeginCreateDocumentationPart(CreateDocumentationPartRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDocumentationPart operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDocumentationPart.</param>
        /// 
        /// <returns>Returns a  CreateDocumentationPartResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/CreateDocumentationPart">REST API Reference for CreateDocumentationPart Operation</seealso>
        CreateDocumentationPartResponse EndCreateDocumentationPart(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateDocumentationVersion


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDocumentationVersion service method.</param>
        /// 
        /// <returns>The response from the CreateDocumentationVersion service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// The request exceeded the rate limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/CreateDocumentationVersion">REST API Reference for CreateDocumentationVersion Operation</seealso>
        CreateDocumentationVersionResponse CreateDocumentationVersion(CreateDocumentationVersionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDocumentationVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDocumentationVersion operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDocumentationVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/CreateDocumentationVersion">REST API Reference for CreateDocumentationVersion Operation</seealso>
        IAsyncResult BeginCreateDocumentationVersion(CreateDocumentationVersionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDocumentationVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDocumentationVersion.</param>
        /// 
        /// <returns>Returns a  CreateDocumentationVersionResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/CreateDocumentationVersion">REST API Reference for CreateDocumentationVersion Operation</seealso>
        CreateDocumentationVersionResponse EndCreateDocumentationVersion(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateDomainName


        /// <summary>
        /// Creates a new domain name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDomainName service method.</param>
        /// 
        /// <returns>The response from the CreateDomainName service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/CreateDomainName">REST API Reference for CreateDomainName Operation</seealso>
        CreateDomainNameResponse CreateDomainName(CreateDomainNameRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDomainName operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDomainName operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDomainName
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/CreateDomainName">REST API Reference for CreateDomainName Operation</seealso>
        IAsyncResult BeginCreateDomainName(CreateDomainNameRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDomainName operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDomainName.</param>
        /// 
        /// <returns>Returns a  CreateDomainNameResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/CreateDomainName">REST API Reference for CreateDomainName Operation</seealso>
        CreateDomainNameResponse EndCreateDomainName(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateModel


        /// <summary>
        /// Adds a new <a>Model</a> resource to an existing <a>RestApi</a> resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateModel service method.</param>
        /// 
        /// <returns>The response from the CreateModel service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// The request exceeded the rate limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/CreateModel">REST API Reference for CreateModel Operation</seealso>
        CreateModelResponse CreateModel(CreateModelRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateModel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateModel operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateModel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/CreateModel">REST API Reference for CreateModel Operation</seealso>
        IAsyncResult BeginCreateModel(CreateModelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateModel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateModel.</param>
        /// 
        /// <returns>Returns a  CreateModelResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/CreateModel">REST API Reference for CreateModel Operation</seealso>
        CreateModelResponse EndCreateModel(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateRequestValidator


        /// <summary>
        /// Creates a <a>ReqeustValidator</a> of a given <a>RestApi</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRequestValidator service method.</param>
        /// 
        /// <returns>The response from the CreateRequestValidator service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// The request exceeded the rate limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/CreateRequestValidator">REST API Reference for CreateRequestValidator Operation</seealso>
        CreateRequestValidatorResponse CreateRequestValidator(CreateRequestValidatorRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateRequestValidator operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRequestValidator operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateRequestValidator
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/CreateRequestValidator">REST API Reference for CreateRequestValidator Operation</seealso>
        IAsyncResult BeginCreateRequestValidator(CreateRequestValidatorRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateRequestValidator operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateRequestValidator.</param>
        /// 
        /// <returns>Returns a  CreateRequestValidatorResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/CreateRequestValidator">REST API Reference for CreateRequestValidator Operation</seealso>
        CreateRequestValidatorResponse EndCreateRequestValidator(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateResource


        /// <summary>
        /// Creates a <a>Resource</a> resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateResource service method.</param>
        /// 
        /// <returns>The response from the CreateResource service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// The request exceeded the rate limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/CreateResource">REST API Reference for CreateResource Operation</seealso>
        CreateResourceResponse CreateResource(CreateResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateResource operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/CreateResource">REST API Reference for CreateResource Operation</seealso>
        IAsyncResult BeginCreateResource(CreateResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateResource.</param>
        /// 
        /// <returns>Returns a  CreateResourceResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/CreateResource">REST API Reference for CreateResource Operation</seealso>
        CreateResourceResponse EndCreateResource(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateRestApi


        /// <summary>
        /// Creates a new <a>RestApi</a> resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRestApi service method.</param>
        /// 
        /// <returns>The response from the CreateRestApi service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// The request exceeded the rate limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/CreateRestApi">REST API Reference for CreateRestApi Operation</seealso>
        CreateRestApiResponse CreateRestApi(CreateRestApiRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateRestApi operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRestApi operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateRestApi
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/CreateRestApi">REST API Reference for CreateRestApi Operation</seealso>
        IAsyncResult BeginCreateRestApi(CreateRestApiRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateRestApi operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateRestApi.</param>
        /// 
        /// <returns>Returns a  CreateRestApiResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/CreateRestApi">REST API Reference for CreateRestApi Operation</seealso>
        CreateRestApiResponse EndCreateRestApi(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateStage


        /// <summary>
        /// Creates a new <a>Stage</a> resource that references a pre-existing <a>Deployment</a>
        /// for the API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateStage service method.</param>
        /// 
        /// <returns>The response from the CreateStage service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// The request exceeded the rate limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/CreateStage">REST API Reference for CreateStage Operation</seealso>
        CreateStageResponse CreateStage(CreateStageRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateStage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateStage operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateStage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/CreateStage">REST API Reference for CreateStage Operation</seealso>
        IAsyncResult BeginCreateStage(CreateStageRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateStage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateStage.</param>
        /// 
        /// <returns>Returns a  CreateStageResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/CreateStage">REST API Reference for CreateStage Operation</seealso>
        CreateStageResponse EndCreateStage(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateUsagePlan


        /// <summary>
        /// Creates a usage plan with the throttle and quota limits, as well as the associated
        /// API stages, specified in the payload.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateUsagePlan service method.</param>
        /// 
        /// <returns>The response from the CreateUsagePlan service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// The request exceeded the rate limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/CreateUsagePlan">REST API Reference for CreateUsagePlan Operation</seealso>
        CreateUsagePlanResponse CreateUsagePlan(CreateUsagePlanRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateUsagePlan operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateUsagePlan operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateUsagePlan
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/CreateUsagePlan">REST API Reference for CreateUsagePlan Operation</seealso>
        IAsyncResult BeginCreateUsagePlan(CreateUsagePlanRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateUsagePlan operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateUsagePlan.</param>
        /// 
        /// <returns>Returns a  CreateUsagePlanResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/CreateUsagePlan">REST API Reference for CreateUsagePlan Operation</seealso>
        CreateUsagePlanResponse EndCreateUsagePlan(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateUsagePlanKey


        /// <summary>
        /// Creates a usage plan key for adding an existing API key to a usage plan.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateUsagePlanKey service method.</param>
        /// 
        /// <returns>The response from the CreateUsagePlanKey service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/CreateUsagePlanKey">REST API Reference for CreateUsagePlanKey Operation</seealso>
        CreateUsagePlanKeyResponse CreateUsagePlanKey(CreateUsagePlanKeyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateUsagePlanKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateUsagePlanKey operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateUsagePlanKey
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/CreateUsagePlanKey">REST API Reference for CreateUsagePlanKey Operation</seealso>
        IAsyncResult BeginCreateUsagePlanKey(CreateUsagePlanKeyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateUsagePlanKey operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateUsagePlanKey.</param>
        /// 
        /// <returns>Returns a  CreateUsagePlanKeyResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/CreateUsagePlanKey">REST API Reference for CreateUsagePlanKey Operation</seealso>
        CreateUsagePlanKeyResponse EndCreateUsagePlanKey(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateVpcLink


        /// <summary>
        /// Creates a VPC link, under the caller's account in a selected region, in an asynchronous
        /// operation that typically takes 2-4 minutes to complete and become operational. The
        /// caller must have permissions to create and update VPC Endpoint services.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVpcLink service method.</param>
        /// 
        /// <returns>The response from the CreateVpcLink service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/CreateVpcLink">REST API Reference for CreateVpcLink Operation</seealso>
        CreateVpcLinkResponse CreateVpcLink(CreateVpcLinkRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateVpcLink operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateVpcLink operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateVpcLink
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/CreateVpcLink">REST API Reference for CreateVpcLink Operation</seealso>
        IAsyncResult BeginCreateVpcLink(CreateVpcLinkRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateVpcLink operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateVpcLink.</param>
        /// 
        /// <returns>Returns a  CreateVpcLinkResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/CreateVpcLink">REST API Reference for CreateVpcLink Operation</seealso>
        CreateVpcLinkResponse EndCreateVpcLink(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteApiKey


        /// <summary>
        /// Deletes the <a>ApiKey</a> resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApiKey service method.</param>
        /// 
        /// <returns>The response from the DeleteApiKey service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteApiKey">REST API Reference for DeleteApiKey Operation</seealso>
        DeleteApiKeyResponse DeleteApiKey(DeleteApiKeyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteApiKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteApiKey operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteApiKey
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteApiKey">REST API Reference for DeleteApiKey Operation</seealso>
        IAsyncResult BeginDeleteApiKey(DeleteApiKeyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteApiKey operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteApiKey.</param>
        /// 
        /// <returns>Returns a  DeleteApiKeyResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteApiKey">REST API Reference for DeleteApiKey Operation</seealso>
        DeleteApiKeyResponse EndDeleteApiKey(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteAuthorizer


        /// <summary>
        /// Deletes an existing <a>Authorizer</a> resource.
        /// 
        ///  <div class="seeAlso"><a href="https://docs.aws.amazon.com/cli/latest/reference/apigateway/delete-authorizer.html">AWS
        /// CLI</a></div>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAuthorizer service method.</param>
        /// 
        /// <returns>The response from the DeleteAuthorizer service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteAuthorizer">REST API Reference for DeleteAuthorizer Operation</seealso>
        DeleteAuthorizerResponse DeleteAuthorizer(DeleteAuthorizerRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAuthorizer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAuthorizer operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAuthorizer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteAuthorizer">REST API Reference for DeleteAuthorizer Operation</seealso>
        IAsyncResult BeginDeleteAuthorizer(DeleteAuthorizerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAuthorizer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAuthorizer.</param>
        /// 
        /// <returns>Returns a  DeleteAuthorizerResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteAuthorizer">REST API Reference for DeleteAuthorizer Operation</seealso>
        DeleteAuthorizerResponse EndDeleteAuthorizer(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteBasePathMapping


        /// <summary>
        /// Deletes the <a>BasePathMapping</a> resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBasePathMapping service method.</param>
        /// 
        /// <returns>The response from the DeleteBasePathMapping service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteBasePathMapping">REST API Reference for DeleteBasePathMapping Operation</seealso>
        DeleteBasePathMappingResponse DeleteBasePathMapping(DeleteBasePathMappingRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBasePathMapping operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBasePathMapping operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteBasePathMapping
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteBasePathMapping">REST API Reference for DeleteBasePathMapping Operation</seealso>
        IAsyncResult BeginDeleteBasePathMapping(DeleteBasePathMappingRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteBasePathMapping operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteBasePathMapping.</param>
        /// 
        /// <returns>Returns a  DeleteBasePathMappingResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteBasePathMapping">REST API Reference for DeleteBasePathMapping Operation</seealso>
        DeleteBasePathMappingResponse EndDeleteBasePathMapping(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteClientCertificate


        /// <summary>
        /// Deletes the <a>ClientCertificate</a> resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteClientCertificate service method.</param>
        /// 
        /// <returns>The response from the DeleteClientCertificate service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteClientCertificate">REST API Reference for DeleteClientCertificate Operation</seealso>
        DeleteClientCertificateResponse DeleteClientCertificate(DeleteClientCertificateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteClientCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteClientCertificate operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteClientCertificate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteClientCertificate">REST API Reference for DeleteClientCertificate Operation</seealso>
        IAsyncResult BeginDeleteClientCertificate(DeleteClientCertificateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteClientCertificate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteClientCertificate.</param>
        /// 
        /// <returns>Returns a  DeleteClientCertificateResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteClientCertificate">REST API Reference for DeleteClientCertificate Operation</seealso>
        DeleteClientCertificateResponse EndDeleteClientCertificate(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteDeployment


        /// <summary>
        /// Deletes a <a>Deployment</a> resource. Deleting a deployment will only succeed if there
        /// are no <a>Stage</a> resources associated with it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDeployment service method.</param>
        /// 
        /// <returns>The response from the DeleteDeployment service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteDeployment">REST API Reference for DeleteDeployment Operation</seealso>
        DeleteDeploymentResponse DeleteDeployment(DeleteDeploymentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDeployment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDeployment operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDeployment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteDeployment">REST API Reference for DeleteDeployment Operation</seealso>
        IAsyncResult BeginDeleteDeployment(DeleteDeploymentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDeployment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDeployment.</param>
        /// 
        /// <returns>Returns a  DeleteDeploymentResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteDeployment">REST API Reference for DeleteDeployment Operation</seealso>
        DeleteDeploymentResponse EndDeleteDeployment(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteDocumentationPart


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDocumentationPart service method.</param>
        /// 
        /// <returns>The response from the DeleteDocumentationPart service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteDocumentationPart">REST API Reference for DeleteDocumentationPart Operation</seealso>
        DeleteDocumentationPartResponse DeleteDocumentationPart(DeleteDocumentationPartRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDocumentationPart operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDocumentationPart operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDocumentationPart
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteDocumentationPart">REST API Reference for DeleteDocumentationPart Operation</seealso>
        IAsyncResult BeginDeleteDocumentationPart(DeleteDocumentationPartRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDocumentationPart operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDocumentationPart.</param>
        /// 
        /// <returns>Returns a  DeleteDocumentationPartResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteDocumentationPart">REST API Reference for DeleteDocumentationPart Operation</seealso>
        DeleteDocumentationPartResponse EndDeleteDocumentationPart(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteDocumentationVersion


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDocumentationVersion service method.</param>
        /// 
        /// <returns>The response from the DeleteDocumentationVersion service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteDocumentationVersion">REST API Reference for DeleteDocumentationVersion Operation</seealso>
        DeleteDocumentationVersionResponse DeleteDocumentationVersion(DeleteDocumentationVersionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDocumentationVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDocumentationVersion operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDocumentationVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteDocumentationVersion">REST API Reference for DeleteDocumentationVersion Operation</seealso>
        IAsyncResult BeginDeleteDocumentationVersion(DeleteDocumentationVersionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDocumentationVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDocumentationVersion.</param>
        /// 
        /// <returns>Returns a  DeleteDocumentationVersionResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteDocumentationVersion">REST API Reference for DeleteDocumentationVersion Operation</seealso>
        DeleteDocumentationVersionResponse EndDeleteDocumentationVersion(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteDomainName


        /// <summary>
        /// Deletes the <a>DomainName</a> resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDomainName service method.</param>
        /// 
        /// <returns>The response from the DeleteDomainName service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteDomainName">REST API Reference for DeleteDomainName Operation</seealso>
        DeleteDomainNameResponse DeleteDomainName(DeleteDomainNameRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDomainName operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDomainName operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDomainName
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteDomainName">REST API Reference for DeleteDomainName Operation</seealso>
        IAsyncResult BeginDeleteDomainName(DeleteDomainNameRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDomainName operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDomainName.</param>
        /// 
        /// <returns>Returns a  DeleteDomainNameResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteDomainName">REST API Reference for DeleteDomainName Operation</seealso>
        DeleteDomainNameResponse EndDeleteDomainName(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteGatewayResponse


        /// <summary>
        /// Clears any customization of a <a>GatewayResponse</a> of a specified response type
        /// on the given <a>RestApi</a> and resets it with the default settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGatewayResponse service method.</param>
        /// 
        /// <returns>The response from the DeleteGatewayResponse service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteGatewayResponse">REST API Reference for DeleteGatewayResponse Operation</seealso>
        DeleteGatewayResponseResponse DeleteGatewayResponse(DeleteGatewayResponseRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteGatewayResponse operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteGatewayResponse operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteGatewayResponse
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteGatewayResponse">REST API Reference for DeleteGatewayResponse Operation</seealso>
        IAsyncResult BeginDeleteGatewayResponse(DeleteGatewayResponseRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteGatewayResponse operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteGatewayResponse.</param>
        /// 
        /// <returns>Returns a  DeleteGatewayResponseResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteGatewayResponse">REST API Reference for DeleteGatewayResponse Operation</seealso>
        DeleteGatewayResponseResponse EndDeleteGatewayResponse(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteIntegration


        /// <summary>
        /// Represents a delete integration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIntegration service method.</param>
        /// 
        /// <returns>The response from the DeleteIntegration service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteIntegration">REST API Reference for DeleteIntegration Operation</seealso>
        DeleteIntegrationResponse DeleteIntegration(DeleteIntegrationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteIntegration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteIntegration operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteIntegration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteIntegration">REST API Reference for DeleteIntegration Operation</seealso>
        IAsyncResult BeginDeleteIntegration(DeleteIntegrationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteIntegration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteIntegration.</param>
        /// 
        /// <returns>Returns a  DeleteIntegrationResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteIntegration">REST API Reference for DeleteIntegration Operation</seealso>
        DeleteIntegrationResponse EndDeleteIntegration(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteIntegrationResponse


        /// <summary>
        /// Represents a delete integration response.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIntegrationResponse service method.</param>
        /// 
        /// <returns>The response from the DeleteIntegrationResponse service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteIntegrationResponse">REST API Reference for DeleteIntegrationResponse Operation</seealso>
        DeleteIntegrationResponseResponse DeleteIntegrationResponse(DeleteIntegrationResponseRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteIntegrationResponse operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteIntegrationResponse operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteIntegrationResponse
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteIntegrationResponse">REST API Reference for DeleteIntegrationResponse Operation</seealso>
        IAsyncResult BeginDeleteIntegrationResponse(DeleteIntegrationResponseRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteIntegrationResponse operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteIntegrationResponse.</param>
        /// 
        /// <returns>Returns a  DeleteIntegrationResponseResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteIntegrationResponse">REST API Reference for DeleteIntegrationResponse Operation</seealso>
        DeleteIntegrationResponseResponse EndDeleteIntegrationResponse(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteMethod


        /// <summary>
        /// Deletes an existing <a>Method</a> resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMethod service method.</param>
        /// 
        /// <returns>The response from the DeleteMethod service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteMethod">REST API Reference for DeleteMethod Operation</seealso>
        DeleteMethodResponse DeleteMethod(DeleteMethodRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteMethod operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteMethod operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteMethod
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteMethod">REST API Reference for DeleteMethod Operation</seealso>
        IAsyncResult BeginDeleteMethod(DeleteMethodRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteMethod operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteMethod.</param>
        /// 
        /// <returns>Returns a  DeleteMethodResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteMethod">REST API Reference for DeleteMethod Operation</seealso>
        DeleteMethodResponse EndDeleteMethod(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteMethodResponse


        /// <summary>
        /// Deletes an existing <a>MethodResponse</a> resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMethodResponse service method.</param>
        /// 
        /// <returns>The response from the DeleteMethodResponse service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteMethodResponse">REST API Reference for DeleteMethodResponse Operation</seealso>
        DeleteMethodResponseResponse DeleteMethodResponse(DeleteMethodResponseRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteMethodResponse operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteMethodResponse operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteMethodResponse
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteMethodResponse">REST API Reference for DeleteMethodResponse Operation</seealso>
        IAsyncResult BeginDeleteMethodResponse(DeleteMethodResponseRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteMethodResponse operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteMethodResponse.</param>
        /// 
        /// <returns>Returns a  DeleteMethodResponseResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteMethodResponse">REST API Reference for DeleteMethodResponse Operation</seealso>
        DeleteMethodResponseResponse EndDeleteMethodResponse(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteModel


        /// <summary>
        /// Deletes a model.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteModel service method.</param>
        /// 
        /// <returns>The response from the DeleteModel service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteModel">REST API Reference for DeleteModel Operation</seealso>
        DeleteModelResponse DeleteModel(DeleteModelRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteModel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteModel operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteModel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteModel">REST API Reference for DeleteModel Operation</seealso>
        IAsyncResult BeginDeleteModel(DeleteModelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteModel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteModel.</param>
        /// 
        /// <returns>Returns a  DeleteModelResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteModel">REST API Reference for DeleteModel Operation</seealso>
        DeleteModelResponse EndDeleteModel(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteRequestValidator


        /// <summary>
        /// Deletes a <a>RequestValidator</a> of a given <a>RestApi</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRequestValidator service method.</param>
        /// 
        /// <returns>The response from the DeleteRequestValidator service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteRequestValidator">REST API Reference for DeleteRequestValidator Operation</seealso>
        DeleteRequestValidatorResponse DeleteRequestValidator(DeleteRequestValidatorRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRequestValidator operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRequestValidator operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteRequestValidator
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteRequestValidator">REST API Reference for DeleteRequestValidator Operation</seealso>
        IAsyncResult BeginDeleteRequestValidator(DeleteRequestValidatorRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteRequestValidator operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRequestValidator.</param>
        /// 
        /// <returns>Returns a  DeleteRequestValidatorResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteRequestValidator">REST API Reference for DeleteRequestValidator Operation</seealso>
        DeleteRequestValidatorResponse EndDeleteRequestValidator(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteResource


        /// <summary>
        /// Deletes a <a>Resource</a> resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResource service method.</param>
        /// 
        /// <returns>The response from the DeleteResource service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteResource">REST API Reference for DeleteResource Operation</seealso>
        DeleteResourceResponse DeleteResource(DeleteResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteResource operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteResource">REST API Reference for DeleteResource Operation</seealso>
        IAsyncResult BeginDeleteResource(DeleteResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteResource.</param>
        /// 
        /// <returns>Returns a  DeleteResourceResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteResource">REST API Reference for DeleteResource Operation</seealso>
        DeleteResourceResponse EndDeleteResource(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteRestApi


        /// <summary>
        /// Deletes the specified API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRestApi service method.</param>
        /// 
        /// <returns>The response from the DeleteRestApi service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteRestApi">REST API Reference for DeleteRestApi Operation</seealso>
        DeleteRestApiResponse DeleteRestApi(DeleteRestApiRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRestApi operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRestApi operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteRestApi
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteRestApi">REST API Reference for DeleteRestApi Operation</seealso>
        IAsyncResult BeginDeleteRestApi(DeleteRestApiRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteRestApi operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRestApi.</param>
        /// 
        /// <returns>Returns a  DeleteRestApiResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteRestApi">REST API Reference for DeleteRestApi Operation</seealso>
        DeleteRestApiResponse EndDeleteRestApi(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteStage


        /// <summary>
        /// Deletes a <a>Stage</a> resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteStage service method.</param>
        /// 
        /// <returns>The response from the DeleteStage service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteStage">REST API Reference for DeleteStage Operation</seealso>
        DeleteStageResponse DeleteStage(DeleteStageRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteStage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteStage operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteStage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteStage">REST API Reference for DeleteStage Operation</seealso>
        IAsyncResult BeginDeleteStage(DeleteStageRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteStage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteStage.</param>
        /// 
        /// <returns>Returns a  DeleteStageResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteStage">REST API Reference for DeleteStage Operation</seealso>
        DeleteStageResponse EndDeleteStage(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteUsagePlan


        /// <summary>
        /// Deletes a usage plan of a given plan Id.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteUsagePlan service method.</param>
        /// 
        /// <returns>The response from the DeleteUsagePlan service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteUsagePlan">REST API Reference for DeleteUsagePlan Operation</seealso>
        DeleteUsagePlanResponse DeleteUsagePlan(DeleteUsagePlanRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteUsagePlan operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteUsagePlan operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteUsagePlan
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteUsagePlan">REST API Reference for DeleteUsagePlan Operation</seealso>
        IAsyncResult BeginDeleteUsagePlan(DeleteUsagePlanRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteUsagePlan operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteUsagePlan.</param>
        /// 
        /// <returns>Returns a  DeleteUsagePlanResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteUsagePlan">REST API Reference for DeleteUsagePlan Operation</seealso>
        DeleteUsagePlanResponse EndDeleteUsagePlan(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteUsagePlanKey


        /// <summary>
        /// Deletes a usage plan key and remove the underlying API key from the associated usage
        /// plan.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteUsagePlanKey service method.</param>
        /// 
        /// <returns>The response from the DeleteUsagePlanKey service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteUsagePlanKey">REST API Reference for DeleteUsagePlanKey Operation</seealso>
        DeleteUsagePlanKeyResponse DeleteUsagePlanKey(DeleteUsagePlanKeyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteUsagePlanKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteUsagePlanKey operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteUsagePlanKey
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteUsagePlanKey">REST API Reference for DeleteUsagePlanKey Operation</seealso>
        IAsyncResult BeginDeleteUsagePlanKey(DeleteUsagePlanKeyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteUsagePlanKey operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteUsagePlanKey.</param>
        /// 
        /// <returns>Returns a  DeleteUsagePlanKeyResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteUsagePlanKey">REST API Reference for DeleteUsagePlanKey Operation</seealso>
        DeleteUsagePlanKeyResponse EndDeleteUsagePlanKey(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteVpcLink


        /// <summary>
        /// Deletes an existing <a>VpcLink</a> of a specified identifier.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVpcLink service method.</param>
        /// 
        /// <returns>The response from the DeleteVpcLink service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteVpcLink">REST API Reference for DeleteVpcLink Operation</seealso>
        DeleteVpcLinkResponse DeleteVpcLink(DeleteVpcLinkRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVpcLink operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVpcLink operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteVpcLink
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteVpcLink">REST API Reference for DeleteVpcLink Operation</seealso>
        IAsyncResult BeginDeleteVpcLink(DeleteVpcLinkRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteVpcLink operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteVpcLink.</param>
        /// 
        /// <returns>Returns a  DeleteVpcLinkResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteVpcLink">REST API Reference for DeleteVpcLink Operation</seealso>
        DeleteVpcLinkResponse EndDeleteVpcLink(IAsyncResult asyncResult);

        #endregion
        
        #region  FlushStageAuthorizersCache


        /// <summary>
        /// Flushes all authorizer cache entries on a stage.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the FlushStageAuthorizersCache service method.</param>
        /// 
        /// <returns>The response from the FlushStageAuthorizersCache service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/FlushStageAuthorizersCache">REST API Reference for FlushStageAuthorizersCache Operation</seealso>
        FlushStageAuthorizersCacheResponse FlushStageAuthorizersCache(FlushStageAuthorizersCacheRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the FlushStageAuthorizersCache operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the FlushStageAuthorizersCache operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndFlushStageAuthorizersCache
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/FlushStageAuthorizersCache">REST API Reference for FlushStageAuthorizersCache Operation</seealso>
        IAsyncResult BeginFlushStageAuthorizersCache(FlushStageAuthorizersCacheRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  FlushStageAuthorizersCache operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginFlushStageAuthorizersCache.</param>
        /// 
        /// <returns>Returns a  FlushStageAuthorizersCacheResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/FlushStageAuthorizersCache">REST API Reference for FlushStageAuthorizersCache Operation</seealso>
        FlushStageAuthorizersCacheResponse EndFlushStageAuthorizersCache(IAsyncResult asyncResult);

        #endregion
        
        #region  FlushStageCache


        /// <summary>
        /// Flushes a stage's cache.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the FlushStageCache service method.</param>
        /// 
        /// <returns>The response from the FlushStageCache service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/FlushStageCache">REST API Reference for FlushStageCache Operation</seealso>
        FlushStageCacheResponse FlushStageCache(FlushStageCacheRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the FlushStageCache operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the FlushStageCache operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndFlushStageCache
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/FlushStageCache">REST API Reference for FlushStageCache Operation</seealso>
        IAsyncResult BeginFlushStageCache(FlushStageCacheRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  FlushStageCache operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginFlushStageCache.</param>
        /// 
        /// <returns>Returns a  FlushStageCacheResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/FlushStageCache">REST API Reference for FlushStageCache Operation</seealso>
        FlushStageCacheResponse EndFlushStageCache(IAsyncResult asyncResult);

        #endregion
        
        #region  GenerateClientCertificate


        /// <summary>
        /// Generates a <a>ClientCertificate</a> resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GenerateClientCertificate service method.</param>
        /// 
        /// <returns>The response from the GenerateClientCertificate service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// The request exceeded the rate limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GenerateClientCertificate">REST API Reference for GenerateClientCertificate Operation</seealso>
        GenerateClientCertificateResponse GenerateClientCertificate(GenerateClientCertificateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GenerateClientCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GenerateClientCertificate operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGenerateClientCertificate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GenerateClientCertificate">REST API Reference for GenerateClientCertificate Operation</seealso>
        IAsyncResult BeginGenerateClientCertificate(GenerateClientCertificateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GenerateClientCertificate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGenerateClientCertificate.</param>
        /// 
        /// <returns>Returns a  GenerateClientCertificateResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GenerateClientCertificate">REST API Reference for GenerateClientCertificate Operation</seealso>
        GenerateClientCertificateResponse EndGenerateClientCertificate(IAsyncResult asyncResult);

        #endregion
        
        #region  GetAccount


        /// <summary>
        /// Gets information about the current <a>Account</a> resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccount service method.</param>
        /// 
        /// <returns>The response from the GetAccount service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetAccount">REST API Reference for GetAccount Operation</seealso>
        GetAccountResponse GetAccount(GetAccountRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAccount operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAccount
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetAccount">REST API Reference for GetAccount Operation</seealso>
        IAsyncResult BeginGetAccount(GetAccountRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetAccount operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAccount.</param>
        /// 
        /// <returns>Returns a  GetAccountResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetAccount">REST API Reference for GetAccount Operation</seealso>
        GetAccountResponse EndGetAccount(IAsyncResult asyncResult);

        #endregion
        
        #region  GetApiKey


        /// <summary>
        /// Gets information about the current <a>ApiKey</a> resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApiKey service method.</param>
        /// 
        /// <returns>The response from the GetApiKey service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetApiKey">REST API Reference for GetApiKey Operation</seealso>
        GetApiKeyResponse GetApiKey(GetApiKeyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetApiKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetApiKey operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetApiKey
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetApiKey">REST API Reference for GetApiKey Operation</seealso>
        IAsyncResult BeginGetApiKey(GetApiKeyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetApiKey operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetApiKey.</param>
        /// 
        /// <returns>Returns a  GetApiKeyResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetApiKey">REST API Reference for GetApiKey Operation</seealso>
        GetApiKeyResponse EndGetApiKey(IAsyncResult asyncResult);

        #endregion
        
        #region  GetApiKeys


        /// <summary>
        /// Gets information about the current <a>ApiKeys</a> resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApiKeys service method.</param>
        /// 
        /// <returns>The response from the GetApiKeys service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetApiKeys">REST API Reference for GetApiKeys Operation</seealso>
        GetApiKeysResponse GetApiKeys(GetApiKeysRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetApiKeys operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetApiKeys operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetApiKeys
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetApiKeys">REST API Reference for GetApiKeys Operation</seealso>
        IAsyncResult BeginGetApiKeys(GetApiKeysRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetApiKeys operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetApiKeys.</param>
        /// 
        /// <returns>Returns a  GetApiKeysResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetApiKeys">REST API Reference for GetApiKeys Operation</seealso>
        GetApiKeysResponse EndGetApiKeys(IAsyncResult asyncResult);

        #endregion
        
        #region  GetAuthorizer


        /// <summary>
        /// Describe an existing <a>Authorizer</a> resource.
        /// 
        ///  <div class="seeAlso"><a href="https://docs.aws.amazon.com/cli/latest/reference/apigateway/get-authorizer.html">AWS
        /// CLI</a></div>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAuthorizer service method.</param>
        /// 
        /// <returns>The response from the GetAuthorizer service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetAuthorizer">REST API Reference for GetAuthorizer Operation</seealso>
        GetAuthorizerResponse GetAuthorizer(GetAuthorizerRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetAuthorizer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAuthorizer operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAuthorizer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetAuthorizer">REST API Reference for GetAuthorizer Operation</seealso>
        IAsyncResult BeginGetAuthorizer(GetAuthorizerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetAuthorizer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAuthorizer.</param>
        /// 
        /// <returns>Returns a  GetAuthorizerResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetAuthorizer">REST API Reference for GetAuthorizer Operation</seealso>
        GetAuthorizerResponse EndGetAuthorizer(IAsyncResult asyncResult);

        #endregion
        
        #region  GetAuthorizers


        /// <summary>
        /// Describe an existing <a>Authorizers</a> resource.
        /// 
        ///  <div class="seeAlso"><a href="https://docs.aws.amazon.com/cli/latest/reference/apigateway/get-authorizers.html">AWS
        /// CLI</a></div>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAuthorizers service method.</param>
        /// 
        /// <returns>The response from the GetAuthorizers service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetAuthorizers">REST API Reference for GetAuthorizers Operation</seealso>
        GetAuthorizersResponse GetAuthorizers(GetAuthorizersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetAuthorizers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAuthorizers operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAuthorizers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetAuthorizers">REST API Reference for GetAuthorizers Operation</seealso>
        IAsyncResult BeginGetAuthorizers(GetAuthorizersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetAuthorizers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAuthorizers.</param>
        /// 
        /// <returns>Returns a  GetAuthorizersResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetAuthorizers">REST API Reference for GetAuthorizers Operation</seealso>
        GetAuthorizersResponse EndGetAuthorizers(IAsyncResult asyncResult);

        #endregion
        
        #region  GetBasePathMapping


        /// <summary>
        /// Describe a <a>BasePathMapping</a> resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBasePathMapping service method.</param>
        /// 
        /// <returns>The response from the GetBasePathMapping service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetBasePathMapping">REST API Reference for GetBasePathMapping Operation</seealso>
        GetBasePathMappingResponse GetBasePathMapping(GetBasePathMappingRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetBasePathMapping operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBasePathMapping operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetBasePathMapping
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetBasePathMapping">REST API Reference for GetBasePathMapping Operation</seealso>
        IAsyncResult BeginGetBasePathMapping(GetBasePathMappingRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetBasePathMapping operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBasePathMapping.</param>
        /// 
        /// <returns>Returns a  GetBasePathMappingResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetBasePathMapping">REST API Reference for GetBasePathMapping Operation</seealso>
        GetBasePathMappingResponse EndGetBasePathMapping(IAsyncResult asyncResult);

        #endregion
        
        #region  GetBasePathMappings


        /// <summary>
        /// Represents a collection of <a>BasePathMapping</a> resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBasePathMappings service method.</param>
        /// 
        /// <returns>The response from the GetBasePathMappings service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetBasePathMappings">REST API Reference for GetBasePathMappings Operation</seealso>
        GetBasePathMappingsResponse GetBasePathMappings(GetBasePathMappingsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetBasePathMappings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBasePathMappings operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetBasePathMappings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetBasePathMappings">REST API Reference for GetBasePathMappings Operation</seealso>
        IAsyncResult BeginGetBasePathMappings(GetBasePathMappingsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetBasePathMappings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBasePathMappings.</param>
        /// 
        /// <returns>Returns a  GetBasePathMappingsResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetBasePathMappings">REST API Reference for GetBasePathMappings Operation</seealso>
        GetBasePathMappingsResponse EndGetBasePathMappings(IAsyncResult asyncResult);

        #endregion
        
        #region  GetClientCertificate


        /// <summary>
        /// Gets information about the current <a>ClientCertificate</a> resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetClientCertificate service method.</param>
        /// 
        /// <returns>The response from the GetClientCertificate service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetClientCertificate">REST API Reference for GetClientCertificate Operation</seealso>
        GetClientCertificateResponse GetClientCertificate(GetClientCertificateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetClientCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetClientCertificate operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetClientCertificate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetClientCertificate">REST API Reference for GetClientCertificate Operation</seealso>
        IAsyncResult BeginGetClientCertificate(GetClientCertificateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetClientCertificate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetClientCertificate.</param>
        /// 
        /// <returns>Returns a  GetClientCertificateResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetClientCertificate">REST API Reference for GetClientCertificate Operation</seealso>
        GetClientCertificateResponse EndGetClientCertificate(IAsyncResult asyncResult);

        #endregion
        
        #region  GetClientCertificates


        /// <summary>
        /// Gets a collection of <a>ClientCertificate</a> resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetClientCertificates service method.</param>
        /// 
        /// <returns>The response from the GetClientCertificates service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetClientCertificates">REST API Reference for GetClientCertificates Operation</seealso>
        GetClientCertificatesResponse GetClientCertificates(GetClientCertificatesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetClientCertificates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetClientCertificates operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetClientCertificates
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetClientCertificates">REST API Reference for GetClientCertificates Operation</seealso>
        IAsyncResult BeginGetClientCertificates(GetClientCertificatesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetClientCertificates operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetClientCertificates.</param>
        /// 
        /// <returns>Returns a  GetClientCertificatesResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetClientCertificates">REST API Reference for GetClientCertificates Operation</seealso>
        GetClientCertificatesResponse EndGetClientCertificates(IAsyncResult asyncResult);

        #endregion
        
        #region  GetDeployment


        /// <summary>
        /// Gets information about a <a>Deployment</a> resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDeployment service method.</param>
        /// 
        /// <returns>The response from the GetDeployment service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ServiceUnavailableException">
        /// The requested service is not available. For details see the accompanying error message.
        /// Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetDeployment">REST API Reference for GetDeployment Operation</seealso>
        GetDeploymentResponse GetDeployment(GetDeploymentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetDeployment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDeployment operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDeployment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetDeployment">REST API Reference for GetDeployment Operation</seealso>
        IAsyncResult BeginGetDeployment(GetDeploymentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetDeployment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDeployment.</param>
        /// 
        /// <returns>Returns a  GetDeploymentResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetDeployment">REST API Reference for GetDeployment Operation</seealso>
        GetDeploymentResponse EndGetDeployment(IAsyncResult asyncResult);

        #endregion
        
        #region  GetDeployments


        /// <summary>
        /// Gets information about a <a>Deployments</a> collection.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDeployments service method.</param>
        /// 
        /// <returns>The response from the GetDeployments service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ServiceUnavailableException">
        /// The requested service is not available. For details see the accompanying error message.
        /// Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetDeployments">REST API Reference for GetDeployments Operation</seealso>
        GetDeploymentsResponse GetDeployments(GetDeploymentsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetDeployments operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDeployments operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDeployments
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetDeployments">REST API Reference for GetDeployments Operation</seealso>
        IAsyncResult BeginGetDeployments(GetDeploymentsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetDeployments operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDeployments.</param>
        /// 
        /// <returns>Returns a  GetDeploymentsResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetDeployments">REST API Reference for GetDeployments Operation</seealso>
        GetDeploymentsResponse EndGetDeployments(IAsyncResult asyncResult);

        #endregion
        
        #region  GetDocumentationPart


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDocumentationPart service method.</param>
        /// 
        /// <returns>The response from the GetDocumentationPart service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetDocumentationPart">REST API Reference for GetDocumentationPart Operation</seealso>
        GetDocumentationPartResponse GetDocumentationPart(GetDocumentationPartRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetDocumentationPart operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDocumentationPart operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDocumentationPart
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetDocumentationPart">REST API Reference for GetDocumentationPart Operation</seealso>
        IAsyncResult BeginGetDocumentationPart(GetDocumentationPartRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetDocumentationPart operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDocumentationPart.</param>
        /// 
        /// <returns>Returns a  GetDocumentationPartResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetDocumentationPart">REST API Reference for GetDocumentationPart Operation</seealso>
        GetDocumentationPartResponse EndGetDocumentationPart(IAsyncResult asyncResult);

        #endregion
        
        #region  GetDocumentationParts


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDocumentationParts service method.</param>
        /// 
        /// <returns>The response from the GetDocumentationParts service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetDocumentationParts">REST API Reference for GetDocumentationParts Operation</seealso>
        GetDocumentationPartsResponse GetDocumentationParts(GetDocumentationPartsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetDocumentationParts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDocumentationParts operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDocumentationParts
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetDocumentationParts">REST API Reference for GetDocumentationParts Operation</seealso>
        IAsyncResult BeginGetDocumentationParts(GetDocumentationPartsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetDocumentationParts operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDocumentationParts.</param>
        /// 
        /// <returns>Returns a  GetDocumentationPartsResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetDocumentationParts">REST API Reference for GetDocumentationParts Operation</seealso>
        GetDocumentationPartsResponse EndGetDocumentationParts(IAsyncResult asyncResult);

        #endregion
        
        #region  GetDocumentationVersion


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDocumentationVersion service method.</param>
        /// 
        /// <returns>The response from the GetDocumentationVersion service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetDocumentationVersion">REST API Reference for GetDocumentationVersion Operation</seealso>
        GetDocumentationVersionResponse GetDocumentationVersion(GetDocumentationVersionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetDocumentationVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDocumentationVersion operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDocumentationVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetDocumentationVersion">REST API Reference for GetDocumentationVersion Operation</seealso>
        IAsyncResult BeginGetDocumentationVersion(GetDocumentationVersionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetDocumentationVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDocumentationVersion.</param>
        /// 
        /// <returns>Returns a  GetDocumentationVersionResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetDocumentationVersion">REST API Reference for GetDocumentationVersion Operation</seealso>
        GetDocumentationVersionResponse EndGetDocumentationVersion(IAsyncResult asyncResult);

        #endregion
        
        #region  GetDocumentationVersions


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDocumentationVersions service method.</param>
        /// 
        /// <returns>The response from the GetDocumentationVersions service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetDocumentationVersions">REST API Reference for GetDocumentationVersions Operation</seealso>
        GetDocumentationVersionsResponse GetDocumentationVersions(GetDocumentationVersionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetDocumentationVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDocumentationVersions operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDocumentationVersions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetDocumentationVersions">REST API Reference for GetDocumentationVersions Operation</seealso>
        IAsyncResult BeginGetDocumentationVersions(GetDocumentationVersionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetDocumentationVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDocumentationVersions.</param>
        /// 
        /// <returns>Returns a  GetDocumentationVersionsResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetDocumentationVersions">REST API Reference for GetDocumentationVersions Operation</seealso>
        GetDocumentationVersionsResponse EndGetDocumentationVersions(IAsyncResult asyncResult);

        #endregion
        
        #region  GetDomainName


        /// <summary>
        /// Represents a domain name that is contained in a simpler, more intuitive URL that can
        /// be called.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDomainName service method.</param>
        /// 
        /// <returns>The response from the GetDomainName service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ServiceUnavailableException">
        /// The requested service is not available. For details see the accompanying error message.
        /// Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetDomainName">REST API Reference for GetDomainName Operation</seealso>
        GetDomainNameResponse GetDomainName(GetDomainNameRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetDomainName operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDomainName operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDomainName
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetDomainName">REST API Reference for GetDomainName Operation</seealso>
        IAsyncResult BeginGetDomainName(GetDomainNameRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetDomainName operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDomainName.</param>
        /// 
        /// <returns>Returns a  GetDomainNameResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetDomainName">REST API Reference for GetDomainName Operation</seealso>
        GetDomainNameResponse EndGetDomainName(IAsyncResult asyncResult);

        #endregion
        
        #region  GetDomainNames


        /// <summary>
        /// Represents a collection of <a>DomainName</a> resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDomainNames service method.</param>
        /// 
        /// <returns>The response from the GetDomainNames service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetDomainNames">REST API Reference for GetDomainNames Operation</seealso>
        GetDomainNamesResponse GetDomainNames(GetDomainNamesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetDomainNames operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDomainNames operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDomainNames
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetDomainNames">REST API Reference for GetDomainNames Operation</seealso>
        IAsyncResult BeginGetDomainNames(GetDomainNamesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetDomainNames operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDomainNames.</param>
        /// 
        /// <returns>Returns a  GetDomainNamesResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetDomainNames">REST API Reference for GetDomainNames Operation</seealso>
        GetDomainNamesResponse EndGetDomainNames(IAsyncResult asyncResult);

        #endregion
        
        #region  GetExport


        /// <summary>
        /// Exports a deployed version of a <a>RestApi</a> in a specified format.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetExport service method.</param>
        /// 
        /// <returns>The response from the GetExport service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetExport">REST API Reference for GetExport Operation</seealso>
        GetExportResponse GetExport(GetExportRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetExport operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetExport operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetExport
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetExport">REST API Reference for GetExport Operation</seealso>
        IAsyncResult BeginGetExport(GetExportRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetExport operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetExport.</param>
        /// 
        /// <returns>Returns a  GetExportResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetExport">REST API Reference for GetExport Operation</seealso>
        GetExportResponse EndGetExport(IAsyncResult asyncResult);

        #endregion
        
        #region  GetGatewayResponse


        /// <summary>
        /// Gets a <a>GatewayResponse</a> of a specified response type on the given <a>RestApi</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGatewayResponse service method.</param>
        /// 
        /// <returns>The response from the GetGatewayResponse service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetGatewayResponse">REST API Reference for GetGatewayResponse Operation</seealso>
        GetGatewayResponseResponse GetGatewayResponse(GetGatewayResponseRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetGatewayResponse operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetGatewayResponse operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetGatewayResponse
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetGatewayResponse">REST API Reference for GetGatewayResponse Operation</seealso>
        IAsyncResult BeginGetGatewayResponse(GetGatewayResponseRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetGatewayResponse operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetGatewayResponse.</param>
        /// 
        /// <returns>Returns a  GetGatewayResponseResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetGatewayResponse">REST API Reference for GetGatewayResponse Operation</seealso>
        GetGatewayResponseResponse EndGetGatewayResponse(IAsyncResult asyncResult);

        #endregion
        
        #region  GetGatewayResponses


        /// <summary>
        /// Gets the <a>GatewayResponses</a> collection on the given <a>RestApi</a>. If an API
        /// developer has not added any definitions for gateway responses, the result will be
        /// the API Gateway-generated default <a>GatewayResponses</a> collection for the supported
        /// response types.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGatewayResponses service method.</param>
        /// 
        /// <returns>The response from the GetGatewayResponses service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetGatewayResponses">REST API Reference for GetGatewayResponses Operation</seealso>
        GetGatewayResponsesResponse GetGatewayResponses(GetGatewayResponsesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetGatewayResponses operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetGatewayResponses operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetGatewayResponses
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetGatewayResponses">REST API Reference for GetGatewayResponses Operation</seealso>
        IAsyncResult BeginGetGatewayResponses(GetGatewayResponsesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetGatewayResponses operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetGatewayResponses.</param>
        /// 
        /// <returns>Returns a  GetGatewayResponsesResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetGatewayResponses">REST API Reference for GetGatewayResponses Operation</seealso>
        GetGatewayResponsesResponse EndGetGatewayResponses(IAsyncResult asyncResult);

        #endregion
        
        #region  GetIntegration


        /// <summary>
        /// Get the integration settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIntegration service method.</param>
        /// 
        /// <returns>The response from the GetIntegration service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetIntegration">REST API Reference for GetIntegration Operation</seealso>
        GetIntegrationResponse GetIntegration(GetIntegrationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetIntegration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetIntegration operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetIntegration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetIntegration">REST API Reference for GetIntegration Operation</seealso>
        IAsyncResult BeginGetIntegration(GetIntegrationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetIntegration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetIntegration.</param>
        /// 
        /// <returns>Returns a  GetIntegrationResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetIntegration">REST API Reference for GetIntegration Operation</seealso>
        GetIntegrationResponse EndGetIntegration(IAsyncResult asyncResult);

        #endregion
        
        #region  GetIntegrationResponse


        /// <summary>
        /// Represents a get integration response.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIntegrationResponse service method.</param>
        /// 
        /// <returns>The response from the GetIntegrationResponse service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetIntegrationResponse">REST API Reference for GetIntegrationResponse Operation</seealso>
        GetIntegrationResponseResponse GetIntegrationResponse(GetIntegrationResponseRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetIntegrationResponse operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetIntegrationResponse operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetIntegrationResponse
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetIntegrationResponse">REST API Reference for GetIntegrationResponse Operation</seealso>
        IAsyncResult BeginGetIntegrationResponse(GetIntegrationResponseRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetIntegrationResponse operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetIntegrationResponse.</param>
        /// 
        /// <returns>Returns a  GetIntegrationResponseResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetIntegrationResponse">REST API Reference for GetIntegrationResponse Operation</seealso>
        GetIntegrationResponseResponse EndGetIntegrationResponse(IAsyncResult asyncResult);

        #endregion
        
        #region  GetMethod


        /// <summary>
        /// Describe an existing <a>Method</a> resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMethod service method.</param>
        /// 
        /// <returns>The response from the GetMethod service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetMethod">REST API Reference for GetMethod Operation</seealso>
        GetMethodResponse GetMethod(GetMethodRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetMethod operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMethod operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetMethod
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetMethod">REST API Reference for GetMethod Operation</seealso>
        IAsyncResult BeginGetMethod(GetMethodRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetMethod operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetMethod.</param>
        /// 
        /// <returns>Returns a  GetMethodResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetMethod">REST API Reference for GetMethod Operation</seealso>
        GetMethodResponse EndGetMethod(IAsyncResult asyncResult);

        #endregion
        
        #region  GetMethodResponse


        /// <summary>
        /// Describes a <a>MethodResponse</a> resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMethodResponse service method.</param>
        /// 
        /// <returns>The response from the GetMethodResponse service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetMethodResponse">REST API Reference for GetMethodResponse Operation</seealso>
        GetMethodResponseResponse GetMethodResponse(GetMethodResponseRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetMethodResponse operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMethodResponse operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetMethodResponse
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetMethodResponse">REST API Reference for GetMethodResponse Operation</seealso>
        IAsyncResult BeginGetMethodResponse(GetMethodResponseRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetMethodResponse operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetMethodResponse.</param>
        /// 
        /// <returns>Returns a  GetMethodResponseResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetMethodResponse">REST API Reference for GetMethodResponse Operation</seealso>
        GetMethodResponseResponse EndGetMethodResponse(IAsyncResult asyncResult);

        #endregion
        
        #region  GetModel


        /// <summary>
        /// Describes an existing model defined for a <a>RestApi</a> resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetModel service method.</param>
        /// 
        /// <returns>The response from the GetModel service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetModel">REST API Reference for GetModel Operation</seealso>
        GetModelResponse GetModel(GetModelRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetModel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetModel operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetModel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetModel">REST API Reference for GetModel Operation</seealso>
        IAsyncResult BeginGetModel(GetModelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetModel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetModel.</param>
        /// 
        /// <returns>Returns a  GetModelResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetModel">REST API Reference for GetModel Operation</seealso>
        GetModelResponse EndGetModel(IAsyncResult asyncResult);

        #endregion
        
        #region  GetModels


        /// <summary>
        /// Describes existing <a>Models</a> defined for a <a>RestApi</a> resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetModels service method.</param>
        /// 
        /// <returns>The response from the GetModels service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetModels">REST API Reference for GetModels Operation</seealso>
        GetModelsResponse GetModels(GetModelsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetModels operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetModels operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetModels
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetModels">REST API Reference for GetModels Operation</seealso>
        IAsyncResult BeginGetModels(GetModelsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetModels operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetModels.</param>
        /// 
        /// <returns>Returns a  GetModelsResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetModels">REST API Reference for GetModels Operation</seealso>
        GetModelsResponse EndGetModels(IAsyncResult asyncResult);

        #endregion
        
        #region  GetModelTemplate


        /// <summary>
        /// Generates a sample mapping template that can be used to transform a payload into the
        /// structure of a model.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetModelTemplate service method.</param>
        /// 
        /// <returns>The response from the GetModelTemplate service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetModelTemplate">REST API Reference for GetModelTemplate Operation</seealso>
        GetModelTemplateResponse GetModelTemplate(GetModelTemplateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetModelTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetModelTemplate operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetModelTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetModelTemplate">REST API Reference for GetModelTemplate Operation</seealso>
        IAsyncResult BeginGetModelTemplate(GetModelTemplateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetModelTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetModelTemplate.</param>
        /// 
        /// <returns>Returns a  GetModelTemplateResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetModelTemplate">REST API Reference for GetModelTemplate Operation</seealso>
        GetModelTemplateResponse EndGetModelTemplate(IAsyncResult asyncResult);

        #endregion
        
        #region  GetRequestValidator


        /// <summary>
        /// Gets a <a>RequestValidator</a> of a given <a>RestApi</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRequestValidator service method.</param>
        /// 
        /// <returns>The response from the GetRequestValidator service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetRequestValidator">REST API Reference for GetRequestValidator Operation</seealso>
        GetRequestValidatorResponse GetRequestValidator(GetRequestValidatorRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetRequestValidator operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRequestValidator operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRequestValidator
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetRequestValidator">REST API Reference for GetRequestValidator Operation</seealso>
        IAsyncResult BeginGetRequestValidator(GetRequestValidatorRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetRequestValidator operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRequestValidator.</param>
        /// 
        /// <returns>Returns a  GetRequestValidatorResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetRequestValidator">REST API Reference for GetRequestValidator Operation</seealso>
        GetRequestValidatorResponse EndGetRequestValidator(IAsyncResult asyncResult);

        #endregion
        
        #region  GetRequestValidators


        /// <summary>
        /// Gets the <a>RequestValidators</a> collection of a given <a>RestApi</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRequestValidators service method.</param>
        /// 
        /// <returns>The response from the GetRequestValidators service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetRequestValidators">REST API Reference for GetRequestValidators Operation</seealso>
        GetRequestValidatorsResponse GetRequestValidators(GetRequestValidatorsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetRequestValidators operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRequestValidators operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRequestValidators
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetRequestValidators">REST API Reference for GetRequestValidators Operation</seealso>
        IAsyncResult BeginGetRequestValidators(GetRequestValidatorsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetRequestValidators operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRequestValidators.</param>
        /// 
        /// <returns>Returns a  GetRequestValidatorsResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetRequestValidators">REST API Reference for GetRequestValidators Operation</seealso>
        GetRequestValidatorsResponse EndGetRequestValidators(IAsyncResult asyncResult);

        #endregion
        
        #region  GetResource


        /// <summary>
        /// Lists information about a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResource service method.</param>
        /// 
        /// <returns>The response from the GetResource service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetResource">REST API Reference for GetResource Operation</seealso>
        GetResourceResponse GetResource(GetResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetResource operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetResource">REST API Reference for GetResource Operation</seealso>
        IAsyncResult BeginGetResource(GetResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetResource.</param>
        /// 
        /// <returns>Returns a  GetResourceResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetResource">REST API Reference for GetResource Operation</seealso>
        GetResourceResponse EndGetResource(IAsyncResult asyncResult);

        #endregion
        
        #region  GetResources


        /// <summary>
        /// Lists information about a collection of <a>Resource</a> resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResources service method.</param>
        /// 
        /// <returns>The response from the GetResources service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetResources">REST API Reference for GetResources Operation</seealso>
        GetResourcesResponse GetResources(GetResourcesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetResources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetResources operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetResources
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetResources">REST API Reference for GetResources Operation</seealso>
        IAsyncResult BeginGetResources(GetResourcesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetResources operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetResources.</param>
        /// 
        /// <returns>Returns a  GetResourcesResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetResources">REST API Reference for GetResources Operation</seealso>
        GetResourcesResponse EndGetResources(IAsyncResult asyncResult);

        #endregion
        
        #region  GetRestApi


        /// <summary>
        /// Lists the <a>RestApi</a> resource in the collection.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRestApi service method.</param>
        /// 
        /// <returns>The response from the GetRestApi service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetRestApi">REST API Reference for GetRestApi Operation</seealso>
        GetRestApiResponse GetRestApi(GetRestApiRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetRestApi operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRestApi operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRestApi
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetRestApi">REST API Reference for GetRestApi Operation</seealso>
        IAsyncResult BeginGetRestApi(GetRestApiRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetRestApi operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRestApi.</param>
        /// 
        /// <returns>Returns a  GetRestApiResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetRestApi">REST API Reference for GetRestApi Operation</seealso>
        GetRestApiResponse EndGetRestApi(IAsyncResult asyncResult);

        #endregion
        
        #region  GetRestApis


        /// <summary>
        /// Lists the <a>RestApis</a> resources for your collection.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRestApis service method.</param>
        /// 
        /// <returns>The response from the GetRestApis service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetRestApis">REST API Reference for GetRestApis Operation</seealso>
        GetRestApisResponse GetRestApis(GetRestApisRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetRestApis operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRestApis operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRestApis
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetRestApis">REST API Reference for GetRestApis Operation</seealso>
        IAsyncResult BeginGetRestApis(GetRestApisRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetRestApis operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRestApis.</param>
        /// 
        /// <returns>Returns a  GetRestApisResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetRestApis">REST API Reference for GetRestApis Operation</seealso>
        GetRestApisResponse EndGetRestApis(IAsyncResult asyncResult);

        #endregion
        
        #region  GetSdk


        /// <summary>
        /// Generates a client SDK for a <a>RestApi</a> and <a>Stage</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSdk service method.</param>
        /// 
        /// <returns>The response from the GetSdk service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetSdk">REST API Reference for GetSdk Operation</seealso>
        GetSdkResponse GetSdk(GetSdkRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetSdk operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSdk operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSdk
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetSdk">REST API Reference for GetSdk Operation</seealso>
        IAsyncResult BeginGetSdk(GetSdkRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetSdk operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSdk.</param>
        /// 
        /// <returns>Returns a  GetSdkResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetSdk">REST API Reference for GetSdk Operation</seealso>
        GetSdkResponse EndGetSdk(IAsyncResult asyncResult);

        #endregion
        
        #region  GetSdkType


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSdkType service method.</param>
        /// 
        /// <returns>The response from the GetSdkType service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetSdkType">REST API Reference for GetSdkType Operation</seealso>
        GetSdkTypeResponse GetSdkType(GetSdkTypeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetSdkType operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSdkType operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSdkType
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetSdkType">REST API Reference for GetSdkType Operation</seealso>
        IAsyncResult BeginGetSdkType(GetSdkTypeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetSdkType operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSdkType.</param>
        /// 
        /// <returns>Returns a  GetSdkTypeResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetSdkType">REST API Reference for GetSdkType Operation</seealso>
        GetSdkTypeResponse EndGetSdkType(IAsyncResult asyncResult);

        #endregion
        
        #region  GetSdkTypes


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSdkTypes service method.</param>
        /// 
        /// <returns>The response from the GetSdkTypes service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetSdkTypes">REST API Reference for GetSdkTypes Operation</seealso>
        GetSdkTypesResponse GetSdkTypes(GetSdkTypesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetSdkTypes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSdkTypes operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSdkTypes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetSdkTypes">REST API Reference for GetSdkTypes Operation</seealso>
        IAsyncResult BeginGetSdkTypes(GetSdkTypesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetSdkTypes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSdkTypes.</param>
        /// 
        /// <returns>Returns a  GetSdkTypesResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetSdkTypes">REST API Reference for GetSdkTypes Operation</seealso>
        GetSdkTypesResponse EndGetSdkTypes(IAsyncResult asyncResult);

        #endregion
        
        #region  GetStage


        /// <summary>
        /// Gets information about a <a>Stage</a> resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetStage service method.</param>
        /// 
        /// <returns>The response from the GetStage service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetStage">REST API Reference for GetStage Operation</seealso>
        GetStageResponse GetStage(GetStageRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetStage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetStage operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetStage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetStage">REST API Reference for GetStage Operation</seealso>
        IAsyncResult BeginGetStage(GetStageRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetStage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetStage.</param>
        /// 
        /// <returns>Returns a  GetStageResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetStage">REST API Reference for GetStage Operation</seealso>
        GetStageResponse EndGetStage(IAsyncResult asyncResult);

        #endregion
        
        #region  GetStages


        /// <summary>
        /// Gets information about one or more <a>Stage</a> resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetStages service method.</param>
        /// 
        /// <returns>The response from the GetStages service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetStages">REST API Reference for GetStages Operation</seealso>
        GetStagesResponse GetStages(GetStagesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetStages operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetStages operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetStages
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetStages">REST API Reference for GetStages Operation</seealso>
        IAsyncResult BeginGetStages(GetStagesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetStages operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetStages.</param>
        /// 
        /// <returns>Returns a  GetStagesResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetStages">REST API Reference for GetStages Operation</seealso>
        GetStagesResponse EndGetStages(IAsyncResult asyncResult);

        #endregion
        
        #region  GetTags


        /// <summary>
        /// Gets the <a>Tags</a> collection for a given resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTags service method.</param>
        /// 
        /// <returns>The response from the GetTags service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// The request exceeded the rate limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetTags">REST API Reference for GetTags Operation</seealso>
        GetTagsResponse GetTags(GetTagsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTags operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTags
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetTags">REST API Reference for GetTags Operation</seealso>
        IAsyncResult BeginGetTags(GetTagsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetTags operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTags.</param>
        /// 
        /// <returns>Returns a  GetTagsResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetTags">REST API Reference for GetTags Operation</seealso>
        GetTagsResponse EndGetTags(IAsyncResult asyncResult);

        #endregion
        
        #region  GetUsage


        /// <summary>
        /// Gets the usage data of a usage plan in a specified time interval.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUsage service method.</param>
        /// 
        /// <returns>The response from the GetUsage service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetUsage">REST API Reference for GetUsage Operation</seealso>
        GetUsageResponse GetUsage(GetUsageRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetUsage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetUsage operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetUsage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetUsage">REST API Reference for GetUsage Operation</seealso>
        IAsyncResult BeginGetUsage(GetUsageRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetUsage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetUsage.</param>
        /// 
        /// <returns>Returns a  GetUsageResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetUsage">REST API Reference for GetUsage Operation</seealso>
        GetUsageResponse EndGetUsage(IAsyncResult asyncResult);

        #endregion
        
        #region  GetUsagePlan


        /// <summary>
        /// Gets a usage plan of a given plan identifier.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUsagePlan service method.</param>
        /// 
        /// <returns>The response from the GetUsagePlan service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetUsagePlan">REST API Reference for GetUsagePlan Operation</seealso>
        GetUsagePlanResponse GetUsagePlan(GetUsagePlanRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetUsagePlan operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetUsagePlan operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetUsagePlan
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetUsagePlan">REST API Reference for GetUsagePlan Operation</seealso>
        IAsyncResult BeginGetUsagePlan(GetUsagePlanRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetUsagePlan operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetUsagePlan.</param>
        /// 
        /// <returns>Returns a  GetUsagePlanResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetUsagePlan">REST API Reference for GetUsagePlan Operation</seealso>
        GetUsagePlanResponse EndGetUsagePlan(IAsyncResult asyncResult);

        #endregion
        
        #region  GetUsagePlanKey


        /// <summary>
        /// Gets a usage plan key of a given key identifier.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUsagePlanKey service method.</param>
        /// 
        /// <returns>The response from the GetUsagePlanKey service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetUsagePlanKey">REST API Reference for GetUsagePlanKey Operation</seealso>
        GetUsagePlanKeyResponse GetUsagePlanKey(GetUsagePlanKeyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetUsagePlanKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetUsagePlanKey operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetUsagePlanKey
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetUsagePlanKey">REST API Reference for GetUsagePlanKey Operation</seealso>
        IAsyncResult BeginGetUsagePlanKey(GetUsagePlanKeyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetUsagePlanKey operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetUsagePlanKey.</param>
        /// 
        /// <returns>Returns a  GetUsagePlanKeyResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetUsagePlanKey">REST API Reference for GetUsagePlanKey Operation</seealso>
        GetUsagePlanKeyResponse EndGetUsagePlanKey(IAsyncResult asyncResult);

        #endregion
        
        #region  GetUsagePlanKeys


        /// <summary>
        /// Gets all the usage plan keys representing the API keys added to a specified usage
        /// plan.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUsagePlanKeys service method.</param>
        /// 
        /// <returns>The response from the GetUsagePlanKeys service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetUsagePlanKeys">REST API Reference for GetUsagePlanKeys Operation</seealso>
        GetUsagePlanKeysResponse GetUsagePlanKeys(GetUsagePlanKeysRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetUsagePlanKeys operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetUsagePlanKeys operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetUsagePlanKeys
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetUsagePlanKeys">REST API Reference for GetUsagePlanKeys Operation</seealso>
        IAsyncResult BeginGetUsagePlanKeys(GetUsagePlanKeysRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetUsagePlanKeys operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetUsagePlanKeys.</param>
        /// 
        /// <returns>Returns a  GetUsagePlanKeysResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetUsagePlanKeys">REST API Reference for GetUsagePlanKeys Operation</seealso>
        GetUsagePlanKeysResponse EndGetUsagePlanKeys(IAsyncResult asyncResult);

        #endregion
        
        #region  GetUsagePlans


        /// <summary>
        /// Gets all the usage plans of the caller's account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUsagePlans service method.</param>
        /// 
        /// <returns>The response from the GetUsagePlans service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetUsagePlans">REST API Reference for GetUsagePlans Operation</seealso>
        GetUsagePlansResponse GetUsagePlans(GetUsagePlansRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetUsagePlans operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetUsagePlans operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetUsagePlans
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetUsagePlans">REST API Reference for GetUsagePlans Operation</seealso>
        IAsyncResult BeginGetUsagePlans(GetUsagePlansRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetUsagePlans operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetUsagePlans.</param>
        /// 
        /// <returns>Returns a  GetUsagePlansResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetUsagePlans">REST API Reference for GetUsagePlans Operation</seealso>
        GetUsagePlansResponse EndGetUsagePlans(IAsyncResult asyncResult);

        #endregion
        
        #region  GetVpcLink


        /// <summary>
        /// Gets a specified VPC link under the caller's account in a region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVpcLink service method.</param>
        /// 
        /// <returns>The response from the GetVpcLink service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetVpcLink">REST API Reference for GetVpcLink Operation</seealso>
        GetVpcLinkResponse GetVpcLink(GetVpcLinkRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetVpcLink operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetVpcLink operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetVpcLink
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetVpcLink">REST API Reference for GetVpcLink Operation</seealso>
        IAsyncResult BeginGetVpcLink(GetVpcLinkRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetVpcLink operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetVpcLink.</param>
        /// 
        /// <returns>Returns a  GetVpcLinkResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetVpcLink">REST API Reference for GetVpcLink Operation</seealso>
        GetVpcLinkResponse EndGetVpcLink(IAsyncResult asyncResult);

        #endregion
        
        #region  GetVpcLinks


        /// <summary>
        /// Gets the <a>VpcLinks</a> collection under the caller's account in a selected region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVpcLinks service method.</param>
        /// 
        /// <returns>The response from the GetVpcLinks service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetVpcLinks">REST API Reference for GetVpcLinks Operation</seealso>
        GetVpcLinksResponse GetVpcLinks(GetVpcLinksRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetVpcLinks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetVpcLinks operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetVpcLinks
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetVpcLinks">REST API Reference for GetVpcLinks Operation</seealso>
        IAsyncResult BeginGetVpcLinks(GetVpcLinksRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetVpcLinks operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetVpcLinks.</param>
        /// 
        /// <returns>Returns a  GetVpcLinksResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetVpcLinks">REST API Reference for GetVpcLinks Operation</seealso>
        GetVpcLinksResponse EndGetVpcLinks(IAsyncResult asyncResult);

        #endregion
        
        #region  ImportApiKeys


        /// <summary>
        /// Import API keys from an external source, such as a CSV-formatted file.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportApiKeys service method.</param>
        /// 
        /// <returns>The response from the ImportApiKeys service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// The request exceeded the rate limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/ImportApiKeys">REST API Reference for ImportApiKeys Operation</seealso>
        ImportApiKeysResponse ImportApiKeys(ImportApiKeysRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ImportApiKeys operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ImportApiKeys operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndImportApiKeys
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/ImportApiKeys">REST API Reference for ImportApiKeys Operation</seealso>
        IAsyncResult BeginImportApiKeys(ImportApiKeysRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ImportApiKeys operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginImportApiKeys.</param>
        /// 
        /// <returns>Returns a  ImportApiKeysResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/ImportApiKeys">REST API Reference for ImportApiKeys Operation</seealso>
        ImportApiKeysResponse EndImportApiKeys(IAsyncResult asyncResult);

        #endregion
        
        #region  ImportDocumentationParts


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportDocumentationParts service method.</param>
        /// 
        /// <returns>The response from the ImportDocumentationParts service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// The request exceeded the rate limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/ImportDocumentationParts">REST API Reference for ImportDocumentationParts Operation</seealso>
        ImportDocumentationPartsResponse ImportDocumentationParts(ImportDocumentationPartsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ImportDocumentationParts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ImportDocumentationParts operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndImportDocumentationParts
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/ImportDocumentationParts">REST API Reference for ImportDocumentationParts Operation</seealso>
        IAsyncResult BeginImportDocumentationParts(ImportDocumentationPartsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ImportDocumentationParts operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginImportDocumentationParts.</param>
        /// 
        /// <returns>Returns a  ImportDocumentationPartsResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/ImportDocumentationParts">REST API Reference for ImportDocumentationParts Operation</seealso>
        ImportDocumentationPartsResponse EndImportDocumentationParts(IAsyncResult asyncResult);

        #endregion
        
        #region  ImportRestApi


        /// <summary>
        /// A feature of the API Gateway control service for creating a new API from an external
        /// API definition file.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportRestApi service method.</param>
        /// 
        /// <returns>The response from the ImportRestApi service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// The request exceeded the rate limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/ImportRestApi">REST API Reference for ImportRestApi Operation</seealso>
        ImportRestApiResponse ImportRestApi(ImportRestApiRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ImportRestApi operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ImportRestApi operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndImportRestApi
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/ImportRestApi">REST API Reference for ImportRestApi Operation</seealso>
        IAsyncResult BeginImportRestApi(ImportRestApiRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ImportRestApi operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginImportRestApi.</param>
        /// 
        /// <returns>Returns a  ImportRestApiResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/ImportRestApi">REST API Reference for ImportRestApi Operation</seealso>
        ImportRestApiResponse EndImportRestApi(IAsyncResult asyncResult);

        #endregion
        
        #region  PutGatewayResponse


        /// <summary>
        /// Creates a customization of a <a>GatewayResponse</a> of a specified response type and
        /// status code on the given <a>RestApi</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutGatewayResponse service method.</param>
        /// 
        /// <returns>The response from the PutGatewayResponse service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// The request exceeded the rate limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/PutGatewayResponse">REST API Reference for PutGatewayResponse Operation</seealso>
        PutGatewayResponseResponse PutGatewayResponse(PutGatewayResponseRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutGatewayResponse operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutGatewayResponse operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutGatewayResponse
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/PutGatewayResponse">REST API Reference for PutGatewayResponse Operation</seealso>
        IAsyncResult BeginPutGatewayResponse(PutGatewayResponseRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutGatewayResponse operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutGatewayResponse.</param>
        /// 
        /// <returns>Returns a  PutGatewayResponseResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/PutGatewayResponse">REST API Reference for PutGatewayResponse Operation</seealso>
        PutGatewayResponseResponse EndPutGatewayResponse(IAsyncResult asyncResult);

        #endregion
        
        #region  PutIntegration


        /// <summary>
        /// Sets up a method's integration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutIntegration service method.</param>
        /// 
        /// <returns>The response from the PutIntegration service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/PutIntegration">REST API Reference for PutIntegration Operation</seealso>
        PutIntegrationResponse PutIntegration(PutIntegrationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutIntegration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutIntegration operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutIntegration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/PutIntegration">REST API Reference for PutIntegration Operation</seealso>
        IAsyncResult BeginPutIntegration(PutIntegrationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutIntegration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutIntegration.</param>
        /// 
        /// <returns>Returns a  PutIntegrationResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/PutIntegration">REST API Reference for PutIntegration Operation</seealso>
        PutIntegrationResponse EndPutIntegration(IAsyncResult asyncResult);

        #endregion
        
        #region  PutIntegrationResponse


        /// <summary>
        /// Represents a put integration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutIntegrationResponse service method.</param>
        /// 
        /// <returns>The response from the PutIntegrationResponse service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// The request exceeded the rate limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/PutIntegrationResponse">REST API Reference for PutIntegrationResponse Operation</seealso>
        PutIntegrationResponseResponse PutIntegrationResponse(PutIntegrationResponseRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutIntegrationResponse operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutIntegrationResponse operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutIntegrationResponse
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/PutIntegrationResponse">REST API Reference for PutIntegrationResponse Operation</seealso>
        IAsyncResult BeginPutIntegrationResponse(PutIntegrationResponseRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutIntegrationResponse operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutIntegrationResponse.</param>
        /// 
        /// <returns>Returns a  PutIntegrationResponseResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/PutIntegrationResponse">REST API Reference for PutIntegrationResponse Operation</seealso>
        PutIntegrationResponseResponse EndPutIntegrationResponse(IAsyncResult asyncResult);

        #endregion
        
        #region  PutMethod


        /// <summary>
        /// Add a method to an existing <a>Resource</a> resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutMethod service method.</param>
        /// 
        /// <returns>The response from the PutMethod service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// The request exceeded the rate limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/PutMethod">REST API Reference for PutMethod Operation</seealso>
        PutMethodResponse PutMethod(PutMethodRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutMethod operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutMethod operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutMethod
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/PutMethod">REST API Reference for PutMethod Operation</seealso>
        IAsyncResult BeginPutMethod(PutMethodRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutMethod operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutMethod.</param>
        /// 
        /// <returns>Returns a  PutMethodResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/PutMethod">REST API Reference for PutMethod Operation</seealso>
        PutMethodResponse EndPutMethod(IAsyncResult asyncResult);

        #endregion
        
        #region  PutMethodResponse


        /// <summary>
        /// Adds a <a>MethodResponse</a> to an existing <a>Method</a> resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutMethodResponse service method.</param>
        /// 
        /// <returns>The response from the PutMethodResponse service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// The request exceeded the rate limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/PutMethodResponse">REST API Reference for PutMethodResponse Operation</seealso>
        PutMethodResponseResponse PutMethodResponse(PutMethodResponseRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutMethodResponse operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutMethodResponse operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutMethodResponse
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/PutMethodResponse">REST API Reference for PutMethodResponse Operation</seealso>
        IAsyncResult BeginPutMethodResponse(PutMethodResponseRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutMethodResponse operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutMethodResponse.</param>
        /// 
        /// <returns>Returns a  PutMethodResponseResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/PutMethodResponse">REST API Reference for PutMethodResponse Operation</seealso>
        PutMethodResponseResponse EndPutMethodResponse(IAsyncResult asyncResult);

        #endregion
        
        #region  PutRestApi


        /// <summary>
        /// A feature of the API Gateway control service for updating an existing API with an
        /// input of external API definitions. The update can take the form of merging the supplied
        /// definition into the existing API or overwriting the existing API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutRestApi service method.</param>
        /// 
        /// <returns>The response from the PutRestApi service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// The request exceeded the rate limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/PutRestApi">REST API Reference for PutRestApi Operation</seealso>
        PutRestApiResponse PutRestApi(PutRestApiRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutRestApi operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutRestApi operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutRestApi
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/PutRestApi">REST API Reference for PutRestApi Operation</seealso>
        IAsyncResult BeginPutRestApi(PutRestApiRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutRestApi operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutRestApi.</param>
        /// 
        /// <returns>Returns a  PutRestApiResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/PutRestApi">REST API Reference for PutRestApi Operation</seealso>
        PutRestApiResponse EndPutRestApi(IAsyncResult asyncResult);

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Adds or updates a tag on a given resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// The request exceeded the rate limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  TestInvokeAuthorizer


        /// <summary>
        /// Simulate the execution of an <a>Authorizer</a> in your <a>RestApi</a> with headers,
        /// parameters, and an incoming request body.
        /// 
        ///  <div class="seeAlso"> <a href="https://docs.aws.amazon.com/apigateway/latest/developerguide/apigateway-use-lambda-authorizer.html">Use
        /// Lambda Function as Authorizer</a> <a href="https://docs.aws.amazon.com/apigateway/latest/developerguide/apigateway-integrate-with-cognito.html">Use
        /// Cognito User Pool as Authorizer</a> </div>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TestInvokeAuthorizer service method.</param>
        /// 
        /// <returns>The response from the TestInvokeAuthorizer service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/TestInvokeAuthorizer">REST API Reference for TestInvokeAuthorizer Operation</seealso>
        TestInvokeAuthorizerResponse TestInvokeAuthorizer(TestInvokeAuthorizerRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TestInvokeAuthorizer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TestInvokeAuthorizer operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTestInvokeAuthorizer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/TestInvokeAuthorizer">REST API Reference for TestInvokeAuthorizer Operation</seealso>
        IAsyncResult BeginTestInvokeAuthorizer(TestInvokeAuthorizerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TestInvokeAuthorizer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTestInvokeAuthorizer.</param>
        /// 
        /// <returns>Returns a  TestInvokeAuthorizerResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/TestInvokeAuthorizer">REST API Reference for TestInvokeAuthorizer Operation</seealso>
        TestInvokeAuthorizerResponse EndTestInvokeAuthorizer(IAsyncResult asyncResult);

        #endregion
        
        #region  TestInvokeMethod


        /// <summary>
        /// Simulate the execution of a <a>Method</a> in your <a>RestApi</a> with headers, parameters,
        /// and an incoming request body.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TestInvokeMethod service method.</param>
        /// 
        /// <returns>The response from the TestInvokeMethod service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/TestInvokeMethod">REST API Reference for TestInvokeMethod Operation</seealso>
        TestInvokeMethodResponse TestInvokeMethod(TestInvokeMethodRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TestInvokeMethod operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TestInvokeMethod operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTestInvokeMethod
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/TestInvokeMethod">REST API Reference for TestInvokeMethod Operation</seealso>
        IAsyncResult BeginTestInvokeMethod(TestInvokeMethodRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TestInvokeMethod operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTestInvokeMethod.</param>
        /// 
        /// <returns>Returns a  TestInvokeMethodResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/TestInvokeMethod">REST API Reference for TestInvokeMethod Operation</seealso>
        TestInvokeMethodResponse EndTestInvokeMethod(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes a tag from a given resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateAccount


        /// <summary>
        /// Changes information about the current <a>Account</a> resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccount service method.</param>
        /// 
        /// <returns>The response from the UpdateAccount service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateAccount">REST API Reference for UpdateAccount Operation</seealso>
        UpdateAccountResponse UpdateAccount(UpdateAccountRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccount operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAccount
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateAccount">REST API Reference for UpdateAccount Operation</seealso>
        IAsyncResult BeginUpdateAccount(UpdateAccountRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAccount operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAccount.</param>
        /// 
        /// <returns>Returns a  UpdateAccountResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateAccount">REST API Reference for UpdateAccount Operation</seealso>
        UpdateAccountResponse EndUpdateAccount(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateApiKey


        /// <summary>
        /// Changes information about an <a>ApiKey</a> resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApiKey service method.</param>
        /// 
        /// <returns>The response from the UpdateApiKey service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateApiKey">REST API Reference for UpdateApiKey Operation</seealso>
        UpdateApiKeyResponse UpdateApiKey(UpdateApiKeyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateApiKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateApiKey operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateApiKey
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateApiKey">REST API Reference for UpdateApiKey Operation</seealso>
        IAsyncResult BeginUpdateApiKey(UpdateApiKeyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateApiKey operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateApiKey.</param>
        /// 
        /// <returns>Returns a  UpdateApiKeyResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateApiKey">REST API Reference for UpdateApiKey Operation</seealso>
        UpdateApiKeyResponse EndUpdateApiKey(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateAuthorizer


        /// <summary>
        /// Updates an existing <a>Authorizer</a> resource.
        /// 
        ///  <div class="seeAlso"><a href="https://docs.aws.amazon.com/cli/latest/reference/apigateway/update-authorizer.html">AWS
        /// CLI</a></div>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAuthorizer service method.</param>
        /// 
        /// <returns>The response from the UpdateAuthorizer service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateAuthorizer">REST API Reference for UpdateAuthorizer Operation</seealso>
        UpdateAuthorizerResponse UpdateAuthorizer(UpdateAuthorizerRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAuthorizer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAuthorizer operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAuthorizer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateAuthorizer">REST API Reference for UpdateAuthorizer Operation</seealso>
        IAsyncResult BeginUpdateAuthorizer(UpdateAuthorizerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAuthorizer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAuthorizer.</param>
        /// 
        /// <returns>Returns a  UpdateAuthorizerResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateAuthorizer">REST API Reference for UpdateAuthorizer Operation</seealso>
        UpdateAuthorizerResponse EndUpdateAuthorizer(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateBasePathMapping


        /// <summary>
        /// Changes information about the <a>BasePathMapping</a> resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBasePathMapping service method.</param>
        /// 
        /// <returns>The response from the UpdateBasePathMapping service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateBasePathMapping">REST API Reference for UpdateBasePathMapping Operation</seealso>
        UpdateBasePathMappingResponse UpdateBasePathMapping(UpdateBasePathMappingRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateBasePathMapping operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateBasePathMapping operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateBasePathMapping
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateBasePathMapping">REST API Reference for UpdateBasePathMapping Operation</seealso>
        IAsyncResult BeginUpdateBasePathMapping(UpdateBasePathMappingRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateBasePathMapping operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateBasePathMapping.</param>
        /// 
        /// <returns>Returns a  UpdateBasePathMappingResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateBasePathMapping">REST API Reference for UpdateBasePathMapping Operation</seealso>
        UpdateBasePathMappingResponse EndUpdateBasePathMapping(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateClientCertificate


        /// <summary>
        /// Changes information about an <a>ClientCertificate</a> resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateClientCertificate service method.</param>
        /// 
        /// <returns>The response from the UpdateClientCertificate service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateClientCertificate">REST API Reference for UpdateClientCertificate Operation</seealso>
        UpdateClientCertificateResponse UpdateClientCertificate(UpdateClientCertificateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateClientCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateClientCertificate operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateClientCertificate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateClientCertificate">REST API Reference for UpdateClientCertificate Operation</seealso>
        IAsyncResult BeginUpdateClientCertificate(UpdateClientCertificateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateClientCertificate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateClientCertificate.</param>
        /// 
        /// <returns>Returns a  UpdateClientCertificateResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateClientCertificate">REST API Reference for UpdateClientCertificate Operation</seealso>
        UpdateClientCertificateResponse EndUpdateClientCertificate(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateDeployment


        /// <summary>
        /// Changes information about a <a>Deployment</a> resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDeployment service method.</param>
        /// 
        /// <returns>The response from the UpdateDeployment service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ServiceUnavailableException">
        /// The requested service is not available. For details see the accompanying error message.
        /// Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateDeployment">REST API Reference for UpdateDeployment Operation</seealso>
        UpdateDeploymentResponse UpdateDeployment(UpdateDeploymentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDeployment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDeployment operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDeployment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateDeployment">REST API Reference for UpdateDeployment Operation</seealso>
        IAsyncResult BeginUpdateDeployment(UpdateDeploymentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDeployment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDeployment.</param>
        /// 
        /// <returns>Returns a  UpdateDeploymentResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateDeployment">REST API Reference for UpdateDeployment Operation</seealso>
        UpdateDeploymentResponse EndUpdateDeployment(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateDocumentationPart


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDocumentationPart service method.</param>
        /// 
        /// <returns>The response from the UpdateDocumentationPart service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// The request exceeded the rate limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateDocumentationPart">REST API Reference for UpdateDocumentationPart Operation</seealso>
        UpdateDocumentationPartResponse UpdateDocumentationPart(UpdateDocumentationPartRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDocumentationPart operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDocumentationPart operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDocumentationPart
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateDocumentationPart">REST API Reference for UpdateDocumentationPart Operation</seealso>
        IAsyncResult BeginUpdateDocumentationPart(UpdateDocumentationPartRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDocumentationPart operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDocumentationPart.</param>
        /// 
        /// <returns>Returns a  UpdateDocumentationPartResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateDocumentationPart">REST API Reference for UpdateDocumentationPart Operation</seealso>
        UpdateDocumentationPartResponse EndUpdateDocumentationPart(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateDocumentationVersion


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDocumentationVersion service method.</param>
        /// 
        /// <returns>The response from the UpdateDocumentationVersion service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateDocumentationVersion">REST API Reference for UpdateDocumentationVersion Operation</seealso>
        UpdateDocumentationVersionResponse UpdateDocumentationVersion(UpdateDocumentationVersionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDocumentationVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDocumentationVersion operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDocumentationVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateDocumentationVersion">REST API Reference for UpdateDocumentationVersion Operation</seealso>
        IAsyncResult BeginUpdateDocumentationVersion(UpdateDocumentationVersionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDocumentationVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDocumentationVersion.</param>
        /// 
        /// <returns>Returns a  UpdateDocumentationVersionResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateDocumentationVersion">REST API Reference for UpdateDocumentationVersion Operation</seealso>
        UpdateDocumentationVersionResponse EndUpdateDocumentationVersion(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateDomainName


        /// <summary>
        /// Changes information about the <a>DomainName</a> resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDomainName service method.</param>
        /// 
        /// <returns>The response from the UpdateDomainName service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateDomainName">REST API Reference for UpdateDomainName Operation</seealso>
        UpdateDomainNameResponse UpdateDomainName(UpdateDomainNameRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDomainName operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDomainName operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDomainName
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateDomainName">REST API Reference for UpdateDomainName Operation</seealso>
        IAsyncResult BeginUpdateDomainName(UpdateDomainNameRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDomainName operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDomainName.</param>
        /// 
        /// <returns>Returns a  UpdateDomainNameResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateDomainName">REST API Reference for UpdateDomainName Operation</seealso>
        UpdateDomainNameResponse EndUpdateDomainName(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateGatewayResponse


        /// <summary>
        /// Updates a <a>GatewayResponse</a> of a specified response type on the given <a>RestApi</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGatewayResponse service method.</param>
        /// 
        /// <returns>The response from the UpdateGatewayResponse service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateGatewayResponse">REST API Reference for UpdateGatewayResponse Operation</seealso>
        UpdateGatewayResponseResponse UpdateGatewayResponse(UpdateGatewayResponseRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateGatewayResponse operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateGatewayResponse operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateGatewayResponse
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateGatewayResponse">REST API Reference for UpdateGatewayResponse Operation</seealso>
        IAsyncResult BeginUpdateGatewayResponse(UpdateGatewayResponseRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateGatewayResponse operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateGatewayResponse.</param>
        /// 
        /// <returns>Returns a  UpdateGatewayResponseResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateGatewayResponse">REST API Reference for UpdateGatewayResponse Operation</seealso>
        UpdateGatewayResponseResponse EndUpdateGatewayResponse(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateIntegration


        /// <summary>
        /// Represents an update integration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateIntegration service method.</param>
        /// 
        /// <returns>The response from the UpdateIntegration service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateIntegration">REST API Reference for UpdateIntegration Operation</seealso>
        UpdateIntegrationResponse UpdateIntegration(UpdateIntegrationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateIntegration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateIntegration operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateIntegration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateIntegration">REST API Reference for UpdateIntegration Operation</seealso>
        IAsyncResult BeginUpdateIntegration(UpdateIntegrationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateIntegration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateIntegration.</param>
        /// 
        /// <returns>Returns a  UpdateIntegrationResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateIntegration">REST API Reference for UpdateIntegration Operation</seealso>
        UpdateIntegrationResponse EndUpdateIntegration(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateIntegrationResponse


        /// <summary>
        /// Represents an update integration response.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateIntegrationResponse service method.</param>
        /// 
        /// <returns>The response from the UpdateIntegrationResponse service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateIntegrationResponse">REST API Reference for UpdateIntegrationResponse Operation</seealso>
        UpdateIntegrationResponseResponse UpdateIntegrationResponse(UpdateIntegrationResponseRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateIntegrationResponse operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateIntegrationResponse operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateIntegrationResponse
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateIntegrationResponse">REST API Reference for UpdateIntegrationResponse Operation</seealso>
        IAsyncResult BeginUpdateIntegrationResponse(UpdateIntegrationResponseRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateIntegrationResponse operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateIntegrationResponse.</param>
        /// 
        /// <returns>Returns a  UpdateIntegrationResponseResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateIntegrationResponse">REST API Reference for UpdateIntegrationResponse Operation</seealso>
        UpdateIntegrationResponseResponse EndUpdateIntegrationResponse(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateMethod


        /// <summary>
        /// Updates an existing <a>Method</a> resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMethod service method.</param>
        /// 
        /// <returns>The response from the UpdateMethod service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateMethod">REST API Reference for UpdateMethod Operation</seealso>
        UpdateMethodResponse UpdateMethod(UpdateMethodRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateMethod operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateMethod operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateMethod
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateMethod">REST API Reference for UpdateMethod Operation</seealso>
        IAsyncResult BeginUpdateMethod(UpdateMethodRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateMethod operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateMethod.</param>
        /// 
        /// <returns>Returns a  UpdateMethodResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateMethod">REST API Reference for UpdateMethod Operation</seealso>
        UpdateMethodResponse EndUpdateMethod(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateMethodResponse


        /// <summary>
        /// Updates an existing <a>MethodResponse</a> resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMethodResponse service method.</param>
        /// 
        /// <returns>The response from the UpdateMethodResponse service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// The request exceeded the rate limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateMethodResponse">REST API Reference for UpdateMethodResponse Operation</seealso>
        UpdateMethodResponseResponse UpdateMethodResponse(UpdateMethodResponseRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateMethodResponse operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateMethodResponse operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateMethodResponse
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateMethodResponse">REST API Reference for UpdateMethodResponse Operation</seealso>
        IAsyncResult BeginUpdateMethodResponse(UpdateMethodResponseRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateMethodResponse operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateMethodResponse.</param>
        /// 
        /// <returns>Returns a  UpdateMethodResponseResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateMethodResponse">REST API Reference for UpdateMethodResponse Operation</seealso>
        UpdateMethodResponseResponse EndUpdateMethodResponse(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateModel


        /// <summary>
        /// Changes information about a model.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateModel service method.</param>
        /// 
        /// <returns>The response from the UpdateModel service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateModel">REST API Reference for UpdateModel Operation</seealso>
        UpdateModelResponse UpdateModel(UpdateModelRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateModel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateModel operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateModel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateModel">REST API Reference for UpdateModel Operation</seealso>
        IAsyncResult BeginUpdateModel(UpdateModelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateModel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateModel.</param>
        /// 
        /// <returns>Returns a  UpdateModelResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateModel">REST API Reference for UpdateModel Operation</seealso>
        UpdateModelResponse EndUpdateModel(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateRequestValidator


        /// <summary>
        /// Updates a <a>RequestValidator</a> of a given <a>RestApi</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRequestValidator service method.</param>
        /// 
        /// <returns>The response from the UpdateRequestValidator service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateRequestValidator">REST API Reference for UpdateRequestValidator Operation</seealso>
        UpdateRequestValidatorResponse UpdateRequestValidator(UpdateRequestValidatorRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateRequestValidator operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateRequestValidator operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateRequestValidator
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateRequestValidator">REST API Reference for UpdateRequestValidator Operation</seealso>
        IAsyncResult BeginUpdateRequestValidator(UpdateRequestValidatorRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateRequestValidator operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateRequestValidator.</param>
        /// 
        /// <returns>Returns a  UpdateRequestValidatorResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateRequestValidator">REST API Reference for UpdateRequestValidator Operation</seealso>
        UpdateRequestValidatorResponse EndUpdateRequestValidator(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateResource


        /// <summary>
        /// Changes information about a <a>Resource</a> resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateResource service method.</param>
        /// 
        /// <returns>The response from the UpdateResource service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateResource">REST API Reference for UpdateResource Operation</seealso>
        UpdateResourceResponse UpdateResource(UpdateResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateResource operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateResource">REST API Reference for UpdateResource Operation</seealso>
        IAsyncResult BeginUpdateResource(UpdateResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateResource.</param>
        /// 
        /// <returns>Returns a  UpdateResourceResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateResource">REST API Reference for UpdateResource Operation</seealso>
        UpdateResourceResponse EndUpdateResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateRestApi


        /// <summary>
        /// Changes information about the specified API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRestApi service method.</param>
        /// 
        /// <returns>The response from the UpdateRestApi service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateRestApi">REST API Reference for UpdateRestApi Operation</seealso>
        UpdateRestApiResponse UpdateRestApi(UpdateRestApiRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateRestApi operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateRestApi operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateRestApi
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateRestApi">REST API Reference for UpdateRestApi Operation</seealso>
        IAsyncResult BeginUpdateRestApi(UpdateRestApiRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateRestApi operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateRestApi.</param>
        /// 
        /// <returns>Returns a  UpdateRestApiResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateRestApi">REST API Reference for UpdateRestApi Operation</seealso>
        UpdateRestApiResponse EndUpdateRestApi(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateStage


        /// <summary>
        /// Changes information about a <a>Stage</a> resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateStage service method.</param>
        /// 
        /// <returns>The response from the UpdateStage service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateStage">REST API Reference for UpdateStage Operation</seealso>
        UpdateStageResponse UpdateStage(UpdateStageRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateStage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateStage operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateStage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateStage">REST API Reference for UpdateStage Operation</seealso>
        IAsyncResult BeginUpdateStage(UpdateStageRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateStage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateStage.</param>
        /// 
        /// <returns>Returns a  UpdateStageResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateStage">REST API Reference for UpdateStage Operation</seealso>
        UpdateStageResponse EndUpdateStage(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateUsage


        /// <summary>
        /// Grants a temporary extension to the remaining quota of a usage plan associated with
        /// a specified API key.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateUsage service method.</param>
        /// 
        /// <returns>The response from the UpdateUsage service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateUsage">REST API Reference for UpdateUsage Operation</seealso>
        UpdateUsageResponse UpdateUsage(UpdateUsageRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateUsage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateUsage operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateUsage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateUsage">REST API Reference for UpdateUsage Operation</seealso>
        IAsyncResult BeginUpdateUsage(UpdateUsageRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateUsage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateUsage.</param>
        /// 
        /// <returns>Returns a  UpdateUsageResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateUsage">REST API Reference for UpdateUsage Operation</seealso>
        UpdateUsageResponse EndUpdateUsage(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateUsagePlan


        /// <summary>
        /// Updates a usage plan of a given plan Id.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateUsagePlan service method.</param>
        /// 
        /// <returns>The response from the UpdateUsagePlan service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateUsagePlan">REST API Reference for UpdateUsagePlan Operation</seealso>
        UpdateUsagePlanResponse UpdateUsagePlan(UpdateUsagePlanRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateUsagePlan operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateUsagePlan operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateUsagePlan
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateUsagePlan">REST API Reference for UpdateUsagePlan Operation</seealso>
        IAsyncResult BeginUpdateUsagePlan(UpdateUsagePlanRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateUsagePlan operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateUsagePlan.</param>
        /// 
        /// <returns>Returns a  UpdateUsagePlanResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateUsagePlan">REST API Reference for UpdateUsagePlan Operation</seealso>
        UpdateUsagePlanResponse EndUpdateUsagePlan(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateVpcLink


        /// <summary>
        /// Updates an existing <a>VpcLink</a> of a specified identifier.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateVpcLink service method.</param>
        /// 
        /// <returns>The response from the UpdateVpcLink service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateVpcLink">REST API Reference for UpdateVpcLink Operation</seealso>
        UpdateVpcLinkResponse UpdateVpcLink(UpdateVpcLinkRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateVpcLink operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateVpcLink operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateVpcLink
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateVpcLink">REST API Reference for UpdateVpcLink Operation</seealso>
        IAsyncResult BeginUpdateVpcLink(UpdateVpcLinkRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateVpcLink operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateVpcLink.</param>
        /// 
        /// <returns>Returns a  UpdateVpcLinkResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateVpcLink">REST API Reference for UpdateVpcLink Operation</seealso>
        UpdateVpcLinkResponse EndUpdateVpcLink(IAsyncResult asyncResult);

        #endregion
        
    }
}