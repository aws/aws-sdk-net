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
 * Do not modify this file. This file is generated from the auditmanager-2017-07-25.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.AuditManager.Model;

namespace Amazon.AuditManager
{
    /// <summary>
    /// Interface for accessing AuditManager
    ///
    /// Welcome to the AWS Audit Manager API reference. This guide is for developers who need
    /// detailed information about the AWS Audit Manager API operations, data types, and errors.
    /// 
    /// 
    ///  
    /// <para>
    /// AWS Audit Manager is a service that provides automated evidence collection so that
    /// you can continuously audit your AWS usage, and assess the effectiveness of your controls
    /// to better manage risk and simplify compliance.
    /// </para>
    ///  
    /// <para>
    /// AWS Audit Manager provides pre-built frameworks that structure and automate assessments
    /// for a given compliance standard. Frameworks include a pre-built collection of controls
    /// with descriptions and testing procedures, which are grouped according to the requirements
    /// of the specified compliance standard or regulation. You can also customize frameworks
    /// and controls to support internal audits with unique requirements. 
    /// </para>
    ///  
    /// <para>
    /// Use the following links to get started with the AWS Audit Manager API:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/audit-manager/latest/APIReference/API_Operations.html">Actions</a>:
    /// An alphabetical list of all AWS Audit Manager API operations.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/audit-manager/latest/APIReference/API_Types.html">Data
    /// types</a>: An alphabetical list of all AWS Audit Manager data types.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/audit-manager/latest/APIReference/CommonParameters.html">Common
    /// parameters</a>: Parameters that all Query operations can use.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/audit-manager/latest/APIReference/CommonErrors.html">Common
    /// errors</a>: Client and server errors that all operations can return.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// If you're new to AWS Audit Manager, we recommend that you review the <a href="https://docs.aws.amazon.com/audit-manager/latest/userguide/what-is.html">
    /// AWS Audit Manager User Guide</a>.
    /// </para>
    /// </summary>
    public partial interface IAmazonAuditManager : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IAuditManagerPaginatorFactory Paginators { get; }
#endif


        
        #region  AssociateAssessmentReportEvidenceFolder


