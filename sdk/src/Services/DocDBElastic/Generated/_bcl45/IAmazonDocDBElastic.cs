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
 * Do not modify this file. This file is generated from the docdb-elastic-2022-11-28.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.DocDBElastic.Model;

namespace Amazon.DocDBElastic
{
    /// <summary>
    /// Interface for accessing DocDBElastic
    ///
    /// The new Amazon Elastic DocumentDB service endpoint.
    /// </summary>
    public partial interface IAmazonDocDBElastic : IAmazonService, IDisposable
    {

        /// <summary>
        /// Paginators for the service
        /// </summary>
        IDocDBElasticPaginatorFactory Paginators { get; }

        
        #region  CreateCluster


        /// <summary>
        /// Creates a new Elastic DocumentDB cluster and returns its Cluster structure.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCluster service method.</param>
        /// 
        /// <returns>The response from the CreateCluster service method, as returned by DocDBElastic.</returns>
        /// <exception cref="Amazon.DocDBElastic.Model.AccessDeniedException">
        /// An exception that occurs when there are not sufficient permissions to perform an action.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ConflictException">
        /// There was an access conflict.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.InternalServerException">
        /// There was an internal server error.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ServiceQuotaExceededException">
        /// The service quota for the action was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ThrottlingException">
        /// ThrottlingException will be thrown when request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ValidationException">
        /// A structure defining a validation exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-elastic-2022-11-28/CreateCluster">REST API Reference for CreateCluster Operation</seealso>
        CreateClusterResponse CreateCluster(CreateClusterRequest request);



