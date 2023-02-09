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
 * Do not modify this file. This file is generated from the migration-hub-refactor-spaces-2021-10-26.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.MigrationHubRefactorSpaces.Model;

namespace Amazon.MigrationHubRefactorSpaces
{
    /// <summary>
    /// Interface for accessing MigrationHubRefactorSpaces
    ///
    /// Amazon Web Services Migration Hub Refactor Spaces 
    /// <para>
    /// This API reference provides descriptions, syntax, and other details about each of
    /// the actions and data types for Amazon Web Services Migration Hub Refactor Spaces (Refactor
    /// Spaces). The topic for each action shows the API request parameters and the response.
    /// Alternatively, you can use one of the Amazon Web Services SDKs to access an API that
    /// is tailored to the programming language or platform that you're using. For more information,
    /// see <a href="https://aws.amazon.com/tools/#SDKs">Amazon Web Services SDKs</a>.
    /// 
    ///  
    /// <para>
    /// To share Refactor Spaces environments with other Amazon Web Services accounts or with
    /// Organizations and their OUs, use Resource Access Manager's <code>CreateResourceShare</code>
    /// API. See <a href="https://docs.aws.amazon.com/ram/latest/APIReference/API_CreateResourceShare.html">CreateResourceShare</a>
    /// in the <i>Amazon Web Services RAM API Reference</i>.
    /// </para>
    /// 
    /// </para>
    /// </summary>
    public partial interface IAmazonMigrationHubRefactorSpaces : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IMigrationHubRefactorSpacesPaginatorFactory Paginators { get; }
#endif


        
        #region  CreateApplication


