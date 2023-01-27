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
using System.Threading;
using System.Threading.Tasks;
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

        /// <summary>
        /// Paginators for the service
        /// </summary>
        IAuditManagerPaginatorFactory Paginators { get; }

        
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
        /// Associates an evidence folder to an assessment report in an Audit Manager assessment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateAssessmentReportEvidenceFolder service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<AssociateAssessmentReportEvidenceFolderResponse> AssociateAssessmentReportEvidenceFolderAsync(AssociateAssessmentReportEvidenceFolderRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Associates a list of evidence to an assessment report in an Audit Manager assessment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchAssociateAssessmentReportEvidence service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<BatchAssociateAssessmentReportEvidenceResponse> BatchAssociateAssessmentReportEvidenceAsync(BatchAssociateAssessmentReportEvidenceRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Creates a batch of delegations for an assessment in Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchCreateDelegationByAssessment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<BatchCreateDelegationByAssessmentResponse> BatchCreateDelegationByAssessmentAsync(BatchCreateDelegationByAssessmentRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Deletes a batch of delegations for an assessment in Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteDelegationByAssessment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<BatchDeleteDelegationByAssessmentResponse> BatchDeleteDelegationByAssessmentAsync(BatchDeleteDelegationByAssessmentRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Disassociates a list of evidence from an assessment report in Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDisassociateAssessmentReportEvidence service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<BatchDisassociateAssessmentReportEvidenceResponse> BatchDisassociateAssessmentReportEvidenceAsync(BatchDisassociateAssessmentReportEvidenceRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<BatchImportEvidenceToAssessmentControlResponse> BatchImportEvidenceToAssessmentControlAsync(BatchImportEvidenceToAssessmentControlRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Creates an assessment in Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAssessment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateAssessmentResponse> CreateAssessmentAsync(CreateAssessmentRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Creates a custom framework in Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAssessmentFramework service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateAssessmentFrameworkResponse> CreateAssessmentFrameworkAsync(CreateAssessmentFrameworkRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Creates an assessment report for the specified assessment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAssessmentReport service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateAssessmentReportResponse> CreateAssessmentReportAsync(CreateAssessmentReportRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Creates a new custom control in Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateControl service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateControlResponse> CreateControlAsync(CreateControlRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Deletes an assessment in Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAssessment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteAssessmentResponse> DeleteAssessmentAsync(DeleteAssessmentRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Deletes a custom framework in Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAssessmentFramework service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteAssessmentFrameworkResponse> DeleteAssessmentFrameworkAsync(DeleteAssessmentFrameworkRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Deletes a share request for a custom framework in Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAssessmentFrameworkShare service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteAssessmentFrameworkShareResponse> DeleteAssessmentFrameworkShareAsync(DeleteAssessmentFrameworkShareRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteAssessmentReportResponse> DeleteAssessmentReportAsync(DeleteAssessmentReportRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Deletes a custom control in Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteControl service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteControlResponse> DeleteControlAsync(DeleteControlRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeregisterAccountResponse> DeregisterAccountAsync(DeregisterAccountRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeregisterOrganizationAdminAccountResponse> DeregisterOrganizationAdminAccountAsync(DeregisterOrganizationAdminAccountRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Disassociates an evidence folder from the specified assessment report in Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateAssessmentReportEvidenceFolder service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DisassociateAssessmentReportEvidenceFolderResponse> DisassociateAssessmentReportEvidenceFolderAsync(DisassociateAssessmentReportEvidenceFolderRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Returns the registration status of an account in Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccountStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAccountStatus service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/GetAccountStatus">REST API Reference for GetAccountStatus Operation</seealso>
        Task<GetAccountStatusResponse> GetAccountStatusAsync(GetAccountStatusRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Returns an assessment from Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAssessment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetAssessmentResponse> GetAssessmentAsync(GetAssessmentRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Returns a framework from Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAssessmentFramework service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetAssessmentFrameworkResponse> GetAssessmentFrameworkAsync(GetAssessmentFrameworkRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Returns the URL of an assessment report in Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAssessmentReportUrl service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetAssessmentReportUrlResponse> GetAssessmentReportUrlAsync(GetAssessmentReportUrlRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Returns a list of changelogs from Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetChangeLogs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetChangeLogsResponse> GetChangeLogsAsync(GetChangeLogsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Returns a control from Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetControl service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetControlResponse> GetControlAsync(GetControlRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Returns a list of delegations from an audit owner to a delegate.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDelegations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetDelegationsResponse> GetDelegationsAsync(GetDelegationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Returns evidence from Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEvidence service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetEvidenceResponse> GetEvidenceAsync(GetEvidenceRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Returns all evidence from a specified evidence folder in Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEvidenceByEvidenceFolder service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetEvidenceByEvidenceFolderResponse> GetEvidenceByEvidenceFolderAsync(GetEvidenceByEvidenceFolderRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Returns an evidence folder from the specified assessment in Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEvidenceFolder service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetEvidenceFolderResponse> GetEvidenceFolderAsync(GetEvidenceFolderRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Returns the evidence folders from a specified assessment in Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEvidenceFoldersByAssessment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetEvidenceFoldersByAssessmentResponse> GetEvidenceFoldersByAssessmentAsync(GetEvidenceFoldersByAssessmentRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Returns a list of evidence folders that are associated with a specified control in
        /// an Audit Manager assessment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEvidenceFoldersByAssessmentControl service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetEvidenceFoldersByAssessmentControlResponse> GetEvidenceFoldersByAssessmentControlAsync(GetEvidenceFoldersByAssessmentControlRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Gets the latest analytics data for all your current active assessments.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInsights service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetInsightsResponse> GetInsightsAsync(GetInsightsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Gets the latest analytics data for a specific active assessment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInsightsByAssessment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetInsightsByAssessmentResponse> GetInsightsByAssessmentAsync(GetInsightsByAssessmentRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Returns the name of the delegated Amazon Web Services administrator account for the
        /// organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOrganizationAdminAccount service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetOrganizationAdminAccountResponse> GetOrganizationAdminAccountAsync(GetOrganizationAdminAccountRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Returns a list of all of the Amazon Web Services that you can choose to include in
        /// your assessment. When you <a href="https://docs.aws.amazon.com/audit-manager/latest/APIReference/API_CreateAssessment.html">create
        /// an assessment</a>, specify which of these services you want to include to narrow the
        /// assessment's <a href="https://docs.aws.amazon.com/audit-manager/latest/APIReference/API_Scope.html">scope</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetServicesInScope service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetServicesInScopeResponse> GetServicesInScopeAsync(GetServicesInScopeRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Returns the settings for the specified Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetSettingsResponse> GetSettingsAsync(GetSettingsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListAssessmentControlInsightsByControlDomainResponse> ListAssessmentControlInsightsByControlDomainAsync(ListAssessmentControlInsightsByControlDomainRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Returns a list of the frameworks that are available in the Audit Manager framework
        /// library.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssessmentFrameworks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListAssessmentFrameworksResponse> ListAssessmentFrameworksAsync(ListAssessmentFrameworksRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Returns a list of sent or received share requests for custom frameworks in Audit
        /// Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssessmentFrameworkShareRequests service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListAssessmentFrameworkShareRequestsResponse> ListAssessmentFrameworkShareRequestsAsync(ListAssessmentFrameworkShareRequestsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Returns a list of assessment reports created in Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssessmentReports service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListAssessmentReportsResponse> ListAssessmentReportsAsync(ListAssessmentReportsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Returns a list of current and past assessments from Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssessments service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListAssessmentsResponse> ListAssessmentsAsync(ListAssessmentsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListControlDomainInsightsResponse> ListControlDomainInsightsAsync(ListControlDomainInsightsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListControlDomainInsightsByAssessmentResponse> ListControlDomainInsightsByAssessmentAsync(ListControlDomainInsightsByAssessmentRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListControlInsightsByControlDomainResponse> ListControlInsightsByControlDomainAsync(ListControlInsightsByControlDomainRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Returns a list of controls from Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListControls service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListControlsResponse> ListControlsAsync(ListControlsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Returns a list of keywords that are pre-mapped to the specified control data source.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListKeywordsForDataSource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListKeywordsForDataSourceResponse> ListKeywordsForDataSourceAsync(ListKeywordsForDataSourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Returns a list of all Audit Manager notifications.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNotifications service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListNotificationsResponse> ListNotificationsAsync(ListNotificationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Returns a list of tags for the specified resource in Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Enables Audit Manager for the specified Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterAccount service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<RegisterAccountResponse> RegisterAccountAsync(RegisterAccountRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Enables an Amazon Web Services account within the organization as the delegated administrator
        /// for Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterOrganizationAdminAccount service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<RegisterOrganizationAdminAccountResponse> RegisterOrganizationAdminAccountAsync(RegisterOrganizationAdminAccountRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<StartAssessmentFrameworkShareResponse> StartAssessmentFrameworkShareAsync(StartAssessmentFrameworkShareRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Tags the specified resource in Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Removes a tag from a resource in Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Edits an Audit Manager assessment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAssessment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateAssessmentResponse> UpdateAssessmentAsync(UpdateAssessmentRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Updates a control within an assessment in Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAssessmentControl service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateAssessmentControlResponse> UpdateAssessmentControlAsync(UpdateAssessmentControlRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Updates the status of a control set in an Audit Manager assessment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAssessmentControlSetStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateAssessmentControlSetStatusResponse> UpdateAssessmentControlSetStatusAsync(UpdateAssessmentControlSetStatusRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Updates a custom framework in Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAssessmentFramework service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateAssessmentFrameworkResponse> UpdateAssessmentFrameworkAsync(UpdateAssessmentFrameworkRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Updates a share request for a custom framework in Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAssessmentFrameworkShare service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateAssessmentFrameworkShareResponse> UpdateAssessmentFrameworkShareAsync(UpdateAssessmentFrameworkShareRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Updates the status of an assessment in Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAssessmentStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateAssessmentStatusResponse> UpdateAssessmentStatusAsync(UpdateAssessmentStatusRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Updates a custom control in Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateControl service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateControlResponse> UpdateControlAsync(UpdateControlRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Updates Audit Manager settings for the current user account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateSettingsResponse> UpdateSettingsAsync(UpdateSettingsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Validates the integrity of an assessment report in Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ValidateAssessmentReportIntegrity service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ValidateAssessmentReportIntegrityResponse> ValidateAssessmentReportIntegrityAsync(ValidateAssessmentReportIntegrityRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}