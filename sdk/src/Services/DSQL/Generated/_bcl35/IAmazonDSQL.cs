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
 * Do not modify this file. This file is generated from the dsql-2018-05-10.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.DSQL.Model;

#pragma warning disable CS1570
namespace Amazon.DSQL
{
    /// <summary>
    /// <para>Interface for accessing DSQL</para>
    ///
    /// This is an interface reference for Amazon Aurora DSQL. It contains documentation for
    /// one of the programming or command line interfaces you can use to manage Amazon Aurora
    /// DSQL.
    /// 
    ///  
    /// <para>
    /// Amazon Aurora DSQL is a serverless, distributed SQL database suitable for workloads
    /// of any size. is available in both single-Region and multi-Region configurations, so
    /// your clusters and databases are always available even if an Availability Zone or an
    /// Amazon Web Services Region are unavailable. lets you focus on using your data to acquire
    /// new insights for your business and customers.
    /// </para>
    /// </summary>
    public partial interface IAmazonDSQL : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IDSQLPaginatorFactory Paginators { get; }
#endif


        
        #region  CreateCluster


        /// <summary>
        /// This operation creates a cluster in Amazon Aurora DSQL. You need the following permissions
        /// to use this operation.
        /// 
        ///  
        /// <para>
        /// Permission to create a cluster.
        /// </para>
        ///  <dl> <dt>dsql:CreateCluster</dt> <dd> 
        /// <para>
        /// Resources: arn:aws:dsql:<i>region</i>:<i>account-id</i>:cluster/*
        /// </para>
        ///  </dd> </dl> 
        /// <para>
        ///  Permission to add tags to a resource.
        /// </para>
        ///  <dl> <dt>dsql:TagResource</dt> <dd> 
        /// <para>
        /// Resources: arn:aws:dsql:<i>region</i>:<i>account-id</i>:cluster/*
        /// </para>
        ///  </dd> </dl> 
        /// <para>
        /// Permission to configure multi-region properties for a cluster.
        /// </para>
        ///  <dl> <dt>dsql:PutMultiRegionProperties</dt> <dd> 
        /// <para>
        /// Resources: arn:aws:dsql:<i>region</i>:<i>account-id</i>:cluster/*
        /// </para>
        ///  </dd> </dl> 
        /// <para>
        /// When specifying multiRegionProperties.clusters.
        /// </para>
        ///  <dl> <dt>dsql:AddPeerCluster</dt> <dd> 
        /// <para>
        /// Permission to add peer clusters.
        /// </para>
        ///  
        /// <para>
        /// Resources:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Local cluster: arn:aws:dsql:<i>region</i>:<i>account-id</i>:cluster/*
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Each peer cluster: exact ARN of each specified peer cluster
        /// </para>
        ///  </li> </ul> </dd> </dl> 
        /// <para>
        /// When specifying multiRegionProperties.witnessRegion.
        /// </para>
        ///  <dl> <dt>dsql:PutWitnessRegion</dt> <dd> 
        /// <para>
        /// Permission to set a witness region.
        /// </para>
        ///  
        /// <para>
        /// Resources: arn:aws:dsql:<i>region</i>:<i>account-id</i>:cluster/*
        /// </para>
        ///  
        /// <para>
        /// Condition Keys: <c>dsql:WitnessRegion</c> (matching the specified witness region)
        /// </para>
        ///  <note> 
        /// <para>
        /// This permission is checked both in the cluster Region and in the witness Region.
        /// </para>
        ///  </note> </dd> </dl> <important> 
        /// <para>
        ///  <b>Important Notes for Multi-Region Operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The witness region specified in <c>multiRegionProperties.witnessRegion</c> cannot
        /// be the same as the cluster's Region.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// When updating clusters with peer relationships, permissions are checked for both adding
        /// and removing peers.
        /// </para>
        ///  </li> </ul> </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCluster service method.</param>
        /// 
        /// <returns>The response from the CreateCluster service method, as returned by DSQL.</returns>
        /// <exception cref="Amazon.DSQL.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DSQL.Model.ConflictException">
        /// The submitted action has conflicts.
        /// </exception>
        /// <exception cref="Amazon.DSQL.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DSQL.Model.ServiceQuotaExceededException">
        /// The service limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DSQL.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DSQL.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dsql-2018-05-10/CreateCluster">REST API Reference for CreateCluster Operation</seealso>
        CreateClusterResponse CreateCluster(CreateClusterRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCluster operation on AmazonDSQLClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateCluster
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dsql-2018-05-10/CreateCluster">REST API Reference for CreateCluster Operation</seealso>
        IAsyncResult BeginCreateCluster(CreateClusterRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateCluster operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCluster.</param>
        /// 
        /// <returns>Returns a  CreateClusterResult from DSQL.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dsql-2018-05-10/CreateCluster">REST API Reference for CreateCluster Operation</seealso>
        CreateClusterResponse EndCreateCluster(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateMultiRegionClusters


        /// <summary>
        /// Creates multi-Region clusters in Amazon Aurora DSQL. Multi-Region clusters require
        /// a linked Region list, which is an array of the Regions in which you want to create
        /// linked clusters. Multi-Region clusters require a witness Region, which participates
        /// in quorum in failure scenarios.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMultiRegionClusters service method.</param>
        /// 
        /// <returns>The response from the CreateMultiRegionClusters service method, as returned by DSQL.</returns>
        /// <exception cref="Amazon.DSQL.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DSQL.Model.ConflictException">
        /// The submitted action has conflicts.
        /// </exception>
        /// <exception cref="Amazon.DSQL.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DSQL.Model.ServiceQuotaExceededException">
        /// The service limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DSQL.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DSQL.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dsql-2018-05-10/CreateMultiRegionClusters">REST API Reference for CreateMultiRegionClusters Operation</seealso>
        [Obsolete("The CreateMultiRegionClusters API is deprecated. Use the CreateCluster API with multi-Region properties to create a multi-Region cluster.")]
        CreateMultiRegionClustersResponse CreateMultiRegionClusters(CreateMultiRegionClustersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateMultiRegionClusters operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateMultiRegionClusters operation on AmazonDSQLClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateMultiRegionClusters
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dsql-2018-05-10/CreateMultiRegionClusters">REST API Reference for CreateMultiRegionClusters Operation</seealso>
        [Obsolete("The CreateMultiRegionClusters API is deprecated. Use the CreateCluster API with multi-Region properties to create a multi-Region cluster.")]
        IAsyncResult BeginCreateMultiRegionClusters(CreateMultiRegionClustersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateMultiRegionClusters operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateMultiRegionClusters.</param>
        /// 
        /// <returns>Returns a  CreateMultiRegionClustersResult from DSQL.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dsql-2018-05-10/CreateMultiRegionClusters">REST API Reference for CreateMultiRegionClusters Operation</seealso>
        [Obsolete("The CreateMultiRegionClusters API is deprecated. Use the CreateCluster API with multi-Region properties to create a multi-Region cluster.")]
        CreateMultiRegionClustersResponse EndCreateMultiRegionClusters(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteCluster


        /// <summary>
        /// Deletes a cluster in Amazon Aurora DSQL.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCluster service method.</param>
        /// 
        /// <returns>The response from the DeleteCluster service method, as returned by DSQL.</returns>
        /// <exception cref="Amazon.DSQL.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DSQL.Model.ConflictException">
        /// The submitted action has conflicts.
        /// </exception>
        /// <exception cref="Amazon.DSQL.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DSQL.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DSQL.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DSQL.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dsql-2018-05-10/DeleteCluster">REST API Reference for DeleteCluster Operation</seealso>
        DeleteClusterResponse DeleteCluster(DeleteClusterRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCluster operation on AmazonDSQLClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteCluster
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dsql-2018-05-10/DeleteCluster">REST API Reference for DeleteCluster Operation</seealso>
        IAsyncResult BeginDeleteCluster(DeleteClusterRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteCluster operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCluster.</param>
        /// 
        /// <returns>Returns a  DeleteClusterResult from DSQL.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dsql-2018-05-10/DeleteCluster">REST API Reference for DeleteCluster Operation</seealso>
        DeleteClusterResponse EndDeleteCluster(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteMultiRegionClusters


        /// <summary>
        /// Deletes a multi-Region cluster in Amazon Aurora DSQL.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMultiRegionClusters service method.</param>
        /// 
        /// <returns>The response from the DeleteMultiRegionClusters service method, as returned by DSQL.</returns>
        /// <exception cref="Amazon.DSQL.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DSQL.Model.ConflictException">
        /// The submitted action has conflicts.
        /// </exception>
        /// <exception cref="Amazon.DSQL.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DSQL.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DSQL.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DSQL.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dsql-2018-05-10/DeleteMultiRegionClusters">REST API Reference for DeleteMultiRegionClusters Operation</seealso>
        [Obsolete("The DeleteMultiRegionClusters API is deprecated. To delete a multi-Region cluster, use the DeleteCluster API instead.")]
        DeleteMultiRegionClustersResponse DeleteMultiRegionClusters(DeleteMultiRegionClustersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteMultiRegionClusters operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteMultiRegionClusters operation on AmazonDSQLClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteMultiRegionClusters
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dsql-2018-05-10/DeleteMultiRegionClusters">REST API Reference for DeleteMultiRegionClusters Operation</seealso>
        [Obsolete("The DeleteMultiRegionClusters API is deprecated. To delete a multi-Region cluster, use the DeleteCluster API instead.")]
        IAsyncResult BeginDeleteMultiRegionClusters(DeleteMultiRegionClustersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteMultiRegionClusters operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteMultiRegionClusters.</param>
        /// 
        /// <returns>Returns a  DeleteMultiRegionClustersResult from DSQL.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dsql-2018-05-10/DeleteMultiRegionClusters">REST API Reference for DeleteMultiRegionClusters Operation</seealso>
        [Obsolete("The DeleteMultiRegionClusters API is deprecated. To delete a multi-Region cluster, use the DeleteCluster API instead.")]
        DeleteMultiRegionClustersResponse EndDeleteMultiRegionClusters(IAsyncResult asyncResult);

        #endregion
        
        #region  GetCluster


        /// <summary>
        /// Retrieves information about a cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCluster service method.</param>
        /// 
        /// <returns>The response from the GetCluster service method, as returned by DSQL.</returns>
        /// <exception cref="Amazon.DSQL.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DSQL.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DSQL.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DSQL.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DSQL.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dsql-2018-05-10/GetCluster">REST API Reference for GetCluster Operation</seealso>
        GetClusterResponse GetCluster(GetClusterRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCluster operation on AmazonDSQLClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCluster
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dsql-2018-05-10/GetCluster">REST API Reference for GetCluster Operation</seealso>
        IAsyncResult BeginGetCluster(GetClusterRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetCluster operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCluster.</param>
        /// 
        /// <returns>Returns a  GetClusterResult from DSQL.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dsql-2018-05-10/GetCluster">REST API Reference for GetCluster Operation</seealso>
        GetClusterResponse EndGetCluster(IAsyncResult asyncResult);

        #endregion
        
        #region  GetVpcEndpointServiceName


        /// <summary>
        /// Retrieves the VPC endpoint service name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVpcEndpointServiceName service method.</param>
        /// 
        /// <returns>The response from the GetVpcEndpointServiceName service method, as returned by DSQL.</returns>
        /// <exception cref="Amazon.DSQL.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DSQL.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DSQL.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DSQL.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DSQL.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dsql-2018-05-10/GetVpcEndpointServiceName">REST API Reference for GetVpcEndpointServiceName Operation</seealso>
        GetVpcEndpointServiceNameResponse GetVpcEndpointServiceName(GetVpcEndpointServiceNameRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetVpcEndpointServiceName operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetVpcEndpointServiceName operation on AmazonDSQLClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetVpcEndpointServiceName
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dsql-2018-05-10/GetVpcEndpointServiceName">REST API Reference for GetVpcEndpointServiceName Operation</seealso>
        IAsyncResult BeginGetVpcEndpointServiceName(GetVpcEndpointServiceNameRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetVpcEndpointServiceName operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetVpcEndpointServiceName.</param>
        /// 
        /// <returns>Returns a  GetVpcEndpointServiceNameResult from DSQL.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dsql-2018-05-10/GetVpcEndpointServiceName">REST API Reference for GetVpcEndpointServiceName Operation</seealso>
        GetVpcEndpointServiceNameResponse EndGetVpcEndpointServiceName(IAsyncResult asyncResult);

        #endregion
        
        #region  ListClusters


        /// <summary>
        /// Retrieves information about a list of clusters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListClusters service method.</param>
        /// 
        /// <returns>The response from the ListClusters service method, as returned by DSQL.</returns>
        /// <exception cref="Amazon.DSQL.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DSQL.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DSQL.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DSQL.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DSQL.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dsql-2018-05-10/ListClusters">REST API Reference for ListClusters Operation</seealso>
        ListClustersResponse ListClusters(ListClustersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListClusters operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListClusters operation on AmazonDSQLClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListClusters
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dsql-2018-05-10/ListClusters">REST API Reference for ListClusters Operation</seealso>
        IAsyncResult BeginListClusters(ListClustersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListClusters operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListClusters.</param>
        /// 
        /// <returns>Returns a  ListClustersResult from DSQL.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dsql-2018-05-10/ListClusters">REST API Reference for ListClusters Operation</seealso>
        ListClustersResponse EndListClusters(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists all of the tags for a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by DSQL.</returns>
        /// <exception cref="Amazon.DSQL.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DSQL.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DSQL.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DSQL.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DSQL.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dsql-2018-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonDSQLClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dsql-2018-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from DSQL.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dsql-2018-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Tags a resource with a map of key and value pairs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by DSQL.</returns>
        /// <exception cref="Amazon.DSQL.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DSQL.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DSQL.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DSQL.Model.ServiceQuotaExceededException">
        /// The service limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DSQL.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DSQL.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dsql-2018-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonDSQLClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dsql-2018-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from DSQL.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dsql-2018-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes a tag from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by DSQL.</returns>
        /// <exception cref="Amazon.DSQL.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DSQL.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DSQL.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DSQL.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DSQL.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dsql-2018-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonDSQLClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dsql-2018-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from DSQL.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dsql-2018-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateCluster


        /// <summary>
        /// Updates a cluster.
        /// 
        ///  
        /// <para>
        ///  <b>Example IAM Policy for Multi-Region Operations</b> 
        /// </para>
        ///  
        /// <para>
        /// The following IAM policy grants permissions for multi-Region operations.
        /// </para>
        ///  
        /// <para>
        /// The <c>dsql:RemovePeerCluster</c> permission uses a wildcard ARN pattern to simplify
        /// permission management during updates.
        /// </para>
        ///  <important> 
        /// <para>
        ///  <b>Important Notes for Multi-Region Operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The witness region specified in <c>multiRegionProperties.witnessRegion</c> cannot
        /// be the same as the cluster's Region.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// When updating clusters with peer relationships, permissions are checked for both adding
        /// and removing peers.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <c>dsql:RemovePeerCluster</c> permission uses a wildcard ARN pattern to simplify
        /// permission management during updates.
        /// </para>
        ///  </li> </ul> </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCluster service method.</param>
        /// 
        /// <returns>The response from the UpdateCluster service method, as returned by DSQL.</returns>
        /// <exception cref="Amazon.DSQL.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DSQL.Model.ConflictException">
        /// The submitted action has conflicts.
        /// </exception>
        /// <exception cref="Amazon.DSQL.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DSQL.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DSQL.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DSQL.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dsql-2018-05-10/UpdateCluster">REST API Reference for UpdateCluster Operation</seealso>
        UpdateClusterResponse UpdateCluster(UpdateClusterRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateCluster operation on AmazonDSQLClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateCluster
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dsql-2018-05-10/UpdateCluster">REST API Reference for UpdateCluster Operation</seealso>
        IAsyncResult BeginUpdateCluster(UpdateClusterRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateCluster operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateCluster.</param>
        /// 
        /// <returns>Returns a  UpdateClusterResult from DSQL.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dsql-2018-05-10/UpdateCluster">REST API Reference for UpdateCluster Operation</seealso>
        UpdateClusterResponse EndUpdateCluster(IAsyncResult asyncResult);

        #endregion
                
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request);
        
        #endregion

    }
}