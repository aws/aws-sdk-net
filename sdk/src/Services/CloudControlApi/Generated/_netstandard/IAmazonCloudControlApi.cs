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
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.CloudControlApi.Model;

#pragma warning disable CS1570
namespace Amazon.CloudControlApi
{
    /// <summary>
    /// <para>Interface for accessing CloudControlApi</para>
    ///
    /// For more information about Amazon Web Services Cloud Control API, see the <a href="https://docs.aws.amazon.com/cloudcontrolapi/latest/userguide/what-is-cloudcontrolapi.html">Amazon
    /// Web Services Cloud Control API User Guide</a>.
    /// </summary>
    public partial interface IAmazonCloudControlApi : IAmazonService, IDisposable
    {
#if AWS_ASYNC_ENUMERABLES_API
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
        /// Only resource operations requests with a status of <c>PENDING</c> or <c>IN_PROGRESS</c>
        /// can be canceled.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelResourceRequest service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelResourceRequest service method, as returned by CloudControlApi.</returns>
        /// <exception cref="Amazon.CloudControlApi.Model.ConcurrentModificationException">
        /// The resource is currently being modified by another operation.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.RequestTokenNotFoundException">
        /// A resource operation with the specified request token can't be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudcontrol-2021-09-30/CancelResourceRequest">REST API Reference for CancelResourceRequest Operation</seealso>
        Task<CancelResourceRequestResponse> CancelResourceRequestAsync(CancelResourceRequestRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// using the <c>RequestToken</c> of the <c>ProgressEvent</c> type returned by <c>CreateResource</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// error, typically with a <c>5XX HTTP</c> status code.
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
        Task<CreateResourceResponse> CreateResourceAsync(CreateResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// using the <c>RequestToken</c> of the <c>ProgressEvent</c> returned by <c>DeleteResource</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// error, typically with a <c>5XX HTTP</c> status code.
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
        Task<DeleteResourceResponse> DeleteResourceAsync(DeleteResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// error, typically with a <c>5XX HTTP</c> status code.
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
        Task<GetResourceResponse> GetResourceAsync(GetResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetResourceRequestStatus



        /// <summary>
        /// Returns the current status of a resource operation request. For more information,
        /// see <a href="https://docs.aws.amazon.com/cloudcontrolapi/latest/userguide/resource-operations-manage-requests.html#resource-operations-manage-requests-track">Tracking
        /// the progress of resource operation requests</a> in the <i>Amazon Web Services Cloud
        /// Control API User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourceRequestStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetResourceRequestStatus service method, as returned by CloudControlApi.</returns>
        /// <exception cref="Amazon.CloudControlApi.Model.RequestTokenNotFoundException">
        /// A resource operation with the specified request token can't be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudcontrol-2021-09-30/GetResourceRequestStatus">REST API Reference for GetResourceRequestStatus Operation</seealso>
        Task<GetResourceRequestStatusResponse> GetResourceRequestStatusAsync(GetResourceRequestStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListResourceRequests service method, as returned by CloudControlApi.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudcontrol-2021-09-30/ListResourceRequests">REST API Reference for ListResourceRequests Operation</seealso>
        Task<ListResourceRequestsResponse> ListResourceRequestsAsync(ListResourceRequestsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// error, typically with a <c>5XX HTTP</c> status code.
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
        Task<ListResourcesResponse> ListResourcesAsync(ListResourcesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// using the <c>RequestToken</c> of the <c>ProgressEvent</c> returned by <c>UpdateResource</c>.
        /// </para>
        ///  
        /// <para>
        /// For more information about the properties of a specific resource, refer to the related
        /// topic for the resource in the <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-template-resource-type-ref.html">Resource
        /// and property types reference</a> in the <i>CloudFormation Users Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// error, typically with a <c>5XX HTTP</c> status code.
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
        Task<UpdateResourceResponse> UpdateResourceAsync(UpdateResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        [System.Diagnostics.CodeAnalysis.DynamicDependency(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties, typeof(AmazonCloudControlApiConfig))]
        static ClientConfig IAmazonService.CreateDefaultClientConfig() => new AmazonCloudControlApiConfig();

        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("AssemblyLoadTrimming", "IL2026:RequiresUnreferencedCode",
    Justification = "This suppression is here to ignore the warnings caused by CognitoSync. See justification in IAmazonService.")]
        static IAmazonService IAmazonService.CreateDefaultServiceClient(AWSCredentials awsCredentials, ClientConfig clientConfig)
        {
            var serviceClientConfig = clientConfig as AmazonCloudControlApiConfig;
            if (serviceClientConfig == null)
            {
                throw new AmazonClientException("ClientConfig is not of type AmazonCloudControlApiConfig to create AmazonCloudControlApiClient");
            }

            return awsCredentials == null ? 
                    new AmazonCloudControlApiClient(serviceClientConfig) :
                    new AmazonCloudControlApiClient(awsCredentials, serviceClientConfig);
        }
#pragma warning restore CA1033
#endif
        #endregion
    }
}