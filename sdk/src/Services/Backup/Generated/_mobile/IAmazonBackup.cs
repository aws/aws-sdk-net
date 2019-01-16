/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the backup-2018-11-15.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.Backup.Model;

namespace Amazon.Backup
{
    /// <summary>
    /// Interface for accessing Backup
    ///
    /// AWS Backup 
    /// <para>
    /// AWS Backup is a unified backup service designed to protect AWS services and their
    /// associated data. AWS Backup simplifies the creation, migration, restoration, and deletion
    /// of backups, while also providing reporting and auditing.
    /// </para>
    /// </summary>
    public partial interface IAmazonBackup : IAmazonService, IDisposable
    {
                
        #region  CreateBackupPlan


        /// <summary>
        /// Initiates the asynchronous execution of the CreateBackupPlan operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateBackupPlan operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/CreateBackupPlan">REST API Reference for CreateBackupPlan Operation</seealso>
        Task<CreateBackupPlanResponse> CreateBackupPlanAsync(CreateBackupPlanRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateBackupSelection


        /// <summary>
        /// Initiates the asynchronous execution of the CreateBackupSelection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateBackupSelection operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/CreateBackupSelection">REST API Reference for CreateBackupSelection Operation</seealso>
        Task<CreateBackupSelectionResponse> CreateBackupSelectionAsync(CreateBackupSelectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateBackupVault


        /// <summary>
        /// Initiates the asynchronous execution of the CreateBackupVault operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateBackupVault operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/CreateBackupVault">REST API Reference for CreateBackupVault Operation</seealso>
        Task<CreateBackupVaultResponse> CreateBackupVaultAsync(CreateBackupVaultRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteBackupPlan


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBackupPlan operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBackupPlan operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/DeleteBackupPlan">REST API Reference for DeleteBackupPlan Operation</seealso>
        Task<DeleteBackupPlanResponse> DeleteBackupPlanAsync(DeleteBackupPlanRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteBackupSelection


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBackupSelection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBackupSelection operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/DeleteBackupSelection">REST API Reference for DeleteBackupSelection Operation</seealso>
        Task<DeleteBackupSelectionResponse> DeleteBackupSelectionAsync(DeleteBackupSelectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteBackupVault


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBackupVault operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBackupVault operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/DeleteBackupVault">REST API Reference for DeleteBackupVault Operation</seealso>
        Task<DeleteBackupVaultResponse> DeleteBackupVaultAsync(DeleteBackupVaultRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteBackupVaultAccessPolicy


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBackupVaultAccessPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBackupVaultAccessPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/DeleteBackupVaultAccessPolicy">REST API Reference for DeleteBackupVaultAccessPolicy Operation</seealso>
        Task<DeleteBackupVaultAccessPolicyResponse> DeleteBackupVaultAccessPolicyAsync(DeleteBackupVaultAccessPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteBackupVaultNotifications


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBackupVaultNotifications operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBackupVaultNotifications operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/DeleteBackupVaultNotifications">REST API Reference for DeleteBackupVaultNotifications Operation</seealso>
        Task<DeleteBackupVaultNotificationsResponse> DeleteBackupVaultNotificationsAsync(DeleteBackupVaultNotificationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteRecoveryPoint


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRecoveryPoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRecoveryPoint operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/DeleteRecoveryPoint">REST API Reference for DeleteRecoveryPoint Operation</seealso>
        Task<DeleteRecoveryPointResponse> DeleteRecoveryPointAsync(DeleteRecoveryPointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeBackupJob


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeBackupJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeBackupJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/DescribeBackupJob">REST API Reference for DescribeBackupJob Operation</seealso>
        Task<DescribeBackupJobResponse> DescribeBackupJobAsync(DescribeBackupJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeBackupVault


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeBackupVault operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeBackupVault operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/DescribeBackupVault">REST API Reference for DescribeBackupVault Operation</seealso>
        Task<DescribeBackupVaultResponse> DescribeBackupVaultAsync(DescribeBackupVaultRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeProtectedResource


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeProtectedResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeProtectedResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/DescribeProtectedResource">REST API Reference for DescribeProtectedResource Operation</seealso>
        Task<DescribeProtectedResourceResponse> DescribeProtectedResourceAsync(DescribeProtectedResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeRecoveryPoint


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeRecoveryPoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeRecoveryPoint operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/DescribeRecoveryPoint">REST API Reference for DescribeRecoveryPoint Operation</seealso>
        Task<DescribeRecoveryPointResponse> DescribeRecoveryPointAsync(DescribeRecoveryPointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeRestoreJob


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeRestoreJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeRestoreJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/DescribeRestoreJob">REST API Reference for DescribeRestoreJob Operation</seealso>
        Task<DescribeRestoreJobResponse> DescribeRestoreJobAsync(DescribeRestoreJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ExportBackupPlanTemplate


        /// <summary>
        /// Initiates the asynchronous execution of the ExportBackupPlanTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ExportBackupPlanTemplate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ExportBackupPlanTemplate">REST API Reference for ExportBackupPlanTemplate Operation</seealso>
        Task<ExportBackupPlanTemplateResponse> ExportBackupPlanTemplateAsync(ExportBackupPlanTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetBackupPlan


        /// <summary>
        /// Initiates the asynchronous execution of the GetBackupPlan operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBackupPlan operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/GetBackupPlan">REST API Reference for GetBackupPlan Operation</seealso>
        Task<GetBackupPlanResponse> GetBackupPlanAsync(GetBackupPlanRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetBackupPlanFromJSON


        /// <summary>
        /// Initiates the asynchronous execution of the GetBackupPlanFromJSON operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBackupPlanFromJSON operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/GetBackupPlanFromJSON">REST API Reference for GetBackupPlanFromJSON Operation</seealso>
        Task<GetBackupPlanFromJSONResponse> GetBackupPlanFromJSONAsync(GetBackupPlanFromJSONRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetBackupPlanFromTemplate


        /// <summary>
        /// Initiates the asynchronous execution of the GetBackupPlanFromTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBackupPlanFromTemplate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/GetBackupPlanFromTemplate">REST API Reference for GetBackupPlanFromTemplate Operation</seealso>
        Task<GetBackupPlanFromTemplateResponse> GetBackupPlanFromTemplateAsync(GetBackupPlanFromTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetBackupSelection


        /// <summary>
        /// Initiates the asynchronous execution of the GetBackupSelection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBackupSelection operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/GetBackupSelection">REST API Reference for GetBackupSelection Operation</seealso>
        Task<GetBackupSelectionResponse> GetBackupSelectionAsync(GetBackupSelectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetBackupVaultAccessPolicy


        /// <summary>
        /// Initiates the asynchronous execution of the GetBackupVaultAccessPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBackupVaultAccessPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/GetBackupVaultAccessPolicy">REST API Reference for GetBackupVaultAccessPolicy Operation</seealso>
        Task<GetBackupVaultAccessPolicyResponse> GetBackupVaultAccessPolicyAsync(GetBackupVaultAccessPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetBackupVaultNotifications


        /// <summary>
        /// Initiates the asynchronous execution of the GetBackupVaultNotifications operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBackupVaultNotifications operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/GetBackupVaultNotifications">REST API Reference for GetBackupVaultNotifications Operation</seealso>
        Task<GetBackupVaultNotificationsResponse> GetBackupVaultNotificationsAsync(GetBackupVaultNotificationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetRecoveryPointRestoreMetadata


        /// <summary>
        /// Initiates the asynchronous execution of the GetRecoveryPointRestoreMetadata operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRecoveryPointRestoreMetadata operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/GetRecoveryPointRestoreMetadata">REST API Reference for GetRecoveryPointRestoreMetadata Operation</seealso>
        Task<GetRecoveryPointRestoreMetadataResponse> GetRecoveryPointRestoreMetadataAsync(GetRecoveryPointRestoreMetadataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetSupportedResourceTypes


        /// <summary>
        /// Initiates the asynchronous execution of the GetSupportedResourceTypes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSupportedResourceTypes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/GetSupportedResourceTypes">REST API Reference for GetSupportedResourceTypes Operation</seealso>
        Task<GetSupportedResourceTypesResponse> GetSupportedResourceTypesAsync(GetSupportedResourceTypesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListBackupJobs


        /// <summary>
        /// Initiates the asynchronous execution of the ListBackupJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListBackupJobs operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListBackupJobs">REST API Reference for ListBackupJobs Operation</seealso>
        Task<ListBackupJobsResponse> ListBackupJobsAsync(ListBackupJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListBackupPlans


        /// <summary>
        /// Initiates the asynchronous execution of the ListBackupPlans operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListBackupPlans operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListBackupPlans">REST API Reference for ListBackupPlans Operation</seealso>
        Task<ListBackupPlansResponse> ListBackupPlansAsync(ListBackupPlansRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListBackupPlanTemplates


        /// <summary>
        /// Initiates the asynchronous execution of the ListBackupPlanTemplates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListBackupPlanTemplates operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListBackupPlanTemplates">REST API Reference for ListBackupPlanTemplates Operation</seealso>
        Task<ListBackupPlanTemplatesResponse> ListBackupPlanTemplatesAsync(ListBackupPlanTemplatesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListBackupPlanVersions


        /// <summary>
        /// Initiates the asynchronous execution of the ListBackupPlanVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListBackupPlanVersions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListBackupPlanVersions">REST API Reference for ListBackupPlanVersions Operation</seealso>
        Task<ListBackupPlanVersionsResponse> ListBackupPlanVersionsAsync(ListBackupPlanVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListBackupSelections


        /// <summary>
        /// Initiates the asynchronous execution of the ListBackupSelections operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListBackupSelections operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListBackupSelections">REST API Reference for ListBackupSelections Operation</seealso>
        Task<ListBackupSelectionsResponse> ListBackupSelectionsAsync(ListBackupSelectionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListBackupVaults


        /// <summary>
        /// Initiates the asynchronous execution of the ListBackupVaults operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListBackupVaults operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListBackupVaults">REST API Reference for ListBackupVaults Operation</seealso>
        Task<ListBackupVaultsResponse> ListBackupVaultsAsync(ListBackupVaultsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListProtectedResources


        /// <summary>
        /// Initiates the asynchronous execution of the ListProtectedResources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListProtectedResources operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListProtectedResources">REST API Reference for ListProtectedResources Operation</seealso>
        Task<ListProtectedResourcesResponse> ListProtectedResourcesAsync(ListProtectedResourcesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListRecoveryPointsByBackupVault


        /// <summary>
        /// Initiates the asynchronous execution of the ListRecoveryPointsByBackupVault operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRecoveryPointsByBackupVault operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListRecoveryPointsByBackupVault">REST API Reference for ListRecoveryPointsByBackupVault Operation</seealso>
        Task<ListRecoveryPointsByBackupVaultResponse> ListRecoveryPointsByBackupVaultAsync(ListRecoveryPointsByBackupVaultRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListRecoveryPointsByResource


        /// <summary>
        /// Initiates the asynchronous execution of the ListRecoveryPointsByResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRecoveryPointsByResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListRecoveryPointsByResource">REST API Reference for ListRecoveryPointsByResource Operation</seealso>
        Task<ListRecoveryPointsByResourceResponse> ListRecoveryPointsByResourceAsync(ListRecoveryPointsByResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListRestoreJobs


        /// <summary>
        /// Initiates the asynchronous execution of the ListRestoreJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRestoreJobs operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListRestoreJobs">REST API Reference for ListRestoreJobs Operation</seealso>
        Task<ListRestoreJobsResponse> ListRestoreJobsAsync(ListRestoreJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTags


        /// <summary>
        /// Initiates the asynchronous execution of the ListTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTags operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListTags">REST API Reference for ListTags Operation</seealso>
        Task<ListTagsResponse> ListTagsAsync(ListTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutBackupVaultAccessPolicy


        /// <summary>
        /// Initiates the asynchronous execution of the PutBackupVaultAccessPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutBackupVaultAccessPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/PutBackupVaultAccessPolicy">REST API Reference for PutBackupVaultAccessPolicy Operation</seealso>
        Task<PutBackupVaultAccessPolicyResponse> PutBackupVaultAccessPolicyAsync(PutBackupVaultAccessPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutBackupVaultNotifications


        /// <summary>
        /// Initiates the asynchronous execution of the PutBackupVaultNotifications operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutBackupVaultNotifications operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/PutBackupVaultNotifications">REST API Reference for PutBackupVaultNotifications Operation</seealso>
        Task<PutBackupVaultNotificationsResponse> PutBackupVaultNotificationsAsync(PutBackupVaultNotificationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StartBackupJob


        /// <summary>
        /// Initiates the asynchronous execution of the StartBackupJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartBackupJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/StartBackupJob">REST API Reference for StartBackupJob Operation</seealso>
        Task<StartBackupJobResponse> StartBackupJobAsync(StartBackupJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StartRestoreJob


        /// <summary>
        /// Initiates the asynchronous execution of the StartRestoreJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartRestoreJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/StartRestoreJob">REST API Reference for StartRestoreJob Operation</seealso>
        Task<StartRestoreJobResponse> StartRestoreJobAsync(StartRestoreJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StopBackupJob


        /// <summary>
        /// Initiates the asynchronous execution of the StopBackupJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopBackupJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/StopBackupJob">REST API Reference for StopBackupJob Operation</seealso>
        Task<StopBackupJobResponse> StopBackupJobAsync(StopBackupJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TagResource


        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UntagResource


        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateBackupPlan


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateBackupPlan operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateBackupPlan operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/UpdateBackupPlan">REST API Reference for UpdateBackupPlan Operation</seealso>
        Task<UpdateBackupPlanResponse> UpdateBackupPlanAsync(UpdateBackupPlanRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateRecoveryPointLifecycle


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateRecoveryPointLifecycle operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateRecoveryPointLifecycle operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/UpdateRecoveryPointLifecycle">REST API Reference for UpdateRecoveryPointLifecycle Operation</seealso>
        Task<UpdateRecoveryPointLifecycleResponse> UpdateRecoveryPointLifecycleAsync(UpdateRecoveryPointLifecycleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}