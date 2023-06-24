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
 * Do not modify this file. This file is generated from the workdocs-2016-05-01.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.WorkDocs.Model;

namespace Amazon.WorkDocs
{
    /// <summary>
    /// Interface for accessing WorkDocs
    ///
    /// The Amazon WorkDocs API is designed for the following use cases:
    /// 
    ///  <ul> <li> 
    /// <para>
    /// File Migration: File migration applications are supported for users who want to migrate
    /// their files from an on-premises or off-premises file system or service. Users can
    /// insert files into a user directory structure, as well as allow for basic metadata
    /// changes, such as modifications to the permissions of files.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Security: Support security applications are supported for users who have additional
    /// security needs, such as antivirus or data loss prevention. The API actions, along
    /// with CloudTrail, allow these applications to detect when changes occur in Amazon WorkDocs.
    /// Then, the application can take the necessary actions and replace the target file.
    /// If the target file violates the policy, the application can also choose to email the
    /// user.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// eDiscovery/Analytics: General administrative applications are supported, such as eDiscovery
    /// and analytics. These applications can choose to mimic or record the actions in an
    /// Amazon WorkDocs site, along with CloudTrail, to replicate data for eDiscovery, backup,
    /// or analytical applications.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// All Amazon WorkDocs API actions are Amazon authenticated and certificate-signed. They
    /// not only require the use of the Amazon Web Services SDK, but also allow for the exclusive
    /// use of IAM users and roles to help facilitate access, trust, and permission policies.
    /// By creating a role and allowing an IAM user to access the Amazon WorkDocs site, the
    /// IAM user gains full administrative visibility into the entire Amazon WorkDocs site
    /// (or as set in the IAM policy). This includes, but is not limited to, the ability to
    /// modify file permissions and upload any file to any user. This allows developers to
    /// perform the three use cases above, as well as give users the ability to grant access
    /// on a selective basis using the IAM model.
    /// </para>
    ///  <note> 
    /// <para>
    /// The pricing for Amazon WorkDocs APIs varies depending on the API call type for these
    /// actions:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <code>READ (Get*)</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>WRITE (Activate*, Add*, Create*, Deactivate*, Initiate*, Update*)</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>LIST (Describe*)</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>DELETE*, CANCEL</code> 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For information about Amazon WorkDocs API pricing, see <a href="https://aws.amazon.com/workdocs/pricing/">Amazon
    /// WorkDocs Pricing</a>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial interface IAmazonWorkDocs : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IWorkDocsPaginatorFactory Paginators { get; }
#endif


        
        #region  AbortDocumentVersionUpload