        /// <summary>
        /// Creates a new Elastic DocumentDB cluster and returns its Cluster structure.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateCluster service method, as returned by DocDBElastic.</returns>
        /// <exception cref="Amazon.DocDBElastic.Model.AccessDeniedException">
        /// An exception that occurs when there are not sufficient permissions to perform an action.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ConflictException">
        /// There was an access conflict.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.InternalServerException">
        /// There was an internal server error.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ServiceQuotaExceededException">
        /// The service quota for the action was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ThrottlingException">
        /// ThrottlingException will be thrown when request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ValidationException">
        /// A structure defining a validation exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-elastic-2022-11-28/CreateCluster">REST API Reference for CreateCluster Operation</seealso>
        Task<CreateClusterResponse> CreateClusterAsync(CreateClusterRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateClusterSnapshot


        /// <summary>
        /// Creates a snapshot of a cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateClusterSnapshot service method.</param>
        /// 
        /// <returns>The response from the CreateClusterSnapshot service method, as returned by DocDBElastic.</returns>
        /// <exception cref="Amazon.DocDBElastic.Model.AccessDeniedException">
        /// An exception that occurs when there are not sufficient permissions to perform an action.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ConflictException">
        /// There was an access conflict.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.InternalServerException">
        /// There was an internal server error.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ResourceNotFoundException">
        /// The specified resource could not be located.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ServiceQuotaExceededException">
        /// The service quota for the action was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ThrottlingException">
        /// ThrottlingException will be thrown when request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ValidationException">
        /// A structure defining a validation exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-elastic-2022-11-28/CreateClusterSnapshot">REST API Reference for CreateClusterSnapshot Operation</seealso>
        CreateClusterSnapshotResponse CreateClusterSnapshot(CreateClusterSnapshotRequest request);



        /// <summary>
        /// Creates a snapshot of a cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateClusterSnapshot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateClusterSnapshot service method, as returned by DocDBElastic.</returns>
        /// <exception cref="Amazon.DocDBElastic.Model.AccessDeniedException">
        /// An exception that occurs when there are not sufficient permissions to perform an action.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ConflictException">
        /// There was an access conflict.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.InternalServerException">
        /// There was an internal server error.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ResourceNotFoundException">
        /// The specified resource could not be located.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ServiceQuotaExceededException">
        /// The service quota for the action was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ThrottlingException">
        /// ThrottlingException will be thrown when request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ValidationException">
        /// A structure defining a validation exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-elastic-2022-11-28/CreateClusterSnapshot">REST API Reference for CreateClusterSnapshot Operation</seealso>
        Task<CreateClusterSnapshotResponse> CreateClusterSnapshotAsync(CreateClusterSnapshotRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteCluster


        /// <summary>
        /// Delete a Elastic DocumentDB cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCluster service method.</param>
        /// 
        /// <returns>The response from the DeleteCluster service method, as returned by DocDBElastic.</returns>
        /// <exception cref="Amazon.DocDBElastic.Model.AccessDeniedException">
        /// An exception that occurs when there are not sufficient permissions to perform an action.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ConflictException">
        /// There was an access conflict.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.InternalServerException">
        /// There was an internal server error.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ResourceNotFoundException">
        /// The specified resource could not be located.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ThrottlingException">
        /// ThrottlingException will be thrown when request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ValidationException">
        /// A structure defining a validation exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-elastic-2022-11-28/DeleteCluster">REST API Reference for DeleteCluster Operation</seealso>
        DeleteClusterResponse DeleteCluster(DeleteClusterRequest request);



        /// <summary>
        /// Delete a Elastic DocumentDB cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteCluster service method, as returned by DocDBElastic.</returns>
        /// <exception cref="Amazon.DocDBElastic.Model.AccessDeniedException">
        /// An exception that occurs when there are not sufficient permissions to perform an action.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ConflictException">
        /// There was an access conflict.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.InternalServerException">
        /// There was an internal server error.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ResourceNotFoundException">
        /// The specified resource could not be located.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ThrottlingException">
        /// ThrottlingException will be thrown when request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ValidationException">
        /// A structure defining a validation exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-elastic-2022-11-28/DeleteCluster">REST API Reference for DeleteCluster Operation</seealso>
        Task<DeleteClusterResponse> DeleteClusterAsync(DeleteClusterRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteClusterSnapshot


        /// <summary>
        /// Delete a Elastic DocumentDB snapshot.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteClusterSnapshot service method.</param>
        /// 
        /// <returns>The response from the DeleteClusterSnapshot service method, as returned by DocDBElastic.</returns>
        /// <exception cref="Amazon.DocDBElastic.Model.AccessDeniedException">
        /// An exception that occurs when there are not sufficient permissions to perform an action.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ConflictException">
        /// There was an access conflict.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.InternalServerException">
        /// There was an internal server error.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ResourceNotFoundException">
        /// The specified resource could not be located.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ThrottlingException">
        /// ThrottlingException will be thrown when request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ValidationException">
        /// A structure defining a validation exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-elastic-2022-11-28/DeleteClusterSnapshot">REST API Reference for DeleteClusterSnapshot Operation</seealso>
        DeleteClusterSnapshotResponse DeleteClusterSnapshot(DeleteClusterSnapshotRequest request);



        /// <summary>
        /// Delete a Elastic DocumentDB snapshot.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteClusterSnapshot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteClusterSnapshot service method, as returned by DocDBElastic.</returns>
        /// <exception cref="Amazon.DocDBElastic.Model.AccessDeniedException">
        /// An exception that occurs when there are not sufficient permissions to perform an action.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ConflictException">
        /// There was an access conflict.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.InternalServerException">
        /// There was an internal server error.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ResourceNotFoundException">
        /// The specified resource could not be located.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ThrottlingException">
        /// ThrottlingException will be thrown when request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ValidationException">
        /// A structure defining a validation exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-elastic-2022-11-28/DeleteClusterSnapshot">REST API Reference for DeleteClusterSnapshot Operation</seealso>
        Task<DeleteClusterSnapshotResponse> DeleteClusterSnapshotAsync(DeleteClusterSnapshotRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetCluster


        /// <summary>
        /// Returns information about a specific Elastic DocumentDB cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCluster service method.</param>
        /// 
        /// <returns>The response from the GetCluster service method, as returned by DocDBElastic.</returns>
        /// <exception cref="Amazon.DocDBElastic.Model.AccessDeniedException">
        /// An exception that occurs when there are not sufficient permissions to perform an action.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.InternalServerException">
        /// There was an internal server error.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ResourceNotFoundException">
        /// The specified resource could not be located.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ThrottlingException">
        /// ThrottlingException will be thrown when request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ValidationException">
        /// A structure defining a validation exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-elastic-2022-11-28/GetCluster">REST API Reference for GetCluster Operation</seealso>
        GetClusterResponse GetCluster(GetClusterRequest request);



        /// <summary>
        /// Returns information about a specific Elastic DocumentDB cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCluster service method, as returned by DocDBElastic.</returns>
        /// <exception cref="Amazon.DocDBElastic.Model.AccessDeniedException">
        /// An exception that occurs when there are not sufficient permissions to perform an action.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.InternalServerException">
        /// There was an internal server error.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ResourceNotFoundException">
        /// The specified resource could not be located.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ThrottlingException">
        /// ThrottlingException will be thrown when request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ValidationException">
        /// A structure defining a validation exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-elastic-2022-11-28/GetCluster">REST API Reference for GetCluster Operation</seealso>
        Task<GetClusterResponse> GetClusterAsync(GetClusterRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetClusterSnapshot


        /// <summary>
        /// Returns information about a specific Elastic DocumentDB snapshot
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetClusterSnapshot service method.</param>
        /// 
        /// <returns>The response from the GetClusterSnapshot service method, as returned by DocDBElastic.</returns>
        /// <exception cref="Amazon.DocDBElastic.Model.AccessDeniedException">
        /// An exception that occurs when there are not sufficient permissions to perform an action.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.InternalServerException">
        /// There was an internal server error.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ResourceNotFoundException">
        /// The specified resource could not be located.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ThrottlingException">
        /// ThrottlingException will be thrown when request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ValidationException">
        /// A structure defining a validation exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-elastic-2022-11-28/GetClusterSnapshot">REST API Reference for GetClusterSnapshot Operation</seealso>
        GetClusterSnapshotResponse GetClusterSnapshot(GetClusterSnapshotRequest request);



        /// <summary>
        /// Returns information about a specific Elastic DocumentDB snapshot
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetClusterSnapshot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetClusterSnapshot service method, as returned by DocDBElastic.</returns>
        /// <exception cref="Amazon.DocDBElastic.Model.AccessDeniedException">
        /// An exception that occurs when there are not sufficient permissions to perform an action.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.InternalServerException">
        /// There was an internal server error.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ResourceNotFoundException">
        /// The specified resource could not be located.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ThrottlingException">
        /// ThrottlingException will be thrown when request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ValidationException">
        /// A structure defining a validation exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-elastic-2022-11-28/GetClusterSnapshot">REST API Reference for GetClusterSnapshot Operation</seealso>
        Task<GetClusterSnapshotResponse> GetClusterSnapshotAsync(GetClusterSnapshotRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListClusters


        /// <summary>
        /// Returns information about provisioned Elastic DocumentDB clusters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListClusters service method.</param>
        /// 
        /// <returns>The response from the ListClusters service method, as returned by DocDBElastic.</returns>
        /// <exception cref="Amazon.DocDBElastic.Model.AccessDeniedException">
        /// An exception that occurs when there are not sufficient permissions to perform an action.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.InternalServerException">
        /// There was an internal server error.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ThrottlingException">
        /// ThrottlingException will be thrown when request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ValidationException">
        /// A structure defining a validation exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-elastic-2022-11-28/ListClusters">REST API Reference for ListClusters Operation</seealso>
        ListClustersResponse ListClusters(ListClustersRequest request);



        /// <summary>
        /// Returns information about provisioned Elastic DocumentDB clusters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListClusters service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListClusters service method, as returned by DocDBElastic.</returns>
        /// <exception cref="Amazon.DocDBElastic.Model.AccessDeniedException">
        /// An exception that occurs when there are not sufficient permissions to perform an action.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.InternalServerException">
        /// There was an internal server error.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ThrottlingException">
        /// ThrottlingException will be thrown when request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ValidationException">
        /// A structure defining a validation exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-elastic-2022-11-28/ListClusters">REST API Reference for ListClusters Operation</seealso>
        Task<ListClustersResponse> ListClustersAsync(ListClustersRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListClusterSnapshots


        /// <summary>
        /// Returns information about Elastic DocumentDB snapshots for a specified cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListClusterSnapshots service method.</param>
        /// 
        /// <returns>The response from the ListClusterSnapshots service method, as returned by DocDBElastic.</returns>
        /// <exception cref="Amazon.DocDBElastic.Model.AccessDeniedException">
        /// An exception that occurs when there are not sufficient permissions to perform an action.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.InternalServerException">
        /// There was an internal server error.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ThrottlingException">
        /// ThrottlingException will be thrown when request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ValidationException">
        /// A structure defining a validation exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-elastic-2022-11-28/ListClusterSnapshots">REST API Reference for ListClusterSnapshots Operation</seealso>
        ListClusterSnapshotsResponse ListClusterSnapshots(ListClusterSnapshotsRequest request);



        /// <summary>
        /// Returns information about Elastic DocumentDB snapshots for a specified cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListClusterSnapshots service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListClusterSnapshots service method, as returned by DocDBElastic.</returns>
        /// <exception cref="Amazon.DocDBElastic.Model.AccessDeniedException">
        /// An exception that occurs when there are not sufficient permissions to perform an action.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.InternalServerException">
        /// There was an internal server error.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ThrottlingException">
        /// ThrottlingException will be thrown when request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ValidationException">
        /// A structure defining a validation exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-elastic-2022-11-28/ListClusterSnapshots">REST API Reference for ListClusterSnapshots Operation</seealso>
        Task<ListClusterSnapshotsResponse> ListClusterSnapshotsAsync(ListClusterSnapshotsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists all tags on a Elastic DocumentDB resource
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by DocDBElastic.</returns>
        /// <exception cref="Amazon.DocDBElastic.Model.InternalServerException">
        /// There was an internal server error.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ResourceNotFoundException">
        /// The specified resource could not be located.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ThrottlingException">
        /// ThrottlingException will be thrown when request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ValidationException">
        /// A structure defining a validation exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-elastic-2022-11-28/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);



        /// <summary>
        /// Lists all tags on a Elastic DocumentDB resource
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by DocDBElastic.</returns>
        /// <exception cref="Amazon.DocDBElastic.Model.InternalServerException">
        /// There was an internal server error.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ResourceNotFoundException">
        /// The specified resource could not be located.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ThrottlingException">
        /// ThrottlingException will be thrown when request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ValidationException">
        /// A structure defining a validation exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-elastic-2022-11-28/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RestoreClusterFromSnapshot


        /// <summary>
        /// Restores a Elastic DocumentDB cluster from a snapshot.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RestoreClusterFromSnapshot service method.</param>
        /// 
        /// <returns>The response from the RestoreClusterFromSnapshot service method, as returned by DocDBElastic.</returns>
        /// <exception cref="Amazon.DocDBElastic.Model.AccessDeniedException">
        /// An exception that occurs when there are not sufficient permissions to perform an action.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ConflictException">
        /// There was an access conflict.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.InternalServerException">
        /// There was an internal server error.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ResourceNotFoundException">
        /// The specified resource could not be located.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ServiceQuotaExceededException">
        /// The service quota for the action was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ThrottlingException">
        /// ThrottlingException will be thrown when request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ValidationException">
        /// A structure defining a validation exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-elastic-2022-11-28/RestoreClusterFromSnapshot">REST API Reference for RestoreClusterFromSnapshot Operation</seealso>
        RestoreClusterFromSnapshotResponse RestoreClusterFromSnapshot(RestoreClusterFromSnapshotRequest request);



        /// <summary>
        /// Restores a Elastic DocumentDB cluster from a snapshot.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RestoreClusterFromSnapshot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RestoreClusterFromSnapshot service method, as returned by DocDBElastic.</returns>
        /// <exception cref="Amazon.DocDBElastic.Model.AccessDeniedException">
        /// An exception that occurs when there are not sufficient permissions to perform an action.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ConflictException">
        /// There was an access conflict.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.InternalServerException">
        /// There was an internal server error.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ResourceNotFoundException">
        /// The specified resource could not be located.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ServiceQuotaExceededException">
        /// The service quota for the action was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ThrottlingException">
        /// ThrottlingException will be thrown when request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ValidationException">
        /// A structure defining a validation exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-elastic-2022-11-28/RestoreClusterFromSnapshot">REST API Reference for RestoreClusterFromSnapshot Operation</seealso>
        Task<RestoreClusterFromSnapshotResponse> RestoreClusterFromSnapshotAsync(RestoreClusterFromSnapshotRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Adds metadata tags to a Elastic DocumentDB resource
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by DocDBElastic.</returns>
        /// <exception cref="Amazon.DocDBElastic.Model.InternalServerException">
        /// There was an internal server error.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ResourceNotFoundException">
        /// The specified resource could not be located.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ThrottlingException">
        /// ThrottlingException will be thrown when request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ValidationException">
        /// A structure defining a validation exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-elastic-2022-11-28/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);



        /// <summary>
        /// Adds metadata tags to a Elastic DocumentDB resource
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by DocDBElastic.</returns>
        /// <exception cref="Amazon.DocDBElastic.Model.InternalServerException">
        /// There was an internal server error.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ResourceNotFoundException">
        /// The specified resource could not be located.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ThrottlingException">
        /// ThrottlingException will be thrown when request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ValidationException">
        /// A structure defining a validation exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-elastic-2022-11-28/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes metadata tags to a Elastic DocumentDB resource
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by DocDBElastic.</returns>
        /// <exception cref="Amazon.DocDBElastic.Model.InternalServerException">
        /// There was an internal server error.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ResourceNotFoundException">
        /// The specified resource could not be located.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ThrottlingException">
        /// ThrottlingException will be thrown when request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ValidationException">
        /// A structure defining a validation exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-elastic-2022-11-28/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);



        /// <summary>
        /// Removes metadata tags to a Elastic DocumentDB resource
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by DocDBElastic.</returns>
        /// <exception cref="Amazon.DocDBElastic.Model.InternalServerException">
        /// There was an internal server error.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ResourceNotFoundException">
        /// The specified resource could not be located.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ThrottlingException">
        /// ThrottlingException will be thrown when request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ValidationException">
        /// A structure defining a validation exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-elastic-2022-11-28/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateCluster


        /// <summary>
        /// Modifies a Elastic DocumentDB cluster. This includes updating admin-username/password,
        /// upgrading API version setting up a backup window and maintenance window
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCluster service method.</param>
        /// 
        /// <returns>The response from the UpdateCluster service method, as returned by DocDBElastic.</returns>
        /// <exception cref="Amazon.DocDBElastic.Model.AccessDeniedException">
        /// An exception that occurs when there are not sufficient permissions to perform an action.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ConflictException">
        /// There was an access conflict.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.InternalServerException">
        /// There was an internal server error.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ResourceNotFoundException">
        /// The specified resource could not be located.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ThrottlingException">
        /// ThrottlingException will be thrown when request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ValidationException">
        /// A structure defining a validation exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-elastic-2022-11-28/UpdateCluster">REST API Reference for UpdateCluster Operation</seealso>
        UpdateClusterResponse UpdateCluster(UpdateClusterRequest request);



        /// <summary>
        /// Modifies a Elastic DocumentDB cluster. This includes updating admin-username/password,
        /// upgrading API version setting up a backup window and maintenance window
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateCluster service method, as returned by DocDBElastic.</returns>
        /// <exception cref="Amazon.DocDBElastic.Model.AccessDeniedException">
        /// An exception that occurs when there are not sufficient permissions to perform an action.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ConflictException">
        /// There was an access conflict.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.InternalServerException">
        /// There was an internal server error.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ResourceNotFoundException">
        /// The specified resource could not be located.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ThrottlingException">
        /// ThrottlingException will be thrown when request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ValidationException">
        /// A structure defining a validation exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-elastic-2022-11-28/UpdateCluster">REST API Reference for UpdateCluster Operation</seealso>
        Task<UpdateClusterResponse> UpdateClusterAsync(UpdateClusterRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}