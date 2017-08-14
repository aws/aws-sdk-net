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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.Glue.Model;

namespace Amazon.Glue
{
    /// <summary>
    /// Interface for accessing Glue
    ///
    /// Defines service operations used by the GlueFrontendService
    /// </summary>
    public partial interface IAmazonGlue : IAmazonService, IDisposable
    {
                
        #region  BatchCreatePartition


        /// <summary>
        /// Initiates the asynchronous execution of the BatchCreatePartition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchCreatePartition operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/BatchCreatePartition">REST API Reference for BatchCreatePartition Operation</seealso>
        Task<BatchCreatePartitionResponse> BatchCreatePartitionAsync(BatchCreatePartitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  BatchDeleteConnection


        /// <summary>
        /// Initiates the asynchronous execution of the BatchDeleteConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteConnection operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/BatchDeleteConnection">REST API Reference for BatchDeleteConnection Operation</seealso>
        Task<BatchDeleteConnectionResponse> BatchDeleteConnectionAsync(BatchDeleteConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  BatchDeletePartition


        /// <summary>
        /// Initiates the asynchronous execution of the BatchDeletePartition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchDeletePartition operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/BatchDeletePartition">REST API Reference for BatchDeletePartition Operation</seealso>
        Task<BatchDeletePartitionResponse> BatchDeletePartitionAsync(BatchDeletePartitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  BatchDeleteTable


        /// <summary>
        /// Initiates the asynchronous execution of the BatchDeleteTable operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteTable operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/BatchDeleteTable">REST API Reference for BatchDeleteTable Operation</seealso>
        Task<BatchDeleteTableResponse> BatchDeleteTableAsync(BatchDeleteTableRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  BatchGetPartition


        /// <summary>
        /// Initiates the asynchronous execution of the BatchGetPartition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchGetPartition operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/BatchGetPartition">REST API Reference for BatchGetPartition Operation</seealso>
        Task<BatchGetPartitionResponse> BatchGetPartitionAsync(BatchGetPartitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateClassifier


        /// <summary>
        /// Initiates the asynchronous execution of the CreateClassifier operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateClassifier operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CreateClassifier">REST API Reference for CreateClassifier Operation</seealso>
        Task<CreateClassifierResponse> CreateClassifierAsync(CreateClassifierRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateConnection


        /// <summary>
        /// Initiates the asynchronous execution of the CreateConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateConnection operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CreateConnection">REST API Reference for CreateConnection Operation</seealso>
        Task<CreateConnectionResponse> CreateConnectionAsync(CreateConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateCrawler


        /// <summary>
        /// Initiates the asynchronous execution of the CreateCrawler operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCrawler operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CreateCrawler">REST API Reference for CreateCrawler Operation</seealso>
        Task<CreateCrawlerResponse> CreateCrawlerAsync(CreateCrawlerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateDatabase


        /// <summary>
        /// Initiates the asynchronous execution of the CreateDatabase operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDatabase operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CreateDatabase">REST API Reference for CreateDatabase Operation</seealso>
        Task<CreateDatabaseResponse> CreateDatabaseAsync(CreateDatabaseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateDevEndpoint


        /// <summary>
        /// Initiates the asynchronous execution of the CreateDevEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDevEndpoint operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CreateDevEndpoint">REST API Reference for CreateDevEndpoint Operation</seealso>
        Task<CreateDevEndpointResponse> CreateDevEndpointAsync(CreateDevEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateJob


        /// <summary>
        /// Initiates the asynchronous execution of the CreateJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CreateJob">REST API Reference for CreateJob Operation</seealso>
        Task<CreateJobResponse> CreateJobAsync(CreateJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreatePartition


        /// <summary>
        /// Initiates the asynchronous execution of the CreatePartition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePartition operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CreatePartition">REST API Reference for CreatePartition Operation</seealso>
        Task<CreatePartitionResponse> CreatePartitionAsync(CreatePartitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateScript


        /// <summary>
        /// Initiates the asynchronous execution of the CreateScript operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateScript operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CreateScript">REST API Reference for CreateScript Operation</seealso>
        Task<CreateScriptResponse> CreateScriptAsync(CreateScriptRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateTable


        /// <summary>
        /// Initiates the asynchronous execution of the CreateTable operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTable operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CreateTable">REST API Reference for CreateTable Operation</seealso>
        Task<CreateTableResponse> CreateTableAsync(CreateTableRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateTrigger


        /// <summary>
        /// Initiates the asynchronous execution of the CreateTrigger operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTrigger operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CreateTrigger">REST API Reference for CreateTrigger Operation</seealso>
        Task<CreateTriggerResponse> CreateTriggerAsync(CreateTriggerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateUserDefinedFunction


        /// <summary>
        /// Initiates the asynchronous execution of the CreateUserDefinedFunction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateUserDefinedFunction operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CreateUserDefinedFunction">REST API Reference for CreateUserDefinedFunction Operation</seealso>
        Task<CreateUserDefinedFunctionResponse> CreateUserDefinedFunctionAsync(CreateUserDefinedFunctionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteClassifier


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteClassifier operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteClassifier operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteClassifier">REST API Reference for DeleteClassifier Operation</seealso>
        Task<DeleteClassifierResponse> DeleteClassifierAsync(DeleteClassifierRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteConnection


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteConnection operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteConnection">REST API Reference for DeleteConnection Operation</seealso>
        Task<DeleteConnectionResponse> DeleteConnectionAsync(DeleteConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteCrawler


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCrawler operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCrawler operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteCrawler">REST API Reference for DeleteCrawler Operation</seealso>
        Task<DeleteCrawlerResponse> DeleteCrawlerAsync(DeleteCrawlerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteDatabase


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDatabase operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDatabase operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteDatabase">REST API Reference for DeleteDatabase Operation</seealso>
        Task<DeleteDatabaseResponse> DeleteDatabaseAsync(DeleteDatabaseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteDevEndpoint


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDevEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDevEndpoint operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteDevEndpoint">REST API Reference for DeleteDevEndpoint Operation</seealso>
        Task<DeleteDevEndpointResponse> DeleteDevEndpointAsync(DeleteDevEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteJob


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteJob">REST API Reference for DeleteJob Operation</seealso>
        Task<DeleteJobResponse> DeleteJobAsync(DeleteJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeletePartition


        /// <summary>
        /// Initiates the asynchronous execution of the DeletePartition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePartition operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeletePartition">REST API Reference for DeletePartition Operation</seealso>
        Task<DeletePartitionResponse> DeletePartitionAsync(DeletePartitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteTable


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTable operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTable operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteTable">REST API Reference for DeleteTable Operation</seealso>
        Task<DeleteTableResponse> DeleteTableAsync(DeleteTableRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteTrigger


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTrigger operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTrigger operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteTrigger">REST API Reference for DeleteTrigger Operation</seealso>
        Task<DeleteTriggerResponse> DeleteTriggerAsync(DeleteTriggerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteUserDefinedFunction


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteUserDefinedFunction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteUserDefinedFunction operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteUserDefinedFunction">REST API Reference for DeleteUserDefinedFunction Operation</seealso>
        Task<DeleteUserDefinedFunctionResponse> DeleteUserDefinedFunctionAsync(DeleteUserDefinedFunctionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetCatalogImportStatus


        /// <summary>
        /// Initiates the asynchronous execution of the GetCatalogImportStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCatalogImportStatus operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetCatalogImportStatus">REST API Reference for GetCatalogImportStatus Operation</seealso>
        Task<GetCatalogImportStatusResponse> GetCatalogImportStatusAsync(GetCatalogImportStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetClassifier


        /// <summary>
        /// Initiates the asynchronous execution of the GetClassifier operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetClassifier operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetClassifier">REST API Reference for GetClassifier Operation</seealso>
        Task<GetClassifierResponse> GetClassifierAsync(GetClassifierRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetClassifiers


        /// <summary>
        /// Initiates the asynchronous execution of the GetClassifiers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetClassifiers operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetClassifiers">REST API Reference for GetClassifiers Operation</seealso>
        Task<GetClassifiersResponse> GetClassifiersAsync(GetClassifiersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetConnection


        /// <summary>
        /// Initiates the asynchronous execution of the GetConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetConnection operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetConnection">REST API Reference for GetConnection Operation</seealso>
        Task<GetConnectionResponse> GetConnectionAsync(GetConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetConnections


        /// <summary>
        /// Initiates the asynchronous execution of the GetConnections operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetConnections operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetConnections">REST API Reference for GetConnections Operation</seealso>
        Task<GetConnectionsResponse> GetConnectionsAsync(GetConnectionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetCrawler


        /// <summary>
        /// Initiates the asynchronous execution of the GetCrawler operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCrawler operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetCrawler">REST API Reference for GetCrawler Operation</seealso>
        Task<GetCrawlerResponse> GetCrawlerAsync(GetCrawlerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetCrawlerMetrics


        /// <summary>
        /// Initiates the asynchronous execution of the GetCrawlerMetrics operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCrawlerMetrics operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetCrawlerMetrics">REST API Reference for GetCrawlerMetrics Operation</seealso>
        Task<GetCrawlerMetricsResponse> GetCrawlerMetricsAsync(GetCrawlerMetricsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetCrawlers


        /// <summary>
        /// Initiates the asynchronous execution of the GetCrawlers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCrawlers operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetCrawlers">REST API Reference for GetCrawlers Operation</seealso>
        Task<GetCrawlersResponse> GetCrawlersAsync(GetCrawlersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetDatabase


        /// <summary>
        /// Initiates the asynchronous execution of the GetDatabase operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDatabase operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetDatabase">REST API Reference for GetDatabase Operation</seealso>
        Task<GetDatabaseResponse> GetDatabaseAsync(GetDatabaseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetDatabases


        /// <summary>
        /// Initiates the asynchronous execution of the GetDatabases operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDatabases operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetDatabases">REST API Reference for GetDatabases Operation</seealso>
        Task<GetDatabasesResponse> GetDatabasesAsync(GetDatabasesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetDataflowGraph


        /// <summary>
        /// Initiates the asynchronous execution of the GetDataflowGraph operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDataflowGraph operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetDataflowGraph">REST API Reference for GetDataflowGraph Operation</seealso>
        Task<GetDataflowGraphResponse> GetDataflowGraphAsync(GetDataflowGraphRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetDevEndpoint


        /// <summary>
        /// Initiates the asynchronous execution of the GetDevEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDevEndpoint operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetDevEndpoint">REST API Reference for GetDevEndpoint Operation</seealso>
        Task<GetDevEndpointResponse> GetDevEndpointAsync(GetDevEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetDevEndpoints


        /// <summary>
        /// Initiates the asynchronous execution of the GetDevEndpoints operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDevEndpoints operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetDevEndpoints">REST API Reference for GetDevEndpoints Operation</seealso>
        Task<GetDevEndpointsResponse> GetDevEndpointsAsync(GetDevEndpointsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetJob


        /// <summary>
        /// Initiates the asynchronous execution of the GetJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetJob">REST API Reference for GetJob Operation</seealso>
        Task<GetJobResponse> GetJobAsync(GetJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetJobRun


        /// <summary>
        /// Initiates the asynchronous execution of the GetJobRun operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetJobRun operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetJobRun">REST API Reference for GetJobRun Operation</seealso>
        Task<GetJobRunResponse> GetJobRunAsync(GetJobRunRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetJobRuns


        /// <summary>
        /// Initiates the asynchronous execution of the GetJobRuns operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetJobRuns operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetJobRuns">REST API Reference for GetJobRuns Operation</seealso>
        Task<GetJobRunsResponse> GetJobRunsAsync(GetJobRunsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetJobs


        /// <summary>
        /// Initiates the asynchronous execution of the GetJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetJobs operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetJobs">REST API Reference for GetJobs Operation</seealso>
        Task<GetJobsResponse> GetJobsAsync(GetJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetMapping


        /// <summary>
        /// Initiates the asynchronous execution of the GetMapping operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMapping operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetMapping">REST API Reference for GetMapping Operation</seealso>
        Task<GetMappingResponse> GetMappingAsync(GetMappingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetPartition


        /// <summary>
        /// Initiates the asynchronous execution of the GetPartition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPartition operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetPartition">REST API Reference for GetPartition Operation</seealso>
        Task<GetPartitionResponse> GetPartitionAsync(GetPartitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetPartitions


        /// <summary>
        /// Initiates the asynchronous execution of the GetPartitions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPartitions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetPartitions">REST API Reference for GetPartitions Operation</seealso>
        Task<GetPartitionsResponse> GetPartitionsAsync(GetPartitionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetPlan


        /// <summary>
        /// Initiates the asynchronous execution of the GetPlan operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPlan operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetPlan">REST API Reference for GetPlan Operation</seealso>
        Task<GetPlanResponse> GetPlanAsync(GetPlanRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetTable


        /// <summary>
        /// Initiates the asynchronous execution of the GetTable operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTable operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetTable">REST API Reference for GetTable Operation</seealso>
        Task<GetTableResponse> GetTableAsync(GetTableRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetTables


        /// <summary>
        /// Initiates the asynchronous execution of the GetTables operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTables operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetTables">REST API Reference for GetTables Operation</seealso>
        Task<GetTablesResponse> GetTablesAsync(GetTablesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetTableVersions


        /// <summary>
        /// Initiates the asynchronous execution of the GetTableVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTableVersions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetTableVersions">REST API Reference for GetTableVersions Operation</seealso>
        Task<GetTableVersionsResponse> GetTableVersionsAsync(GetTableVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetTrigger


        /// <summary>
        /// Initiates the asynchronous execution of the GetTrigger operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTrigger operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetTrigger">REST API Reference for GetTrigger Operation</seealso>
        Task<GetTriggerResponse> GetTriggerAsync(GetTriggerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetTriggers


        /// <summary>
        /// Initiates the asynchronous execution of the GetTriggers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTriggers operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetTriggers">REST API Reference for GetTriggers Operation</seealso>
        Task<GetTriggersResponse> GetTriggersAsync(GetTriggersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetUserDefinedFunction


        /// <summary>
        /// Initiates the asynchronous execution of the GetUserDefinedFunction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetUserDefinedFunction operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetUserDefinedFunction">REST API Reference for GetUserDefinedFunction Operation</seealso>
        Task<GetUserDefinedFunctionResponse> GetUserDefinedFunctionAsync(GetUserDefinedFunctionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetUserDefinedFunctions


        /// <summary>
        /// Initiates the asynchronous execution of the GetUserDefinedFunctions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetUserDefinedFunctions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetUserDefinedFunctions">REST API Reference for GetUserDefinedFunctions Operation</seealso>
        Task<GetUserDefinedFunctionsResponse> GetUserDefinedFunctionsAsync(GetUserDefinedFunctionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ImportCatalogToGlue


        /// <summary>
        /// Initiates the asynchronous execution of the ImportCatalogToGlue operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ImportCatalogToGlue operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/ImportCatalogToGlue">REST API Reference for ImportCatalogToGlue Operation</seealso>
        Task<ImportCatalogToGlueResponse> ImportCatalogToGlueAsync(ImportCatalogToGlueRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ResetJobBookmark


        /// <summary>
        /// Initiates the asynchronous execution of the ResetJobBookmark operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResetJobBookmark operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/ResetJobBookmark">REST API Reference for ResetJobBookmark Operation</seealso>
        Task<ResetJobBookmarkResponse> ResetJobBookmarkAsync(ResetJobBookmarkRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StartCrawler


        /// <summary>
        /// Initiates the asynchronous execution of the StartCrawler operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartCrawler operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/StartCrawler">REST API Reference for StartCrawler Operation</seealso>
        Task<StartCrawlerResponse> StartCrawlerAsync(StartCrawlerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StartCrawlerSchedule


        /// <summary>
        /// Initiates the asynchronous execution of the StartCrawlerSchedule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartCrawlerSchedule operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/StartCrawlerSchedule">REST API Reference for StartCrawlerSchedule Operation</seealso>
        Task<StartCrawlerScheduleResponse> StartCrawlerScheduleAsync(StartCrawlerScheduleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StartJobRun


        /// <summary>
        /// Initiates the asynchronous execution of the StartJobRun operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartJobRun operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/StartJobRun">REST API Reference for StartJobRun Operation</seealso>
        Task<StartJobRunResponse> StartJobRunAsync(StartJobRunRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StartTrigger


        /// <summary>
        /// Initiates the asynchronous execution of the StartTrigger operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartTrigger operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/StartTrigger">REST API Reference for StartTrigger Operation</seealso>
        Task<StartTriggerResponse> StartTriggerAsync(StartTriggerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StopCrawler


        /// <summary>
        /// Initiates the asynchronous execution of the StopCrawler operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopCrawler operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/StopCrawler">REST API Reference for StopCrawler Operation</seealso>
        Task<StopCrawlerResponse> StopCrawlerAsync(StopCrawlerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StopCrawlerSchedule


        /// <summary>
        /// Initiates the asynchronous execution of the StopCrawlerSchedule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopCrawlerSchedule operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/StopCrawlerSchedule">REST API Reference for StopCrawlerSchedule Operation</seealso>
        Task<StopCrawlerScheduleResponse> StopCrawlerScheduleAsync(StopCrawlerScheduleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StopTrigger


        /// <summary>
        /// Initiates the asynchronous execution of the StopTrigger operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopTrigger operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/StopTrigger">REST API Reference for StopTrigger Operation</seealso>
        Task<StopTriggerResponse> StopTriggerAsync(StopTriggerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateClassifier


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateClassifier operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateClassifier operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UpdateClassifier">REST API Reference for UpdateClassifier Operation</seealso>
        Task<UpdateClassifierResponse> UpdateClassifierAsync(UpdateClassifierRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateConnection


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateConnection operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UpdateConnection">REST API Reference for UpdateConnection Operation</seealso>
        Task<UpdateConnectionResponse> UpdateConnectionAsync(UpdateConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateCrawler


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateCrawler operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateCrawler operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UpdateCrawler">REST API Reference for UpdateCrawler Operation</seealso>
        Task<UpdateCrawlerResponse> UpdateCrawlerAsync(UpdateCrawlerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateCrawlerSchedule


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateCrawlerSchedule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateCrawlerSchedule operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UpdateCrawlerSchedule">REST API Reference for UpdateCrawlerSchedule Operation</seealso>
        Task<UpdateCrawlerScheduleResponse> UpdateCrawlerScheduleAsync(UpdateCrawlerScheduleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateDatabase


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDatabase operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDatabase operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UpdateDatabase">REST API Reference for UpdateDatabase Operation</seealso>
        Task<UpdateDatabaseResponse> UpdateDatabaseAsync(UpdateDatabaseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateDevEndpoint


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDevEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDevEndpoint operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UpdateDevEndpoint">REST API Reference for UpdateDevEndpoint Operation</seealso>
        Task<UpdateDevEndpointResponse> UpdateDevEndpointAsync(UpdateDevEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateJob


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UpdateJob">REST API Reference for UpdateJob Operation</seealso>
        Task<UpdateJobResponse> UpdateJobAsync(UpdateJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdatePartition


        /// <summary>
        /// Initiates the asynchronous execution of the UpdatePartition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdatePartition operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UpdatePartition">REST API Reference for UpdatePartition Operation</seealso>
        Task<UpdatePartitionResponse> UpdatePartitionAsync(UpdatePartitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateTable


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateTable operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateTable operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UpdateTable">REST API Reference for UpdateTable Operation</seealso>
        Task<UpdateTableResponse> UpdateTableAsync(UpdateTableRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateTrigger


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateTrigger operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateTrigger operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UpdateTrigger">REST API Reference for UpdateTrigger Operation</seealso>
        Task<UpdateTriggerResponse> UpdateTriggerAsync(UpdateTriggerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateUserDefinedFunction


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateUserDefinedFunction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateUserDefinedFunction operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UpdateUserDefinedFunction">REST API Reference for UpdateUserDefinedFunction Operation</seealso>
        Task<UpdateUserDefinedFunctionResponse> UpdateUserDefinedFunctionAsync(UpdateUserDefinedFunctionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}