        /// <summary>
        /// Associates an evidence folder to the specified assessment report in AWS Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateAssessmentReportEvidenceFolder service method.</param>
        /// 
        /// <returns>The response from the AssociateAssessmentReportEvidenceFolder service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/AssociateAssessmentReportEvidenceFolder">REST API Reference for AssociateAssessmentReportEvidenceFolder Operation</seealso>
        AssociateAssessmentReportEvidenceFolderResponse AssociateAssessmentReportEvidenceFolder(AssociateAssessmentReportEvidenceFolderRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateAssessmentReportEvidenceFolder operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateAssessmentReportEvidenceFolder operation on AmazonAuditManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateAssessmentReportEvidenceFolder
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/AssociateAssessmentReportEvidenceFolder">REST API Reference for AssociateAssessmentReportEvidenceFolder Operation</seealso>
        IAsyncResult BeginAssociateAssessmentReportEvidenceFolder(AssociateAssessmentReportEvidenceFolderRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateAssessmentReportEvidenceFolder operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateAssessmentReportEvidenceFolder.</param>
        /// 
        /// <returns>Returns a  AssociateAssessmentReportEvidenceFolderResult from AuditManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/AssociateAssessmentReportEvidenceFolder">REST API Reference for AssociateAssessmentReportEvidenceFolder Operation</seealso>
        AssociateAssessmentReportEvidenceFolderResponse EndAssociateAssessmentReportEvidenceFolder(IAsyncResult asyncResult);

        #endregion
        
        #region  BatchAssociateAssessmentReportEvidence


        /// <summary>
        /// Associates a list of evidence to an assessment report in an AWS Audit Manager assessment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchAssociateAssessmentReportEvidence service method.</param>
        /// 
        /// <returns>The response from the BatchAssociateAssessmentReportEvidence service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/BatchAssociateAssessmentReportEvidence">REST API Reference for BatchAssociateAssessmentReportEvidence Operation</seealso>
        BatchAssociateAssessmentReportEvidenceResponse BatchAssociateAssessmentReportEvidence(BatchAssociateAssessmentReportEvidenceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the BatchAssociateAssessmentReportEvidence operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchAssociateAssessmentReportEvidence operation on AmazonAuditManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchAssociateAssessmentReportEvidence
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/BatchAssociateAssessmentReportEvidence">REST API Reference for BatchAssociateAssessmentReportEvidence Operation</seealso>
        IAsyncResult BeginBatchAssociateAssessmentReportEvidence(BatchAssociateAssessmentReportEvidenceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BatchAssociateAssessmentReportEvidence operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchAssociateAssessmentReportEvidence.</param>
        /// 
        /// <returns>Returns a  BatchAssociateAssessmentReportEvidenceResult from AuditManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/BatchAssociateAssessmentReportEvidence">REST API Reference for BatchAssociateAssessmentReportEvidence Operation</seealso>
        BatchAssociateAssessmentReportEvidenceResponse EndBatchAssociateAssessmentReportEvidence(IAsyncResult asyncResult);

        #endregion
        
        #region  BatchCreateDelegationByAssessment


        /// <summary>
        /// Create a batch of delegations for a specified assessment in AWS Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchCreateDelegationByAssessment service method.</param>
        /// 
        /// <returns>The response from the BatchCreateDelegationByAssessment service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/BatchCreateDelegationByAssessment">REST API Reference for BatchCreateDelegationByAssessment Operation</seealso>
        BatchCreateDelegationByAssessmentResponse BatchCreateDelegationByAssessment(BatchCreateDelegationByAssessmentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the BatchCreateDelegationByAssessment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchCreateDelegationByAssessment operation on AmazonAuditManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchCreateDelegationByAssessment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/BatchCreateDelegationByAssessment">REST API Reference for BatchCreateDelegationByAssessment Operation</seealso>
        IAsyncResult BeginBatchCreateDelegationByAssessment(BatchCreateDelegationByAssessmentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BatchCreateDelegationByAssessment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchCreateDelegationByAssessment.</param>
        /// 
        /// <returns>Returns a  BatchCreateDelegationByAssessmentResult from AuditManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/BatchCreateDelegationByAssessment">REST API Reference for BatchCreateDelegationByAssessment Operation</seealso>
        BatchCreateDelegationByAssessmentResponse EndBatchCreateDelegationByAssessment(IAsyncResult asyncResult);

        #endregion
        
        #region  BatchDeleteDelegationByAssessment


        /// <summary>
        /// Deletes the delegations in the specified AWS Audit Manager assessment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteDelegationByAssessment service method.</param>
        /// 
        /// <returns>The response from the BatchDeleteDelegationByAssessment service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/BatchDeleteDelegationByAssessment">REST API Reference for BatchDeleteDelegationByAssessment Operation</seealso>
        BatchDeleteDelegationByAssessmentResponse BatchDeleteDelegationByAssessment(BatchDeleteDelegationByAssessmentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the BatchDeleteDelegationByAssessment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteDelegationByAssessment operation on AmazonAuditManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchDeleteDelegationByAssessment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/BatchDeleteDelegationByAssessment">REST API Reference for BatchDeleteDelegationByAssessment Operation</seealso>
        IAsyncResult BeginBatchDeleteDelegationByAssessment(BatchDeleteDelegationByAssessmentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BatchDeleteDelegationByAssessment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchDeleteDelegationByAssessment.</param>
        /// 
        /// <returns>Returns a  BatchDeleteDelegationByAssessmentResult from AuditManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/BatchDeleteDelegationByAssessment">REST API Reference for BatchDeleteDelegationByAssessment Operation</seealso>
        BatchDeleteDelegationByAssessmentResponse EndBatchDeleteDelegationByAssessment(IAsyncResult asyncResult);

        #endregion
        
        #region  BatchDisassociateAssessmentReportEvidence


        /// <summary>
        /// Disassociates a list of evidence from the specified assessment report in AWS Audit
        /// Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDisassociateAssessmentReportEvidence service method.</param>
        /// 
        /// <returns>The response from the BatchDisassociateAssessmentReportEvidence service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/BatchDisassociateAssessmentReportEvidence">REST API Reference for BatchDisassociateAssessmentReportEvidence Operation</seealso>
        BatchDisassociateAssessmentReportEvidenceResponse BatchDisassociateAssessmentReportEvidence(BatchDisassociateAssessmentReportEvidenceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the BatchDisassociateAssessmentReportEvidence operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchDisassociateAssessmentReportEvidence operation on AmazonAuditManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchDisassociateAssessmentReportEvidence
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/BatchDisassociateAssessmentReportEvidence">REST API Reference for BatchDisassociateAssessmentReportEvidence Operation</seealso>
        IAsyncResult BeginBatchDisassociateAssessmentReportEvidence(BatchDisassociateAssessmentReportEvidenceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BatchDisassociateAssessmentReportEvidence operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchDisassociateAssessmentReportEvidence.</param>
        /// 
        /// <returns>Returns a  BatchDisassociateAssessmentReportEvidenceResult from AuditManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/BatchDisassociateAssessmentReportEvidence">REST API Reference for BatchDisassociateAssessmentReportEvidence Operation</seealso>
        BatchDisassociateAssessmentReportEvidenceResponse EndBatchDisassociateAssessmentReportEvidence(IAsyncResult asyncResult);

        #endregion
        
        #region  BatchImportEvidenceToAssessmentControl


        /// <summary>
        /// Uploads one or more pieces of evidence to the specified control in the assessment
        /// in AWS Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchImportEvidenceToAssessmentControl service method.</param>
        /// 
        /// <returns>The response from the BatchImportEvidenceToAssessmentControl service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/BatchImportEvidenceToAssessmentControl">REST API Reference for BatchImportEvidenceToAssessmentControl Operation</seealso>
        BatchImportEvidenceToAssessmentControlResponse BatchImportEvidenceToAssessmentControl(BatchImportEvidenceToAssessmentControlRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the BatchImportEvidenceToAssessmentControl operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchImportEvidenceToAssessmentControl operation on AmazonAuditManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchImportEvidenceToAssessmentControl
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/BatchImportEvidenceToAssessmentControl">REST API Reference for BatchImportEvidenceToAssessmentControl Operation</seealso>
        IAsyncResult BeginBatchImportEvidenceToAssessmentControl(BatchImportEvidenceToAssessmentControlRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BatchImportEvidenceToAssessmentControl operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchImportEvidenceToAssessmentControl.</param>
        /// 
        /// <returns>Returns a  BatchImportEvidenceToAssessmentControlResult from AuditManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/BatchImportEvidenceToAssessmentControl">REST API Reference for BatchImportEvidenceToAssessmentControl Operation</seealso>
        BatchImportEvidenceToAssessmentControlResponse EndBatchImportEvidenceToAssessmentControl(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateAssessment


        /// <summary>
        /// Creates an assessment in AWS Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAssessment service method.</param>
        /// 
        /// <returns>The response from the CreateAssessment service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/CreateAssessment">REST API Reference for CreateAssessment Operation</seealso>
        CreateAssessmentResponse CreateAssessment(CreateAssessmentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAssessment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAssessment operation on AmazonAuditManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAssessment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/CreateAssessment">REST API Reference for CreateAssessment Operation</seealso>
        IAsyncResult BeginCreateAssessment(CreateAssessmentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAssessment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAssessment.</param>
        /// 
        /// <returns>Returns a  CreateAssessmentResult from AuditManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/CreateAssessment">REST API Reference for CreateAssessment Operation</seealso>
        CreateAssessmentResponse EndCreateAssessment(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateAssessmentFramework


        /// <summary>
        /// Creates a custom framework in AWS Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAssessmentFramework service method.</param>
        /// 
        /// <returns>The response from the CreateAssessmentFramework service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/CreateAssessmentFramework">REST API Reference for CreateAssessmentFramework Operation</seealso>
        CreateAssessmentFrameworkResponse CreateAssessmentFramework(CreateAssessmentFrameworkRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAssessmentFramework operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAssessmentFramework operation on AmazonAuditManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAssessmentFramework
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/CreateAssessmentFramework">REST API Reference for CreateAssessmentFramework Operation</seealso>
        IAsyncResult BeginCreateAssessmentFramework(CreateAssessmentFrameworkRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAssessmentFramework operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAssessmentFramework.</param>
        /// 
        /// <returns>Returns a  CreateAssessmentFrameworkResult from AuditManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/CreateAssessmentFramework">REST API Reference for CreateAssessmentFramework Operation</seealso>
        CreateAssessmentFrameworkResponse EndCreateAssessmentFramework(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateAssessmentReport


        /// <summary>
        /// Creates an assessment report for the specified assessment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAssessmentReport service method.</param>
        /// 
        /// <returns>The response from the CreateAssessmentReport service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/CreateAssessmentReport">REST API Reference for CreateAssessmentReport Operation</seealso>
        CreateAssessmentReportResponse CreateAssessmentReport(CreateAssessmentReportRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAssessmentReport operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAssessmentReport operation on AmazonAuditManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAssessmentReport
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/CreateAssessmentReport">REST API Reference for CreateAssessmentReport Operation</seealso>
        IAsyncResult BeginCreateAssessmentReport(CreateAssessmentReportRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAssessmentReport operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAssessmentReport.</param>
        /// 
        /// <returns>Returns a  CreateAssessmentReportResult from AuditManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/CreateAssessmentReport">REST API Reference for CreateAssessmentReport Operation</seealso>
        CreateAssessmentReportResponse EndCreateAssessmentReport(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateControl


        /// <summary>
        /// Creates a new custom control in AWS Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateControl service method.</param>
        /// 
        /// <returns>The response from the CreateControl service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/CreateControl">REST API Reference for CreateControl Operation</seealso>
        CreateControlResponse CreateControl(CreateControlRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateControl operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateControl operation on AmazonAuditManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateControl
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/CreateControl">REST API Reference for CreateControl Operation</seealso>
        IAsyncResult BeginCreateControl(CreateControlRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateControl operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateControl.</param>
        /// 
        /// <returns>Returns a  CreateControlResult from AuditManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/CreateControl">REST API Reference for CreateControl Operation</seealso>
        CreateControlResponse EndCreateControl(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteAssessment


        /// <summary>
        /// Deletes an assessment in AWS Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAssessment service method.</param>
        /// 
        /// <returns>The response from the DeleteAssessment service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/DeleteAssessment">REST API Reference for DeleteAssessment Operation</seealso>
        DeleteAssessmentResponse DeleteAssessment(DeleteAssessmentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAssessment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAssessment operation on AmazonAuditManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAssessment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/DeleteAssessment">REST API Reference for DeleteAssessment Operation</seealso>
        IAsyncResult BeginDeleteAssessment(DeleteAssessmentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAssessment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAssessment.</param>
        /// 
        /// <returns>Returns a  DeleteAssessmentResult from AuditManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/DeleteAssessment">REST API Reference for DeleteAssessment Operation</seealso>
        DeleteAssessmentResponse EndDeleteAssessment(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteAssessmentFramework


        /// <summary>
        /// Deletes a custom framework in AWS Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAssessmentFramework service method.</param>
        /// 
        /// <returns>The response from the DeleteAssessmentFramework service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/DeleteAssessmentFramework">REST API Reference for DeleteAssessmentFramework Operation</seealso>
        DeleteAssessmentFrameworkResponse DeleteAssessmentFramework(DeleteAssessmentFrameworkRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAssessmentFramework operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAssessmentFramework operation on AmazonAuditManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAssessmentFramework
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/DeleteAssessmentFramework">REST API Reference for DeleteAssessmentFramework Operation</seealso>
        IAsyncResult BeginDeleteAssessmentFramework(DeleteAssessmentFrameworkRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAssessmentFramework operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAssessmentFramework.</param>
        /// 
        /// <returns>Returns a  DeleteAssessmentFrameworkResult from AuditManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/DeleteAssessmentFramework">REST API Reference for DeleteAssessmentFramework Operation</seealso>
        DeleteAssessmentFrameworkResponse EndDeleteAssessmentFramework(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteAssessmentReport


        /// <summary>
        /// Deletes an assessment report from an assessment in AWS Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAssessmentReport service method.</param>
        /// 
        /// <returns>The response from the DeleteAssessmentReport service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/DeleteAssessmentReport">REST API Reference for DeleteAssessmentReport Operation</seealso>
        DeleteAssessmentReportResponse DeleteAssessmentReport(DeleteAssessmentReportRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAssessmentReport operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAssessmentReport operation on AmazonAuditManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAssessmentReport
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/DeleteAssessmentReport">REST API Reference for DeleteAssessmentReport Operation</seealso>
        IAsyncResult BeginDeleteAssessmentReport(DeleteAssessmentReportRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAssessmentReport operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAssessmentReport.</param>
        /// 
        /// <returns>Returns a  DeleteAssessmentReportResult from AuditManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/DeleteAssessmentReport">REST API Reference for DeleteAssessmentReport Operation</seealso>
        DeleteAssessmentReportResponse EndDeleteAssessmentReport(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteControl


        /// <summary>
        /// Deletes a custom control in AWS Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteControl service method.</param>
        /// 
        /// <returns>The response from the DeleteControl service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/DeleteControl">REST API Reference for DeleteControl Operation</seealso>
        DeleteControlResponse DeleteControl(DeleteControlRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteControl operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteControl operation on AmazonAuditManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteControl
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/DeleteControl">REST API Reference for DeleteControl Operation</seealso>
        IAsyncResult BeginDeleteControl(DeleteControlRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteControl operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteControl.</param>
        /// 
        /// <returns>Returns a  DeleteControlResult from AuditManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/DeleteControl">REST API Reference for DeleteControl Operation</seealso>
        DeleteControlResponse EndDeleteControl(IAsyncResult asyncResult);

        #endregion
        
        #region  DeregisterAccount


        /// <summary>
        /// Deregisters an account in AWS Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterAccount service method.</param>
        /// 
        /// <returns>The response from the DeregisterAccount service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/DeregisterAccount">REST API Reference for DeregisterAccount Operation</seealso>
        DeregisterAccountResponse DeregisterAccount(DeregisterAccountRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeregisterAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeregisterAccount operation on AmazonAuditManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeregisterAccount
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/DeregisterAccount">REST API Reference for DeregisterAccount Operation</seealso>
        IAsyncResult BeginDeregisterAccount(DeregisterAccountRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeregisterAccount operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeregisterAccount.</param>
        /// 
        /// <returns>Returns a  DeregisterAccountResult from AuditManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/DeregisterAccount">REST API Reference for DeregisterAccount Operation</seealso>
        DeregisterAccountResponse EndDeregisterAccount(IAsyncResult asyncResult);

        #endregion
        
        #region  DeregisterOrganizationAdminAccount


        /// <summary>
        /// Deregisters the delegated AWS administrator account from the AWS organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterOrganizationAdminAccount service method.</param>
        /// 
        /// <returns>The response from the DeregisterOrganizationAdminAccount service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/DeregisterOrganizationAdminAccount">REST API Reference for DeregisterOrganizationAdminAccount Operation</seealso>
        DeregisterOrganizationAdminAccountResponse DeregisterOrganizationAdminAccount(DeregisterOrganizationAdminAccountRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeregisterOrganizationAdminAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeregisterOrganizationAdminAccount operation on AmazonAuditManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeregisterOrganizationAdminAccount
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/DeregisterOrganizationAdminAccount">REST API Reference for DeregisterOrganizationAdminAccount Operation</seealso>
        IAsyncResult BeginDeregisterOrganizationAdminAccount(DeregisterOrganizationAdminAccountRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeregisterOrganizationAdminAccount operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeregisterOrganizationAdminAccount.</param>
        /// 
        /// <returns>Returns a  DeregisterOrganizationAdminAccountResult from AuditManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/DeregisterOrganizationAdminAccount">REST API Reference for DeregisterOrganizationAdminAccount Operation</seealso>
        DeregisterOrganizationAdminAccountResponse EndDeregisterOrganizationAdminAccount(IAsyncResult asyncResult);

        #endregion
        
        #region  DisassociateAssessmentReportEvidenceFolder


        /// <summary>
        /// Disassociates an evidence folder from the specified assessment report in AWS Audit
        /// Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateAssessmentReportEvidenceFolder service method.</param>
        /// 
        /// <returns>The response from the DisassociateAssessmentReportEvidenceFolder service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/DisassociateAssessmentReportEvidenceFolder">REST API Reference for DisassociateAssessmentReportEvidenceFolder Operation</seealso>
        DisassociateAssessmentReportEvidenceFolderResponse DisassociateAssessmentReportEvidenceFolder(DisassociateAssessmentReportEvidenceFolderRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateAssessmentReportEvidenceFolder operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateAssessmentReportEvidenceFolder operation on AmazonAuditManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateAssessmentReportEvidenceFolder
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/DisassociateAssessmentReportEvidenceFolder">REST API Reference for DisassociateAssessmentReportEvidenceFolder Operation</seealso>
        IAsyncResult BeginDisassociateAssessmentReportEvidenceFolder(DisassociateAssessmentReportEvidenceFolderRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateAssessmentReportEvidenceFolder operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateAssessmentReportEvidenceFolder.</param>
        /// 
        /// <returns>Returns a  DisassociateAssessmentReportEvidenceFolderResult from AuditManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/DisassociateAssessmentReportEvidenceFolder">REST API Reference for DisassociateAssessmentReportEvidenceFolder Operation</seealso>
        DisassociateAssessmentReportEvidenceFolderResponse EndDisassociateAssessmentReportEvidenceFolder(IAsyncResult asyncResult);

        #endregion
        
        #region  GetAccountStatus


        /// <summary>
        /// Returns the registration status of an account in AWS Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccountStatus service method.</param>
        /// 
        /// <returns>The response from the GetAccountStatus service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/GetAccountStatus">REST API Reference for GetAccountStatus Operation</seealso>
        GetAccountStatusResponse GetAccountStatus(GetAccountStatusRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetAccountStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAccountStatus operation on AmazonAuditManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAccountStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/GetAccountStatus">REST API Reference for GetAccountStatus Operation</seealso>
        IAsyncResult BeginGetAccountStatus(GetAccountStatusRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetAccountStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAccountStatus.</param>
        /// 
        /// <returns>Returns a  GetAccountStatusResult from AuditManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/GetAccountStatus">REST API Reference for GetAccountStatus Operation</seealso>
        GetAccountStatusResponse EndGetAccountStatus(IAsyncResult asyncResult);

        #endregion
        
        #region  GetAssessment


        /// <summary>
        /// Returns an assessment from AWS Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAssessment service method.</param>
        /// 
        /// <returns>The response from the GetAssessment service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/GetAssessment">REST API Reference for GetAssessment Operation</seealso>
        GetAssessmentResponse GetAssessment(GetAssessmentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetAssessment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAssessment operation on AmazonAuditManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAssessment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/GetAssessment">REST API Reference for GetAssessment Operation</seealso>
        IAsyncResult BeginGetAssessment(GetAssessmentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetAssessment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAssessment.</param>
        /// 
        /// <returns>Returns a  GetAssessmentResult from AuditManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/GetAssessment">REST API Reference for GetAssessment Operation</seealso>
        GetAssessmentResponse EndGetAssessment(IAsyncResult asyncResult);

        #endregion
        
        #region  GetAssessmentFramework


        /// <summary>
        /// Returns a framework from AWS Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAssessmentFramework service method.</param>
        /// 
        /// <returns>The response from the GetAssessmentFramework service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/GetAssessmentFramework">REST API Reference for GetAssessmentFramework Operation</seealso>
        GetAssessmentFrameworkResponse GetAssessmentFramework(GetAssessmentFrameworkRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetAssessmentFramework operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAssessmentFramework operation on AmazonAuditManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAssessmentFramework
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/GetAssessmentFramework">REST API Reference for GetAssessmentFramework Operation</seealso>
        IAsyncResult BeginGetAssessmentFramework(GetAssessmentFrameworkRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetAssessmentFramework operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAssessmentFramework.</param>
        /// 
        /// <returns>Returns a  GetAssessmentFrameworkResult from AuditManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/GetAssessmentFramework">REST API Reference for GetAssessmentFramework Operation</seealso>
        GetAssessmentFrameworkResponse EndGetAssessmentFramework(IAsyncResult asyncResult);

        #endregion
        
        #region  GetAssessmentReportUrl


        /// <summary>
        /// Returns the URL of a specified assessment report in AWS Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAssessmentReportUrl service method.</param>
        /// 
        /// <returns>The response from the GetAssessmentReportUrl service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/GetAssessmentReportUrl">REST API Reference for GetAssessmentReportUrl Operation</seealso>
        GetAssessmentReportUrlResponse GetAssessmentReportUrl(GetAssessmentReportUrlRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetAssessmentReportUrl operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAssessmentReportUrl operation on AmazonAuditManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAssessmentReportUrl
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/GetAssessmentReportUrl">REST API Reference for GetAssessmentReportUrl Operation</seealso>
        IAsyncResult BeginGetAssessmentReportUrl(GetAssessmentReportUrlRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetAssessmentReportUrl operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAssessmentReportUrl.</param>
        /// 
        /// <returns>Returns a  GetAssessmentReportUrlResult from AuditManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/GetAssessmentReportUrl">REST API Reference for GetAssessmentReportUrl Operation</seealso>
        GetAssessmentReportUrlResponse EndGetAssessmentReportUrl(IAsyncResult asyncResult);

        #endregion
        
        #region  GetChangeLogs


        /// <summary>
        /// Returns a list of changelogs from AWS Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetChangeLogs service method.</param>
        /// 
        /// <returns>The response from the GetChangeLogs service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/GetChangeLogs">REST API Reference for GetChangeLogs Operation</seealso>
        GetChangeLogsResponse GetChangeLogs(GetChangeLogsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetChangeLogs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetChangeLogs operation on AmazonAuditManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetChangeLogs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/GetChangeLogs">REST API Reference for GetChangeLogs Operation</seealso>
        IAsyncResult BeginGetChangeLogs(GetChangeLogsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetChangeLogs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetChangeLogs.</param>
        /// 
        /// <returns>Returns a  GetChangeLogsResult from AuditManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/GetChangeLogs">REST API Reference for GetChangeLogs Operation</seealso>
        GetChangeLogsResponse EndGetChangeLogs(IAsyncResult asyncResult);

        #endregion
        
        #region  GetControl


        /// <summary>
        /// Returns a control from AWS Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetControl service method.</param>
        /// 
        /// <returns>The response from the GetControl service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/GetControl">REST API Reference for GetControl Operation</seealso>
        GetControlResponse GetControl(GetControlRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetControl operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetControl operation on AmazonAuditManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetControl
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/GetControl">REST API Reference for GetControl Operation</seealso>
        IAsyncResult BeginGetControl(GetControlRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetControl operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetControl.</param>
        /// 
        /// <returns>Returns a  GetControlResult from AuditManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/GetControl">REST API Reference for GetControl Operation</seealso>
        GetControlResponse EndGetControl(IAsyncResult asyncResult);

        #endregion
        
        #region  GetDelegations


        /// <summary>
        /// Returns a list of delegations from an audit owner to a delegate.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDelegations service method.</param>
        /// 
        /// <returns>The response from the GetDelegations service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/GetDelegations">REST API Reference for GetDelegations Operation</seealso>
        GetDelegationsResponse GetDelegations(GetDelegationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetDelegations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDelegations operation on AmazonAuditManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDelegations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/GetDelegations">REST API Reference for GetDelegations Operation</seealso>
        IAsyncResult BeginGetDelegations(GetDelegationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetDelegations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDelegations.</param>
        /// 
        /// <returns>Returns a  GetDelegationsResult from AuditManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/GetDelegations">REST API Reference for GetDelegations Operation</seealso>
        GetDelegationsResponse EndGetDelegations(IAsyncResult asyncResult);

        #endregion
        
        #region  GetEvidence


        /// <summary>
        /// Returns evidence from AWS Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEvidence service method.</param>
        /// 
        /// <returns>The response from the GetEvidence service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/GetEvidence">REST API Reference for GetEvidence Operation</seealso>
        GetEvidenceResponse GetEvidence(GetEvidenceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetEvidence operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetEvidence operation on AmazonAuditManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetEvidence
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/GetEvidence">REST API Reference for GetEvidence Operation</seealso>
        IAsyncResult BeginGetEvidence(GetEvidenceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetEvidence operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetEvidence.</param>
        /// 
        /// <returns>Returns a  GetEvidenceResult from AuditManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/GetEvidence">REST API Reference for GetEvidence Operation</seealso>
        GetEvidenceResponse EndGetEvidence(IAsyncResult asyncResult);

        #endregion
        
        #region  GetEvidenceByEvidenceFolder


        /// <summary>
        /// Returns all evidence from a specified evidence folder in AWS Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEvidenceByEvidenceFolder service method.</param>
        /// 
        /// <returns>The response from the GetEvidenceByEvidenceFolder service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/GetEvidenceByEvidenceFolder">REST API Reference for GetEvidenceByEvidenceFolder Operation</seealso>
        GetEvidenceByEvidenceFolderResponse GetEvidenceByEvidenceFolder(GetEvidenceByEvidenceFolderRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetEvidenceByEvidenceFolder operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetEvidenceByEvidenceFolder operation on AmazonAuditManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetEvidenceByEvidenceFolder
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/GetEvidenceByEvidenceFolder">REST API Reference for GetEvidenceByEvidenceFolder Operation</seealso>
        IAsyncResult BeginGetEvidenceByEvidenceFolder(GetEvidenceByEvidenceFolderRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetEvidenceByEvidenceFolder operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetEvidenceByEvidenceFolder.</param>
        /// 
        /// <returns>Returns a  GetEvidenceByEvidenceFolderResult from AuditManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/GetEvidenceByEvidenceFolder">REST API Reference for GetEvidenceByEvidenceFolder Operation</seealso>
        GetEvidenceByEvidenceFolderResponse EndGetEvidenceByEvidenceFolder(IAsyncResult asyncResult);

        #endregion
        
        #region  GetEvidenceFolder


        /// <summary>
        /// Returns an evidence folder from the specified assessment in AWS Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEvidenceFolder service method.</param>
        /// 
        /// <returns>The response from the GetEvidenceFolder service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/GetEvidenceFolder">REST API Reference for GetEvidenceFolder Operation</seealso>
        GetEvidenceFolderResponse GetEvidenceFolder(GetEvidenceFolderRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetEvidenceFolder operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetEvidenceFolder operation on AmazonAuditManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetEvidenceFolder
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/GetEvidenceFolder">REST API Reference for GetEvidenceFolder Operation</seealso>
        IAsyncResult BeginGetEvidenceFolder(GetEvidenceFolderRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetEvidenceFolder operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetEvidenceFolder.</param>
        /// 
        /// <returns>Returns a  GetEvidenceFolderResult from AuditManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/GetEvidenceFolder">REST API Reference for GetEvidenceFolder Operation</seealso>
        GetEvidenceFolderResponse EndGetEvidenceFolder(IAsyncResult asyncResult);

        #endregion
        
        #region  GetEvidenceFoldersByAssessment


        /// <summary>
        /// Returns the evidence folders from a specified assessment in AWS Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEvidenceFoldersByAssessment service method.</param>
        /// 
        /// <returns>The response from the GetEvidenceFoldersByAssessment service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/GetEvidenceFoldersByAssessment">REST API Reference for GetEvidenceFoldersByAssessment Operation</seealso>
        GetEvidenceFoldersByAssessmentResponse GetEvidenceFoldersByAssessment(GetEvidenceFoldersByAssessmentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetEvidenceFoldersByAssessment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetEvidenceFoldersByAssessment operation on AmazonAuditManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetEvidenceFoldersByAssessment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/GetEvidenceFoldersByAssessment">REST API Reference for GetEvidenceFoldersByAssessment Operation</seealso>
        IAsyncResult BeginGetEvidenceFoldersByAssessment(GetEvidenceFoldersByAssessmentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetEvidenceFoldersByAssessment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetEvidenceFoldersByAssessment.</param>
        /// 
        /// <returns>Returns a  GetEvidenceFoldersByAssessmentResult from AuditManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/GetEvidenceFoldersByAssessment">REST API Reference for GetEvidenceFoldersByAssessment Operation</seealso>
        GetEvidenceFoldersByAssessmentResponse EndGetEvidenceFoldersByAssessment(IAsyncResult asyncResult);

        #endregion
        
        #region  GetEvidenceFoldersByAssessmentControl


        /// <summary>
        /// Returns a list of evidence folders associated with a specified control of an assessment
        /// in AWS Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEvidenceFoldersByAssessmentControl service method.</param>
        /// 
        /// <returns>The response from the GetEvidenceFoldersByAssessmentControl service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/GetEvidenceFoldersByAssessmentControl">REST API Reference for GetEvidenceFoldersByAssessmentControl Operation</seealso>
        GetEvidenceFoldersByAssessmentControlResponse GetEvidenceFoldersByAssessmentControl(GetEvidenceFoldersByAssessmentControlRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetEvidenceFoldersByAssessmentControl operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetEvidenceFoldersByAssessmentControl operation on AmazonAuditManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetEvidenceFoldersByAssessmentControl
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/GetEvidenceFoldersByAssessmentControl">REST API Reference for GetEvidenceFoldersByAssessmentControl Operation</seealso>
        IAsyncResult BeginGetEvidenceFoldersByAssessmentControl(GetEvidenceFoldersByAssessmentControlRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetEvidenceFoldersByAssessmentControl operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetEvidenceFoldersByAssessmentControl.</param>
        /// 
        /// <returns>Returns a  GetEvidenceFoldersByAssessmentControlResult from AuditManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/GetEvidenceFoldersByAssessmentControl">REST API Reference for GetEvidenceFoldersByAssessmentControl Operation</seealso>
        GetEvidenceFoldersByAssessmentControlResponse EndGetEvidenceFoldersByAssessmentControl(IAsyncResult asyncResult);

        #endregion
        
        #region  GetOrganizationAdminAccount


        /// <summary>
        /// Returns the name of the delegated AWS administrator account for the AWS organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOrganizationAdminAccount service method.</param>
        /// 
        /// <returns>The response from the GetOrganizationAdminAccount service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/GetOrganizationAdminAccount">REST API Reference for GetOrganizationAdminAccount Operation</seealso>
        GetOrganizationAdminAccountResponse GetOrganizationAdminAccount(GetOrganizationAdminAccountRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetOrganizationAdminAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetOrganizationAdminAccount operation on AmazonAuditManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetOrganizationAdminAccount
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/GetOrganizationAdminAccount">REST API Reference for GetOrganizationAdminAccount Operation</seealso>
        IAsyncResult BeginGetOrganizationAdminAccount(GetOrganizationAdminAccountRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetOrganizationAdminAccount operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetOrganizationAdminAccount.</param>
        /// 
        /// <returns>Returns a  GetOrganizationAdminAccountResult from AuditManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/GetOrganizationAdminAccount">REST API Reference for GetOrganizationAdminAccount Operation</seealso>
        GetOrganizationAdminAccountResponse EndGetOrganizationAdminAccount(IAsyncResult asyncResult);

        #endregion
        
        #region  GetServicesInScope


        /// <summary>
        /// Returns a list of the in-scope AWS services for the specified assessment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetServicesInScope service method.</param>
        /// 
        /// <returns>The response from the GetServicesInScope service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/GetServicesInScope">REST API Reference for GetServicesInScope Operation</seealso>
        GetServicesInScopeResponse GetServicesInScope(GetServicesInScopeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetServicesInScope operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetServicesInScope operation on AmazonAuditManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetServicesInScope
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/GetServicesInScope">REST API Reference for GetServicesInScope Operation</seealso>
        IAsyncResult BeginGetServicesInScope(GetServicesInScopeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetServicesInScope operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetServicesInScope.</param>
        /// 
        /// <returns>Returns a  GetServicesInScopeResult from AuditManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/GetServicesInScope">REST API Reference for GetServicesInScope Operation</seealso>
        GetServicesInScopeResponse EndGetServicesInScope(IAsyncResult asyncResult);

        #endregion
        
        #region  GetSettings


        /// <summary>
        /// Returns the settings for the specified AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSettings service method.</param>
        /// 
        /// <returns>The response from the GetSettings service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/GetSettings">REST API Reference for GetSettings Operation</seealso>
        GetSettingsResponse GetSettings(GetSettingsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSettings operation on AmazonAuditManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/GetSettings">REST API Reference for GetSettings Operation</seealso>
        IAsyncResult BeginGetSettings(GetSettingsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSettings.</param>
        /// 
        /// <returns>Returns a  GetSettingsResult from AuditManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/GetSettings">REST API Reference for GetSettings Operation</seealso>
        GetSettingsResponse EndGetSettings(IAsyncResult asyncResult);

        #endregion
        
        #region  ListAssessmentFrameworks


        /// <summary>
        /// Returns a list of the frameworks available in the AWS Audit Manager framework library.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssessmentFrameworks service method.</param>
        /// 
        /// <returns>The response from the ListAssessmentFrameworks service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/ListAssessmentFrameworks">REST API Reference for ListAssessmentFrameworks Operation</seealso>
        ListAssessmentFrameworksResponse ListAssessmentFrameworks(ListAssessmentFrameworksRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListAssessmentFrameworks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAssessmentFrameworks operation on AmazonAuditManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAssessmentFrameworks
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/ListAssessmentFrameworks">REST API Reference for ListAssessmentFrameworks Operation</seealso>
        IAsyncResult BeginListAssessmentFrameworks(ListAssessmentFrameworksRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAssessmentFrameworks operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAssessmentFrameworks.</param>
        /// 
        /// <returns>Returns a  ListAssessmentFrameworksResult from AuditManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/ListAssessmentFrameworks">REST API Reference for ListAssessmentFrameworks Operation</seealso>
        ListAssessmentFrameworksResponse EndListAssessmentFrameworks(IAsyncResult asyncResult);

        #endregion
        
        #region  ListAssessmentReports


        /// <summary>
        /// Returns a list of assessment reports created in AWS Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssessmentReports service method.</param>
        /// 
        /// <returns>The response from the ListAssessmentReports service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/ListAssessmentReports">REST API Reference for ListAssessmentReports Operation</seealso>
        ListAssessmentReportsResponse ListAssessmentReports(ListAssessmentReportsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListAssessmentReports operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAssessmentReports operation on AmazonAuditManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAssessmentReports
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/ListAssessmentReports">REST API Reference for ListAssessmentReports Operation</seealso>
        IAsyncResult BeginListAssessmentReports(ListAssessmentReportsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAssessmentReports operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAssessmentReports.</param>
        /// 
        /// <returns>Returns a  ListAssessmentReportsResult from AuditManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/ListAssessmentReports">REST API Reference for ListAssessmentReports Operation</seealso>
        ListAssessmentReportsResponse EndListAssessmentReports(IAsyncResult asyncResult);

        #endregion
        
        #region  ListAssessments


        /// <summary>
        /// Returns a list of current and past assessments from AWS Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssessments service method.</param>
        /// 
        /// <returns>The response from the ListAssessments service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/ListAssessments">REST API Reference for ListAssessments Operation</seealso>
        ListAssessmentsResponse ListAssessments(ListAssessmentsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListAssessments operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAssessments operation on AmazonAuditManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAssessments
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/ListAssessments">REST API Reference for ListAssessments Operation</seealso>
        IAsyncResult BeginListAssessments(ListAssessmentsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAssessments operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAssessments.</param>
        /// 
        /// <returns>Returns a  ListAssessmentsResult from AuditManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/ListAssessments">REST API Reference for ListAssessments Operation</seealso>
        ListAssessmentsResponse EndListAssessments(IAsyncResult asyncResult);

        #endregion
        
        #region  ListControls


        /// <summary>
        /// Returns a list of controls from AWS Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListControls service method.</param>
        /// 
        /// <returns>The response from the ListControls service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/ListControls">REST API Reference for ListControls Operation</seealso>
        ListControlsResponse ListControls(ListControlsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListControls operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListControls operation on AmazonAuditManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListControls
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/ListControls">REST API Reference for ListControls Operation</seealso>
        IAsyncResult BeginListControls(ListControlsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListControls operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListControls.</param>
        /// 
        /// <returns>Returns a  ListControlsResult from AuditManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/ListControls">REST API Reference for ListControls Operation</seealso>
        ListControlsResponse EndListControls(IAsyncResult asyncResult);

        #endregion
        
        #region  ListKeywordsForDataSource


        /// <summary>
        /// Returns a list of keywords that pre-mapped to the specified control data source.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListKeywordsForDataSource service method.</param>
        /// 
        /// <returns>The response from the ListKeywordsForDataSource service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/ListKeywordsForDataSource">REST API Reference for ListKeywordsForDataSource Operation</seealso>
        ListKeywordsForDataSourceResponse ListKeywordsForDataSource(ListKeywordsForDataSourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListKeywordsForDataSource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListKeywordsForDataSource operation on AmazonAuditManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListKeywordsForDataSource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/ListKeywordsForDataSource">REST API Reference for ListKeywordsForDataSource Operation</seealso>
        IAsyncResult BeginListKeywordsForDataSource(ListKeywordsForDataSourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListKeywordsForDataSource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListKeywordsForDataSource.</param>
        /// 
        /// <returns>Returns a  ListKeywordsForDataSourceResult from AuditManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/ListKeywordsForDataSource">REST API Reference for ListKeywordsForDataSource Operation</seealso>
        ListKeywordsForDataSourceResponse EndListKeywordsForDataSource(IAsyncResult asyncResult);

        #endregion
        
        #region  ListNotifications


        /// <summary>
        /// Returns a list of all AWS Audit Manager notifications.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNotifications service method.</param>
        /// 
        /// <returns>The response from the ListNotifications service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/ListNotifications">REST API Reference for ListNotifications Operation</seealso>
        ListNotificationsResponse ListNotifications(ListNotificationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListNotifications operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListNotifications operation on AmazonAuditManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListNotifications
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/ListNotifications">REST API Reference for ListNotifications Operation</seealso>
        IAsyncResult BeginListNotifications(ListNotificationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListNotifications operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListNotifications.</param>
        /// 
        /// <returns>Returns a  ListNotificationsResult from AuditManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/ListNotifications">REST API Reference for ListNotifications Operation</seealso>
        ListNotificationsResponse EndListNotifications(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Returns a list of tags for the specified resource in AWS Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonAuditManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from AuditManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

        #endregion
        
        #region  RegisterAccount


        /// <summary>
        /// Enables AWS Audit Manager for the specified AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterAccount service method.</param>
        /// 
        /// <returns>The response from the RegisterAccount service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/RegisterAccount">REST API Reference for RegisterAccount Operation</seealso>
        RegisterAccountResponse RegisterAccount(RegisterAccountRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RegisterAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterAccount operation on AmazonAuditManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRegisterAccount
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/RegisterAccount">REST API Reference for RegisterAccount Operation</seealso>
        IAsyncResult BeginRegisterAccount(RegisterAccountRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RegisterAccount operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRegisterAccount.</param>
        /// 
        /// <returns>Returns a  RegisterAccountResult from AuditManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/RegisterAccount">REST API Reference for RegisterAccount Operation</seealso>
        RegisterAccountResponse EndRegisterAccount(IAsyncResult asyncResult);

        #endregion
        
        #region  RegisterOrganizationAdminAccount


        /// <summary>
        /// Enables an AWS account within the organization as the delegated administrator for
        /// AWS Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterOrganizationAdminAccount service method.</param>
        /// 
        /// <returns>The response from the RegisterOrganizationAdminAccount service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/RegisterOrganizationAdminAccount">REST API Reference for RegisterOrganizationAdminAccount Operation</seealso>
        RegisterOrganizationAdminAccountResponse RegisterOrganizationAdminAccount(RegisterOrganizationAdminAccountRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RegisterOrganizationAdminAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterOrganizationAdminAccount operation on AmazonAuditManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRegisterOrganizationAdminAccount
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/RegisterOrganizationAdminAccount">REST API Reference for RegisterOrganizationAdminAccount Operation</seealso>
        IAsyncResult BeginRegisterOrganizationAdminAccount(RegisterOrganizationAdminAccountRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RegisterOrganizationAdminAccount operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRegisterOrganizationAdminAccount.</param>
        /// 
        /// <returns>Returns a  RegisterOrganizationAdminAccountResult from AuditManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/RegisterOrganizationAdminAccount">REST API Reference for RegisterOrganizationAdminAccount Operation</seealso>
        RegisterOrganizationAdminAccountResponse EndRegisterOrganizationAdminAccount(IAsyncResult asyncResult);

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Tags the specified resource in AWS Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonAuditManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from AuditManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes a tag from a resource in AWS Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonAuditManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from AuditManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateAssessment


        /// <summary>
        /// Edits an AWS Audit Manager assessment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAssessment service method.</param>
        /// 
        /// <returns>The response from the UpdateAssessment service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/UpdateAssessment">REST API Reference for UpdateAssessment Operation</seealso>
        UpdateAssessmentResponse UpdateAssessment(UpdateAssessmentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAssessment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAssessment operation on AmazonAuditManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAssessment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/UpdateAssessment">REST API Reference for UpdateAssessment Operation</seealso>
        IAsyncResult BeginUpdateAssessment(UpdateAssessmentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAssessment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAssessment.</param>
        /// 
        /// <returns>Returns a  UpdateAssessmentResult from AuditManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/UpdateAssessment">REST API Reference for UpdateAssessment Operation</seealso>
        UpdateAssessmentResponse EndUpdateAssessment(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateAssessmentControl


        /// <summary>
        /// Updates a control within an assessment in AWS Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAssessmentControl service method.</param>
        /// 
        /// <returns>The response from the UpdateAssessmentControl service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/UpdateAssessmentControl">REST API Reference for UpdateAssessmentControl Operation</seealso>
        UpdateAssessmentControlResponse UpdateAssessmentControl(UpdateAssessmentControlRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAssessmentControl operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAssessmentControl operation on AmazonAuditManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAssessmentControl
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/UpdateAssessmentControl">REST API Reference for UpdateAssessmentControl Operation</seealso>
        IAsyncResult BeginUpdateAssessmentControl(UpdateAssessmentControlRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAssessmentControl operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAssessmentControl.</param>
        /// 
        /// <returns>Returns a  UpdateAssessmentControlResult from AuditManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/UpdateAssessmentControl">REST API Reference for UpdateAssessmentControl Operation</seealso>
        UpdateAssessmentControlResponse EndUpdateAssessmentControl(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateAssessmentControlSetStatus


        /// <summary>
        /// Updates the status of a control set in an AWS Audit Manager assessment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAssessmentControlSetStatus service method.</param>
        /// 
        /// <returns>The response from the UpdateAssessmentControlSetStatus service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/UpdateAssessmentControlSetStatus">REST API Reference for UpdateAssessmentControlSetStatus Operation</seealso>
        UpdateAssessmentControlSetStatusResponse UpdateAssessmentControlSetStatus(UpdateAssessmentControlSetStatusRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAssessmentControlSetStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAssessmentControlSetStatus operation on AmazonAuditManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAssessmentControlSetStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/UpdateAssessmentControlSetStatus">REST API Reference for UpdateAssessmentControlSetStatus Operation</seealso>
        IAsyncResult BeginUpdateAssessmentControlSetStatus(UpdateAssessmentControlSetStatusRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAssessmentControlSetStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAssessmentControlSetStatus.</param>
        /// 
        /// <returns>Returns a  UpdateAssessmentControlSetStatusResult from AuditManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/UpdateAssessmentControlSetStatus">REST API Reference for UpdateAssessmentControlSetStatus Operation</seealso>
        UpdateAssessmentControlSetStatusResponse EndUpdateAssessmentControlSetStatus(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateAssessmentFramework


        /// <summary>
        /// Updates a custom framework in AWS Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAssessmentFramework service method.</param>
        /// 
        /// <returns>The response from the UpdateAssessmentFramework service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/UpdateAssessmentFramework">REST API Reference for UpdateAssessmentFramework Operation</seealso>
        UpdateAssessmentFrameworkResponse UpdateAssessmentFramework(UpdateAssessmentFrameworkRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAssessmentFramework operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAssessmentFramework operation on AmazonAuditManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAssessmentFramework
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/UpdateAssessmentFramework">REST API Reference for UpdateAssessmentFramework Operation</seealso>
        IAsyncResult BeginUpdateAssessmentFramework(UpdateAssessmentFrameworkRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAssessmentFramework operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAssessmentFramework.</param>
        /// 
        /// <returns>Returns a  UpdateAssessmentFrameworkResult from AuditManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/UpdateAssessmentFramework">REST API Reference for UpdateAssessmentFramework Operation</seealso>
        UpdateAssessmentFrameworkResponse EndUpdateAssessmentFramework(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateAssessmentStatus


        /// <summary>
        /// Updates the status of an assessment in AWS Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAssessmentStatus service method.</param>
        /// 
        /// <returns>The response from the UpdateAssessmentStatus service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/UpdateAssessmentStatus">REST API Reference for UpdateAssessmentStatus Operation</seealso>
        UpdateAssessmentStatusResponse UpdateAssessmentStatus(UpdateAssessmentStatusRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAssessmentStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAssessmentStatus operation on AmazonAuditManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAssessmentStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/UpdateAssessmentStatus">REST API Reference for UpdateAssessmentStatus Operation</seealso>
        IAsyncResult BeginUpdateAssessmentStatus(UpdateAssessmentStatusRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAssessmentStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAssessmentStatus.</param>
        /// 
        /// <returns>Returns a  UpdateAssessmentStatusResult from AuditManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/UpdateAssessmentStatus">REST API Reference for UpdateAssessmentStatus Operation</seealso>
        UpdateAssessmentStatusResponse EndUpdateAssessmentStatus(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateControl


        /// <summary>
        /// Updates a custom control in AWS Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateControl service method.</param>
        /// 
        /// <returns>The response from the UpdateControl service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/UpdateControl">REST API Reference for UpdateControl Operation</seealso>
        UpdateControlResponse UpdateControl(UpdateControlRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateControl operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateControl operation on AmazonAuditManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateControl
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/UpdateControl">REST API Reference for UpdateControl Operation</seealso>
        IAsyncResult BeginUpdateControl(UpdateControlRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateControl operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateControl.</param>
        /// 
        /// <returns>Returns a  UpdateControlResult from AuditManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/UpdateControl">REST API Reference for UpdateControl Operation</seealso>
        UpdateControlResponse EndUpdateControl(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateSettings


        /// <summary>
        /// Updates AWS Audit Manager settings for the current user account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSettings service method.</param>
        /// 
        /// <returns>The response from the UpdateSettings service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/UpdateSettings">REST API Reference for UpdateSettings Operation</seealso>
        UpdateSettingsResponse UpdateSettings(UpdateSettingsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSettings operation on AmazonAuditManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/UpdateSettings">REST API Reference for UpdateSettings Operation</seealso>
        IAsyncResult BeginUpdateSettings(UpdateSettingsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSettings.</param>
        /// 
        /// <returns>Returns a  UpdateSettingsResult from AuditManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/UpdateSettings">REST API Reference for UpdateSettings Operation</seealso>
        UpdateSettingsResponse EndUpdateSettings(IAsyncResult asyncResult);

        #endregion
        
        #region  ValidateAssessmentReportIntegrity


        /// <summary>
        /// Validates the integrity of an assessment report in AWS Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ValidateAssessmentReportIntegrity service method.</param>
        /// 
        /// <returns>The response from the ValidateAssessmentReportIntegrity service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/ValidateAssessmentReportIntegrity">REST API Reference for ValidateAssessmentReportIntegrity Operation</seealso>
        ValidateAssessmentReportIntegrityResponse ValidateAssessmentReportIntegrity(ValidateAssessmentReportIntegrityRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ValidateAssessmentReportIntegrity operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ValidateAssessmentReportIntegrity operation on AmazonAuditManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndValidateAssessmentReportIntegrity
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/ValidateAssessmentReportIntegrity">REST API Reference for ValidateAssessmentReportIntegrity Operation</seealso>
        IAsyncResult BeginValidateAssessmentReportIntegrity(ValidateAssessmentReportIntegrityRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ValidateAssessmentReportIntegrity operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginValidateAssessmentReportIntegrity.</param>
        /// 
        /// <returns>Returns a  ValidateAssessmentReportIntegrityResult from AuditManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/ValidateAssessmentReportIntegrity">REST API Reference for ValidateAssessmentReportIntegrity Operation</seealso>
        ValidateAssessmentReportIntegrityResponse EndValidateAssessmentReportIntegrity(IAsyncResult asyncResult);

        #endregion
        
    }
}