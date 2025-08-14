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
 * Do not modify this file. This file is generated from the qapps-2023-11-27.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.QApps.Model;

#pragma warning disable CS1570
namespace Amazon.QApps
{
    /// <summary>
    /// <para>Interface for accessing QApps</para>
    ///
    /// The Amazon Q Apps feature capability within Amazon Q Business allows web experience
    /// users to create lightweight, purpose-built AI apps to fulfill specific tasks from
    /// within their web experience. For example, users can create a Q App that exclusively
    /// generates marketing-related content to improve your marketing team's productivity
    /// or a Q App for writing customer emails and creating promotional content using a certain
    /// style of voice, tone, and branding. For more information on the capabilities, see
    /// <a href="https://docs.aws.amazon.com/amazonq/latest/qbusiness-ug/deploy-experience-iam-role.html#q-apps-actions">Amazon
    /// Q Apps capabilities</a> in the <i>Amazon Q Business User Guide</i>. 
    /// 
    ///  
    /// <para>
    /// For an overview of the Amazon Q App APIs, see <a href="https://docs.aws.amazon.com/amazonq/latest/api-reference/API_Operations_QApps.html">Overview
    /// of Amazon Q Apps API operations</a>.
    /// </para>
    ///  
    /// <para>
    /// For information about the IAM access control permissions you need to use the Amazon
    /// Q Apps API, see <a href="https://docs.aws.amazon.com/amazonq/latest/qbusiness-ug/deploy-experience-iam-role.html">
    /// IAM role for the Amazon Q Business web experience including Amazon Q Apps</a> in the
    /// <i>Amazon Q Business User Guide</i>.
    /// </para>
    /// </summary>
    public partial interface IAmazonQApps : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IQAppsPaginatorFactory Paginators { get; }
#endif


        
        #region  AssociateLibraryItemReview


