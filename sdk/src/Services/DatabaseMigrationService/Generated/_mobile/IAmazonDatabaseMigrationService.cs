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
 * Do not modify this file. This file is generated from the dms-2016-01-01.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.DatabaseMigrationService.Model;

namespace Amazon.DatabaseMigrationService
{
    /// <summary>
    /// Interface for accessing DatabaseMigrationService
    ///
    /// AWS Database Migration Service 
    /// <para>
    /// AWS Database Migration Service (AWS DMS) can migrate your data to and from the most
    /// widely used commercial and open-source databases such as Oracle, PostgreSQL, Microsoft
    /// SQL Server, Amazon Redshift, MariaDB, Amazon Aurora, MySQL, and SAP Adaptive Server
    /// Enterprise (ASE). The service supports homogeneous migrations such as Oracle to Oracle,
    /// as well as heterogeneous migrations between different database platforms, such as
    /// Oracle to MySQL or SQL Server to PostgreSQL.
    /// </para>
    ///  
    /// <para>
    /// For more information about AWS DMS, see the AWS DMS user guide at <a href="http://docs.aws.amazon.com/dms/latest/userguide/Welcome.html">
    /// What Is AWS Database Migration Service? </a> 
    /// </para>
    /// </summary>
    public partial interface IAmazonDatabaseMigrationService : IAmazonService, IDisposable
    {
                
        #region  AddTagsToResource


