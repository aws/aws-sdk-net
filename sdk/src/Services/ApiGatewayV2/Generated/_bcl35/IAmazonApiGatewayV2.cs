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
 * Do not modify this file. This file is generated from the apigatewayv2-2018-11-29.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.ApiGatewayV2.Model;

#pragma warning disable CS1570
namespace Amazon.ApiGatewayV2
{
    /// <summary>
    /// <para>Interface for accessing ApiGatewayV2</para>
    ///
    /// Amazon API Gateway V2
    /// </summary>
    public partial interface IAmazonApiGatewayV2 : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IApiGatewayV2PaginatorFactory Paginators { get; }
#endif


        
        #region  CreateApi


        /// <summary>
        /// Creates an Api resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateApi service method.</param>
        /// 
        /// <returns>The response from the CreateApi service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/CreateApi">REST API Reference for CreateApi Operation</seealso>
        CreateApiResponse CreateApi(CreateApiRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateApi operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateApi operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateApi
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/CreateApi">REST API Reference for CreateApi Operation</seealso>
        IAsyncResult BeginCreateApi(CreateApiRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateApi operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateApi.</param>
        /// 
        /// <returns>Returns a  CreateApiResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/CreateApi">REST API Reference for CreateApi Operation</seealso>
        CreateApiResponse EndCreateApi(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateApiMapping


        /// <summary>
        /// Creates an API mapping.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateApiMapping service method.</param>
        /// 
        /// <returns>The response from the CreateApiMapping service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/CreateApiMapping">REST API Reference for CreateApiMapping Operation</seealso>
        CreateApiMappingResponse CreateApiMapping(CreateApiMappingRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateApiMapping operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateApiMapping operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateApiMapping
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/CreateApiMapping">REST API Reference for CreateApiMapping Operation</seealso>
        IAsyncResult BeginCreateApiMapping(CreateApiMappingRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateApiMapping operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateApiMapping.</param>
        /// 
        /// <returns>Returns a  CreateApiMappingResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/CreateApiMapping">REST API Reference for CreateApiMapping Operation</seealso>
        CreateApiMappingResponse EndCreateApiMapping(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateAuthorizer


        /// <summary>
        /// Creates an Authorizer for an API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAuthorizer service method.</param>
        /// 
        /// <returns>The response from the CreateAuthorizer service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/CreateAuthorizer">REST API Reference for CreateAuthorizer Operation</seealso>
        CreateAuthorizerResponse CreateAuthorizer(CreateAuthorizerRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAuthorizer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAuthorizer operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAuthorizer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/CreateAuthorizer">REST API Reference for CreateAuthorizer Operation</seealso>
        IAsyncResult BeginCreateAuthorizer(CreateAuthorizerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAuthorizer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAuthorizer.</param>
        /// 
        /// <returns>Returns a  CreateAuthorizerResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/CreateAuthorizer">REST API Reference for CreateAuthorizer Operation</seealso>
        CreateAuthorizerResponse EndCreateAuthorizer(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateDeployment


        /// <summary>
        /// Creates a Deployment for an API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDeployment service method.</param>
        /// 
        /// <returns>The response from the CreateDeployment service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/CreateDeployment">REST API Reference for CreateDeployment Operation</seealso>
        CreateDeploymentResponse CreateDeployment(CreateDeploymentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDeployment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDeployment operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDeployment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/CreateDeployment">REST API Reference for CreateDeployment Operation</seealso>
        IAsyncResult BeginCreateDeployment(CreateDeploymentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDeployment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDeployment.</param>
        /// 
        /// <returns>Returns a  CreateDeploymentResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/CreateDeployment">REST API Reference for CreateDeployment Operation</seealso>
        CreateDeploymentResponse EndCreateDeployment(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateDomainName


        /// <summary>
        /// Creates a domain name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDomainName service method.</param>
        /// 
        /// <returns>The response from the CreateDomainName service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/CreateDomainName">REST API Reference for CreateDomainName Operation</seealso>
        CreateDomainNameResponse CreateDomainName(CreateDomainNameRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDomainName operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDomainName operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDomainName
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/CreateDomainName">REST API Reference for CreateDomainName Operation</seealso>
        IAsyncResult BeginCreateDomainName(CreateDomainNameRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDomainName operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDomainName.</param>
        /// 
        /// <returns>Returns a  CreateDomainNameResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/CreateDomainName">REST API Reference for CreateDomainName Operation</seealso>
        CreateDomainNameResponse EndCreateDomainName(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateIntegration


        /// <summary>
        /// Creates an Integration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateIntegration service method.</param>
        /// 
        /// <returns>The response from the CreateIntegration service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/CreateIntegration">REST API Reference for CreateIntegration Operation</seealso>
        CreateIntegrationResponse CreateIntegration(CreateIntegrationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateIntegration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateIntegration operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateIntegration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/CreateIntegration">REST API Reference for CreateIntegration Operation</seealso>
        IAsyncResult BeginCreateIntegration(CreateIntegrationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateIntegration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateIntegration.</param>
        /// 
        /// <returns>Returns a  CreateIntegrationResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/CreateIntegration">REST API Reference for CreateIntegration Operation</seealso>
        CreateIntegrationResponse EndCreateIntegration(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateIntegrationResponse


        /// <summary>
        /// Creates an IntegrationResponses.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateIntegrationResponse service method.</param>
        /// 
        /// <returns>The response from the CreateIntegrationResponse service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/CreateIntegrationResponse">REST API Reference for CreateIntegrationResponse Operation</seealso>
        CreateIntegrationResponseResponse CreateIntegrationResponse(CreateIntegrationResponseRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateIntegrationResponse operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateIntegrationResponse operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateIntegrationResponse
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/CreateIntegrationResponse">REST API Reference for CreateIntegrationResponse Operation</seealso>
        IAsyncResult BeginCreateIntegrationResponse(CreateIntegrationResponseRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateIntegrationResponse operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateIntegrationResponse.</param>
        /// 
        /// <returns>Returns a  CreateIntegrationResponseResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/CreateIntegrationResponse">REST API Reference for CreateIntegrationResponse Operation</seealso>
        CreateIntegrationResponseResponse EndCreateIntegrationResponse(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateModel


        /// <summary>
        /// Creates a Model for an API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateModel service method.</param>
        /// 
        /// <returns>The response from the CreateModel service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/CreateModel">REST API Reference for CreateModel Operation</seealso>
        CreateModelResponse CreateModel(CreateModelRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateModel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateModel operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateModel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/CreateModel">REST API Reference for CreateModel Operation</seealso>
        IAsyncResult BeginCreateModel(CreateModelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateModel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateModel.</param>
        /// 
        /// <returns>Returns a  CreateModelResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/CreateModel">REST API Reference for CreateModel Operation</seealso>
        CreateModelResponse EndCreateModel(IAsyncResult asyncResult);

        #endregion
        
        #region  CreatePortal


        /// <summary>
        /// Creates a portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePortal service method.</param>
        /// 
        /// <returns>The response from the CreatePortal service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/CreatePortal">REST API Reference for CreatePortal Operation</seealso>
        CreatePortalResponse CreatePortal(CreatePortalRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePortal operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePortal operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreatePortal
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/CreatePortal">REST API Reference for CreatePortal Operation</seealso>
        IAsyncResult BeginCreatePortal(CreatePortalRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreatePortal operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreatePortal.</param>
        /// 
        /// <returns>Returns a  CreatePortalResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/CreatePortal">REST API Reference for CreatePortal Operation</seealso>
        CreatePortalResponse EndCreatePortal(IAsyncResult asyncResult);

        #endregion
        
        #region  CreatePortalProduct


        /// <summary>
        /// Creates a new portal product.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePortalProduct service method.</param>
        /// 
        /// <returns>The response from the CreatePortalProduct service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/CreatePortalProduct">REST API Reference for CreatePortalProduct Operation</seealso>
        CreatePortalProductResponse CreatePortalProduct(CreatePortalProductRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePortalProduct operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePortalProduct operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreatePortalProduct
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/CreatePortalProduct">REST API Reference for CreatePortalProduct Operation</seealso>
        IAsyncResult BeginCreatePortalProduct(CreatePortalProductRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreatePortalProduct operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreatePortalProduct.</param>
        /// 
        /// <returns>Returns a  CreatePortalProductResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/CreatePortalProduct">REST API Reference for CreatePortalProduct Operation</seealso>
        CreatePortalProductResponse EndCreatePortalProduct(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateProductPage


        /// <summary>
        /// Creates a new product page for a portal product.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProductPage service method.</param>
        /// 
        /// <returns>The response from the CreateProductPage service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/CreateProductPage">REST API Reference for CreateProductPage Operation</seealso>
        CreateProductPageResponse CreateProductPage(CreateProductPageRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateProductPage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateProductPage operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateProductPage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/CreateProductPage">REST API Reference for CreateProductPage Operation</seealso>
        IAsyncResult BeginCreateProductPage(CreateProductPageRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateProductPage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateProductPage.</param>
        /// 
        /// <returns>Returns a  CreateProductPageResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/CreateProductPage">REST API Reference for CreateProductPage Operation</seealso>
        CreateProductPageResponse EndCreateProductPage(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateProductRestEndpointPage


        /// <summary>
        /// Creates a product REST endpoint page for a portal product.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProductRestEndpointPage service method.</param>
        /// 
        /// <returns>The response from the CreateProductRestEndpointPage service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/CreateProductRestEndpointPage">REST API Reference for CreateProductRestEndpointPage Operation</seealso>
        CreateProductRestEndpointPageResponse CreateProductRestEndpointPage(CreateProductRestEndpointPageRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateProductRestEndpointPage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateProductRestEndpointPage operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateProductRestEndpointPage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/CreateProductRestEndpointPage">REST API Reference for CreateProductRestEndpointPage Operation</seealso>
        IAsyncResult BeginCreateProductRestEndpointPage(CreateProductRestEndpointPageRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateProductRestEndpointPage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateProductRestEndpointPage.</param>
        /// 
        /// <returns>Returns a  CreateProductRestEndpointPageResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/CreateProductRestEndpointPage">REST API Reference for CreateProductRestEndpointPage Operation</seealso>
        CreateProductRestEndpointPageResponse EndCreateProductRestEndpointPage(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateRoute


        /// <summary>
        /// Creates a Route for an API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRoute service method.</param>
        /// 
        /// <returns>The response from the CreateRoute service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/CreateRoute">REST API Reference for CreateRoute Operation</seealso>
        CreateRouteResponse CreateRoute(CreateRouteRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateRoute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRoute operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateRoute
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/CreateRoute">REST API Reference for CreateRoute Operation</seealso>
        IAsyncResult BeginCreateRoute(CreateRouteRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateRoute operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateRoute.</param>
        /// 
        /// <returns>Returns a  CreateRouteResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/CreateRoute">REST API Reference for CreateRoute Operation</seealso>
        CreateRouteResponse EndCreateRoute(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateRouteResponse


        /// <summary>
        /// Creates a RouteResponse for a Route.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRouteResponse service method.</param>
        /// 
        /// <returns>The response from the CreateRouteResponse service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/CreateRouteResponse">REST API Reference for CreateRouteResponse Operation</seealso>
        CreateRouteResponseResponse CreateRouteResponse(CreateRouteResponseRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateRouteResponse operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRouteResponse operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateRouteResponse
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/CreateRouteResponse">REST API Reference for CreateRouteResponse Operation</seealso>
        IAsyncResult BeginCreateRouteResponse(CreateRouteResponseRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateRouteResponse operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateRouteResponse.</param>
        /// 
        /// <returns>Returns a  CreateRouteResponseResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/CreateRouteResponse">REST API Reference for CreateRouteResponse Operation</seealso>
        CreateRouteResponseResponse EndCreateRouteResponse(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateRoutingRule


        /// <summary>
        /// Creates a RoutingRule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRoutingRule service method.</param>
        /// 
        /// <returns>The response from the CreateRoutingRule service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/CreateRoutingRule">REST API Reference for CreateRoutingRule Operation</seealso>
        CreateRoutingRuleResponse CreateRoutingRule(CreateRoutingRuleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateRoutingRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRoutingRule operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateRoutingRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/CreateRoutingRule">REST API Reference for CreateRoutingRule Operation</seealso>
        IAsyncResult BeginCreateRoutingRule(CreateRoutingRuleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateRoutingRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateRoutingRule.</param>
        /// 
        /// <returns>Returns a  CreateRoutingRuleResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/CreateRoutingRule">REST API Reference for CreateRoutingRule Operation</seealso>
        CreateRoutingRuleResponse EndCreateRoutingRule(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateStage


        /// <summary>
        /// Creates a Stage for an API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateStage service method.</param>
        /// 
        /// <returns>The response from the CreateStage service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/CreateStage">REST API Reference for CreateStage Operation</seealso>
        CreateStageResponse CreateStage(CreateStageRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateStage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateStage operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateStage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/CreateStage">REST API Reference for CreateStage Operation</seealso>
        IAsyncResult BeginCreateStage(CreateStageRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateStage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateStage.</param>
        /// 
        /// <returns>Returns a  CreateStageResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/CreateStage">REST API Reference for CreateStage Operation</seealso>
        CreateStageResponse EndCreateStage(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateVpcLink


        /// <summary>
        /// Creates a VPC link.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVpcLink service method.</param>
        /// 
        /// <returns>The response from the CreateVpcLink service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/CreateVpcLink">REST API Reference for CreateVpcLink Operation</seealso>
        CreateVpcLinkResponse CreateVpcLink(CreateVpcLinkRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateVpcLink operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateVpcLink operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateVpcLink
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/CreateVpcLink">REST API Reference for CreateVpcLink Operation</seealso>
        IAsyncResult BeginCreateVpcLink(CreateVpcLinkRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateVpcLink operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateVpcLink.</param>
        /// 
        /// <returns>Returns a  CreateVpcLinkResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/CreateVpcLink">REST API Reference for CreateVpcLink Operation</seealso>
        CreateVpcLinkResponse EndCreateVpcLink(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteAccessLogSettings


        /// <summary>
        /// Deletes the AccessLogSettings for a Stage. To disable access logging for a Stage,
        /// delete its AccessLogSettings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccessLogSettings service method.</param>
        /// 
        /// <returns>The response from the DeleteAccessLogSettings service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeleteAccessLogSettings">REST API Reference for DeleteAccessLogSettings Operation</seealso>
        DeleteAccessLogSettingsResponse DeleteAccessLogSettings(DeleteAccessLogSettingsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAccessLogSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccessLogSettings operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAccessLogSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeleteAccessLogSettings">REST API Reference for DeleteAccessLogSettings Operation</seealso>
        IAsyncResult BeginDeleteAccessLogSettings(DeleteAccessLogSettingsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAccessLogSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAccessLogSettings.</param>
        /// 
        /// <returns>Returns a  DeleteAccessLogSettingsResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeleteAccessLogSettings">REST API Reference for DeleteAccessLogSettings Operation</seealso>
        DeleteAccessLogSettingsResponse EndDeleteAccessLogSettings(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteApi


        /// <summary>
        /// Deletes an Api resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApi service method.</param>
        /// 
        /// <returns>The response from the DeleteApi service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeleteApi">REST API Reference for DeleteApi Operation</seealso>
        DeleteApiResponse DeleteApi(DeleteApiRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteApi operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteApi operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteApi
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeleteApi">REST API Reference for DeleteApi Operation</seealso>
        IAsyncResult BeginDeleteApi(DeleteApiRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteApi operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteApi.</param>
        /// 
        /// <returns>Returns a  DeleteApiResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeleteApi">REST API Reference for DeleteApi Operation</seealso>
        DeleteApiResponse EndDeleteApi(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteApiMapping


        /// <summary>
        /// Deletes an API mapping.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApiMapping service method.</param>
        /// 
        /// <returns>The response from the DeleteApiMapping service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeleteApiMapping">REST API Reference for DeleteApiMapping Operation</seealso>
        DeleteApiMappingResponse DeleteApiMapping(DeleteApiMappingRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteApiMapping operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteApiMapping operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteApiMapping
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeleteApiMapping">REST API Reference for DeleteApiMapping Operation</seealso>
        IAsyncResult BeginDeleteApiMapping(DeleteApiMappingRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteApiMapping operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteApiMapping.</param>
        /// 
        /// <returns>Returns a  DeleteApiMappingResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeleteApiMapping">REST API Reference for DeleteApiMapping Operation</seealso>
        DeleteApiMappingResponse EndDeleteApiMapping(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteAuthorizer


        /// <summary>
        /// Deletes an Authorizer.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAuthorizer service method.</param>
        /// 
        /// <returns>The response from the DeleteAuthorizer service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeleteAuthorizer">REST API Reference for DeleteAuthorizer Operation</seealso>
        DeleteAuthorizerResponse DeleteAuthorizer(DeleteAuthorizerRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAuthorizer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAuthorizer operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAuthorizer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeleteAuthorizer">REST API Reference for DeleteAuthorizer Operation</seealso>
        IAsyncResult BeginDeleteAuthorizer(DeleteAuthorizerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAuthorizer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAuthorizer.</param>
        /// 
        /// <returns>Returns a  DeleteAuthorizerResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeleteAuthorizer">REST API Reference for DeleteAuthorizer Operation</seealso>
        DeleteAuthorizerResponse EndDeleteAuthorizer(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteCorsConfiguration


        /// <summary>
        /// Deletes a CORS configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCorsConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteCorsConfiguration service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeleteCorsConfiguration">REST API Reference for DeleteCorsConfiguration Operation</seealso>
        DeleteCorsConfigurationResponse DeleteCorsConfiguration(DeleteCorsConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCorsConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCorsConfiguration operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteCorsConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeleteCorsConfiguration">REST API Reference for DeleteCorsConfiguration Operation</seealso>
        IAsyncResult BeginDeleteCorsConfiguration(DeleteCorsConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteCorsConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCorsConfiguration.</param>
        /// 
        /// <returns>Returns a  DeleteCorsConfigurationResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeleteCorsConfiguration">REST API Reference for DeleteCorsConfiguration Operation</seealso>
        DeleteCorsConfigurationResponse EndDeleteCorsConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteDeployment


        /// <summary>
        /// Deletes a Deployment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDeployment service method.</param>
        /// 
        /// <returns>The response from the DeleteDeployment service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeleteDeployment">REST API Reference for DeleteDeployment Operation</seealso>
        DeleteDeploymentResponse DeleteDeployment(DeleteDeploymentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDeployment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDeployment operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDeployment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeleteDeployment">REST API Reference for DeleteDeployment Operation</seealso>
        IAsyncResult BeginDeleteDeployment(DeleteDeploymentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDeployment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDeployment.</param>
        /// 
        /// <returns>Returns a  DeleteDeploymentResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeleteDeployment">REST API Reference for DeleteDeployment Operation</seealso>
        DeleteDeploymentResponse EndDeleteDeployment(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteDomainName


        /// <summary>
        /// Deletes a domain name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDomainName service method.</param>
        /// 
        /// <returns>The response from the DeleteDomainName service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeleteDomainName">REST API Reference for DeleteDomainName Operation</seealso>
        DeleteDomainNameResponse DeleteDomainName(DeleteDomainNameRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDomainName operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDomainName operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDomainName
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeleteDomainName">REST API Reference for DeleteDomainName Operation</seealso>
        IAsyncResult BeginDeleteDomainName(DeleteDomainNameRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDomainName operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDomainName.</param>
        /// 
        /// <returns>Returns a  DeleteDomainNameResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeleteDomainName">REST API Reference for DeleteDomainName Operation</seealso>
        DeleteDomainNameResponse EndDeleteDomainName(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteIntegration


        /// <summary>
        /// Deletes an Integration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIntegration service method.</param>
        /// 
        /// <returns>The response from the DeleteIntegration service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeleteIntegration">REST API Reference for DeleteIntegration Operation</seealso>
        DeleteIntegrationResponse DeleteIntegration(DeleteIntegrationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteIntegration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteIntegration operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteIntegration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeleteIntegration">REST API Reference for DeleteIntegration Operation</seealso>
        IAsyncResult BeginDeleteIntegration(DeleteIntegrationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteIntegration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteIntegration.</param>
        /// 
        /// <returns>Returns a  DeleteIntegrationResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeleteIntegration">REST API Reference for DeleteIntegration Operation</seealso>
        DeleteIntegrationResponse EndDeleteIntegration(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteIntegrationResponse


        /// <summary>
        /// Deletes an IntegrationResponses.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIntegrationResponse service method.</param>
        /// 
        /// <returns>The response from the DeleteIntegrationResponse service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeleteIntegrationResponse">REST API Reference for DeleteIntegrationResponse Operation</seealso>
        DeleteIntegrationResponseResponse DeleteIntegrationResponse(DeleteIntegrationResponseRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteIntegrationResponse operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteIntegrationResponse operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteIntegrationResponse
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeleteIntegrationResponse">REST API Reference for DeleteIntegrationResponse Operation</seealso>
        IAsyncResult BeginDeleteIntegrationResponse(DeleteIntegrationResponseRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteIntegrationResponse operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteIntegrationResponse.</param>
        /// 
        /// <returns>Returns a  DeleteIntegrationResponseResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeleteIntegrationResponse">REST API Reference for DeleteIntegrationResponse Operation</seealso>
        DeleteIntegrationResponseResponse EndDeleteIntegrationResponse(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteModel


        /// <summary>
        /// Deletes a Model.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteModel service method.</param>
        /// 
        /// <returns>The response from the DeleteModel service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeleteModel">REST API Reference for DeleteModel Operation</seealso>
        DeleteModelResponse DeleteModel(DeleteModelRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteModel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteModel operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteModel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeleteModel">REST API Reference for DeleteModel Operation</seealso>
        IAsyncResult BeginDeleteModel(DeleteModelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteModel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteModel.</param>
        /// 
        /// <returns>Returns a  DeleteModelResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeleteModel">REST API Reference for DeleteModel Operation</seealso>
        DeleteModelResponse EndDeleteModel(IAsyncResult asyncResult);

        #endregion
        
        #region  DeletePortal


        /// <summary>
        /// Deletes a portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePortal service method.</param>
        /// 
        /// <returns>The response from the DeletePortal service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeletePortal">REST API Reference for DeletePortal Operation</seealso>
        DeletePortalResponse DeletePortal(DeletePortalRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeletePortal operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePortal operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeletePortal
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeletePortal">REST API Reference for DeletePortal Operation</seealso>
        IAsyncResult BeginDeletePortal(DeletePortalRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeletePortal operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeletePortal.</param>
        /// 
        /// <returns>Returns a  DeletePortalResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeletePortal">REST API Reference for DeletePortal Operation</seealso>
        DeletePortalResponse EndDeletePortal(IAsyncResult asyncResult);

        #endregion
        
        #region  DeletePortalProduct


        /// <summary>
        /// Deletes a portal product.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePortalProduct service method.</param>
        /// 
        /// <returns>The response from the DeletePortalProduct service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeletePortalProduct">REST API Reference for DeletePortalProduct Operation</seealso>
        DeletePortalProductResponse DeletePortalProduct(DeletePortalProductRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeletePortalProduct operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePortalProduct operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeletePortalProduct
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeletePortalProduct">REST API Reference for DeletePortalProduct Operation</seealso>
        IAsyncResult BeginDeletePortalProduct(DeletePortalProductRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeletePortalProduct operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeletePortalProduct.</param>
        /// 
        /// <returns>Returns a  DeletePortalProductResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeletePortalProduct">REST API Reference for DeletePortalProduct Operation</seealso>
        DeletePortalProductResponse EndDeletePortalProduct(IAsyncResult asyncResult);

        #endregion
        
        #region  DeletePortalProductSharingPolicy


        /// <summary>
        /// Deletes the sharing policy for a portal product.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePortalProductSharingPolicy service method.</param>
        /// 
        /// <returns>The response from the DeletePortalProductSharingPolicy service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeletePortalProductSharingPolicy">REST API Reference for DeletePortalProductSharingPolicy Operation</seealso>
        DeletePortalProductSharingPolicyResponse DeletePortalProductSharingPolicy(DeletePortalProductSharingPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeletePortalProductSharingPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePortalProductSharingPolicy operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeletePortalProductSharingPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeletePortalProductSharingPolicy">REST API Reference for DeletePortalProductSharingPolicy Operation</seealso>
        IAsyncResult BeginDeletePortalProductSharingPolicy(DeletePortalProductSharingPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeletePortalProductSharingPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeletePortalProductSharingPolicy.</param>
        /// 
        /// <returns>Returns a  DeletePortalProductSharingPolicyResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeletePortalProductSharingPolicy">REST API Reference for DeletePortalProductSharingPolicy Operation</seealso>
        DeletePortalProductSharingPolicyResponse EndDeletePortalProductSharingPolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteProductPage


        /// <summary>
        /// Deletes a product page of a portal product.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProductPage service method.</param>
        /// 
        /// <returns>The response from the DeleteProductPage service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeleteProductPage">REST API Reference for DeleteProductPage Operation</seealso>
        DeleteProductPageResponse DeleteProductPage(DeleteProductPageRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteProductPage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteProductPage operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteProductPage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeleteProductPage">REST API Reference for DeleteProductPage Operation</seealso>
        IAsyncResult BeginDeleteProductPage(DeleteProductPageRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteProductPage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteProductPage.</param>
        /// 
        /// <returns>Returns a  DeleteProductPageResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeleteProductPage">REST API Reference for DeleteProductPage Operation</seealso>
        DeleteProductPageResponse EndDeleteProductPage(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteProductRestEndpointPage


        /// <summary>
        /// Deletes a product REST endpoint page.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProductRestEndpointPage service method.</param>
        /// 
        /// <returns>The response from the DeleteProductRestEndpointPage service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeleteProductRestEndpointPage">REST API Reference for DeleteProductRestEndpointPage Operation</seealso>
        DeleteProductRestEndpointPageResponse DeleteProductRestEndpointPage(DeleteProductRestEndpointPageRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteProductRestEndpointPage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteProductRestEndpointPage operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteProductRestEndpointPage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeleteProductRestEndpointPage">REST API Reference for DeleteProductRestEndpointPage Operation</seealso>
        IAsyncResult BeginDeleteProductRestEndpointPage(DeleteProductRestEndpointPageRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteProductRestEndpointPage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteProductRestEndpointPage.</param>
        /// 
        /// <returns>Returns a  DeleteProductRestEndpointPageResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeleteProductRestEndpointPage">REST API Reference for DeleteProductRestEndpointPage Operation</seealso>
        DeleteProductRestEndpointPageResponse EndDeleteProductRestEndpointPage(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteRoute


        /// <summary>
        /// Deletes a Route.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRoute service method.</param>
        /// 
        /// <returns>The response from the DeleteRoute service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeleteRoute">REST API Reference for DeleteRoute Operation</seealso>
        DeleteRouteResponse DeleteRoute(DeleteRouteRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRoute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRoute operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteRoute
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeleteRoute">REST API Reference for DeleteRoute Operation</seealso>
        IAsyncResult BeginDeleteRoute(DeleteRouteRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteRoute operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRoute.</param>
        /// 
        /// <returns>Returns a  DeleteRouteResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeleteRoute">REST API Reference for DeleteRoute Operation</seealso>
        DeleteRouteResponse EndDeleteRoute(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteRouteRequestParameter


        /// <summary>
        /// Deletes a route request parameter. Supported only for WebSocket APIs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRouteRequestParameter service method.</param>
        /// 
        /// <returns>The response from the DeleteRouteRequestParameter service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeleteRouteRequestParameter">REST API Reference for DeleteRouteRequestParameter Operation</seealso>
        DeleteRouteRequestParameterResponse DeleteRouteRequestParameter(DeleteRouteRequestParameterRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRouteRequestParameter operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRouteRequestParameter operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteRouteRequestParameter
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeleteRouteRequestParameter">REST API Reference for DeleteRouteRequestParameter Operation</seealso>
        IAsyncResult BeginDeleteRouteRequestParameter(DeleteRouteRequestParameterRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteRouteRequestParameter operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRouteRequestParameter.</param>
        /// 
        /// <returns>Returns a  DeleteRouteRequestParameterResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeleteRouteRequestParameter">REST API Reference for DeleteRouteRequestParameter Operation</seealso>
        DeleteRouteRequestParameterResponse EndDeleteRouteRequestParameter(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteRouteResponse


        /// <summary>
        /// Deletes a RouteResponse.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRouteResponse service method.</param>
        /// 
        /// <returns>The response from the DeleteRouteResponse service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeleteRouteResponse">REST API Reference for DeleteRouteResponse Operation</seealso>
        DeleteRouteResponseResponse DeleteRouteResponse(DeleteRouteResponseRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRouteResponse operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRouteResponse operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteRouteResponse
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeleteRouteResponse">REST API Reference for DeleteRouteResponse Operation</seealso>
        IAsyncResult BeginDeleteRouteResponse(DeleteRouteResponseRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteRouteResponse operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRouteResponse.</param>
        /// 
        /// <returns>Returns a  DeleteRouteResponseResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeleteRouteResponse">REST API Reference for DeleteRouteResponse Operation</seealso>
        DeleteRouteResponseResponse EndDeleteRouteResponse(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteRouteSettings


        /// <summary>
        /// Deletes the RouteSettings for a stage.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRouteSettings service method.</param>
        /// 
        /// <returns>The response from the DeleteRouteSettings service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeleteRouteSettings">REST API Reference for DeleteRouteSettings Operation</seealso>
        DeleteRouteSettingsResponse DeleteRouteSettings(DeleteRouteSettingsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRouteSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRouteSettings operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteRouteSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeleteRouteSettings">REST API Reference for DeleteRouteSettings Operation</seealso>
        IAsyncResult BeginDeleteRouteSettings(DeleteRouteSettingsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteRouteSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRouteSettings.</param>
        /// 
        /// <returns>Returns a  DeleteRouteSettingsResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeleteRouteSettings">REST API Reference for DeleteRouteSettings Operation</seealso>
        DeleteRouteSettingsResponse EndDeleteRouteSettings(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteRoutingRule


        /// <summary>
        /// Deletes a routing rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRoutingRule service method.</param>
        /// 
        /// <returns>The response from the DeleteRoutingRule service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeleteRoutingRule">REST API Reference for DeleteRoutingRule Operation</seealso>
        DeleteRoutingRuleResponse DeleteRoutingRule(DeleteRoutingRuleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRoutingRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRoutingRule operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteRoutingRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeleteRoutingRule">REST API Reference for DeleteRoutingRule Operation</seealso>
        IAsyncResult BeginDeleteRoutingRule(DeleteRoutingRuleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteRoutingRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRoutingRule.</param>
        /// 
        /// <returns>Returns a  DeleteRoutingRuleResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeleteRoutingRule">REST API Reference for DeleteRoutingRule Operation</seealso>
        DeleteRoutingRuleResponse EndDeleteRoutingRule(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteStage


        /// <summary>
        /// Deletes a Stage.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteStage service method.</param>
        /// 
        /// <returns>The response from the DeleteStage service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeleteStage">REST API Reference for DeleteStage Operation</seealso>
        DeleteStageResponse DeleteStage(DeleteStageRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteStage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteStage operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteStage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeleteStage">REST API Reference for DeleteStage Operation</seealso>
        IAsyncResult BeginDeleteStage(DeleteStageRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteStage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteStage.</param>
        /// 
        /// <returns>Returns a  DeleteStageResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeleteStage">REST API Reference for DeleteStage Operation</seealso>
        DeleteStageResponse EndDeleteStage(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteVpcLink


        /// <summary>
        /// Deletes a VPC link.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVpcLink service method.</param>
        /// 
        /// <returns>The response from the DeleteVpcLink service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeleteVpcLink">REST API Reference for DeleteVpcLink Operation</seealso>
        DeleteVpcLinkResponse DeleteVpcLink(DeleteVpcLinkRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVpcLink operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVpcLink operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteVpcLink
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeleteVpcLink">REST API Reference for DeleteVpcLink Operation</seealso>
        IAsyncResult BeginDeleteVpcLink(DeleteVpcLinkRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteVpcLink operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteVpcLink.</param>
        /// 
        /// <returns>Returns a  DeleteVpcLinkResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeleteVpcLink">REST API Reference for DeleteVpcLink Operation</seealso>
        DeleteVpcLinkResponse EndDeleteVpcLink(IAsyncResult asyncResult);

        #endregion
        
        #region  DisablePortal


        /// <summary>
        /// Deletes the publication of a portal portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisablePortal service method.</param>
        /// 
        /// <returns>The response from the DisablePortal service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DisablePortal">REST API Reference for DisablePortal Operation</seealso>
        DisablePortalResponse DisablePortal(DisablePortalRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisablePortal operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisablePortal operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisablePortal
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DisablePortal">REST API Reference for DisablePortal Operation</seealso>
        IAsyncResult BeginDisablePortal(DisablePortalRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisablePortal operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisablePortal.</param>
        /// 
        /// <returns>Returns a  DisablePortalResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DisablePortal">REST API Reference for DisablePortal Operation</seealso>
        DisablePortalResponse EndDisablePortal(IAsyncResult asyncResult);

        #endregion
        
        #region  ExportApi


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExportApi service method.</param>
        /// 
        /// <returns>The response from the ExportApi service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/ExportApi">REST API Reference for ExportApi Operation</seealso>
        ExportApiResponse ExportApi(ExportApiRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ExportApi operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ExportApi operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndExportApi
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/ExportApi">REST API Reference for ExportApi Operation</seealso>
        IAsyncResult BeginExportApi(ExportApiRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ExportApi operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginExportApi.</param>
        /// 
        /// <returns>Returns a  ExportApiResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/ExportApi">REST API Reference for ExportApi Operation</seealso>
        ExportApiResponse EndExportApi(IAsyncResult asyncResult);

        #endregion
        
        #region  GetApi


        /// <summary>
        /// Gets an Api resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApi service method.</param>
        /// 
        /// <returns>The response from the GetApi service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetApi">REST API Reference for GetApi Operation</seealso>
        GetApiResponse GetApi(GetApiRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetApi operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetApi operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetApi
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetApi">REST API Reference for GetApi Operation</seealso>
        IAsyncResult BeginGetApi(GetApiRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetApi operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetApi.</param>
        /// 
        /// <returns>Returns a  GetApiResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetApi">REST API Reference for GetApi Operation</seealso>
        GetApiResponse EndGetApi(IAsyncResult asyncResult);

        #endregion
        
        #region  GetApiMapping


        /// <summary>
        /// Gets an API mapping.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApiMapping service method.</param>
        /// 
        /// <returns>The response from the GetApiMapping service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetApiMapping">REST API Reference for GetApiMapping Operation</seealso>
        GetApiMappingResponse GetApiMapping(GetApiMappingRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetApiMapping operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetApiMapping operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetApiMapping
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetApiMapping">REST API Reference for GetApiMapping Operation</seealso>
        IAsyncResult BeginGetApiMapping(GetApiMappingRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetApiMapping operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetApiMapping.</param>
        /// 
        /// <returns>Returns a  GetApiMappingResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetApiMapping">REST API Reference for GetApiMapping Operation</seealso>
        GetApiMappingResponse EndGetApiMapping(IAsyncResult asyncResult);

        #endregion
        
        #region  GetApiMappings


        /// <summary>
        /// Gets API mappings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApiMappings service method.</param>
        /// 
        /// <returns>The response from the GetApiMappings service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetApiMappings">REST API Reference for GetApiMappings Operation</seealso>
        GetApiMappingsResponse GetApiMappings(GetApiMappingsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetApiMappings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetApiMappings operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetApiMappings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetApiMappings">REST API Reference for GetApiMappings Operation</seealso>
        IAsyncResult BeginGetApiMappings(GetApiMappingsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetApiMappings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetApiMappings.</param>
        /// 
        /// <returns>Returns a  GetApiMappingsResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetApiMappings">REST API Reference for GetApiMappings Operation</seealso>
        GetApiMappingsResponse EndGetApiMappings(IAsyncResult asyncResult);

        #endregion
        
        #region  GetApis


        /// <summary>
        /// Gets a collection of Api resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApis service method.</param>
        /// 
        /// <returns>The response from the GetApis service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetApis">REST API Reference for GetApis Operation</seealso>
        GetApisResponse GetApis(GetApisRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetApis operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetApis operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetApis
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetApis">REST API Reference for GetApis Operation</seealso>
        IAsyncResult BeginGetApis(GetApisRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetApis operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetApis.</param>
        /// 
        /// <returns>Returns a  GetApisResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetApis">REST API Reference for GetApis Operation</seealso>
        GetApisResponse EndGetApis(IAsyncResult asyncResult);

        #endregion
        
        #region  GetAuthorizer


        /// <summary>
        /// Gets an Authorizer.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAuthorizer service method.</param>
        /// 
        /// <returns>The response from the GetAuthorizer service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetAuthorizer">REST API Reference for GetAuthorizer Operation</seealso>
        GetAuthorizerResponse GetAuthorizer(GetAuthorizerRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetAuthorizer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAuthorizer operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAuthorizer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetAuthorizer">REST API Reference for GetAuthorizer Operation</seealso>
        IAsyncResult BeginGetAuthorizer(GetAuthorizerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetAuthorizer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAuthorizer.</param>
        /// 
        /// <returns>Returns a  GetAuthorizerResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetAuthorizer">REST API Reference for GetAuthorizer Operation</seealso>
        GetAuthorizerResponse EndGetAuthorizer(IAsyncResult asyncResult);

        #endregion
        
        #region  GetAuthorizers


        /// <summary>
        /// Gets the Authorizers for an API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAuthorizers service method.</param>
        /// 
        /// <returns>The response from the GetAuthorizers service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetAuthorizers">REST API Reference for GetAuthorizers Operation</seealso>
        GetAuthorizersResponse GetAuthorizers(GetAuthorizersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetAuthorizers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAuthorizers operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAuthorizers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetAuthorizers">REST API Reference for GetAuthorizers Operation</seealso>
        IAsyncResult BeginGetAuthorizers(GetAuthorizersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetAuthorizers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAuthorizers.</param>
        /// 
        /// <returns>Returns a  GetAuthorizersResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetAuthorizers">REST API Reference for GetAuthorizers Operation</seealso>
        GetAuthorizersResponse EndGetAuthorizers(IAsyncResult asyncResult);

        #endregion
        
        #region  GetDeployment


        /// <summary>
        /// Gets a Deployment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDeployment service method.</param>
        /// 
        /// <returns>The response from the GetDeployment service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetDeployment">REST API Reference for GetDeployment Operation</seealso>
        GetDeploymentResponse GetDeployment(GetDeploymentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetDeployment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDeployment operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDeployment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetDeployment">REST API Reference for GetDeployment Operation</seealso>
        IAsyncResult BeginGetDeployment(GetDeploymentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetDeployment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDeployment.</param>
        /// 
        /// <returns>Returns a  GetDeploymentResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetDeployment">REST API Reference for GetDeployment Operation</seealso>
        GetDeploymentResponse EndGetDeployment(IAsyncResult asyncResult);

        #endregion
        
        #region  GetDeployments


        /// <summary>
        /// Gets the Deployments for an API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDeployments service method.</param>
        /// 
        /// <returns>The response from the GetDeployments service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetDeployments">REST API Reference for GetDeployments Operation</seealso>
        GetDeploymentsResponse GetDeployments(GetDeploymentsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetDeployments operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDeployments operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDeployments
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetDeployments">REST API Reference for GetDeployments Operation</seealso>
        IAsyncResult BeginGetDeployments(GetDeploymentsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetDeployments operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDeployments.</param>
        /// 
        /// <returns>Returns a  GetDeploymentsResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetDeployments">REST API Reference for GetDeployments Operation</seealso>
        GetDeploymentsResponse EndGetDeployments(IAsyncResult asyncResult);

        #endregion
        
        #region  GetDomainName


        /// <summary>
        /// Gets a domain name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDomainName service method.</param>
        /// 
        /// <returns>The response from the GetDomainName service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetDomainName">REST API Reference for GetDomainName Operation</seealso>
        GetDomainNameResponse GetDomainName(GetDomainNameRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetDomainName operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDomainName operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDomainName
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetDomainName">REST API Reference for GetDomainName Operation</seealso>
        IAsyncResult BeginGetDomainName(GetDomainNameRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetDomainName operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDomainName.</param>
        /// 
        /// <returns>Returns a  GetDomainNameResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetDomainName">REST API Reference for GetDomainName Operation</seealso>
        GetDomainNameResponse EndGetDomainName(IAsyncResult asyncResult);

        #endregion
        
        #region  GetDomainNames


        /// <summary>
        /// Gets the domain names for an AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDomainNames service method.</param>
        /// 
        /// <returns>The response from the GetDomainNames service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetDomainNames">REST API Reference for GetDomainNames Operation</seealso>
        GetDomainNamesResponse GetDomainNames(GetDomainNamesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetDomainNames operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDomainNames operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDomainNames
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetDomainNames">REST API Reference for GetDomainNames Operation</seealso>
        IAsyncResult BeginGetDomainNames(GetDomainNamesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetDomainNames operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDomainNames.</param>
        /// 
        /// <returns>Returns a  GetDomainNamesResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetDomainNames">REST API Reference for GetDomainNames Operation</seealso>
        GetDomainNamesResponse EndGetDomainNames(IAsyncResult asyncResult);

        #endregion
        
        #region  GetIntegration


        /// <summary>
        /// Gets an Integration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIntegration service method.</param>
        /// 
        /// <returns>The response from the GetIntegration service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetIntegration">REST API Reference for GetIntegration Operation</seealso>
        GetIntegrationResponse GetIntegration(GetIntegrationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetIntegration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetIntegration operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetIntegration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetIntegration">REST API Reference for GetIntegration Operation</seealso>
        IAsyncResult BeginGetIntegration(GetIntegrationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetIntegration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetIntegration.</param>
        /// 
        /// <returns>Returns a  GetIntegrationResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetIntegration">REST API Reference for GetIntegration Operation</seealso>
        GetIntegrationResponse EndGetIntegration(IAsyncResult asyncResult);

        #endregion
        
        #region  GetIntegrationResponse


        /// <summary>
        /// Gets an IntegrationResponses.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIntegrationResponse service method.</param>
        /// 
        /// <returns>The response from the GetIntegrationResponse service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetIntegrationResponse">REST API Reference for GetIntegrationResponse Operation</seealso>
        GetIntegrationResponseResponse GetIntegrationResponse(GetIntegrationResponseRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetIntegrationResponse operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetIntegrationResponse operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetIntegrationResponse
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetIntegrationResponse">REST API Reference for GetIntegrationResponse Operation</seealso>
        IAsyncResult BeginGetIntegrationResponse(GetIntegrationResponseRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetIntegrationResponse operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetIntegrationResponse.</param>
        /// 
        /// <returns>Returns a  GetIntegrationResponseResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetIntegrationResponse">REST API Reference for GetIntegrationResponse Operation</seealso>
        GetIntegrationResponseResponse EndGetIntegrationResponse(IAsyncResult asyncResult);

        #endregion
        
        #region  GetIntegrationResponses


        /// <summary>
        /// Gets the IntegrationResponses for an Integration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIntegrationResponses service method.</param>
        /// 
        /// <returns>The response from the GetIntegrationResponses service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetIntegrationResponses">REST API Reference for GetIntegrationResponses Operation</seealso>
        GetIntegrationResponsesResponse GetIntegrationResponses(GetIntegrationResponsesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetIntegrationResponses operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetIntegrationResponses operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetIntegrationResponses
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetIntegrationResponses">REST API Reference for GetIntegrationResponses Operation</seealso>
        IAsyncResult BeginGetIntegrationResponses(GetIntegrationResponsesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetIntegrationResponses operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetIntegrationResponses.</param>
        /// 
        /// <returns>Returns a  GetIntegrationResponsesResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetIntegrationResponses">REST API Reference for GetIntegrationResponses Operation</seealso>
        GetIntegrationResponsesResponse EndGetIntegrationResponses(IAsyncResult asyncResult);

        #endregion
        
        #region  GetIntegrations


        /// <summary>
        /// Gets the Integrations for an API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIntegrations service method.</param>
        /// 
        /// <returns>The response from the GetIntegrations service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetIntegrations">REST API Reference for GetIntegrations Operation</seealso>
        GetIntegrationsResponse GetIntegrations(GetIntegrationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetIntegrations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetIntegrations operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetIntegrations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetIntegrations">REST API Reference for GetIntegrations Operation</seealso>
        IAsyncResult BeginGetIntegrations(GetIntegrationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetIntegrations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetIntegrations.</param>
        /// 
        /// <returns>Returns a  GetIntegrationsResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetIntegrations">REST API Reference for GetIntegrations Operation</seealso>
        GetIntegrationsResponse EndGetIntegrations(IAsyncResult asyncResult);

        #endregion
        
        #region  GetModel


        /// <summary>
        /// Gets a Model.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetModel service method.</param>
        /// 
        /// <returns>The response from the GetModel service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetModel">REST API Reference for GetModel Operation</seealso>
        GetModelResponse GetModel(GetModelRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetModel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetModel operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetModel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetModel">REST API Reference for GetModel Operation</seealso>
        IAsyncResult BeginGetModel(GetModelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetModel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetModel.</param>
        /// 
        /// <returns>Returns a  GetModelResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetModel">REST API Reference for GetModel Operation</seealso>
        GetModelResponse EndGetModel(IAsyncResult asyncResult);

        #endregion
        
        #region  GetModels


        /// <summary>
        /// Gets the Models for an API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetModels service method.</param>
        /// 
        /// <returns>The response from the GetModels service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetModels">REST API Reference for GetModels Operation</seealso>
        GetModelsResponse GetModels(GetModelsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetModels operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetModels operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetModels
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetModels">REST API Reference for GetModels Operation</seealso>
        IAsyncResult BeginGetModels(GetModelsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetModels operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetModels.</param>
        /// 
        /// <returns>Returns a  GetModelsResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetModels">REST API Reference for GetModels Operation</seealso>
        GetModelsResponse EndGetModels(IAsyncResult asyncResult);

        #endregion
        
        #region  GetModelTemplate


        /// <summary>
        /// Gets a model template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetModelTemplate service method.</param>
        /// 
        /// <returns>The response from the GetModelTemplate service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetModelTemplate">REST API Reference for GetModelTemplate Operation</seealso>
        GetModelTemplateResponse GetModelTemplate(GetModelTemplateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetModelTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetModelTemplate operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetModelTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetModelTemplate">REST API Reference for GetModelTemplate Operation</seealso>
        IAsyncResult BeginGetModelTemplate(GetModelTemplateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetModelTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetModelTemplate.</param>
        /// 
        /// <returns>Returns a  GetModelTemplateResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetModelTemplate">REST API Reference for GetModelTemplate Operation</seealso>
        GetModelTemplateResponse EndGetModelTemplate(IAsyncResult asyncResult);

        #endregion
        
        #region  GetPortal


        /// <summary>
        /// Gets a portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPortal service method.</param>
        /// 
        /// <returns>The response from the GetPortal service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetPortal">REST API Reference for GetPortal Operation</seealso>
        GetPortalResponse GetPortal(GetPortalRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetPortal operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPortal operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPortal
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetPortal">REST API Reference for GetPortal Operation</seealso>
        IAsyncResult BeginGetPortal(GetPortalRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetPortal operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPortal.</param>
        /// 
        /// <returns>Returns a  GetPortalResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetPortal">REST API Reference for GetPortal Operation</seealso>
        GetPortalResponse EndGetPortal(IAsyncResult asyncResult);

        #endregion
        
        #region  GetPortalProduct


        /// <summary>
        /// Gets a portal product.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPortalProduct service method.</param>
        /// 
        /// <returns>The response from the GetPortalProduct service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetPortalProduct">REST API Reference for GetPortalProduct Operation</seealso>
        GetPortalProductResponse GetPortalProduct(GetPortalProductRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetPortalProduct operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPortalProduct operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPortalProduct
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetPortalProduct">REST API Reference for GetPortalProduct Operation</seealso>
        IAsyncResult BeginGetPortalProduct(GetPortalProductRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetPortalProduct operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPortalProduct.</param>
        /// 
        /// <returns>Returns a  GetPortalProductResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetPortalProduct">REST API Reference for GetPortalProduct Operation</seealso>
        GetPortalProductResponse EndGetPortalProduct(IAsyncResult asyncResult);

        #endregion
        
        #region  GetPortalProductSharingPolicy


        /// <summary>
        /// Gets the sharing policy for a portal product.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPortalProductSharingPolicy service method.</param>
        /// 
        /// <returns>The response from the GetPortalProductSharingPolicy service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetPortalProductSharingPolicy">REST API Reference for GetPortalProductSharingPolicy Operation</seealso>
        GetPortalProductSharingPolicyResponse GetPortalProductSharingPolicy(GetPortalProductSharingPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetPortalProductSharingPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPortalProductSharingPolicy operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPortalProductSharingPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetPortalProductSharingPolicy">REST API Reference for GetPortalProductSharingPolicy Operation</seealso>
        IAsyncResult BeginGetPortalProductSharingPolicy(GetPortalProductSharingPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetPortalProductSharingPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPortalProductSharingPolicy.</param>
        /// 
        /// <returns>Returns a  GetPortalProductSharingPolicyResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetPortalProductSharingPolicy">REST API Reference for GetPortalProductSharingPolicy Operation</seealso>
        GetPortalProductSharingPolicyResponse EndGetPortalProductSharingPolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  GetProductPage


        /// <summary>
        /// Gets a product page of a portal product.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProductPage service method.</param>
        /// 
        /// <returns>The response from the GetProductPage service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetProductPage">REST API Reference for GetProductPage Operation</seealso>
        GetProductPageResponse GetProductPage(GetProductPageRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetProductPage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetProductPage operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetProductPage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetProductPage">REST API Reference for GetProductPage Operation</seealso>
        IAsyncResult BeginGetProductPage(GetProductPageRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetProductPage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetProductPage.</param>
        /// 
        /// <returns>Returns a  GetProductPageResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetProductPage">REST API Reference for GetProductPage Operation</seealso>
        GetProductPageResponse EndGetProductPage(IAsyncResult asyncResult);

        #endregion
        
        #region  GetProductRestEndpointPage


        /// <summary>
        /// Gets a product REST endpoint page.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProductRestEndpointPage service method.</param>
        /// 
        /// <returns>The response from the GetProductRestEndpointPage service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetProductRestEndpointPage">REST API Reference for GetProductRestEndpointPage Operation</seealso>
        GetProductRestEndpointPageResponse GetProductRestEndpointPage(GetProductRestEndpointPageRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetProductRestEndpointPage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetProductRestEndpointPage operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetProductRestEndpointPage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetProductRestEndpointPage">REST API Reference for GetProductRestEndpointPage Operation</seealso>
        IAsyncResult BeginGetProductRestEndpointPage(GetProductRestEndpointPageRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetProductRestEndpointPage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetProductRestEndpointPage.</param>
        /// 
        /// <returns>Returns a  GetProductRestEndpointPageResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetProductRestEndpointPage">REST API Reference for GetProductRestEndpointPage Operation</seealso>
        GetProductRestEndpointPageResponse EndGetProductRestEndpointPage(IAsyncResult asyncResult);

        #endregion
        
        #region  GetRoute


        /// <summary>
        /// Gets a Route.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRoute service method.</param>
        /// 
        /// <returns>The response from the GetRoute service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetRoute">REST API Reference for GetRoute Operation</seealso>
        GetRouteResponse GetRoute(GetRouteRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetRoute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRoute operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRoute
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetRoute">REST API Reference for GetRoute Operation</seealso>
        IAsyncResult BeginGetRoute(GetRouteRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetRoute operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRoute.</param>
        /// 
        /// <returns>Returns a  GetRouteResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetRoute">REST API Reference for GetRoute Operation</seealso>
        GetRouteResponse EndGetRoute(IAsyncResult asyncResult);

        #endregion
        
        #region  GetRouteResponse


        /// <summary>
        /// Gets a RouteResponse.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRouteResponse service method.</param>
        /// 
        /// <returns>The response from the GetRouteResponse service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetRouteResponse">REST API Reference for GetRouteResponse Operation</seealso>
        GetRouteResponseResponse GetRouteResponse(GetRouteResponseRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetRouteResponse operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRouteResponse operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRouteResponse
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetRouteResponse">REST API Reference for GetRouteResponse Operation</seealso>
        IAsyncResult BeginGetRouteResponse(GetRouteResponseRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetRouteResponse operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRouteResponse.</param>
        /// 
        /// <returns>Returns a  GetRouteResponseResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetRouteResponse">REST API Reference for GetRouteResponse Operation</seealso>
        GetRouteResponseResponse EndGetRouteResponse(IAsyncResult asyncResult);

        #endregion
        
        #region  GetRouteResponses


        /// <summary>
        /// Gets the RouteResponses for a Route.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRouteResponses service method.</param>
        /// 
        /// <returns>The response from the GetRouteResponses service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetRouteResponses">REST API Reference for GetRouteResponses Operation</seealso>
        GetRouteResponsesResponse GetRouteResponses(GetRouteResponsesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetRouteResponses operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRouteResponses operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRouteResponses
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetRouteResponses">REST API Reference for GetRouteResponses Operation</seealso>
        IAsyncResult BeginGetRouteResponses(GetRouteResponsesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetRouteResponses operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRouteResponses.</param>
        /// 
        /// <returns>Returns a  GetRouteResponsesResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetRouteResponses">REST API Reference for GetRouteResponses Operation</seealso>
        GetRouteResponsesResponse EndGetRouteResponses(IAsyncResult asyncResult);

        #endregion
        
        #region  GetRoutes


        /// <summary>
        /// Gets the Routes for an API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRoutes service method.</param>
        /// 
        /// <returns>The response from the GetRoutes service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetRoutes">REST API Reference for GetRoutes Operation</seealso>
        GetRoutesResponse GetRoutes(GetRoutesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetRoutes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRoutes operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRoutes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetRoutes">REST API Reference for GetRoutes Operation</seealso>
        IAsyncResult BeginGetRoutes(GetRoutesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetRoutes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRoutes.</param>
        /// 
        /// <returns>Returns a  GetRoutesResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetRoutes">REST API Reference for GetRoutes Operation</seealso>
        GetRoutesResponse EndGetRoutes(IAsyncResult asyncResult);

        #endregion
        
        #region  GetRoutingRule


        /// <summary>
        /// Gets a routing rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRoutingRule service method.</param>
        /// 
        /// <returns>The response from the GetRoutingRule service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetRoutingRule">REST API Reference for GetRoutingRule Operation</seealso>
        GetRoutingRuleResponse GetRoutingRule(GetRoutingRuleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetRoutingRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRoutingRule operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRoutingRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetRoutingRule">REST API Reference for GetRoutingRule Operation</seealso>
        IAsyncResult BeginGetRoutingRule(GetRoutingRuleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetRoutingRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRoutingRule.</param>
        /// 
        /// <returns>Returns a  GetRoutingRuleResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetRoutingRule">REST API Reference for GetRoutingRule Operation</seealso>
        GetRoutingRuleResponse EndGetRoutingRule(IAsyncResult asyncResult);

        #endregion
        
        #region  GetStage


        /// <summary>
        /// Gets a Stage.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetStage service method.</param>
        /// 
        /// <returns>The response from the GetStage service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetStage">REST API Reference for GetStage Operation</seealso>
        GetStageResponse GetStage(GetStageRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetStage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetStage operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetStage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetStage">REST API Reference for GetStage Operation</seealso>
        IAsyncResult BeginGetStage(GetStageRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetStage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetStage.</param>
        /// 
        /// <returns>Returns a  GetStageResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetStage">REST API Reference for GetStage Operation</seealso>
        GetStageResponse EndGetStage(IAsyncResult asyncResult);

        #endregion
        
        #region  GetStages


        /// <summary>
        /// Gets the Stages for an API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetStages service method.</param>
        /// 
        /// <returns>The response from the GetStages service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetStages">REST API Reference for GetStages Operation</seealso>
        GetStagesResponse GetStages(GetStagesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetStages operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetStages operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetStages
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetStages">REST API Reference for GetStages Operation</seealso>
        IAsyncResult BeginGetStages(GetStagesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetStages operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetStages.</param>
        /// 
        /// <returns>Returns a  GetStagesResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetStages">REST API Reference for GetStages Operation</seealso>
        GetStagesResponse EndGetStages(IAsyncResult asyncResult);

        #endregion
        
        #region  GetTags


        /// <summary>
        /// Gets a collection of Tag resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTags service method.</param>
        /// 
        /// <returns>The response from the GetTags service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetTags">REST API Reference for GetTags Operation</seealso>
        GetTagsResponse GetTags(GetTagsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTags operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTags
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetTags">REST API Reference for GetTags Operation</seealso>
        IAsyncResult BeginGetTags(GetTagsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetTags operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTags.</param>
        /// 
        /// <returns>Returns a  GetTagsResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetTags">REST API Reference for GetTags Operation</seealso>
        GetTagsResponse EndGetTags(IAsyncResult asyncResult);

        #endregion
        
        #region  GetVpcLink


        /// <summary>
        /// Gets a VPC link.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVpcLink service method.</param>
        /// 
        /// <returns>The response from the GetVpcLink service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetVpcLink">REST API Reference for GetVpcLink Operation</seealso>
        GetVpcLinkResponse GetVpcLink(GetVpcLinkRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetVpcLink operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetVpcLink operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetVpcLink
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetVpcLink">REST API Reference for GetVpcLink Operation</seealso>
        IAsyncResult BeginGetVpcLink(GetVpcLinkRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetVpcLink operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetVpcLink.</param>
        /// 
        /// <returns>Returns a  GetVpcLinkResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetVpcLink">REST API Reference for GetVpcLink Operation</seealso>
        GetVpcLinkResponse EndGetVpcLink(IAsyncResult asyncResult);

        #endregion
        
        #region  GetVpcLinks


        /// <summary>
        /// Gets a collection of VPC links.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVpcLinks service method.</param>
        /// 
        /// <returns>The response from the GetVpcLinks service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetVpcLinks">REST API Reference for GetVpcLinks Operation</seealso>
        GetVpcLinksResponse GetVpcLinks(GetVpcLinksRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetVpcLinks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetVpcLinks operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetVpcLinks
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetVpcLinks">REST API Reference for GetVpcLinks Operation</seealso>
        IAsyncResult BeginGetVpcLinks(GetVpcLinksRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetVpcLinks operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetVpcLinks.</param>
        /// 
        /// <returns>Returns a  GetVpcLinksResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetVpcLinks">REST API Reference for GetVpcLinks Operation</seealso>
        GetVpcLinksResponse EndGetVpcLinks(IAsyncResult asyncResult);

        #endregion
        
        #region  ImportApi


        /// <summary>
        /// Imports an API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportApi service method.</param>
        /// 
        /// <returns>The response from the ImportApi service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/ImportApi">REST API Reference for ImportApi Operation</seealso>
        ImportApiResponse ImportApi(ImportApiRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ImportApi operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ImportApi operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndImportApi
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/ImportApi">REST API Reference for ImportApi Operation</seealso>
        IAsyncResult BeginImportApi(ImportApiRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ImportApi operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginImportApi.</param>
        /// 
        /// <returns>Returns a  ImportApiResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/ImportApi">REST API Reference for ImportApi Operation</seealso>
        ImportApiResponse EndImportApi(IAsyncResult asyncResult);

        #endregion
        
        #region  ListPortalProducts


        /// <summary>
        /// Lists portal products.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPortalProducts service method.</param>
        /// 
        /// <returns>The response from the ListPortalProducts service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/ListPortalProducts">REST API Reference for ListPortalProducts Operation</seealso>
        ListPortalProductsResponse ListPortalProducts(ListPortalProductsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListPortalProducts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPortalProducts operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPortalProducts
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/ListPortalProducts">REST API Reference for ListPortalProducts Operation</seealso>
        IAsyncResult BeginListPortalProducts(ListPortalProductsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListPortalProducts operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPortalProducts.</param>
        /// 
        /// <returns>Returns a  ListPortalProductsResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/ListPortalProducts">REST API Reference for ListPortalProducts Operation</seealso>
        ListPortalProductsResponse EndListPortalProducts(IAsyncResult asyncResult);

        #endregion
        
        #region  ListPortals


        /// <summary>
        /// Lists portals.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPortals service method.</param>
        /// 
        /// <returns>The response from the ListPortals service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/ListPortals">REST API Reference for ListPortals Operation</seealso>
        ListPortalsResponse ListPortals(ListPortalsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListPortals operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPortals operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPortals
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/ListPortals">REST API Reference for ListPortals Operation</seealso>
        IAsyncResult BeginListPortals(ListPortalsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListPortals operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPortals.</param>
        /// 
        /// <returns>Returns a  ListPortalsResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/ListPortals">REST API Reference for ListPortals Operation</seealso>
        ListPortalsResponse EndListPortals(IAsyncResult asyncResult);

        #endregion
        
        #region  ListProductPages


        /// <summary>
        /// Lists the product pages for a portal product.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProductPages service method.</param>
        /// 
        /// <returns>The response from the ListProductPages service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/ListProductPages">REST API Reference for ListProductPages Operation</seealso>
        ListProductPagesResponse ListProductPages(ListProductPagesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListProductPages operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListProductPages operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListProductPages
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/ListProductPages">REST API Reference for ListProductPages Operation</seealso>
        IAsyncResult BeginListProductPages(ListProductPagesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListProductPages operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListProductPages.</param>
        /// 
        /// <returns>Returns a  ListProductPagesResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/ListProductPages">REST API Reference for ListProductPages Operation</seealso>
        ListProductPagesResponse EndListProductPages(IAsyncResult asyncResult);

        #endregion
        
        #region  ListProductRestEndpointPages


        /// <summary>
        /// Lists the product REST endpoint pages of a portal product.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProductRestEndpointPages service method.</param>
        /// 
        /// <returns>The response from the ListProductRestEndpointPages service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/ListProductRestEndpointPages">REST API Reference for ListProductRestEndpointPages Operation</seealso>
        ListProductRestEndpointPagesResponse ListProductRestEndpointPages(ListProductRestEndpointPagesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListProductRestEndpointPages operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListProductRestEndpointPages operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListProductRestEndpointPages
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/ListProductRestEndpointPages">REST API Reference for ListProductRestEndpointPages Operation</seealso>
        IAsyncResult BeginListProductRestEndpointPages(ListProductRestEndpointPagesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListProductRestEndpointPages operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListProductRestEndpointPages.</param>
        /// 
        /// <returns>Returns a  ListProductRestEndpointPagesResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/ListProductRestEndpointPages">REST API Reference for ListProductRestEndpointPages Operation</seealso>
        ListProductRestEndpointPagesResponse EndListProductRestEndpointPages(IAsyncResult asyncResult);

        #endregion
        
        #region  ListRoutingRules


        /// <summary>
        /// Lists routing rules.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRoutingRules service method.</param>
        /// 
        /// <returns>The response from the ListRoutingRules service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/ListRoutingRules">REST API Reference for ListRoutingRules Operation</seealso>
        ListRoutingRulesResponse ListRoutingRules(ListRoutingRulesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListRoutingRules operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRoutingRules operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRoutingRules
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/ListRoutingRules">REST API Reference for ListRoutingRules Operation</seealso>
        IAsyncResult BeginListRoutingRules(ListRoutingRulesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListRoutingRules operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRoutingRules.</param>
        /// 
        /// <returns>Returns a  ListRoutingRulesResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/ListRoutingRules">REST API Reference for ListRoutingRules Operation</seealso>
        ListRoutingRulesResponse EndListRoutingRules(IAsyncResult asyncResult);

        #endregion
        
        #region  PreviewPortal


        /// <summary>
        /// Creates a portal preview.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PreviewPortal service method.</param>
        /// 
        /// <returns>The response from the PreviewPortal service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/PreviewPortal">REST API Reference for PreviewPortal Operation</seealso>
        PreviewPortalResponse PreviewPortal(PreviewPortalRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PreviewPortal operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PreviewPortal operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPreviewPortal
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/PreviewPortal">REST API Reference for PreviewPortal Operation</seealso>
        IAsyncResult BeginPreviewPortal(PreviewPortalRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PreviewPortal operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPreviewPortal.</param>
        /// 
        /// <returns>Returns a  PreviewPortalResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/PreviewPortal">REST API Reference for PreviewPortal Operation</seealso>
        PreviewPortalResponse EndPreviewPortal(IAsyncResult asyncResult);

        #endregion
        
        #region  PublishPortal


        /// <summary>
        /// Publishes a portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PublishPortal service method.</param>
        /// 
        /// <returns>The response from the PublishPortal service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/PublishPortal">REST API Reference for PublishPortal Operation</seealso>
        PublishPortalResponse PublishPortal(PublishPortalRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PublishPortal operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PublishPortal operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPublishPortal
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/PublishPortal">REST API Reference for PublishPortal Operation</seealso>
        IAsyncResult BeginPublishPortal(PublishPortalRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PublishPortal operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPublishPortal.</param>
        /// 
        /// <returns>Returns a  PublishPortalResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/PublishPortal">REST API Reference for PublishPortal Operation</seealso>
        PublishPortalResponse EndPublishPortal(IAsyncResult asyncResult);

        #endregion
        
        #region  PutPortalProductSharingPolicy


        /// <summary>
        /// Updates the sharing policy for a portal product.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutPortalProductSharingPolicy service method.</param>
        /// 
        /// <returns>The response from the PutPortalProductSharingPolicy service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/PutPortalProductSharingPolicy">REST API Reference for PutPortalProductSharingPolicy Operation</seealso>
        PutPortalProductSharingPolicyResponse PutPortalProductSharingPolicy(PutPortalProductSharingPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutPortalProductSharingPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutPortalProductSharingPolicy operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutPortalProductSharingPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/PutPortalProductSharingPolicy">REST API Reference for PutPortalProductSharingPolicy Operation</seealso>
        IAsyncResult BeginPutPortalProductSharingPolicy(PutPortalProductSharingPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutPortalProductSharingPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutPortalProductSharingPolicy.</param>
        /// 
        /// <returns>Returns a  PutPortalProductSharingPolicyResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/PutPortalProductSharingPolicy">REST API Reference for PutPortalProductSharingPolicy Operation</seealso>
        PutPortalProductSharingPolicyResponse EndPutPortalProductSharingPolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  PutRoutingRule


        /// <summary>
        /// Updates a routing rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutRoutingRule service method.</param>
        /// 
        /// <returns>The response from the PutRoutingRule service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/PutRoutingRule">REST API Reference for PutRoutingRule Operation</seealso>
        PutRoutingRuleResponse PutRoutingRule(PutRoutingRuleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutRoutingRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutRoutingRule operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutRoutingRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/PutRoutingRule">REST API Reference for PutRoutingRule Operation</seealso>
        IAsyncResult BeginPutRoutingRule(PutRoutingRuleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutRoutingRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutRoutingRule.</param>
        /// 
        /// <returns>Returns a  PutRoutingRuleResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/PutRoutingRule">REST API Reference for PutRoutingRule Operation</seealso>
        PutRoutingRuleResponse EndPutRoutingRule(IAsyncResult asyncResult);

        #endregion
        
        #region  ReimportApi


        /// <summary>
        /// Puts an Api resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ReimportApi service method.</param>
        /// 
        /// <returns>The response from the ReimportApi service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/ReimportApi">REST API Reference for ReimportApi Operation</seealso>
        ReimportApiResponse ReimportApi(ReimportApiRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ReimportApi operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ReimportApi operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndReimportApi
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/ReimportApi">REST API Reference for ReimportApi Operation</seealso>
        IAsyncResult BeginReimportApi(ReimportApiRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ReimportApi operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginReimportApi.</param>
        /// 
        /// <returns>Returns a  ReimportApiResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/ReimportApi">REST API Reference for ReimportApi Operation</seealso>
        ReimportApiResponse EndReimportApi(IAsyncResult asyncResult);

        #endregion
        
        #region  ResetAuthorizersCache


        /// <summary>
        /// Resets all authorizer cache entries on a stage. Supported only for HTTP APIs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResetAuthorizersCache service method.</param>
        /// 
        /// <returns>The response from the ResetAuthorizersCache service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/ResetAuthorizersCache">REST API Reference for ResetAuthorizersCache Operation</seealso>
        ResetAuthorizersCacheResponse ResetAuthorizersCache(ResetAuthorizersCacheRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ResetAuthorizersCache operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResetAuthorizersCache operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndResetAuthorizersCache
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/ResetAuthorizersCache">REST API Reference for ResetAuthorizersCache Operation</seealso>
        IAsyncResult BeginResetAuthorizersCache(ResetAuthorizersCacheRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ResetAuthorizersCache operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginResetAuthorizersCache.</param>
        /// 
        /// <returns>Returns a  ResetAuthorizersCacheResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/ResetAuthorizersCache">REST API Reference for ResetAuthorizersCache Operation</seealso>
        ResetAuthorizersCacheResponse EndResetAuthorizersCache(IAsyncResult asyncResult);

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Creates a new Tag resource to represent a tag.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Deletes a Tag.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateApi


        /// <summary>
        /// Updates an Api resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApi service method.</param>
        /// 
        /// <returns>The response from the UpdateApi service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/UpdateApi">REST API Reference for UpdateApi Operation</seealso>
        UpdateApiResponse UpdateApi(UpdateApiRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateApi operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateApi operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateApi
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/UpdateApi">REST API Reference for UpdateApi Operation</seealso>
        IAsyncResult BeginUpdateApi(UpdateApiRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateApi operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateApi.</param>
        /// 
        /// <returns>Returns a  UpdateApiResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/UpdateApi">REST API Reference for UpdateApi Operation</seealso>
        UpdateApiResponse EndUpdateApi(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateApiMapping


        /// <summary>
        /// The API mapping.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApiMapping service method.</param>
        /// 
        /// <returns>The response from the UpdateApiMapping service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/UpdateApiMapping">REST API Reference for UpdateApiMapping Operation</seealso>
        UpdateApiMappingResponse UpdateApiMapping(UpdateApiMappingRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateApiMapping operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateApiMapping operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateApiMapping
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/UpdateApiMapping">REST API Reference for UpdateApiMapping Operation</seealso>
        IAsyncResult BeginUpdateApiMapping(UpdateApiMappingRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateApiMapping operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateApiMapping.</param>
        /// 
        /// <returns>Returns a  UpdateApiMappingResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/UpdateApiMapping">REST API Reference for UpdateApiMapping Operation</seealso>
        UpdateApiMappingResponse EndUpdateApiMapping(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateAuthorizer


        /// <summary>
        /// Updates an Authorizer.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAuthorizer service method.</param>
        /// 
        /// <returns>The response from the UpdateAuthorizer service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/UpdateAuthorizer">REST API Reference for UpdateAuthorizer Operation</seealso>
        UpdateAuthorizerResponse UpdateAuthorizer(UpdateAuthorizerRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAuthorizer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAuthorizer operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAuthorizer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/UpdateAuthorizer">REST API Reference for UpdateAuthorizer Operation</seealso>
        IAsyncResult BeginUpdateAuthorizer(UpdateAuthorizerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAuthorizer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAuthorizer.</param>
        /// 
        /// <returns>Returns a  UpdateAuthorizerResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/UpdateAuthorizer">REST API Reference for UpdateAuthorizer Operation</seealso>
        UpdateAuthorizerResponse EndUpdateAuthorizer(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateDeployment


        /// <summary>
        /// Updates a Deployment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDeployment service method.</param>
        /// 
        /// <returns>The response from the UpdateDeployment service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/UpdateDeployment">REST API Reference for UpdateDeployment Operation</seealso>
        UpdateDeploymentResponse UpdateDeployment(UpdateDeploymentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDeployment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDeployment operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDeployment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/UpdateDeployment">REST API Reference for UpdateDeployment Operation</seealso>
        IAsyncResult BeginUpdateDeployment(UpdateDeploymentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDeployment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDeployment.</param>
        /// 
        /// <returns>Returns a  UpdateDeploymentResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/UpdateDeployment">REST API Reference for UpdateDeployment Operation</seealso>
        UpdateDeploymentResponse EndUpdateDeployment(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateDomainName


        /// <summary>
        /// Updates a domain name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDomainName service method.</param>
        /// 
        /// <returns>The response from the UpdateDomainName service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/UpdateDomainName">REST API Reference for UpdateDomainName Operation</seealso>
        UpdateDomainNameResponse UpdateDomainName(UpdateDomainNameRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDomainName operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDomainName operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDomainName
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/UpdateDomainName">REST API Reference for UpdateDomainName Operation</seealso>
        IAsyncResult BeginUpdateDomainName(UpdateDomainNameRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDomainName operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDomainName.</param>
        /// 
        /// <returns>Returns a  UpdateDomainNameResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/UpdateDomainName">REST API Reference for UpdateDomainName Operation</seealso>
        UpdateDomainNameResponse EndUpdateDomainName(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateIntegration


        /// <summary>
        /// Updates an Integration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateIntegration service method.</param>
        /// 
        /// <returns>The response from the UpdateIntegration service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/UpdateIntegration">REST API Reference for UpdateIntegration Operation</seealso>
        UpdateIntegrationResponse UpdateIntegration(UpdateIntegrationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateIntegration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateIntegration operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateIntegration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/UpdateIntegration">REST API Reference for UpdateIntegration Operation</seealso>
        IAsyncResult BeginUpdateIntegration(UpdateIntegrationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateIntegration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateIntegration.</param>
        /// 
        /// <returns>Returns a  UpdateIntegrationResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/UpdateIntegration">REST API Reference for UpdateIntegration Operation</seealso>
        UpdateIntegrationResponse EndUpdateIntegration(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateIntegrationResponse


        /// <summary>
        /// Updates an IntegrationResponses.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateIntegrationResponse service method.</param>
        /// 
        /// <returns>The response from the UpdateIntegrationResponse service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/UpdateIntegrationResponse">REST API Reference for UpdateIntegrationResponse Operation</seealso>
        UpdateIntegrationResponseResponse UpdateIntegrationResponse(UpdateIntegrationResponseRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateIntegrationResponse operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateIntegrationResponse operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateIntegrationResponse
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/UpdateIntegrationResponse">REST API Reference for UpdateIntegrationResponse Operation</seealso>
        IAsyncResult BeginUpdateIntegrationResponse(UpdateIntegrationResponseRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateIntegrationResponse operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateIntegrationResponse.</param>
        /// 
        /// <returns>Returns a  UpdateIntegrationResponseResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/UpdateIntegrationResponse">REST API Reference for UpdateIntegrationResponse Operation</seealso>
        UpdateIntegrationResponseResponse EndUpdateIntegrationResponse(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateModel


        /// <summary>
        /// Updates a Model.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateModel service method.</param>
        /// 
        /// <returns>The response from the UpdateModel service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/UpdateModel">REST API Reference for UpdateModel Operation</seealso>
        UpdateModelResponse UpdateModel(UpdateModelRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateModel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateModel operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateModel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/UpdateModel">REST API Reference for UpdateModel Operation</seealso>
        IAsyncResult BeginUpdateModel(UpdateModelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateModel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateModel.</param>
        /// 
        /// <returns>Returns a  UpdateModelResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/UpdateModel">REST API Reference for UpdateModel Operation</seealso>
        UpdateModelResponse EndUpdateModel(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdatePortal


        /// <summary>
        /// Updates a portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePortal service method.</param>
        /// 
        /// <returns>The response from the UpdatePortal service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/UpdatePortal">REST API Reference for UpdatePortal Operation</seealso>
        UpdatePortalResponse UpdatePortal(UpdatePortalRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdatePortal operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdatePortal operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdatePortal
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/UpdatePortal">REST API Reference for UpdatePortal Operation</seealso>
        IAsyncResult BeginUpdatePortal(UpdatePortalRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdatePortal operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdatePortal.</param>
        /// 
        /// <returns>Returns a  UpdatePortalResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/UpdatePortal">REST API Reference for UpdatePortal Operation</seealso>
        UpdatePortalResponse EndUpdatePortal(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdatePortalProduct


        /// <summary>
        /// Updates the portal product.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePortalProduct service method.</param>
        /// 
        /// <returns>The response from the UpdatePortalProduct service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/UpdatePortalProduct">REST API Reference for UpdatePortalProduct Operation</seealso>
        UpdatePortalProductResponse UpdatePortalProduct(UpdatePortalProductRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdatePortalProduct operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdatePortalProduct operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdatePortalProduct
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/UpdatePortalProduct">REST API Reference for UpdatePortalProduct Operation</seealso>
        IAsyncResult BeginUpdatePortalProduct(UpdatePortalProductRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdatePortalProduct operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdatePortalProduct.</param>
        /// 
        /// <returns>Returns a  UpdatePortalProductResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/UpdatePortalProduct">REST API Reference for UpdatePortalProduct Operation</seealso>
        UpdatePortalProductResponse EndUpdatePortalProduct(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateProductPage


        /// <summary>
        /// Updates a product page of a portal product.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProductPage service method.</param>
        /// 
        /// <returns>The response from the UpdateProductPage service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/UpdateProductPage">REST API Reference for UpdateProductPage Operation</seealso>
        UpdateProductPageResponse UpdateProductPage(UpdateProductPageRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateProductPage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateProductPage operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateProductPage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/UpdateProductPage">REST API Reference for UpdateProductPage Operation</seealso>
        IAsyncResult BeginUpdateProductPage(UpdateProductPageRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateProductPage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateProductPage.</param>
        /// 
        /// <returns>Returns a  UpdateProductPageResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/UpdateProductPage">REST API Reference for UpdateProductPage Operation</seealso>
        UpdateProductPageResponse EndUpdateProductPage(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateProductRestEndpointPage


        /// <summary>
        /// Updates a product REST endpoint page.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProductRestEndpointPage service method.</param>
        /// 
        /// <returns>The response from the UpdateProductRestEndpointPage service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/UpdateProductRestEndpointPage">REST API Reference for UpdateProductRestEndpointPage Operation</seealso>
        UpdateProductRestEndpointPageResponse UpdateProductRestEndpointPage(UpdateProductRestEndpointPageRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateProductRestEndpointPage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateProductRestEndpointPage operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateProductRestEndpointPage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/UpdateProductRestEndpointPage">REST API Reference for UpdateProductRestEndpointPage Operation</seealso>
        IAsyncResult BeginUpdateProductRestEndpointPage(UpdateProductRestEndpointPageRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateProductRestEndpointPage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateProductRestEndpointPage.</param>
        /// 
        /// <returns>Returns a  UpdateProductRestEndpointPageResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/UpdateProductRestEndpointPage">REST API Reference for UpdateProductRestEndpointPage Operation</seealso>
        UpdateProductRestEndpointPageResponse EndUpdateProductRestEndpointPage(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateRoute


        /// <summary>
        /// Updates a Route.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRoute service method.</param>
        /// 
        /// <returns>The response from the UpdateRoute service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/UpdateRoute">REST API Reference for UpdateRoute Operation</seealso>
        UpdateRouteResponse UpdateRoute(UpdateRouteRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateRoute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateRoute operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateRoute
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/UpdateRoute">REST API Reference for UpdateRoute Operation</seealso>
        IAsyncResult BeginUpdateRoute(UpdateRouteRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateRoute operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateRoute.</param>
        /// 
        /// <returns>Returns a  UpdateRouteResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/UpdateRoute">REST API Reference for UpdateRoute Operation</seealso>
        UpdateRouteResponse EndUpdateRoute(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateRouteResponse


        /// <summary>
        /// Updates a RouteResponse.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRouteResponse service method.</param>
        /// 
        /// <returns>The response from the UpdateRouteResponse service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/UpdateRouteResponse">REST API Reference for UpdateRouteResponse Operation</seealso>
        UpdateRouteResponseResponse UpdateRouteResponse(UpdateRouteResponseRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateRouteResponse operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateRouteResponse operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateRouteResponse
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/UpdateRouteResponse">REST API Reference for UpdateRouteResponse Operation</seealso>
        IAsyncResult BeginUpdateRouteResponse(UpdateRouteResponseRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateRouteResponse operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateRouteResponse.</param>
        /// 
        /// <returns>Returns a  UpdateRouteResponseResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/UpdateRouteResponse">REST API Reference for UpdateRouteResponse Operation</seealso>
        UpdateRouteResponseResponse EndUpdateRouteResponse(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateStage


        /// <summary>
        /// Updates a Stage.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateStage service method.</param>
        /// 
        /// <returns>The response from the UpdateStage service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/UpdateStage">REST API Reference for UpdateStage Operation</seealso>
        UpdateStageResponse UpdateStage(UpdateStageRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateStage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateStage operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateStage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/UpdateStage">REST API Reference for UpdateStage Operation</seealso>
        IAsyncResult BeginUpdateStage(UpdateStageRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateStage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateStage.</param>
        /// 
        /// <returns>Returns a  UpdateStageResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/UpdateStage">REST API Reference for UpdateStage Operation</seealso>
        UpdateStageResponse EndUpdateStage(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateVpcLink


        /// <summary>
        /// Updates a VPC link.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateVpcLink service method.</param>
        /// 
        /// <returns>The response from the UpdateVpcLink service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/UpdateVpcLink">REST API Reference for UpdateVpcLink Operation</seealso>
        UpdateVpcLinkResponse UpdateVpcLink(UpdateVpcLinkRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateVpcLink operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateVpcLink operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateVpcLink
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/UpdateVpcLink">REST API Reference for UpdateVpcLink Operation</seealso>
        IAsyncResult BeginUpdateVpcLink(UpdateVpcLinkRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateVpcLink operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateVpcLink.</param>
        /// 
        /// <returns>Returns a  UpdateVpcLinkResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/UpdateVpcLink">REST API Reference for UpdateVpcLink Operation</seealso>
        UpdateVpcLinkResponse EndUpdateVpcLink(IAsyncResult asyncResult);

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