        /// <summary>
        /// Aborts the upload of the specified document version that was previously initiated
        /// by <a>InitiateDocumentVersionUpload</a>. The client should make this call only when
        /// it no longer intends to upload the document version, or fails to do so.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AbortDocumentVersionUpload service method.</param>
        /// 
        /// <returns>The response from the AbortDocumentVersionUpload service method, as returned by WorkDocs.</returns>
        /// <exception cref="Amazon.WorkDocs.Model.ConcurrentModificationException">
        /// The resource hierarchy is changing.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.EntityNotExistsException">
        /// The resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.FailedDependencyException">
        /// The Directory Service cannot reach an on-premises instance. Or a dependency under
        /// the control of the organization is failing, such as a connected Active Directory.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.ProhibitedStateException">
        /// The specified document version is not in the INITIALIZED state.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.ServiceUnavailableException">
        /// One or more of the dependencies is unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedOperationException">
        /// The operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedResourceAccessException">
        /// The caller does not have access to perform the action on the resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/AbortDocumentVersionUpload">REST API Reference for AbortDocumentVersionUpload Operation</seealso>
        AbortDocumentVersionUploadResponse AbortDocumentVersionUpload(AbortDocumentVersionUploadRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AbortDocumentVersionUpload operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AbortDocumentVersionUpload operation on AmazonWorkDocsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAbortDocumentVersionUpload
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/AbortDocumentVersionUpload">REST API Reference for AbortDocumentVersionUpload Operation</seealso>
        IAsyncResult BeginAbortDocumentVersionUpload(AbortDocumentVersionUploadRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AbortDocumentVersionUpload operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAbortDocumentVersionUpload.</param>
        /// 
        /// <returns>Returns a  AbortDocumentVersionUploadResult from WorkDocs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/AbortDocumentVersionUpload">REST API Reference for AbortDocumentVersionUpload Operation</seealso>
        AbortDocumentVersionUploadResponse EndAbortDocumentVersionUpload(IAsyncResult asyncResult);

        #endregion
        
        #region  ActivateUser


        /// <summary>
        /// Activates the specified user. Only active users can access Amazon WorkDocs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ActivateUser service method.</param>
        /// 
        /// <returns>The response from the ActivateUser service method, as returned by WorkDocs.</returns>
        /// <exception cref="Amazon.WorkDocs.Model.EntityNotExistsException">
        /// The resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.FailedDependencyException">
        /// The Directory Service cannot reach an on-premises instance. Or a dependency under
        /// the control of the organization is failing, such as a connected Active Directory.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.ServiceUnavailableException">
        /// One or more of the dependencies is unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedOperationException">
        /// The operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedResourceAccessException">
        /// The caller does not have access to perform the action on the resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/ActivateUser">REST API Reference for ActivateUser Operation</seealso>
        ActivateUserResponse ActivateUser(ActivateUserRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ActivateUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ActivateUser operation on AmazonWorkDocsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndActivateUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/ActivateUser">REST API Reference for ActivateUser Operation</seealso>
        IAsyncResult BeginActivateUser(ActivateUserRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ActivateUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginActivateUser.</param>
        /// 
        /// <returns>Returns a  ActivateUserResult from WorkDocs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/ActivateUser">REST API Reference for ActivateUser Operation</seealso>
        ActivateUserResponse EndActivateUser(IAsyncResult asyncResult);

        #endregion
        
        #region  AddResourcePermissions


        /// <summary>
        /// Creates a set of permissions for the specified folder or document. The resource permissions
        /// are overwritten if the principals already have different permissions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddResourcePermissions service method.</param>
        /// 
        /// <returns>The response from the AddResourcePermissions service method, as returned by WorkDocs.</returns>
        /// <exception cref="Amazon.WorkDocs.Model.FailedDependencyException">
        /// The Directory Service cannot reach an on-premises instance. Or a dependency under
        /// the control of the organization is failing, such as a connected Active Directory.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.ProhibitedStateException">
        /// The specified document version is not in the INITIALIZED state.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.ServiceUnavailableException">
        /// One or more of the dependencies is unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedOperationException">
        /// The operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedResourceAccessException">
        /// The caller does not have access to perform the action on the resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/AddResourcePermissions">REST API Reference for AddResourcePermissions Operation</seealso>
        AddResourcePermissionsResponse AddResourcePermissions(AddResourcePermissionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AddResourcePermissions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddResourcePermissions operation on AmazonWorkDocsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAddResourcePermissions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/AddResourcePermissions">REST API Reference for AddResourcePermissions Operation</seealso>
        IAsyncResult BeginAddResourcePermissions(AddResourcePermissionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AddResourcePermissions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAddResourcePermissions.</param>
        /// 
        /// <returns>Returns a  AddResourcePermissionsResult from WorkDocs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/AddResourcePermissions">REST API Reference for AddResourcePermissions Operation</seealso>
        AddResourcePermissionsResponse EndAddResourcePermissions(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateComment


        /// <summary>
        /// Adds a new comment to the specified document version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateComment service method.</param>
        /// 
        /// <returns>The response from the CreateComment service method, as returned by WorkDocs.</returns>
        /// <exception cref="Amazon.WorkDocs.Model.DocumentLockedForCommentsException">
        /// This exception is thrown when the document is locked for comments and user tries to
        /// create or delete a comment on that document.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.EntityNotExistsException">
        /// The resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.FailedDependencyException">
        /// The Directory Service cannot reach an on-premises instance. Or a dependency under
        /// the control of the organization is failing, such as a connected Active Directory.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.InvalidCommentOperationException">
        /// The requested operation is not allowed on the specified comment object.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.ProhibitedStateException">
        /// The specified document version is not in the INITIALIZED state.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.ServiceUnavailableException">
        /// One or more of the dependencies is unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedOperationException">
        /// The operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedResourceAccessException">
        /// The caller does not have access to perform the action on the resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/CreateComment">REST API Reference for CreateComment Operation</seealso>
        CreateCommentResponse CreateComment(CreateCommentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateComment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateComment operation on AmazonWorkDocsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateComment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/CreateComment">REST API Reference for CreateComment Operation</seealso>
        IAsyncResult BeginCreateComment(CreateCommentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateComment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateComment.</param>
        /// 
        /// <returns>Returns a  CreateCommentResult from WorkDocs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/CreateComment">REST API Reference for CreateComment Operation</seealso>
        CreateCommentResponse EndCreateComment(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateCustomMetadata


        /// <summary>
        /// Adds one or more custom properties to the specified resource (a folder, document,
        /// or version).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCustomMetadata service method.</param>
        /// 
        /// <returns>The response from the CreateCustomMetadata service method, as returned by WorkDocs.</returns>
        /// <exception cref="Amazon.WorkDocs.Model.CustomMetadataLimitExceededException">
        /// The limit has been reached on the number of custom properties for the specified resource.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.EntityNotExistsException">
        /// The resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.FailedDependencyException">
        /// The Directory Service cannot reach an on-premises instance. Or a dependency under
        /// the control of the organization is failing, such as a connected Active Directory.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.ProhibitedStateException">
        /// The specified document version is not in the INITIALIZED state.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.ServiceUnavailableException">
        /// One or more of the dependencies is unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedOperationException">
        /// The operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedResourceAccessException">
        /// The caller does not have access to perform the action on the resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/CreateCustomMetadata">REST API Reference for CreateCustomMetadata Operation</seealso>
        CreateCustomMetadataResponse CreateCustomMetadata(CreateCustomMetadataRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCustomMetadata operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCustomMetadata operation on AmazonWorkDocsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateCustomMetadata
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/CreateCustomMetadata">REST API Reference for CreateCustomMetadata Operation</seealso>
        IAsyncResult BeginCreateCustomMetadata(CreateCustomMetadataRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateCustomMetadata operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCustomMetadata.</param>
        /// 
        /// <returns>Returns a  CreateCustomMetadataResult from WorkDocs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/CreateCustomMetadata">REST API Reference for CreateCustomMetadata Operation</seealso>
        CreateCustomMetadataResponse EndCreateCustomMetadata(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateFolder


        /// <summary>
        /// Creates a folder with the specified name and parent folder.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFolder service method.</param>
        /// 
        /// <returns>The response from the CreateFolder service method, as returned by WorkDocs.</returns>
        /// <exception cref="Amazon.WorkDocs.Model.ConcurrentModificationException">
        /// The resource hierarchy is changing.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.ConflictingOperationException">
        /// Another operation is in progress on the resource that conflicts with the current operation.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.EntityAlreadyExistsException">
        /// The resource already exists.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.EntityNotExistsException">
        /// The resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.FailedDependencyException">
        /// The Directory Service cannot reach an on-premises instance. Or a dependency under
        /// the control of the organization is failing, such as a connected Active Directory.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.LimitExceededException">
        /// The maximum of 100,000 files and folders under the parent folder has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.ProhibitedStateException">
        /// The specified document version is not in the INITIALIZED state.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.ServiceUnavailableException">
        /// One or more of the dependencies is unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedOperationException">
        /// The operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedResourceAccessException">
        /// The caller does not have access to perform the action on the resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/CreateFolder">REST API Reference for CreateFolder Operation</seealso>
        CreateFolderResponse CreateFolder(CreateFolderRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateFolder operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateFolder operation on AmazonWorkDocsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateFolder
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/CreateFolder">REST API Reference for CreateFolder Operation</seealso>
        IAsyncResult BeginCreateFolder(CreateFolderRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateFolder operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateFolder.</param>
        /// 
        /// <returns>Returns a  CreateFolderResult from WorkDocs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/CreateFolder">REST API Reference for CreateFolder Operation</seealso>
        CreateFolderResponse EndCreateFolder(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateLabels


        /// <summary>
        /// Adds the specified list of labels to the given resource (a document or folder)
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLabels service method.</param>
        /// 
        /// <returns>The response from the CreateLabels service method, as returned by WorkDocs.</returns>
        /// <exception cref="Amazon.WorkDocs.Model.EntityNotExistsException">
        /// The resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.FailedDependencyException">
        /// The Directory Service cannot reach an on-premises instance. Or a dependency under
        /// the control of the organization is failing, such as a connected Active Directory.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.ServiceUnavailableException">
        /// One or more of the dependencies is unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.TooManyLabelsException">
        /// The limit has been reached on the number of labels for the specified resource.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedOperationException">
        /// The operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedResourceAccessException">
        /// The caller does not have access to perform the action on the resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/CreateLabels">REST API Reference for CreateLabels Operation</seealso>
        CreateLabelsResponse CreateLabels(CreateLabelsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateLabels operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLabels operation on AmazonWorkDocsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateLabels
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/CreateLabels">REST API Reference for CreateLabels Operation</seealso>
        IAsyncResult BeginCreateLabels(CreateLabelsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateLabels operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateLabels.</param>
        /// 
        /// <returns>Returns a  CreateLabelsResult from WorkDocs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/CreateLabels">REST API Reference for CreateLabels Operation</seealso>
        CreateLabelsResponse EndCreateLabels(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateNotificationSubscription


        /// <summary>
        /// Configure Amazon WorkDocs to use Amazon SNS notifications. The endpoint receives a
        /// confirmation message, and must confirm the subscription.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/workdocs/latest/developerguide/manage-notifications.html">Setting
        /// up notifications for an IAM user or role</a> in the <i>Amazon WorkDocs Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateNotificationSubscription service method.</param>
        /// 
        /// <returns>The response from the CreateNotificationSubscription service method, as returned by WorkDocs.</returns>
        /// <exception cref="Amazon.WorkDocs.Model.InvalidArgumentException">
        /// The pagination marker or limit fields are not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.ServiceUnavailableException">
        /// One or more of the dependencies is unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.TooManySubscriptionsException">
        /// You've reached the limit on the number of subscriptions for the WorkDocs instance.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedResourceAccessException">
        /// The caller does not have access to perform the action on the resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/CreateNotificationSubscription">REST API Reference for CreateNotificationSubscription Operation</seealso>
        CreateNotificationSubscriptionResponse CreateNotificationSubscription(CreateNotificationSubscriptionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateNotificationSubscription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateNotificationSubscription operation on AmazonWorkDocsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateNotificationSubscription
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/CreateNotificationSubscription">REST API Reference for CreateNotificationSubscription Operation</seealso>
        IAsyncResult BeginCreateNotificationSubscription(CreateNotificationSubscriptionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateNotificationSubscription operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateNotificationSubscription.</param>
        /// 
        /// <returns>Returns a  CreateNotificationSubscriptionResult from WorkDocs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/CreateNotificationSubscription">REST API Reference for CreateNotificationSubscription Operation</seealso>
        CreateNotificationSubscriptionResponse EndCreateNotificationSubscription(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateUser


        /// <summary>
        /// Creates a user in a Simple AD or Microsoft AD directory. The status of a newly created
        /// user is "ACTIVE". New users can access Amazon WorkDocs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateUser service method.</param>
        /// 
        /// <returns>The response from the CreateUser service method, as returned by WorkDocs.</returns>
        /// <exception cref="Amazon.WorkDocs.Model.EntityAlreadyExistsException">
        /// The resource already exists.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.FailedDependencyException">
        /// The Directory Service cannot reach an on-premises instance. Or a dependency under
        /// the control of the organization is failing, such as a connected Active Directory.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.ServiceUnavailableException">
        /// One or more of the dependencies is unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedOperationException">
        /// The operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedResourceAccessException">
        /// The caller does not have access to perform the action on the resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/CreateUser">REST API Reference for CreateUser Operation</seealso>
        CreateUserResponse CreateUser(CreateUserRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateUser operation on AmazonWorkDocsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/CreateUser">REST API Reference for CreateUser Operation</seealso>
        IAsyncResult BeginCreateUser(CreateUserRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateUser.</param>
        /// 
        /// <returns>Returns a  CreateUserResult from WorkDocs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/CreateUser">REST API Reference for CreateUser Operation</seealso>
        CreateUserResponse EndCreateUser(IAsyncResult asyncResult);

        #endregion
        
        #region  DeactivateUser


        /// <summary>
        /// Deactivates the specified user, which revokes the user's access to Amazon WorkDocs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeactivateUser service method.</param>
        /// 
        /// <returns>The response from the DeactivateUser service method, as returned by WorkDocs.</returns>
        /// <exception cref="Amazon.WorkDocs.Model.EntityNotExistsException">
        /// The resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.FailedDependencyException">
        /// The Directory Service cannot reach an on-premises instance. Or a dependency under
        /// the control of the organization is failing, such as a connected Active Directory.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.ServiceUnavailableException">
        /// One or more of the dependencies is unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedOperationException">
        /// The operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedResourceAccessException">
        /// The caller does not have access to perform the action on the resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/DeactivateUser">REST API Reference for DeactivateUser Operation</seealso>
        DeactivateUserResponse DeactivateUser(DeactivateUserRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeactivateUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeactivateUser operation on AmazonWorkDocsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeactivateUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/DeactivateUser">REST API Reference for DeactivateUser Operation</seealso>
        IAsyncResult BeginDeactivateUser(DeactivateUserRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeactivateUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeactivateUser.</param>
        /// 
        /// <returns>Returns a  DeactivateUserResult from WorkDocs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/DeactivateUser">REST API Reference for DeactivateUser Operation</seealso>
        DeactivateUserResponse EndDeactivateUser(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteComment


        /// <summary>
        /// Deletes the specified comment from the document version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteComment service method.</param>
        /// 
        /// <returns>The response from the DeleteComment service method, as returned by WorkDocs.</returns>
        /// <exception cref="Amazon.WorkDocs.Model.DocumentLockedForCommentsException">
        /// This exception is thrown when the document is locked for comments and user tries to
        /// create or delete a comment on that document.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.EntityNotExistsException">
        /// The resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.FailedDependencyException">
        /// The Directory Service cannot reach an on-premises instance. Or a dependency under
        /// the control of the organization is failing, such as a connected Active Directory.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.ProhibitedStateException">
        /// The specified document version is not in the INITIALIZED state.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.ServiceUnavailableException">
        /// One or more of the dependencies is unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedOperationException">
        /// The operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedResourceAccessException">
        /// The caller does not have access to perform the action on the resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/DeleteComment">REST API Reference for DeleteComment Operation</seealso>
        DeleteCommentResponse DeleteComment(DeleteCommentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteComment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteComment operation on AmazonWorkDocsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteComment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/DeleteComment">REST API Reference for DeleteComment Operation</seealso>
        IAsyncResult BeginDeleteComment(DeleteCommentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteComment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteComment.</param>
        /// 
        /// <returns>Returns a  DeleteCommentResult from WorkDocs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/DeleteComment">REST API Reference for DeleteComment Operation</seealso>
        DeleteCommentResponse EndDeleteComment(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteCustomMetadata


        /// <summary>
        /// Deletes custom metadata from the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCustomMetadata service method.</param>
        /// 
        /// <returns>The response from the DeleteCustomMetadata service method, as returned by WorkDocs.</returns>
        /// <exception cref="Amazon.WorkDocs.Model.EntityNotExistsException">
        /// The resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.FailedDependencyException">
        /// The Directory Service cannot reach an on-premises instance. Or a dependency under
        /// the control of the organization is failing, such as a connected Active Directory.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.ProhibitedStateException">
        /// The specified document version is not in the INITIALIZED state.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.ServiceUnavailableException">
        /// One or more of the dependencies is unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedOperationException">
        /// The operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedResourceAccessException">
        /// The caller does not have access to perform the action on the resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/DeleteCustomMetadata">REST API Reference for DeleteCustomMetadata Operation</seealso>
        DeleteCustomMetadataResponse DeleteCustomMetadata(DeleteCustomMetadataRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCustomMetadata operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCustomMetadata operation on AmazonWorkDocsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteCustomMetadata
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/DeleteCustomMetadata">REST API Reference for DeleteCustomMetadata Operation</seealso>
        IAsyncResult BeginDeleteCustomMetadata(DeleteCustomMetadataRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteCustomMetadata operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCustomMetadata.</param>
        /// 
        /// <returns>Returns a  DeleteCustomMetadataResult from WorkDocs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/DeleteCustomMetadata">REST API Reference for DeleteCustomMetadata Operation</seealso>
        DeleteCustomMetadataResponse EndDeleteCustomMetadata(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteDocument


        /// <summary>
        /// Permanently deletes the specified document and its associated metadata.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDocument service method.</param>
        /// 
        /// <returns>The response from the DeleteDocument service method, as returned by WorkDocs.</returns>
        /// <exception cref="Amazon.WorkDocs.Model.ConcurrentModificationException">
        /// The resource hierarchy is changing.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.ConflictingOperationException">
        /// Another operation is in progress on the resource that conflicts with the current operation.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.EntityNotExistsException">
        /// The resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.FailedDependencyException">
        /// The Directory Service cannot reach an on-premises instance. Or a dependency under
        /// the control of the organization is failing, such as a connected Active Directory.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.LimitExceededException">
        /// The maximum of 100,000 files and folders under the parent folder has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.ProhibitedStateException">
        /// The specified document version is not in the INITIALIZED state.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.ServiceUnavailableException">
        /// One or more of the dependencies is unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedOperationException">
        /// The operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedResourceAccessException">
        /// The caller does not have access to perform the action on the resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/DeleteDocument">REST API Reference for DeleteDocument Operation</seealso>
        DeleteDocumentResponse DeleteDocument(DeleteDocumentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDocument operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDocument operation on AmazonWorkDocsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDocument
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/DeleteDocument">REST API Reference for DeleteDocument Operation</seealso>
        IAsyncResult BeginDeleteDocument(DeleteDocumentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDocument operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDocument.</param>
        /// 
        /// <returns>Returns a  DeleteDocumentResult from WorkDocs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/DeleteDocument">REST API Reference for DeleteDocument Operation</seealso>
        DeleteDocumentResponse EndDeleteDocument(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteDocumentVersion


        /// <summary>
        /// Deletes a specific version of a document.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDocumentVersion service method.</param>
        /// 
        /// <returns>The response from the DeleteDocumentVersion service method, as returned by WorkDocs.</returns>
        /// <exception cref="Amazon.WorkDocs.Model.ConcurrentModificationException">
        /// The resource hierarchy is changing.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.ConflictingOperationException">
        /// Another operation is in progress on the resource that conflicts with the current operation.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.EntityNotExistsException">
        /// The resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.FailedDependencyException">
        /// The Directory Service cannot reach an on-premises instance. Or a dependency under
        /// the control of the organization is failing, such as a connected Active Directory.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.InvalidOperationException">
        /// The operation is invalid.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.ProhibitedStateException">
        /// The specified document version is not in the INITIALIZED state.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedOperationException">
        /// The operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedResourceAccessException">
        /// The caller does not have access to perform the action on the resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/DeleteDocumentVersion">REST API Reference for DeleteDocumentVersion Operation</seealso>
        DeleteDocumentVersionResponse DeleteDocumentVersion(DeleteDocumentVersionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDocumentVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDocumentVersion operation on AmazonWorkDocsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDocumentVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/DeleteDocumentVersion">REST API Reference for DeleteDocumentVersion Operation</seealso>
        IAsyncResult BeginDeleteDocumentVersion(DeleteDocumentVersionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDocumentVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDocumentVersion.</param>
        /// 
        /// <returns>Returns a  DeleteDocumentVersionResult from WorkDocs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/DeleteDocumentVersion">REST API Reference for DeleteDocumentVersion Operation</seealso>
        DeleteDocumentVersionResponse EndDeleteDocumentVersion(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteFolder


        /// <summary>
        /// Permanently deletes the specified folder and its contents.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFolder service method.</param>
        /// 
        /// <returns>The response from the DeleteFolder service method, as returned by WorkDocs.</returns>
        /// <exception cref="Amazon.WorkDocs.Model.ConcurrentModificationException">
        /// The resource hierarchy is changing.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.ConflictingOperationException">
        /// Another operation is in progress on the resource that conflicts with the current operation.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.EntityNotExistsException">
        /// The resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.FailedDependencyException">
        /// The Directory Service cannot reach an on-premises instance. Or a dependency under
        /// the control of the organization is failing, such as a connected Active Directory.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.LimitExceededException">
        /// The maximum of 100,000 files and folders under the parent folder has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.ProhibitedStateException">
        /// The specified document version is not in the INITIALIZED state.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.ServiceUnavailableException">
        /// One or more of the dependencies is unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedOperationException">
        /// The operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedResourceAccessException">
        /// The caller does not have access to perform the action on the resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/DeleteFolder">REST API Reference for DeleteFolder Operation</seealso>
        DeleteFolderResponse DeleteFolder(DeleteFolderRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteFolder operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteFolder operation on AmazonWorkDocsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteFolder
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/DeleteFolder">REST API Reference for DeleteFolder Operation</seealso>
        IAsyncResult BeginDeleteFolder(DeleteFolderRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteFolder operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteFolder.</param>
        /// 
        /// <returns>Returns a  DeleteFolderResult from WorkDocs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/DeleteFolder">REST API Reference for DeleteFolder Operation</seealso>
        DeleteFolderResponse EndDeleteFolder(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteFolderContents


        /// <summary>
        /// Deletes the contents of the specified folder.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFolderContents service method.</param>
        /// 
        /// <returns>The response from the DeleteFolderContents service method, as returned by WorkDocs.</returns>
        /// <exception cref="Amazon.WorkDocs.Model.ConflictingOperationException">
        /// Another operation is in progress on the resource that conflicts with the current operation.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.EntityNotExistsException">
        /// The resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.FailedDependencyException">
        /// The Directory Service cannot reach an on-premises instance. Or a dependency under
        /// the control of the organization is failing, such as a connected Active Directory.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.ProhibitedStateException">
        /// The specified document version is not in the INITIALIZED state.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.ServiceUnavailableException">
        /// One or more of the dependencies is unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedOperationException">
        /// The operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedResourceAccessException">
        /// The caller does not have access to perform the action on the resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/DeleteFolderContents">REST API Reference for DeleteFolderContents Operation</seealso>
        DeleteFolderContentsResponse DeleteFolderContents(DeleteFolderContentsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteFolderContents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteFolderContents operation on AmazonWorkDocsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteFolderContents
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/DeleteFolderContents">REST API Reference for DeleteFolderContents Operation</seealso>
        IAsyncResult BeginDeleteFolderContents(DeleteFolderContentsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteFolderContents operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteFolderContents.</param>
        /// 
        /// <returns>Returns a  DeleteFolderContentsResult from WorkDocs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/DeleteFolderContents">REST API Reference for DeleteFolderContents Operation</seealso>
        DeleteFolderContentsResponse EndDeleteFolderContents(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteLabels


        /// <summary>
        /// Deletes the specified list of labels from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLabels service method.</param>
        /// 
        /// <returns>The response from the DeleteLabels service method, as returned by WorkDocs.</returns>
        /// <exception cref="Amazon.WorkDocs.Model.EntityNotExistsException">
        /// The resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.FailedDependencyException">
        /// The Directory Service cannot reach an on-premises instance. Or a dependency under
        /// the control of the organization is failing, such as a connected Active Directory.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.ProhibitedStateException">
        /// The specified document version is not in the INITIALIZED state.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.ServiceUnavailableException">
        /// One or more of the dependencies is unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedOperationException">
        /// The operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedResourceAccessException">
        /// The caller does not have access to perform the action on the resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/DeleteLabels">REST API Reference for DeleteLabels Operation</seealso>
        DeleteLabelsResponse DeleteLabels(DeleteLabelsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLabels operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLabels operation on AmazonWorkDocsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteLabels
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/DeleteLabels">REST API Reference for DeleteLabels Operation</seealso>
        IAsyncResult BeginDeleteLabels(DeleteLabelsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteLabels operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteLabels.</param>
        /// 
        /// <returns>Returns a  DeleteLabelsResult from WorkDocs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/DeleteLabels">REST API Reference for DeleteLabels Operation</seealso>
        DeleteLabelsResponse EndDeleteLabels(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteNotificationSubscription


        /// <summary>
        /// Deletes the specified subscription from the specified organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteNotificationSubscription service method.</param>
        /// 
        /// <returns>The response from the DeleteNotificationSubscription service method, as returned by WorkDocs.</returns>
        /// <exception cref="Amazon.WorkDocs.Model.EntityNotExistsException">
        /// The resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.ProhibitedStateException">
        /// The specified document version is not in the INITIALIZED state.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.ServiceUnavailableException">
        /// One or more of the dependencies is unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedResourceAccessException">
        /// The caller does not have access to perform the action on the resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/DeleteNotificationSubscription">REST API Reference for DeleteNotificationSubscription Operation</seealso>
        DeleteNotificationSubscriptionResponse DeleteNotificationSubscription(DeleteNotificationSubscriptionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteNotificationSubscription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteNotificationSubscription operation on AmazonWorkDocsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteNotificationSubscription
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/DeleteNotificationSubscription">REST API Reference for DeleteNotificationSubscription Operation</seealso>
        IAsyncResult BeginDeleteNotificationSubscription(DeleteNotificationSubscriptionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteNotificationSubscription operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteNotificationSubscription.</param>
        /// 
        /// <returns>Returns a  DeleteNotificationSubscriptionResult from WorkDocs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/DeleteNotificationSubscription">REST API Reference for DeleteNotificationSubscription Operation</seealso>
        DeleteNotificationSubscriptionResponse EndDeleteNotificationSubscription(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteUser


        /// <summary>
        /// Deletes the specified user from a Simple AD or Microsoft AD directory.
        /// 
        ///  <important> 
        /// <para>
        /// Deleting a user immediately and permanently deletes all content in that user's folder
        /// structure. Site retention policies do NOT apply to this type of deletion.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteUser service method.</param>
        /// 
        /// <returns>The response from the DeleteUser service method, as returned by WorkDocs.</returns>
        /// <exception cref="Amazon.WorkDocs.Model.EntityNotExistsException">
        /// The resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.FailedDependencyException">
        /// The Directory Service cannot reach an on-premises instance. Or a dependency under
        /// the control of the organization is failing, such as a connected Active Directory.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.ServiceUnavailableException">
        /// One or more of the dependencies is unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedOperationException">
        /// The operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedResourceAccessException">
        /// The caller does not have access to perform the action on the resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/DeleteUser">REST API Reference for DeleteUser Operation</seealso>
        DeleteUserResponse DeleteUser(DeleteUserRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteUser operation on AmazonWorkDocsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/DeleteUser">REST API Reference for DeleteUser Operation</seealso>
        IAsyncResult BeginDeleteUser(DeleteUserRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteUser.</param>
        /// 
        /// <returns>Returns a  DeleteUserResult from WorkDocs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/DeleteUser">REST API Reference for DeleteUser Operation</seealso>
        DeleteUserResponse EndDeleteUser(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeActivities


        /// <summary>
        /// Describes the user activities in a specified time period.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeActivities service method.</param>
        /// 
        /// <returns>The response from the DescribeActivities service method, as returned by WorkDocs.</returns>
        /// <exception cref="Amazon.WorkDocs.Model.FailedDependencyException">
        /// The Directory Service cannot reach an on-premises instance. Or a dependency under
        /// the control of the organization is failing, such as a connected Active Directory.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.InvalidArgumentException">
        /// The pagination marker or limit fields are not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.ServiceUnavailableException">
        /// One or more of the dependencies is unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedOperationException">
        /// The operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedResourceAccessException">
        /// The caller does not have access to perform the action on the resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/DescribeActivities">REST API Reference for DescribeActivities Operation</seealso>
        DescribeActivitiesResponse DescribeActivities(DescribeActivitiesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeActivities operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeActivities operation on AmazonWorkDocsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeActivities
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/DescribeActivities">REST API Reference for DescribeActivities Operation</seealso>
        IAsyncResult BeginDescribeActivities(DescribeActivitiesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeActivities operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeActivities.</param>
        /// 
        /// <returns>Returns a  DescribeActivitiesResult from WorkDocs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/DescribeActivities">REST API Reference for DescribeActivities Operation</seealso>
        DescribeActivitiesResponse EndDescribeActivities(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeComments


        /// <summary>
        /// List all the comments for the specified document version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeComments service method.</param>
        /// 
        /// <returns>The response from the DescribeComments service method, as returned by WorkDocs.</returns>
        /// <exception cref="Amazon.WorkDocs.Model.EntityNotExistsException">
        /// The resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.FailedDependencyException">
        /// The Directory Service cannot reach an on-premises instance. Or a dependency under
        /// the control of the organization is failing, such as a connected Active Directory.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.ProhibitedStateException">
        /// The specified document version is not in the INITIALIZED state.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.ServiceUnavailableException">
        /// One or more of the dependencies is unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedOperationException">
        /// The operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedResourceAccessException">
        /// The caller does not have access to perform the action on the resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/DescribeComments">REST API Reference for DescribeComments Operation</seealso>
        DescribeCommentsResponse DescribeComments(DescribeCommentsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeComments operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeComments operation on AmazonWorkDocsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeComments
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/DescribeComments">REST API Reference for DescribeComments Operation</seealso>
        IAsyncResult BeginDescribeComments(DescribeCommentsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeComments operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeComments.</param>
        /// 
        /// <returns>Returns a  DescribeCommentsResult from WorkDocs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/DescribeComments">REST API Reference for DescribeComments Operation</seealso>
        DescribeCommentsResponse EndDescribeComments(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeDocumentVersions


        /// <summary>
        /// Retrieves the document versions for the specified document.
        /// 
        ///  
        /// <para>
        /// By default, only active versions are returned.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDocumentVersions service method.</param>
        /// 
        /// <returns>The response from the DescribeDocumentVersions service method, as returned by WorkDocs.</returns>
        /// <exception cref="Amazon.WorkDocs.Model.EntityNotExistsException">
        /// The resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.FailedDependencyException">
        /// The Directory Service cannot reach an on-premises instance. Or a dependency under
        /// the control of the organization is failing, such as a connected Active Directory.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.InvalidArgumentException">
        /// The pagination marker or limit fields are not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.InvalidPasswordException">
        /// The password is invalid.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.ProhibitedStateException">
        /// The specified document version is not in the INITIALIZED state.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.ServiceUnavailableException">
        /// One or more of the dependencies is unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedOperationException">
        /// The operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedResourceAccessException">
        /// The caller does not have access to perform the action on the resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/DescribeDocumentVersions">REST API Reference for DescribeDocumentVersions Operation</seealso>
        DescribeDocumentVersionsResponse DescribeDocumentVersions(DescribeDocumentVersionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDocumentVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDocumentVersions operation on AmazonWorkDocsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDocumentVersions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/DescribeDocumentVersions">REST API Reference for DescribeDocumentVersions Operation</seealso>
        IAsyncResult BeginDescribeDocumentVersions(DescribeDocumentVersionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDocumentVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDocumentVersions.</param>
        /// 
        /// <returns>Returns a  DescribeDocumentVersionsResult from WorkDocs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/DescribeDocumentVersions">REST API Reference for DescribeDocumentVersions Operation</seealso>
        DescribeDocumentVersionsResponse EndDescribeDocumentVersions(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeFolderContents


        /// <summary>
        /// Describes the contents of the specified folder, including its documents and subfolders.
        /// 
        ///  
        /// <para>
        /// By default, Amazon WorkDocs returns the first 100 active document and folder metadata
        /// items. If there are more results, the response includes a marker that you can use
        /// to request the next set of results. You can also request initialized documents.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFolderContents service method.</param>
        /// 
        /// <returns>The response from the DescribeFolderContents service method, as returned by WorkDocs.</returns>
        /// <exception cref="Amazon.WorkDocs.Model.EntityNotExistsException">
        /// The resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.FailedDependencyException">
        /// The Directory Service cannot reach an on-premises instance. Or a dependency under
        /// the control of the organization is failing, such as a connected Active Directory.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.InvalidArgumentException">
        /// The pagination marker or limit fields are not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.ProhibitedStateException">
        /// The specified document version is not in the INITIALIZED state.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.ServiceUnavailableException">
        /// One or more of the dependencies is unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedResourceAccessException">
        /// The caller does not have access to perform the action on the resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/DescribeFolderContents">REST API Reference for DescribeFolderContents Operation</seealso>
        DescribeFolderContentsResponse DescribeFolderContents(DescribeFolderContentsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeFolderContents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeFolderContents operation on AmazonWorkDocsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeFolderContents
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/DescribeFolderContents">REST API Reference for DescribeFolderContents Operation</seealso>
        IAsyncResult BeginDescribeFolderContents(DescribeFolderContentsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeFolderContents operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeFolderContents.</param>
        /// 
        /// <returns>Returns a  DescribeFolderContentsResult from WorkDocs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/DescribeFolderContents">REST API Reference for DescribeFolderContents Operation</seealso>
        DescribeFolderContentsResponse EndDescribeFolderContents(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeGroups


        /// <summary>
        /// Describes the groups specified by the query. Groups are defined by the underlying
        /// Active Directory.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeGroups service method.</param>
        /// 
        /// <returns>The response from the DescribeGroups service method, as returned by WorkDocs.</returns>
        /// <exception cref="Amazon.WorkDocs.Model.FailedDependencyException">
        /// The Directory Service cannot reach an on-premises instance. Or a dependency under
        /// the control of the organization is failing, such as a connected Active Directory.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.ServiceUnavailableException">
        /// One or more of the dependencies is unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedOperationException">
        /// The operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedResourceAccessException">
        /// The caller does not have access to perform the action on the resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/DescribeGroups">REST API Reference for DescribeGroups Operation</seealso>
        DescribeGroupsResponse DescribeGroups(DescribeGroupsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeGroups operation on AmazonWorkDocsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeGroups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/DescribeGroups">REST API Reference for DescribeGroups Operation</seealso>
        IAsyncResult BeginDescribeGroups(DescribeGroupsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeGroups.</param>
        /// 
        /// <returns>Returns a  DescribeGroupsResult from WorkDocs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/DescribeGroups">REST API Reference for DescribeGroups Operation</seealso>
        DescribeGroupsResponse EndDescribeGroups(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeNotificationSubscriptions


        /// <summary>
        /// Lists the specified notification subscriptions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeNotificationSubscriptions service method.</param>
        /// 
        /// <returns>The response from the DescribeNotificationSubscriptions service method, as returned by WorkDocs.</returns>
        /// <exception cref="Amazon.WorkDocs.Model.EntityNotExistsException">
        /// The resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.ServiceUnavailableException">
        /// One or more of the dependencies is unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedResourceAccessException">
        /// The caller does not have access to perform the action on the resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/DescribeNotificationSubscriptions">REST API Reference for DescribeNotificationSubscriptions Operation</seealso>
        DescribeNotificationSubscriptionsResponse DescribeNotificationSubscriptions(DescribeNotificationSubscriptionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeNotificationSubscriptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeNotificationSubscriptions operation on AmazonWorkDocsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeNotificationSubscriptions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/DescribeNotificationSubscriptions">REST API Reference for DescribeNotificationSubscriptions Operation</seealso>
        IAsyncResult BeginDescribeNotificationSubscriptions(DescribeNotificationSubscriptionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeNotificationSubscriptions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeNotificationSubscriptions.</param>
        /// 
        /// <returns>Returns a  DescribeNotificationSubscriptionsResult from WorkDocs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/DescribeNotificationSubscriptions">REST API Reference for DescribeNotificationSubscriptions Operation</seealso>
        DescribeNotificationSubscriptionsResponse EndDescribeNotificationSubscriptions(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeResourcePermissions


        /// <summary>
        /// Describes the permissions of a specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeResourcePermissions service method.</param>
        /// 
        /// <returns>The response from the DescribeResourcePermissions service method, as returned by WorkDocs.</returns>
        /// <exception cref="Amazon.WorkDocs.Model.FailedDependencyException">
        /// The Directory Service cannot reach an on-premises instance. Or a dependency under
        /// the control of the organization is failing, such as a connected Active Directory.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.InvalidArgumentException">
        /// The pagination marker or limit fields are not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.ServiceUnavailableException">
        /// One or more of the dependencies is unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedOperationException">
        /// The operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedResourceAccessException">
        /// The caller does not have access to perform the action on the resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/DescribeResourcePermissions">REST API Reference for DescribeResourcePermissions Operation</seealso>
        DescribeResourcePermissionsResponse DescribeResourcePermissions(DescribeResourcePermissionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeResourcePermissions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeResourcePermissions operation on AmazonWorkDocsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeResourcePermissions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/DescribeResourcePermissions">REST API Reference for DescribeResourcePermissions Operation</seealso>
        IAsyncResult BeginDescribeResourcePermissions(DescribeResourcePermissionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeResourcePermissions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeResourcePermissions.</param>
        /// 
        /// <returns>Returns a  DescribeResourcePermissionsResult from WorkDocs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/DescribeResourcePermissions">REST API Reference for DescribeResourcePermissions Operation</seealso>
        DescribeResourcePermissionsResponse EndDescribeResourcePermissions(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeRootFolders


        /// <summary>
        /// Describes the current user's special folders; the <code>RootFolder</code> and the
        /// <code>RecycleBin</code>. <code>RootFolder</code> is the root of user's files and folders
        /// and <code>RecycleBin</code> is the root of recycled items. This is not a valid action
        /// for SigV4 (administrative API) clients.
        /// 
        ///  
        /// <para>
        /// This action requires an authentication token. To get an authentication token, register
        /// an application with Amazon WorkDocs. For more information, see <a href="https://docs.aws.amazon.com/workdocs/latest/developerguide/wd-auth-user.html">Authentication
        /// and Access Control for User Applications</a> in the <i>Amazon WorkDocs Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRootFolders service method.</param>
        /// 
        /// <returns>The response from the DescribeRootFolders service method, as returned by WorkDocs.</returns>
        /// <exception cref="Amazon.WorkDocs.Model.FailedDependencyException">
        /// The Directory Service cannot reach an on-premises instance. Or a dependency under
        /// the control of the organization is failing, such as a connected Active Directory.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.InvalidArgumentException">
        /// The pagination marker or limit fields are not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.ServiceUnavailableException">
        /// One or more of the dependencies is unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedOperationException">
        /// The operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedResourceAccessException">
        /// The caller does not have access to perform the action on the resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/DescribeRootFolders">REST API Reference for DescribeRootFolders Operation</seealso>
        DescribeRootFoldersResponse DescribeRootFolders(DescribeRootFoldersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeRootFolders operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeRootFolders operation on AmazonWorkDocsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeRootFolders
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/DescribeRootFolders">REST API Reference for DescribeRootFolders Operation</seealso>
        IAsyncResult BeginDescribeRootFolders(DescribeRootFoldersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeRootFolders operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeRootFolders.</param>
        /// 
        /// <returns>Returns a  DescribeRootFoldersResult from WorkDocs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/DescribeRootFolders">REST API Reference for DescribeRootFolders Operation</seealso>
        DescribeRootFoldersResponse EndDescribeRootFolders(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeUsers


        /// <summary>
        /// Describes the specified users. You can describe all users or filter the results (for
        /// example, by status or organization).
        /// 
        ///  
        /// <para>
        /// By default, Amazon WorkDocs returns the first 24 active or pending users. If there
        /// are more results, the response includes a marker that you can use to request the next
        /// set of results.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeUsers service method.</param>
        /// 
        /// <returns>The response from the DescribeUsers service method, as returned by WorkDocs.</returns>
        /// <exception cref="Amazon.WorkDocs.Model.EntityNotExistsException">
        /// The resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.FailedDependencyException">
        /// The Directory Service cannot reach an on-premises instance. Or a dependency under
        /// the control of the organization is failing, such as a connected Active Directory.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.InvalidArgumentException">
        /// The pagination marker or limit fields are not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.RequestedEntityTooLargeException">
        /// The response is too large to return. The request must include a filter to reduce the
        /// size of the response.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.ServiceUnavailableException">
        /// One or more of the dependencies is unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedOperationException">
        /// The operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedResourceAccessException">
        /// The caller does not have access to perform the action on the resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/DescribeUsers">REST API Reference for DescribeUsers Operation</seealso>
        DescribeUsersResponse DescribeUsers(DescribeUsersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeUsers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeUsers operation on AmazonWorkDocsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeUsers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/DescribeUsers">REST API Reference for DescribeUsers Operation</seealso>
        IAsyncResult BeginDescribeUsers(DescribeUsersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeUsers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeUsers.</param>
        /// 
        /// <returns>Returns a  DescribeUsersResult from WorkDocs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/DescribeUsers">REST API Reference for DescribeUsers Operation</seealso>
        DescribeUsersResponse EndDescribeUsers(IAsyncResult asyncResult);

        #endregion
        
        #region  GetCurrentUser


        /// <summary>
        /// Retrieves details of the current user for whom the authentication token was generated.
        /// This is not a valid action for SigV4 (administrative API) clients.
        /// 
        ///  
        /// <para>
        /// This action requires an authentication token. To get an authentication token, register
        /// an application with Amazon WorkDocs. For more information, see <a href="https://docs.aws.amazon.com/workdocs/latest/developerguide/wd-auth-user.html">Authentication
        /// and Access Control for User Applications</a> in the <i>Amazon WorkDocs Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCurrentUser service method.</param>
        /// 
        /// <returns>The response from the GetCurrentUser service method, as returned by WorkDocs.</returns>
        /// <exception cref="Amazon.WorkDocs.Model.EntityNotExistsException">
        /// The resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.FailedDependencyException">
        /// The Directory Service cannot reach an on-premises instance. Or a dependency under
        /// the control of the organization is failing, such as a connected Active Directory.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.ServiceUnavailableException">
        /// One or more of the dependencies is unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedOperationException">
        /// The operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedResourceAccessException">
        /// The caller does not have access to perform the action on the resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/GetCurrentUser">REST API Reference for GetCurrentUser Operation</seealso>
        GetCurrentUserResponse GetCurrentUser(GetCurrentUserRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetCurrentUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCurrentUser operation on AmazonWorkDocsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCurrentUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/GetCurrentUser">REST API Reference for GetCurrentUser Operation</seealso>
        IAsyncResult BeginGetCurrentUser(GetCurrentUserRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetCurrentUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCurrentUser.</param>
        /// 
        /// <returns>Returns a  GetCurrentUserResult from WorkDocs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/GetCurrentUser">REST API Reference for GetCurrentUser Operation</seealso>
        GetCurrentUserResponse EndGetCurrentUser(IAsyncResult asyncResult);

        #endregion
        
        #region  GetDocument


        /// <summary>
        /// Retrieves details of a document.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDocument service method.</param>
        /// 
        /// <returns>The response from the GetDocument service method, as returned by WorkDocs.</returns>
        /// <exception cref="Amazon.WorkDocs.Model.EntityNotExistsException">
        /// The resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.FailedDependencyException">
        /// The Directory Service cannot reach an on-premises instance. Or a dependency under
        /// the control of the organization is failing, such as a connected Active Directory.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.InvalidArgumentException">
        /// The pagination marker or limit fields are not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.InvalidPasswordException">
        /// The password is invalid.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.ServiceUnavailableException">
        /// One or more of the dependencies is unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedOperationException">
        /// The operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedResourceAccessException">
        /// The caller does not have access to perform the action on the resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/GetDocument">REST API Reference for GetDocument Operation</seealso>
        GetDocumentResponse GetDocument(GetDocumentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetDocument operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDocument operation on AmazonWorkDocsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDocument
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/GetDocument">REST API Reference for GetDocument Operation</seealso>
        IAsyncResult BeginGetDocument(GetDocumentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetDocument operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDocument.</param>
        /// 
        /// <returns>Returns a  GetDocumentResult from WorkDocs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/GetDocument">REST API Reference for GetDocument Operation</seealso>
        GetDocumentResponse EndGetDocument(IAsyncResult asyncResult);

        #endregion
        
        #region  GetDocumentPath


        /// <summary>
        /// Retrieves the path information (the hierarchy from the root folder) for the requested
        /// document.
        /// 
        ///  
        /// <para>
        /// By default, Amazon WorkDocs returns a maximum of 100 levels upwards from the requested
        /// document and only includes the IDs of the parent folders in the path. You can limit
        /// the maximum number of levels. You can also request the names of the parent folders.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDocumentPath service method.</param>
        /// 
        /// <returns>The response from the GetDocumentPath service method, as returned by WorkDocs.</returns>
        /// <exception cref="Amazon.WorkDocs.Model.EntityNotExistsException">
        /// The resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.FailedDependencyException">
        /// The Directory Service cannot reach an on-premises instance. Or a dependency under
        /// the control of the organization is failing, such as a connected Active Directory.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.ServiceUnavailableException">
        /// One or more of the dependencies is unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedOperationException">
        /// The operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedResourceAccessException">
        /// The caller does not have access to perform the action on the resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/GetDocumentPath">REST API Reference for GetDocumentPath Operation</seealso>
        GetDocumentPathResponse GetDocumentPath(GetDocumentPathRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetDocumentPath operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDocumentPath operation on AmazonWorkDocsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDocumentPath
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/GetDocumentPath">REST API Reference for GetDocumentPath Operation</seealso>
        IAsyncResult BeginGetDocumentPath(GetDocumentPathRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetDocumentPath operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDocumentPath.</param>
        /// 
        /// <returns>Returns a  GetDocumentPathResult from WorkDocs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/GetDocumentPath">REST API Reference for GetDocumentPath Operation</seealso>
        GetDocumentPathResponse EndGetDocumentPath(IAsyncResult asyncResult);

        #endregion
        
        #region  GetDocumentVersion


        /// <summary>
        /// Retrieves version metadata for the specified document.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDocumentVersion service method.</param>
        /// 
        /// <returns>The response from the GetDocumentVersion service method, as returned by WorkDocs.</returns>
        /// <exception cref="Amazon.WorkDocs.Model.EntityNotExistsException">
        /// The resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.FailedDependencyException">
        /// The Directory Service cannot reach an on-premises instance. Or a dependency under
        /// the control of the organization is failing, such as a connected Active Directory.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.InvalidPasswordException">
        /// The password is invalid.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.ProhibitedStateException">
        /// The specified document version is not in the INITIALIZED state.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.ServiceUnavailableException">
        /// One or more of the dependencies is unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedOperationException">
        /// The operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedResourceAccessException">
        /// The caller does not have access to perform the action on the resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/GetDocumentVersion">REST API Reference for GetDocumentVersion Operation</seealso>
        GetDocumentVersionResponse GetDocumentVersion(GetDocumentVersionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetDocumentVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDocumentVersion operation on AmazonWorkDocsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDocumentVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/GetDocumentVersion">REST API Reference for GetDocumentVersion Operation</seealso>
        IAsyncResult BeginGetDocumentVersion(GetDocumentVersionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetDocumentVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDocumentVersion.</param>
        /// 
        /// <returns>Returns a  GetDocumentVersionResult from WorkDocs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/GetDocumentVersion">REST API Reference for GetDocumentVersion Operation</seealso>
        GetDocumentVersionResponse EndGetDocumentVersion(IAsyncResult asyncResult);

        #endregion
        
        #region  GetFolder


        /// <summary>
        /// Retrieves the metadata of the specified folder.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFolder service method.</param>
        /// 
        /// <returns>The response from the GetFolder service method, as returned by WorkDocs.</returns>
        /// <exception cref="Amazon.WorkDocs.Model.EntityNotExistsException">
        /// The resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.FailedDependencyException">
        /// The Directory Service cannot reach an on-premises instance. Or a dependency under
        /// the control of the organization is failing, such as a connected Active Directory.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.InvalidArgumentException">
        /// The pagination marker or limit fields are not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.ProhibitedStateException">
        /// The specified document version is not in the INITIALIZED state.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.ServiceUnavailableException">
        /// One or more of the dependencies is unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedOperationException">
        /// The operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedResourceAccessException">
        /// The caller does not have access to perform the action on the resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/GetFolder">REST API Reference for GetFolder Operation</seealso>
        GetFolderResponse GetFolder(GetFolderRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetFolder operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetFolder operation on AmazonWorkDocsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetFolder
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/GetFolder">REST API Reference for GetFolder Operation</seealso>
        IAsyncResult BeginGetFolder(GetFolderRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetFolder operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetFolder.</param>
        /// 
        /// <returns>Returns a  GetFolderResult from WorkDocs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/GetFolder">REST API Reference for GetFolder Operation</seealso>
        GetFolderResponse EndGetFolder(IAsyncResult asyncResult);

        #endregion
        
        #region  GetFolderPath


        /// <summary>
        /// Retrieves the path information (the hierarchy from the root folder) for the specified
        /// folder.
        /// 
        ///  
        /// <para>
        /// By default, Amazon WorkDocs returns a maximum of 100 levels upwards from the requested
        /// folder and only includes the IDs of the parent folders in the path. You can limit
        /// the maximum number of levels. You can also request the parent folder names.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFolderPath service method.</param>
        /// 
        /// <returns>The response from the GetFolderPath service method, as returned by WorkDocs.</returns>
        /// <exception cref="Amazon.WorkDocs.Model.EntityNotExistsException">
        /// The resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.FailedDependencyException">
        /// The Directory Service cannot reach an on-premises instance. Or a dependency under
        /// the control of the organization is failing, such as a connected Active Directory.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.ServiceUnavailableException">
        /// One or more of the dependencies is unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedOperationException">
        /// The operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedResourceAccessException">
        /// The caller does not have access to perform the action on the resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/GetFolderPath">REST API Reference for GetFolderPath Operation</seealso>
        GetFolderPathResponse GetFolderPath(GetFolderPathRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetFolderPath operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetFolderPath operation on AmazonWorkDocsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetFolderPath
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/GetFolderPath">REST API Reference for GetFolderPath Operation</seealso>
        IAsyncResult BeginGetFolderPath(GetFolderPathRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetFolderPath operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetFolderPath.</param>
        /// 
        /// <returns>Returns a  GetFolderPathResult from WorkDocs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/GetFolderPath">REST API Reference for GetFolderPath Operation</seealso>
        GetFolderPathResponse EndGetFolderPath(IAsyncResult asyncResult);

        #endregion
        
        #region  GetResources


        /// <summary>
        /// Retrieves a collection of resources, including folders and documents. The only <code>CollectionType</code>
        /// supported is <code>SHARED_WITH_ME</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResources service method.</param>
        /// 
        /// <returns>The response from the GetResources service method, as returned by WorkDocs.</returns>
        /// <exception cref="Amazon.WorkDocs.Model.FailedDependencyException">
        /// The Directory Service cannot reach an on-premises instance. Or a dependency under
        /// the control of the organization is failing, such as a connected Active Directory.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.InvalidArgumentException">
        /// The pagination marker or limit fields are not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.ServiceUnavailableException">
        /// One or more of the dependencies is unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedOperationException">
        /// The operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedResourceAccessException">
        /// The caller does not have access to perform the action on the resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/GetResources">REST API Reference for GetResources Operation</seealso>
        GetResourcesResponse GetResources(GetResourcesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetResources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetResources operation on AmazonWorkDocsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetResources
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/GetResources">REST API Reference for GetResources Operation</seealso>
        IAsyncResult BeginGetResources(GetResourcesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetResources operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetResources.</param>
        /// 
        /// <returns>Returns a  GetResourcesResult from WorkDocs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/GetResources">REST API Reference for GetResources Operation</seealso>
        GetResourcesResponse EndGetResources(IAsyncResult asyncResult);

        #endregion
        
        #region  InitiateDocumentVersionUpload


        /// <summary>
        /// Creates a new document object and version object.
        /// 
        ///  
        /// <para>
        /// The client specifies the parent folder ID and name of the document to upload. The
        /// ID is optionally specified when creating a new version of an existing document. This
        /// is the first step to upload a document. Next, upload the document to the URL returned
        /// from the call, and then call <a>UpdateDocumentVersion</a>.
        /// </para>
        ///  
        /// <para>
        /// To cancel the document upload, call <a>AbortDocumentVersionUpload</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InitiateDocumentVersionUpload service method.</param>
        /// 
        /// <returns>The response from the InitiateDocumentVersionUpload service method, as returned by WorkDocs.</returns>
        /// <exception cref="Amazon.WorkDocs.Model.DraftUploadOutOfSyncException">
        /// This exception is thrown when a valid checkout ID is not presented on document version
        /// upload calls for a document that has been checked out from Web client.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.EntityAlreadyExistsException">
        /// The resource already exists.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.EntityNotExistsException">
        /// The resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.FailedDependencyException">
        /// The Directory Service cannot reach an on-premises instance. Or a dependency under
        /// the control of the organization is failing, such as a connected Active Directory.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.InvalidArgumentException">
        /// The pagination marker or limit fields are not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.InvalidPasswordException">
        /// The password is invalid.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.LimitExceededException">
        /// The maximum of 100,000 files and folders under the parent folder has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.ProhibitedStateException">
        /// The specified document version is not in the INITIALIZED state.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.ResourceAlreadyCheckedOutException">
        /// The resource is already checked out.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.ServiceUnavailableException">
        /// One or more of the dependencies is unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.StorageLimitExceededException">
        /// The storage limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.StorageLimitWillExceedException">
        /// The storage limit will be exceeded.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedOperationException">
        /// The operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedResourceAccessException">
        /// The caller does not have access to perform the action on the resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/InitiateDocumentVersionUpload">REST API Reference for InitiateDocumentVersionUpload Operation</seealso>
        InitiateDocumentVersionUploadResponse InitiateDocumentVersionUpload(InitiateDocumentVersionUploadRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the InitiateDocumentVersionUpload operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the InitiateDocumentVersionUpload operation on AmazonWorkDocsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndInitiateDocumentVersionUpload
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/InitiateDocumentVersionUpload">REST API Reference for InitiateDocumentVersionUpload Operation</seealso>
        IAsyncResult BeginInitiateDocumentVersionUpload(InitiateDocumentVersionUploadRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  InitiateDocumentVersionUpload operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginInitiateDocumentVersionUpload.</param>
        /// 
        /// <returns>Returns a  InitiateDocumentVersionUploadResult from WorkDocs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/InitiateDocumentVersionUpload">REST API Reference for InitiateDocumentVersionUpload Operation</seealso>
        InitiateDocumentVersionUploadResponse EndInitiateDocumentVersionUpload(IAsyncResult asyncResult);

        #endregion
        
        #region  RemoveAllResourcePermissions


        /// <summary>
        /// Removes all the permissions from the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveAllResourcePermissions service method.</param>
        /// 
        /// <returns>The response from the RemoveAllResourcePermissions service method, as returned by WorkDocs.</returns>
        /// <exception cref="Amazon.WorkDocs.Model.FailedDependencyException">
        /// The Directory Service cannot reach an on-premises instance. Or a dependency under
        /// the control of the organization is failing, such as a connected Active Directory.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.ServiceUnavailableException">
        /// One or more of the dependencies is unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedOperationException">
        /// The operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedResourceAccessException">
        /// The caller does not have access to perform the action on the resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/RemoveAllResourcePermissions">REST API Reference for RemoveAllResourcePermissions Operation</seealso>
        RemoveAllResourcePermissionsResponse RemoveAllResourcePermissions(RemoveAllResourcePermissionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RemoveAllResourcePermissions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveAllResourcePermissions operation on AmazonWorkDocsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRemoveAllResourcePermissions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/RemoveAllResourcePermissions">REST API Reference for RemoveAllResourcePermissions Operation</seealso>
        IAsyncResult BeginRemoveAllResourcePermissions(RemoveAllResourcePermissionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RemoveAllResourcePermissions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRemoveAllResourcePermissions.</param>
        /// 
        /// <returns>Returns a  RemoveAllResourcePermissionsResult from WorkDocs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/RemoveAllResourcePermissions">REST API Reference for RemoveAllResourcePermissions Operation</seealso>
        RemoveAllResourcePermissionsResponse EndRemoveAllResourcePermissions(IAsyncResult asyncResult);

        #endregion
        
        #region  RemoveResourcePermission


        /// <summary>
        /// Removes the permission for the specified principal from the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveResourcePermission service method.</param>
        /// 
        /// <returns>The response from the RemoveResourcePermission service method, as returned by WorkDocs.</returns>
        /// <exception cref="Amazon.WorkDocs.Model.FailedDependencyException">
        /// The Directory Service cannot reach an on-premises instance. Or a dependency under
        /// the control of the organization is failing, such as a connected Active Directory.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.ServiceUnavailableException">
        /// One or more of the dependencies is unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedOperationException">
        /// The operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedResourceAccessException">
        /// The caller does not have access to perform the action on the resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/RemoveResourcePermission">REST API Reference for RemoveResourcePermission Operation</seealso>
        RemoveResourcePermissionResponse RemoveResourcePermission(RemoveResourcePermissionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RemoveResourcePermission operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveResourcePermission operation on AmazonWorkDocsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRemoveResourcePermission
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/RemoveResourcePermission">REST API Reference for RemoveResourcePermission Operation</seealso>
        IAsyncResult BeginRemoveResourcePermission(RemoveResourcePermissionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RemoveResourcePermission operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRemoveResourcePermission.</param>
        /// 
        /// <returns>Returns a  RemoveResourcePermissionResult from WorkDocs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/RemoveResourcePermission">REST API Reference for RemoveResourcePermission Operation</seealso>
        RemoveResourcePermissionResponse EndRemoveResourcePermission(IAsyncResult asyncResult);

        #endregion
        
        #region  RestoreDocumentVersions


        /// <summary>
        /// Recovers a deleted version of an Amazon WorkDocs document.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RestoreDocumentVersions service method.</param>
        /// 
        /// <returns>The response from the RestoreDocumentVersions service method, as returned by WorkDocs.</returns>
        /// <exception cref="Amazon.WorkDocs.Model.ConcurrentModificationException">
        /// The resource hierarchy is changing.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.ConflictingOperationException">
        /// Another operation is in progress on the resource that conflicts with the current operation.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.EntityNotExistsException">
        /// The resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.FailedDependencyException">
        /// The Directory Service cannot reach an on-premises instance. Or a dependency under
        /// the control of the organization is failing, such as a connected Active Directory.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.InvalidOperationException">
        /// The operation is invalid.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.ProhibitedStateException">
        /// The specified document version is not in the INITIALIZED state.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedOperationException">
        /// The operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedResourceAccessException">
        /// The caller does not have access to perform the action on the resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/RestoreDocumentVersions">REST API Reference for RestoreDocumentVersions Operation</seealso>
        RestoreDocumentVersionsResponse RestoreDocumentVersions(RestoreDocumentVersionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RestoreDocumentVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RestoreDocumentVersions operation on AmazonWorkDocsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRestoreDocumentVersions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/RestoreDocumentVersions">REST API Reference for RestoreDocumentVersions Operation</seealso>
        IAsyncResult BeginRestoreDocumentVersions(RestoreDocumentVersionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RestoreDocumentVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRestoreDocumentVersions.</param>
        /// 
        /// <returns>Returns a  RestoreDocumentVersionsResult from WorkDocs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/RestoreDocumentVersions">REST API Reference for RestoreDocumentVersions Operation</seealso>
        RestoreDocumentVersionsResponse EndRestoreDocumentVersions(IAsyncResult asyncResult);

        #endregion
        
        #region  SearchResources


        /// <summary>
        /// Searches metadata and the content of folders, documents, document versions, and comments.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchResources service method.</param>
        /// 
        /// <returns>The response from the SearchResources service method, as returned by WorkDocs.</returns>
        /// <exception cref="Amazon.WorkDocs.Model.InvalidArgumentException">
        /// The pagination marker or limit fields are not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.ServiceUnavailableException">
        /// One or more of the dependencies is unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedOperationException">
        /// The operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedResourceAccessException">
        /// The caller does not have access to perform the action on the resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/SearchResources">REST API Reference for SearchResources Operation</seealso>
        SearchResourcesResponse SearchResources(SearchResourcesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the SearchResources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SearchResources operation on AmazonWorkDocsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSearchResources
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/SearchResources">REST API Reference for SearchResources Operation</seealso>
        IAsyncResult BeginSearchResources(SearchResourcesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SearchResources operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSearchResources.</param>
        /// 
        /// <returns>Returns a  SearchResourcesResult from WorkDocs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/SearchResources">REST API Reference for SearchResources Operation</seealso>
        SearchResourcesResponse EndSearchResources(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateDocument


        /// <summary>
        /// Updates the specified attributes of a document. The user must have access to both
        /// the document and its parent folder, if applicable.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDocument service method.</param>
        /// 
        /// <returns>The response from the UpdateDocument service method, as returned by WorkDocs.</returns>
        /// <exception cref="Amazon.WorkDocs.Model.ConcurrentModificationException">
        /// The resource hierarchy is changing.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.ConflictingOperationException">
        /// Another operation is in progress on the resource that conflicts with the current operation.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.EntityAlreadyExistsException">
        /// The resource already exists.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.EntityNotExistsException">
        /// The resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.FailedDependencyException">
        /// The Directory Service cannot reach an on-premises instance. Or a dependency under
        /// the control of the organization is failing, such as a connected Active Directory.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.LimitExceededException">
        /// The maximum of 100,000 files and folders under the parent folder has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.ProhibitedStateException">
        /// The specified document version is not in the INITIALIZED state.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.ServiceUnavailableException">
        /// One or more of the dependencies is unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedOperationException">
        /// The operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedResourceAccessException">
        /// The caller does not have access to perform the action on the resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/UpdateDocument">REST API Reference for UpdateDocument Operation</seealso>
        UpdateDocumentResponse UpdateDocument(UpdateDocumentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDocument operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDocument operation on AmazonWorkDocsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDocument
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/UpdateDocument">REST API Reference for UpdateDocument Operation</seealso>
        IAsyncResult BeginUpdateDocument(UpdateDocumentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDocument operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDocument.</param>
        /// 
        /// <returns>Returns a  UpdateDocumentResult from WorkDocs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/UpdateDocument">REST API Reference for UpdateDocument Operation</seealso>
        UpdateDocumentResponse EndUpdateDocument(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateDocumentVersion


        /// <summary>
        /// Changes the status of the document version to ACTIVE. 
        /// 
        ///  
        /// <para>
        /// Amazon WorkDocs also sets its document container to ACTIVE. This is the last step
        /// in a document upload, after the client uploads the document to an S3-presigned URL
        /// returned by <a>InitiateDocumentVersionUpload</a>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDocumentVersion service method.</param>
        /// 
        /// <returns>The response from the UpdateDocumentVersion service method, as returned by WorkDocs.</returns>
        /// <exception cref="Amazon.WorkDocs.Model.ConcurrentModificationException">
        /// The resource hierarchy is changing.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.EntityNotExistsException">
        /// The resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.FailedDependencyException">
        /// The Directory Service cannot reach an on-premises instance. Or a dependency under
        /// the control of the organization is failing, such as a connected Active Directory.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.InvalidOperationException">
        /// The operation is invalid.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.ProhibitedStateException">
        /// The specified document version is not in the INITIALIZED state.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.ServiceUnavailableException">
        /// One or more of the dependencies is unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedOperationException">
        /// The operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedResourceAccessException">
        /// The caller does not have access to perform the action on the resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/UpdateDocumentVersion">REST API Reference for UpdateDocumentVersion Operation</seealso>
        UpdateDocumentVersionResponse UpdateDocumentVersion(UpdateDocumentVersionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDocumentVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDocumentVersion operation on AmazonWorkDocsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDocumentVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/UpdateDocumentVersion">REST API Reference for UpdateDocumentVersion Operation</seealso>
        IAsyncResult BeginUpdateDocumentVersion(UpdateDocumentVersionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDocumentVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDocumentVersion.</param>
        /// 
        /// <returns>Returns a  UpdateDocumentVersionResult from WorkDocs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/UpdateDocumentVersion">REST API Reference for UpdateDocumentVersion Operation</seealso>
        UpdateDocumentVersionResponse EndUpdateDocumentVersion(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateFolder


        /// <summary>
        /// Updates the specified attributes of the specified folder. The user must have access
        /// to both the folder and its parent folder, if applicable.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFolder service method.</param>
        /// 
        /// <returns>The response from the UpdateFolder service method, as returned by WorkDocs.</returns>
        /// <exception cref="Amazon.WorkDocs.Model.ConcurrentModificationException">
        /// The resource hierarchy is changing.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.ConflictingOperationException">
        /// Another operation is in progress on the resource that conflicts with the current operation.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.EntityAlreadyExistsException">
        /// The resource already exists.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.EntityNotExistsException">
        /// The resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.FailedDependencyException">
        /// The Directory Service cannot reach an on-premises instance. Or a dependency under
        /// the control of the organization is failing, such as a connected Active Directory.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.LimitExceededException">
        /// The maximum of 100,000 files and folders under the parent folder has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.ProhibitedStateException">
        /// The specified document version is not in the INITIALIZED state.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.ServiceUnavailableException">
        /// One or more of the dependencies is unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedOperationException">
        /// The operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedResourceAccessException">
        /// The caller does not have access to perform the action on the resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/UpdateFolder">REST API Reference for UpdateFolder Operation</seealso>
        UpdateFolderResponse UpdateFolder(UpdateFolderRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateFolder operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateFolder operation on AmazonWorkDocsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateFolder
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/UpdateFolder">REST API Reference for UpdateFolder Operation</seealso>
        IAsyncResult BeginUpdateFolder(UpdateFolderRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateFolder operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateFolder.</param>
        /// 
        /// <returns>Returns a  UpdateFolderResult from WorkDocs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/UpdateFolder">REST API Reference for UpdateFolder Operation</seealso>
        UpdateFolderResponse EndUpdateFolder(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateUser


        /// <summary>
        /// Updates the specified attributes of the specified user, and grants or revokes administrative
        /// privileges to the Amazon WorkDocs site.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateUser service method.</param>
        /// 
        /// <returns>The response from the UpdateUser service method, as returned by WorkDocs.</returns>
        /// <exception cref="Amazon.WorkDocs.Model.DeactivatingLastSystemUserException">
        /// The last user in the organization is being deactivated.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.EntityNotExistsException">
        /// The resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.FailedDependencyException">
        /// The Directory Service cannot reach an on-premises instance. Or a dependency under
        /// the control of the organization is failing, such as a connected Active Directory.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.IllegalUserStateException">
        /// The user is undergoing transfer of ownership.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.InvalidArgumentException">
        /// The pagination marker or limit fields are not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.ProhibitedStateException">
        /// The specified document version is not in the INITIALIZED state.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.ServiceUnavailableException">
        /// One or more of the dependencies is unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedOperationException">
        /// The operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedResourceAccessException">
        /// The caller does not have access to perform the action on the resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/UpdateUser">REST API Reference for UpdateUser Operation</seealso>
        UpdateUserResponse UpdateUser(UpdateUserRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateUser operation on AmazonWorkDocsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/UpdateUser">REST API Reference for UpdateUser Operation</seealso>
        IAsyncResult BeginUpdateUser(UpdateUserRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateUser.</param>
        /// 
        /// <returns>Returns a  UpdateUserResult from WorkDocs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/UpdateUser">REST API Reference for UpdateUser Operation</seealso>
        UpdateUserResponse EndUpdateUser(IAsyncResult asyncResult);

        #endregion
        
    }
}