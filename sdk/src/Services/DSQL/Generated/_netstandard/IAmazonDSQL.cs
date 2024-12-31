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
using System.Threading;
using System.Threading.Tasks;
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
    /// of any size. Aurora DSQL is available in both single-Region and multi-Region configurations,
    /// so your clusters and databases are always available even if an Availability Zone or
    /// an Amazon Web Services Region are unavailable. Aurora DSQL lets you focus on using
    /// your data to acquire new insights for your business and customers.
    /// </para>
    /// </summary>
    public partial interface IAmazonDSQL : IAmazonService, IDisposable
    {
#if AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IDSQLPaginatorFactory Paginators { get; }
#endif
                
        #region  CreateCluster



        /// <summary>
        /// Creates a cluster in Amazon Aurora DSQL.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateClusterResponse> CreateClusterAsync(CreateClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateMultiRegionClusters



        /// <summary>
        /// Creates multi-Region clusters in Amazon Aurora DSQL. Multi-Region clusters require
        /// a linked Region list, which is an array of the Regions in which you want to create
        /// linked clusters. Multi-Region clusters require a witness Region, which participates
        /// in quorum in failure scenarios.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMultiRegionClusters service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateMultiRegionClustersResponse> CreateMultiRegionClustersAsync(CreateMultiRegionClustersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteCluster



        /// <summary>
        /// Deletes a cluster in Amazon Aurora DSQL.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteClusterResponse> DeleteClusterAsync(DeleteClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteMultiRegionClusters



        /// <summary>
        /// Deletes a multi-Region cluster in Amazon Aurora DSQL.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMultiRegionClusters service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteMultiRegionClustersResponse> DeleteMultiRegionClustersAsync(DeleteMultiRegionClustersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetCluster



        /// <summary>
        /// Retrieves information about a cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetClusterResponse> GetClusterAsync(GetClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListClusters



        /// <summary>
        /// Retrieves information about a list of clusters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListClusters service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListClustersResponse> ListClustersAsync(ListClustersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTagsForResource



        /// <summary>
        /// Lists all of the tags for a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TagResource



        /// <summary>
        /// Tags a resource with a map of key and value pairs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UntagResource



        /// <summary>
        /// Removes a tag from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateCluster



        /// <summary>
        /// Updates a cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateClusterResponse> UpdateClusterAsync(UpdateClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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