        /// <summary>
        /// Creates an Amazon Web Services Migration Hub Refactor Spaces application. The account
        /// that owns the environment also owns the applications created inside the environment,
        /// regardless of the account that creates the application. Refactor Spaces provisions
        /// an Amazon API Gateway, API Gateway VPC link, and Network Load Balancer for the application
        /// proxy inside your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateApplication service method.</param>
        /// 
        /// <returns>The response from the CreateApplication service method, as returned by MigrationHubRefactorSpaces.</returns>
        /// <exception cref="Amazon.MigrationHubRefactorSpaces.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubRefactorSpaces.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubRefactorSpaces.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubRefactorSpaces.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubRefactorSpaces.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubRefactorSpaces.Model.ThrottlingException">
        /// Request was denied because the request was throttled.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubRefactorSpaces.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migration-hub-refactor-spaces-2021-10-26/CreateApplication">REST API Reference for CreateApplication Operation</seealso>
        CreateApplicationResponse CreateApplication(CreateApplicationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateApplication operation on AmazonMigrationHubRefactorSpacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateApplication
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migration-hub-refactor-spaces-2021-10-26/CreateApplication">REST API Reference for CreateApplication Operation</seealso>
        IAsyncResult BeginCreateApplication(CreateApplicationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateApplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateApplication.</param>
        /// 
        /// <returns>Returns a  CreateApplicationResult from MigrationHubRefactorSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migration-hub-refactor-spaces-2021-10-26/CreateApplication">REST API Reference for CreateApplication Operation</seealso>
        CreateApplicationResponse EndCreateApplication(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateEnvironment


        /// <summary>
        /// Creates an Amazon Web Services Migration Hub Refactor Spaces environment. The caller
        /// owns the environment resource, and all Refactor Spaces applications, services, and
        /// routes created within the environment. They are referred to as the <i>environment
        /// owner</i>. The environment owner has cross-account visibility and control of Refactor
        /// Spaces resources that are added to the environment by other accounts that the environment
        /// is shared with.
        /// 
        ///  
        /// <para>
        /// When creating an environment with a network fabric type of <code>TRANSIT_GATEWAY</code>,
        /// Refactor Spaces provisions a transit gateway in your account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEnvironment service method.</param>
        /// 
        /// <returns>The response from the CreateEnvironment service method, as returned by MigrationHubRefactorSpaces.</returns>
        /// <exception cref="Amazon.MigrationHubRefactorSpaces.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubRefactorSpaces.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubRefactorSpaces.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubRefactorSpaces.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubRefactorSpaces.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubRefactorSpaces.Model.ThrottlingException">
        /// Request was denied because the request was throttled.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubRefactorSpaces.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migration-hub-refactor-spaces-2021-10-26/CreateEnvironment">REST API Reference for CreateEnvironment Operation</seealso>
        CreateEnvironmentResponse CreateEnvironment(CreateEnvironmentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateEnvironment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateEnvironment operation on AmazonMigrationHubRefactorSpacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateEnvironment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migration-hub-refactor-spaces-2021-10-26/CreateEnvironment">REST API Reference for CreateEnvironment Operation</seealso>
        IAsyncResult BeginCreateEnvironment(CreateEnvironmentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateEnvironment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateEnvironment.</param>
        /// 
        /// <returns>Returns a  CreateEnvironmentResult from MigrationHubRefactorSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migration-hub-refactor-spaces-2021-10-26/CreateEnvironment">REST API Reference for CreateEnvironment Operation</seealso>
        CreateEnvironmentResponse EndCreateEnvironment(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateRoute


        /// <summary>
        /// Creates an Amazon Web Services Migration Hub Refactor Spaces route. The account owner
        /// of the service resource is always the environment owner, regardless of which account
        /// creates the route. Routes target a service in the application. If an application does
        /// not have any routes, then the first route must be created as a <code>DEFAULT</code>
        /// <code>RouteType</code>.
        /// 
        ///  
        /// <para>
        /// When created, the default route defaults to an active state so state is not a required
        /// input. However, like all other state values the state of the default route can be
        /// updated after creation, but only when all other routes are also inactive. Conversely,
        /// no route can be active without the default route also being active.
        /// </para>
        ///  
        /// <para>
        /// When you create a route, Refactor Spaces configures the Amazon API Gateway to send
        /// traffic to the target service as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If the service has a URL endpoint, and the endpoint resolves to a private IP address,
        /// Refactor Spaces routes traffic using the API Gateway VPC link. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the service has a URL endpoint, and the endpoint resolves to a public IP address,
        /// Refactor Spaces routes traffic over the public internet.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the service has an Lambda function endpoint, then Refactor Spaces configures the
        /// Lambda function's resource policy to allow the application's API Gateway to invoke
        /// the function.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// A one-time health check is performed on the service when either the route is updated
        /// from inactive to active, or when it is created with an active state. If the health
        /// check fails, the route transitions the route state to <code>FAILED</code>, an error
        /// code of <code>SERVICE_ENDPOINT_HEALTH_CHECK_FAILURE</code> is provided, and no traffic
        /// is sent to the service.
        /// </para>
        ///  
        /// <para>
        /// For Lambda functions, the Lambda function state is checked. If the function is not
        /// active, the function configuration is updated so that Lambda resources are provisioned.
        /// If the Lambda state is <code>Failed</code>, then the route creation fails. For more
        /// information, see the <a href="https://docs.aws.amazon.com/lambda/latest/dg/API_GetFunctionConfiguration.html#SSS-GetFunctionConfiguration-response-State">GetFunctionConfiguration's
        /// State response parameter</a> in the <i>Lambda Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For Lambda endpoints, a check is performed to determine that a Lambda function with
        /// the specified ARN exists. If it does not exist, the health check fails. For public
        /// URLs, a connection is opened to the public endpoint. If the URL is not reachable,
        /// the health check fails. 
        /// </para>
        ///  
        /// <para>
        /// Refactor Spaces automatically resolves the public Domain Name System (DNS) names that
        /// are set in <a>CreateServiceRequest$UrlEndpoint</a> when you create a service. The
        /// DNS names resolve when the DNS time-to-live (TTL) expires, or every 60 seconds for
        /// TTLs less than 60 seconds. This periodic DNS resolution ensures that the route configuration
        /// remains up-to-date. 
        /// </para>
        ///  
        /// <para>
        /// For private URLS, a target group is created on the Elastic Load Balancing and the
        /// target group health check is run. The <code>HealthCheckProtocol</code>, <code>HealthCheckPort</code>,
        /// and <code>HealthCheckPath</code> are the same protocol, port, and path specified in
        /// the URL or health URL, if used. All other settings use the default values, as described
        /// in <a href="https://docs.aws.amazon.com/elasticloadbalancing/latest/application/target-group-health-checks.html">Health
        /// checks for your target groups</a>. The health check is considered successful if at
        /// least one target within the target group transitions to a healthy state.
        /// </para>
        ///  
        /// <para>
        /// Services can have HTTP or HTTPS URL endpoints. For HTTPS URLs, publicly-signed certificates
        /// are supported. Private Certificate Authorities (CAs) are permitted only if the CA's
        /// domain is also publicly resolvable.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRoute service method.</param>
        /// 
        /// <returns>The response from the CreateRoute service method, as returned by MigrationHubRefactorSpaces.</returns>
        /// <exception cref="Amazon.MigrationHubRefactorSpaces.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubRefactorSpaces.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubRefactorSpaces.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubRefactorSpaces.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubRefactorSpaces.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubRefactorSpaces.Model.ThrottlingException">
        /// Request was denied because the request was throttled.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubRefactorSpaces.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migration-hub-refactor-spaces-2021-10-26/CreateRoute">REST API Reference for CreateRoute Operation</seealso>
        CreateRouteResponse CreateRoute(CreateRouteRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateRoute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRoute operation on AmazonMigrationHubRefactorSpacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateRoute
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migration-hub-refactor-spaces-2021-10-26/CreateRoute">REST API Reference for CreateRoute Operation</seealso>
        IAsyncResult BeginCreateRoute(CreateRouteRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateRoute operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateRoute.</param>
        /// 
        /// <returns>Returns a  CreateRouteResult from MigrationHubRefactorSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migration-hub-refactor-spaces-2021-10-26/CreateRoute">REST API Reference for CreateRoute Operation</seealso>
        CreateRouteResponse EndCreateRoute(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateService


        /// <summary>
        /// Creates an Amazon Web Services Migration Hub Refactor Spaces service. The account
        /// owner of the service is always the environment owner, regardless of which account
        /// in the environment creates the service. Services have either a URL endpoint in a virtual
        /// private cloud (VPC), or a Lambda function endpoint.
        /// 
        ///  <important> 
        /// <para>
        /// If an Amazon Web Services resource is launched in a service VPC, and you want it to
        /// be accessible to all of an environment’s services with VPCs and routes, apply the
        /// <code>RefactorSpacesSecurityGroup</code> to the resource. Alternatively, to add more
        /// cross-account constraints, apply your own security group.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateService service method.</param>
        /// 
        /// <returns>The response from the CreateService service method, as returned by MigrationHubRefactorSpaces.</returns>
        /// <exception cref="Amazon.MigrationHubRefactorSpaces.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubRefactorSpaces.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubRefactorSpaces.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubRefactorSpaces.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubRefactorSpaces.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubRefactorSpaces.Model.ThrottlingException">
        /// Request was denied because the request was throttled.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubRefactorSpaces.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migration-hub-refactor-spaces-2021-10-26/CreateService">REST API Reference for CreateService Operation</seealso>
        CreateServiceResponse CreateService(CreateServiceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateService operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateService operation on AmazonMigrationHubRefactorSpacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateService
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migration-hub-refactor-spaces-2021-10-26/CreateService">REST API Reference for CreateService Operation</seealso>
        IAsyncResult BeginCreateService(CreateServiceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateService operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateService.</param>
        /// 
        /// <returns>Returns a  CreateServiceResult from MigrationHubRefactorSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migration-hub-refactor-spaces-2021-10-26/CreateService">REST API Reference for CreateService Operation</seealso>
        CreateServiceResponse EndCreateService(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteApplication


        /// <summary>
        /// Deletes an Amazon Web Services Migration Hub Refactor Spaces application. Before you
        /// can delete an application, you must first delete any services or routes within the
        /// application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplication service method.</param>
        /// 
        /// <returns>The response from the DeleteApplication service method, as returned by MigrationHubRefactorSpaces.</returns>
        /// <exception cref="Amazon.MigrationHubRefactorSpaces.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubRefactorSpaces.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubRefactorSpaces.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubRefactorSpaces.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubRefactorSpaces.Model.ThrottlingException">
        /// Request was denied because the request was throttled.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubRefactorSpaces.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migration-hub-refactor-spaces-2021-10-26/DeleteApplication">REST API Reference for DeleteApplication Operation</seealso>
        DeleteApplicationResponse DeleteApplication(DeleteApplicationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplication operation on AmazonMigrationHubRefactorSpacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteApplication
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migration-hub-refactor-spaces-2021-10-26/DeleteApplication">REST API Reference for DeleteApplication Operation</seealso>
        IAsyncResult BeginDeleteApplication(DeleteApplicationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteApplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteApplication.</param>
        /// 
        /// <returns>Returns a  DeleteApplicationResult from MigrationHubRefactorSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migration-hub-refactor-spaces-2021-10-26/DeleteApplication">REST API Reference for DeleteApplication Operation</seealso>
        DeleteApplicationResponse EndDeleteApplication(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteEnvironment


        /// <summary>
        /// Deletes an Amazon Web Services Migration Hub Refactor Spaces environment. Before you
        /// can delete an environment, you must first delete any applications and services within
        /// the environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEnvironment service method.</param>
        /// 
        /// <returns>The response from the DeleteEnvironment service method, as returned by MigrationHubRefactorSpaces.</returns>
        /// <exception cref="Amazon.MigrationHubRefactorSpaces.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubRefactorSpaces.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubRefactorSpaces.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubRefactorSpaces.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubRefactorSpaces.Model.ThrottlingException">
        /// Request was denied because the request was throttled.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubRefactorSpaces.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migration-hub-refactor-spaces-2021-10-26/DeleteEnvironment">REST API Reference for DeleteEnvironment Operation</seealso>
        DeleteEnvironmentResponse DeleteEnvironment(DeleteEnvironmentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEnvironment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEnvironment operation on AmazonMigrationHubRefactorSpacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteEnvironment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migration-hub-refactor-spaces-2021-10-26/DeleteEnvironment">REST API Reference for DeleteEnvironment Operation</seealso>
        IAsyncResult BeginDeleteEnvironment(DeleteEnvironmentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteEnvironment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteEnvironment.</param>
        /// 
        /// <returns>Returns a  DeleteEnvironmentResult from MigrationHubRefactorSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migration-hub-refactor-spaces-2021-10-26/DeleteEnvironment">REST API Reference for DeleteEnvironment Operation</seealso>
        DeleteEnvironmentResponse EndDeleteEnvironment(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteResourcePolicy


        /// <summary>
        /// Deletes the resource policy set for the environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourcePolicy service method.</param>
        /// 
        /// <returns>The response from the DeleteResourcePolicy service method, as returned by MigrationHubRefactorSpaces.</returns>
        /// <exception cref="Amazon.MigrationHubRefactorSpaces.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubRefactorSpaces.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubRefactorSpaces.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubRefactorSpaces.Model.ThrottlingException">
        /// Request was denied because the request was throttled.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubRefactorSpaces.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migration-hub-refactor-spaces-2021-10-26/DeleteResourcePolicy">REST API Reference for DeleteResourcePolicy Operation</seealso>
        DeleteResourcePolicyResponse DeleteResourcePolicy(DeleteResourcePolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourcePolicy operation on AmazonMigrationHubRefactorSpacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteResourcePolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migration-hub-refactor-spaces-2021-10-26/DeleteResourcePolicy">REST API Reference for DeleteResourcePolicy Operation</seealso>
        IAsyncResult BeginDeleteResourcePolicy(DeleteResourcePolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteResourcePolicy.</param>
        /// 
        /// <returns>Returns a  DeleteResourcePolicyResult from MigrationHubRefactorSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migration-hub-refactor-spaces-2021-10-26/DeleteResourcePolicy">REST API Reference for DeleteResourcePolicy Operation</seealso>
        DeleteResourcePolicyResponse EndDeleteResourcePolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteRoute


        /// <summary>
        /// Deletes an Amazon Web Services Migration Hub Refactor Spaces route.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRoute service method.</param>
        /// 
        /// <returns>The response from the DeleteRoute service method, as returned by MigrationHubRefactorSpaces.</returns>
        /// <exception cref="Amazon.MigrationHubRefactorSpaces.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubRefactorSpaces.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubRefactorSpaces.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubRefactorSpaces.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubRefactorSpaces.Model.ThrottlingException">
        /// Request was denied because the request was throttled.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubRefactorSpaces.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migration-hub-refactor-spaces-2021-10-26/DeleteRoute">REST API Reference for DeleteRoute Operation</seealso>
        DeleteRouteResponse DeleteRoute(DeleteRouteRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRoute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRoute operation on AmazonMigrationHubRefactorSpacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteRoute
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migration-hub-refactor-spaces-2021-10-26/DeleteRoute">REST API Reference for DeleteRoute Operation</seealso>
        IAsyncResult BeginDeleteRoute(DeleteRouteRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteRoute operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRoute.</param>
        /// 
        /// <returns>Returns a  DeleteRouteResult from MigrationHubRefactorSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migration-hub-refactor-spaces-2021-10-26/DeleteRoute">REST API Reference for DeleteRoute Operation</seealso>
        DeleteRouteResponse EndDeleteRoute(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteService


        /// <summary>
        /// Deletes an Amazon Web Services Migration Hub Refactor Spaces service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteService service method.</param>
        /// 
        /// <returns>The response from the DeleteService service method, as returned by MigrationHubRefactorSpaces.</returns>
        /// <exception cref="Amazon.MigrationHubRefactorSpaces.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubRefactorSpaces.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubRefactorSpaces.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubRefactorSpaces.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubRefactorSpaces.Model.ThrottlingException">
        /// Request was denied because the request was throttled.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubRefactorSpaces.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migration-hub-refactor-spaces-2021-10-26/DeleteService">REST API Reference for DeleteService Operation</seealso>
        DeleteServiceResponse DeleteService(DeleteServiceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteService operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteService operation on AmazonMigrationHubRefactorSpacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteService
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migration-hub-refactor-spaces-2021-10-26/DeleteService">REST API Reference for DeleteService Operation</seealso>
        IAsyncResult BeginDeleteService(DeleteServiceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteService operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteService.</param>
        /// 
        /// <returns>Returns a  DeleteServiceResult from MigrationHubRefactorSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migration-hub-refactor-spaces-2021-10-26/DeleteService">REST API Reference for DeleteService Operation</seealso>
        DeleteServiceResponse EndDeleteService(IAsyncResult asyncResult);

        #endregion
        
        #region  GetApplication


        /// <summary>
        /// Gets an Amazon Web Services Migration Hub Refactor Spaces application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApplication service method.</param>
        /// 
        /// <returns>The response from the GetApplication service method, as returned by MigrationHubRefactorSpaces.</returns>
        /// <exception cref="Amazon.MigrationHubRefactorSpaces.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubRefactorSpaces.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubRefactorSpaces.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubRefactorSpaces.Model.ThrottlingException">
        /// Request was denied because the request was throttled.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubRefactorSpaces.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migration-hub-refactor-spaces-2021-10-26/GetApplication">REST API Reference for GetApplication Operation</seealso>
        GetApplicationResponse GetApplication(GetApplicationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetApplication operation on AmazonMigrationHubRefactorSpacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetApplication
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migration-hub-refactor-spaces-2021-10-26/GetApplication">REST API Reference for GetApplication Operation</seealso>
        IAsyncResult BeginGetApplication(GetApplicationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetApplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetApplication.</param>
        /// 
        /// <returns>Returns a  GetApplicationResult from MigrationHubRefactorSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migration-hub-refactor-spaces-2021-10-26/GetApplication">REST API Reference for GetApplication Operation</seealso>
        GetApplicationResponse EndGetApplication(IAsyncResult asyncResult);

        #endregion
        
        #region  GetEnvironment


        /// <summary>
        /// Gets an Amazon Web Services Migration Hub Refactor Spaces environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEnvironment service method.</param>
        /// 
        /// <returns>The response from the GetEnvironment service method, as returned by MigrationHubRefactorSpaces.</returns>
        /// <exception cref="Amazon.MigrationHubRefactorSpaces.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubRefactorSpaces.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubRefactorSpaces.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubRefactorSpaces.Model.ThrottlingException">
        /// Request was denied because the request was throttled.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubRefactorSpaces.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migration-hub-refactor-spaces-2021-10-26/GetEnvironment">REST API Reference for GetEnvironment Operation</seealso>
        GetEnvironmentResponse GetEnvironment(GetEnvironmentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetEnvironment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetEnvironment operation on AmazonMigrationHubRefactorSpacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetEnvironment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migration-hub-refactor-spaces-2021-10-26/GetEnvironment">REST API Reference for GetEnvironment Operation</seealso>
        IAsyncResult BeginGetEnvironment(GetEnvironmentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetEnvironment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetEnvironment.</param>
        /// 
        /// <returns>Returns a  GetEnvironmentResult from MigrationHubRefactorSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migration-hub-refactor-spaces-2021-10-26/GetEnvironment">REST API Reference for GetEnvironment Operation</seealso>
        GetEnvironmentResponse EndGetEnvironment(IAsyncResult asyncResult);

        #endregion
        
        #region  GetResourcePolicy


        /// <summary>
        /// Gets the resource-based permission policy that is set for the given environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourcePolicy service method.</param>
        /// 
        /// <returns>The response from the GetResourcePolicy service method, as returned by MigrationHubRefactorSpaces.</returns>
        /// <exception cref="Amazon.MigrationHubRefactorSpaces.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubRefactorSpaces.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubRefactorSpaces.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubRefactorSpaces.Model.ThrottlingException">
        /// Request was denied because the request was throttled.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubRefactorSpaces.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migration-hub-refactor-spaces-2021-10-26/GetResourcePolicy">REST API Reference for GetResourcePolicy Operation</seealso>
        GetResourcePolicyResponse GetResourcePolicy(GetResourcePolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetResourcePolicy operation on AmazonMigrationHubRefactorSpacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetResourcePolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migration-hub-refactor-spaces-2021-10-26/GetResourcePolicy">REST API Reference for GetResourcePolicy Operation</seealso>
        IAsyncResult BeginGetResourcePolicy(GetResourcePolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetResourcePolicy.</param>
        /// 
        /// <returns>Returns a  GetResourcePolicyResult from MigrationHubRefactorSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migration-hub-refactor-spaces-2021-10-26/GetResourcePolicy">REST API Reference for GetResourcePolicy Operation</seealso>
        GetResourcePolicyResponse EndGetResourcePolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  GetRoute


        /// <summary>
        /// Gets an Amazon Web Services Migration Hub Refactor Spaces route.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRoute service method.</param>
        /// 
        /// <returns>The response from the GetRoute service method, as returned by MigrationHubRefactorSpaces.</returns>
        /// <exception cref="Amazon.MigrationHubRefactorSpaces.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubRefactorSpaces.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubRefactorSpaces.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubRefactorSpaces.Model.ThrottlingException">
        /// Request was denied because the request was throttled.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubRefactorSpaces.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migration-hub-refactor-spaces-2021-10-26/GetRoute">REST API Reference for GetRoute Operation</seealso>
        GetRouteResponse GetRoute(GetRouteRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetRoute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRoute operation on AmazonMigrationHubRefactorSpacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRoute
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migration-hub-refactor-spaces-2021-10-26/GetRoute">REST API Reference for GetRoute Operation</seealso>
        IAsyncResult BeginGetRoute(GetRouteRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetRoute operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRoute.</param>
        /// 
        /// <returns>Returns a  GetRouteResult from MigrationHubRefactorSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migration-hub-refactor-spaces-2021-10-26/GetRoute">REST API Reference for GetRoute Operation</seealso>
        GetRouteResponse EndGetRoute(IAsyncResult asyncResult);

        #endregion
        
        #region  GetService


        /// <summary>
        /// Gets an Amazon Web Services Migration Hub Refactor Spaces service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetService service method.</param>
        /// 
        /// <returns>The response from the GetService service method, as returned by MigrationHubRefactorSpaces.</returns>
        /// <exception cref="Amazon.MigrationHubRefactorSpaces.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubRefactorSpaces.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubRefactorSpaces.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubRefactorSpaces.Model.ThrottlingException">
        /// Request was denied because the request was throttled.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubRefactorSpaces.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migration-hub-refactor-spaces-2021-10-26/GetService">REST API Reference for GetService Operation</seealso>
        GetServiceResponse GetService(GetServiceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetService operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetService operation on AmazonMigrationHubRefactorSpacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetService
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migration-hub-refactor-spaces-2021-10-26/GetService">REST API Reference for GetService Operation</seealso>
        IAsyncResult BeginGetService(GetServiceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetService operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetService.</param>
        /// 
        /// <returns>Returns a  GetServiceResult from MigrationHubRefactorSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migration-hub-refactor-spaces-2021-10-26/GetService">REST API Reference for GetService Operation</seealso>
        GetServiceResponse EndGetService(IAsyncResult asyncResult);

        #endregion
        
        #region  ListApplications


        /// <summary>
        /// Lists all the Amazon Web Services Migration Hub Refactor Spaces applications within
        /// an environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApplications service method.</param>
        /// 
        /// <returns>The response from the ListApplications service method, as returned by MigrationHubRefactorSpaces.</returns>
        /// <exception cref="Amazon.MigrationHubRefactorSpaces.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubRefactorSpaces.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubRefactorSpaces.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubRefactorSpaces.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubRefactorSpaces.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubRefactorSpaces.Model.ThrottlingException">
        /// Request was denied because the request was throttled.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubRefactorSpaces.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migration-hub-refactor-spaces-2021-10-26/ListApplications">REST API Reference for ListApplications Operation</seealso>
        ListApplicationsResponse ListApplications(ListApplicationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListApplications operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListApplications operation on AmazonMigrationHubRefactorSpacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListApplications
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migration-hub-refactor-spaces-2021-10-26/ListApplications">REST API Reference for ListApplications Operation</seealso>
        IAsyncResult BeginListApplications(ListApplicationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListApplications operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListApplications.</param>
        /// 
        /// <returns>Returns a  ListApplicationsResult from MigrationHubRefactorSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migration-hub-refactor-spaces-2021-10-26/ListApplications">REST API Reference for ListApplications Operation</seealso>
        ListApplicationsResponse EndListApplications(IAsyncResult asyncResult);

        #endregion
        
        #region  ListEnvironments


        /// <summary>
        /// Lists Amazon Web Services Migration Hub Refactor Spaces environments owned by a caller
        /// account or shared with the caller account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEnvironments service method.</param>
        /// 
        /// <returns>The response from the ListEnvironments service method, as returned by MigrationHubRefactorSpaces.</returns>
        /// <exception cref="Amazon.MigrationHubRefactorSpaces.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubRefactorSpaces.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubRefactorSpaces.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubRefactorSpaces.Model.ThrottlingException">
        /// Request was denied because the request was throttled.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubRefactorSpaces.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migration-hub-refactor-spaces-2021-10-26/ListEnvironments">REST API Reference for ListEnvironments Operation</seealso>
        ListEnvironmentsResponse ListEnvironments(ListEnvironmentsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListEnvironments operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListEnvironments operation on AmazonMigrationHubRefactorSpacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListEnvironments
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migration-hub-refactor-spaces-2021-10-26/ListEnvironments">REST API Reference for ListEnvironments Operation</seealso>
        IAsyncResult BeginListEnvironments(ListEnvironmentsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListEnvironments operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListEnvironments.</param>
        /// 
        /// <returns>Returns a  ListEnvironmentsResult from MigrationHubRefactorSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migration-hub-refactor-spaces-2021-10-26/ListEnvironments">REST API Reference for ListEnvironments Operation</seealso>
        ListEnvironmentsResponse EndListEnvironments(IAsyncResult asyncResult);

        #endregion
        
        #region  ListEnvironmentVpcs


        /// <summary>
        /// Lists all Amazon Web Services Migration Hub Refactor Spaces service virtual private
        /// clouds (VPCs) that are part of the environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEnvironmentVpcs service method.</param>
        /// 
        /// <returns>The response from the ListEnvironmentVpcs service method, as returned by MigrationHubRefactorSpaces.</returns>
        /// <exception cref="Amazon.MigrationHubRefactorSpaces.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubRefactorSpaces.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubRefactorSpaces.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubRefactorSpaces.Model.ThrottlingException">
        /// Request was denied because the request was throttled.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubRefactorSpaces.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migration-hub-refactor-spaces-2021-10-26/ListEnvironmentVpcs">REST API Reference for ListEnvironmentVpcs Operation</seealso>
        ListEnvironmentVpcsResponse ListEnvironmentVpcs(ListEnvironmentVpcsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListEnvironmentVpcs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListEnvironmentVpcs operation on AmazonMigrationHubRefactorSpacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListEnvironmentVpcs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migration-hub-refactor-spaces-2021-10-26/ListEnvironmentVpcs">REST API Reference for ListEnvironmentVpcs Operation</seealso>
        IAsyncResult BeginListEnvironmentVpcs(ListEnvironmentVpcsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListEnvironmentVpcs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListEnvironmentVpcs.</param>
        /// 
        /// <returns>Returns a  ListEnvironmentVpcsResult from MigrationHubRefactorSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migration-hub-refactor-spaces-2021-10-26/ListEnvironmentVpcs">REST API Reference for ListEnvironmentVpcs Operation</seealso>
        ListEnvironmentVpcsResponse EndListEnvironmentVpcs(IAsyncResult asyncResult);

        #endregion
        
        #region  ListRoutes


        /// <summary>
        /// Lists all the Amazon Web Services Migration Hub Refactor Spaces routes within an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRoutes service method.</param>
        /// 
        /// <returns>The response from the ListRoutes service method, as returned by MigrationHubRefactorSpaces.</returns>
        /// <exception cref="Amazon.MigrationHubRefactorSpaces.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubRefactorSpaces.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubRefactorSpaces.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubRefactorSpaces.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubRefactorSpaces.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubRefactorSpaces.Model.ThrottlingException">
        /// Request was denied because the request was throttled.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubRefactorSpaces.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migration-hub-refactor-spaces-2021-10-26/ListRoutes">REST API Reference for ListRoutes Operation</seealso>
        ListRoutesResponse ListRoutes(ListRoutesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListRoutes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRoutes operation on AmazonMigrationHubRefactorSpacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRoutes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migration-hub-refactor-spaces-2021-10-26/ListRoutes">REST API Reference for ListRoutes Operation</seealso>
        IAsyncResult BeginListRoutes(ListRoutesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListRoutes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRoutes.</param>
        /// 
        /// <returns>Returns a  ListRoutesResult from MigrationHubRefactorSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migration-hub-refactor-spaces-2021-10-26/ListRoutes">REST API Reference for ListRoutes Operation</seealso>
        ListRoutesResponse EndListRoutes(IAsyncResult asyncResult);

        #endregion
        
        #region  ListServices


        /// <summary>
        /// Lists all the Amazon Web Services Migration Hub Refactor Spaces services within an
        /// application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServices service method.</param>
        /// 
        /// <returns>The response from the ListServices service method, as returned by MigrationHubRefactorSpaces.</returns>
        /// <exception cref="Amazon.MigrationHubRefactorSpaces.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubRefactorSpaces.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubRefactorSpaces.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubRefactorSpaces.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubRefactorSpaces.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubRefactorSpaces.Model.ThrottlingException">
        /// Request was denied because the request was throttled.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubRefactorSpaces.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migration-hub-refactor-spaces-2021-10-26/ListServices">REST API Reference for ListServices Operation</seealso>
        ListServicesResponse ListServices(ListServicesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListServices operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListServices operation on AmazonMigrationHubRefactorSpacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListServices
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migration-hub-refactor-spaces-2021-10-26/ListServices">REST API Reference for ListServices Operation</seealso>
        IAsyncResult BeginListServices(ListServicesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListServices operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListServices.</param>
        /// 
        /// <returns>Returns a  ListServicesResult from MigrationHubRefactorSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migration-hub-refactor-spaces-2021-10-26/ListServices">REST API Reference for ListServices Operation</seealso>
        ListServicesResponse EndListServices(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists the tags of a resource. The caller account must be the same as the resource’s
        /// <code>OwnerAccountId</code>. Listing tags in other accounts is not supported.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by MigrationHubRefactorSpaces.</returns>
        /// <exception cref="Amazon.MigrationHubRefactorSpaces.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubRefactorSpaces.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubRefactorSpaces.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migration-hub-refactor-spaces-2021-10-26/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonMigrationHubRefactorSpacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migration-hub-refactor-spaces-2021-10-26/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from MigrationHubRefactorSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migration-hub-refactor-spaces-2021-10-26/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

        #endregion
        
        #region  PutResourcePolicy


        /// <summary>
        /// Attaches a resource-based permission policy to the Amazon Web Services Migration Hub
        /// Refactor Spaces environment. The policy must contain the same actions and condition
        /// statements as the <code>arn:aws:ram::aws:permission/AWSRAMDefaultPermissionRefactorSpacesEnvironment</code>
        /// permission in Resource Access Manager. The policy must not contain new lines or blank
        /// lines.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutResourcePolicy service method.</param>
        /// 
        /// <returns>The response from the PutResourcePolicy service method, as returned by MigrationHubRefactorSpaces.</returns>
        /// <exception cref="Amazon.MigrationHubRefactorSpaces.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubRefactorSpaces.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubRefactorSpaces.Model.InvalidResourcePolicyException">
        /// The resource policy is not valid.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubRefactorSpaces.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubRefactorSpaces.Model.ThrottlingException">
        /// Request was denied because the request was throttled.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubRefactorSpaces.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migration-hub-refactor-spaces-2021-10-26/PutResourcePolicy">REST API Reference for PutResourcePolicy Operation</seealso>
        PutResourcePolicyResponse PutResourcePolicy(PutResourcePolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutResourcePolicy operation on AmazonMigrationHubRefactorSpacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutResourcePolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migration-hub-refactor-spaces-2021-10-26/PutResourcePolicy">REST API Reference for PutResourcePolicy Operation</seealso>
        IAsyncResult BeginPutResourcePolicy(PutResourcePolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutResourcePolicy.</param>
        /// 
        /// <returns>Returns a  PutResourcePolicyResult from MigrationHubRefactorSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migration-hub-refactor-spaces-2021-10-26/PutResourcePolicy">REST API Reference for PutResourcePolicy Operation</seealso>
        PutResourcePolicyResponse EndPutResourcePolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Removes the tags of a given resource. Tags are metadata which can be used to manage
        /// a resource. To tag a resource, the caller account must be the same as the resource’s
        /// <code>OwnerAccountId</code>. Tagging resources in other accounts is not supported.
        /// 
        ///  <note> 
        /// <para>
        /// Amazon Web Services Migration Hub Refactor Spaces does not propagate tags to orchestrated
        /// resources, such as an environment’s transit gateway.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by MigrationHubRefactorSpaces.</returns>
        /// <exception cref="Amazon.MigrationHubRefactorSpaces.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubRefactorSpaces.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubRefactorSpaces.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migration-hub-refactor-spaces-2021-10-26/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonMigrationHubRefactorSpacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migration-hub-refactor-spaces-2021-10-26/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from MigrationHubRefactorSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migration-hub-refactor-spaces-2021-10-26/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Adds to or modifies the tags of the given resource. Tags are metadata which can be
        /// used to manage a resource. To untag a resource, the caller account must be the same
        /// as the resource’s <code>OwnerAccountId</code>. Untagging resources across accounts
        /// is not supported.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by MigrationHubRefactorSpaces.</returns>
        /// <exception cref="Amazon.MigrationHubRefactorSpaces.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubRefactorSpaces.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubRefactorSpaces.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migration-hub-refactor-spaces-2021-10-26/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonMigrationHubRefactorSpacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migration-hub-refactor-spaces-2021-10-26/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from MigrationHubRefactorSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migration-hub-refactor-spaces-2021-10-26/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateRoute


        /// <summary>
        /// Updates an Amazon Web Services Migration Hub Refactor Spaces route.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRoute service method.</param>
        /// 
        /// <returns>The response from the UpdateRoute service method, as returned by MigrationHubRefactorSpaces.</returns>
        /// <exception cref="Amazon.MigrationHubRefactorSpaces.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubRefactorSpaces.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubRefactorSpaces.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubRefactorSpaces.Model.ThrottlingException">
        /// Request was denied because the request was throttled.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubRefactorSpaces.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migration-hub-refactor-spaces-2021-10-26/UpdateRoute">REST API Reference for UpdateRoute Operation</seealso>
        UpdateRouteResponse UpdateRoute(UpdateRouteRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateRoute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateRoute operation on AmazonMigrationHubRefactorSpacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateRoute
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migration-hub-refactor-spaces-2021-10-26/UpdateRoute">REST API Reference for UpdateRoute Operation</seealso>
        IAsyncResult BeginUpdateRoute(UpdateRouteRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateRoute operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateRoute.</param>
        /// 
        /// <returns>Returns a  UpdateRouteResult from MigrationHubRefactorSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migration-hub-refactor-spaces-2021-10-26/UpdateRoute">REST API Reference for UpdateRoute Operation</seealso>
        UpdateRouteResponse EndUpdateRoute(IAsyncResult asyncResult);

        #endregion
        
    }
}