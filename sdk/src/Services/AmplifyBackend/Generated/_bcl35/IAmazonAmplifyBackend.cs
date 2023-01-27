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
 * Do not modify this file. This file is generated from the amplifybackend-2020-08-11.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.AmplifyBackend.Model;

namespace Amazon.AmplifyBackend
{
    /// <summary>
    /// Interface for accessing AmplifyBackend
    ///
    /// AWS Amplify Admin API
    /// </summary>
    public partial interface IAmazonAmplifyBackend : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IAmplifyBackendPaginatorFactory Paginators { get; }
#endif


        
        #region  CloneBackend


        /// <summary>
        /// This operation clones an existing backend.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CloneBackend service method.</param>
        /// 
        /// <returns>The response from the CloneBackend service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/CloneBackend">REST API Reference for CloneBackend Operation</seealso>
        CloneBackendResponse CloneBackend(CloneBackendRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CloneBackend operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CloneBackend operation on AmazonAmplifyBackendClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCloneBackend
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/CloneBackend">REST API Reference for CloneBackend Operation</seealso>
        IAsyncResult BeginCloneBackend(CloneBackendRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CloneBackend operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCloneBackend.</param>
        /// 
        /// <returns>Returns a  CloneBackendResult from AmplifyBackend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/CloneBackend">REST API Reference for CloneBackend Operation</seealso>
        CloneBackendResponse EndCloneBackend(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateBackend


        /// <summary>
        /// This operation creates a backend for an Amplify app. Backends are automatically created
        /// at the time of app creation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBackend service method.</param>
        /// 
        /// <returns>The response from the CreateBackend service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/CreateBackend">REST API Reference for CreateBackend Operation</seealso>
        CreateBackendResponse CreateBackend(CreateBackendRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateBackend operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateBackend operation on AmazonAmplifyBackendClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateBackend
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/CreateBackend">REST API Reference for CreateBackend Operation</seealso>
        IAsyncResult BeginCreateBackend(CreateBackendRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateBackend operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateBackend.</param>
        /// 
        /// <returns>Returns a  CreateBackendResult from AmplifyBackend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/CreateBackend">REST API Reference for CreateBackend Operation</seealso>
        CreateBackendResponse EndCreateBackend(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateBackendAPI


        /// <summary>
        /// Creates a new backend API resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBackendAPI service method.</param>
        /// 
        /// <returns>The response from the CreateBackendAPI service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/CreateBackendAPI">REST API Reference for CreateBackendAPI Operation</seealso>
        CreateBackendAPIResponse CreateBackendAPI(CreateBackendAPIRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateBackendAPI operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateBackendAPI operation on AmazonAmplifyBackendClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateBackendAPI
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/CreateBackendAPI">REST API Reference for CreateBackendAPI Operation</seealso>
        IAsyncResult BeginCreateBackendAPI(CreateBackendAPIRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateBackendAPI operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateBackendAPI.</param>
        /// 
        /// <returns>Returns a  CreateBackendAPIResult from AmplifyBackend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/CreateBackendAPI">REST API Reference for CreateBackendAPI Operation</seealso>
        CreateBackendAPIResponse EndCreateBackendAPI(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateBackendAuth


        /// <summary>
        /// Creates a new backend authentication resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBackendAuth service method.</param>
        /// 
        /// <returns>The response from the CreateBackendAuth service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/CreateBackendAuth">REST API Reference for CreateBackendAuth Operation</seealso>
        CreateBackendAuthResponse CreateBackendAuth(CreateBackendAuthRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateBackendAuth operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateBackendAuth operation on AmazonAmplifyBackendClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateBackendAuth
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/CreateBackendAuth">REST API Reference for CreateBackendAuth Operation</seealso>
        IAsyncResult BeginCreateBackendAuth(CreateBackendAuthRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateBackendAuth operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateBackendAuth.</param>
        /// 
        /// <returns>Returns a  CreateBackendAuthResult from AmplifyBackend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/CreateBackendAuth">REST API Reference for CreateBackendAuth Operation</seealso>
        CreateBackendAuthResponse EndCreateBackendAuth(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateBackendConfig


        /// <summary>
        /// Creates a config object for a backend.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBackendConfig service method.</param>
        /// 
        /// <returns>The response from the CreateBackendConfig service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/CreateBackendConfig">REST API Reference for CreateBackendConfig Operation</seealso>
        CreateBackendConfigResponse CreateBackendConfig(CreateBackendConfigRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateBackendConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateBackendConfig operation on AmazonAmplifyBackendClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateBackendConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/CreateBackendConfig">REST API Reference for CreateBackendConfig Operation</seealso>
        IAsyncResult BeginCreateBackendConfig(CreateBackendConfigRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateBackendConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateBackendConfig.</param>
        /// 
        /// <returns>Returns a  CreateBackendConfigResult from AmplifyBackend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/CreateBackendConfig">REST API Reference for CreateBackendConfig Operation</seealso>
        CreateBackendConfigResponse EndCreateBackendConfig(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateBackendStorage


        /// <summary>
        /// Creates a backend storage resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBackendStorage service method.</param>
        /// 
        /// <returns>The response from the CreateBackendStorage service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/CreateBackendStorage">REST API Reference for CreateBackendStorage Operation</seealso>
        CreateBackendStorageResponse CreateBackendStorage(CreateBackendStorageRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateBackendStorage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateBackendStorage operation on AmazonAmplifyBackendClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateBackendStorage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/CreateBackendStorage">REST API Reference for CreateBackendStorage Operation</seealso>
        IAsyncResult BeginCreateBackendStorage(CreateBackendStorageRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateBackendStorage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateBackendStorage.</param>
        /// 
        /// <returns>Returns a  CreateBackendStorageResult from AmplifyBackend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/CreateBackendStorage">REST API Reference for CreateBackendStorage Operation</seealso>
        CreateBackendStorageResponse EndCreateBackendStorage(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateToken


        /// <summary>
        /// Generates a one-time challenge code to authenticate a user into your Amplify Admin
        /// UI.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateToken service method.</param>
        /// 
        /// <returns>The response from the CreateToken service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/CreateToken">REST API Reference for CreateToken Operation</seealso>
        CreateTokenResponse CreateToken(CreateTokenRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateToken operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateToken operation on AmazonAmplifyBackendClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateToken
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/CreateToken">REST API Reference for CreateToken Operation</seealso>
        IAsyncResult BeginCreateToken(CreateTokenRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateToken operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateToken.</param>
        /// 
        /// <returns>Returns a  CreateTokenResult from AmplifyBackend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/CreateToken">REST API Reference for CreateToken Operation</seealso>
        CreateTokenResponse EndCreateToken(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteBackend


        /// <summary>
        /// Removes an existing environment from your Amplify project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBackend service method.</param>
        /// 
        /// <returns>The response from the DeleteBackend service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/DeleteBackend">REST API Reference for DeleteBackend Operation</seealso>
        DeleteBackendResponse DeleteBackend(DeleteBackendRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBackend operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBackend operation on AmazonAmplifyBackendClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteBackend
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/DeleteBackend">REST API Reference for DeleteBackend Operation</seealso>
        IAsyncResult BeginDeleteBackend(DeleteBackendRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteBackend operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteBackend.</param>
        /// 
        /// <returns>Returns a  DeleteBackendResult from AmplifyBackend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/DeleteBackend">REST API Reference for DeleteBackend Operation</seealso>
        DeleteBackendResponse EndDeleteBackend(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteBackendAPI


        /// <summary>
        /// Deletes an existing backend API resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBackendAPI service method.</param>
        /// 
        /// <returns>The response from the DeleteBackendAPI service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/DeleteBackendAPI">REST API Reference for DeleteBackendAPI Operation</seealso>
        DeleteBackendAPIResponse DeleteBackendAPI(DeleteBackendAPIRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBackendAPI operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBackendAPI operation on AmazonAmplifyBackendClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteBackendAPI
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/DeleteBackendAPI">REST API Reference for DeleteBackendAPI Operation</seealso>
        IAsyncResult BeginDeleteBackendAPI(DeleteBackendAPIRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteBackendAPI operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteBackendAPI.</param>
        /// 
        /// <returns>Returns a  DeleteBackendAPIResult from AmplifyBackend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/DeleteBackendAPI">REST API Reference for DeleteBackendAPI Operation</seealso>
        DeleteBackendAPIResponse EndDeleteBackendAPI(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteBackendAuth


        /// <summary>
        /// Deletes an existing backend authentication resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBackendAuth service method.</param>
        /// 
        /// <returns>The response from the DeleteBackendAuth service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/DeleteBackendAuth">REST API Reference for DeleteBackendAuth Operation</seealso>
        DeleteBackendAuthResponse DeleteBackendAuth(DeleteBackendAuthRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBackendAuth operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBackendAuth operation on AmazonAmplifyBackendClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteBackendAuth
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/DeleteBackendAuth">REST API Reference for DeleteBackendAuth Operation</seealso>
        IAsyncResult BeginDeleteBackendAuth(DeleteBackendAuthRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteBackendAuth operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteBackendAuth.</param>
        /// 
        /// <returns>Returns a  DeleteBackendAuthResult from AmplifyBackend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/DeleteBackendAuth">REST API Reference for DeleteBackendAuth Operation</seealso>
        DeleteBackendAuthResponse EndDeleteBackendAuth(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteBackendStorage


        /// <summary>
        /// Removes the specified backend storage resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBackendStorage service method.</param>
        /// 
        /// <returns>The response from the DeleteBackendStorage service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/DeleteBackendStorage">REST API Reference for DeleteBackendStorage Operation</seealso>
        DeleteBackendStorageResponse DeleteBackendStorage(DeleteBackendStorageRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBackendStorage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBackendStorage operation on AmazonAmplifyBackendClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteBackendStorage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/DeleteBackendStorage">REST API Reference for DeleteBackendStorage Operation</seealso>
        IAsyncResult BeginDeleteBackendStorage(DeleteBackendStorageRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteBackendStorage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteBackendStorage.</param>
        /// 
        /// <returns>Returns a  DeleteBackendStorageResult from AmplifyBackend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/DeleteBackendStorage">REST API Reference for DeleteBackendStorage Operation</seealso>
        DeleteBackendStorageResponse EndDeleteBackendStorage(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteToken


        /// <summary>
        /// Deletes the challenge token based on the given appId and sessionId.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteToken service method.</param>
        /// 
        /// <returns>The response from the DeleteToken service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/DeleteToken">REST API Reference for DeleteToken Operation</seealso>
        DeleteTokenResponse DeleteToken(DeleteTokenRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteToken operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteToken operation on AmazonAmplifyBackendClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteToken
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/DeleteToken">REST API Reference for DeleteToken Operation</seealso>
        IAsyncResult BeginDeleteToken(DeleteTokenRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteToken operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteToken.</param>
        /// 
        /// <returns>Returns a  DeleteTokenResult from AmplifyBackend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/DeleteToken">REST API Reference for DeleteToken Operation</seealso>
        DeleteTokenResponse EndDeleteToken(IAsyncResult asyncResult);

        #endregion
        
        #region  GenerateBackendAPIModels


        /// <summary>
        /// Generates a model schema for an existing backend API resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GenerateBackendAPIModels service method.</param>
        /// 
        /// <returns>The response from the GenerateBackendAPIModels service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/GenerateBackendAPIModels">REST API Reference for GenerateBackendAPIModels Operation</seealso>
        GenerateBackendAPIModelsResponse GenerateBackendAPIModels(GenerateBackendAPIModelsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GenerateBackendAPIModels operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GenerateBackendAPIModels operation on AmazonAmplifyBackendClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGenerateBackendAPIModels
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/GenerateBackendAPIModels">REST API Reference for GenerateBackendAPIModels Operation</seealso>
        IAsyncResult BeginGenerateBackendAPIModels(GenerateBackendAPIModelsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GenerateBackendAPIModels operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGenerateBackendAPIModels.</param>
        /// 
        /// <returns>Returns a  GenerateBackendAPIModelsResult from AmplifyBackend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/GenerateBackendAPIModels">REST API Reference for GenerateBackendAPIModels Operation</seealso>
        GenerateBackendAPIModelsResponse EndGenerateBackendAPIModels(IAsyncResult asyncResult);

        #endregion
        
        #region  GetBackend


        /// <summary>
        /// Provides project-level details for your Amplify UI project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBackend service method.</param>
        /// 
        /// <returns>The response from the GetBackend service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/GetBackend">REST API Reference for GetBackend Operation</seealso>
        GetBackendResponse GetBackend(GetBackendRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetBackend operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBackend operation on AmazonAmplifyBackendClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetBackend
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/GetBackend">REST API Reference for GetBackend Operation</seealso>
        IAsyncResult BeginGetBackend(GetBackendRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetBackend operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBackend.</param>
        /// 
        /// <returns>Returns a  GetBackendResult from AmplifyBackend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/GetBackend">REST API Reference for GetBackend Operation</seealso>
        GetBackendResponse EndGetBackend(IAsyncResult asyncResult);

        #endregion
        
        #region  GetBackendAPI


        /// <summary>
        /// Gets the details for a backend API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBackendAPI service method.</param>
        /// 
        /// <returns>The response from the GetBackendAPI service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/GetBackendAPI">REST API Reference for GetBackendAPI Operation</seealso>
        GetBackendAPIResponse GetBackendAPI(GetBackendAPIRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetBackendAPI operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBackendAPI operation on AmazonAmplifyBackendClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetBackendAPI
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/GetBackendAPI">REST API Reference for GetBackendAPI Operation</seealso>
        IAsyncResult BeginGetBackendAPI(GetBackendAPIRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetBackendAPI operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBackendAPI.</param>
        /// 
        /// <returns>Returns a  GetBackendAPIResult from AmplifyBackend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/GetBackendAPI">REST API Reference for GetBackendAPI Operation</seealso>
        GetBackendAPIResponse EndGetBackendAPI(IAsyncResult asyncResult);

        #endregion
        
        #region  GetBackendAPIModels


        /// <summary>
        /// Gets a model introspection schema for an existing backend API resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBackendAPIModels service method.</param>
        /// 
        /// <returns>The response from the GetBackendAPIModels service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/GetBackendAPIModels">REST API Reference for GetBackendAPIModels Operation</seealso>
        GetBackendAPIModelsResponse GetBackendAPIModels(GetBackendAPIModelsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetBackendAPIModels operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBackendAPIModels operation on AmazonAmplifyBackendClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetBackendAPIModels
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/GetBackendAPIModels">REST API Reference for GetBackendAPIModels Operation</seealso>
        IAsyncResult BeginGetBackendAPIModels(GetBackendAPIModelsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetBackendAPIModels operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBackendAPIModels.</param>
        /// 
        /// <returns>Returns a  GetBackendAPIModelsResult from AmplifyBackend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/GetBackendAPIModels">REST API Reference for GetBackendAPIModels Operation</seealso>
        GetBackendAPIModelsResponse EndGetBackendAPIModels(IAsyncResult asyncResult);

        #endregion
        
        #region  GetBackendAuth


        /// <summary>
        /// Gets a backend auth details.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBackendAuth service method.</param>
        /// 
        /// <returns>The response from the GetBackendAuth service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/GetBackendAuth">REST API Reference for GetBackendAuth Operation</seealso>
        GetBackendAuthResponse GetBackendAuth(GetBackendAuthRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetBackendAuth operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBackendAuth operation on AmazonAmplifyBackendClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetBackendAuth
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/GetBackendAuth">REST API Reference for GetBackendAuth Operation</seealso>
        IAsyncResult BeginGetBackendAuth(GetBackendAuthRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetBackendAuth operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBackendAuth.</param>
        /// 
        /// <returns>Returns a  GetBackendAuthResult from AmplifyBackend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/GetBackendAuth">REST API Reference for GetBackendAuth Operation</seealso>
        GetBackendAuthResponse EndGetBackendAuth(IAsyncResult asyncResult);

        #endregion
        
        #region  GetBackendJob


        /// <summary>
        /// Returns information about a specific job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBackendJob service method.</param>
        /// 
        /// <returns>The response from the GetBackendJob service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/GetBackendJob">REST API Reference for GetBackendJob Operation</seealso>
        GetBackendJobResponse GetBackendJob(GetBackendJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetBackendJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBackendJob operation on AmazonAmplifyBackendClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetBackendJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/GetBackendJob">REST API Reference for GetBackendJob Operation</seealso>
        IAsyncResult BeginGetBackendJob(GetBackendJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetBackendJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBackendJob.</param>
        /// 
        /// <returns>Returns a  GetBackendJobResult from AmplifyBackend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/GetBackendJob">REST API Reference for GetBackendJob Operation</seealso>
        GetBackendJobResponse EndGetBackendJob(IAsyncResult asyncResult);

        #endregion
        
        #region  GetBackendStorage


        /// <summary>
        /// Gets details for a backend storage resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBackendStorage service method.</param>
        /// 
        /// <returns>The response from the GetBackendStorage service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/GetBackendStorage">REST API Reference for GetBackendStorage Operation</seealso>
        GetBackendStorageResponse GetBackendStorage(GetBackendStorageRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetBackendStorage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBackendStorage operation on AmazonAmplifyBackendClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetBackendStorage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/GetBackendStorage">REST API Reference for GetBackendStorage Operation</seealso>
        IAsyncResult BeginGetBackendStorage(GetBackendStorageRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetBackendStorage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBackendStorage.</param>
        /// 
        /// <returns>Returns a  GetBackendStorageResult from AmplifyBackend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/GetBackendStorage">REST API Reference for GetBackendStorage Operation</seealso>
        GetBackendStorageResponse EndGetBackendStorage(IAsyncResult asyncResult);

        #endregion
        
        #region  GetToken


        /// <summary>
        /// Gets the challenge token based on the given appId and sessionId.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetToken service method.</param>
        /// 
        /// <returns>The response from the GetToken service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/GetToken">REST API Reference for GetToken Operation</seealso>
        GetTokenResponse GetToken(GetTokenRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetToken operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetToken operation on AmazonAmplifyBackendClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetToken
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/GetToken">REST API Reference for GetToken Operation</seealso>
        IAsyncResult BeginGetToken(GetTokenRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetToken operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetToken.</param>
        /// 
        /// <returns>Returns a  GetTokenResult from AmplifyBackend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/GetToken">REST API Reference for GetToken Operation</seealso>
        GetTokenResponse EndGetToken(IAsyncResult asyncResult);

        #endregion
        
        #region  ImportBackendAuth


        /// <summary>
        /// Imports an existing backend authentication resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportBackendAuth service method.</param>
        /// 
        /// <returns>The response from the ImportBackendAuth service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/ImportBackendAuth">REST API Reference for ImportBackendAuth Operation</seealso>
        ImportBackendAuthResponse ImportBackendAuth(ImportBackendAuthRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ImportBackendAuth operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ImportBackendAuth operation on AmazonAmplifyBackendClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndImportBackendAuth
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/ImportBackendAuth">REST API Reference for ImportBackendAuth Operation</seealso>
        IAsyncResult BeginImportBackendAuth(ImportBackendAuthRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ImportBackendAuth operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginImportBackendAuth.</param>
        /// 
        /// <returns>Returns a  ImportBackendAuthResult from AmplifyBackend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/ImportBackendAuth">REST API Reference for ImportBackendAuth Operation</seealso>
        ImportBackendAuthResponse EndImportBackendAuth(IAsyncResult asyncResult);

        #endregion
        
        #region  ImportBackendStorage


        /// <summary>
        /// Imports an existing backend storage resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportBackendStorage service method.</param>
        /// 
        /// <returns>The response from the ImportBackendStorage service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/ImportBackendStorage">REST API Reference for ImportBackendStorage Operation</seealso>
        ImportBackendStorageResponse ImportBackendStorage(ImportBackendStorageRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ImportBackendStorage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ImportBackendStorage operation on AmazonAmplifyBackendClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndImportBackendStorage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/ImportBackendStorage">REST API Reference for ImportBackendStorage Operation</seealso>
        IAsyncResult BeginImportBackendStorage(ImportBackendStorageRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ImportBackendStorage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginImportBackendStorage.</param>
        /// 
        /// <returns>Returns a  ImportBackendStorageResult from AmplifyBackend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/ImportBackendStorage">REST API Reference for ImportBackendStorage Operation</seealso>
        ImportBackendStorageResponse EndImportBackendStorage(IAsyncResult asyncResult);

        #endregion
        
        #region  ListBackendJobs


        /// <summary>
        /// Lists the jobs for the backend of an Amplify app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBackendJobs service method.</param>
        /// 
        /// <returns>The response from the ListBackendJobs service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/ListBackendJobs">REST API Reference for ListBackendJobs Operation</seealso>
        ListBackendJobsResponse ListBackendJobs(ListBackendJobsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListBackendJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListBackendJobs operation on AmazonAmplifyBackendClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListBackendJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/ListBackendJobs">REST API Reference for ListBackendJobs Operation</seealso>
        IAsyncResult BeginListBackendJobs(ListBackendJobsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListBackendJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListBackendJobs.</param>
        /// 
        /// <returns>Returns a  ListBackendJobsResult from AmplifyBackend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/ListBackendJobs">REST API Reference for ListBackendJobs Operation</seealso>
        ListBackendJobsResponse EndListBackendJobs(IAsyncResult asyncResult);

        #endregion
        
        #region  ListS3Buckets


        /// <summary>
        /// The list of S3 buckets in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListS3Buckets service method.</param>
        /// 
        /// <returns>The response from the ListS3Buckets service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/ListS3Buckets">REST API Reference for ListS3Buckets Operation</seealso>
        ListS3BucketsResponse ListS3Buckets(ListS3BucketsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListS3Buckets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListS3Buckets operation on AmazonAmplifyBackendClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListS3Buckets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/ListS3Buckets">REST API Reference for ListS3Buckets Operation</seealso>
        IAsyncResult BeginListS3Buckets(ListS3BucketsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListS3Buckets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListS3Buckets.</param>
        /// 
        /// <returns>Returns a  ListS3BucketsResult from AmplifyBackend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/ListS3Buckets">REST API Reference for ListS3Buckets Operation</seealso>
        ListS3BucketsResponse EndListS3Buckets(IAsyncResult asyncResult);

        #endregion
        
        #region  RemoveAllBackends


        /// <summary>
        /// Removes all backend environments from your Amplify project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveAllBackends service method.</param>
        /// 
        /// <returns>The response from the RemoveAllBackends service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/RemoveAllBackends">REST API Reference for RemoveAllBackends Operation</seealso>
        RemoveAllBackendsResponse RemoveAllBackends(RemoveAllBackendsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RemoveAllBackends operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveAllBackends operation on AmazonAmplifyBackendClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRemoveAllBackends
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/RemoveAllBackends">REST API Reference for RemoveAllBackends Operation</seealso>
        IAsyncResult BeginRemoveAllBackends(RemoveAllBackendsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RemoveAllBackends operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRemoveAllBackends.</param>
        /// 
        /// <returns>Returns a  RemoveAllBackendsResult from AmplifyBackend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/RemoveAllBackends">REST API Reference for RemoveAllBackends Operation</seealso>
        RemoveAllBackendsResponse EndRemoveAllBackends(IAsyncResult asyncResult);

        #endregion
        
        #region  RemoveBackendConfig


        /// <summary>
        /// Removes the AWS resources required to access the Amplify Admin UI.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveBackendConfig service method.</param>
        /// 
        /// <returns>The response from the RemoveBackendConfig service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/RemoveBackendConfig">REST API Reference for RemoveBackendConfig Operation</seealso>
        RemoveBackendConfigResponse RemoveBackendConfig(RemoveBackendConfigRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RemoveBackendConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveBackendConfig operation on AmazonAmplifyBackendClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRemoveBackendConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/RemoveBackendConfig">REST API Reference for RemoveBackendConfig Operation</seealso>
        IAsyncResult BeginRemoveBackendConfig(RemoveBackendConfigRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RemoveBackendConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRemoveBackendConfig.</param>
        /// 
        /// <returns>Returns a  RemoveBackendConfigResult from AmplifyBackend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/RemoveBackendConfig">REST API Reference for RemoveBackendConfig Operation</seealso>
        RemoveBackendConfigResponse EndRemoveBackendConfig(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateBackendAPI


        /// <summary>
        /// Updates an existing backend API resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBackendAPI service method.</param>
        /// 
        /// <returns>The response from the UpdateBackendAPI service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/UpdateBackendAPI">REST API Reference for UpdateBackendAPI Operation</seealso>
        UpdateBackendAPIResponse UpdateBackendAPI(UpdateBackendAPIRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateBackendAPI operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateBackendAPI operation on AmazonAmplifyBackendClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateBackendAPI
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/UpdateBackendAPI">REST API Reference for UpdateBackendAPI Operation</seealso>
        IAsyncResult BeginUpdateBackendAPI(UpdateBackendAPIRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateBackendAPI operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateBackendAPI.</param>
        /// 
        /// <returns>Returns a  UpdateBackendAPIResult from AmplifyBackend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/UpdateBackendAPI">REST API Reference for UpdateBackendAPI Operation</seealso>
        UpdateBackendAPIResponse EndUpdateBackendAPI(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateBackendAuth


        /// <summary>
        /// Updates an existing backend authentication resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBackendAuth service method.</param>
        /// 
        /// <returns>The response from the UpdateBackendAuth service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/UpdateBackendAuth">REST API Reference for UpdateBackendAuth Operation</seealso>
        UpdateBackendAuthResponse UpdateBackendAuth(UpdateBackendAuthRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateBackendAuth operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateBackendAuth operation on AmazonAmplifyBackendClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateBackendAuth
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/UpdateBackendAuth">REST API Reference for UpdateBackendAuth Operation</seealso>
        IAsyncResult BeginUpdateBackendAuth(UpdateBackendAuthRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateBackendAuth operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateBackendAuth.</param>
        /// 
        /// <returns>Returns a  UpdateBackendAuthResult from AmplifyBackend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/UpdateBackendAuth">REST API Reference for UpdateBackendAuth Operation</seealso>
        UpdateBackendAuthResponse EndUpdateBackendAuth(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateBackendConfig


        /// <summary>
        /// Updates the AWS resources required to access the Amplify Admin UI.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBackendConfig service method.</param>
        /// 
        /// <returns>The response from the UpdateBackendConfig service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/UpdateBackendConfig">REST API Reference for UpdateBackendConfig Operation</seealso>
        UpdateBackendConfigResponse UpdateBackendConfig(UpdateBackendConfigRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateBackendConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateBackendConfig operation on AmazonAmplifyBackendClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateBackendConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/UpdateBackendConfig">REST API Reference for UpdateBackendConfig Operation</seealso>
        IAsyncResult BeginUpdateBackendConfig(UpdateBackendConfigRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateBackendConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateBackendConfig.</param>
        /// 
        /// <returns>Returns a  UpdateBackendConfigResult from AmplifyBackend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/UpdateBackendConfig">REST API Reference for UpdateBackendConfig Operation</seealso>
        UpdateBackendConfigResponse EndUpdateBackendConfig(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateBackendJob


        /// <summary>
        /// Updates a specific job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBackendJob service method.</param>
        /// 
        /// <returns>The response from the UpdateBackendJob service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/UpdateBackendJob">REST API Reference for UpdateBackendJob Operation</seealso>
        UpdateBackendJobResponse UpdateBackendJob(UpdateBackendJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateBackendJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateBackendJob operation on AmazonAmplifyBackendClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateBackendJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/UpdateBackendJob">REST API Reference for UpdateBackendJob Operation</seealso>
        IAsyncResult BeginUpdateBackendJob(UpdateBackendJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateBackendJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateBackendJob.</param>
        /// 
        /// <returns>Returns a  UpdateBackendJobResult from AmplifyBackend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/UpdateBackendJob">REST API Reference for UpdateBackendJob Operation</seealso>
        UpdateBackendJobResponse EndUpdateBackendJob(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateBackendStorage


        /// <summary>
        /// Updates an existing backend storage resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBackendStorage service method.</param>
        /// 
        /// <returns>The response from the UpdateBackendStorage service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/UpdateBackendStorage">REST API Reference for UpdateBackendStorage Operation</seealso>
        UpdateBackendStorageResponse UpdateBackendStorage(UpdateBackendStorageRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateBackendStorage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateBackendStorage operation on AmazonAmplifyBackendClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateBackendStorage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/UpdateBackendStorage">REST API Reference for UpdateBackendStorage Operation</seealso>
        IAsyncResult BeginUpdateBackendStorage(UpdateBackendStorageRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateBackendStorage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateBackendStorage.</param>
        /// 
        /// <returns>Returns a  UpdateBackendStorageResult from AmplifyBackend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/UpdateBackendStorage">REST API Reference for UpdateBackendStorage Operation</seealso>
        UpdateBackendStorageResponse EndUpdateBackendStorage(IAsyncResult asyncResult);

        #endregion
        
    }
}