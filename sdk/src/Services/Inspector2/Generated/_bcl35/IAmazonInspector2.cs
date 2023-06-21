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
 * Do not modify this file. This file is generated from the inspector2-2020-06-08.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.Inspector2.Model;

namespace Amazon.Inspector2
{
    /// <summary>
    /// Interface for accessing Inspector2
    ///
    /// Amazon Inspector is a vulnerability discovery service that automates continuous scanning
    /// for security vulnerabilities within your Amazon EC2 and Amazon ECR environments.
    /// </summary>
    public partial interface IAmazonInspector2 : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IInspector2PaginatorFactory Paginators { get; }
#endif


        
        #region  AssociateMember


        /// <summary>
        /// Associates an Amazon Web Services account with an Amazon Inspector delegated administrator.
        /// An HTTP 200 response indicates the association was successfully started, but doesn’t
        /// indicate whether it was completed. You can check if the association completed by using
        /// <a href="https://docs.aws.amazon.com/inspector/v2/APIReference/API_ListMembers.html">ListMembers</a>
        /// for multiple accounts or <a href="https://docs.aws.amazon.com/inspector/v2/APIReference/API_GetMember.html">GetMembers</a>
        /// for a single account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateMember service method.</param>
        /// 
        /// <returns>The response from the AssociateMember service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/AssociateMember">REST API Reference for AssociateMember Operation</seealso>
        AssociateMemberResponse AssociateMember(AssociateMemberRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateMember operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateMember operation on AmazonInspector2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateMember
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/AssociateMember">REST API Reference for AssociateMember Operation</seealso>
        IAsyncResult BeginAssociateMember(AssociateMemberRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateMember operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateMember.</param>
        /// 
        /// <returns>Returns a  AssociateMemberResult from Inspector2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/AssociateMember">REST API Reference for AssociateMember Operation</seealso>
        AssociateMemberResponse EndAssociateMember(IAsyncResult asyncResult);

        #endregion
        
        #region  BatchGetAccountStatus


        /// <summary>
        /// Retrieves the Amazon Inspector status of multiple Amazon Web Services accounts within
        /// your environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetAccountStatus service method.</param>
        /// 
        /// <returns>The response from the BatchGetAccountStatus service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/BatchGetAccountStatus">REST API Reference for BatchGetAccountStatus Operation</seealso>
        BatchGetAccountStatusResponse BatchGetAccountStatus(BatchGetAccountStatusRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the BatchGetAccountStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchGetAccountStatus operation on AmazonInspector2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchGetAccountStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/BatchGetAccountStatus">REST API Reference for BatchGetAccountStatus Operation</seealso>
        IAsyncResult BeginBatchGetAccountStatus(BatchGetAccountStatusRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BatchGetAccountStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchGetAccountStatus.</param>
        /// 
        /// <returns>Returns a  BatchGetAccountStatusResult from Inspector2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/BatchGetAccountStatus">REST API Reference for BatchGetAccountStatus Operation</seealso>
        BatchGetAccountStatusResponse EndBatchGetAccountStatus(IAsyncResult asyncResult);

        #endregion
        
        #region  BatchGetCodeSnippet


        /// <summary>
        /// Retrieves code snippets from findings that Amazon Inspector detected code vulnerabilities
        /// in.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetCodeSnippet service method.</param>
        /// 
        /// <returns>The response from the BatchGetCodeSnippet service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/BatchGetCodeSnippet">REST API Reference for BatchGetCodeSnippet Operation</seealso>
        BatchGetCodeSnippetResponse BatchGetCodeSnippet(BatchGetCodeSnippetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the BatchGetCodeSnippet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchGetCodeSnippet operation on AmazonInspector2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchGetCodeSnippet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/BatchGetCodeSnippet">REST API Reference for BatchGetCodeSnippet Operation</seealso>
        IAsyncResult BeginBatchGetCodeSnippet(BatchGetCodeSnippetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BatchGetCodeSnippet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchGetCodeSnippet.</param>
        /// 
        /// <returns>Returns a  BatchGetCodeSnippetResult from Inspector2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/BatchGetCodeSnippet">REST API Reference for BatchGetCodeSnippet Operation</seealso>
        BatchGetCodeSnippetResponse EndBatchGetCodeSnippet(IAsyncResult asyncResult);

        #endregion
        
        #region  BatchGetFreeTrialInfo


        /// <summary>
        /// Gets free trial status for multiple Amazon Web Services accounts.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetFreeTrialInfo service method.</param>
        /// 
        /// <returns>The response from the BatchGetFreeTrialInfo service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/BatchGetFreeTrialInfo">REST API Reference for BatchGetFreeTrialInfo Operation</seealso>
        BatchGetFreeTrialInfoResponse BatchGetFreeTrialInfo(BatchGetFreeTrialInfoRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the BatchGetFreeTrialInfo operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchGetFreeTrialInfo operation on AmazonInspector2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchGetFreeTrialInfo
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/BatchGetFreeTrialInfo">REST API Reference for BatchGetFreeTrialInfo Operation</seealso>
        IAsyncResult BeginBatchGetFreeTrialInfo(BatchGetFreeTrialInfoRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BatchGetFreeTrialInfo operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchGetFreeTrialInfo.</param>
        /// 
        /// <returns>Returns a  BatchGetFreeTrialInfoResult from Inspector2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/BatchGetFreeTrialInfo">REST API Reference for BatchGetFreeTrialInfo Operation</seealso>
        BatchGetFreeTrialInfoResponse EndBatchGetFreeTrialInfo(IAsyncResult asyncResult);

        #endregion
        
        #region  BatchGetMemberEc2DeepInspectionStatus


        /// <summary>
        /// Retrieves Amazon Inspector deep inspection activation status of multiple member accounts
        /// within your organization. You must be the delegated administrator of an organization
        /// in Amazon Inspector to use this API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetMemberEc2DeepInspectionStatus service method.</param>
        /// 
        /// <returns>The response from the BatchGetMemberEc2DeepInspectionStatus service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/BatchGetMemberEc2DeepInspectionStatus">REST API Reference for BatchGetMemberEc2DeepInspectionStatus Operation</seealso>
        BatchGetMemberEc2DeepInspectionStatusResponse BatchGetMemberEc2DeepInspectionStatus(BatchGetMemberEc2DeepInspectionStatusRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the BatchGetMemberEc2DeepInspectionStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchGetMemberEc2DeepInspectionStatus operation on AmazonInspector2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchGetMemberEc2DeepInspectionStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/BatchGetMemberEc2DeepInspectionStatus">REST API Reference for BatchGetMemberEc2DeepInspectionStatus Operation</seealso>
        IAsyncResult BeginBatchGetMemberEc2DeepInspectionStatus(BatchGetMemberEc2DeepInspectionStatusRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BatchGetMemberEc2DeepInspectionStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchGetMemberEc2DeepInspectionStatus.</param>
        /// 
        /// <returns>Returns a  BatchGetMemberEc2DeepInspectionStatusResult from Inspector2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/BatchGetMemberEc2DeepInspectionStatus">REST API Reference for BatchGetMemberEc2DeepInspectionStatus Operation</seealso>
        BatchGetMemberEc2DeepInspectionStatusResponse EndBatchGetMemberEc2DeepInspectionStatus(IAsyncResult asyncResult);

        #endregion
        
        #region  BatchUpdateMemberEc2DeepInspectionStatus


        /// <summary>
        /// Activates or deactivates Amazon Inspector deep inspection for the provided member
        /// accounts in your organization. You must be the delegated administrator of an organization
        /// in Amazon Inspector to use this API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchUpdateMemberEc2DeepInspectionStatus service method.</param>
        /// 
        /// <returns>The response from the BatchUpdateMemberEc2DeepInspectionStatus service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/BatchUpdateMemberEc2DeepInspectionStatus">REST API Reference for BatchUpdateMemberEc2DeepInspectionStatus Operation</seealso>
        BatchUpdateMemberEc2DeepInspectionStatusResponse BatchUpdateMemberEc2DeepInspectionStatus(BatchUpdateMemberEc2DeepInspectionStatusRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the BatchUpdateMemberEc2DeepInspectionStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchUpdateMemberEc2DeepInspectionStatus operation on AmazonInspector2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchUpdateMemberEc2DeepInspectionStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/BatchUpdateMemberEc2DeepInspectionStatus">REST API Reference for BatchUpdateMemberEc2DeepInspectionStatus Operation</seealso>
        IAsyncResult BeginBatchUpdateMemberEc2DeepInspectionStatus(BatchUpdateMemberEc2DeepInspectionStatusRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BatchUpdateMemberEc2DeepInspectionStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchUpdateMemberEc2DeepInspectionStatus.</param>
        /// 
        /// <returns>Returns a  BatchUpdateMemberEc2DeepInspectionStatusResult from Inspector2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/BatchUpdateMemberEc2DeepInspectionStatus">REST API Reference for BatchUpdateMemberEc2DeepInspectionStatus Operation</seealso>
        BatchUpdateMemberEc2DeepInspectionStatusResponse EndBatchUpdateMemberEc2DeepInspectionStatus(IAsyncResult asyncResult);

        #endregion
        
        #region  CancelFindingsReport


        /// <summary>
        /// Cancels the given findings report.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelFindingsReport service method.</param>
        /// 
        /// <returns>The response from the CancelFindingsReport service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/CancelFindingsReport">REST API Reference for CancelFindingsReport Operation</seealso>
        CancelFindingsReportResponse CancelFindingsReport(CancelFindingsReportRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CancelFindingsReport operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelFindingsReport operation on AmazonInspector2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelFindingsReport
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/CancelFindingsReport">REST API Reference for CancelFindingsReport Operation</seealso>
        IAsyncResult BeginCancelFindingsReport(CancelFindingsReportRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CancelFindingsReport operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelFindingsReport.</param>
        /// 
        /// <returns>Returns a  CancelFindingsReportResult from Inspector2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/CancelFindingsReport">REST API Reference for CancelFindingsReport Operation</seealso>
        CancelFindingsReportResponse EndCancelFindingsReport(IAsyncResult asyncResult);

        #endregion
        
        #region  CancelSbomExport


        /// <summary>
        /// Cancels a software bill of materials (SBOM) report.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelSbomExport service method.</param>
        /// 
        /// <returns>The response from the CancelSbomExport service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/CancelSbomExport">REST API Reference for CancelSbomExport Operation</seealso>
        CancelSbomExportResponse CancelSbomExport(CancelSbomExportRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CancelSbomExport operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelSbomExport operation on AmazonInspector2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelSbomExport
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/CancelSbomExport">REST API Reference for CancelSbomExport Operation</seealso>
        IAsyncResult BeginCancelSbomExport(CancelSbomExportRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CancelSbomExport operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelSbomExport.</param>
        /// 
        /// <returns>Returns a  CancelSbomExportResult from Inspector2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/CancelSbomExport">REST API Reference for CancelSbomExport Operation</seealso>
        CancelSbomExportResponse EndCancelSbomExport(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateFilter


        /// <summary>
        /// Creates a filter resource using specified filter criteria.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFilter service method.</param>
        /// 
        /// <returns>The response from the CreateFilter service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.BadRequestException">
        /// One or more tags submitted as part of the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ServiceQuotaExceededException">
        /// You have exceeded your service quota. To perform the requested action, remove some
        /// of the relevant resources, or use Service Quotas to request a service quota increase.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/CreateFilter">REST API Reference for CreateFilter Operation</seealso>
        CreateFilterResponse CreateFilter(CreateFilterRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateFilter operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateFilter operation on AmazonInspector2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateFilter
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/CreateFilter">REST API Reference for CreateFilter Operation</seealso>
        IAsyncResult BeginCreateFilter(CreateFilterRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateFilter operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateFilter.</param>
        /// 
        /// <returns>Returns a  CreateFilterResult from Inspector2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/CreateFilter">REST API Reference for CreateFilter Operation</seealso>
        CreateFilterResponse EndCreateFilter(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateFindingsReport


        /// <summary>
        /// Creates a finding report. By default only <code>ACTIVE</code> findings are returned
        /// in the report. To see <code>SUPRESSED</code> or <code>CLOSED</code> findings you must
        /// specify a value for the <code>findingStatus</code> filter criteria.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFindingsReport service method.</param>
        /// 
        /// <returns>The response from the CreateFindingsReport service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/CreateFindingsReport">REST API Reference for CreateFindingsReport Operation</seealso>
        CreateFindingsReportResponse CreateFindingsReport(CreateFindingsReportRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateFindingsReport operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateFindingsReport operation on AmazonInspector2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateFindingsReport
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/CreateFindingsReport">REST API Reference for CreateFindingsReport Operation</seealso>
        IAsyncResult BeginCreateFindingsReport(CreateFindingsReportRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateFindingsReport operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateFindingsReport.</param>
        /// 
        /// <returns>Returns a  CreateFindingsReportResult from Inspector2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/CreateFindingsReport">REST API Reference for CreateFindingsReport Operation</seealso>
        CreateFindingsReportResponse EndCreateFindingsReport(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateSbomExport


        /// <summary>
        /// Creates a software bill of materials (SBOM) report.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSbomExport service method.</param>
        /// 
        /// <returns>The response from the CreateSbomExport service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/CreateSbomExport">REST API Reference for CreateSbomExport Operation</seealso>
        CreateSbomExportResponse CreateSbomExport(CreateSbomExportRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSbomExport operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSbomExport operation on AmazonInspector2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSbomExport
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/CreateSbomExport">REST API Reference for CreateSbomExport Operation</seealso>
        IAsyncResult BeginCreateSbomExport(CreateSbomExportRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSbomExport operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSbomExport.</param>
        /// 
        /// <returns>Returns a  CreateSbomExportResult from Inspector2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/CreateSbomExport">REST API Reference for CreateSbomExport Operation</seealso>
        CreateSbomExportResponse EndCreateSbomExport(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteFilter


        /// <summary>
        /// Deletes a filter resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFilter service method.</param>
        /// 
        /// <returns>The response from the DeleteFilter service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/DeleteFilter">REST API Reference for DeleteFilter Operation</seealso>
        DeleteFilterResponse DeleteFilter(DeleteFilterRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteFilter operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteFilter operation on AmazonInspector2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteFilter
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/DeleteFilter">REST API Reference for DeleteFilter Operation</seealso>
        IAsyncResult BeginDeleteFilter(DeleteFilterRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteFilter operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteFilter.</param>
        /// 
        /// <returns>Returns a  DeleteFilterResult from Inspector2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/DeleteFilter">REST API Reference for DeleteFilter Operation</seealso>
        DeleteFilterResponse EndDeleteFilter(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeOrganizationConfiguration


        /// <summary>
        /// Describe Amazon Inspector configuration settings for an Amazon Web Services organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeOrganizationConfiguration service method.</param>
        /// 
        /// <returns>The response from the DescribeOrganizationConfiguration service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/DescribeOrganizationConfiguration">REST API Reference for DescribeOrganizationConfiguration Operation</seealso>
        DescribeOrganizationConfigurationResponse DescribeOrganizationConfiguration(DescribeOrganizationConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeOrganizationConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeOrganizationConfiguration operation on AmazonInspector2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeOrganizationConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/DescribeOrganizationConfiguration">REST API Reference for DescribeOrganizationConfiguration Operation</seealso>
        IAsyncResult BeginDescribeOrganizationConfiguration(DescribeOrganizationConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeOrganizationConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeOrganizationConfiguration.</param>
        /// 
        /// <returns>Returns a  DescribeOrganizationConfigurationResult from Inspector2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/DescribeOrganizationConfiguration">REST API Reference for DescribeOrganizationConfiguration Operation</seealso>
        DescribeOrganizationConfigurationResponse EndDescribeOrganizationConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  Disable


        /// <summary>
        /// Disables Amazon Inspector scans for one or more Amazon Web Services accounts. Disabling
        /// all scan types in an account disables the Amazon Inspector service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Disable service method.</param>
        /// 
        /// <returns>The response from the Disable service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/Disable">REST API Reference for Disable Operation</seealso>
        DisableResponse Disable(DisableRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the Disable operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the Disable operation on AmazonInspector2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisable
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/Disable">REST API Reference for Disable Operation</seealso>
        IAsyncResult BeginDisable(DisableRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  Disable operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisable.</param>
        /// 
        /// <returns>Returns a  DisableResult from Inspector2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/Disable">REST API Reference for Disable Operation</seealso>
        DisableResponse EndDisable(IAsyncResult asyncResult);

        #endregion
        
        #region  DisableDelegatedAdminAccount


        /// <summary>
        /// Disables the Amazon Inspector delegated administrator for your organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableDelegatedAdminAccount service method.</param>
        /// 
        /// <returns>The response from the DisableDelegatedAdminAccount service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ConflictException">
        /// A conflict occurred.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/DisableDelegatedAdminAccount">REST API Reference for DisableDelegatedAdminAccount Operation</seealso>
        DisableDelegatedAdminAccountResponse DisableDelegatedAdminAccount(DisableDelegatedAdminAccountRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisableDelegatedAdminAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableDelegatedAdminAccount operation on AmazonInspector2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisableDelegatedAdminAccount
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/DisableDelegatedAdminAccount">REST API Reference for DisableDelegatedAdminAccount Operation</seealso>
        IAsyncResult BeginDisableDelegatedAdminAccount(DisableDelegatedAdminAccountRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisableDelegatedAdminAccount operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisableDelegatedAdminAccount.</param>
        /// 
        /// <returns>Returns a  DisableDelegatedAdminAccountResult from Inspector2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/DisableDelegatedAdminAccount">REST API Reference for DisableDelegatedAdminAccount Operation</seealso>
        DisableDelegatedAdminAccountResponse EndDisableDelegatedAdminAccount(IAsyncResult asyncResult);

        #endregion
        
        #region  DisassociateMember


        /// <summary>
        /// Disassociates a member account from an Amazon Inspector delegated administrator.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateMember service method.</param>
        /// 
        /// <returns>The response from the DisassociateMember service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/DisassociateMember">REST API Reference for DisassociateMember Operation</seealso>
        DisassociateMemberResponse DisassociateMember(DisassociateMemberRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateMember operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateMember operation on AmazonInspector2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateMember
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/DisassociateMember">REST API Reference for DisassociateMember Operation</seealso>
        IAsyncResult BeginDisassociateMember(DisassociateMemberRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateMember operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateMember.</param>
        /// 
        /// <returns>Returns a  DisassociateMemberResult from Inspector2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/DisassociateMember">REST API Reference for DisassociateMember Operation</seealso>
        DisassociateMemberResponse EndDisassociateMember(IAsyncResult asyncResult);

        #endregion
        
        #region  Enable


        /// <summary>
        /// Enables Amazon Inspector scans for one or more Amazon Web Services accounts.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Enable service method.</param>
        /// 
        /// <returns>The response from the Enable service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/Enable">REST API Reference for Enable Operation</seealso>
        EnableResponse Enable(EnableRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the Enable operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the Enable operation on AmazonInspector2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndEnable
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/Enable">REST API Reference for Enable Operation</seealso>
        IAsyncResult BeginEnable(EnableRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  Enable operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginEnable.</param>
        /// 
        /// <returns>Returns a  EnableResult from Inspector2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/Enable">REST API Reference for Enable Operation</seealso>
        EnableResponse EndEnable(IAsyncResult asyncResult);

        #endregion
        
        #region  EnableDelegatedAdminAccount


        /// <summary>
        /// Enables the Amazon Inspector delegated administrator for your Organizations organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableDelegatedAdminAccount service method.</param>
        /// 
        /// <returns>The response from the EnableDelegatedAdminAccount service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ConflictException">
        /// A conflict occurred.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/EnableDelegatedAdminAccount">REST API Reference for EnableDelegatedAdminAccount Operation</seealso>
        EnableDelegatedAdminAccountResponse EnableDelegatedAdminAccount(EnableDelegatedAdminAccountRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the EnableDelegatedAdminAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableDelegatedAdminAccount operation on AmazonInspector2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndEnableDelegatedAdminAccount
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/EnableDelegatedAdminAccount">REST API Reference for EnableDelegatedAdminAccount Operation</seealso>
        IAsyncResult BeginEnableDelegatedAdminAccount(EnableDelegatedAdminAccountRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  EnableDelegatedAdminAccount operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginEnableDelegatedAdminAccount.</param>
        /// 
        /// <returns>Returns a  EnableDelegatedAdminAccountResult from Inspector2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/EnableDelegatedAdminAccount">REST API Reference for EnableDelegatedAdminAccount Operation</seealso>
        EnableDelegatedAdminAccountResponse EndEnableDelegatedAdminAccount(IAsyncResult asyncResult);

        #endregion
        
        #region  GetConfiguration


        /// <summary>
        /// Retrieves setting configurations for Inspector scans.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetConfiguration service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/GetConfiguration">REST API Reference for GetConfiguration Operation</seealso>
        GetConfigurationResponse GetConfiguration(GetConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetConfiguration operation on AmazonInspector2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/GetConfiguration">REST API Reference for GetConfiguration Operation</seealso>
        IAsyncResult BeginGetConfiguration(GetConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetConfiguration.</param>
        /// 
        /// <returns>Returns a  GetConfigurationResult from Inspector2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/GetConfiguration">REST API Reference for GetConfiguration Operation</seealso>
        GetConfigurationResponse EndGetConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  GetDelegatedAdminAccount


        /// <summary>
        /// Retrieves information about the Amazon Inspector delegated administrator for your
        /// organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDelegatedAdminAccount service method.</param>
        /// 
        /// <returns>The response from the GetDelegatedAdminAccount service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/GetDelegatedAdminAccount">REST API Reference for GetDelegatedAdminAccount Operation</seealso>
        GetDelegatedAdminAccountResponse GetDelegatedAdminAccount(GetDelegatedAdminAccountRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetDelegatedAdminAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDelegatedAdminAccount operation on AmazonInspector2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDelegatedAdminAccount
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/GetDelegatedAdminAccount">REST API Reference for GetDelegatedAdminAccount Operation</seealso>
        IAsyncResult BeginGetDelegatedAdminAccount(GetDelegatedAdminAccountRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetDelegatedAdminAccount operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDelegatedAdminAccount.</param>
        /// 
        /// <returns>Returns a  GetDelegatedAdminAccountResult from Inspector2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/GetDelegatedAdminAccount">REST API Reference for GetDelegatedAdminAccount Operation</seealso>
        GetDelegatedAdminAccountResponse EndGetDelegatedAdminAccount(IAsyncResult asyncResult);

        #endregion
        
        #region  GetEc2DeepInspectionConfiguration


        /// <summary>
        /// Retrieves the activation status of Amazon Inspector deep inspection and custom paths
        /// associated with your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEc2DeepInspectionConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetEc2DeepInspectionConfiguration service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/GetEc2DeepInspectionConfiguration">REST API Reference for GetEc2DeepInspectionConfiguration Operation</seealso>
        GetEc2DeepInspectionConfigurationResponse GetEc2DeepInspectionConfiguration(GetEc2DeepInspectionConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetEc2DeepInspectionConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetEc2DeepInspectionConfiguration operation on AmazonInspector2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetEc2DeepInspectionConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/GetEc2DeepInspectionConfiguration">REST API Reference for GetEc2DeepInspectionConfiguration Operation</seealso>
        IAsyncResult BeginGetEc2DeepInspectionConfiguration(GetEc2DeepInspectionConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetEc2DeepInspectionConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetEc2DeepInspectionConfiguration.</param>
        /// 
        /// <returns>Returns a  GetEc2DeepInspectionConfigurationResult from Inspector2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/GetEc2DeepInspectionConfiguration">REST API Reference for GetEc2DeepInspectionConfiguration Operation</seealso>
        GetEc2DeepInspectionConfigurationResponse EndGetEc2DeepInspectionConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  GetEncryptionKey


        /// <summary>
        /// Gets an encryption key.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEncryptionKey service method.</param>
        /// 
        /// <returns>The response from the GetEncryptionKey service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/GetEncryptionKey">REST API Reference for GetEncryptionKey Operation</seealso>
        GetEncryptionKeyResponse GetEncryptionKey(GetEncryptionKeyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetEncryptionKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetEncryptionKey operation on AmazonInspector2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetEncryptionKey
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/GetEncryptionKey">REST API Reference for GetEncryptionKey Operation</seealso>
        IAsyncResult BeginGetEncryptionKey(GetEncryptionKeyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetEncryptionKey operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetEncryptionKey.</param>
        /// 
        /// <returns>Returns a  GetEncryptionKeyResult from Inspector2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/GetEncryptionKey">REST API Reference for GetEncryptionKey Operation</seealso>
        GetEncryptionKeyResponse EndGetEncryptionKey(IAsyncResult asyncResult);

        #endregion
        
        #region  GetFindingsReportStatus


        /// <summary>
        /// Gets the status of a findings report.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFindingsReportStatus service method.</param>
        /// 
        /// <returns>The response from the GetFindingsReportStatus service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/GetFindingsReportStatus">REST API Reference for GetFindingsReportStatus Operation</seealso>
        GetFindingsReportStatusResponse GetFindingsReportStatus(GetFindingsReportStatusRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetFindingsReportStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetFindingsReportStatus operation on AmazonInspector2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetFindingsReportStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/GetFindingsReportStatus">REST API Reference for GetFindingsReportStatus Operation</seealso>
        IAsyncResult BeginGetFindingsReportStatus(GetFindingsReportStatusRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetFindingsReportStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetFindingsReportStatus.</param>
        /// 
        /// <returns>Returns a  GetFindingsReportStatusResult from Inspector2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/GetFindingsReportStatus">REST API Reference for GetFindingsReportStatus Operation</seealso>
        GetFindingsReportStatusResponse EndGetFindingsReportStatus(IAsyncResult asyncResult);

        #endregion
        
        #region  GetMember


        /// <summary>
        /// Gets member information for your organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMember service method.</param>
        /// 
        /// <returns>The response from the GetMember service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/GetMember">REST API Reference for GetMember Operation</seealso>
        GetMemberResponse GetMember(GetMemberRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetMember operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMember operation on AmazonInspector2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetMember
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/GetMember">REST API Reference for GetMember Operation</seealso>
        IAsyncResult BeginGetMember(GetMemberRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetMember operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetMember.</param>
        /// 
        /// <returns>Returns a  GetMemberResult from Inspector2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/GetMember">REST API Reference for GetMember Operation</seealso>
        GetMemberResponse EndGetMember(IAsyncResult asyncResult);

        #endregion
        
        #region  GetSbomExport


        /// <summary>
        /// Gets details of a software bill of materials (SBOM) report.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSbomExport service method.</param>
        /// 
        /// <returns>The response from the GetSbomExport service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/GetSbomExport">REST API Reference for GetSbomExport Operation</seealso>
        GetSbomExportResponse GetSbomExport(GetSbomExportRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetSbomExport operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSbomExport operation on AmazonInspector2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSbomExport
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/GetSbomExport">REST API Reference for GetSbomExport Operation</seealso>
        IAsyncResult BeginGetSbomExport(GetSbomExportRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetSbomExport operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSbomExport.</param>
        /// 
        /// <returns>Returns a  GetSbomExportResult from Inspector2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/GetSbomExport">REST API Reference for GetSbomExport Operation</seealso>
        GetSbomExportResponse EndGetSbomExport(IAsyncResult asyncResult);

        #endregion
        
        #region  ListAccountPermissions


        /// <summary>
        /// Lists the permissions an account has to configure Amazon Inspector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAccountPermissions service method.</param>
        /// 
        /// <returns>The response from the ListAccountPermissions service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/ListAccountPermissions">REST API Reference for ListAccountPermissions Operation</seealso>
        ListAccountPermissionsResponse ListAccountPermissions(ListAccountPermissionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListAccountPermissions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAccountPermissions operation on AmazonInspector2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAccountPermissions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/ListAccountPermissions">REST API Reference for ListAccountPermissions Operation</seealso>
        IAsyncResult BeginListAccountPermissions(ListAccountPermissionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAccountPermissions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAccountPermissions.</param>
        /// 
        /// <returns>Returns a  ListAccountPermissionsResult from Inspector2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/ListAccountPermissions">REST API Reference for ListAccountPermissions Operation</seealso>
        ListAccountPermissionsResponse EndListAccountPermissions(IAsyncResult asyncResult);

        #endregion
        
        #region  ListCoverage


        /// <summary>
        /// Lists coverage details for you environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCoverage service method.</param>
        /// 
        /// <returns>The response from the ListCoverage service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/ListCoverage">REST API Reference for ListCoverage Operation</seealso>
        ListCoverageResponse ListCoverage(ListCoverageRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListCoverage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCoverage operation on AmazonInspector2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListCoverage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/ListCoverage">REST API Reference for ListCoverage Operation</seealso>
        IAsyncResult BeginListCoverage(ListCoverageRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListCoverage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCoverage.</param>
        /// 
        /// <returns>Returns a  ListCoverageResult from Inspector2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/ListCoverage">REST API Reference for ListCoverage Operation</seealso>
        ListCoverageResponse EndListCoverage(IAsyncResult asyncResult);

        #endregion
        
        #region  ListCoverageStatistics


        /// <summary>
        /// Lists Amazon Inspector coverage statistics for your environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCoverageStatistics service method.</param>
        /// 
        /// <returns>The response from the ListCoverageStatistics service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/ListCoverageStatistics">REST API Reference for ListCoverageStatistics Operation</seealso>
        ListCoverageStatisticsResponse ListCoverageStatistics(ListCoverageStatisticsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListCoverageStatistics operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCoverageStatistics operation on AmazonInspector2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListCoverageStatistics
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/ListCoverageStatistics">REST API Reference for ListCoverageStatistics Operation</seealso>
        IAsyncResult BeginListCoverageStatistics(ListCoverageStatisticsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListCoverageStatistics operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCoverageStatistics.</param>
        /// 
        /// <returns>Returns a  ListCoverageStatisticsResult from Inspector2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/ListCoverageStatistics">REST API Reference for ListCoverageStatistics Operation</seealso>
        ListCoverageStatisticsResponse EndListCoverageStatistics(IAsyncResult asyncResult);

        #endregion
        
        #region  ListDelegatedAdminAccounts


        /// <summary>
        /// Lists information about the Amazon Inspector delegated administrator of your organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDelegatedAdminAccounts service method.</param>
        /// 
        /// <returns>The response from the ListDelegatedAdminAccounts service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/ListDelegatedAdminAccounts">REST API Reference for ListDelegatedAdminAccounts Operation</seealso>
        ListDelegatedAdminAccountsResponse ListDelegatedAdminAccounts(ListDelegatedAdminAccountsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListDelegatedAdminAccounts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDelegatedAdminAccounts operation on AmazonInspector2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDelegatedAdminAccounts
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/ListDelegatedAdminAccounts">REST API Reference for ListDelegatedAdminAccounts Operation</seealso>
        IAsyncResult BeginListDelegatedAdminAccounts(ListDelegatedAdminAccountsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListDelegatedAdminAccounts operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDelegatedAdminAccounts.</param>
        /// 
        /// <returns>Returns a  ListDelegatedAdminAccountsResult from Inspector2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/ListDelegatedAdminAccounts">REST API Reference for ListDelegatedAdminAccounts Operation</seealso>
        ListDelegatedAdminAccountsResponse EndListDelegatedAdminAccounts(IAsyncResult asyncResult);

        #endregion
        
        #region  ListFilters


        /// <summary>
        /// Lists the filters associated with your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFilters service method.</param>
        /// 
        /// <returns>The response from the ListFilters service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/ListFilters">REST API Reference for ListFilters Operation</seealso>
        ListFiltersResponse ListFilters(ListFiltersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListFilters operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListFilters operation on AmazonInspector2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListFilters
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/ListFilters">REST API Reference for ListFilters Operation</seealso>
        IAsyncResult BeginListFilters(ListFiltersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListFilters operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListFilters.</param>
        /// 
        /// <returns>Returns a  ListFiltersResult from Inspector2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/ListFilters">REST API Reference for ListFilters Operation</seealso>
        ListFiltersResponse EndListFilters(IAsyncResult asyncResult);

        #endregion
        
        #region  ListFindingAggregations


        /// <summary>
        /// Lists aggregated finding data for your environment based on specific criteria.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFindingAggregations service method.</param>
        /// 
        /// <returns>The response from the ListFindingAggregations service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/ListFindingAggregations">REST API Reference for ListFindingAggregations Operation</seealso>
        ListFindingAggregationsResponse ListFindingAggregations(ListFindingAggregationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListFindingAggregations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListFindingAggregations operation on AmazonInspector2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListFindingAggregations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/ListFindingAggregations">REST API Reference for ListFindingAggregations Operation</seealso>
        IAsyncResult BeginListFindingAggregations(ListFindingAggregationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListFindingAggregations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListFindingAggregations.</param>
        /// 
        /// <returns>Returns a  ListFindingAggregationsResult from Inspector2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/ListFindingAggregations">REST API Reference for ListFindingAggregations Operation</seealso>
        ListFindingAggregationsResponse EndListFindingAggregations(IAsyncResult asyncResult);

        #endregion
        
        #region  ListFindings


        /// <summary>
        /// Lists findings for your environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFindings service method.</param>
        /// 
        /// <returns>The response from the ListFindings service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/ListFindings">REST API Reference for ListFindings Operation</seealso>
        ListFindingsResponse ListFindings(ListFindingsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListFindings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListFindings operation on AmazonInspector2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListFindings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/ListFindings">REST API Reference for ListFindings Operation</seealso>
        IAsyncResult BeginListFindings(ListFindingsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListFindings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListFindings.</param>
        /// 
        /// <returns>Returns a  ListFindingsResult from Inspector2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/ListFindings">REST API Reference for ListFindings Operation</seealso>
        ListFindingsResponse EndListFindings(IAsyncResult asyncResult);

        #endregion
        
        #region  ListMembers


        /// <summary>
        /// List members associated with the Amazon Inspector delegated administrator for your
        /// organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMembers service method.</param>
        /// 
        /// <returns>The response from the ListMembers service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/ListMembers">REST API Reference for ListMembers Operation</seealso>
        ListMembersResponse ListMembers(ListMembersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListMembers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMembers operation on AmazonInspector2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListMembers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/ListMembers">REST API Reference for ListMembers Operation</seealso>
        IAsyncResult BeginListMembers(ListMembersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListMembers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListMembers.</param>
        /// 
        /// <returns>Returns a  ListMembersResult from Inspector2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/ListMembers">REST API Reference for ListMembers Operation</seealso>
        ListMembersResponse EndListMembers(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists all tags attached to a given resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonInspector2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from Inspector2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

        #endregion
        
        #region  ListUsageTotals


        /// <summary>
        /// Lists the Amazon Inspector usage totals over the last 30 days.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListUsageTotals service method.</param>
        /// 
        /// <returns>The response from the ListUsageTotals service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/ListUsageTotals">REST API Reference for ListUsageTotals Operation</seealso>
        ListUsageTotalsResponse ListUsageTotals(ListUsageTotalsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListUsageTotals operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListUsageTotals operation on AmazonInspector2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListUsageTotals
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/ListUsageTotals">REST API Reference for ListUsageTotals Operation</seealso>
        IAsyncResult BeginListUsageTotals(ListUsageTotalsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListUsageTotals operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListUsageTotals.</param>
        /// 
        /// <returns>Returns a  ListUsageTotalsResult from Inspector2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/ListUsageTotals">REST API Reference for ListUsageTotals Operation</seealso>
        ListUsageTotalsResponse EndListUsageTotals(IAsyncResult asyncResult);

        #endregion
        
        #region  ResetEncryptionKey


        /// <summary>
        /// Resets an encryption key. After the key is reset your resources will be encrypted
        /// by an Amazon Web Services owned key.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResetEncryptionKey service method.</param>
        /// 
        /// <returns>The response from the ResetEncryptionKey service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/ResetEncryptionKey">REST API Reference for ResetEncryptionKey Operation</seealso>
        ResetEncryptionKeyResponse ResetEncryptionKey(ResetEncryptionKeyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ResetEncryptionKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResetEncryptionKey operation on AmazonInspector2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndResetEncryptionKey
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/ResetEncryptionKey">REST API Reference for ResetEncryptionKey Operation</seealso>
        IAsyncResult BeginResetEncryptionKey(ResetEncryptionKeyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ResetEncryptionKey operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginResetEncryptionKey.</param>
        /// 
        /// <returns>Returns a  ResetEncryptionKeyResult from Inspector2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/ResetEncryptionKey">REST API Reference for ResetEncryptionKey Operation</seealso>
        ResetEncryptionKeyResponse EndResetEncryptionKey(IAsyncResult asyncResult);

        #endregion
        
        #region  SearchVulnerabilities


        /// <summary>
        /// Lists Amazon Inspector coverage details for a specific vulnerability.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchVulnerabilities service method.</param>
        /// 
        /// <returns>The response from the SearchVulnerabilities service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/SearchVulnerabilities">REST API Reference for SearchVulnerabilities Operation</seealso>
        SearchVulnerabilitiesResponse SearchVulnerabilities(SearchVulnerabilitiesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the SearchVulnerabilities operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SearchVulnerabilities operation on AmazonInspector2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSearchVulnerabilities
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/SearchVulnerabilities">REST API Reference for SearchVulnerabilities Operation</seealso>
        IAsyncResult BeginSearchVulnerabilities(SearchVulnerabilitiesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SearchVulnerabilities operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSearchVulnerabilities.</param>
        /// 
        /// <returns>Returns a  SearchVulnerabilitiesResult from Inspector2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/SearchVulnerabilities">REST API Reference for SearchVulnerabilities Operation</seealso>
        SearchVulnerabilitiesResponse EndSearchVulnerabilities(IAsyncResult asyncResult);

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Adds tags to a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.BadRequestException">
        /// One or more tags submitted as part of the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonInspector2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from Inspector2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes tags from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonInspector2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from Inspector2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateConfiguration


        /// <summary>
        /// Updates setting configurations for your Amazon Inspector account. When you use this
        /// API as an Amazon Inspector delegated administrator this updates the setting for all
        /// accounts you manage. Member accounts in an organization cannot update this setting.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateConfiguration service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/UpdateConfiguration">REST API Reference for UpdateConfiguration Operation</seealso>
        UpdateConfigurationResponse UpdateConfiguration(UpdateConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateConfiguration operation on AmazonInspector2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/UpdateConfiguration">REST API Reference for UpdateConfiguration Operation</seealso>
        IAsyncResult BeginUpdateConfiguration(UpdateConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateConfiguration.</param>
        /// 
        /// <returns>Returns a  UpdateConfigurationResult from Inspector2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/UpdateConfiguration">REST API Reference for UpdateConfiguration Operation</seealso>
        UpdateConfigurationResponse EndUpdateConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateEc2DeepInspectionConfiguration


        /// <summary>
        /// Activates, deactivates Amazon Inspector deep inspection, or updates custom paths for
        /// your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEc2DeepInspectionConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateEc2DeepInspectionConfiguration service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/UpdateEc2DeepInspectionConfiguration">REST API Reference for UpdateEc2DeepInspectionConfiguration Operation</seealso>
        UpdateEc2DeepInspectionConfigurationResponse UpdateEc2DeepInspectionConfiguration(UpdateEc2DeepInspectionConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateEc2DeepInspectionConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateEc2DeepInspectionConfiguration operation on AmazonInspector2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateEc2DeepInspectionConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/UpdateEc2DeepInspectionConfiguration">REST API Reference for UpdateEc2DeepInspectionConfiguration Operation</seealso>
        IAsyncResult BeginUpdateEc2DeepInspectionConfiguration(UpdateEc2DeepInspectionConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateEc2DeepInspectionConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateEc2DeepInspectionConfiguration.</param>
        /// 
        /// <returns>Returns a  UpdateEc2DeepInspectionConfigurationResult from Inspector2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/UpdateEc2DeepInspectionConfiguration">REST API Reference for UpdateEc2DeepInspectionConfiguration Operation</seealso>
        UpdateEc2DeepInspectionConfigurationResponse EndUpdateEc2DeepInspectionConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateEncryptionKey


        /// <summary>
        /// Updates an encryption key. A <code>ResourceNotFoundException</code> means that an
        /// AWS owned key is being used for encryption.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEncryptionKey service method.</param>
        /// 
        /// <returns>The response from the UpdateEncryptionKey service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/UpdateEncryptionKey">REST API Reference for UpdateEncryptionKey Operation</seealso>
        UpdateEncryptionKeyResponse UpdateEncryptionKey(UpdateEncryptionKeyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateEncryptionKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateEncryptionKey operation on AmazonInspector2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateEncryptionKey
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/UpdateEncryptionKey">REST API Reference for UpdateEncryptionKey Operation</seealso>
        IAsyncResult BeginUpdateEncryptionKey(UpdateEncryptionKeyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateEncryptionKey operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateEncryptionKey.</param>
        /// 
        /// <returns>Returns a  UpdateEncryptionKeyResult from Inspector2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/UpdateEncryptionKey">REST API Reference for UpdateEncryptionKey Operation</seealso>
        UpdateEncryptionKeyResponse EndUpdateEncryptionKey(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateFilter


        /// <summary>
        /// Specifies the action that is to be applied to the findings that match the filter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFilter service method.</param>
        /// 
        /// <returns>The response from the UpdateFilter service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/UpdateFilter">REST API Reference for UpdateFilter Operation</seealso>
        UpdateFilterResponse UpdateFilter(UpdateFilterRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateFilter operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateFilter operation on AmazonInspector2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateFilter
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/UpdateFilter">REST API Reference for UpdateFilter Operation</seealso>
        IAsyncResult BeginUpdateFilter(UpdateFilterRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateFilter operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateFilter.</param>
        /// 
        /// <returns>Returns a  UpdateFilterResult from Inspector2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/UpdateFilter">REST API Reference for UpdateFilter Operation</seealso>
        UpdateFilterResponse EndUpdateFilter(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateOrganizationConfiguration


        /// <summary>
        /// Updates the configurations for your Amazon Inspector organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateOrganizationConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateOrganizationConfiguration service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/UpdateOrganizationConfiguration">REST API Reference for UpdateOrganizationConfiguration Operation</seealso>
        UpdateOrganizationConfigurationResponse UpdateOrganizationConfiguration(UpdateOrganizationConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateOrganizationConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateOrganizationConfiguration operation on AmazonInspector2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateOrganizationConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/UpdateOrganizationConfiguration">REST API Reference for UpdateOrganizationConfiguration Operation</seealso>
        IAsyncResult BeginUpdateOrganizationConfiguration(UpdateOrganizationConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateOrganizationConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateOrganizationConfiguration.</param>
        /// 
        /// <returns>Returns a  UpdateOrganizationConfigurationResult from Inspector2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/UpdateOrganizationConfiguration">REST API Reference for UpdateOrganizationConfiguration Operation</seealso>
        UpdateOrganizationConfigurationResponse EndUpdateOrganizationConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateOrgEc2DeepInspectionConfiguration


        /// <summary>
        /// Updates the Amazon Inspector deep inspection custom paths for your organization. You
        /// must be an Amazon Inspector delegated administrator to use this API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateOrgEc2DeepInspectionConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateOrgEc2DeepInspectionConfiguration service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/UpdateOrgEc2DeepInspectionConfiguration">REST API Reference for UpdateOrgEc2DeepInspectionConfiguration Operation</seealso>
        UpdateOrgEc2DeepInspectionConfigurationResponse UpdateOrgEc2DeepInspectionConfiguration(UpdateOrgEc2DeepInspectionConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateOrgEc2DeepInspectionConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateOrgEc2DeepInspectionConfiguration operation on AmazonInspector2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateOrgEc2DeepInspectionConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/UpdateOrgEc2DeepInspectionConfiguration">REST API Reference for UpdateOrgEc2DeepInspectionConfiguration Operation</seealso>
        IAsyncResult BeginUpdateOrgEc2DeepInspectionConfiguration(UpdateOrgEc2DeepInspectionConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateOrgEc2DeepInspectionConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateOrgEc2DeepInspectionConfiguration.</param>
        /// 
        /// <returns>Returns a  UpdateOrgEc2DeepInspectionConfigurationResult from Inspector2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/UpdateOrgEc2DeepInspectionConfiguration">REST API Reference for UpdateOrgEc2DeepInspectionConfiguration Operation</seealso>
        UpdateOrgEc2DeepInspectionConfigurationResponse EndUpdateOrgEc2DeepInspectionConfiguration(IAsyncResult asyncResult);

        #endregion
        
    }
}