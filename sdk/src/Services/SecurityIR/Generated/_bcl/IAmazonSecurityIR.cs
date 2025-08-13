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
 * Do not modify this file. This file is generated from the security-ir-2018-05-10.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.SecurityIR.Model;

#pragma warning disable CS1570
namespace Amazon.SecurityIR
{
    /// <summary>
    /// <para>Interface for accessing SecurityIR</para>
    ///
    /// This guide documents the action and response elements for use of the service.
    /// </summary>
    public partial interface IAmazonSecurityIR : IAmazonService, IDisposable
    {

        /// <summary>
        /// Paginators for the service
        /// </summary>
        ISecurityIRPaginatorFactory Paginators { get; }

        
        #region  BatchGetMemberAccountDetails


        /// <summary>
        /// Provides information on whether the supplied account IDs are associated with a membership.
        /// 
        ///  <note> 
        /// <para>
        ///  AWS account ID's may appear less than 12 characters and need to be zero-prepended.
        /// An example would be <c>123123123</c> which is nine digits, and with zero-prepend would
        /// be <c>000123123123</c>. Not zero-prepending to 12 digits could result in errors. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetMemberAccountDetails service method.</param>
        /// 
        /// <returns>The response from the BatchGetMemberAccountDetails service method, as returned by SecurityIR.</returns>
        /// <exception cref="Amazon.SecurityIR.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InvalidTokenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.SecurityIncidentResponseNotActiveException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/BatchGetMemberAccountDetails">REST API Reference for BatchGetMemberAccountDetails Operation</seealso>
        BatchGetMemberAccountDetailsResponse BatchGetMemberAccountDetails(BatchGetMemberAccountDetailsRequest request);



