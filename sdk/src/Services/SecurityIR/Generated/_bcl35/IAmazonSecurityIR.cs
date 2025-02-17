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
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.SecurityIR.Model;

#pragma warning disable CS1570
namespace Amazon.SecurityIR
{
    /// <summary>
    /// <para>Interface for accessing SecurityIR</para>
    ///
    /// This guide provides documents the action and response elements for customer use of
    /// the service.
    /// </summary>
    public partial interface IAmazonSecurityIR : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        ISecurityIRPaginatorFactory Paginators { get; }
#endif


        
        #region  BatchGetMemberAccountDetails


        /// <summary>
        /// Grants permission to view an existing membership.
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
        /// Initiates the asynchronous execution of the BatchGetMemberAccountDetails operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchGetMemberAccountDetails operation on AmazonSecurityIRClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchGetMemberAccountDetails
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/BatchGetMemberAccountDetails">REST API Reference for BatchGetMemberAccountDetails Operation</seealso>
        IAsyncResult BeginBatchGetMemberAccountDetails(BatchGetMemberAccountDetailsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BatchGetMemberAccountDetails operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchGetMemberAccountDetails.</param>
        /// 
        /// <returns>Returns a  BatchGetMemberAccountDetailsResult from SecurityIR.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/BatchGetMemberAccountDetails">REST API Reference for BatchGetMemberAccountDetails Operation</seealso>
        BatchGetMemberAccountDetailsResponse EndBatchGetMemberAccountDetails(IAsyncResult asyncResult);

        #endregion
        
        #region  CancelMembership


        /// <summary>
        /// Grants permissions to cancel an existing membership.
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
        /// Initiates the asynchronous execution of the CancelMembership operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelMembership operation on AmazonSecurityIRClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelMembership
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/CancelMembership">REST API Reference for CancelMembership Operation</seealso>
        IAsyncResult BeginCancelMembership(CancelMembershipRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CancelMembership operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelMembership.</param>
        /// 
        /// <returns>Returns a  CancelMembershipResult from SecurityIR.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/CancelMembership">REST API Reference for CancelMembership Operation</seealso>
        CancelMembershipResponse EndCancelMembership(IAsyncResult asyncResult);

        #endregion
        
        #region  CloseCase


        /// <summary>
        /// Grants permission to close an existing case.
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
        /// Initiates the asynchronous execution of the CloseCase operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CloseCase operation on AmazonSecurityIRClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCloseCase
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/CloseCase">REST API Reference for CloseCase Operation</seealso>
        IAsyncResult BeginCloseCase(CloseCaseRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CloseCase operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCloseCase.</param>
        /// 
        /// <returns>Returns a  CloseCaseResult from SecurityIR.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/CloseCase">REST API Reference for CloseCase Operation</seealso>
        CloseCaseResponse EndCloseCase(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateCase


        /// <summary>
        /// Grants permission to create a new case.
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
        /// Initiates the asynchronous execution of the CreateCase operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCase operation on AmazonSecurityIRClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateCase
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/CreateCase">REST API Reference for CreateCase Operation</seealso>
        IAsyncResult BeginCreateCase(CreateCaseRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateCase operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCase.</param>
        /// 
        /// <returns>Returns a  CreateCaseResult from SecurityIR.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/CreateCase">REST API Reference for CreateCase Operation</seealso>
        CreateCaseResponse EndCreateCase(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateCaseComment


        /// <summary>
        /// Grants permission to add a comment to an existing case.
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
        /// Initiates the asynchronous execution of the CreateCaseComment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCaseComment operation on AmazonSecurityIRClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateCaseComment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/CreateCaseComment">REST API Reference for CreateCaseComment Operation</seealso>
        IAsyncResult BeginCreateCaseComment(CreateCaseCommentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateCaseComment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCaseComment.</param>
        /// 
        /// <returns>Returns a  CreateCaseCommentResult from SecurityIR.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/CreateCaseComment">REST API Reference for CreateCaseComment Operation</seealso>
        CreateCaseCommentResponse EndCreateCaseComment(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateMembership


        /// <summary>
        /// Grants permissions to create a new membership.
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
        /// Initiates the asynchronous execution of the CreateMembership operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateMembership operation on AmazonSecurityIRClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateMembership
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/CreateMembership">REST API Reference for CreateMembership Operation</seealso>
        IAsyncResult BeginCreateMembership(CreateMembershipRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateMembership operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateMembership.</param>
        /// 
        /// <returns>Returns a  CreateMembershipResult from SecurityIR.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/CreateMembership">REST API Reference for CreateMembership Operation</seealso>
        CreateMembershipResponse EndCreateMembership(IAsyncResult asyncResult);

        #endregion
        
        #region  GetCase


        /// <summary>
        /// Grant permission to view a designated case.
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
        /// Initiates the asynchronous execution of the GetCase operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCase operation on AmazonSecurityIRClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCase
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/GetCase">REST API Reference for GetCase Operation</seealso>
        IAsyncResult BeginGetCase(GetCaseRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetCase operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCase.</param>
        /// 
        /// <returns>Returns a  GetCaseResult from SecurityIR.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/GetCase">REST API Reference for GetCase Operation</seealso>
        GetCaseResponse EndGetCase(IAsyncResult asyncResult);

        #endregion
        
        #region  GetCaseAttachmentDownloadUrl


        /// <summary>
        /// Grants permission to obtain an Amazon S3 presigned URL to download an attachment.
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
        /// Initiates the asynchronous execution of the GetCaseAttachmentDownloadUrl operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCaseAttachmentDownloadUrl operation on AmazonSecurityIRClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCaseAttachmentDownloadUrl
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/GetCaseAttachmentDownloadUrl">REST API Reference for GetCaseAttachmentDownloadUrl Operation</seealso>
        IAsyncResult BeginGetCaseAttachmentDownloadUrl(GetCaseAttachmentDownloadUrlRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetCaseAttachmentDownloadUrl operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCaseAttachmentDownloadUrl.</param>
        /// 
        /// <returns>Returns a  GetCaseAttachmentDownloadUrlResult from SecurityIR.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/GetCaseAttachmentDownloadUrl">REST API Reference for GetCaseAttachmentDownloadUrl Operation</seealso>
        GetCaseAttachmentDownloadUrlResponse EndGetCaseAttachmentDownloadUrl(IAsyncResult asyncResult);

        #endregion
        
        #region  GetCaseAttachmentUploadUrl


        /// <summary>
        /// Grants permission to upload an attachment to a case.
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
        /// Initiates the asynchronous execution of the GetCaseAttachmentUploadUrl operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCaseAttachmentUploadUrl operation on AmazonSecurityIRClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCaseAttachmentUploadUrl
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/GetCaseAttachmentUploadUrl">REST API Reference for GetCaseAttachmentUploadUrl Operation</seealso>
        IAsyncResult BeginGetCaseAttachmentUploadUrl(GetCaseAttachmentUploadUrlRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetCaseAttachmentUploadUrl operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCaseAttachmentUploadUrl.</param>
        /// 
        /// <returns>Returns a  GetCaseAttachmentUploadUrlResult from SecurityIR.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/GetCaseAttachmentUploadUrl">REST API Reference for GetCaseAttachmentUploadUrl Operation</seealso>
        GetCaseAttachmentUploadUrlResponse EndGetCaseAttachmentUploadUrl(IAsyncResult asyncResult);

        #endregion
        
        #region  GetMembership


        /// <summary>
        /// Grants permission to get details of a designated service membership.
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
        /// Initiates the asynchronous execution of the GetMembership operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMembership operation on AmazonSecurityIRClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetMembership
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/GetMembership">REST API Reference for GetMembership Operation</seealso>
        IAsyncResult BeginGetMembership(GetMembershipRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetMembership operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetMembership.</param>
        /// 
        /// <returns>Returns a  GetMembershipResult from SecurityIR.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/GetMembership">REST API Reference for GetMembership Operation</seealso>
        GetMembershipResponse EndGetMembership(IAsyncResult asyncResult);

        #endregion
        
        #region  ListCaseEdits


        /// <summary>
        /// Grants permissions to view the aidt log for edits made to a designated case.
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
        /// Initiates the asynchronous execution of the ListCaseEdits operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCaseEdits operation on AmazonSecurityIRClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListCaseEdits
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/ListCaseEdits">REST API Reference for ListCaseEdits Operation</seealso>
        IAsyncResult BeginListCaseEdits(ListCaseEditsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListCaseEdits operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCaseEdits.</param>
        /// 
        /// <returns>Returns a  ListCaseEditsResult from SecurityIR.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/ListCaseEdits">REST API Reference for ListCaseEdits Operation</seealso>
        ListCaseEditsResponse EndListCaseEdits(IAsyncResult asyncResult);

        #endregion
        
        #region  ListCases


        /// <summary>
        /// Grants permission to list all cases the requester has access to.
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
        /// Initiates the asynchronous execution of the ListCases operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCases operation on AmazonSecurityIRClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListCases
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/ListCases">REST API Reference for ListCases Operation</seealso>
        IAsyncResult BeginListCases(ListCasesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListCases operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCases.</param>
        /// 
        /// <returns>Returns a  ListCasesResult from SecurityIR.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/ListCases">REST API Reference for ListCases Operation</seealso>
        ListCasesResponse EndListCases(IAsyncResult asyncResult);

        #endregion
        
        #region  ListComments


        /// <summary>
        /// Grants permissions to list and view comments for a designated case.
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
        /// Initiates the asynchronous execution of the ListComments operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListComments operation on AmazonSecurityIRClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListComments
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/ListComments">REST API Reference for ListComments Operation</seealso>
        IAsyncResult BeginListComments(ListCommentsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListComments operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListComments.</param>
        /// 
        /// <returns>Returns a  ListCommentsResult from SecurityIR.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/ListComments">REST API Reference for ListComments Operation</seealso>
        ListCommentsResponse EndListComments(IAsyncResult asyncResult);

        #endregion
        
        #region  ListMemberships


        /// <summary>
        /// Grants permission to query the memberships a principal has access to.
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
        /// Initiates the asynchronous execution of the ListMemberships operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMemberships operation on AmazonSecurityIRClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListMemberships
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/ListMemberships">REST API Reference for ListMemberships Operation</seealso>
        IAsyncResult BeginListMemberships(ListMembershipsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListMemberships operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListMemberships.</param>
        /// 
        /// <returns>Returns a  ListMembershipsResult from SecurityIR.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/ListMemberships">REST API Reference for ListMemberships Operation</seealso>
        ListMembershipsResponse EndListMemberships(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Grants permission to view currently configured tags on a resource.
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
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonSecurityIRClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from SecurityIR.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Grants permission to add a tag(s) to a designated resource.
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
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonSecurityIRClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from SecurityIR.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Grants permission to remove a tag(s) from a designate resource.
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
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonSecurityIRClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from SecurityIR.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateCase


        /// <summary>
        /// Grants permission to update an existing case.
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
        /// Initiates the asynchronous execution of the UpdateCase operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateCase operation on AmazonSecurityIRClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateCase
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/UpdateCase">REST API Reference for UpdateCase Operation</seealso>
        IAsyncResult BeginUpdateCase(UpdateCaseRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateCase operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateCase.</param>
        /// 
        /// <returns>Returns a  UpdateCaseResult from SecurityIR.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/UpdateCase">REST API Reference for UpdateCase Operation</seealso>
        UpdateCaseResponse EndUpdateCase(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateCaseComment


        /// <summary>
        /// Grants permission to update an existing case comment.
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
        /// Initiates the asynchronous execution of the UpdateCaseComment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateCaseComment operation on AmazonSecurityIRClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateCaseComment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/UpdateCaseComment">REST API Reference for UpdateCaseComment Operation</seealso>
        IAsyncResult BeginUpdateCaseComment(UpdateCaseCommentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateCaseComment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateCaseComment.</param>
        /// 
        /// <returns>Returns a  UpdateCaseCommentResult from SecurityIR.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/UpdateCaseComment">REST API Reference for UpdateCaseComment Operation</seealso>
        UpdateCaseCommentResponse EndUpdateCaseComment(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateCaseStatus


        /// <summary>
        /// Grants permission to update the status for a designated cases. Options include <c>Submitted
        /// | Detection and Analysis | Eradication, Containment and Recovery | Post-Incident Activities
        /// | Closed</c>.
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
        /// Initiates the asynchronous execution of the UpdateCaseStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateCaseStatus operation on AmazonSecurityIRClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateCaseStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/UpdateCaseStatus">REST API Reference for UpdateCaseStatus Operation</seealso>
        IAsyncResult BeginUpdateCaseStatus(UpdateCaseStatusRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateCaseStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateCaseStatus.</param>
        /// 
        /// <returns>Returns a  UpdateCaseStatusResult from SecurityIR.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/UpdateCaseStatus">REST API Reference for UpdateCaseStatus Operation</seealso>
        UpdateCaseStatusResponse EndUpdateCaseStatus(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateMembership


        /// <summary>
        /// Grants access to UpdateMembership to change membership configuration.
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
        /// Initiates the asynchronous execution of the UpdateMembership operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateMembership operation on AmazonSecurityIRClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateMembership
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/UpdateMembership">REST API Reference for UpdateMembership Operation</seealso>
        IAsyncResult BeginUpdateMembership(UpdateMembershipRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateMembership operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateMembership.</param>
        /// 
        /// <returns>Returns a  UpdateMembershipResult from SecurityIR.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/UpdateMembership">REST API Reference for UpdateMembership Operation</seealso>
        UpdateMembershipResponse EndUpdateMembership(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateResolverType


        /// <summary>
        /// Grants permission to update the resolver type for a case.
        /// 
        ///  <important> 
        /// <para>
        /// This is a one-way action and cannot be reversed.
        /// </para>
        ///  </important> 
        /// <para>
        /// Options include self-supported &gt; AWS-supported.
        /// </para>
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
        /// Initiates the asynchronous execution of the UpdateResolverType operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateResolverType operation on AmazonSecurityIRClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateResolverType
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/UpdateResolverType">REST API Reference for UpdateResolverType Operation</seealso>
        IAsyncResult BeginUpdateResolverType(UpdateResolverTypeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateResolverType operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateResolverType.</param>
        /// 
        /// <returns>Returns a  UpdateResolverTypeResult from SecurityIR.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/UpdateResolverType">REST API Reference for UpdateResolverType Operation</seealso>
        UpdateResolverTypeResponse EndUpdateResolverType(IAsyncResult asyncResult);

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