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


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IDocDBElasticPaginatorFactory Paginators { get; }
#endif


        
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
        /// Initiates the asynchronous execution of the CreateCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCluster operation on AmazonDocDBElasticClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateCluster
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-elastic-2022-11-28/CreateCluster">REST API Reference for CreateCluster Operation</seealso>
        IAsyncResult BeginCreateCluster(CreateClusterRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateCluster operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCluster.</param>
        /// 
        /// <returns>Returns a  CreateClusterResult from DocDBElastic.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-elastic-2022-11-28/CreateCluster">REST API Reference for CreateCluster Operation</seealso>
        CreateClusterResponse EndCreateCluster(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the CreateClusterSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateClusterSnapshot operation on AmazonDocDBElasticClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateClusterSnapshot
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-elastic-2022-11-28/CreateClusterSnapshot">REST API Reference for CreateClusterSnapshot Operation</seealso>
        IAsyncResult BeginCreateClusterSnapshot(CreateClusterSnapshotRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateClusterSnapshot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateClusterSnapshot.</param>
        /// 
        /// <returns>Returns a  CreateClusterSnapshotResult from DocDBElastic.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-elastic-2022-11-28/CreateClusterSnapshot">REST API Reference for CreateClusterSnapshot Operation</seealso>
        CreateClusterSnapshotResponse EndCreateClusterSnapshot(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the DeleteCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCluster operation on AmazonDocDBElasticClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteCluster
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-elastic-2022-11-28/DeleteCluster">REST API Reference for DeleteCluster Operation</seealso>
        IAsyncResult BeginDeleteCluster(DeleteClusterRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteCluster operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCluster.</param>
        /// 
        /// <returns>Returns a  DeleteClusterResult from DocDBElastic.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-elastic-2022-11-28/DeleteCluster">REST API Reference for DeleteCluster Operation</seealso>
        DeleteClusterResponse EndDeleteCluster(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the DeleteClusterSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteClusterSnapshot operation on AmazonDocDBElasticClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteClusterSnapshot
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-elastic-2022-11-28/DeleteClusterSnapshot">REST API Reference for DeleteClusterSnapshot Operation</seealso>
        IAsyncResult BeginDeleteClusterSnapshot(DeleteClusterSnapshotRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteClusterSnapshot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteClusterSnapshot.</param>
        /// 
        /// <returns>Returns a  DeleteClusterSnapshotResult from DocDBElastic.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-elastic-2022-11-28/DeleteClusterSnapshot">REST API Reference for DeleteClusterSnapshot Operation</seealso>
        DeleteClusterSnapshotResponse EndDeleteClusterSnapshot(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the GetCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCluster operation on AmazonDocDBElasticClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCluster
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-elastic-2022-11-28/GetCluster">REST API Reference for GetCluster Operation</seealso>
        IAsyncResult BeginGetCluster(GetClusterRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetCluster operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCluster.</param>
        /// 
        /// <returns>Returns a  GetClusterResult from DocDBElastic.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-elastic-2022-11-28/GetCluster">REST API Reference for GetCluster Operation</seealso>
        GetClusterResponse EndGetCluster(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the GetClusterSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetClusterSnapshot operation on AmazonDocDBElasticClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetClusterSnapshot
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-elastic-2022-11-28/GetClusterSnapshot">REST API Reference for GetClusterSnapshot Operation</seealso>
        IAsyncResult BeginGetClusterSnapshot(GetClusterSnapshotRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetClusterSnapshot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetClusterSnapshot.</param>
        /// 
        /// <returns>Returns a  GetClusterSnapshotResult from DocDBElastic.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-elastic-2022-11-28/GetClusterSnapshot">REST API Reference for GetClusterSnapshot Operation</seealso>
        GetClusterSnapshotResponse EndGetClusterSnapshot(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the ListClusters operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListClusters operation on AmazonDocDBElasticClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListClusters
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-elastic-2022-11-28/ListClusters">REST API Reference for ListClusters Operation</seealso>
        IAsyncResult BeginListClusters(ListClustersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListClusters operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListClusters.</param>
        /// 
        /// <returns>Returns a  ListClustersResult from DocDBElastic.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-elastic-2022-11-28/ListClusters">REST API Reference for ListClusters Operation</seealso>
        ListClustersResponse EndListClusters(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the ListClusterSnapshots operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListClusterSnapshots operation on AmazonDocDBElasticClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListClusterSnapshots
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-elastic-2022-11-28/ListClusterSnapshots">REST API Reference for ListClusterSnapshots Operation</seealso>
        IAsyncResult BeginListClusterSnapshots(ListClusterSnapshotsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListClusterSnapshots operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListClusterSnapshots.</param>
        /// 
        /// <returns>Returns a  ListClusterSnapshotsResult from DocDBElastic.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-elastic-2022-11-28/ListClusterSnapshots">REST API Reference for ListClusterSnapshots Operation</seealso>
        ListClusterSnapshotsResponse EndListClusterSnapshots(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonDocDBElasticClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-elastic-2022-11-28/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from DocDBElastic.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-elastic-2022-11-28/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the RestoreClusterFromSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RestoreClusterFromSnapshot operation on AmazonDocDBElasticClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRestoreClusterFromSnapshot
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-elastic-2022-11-28/RestoreClusterFromSnapshot">REST API Reference for RestoreClusterFromSnapshot Operation</seealso>
        IAsyncResult BeginRestoreClusterFromSnapshot(RestoreClusterFromSnapshotRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RestoreClusterFromSnapshot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRestoreClusterFromSnapshot.</param>
        /// 
        /// <returns>Returns a  RestoreClusterFromSnapshotResult from DocDBElastic.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-elastic-2022-11-28/RestoreClusterFromSnapshot">REST API Reference for RestoreClusterFromSnapshot Operation</seealso>
        RestoreClusterFromSnapshotResponse EndRestoreClusterFromSnapshot(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonDocDBElasticClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-elastic-2022-11-28/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from DocDBElastic.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-elastic-2022-11-28/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonDocDBElasticClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-elastic-2022-11-28/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from DocDBElastic.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-elastic-2022-11-28/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the UpdateCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateCluster operation on AmazonDocDBElasticClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateCluster
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-elastic-2022-11-28/UpdateCluster">REST API Reference for UpdateCluster Operation</seealso>
        IAsyncResult BeginUpdateCluster(UpdateClusterRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateCluster operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateCluster.</param>
        /// 
        /// <returns>Returns a  UpdateClusterResult from DocDBElastic.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-elastic-2022-11-28/UpdateCluster">REST API Reference for UpdateCluster Operation</seealso>
        UpdateClusterResponse EndUpdateCluster(IAsyncResult asyncResult);

        #endregion
        
    }
}