        /// <summary>
        /// Initiates the asynchronous execution of the AddTagsToResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddTagsToResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/AddTagsToResource">REST API Reference for AddTagsToResource Operation</seealso>
        Task<AddTagsToResourceResponse> AddTagsToResourceAsync(AddTagsToResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateEndpoint


        /// <summary>
        /// Initiates the asynchronous execution of the CreateEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateEndpoint operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/CreateEndpoint">REST API Reference for CreateEndpoint Operation</seealso>
        Task<CreateEndpointResponse> CreateEndpointAsync(CreateEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateEventSubscription


        /// <summary>
        /// Initiates the asynchronous execution of the CreateEventSubscription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateEventSubscription operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/CreateEventSubscription">REST API Reference for CreateEventSubscription Operation</seealso>
        Task<CreateEventSubscriptionResponse> CreateEventSubscriptionAsync(CreateEventSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateReplicationInstance


        /// <summary>
        /// Initiates the asynchronous execution of the CreateReplicationInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateReplicationInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/CreateReplicationInstance">REST API Reference for CreateReplicationInstance Operation</seealso>
        Task<CreateReplicationInstanceResponse> CreateReplicationInstanceAsync(CreateReplicationInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateReplicationSubnetGroup


        /// <summary>
        /// Initiates the asynchronous execution of the CreateReplicationSubnetGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateReplicationSubnetGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/CreateReplicationSubnetGroup">REST API Reference for CreateReplicationSubnetGroup Operation</seealso>
        Task<CreateReplicationSubnetGroupResponse> CreateReplicationSubnetGroupAsync(CreateReplicationSubnetGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateReplicationTask


        /// <summary>
        /// Initiates the asynchronous execution of the CreateReplicationTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateReplicationTask operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/CreateReplicationTask">REST API Reference for CreateReplicationTask Operation</seealso>
        Task<CreateReplicationTaskResponse> CreateReplicationTaskAsync(CreateReplicationTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteCertificate


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCertificate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DeleteCertificate">REST API Reference for DeleteCertificate Operation</seealso>
        Task<DeleteCertificateResponse> DeleteCertificateAsync(DeleteCertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteEndpoint


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEndpoint operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DeleteEndpoint">REST API Reference for DeleteEndpoint Operation</seealso>
        Task<DeleteEndpointResponse> DeleteEndpointAsync(DeleteEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteEventSubscription


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEventSubscription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEventSubscription operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DeleteEventSubscription">REST API Reference for DeleteEventSubscription Operation</seealso>
        Task<DeleteEventSubscriptionResponse> DeleteEventSubscriptionAsync(DeleteEventSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteReplicationInstance


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteReplicationInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteReplicationInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DeleteReplicationInstance">REST API Reference for DeleteReplicationInstance Operation</seealso>
        Task<DeleteReplicationInstanceResponse> DeleteReplicationInstanceAsync(DeleteReplicationInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteReplicationSubnetGroup


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteReplicationSubnetGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteReplicationSubnetGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DeleteReplicationSubnetGroup">REST API Reference for DeleteReplicationSubnetGroup Operation</seealso>
        Task<DeleteReplicationSubnetGroupResponse> DeleteReplicationSubnetGroupAsync(DeleteReplicationSubnetGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteReplicationTask


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteReplicationTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteReplicationTask operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DeleteReplicationTask">REST API Reference for DeleteReplicationTask Operation</seealso>
        Task<DeleteReplicationTaskResponse> DeleteReplicationTaskAsync(DeleteReplicationTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeAccountAttributes


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAccountAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccountAttributes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeAccountAttributes">REST API Reference for DescribeAccountAttributes Operation</seealso>
        Task<DescribeAccountAttributesResponse> DescribeAccountAttributesAsync(DescribeAccountAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeCertificates


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCertificates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCertificates operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeCertificates">REST API Reference for DescribeCertificates Operation</seealso>
        Task<DescribeCertificatesResponse> DescribeCertificatesAsync(DescribeCertificatesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeConnections


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeConnections operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeConnections operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeConnections">REST API Reference for DescribeConnections Operation</seealso>
        Task<DescribeConnectionsResponse> DescribeConnectionsAsync(DescribeConnectionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeEndpoints


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEndpoints operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEndpoints operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeEndpoints">REST API Reference for DescribeEndpoints Operation</seealso>
        Task<DescribeEndpointsResponse> DescribeEndpointsAsync(DescribeEndpointsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeEndpointTypes


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEndpointTypes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEndpointTypes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeEndpointTypes">REST API Reference for DescribeEndpointTypes Operation</seealso>
        Task<DescribeEndpointTypesResponse> DescribeEndpointTypesAsync(DescribeEndpointTypesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeEventCategories


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEventCategories operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEventCategories operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeEventCategories">REST API Reference for DescribeEventCategories Operation</seealso>
        Task<DescribeEventCategoriesResponse> DescribeEventCategoriesAsync(DescribeEventCategoriesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeEvents


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEvents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEvents operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeEvents">REST API Reference for DescribeEvents Operation</seealso>
        Task<DescribeEventsResponse> DescribeEventsAsync(DescribeEventsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeEventSubscriptions


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEventSubscriptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEventSubscriptions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeEventSubscriptions">REST API Reference for DescribeEventSubscriptions Operation</seealso>
        Task<DescribeEventSubscriptionsResponse> DescribeEventSubscriptionsAsync(DescribeEventSubscriptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeOrderableReplicationInstances


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeOrderableReplicationInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeOrderableReplicationInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeOrderableReplicationInstances">REST API Reference for DescribeOrderableReplicationInstances Operation</seealso>
        Task<DescribeOrderableReplicationInstancesResponse> DescribeOrderableReplicationInstancesAsync(DescribeOrderableReplicationInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeRefreshSchemasStatus


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeRefreshSchemasStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeRefreshSchemasStatus operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeRefreshSchemasStatus">REST API Reference for DescribeRefreshSchemasStatus Operation</seealso>
        Task<DescribeRefreshSchemasStatusResponse> DescribeRefreshSchemasStatusAsync(DescribeRefreshSchemasStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeReplicationInstances


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReplicationInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReplicationInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeReplicationInstances">REST API Reference for DescribeReplicationInstances Operation</seealso>
        Task<DescribeReplicationInstancesResponse> DescribeReplicationInstancesAsync(DescribeReplicationInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeReplicationInstanceTaskLogs


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReplicationInstanceTaskLogs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReplicationInstanceTaskLogs operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeReplicationInstanceTaskLogs">REST API Reference for DescribeReplicationInstanceTaskLogs Operation</seealso>
        Task<DescribeReplicationInstanceTaskLogsResponse> DescribeReplicationInstanceTaskLogsAsync(DescribeReplicationInstanceTaskLogsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeReplicationSubnetGroups


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReplicationSubnetGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReplicationSubnetGroups operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeReplicationSubnetGroups">REST API Reference for DescribeReplicationSubnetGroups Operation</seealso>
        Task<DescribeReplicationSubnetGroupsResponse> DescribeReplicationSubnetGroupsAsync(DescribeReplicationSubnetGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeReplicationTaskAssessmentResults


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReplicationTaskAssessmentResults operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReplicationTaskAssessmentResults operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeReplicationTaskAssessmentResults">REST API Reference for DescribeReplicationTaskAssessmentResults Operation</seealso>
        Task<DescribeReplicationTaskAssessmentResultsResponse> DescribeReplicationTaskAssessmentResultsAsync(DescribeReplicationTaskAssessmentResultsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeReplicationTasks


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReplicationTasks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReplicationTasks operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeReplicationTasks">REST API Reference for DescribeReplicationTasks Operation</seealso>
        Task<DescribeReplicationTasksResponse> DescribeReplicationTasksAsync(DescribeReplicationTasksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeSchemas


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSchemas operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSchemas operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeSchemas">REST API Reference for DescribeSchemas Operation</seealso>
        Task<DescribeSchemasResponse> DescribeSchemasAsync(DescribeSchemasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeTableStatistics


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTableStatistics operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTableStatistics operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeTableStatistics">REST API Reference for DescribeTableStatistics Operation</seealso>
        Task<DescribeTableStatisticsResponse> DescribeTableStatisticsAsync(DescribeTableStatisticsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ImportCertificate


        /// <summary>
        /// Initiates the asynchronous execution of the ImportCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ImportCertificate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/ImportCertificate">REST API Reference for ImportCertificate Operation</seealso>
        Task<ImportCertificateResponse> ImportCertificateAsync(ImportCertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTagsForResource


        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ModifyEndpoint


        /// <summary>
        /// Initiates the asynchronous execution of the ModifyEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyEndpoint operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/ModifyEndpoint">REST API Reference for ModifyEndpoint Operation</seealso>
        Task<ModifyEndpointResponse> ModifyEndpointAsync(ModifyEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ModifyEventSubscription


        /// <summary>
        /// Initiates the asynchronous execution of the ModifyEventSubscription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyEventSubscription operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/ModifyEventSubscription">REST API Reference for ModifyEventSubscription Operation</seealso>
        Task<ModifyEventSubscriptionResponse> ModifyEventSubscriptionAsync(ModifyEventSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ModifyReplicationInstance


        /// <summary>
        /// Initiates the asynchronous execution of the ModifyReplicationInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyReplicationInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/ModifyReplicationInstance">REST API Reference for ModifyReplicationInstance Operation</seealso>
        Task<ModifyReplicationInstanceResponse> ModifyReplicationInstanceAsync(ModifyReplicationInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ModifyReplicationSubnetGroup


        /// <summary>
        /// Initiates the asynchronous execution of the ModifyReplicationSubnetGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyReplicationSubnetGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/ModifyReplicationSubnetGroup">REST API Reference for ModifyReplicationSubnetGroup Operation</seealso>
        Task<ModifyReplicationSubnetGroupResponse> ModifyReplicationSubnetGroupAsync(ModifyReplicationSubnetGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ModifyReplicationTask


        /// <summary>
        /// Initiates the asynchronous execution of the ModifyReplicationTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyReplicationTask operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/ModifyReplicationTask">REST API Reference for ModifyReplicationTask Operation</seealso>
        Task<ModifyReplicationTaskResponse> ModifyReplicationTaskAsync(ModifyReplicationTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RebootReplicationInstance


        /// <summary>
        /// Initiates the asynchronous execution of the RebootReplicationInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RebootReplicationInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/RebootReplicationInstance">REST API Reference for RebootReplicationInstance Operation</seealso>
        Task<RebootReplicationInstanceResponse> RebootReplicationInstanceAsync(RebootReplicationInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RefreshSchemas


        /// <summary>
        /// Initiates the asynchronous execution of the RefreshSchemas operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RefreshSchemas operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/RefreshSchemas">REST API Reference for RefreshSchemas Operation</seealso>
        Task<RefreshSchemasResponse> RefreshSchemasAsync(RefreshSchemasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ReloadTables


        /// <summary>
        /// Initiates the asynchronous execution of the ReloadTables operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ReloadTables operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/ReloadTables">REST API Reference for ReloadTables Operation</seealso>
        Task<ReloadTablesResponse> ReloadTablesAsync(ReloadTablesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RemoveTagsFromResource


        /// <summary>
        /// Initiates the asynchronous execution of the RemoveTagsFromResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveTagsFromResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/RemoveTagsFromResource">REST API Reference for RemoveTagsFromResource Operation</seealso>
        Task<RemoveTagsFromResourceResponse> RemoveTagsFromResourceAsync(RemoveTagsFromResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StartReplicationTask


        /// <summary>
        /// Initiates the asynchronous execution of the StartReplicationTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartReplicationTask operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/StartReplicationTask">REST API Reference for StartReplicationTask Operation</seealso>
        Task<StartReplicationTaskResponse> StartReplicationTaskAsync(StartReplicationTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StartReplicationTaskAssessment


        /// <summary>
        /// Initiates the asynchronous execution of the StartReplicationTaskAssessment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartReplicationTaskAssessment operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/StartReplicationTaskAssessment">REST API Reference for StartReplicationTaskAssessment Operation</seealso>
        Task<StartReplicationTaskAssessmentResponse> StartReplicationTaskAssessmentAsync(StartReplicationTaskAssessmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StopReplicationTask


        /// <summary>
        /// Initiates the asynchronous execution of the StopReplicationTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopReplicationTask operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/StopReplicationTask">REST API Reference for StopReplicationTask Operation</seealso>
        Task<StopReplicationTaskResponse> StopReplicationTaskAsync(StopReplicationTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TestConnection


        /// <summary>
        /// Initiates the asynchronous execution of the TestConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TestConnection operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/TestConnection">REST API Reference for TestConnection Operation</seealso>
        Task<TestConnectionResponse> TestConnectionAsync(TestConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}