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
 * Do not modify this file. This file is generated from the AWSMigrationHub-2017-05-31.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.MigrationHub.Model;

namespace Amazon.MigrationHub
{
    /// <summary>
    /// Interface for accessing MigrationHub
    ///
    /// The AWS Migration Hub API methods help to obtain server and application migration
    /// status and integrate your resource-specific migration tool by providing a programmatic
    /// interface to Migration Hub.
    /// </summary>
    public partial interface IAmazonMigrationHub : IAmazonService, IDisposable
    {
                
        #region  AssociateCreatedArtifact


        /// <summary>
        /// Initiates the asynchronous execution of the AssociateCreatedArtifact operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateCreatedArtifact operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSMigrationHub-2017-05-31/AssociateCreatedArtifact">REST API Reference for AssociateCreatedArtifact Operation</seealso>
        Task<AssociateCreatedArtifactResponse> AssociateCreatedArtifactAsync(AssociateCreatedArtifactRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  AssociateDiscoveredResource


        /// <summary>
        /// Initiates the asynchronous execution of the AssociateDiscoveredResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateDiscoveredResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSMigrationHub-2017-05-31/AssociateDiscoveredResource">REST API Reference for AssociateDiscoveredResource Operation</seealso>
        Task<AssociateDiscoveredResourceResponse> AssociateDiscoveredResourceAsync(AssociateDiscoveredResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateProgressUpdateStream


        /// <summary>
        /// Initiates the asynchronous execution of the CreateProgressUpdateStream operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateProgressUpdateStream operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSMigrationHub-2017-05-31/CreateProgressUpdateStream">REST API Reference for CreateProgressUpdateStream Operation</seealso>
        Task<CreateProgressUpdateStreamResponse> CreateProgressUpdateStreamAsync(CreateProgressUpdateStreamRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteProgressUpdateStream


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteProgressUpdateStream operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteProgressUpdateStream operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSMigrationHub-2017-05-31/DeleteProgressUpdateStream">REST API Reference for DeleteProgressUpdateStream Operation</seealso>
        Task<DeleteProgressUpdateStreamResponse> DeleteProgressUpdateStreamAsync(DeleteProgressUpdateStreamRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeApplicationState


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeApplicationState operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeApplicationState operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSMigrationHub-2017-05-31/DescribeApplicationState">REST API Reference for DescribeApplicationState Operation</seealso>
        Task<DescribeApplicationStateResponse> DescribeApplicationStateAsync(DescribeApplicationStateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeMigrationTask


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeMigrationTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeMigrationTask operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSMigrationHub-2017-05-31/DescribeMigrationTask">REST API Reference for DescribeMigrationTask Operation</seealso>
        Task<DescribeMigrationTaskResponse> DescribeMigrationTaskAsync(DescribeMigrationTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DisassociateCreatedArtifact


        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateCreatedArtifact operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateCreatedArtifact operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSMigrationHub-2017-05-31/DisassociateCreatedArtifact">REST API Reference for DisassociateCreatedArtifact Operation</seealso>
        Task<DisassociateCreatedArtifactResponse> DisassociateCreatedArtifactAsync(DisassociateCreatedArtifactRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DisassociateDiscoveredResource


        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateDiscoveredResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateDiscoveredResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSMigrationHub-2017-05-31/DisassociateDiscoveredResource">REST API Reference for DisassociateDiscoveredResource Operation</seealso>
        Task<DisassociateDiscoveredResourceResponse> DisassociateDiscoveredResourceAsync(DisassociateDiscoveredResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ImportMigrationTask


        /// <summary>
        /// Initiates the asynchronous execution of the ImportMigrationTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ImportMigrationTask operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSMigrationHub-2017-05-31/ImportMigrationTask">REST API Reference for ImportMigrationTask Operation</seealso>
        Task<ImportMigrationTaskResponse> ImportMigrationTaskAsync(ImportMigrationTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListCreatedArtifacts


        /// <summary>
        /// Initiates the asynchronous execution of the ListCreatedArtifacts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCreatedArtifacts operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSMigrationHub-2017-05-31/ListCreatedArtifacts">REST API Reference for ListCreatedArtifacts Operation</seealso>
        Task<ListCreatedArtifactsResponse> ListCreatedArtifactsAsync(ListCreatedArtifactsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListDiscoveredResources


        /// <summary>
        /// Initiates the asynchronous execution of the ListDiscoveredResources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDiscoveredResources operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSMigrationHub-2017-05-31/ListDiscoveredResources">REST API Reference for ListDiscoveredResources Operation</seealso>
        Task<ListDiscoveredResourcesResponse> ListDiscoveredResourcesAsync(ListDiscoveredResourcesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListMigrationTasks


        /// <summary>
        /// Initiates the asynchronous execution of the ListMigrationTasks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMigrationTasks operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSMigrationHub-2017-05-31/ListMigrationTasks">REST API Reference for ListMigrationTasks Operation</seealso>
        Task<ListMigrationTasksResponse> ListMigrationTasksAsync(ListMigrationTasksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListProgressUpdateStreams


        /// <summary>
        /// Initiates the asynchronous execution of the ListProgressUpdateStreams operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListProgressUpdateStreams operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSMigrationHub-2017-05-31/ListProgressUpdateStreams">REST API Reference for ListProgressUpdateStreams Operation</seealso>
        Task<ListProgressUpdateStreamsResponse> ListProgressUpdateStreamsAsync(ListProgressUpdateStreamsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  NotifyApplicationState


        /// <summary>
        /// Initiates the asynchronous execution of the NotifyApplicationState operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the NotifyApplicationState operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSMigrationHub-2017-05-31/NotifyApplicationState">REST API Reference for NotifyApplicationState Operation</seealso>
        Task<NotifyApplicationStateResponse> NotifyApplicationStateAsync(NotifyApplicationStateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  NotifyMigrationTaskState


        /// <summary>
        /// Initiates the asynchronous execution of the NotifyMigrationTaskState operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the NotifyMigrationTaskState operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSMigrationHub-2017-05-31/NotifyMigrationTaskState">REST API Reference for NotifyMigrationTaskState Operation</seealso>
        Task<NotifyMigrationTaskStateResponse> NotifyMigrationTaskStateAsync(NotifyMigrationTaskStateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutResourceAttributes


        /// <summary>
        /// Initiates the asynchronous execution of the PutResourceAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutResourceAttributes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSMigrationHub-2017-05-31/PutResourceAttributes">REST API Reference for PutResourceAttributes Operation</seealso>
        Task<PutResourceAttributesResponse> PutResourceAttributesAsync(PutResourceAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}