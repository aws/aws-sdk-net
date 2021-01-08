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
#if NETSTANDARD13
    [Obsolete("Support for .NET Standard 1.3 is in maintenance mode and will only receive critical bug fixes and security patches. Visit https://docs.aws.amazon.com/sdk-for-net/v3/developer-guide/migration-from-net-standard-1-3.html for further details.")]
#endif
    public partial interface IAmazonAuditManager : IAmazonService, IDisposable
    {
#if AWS_ASYNC_ENUMERABLES_API
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<AssociateAssessmentReportEvidenceFolderResponse> AssociateAssessmentReportEvidenceFolderAsync(AssociateAssessmentReportEvidenceFolderRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  BatchAssociateAssessmentReportEvidence



        /// <summary>
        /// Associates a list of evidence to an assessment report in an AWS Audit Manager assessment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchAssociateAssessmentReportEvidence service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<BatchAssociateAssessmentReportEvidenceResponse> BatchAssociateAssessmentReportEvidenceAsync(BatchAssociateAssessmentReportEvidenceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  BatchCreateDelegationByAssessment



        /// <summary>
        /// Create a batch of delegations for a specified assessment in AWS Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchCreateDelegationByAssessment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<BatchCreateDelegationByAssessmentResponse> BatchCreateDelegationByAssessmentAsync(BatchCreateDelegationByAssessmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  BatchDeleteDelegationByAssessment



        /// <summary>
        /// Deletes the delegations in the specified AWS Audit Manager assessment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteDelegationByAssessment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<BatchDeleteDelegationByAssessmentResponse> BatchDeleteDelegationByAssessmentAsync(BatchDeleteDelegationByAssessmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  BatchDisassociateAssessmentReportEvidence



        /// <summary>
        /// Disassociates a list of evidence from the specified assessment report in AWS Audit
        /// Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDisassociateAssessmentReportEvidence service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<BatchDisassociateAssessmentReportEvidenceResponse> BatchDisassociateAssessmentReportEvidenceAsync(BatchDisassociateAssessmentReportEvidenceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  BatchImportEvidenceToAssessmentControl



        /// <summary>
        /// Uploads one or more pieces of evidence to the specified control in the assessment
        /// in AWS Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchImportEvidenceToAssessmentControl service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<BatchImportEvidenceToAssessmentControlResponse> BatchImportEvidenceToAssessmentControlAsync(BatchImportEvidenceToAssessmentControlRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateAssessment



        /// <summary>
        /// Creates an assessment in AWS Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAssessment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateAssessmentResponse> CreateAssessmentAsync(CreateAssessmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateAssessmentFramework



        /// <summary>
        /// Creates a custom framework in AWS Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAssessmentFramework service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateAssessmentFrameworkResponse> CreateAssessmentFrameworkAsync(CreateAssessmentFrameworkRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateAssessmentReport



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
        Task<CreateAssessmentReportResponse> CreateAssessmentReportAsync(CreateAssessmentReportRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateControl



        /// <summary>
        /// Creates a new custom control in AWS Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateControl service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateControlResponse> CreateControlAsync(CreateControlRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteAssessment



        /// <summary>
        /// Deletes an assessment in AWS Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAssessment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteAssessmentResponse> DeleteAssessmentAsync(DeleteAssessmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteAssessmentFramework



        /// <summary>
        /// Deletes a custom framework in AWS Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAssessmentFramework service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteAssessmentFrameworkResponse> DeleteAssessmentFrameworkAsync(DeleteAssessmentFrameworkRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteAssessmentReport



        /// <summary>
        /// Deletes an assessment report from an assessment in AWS Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAssessmentReport service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteAssessmentReportResponse> DeleteAssessmentReportAsync(DeleteAssessmentReportRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteControl



        /// <summary>
        /// Deletes a custom control in AWS Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteControl service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteControlResponse> DeleteControlAsync(DeleteControlRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeregisterAccount



        /// <summary>
        /// Deregisters an account in AWS Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterAccount service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeregisterAccountResponse> DeregisterAccountAsync(DeregisterAccountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeregisterOrganizationAdminAccount



        /// <summary>
        /// Deregisters the delegated AWS administrator account from the AWS organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterOrganizationAdminAccount service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeregisterOrganizationAdminAccountResponse> DeregisterOrganizationAdminAccountAsync(DeregisterOrganizationAdminAccountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DisassociateAssessmentReportEvidenceFolder



        /// <summary>
        /// Disassociates an evidence folder from the specified assessment report in AWS Audit
        /// Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateAssessmentReportEvidenceFolder service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DisassociateAssessmentReportEvidenceFolderResponse> DisassociateAssessmentReportEvidenceFolderAsync(DisassociateAssessmentReportEvidenceFolderRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetAccountStatus



        /// <summary>
        /// Returns the registration status of an account in AWS Audit Manager.
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
        Task<GetAccountStatusResponse> GetAccountStatusAsync(GetAccountStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetAssessment



        /// <summary>
        /// Returns an assessment from AWS Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAssessment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetAssessmentResponse> GetAssessmentAsync(GetAssessmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetAssessmentFramework



        /// <summary>
        /// Returns a framework from AWS Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAssessmentFramework service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetAssessmentFrameworkResponse> GetAssessmentFrameworkAsync(GetAssessmentFrameworkRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetAssessmentReportUrl



        /// <summary>
        /// Returns the URL of a specified assessment report in AWS Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAssessmentReportUrl service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetAssessmentReportUrlResponse> GetAssessmentReportUrlAsync(GetAssessmentReportUrlRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetChangeLogs



        /// <summary>
        /// Returns a list of changelogs from AWS Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetChangeLogs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetChangeLogsResponse> GetChangeLogsAsync(GetChangeLogsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetControl



        /// <summary>
        /// Returns a control from AWS Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetControl service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetControlResponse> GetControlAsync(GetControlRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetDelegations



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
        Task<GetDelegationsResponse> GetDelegationsAsync(GetDelegationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetEvidence



        /// <summary>
        /// Returns evidence from AWS Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEvidence service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetEvidenceResponse> GetEvidenceAsync(GetEvidenceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetEvidenceByEvidenceFolder



        /// <summary>
        /// Returns all evidence from a specified evidence folder in AWS Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEvidenceByEvidenceFolder service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetEvidenceByEvidenceFolderResponse> GetEvidenceByEvidenceFolderAsync(GetEvidenceByEvidenceFolderRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetEvidenceFolder



        /// <summary>
        /// Returns an evidence folder from the specified assessment in AWS Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEvidenceFolder service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetEvidenceFolderResponse> GetEvidenceFolderAsync(GetEvidenceFolderRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetEvidenceFoldersByAssessment



        /// <summary>
        /// Returns the evidence folders from a specified assessment in AWS Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEvidenceFoldersByAssessment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetEvidenceFoldersByAssessmentResponse> GetEvidenceFoldersByAssessmentAsync(GetEvidenceFoldersByAssessmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetEvidenceFoldersByAssessmentControl



        /// <summary>
        /// Returns a list of evidence folders associated with a specified control of an assessment
        /// in AWS Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEvidenceFoldersByAssessmentControl service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetEvidenceFoldersByAssessmentControlResponse> GetEvidenceFoldersByAssessmentControlAsync(GetEvidenceFoldersByAssessmentControlRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetOrganizationAdminAccount



        /// <summary>
        /// Returns the name of the delegated AWS administrator account for the AWS organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOrganizationAdminAccount service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetOrganizationAdminAccountResponse> GetOrganizationAdminAccountAsync(GetOrganizationAdminAccountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetServicesInScope



        /// <summary>
        /// Returns a list of the in-scope AWS services for the specified assessment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetServicesInScope service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetServicesInScopeResponse> GetServicesInScopeAsync(GetServicesInScopeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetSettings



        /// <summary>
        /// Returns the settings for the specified AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetSettingsResponse> GetSettingsAsync(GetSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListAssessmentFrameworks



        /// <summary>
        /// Returns a list of the frameworks available in the AWS Audit Manager framework library.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssessmentFrameworks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListAssessmentFrameworksResponse> ListAssessmentFrameworksAsync(ListAssessmentFrameworksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListAssessmentReports



        /// <summary>
        /// Returns a list of assessment reports created in AWS Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssessmentReports service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListAssessmentReportsResponse> ListAssessmentReportsAsync(ListAssessmentReportsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListAssessments



        /// <summary>
        /// Returns a list of current and past assessments from AWS Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssessments service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListAssessmentsResponse> ListAssessmentsAsync(ListAssessmentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListControls



        /// <summary>
        /// Returns a list of controls from AWS Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListControls service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListControlsResponse> ListControlsAsync(ListControlsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListKeywordsForDataSource



        /// <summary>
        /// Returns a list of keywords that pre-mapped to the specified control data source.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListKeywordsForDataSource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListKeywordsForDataSourceResponse> ListKeywordsForDataSourceAsync(ListKeywordsForDataSourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListNotifications



        /// <summary>
        /// Returns a list of all AWS Audit Manager notifications.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNotifications service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListNotificationsResponse> ListNotificationsAsync(ListNotificationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTagsForResource



        /// <summary>
        /// Returns a list of tags for the specified resource in AWS Audit Manager.
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
        /// The resource specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RegisterAccount



        /// <summary>
        /// Enables AWS Audit Manager for the specified AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterAccount service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<RegisterAccountResponse> RegisterAccountAsync(RegisterAccountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RegisterOrganizationAdminAccount



        /// <summary>
        /// Enables an AWS account within the organization as the delegated administrator for
        /// AWS Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterOrganizationAdminAccount service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<RegisterOrganizationAdminAccountResponse> RegisterOrganizationAdminAccountAsync(RegisterOrganizationAdminAccountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TagResource



        /// <summary>
        /// Tags the specified resource in AWS Audit Manager.
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
        /// The resource specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UntagResource



        /// <summary>
        /// Removes a tag from a resource in AWS Audit Manager.
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
        /// The resource specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateAssessment



        /// <summary>
        /// Edits an AWS Audit Manager assessment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAssessment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateAssessmentResponse> UpdateAssessmentAsync(UpdateAssessmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateAssessmentControl



        /// <summary>
        /// Updates a control within an assessment in AWS Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAssessmentControl service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateAssessmentControlResponse> UpdateAssessmentControlAsync(UpdateAssessmentControlRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateAssessmentControlSetStatus



        /// <summary>
        /// Updates the status of a control set in an AWS Audit Manager assessment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAssessmentControlSetStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateAssessmentControlSetStatusResponse> UpdateAssessmentControlSetStatusAsync(UpdateAssessmentControlSetStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateAssessmentFramework



        /// <summary>
        /// Updates a custom framework in AWS Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAssessmentFramework service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateAssessmentFrameworkResponse> UpdateAssessmentFrameworkAsync(UpdateAssessmentFrameworkRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateAssessmentStatus



        /// <summary>
        /// Updates the status of an assessment in AWS Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAssessmentStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateAssessmentStatusResponse> UpdateAssessmentStatusAsync(UpdateAssessmentStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateControl



        /// <summary>
        /// Updates a custom control in AWS Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateControl service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateControlResponse> UpdateControlAsync(UpdateControlRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateSettings



        /// <summary>
        /// Updates AWS Audit Manager settings for the current user account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateSettingsResponse> UpdateSettingsAsync(UpdateSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ValidateAssessmentReportIntegrity



        /// <summary>
        /// Validates the integrity of an assessment report in AWS Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ValidateAssessmentReportIntegrity service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ValidateAssessmentReportIntegrityResponse> ValidateAssessmentReportIntegrityAsync(ValidateAssessmentReportIntegrityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}