        /// <summary>
        /// Provides information on whether the supplied account IDs are associated with a membership.
        /// 
        ///  <note> 
        /// <para>
        ///  AWS account ID's may appear less than 12 characters and need to be zero-prepended.
        /// An example would be <c>123123123</c> which is nine digits, and with zero-prepend would
        /// be <c>000123123123</c>. Not zero-prepending to 12 digits could result in errors. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetMemberAccountDetails service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchGetMemberAccountDetails service method, as returned by SecurityIR.</returns>
        /// <exception cref="Amazon.SecurityIR.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InvalidTokenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.SecurityIncidentResponseNotActiveException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/BatchGetMemberAccountDetails">REST API Reference for BatchGetMemberAccountDetails Operation</seealso>
        Task<BatchGetMemberAccountDetailsResponse> BatchGetMemberAccountDetailsAsync(BatchGetMemberAccountDetailsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CancelMembership


        /// <summary>
        /// Cancels an existing membership.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelMembership service method.</param>
        /// 
        /// <returns>The response from the CancelMembership service method, as returned by SecurityIR.</returns>
        /// <exception cref="Amazon.SecurityIR.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InvalidTokenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.SecurityIncidentResponseNotActiveException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/CancelMembership">REST API Reference for CancelMembership Operation</seealso>
        CancelMembershipResponse CancelMembership(CancelMembershipRequest request);



        /// <summary>
        /// Cancels an existing membership.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelMembership service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelMembership service method, as returned by SecurityIR.</returns>
        /// <exception cref="Amazon.SecurityIR.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InvalidTokenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.SecurityIncidentResponseNotActiveException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/CancelMembership">REST API Reference for CancelMembership Operation</seealso>
        Task<CancelMembershipResponse> CancelMembershipAsync(CancelMembershipRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CloseCase


        /// <summary>
        /// Closes an existing case.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CloseCase service method.</param>
        /// 
        /// <returns>The response from the CloseCase service method, as returned by SecurityIR.</returns>
        /// <exception cref="Amazon.SecurityIR.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InvalidTokenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.SecurityIncidentResponseNotActiveException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/CloseCase">REST API Reference for CloseCase Operation</seealso>
        CloseCaseResponse CloseCase(CloseCaseRequest request);



        /// <summary>
        /// Closes an existing case.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CloseCase service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CloseCase service method, as returned by SecurityIR.</returns>
        /// <exception cref="Amazon.SecurityIR.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InvalidTokenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.SecurityIncidentResponseNotActiveException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/CloseCase">REST API Reference for CloseCase Operation</seealso>
        Task<CloseCaseResponse> CloseCaseAsync(CloseCaseRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateCase


        /// <summary>
        /// Creates a new case.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCase service method.</param>
        /// 
        /// <returns>The response from the CreateCase service method, as returned by SecurityIR.</returns>
        /// <exception cref="Amazon.SecurityIR.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InvalidTokenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.SecurityIncidentResponseNotActiveException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/CreateCase">REST API Reference for CreateCase Operation</seealso>
        CreateCaseResponse CreateCase(CreateCaseRequest request);



        /// <summary>
        /// Creates a new case.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCase service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateCase service method, as returned by SecurityIR.</returns>
        /// <exception cref="Amazon.SecurityIR.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InvalidTokenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.SecurityIncidentResponseNotActiveException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/CreateCase">REST API Reference for CreateCase Operation</seealso>
        Task<CreateCaseResponse> CreateCaseAsync(CreateCaseRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateCaseComment


        /// <summary>
        /// Adds a comment to an existing case.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCaseComment service method.</param>
        /// 
        /// <returns>The response from the CreateCaseComment service method, as returned by SecurityIR.</returns>
        /// <exception cref="Amazon.SecurityIR.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InvalidTokenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.SecurityIncidentResponseNotActiveException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/CreateCaseComment">REST API Reference for CreateCaseComment Operation</seealso>
        CreateCaseCommentResponse CreateCaseComment(CreateCaseCommentRequest request);



        /// <summary>
        /// Adds a comment to an existing case.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCaseComment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateCaseComment service method, as returned by SecurityIR.</returns>
        /// <exception cref="Amazon.SecurityIR.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InvalidTokenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.SecurityIncidentResponseNotActiveException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/CreateCaseComment">REST API Reference for CreateCaseComment Operation</seealso>
        Task<CreateCaseCommentResponse> CreateCaseCommentAsync(CreateCaseCommentRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateMembership


        /// <summary>
        /// Creates a new membership.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMembership service method.</param>
        /// 
        /// <returns>The response from the CreateMembership service method, as returned by SecurityIR.</returns>
        /// <exception cref="Amazon.SecurityIR.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InvalidTokenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.SecurityIncidentResponseNotActiveException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/CreateMembership">REST API Reference for CreateMembership Operation</seealso>
        CreateMembershipResponse CreateMembership(CreateMembershipRequest request);



        /// <summary>
        /// Creates a new membership.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMembership service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateMembership service method, as returned by SecurityIR.</returns>
        /// <exception cref="Amazon.SecurityIR.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InvalidTokenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.SecurityIncidentResponseNotActiveException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/CreateMembership">REST API Reference for CreateMembership Operation</seealso>
        Task<CreateMembershipResponse> CreateMembershipAsync(CreateMembershipRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetCase


        /// <summary>
        /// Returns the attributes of a case.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCase service method.</param>
        /// 
        /// <returns>The response from the GetCase service method, as returned by SecurityIR.</returns>
        /// <exception cref="Amazon.SecurityIR.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InvalidTokenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.SecurityIncidentResponseNotActiveException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/GetCase">REST API Reference for GetCase Operation</seealso>
        GetCaseResponse GetCase(GetCaseRequest request);



        /// <summary>
        /// Returns the attributes of a case.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCase service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCase service method, as returned by SecurityIR.</returns>
        /// <exception cref="Amazon.SecurityIR.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InvalidTokenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.SecurityIncidentResponseNotActiveException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/GetCase">REST API Reference for GetCase Operation</seealso>
        Task<GetCaseResponse> GetCaseAsync(GetCaseRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetCaseAttachmentDownloadUrl


        /// <summary>
        /// Returns a Pre-Signed URL for uploading attachments into a case.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCaseAttachmentDownloadUrl service method.</param>
        /// 
        /// <returns>The response from the GetCaseAttachmentDownloadUrl service method, as returned by SecurityIR.</returns>
        /// <exception cref="Amazon.SecurityIR.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InvalidTokenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.SecurityIncidentResponseNotActiveException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/GetCaseAttachmentDownloadUrl">REST API Reference for GetCaseAttachmentDownloadUrl Operation</seealso>
        GetCaseAttachmentDownloadUrlResponse GetCaseAttachmentDownloadUrl(GetCaseAttachmentDownloadUrlRequest request);



        /// <summary>
        /// Returns a Pre-Signed URL for uploading attachments into a case.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCaseAttachmentDownloadUrl service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCaseAttachmentDownloadUrl service method, as returned by SecurityIR.</returns>
        /// <exception cref="Amazon.SecurityIR.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InvalidTokenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.SecurityIncidentResponseNotActiveException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/GetCaseAttachmentDownloadUrl">REST API Reference for GetCaseAttachmentDownloadUrl Operation</seealso>
        Task<GetCaseAttachmentDownloadUrlResponse> GetCaseAttachmentDownloadUrlAsync(GetCaseAttachmentDownloadUrlRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetCaseAttachmentUploadUrl


        /// <summary>
        /// Uploads an attachment to a case.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCaseAttachmentUploadUrl service method.</param>
        /// 
        /// <returns>The response from the GetCaseAttachmentUploadUrl service method, as returned by SecurityIR.</returns>
        /// <exception cref="Amazon.SecurityIR.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InvalidTokenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.SecurityIncidentResponseNotActiveException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/GetCaseAttachmentUploadUrl">REST API Reference for GetCaseAttachmentUploadUrl Operation</seealso>
        GetCaseAttachmentUploadUrlResponse GetCaseAttachmentUploadUrl(GetCaseAttachmentUploadUrlRequest request);



        /// <summary>
        /// Uploads an attachment to a case.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCaseAttachmentUploadUrl service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCaseAttachmentUploadUrl service method, as returned by SecurityIR.</returns>
        /// <exception cref="Amazon.SecurityIR.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InvalidTokenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.SecurityIncidentResponseNotActiveException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/GetCaseAttachmentUploadUrl">REST API Reference for GetCaseAttachmentUploadUrl Operation</seealso>
        Task<GetCaseAttachmentUploadUrlResponse> GetCaseAttachmentUploadUrlAsync(GetCaseAttachmentUploadUrlRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetMembership


        /// <summary>
        /// Returns the attributes of a membership.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMembership service method.</param>
        /// 
        /// <returns>The response from the GetMembership service method, as returned by SecurityIR.</returns>
        /// <exception cref="Amazon.SecurityIR.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InvalidTokenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.SecurityIncidentResponseNotActiveException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/GetMembership">REST API Reference for GetMembership Operation</seealso>
        GetMembershipResponse GetMembership(GetMembershipRequest request);



        /// <summary>
        /// Returns the attributes of a membership.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMembership service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetMembership service method, as returned by SecurityIR.</returns>
        /// <exception cref="Amazon.SecurityIR.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InvalidTokenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.SecurityIncidentResponseNotActiveException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/GetMembership">REST API Reference for GetMembership Operation</seealso>
        Task<GetMembershipResponse> GetMembershipAsync(GetMembershipRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListCaseEdits


        /// <summary>
        /// Views the case history for edits made to a designated case.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCaseEdits service method.</param>
        /// 
        /// <returns>The response from the ListCaseEdits service method, as returned by SecurityIR.</returns>
        /// <exception cref="Amazon.SecurityIR.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InvalidTokenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.SecurityIncidentResponseNotActiveException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/ListCaseEdits">REST API Reference for ListCaseEdits Operation</seealso>
        ListCaseEditsResponse ListCaseEdits(ListCaseEditsRequest request);



        /// <summary>
        /// Views the case history for edits made to a designated case.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCaseEdits service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCaseEdits service method, as returned by SecurityIR.</returns>
        /// <exception cref="Amazon.SecurityIR.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InvalidTokenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.SecurityIncidentResponseNotActiveException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/ListCaseEdits">REST API Reference for ListCaseEdits Operation</seealso>
        Task<ListCaseEditsResponse> ListCaseEditsAsync(ListCaseEditsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListCases


        /// <summary>
        /// Lists all cases the requester has access to.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCases service method.</param>
        /// 
        /// <returns>The response from the ListCases service method, as returned by SecurityIR.</returns>
        /// <exception cref="Amazon.SecurityIR.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InvalidTokenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.SecurityIncidentResponseNotActiveException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/ListCases">REST API Reference for ListCases Operation</seealso>
        ListCasesResponse ListCases(ListCasesRequest request);



        /// <summary>
        /// Lists all cases the requester has access to.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCases service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCases service method, as returned by SecurityIR.</returns>
        /// <exception cref="Amazon.SecurityIR.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InvalidTokenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.SecurityIncidentResponseNotActiveException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/ListCases">REST API Reference for ListCases Operation</seealso>
        Task<ListCasesResponse> ListCasesAsync(ListCasesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListComments


        /// <summary>
        /// Returns comments for a designated case.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListComments service method.</param>
        /// 
        /// <returns>The response from the ListComments service method, as returned by SecurityIR.</returns>
        /// <exception cref="Amazon.SecurityIR.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InvalidTokenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.SecurityIncidentResponseNotActiveException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/ListComments">REST API Reference for ListComments Operation</seealso>
        ListCommentsResponse ListComments(ListCommentsRequest request);



        /// <summary>
        /// Returns comments for a designated case.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListComments service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListComments service method, as returned by SecurityIR.</returns>
        /// <exception cref="Amazon.SecurityIR.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InvalidTokenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.SecurityIncidentResponseNotActiveException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/ListComments">REST API Reference for ListComments Operation</seealso>
        Task<ListCommentsResponse> ListCommentsAsync(ListCommentsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListMemberships


        /// <summary>
        /// Returns the memberships that the calling principal can access.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMemberships service method.</param>
        /// 
        /// <returns>The response from the ListMemberships service method, as returned by SecurityIR.</returns>
        /// <exception cref="Amazon.SecurityIR.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InvalidTokenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.SecurityIncidentResponseNotActiveException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/ListMemberships">REST API Reference for ListMemberships Operation</seealso>
        ListMembershipsResponse ListMemberships(ListMembershipsRequest request);



        /// <summary>
        /// Returns the memberships that the calling principal can access.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMemberships service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListMemberships service method, as returned by SecurityIR.</returns>
        /// <exception cref="Amazon.SecurityIR.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InvalidTokenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.SecurityIncidentResponseNotActiveException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/ListMemberships">REST API Reference for ListMemberships Operation</seealso>
        Task<ListMembershipsResponse> ListMembershipsAsync(ListMembershipsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Returns currently configured tags on a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by SecurityIR.</returns>
        /// <exception cref="Amazon.SecurityIR.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InvalidTokenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.SecurityIncidentResponseNotActiveException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);



        /// <summary>
        /// Returns currently configured tags on a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by SecurityIR.</returns>
        /// <exception cref="Amazon.SecurityIR.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InvalidTokenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.SecurityIncidentResponseNotActiveException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Adds a tag(s) to a designated resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by SecurityIR.</returns>
        /// <exception cref="Amazon.SecurityIR.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InvalidTokenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.SecurityIncidentResponseNotActiveException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);



        /// <summary>
        /// Adds a tag(s) to a designated resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by SecurityIR.</returns>
        /// <exception cref="Amazon.SecurityIR.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InvalidTokenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.SecurityIncidentResponseNotActiveException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes a tag(s) from a designate resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by SecurityIR.</returns>
        /// <exception cref="Amazon.SecurityIR.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InvalidTokenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.SecurityIncidentResponseNotActiveException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);



        /// <summary>
        /// Removes a tag(s) from a designate resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by SecurityIR.</returns>
        /// <exception cref="Amazon.SecurityIR.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InvalidTokenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.SecurityIncidentResponseNotActiveException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateCase


        /// <summary>
        /// Updates an existing case.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCase service method.</param>
        /// 
        /// <returns>The response from the UpdateCase service method, as returned by SecurityIR.</returns>
        /// <exception cref="Amazon.SecurityIR.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InvalidTokenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.SecurityIncidentResponseNotActiveException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/UpdateCase">REST API Reference for UpdateCase Operation</seealso>
        UpdateCaseResponse UpdateCase(UpdateCaseRequest request);



        /// <summary>
        /// Updates an existing case.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCase service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateCase service method, as returned by SecurityIR.</returns>
        /// <exception cref="Amazon.SecurityIR.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InvalidTokenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.SecurityIncidentResponseNotActiveException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/UpdateCase">REST API Reference for UpdateCase Operation</seealso>
        Task<UpdateCaseResponse> UpdateCaseAsync(UpdateCaseRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateCaseComment


        /// <summary>
        /// Updates an existing case comment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCaseComment service method.</param>
        /// 
        /// <returns>The response from the UpdateCaseComment service method, as returned by SecurityIR.</returns>
        /// <exception cref="Amazon.SecurityIR.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InvalidTokenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.SecurityIncidentResponseNotActiveException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/UpdateCaseComment">REST API Reference for UpdateCaseComment Operation</seealso>
        UpdateCaseCommentResponse UpdateCaseComment(UpdateCaseCommentRequest request);



        /// <summary>
        /// Updates an existing case comment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCaseComment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateCaseComment service method, as returned by SecurityIR.</returns>
        /// <exception cref="Amazon.SecurityIR.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InvalidTokenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.SecurityIncidentResponseNotActiveException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/UpdateCaseComment">REST API Reference for UpdateCaseComment Operation</seealso>
        Task<UpdateCaseCommentResponse> UpdateCaseCommentAsync(UpdateCaseCommentRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateCaseStatus


        /// <summary>
        /// Updates the state transitions for a designated cases.
        /// 
        ///  
        /// <para>
        ///  <b>Self-managed</b>: the following states are available for self-managed cases. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Submitted → Detection and Analysis
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Detection and Analysis → Containment, Eradication, and Recovery
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Detection and Analysis → Post-incident Activities
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Containment, Eradication, and Recovery → Detection and Analysis
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Containment, Eradication, and Recovery → Post-incident Activities
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Post-incident Activities → Containment, Eradication, and Recovery
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Post-incident Activities → Detection and Analysis
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Any → Closed
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>AWS supported</b>: You must use the <c>CloseCase</c> API to close. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCaseStatus service method.</param>
        /// 
        /// <returns>The response from the UpdateCaseStatus service method, as returned by SecurityIR.</returns>
        /// <exception cref="Amazon.SecurityIR.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InvalidTokenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.SecurityIncidentResponseNotActiveException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/UpdateCaseStatus">REST API Reference for UpdateCaseStatus Operation</seealso>
        UpdateCaseStatusResponse UpdateCaseStatus(UpdateCaseStatusRequest request);



        /// <summary>
        /// Updates the state transitions for a designated cases.
        /// 
        ///  
        /// <para>
        ///  <b>Self-managed</b>: the following states are available for self-managed cases. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Submitted → Detection and Analysis
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Detection and Analysis → Containment, Eradication, and Recovery
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Detection and Analysis → Post-incident Activities
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Containment, Eradication, and Recovery → Detection and Analysis
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Containment, Eradication, and Recovery → Post-incident Activities
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Post-incident Activities → Containment, Eradication, and Recovery
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Post-incident Activities → Detection and Analysis
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Any → Closed
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>AWS supported</b>: You must use the <c>CloseCase</c> API to close. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCaseStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateCaseStatus service method, as returned by SecurityIR.</returns>
        /// <exception cref="Amazon.SecurityIR.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InvalidTokenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.SecurityIncidentResponseNotActiveException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/UpdateCaseStatus">REST API Reference for UpdateCaseStatus Operation</seealso>
        Task<UpdateCaseStatusResponse> UpdateCaseStatusAsync(UpdateCaseStatusRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateMembership


        /// <summary>
        /// Updates membership configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMembership service method.</param>
        /// 
        /// <returns>The response from the UpdateMembership service method, as returned by SecurityIR.</returns>
        /// <exception cref="Amazon.SecurityIR.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InvalidTokenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.SecurityIncidentResponseNotActiveException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/UpdateMembership">REST API Reference for UpdateMembership Operation</seealso>
        UpdateMembershipResponse UpdateMembership(UpdateMembershipRequest request);



        /// <summary>
        /// Updates membership configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMembership service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateMembership service method, as returned by SecurityIR.</returns>
        /// <exception cref="Amazon.SecurityIR.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InvalidTokenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.SecurityIncidentResponseNotActiveException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/UpdateMembership">REST API Reference for UpdateMembership Operation</seealso>
        Task<UpdateMembershipResponse> UpdateMembershipAsync(UpdateMembershipRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateResolverType


        /// <summary>
        /// Updates the resolver type for a case.
        /// 
        ///  <important> 
        /// <para>
        /// This is a one-way action and cannot be reversed.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateResolverType service method.</param>
        /// 
        /// <returns>The response from the UpdateResolverType service method, as returned by SecurityIR.</returns>
        /// <exception cref="Amazon.SecurityIR.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InvalidTokenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.SecurityIncidentResponseNotActiveException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/UpdateResolverType">REST API Reference for UpdateResolverType Operation</seealso>
        UpdateResolverTypeResponse UpdateResolverType(UpdateResolverTypeRequest request);



        /// <summary>
        /// Updates the resolver type for a case.
        /// 
        ///  <important> 
        /// <para>
        /// This is a one-way action and cannot be reversed.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateResolverType service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateResolverType service method, as returned by SecurityIR.</returns>
        /// <exception cref="Amazon.SecurityIR.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InvalidTokenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.SecurityIncidentResponseNotActiveException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/UpdateResolverType">REST API Reference for UpdateResolverType Operation</seealso>
        Task<UpdateResolverTypeResponse> UpdateResolverTypeAsync(UpdateResolverTypeRequest request, CancellationToken cancellationToken = default(CancellationToken));

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