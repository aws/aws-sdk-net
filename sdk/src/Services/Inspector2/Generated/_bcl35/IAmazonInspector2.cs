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

#pragma warning disable CS1570
namespace Amazon.Inspector2
{
    /// <summary>
    /// <para>Interface for accessing Inspector2</para>
    ///
    /// Amazon Inspector is a vulnerability discovery service that automates continuous scanning
    /// for security vulnerabilities within your Amazon EC2, Amazon ECR, and Amazon Web Services
    /// Lambda environments.
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
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
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
        
        #region  BatchAssociateCodeSecurityScanConfiguration


        /// <summary>
        /// Associates multiple code repositories with an Amazon Inspector code security scan
        /// configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchAssociateCodeSecurityScanConfiguration service method.</param>
        /// 
        /// <returns>The response from the BatchAssociateCodeSecurityScanConfiguration service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ConflictException">
        /// A conflict occurred. This exception occurs when the same resource is being modified
        /// by concurrent requests.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/BatchAssociateCodeSecurityScanConfiguration">REST API Reference for BatchAssociateCodeSecurityScanConfiguration Operation</seealso>
        BatchAssociateCodeSecurityScanConfigurationResponse BatchAssociateCodeSecurityScanConfiguration(BatchAssociateCodeSecurityScanConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the BatchAssociateCodeSecurityScanConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchAssociateCodeSecurityScanConfiguration operation on AmazonInspector2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchAssociateCodeSecurityScanConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/BatchAssociateCodeSecurityScanConfiguration">REST API Reference for BatchAssociateCodeSecurityScanConfiguration Operation</seealso>
        IAsyncResult BeginBatchAssociateCodeSecurityScanConfiguration(BatchAssociateCodeSecurityScanConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BatchAssociateCodeSecurityScanConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchAssociateCodeSecurityScanConfiguration.</param>
        /// 
        /// <returns>Returns a  BatchAssociateCodeSecurityScanConfigurationResult from Inspector2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/BatchAssociateCodeSecurityScanConfiguration">REST API Reference for BatchAssociateCodeSecurityScanConfiguration Operation</seealso>
        BatchAssociateCodeSecurityScanConfigurationResponse EndBatchAssociateCodeSecurityScanConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  BatchDisassociateCodeSecurityScanConfiguration


        /// <summary>
        /// Disassociates multiple code repositories from an Amazon Inspector code security scan
        /// configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDisassociateCodeSecurityScanConfiguration service method.</param>
        /// 
        /// <returns>The response from the BatchDisassociateCodeSecurityScanConfiguration service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ConflictException">
        /// A conflict occurred. This exception occurs when the same resource is being modified
        /// by concurrent requests.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/BatchDisassociateCodeSecurityScanConfiguration">REST API Reference for BatchDisassociateCodeSecurityScanConfiguration Operation</seealso>
        BatchDisassociateCodeSecurityScanConfigurationResponse BatchDisassociateCodeSecurityScanConfiguration(BatchDisassociateCodeSecurityScanConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the BatchDisassociateCodeSecurityScanConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchDisassociateCodeSecurityScanConfiguration operation on AmazonInspector2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchDisassociateCodeSecurityScanConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/BatchDisassociateCodeSecurityScanConfiguration">REST API Reference for BatchDisassociateCodeSecurityScanConfiguration Operation</seealso>
        IAsyncResult BeginBatchDisassociateCodeSecurityScanConfiguration(BatchDisassociateCodeSecurityScanConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BatchDisassociateCodeSecurityScanConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchDisassociateCodeSecurityScanConfiguration.</param>
        /// 
        /// <returns>Returns a  BatchDisassociateCodeSecurityScanConfigurationResult from Inspector2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/BatchDisassociateCodeSecurityScanConfiguration">REST API Reference for BatchDisassociateCodeSecurityScanConfiguration Operation</seealso>
        BatchDisassociateCodeSecurityScanConfigurationResponse EndBatchDisassociateCodeSecurityScanConfiguration(IAsyncResult asyncResult);

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
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
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
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
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
        
        #region  BatchGetFindingDetails


        /// <summary>
        /// Gets vulnerability details for findings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetFindingDetails service method.</param>
        /// 
        /// <returns>The response from the BatchGetFindingDetails service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/BatchGetFindingDetails">REST API Reference for BatchGetFindingDetails Operation</seealso>
        BatchGetFindingDetailsResponse BatchGetFindingDetails(BatchGetFindingDetailsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the BatchGetFindingDetails operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchGetFindingDetails operation on AmazonInspector2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchGetFindingDetails
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/BatchGetFindingDetails">REST API Reference for BatchGetFindingDetails Operation</seealso>
        IAsyncResult BeginBatchGetFindingDetails(BatchGetFindingDetailsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BatchGetFindingDetails operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchGetFindingDetails.</param>
        /// 
        /// <returns>Returns a  BatchGetFindingDetailsResult from Inspector2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/BatchGetFindingDetails">REST API Reference for BatchGetFindingDetails Operation</seealso>
        BatchGetFindingDetailsResponse EndBatchGetFindingDetails(IAsyncResult asyncResult);

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
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
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
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
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
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
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
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
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
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
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
        
        #region  CreateCisScanConfiguration


        /// <summary>
        /// Creates a CIS scan configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCisScanConfiguration service method.</param>
        /// 
        /// <returns>The response from the CreateCisScanConfiguration service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/CreateCisScanConfiguration">REST API Reference for CreateCisScanConfiguration Operation</seealso>
        CreateCisScanConfigurationResponse CreateCisScanConfiguration(CreateCisScanConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCisScanConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCisScanConfiguration operation on AmazonInspector2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateCisScanConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/CreateCisScanConfiguration">REST API Reference for CreateCisScanConfiguration Operation</seealso>
        IAsyncResult BeginCreateCisScanConfiguration(CreateCisScanConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateCisScanConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCisScanConfiguration.</param>
        /// 
        /// <returns>Returns a  CreateCisScanConfigurationResult from Inspector2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/CreateCisScanConfiguration">REST API Reference for CreateCisScanConfiguration Operation</seealso>
        CreateCisScanConfigurationResponse EndCreateCisScanConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateCodeSecurityIntegration


        /// <summary>
        /// Creates a code security integration with a source code repository provider.
        /// 
        ///  
        /// <para>
        /// After calling the <c>CreateCodeSecurityIntegration</c> operation, you complete authentication
        /// and authorization with your provider. Next you call the <c>UpdateCodeSecurityIntegration</c>
        /// operation to provide the <c>details</c> to complete the integration setup
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCodeSecurityIntegration service method.</param>
        /// 
        /// <returns>The response from the CreateCodeSecurityIntegration service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ConflictException">
        /// A conflict occurred. This exception occurs when the same resource is being modified
        /// by concurrent requests.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/CreateCodeSecurityIntegration">REST API Reference for CreateCodeSecurityIntegration Operation</seealso>
        CreateCodeSecurityIntegrationResponse CreateCodeSecurityIntegration(CreateCodeSecurityIntegrationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCodeSecurityIntegration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCodeSecurityIntegration operation on AmazonInspector2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateCodeSecurityIntegration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/CreateCodeSecurityIntegration">REST API Reference for CreateCodeSecurityIntegration Operation</seealso>
        IAsyncResult BeginCreateCodeSecurityIntegration(CreateCodeSecurityIntegrationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateCodeSecurityIntegration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCodeSecurityIntegration.</param>
        /// 
        /// <returns>Returns a  CreateCodeSecurityIntegrationResult from Inspector2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/CreateCodeSecurityIntegration">REST API Reference for CreateCodeSecurityIntegration Operation</seealso>
        CreateCodeSecurityIntegrationResponse EndCreateCodeSecurityIntegration(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateCodeSecurityScanConfiguration


        /// <summary>
        /// Creates a scan configuration for code security scanning.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCodeSecurityScanConfiguration service method.</param>
        /// 
        /// <returns>The response from the CreateCodeSecurityScanConfiguration service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ConflictException">
        /// A conflict occurred. This exception occurs when the same resource is being modified
        /// by concurrent requests.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/CreateCodeSecurityScanConfiguration">REST API Reference for CreateCodeSecurityScanConfiguration Operation</seealso>
        CreateCodeSecurityScanConfigurationResponse CreateCodeSecurityScanConfiguration(CreateCodeSecurityScanConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCodeSecurityScanConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCodeSecurityScanConfiguration operation on AmazonInspector2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateCodeSecurityScanConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/CreateCodeSecurityScanConfiguration">REST API Reference for CreateCodeSecurityScanConfiguration Operation</seealso>
        IAsyncResult BeginCreateCodeSecurityScanConfiguration(CreateCodeSecurityScanConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateCodeSecurityScanConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCodeSecurityScanConfiguration.</param>
        /// 
        /// <returns>Returns a  CreateCodeSecurityScanConfigurationResult from Inspector2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/CreateCodeSecurityScanConfiguration">REST API Reference for CreateCodeSecurityScanConfiguration Operation</seealso>
        CreateCodeSecurityScanConfigurationResponse EndCreateCodeSecurityScanConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateFilter


        /// <summary>
        /// Creates a filter resource using specified filter criteria. When the filter action
        /// is set to <c>SUPPRESS</c> this action creates a suppression rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFilter service method.</param>
        /// 
        /// <returns>The response from the CreateFilter service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
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
        /// Creates a finding report. By default only <c>ACTIVE</c> findings are returned in the
        /// report. To see <c>SUPRESSED</c> or <c>CLOSED</c> findings you must specify a value
        /// for the <c>findingStatus</c> filter criteria.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFindingsReport service method.</param>
        /// 
        /// <returns>The response from the CreateFindingsReport service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
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
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
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
        
        #region  DeleteCisScanConfiguration


        /// <summary>
        /// Deletes a CIS scan configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCisScanConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteCisScanConfiguration service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/DeleteCisScanConfiguration">REST API Reference for DeleteCisScanConfiguration Operation</seealso>
        DeleteCisScanConfigurationResponse DeleteCisScanConfiguration(DeleteCisScanConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCisScanConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCisScanConfiguration operation on AmazonInspector2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteCisScanConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/DeleteCisScanConfiguration">REST API Reference for DeleteCisScanConfiguration Operation</seealso>
        IAsyncResult BeginDeleteCisScanConfiguration(DeleteCisScanConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteCisScanConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCisScanConfiguration.</param>
        /// 
        /// <returns>Returns a  DeleteCisScanConfigurationResult from Inspector2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/DeleteCisScanConfiguration">REST API Reference for DeleteCisScanConfiguration Operation</seealso>
        DeleteCisScanConfigurationResponse EndDeleteCisScanConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteCodeSecurityIntegration


        /// <summary>
        /// Deletes a code security integration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCodeSecurityIntegration service method.</param>
        /// 
        /// <returns>The response from the DeleteCodeSecurityIntegration service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/DeleteCodeSecurityIntegration">REST API Reference for DeleteCodeSecurityIntegration Operation</seealso>
        DeleteCodeSecurityIntegrationResponse DeleteCodeSecurityIntegration(DeleteCodeSecurityIntegrationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCodeSecurityIntegration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCodeSecurityIntegration operation on AmazonInspector2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteCodeSecurityIntegration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/DeleteCodeSecurityIntegration">REST API Reference for DeleteCodeSecurityIntegration Operation</seealso>
        IAsyncResult BeginDeleteCodeSecurityIntegration(DeleteCodeSecurityIntegrationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteCodeSecurityIntegration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCodeSecurityIntegration.</param>
        /// 
        /// <returns>Returns a  DeleteCodeSecurityIntegrationResult from Inspector2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/DeleteCodeSecurityIntegration">REST API Reference for DeleteCodeSecurityIntegration Operation</seealso>
        DeleteCodeSecurityIntegrationResponse EndDeleteCodeSecurityIntegration(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteCodeSecurityScanConfiguration


        /// <summary>
        /// Deletes a code security scan configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCodeSecurityScanConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteCodeSecurityScanConfiguration service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/DeleteCodeSecurityScanConfiguration">REST API Reference for DeleteCodeSecurityScanConfiguration Operation</seealso>
        DeleteCodeSecurityScanConfigurationResponse DeleteCodeSecurityScanConfiguration(DeleteCodeSecurityScanConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCodeSecurityScanConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCodeSecurityScanConfiguration operation on AmazonInspector2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteCodeSecurityScanConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/DeleteCodeSecurityScanConfiguration">REST API Reference for DeleteCodeSecurityScanConfiguration Operation</seealso>
        IAsyncResult BeginDeleteCodeSecurityScanConfiguration(DeleteCodeSecurityScanConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteCodeSecurityScanConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCodeSecurityScanConfiguration.</param>
        /// 
        /// <returns>Returns a  DeleteCodeSecurityScanConfigurationResult from Inspector2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/DeleteCodeSecurityScanConfiguration">REST API Reference for DeleteCodeSecurityScanConfiguration Operation</seealso>
        DeleteCodeSecurityScanConfigurationResponse EndDeleteCodeSecurityScanConfiguration(IAsyncResult asyncResult);

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
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
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
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
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
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
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
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ConflictException">
        /// A conflict occurred. This exception occurs when the same resource is being modified
        /// by concurrent requests.
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
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
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
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
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
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ConflictException">
        /// A conflict occurred. This exception occurs when the same resource is being modified
        /// by concurrent requests.
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
        
        #region  GetCisScanReport


        /// <summary>
        /// Retrieves a CIS scan report.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCisScanReport service method.</param>
        /// 
        /// <returns>The response from the GetCisScanReport service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/GetCisScanReport">REST API Reference for GetCisScanReport Operation</seealso>
        GetCisScanReportResponse GetCisScanReport(GetCisScanReportRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetCisScanReport operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCisScanReport operation on AmazonInspector2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCisScanReport
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/GetCisScanReport">REST API Reference for GetCisScanReport Operation</seealso>
        IAsyncResult BeginGetCisScanReport(GetCisScanReportRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetCisScanReport operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCisScanReport.</param>
        /// 
        /// <returns>Returns a  GetCisScanReportResult from Inspector2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/GetCisScanReport">REST API Reference for GetCisScanReport Operation</seealso>
        GetCisScanReportResponse EndGetCisScanReport(IAsyncResult asyncResult);

        #endregion
        
        #region  GetCisScanResultDetails


        /// <summary>
        /// Retrieves CIS scan result details.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCisScanResultDetails service method.</param>
        /// 
        /// <returns>The response from the GetCisScanResultDetails service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/GetCisScanResultDetails">REST API Reference for GetCisScanResultDetails Operation</seealso>
        GetCisScanResultDetailsResponse GetCisScanResultDetails(GetCisScanResultDetailsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetCisScanResultDetails operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCisScanResultDetails operation on AmazonInspector2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCisScanResultDetails
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/GetCisScanResultDetails">REST API Reference for GetCisScanResultDetails Operation</seealso>
        IAsyncResult BeginGetCisScanResultDetails(GetCisScanResultDetailsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetCisScanResultDetails operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCisScanResultDetails.</param>
        /// 
        /// <returns>Returns a  GetCisScanResultDetailsResult from Inspector2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/GetCisScanResultDetails">REST API Reference for GetCisScanResultDetails Operation</seealso>
        GetCisScanResultDetailsResponse EndGetCisScanResultDetails(IAsyncResult asyncResult);

        #endregion
        
        #region  GetClustersForImage


        /// <summary>
        /// Returns a list of clusters and metadata associated with an image.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetClustersForImage service method.</param>
        /// 
        /// <returns>The response from the GetClustersForImage service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/GetClustersForImage">REST API Reference for GetClustersForImage Operation</seealso>
        GetClustersForImageResponse GetClustersForImage(GetClustersForImageRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetClustersForImage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetClustersForImage operation on AmazonInspector2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetClustersForImage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/GetClustersForImage">REST API Reference for GetClustersForImage Operation</seealso>
        IAsyncResult BeginGetClustersForImage(GetClustersForImageRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetClustersForImage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetClustersForImage.</param>
        /// 
        /// <returns>Returns a  GetClustersForImageResult from Inspector2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/GetClustersForImage">REST API Reference for GetClustersForImage Operation</seealso>
        GetClustersForImageResponse EndGetClustersForImage(IAsyncResult asyncResult);

        #endregion
        
        #region  GetCodeSecurityIntegration


        /// <summary>
        /// Retrieves information about a code security integration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCodeSecurityIntegration service method.</param>
        /// 
        /// <returns>The response from the GetCodeSecurityIntegration service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/GetCodeSecurityIntegration">REST API Reference for GetCodeSecurityIntegration Operation</seealso>
        GetCodeSecurityIntegrationResponse GetCodeSecurityIntegration(GetCodeSecurityIntegrationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetCodeSecurityIntegration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCodeSecurityIntegration operation on AmazonInspector2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCodeSecurityIntegration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/GetCodeSecurityIntegration">REST API Reference for GetCodeSecurityIntegration Operation</seealso>
        IAsyncResult BeginGetCodeSecurityIntegration(GetCodeSecurityIntegrationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetCodeSecurityIntegration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCodeSecurityIntegration.</param>
        /// 
        /// <returns>Returns a  GetCodeSecurityIntegrationResult from Inspector2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/GetCodeSecurityIntegration">REST API Reference for GetCodeSecurityIntegration Operation</seealso>
        GetCodeSecurityIntegrationResponse EndGetCodeSecurityIntegration(IAsyncResult asyncResult);

        #endregion
        
        #region  GetCodeSecurityScan


        /// <summary>
        /// Retrieves information about a specific code security scan.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCodeSecurityScan service method.</param>
        /// 
        /// <returns>The response from the GetCodeSecurityScan service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ConflictException">
        /// A conflict occurred. This exception occurs when the same resource is being modified
        /// by concurrent requests.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/GetCodeSecurityScan">REST API Reference for GetCodeSecurityScan Operation</seealso>
        GetCodeSecurityScanResponse GetCodeSecurityScan(GetCodeSecurityScanRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetCodeSecurityScan operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCodeSecurityScan operation on AmazonInspector2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCodeSecurityScan
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/GetCodeSecurityScan">REST API Reference for GetCodeSecurityScan Operation</seealso>
        IAsyncResult BeginGetCodeSecurityScan(GetCodeSecurityScanRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetCodeSecurityScan operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCodeSecurityScan.</param>
        /// 
        /// <returns>Returns a  GetCodeSecurityScanResult from Inspector2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/GetCodeSecurityScan">REST API Reference for GetCodeSecurityScan Operation</seealso>
        GetCodeSecurityScanResponse EndGetCodeSecurityScan(IAsyncResult asyncResult);

        #endregion
        
        #region  GetCodeSecurityScanConfiguration


        /// <summary>
        /// Retrieves information about a code security scan configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCodeSecurityScanConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetCodeSecurityScanConfiguration service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/GetCodeSecurityScanConfiguration">REST API Reference for GetCodeSecurityScanConfiguration Operation</seealso>
        GetCodeSecurityScanConfigurationResponse GetCodeSecurityScanConfiguration(GetCodeSecurityScanConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetCodeSecurityScanConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCodeSecurityScanConfiguration operation on AmazonInspector2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCodeSecurityScanConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/GetCodeSecurityScanConfiguration">REST API Reference for GetCodeSecurityScanConfiguration Operation</seealso>
        IAsyncResult BeginGetCodeSecurityScanConfiguration(GetCodeSecurityScanConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetCodeSecurityScanConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCodeSecurityScanConfiguration.</param>
        /// 
        /// <returns>Returns a  GetCodeSecurityScanConfigurationResult from Inspector2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/GetCodeSecurityScanConfiguration">REST API Reference for GetCodeSecurityScanConfiguration Operation</seealso>
        GetCodeSecurityScanConfigurationResponse EndGetCodeSecurityScanConfiguration(IAsyncResult asyncResult);

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
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
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
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
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
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
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
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
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
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
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
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
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
        /// Lists the permissions an account has to configure Amazon Inspector. If the account
        /// is a member account or standalone account with resources managed by an Organizations
        /// policy, the operation returns fewer permissions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAccountPermissions service method.</param>
        /// 
        /// <returns>The response from the ListAccountPermissions service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
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
        
        #region  ListCisScanConfigurations


        /// <summary>
        /// Lists CIS scan configurations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCisScanConfigurations service method.</param>
        /// 
        /// <returns>The response from the ListCisScanConfigurations service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/ListCisScanConfigurations">REST API Reference for ListCisScanConfigurations Operation</seealso>
        ListCisScanConfigurationsResponse ListCisScanConfigurations(ListCisScanConfigurationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListCisScanConfigurations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCisScanConfigurations operation on AmazonInspector2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListCisScanConfigurations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/ListCisScanConfigurations">REST API Reference for ListCisScanConfigurations Operation</seealso>
        IAsyncResult BeginListCisScanConfigurations(ListCisScanConfigurationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListCisScanConfigurations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCisScanConfigurations.</param>
        /// 
        /// <returns>Returns a  ListCisScanConfigurationsResult from Inspector2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/ListCisScanConfigurations">REST API Reference for ListCisScanConfigurations Operation</seealso>
        ListCisScanConfigurationsResponse EndListCisScanConfigurations(IAsyncResult asyncResult);

        #endregion
        
        #region  ListCisScanResultsAggregatedByChecks


        /// <summary>
        /// Lists scan results aggregated by checks.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCisScanResultsAggregatedByChecks service method.</param>
        /// 
        /// <returns>The response from the ListCisScanResultsAggregatedByChecks service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/ListCisScanResultsAggregatedByChecks">REST API Reference for ListCisScanResultsAggregatedByChecks Operation</seealso>
        ListCisScanResultsAggregatedByChecksResponse ListCisScanResultsAggregatedByChecks(ListCisScanResultsAggregatedByChecksRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListCisScanResultsAggregatedByChecks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCisScanResultsAggregatedByChecks operation on AmazonInspector2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListCisScanResultsAggregatedByChecks
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/ListCisScanResultsAggregatedByChecks">REST API Reference for ListCisScanResultsAggregatedByChecks Operation</seealso>
        IAsyncResult BeginListCisScanResultsAggregatedByChecks(ListCisScanResultsAggregatedByChecksRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListCisScanResultsAggregatedByChecks operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCisScanResultsAggregatedByChecks.</param>
        /// 
        /// <returns>Returns a  ListCisScanResultsAggregatedByChecksResult from Inspector2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/ListCisScanResultsAggregatedByChecks">REST API Reference for ListCisScanResultsAggregatedByChecks Operation</seealso>
        ListCisScanResultsAggregatedByChecksResponse EndListCisScanResultsAggregatedByChecks(IAsyncResult asyncResult);

        #endregion
        
        #region  ListCisScanResultsAggregatedByTargetResource


        /// <summary>
        /// Lists scan results aggregated by a target resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCisScanResultsAggregatedByTargetResource service method.</param>
        /// 
        /// <returns>The response from the ListCisScanResultsAggregatedByTargetResource service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/ListCisScanResultsAggregatedByTargetResource">REST API Reference for ListCisScanResultsAggregatedByTargetResource Operation</seealso>
        ListCisScanResultsAggregatedByTargetResourceResponse ListCisScanResultsAggregatedByTargetResource(ListCisScanResultsAggregatedByTargetResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListCisScanResultsAggregatedByTargetResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCisScanResultsAggregatedByTargetResource operation on AmazonInspector2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListCisScanResultsAggregatedByTargetResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/ListCisScanResultsAggregatedByTargetResource">REST API Reference for ListCisScanResultsAggregatedByTargetResource Operation</seealso>
        IAsyncResult BeginListCisScanResultsAggregatedByTargetResource(ListCisScanResultsAggregatedByTargetResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListCisScanResultsAggregatedByTargetResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCisScanResultsAggregatedByTargetResource.</param>
        /// 
        /// <returns>Returns a  ListCisScanResultsAggregatedByTargetResourceResult from Inspector2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/ListCisScanResultsAggregatedByTargetResource">REST API Reference for ListCisScanResultsAggregatedByTargetResource Operation</seealso>
        ListCisScanResultsAggregatedByTargetResourceResponse EndListCisScanResultsAggregatedByTargetResource(IAsyncResult asyncResult);

        #endregion
        
        #region  ListCisScans


        /// <summary>
        /// Returns a CIS scan list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCisScans service method.</param>
        /// 
        /// <returns>The response from the ListCisScans service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/ListCisScans">REST API Reference for ListCisScans Operation</seealso>
        ListCisScansResponse ListCisScans(ListCisScansRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListCisScans operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCisScans operation on AmazonInspector2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListCisScans
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/ListCisScans">REST API Reference for ListCisScans Operation</seealso>
        IAsyncResult BeginListCisScans(ListCisScansRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListCisScans operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCisScans.</param>
        /// 
        /// <returns>Returns a  ListCisScansResult from Inspector2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/ListCisScans">REST API Reference for ListCisScans Operation</seealso>
        ListCisScansResponse EndListCisScans(IAsyncResult asyncResult);

        #endregion
        
        #region  ListCodeSecurityIntegrations


        /// <summary>
        /// Lists all code security integrations in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCodeSecurityIntegrations service method.</param>
        /// 
        /// <returns>The response from the ListCodeSecurityIntegrations service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/ListCodeSecurityIntegrations">REST API Reference for ListCodeSecurityIntegrations Operation</seealso>
        ListCodeSecurityIntegrationsResponse ListCodeSecurityIntegrations(ListCodeSecurityIntegrationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListCodeSecurityIntegrations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCodeSecurityIntegrations operation on AmazonInspector2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListCodeSecurityIntegrations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/ListCodeSecurityIntegrations">REST API Reference for ListCodeSecurityIntegrations Operation</seealso>
        IAsyncResult BeginListCodeSecurityIntegrations(ListCodeSecurityIntegrationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListCodeSecurityIntegrations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCodeSecurityIntegrations.</param>
        /// 
        /// <returns>Returns a  ListCodeSecurityIntegrationsResult from Inspector2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/ListCodeSecurityIntegrations">REST API Reference for ListCodeSecurityIntegrations Operation</seealso>
        ListCodeSecurityIntegrationsResponse EndListCodeSecurityIntegrations(IAsyncResult asyncResult);

        #endregion
        
        #region  ListCodeSecurityScanConfigurationAssociations


        /// <summary>
        /// Lists the associations between code repositories and Amazon Inspector code security
        /// scan configurations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCodeSecurityScanConfigurationAssociations service method.</param>
        /// 
        /// <returns>The response from the ListCodeSecurityScanConfigurationAssociations service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/ListCodeSecurityScanConfigurationAssociations">REST API Reference for ListCodeSecurityScanConfigurationAssociations Operation</seealso>
        ListCodeSecurityScanConfigurationAssociationsResponse ListCodeSecurityScanConfigurationAssociations(ListCodeSecurityScanConfigurationAssociationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListCodeSecurityScanConfigurationAssociations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCodeSecurityScanConfigurationAssociations operation on AmazonInspector2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListCodeSecurityScanConfigurationAssociations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/ListCodeSecurityScanConfigurationAssociations">REST API Reference for ListCodeSecurityScanConfigurationAssociations Operation</seealso>
        IAsyncResult BeginListCodeSecurityScanConfigurationAssociations(ListCodeSecurityScanConfigurationAssociationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListCodeSecurityScanConfigurationAssociations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCodeSecurityScanConfigurationAssociations.</param>
        /// 
        /// <returns>Returns a  ListCodeSecurityScanConfigurationAssociationsResult from Inspector2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/ListCodeSecurityScanConfigurationAssociations">REST API Reference for ListCodeSecurityScanConfigurationAssociations Operation</seealso>
        ListCodeSecurityScanConfigurationAssociationsResponse EndListCodeSecurityScanConfigurationAssociations(IAsyncResult asyncResult);

        #endregion
        
        #region  ListCodeSecurityScanConfigurations


        /// <summary>
        /// Lists all code security scan configurations in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCodeSecurityScanConfigurations service method.</param>
        /// 
        /// <returns>The response from the ListCodeSecurityScanConfigurations service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/ListCodeSecurityScanConfigurations">REST API Reference for ListCodeSecurityScanConfigurations Operation</seealso>
        ListCodeSecurityScanConfigurationsResponse ListCodeSecurityScanConfigurations(ListCodeSecurityScanConfigurationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListCodeSecurityScanConfigurations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCodeSecurityScanConfigurations operation on AmazonInspector2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListCodeSecurityScanConfigurations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/ListCodeSecurityScanConfigurations">REST API Reference for ListCodeSecurityScanConfigurations Operation</seealso>
        IAsyncResult BeginListCodeSecurityScanConfigurations(ListCodeSecurityScanConfigurationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListCodeSecurityScanConfigurations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCodeSecurityScanConfigurations.</param>
        /// 
        /// <returns>Returns a  ListCodeSecurityScanConfigurationsResult from Inspector2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/ListCodeSecurityScanConfigurations">REST API Reference for ListCodeSecurityScanConfigurations Operation</seealso>
        ListCodeSecurityScanConfigurationsResponse EndListCodeSecurityScanConfigurations(IAsyncResult asyncResult);

        #endregion
        
        #region  ListCoverage


        /// <summary>
        /// Lists coverage details for your environment.
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
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
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
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
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
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
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
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
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
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
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
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
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
        
        #region  SendCisSessionHealth


        /// <summary>
        /// Sends a CIS session health. This API is used by the Amazon Inspector SSM plugin to
        /// communicate with the Amazon Inspector service. The Amazon Inspector SSM plugin calls
        /// this API to start a CIS scan session for the scan ID supplied by the service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendCisSessionHealth service method.</param>
        /// 
        /// <returns>The response from the SendCisSessionHealth service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ConflictException">
        /// A conflict occurred. This exception occurs when the same resource is being modified
        /// by concurrent requests.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/SendCisSessionHealth">REST API Reference for SendCisSessionHealth Operation</seealso>
        SendCisSessionHealthResponse SendCisSessionHealth(SendCisSessionHealthRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the SendCisSessionHealth operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SendCisSessionHealth operation on AmazonInspector2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSendCisSessionHealth
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/SendCisSessionHealth">REST API Reference for SendCisSessionHealth Operation</seealso>
        IAsyncResult BeginSendCisSessionHealth(SendCisSessionHealthRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SendCisSessionHealth operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSendCisSessionHealth.</param>
        /// 
        /// <returns>Returns a  SendCisSessionHealthResult from Inspector2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/SendCisSessionHealth">REST API Reference for SendCisSessionHealth Operation</seealso>
        SendCisSessionHealthResponse EndSendCisSessionHealth(IAsyncResult asyncResult);

        #endregion
        
        #region  SendCisSessionTelemetry


        /// <summary>
        /// Sends a CIS session telemetry. This API is used by the Amazon Inspector SSM plugin
        /// to communicate with the Amazon Inspector service. The Amazon Inspector SSM plugin
        /// calls this API to start a CIS scan session for the scan ID supplied by the service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendCisSessionTelemetry service method.</param>
        /// 
        /// <returns>The response from the SendCisSessionTelemetry service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ConflictException">
        /// A conflict occurred. This exception occurs when the same resource is being modified
        /// by concurrent requests.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/SendCisSessionTelemetry">REST API Reference for SendCisSessionTelemetry Operation</seealso>
        SendCisSessionTelemetryResponse SendCisSessionTelemetry(SendCisSessionTelemetryRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the SendCisSessionTelemetry operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SendCisSessionTelemetry operation on AmazonInspector2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSendCisSessionTelemetry
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/SendCisSessionTelemetry">REST API Reference for SendCisSessionTelemetry Operation</seealso>
        IAsyncResult BeginSendCisSessionTelemetry(SendCisSessionTelemetryRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SendCisSessionTelemetry operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSendCisSessionTelemetry.</param>
        /// 
        /// <returns>Returns a  SendCisSessionTelemetryResult from Inspector2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/SendCisSessionTelemetry">REST API Reference for SendCisSessionTelemetry Operation</seealso>
        SendCisSessionTelemetryResponse EndSendCisSessionTelemetry(IAsyncResult asyncResult);

        #endregion
        
        #region  StartCisSession


        /// <summary>
        /// Starts a CIS session. This API is used by the Amazon Inspector SSM plugin to communicate
        /// with the Amazon Inspector service. The Amazon Inspector SSM plugin calls this API
        /// to start a CIS scan session for the scan ID supplied by the service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartCisSession service method.</param>
        /// 
        /// <returns>The response from the StartCisSession service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ConflictException">
        /// A conflict occurred. This exception occurs when the same resource is being modified
        /// by concurrent requests.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/StartCisSession">REST API Reference for StartCisSession Operation</seealso>
        StartCisSessionResponse StartCisSession(StartCisSessionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartCisSession operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartCisSession operation on AmazonInspector2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartCisSession
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/StartCisSession">REST API Reference for StartCisSession Operation</seealso>
        IAsyncResult BeginStartCisSession(StartCisSessionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartCisSession operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartCisSession.</param>
        /// 
        /// <returns>Returns a  StartCisSessionResult from Inspector2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/StartCisSession">REST API Reference for StartCisSession Operation</seealso>
        StartCisSessionResponse EndStartCisSession(IAsyncResult asyncResult);

        #endregion
        
        #region  StartCodeSecurityScan


        /// <summary>
        /// Initiates a code security scan on a specified repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartCodeSecurityScan service method.</param>
        /// 
        /// <returns>The response from the StartCodeSecurityScan service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ConflictException">
        /// A conflict occurred. This exception occurs when the same resource is being modified
        /// by concurrent requests.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/StartCodeSecurityScan">REST API Reference for StartCodeSecurityScan Operation</seealso>
        StartCodeSecurityScanResponse StartCodeSecurityScan(StartCodeSecurityScanRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartCodeSecurityScan operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartCodeSecurityScan operation on AmazonInspector2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartCodeSecurityScan
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/StartCodeSecurityScan">REST API Reference for StartCodeSecurityScan Operation</seealso>
        IAsyncResult BeginStartCodeSecurityScan(StartCodeSecurityScanRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartCodeSecurityScan operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartCodeSecurityScan.</param>
        /// 
        /// <returns>Returns a  StartCodeSecurityScanResult from Inspector2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/StartCodeSecurityScan">REST API Reference for StartCodeSecurityScan Operation</seealso>
        StartCodeSecurityScanResponse EndStartCodeSecurityScan(IAsyncResult asyncResult);

        #endregion
        
        #region  StopCisSession


        /// <summary>
        /// Stops a CIS session. This API is used by the Amazon Inspector SSM plugin to communicate
        /// with the Amazon Inspector service. The Amazon Inspector SSM plugin calls this API
        /// to stop a CIS scan session for the scan ID supplied by the service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopCisSession service method.</param>
        /// 
        /// <returns>The response from the StopCisSession service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ConflictException">
        /// A conflict occurred. This exception occurs when the same resource is being modified
        /// by concurrent requests.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/StopCisSession">REST API Reference for StopCisSession Operation</seealso>
        StopCisSessionResponse StopCisSession(StopCisSessionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StopCisSession operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopCisSession operation on AmazonInspector2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopCisSession
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/StopCisSession">REST API Reference for StopCisSession Operation</seealso>
        IAsyncResult BeginStopCisSession(StopCisSessionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StopCisSession operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopCisSession.</param>
        /// 
        /// <returns>Returns a  StopCisSessionResult from Inspector2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/StopCisSession">REST API Reference for StopCisSession Operation</seealso>
        StopCisSessionResponse EndStopCisSession(IAsyncResult asyncResult);

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
        
        #region  UpdateCisScanConfiguration


        /// <summary>
        /// Updates a CIS scan configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCisScanConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateCisScanConfiguration service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/UpdateCisScanConfiguration">REST API Reference for UpdateCisScanConfiguration Operation</seealso>
        UpdateCisScanConfigurationResponse UpdateCisScanConfiguration(UpdateCisScanConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateCisScanConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateCisScanConfiguration operation on AmazonInspector2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateCisScanConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/UpdateCisScanConfiguration">REST API Reference for UpdateCisScanConfiguration Operation</seealso>
        IAsyncResult BeginUpdateCisScanConfiguration(UpdateCisScanConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateCisScanConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateCisScanConfiguration.</param>
        /// 
        /// <returns>Returns a  UpdateCisScanConfigurationResult from Inspector2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/UpdateCisScanConfiguration">REST API Reference for UpdateCisScanConfiguration Operation</seealso>
        UpdateCisScanConfigurationResponse EndUpdateCisScanConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateCodeSecurityIntegration


        /// <summary>
        /// Updates an existing code security integration.
        /// 
        ///  
        /// <para>
        /// After calling the <c>CreateCodeSecurityIntegration</c> operation, you complete authentication
        /// and authorization with your provider. Next you call the <c>UpdateCodeSecurityIntegration</c>
        /// operation to provide the <c>details</c> to complete the integration setup
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCodeSecurityIntegration service method.</param>
        /// 
        /// <returns>The response from the UpdateCodeSecurityIntegration service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ConflictException">
        /// A conflict occurred. This exception occurs when the same resource is being modified
        /// by concurrent requests.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/UpdateCodeSecurityIntegration">REST API Reference for UpdateCodeSecurityIntegration Operation</seealso>
        UpdateCodeSecurityIntegrationResponse UpdateCodeSecurityIntegration(UpdateCodeSecurityIntegrationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateCodeSecurityIntegration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateCodeSecurityIntegration operation on AmazonInspector2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateCodeSecurityIntegration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/UpdateCodeSecurityIntegration">REST API Reference for UpdateCodeSecurityIntegration Operation</seealso>
        IAsyncResult BeginUpdateCodeSecurityIntegration(UpdateCodeSecurityIntegrationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateCodeSecurityIntegration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateCodeSecurityIntegration.</param>
        /// 
        /// <returns>Returns a  UpdateCodeSecurityIntegrationResult from Inspector2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/UpdateCodeSecurityIntegration">REST API Reference for UpdateCodeSecurityIntegration Operation</seealso>
        UpdateCodeSecurityIntegrationResponse EndUpdateCodeSecurityIntegration(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateCodeSecurityScanConfiguration


        /// <summary>
        /// Updates an existing code security scan configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCodeSecurityScanConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateCodeSecurityScanConfiguration service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ConflictException">
        /// A conflict occurred. This exception occurs when the same resource is being modified
        /// by concurrent requests.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/UpdateCodeSecurityScanConfiguration">REST API Reference for UpdateCodeSecurityScanConfiguration Operation</seealso>
        UpdateCodeSecurityScanConfigurationResponse UpdateCodeSecurityScanConfiguration(UpdateCodeSecurityScanConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateCodeSecurityScanConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateCodeSecurityScanConfiguration operation on AmazonInspector2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateCodeSecurityScanConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/UpdateCodeSecurityScanConfiguration">REST API Reference for UpdateCodeSecurityScanConfiguration Operation</seealso>
        IAsyncResult BeginUpdateCodeSecurityScanConfiguration(UpdateCodeSecurityScanConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateCodeSecurityScanConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateCodeSecurityScanConfiguration.</param>
        /// 
        /// <returns>Returns a  UpdateCodeSecurityScanConfigurationResult from Inspector2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/UpdateCodeSecurityScanConfiguration">REST API Reference for UpdateCodeSecurityScanConfiguration Operation</seealso>
        UpdateCodeSecurityScanConfigurationResponse EndUpdateCodeSecurityScanConfiguration(IAsyncResult asyncResult);

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
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
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
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
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
        /// Updates an encryption key. A <c>ResourceNotFoundException</c> means that an Amazon
        /// Web Services owned key is being used for encryption.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEncryptionKey service method.</param>
        /// 
        /// <returns>The response from the UpdateEncryptionKey service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
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
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
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
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
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
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
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