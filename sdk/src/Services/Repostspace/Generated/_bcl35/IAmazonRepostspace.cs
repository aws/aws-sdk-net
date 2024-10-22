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
 * Do not modify this file. This file is generated from the repostspace-2022-05-13.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.Repostspace.Model;

#pragma warning disable CS1570
namespace Amazon.Repostspace
{
    /// <summary>
    /// <para>Interface for accessing Repostspace</para>
    ///
    /// AWS re:Post Private is a private version of AWS re:Post for enterprises with Enterprise
    /// Support or Enterprise On-Ramp Support plans. It provides access to knowledge and experts
    /// to accelerate cloud adoption and increase developer productivity. With your organization-specific
    /// private re:Post, you can build an organization-specific developer community that drives
    /// efficiencies at scale and provides access to valuable knowledge resources. Additionally,
    /// re:Post Private centralizes trusted AWS technical content and offers private discussion
    /// forums to improve how your teams collaborate internally and with AWS to remove technical
    /// obstacles, accelerate innovation, and scale more efficiently in the cloud.
    /// </summary>
    public partial interface IAmazonRepostspace : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IRepostspacePaginatorFactory Paginators { get; }
#endif


        
        #region  BatchAddRole


        /// <summary>
        /// Add role to multiple users or groups in a private re:Post.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchAddRole service method.</param>
        /// 
        /// <returns>The response from the BatchAddRole service method, as returned by Repostspace.</returns>
        /// <exception cref="Amazon.Repostspace.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Repostspace.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Repostspace.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Repostspace.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Repostspace.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/repostspace-2022-05-13/BatchAddRole">REST API Reference for BatchAddRole Operation</seealso>
        BatchAddRoleResponse BatchAddRole(BatchAddRoleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the BatchAddRole operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchAddRole operation on AmazonRepostspaceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchAddRole
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/repostspace-2022-05-13/BatchAddRole">REST API Reference for BatchAddRole Operation</seealso>
        IAsyncResult BeginBatchAddRole(BatchAddRoleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BatchAddRole operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchAddRole.</param>
        /// 
        /// <returns>Returns a  BatchAddRoleResult from Repostspace.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/repostspace-2022-05-13/BatchAddRole">REST API Reference for BatchAddRole Operation</seealso>
        BatchAddRoleResponse EndBatchAddRole(IAsyncResult asyncResult);

        #endregion
        
        #region  BatchRemoveRole


        /// <summary>
        /// Remove role from multiple users or groups in a private re:Post.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchRemoveRole service method.</param>
        /// 
        /// <returns>The response from the BatchRemoveRole service method, as returned by Repostspace.</returns>
        /// <exception cref="Amazon.Repostspace.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Repostspace.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Repostspace.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Repostspace.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Repostspace.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/repostspace-2022-05-13/BatchRemoveRole">REST API Reference for BatchRemoveRole Operation</seealso>
        BatchRemoveRoleResponse BatchRemoveRole(BatchRemoveRoleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the BatchRemoveRole operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchRemoveRole operation on AmazonRepostspaceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchRemoveRole
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/repostspace-2022-05-13/BatchRemoveRole">REST API Reference for BatchRemoveRole Operation</seealso>
        IAsyncResult BeginBatchRemoveRole(BatchRemoveRoleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BatchRemoveRole operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchRemoveRole.</param>
        /// 
        /// <returns>Returns a  BatchRemoveRoleResult from Repostspace.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/repostspace-2022-05-13/BatchRemoveRole">REST API Reference for BatchRemoveRole Operation</seealso>
        BatchRemoveRoleResponse EndBatchRemoveRole(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateSpace


        /// <summary>
        /// Creates an AWS re:Post Private private re:Post.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSpace service method.</param>
        /// 
        /// <returns>The response from the CreateSpace service method, as returned by Repostspace.</returns>
        /// <exception cref="Amazon.Repostspace.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Repostspace.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.Repostspace.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Repostspace.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Repostspace.Model.ServiceQuotaExceededException">
        /// Request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.Repostspace.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Repostspace.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/repostspace-2022-05-13/CreateSpace">REST API Reference for CreateSpace Operation</seealso>
        CreateSpaceResponse CreateSpace(CreateSpaceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSpace operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSpace operation on AmazonRepostspaceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSpace
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/repostspace-2022-05-13/CreateSpace">REST API Reference for CreateSpace Operation</seealso>
        IAsyncResult BeginCreateSpace(CreateSpaceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSpace operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSpace.</param>
        /// 
        /// <returns>Returns a  CreateSpaceResult from Repostspace.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/repostspace-2022-05-13/CreateSpace">REST API Reference for CreateSpace Operation</seealso>
        CreateSpaceResponse EndCreateSpace(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteSpace


        /// <summary>
        /// Deletes an AWS re:Post Private private re:Post.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSpace service method.</param>
        /// 
        /// <returns>The response from the DeleteSpace service method, as returned by Repostspace.</returns>
        /// <exception cref="Amazon.Repostspace.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Repostspace.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Repostspace.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Repostspace.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Repostspace.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/repostspace-2022-05-13/DeleteSpace">REST API Reference for DeleteSpace Operation</seealso>
        DeleteSpaceResponse DeleteSpace(DeleteSpaceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSpace operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSpace operation on AmazonRepostspaceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSpace
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/repostspace-2022-05-13/DeleteSpace">REST API Reference for DeleteSpace Operation</seealso>
        IAsyncResult BeginDeleteSpace(DeleteSpaceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSpace operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSpace.</param>
        /// 
        /// <returns>Returns a  DeleteSpaceResult from Repostspace.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/repostspace-2022-05-13/DeleteSpace">REST API Reference for DeleteSpace Operation</seealso>
        DeleteSpaceResponse EndDeleteSpace(IAsyncResult asyncResult);

        #endregion
        
        #region  DeregisterAdmin


        /// <summary>
        /// Removes the user or group from the list of administrators of the private re:Post.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterAdmin service method.</param>
        /// 
        /// <returns>The response from the DeregisterAdmin service method, as returned by Repostspace.</returns>
        /// <exception cref="Amazon.Repostspace.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Repostspace.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Repostspace.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Repostspace.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Repostspace.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/repostspace-2022-05-13/DeregisterAdmin">REST API Reference for DeregisterAdmin Operation</seealso>
        DeregisterAdminResponse DeregisterAdmin(DeregisterAdminRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeregisterAdmin operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeregisterAdmin operation on AmazonRepostspaceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeregisterAdmin
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/repostspace-2022-05-13/DeregisterAdmin">REST API Reference for DeregisterAdmin Operation</seealso>
        IAsyncResult BeginDeregisterAdmin(DeregisterAdminRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeregisterAdmin operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeregisterAdmin.</param>
        /// 
        /// <returns>Returns a  DeregisterAdminResult from Repostspace.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/repostspace-2022-05-13/DeregisterAdmin">REST API Reference for DeregisterAdmin Operation</seealso>
        DeregisterAdminResponse EndDeregisterAdmin(IAsyncResult asyncResult);

        #endregion
        
        #region  GetSpace


        /// <summary>
        /// Displays information about the AWS re:Post Private private re:Post.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSpace service method.</param>
        /// 
        /// <returns>The response from the GetSpace service method, as returned by Repostspace.</returns>
        /// <exception cref="Amazon.Repostspace.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Repostspace.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Repostspace.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Repostspace.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Repostspace.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/repostspace-2022-05-13/GetSpace">REST API Reference for GetSpace Operation</seealso>
        GetSpaceResponse GetSpace(GetSpaceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetSpace operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSpace operation on AmazonRepostspaceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSpace
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/repostspace-2022-05-13/GetSpace">REST API Reference for GetSpace Operation</seealso>
        IAsyncResult BeginGetSpace(GetSpaceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetSpace operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSpace.</param>
        /// 
        /// <returns>Returns a  GetSpaceResult from Repostspace.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/repostspace-2022-05-13/GetSpace">REST API Reference for GetSpace Operation</seealso>
        GetSpaceResponse EndGetSpace(IAsyncResult asyncResult);

        #endregion
        
        #region  ListSpaces


        /// <summary>
        /// Returns a list of AWS re:Post Private private re:Posts in the account with some information
        /// about each private re:Post.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSpaces service method.</param>
        /// 
        /// <returns>The response from the ListSpaces service method, as returned by Repostspace.</returns>
        /// <exception cref="Amazon.Repostspace.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Repostspace.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Repostspace.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Repostspace.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/repostspace-2022-05-13/ListSpaces">REST API Reference for ListSpaces Operation</seealso>
        ListSpacesResponse ListSpaces(ListSpacesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListSpaces operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSpaces operation on AmazonRepostspaceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSpaces
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/repostspace-2022-05-13/ListSpaces">REST API Reference for ListSpaces Operation</seealso>
        IAsyncResult BeginListSpaces(ListSpacesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListSpaces operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSpaces.</param>
        /// 
        /// <returns>Returns a  ListSpacesResult from Repostspace.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/repostspace-2022-05-13/ListSpaces">REST API Reference for ListSpaces Operation</seealso>
        ListSpacesResponse EndListSpaces(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Returns the tags that are associated with the AWS re:Post Private resource specified
        /// by the resourceArn. The only resource that can be tagged is a private re:Post.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Repostspace.</returns>
        /// <exception cref="Amazon.Repostspace.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Repostspace.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Repostspace.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Repostspace.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Repostspace.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/repostspace-2022-05-13/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonRepostspaceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/repostspace-2022-05-13/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from Repostspace.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/repostspace-2022-05-13/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

        #endregion
        
        #region  RegisterAdmin


        /// <summary>
        /// Adds a user or group to the list of administrators of the private re:Post.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterAdmin service method.</param>
        /// 
        /// <returns>The response from the RegisterAdmin service method, as returned by Repostspace.</returns>
        /// <exception cref="Amazon.Repostspace.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Repostspace.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Repostspace.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Repostspace.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Repostspace.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/repostspace-2022-05-13/RegisterAdmin">REST API Reference for RegisterAdmin Operation</seealso>
        RegisterAdminResponse RegisterAdmin(RegisterAdminRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RegisterAdmin operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterAdmin operation on AmazonRepostspaceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRegisterAdmin
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/repostspace-2022-05-13/RegisterAdmin">REST API Reference for RegisterAdmin Operation</seealso>
        IAsyncResult BeginRegisterAdmin(RegisterAdminRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RegisterAdmin operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRegisterAdmin.</param>
        /// 
        /// <returns>Returns a  RegisterAdminResult from Repostspace.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/repostspace-2022-05-13/RegisterAdmin">REST API Reference for RegisterAdmin Operation</seealso>
        RegisterAdminResponse EndRegisterAdmin(IAsyncResult asyncResult);

        #endregion
        
        #region  SendInvites


        /// <summary>
        /// Sends an invitation email to selected users and groups.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendInvites service method.</param>
        /// 
        /// <returns>The response from the SendInvites service method, as returned by Repostspace.</returns>
        /// <exception cref="Amazon.Repostspace.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Repostspace.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Repostspace.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Repostspace.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Repostspace.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/repostspace-2022-05-13/SendInvites">REST API Reference for SendInvites Operation</seealso>
        SendInvitesResponse SendInvites(SendInvitesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the SendInvites operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SendInvites operation on AmazonRepostspaceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSendInvites
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/repostspace-2022-05-13/SendInvites">REST API Reference for SendInvites Operation</seealso>
        IAsyncResult BeginSendInvites(SendInvitesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SendInvites operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSendInvites.</param>
        /// 
        /// <returns>Returns a  SendInvitesResult from Repostspace.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/repostspace-2022-05-13/SendInvites">REST API Reference for SendInvites Operation</seealso>
        SendInvitesResponse EndSendInvites(IAsyncResult asyncResult);

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Associates tags with an AWS re:Post Private resource. Currently, the only resource
        /// that can be tagged is the private re:Post. If you specify a new tag key for the resource,
        /// the tag is appended to the list of tags that are associated with the resource. If
        /// you specify a tag key that’s already associated with the resource, the new tag value
        /// that you specify replaces the previous value for that tag.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Repostspace.</returns>
        /// <exception cref="Amazon.Repostspace.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Repostspace.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Repostspace.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Repostspace.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Repostspace.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/repostspace-2022-05-13/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonRepostspaceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/repostspace-2022-05-13/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from Repostspace.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/repostspace-2022-05-13/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes the association of the tag with the AWS re:Post Private resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Repostspace.</returns>
        /// <exception cref="Amazon.Repostspace.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Repostspace.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Repostspace.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Repostspace.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Repostspace.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/repostspace-2022-05-13/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonRepostspaceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/repostspace-2022-05-13/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from Repostspace.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/repostspace-2022-05-13/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateSpace


        /// <summary>
        /// Modifies an existing AWS re:Post Private private re:Post.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSpace service method.</param>
        /// 
        /// <returns>The response from the UpdateSpace service method, as returned by Repostspace.</returns>
        /// <exception cref="Amazon.Repostspace.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Repostspace.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.Repostspace.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Repostspace.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Repostspace.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Repostspace.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/repostspace-2022-05-13/UpdateSpace">REST API Reference for UpdateSpace Operation</seealso>
        UpdateSpaceResponse UpdateSpace(UpdateSpaceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSpace operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSpace operation on AmazonRepostspaceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateSpace
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/repostspace-2022-05-13/UpdateSpace">REST API Reference for UpdateSpace Operation</seealso>
        IAsyncResult BeginUpdateSpace(UpdateSpaceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateSpace operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSpace.</param>
        /// 
        /// <returns>Returns a  UpdateSpaceResult from Repostspace.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/repostspace-2022-05-13/UpdateSpace">REST API Reference for UpdateSpace Operation</seealso>
        UpdateSpaceResponse EndUpdateSpace(IAsyncResult asyncResult);

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