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
using System.Threading;
using System.Threading.Tasks;
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

        /// <summary>
        /// Paginators for the service
        /// </summary>
        IQAppsPaginatorFactory Paginators { get; }

        
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
        /// Associates a rating or review for a library item with the user submitting the request.
        /// This increments the rating count for the specified library item.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateLibraryItemReview service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<AssociateLibraryItemReviewResponse> AssociateLibraryItemReviewAsync(AssociateLibraryItemReviewRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// This operation creates a link between the user's identity calling the operation and
        /// a specific Q App. This is useful to mark the Q App as a <i>favorite</i> for the user
        /// if the user doesn't own the Amazon Q App so they can still run it and see it in their
        /// inventory of Q Apps.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateQAppWithUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<AssociateQAppWithUserResponse> AssociateQAppWithUserAsync(AssociateQAppWithUserRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Creates Categories for the Amazon Q Business application environment instance. Web
        /// experience users use Categories to tag and filter library items. For more information,
        /// see <a href="https://docs.aws.amazon.com/amazonq/latest/qbusiness-ug/qapps-custom-labels.html">Custom
        /// labels for Amazon Q Apps</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchCreateCategory service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<BatchCreateCategoryResponse> BatchCreateCategoryAsync(BatchCreateCategoryRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Deletes Categories for the Amazon Q Business application environment instance. Web
        /// experience users use Categories to tag and filter library items. For more information,
        /// see <a href="https://docs.aws.amazon.com/amazonq/latest/qbusiness-ug/qapps-custom-labels.html">Custom
        /// labels for Amazon Q Apps</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteCategory service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<BatchDeleteCategoryResponse> BatchDeleteCategoryAsync(BatchDeleteCategoryRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Updates Categories for the Amazon Q Business application environment instance. Web
        /// experience users use Categories to tag and filter library items. For more information,
        /// see <a href="https://docs.aws.amazon.com/amazonq/latest/qbusiness-ug/qapps-custom-labels.html">Custom
        /// labels for Amazon Q Apps</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchUpdateCategory service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<BatchUpdateCategoryResponse> BatchUpdateCategoryAsync(BatchUpdateCategoryRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Creates a new library item for an Amazon Q App, allowing it to be discovered and used
        /// by other allowed users.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLibraryItem service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateLibraryItemResponse> CreateLibraryItemAsync(CreateLibraryItemRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Creates a new Amazon Q App based on the provided definition. The Q App definition
        /// specifies the cards and flow of the Q App. This operation also calculates the dependencies
        /// between the cards by inspecting the references in the prompts.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateQApp service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateQAppResponse> CreateQAppAsync(CreateQAppRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Deletes a library item for an Amazon Q App, removing it from the library so it can
        /// no longer be discovered or used by other users.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLibraryItem service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteLibraryItemResponse> DeleteLibraryItemAsync(DeleteLibraryItemRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Deletes an Amazon Q App owned by the user. If the Q App was previously published to
        /// the library, it is also removed from the library.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteQApp service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteQAppResponse> DeleteQAppAsync(DeleteQAppRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Removes a rating or review previously submitted by the user for a library item.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateLibraryItemReview service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DisassociateLibraryItemReviewResponse> DisassociateLibraryItemReviewAsync(DisassociateLibraryItemReviewRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Disassociates a Q App from a user removing the user's access to run the Q App.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateQAppFromUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DisassociateQAppFromUserResponse> DisassociateQAppFromUserAsync(DisassociateQAppFromUserRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Retrieves details about a library item for an Amazon Q App, including its metadata,
        /// categories, ratings, and usage statistics.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLibraryItem service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetLibraryItemResponse> GetLibraryItemAsync(GetLibraryItemRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Retrieves the full details of an Q App, including its definition specifying the cards
        /// and flow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetQApp service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetQAppResponse> GetQAppAsync(GetQAppRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Retrieves the current state and results for an active session of an Amazon Q App.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetQAppSession service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetQAppSessionResponse> GetQAppSessionAsync(GetQAppSessionRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Uploads a file that can then be used either as a default in a <c>FileUploadCard</c>
        /// from Q App definition or as a file that is used inside a single Q App run. The purpose
        /// of the document is determined by a scope parameter that indicates whether it is at
        /// the app definition level or at the app session level.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportDocument service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ImportDocumentResponse> ImportDocumentAsync(ImportDocumentRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Lists the categories of a Amazon Q Business application environment instance. For
        /// more information, see <a href="https://docs.aws.amazon.com/amazonq/latest/qbusiness-ug/qapps-custom-labels.html">Custom
        /// labels for Amazon Q Apps</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCategories service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListCategoriesResponse> ListCategoriesAsync(ListCategoriesRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Lists the library items for Amazon Q Apps that are published and available for users
        /// in your Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLibraryItems service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListLibraryItemsResponse> ListLibraryItemsAsync(ListLibraryItemsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Lists the Amazon Q Apps owned by or associated with the user either because they created
        /// it or because they used it from the library in the past. The user identity is extracted
        /// from the credentials used to invoke this operation..
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListQApps service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListQAppsResponse> ListQAppsAsync(ListQAppsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Lists the tags associated with an Amazon Q Apps resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Generates an Amazon Q App definition based on either a conversation or a problem statement
        /// provided as input.The resulting app definition can be used to call <c>CreateQApp</c>.
        /// This API doesn't create Amazon Q Apps directly.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PredictQApp service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<PredictQAppResponse> PredictQAppAsync(PredictQAppRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<StartQAppSessionResponse> StartQAppSessionAsync(StartQAppSessionRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Stops an active session for an Amazon Q App.This deletes all data related to the session
        /// and makes it invalid for future uses. The results of the session will be persisted
        /// as part of the conversation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopQAppSession service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<StopQAppSessionResponse> StopQAppSessionAsync(StopQAppSessionRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Associates tags with an Amazon Q Apps resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Disassociates tags from an Amazon Q Apps resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Updates the library item for an Amazon Q App.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLibraryItem service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateLibraryItemResponse> UpdateLibraryItemAsync(UpdateLibraryItemRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Updates the verification status of a library item for an Amazon Q App.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLibraryItemMetadata service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateLibraryItemMetadataResponse> UpdateLibraryItemMetadataAsync(UpdateLibraryItemMetadataRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Updates an existing Amazon Q App, allowing modifications to its title, description,
        /// and definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateQApp service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateQAppResponse> UpdateQAppAsync(UpdateQAppRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Updates the session for a given Q App <c>sessionId</c>. This is only valid when at
        /// least one card of the session is in the <c>WAITING</c> state. Data for each <c>WAITING</c>
        /// card can be provided as input. If inputs are not provided, the call will be accepted
        /// but session will not move forward. Inputs for cards that are not in the <c>WAITING</c>
        /// status will be ignored.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateQAppSession service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateQAppSessionResponse> UpdateQAppSessionAsync(UpdateQAppSessionRequest request, CancellationToken cancellationToken = default(CancellationToken));

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