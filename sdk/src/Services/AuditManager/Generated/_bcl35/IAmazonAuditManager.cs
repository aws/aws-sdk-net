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
    /// Welcome to the Audit Manager API reference. This guide is for developers who need
    /// detailed information about the Audit Manager API operations, data types, and errors.
    /// 
    /// 
    ///  
    /// <para>
    /// Audit Manager is a service that provides automated evidence collection so that you
    /// can continually audit your Amazon Web Services usage. You can use it to assess the
    /// effectiveness of your controls, manage risk, and simplify compliance.
    /// </para>
    ///  
    /// <para>
    /// Audit Manager provides prebuilt frameworks that structure and automate assessments
    /// for a given compliance standard. Frameworks include a prebuilt collection of controls
    /// with descriptions and testing procedures. These controls are grouped according to
    /// the requirements of the specified compliance standard or regulation. You can also
    /// customize frameworks and controls to support internal audits with specific requirements.
    /// 
    /// </para>
    ///  
    /// <para>
    /// Use the following links to get started with the Audit Manager API:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/audit-manager/latest/APIReference/API_Operations.html">Actions</a>:
    /// An alphabetical list of all Audit Manager API operations.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/audit-manager/latest/APIReference/API_Types.html">Data
    /// types</a>: An alphabetical list of all Audit Manager data types.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/audit-manager/latest/APIReference/CommonParameters.html">Common
    /// parameters</a>: Parameters that all operations can use.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/audit-manager/latest/APIReference/CommonErrors.html">Common
    /// errors</a>: Client and server errors that all operations can return.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// If you're new to Audit Manager, we recommend that you review the <a href="https://docs.aws.amazon.com/audit-manager/latest/userguide/what-is.html">
    /// Audit Manager User Guide</a>.
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
        /// Associates an evidence folder to an assessment report in an Audit Manager assessment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateAssessmentReportEvidenceFolder service method.</param>
        /// 
        /// <returns>The response from the AssociateAssessmentReportEvidenceFolder service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// Your account isn't registered with Audit Manager. Check the delegated administrator
        /// setup on the Audit Manager settings page, and try again.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource that's specified in the request can't be found.
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
        /// Associates a list of evidence to an assessment report in an Audit Manager assessment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchAssociateAssessmentReportEvidence service method.</param>
        /// 
        /// <returns>The response from the BatchAssociateAssessmentReportEvidence service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// Your account isn't registered with Audit Manager. Check the delegated administrator
        /// setup on the Audit Manager settings page, and try again.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource that's specified in the request can't be found.
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
        /// Creates a batch of delegations for an assessment in Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchCreateDelegationByAssessment service method.</param>
        /// 
        /// <returns>The response from the BatchCreateDelegationByAssessment service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// Your account isn't registered with Audit Manager. Check the delegated administrator
        /// setup on the Audit Manager settings page, and try again.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource that's specified in the request can't be found.
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
        /// Deletes a batch of delegations for an assessment in Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteDelegationByAssessment service method.</param>
        /// 
        /// <returns>The response from the BatchDeleteDelegationByAssessment service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// Your account isn't registered with Audit Manager. Check the delegated administrator
        /// setup on the Audit Manager settings page, and try again.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource that's specified in the request can't be found.
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
        /// Disassociates a list of evidence from an assessment report in Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDisassociateAssessmentReportEvidence service method.</param>
        /// 
        /// <returns>The response from the BatchDisassociateAssessmentReportEvidence service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// Your account isn't registered with Audit Manager. Check the delegated administrator
        /// setup on the Audit Manager settings page, and try again.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource that's specified in the request can't be found.
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
        /// Uploads one or more pieces of evidence to a control in an Audit Manager assessment.
        /// You can upload manual evidence from any Amazon Simple Storage Service (Amazon S3)
        /// bucket by specifying the S3 URI of the evidence. 
        /// 
        ///  
        /// <para>
        /// You must upload manual evidence to your S3 bucket before you can upload it to your
        /// assessment. For instructions, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_CreateBucket.html">CreateBucket</a>
        /// and <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_PutObject.html">PutObject</a>
        /// in the <i>Amazon Simple Storage Service API Reference.</i> 
        /// </para>
        ///  
        /// <para>
        /// The following restrictions apply to this action:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Maximum size of an individual evidence file: 100 MB
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Number of daily manual evidence uploads per control: 100
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Supported file formats: See <a href="https://docs.aws.amazon.com/audit-manager/latest/userguide/upload-evidence.html#supported-manual-evidence-files">Supported
        /// file types for manual evidence</a> in the <i>Audit Manager User Guide</i> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information about Audit Manager service restrictions, see <a href="https://docs.aws.amazon.com/audit-manager/latest/userguide/service-quotas.html">Quotas
        /// and restrictions for Audit Manager</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchImportEvidenceToAssessmentControl service method.</param>
        /// 
        /// <returns>The response from the BatchImportEvidenceToAssessmentControl service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// Your account isn't registered with Audit Manager. Check the delegated administrator
        /// setup on the Audit Manager settings page, and try again.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource that's specified in the request can't be found.
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
        /// Creates an assessment in Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAssessment service method.</param>
        /// 
        /// <returns>The response from the CreateAssessment service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// Your account isn't registered with Audit Manager. Check the delegated administrator
        /// setup on the Audit Manager settings page, and try again.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource that's specified in the request can't be found.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ServiceQuotaExceededException">
        /// You've reached your account quota for this resource type. To perform the requested
        /// action, delete some existing resources or <a href="https://docs.aws.amazon.com/general/latest/gr/aws_service_limits.html">request
        /// a quota increase</a> from the Service Quotas console. For a list of Audit Manager
        /// service quotas, see <a href="https://docs.aws.amazon.com/audit-manager/latest/userguide/service-quotas.html">Quotas
        /// and restrictions for Audit Manager</a>.
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
        /// Creates a custom framework in Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAssessmentFramework service method.</param>
        /// 
        /// <returns>The response from the CreateAssessmentFramework service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// Your account isn't registered with Audit Manager. Check the delegated administrator
        /// setup on the Audit Manager settings page, and try again.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource that's specified in the request can't be found.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ServiceQuotaExceededException">
        /// You've reached your account quota for this resource type. To perform the requested
        /// action, delete some existing resources or <a href="https://docs.aws.amazon.com/general/latest/gr/aws_service_limits.html">request
        /// a quota increase</a> from the Service Quotas console. For a list of Audit Manager
        /// service quotas, see <a href="https://docs.aws.amazon.com/audit-manager/latest/userguide/service-quotas.html">Quotas
        /// and restrictions for Audit Manager</a>.
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
        /// Your account isn't registered with Audit Manager. Check the delegated administrator
        /// setup on the Audit Manager settings page, and try again.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource that's specified in the request can't be found.
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
        /// Creates a new custom control in Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateControl service method.</param>
        /// 
        /// <returns>The response from the CreateControl service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// Your account isn't registered with Audit Manager. Check the delegated administrator
        /// setup on the Audit Manager settings page, and try again.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource that's specified in the request can't be found.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ServiceQuotaExceededException">
        /// You've reached your account quota for this resource type. To perform the requested
        /// action, delete some existing resources or <a href="https://docs.aws.amazon.com/general/latest/gr/aws_service_limits.html">request
        /// a quota increase</a> from the Service Quotas console. For a list of Audit Manager
        /// service quotas, see <a href="https://docs.aws.amazon.com/audit-manager/latest/userguide/service-quotas.html">Quotas
        /// and restrictions for Audit Manager</a>.
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
        /// Deletes an assessment in Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAssessment service method.</param>
        /// 
        /// <returns>The response from the DeleteAssessment service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// Your account isn't registered with Audit Manager. Check the delegated administrator
        /// setup on the Audit Manager settings page, and try again.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource that's specified in the request can't be found.
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
        /// Deletes a custom framework in Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAssessmentFramework service method.</param>
        /// 
        /// <returns>The response from the DeleteAssessmentFramework service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// Your account isn't registered with Audit Manager. Check the delegated administrator
        /// setup on the Audit Manager settings page, and try again.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource that's specified in the request can't be found.
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
        
        #region  DeleteAssessmentFrameworkShare


        /// <summary>
        /// Deletes a share request for a custom framework in Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAssessmentFrameworkShare service method.</param>
        /// 
        /// <returns>The response from the DeleteAssessmentFrameworkShare service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// Your account isn't registered with Audit Manager. Check the delegated administrator
        /// setup on the Audit Manager settings page, and try again.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource that's specified in the request can't be found.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/DeleteAssessmentFrameworkShare">REST API Reference for DeleteAssessmentFrameworkShare Operation</seealso>
        DeleteAssessmentFrameworkShareResponse DeleteAssessmentFrameworkShare(DeleteAssessmentFrameworkShareRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAssessmentFrameworkShare operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAssessmentFrameworkShare operation on AmazonAuditManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAssessmentFrameworkShare
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/DeleteAssessmentFrameworkShare">REST API Reference for DeleteAssessmentFrameworkShare Operation</seealso>
        IAsyncResult BeginDeleteAssessmentFrameworkShare(DeleteAssessmentFrameworkShareRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAssessmentFrameworkShare operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAssessmentFrameworkShare.</param>
        /// 
        /// <returns>Returns a  DeleteAssessmentFrameworkShareResult from AuditManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/DeleteAssessmentFrameworkShare">REST API Reference for DeleteAssessmentFrameworkShare Operation</seealso>
        DeleteAssessmentFrameworkShareResponse EndDeleteAssessmentFrameworkShare(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteAssessmentReport


        /// <summary>
        /// Deletes an assessment report in Audit Manager. 
        /// 
        ///  
        /// <para>
        /// When you run the <code>DeleteAssessmentReport</code> operation, Audit Manager attempts
        /// to delete the following data:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// The specified assessment report that’s stored in your S3 bucket
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The associated metadata that’s stored in Audit Manager
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// If Audit Manager can’t access the assessment report in your S3 bucket, the report
        /// isn’t deleted. In this event, the <code>DeleteAssessmentReport</code> operation doesn’t
        /// fail. Instead, it proceeds to delete the associated metadata only. You must then delete
        /// the assessment report from the S3 bucket yourself. 
        /// </para>
        ///  
        /// <para>
        /// This scenario happens when Audit Manager receives a <code>403 (Forbidden)</code> or
        /// <code>404 (Not Found)</code> error from Amazon S3. To avoid this, make sure that your
        /// S3 bucket is available, and that you configured the correct permissions for Audit
        /// Manager to delete resources in your S3 bucket. For an example permissions policy that
        /// you can use, see <a href="https://docs.aws.amazon.com/audit-manager/latest/userguide/security_iam_id-based-policy-examples.html#full-administrator-access-assessment-report-destination">Assessment
        /// report destination permissions</a> in the <i>Audit Manager User Guide</i>. For information
        /// about the issues that could cause a <code>403 (Forbidden)</code> or <code>404 (Not
        /// Found</code>) error from Amazon S3, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/ErrorResponses.html#ErrorCodeList">List
        /// of Error Codes</a> in the <i>Amazon Simple Storage Service API Reference</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAssessmentReport service method.</param>
        /// 
        /// <returns>The response from the DeleteAssessmentReport service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// Your account isn't registered with Audit Manager. Check the delegated administrator
        /// setup on the Audit Manager settings page, and try again.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource that's specified in the request can't be found.
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
        /// Deletes a custom control in Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteControl service method.</param>
        /// 
        /// <returns>The response from the DeleteControl service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// Your account isn't registered with Audit Manager. Check the delegated administrator
        /// setup on the Audit Manager settings page, and try again.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource that's specified in the request can't be found.
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
        /// Deregisters an account in Audit Manager. 
        /// 
        ///  <note> 
        /// <para>
        /// Before you deregister, you can use the <a href="https://docs.aws.amazon.com/audit-manager/latest/APIReference/API_UpdateSettings.html">UpdateSettings</a>
        /// API operation to set your preferred data retention policy. By default, Audit Manager
        /// retains your data. If you want to delete your data, you can use the <code>DeregistrationPolicy</code>
        /// attribute to request the deletion of your data. 
        /// </para>
        ///  
        /// <para>
        /// For more information about data retention, see <a href="https://docs.aws.amazon.com/audit-manager/latest/userguide/data-protection.html">Data
        /// Protection</a> in the <i>Audit Manager User Guide</i>. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterAccount service method.</param>
        /// 
        /// <returns>The response from the DeregisterAccount service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// Your account isn't registered with Audit Manager. Check the delegated administrator
        /// setup on the Audit Manager settings page, and try again.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource that's specified in the request can't be found.
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
        /// Removes the specified Amazon Web Services account as a delegated administrator for
        /// Audit Manager. 
        /// 
        ///  
        /// <para>
        /// When you remove a delegated administrator from your Audit Manager settings, you continue
        /// to have access to the evidence that you previously collected under that account. This
        /// is also the case when you deregister a delegated administrator from Organizations.
        /// However, Audit Manager stops collecting and attaching evidence to that delegated administrator
        /// account moving forward.
        /// </para>
        ///  <important> 
        /// <para>
        /// Keep in mind the following cleanup task if you use evidence finder:
        /// </para>
        ///  
        /// <para>
        /// Before you use your management account to remove a delegated administrator, make sure
        /// that the current delegated administrator account signs in to Audit Manager and disables
        /// evidence finder first. Disabling evidence finder automatically deletes the event data
        /// store that was created in their account when they enabled evidence finder. If this
        /// task isn’t completed, the event data store remains in their account. In this case,
        /// we recommend that the original delegated administrator goes to CloudTrail Lake and
        /// manually <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/query-eds-disable-termination.html">deletes
        /// the event data store</a>.
        /// </para>
        ///  
        /// <para>
        /// This cleanup task is necessary to ensure that you don't end up with multiple event
        /// data stores. Audit Manager ignores an unused event data store after you remove or
        /// change a delegated administrator account. However, the unused event data store continues
        /// to incur storage costs from CloudTrail Lake if you don't delete it.
        /// </para>
        ///  </important> 
        /// <para>
        /// When you deregister a delegated administrator account for Audit Manager, the data
        /// for that account isn’t deleted. If you want to delete resource data for a delegated
        /// administrator account, you must perform that task separately before you deregister
        /// the account. Either, you can do this in the Audit Manager console. Or, you can use
        /// one of the delete API operations that are provided by Audit Manager. 
        /// </para>
        ///  
        /// <para>
        /// To delete your Audit Manager resource data, see the following instructions: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/audit-manager/latest/APIReference/API_DeleteAssessment.html">DeleteAssessment</a>
        /// (see also: <a href="https://docs.aws.amazon.com/audit-manager/latest/userguide/delete-assessment.html">Deleting
        /// an assessment</a> in the <i>Audit Manager User Guide</i>)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/audit-manager/latest/APIReference/API_DeleteAssessmentFramework.html">DeleteAssessmentFramework</a>
        /// (see also: <a href="https://docs.aws.amazon.com/audit-manager/latest/userguide/delete-custom-framework.html">Deleting
        /// a custom framework</a> in the <i>Audit Manager User Guide</i>)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/audit-manager/latest/APIReference/API_DeleteAssessmentFrameworkShare.html">DeleteAssessmentFrameworkShare</a>
        /// (see also: <a href="https://docs.aws.amazon.com/audit-manager/latest/userguide/deleting-shared-framework-requests.html">Deleting
        /// a share request</a> in the <i>Audit Manager User Guide</i>)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/audit-manager/latest/APIReference/API_DeleteAssessmentReport.html">DeleteAssessmentReport</a>
        /// (see also: <a href="https://docs.aws.amazon.com/audit-manager/latest/userguide/generate-assessment-report.html#delete-assessment-report-steps">Deleting
        /// an assessment report</a> in the <i>Audit Manager User Guide</i>)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/audit-manager/latest/APIReference/API_DeleteControl.html">DeleteControl</a>
        /// (see also: <a href="https://docs.aws.amazon.com/audit-manager/latest/userguide/delete-controls.html">Deleting
        /// a custom control</a> in the <i>Audit Manager User Guide</i>)
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// At this time, Audit Manager doesn't provide an option to delete evidence for a specific
        /// delegated administrator. Instead, when your management account deregisters Audit Manager,
        /// we perform a cleanup for the current delegated administrator account at the time of
        /// deregistration.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterOrganizationAdminAccount service method.</param>
        /// 
        /// <returns>The response from the DeregisterOrganizationAdminAccount service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// Your account isn't registered with Audit Manager. Check the delegated administrator
        /// setup on the Audit Manager settings page, and try again.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource that's specified in the request can't be found.
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
        /// Disassociates an evidence folder from the specified assessment report in Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateAssessmentReportEvidenceFolder service method.</param>
        /// 
        /// <returns>The response from the DisassociateAssessmentReportEvidenceFolder service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// Your account isn't registered with Audit Manager. Check the delegated administrator
        /// setup on the Audit Manager settings page, and try again.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource that's specified in the request can't be found.
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
        /// Returns the registration status of an account in Audit Manager.
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
        /// Returns an assessment from Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAssessment service method.</param>
        /// 
        /// <returns>The response from the GetAssessment service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// Your account isn't registered with Audit Manager. Check the delegated administrator
        /// setup on the Audit Manager settings page, and try again.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource that's specified in the request can't be found.
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
        /// Returns a framework from Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAssessmentFramework service method.</param>
        /// 
        /// <returns>The response from the GetAssessmentFramework service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// Your account isn't registered with Audit Manager. Check the delegated administrator
        /// setup on the Audit Manager settings page, and try again.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource that's specified in the request can't be found.
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
        /// Returns the URL of an assessment report in Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAssessmentReportUrl service method.</param>
        /// 
        /// <returns>The response from the GetAssessmentReportUrl service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// Your account isn't registered with Audit Manager. Check the delegated administrator
        /// setup on the Audit Manager settings page, and try again.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource that's specified in the request can't be found.
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
        /// Returns a list of changelogs from Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetChangeLogs service method.</param>
        /// 
        /// <returns>The response from the GetChangeLogs service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// Your account isn't registered with Audit Manager. Check the delegated administrator
        /// setup on the Audit Manager settings page, and try again.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource that's specified in the request can't be found.
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
        /// Returns a control from Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetControl service method.</param>
        /// 
        /// <returns>The response from the GetControl service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// Your account isn't registered with Audit Manager. Check the delegated administrator
        /// setup on the Audit Manager settings page, and try again.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource that's specified in the request can't be found.
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
        /// Your account isn't registered with Audit Manager. Check the delegated administrator
        /// setup on the Audit Manager settings page, and try again.
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
        /// Returns evidence from Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEvidence service method.</param>
        /// 
        /// <returns>The response from the GetEvidence service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// Your account isn't registered with Audit Manager. Check the delegated administrator
        /// setup on the Audit Manager settings page, and try again.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource that's specified in the request can't be found.
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
        /// Returns all evidence from a specified evidence folder in Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEvidenceByEvidenceFolder service method.</param>
        /// 
        /// <returns>The response from the GetEvidenceByEvidenceFolder service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// Your account isn't registered with Audit Manager. Check the delegated administrator
        /// setup on the Audit Manager settings page, and try again.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource that's specified in the request can't be found.
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
        /// Returns an evidence folder from the specified assessment in Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEvidenceFolder service method.</param>
        /// 
        /// <returns>The response from the GetEvidenceFolder service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// Your account isn't registered with Audit Manager. Check the delegated administrator
        /// setup on the Audit Manager settings page, and try again.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource that's specified in the request can't be found.
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
        /// Returns the evidence folders from a specified assessment in Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEvidenceFoldersByAssessment service method.</param>
        /// 
        /// <returns>The response from the GetEvidenceFoldersByAssessment service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// Your account isn't registered with Audit Manager. Check the delegated administrator
        /// setup on the Audit Manager settings page, and try again.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource that's specified in the request can't be found.
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
        /// Returns a list of evidence folders that are associated with a specified control in
        /// an Audit Manager assessment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEvidenceFoldersByAssessmentControl service method.</param>
        /// 
        /// <returns>The response from the GetEvidenceFoldersByAssessmentControl service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// Your account isn't registered with Audit Manager. Check the delegated administrator
        /// setup on the Audit Manager settings page, and try again.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource that's specified in the request can't be found.
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
        
        #region  GetInsights


        /// <summary>
        /// Gets the latest analytics data for all your current active assessments.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInsights service method.</param>
        /// 
        /// <returns>The response from the GetInsights service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// Your account isn't registered with Audit Manager. Check the delegated administrator
        /// setup on the Audit Manager settings page, and try again.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/GetInsights">REST API Reference for GetInsights Operation</seealso>
        GetInsightsResponse GetInsights(GetInsightsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetInsights operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetInsights operation on AmazonAuditManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetInsights
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/GetInsights">REST API Reference for GetInsights Operation</seealso>
        IAsyncResult BeginGetInsights(GetInsightsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetInsights operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetInsights.</param>
        /// 
        /// <returns>Returns a  GetInsightsResult from AuditManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/GetInsights">REST API Reference for GetInsights Operation</seealso>
        GetInsightsResponse EndGetInsights(IAsyncResult asyncResult);

        #endregion
        
        #region  GetInsightsByAssessment


        /// <summary>
        /// Gets the latest analytics data for a specific active assessment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInsightsByAssessment service method.</param>
        /// 
        /// <returns>The response from the GetInsightsByAssessment service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// Your account isn't registered with Audit Manager. Check the delegated administrator
        /// setup on the Audit Manager settings page, and try again.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource that's specified in the request can't be found.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/GetInsightsByAssessment">REST API Reference for GetInsightsByAssessment Operation</seealso>
        GetInsightsByAssessmentResponse GetInsightsByAssessment(GetInsightsByAssessmentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetInsightsByAssessment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetInsightsByAssessment operation on AmazonAuditManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetInsightsByAssessment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/GetInsightsByAssessment">REST API Reference for GetInsightsByAssessment Operation</seealso>
        IAsyncResult BeginGetInsightsByAssessment(GetInsightsByAssessmentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetInsightsByAssessment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetInsightsByAssessment.</param>
        /// 
        /// <returns>Returns a  GetInsightsByAssessmentResult from AuditManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/GetInsightsByAssessment">REST API Reference for GetInsightsByAssessment Operation</seealso>
        GetInsightsByAssessmentResponse EndGetInsightsByAssessment(IAsyncResult asyncResult);

        #endregion
        
        #region  GetOrganizationAdminAccount


        /// <summary>
        /// Returns the name of the delegated Amazon Web Services administrator account for the
        /// organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOrganizationAdminAccount service method.</param>
        /// 
        /// <returns>The response from the GetOrganizationAdminAccount service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// Your account isn't registered with Audit Manager. Check the delegated administrator
        /// setup on the Audit Manager settings page, and try again.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource that's specified in the request can't be found.
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
        /// Returns a list of all of the Amazon Web Services that you can choose to include in
        /// your assessment. When you <a href="https://docs.aws.amazon.com/audit-manager/latest/APIReference/API_CreateAssessment.html">create
        /// an assessment</a>, specify which of these services you want to include to narrow the
        /// assessment's <a href="https://docs.aws.amazon.com/audit-manager/latest/APIReference/API_Scope.html">scope</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetServicesInScope service method.</param>
        /// 
        /// <returns>The response from the GetServicesInScope service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// Your account isn't registered with Audit Manager. Check the delegated administrator
        /// setup on the Audit Manager settings page, and try again.
        /// </exception>
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
        /// Returns the settings for the specified Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSettings service method.</param>
        /// 
        /// <returns>The response from the GetSettings service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// Your account isn't registered with Audit Manager. Check the delegated administrator
        /// setup on the Audit Manager settings page, and try again.
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
        
        #region  ListAssessmentControlInsightsByControlDomain


        /// <summary>
        /// Lists the latest analytics data for controls within a specific control domain and
        /// a specific active assessment.
        /// 
        ///  <note> 
        /// <para>
        /// Control insights are listed only if the control belongs to the control domain and
        /// assessment that was specified. Moreover, the control must have collected evidence
        /// on the <code>lastUpdated</code> date of <code>controlInsightsByAssessment</code>.
        /// If neither of these conditions are met, no data is listed for that control. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssessmentControlInsightsByControlDomain service method.</param>
        /// 
        /// <returns>The response from the ListAssessmentControlInsightsByControlDomain service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// Your account isn't registered with Audit Manager. Check the delegated administrator
        /// setup on the Audit Manager settings page, and try again.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource that's specified in the request can't be found.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/ListAssessmentControlInsightsByControlDomain">REST API Reference for ListAssessmentControlInsightsByControlDomain Operation</seealso>
        ListAssessmentControlInsightsByControlDomainResponse ListAssessmentControlInsightsByControlDomain(ListAssessmentControlInsightsByControlDomainRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListAssessmentControlInsightsByControlDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAssessmentControlInsightsByControlDomain operation on AmazonAuditManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAssessmentControlInsightsByControlDomain
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/ListAssessmentControlInsightsByControlDomain">REST API Reference for ListAssessmentControlInsightsByControlDomain Operation</seealso>
        IAsyncResult BeginListAssessmentControlInsightsByControlDomain(ListAssessmentControlInsightsByControlDomainRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAssessmentControlInsightsByControlDomain operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAssessmentControlInsightsByControlDomain.</param>
        /// 
        /// <returns>Returns a  ListAssessmentControlInsightsByControlDomainResult from AuditManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/ListAssessmentControlInsightsByControlDomain">REST API Reference for ListAssessmentControlInsightsByControlDomain Operation</seealso>
        ListAssessmentControlInsightsByControlDomainResponse EndListAssessmentControlInsightsByControlDomain(IAsyncResult asyncResult);

        #endregion
        
        #region  ListAssessmentFrameworks


        /// <summary>
        /// Returns a list of the frameworks that are available in the Audit Manager framework
        /// library.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssessmentFrameworks service method.</param>
        /// 
        /// <returns>The response from the ListAssessmentFrameworks service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// Your account isn't registered with Audit Manager. Check the delegated administrator
        /// setup on the Audit Manager settings page, and try again.
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
        
        #region  ListAssessmentFrameworkShareRequests


        /// <summary>
        /// Returns a list of sent or received share requests for custom frameworks in Audit
        /// Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssessmentFrameworkShareRequests service method.</param>
        /// 
        /// <returns>The response from the ListAssessmentFrameworkShareRequests service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// Your account isn't registered with Audit Manager. Check the delegated administrator
        /// setup on the Audit Manager settings page, and try again.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/ListAssessmentFrameworkShareRequests">REST API Reference for ListAssessmentFrameworkShareRequests Operation</seealso>
        ListAssessmentFrameworkShareRequestsResponse ListAssessmentFrameworkShareRequests(ListAssessmentFrameworkShareRequestsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListAssessmentFrameworkShareRequests operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAssessmentFrameworkShareRequests operation on AmazonAuditManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAssessmentFrameworkShareRequests
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/ListAssessmentFrameworkShareRequests">REST API Reference for ListAssessmentFrameworkShareRequests Operation</seealso>
        IAsyncResult BeginListAssessmentFrameworkShareRequests(ListAssessmentFrameworkShareRequestsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAssessmentFrameworkShareRequests operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAssessmentFrameworkShareRequests.</param>
        /// 
        /// <returns>Returns a  ListAssessmentFrameworkShareRequestsResult from AuditManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/ListAssessmentFrameworkShareRequests">REST API Reference for ListAssessmentFrameworkShareRequests Operation</seealso>
        ListAssessmentFrameworkShareRequestsResponse EndListAssessmentFrameworkShareRequests(IAsyncResult asyncResult);

        #endregion
        
        #region  ListAssessmentReports


        /// <summary>
        /// Returns a list of assessment reports created in Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssessmentReports service method.</param>
        /// 
        /// <returns>The response from the ListAssessmentReports service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// Your account isn't registered with Audit Manager. Check the delegated administrator
        /// setup on the Audit Manager settings page, and try again.
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
        /// Returns a list of current and past assessments from Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssessments service method.</param>
        /// 
        /// <returns>The response from the ListAssessments service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// Your account isn't registered with Audit Manager. Check the delegated administrator
        /// setup on the Audit Manager settings page, and try again.
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
        
        #region  ListControlDomainInsights


        /// <summary>
        /// Lists the latest analytics data for control domains across all of your active assessments.
        /// 
        /// 
        ///  <note> 
        /// <para>
        /// A control domain is listed only if at least one of the controls within that domain
        /// collected evidence on the <code>lastUpdated</code> date of <code>controlDomainInsights</code>.
        /// If this condition isn’t met, no data is listed for that control domain.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListControlDomainInsights service method.</param>
        /// 
        /// <returns>The response from the ListControlDomainInsights service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// Your account isn't registered with Audit Manager. Check the delegated administrator
        /// setup on the Audit Manager settings page, and try again.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource that's specified in the request can't be found.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/ListControlDomainInsights">REST API Reference for ListControlDomainInsights Operation</seealso>
        ListControlDomainInsightsResponse ListControlDomainInsights(ListControlDomainInsightsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListControlDomainInsights operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListControlDomainInsights operation on AmazonAuditManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListControlDomainInsights
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/ListControlDomainInsights">REST API Reference for ListControlDomainInsights Operation</seealso>
        IAsyncResult BeginListControlDomainInsights(ListControlDomainInsightsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListControlDomainInsights operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListControlDomainInsights.</param>
        /// 
        /// <returns>Returns a  ListControlDomainInsightsResult from AuditManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/ListControlDomainInsights">REST API Reference for ListControlDomainInsights Operation</seealso>
        ListControlDomainInsightsResponse EndListControlDomainInsights(IAsyncResult asyncResult);

        #endregion
        
        #region  ListControlDomainInsightsByAssessment


        /// <summary>
        /// Lists analytics data for control domains within a specified active assessment.
        /// 
        ///  <note> 
        /// <para>
        /// A control domain is listed only if at least one of the controls within that domain
        /// collected evidence on the <code>lastUpdated</code> date of <code>controlDomainInsights</code>.
        /// If this condition isn’t met, no data is listed for that domain.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListControlDomainInsightsByAssessment service method.</param>
        /// 
        /// <returns>The response from the ListControlDomainInsightsByAssessment service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// Your account isn't registered with Audit Manager. Check the delegated administrator
        /// setup on the Audit Manager settings page, and try again.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource that's specified in the request can't be found.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/ListControlDomainInsightsByAssessment">REST API Reference for ListControlDomainInsightsByAssessment Operation</seealso>
        ListControlDomainInsightsByAssessmentResponse ListControlDomainInsightsByAssessment(ListControlDomainInsightsByAssessmentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListControlDomainInsightsByAssessment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListControlDomainInsightsByAssessment operation on AmazonAuditManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListControlDomainInsightsByAssessment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/ListControlDomainInsightsByAssessment">REST API Reference for ListControlDomainInsightsByAssessment Operation</seealso>
        IAsyncResult BeginListControlDomainInsightsByAssessment(ListControlDomainInsightsByAssessmentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListControlDomainInsightsByAssessment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListControlDomainInsightsByAssessment.</param>
        /// 
        /// <returns>Returns a  ListControlDomainInsightsByAssessmentResult from AuditManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/ListControlDomainInsightsByAssessment">REST API Reference for ListControlDomainInsightsByAssessment Operation</seealso>
        ListControlDomainInsightsByAssessmentResponse EndListControlDomainInsightsByAssessment(IAsyncResult asyncResult);

        #endregion
        
        #region  ListControlInsightsByControlDomain


        /// <summary>
        /// Lists the latest analytics data for controls within a specific control domain across
        /// all active assessments.
        /// 
        ///  <note> 
        /// <para>
        /// Control insights are listed only if the control belongs to the control domain that
        /// was specified and the control collected evidence on the <code>lastUpdated</code> date
        /// of <code>controlInsightsMetadata</code>. If neither of these conditions are met, no
        /// data is listed for that control. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListControlInsightsByControlDomain service method.</param>
        /// 
        /// <returns>The response from the ListControlInsightsByControlDomain service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// Your account isn't registered with Audit Manager. Check the delegated administrator
        /// setup on the Audit Manager settings page, and try again.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource that's specified in the request can't be found.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/ListControlInsightsByControlDomain">REST API Reference for ListControlInsightsByControlDomain Operation</seealso>
        ListControlInsightsByControlDomainResponse ListControlInsightsByControlDomain(ListControlInsightsByControlDomainRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListControlInsightsByControlDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListControlInsightsByControlDomain operation on AmazonAuditManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListControlInsightsByControlDomain
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/ListControlInsightsByControlDomain">REST API Reference for ListControlInsightsByControlDomain Operation</seealso>
        IAsyncResult BeginListControlInsightsByControlDomain(ListControlInsightsByControlDomainRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListControlInsightsByControlDomain operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListControlInsightsByControlDomain.</param>
        /// 
        /// <returns>Returns a  ListControlInsightsByControlDomainResult from AuditManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/ListControlInsightsByControlDomain">REST API Reference for ListControlInsightsByControlDomain Operation</seealso>
        ListControlInsightsByControlDomainResponse EndListControlInsightsByControlDomain(IAsyncResult asyncResult);

        #endregion
        
        #region  ListControls


        /// <summary>
        /// Returns a list of controls from Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListControls service method.</param>
        /// 
        /// <returns>The response from the ListControls service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// Your account isn't registered with Audit Manager. Check the delegated administrator
        /// setup on the Audit Manager settings page, and try again.
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
        /// Returns a list of keywords that are pre-mapped to the specified control data source.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListKeywordsForDataSource service method.</param>
        /// 
        /// <returns>The response from the ListKeywordsForDataSource service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// Your account isn't registered with Audit Manager. Check the delegated administrator
        /// setup on the Audit Manager settings page, and try again.
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
        /// Returns a list of all Audit Manager notifications.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNotifications service method.</param>
        /// 
        /// <returns>The response from the ListNotifications service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// Your account isn't registered with Audit Manager. Check the delegated administrator
        /// setup on the Audit Manager settings page, and try again.
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
        /// Returns a list of tags for the specified resource in Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource that's specified in the request can't be found.
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
        /// Enables Audit Manager for the specified Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterAccount service method.</param>
        /// 
        /// <returns>The response from the RegisterAccount service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// Your account isn't registered with Audit Manager. Check the delegated administrator
        /// setup on the Audit Manager settings page, and try again.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource that's specified in the request can't be found.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ThrottlingException">
        /// The request was denied due to request throttling.
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
        /// Enables an Amazon Web Services account within the organization as the delegated administrator
        /// for Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterOrganizationAdminAccount service method.</param>
        /// 
        /// <returns>The response from the RegisterOrganizationAdminAccount service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// Your account isn't registered with Audit Manager. Check the delegated administrator
        /// setup on the Audit Manager settings page, and try again.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource that's specified in the request can't be found.
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
        
        #region  StartAssessmentFrameworkShare


        /// <summary>
        /// Creates a share request for a custom framework in Audit Manager. 
        /// 
        ///  
        /// <para>
        /// The share request specifies a recipient and notifies them that a custom framework
        /// is available. Recipients have 120 days to accept or decline the request. If no action
        /// is taken, the share request expires.
        /// </para>
        ///  
        /// <para>
        /// When you create a share request, Audit Manager stores a snapshot of your custom framework
        /// in the US East (N. Virginia) Amazon Web Services Region. Audit Manager also stores
        /// a backup of the same snapshot in the US West (Oregon) Amazon Web Services Region.
        /// </para>
        ///  
        /// <para>
        /// Audit Manager deletes the snapshot and the backup snapshot when one of the following
        /// events occurs:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The sender revokes the share request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The recipient declines the share request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The recipient encounters an error and doesn't successfully accept the share request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The share request expires before the recipient responds to the request.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When a sender <a href="https://docs.aws.amazon.com/audit-manager/latest/userguide/framework-sharing.html#framework-sharing-resend">resends
        /// a share request</a>, the snapshot is replaced with an updated version that corresponds
        /// with the latest version of the custom framework. 
        /// </para>
        ///  
        /// <para>
        /// When a recipient accepts a share request, the snapshot is replicated into their Amazon
        /// Web Services account under the Amazon Web Services Region that was specified in the
        /// share request. 
        /// </para>
        ///  <important> 
        /// <para>
        /// When you invoke the <code>StartAssessmentFrameworkShare</code> API, you are about
        /// to share a custom framework with another Amazon Web Services account. You may not
        /// share a custom framework that is derived from a standard framework if the standard
        /// framework is designated as not eligible for sharing by Amazon Web Services, unless
        /// you have obtained permission to do so from the owner of the standard framework. To
        /// learn more about which standard frameworks are eligible for sharing, see <a href="https://docs.aws.amazon.com/audit-manager/latest/userguide/share-custom-framework-concepts-and-terminology.html#eligibility">Framework
        /// sharing eligibility</a> in the <i>Audit Manager User Guide</i>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartAssessmentFrameworkShare service method.</param>
        /// 
        /// <returns>The response from the StartAssessmentFrameworkShare service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// Your account isn't registered with Audit Manager. Check the delegated administrator
        /// setup on the Audit Manager settings page, and try again.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource that's specified in the request can't be found.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/StartAssessmentFrameworkShare">REST API Reference for StartAssessmentFrameworkShare Operation</seealso>
        StartAssessmentFrameworkShareResponse StartAssessmentFrameworkShare(StartAssessmentFrameworkShareRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartAssessmentFrameworkShare operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartAssessmentFrameworkShare operation on AmazonAuditManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartAssessmentFrameworkShare
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/StartAssessmentFrameworkShare">REST API Reference for StartAssessmentFrameworkShare Operation</seealso>
        IAsyncResult BeginStartAssessmentFrameworkShare(StartAssessmentFrameworkShareRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartAssessmentFrameworkShare operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartAssessmentFrameworkShare.</param>
        /// 
        /// <returns>Returns a  StartAssessmentFrameworkShareResult from AuditManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/StartAssessmentFrameworkShare">REST API Reference for StartAssessmentFrameworkShare Operation</seealso>
        StartAssessmentFrameworkShareResponse EndStartAssessmentFrameworkShare(IAsyncResult asyncResult);

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Tags the specified resource in Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource that's specified in the request can't be found.
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
        /// Removes a tag from a resource in Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource that's specified in the request can't be found.
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
        /// Edits an Audit Manager assessment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAssessment service method.</param>
        /// 
        /// <returns>The response from the UpdateAssessment service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// Your account isn't registered with Audit Manager. Check the delegated administrator
        /// setup on the Audit Manager settings page, and try again.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource that's specified in the request can't be found.
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
        /// Updates a control within an assessment in Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAssessmentControl service method.</param>
        /// 
        /// <returns>The response from the UpdateAssessmentControl service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// Your account isn't registered with Audit Manager. Check the delegated administrator
        /// setup on the Audit Manager settings page, and try again.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource that's specified in the request can't be found.
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
        /// Updates the status of a control set in an Audit Manager assessment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAssessmentControlSetStatus service method.</param>
        /// 
        /// <returns>The response from the UpdateAssessmentControlSetStatus service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// Your account isn't registered with Audit Manager. Check the delegated administrator
        /// setup on the Audit Manager settings page, and try again.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource that's specified in the request can't be found.
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
        /// Updates a custom framework in Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAssessmentFramework service method.</param>
        /// 
        /// <returns>The response from the UpdateAssessmentFramework service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// Your account isn't registered with Audit Manager. Check the delegated administrator
        /// setup on the Audit Manager settings page, and try again.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource that's specified in the request can't be found.
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
        
        #region  UpdateAssessmentFrameworkShare


        /// <summary>
        /// Updates a share request for a custom framework in Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAssessmentFrameworkShare service method.</param>
        /// 
        /// <returns>The response from the UpdateAssessmentFrameworkShare service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// Your account isn't registered with Audit Manager. Check the delegated administrator
        /// setup on the Audit Manager settings page, and try again.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource that's specified in the request can't be found.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/UpdateAssessmentFrameworkShare">REST API Reference for UpdateAssessmentFrameworkShare Operation</seealso>
        UpdateAssessmentFrameworkShareResponse UpdateAssessmentFrameworkShare(UpdateAssessmentFrameworkShareRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAssessmentFrameworkShare operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAssessmentFrameworkShare operation on AmazonAuditManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAssessmentFrameworkShare
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/UpdateAssessmentFrameworkShare">REST API Reference for UpdateAssessmentFrameworkShare Operation</seealso>
        IAsyncResult BeginUpdateAssessmentFrameworkShare(UpdateAssessmentFrameworkShareRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAssessmentFrameworkShare operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAssessmentFrameworkShare.</param>
        /// 
        /// <returns>Returns a  UpdateAssessmentFrameworkShareResult from AuditManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/UpdateAssessmentFrameworkShare">REST API Reference for UpdateAssessmentFrameworkShare Operation</seealso>
        UpdateAssessmentFrameworkShareResponse EndUpdateAssessmentFrameworkShare(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateAssessmentStatus


        /// <summary>
        /// Updates the status of an assessment in Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAssessmentStatus service method.</param>
        /// 
        /// <returns>The response from the UpdateAssessmentStatus service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// Your account isn't registered with Audit Manager. Check the delegated administrator
        /// setup on the Audit Manager settings page, and try again.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource that's specified in the request can't be found.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ServiceQuotaExceededException">
        /// You've reached your account quota for this resource type. To perform the requested
        /// action, delete some existing resources or <a href="https://docs.aws.amazon.com/general/latest/gr/aws_service_limits.html">request
        /// a quota increase</a> from the Service Quotas console. For a list of Audit Manager
        /// service quotas, see <a href="https://docs.aws.amazon.com/audit-manager/latest/userguide/service-quotas.html">Quotas
        /// and restrictions for Audit Manager</a>.
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
        /// Updates a custom control in Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateControl service method.</param>
        /// 
        /// <returns>The response from the UpdateControl service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// Your account isn't registered with Audit Manager. Check the delegated administrator
        /// setup on the Audit Manager settings page, and try again.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource that's specified in the request can't be found.
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
        /// Updates Audit Manager settings for the current user account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSettings service method.</param>
        /// 
        /// <returns>The response from the UpdateSettings service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// Your account isn't registered with Audit Manager. Check the delegated administrator
        /// setup on the Audit Manager settings page, and try again.
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
        /// Validates the integrity of an assessment report in Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ValidateAssessmentReportIntegrity service method.</param>
        /// 
        /// <returns>The response from the ValidateAssessmentReportIntegrity service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// Your account isn't registered with Audit Manager. Check the delegated administrator
        /// setup on the Audit Manager settings page, and try again.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource that's specified in the request can't be found.
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