        /// <summary>
        /// Associates a rating or review for a library item with the user submitting the request.
        /// This increments the rating count for the specified library item.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateLibraryItemReview service method.</param>
        /// 
        /// <returns>The response from the AssociateLibraryItemReview service method, as returned by QApps.</returns>
        /// <exception cref="Amazon.QApps.Model.AccessDeniedException">
        /// The client is not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ConflictException">
        /// The requested operation could not be completed due to a conflict with the current
        /// state of the resource.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.InternalServerException">
        /// An internal service error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ServiceQuotaExceededException">
        /// The requested operation could not be completed because it would exceed the service's
        /// quota or limit.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ThrottlingException">
        /// The requested operation could not be completed because too many requests were sent
        /// at once. Wait a bit and try again later.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.UnauthorizedException">
        /// The client is not authenticated or authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/AssociateLibraryItemReview">REST API Reference for AssociateLibraryItemReview Operation</seealso>
        AssociateLibraryItemReviewResponse AssociateLibraryItemReview(AssociateLibraryItemReviewRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateLibraryItemReview operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateLibraryItemReview operation on AmazonQAppsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateLibraryItemReview
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/AssociateLibraryItemReview">REST API Reference for AssociateLibraryItemReview Operation</seealso>
        IAsyncResult BeginAssociateLibraryItemReview(AssociateLibraryItemReviewRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateLibraryItemReview operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateLibraryItemReview.</param>
        /// 
        /// <returns>Returns a  AssociateLibraryItemReviewResult from QApps.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/AssociateLibraryItemReview">REST API Reference for AssociateLibraryItemReview Operation</seealso>
        AssociateLibraryItemReviewResponse EndAssociateLibraryItemReview(IAsyncResult asyncResult);

        #endregion
        
        #region  AssociateQAppWithUser


        /// <summary>
        /// This operation creates a link between the user's identity calling the operation and
        /// a specific Q App. This is useful to mark the Q App as a <i>favorite</i> for the user
        /// if the user doesn't own the Amazon Q App so they can still run it and see it in their
        /// inventory of Q Apps.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateQAppWithUser service method.</param>
        /// 
        /// <returns>The response from the AssociateQAppWithUser service method, as returned by QApps.</returns>
        /// <exception cref="Amazon.QApps.Model.AccessDeniedException">
        /// The client is not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.InternalServerException">
        /// An internal service error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ServiceQuotaExceededException">
        /// The requested operation could not be completed because it would exceed the service's
        /// quota or limit.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ThrottlingException">
        /// The requested operation could not be completed because too many requests were sent
        /// at once. Wait a bit and try again later.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.UnauthorizedException">
        /// The client is not authenticated or authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/AssociateQAppWithUser">REST API Reference for AssociateQAppWithUser Operation</seealso>
        AssociateQAppWithUserResponse AssociateQAppWithUser(AssociateQAppWithUserRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateQAppWithUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateQAppWithUser operation on AmazonQAppsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateQAppWithUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/AssociateQAppWithUser">REST API Reference for AssociateQAppWithUser Operation</seealso>
        IAsyncResult BeginAssociateQAppWithUser(AssociateQAppWithUserRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateQAppWithUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateQAppWithUser.</param>
        /// 
        /// <returns>Returns a  AssociateQAppWithUserResult from QApps.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/AssociateQAppWithUser">REST API Reference for AssociateQAppWithUser Operation</seealso>
        AssociateQAppWithUserResponse EndAssociateQAppWithUser(IAsyncResult asyncResult);

        #endregion
        
        #region  BatchCreateCategory


        /// <summary>
        /// Creates Categories for the Amazon Q Business application environment instance. Web
        /// experience users use Categories to tag and filter library items. For more information,
        /// see <a href="https://docs.aws.amazon.com/amazonq/latest/qbusiness-ug/qapps-custom-labels.html">Custom
        /// labels for Amazon Q Apps</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchCreateCategory service method.</param>
        /// 
        /// <returns>The response from the BatchCreateCategory service method, as returned by QApps.</returns>
        /// <exception cref="Amazon.QApps.Model.AccessDeniedException">
        /// The client is not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ConflictException">
        /// The requested operation could not be completed due to a conflict with the current
        /// state of the resource.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.InternalServerException">
        /// An internal service error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ThrottlingException">
        /// The requested operation could not be completed because too many requests were sent
        /// at once. Wait a bit and try again later.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.UnauthorizedException">
        /// The client is not authenticated or authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/BatchCreateCategory">REST API Reference for BatchCreateCategory Operation</seealso>
        BatchCreateCategoryResponse BatchCreateCategory(BatchCreateCategoryRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the BatchCreateCategory operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchCreateCategory operation on AmazonQAppsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchCreateCategory
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/BatchCreateCategory">REST API Reference for BatchCreateCategory Operation</seealso>
        IAsyncResult BeginBatchCreateCategory(BatchCreateCategoryRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BatchCreateCategory operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchCreateCategory.</param>
        /// 
        /// <returns>Returns a  BatchCreateCategoryResult from QApps.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/BatchCreateCategory">REST API Reference for BatchCreateCategory Operation</seealso>
        BatchCreateCategoryResponse EndBatchCreateCategory(IAsyncResult asyncResult);

        #endregion
        
        #region  BatchDeleteCategory


        /// <summary>
        /// Deletes Categories for the Amazon Q Business application environment instance. Web
        /// experience users use Categories to tag and filter library items. For more information,
        /// see <a href="https://docs.aws.amazon.com/amazonq/latest/qbusiness-ug/qapps-custom-labels.html">Custom
        /// labels for Amazon Q Apps</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteCategory service method.</param>
        /// 
        /// <returns>The response from the BatchDeleteCategory service method, as returned by QApps.</returns>
        /// <exception cref="Amazon.QApps.Model.AccessDeniedException">
        /// The client is not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ConflictException">
        /// The requested operation could not be completed due to a conflict with the current
        /// state of the resource.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.InternalServerException">
        /// An internal service error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ThrottlingException">
        /// The requested operation could not be completed because too many requests were sent
        /// at once. Wait a bit and try again later.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.UnauthorizedException">
        /// The client is not authenticated or authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/BatchDeleteCategory">REST API Reference for BatchDeleteCategory Operation</seealso>
        BatchDeleteCategoryResponse BatchDeleteCategory(BatchDeleteCategoryRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the BatchDeleteCategory operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteCategory operation on AmazonQAppsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchDeleteCategory
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/BatchDeleteCategory">REST API Reference for BatchDeleteCategory Operation</seealso>
        IAsyncResult BeginBatchDeleteCategory(BatchDeleteCategoryRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BatchDeleteCategory operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchDeleteCategory.</param>
        /// 
        /// <returns>Returns a  BatchDeleteCategoryResult from QApps.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/BatchDeleteCategory">REST API Reference for BatchDeleteCategory Operation</seealso>
        BatchDeleteCategoryResponse EndBatchDeleteCategory(IAsyncResult asyncResult);

        #endregion
        
        #region  BatchUpdateCategory


        /// <summary>
        /// Updates Categories for the Amazon Q Business application environment instance. Web
        /// experience users use Categories to tag and filter library items. For more information,
        /// see <a href="https://docs.aws.amazon.com/amazonq/latest/qbusiness-ug/qapps-custom-labels.html">Custom
        /// labels for Amazon Q Apps</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchUpdateCategory service method.</param>
        /// 
        /// <returns>The response from the BatchUpdateCategory service method, as returned by QApps.</returns>
        /// <exception cref="Amazon.QApps.Model.AccessDeniedException">
        /// The client is not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ConflictException">
        /// The requested operation could not be completed due to a conflict with the current
        /// state of the resource.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.InternalServerException">
        /// An internal service error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ThrottlingException">
        /// The requested operation could not be completed because too many requests were sent
        /// at once. Wait a bit and try again later.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.UnauthorizedException">
        /// The client is not authenticated or authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/BatchUpdateCategory">REST API Reference for BatchUpdateCategory Operation</seealso>
        BatchUpdateCategoryResponse BatchUpdateCategory(BatchUpdateCategoryRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the BatchUpdateCategory operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchUpdateCategory operation on AmazonQAppsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchUpdateCategory
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/BatchUpdateCategory">REST API Reference for BatchUpdateCategory Operation</seealso>
        IAsyncResult BeginBatchUpdateCategory(BatchUpdateCategoryRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BatchUpdateCategory operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchUpdateCategory.</param>
        /// 
        /// <returns>Returns a  BatchUpdateCategoryResult from QApps.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/BatchUpdateCategory">REST API Reference for BatchUpdateCategory Operation</seealso>
        BatchUpdateCategoryResponse EndBatchUpdateCategory(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateLibraryItem


        /// <summary>
        /// Creates a new library item for an Amazon Q App, allowing it to be discovered and used
        /// by other allowed users.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLibraryItem service method.</param>
        /// 
        /// <returns>The response from the CreateLibraryItem service method, as returned by QApps.</returns>
        /// <exception cref="Amazon.QApps.Model.AccessDeniedException">
        /// The client is not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.InternalServerException">
        /// An internal service error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ServiceQuotaExceededException">
        /// The requested operation could not be completed because it would exceed the service's
        /// quota or limit.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ThrottlingException">
        /// The requested operation could not be completed because too many requests were sent
        /// at once. Wait a bit and try again later.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.UnauthorizedException">
        /// The client is not authenticated or authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/CreateLibraryItem">REST API Reference for CreateLibraryItem Operation</seealso>
        CreateLibraryItemResponse CreateLibraryItem(CreateLibraryItemRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateLibraryItem operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLibraryItem operation on AmazonQAppsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateLibraryItem
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/CreateLibraryItem">REST API Reference for CreateLibraryItem Operation</seealso>
        IAsyncResult BeginCreateLibraryItem(CreateLibraryItemRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateLibraryItem operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateLibraryItem.</param>
        /// 
        /// <returns>Returns a  CreateLibraryItemResult from QApps.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/CreateLibraryItem">REST API Reference for CreateLibraryItem Operation</seealso>
        CreateLibraryItemResponse EndCreateLibraryItem(IAsyncResult asyncResult);

        #endregion
        
        #region  CreatePresignedUrl


        /// <summary>
        /// Creates a presigned URL for an S3 POST operation to upload a file. You can use this
        /// URL to set a default file for a <c>FileUploadCard</c> in a Q App definition or to
        /// provide a file for a single Q App run. The <c>scope</c> parameter determines how the
        /// file will be used, either at the app definition level or the app session level.
        /// 
        ///  <note> 
        /// <para>
        /// The IAM permissions are derived from the <c>qapps:ImportDocument</c> action. For more
        /// information on the IAM policy for Amazon Q Apps, see <a href="https://docs.aws.amazon.com/amazonq/latest/qbusiness-ug/deploy-q-apps-iam-permissions.html">IAM
        /// permissions for using Amazon Q Apps</a>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePresignedUrl service method.</param>
        /// 
        /// <returns>The response from the CreatePresignedUrl service method, as returned by QApps.</returns>
        /// <exception cref="Amazon.QApps.Model.AccessDeniedException">
        /// The client is not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.InternalServerException">
        /// An internal service error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ThrottlingException">
        /// The requested operation could not be completed because too many requests were sent
        /// at once. Wait a bit and try again later.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.UnauthorizedException">
        /// The client is not authenticated or authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/CreatePresignedUrl">REST API Reference for CreatePresignedUrl Operation</seealso>
        CreatePresignedUrlResponse CreatePresignedUrl(CreatePresignedUrlRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePresignedUrl operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePresignedUrl operation on AmazonQAppsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreatePresignedUrl
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/CreatePresignedUrl">REST API Reference for CreatePresignedUrl Operation</seealso>
        IAsyncResult BeginCreatePresignedUrl(CreatePresignedUrlRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreatePresignedUrl operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreatePresignedUrl.</param>
        /// 
        /// <returns>Returns a  CreatePresignedUrlResult from QApps.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/CreatePresignedUrl">REST API Reference for CreatePresignedUrl Operation</seealso>
        CreatePresignedUrlResponse EndCreatePresignedUrl(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateQApp


        /// <summary>
        /// Creates a new Amazon Q App based on the provided definition. The Q App definition
        /// specifies the cards and flow of the Q App. This operation also calculates the dependencies
        /// between the cards by inspecting the references in the prompts.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateQApp service method.</param>
        /// 
        /// <returns>The response from the CreateQApp service method, as returned by QApps.</returns>
        /// <exception cref="Amazon.QApps.Model.AccessDeniedException">
        /// The client is not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ConflictException">
        /// The requested operation could not be completed due to a conflict with the current
        /// state of the resource.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ContentTooLargeException">
        /// The requested operation could not be completed because the content exceeds the maximum
        /// allowed size.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.InternalServerException">
        /// An internal service error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ServiceQuotaExceededException">
        /// The requested operation could not be completed because it would exceed the service's
        /// quota or limit.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ThrottlingException">
        /// The requested operation could not be completed because too many requests were sent
        /// at once. Wait a bit and try again later.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.UnauthorizedException">
        /// The client is not authenticated or authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/CreateQApp">REST API Reference for CreateQApp Operation</seealso>
        CreateQAppResponse CreateQApp(CreateQAppRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateQApp operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateQApp operation on AmazonQAppsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateQApp
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/CreateQApp">REST API Reference for CreateQApp Operation</seealso>
        IAsyncResult BeginCreateQApp(CreateQAppRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateQApp operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateQApp.</param>
        /// 
        /// <returns>Returns a  CreateQAppResult from QApps.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/CreateQApp">REST API Reference for CreateQApp Operation</seealso>
        CreateQAppResponse EndCreateQApp(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteLibraryItem


        /// <summary>
        /// Deletes a library item for an Amazon Q App, removing it from the library so it can
        /// no longer be discovered or used by other users.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLibraryItem service method.</param>
        /// 
        /// <returns>The response from the DeleteLibraryItem service method, as returned by QApps.</returns>
        /// <exception cref="Amazon.QApps.Model.AccessDeniedException">
        /// The client is not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.InternalServerException">
        /// An internal service error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ServiceQuotaExceededException">
        /// The requested operation could not be completed because it would exceed the service's
        /// quota or limit.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ThrottlingException">
        /// The requested operation could not be completed because too many requests were sent
        /// at once. Wait a bit and try again later.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.UnauthorizedException">
        /// The client is not authenticated or authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/DeleteLibraryItem">REST API Reference for DeleteLibraryItem Operation</seealso>
        DeleteLibraryItemResponse DeleteLibraryItem(DeleteLibraryItemRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLibraryItem operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLibraryItem operation on AmazonQAppsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteLibraryItem
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/DeleteLibraryItem">REST API Reference for DeleteLibraryItem Operation</seealso>
        IAsyncResult BeginDeleteLibraryItem(DeleteLibraryItemRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteLibraryItem operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteLibraryItem.</param>
        /// 
        /// <returns>Returns a  DeleteLibraryItemResult from QApps.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/DeleteLibraryItem">REST API Reference for DeleteLibraryItem Operation</seealso>
        DeleteLibraryItemResponse EndDeleteLibraryItem(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteQApp


        /// <summary>
        /// Deletes an Amazon Q App owned by the user. If the Q App was previously published to
        /// the library, it is also removed from the library.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteQApp service method.</param>
        /// 
        /// <returns>The response from the DeleteQApp service method, as returned by QApps.</returns>
        /// <exception cref="Amazon.QApps.Model.AccessDeniedException">
        /// The client is not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.InternalServerException">
        /// An internal service error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ThrottlingException">
        /// The requested operation could not be completed because too many requests were sent
        /// at once. Wait a bit and try again later.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.UnauthorizedException">
        /// The client is not authenticated or authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/DeleteQApp">REST API Reference for DeleteQApp Operation</seealso>
        DeleteQAppResponse DeleteQApp(DeleteQAppRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteQApp operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteQApp operation on AmazonQAppsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteQApp
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/DeleteQApp">REST API Reference for DeleteQApp Operation</seealso>
        IAsyncResult BeginDeleteQApp(DeleteQAppRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteQApp operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteQApp.</param>
        /// 
        /// <returns>Returns a  DeleteQAppResult from QApps.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/DeleteQApp">REST API Reference for DeleteQApp Operation</seealso>
        DeleteQAppResponse EndDeleteQApp(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeQAppPermissions


        /// <summary>
        /// Describes read permissions for a Amazon Q App in Amazon Q Business application environment
        /// instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeQAppPermissions service method.</param>
        /// 
        /// <returns>The response from the DescribeQAppPermissions service method, as returned by QApps.</returns>
        /// <exception cref="Amazon.QApps.Model.AccessDeniedException">
        /// The client is not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.InternalServerException">
        /// An internal service error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ThrottlingException">
        /// The requested operation could not be completed because too many requests were sent
        /// at once. Wait a bit and try again later.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.UnauthorizedException">
        /// The client is not authenticated or authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/DescribeQAppPermissions">REST API Reference for DescribeQAppPermissions Operation</seealso>
        DescribeQAppPermissionsResponse DescribeQAppPermissions(DescribeQAppPermissionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeQAppPermissions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeQAppPermissions operation on AmazonQAppsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeQAppPermissions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/DescribeQAppPermissions">REST API Reference for DescribeQAppPermissions Operation</seealso>
        IAsyncResult BeginDescribeQAppPermissions(DescribeQAppPermissionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeQAppPermissions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeQAppPermissions.</param>
        /// 
        /// <returns>Returns a  DescribeQAppPermissionsResult from QApps.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/DescribeQAppPermissions">REST API Reference for DescribeQAppPermissions Operation</seealso>
        DescribeQAppPermissionsResponse EndDescribeQAppPermissions(IAsyncResult asyncResult);

        #endregion
        
        #region  DisassociateLibraryItemReview


        /// <summary>
        /// Removes a rating or review previously submitted by the user for a library item.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateLibraryItemReview service method.</param>
        /// 
        /// <returns>The response from the DisassociateLibraryItemReview service method, as returned by QApps.</returns>
        /// <exception cref="Amazon.QApps.Model.AccessDeniedException">
        /// The client is not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ConflictException">
        /// The requested operation could not be completed due to a conflict with the current
        /// state of the resource.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.InternalServerException">
        /// An internal service error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ServiceQuotaExceededException">
        /// The requested operation could not be completed because it would exceed the service's
        /// quota or limit.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ThrottlingException">
        /// The requested operation could not be completed because too many requests were sent
        /// at once. Wait a bit and try again later.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.UnauthorizedException">
        /// The client is not authenticated or authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/DisassociateLibraryItemReview">REST API Reference for DisassociateLibraryItemReview Operation</seealso>
        DisassociateLibraryItemReviewResponse DisassociateLibraryItemReview(DisassociateLibraryItemReviewRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateLibraryItemReview operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateLibraryItemReview operation on AmazonQAppsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateLibraryItemReview
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/DisassociateLibraryItemReview">REST API Reference for DisassociateLibraryItemReview Operation</seealso>
        IAsyncResult BeginDisassociateLibraryItemReview(DisassociateLibraryItemReviewRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateLibraryItemReview operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateLibraryItemReview.</param>
        /// 
        /// <returns>Returns a  DisassociateLibraryItemReviewResult from QApps.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/DisassociateLibraryItemReview">REST API Reference for DisassociateLibraryItemReview Operation</seealso>
        DisassociateLibraryItemReviewResponse EndDisassociateLibraryItemReview(IAsyncResult asyncResult);

        #endregion
        
        #region  DisassociateQAppFromUser


        /// <summary>
        /// Disassociates a Q App from a user removing the user's access to run the Q App.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateQAppFromUser service method.</param>
        /// 
        /// <returns>The response from the DisassociateQAppFromUser service method, as returned by QApps.</returns>
        /// <exception cref="Amazon.QApps.Model.AccessDeniedException">
        /// The client is not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.InternalServerException">
        /// An internal service error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ThrottlingException">
        /// The requested operation could not be completed because too many requests were sent
        /// at once. Wait a bit and try again later.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.UnauthorizedException">
        /// The client is not authenticated or authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/DisassociateQAppFromUser">REST API Reference for DisassociateQAppFromUser Operation</seealso>
        DisassociateQAppFromUserResponse DisassociateQAppFromUser(DisassociateQAppFromUserRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateQAppFromUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateQAppFromUser operation on AmazonQAppsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateQAppFromUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/DisassociateQAppFromUser">REST API Reference for DisassociateQAppFromUser Operation</seealso>
        IAsyncResult BeginDisassociateQAppFromUser(DisassociateQAppFromUserRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateQAppFromUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateQAppFromUser.</param>
        /// 
        /// <returns>Returns a  DisassociateQAppFromUserResult from QApps.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/DisassociateQAppFromUser">REST API Reference for DisassociateQAppFromUser Operation</seealso>
        DisassociateQAppFromUserResponse EndDisassociateQAppFromUser(IAsyncResult asyncResult);

        #endregion
        
        #region  ExportQAppSessionData


        /// <summary>
        /// Exports the collected data of a Q App data collection session.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExportQAppSessionData service method.</param>
        /// 
        /// <returns>The response from the ExportQAppSessionData service method, as returned by QApps.</returns>
        /// <exception cref="Amazon.QApps.Model.AccessDeniedException">
        /// The client is not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ConflictException">
        /// The requested operation could not be completed due to a conflict with the current
        /// state of the resource.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.InternalServerException">
        /// An internal service error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ServiceQuotaExceededException">
        /// The requested operation could not be completed because it would exceed the service's
        /// quota or limit.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ThrottlingException">
        /// The requested operation could not be completed because too many requests were sent
        /// at once. Wait a bit and try again later.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.UnauthorizedException">
        /// The client is not authenticated or authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/ExportQAppSessionData">REST API Reference for ExportQAppSessionData Operation</seealso>
        ExportQAppSessionDataResponse ExportQAppSessionData(ExportQAppSessionDataRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ExportQAppSessionData operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ExportQAppSessionData operation on AmazonQAppsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndExportQAppSessionData
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/ExportQAppSessionData">REST API Reference for ExportQAppSessionData Operation</seealso>
        IAsyncResult BeginExportQAppSessionData(ExportQAppSessionDataRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ExportQAppSessionData operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginExportQAppSessionData.</param>
        /// 
        /// <returns>Returns a  ExportQAppSessionDataResult from QApps.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/ExportQAppSessionData">REST API Reference for ExportQAppSessionData Operation</seealso>
        ExportQAppSessionDataResponse EndExportQAppSessionData(IAsyncResult asyncResult);

        #endregion
        
        #region  GetLibraryItem


        /// <summary>
        /// Retrieves details about a library item for an Amazon Q App, including its metadata,
        /// categories, ratings, and usage statistics.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLibraryItem service method.</param>
        /// 
        /// <returns>The response from the GetLibraryItem service method, as returned by QApps.</returns>
        /// <exception cref="Amazon.QApps.Model.AccessDeniedException">
        /// The client is not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.InternalServerException">
        /// An internal service error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ThrottlingException">
        /// The requested operation could not be completed because too many requests were sent
        /// at once. Wait a bit and try again later.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.UnauthorizedException">
        /// The client is not authenticated or authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/GetLibraryItem">REST API Reference for GetLibraryItem Operation</seealso>
        GetLibraryItemResponse GetLibraryItem(GetLibraryItemRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetLibraryItem operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetLibraryItem operation on AmazonQAppsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetLibraryItem
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/GetLibraryItem">REST API Reference for GetLibraryItem Operation</seealso>
        IAsyncResult BeginGetLibraryItem(GetLibraryItemRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetLibraryItem operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetLibraryItem.</param>
        /// 
        /// <returns>Returns a  GetLibraryItemResult from QApps.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/GetLibraryItem">REST API Reference for GetLibraryItem Operation</seealso>
        GetLibraryItemResponse EndGetLibraryItem(IAsyncResult asyncResult);

        #endregion
        
        #region  GetQApp


        /// <summary>
        /// Retrieves the full details of an Q App, including its definition specifying the cards
        /// and flow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetQApp service method.</param>
        /// 
        /// <returns>The response from the GetQApp service method, as returned by QApps.</returns>
        /// <exception cref="Amazon.QApps.Model.AccessDeniedException">
        /// The client is not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.InternalServerException">
        /// An internal service error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ThrottlingException">
        /// The requested operation could not be completed because too many requests were sent
        /// at once. Wait a bit and try again later.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.UnauthorizedException">
        /// The client is not authenticated or authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/GetQApp">REST API Reference for GetQApp Operation</seealso>
        GetQAppResponse GetQApp(GetQAppRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetQApp operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetQApp operation on AmazonQAppsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetQApp
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/GetQApp">REST API Reference for GetQApp Operation</seealso>
        IAsyncResult BeginGetQApp(GetQAppRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetQApp operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetQApp.</param>
        /// 
        /// <returns>Returns a  GetQAppResult from QApps.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/GetQApp">REST API Reference for GetQApp Operation</seealso>
        GetQAppResponse EndGetQApp(IAsyncResult asyncResult);

        #endregion
        
        #region  GetQAppSession


        /// <summary>
        /// Retrieves the current state and results for an active session of an Amazon Q App.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetQAppSession service method.</param>
        /// 
        /// <returns>The response from the GetQAppSession service method, as returned by QApps.</returns>
        /// <exception cref="Amazon.QApps.Model.AccessDeniedException">
        /// The client is not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.InternalServerException">
        /// An internal service error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ServiceQuotaExceededException">
        /// The requested operation could not be completed because it would exceed the service's
        /// quota or limit.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ThrottlingException">
        /// The requested operation could not be completed because too many requests were sent
        /// at once. Wait a bit and try again later.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.UnauthorizedException">
        /// The client is not authenticated or authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/GetQAppSession">REST API Reference for GetQAppSession Operation</seealso>
        GetQAppSessionResponse GetQAppSession(GetQAppSessionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetQAppSession operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetQAppSession operation on AmazonQAppsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetQAppSession
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/GetQAppSession">REST API Reference for GetQAppSession Operation</seealso>
        IAsyncResult BeginGetQAppSession(GetQAppSessionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetQAppSession operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetQAppSession.</param>
        /// 
        /// <returns>Returns a  GetQAppSessionResult from QApps.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/GetQAppSession">REST API Reference for GetQAppSession Operation</seealso>
        GetQAppSessionResponse EndGetQAppSession(IAsyncResult asyncResult);

        #endregion
        
        #region  GetQAppSessionMetadata


        /// <summary>
        /// Retrieves the current configuration of a Q App session.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetQAppSessionMetadata service method.</param>
        /// 
        /// <returns>The response from the GetQAppSessionMetadata service method, as returned by QApps.</returns>
        /// <exception cref="Amazon.QApps.Model.AccessDeniedException">
        /// The client is not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.InternalServerException">
        /// An internal service error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ServiceQuotaExceededException">
        /// The requested operation could not be completed because it would exceed the service's
        /// quota or limit.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ThrottlingException">
        /// The requested operation could not be completed because too many requests were sent
        /// at once. Wait a bit and try again later.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.UnauthorizedException">
        /// The client is not authenticated or authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/GetQAppSessionMetadata">REST API Reference for GetQAppSessionMetadata Operation</seealso>
        GetQAppSessionMetadataResponse GetQAppSessionMetadata(GetQAppSessionMetadataRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetQAppSessionMetadata operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetQAppSessionMetadata operation on AmazonQAppsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetQAppSessionMetadata
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/GetQAppSessionMetadata">REST API Reference for GetQAppSessionMetadata Operation</seealso>
        IAsyncResult BeginGetQAppSessionMetadata(GetQAppSessionMetadataRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetQAppSessionMetadata operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetQAppSessionMetadata.</param>
        /// 
        /// <returns>Returns a  GetQAppSessionMetadataResult from QApps.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/GetQAppSessionMetadata">REST API Reference for GetQAppSessionMetadata Operation</seealso>
        GetQAppSessionMetadataResponse EndGetQAppSessionMetadata(IAsyncResult asyncResult);

        #endregion
        
        #region  ImportDocument


        /// <summary>
        /// Uploads a file that can then be used either as a default in a <c>FileUploadCard</c>
        /// from Q App definition or as a file that is used inside a single Q App run. The purpose
        /// of the document is determined by a scope parameter that indicates whether it is at
        /// the app definition level or at the app session level.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportDocument service method.</param>
        /// 
        /// <returns>The response from the ImportDocument service method, as returned by QApps.</returns>
        /// <exception cref="Amazon.QApps.Model.AccessDeniedException">
        /// The client is not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ContentTooLargeException">
        /// The requested operation could not be completed because the content exceeds the maximum
        /// allowed size.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.InternalServerException">
        /// An internal service error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ServiceQuotaExceededException">
        /// The requested operation could not be completed because it would exceed the service's
        /// quota or limit.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ThrottlingException">
        /// The requested operation could not be completed because too many requests were sent
        /// at once. Wait a bit and try again later.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.UnauthorizedException">
        /// The client is not authenticated or authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/ImportDocument">REST API Reference for ImportDocument Operation</seealso>
        ImportDocumentResponse ImportDocument(ImportDocumentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ImportDocument operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ImportDocument operation on AmazonQAppsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndImportDocument
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/ImportDocument">REST API Reference for ImportDocument Operation</seealso>
        IAsyncResult BeginImportDocument(ImportDocumentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ImportDocument operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginImportDocument.</param>
        /// 
        /// <returns>Returns a  ImportDocumentResult from QApps.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/ImportDocument">REST API Reference for ImportDocument Operation</seealso>
        ImportDocumentResponse EndImportDocument(IAsyncResult asyncResult);

        #endregion
        
        #region  ListCategories


        /// <summary>
        /// Lists the categories of a Amazon Q Business application environment instance. For
        /// more information, see <a href="https://docs.aws.amazon.com/amazonq/latest/qbusiness-ug/qapps-custom-labels.html">Custom
        /// labels for Amazon Q Apps</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCategories service method.</param>
        /// 
        /// <returns>The response from the ListCategories service method, as returned by QApps.</returns>
        /// <exception cref="Amazon.QApps.Model.AccessDeniedException">
        /// The client is not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.InternalServerException">
        /// An internal service error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ThrottlingException">
        /// The requested operation could not be completed because too many requests were sent
        /// at once. Wait a bit and try again later.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.UnauthorizedException">
        /// The client is not authenticated or authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/ListCategories">REST API Reference for ListCategories Operation</seealso>
        ListCategoriesResponse ListCategories(ListCategoriesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListCategories operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCategories operation on AmazonQAppsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListCategories
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/ListCategories">REST API Reference for ListCategories Operation</seealso>
        IAsyncResult BeginListCategories(ListCategoriesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListCategories operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCategories.</param>
        /// 
        /// <returns>Returns a  ListCategoriesResult from QApps.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/ListCategories">REST API Reference for ListCategories Operation</seealso>
        ListCategoriesResponse EndListCategories(IAsyncResult asyncResult);

        #endregion
        
        #region  ListLibraryItems


        /// <summary>
        /// Lists the library items for Amazon Q Apps that are published and available for users
        /// in your Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLibraryItems service method.</param>
        /// 
        /// <returns>The response from the ListLibraryItems service method, as returned by QApps.</returns>
        /// <exception cref="Amazon.QApps.Model.AccessDeniedException">
        /// The client is not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.InternalServerException">
        /// An internal service error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ThrottlingException">
        /// The requested operation could not be completed because too many requests were sent
        /// at once. Wait a bit and try again later.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.UnauthorizedException">
        /// The client is not authenticated or authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/ListLibraryItems">REST API Reference for ListLibraryItems Operation</seealso>
        ListLibraryItemsResponse ListLibraryItems(ListLibraryItemsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListLibraryItems operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListLibraryItems operation on AmazonQAppsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListLibraryItems
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/ListLibraryItems">REST API Reference for ListLibraryItems Operation</seealso>
        IAsyncResult BeginListLibraryItems(ListLibraryItemsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListLibraryItems operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListLibraryItems.</param>
        /// 
        /// <returns>Returns a  ListLibraryItemsResult from QApps.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/ListLibraryItems">REST API Reference for ListLibraryItems Operation</seealso>
        ListLibraryItemsResponse EndListLibraryItems(IAsyncResult asyncResult);

        #endregion
        
        #region  ListQApps


        /// <summary>
        /// Lists the Amazon Q Apps owned by or associated with the user either because they created
        /// it or because they used it from the library in the past. The user identity is extracted
        /// from the credentials used to invoke this operation..
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListQApps service method.</param>
        /// 
        /// <returns>The response from the ListQApps service method, as returned by QApps.</returns>
        /// <exception cref="Amazon.QApps.Model.AccessDeniedException">
        /// The client is not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.InternalServerException">
        /// An internal service error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ThrottlingException">
        /// The requested operation could not be completed because too many requests were sent
        /// at once. Wait a bit and try again later.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.UnauthorizedException">
        /// The client is not authenticated or authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/ListQApps">REST API Reference for ListQApps Operation</seealso>
        ListQAppsResponse ListQApps(ListQAppsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListQApps operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListQApps operation on AmazonQAppsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListQApps
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/ListQApps">REST API Reference for ListQApps Operation</seealso>
        IAsyncResult BeginListQApps(ListQAppsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListQApps operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListQApps.</param>
        /// 
        /// <returns>Returns a  ListQAppsResult from QApps.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/ListQApps">REST API Reference for ListQApps Operation</seealso>
        ListQAppsResponse EndListQApps(IAsyncResult asyncResult);

        #endregion
        
        #region  ListQAppSessionData


        /// <summary>
        /// Lists the collected data of a Q App data collection session.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListQAppSessionData service method.</param>
        /// 
        /// <returns>The response from the ListQAppSessionData service method, as returned by QApps.</returns>
        /// <exception cref="Amazon.QApps.Model.AccessDeniedException">
        /// The client is not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.InternalServerException">
        /// An internal service error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ServiceQuotaExceededException">
        /// The requested operation could not be completed because it would exceed the service's
        /// quota or limit.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ThrottlingException">
        /// The requested operation could not be completed because too many requests were sent
        /// at once. Wait a bit and try again later.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.UnauthorizedException">
        /// The client is not authenticated or authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/ListQAppSessionData">REST API Reference for ListQAppSessionData Operation</seealso>
        ListQAppSessionDataResponse ListQAppSessionData(ListQAppSessionDataRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListQAppSessionData operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListQAppSessionData operation on AmazonQAppsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListQAppSessionData
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/ListQAppSessionData">REST API Reference for ListQAppSessionData Operation</seealso>
        IAsyncResult BeginListQAppSessionData(ListQAppSessionDataRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListQAppSessionData operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListQAppSessionData.</param>
        /// 
        /// <returns>Returns a  ListQAppSessionDataResult from QApps.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/ListQAppSessionData">REST API Reference for ListQAppSessionData Operation</seealso>
        ListQAppSessionDataResponse EndListQAppSessionData(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists the tags associated with an Amazon Q Apps resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by QApps.</returns>
        /// <exception cref="Amazon.QApps.Model.AccessDeniedException">
        /// The client is not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.InternalServerException">
        /// An internal service error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ThrottlingException">
        /// The requested operation could not be completed because too many requests were sent
        /// at once. Wait a bit and try again later.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonQAppsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from QApps.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

        #endregion
        
        #region  PredictQApp


        /// <summary>
        /// Generates an Amazon Q App definition based on either a conversation or a problem statement
        /// provided as input.The resulting app definition can be used to call <c>CreateQApp</c>.
        /// This API doesn't create Amazon Q Apps directly.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PredictQApp service method.</param>
        /// 
        /// <returns>The response from the PredictQApp service method, as returned by QApps.</returns>
        /// <exception cref="Amazon.QApps.Model.AccessDeniedException">
        /// The client is not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.InternalServerException">
        /// An internal service error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ThrottlingException">
        /// The requested operation could not be completed because too many requests were sent
        /// at once. Wait a bit and try again later.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.UnauthorizedException">
        /// The client is not authenticated or authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/PredictQApp">REST API Reference for PredictQApp Operation</seealso>
        PredictQAppResponse PredictQApp(PredictQAppRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PredictQApp operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PredictQApp operation on AmazonQAppsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPredictQApp
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/PredictQApp">REST API Reference for PredictQApp Operation</seealso>
        IAsyncResult BeginPredictQApp(PredictQAppRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PredictQApp operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPredictQApp.</param>
        /// 
        /// <returns>Returns a  PredictQAppResult from QApps.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/PredictQApp">REST API Reference for PredictQApp Operation</seealso>
        PredictQAppResponse EndPredictQApp(IAsyncResult asyncResult);

        #endregion
        
        #region  StartQAppSession


        /// <summary>
        /// Starts a new session for an Amazon Q App, allowing inputs to be provided and the app
        /// to be run.
        /// 
        ///  <note> 
        /// <para>
        /// Each Q App session will be condensed into a single conversation in the web experience.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartQAppSession service method.</param>
        /// 
        /// <returns>The response from the StartQAppSession service method, as returned by QApps.</returns>
        /// <exception cref="Amazon.QApps.Model.AccessDeniedException">
        /// The client is not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.InternalServerException">
        /// An internal service error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ServiceQuotaExceededException">
        /// The requested operation could not be completed because it would exceed the service's
        /// quota or limit.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ThrottlingException">
        /// The requested operation could not be completed because too many requests were sent
        /// at once. Wait a bit and try again later.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.UnauthorizedException">
        /// The client is not authenticated or authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/StartQAppSession">REST API Reference for StartQAppSession Operation</seealso>
        StartQAppSessionResponse StartQAppSession(StartQAppSessionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartQAppSession operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartQAppSession operation on AmazonQAppsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartQAppSession
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/StartQAppSession">REST API Reference for StartQAppSession Operation</seealso>
        IAsyncResult BeginStartQAppSession(StartQAppSessionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartQAppSession operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartQAppSession.</param>
        /// 
        /// <returns>Returns a  StartQAppSessionResult from QApps.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/StartQAppSession">REST API Reference for StartQAppSession Operation</seealso>
        StartQAppSessionResponse EndStartQAppSession(IAsyncResult asyncResult);

        #endregion
        
        #region  StopQAppSession


        /// <summary>
        /// Stops an active session for an Amazon Q App.This deletes all data related to the session
        /// and makes it invalid for future uses. The results of the session will be persisted
        /// as part of the conversation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopQAppSession service method.</param>
        /// 
        /// <returns>The response from the StopQAppSession service method, as returned by QApps.</returns>
        /// <exception cref="Amazon.QApps.Model.AccessDeniedException">
        /// The client is not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.InternalServerException">
        /// An internal service error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ServiceQuotaExceededException">
        /// The requested operation could not be completed because it would exceed the service's
        /// quota or limit.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ThrottlingException">
        /// The requested operation could not be completed because too many requests were sent
        /// at once. Wait a bit and try again later.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.UnauthorizedException">
        /// The client is not authenticated or authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/StopQAppSession">REST API Reference for StopQAppSession Operation</seealso>
        StopQAppSessionResponse StopQAppSession(StopQAppSessionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StopQAppSession operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopQAppSession operation on AmazonQAppsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopQAppSession
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/StopQAppSession">REST API Reference for StopQAppSession Operation</seealso>
        IAsyncResult BeginStopQAppSession(StopQAppSessionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StopQAppSession operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopQAppSession.</param>
        /// 
        /// <returns>Returns a  StopQAppSessionResult from QApps.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/StopQAppSession">REST API Reference for StopQAppSession Operation</seealso>
        StopQAppSessionResponse EndStopQAppSession(IAsyncResult asyncResult);

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Associates tags with an Amazon Q Apps resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by QApps.</returns>
        /// <exception cref="Amazon.QApps.Model.AccessDeniedException">
        /// The client is not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ConflictException">
        /// The requested operation could not be completed due to a conflict with the current
        /// state of the resource.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.InternalServerException">
        /// An internal service error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ThrottlingException">
        /// The requested operation could not be completed because too many requests were sent
        /// at once. Wait a bit and try again later.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonQAppsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from QApps.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Disassociates tags from an Amazon Q Apps resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by QApps.</returns>
        /// <exception cref="Amazon.QApps.Model.AccessDeniedException">
        /// The client is not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.InternalServerException">
        /// An internal service error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ThrottlingException">
        /// The requested operation could not be completed because too many requests were sent
        /// at once. Wait a bit and try again later.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonQAppsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from QApps.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateLibraryItem


        /// <summary>
        /// Updates the library item for an Amazon Q App.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLibraryItem service method.</param>
        /// 
        /// <returns>The response from the UpdateLibraryItem service method, as returned by QApps.</returns>
        /// <exception cref="Amazon.QApps.Model.AccessDeniedException">
        /// The client is not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ConflictException">
        /// The requested operation could not be completed due to a conflict with the current
        /// state of the resource.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.InternalServerException">
        /// An internal service error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ThrottlingException">
        /// The requested operation could not be completed because too many requests were sent
        /// at once. Wait a bit and try again later.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.UnauthorizedException">
        /// The client is not authenticated or authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/UpdateLibraryItem">REST API Reference for UpdateLibraryItem Operation</seealso>
        UpdateLibraryItemResponse UpdateLibraryItem(UpdateLibraryItemRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateLibraryItem operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateLibraryItem operation on AmazonQAppsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateLibraryItem
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/UpdateLibraryItem">REST API Reference for UpdateLibraryItem Operation</seealso>
        IAsyncResult BeginUpdateLibraryItem(UpdateLibraryItemRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateLibraryItem operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateLibraryItem.</param>
        /// 
        /// <returns>Returns a  UpdateLibraryItemResult from QApps.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/UpdateLibraryItem">REST API Reference for UpdateLibraryItem Operation</seealso>
        UpdateLibraryItemResponse EndUpdateLibraryItem(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateLibraryItemMetadata


        /// <summary>
        /// Updates the verification status of a library item for an Amazon Q App.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLibraryItemMetadata service method.</param>
        /// 
        /// <returns>The response from the UpdateLibraryItemMetadata service method, as returned by QApps.</returns>
        /// <exception cref="Amazon.QApps.Model.AccessDeniedException">
        /// The client is not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ConflictException">
        /// The requested operation could not be completed due to a conflict with the current
        /// state of the resource.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.InternalServerException">
        /// An internal service error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ThrottlingException">
        /// The requested operation could not be completed because too many requests were sent
        /// at once. Wait a bit and try again later.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.UnauthorizedException">
        /// The client is not authenticated or authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/UpdateLibraryItemMetadata">REST API Reference for UpdateLibraryItemMetadata Operation</seealso>
        UpdateLibraryItemMetadataResponse UpdateLibraryItemMetadata(UpdateLibraryItemMetadataRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateLibraryItemMetadata operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateLibraryItemMetadata operation on AmazonQAppsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateLibraryItemMetadata
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/UpdateLibraryItemMetadata">REST API Reference for UpdateLibraryItemMetadata Operation</seealso>
        IAsyncResult BeginUpdateLibraryItemMetadata(UpdateLibraryItemMetadataRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateLibraryItemMetadata operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateLibraryItemMetadata.</param>
        /// 
        /// <returns>Returns a  UpdateLibraryItemMetadataResult from QApps.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/UpdateLibraryItemMetadata">REST API Reference for UpdateLibraryItemMetadata Operation</seealso>
        UpdateLibraryItemMetadataResponse EndUpdateLibraryItemMetadata(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateQApp


        /// <summary>
        /// Updates an existing Amazon Q App, allowing modifications to its title, description,
        /// and definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateQApp service method.</param>
        /// 
        /// <returns>The response from the UpdateQApp service method, as returned by QApps.</returns>
        /// <exception cref="Amazon.QApps.Model.AccessDeniedException">
        /// The client is not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ContentTooLargeException">
        /// The requested operation could not be completed because the content exceeds the maximum
        /// allowed size.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.InternalServerException">
        /// An internal service error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ThrottlingException">
        /// The requested operation could not be completed because too many requests were sent
        /// at once. Wait a bit and try again later.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.UnauthorizedException">
        /// The client is not authenticated or authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/UpdateQApp">REST API Reference for UpdateQApp Operation</seealso>
        UpdateQAppResponse UpdateQApp(UpdateQAppRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateQApp operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateQApp operation on AmazonQAppsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateQApp
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/UpdateQApp">REST API Reference for UpdateQApp Operation</seealso>
        IAsyncResult BeginUpdateQApp(UpdateQAppRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateQApp operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateQApp.</param>
        /// 
        /// <returns>Returns a  UpdateQAppResult from QApps.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/UpdateQApp">REST API Reference for UpdateQApp Operation</seealso>
        UpdateQAppResponse EndUpdateQApp(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateQAppPermissions


        /// <summary>
        /// Updates read permissions for a Amazon Q App in Amazon Q Business application environment
        /// instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateQAppPermissions service method.</param>
        /// 
        /// <returns>The response from the UpdateQAppPermissions service method, as returned by QApps.</returns>
        /// <exception cref="Amazon.QApps.Model.AccessDeniedException">
        /// The client is not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.InternalServerException">
        /// An internal service error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ThrottlingException">
        /// The requested operation could not be completed because too many requests were sent
        /// at once. Wait a bit and try again later.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.UnauthorizedException">
        /// The client is not authenticated or authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/UpdateQAppPermissions">REST API Reference for UpdateQAppPermissions Operation</seealso>
        UpdateQAppPermissionsResponse UpdateQAppPermissions(UpdateQAppPermissionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateQAppPermissions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateQAppPermissions operation on AmazonQAppsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateQAppPermissions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/UpdateQAppPermissions">REST API Reference for UpdateQAppPermissions Operation</seealso>
        IAsyncResult BeginUpdateQAppPermissions(UpdateQAppPermissionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateQAppPermissions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateQAppPermissions.</param>
        /// 
        /// <returns>Returns a  UpdateQAppPermissionsResult from QApps.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/UpdateQAppPermissions">REST API Reference for UpdateQAppPermissions Operation</seealso>
        UpdateQAppPermissionsResponse EndUpdateQAppPermissions(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateQAppSession


        /// <summary>
        /// Updates the session for a given Q App <c>sessionId</c>. This is only valid when at
        /// least one card of the session is in the <c>WAITING</c> state. Data for each <c>WAITING</c>
        /// card can be provided as input. If inputs are not provided, the call will be accepted
        /// but session will not move forward. Inputs for cards that are not in the <c>WAITING</c>
        /// status will be ignored.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateQAppSession service method.</param>
        /// 
        /// <returns>The response from the UpdateQAppSession service method, as returned by QApps.</returns>
        /// <exception cref="Amazon.QApps.Model.AccessDeniedException">
        /// The client is not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.InternalServerException">
        /// An internal service error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ServiceQuotaExceededException">
        /// The requested operation could not be completed because it would exceed the service's
        /// quota or limit.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ThrottlingException">
        /// The requested operation could not be completed because too many requests were sent
        /// at once. Wait a bit and try again later.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.UnauthorizedException">
        /// The client is not authenticated or authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/UpdateQAppSession">REST API Reference for UpdateQAppSession Operation</seealso>
        UpdateQAppSessionResponse UpdateQAppSession(UpdateQAppSessionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateQAppSession operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateQAppSession operation on AmazonQAppsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateQAppSession
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/UpdateQAppSession">REST API Reference for UpdateQAppSession Operation</seealso>
        IAsyncResult BeginUpdateQAppSession(UpdateQAppSessionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateQAppSession operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateQAppSession.</param>
        /// 
        /// <returns>Returns a  UpdateQAppSessionResult from QApps.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/UpdateQAppSession">REST API Reference for UpdateQAppSession Operation</seealso>
        UpdateQAppSessionResponse EndUpdateQAppSession(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateQAppSessionMetadata


        /// <summary>
        /// Updates the configuration metadata of a session for a given Q App <c>sessionId</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateQAppSessionMetadata service method.</param>
        /// 
        /// <returns>The response from the UpdateQAppSessionMetadata service method, as returned by QApps.</returns>
        /// <exception cref="Amazon.QApps.Model.AccessDeniedException">
        /// The client is not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.InternalServerException">
        /// An internal service error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ServiceQuotaExceededException">
        /// The requested operation could not be completed because it would exceed the service's
        /// quota or limit.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ThrottlingException">
        /// The requested operation could not be completed because too many requests were sent
        /// at once. Wait a bit and try again later.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.UnauthorizedException">
        /// The client is not authenticated or authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/UpdateQAppSessionMetadata">REST API Reference for UpdateQAppSessionMetadata Operation</seealso>
        UpdateQAppSessionMetadataResponse UpdateQAppSessionMetadata(UpdateQAppSessionMetadataRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateQAppSessionMetadata operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateQAppSessionMetadata operation on AmazonQAppsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateQAppSessionMetadata
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/UpdateQAppSessionMetadata">REST API Reference for UpdateQAppSessionMetadata Operation</seealso>
        IAsyncResult BeginUpdateQAppSessionMetadata(UpdateQAppSessionMetadataRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateQAppSessionMetadata operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateQAppSessionMetadata.</param>
        /// 
        /// <returns>Returns a  UpdateQAppSessionMetadataResult from QApps.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/UpdateQAppSessionMetadata">REST API Reference for UpdateQAppSessionMetadata Operation</seealso>
        UpdateQAppSessionMetadataResponse EndUpdateQAppSessionMetadata(IAsyncResult asyncResult);

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