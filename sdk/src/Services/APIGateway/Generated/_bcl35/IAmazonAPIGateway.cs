/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.APIGateway.Model;

namespace Amazon.APIGateway
{
    /// <summary>
    /// Interface for accessing APIGateway
    ///
    /// Amazon API Gateway 
    /// <para>
    /// Amazon API Gateway helps developers deliver robust, secure, and scalable mobile and
    /// web application back ends. Amazon API Gateway allows developers to securely connect
    /// mobile and web applications to APIs that run on AWS Lambda, Amazon EC2, or other publicly
    /// addressable web services that are hosted outside of AWS.
    /// </para>
    /// </summary>
    public partial interface IAmazonAPIGateway : IDisposable
    {

        
        #region  CreateApiKey


        /// <summary>
        /// Create an <a>ApiKey</a> resource. 
        /// 
        ///  <div class="seeAlso"><a href="http://docs.aws.amazon.com/cli/latest/reference/apigateway/create-api-key.html">AWS
        /// CLI</a></div>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateApiKey service method.</param>
        /// 
        /// <returns>The response from the CreateApiKey service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
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
        IAsyncResult BeginCreateApiKey(CreateApiKeyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateApiKey operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateApiKey.</param>
        /// 
        /// <returns>Returns a  CreateApiKeyResult from APIGateway.</returns>
        CreateApiKeyResponse EndCreateApiKey(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateAuthorizer


        /// <summary>
        /// Adds a new <a>Authorizer</a> resource to an existing <a>RestApi</a> resource.
        /// 
        ///  <div class="seeAlso"><a href="http://docs.aws.amazon.com/cli/latest/reference/apigateway/create-authorizer.html">AWS
        /// CLI</a></div>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAuthorizer service method.</param>
        /// 
        /// <returns>The response from the CreateAuthorizer service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
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
        IAsyncResult BeginCreateAuthorizer(CreateAuthorizerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAuthorizer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAuthorizer.</param>
        /// 
        /// <returns>Returns a  CreateAuthorizerResult from APIGateway.</returns>
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
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
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
        IAsyncResult BeginCreateBasePathMapping(CreateBasePathMappingRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateBasePathMapping operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateBasePathMapping.</param>
        /// 
        /// <returns>Returns a  CreateBasePathMappingResult from APIGateway.</returns>
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
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
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
        IAsyncResult BeginCreateDeployment(CreateDeploymentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDeployment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDeployment.</param>
        /// 
        /// <returns>Returns a  CreateDeploymentResult from APIGateway.</returns>
        CreateDeploymentResponse EndCreateDeployment(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateDomainName


        /// <summary>
        /// Creates a new domain name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDomainName service method.</param>
        /// 
        /// <returns>The response from the CreateDomainName service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
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
        IAsyncResult BeginCreateDomainName(CreateDomainNameRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDomainName operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDomainName.</param>
        /// 
        /// <returns>Returns a  CreateDomainNameResult from APIGateway.</returns>
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
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
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
        IAsyncResult BeginCreateModel(CreateModelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateModel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateModel.</param>
        /// 
        /// <returns>Returns a  CreateModelResult from APIGateway.</returns>
        CreateModelResponse EndCreateModel(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateResource


        /// <summary>
        /// Creates a <a>Resource</a> resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateResource service method.</param>
        /// 
        /// <returns>The response from the CreateResource service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
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
        IAsyncResult BeginCreateResource(CreateResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateResource.</param>
        /// 
        /// <returns>Returns a  CreateResourceResult from APIGateway.</returns>
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
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
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
        IAsyncResult BeginCreateRestApi(CreateRestApiRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateRestApi operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateRestApi.</param>
        /// 
        /// <returns>Returns a  CreateRestApiResult from APIGateway.</returns>
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
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
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
        IAsyncResult BeginCreateStage(CreateStageRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateStage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateStage.</param>
        /// 
        /// <returns>Returns a  CreateStageResult from APIGateway.</returns>
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
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
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
        IAsyncResult BeginCreateUsagePlan(CreateUsagePlanRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateUsagePlan operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateUsagePlan.</param>
        /// 
        /// <returns>Returns a  CreateUsagePlanResult from APIGateway.</returns>
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
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
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
        IAsyncResult BeginCreateUsagePlanKey(CreateUsagePlanKeyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateUsagePlanKey operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateUsagePlanKey.</param>
        /// 
        /// <returns>Returns a  CreateUsagePlanKeyResult from APIGateway.</returns>
        CreateUsagePlanKeyResponse EndCreateUsagePlanKey(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteApiKey


        /// <summary>
        /// Deletes the <a>ApiKey</a> resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApiKey service method.</param>
        /// 
        /// <returns>The response from the DeleteApiKey service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
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
        IAsyncResult BeginDeleteApiKey(DeleteApiKeyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteApiKey operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteApiKey.</param>
        /// 
        /// <returns>Returns a  DeleteApiKeyResult from APIGateway.</returns>
        DeleteApiKeyResponse EndDeleteApiKey(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteAuthorizer


        /// <summary>
        /// Deletes an existing <a>Authorizer</a> resource.
        /// 
        ///  <div class="seeAlso"><a href="http://docs.aws.amazon.com/cli/latest/reference/apigateway/delete-authorizer.html">AWS
        /// CLI</a></div>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAuthorizer service method.</param>
        /// 
        /// <returns>The response from the DeleteAuthorizer service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
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
        IAsyncResult BeginDeleteAuthorizer(DeleteAuthorizerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAuthorizer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAuthorizer.</param>
        /// 
        /// <returns>Returns a  DeleteAuthorizerResult from APIGateway.</returns>
        DeleteAuthorizerResponse EndDeleteAuthorizer(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteBasePathMapping


        /// <summary>
        /// Deletes the <a>BasePathMapping</a> resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBasePathMapping service method.</param>
        /// 
        /// <returns>The response from the DeleteBasePathMapping service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
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
        IAsyncResult BeginDeleteBasePathMapping(DeleteBasePathMappingRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteBasePathMapping operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteBasePathMapping.</param>
        /// 
        /// <returns>Returns a  DeleteBasePathMappingResult from APIGateway.</returns>
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
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
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
        IAsyncResult BeginDeleteClientCertificate(DeleteClientCertificateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteClientCertificate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteClientCertificate.</param>
        /// 
        /// <returns>Returns a  DeleteClientCertificateResult from APIGateway.</returns>
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
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
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
        IAsyncResult BeginDeleteDeployment(DeleteDeploymentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDeployment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDeployment.</param>
        /// 
        /// <returns>Returns a  DeleteDeploymentResult from APIGateway.</returns>
        DeleteDeploymentResponse EndDeleteDeployment(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteDomainName


        /// <summary>
        /// Deletes the <a>DomainName</a> resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDomainName service method.</param>
        /// 
        /// <returns>The response from the DeleteDomainName service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
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
        IAsyncResult BeginDeleteDomainName(DeleteDomainNameRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDomainName operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDomainName.</param>
        /// 
        /// <returns>Returns a  DeleteDomainNameResult from APIGateway.</returns>
        DeleteDomainNameResponse EndDeleteDomainName(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteIntegration


        /// <summary>
        /// Represents a delete integration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIntegration service method.</param>
        /// 
        /// <returns>The response from the DeleteIntegration service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
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
        IAsyncResult BeginDeleteIntegration(DeleteIntegrationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteIntegration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteIntegration.</param>
        /// 
        /// <returns>Returns a  DeleteIntegrationResult from APIGateway.</returns>
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
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
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
        IAsyncResult BeginDeleteIntegrationResponse(DeleteIntegrationResponseRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteIntegrationResponse operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteIntegrationResponse.</param>
        /// 
        /// <returns>Returns a  DeleteIntegrationResponseResult from APIGateway.</returns>
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
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
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
        IAsyncResult BeginDeleteMethod(DeleteMethodRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteMethod operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteMethod.</param>
        /// 
        /// <returns>Returns a  DeleteMethodResult from APIGateway.</returns>
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
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
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
        IAsyncResult BeginDeleteMethodResponse(DeleteMethodResponseRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteMethodResponse operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteMethodResponse.</param>
        /// 
        /// <returns>Returns a  DeleteMethodResponseResult from APIGateway.</returns>
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
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
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
        IAsyncResult BeginDeleteModel(DeleteModelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteModel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteModel.</param>
        /// 
        /// <returns>Returns a  DeleteModelResult from APIGateway.</returns>
        DeleteModelResponse EndDeleteModel(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteResource


        /// <summary>
        /// Deletes a <a>Resource</a> resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResource service method.</param>
        /// 
        /// <returns>The response from the DeleteResource service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
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
        IAsyncResult BeginDeleteResource(DeleteResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteResource.</param>
        /// 
        /// <returns>Returns a  DeleteResourceResult from APIGateway.</returns>
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
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
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
        IAsyncResult BeginDeleteRestApi(DeleteRestApiRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteRestApi operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRestApi.</param>
        /// 
        /// <returns>Returns a  DeleteRestApiResult from APIGateway.</returns>
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
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
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
        IAsyncResult BeginDeleteStage(DeleteStageRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteStage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteStage.</param>
        /// 
        /// <returns>Returns a  DeleteStageResult from APIGateway.</returns>
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
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
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
        IAsyncResult BeginDeleteUsagePlan(DeleteUsagePlanRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteUsagePlan operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteUsagePlan.</param>
        /// 
        /// <returns>Returns a  DeleteUsagePlanResult from APIGateway.</returns>
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
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
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
        IAsyncResult BeginDeleteUsagePlanKey(DeleteUsagePlanKeyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteUsagePlanKey operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteUsagePlanKey.</param>
        /// 
        /// <returns>Returns a  DeleteUsagePlanKeyResult from APIGateway.</returns>
        DeleteUsagePlanKeyResponse EndDeleteUsagePlanKey(IAsyncResult asyncResult);

        #endregion
        
        #region  FlushStageAuthorizersCache


        /// <summary>
        /// Flushes all authorizer cache entries on a stage.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the FlushStageAuthorizersCache service method.</param>
        /// 
        /// <returns>The response from the FlushStageAuthorizersCache service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
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
        IAsyncResult BeginFlushStageAuthorizersCache(FlushStageAuthorizersCacheRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  FlushStageAuthorizersCache operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginFlushStageAuthorizersCache.</param>
        /// 
        /// <returns>Returns a  FlushStageAuthorizersCacheResult from APIGateway.</returns>
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
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
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
        IAsyncResult BeginFlushStageCache(FlushStageCacheRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  FlushStageCache operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginFlushStageCache.</param>
        /// 
        /// <returns>Returns a  FlushStageCacheResult from APIGateway.</returns>
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
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
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
        IAsyncResult BeginGenerateClientCertificate(GenerateClientCertificateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GenerateClientCertificate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGenerateClientCertificate.</param>
        /// 
        /// <returns>Returns a  GenerateClientCertificateResult from APIGateway.</returns>
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
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
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
        IAsyncResult BeginGetAccount(GetAccountRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetAccount operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAccount.</param>
        /// 
        /// <returns>Returns a  GetAccountResult from APIGateway.</returns>
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
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
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
        IAsyncResult BeginGetApiKey(GetApiKeyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetApiKey operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetApiKey.</param>
        /// 
        /// <returns>Returns a  GetApiKeyResult from APIGateway.</returns>
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
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
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
        IAsyncResult BeginGetApiKeys(GetApiKeysRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetApiKeys operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetApiKeys.</param>
        /// 
        /// <returns>Returns a  GetApiKeysResult from APIGateway.</returns>
        GetApiKeysResponse EndGetApiKeys(IAsyncResult asyncResult);

        #endregion
        
        #region  GetAuthorizer


        /// <summary>
        /// Describe an existing <a>Authorizer</a> resource.
        /// 
        ///  <div class="seeAlso"><a href="http://docs.aws.amazon.com/cli/latest/reference/apigateway/get-authorizer.html">AWS
        /// CLI</a></div>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAuthorizer service method.</param>
        /// 
        /// <returns>The response from the GetAuthorizer service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
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
        IAsyncResult BeginGetAuthorizer(GetAuthorizerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetAuthorizer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAuthorizer.</param>
        /// 
        /// <returns>Returns a  GetAuthorizerResult from APIGateway.</returns>
        GetAuthorizerResponse EndGetAuthorizer(IAsyncResult asyncResult);

        #endregion
        
        #region  GetAuthorizers


        /// <summary>
        /// Describe an existing <a>Authorizers</a> resource.
        /// 
        ///  <div class="seeAlso"><a href="http://docs.aws.amazon.com/cli/latest/reference/apigateway/get-authorizers.html">AWS
        /// CLI</a></div>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAuthorizers service method.</param>
        /// 
        /// <returns>The response from the GetAuthorizers service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
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
        IAsyncResult BeginGetAuthorizers(GetAuthorizersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetAuthorizers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAuthorizers.</param>
        /// 
        /// <returns>Returns a  GetAuthorizersResult from APIGateway.</returns>
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
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
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
        IAsyncResult BeginGetBasePathMapping(GetBasePathMappingRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetBasePathMapping operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBasePathMapping.</param>
        /// 
        /// <returns>Returns a  GetBasePathMappingResult from APIGateway.</returns>
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
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
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
        IAsyncResult BeginGetBasePathMappings(GetBasePathMappingsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetBasePathMappings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBasePathMappings.</param>
        /// 
        /// <returns>Returns a  GetBasePathMappingsResult from APIGateway.</returns>
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
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
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
        IAsyncResult BeginGetClientCertificate(GetClientCertificateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetClientCertificate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetClientCertificate.</param>
        /// 
        /// <returns>Returns a  GetClientCertificateResult from APIGateway.</returns>
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
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
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
        IAsyncResult BeginGetClientCertificates(GetClientCertificatesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetClientCertificates operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetClientCertificates.</param>
        /// 
        /// <returns>Returns a  GetClientCertificatesResult from APIGateway.</returns>
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
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
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
        IAsyncResult BeginGetDeployment(GetDeploymentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetDeployment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDeployment.</param>
        /// 
        /// <returns>Returns a  GetDeploymentResult from APIGateway.</returns>
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
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
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
        IAsyncResult BeginGetDeployments(GetDeploymentsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetDeployments operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDeployments.</param>
        /// 
        /// <returns>Returns a  GetDeploymentsResult from APIGateway.</returns>
        GetDeploymentsResponse EndGetDeployments(IAsyncResult asyncResult);

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
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
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
        IAsyncResult BeginGetDomainName(GetDomainNameRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetDomainName operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDomainName.</param>
        /// 
        /// <returns>Returns a  GetDomainNameResult from APIGateway.</returns>
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
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
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
        IAsyncResult BeginGetDomainNames(GetDomainNamesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetDomainNames operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDomainNames.</param>
        /// 
        /// <returns>Returns a  GetDomainNamesResult from APIGateway.</returns>
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
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
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
        IAsyncResult BeginGetExport(GetExportRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetExport operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetExport.</param>
        /// 
        /// <returns>Returns a  GetExportResult from APIGateway.</returns>
        GetExportResponse EndGetExport(IAsyncResult asyncResult);

        #endregion
        
        #region  GetIntegration


        /// <summary>
        /// Represents a get integration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIntegration service method.</param>
        /// 
        /// <returns>The response from the GetIntegration service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
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
        IAsyncResult BeginGetIntegration(GetIntegrationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetIntegration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetIntegration.</param>
        /// 
        /// <returns>Returns a  GetIntegrationResult from APIGateway.</returns>
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
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
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
        IAsyncResult BeginGetIntegrationResponse(GetIntegrationResponseRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetIntegrationResponse operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetIntegrationResponse.</param>
        /// 
        /// <returns>Returns a  GetIntegrationResponseResult from APIGateway.</returns>
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
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
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
        IAsyncResult BeginGetMethod(GetMethodRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetMethod operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetMethod.</param>
        /// 
        /// <returns>Returns a  GetMethodResult from APIGateway.</returns>
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
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
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
        IAsyncResult BeginGetMethodResponse(GetMethodResponseRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetMethodResponse operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetMethodResponse.</param>
        /// 
        /// <returns>Returns a  GetMethodResponseResult from APIGateway.</returns>
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
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
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
        IAsyncResult BeginGetModel(GetModelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetModel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetModel.</param>
        /// 
        /// <returns>Returns a  GetModelResult from APIGateway.</returns>
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
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
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
        IAsyncResult BeginGetModels(GetModelsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetModels operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetModels.</param>
        /// 
        /// <returns>Returns a  GetModelsResult from APIGateway.</returns>
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
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
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
        IAsyncResult BeginGetModelTemplate(GetModelTemplateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetModelTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetModelTemplate.</param>
        /// 
        /// <returns>Returns a  GetModelTemplateResult from APIGateway.</returns>
        GetModelTemplateResponse EndGetModelTemplate(IAsyncResult asyncResult);

        #endregion
        
        #region  GetResource


        /// <summary>
        /// Lists information about a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResource service method.</param>
        /// 
        /// <returns>The response from the GetResource service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
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
        IAsyncResult BeginGetResource(GetResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetResource.</param>
        /// 
        /// <returns>Returns a  GetResourceResult from APIGateway.</returns>
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
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
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
        IAsyncResult BeginGetResources(GetResourcesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetResources operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetResources.</param>
        /// 
        /// <returns>Returns a  GetResourcesResult from APIGateway.</returns>
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
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
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
        IAsyncResult BeginGetRestApi(GetRestApiRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetRestApi operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRestApi.</param>
        /// 
        /// <returns>Returns a  GetRestApiResult from APIGateway.</returns>
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
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
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
        IAsyncResult BeginGetRestApis(GetRestApisRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetRestApis operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRestApis.</param>
        /// 
        /// <returns>Returns a  GetRestApisResult from APIGateway.</returns>
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
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
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
        IAsyncResult BeginGetSdk(GetSdkRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetSdk operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSdk.</param>
        /// 
        /// <returns>Returns a  GetSdkResult from APIGateway.</returns>
        GetSdkResponse EndGetSdk(IAsyncResult asyncResult);

        #endregion
        
        #region  GetStage


        /// <summary>
        /// Gets information about a <a>Stage</a> resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetStage service method.</param>
        /// 
        /// <returns>The response from the GetStage service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
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
        IAsyncResult BeginGetStage(GetStageRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetStage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetStage.</param>
        /// 
        /// <returns>Returns a  GetStageResult from APIGateway.</returns>
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
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
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
        IAsyncResult BeginGetStages(GetStagesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetStages operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetStages.</param>
        /// 
        /// <returns>Returns a  GetStagesResult from APIGateway.</returns>
        GetStagesResponse EndGetStages(IAsyncResult asyncResult);

        #endregion
        
        #region  GetUsage


        /// <summary>
        /// Gets the usage data of a usage plan in a specified time interval.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUsage service method.</param>
        /// 
        /// <returns>The response from the GetUsage service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
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
        IAsyncResult BeginGetUsage(GetUsageRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetUsage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetUsage.</param>
        /// 
        /// <returns>Returns a  GetUsageResult from APIGateway.</returns>
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
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
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
        IAsyncResult BeginGetUsagePlan(GetUsagePlanRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetUsagePlan operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetUsagePlan.</param>
        /// 
        /// <returns>Returns a  GetUsagePlanResult from APIGateway.</returns>
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
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
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
        IAsyncResult BeginGetUsagePlanKey(GetUsagePlanKeyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetUsagePlanKey operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetUsagePlanKey.</param>
        /// 
        /// <returns>Returns a  GetUsagePlanKeyResult from APIGateway.</returns>
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
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
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
        IAsyncResult BeginGetUsagePlanKeys(GetUsagePlanKeysRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetUsagePlanKeys operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetUsagePlanKeys.</param>
        /// 
        /// <returns>Returns a  GetUsagePlanKeysResult from APIGateway.</returns>
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
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
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
        IAsyncResult BeginGetUsagePlans(GetUsagePlansRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetUsagePlans operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetUsagePlans.</param>
        /// 
        /// <returns>Returns a  GetUsagePlansResult from APIGateway.</returns>
        GetUsagePlansResponse EndGetUsagePlans(IAsyncResult asyncResult);

        #endregion
        
        #region  ImportApiKeys


        /// <summary>
        /// Import API keys from an external source, such as a CSV-formatted file.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportApiKeys service method.</param>
        /// 
        /// <returns>The response from the ImportApiKeys service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
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
        IAsyncResult BeginImportApiKeys(ImportApiKeysRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ImportApiKeys operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginImportApiKeys.</param>
        /// 
        /// <returns>Returns a  ImportApiKeysResult from APIGateway.</returns>
        ImportApiKeysResponse EndImportApiKeys(IAsyncResult asyncResult);

        #endregion
        
        #region  ImportRestApi


        /// <summary>
        /// A feature of the Amazon API Gateway control service for creating a new API from an
        /// external API definition file.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportRestApi service method.</param>
        /// 
        /// <returns>The response from the ImportRestApi service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
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
        IAsyncResult BeginImportRestApi(ImportRestApiRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ImportRestApi operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginImportRestApi.</param>
        /// 
        /// <returns>Returns a  ImportRestApiResult from APIGateway.</returns>
        ImportRestApiResponse EndImportRestApi(IAsyncResult asyncResult);

        #endregion
        
        #region  PutIntegration


        /// <summary>
        /// Represents a put integration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutIntegration service method.</param>
        /// 
        /// <returns>The response from the PutIntegration service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
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
        IAsyncResult BeginPutIntegration(PutIntegrationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutIntegration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutIntegration.</param>
        /// 
        /// <returns>Returns a  PutIntegrationResult from APIGateway.</returns>
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
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
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
        IAsyncResult BeginPutIntegrationResponse(PutIntegrationResponseRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutIntegrationResponse operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutIntegrationResponse.</param>
        /// 
        /// <returns>Returns a  PutIntegrationResponseResult from APIGateway.</returns>
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
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
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
        IAsyncResult BeginPutMethod(PutMethodRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutMethod operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutMethod.</param>
        /// 
        /// <returns>Returns a  PutMethodResult from APIGateway.</returns>
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
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
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
        IAsyncResult BeginPutMethodResponse(PutMethodResponseRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutMethodResponse operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutMethodResponse.</param>
        /// 
        /// <returns>Returns a  PutMethodResponseResult from APIGateway.</returns>
        PutMethodResponseResponse EndPutMethodResponse(IAsyncResult asyncResult);

        #endregion
        
        #region  PutRestApi


        /// <summary>
        /// A feature of the Amazon API Gateway control service for updating an existing API with
        /// an input of external API definitions. The update can take the form of merging the
        /// supplied definition into the existing API or overwriting the existing API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutRestApi service method.</param>
        /// 
        /// <returns>The response from the PutRestApi service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
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
        IAsyncResult BeginPutRestApi(PutRestApiRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutRestApi operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutRestApi.</param>
        /// 
        /// <returns>Returns a  PutRestApiResult from APIGateway.</returns>
        PutRestApiResponse EndPutRestApi(IAsyncResult asyncResult);

        #endregion
        
        #region  TestInvokeAuthorizer


        /// <summary>
        /// Simulate the execution of an <a>Authorizer</a> in your <a>RestApi</a> with headers,
        /// parameters, and an incoming request body.
        /// 
        ///  <div class="seeAlso"> <a href="http://docs.aws.amazon.com/apigateway/latest/developerguide/use-custom-authorizer.html">Enable
        /// custom authorizers</a> </div>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TestInvokeAuthorizer service method.</param>
        /// 
        /// <returns>The response from the TestInvokeAuthorizer service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
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
        IAsyncResult BeginTestInvokeAuthorizer(TestInvokeAuthorizerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TestInvokeAuthorizer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTestInvokeAuthorizer.</param>
        /// 
        /// <returns>Returns a  TestInvokeAuthorizerResult from APIGateway.</returns>
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
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
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
        IAsyncResult BeginTestInvokeMethod(TestInvokeMethodRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TestInvokeMethod operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTestInvokeMethod.</param>
        /// 
        /// <returns>Returns a  TestInvokeMethodResult from APIGateway.</returns>
        TestInvokeMethodResponse EndTestInvokeMethod(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateAccount


        /// <summary>
        /// Changes information about the current <a>Account</a> resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccount service method.</param>
        /// 
        /// <returns>The response from the UpdateAccount service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
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
        IAsyncResult BeginUpdateAccount(UpdateAccountRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAccount operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAccount.</param>
        /// 
        /// <returns>Returns a  UpdateAccountResult from APIGateway.</returns>
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
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
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
        IAsyncResult BeginUpdateApiKey(UpdateApiKeyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateApiKey operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateApiKey.</param>
        /// 
        /// <returns>Returns a  UpdateApiKeyResult from APIGateway.</returns>
        UpdateApiKeyResponse EndUpdateApiKey(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateAuthorizer


        /// <summary>
        /// Updates an existing <a>Authorizer</a> resource.
        /// 
        ///  <div class="seeAlso"><a href="http://docs.aws.amazon.com/cli/latest/reference/apigateway/update-authorizer.html">AWS
        /// CLI</a></div>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAuthorizer service method.</param>
        /// 
        /// <returns>The response from the UpdateAuthorizer service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
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
        IAsyncResult BeginUpdateAuthorizer(UpdateAuthorizerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAuthorizer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAuthorizer.</param>
        /// 
        /// <returns>Returns a  UpdateAuthorizerResult from APIGateway.</returns>
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
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
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
        IAsyncResult BeginUpdateBasePathMapping(UpdateBasePathMappingRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateBasePathMapping operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateBasePathMapping.</param>
        /// 
        /// <returns>Returns a  UpdateBasePathMappingResult from APIGateway.</returns>
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
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
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
        IAsyncResult BeginUpdateClientCertificate(UpdateClientCertificateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateClientCertificate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateClientCertificate.</param>
        /// 
        /// <returns>Returns a  UpdateClientCertificateResult from APIGateway.</returns>
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
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
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
        IAsyncResult BeginUpdateDeployment(UpdateDeploymentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDeployment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDeployment.</param>
        /// 
        /// <returns>Returns a  UpdateDeploymentResult from APIGateway.</returns>
        UpdateDeploymentResponse EndUpdateDeployment(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateDomainName


        /// <summary>
        /// Changes information about the <a>DomainName</a> resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDomainName service method.</param>
        /// 
        /// <returns>The response from the UpdateDomainName service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
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
        IAsyncResult BeginUpdateDomainName(UpdateDomainNameRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDomainName operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDomainName.</param>
        /// 
        /// <returns>Returns a  UpdateDomainNameResult from APIGateway.</returns>
        UpdateDomainNameResponse EndUpdateDomainName(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateIntegration


        /// <summary>
        /// Represents an update integration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateIntegration service method.</param>
        /// 
        /// <returns>The response from the UpdateIntegration service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
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
        IAsyncResult BeginUpdateIntegration(UpdateIntegrationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateIntegration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateIntegration.</param>
        /// 
        /// <returns>Returns a  UpdateIntegrationResult from APIGateway.</returns>
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
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
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
        IAsyncResult BeginUpdateIntegrationResponse(UpdateIntegrationResponseRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateIntegrationResponse operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateIntegrationResponse.</param>
        /// 
        /// <returns>Returns a  UpdateIntegrationResponseResult from APIGateway.</returns>
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
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
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
        IAsyncResult BeginUpdateMethod(UpdateMethodRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateMethod operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateMethod.</param>
        /// 
        /// <returns>Returns a  UpdateMethodResult from APIGateway.</returns>
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
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
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
        IAsyncResult BeginUpdateMethodResponse(UpdateMethodResponseRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateMethodResponse operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateMethodResponse.</param>
        /// 
        /// <returns>Returns a  UpdateMethodResponseResult from APIGateway.</returns>
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
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
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
        IAsyncResult BeginUpdateModel(UpdateModelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateModel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateModel.</param>
        /// 
        /// <returns>Returns a  UpdateModelResult from APIGateway.</returns>
        UpdateModelResponse EndUpdateModel(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateResource


        /// <summary>
        /// Changes information about a <a>Resource</a> resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateResource service method.</param>
        /// 
        /// <returns>The response from the UpdateResource service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
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
        IAsyncResult BeginUpdateResource(UpdateResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateResource.</param>
        /// 
        /// <returns>Returns a  UpdateResourceResult from APIGateway.</returns>
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
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
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
        IAsyncResult BeginUpdateRestApi(UpdateRestApiRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateRestApi operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateRestApi.</param>
        /// 
        /// <returns>Returns a  UpdateRestApiResult from APIGateway.</returns>
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
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
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
        IAsyncResult BeginUpdateStage(UpdateStageRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateStage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateStage.</param>
        /// 
        /// <returns>Returns a  UpdateStageResult from APIGateway.</returns>
        UpdateStageResponse EndUpdateStage(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateUsage


        /// <summary>
        /// Grants a temporary extension to the reamining quota of a usage plan associated with
        /// a specified API key.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateUsage service method.</param>
        /// 
        /// <returns>The response from the UpdateUsage service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
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
        IAsyncResult BeginUpdateUsage(UpdateUsageRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateUsage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateUsage.</param>
        /// 
        /// <returns>Returns a  UpdateUsageResult from APIGateway.</returns>
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
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
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
        IAsyncResult BeginUpdateUsagePlan(UpdateUsagePlanRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateUsagePlan operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateUsagePlan.</param>
        /// 
        /// <returns>Returns a  UpdateUsagePlanResult from APIGateway.</returns>
        UpdateUsagePlanResponse EndUpdateUsagePlan(IAsyncResult asyncResult);

        #endregion
        
    }
}