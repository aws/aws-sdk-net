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
 * Do not modify this file. This file is generated from the cloudcontrol-2021-09-30.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.CloudControlApi.Model;

namespace Amazon.CloudControlApi
{
    /// <summary>
    /// Interface for accessing CloudControlApi
    ///
    /// For more information about Amazon Web Services Cloud Control API, see the <a href="https://docs.aws.amazon.com/cloudcontrolapi/latest/userguide/what-is-cloudcontrolapi.html">Amazon
    /// Web Services Cloud Control API User Guide</a>.
    /// </summary>
    public partial interface IAmazonCloudControlApi : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        ICloudControlApiPaginatorFactory Paginators { get; }
#endif


        
        #region  CancelResourceRequest


        /// <summary>
        /// Cancels the specified resource operation request. For more information, see <a href="https://docs.aws.amazon.com/cloudcontrolapi/latest/userguide/resource-operations-manage-requests.html#resource-operations-manage-requests-cancel">Canceling
        /// resource operation requests</a> in the <i>Amazon Web Services Cloud Control API User
        /// Guide</i>.
        /// 
        ///  
        /// <para>
        /// Only resource operations requests with a status of <code>PENDING</code> or <code>IN_PROGRESS</code>
        /// can be canceled.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelResourceRequest service method.</param>
        /// 
        /// <returns>The response from the CancelResourceRequest service method, as returned by CloudControlApi.</returns>
        /// <exception cref="Amazon.CloudControlApi.Model.ConcurrentModificationException">
        /// The resource is currently being modified by another operation.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.RequestTokenNotFoundException">
        /// A resource operation with the specified request token can't be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudcontrol-2021-09-30/CancelResourceRequest">REST API Reference for CancelResourceRequest Operation</seealso>
        CancelResourceRequestResponse CancelResourceRequest(CancelResourceRequestRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CancelResourceRequest operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelResourceRequest operation on AmazonCloudControlApiClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelResourceRequest
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudcontrol-2021-09-30/CancelResourceRequest">REST API Reference for CancelResourceRequest Operation</seealso>
        IAsyncResult BeginCancelResourceRequest(CancelResourceRequestRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CancelResourceRequest operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelResourceRequest.</param>
        /// 
        /// <returns>Returns a  CancelResourceRequestResult from CloudControlApi.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudcontrol-2021-09-30/CancelResourceRequest">REST API Reference for CancelResourceRequest Operation</seealso>
        CancelResourceRequestResponse EndCancelResourceRequest(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateResource


        /// <summary>
        /// Creates the specified resource. For more information, see <a href="https://docs.aws.amazon.com/cloudcontrolapi/latest/userguide/resource-operations-create.html">Creating
        /// a resource</a> in the <i>Amazon Web Services Cloud Control API User Guide</i>.
        /// 
        ///  
        /// <para>
        /// After you have initiated a resource creation request, you can monitor the progress
        /// of your request by calling <a href="https://docs.aws.amazon.com/cloudcontrolapi/latest/APIReference/API_GetResourceRequestStatus.html">GetResourceRequestStatus</a>
        /// using the <code>RequestToken</code> of the <code>ProgressEvent</code> type returned
        /// by <code>CreateResource</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateResource service method.</param>
        /// 
        /// <returns>The response from the CreateResource service method, as returned by CloudControlApi.</returns>
        /// <exception cref="Amazon.CloudControlApi.Model.AlreadyExistsException">
        /// The resource with the name requested already exists.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.ClientTokenConflictException">
        /// The specified client token has already been used in another resource request.
        /// 
        ///  
        /// <para>
        /// It's best practice for client tokens to be unique for each resource operation request.
        /// However, client token expire after 36 hours.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.ConcurrentOperationException">
        /// Another resource operation is currently being performed on this resource.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.GeneralServiceException">
        /// The resource handler has returned that the downstream service generated an error that
        /// doesn't map to any other handler error code.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.HandlerFailureException">
        /// The resource handler has failed without a returning a more specific error code. This
        /// can include timeouts.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.HandlerInternalFailureException">
        /// The resource handler has returned that an unexpected error occurred within the resource
        /// handler.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.InvalidCredentialsException">
        /// The resource handler has returned that the credentials provided by the user are invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.InvalidRequestException">
        /// The resource handler has returned that invalid input from the user has generated a
        /// generic exception.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.NetworkFailureException">
        /// The resource handler has returned that the request couldn't be completed due to networking
        /// issues, such as a failure to receive a response from the server.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.NotStabilizedException">
        /// The resource handler has returned that the downstream resource failed to complete
        /// all of its ready-state checks.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.NotUpdatableException">
        /// One or more properties included in this resource operation are defined as create-only,
        /// and therefore can't be updated.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.PrivateTypeException">
        /// Cloud Control API hasn't received a valid response from the resource handler, due
        /// to a configuration error. This includes issues such as the resource handler returning
        /// an invalid response, or timing out.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.ResourceConflictException">
        /// The resource is temporarily unavailable to be acted upon. For example, if the resource
        /// is currently undergoing an operation and can't be acted upon until that operation
        /// is finished.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.ResourceNotFoundException">
        /// A resource with the specified identifier can't be found.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.ServiceInternalErrorException">
        /// The resource handler has returned that the downstream service returned an internal
        /// error, typically with a <code>5XX HTTP</code> status code.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.ServiceLimitExceededException">
        /// The resource handler has returned that a non-transient resource limit was reached
        /// on the service side.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.TypeNotFoundException">
        /// The specified extension doesn't exist in the CloudFormation registry.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.UnsupportedActionException">
        /// The specified resource doesn't support this resource operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudcontrol-2021-09-30/CreateResource">REST API Reference for CreateResource Operation</seealso>
        CreateResourceResponse CreateResource(CreateResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateResource operation on AmazonCloudControlApiClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudcontrol-2021-09-30/CreateResource">REST API Reference for CreateResource Operation</seealso>
        IAsyncResult BeginCreateResource(CreateResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateResource.</param>
        /// 
        /// <returns>Returns a  CreateResourceResult from CloudControlApi.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudcontrol-2021-09-30/CreateResource">REST API Reference for CreateResource Operation</seealso>
        CreateResourceResponse EndCreateResource(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteResource


        /// <summary>
        /// Deletes the specified resource. For details, see <a href="https://docs.aws.amazon.com/cloudcontrolapi/latest/userguide/resource-operations-delete.html">Deleting
        /// a resource</a> in the <i>Amazon Web Services Cloud Control API User Guide</i>.
        /// 
        ///  
        /// <para>
        /// After you have initiated a resource deletion request, you can monitor the progress
        /// of your request by calling <a href="https://docs.aws.amazon.com/cloudcontrolapi/latest/APIReference/API_GetResourceRequestStatus.html">GetResourceRequestStatus</a>
        /// using the <code>RequestToken</code> of the <code>ProgressEvent</code> returned by
        /// <code>DeleteResource</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResource service method.</param>
        /// 
        /// <returns>The response from the DeleteResource service method, as returned by CloudControlApi.</returns>
        /// <exception cref="Amazon.CloudControlApi.Model.AlreadyExistsException">
        /// The resource with the name requested already exists.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.ClientTokenConflictException">
        /// The specified client token has already been used in another resource request.
        /// 
        ///  
        /// <para>
        /// It's best practice for client tokens to be unique for each resource operation request.
        /// However, client token expire after 36 hours.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.ConcurrentOperationException">
        /// Another resource operation is currently being performed on this resource.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.GeneralServiceException">
        /// The resource handler has returned that the downstream service generated an error that
        /// doesn't map to any other handler error code.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.HandlerFailureException">
        /// The resource handler has failed without a returning a more specific error code. This
        /// can include timeouts.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.HandlerInternalFailureException">
        /// The resource handler has returned that an unexpected error occurred within the resource
        /// handler.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.InvalidCredentialsException">
        /// The resource handler has returned that the credentials provided by the user are invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.InvalidRequestException">
        /// The resource handler has returned that invalid input from the user has generated a
        /// generic exception.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.NetworkFailureException">
        /// The resource handler has returned that the request couldn't be completed due to networking
        /// issues, such as a failure to receive a response from the server.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.NotStabilizedException">
        /// The resource handler has returned that the downstream resource failed to complete
        /// all of its ready-state checks.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.NotUpdatableException">
        /// One or more properties included in this resource operation are defined as create-only,
        /// and therefore can't be updated.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.PrivateTypeException">
        /// Cloud Control API hasn't received a valid response from the resource handler, due
        /// to a configuration error. This includes issues such as the resource handler returning
        /// an invalid response, or timing out.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.ResourceConflictException">
        /// The resource is temporarily unavailable to be acted upon. For example, if the resource
        /// is currently undergoing an operation and can't be acted upon until that operation
        /// is finished.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.ResourceNotFoundException">
        /// A resource with the specified identifier can't be found.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.ServiceInternalErrorException">
        /// The resource handler has returned that the downstream service returned an internal
        /// error, typically with a <code>5XX HTTP</code> status code.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.ServiceLimitExceededException">
        /// The resource handler has returned that a non-transient resource limit was reached
        /// on the service side.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.TypeNotFoundException">
        /// The specified extension doesn't exist in the CloudFormation registry.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.UnsupportedActionException">
        /// The specified resource doesn't support this resource operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudcontrol-2021-09-30/DeleteResource">REST API Reference for DeleteResource Operation</seealso>
        DeleteResourceResponse DeleteResource(DeleteResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteResource operation on AmazonCloudControlApiClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudcontrol-2021-09-30/DeleteResource">REST API Reference for DeleteResource Operation</seealso>
        IAsyncResult BeginDeleteResource(DeleteResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteResource.</param>
        /// 
        /// <returns>Returns a  DeleteResourceResult from CloudControlApi.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudcontrol-2021-09-30/DeleteResource">REST API Reference for DeleteResource Operation</seealso>
        DeleteResourceResponse EndDeleteResource(IAsyncResult asyncResult);

        #endregion
        
        #region  GetResource


        /// <summary>
        /// Returns information about the current state of the specified resource. For details,
        /// see <a href="https://docs.aws.amazon.com/cloudcontrolapi/latest/userguide/resource-operations-read.html">Reading
        /// a resource's current state</a>.
        /// 
        ///  
        /// <para>
        /// You can use this action to return information about an existing resource in your account
        /// and Amazon Web Services Region, whether those resources were provisioned using Cloud
        /// Control API.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResource service method.</param>
        /// 
        /// <returns>The response from the GetResource service method, as returned by CloudControlApi.</returns>
        /// <exception cref="Amazon.CloudControlApi.Model.AlreadyExistsException">
        /// The resource with the name requested already exists.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.GeneralServiceException">
        /// The resource handler has returned that the downstream service generated an error that
        /// doesn't map to any other handler error code.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.HandlerFailureException">
        /// The resource handler has failed without a returning a more specific error code. This
        /// can include timeouts.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.HandlerInternalFailureException">
        /// The resource handler has returned that an unexpected error occurred within the resource
        /// handler.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.InvalidCredentialsException">
        /// The resource handler has returned that the credentials provided by the user are invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.InvalidRequestException">
        /// The resource handler has returned that invalid input from the user has generated a
        /// generic exception.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.NetworkFailureException">
        /// The resource handler has returned that the request couldn't be completed due to networking
        /// issues, such as a failure to receive a response from the server.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.NotStabilizedException">
        /// The resource handler has returned that the downstream resource failed to complete
        /// all of its ready-state checks.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.NotUpdatableException">
        /// One or more properties included in this resource operation are defined as create-only,
        /// and therefore can't be updated.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.PrivateTypeException">
        /// Cloud Control API hasn't received a valid response from the resource handler, due
        /// to a configuration error. This includes issues such as the resource handler returning
        /// an invalid response, or timing out.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.ResourceConflictException">
        /// The resource is temporarily unavailable to be acted upon. For example, if the resource
        /// is currently undergoing an operation and can't be acted upon until that operation
        /// is finished.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.ResourceNotFoundException">
        /// A resource with the specified identifier can't be found.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.ServiceInternalErrorException">
        /// The resource handler has returned that the downstream service returned an internal
        /// error, typically with a <code>5XX HTTP</code> status code.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.ServiceLimitExceededException">
        /// The resource handler has returned that a non-transient resource limit was reached
        /// on the service side.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.TypeNotFoundException">
        /// The specified extension doesn't exist in the CloudFormation registry.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.UnsupportedActionException">
        /// The specified resource doesn't support this resource operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudcontrol-2021-09-30/GetResource">REST API Reference for GetResource Operation</seealso>
        GetResourceResponse GetResource(GetResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetResource operation on AmazonCloudControlApiClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudcontrol-2021-09-30/GetResource">REST API Reference for GetResource Operation</seealso>
        IAsyncResult BeginGetResource(GetResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetResource.</param>
        /// 
        /// <returns>Returns a  GetResourceResult from CloudControlApi.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudcontrol-2021-09-30/GetResource">REST API Reference for GetResource Operation</seealso>
        GetResourceResponse EndGetResource(IAsyncResult asyncResult);

        #endregion
        
        #region  GetResourceRequestStatus


        /// <summary>
        /// Returns the current status of a resource operation request. For more information,
        /// see <a href="https://docs.aws.amazon.com/cloudcontrolapi/latest/userguide/resource-operations-manage-requests.html#resource-operations-manage-requests-track">Tracking
        /// the progress of resource operation requests</a> in the <i>Amazon Web Services Cloud
        /// Control API User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourceRequestStatus service method.</param>
        /// 
        /// <returns>The response from the GetResourceRequestStatus service method, as returned by CloudControlApi.</returns>
        /// <exception cref="Amazon.CloudControlApi.Model.RequestTokenNotFoundException">
        /// A resource operation with the specified request token can't be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudcontrol-2021-09-30/GetResourceRequestStatus">REST API Reference for GetResourceRequestStatus Operation</seealso>
        GetResourceRequestStatusResponse GetResourceRequestStatus(GetResourceRequestStatusRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetResourceRequestStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetResourceRequestStatus operation on AmazonCloudControlApiClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetResourceRequestStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudcontrol-2021-09-30/GetResourceRequestStatus">REST API Reference for GetResourceRequestStatus Operation</seealso>
        IAsyncResult BeginGetResourceRequestStatus(GetResourceRequestStatusRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetResourceRequestStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetResourceRequestStatus.</param>
        /// 
        /// <returns>Returns a  GetResourceRequestStatusResult from CloudControlApi.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudcontrol-2021-09-30/GetResourceRequestStatus">REST API Reference for GetResourceRequestStatus Operation</seealso>
        GetResourceRequestStatusResponse EndGetResourceRequestStatus(IAsyncResult asyncResult);

        #endregion
        
        #region  ListResourceRequests


        /// <summary>
        /// Returns existing resource operation requests. This includes requests of all status
        /// types. For more information, see <a href="https://docs.aws.amazon.com/cloudcontrolapi/latest/userguide/resource-operations-manage-requests.html#resource-operations-manage-requests-list">Listing
        /// active resource operation requests</a> in the <i>Amazon Web Services Cloud Control
        /// API User Guide</i>.
        /// 
        ///  <note> 
        /// <para>
        /// Resource operation requests expire after 7 days.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResourceRequests service method.</param>
        /// 
        /// <returns>The response from the ListResourceRequests service method, as returned by CloudControlApi.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudcontrol-2021-09-30/ListResourceRequests">REST API Reference for ListResourceRequests Operation</seealso>
        ListResourceRequestsResponse ListResourceRequests(ListResourceRequestsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListResourceRequests operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListResourceRequests operation on AmazonCloudControlApiClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListResourceRequests
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudcontrol-2021-09-30/ListResourceRequests">REST API Reference for ListResourceRequests Operation</seealso>
        IAsyncResult BeginListResourceRequests(ListResourceRequestsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListResourceRequests operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListResourceRequests.</param>
        /// 
        /// <returns>Returns a  ListResourceRequestsResult from CloudControlApi.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudcontrol-2021-09-30/ListResourceRequests">REST API Reference for ListResourceRequests Operation</seealso>
        ListResourceRequestsResponse EndListResourceRequests(IAsyncResult asyncResult);

        #endregion
        
        #region  ListResources


        /// <summary>
        /// Returns information about the specified resources. For more information, see <a href="https://docs.aws.amazon.com/cloudcontrolapi/latest/userguide/resource-operations-list.html">Discovering
        /// resources</a> in the <i>Amazon Web Services Cloud Control API User Guide</i>.
        /// 
        ///  
        /// <para>
        /// You can use this action to return information about existing resources in your account
        /// and Amazon Web Services Region, whether those resources were provisioned using Cloud
        /// Control API.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResources service method.</param>
        /// 
        /// <returns>The response from the ListResources service method, as returned by CloudControlApi.</returns>
        /// <exception cref="Amazon.CloudControlApi.Model.AlreadyExistsException">
        /// The resource with the name requested already exists.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.GeneralServiceException">
        /// The resource handler has returned that the downstream service generated an error that
        /// doesn't map to any other handler error code.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.HandlerFailureException">
        /// The resource handler has failed without a returning a more specific error code. This
        /// can include timeouts.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.HandlerInternalFailureException">
        /// The resource handler has returned that an unexpected error occurred within the resource
        /// handler.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.InvalidCredentialsException">
        /// The resource handler has returned that the credentials provided by the user are invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.InvalidRequestException">
        /// The resource handler has returned that invalid input from the user has generated a
        /// generic exception.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.NetworkFailureException">
        /// The resource handler has returned that the request couldn't be completed due to networking
        /// issues, such as a failure to receive a response from the server.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.NotStabilizedException">
        /// The resource handler has returned that the downstream resource failed to complete
        /// all of its ready-state checks.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.NotUpdatableException">
        /// One or more properties included in this resource operation are defined as create-only,
        /// and therefore can't be updated.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.PrivateTypeException">
        /// Cloud Control API hasn't received a valid response from the resource handler, due
        /// to a configuration error. This includes issues such as the resource handler returning
        /// an invalid response, or timing out.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.ResourceConflictException">
        /// The resource is temporarily unavailable to be acted upon. For example, if the resource
        /// is currently undergoing an operation and can't be acted upon until that operation
        /// is finished.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.ResourceNotFoundException">
        /// A resource with the specified identifier can't be found.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.ServiceInternalErrorException">
        /// The resource handler has returned that the downstream service returned an internal
        /// error, typically with a <code>5XX HTTP</code> status code.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.ServiceLimitExceededException">
        /// The resource handler has returned that a non-transient resource limit was reached
        /// on the service side.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.TypeNotFoundException">
        /// The specified extension doesn't exist in the CloudFormation registry.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.UnsupportedActionException">
        /// The specified resource doesn't support this resource operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudcontrol-2021-09-30/ListResources">REST API Reference for ListResources Operation</seealso>
        ListResourcesResponse ListResources(ListResourcesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListResources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListResources operation on AmazonCloudControlApiClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListResources
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudcontrol-2021-09-30/ListResources">REST API Reference for ListResources Operation</seealso>
        IAsyncResult BeginListResources(ListResourcesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListResources operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListResources.</param>
        /// 
        /// <returns>Returns a  ListResourcesResult from CloudControlApi.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudcontrol-2021-09-30/ListResources">REST API Reference for ListResources Operation</seealso>
        ListResourcesResponse EndListResources(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateResource


        /// <summary>
        /// Updates the specified property values in the resource.
        /// 
        ///  
        /// <para>
        /// You specify your resource property updates as a list of patch operations contained
        /// in a JSON patch document that adheres to the <a href="https://datatracker.ietf.org/doc/html/rfc6902">
        /// <i>RFC 6902 - JavaScript Object Notation (JSON) Patch</i> </a> standard.
        /// </para>
        ///  
        /// <para>
        /// For details on how Cloud Control API performs resource update operations, see <a href="https://docs.aws.amazon.com/cloudcontrolapi/latest/userguide/resource-operations-update.html">Updating
        /// a resource</a> in the <i>Amazon Web Services Cloud Control API User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// After you have initiated a resource update request, you can monitor the progress of
        /// your request by calling <a href="https://docs.aws.amazon.com/cloudcontrolapi/latest/APIReference/API_GetResourceRequestStatus.html">GetResourceRequestStatus</a>
        /// using the <code>RequestToken</code> of the <code>ProgressEvent</code> returned by
        /// <code>UpdateResource</code>.
        /// </para>
        ///  
        /// <para>
        /// For more information about the properties of a specific resource, refer to the related
        /// topic for the resource in the <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-template-resource-type-ref.html">Resource
        /// and property types reference</a> in the <i>CloudFormation Users Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateResource service method.</param>
        /// 
        /// <returns>The response from the UpdateResource service method, as returned by CloudControlApi.</returns>
        /// <exception cref="Amazon.CloudControlApi.Model.AlreadyExistsException">
        /// The resource with the name requested already exists.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.ClientTokenConflictException">
        /// The specified client token has already been used in another resource request.
        /// 
        ///  
        /// <para>
        /// It's best practice for client tokens to be unique for each resource operation request.
        /// However, client token expire after 36 hours.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.ConcurrentOperationException">
        /// Another resource operation is currently being performed on this resource.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.GeneralServiceException">
        /// The resource handler has returned that the downstream service generated an error that
        /// doesn't map to any other handler error code.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.HandlerFailureException">
        /// The resource handler has failed without a returning a more specific error code. This
        /// can include timeouts.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.HandlerInternalFailureException">
        /// The resource handler has returned that an unexpected error occurred within the resource
        /// handler.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.InvalidCredentialsException">
        /// The resource handler has returned that the credentials provided by the user are invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.InvalidRequestException">
        /// The resource handler has returned that invalid input from the user has generated a
        /// generic exception.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.NetworkFailureException">
        /// The resource handler has returned that the request couldn't be completed due to networking
        /// issues, such as a failure to receive a response from the server.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.NotStabilizedException">
        /// The resource handler has returned that the downstream resource failed to complete
        /// all of its ready-state checks.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.NotUpdatableException">
        /// One or more properties included in this resource operation are defined as create-only,
        /// and therefore can't be updated.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.PrivateTypeException">
        /// Cloud Control API hasn't received a valid response from the resource handler, due
        /// to a configuration error. This includes issues such as the resource handler returning
        /// an invalid response, or timing out.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.ResourceConflictException">
        /// The resource is temporarily unavailable to be acted upon. For example, if the resource
        /// is currently undergoing an operation and can't be acted upon until that operation
        /// is finished.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.ResourceNotFoundException">
        /// A resource with the specified identifier can't be found.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.ServiceInternalErrorException">
        /// The resource handler has returned that the downstream service returned an internal
        /// error, typically with a <code>5XX HTTP</code> status code.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.ServiceLimitExceededException">
        /// The resource handler has returned that a non-transient resource limit was reached
        /// on the service side.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.TypeNotFoundException">
        /// The specified extension doesn't exist in the CloudFormation registry.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.UnsupportedActionException">
        /// The specified resource doesn't support this resource operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudcontrol-2021-09-30/UpdateResource">REST API Reference for UpdateResource Operation</seealso>
        UpdateResourceResponse UpdateResource(UpdateResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateResource operation on AmazonCloudControlApiClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudcontrol-2021-09-30/UpdateResource">REST API Reference for UpdateResource Operation</seealso>
        IAsyncResult BeginUpdateResource(UpdateResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateResource.</param>
        /// 
        /// <returns>Returns a  UpdateResourceResult from CloudControlApi.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudcontrol-2021-09-30/UpdateResource">REST API Reference for UpdateResource Operation</seealso>
        UpdateResourceResponse EndUpdateResource(IAsyncResult asyncResult);

        #endregion
        
    }
}