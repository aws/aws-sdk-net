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
    /// of any size. is available in both single-Region and multi-Region configurations, so
    /// your clusters and databases are always available even if an Availability Zone or an
    /// Amazon Web Services Region are unavailable. lets you focus on using your data to acquire
    /// new insights for your business and customers.
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
        /// The CreateCluster API allows you to create both single-region clusters and multi-Region
        /// clusters. With the addition of the <i>multiRegionProperties</i> parameter, you can
        /// create a cluster with witness Region support and establish peer relationships with
        /// clusters in other Regions during creation.
        /// 
        ///  <note> 
        /// <para>
        /// Creating multi-Region clusters requires additional IAM permissions beyond those needed
        /// for single-Region clusters, as detailed in the <b>Required permissions</b> section
        /// below.
        /// </para>
        ///  </note> 
        /// <para>
        ///  <b>Required permissions</b> 
        /// </para>
        ///  <dl> <dt>dsql:CreateCluster</dt> <dd> 
        /// <para>
        /// Required to create a cluster.
        /// </para>
        ///  
        /// <para>
        /// Resources: <c>arn:aws:dsql:region:account-id:cluster/*</c> 
        /// </para>
        ///  </dd> <dt>dsql:TagResource</dt> <dd> 
        /// <para>
        /// Permission to add tags to a resource.
        /// </para>
        ///  
        /// <para>
        /// Resources: <c>arn:aws:dsql:region:account-id:cluster/*</c> 
        /// </para>
        ///  </dd> <dt>dsql:PutMultiRegionProperties</dt> <dd> 
        /// <para>
        /// Permission to configure multi-region properties for a cluster.
        /// </para>
        ///  
        /// <para>
        /// Resources: <c>arn:aws:dsql:region:account-id:cluster/*</c> 
        /// </para>
        ///  </dd> <dt>dsql:AddPeerCluster</dt> <dd> 
        /// <para>
        /// When specifying <c>multiRegionProperties.clusters</c>, permission to add peer clusters.
        /// </para>
        ///  
        /// <para>
        /// Resources:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Local cluster: <c>arn:aws:dsql:region:account-id:cluster/*</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Each peer cluster: exact ARN of each specified peer cluster
        /// </para>
        ///  </li> </ul> </dd> <dt>dsql:PutWitnessRegion</dt> <dd> 
        /// <para>
        /// When specifying <c>multiRegionProperties.witnessRegion</c>, permission to set a witness
        /// Region. This permission is checked both in the cluster Region and in the witness Region.
        /// </para>
        ///  
        /// <para>
        /// Resources: <c>arn:aws:dsql:region:account-id:cluster/*</c> 
        /// </para>
        ///  
        /// <para>
        /// Condition Keys: <c>dsql:WitnessRegion</c> (matching the specified witness region)
        /// </para>
        ///  </dd> </dl> <important> <ul> <li> 
        /// <para>
        /// The witness Region specified in <c>multiRegionProperties.witnessRegion</c> cannot
        /// be the same as the cluster's Region.
        /// </para>
        ///  </li> </ul> </important>
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
                
        #region  GetVpcEndpointServiceName



        /// <summary>
        /// Retrieves the VPC endpoint service name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVpcEndpointServiceName service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetVpcEndpointServiceNameResponse> GetVpcEndpointServiceNameAsync(GetVpcEndpointServiceNameRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// The <i>UpdateCluster</i> API allows you to modify both single-Region and multi-Region
        /// cluster configurations. With the <i>multiRegionProperties</i> parameter, you can add
        /// or modify witness Region support and manage peer relationships with clusters in other
        /// Regions.
        /// 
        ///  <note> 
        /// <para>
        /// Note that updating multi-region clusters requires additional IAM permissions beyond
        /// those needed for standard cluster updates, as detailed in the Permissions section.
        /// </para>
        ///  </note> 
        /// <para>
        ///  <b>Required permissions</b> 
        /// </para>
        ///  <dl> <dt>dsql:UpdateCluster</dt> <dd> 
        /// <para>
        /// Permission to update a DSQL cluster.
        /// </para>
        ///  
        /// <para>
        /// Resources: <c>arn:aws:dsql:<i>region</i>:<i>account-id</i>:cluster/<i>cluster-id</i>
        /// </c> 
        /// </para>
        ///  </dd> </dl> <dl> <dt>dsql:PutMultiRegionProperties</dt> <dd> 
        /// <para>
        /// Permission to configure multi-Region properties for a cluster.
        /// </para>
        ///  
        /// <para>
        /// Resources: <c>arn:aws:dsql:<i>region</i>:<i>account-id</i>:cluster/<i>cluster-id</i>
        /// </c> 
        /// </para>
        ///  </dd> </dl> <dl> <dt>dsql:GetCluster</dt> <dd> 
        /// <para>
        /// Permission to retrieve cluster information.
        /// </para>
        ///  
        /// <para>
        /// Resources: <c>arn:aws:dsql:<i>region</i>:<i>account-id</i>:cluster/<i>cluster-id</i>
        /// </c> 
        /// </para>
        ///  </dd> <dt>dsql:AddPeerCluster</dt> <dd> 
        /// <para>
        /// Permission to add peer clusters.
        /// </para>
        ///  
        /// <para>
        /// Resources:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Local cluster: <c>arn:aws:dsql:<i>region</i>:<i>account-id</i>:cluster/<i>cluster-id</i>
        /// </c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Each peer cluster: exact ARN of each specified peer cluster
        /// </para>
        ///  </li> </ul> </dd> <dt>dsql:RemovePeerCluster</dt> <dd> 
        /// <para>
        /// Permission to remove peer clusters. The <i>dsql:RemovePeerCluster</i> permission uses
        /// a wildcard ARN pattern to simplify permission management during updates.
        /// </para>
        ///  
        /// <para>
        /// Resources: <c>arn:aws:dsql:*:<i>account-id</i>:cluster/*</c> 
        /// </para>
        ///  </dd> </dl> <dl> <dt>dsql:PutWitnessRegion</dt> <dd> 
        /// <para>
        /// Permission to set a witness Region.
        /// </para>
        ///  
        /// <para>
        /// Resources: <c>arn:aws:dsql:<i>region</i>:<i>account-id</i>:cluster/<i>cluster-id</i>
        /// </c> 
        /// </para>
        ///  
        /// <para>
        /// Condition Keys: dsql:WitnessRegion (matching the specified witness Region)
        /// </para>
        ///  
        /// <para>
        ///  <b>This permission is checked both in the cluster Region and in the witness Region.</b>
        /// 
        /// </para>
        ///  </dd> </dl> <important> <ul> <li> 
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

        #region Static factory interface methods
#if NET8_0_OR_GREATER
// Warning CA1033 is issued when the child types can not call the method defined in parent types.
// In this use case the intended caller is only meant to be the interface as a factory
// method to create the child types. Given the SDK use case the warning can be ignored.
#pragma warning disable CA1033
        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.DynamicDependency(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties, typeof(AmazonDSQLConfig))]
        static ClientConfig IAmazonService.CreateDefaultClientConfig() => new AmazonDSQLConfig();

        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("AssemblyLoadTrimming", "IL2026:RequiresUnreferencedCode",
    Justification = "This suppression is here to ignore the warnings caused by CognitoSync. See justification in IAmazonService.")]
        static IAmazonService IAmazonService.CreateDefaultServiceClient(AWSCredentials awsCredentials, ClientConfig clientConfig)
        {
            var serviceClientConfig = clientConfig as AmazonDSQLConfig;
            if (serviceClientConfig == null)
            {
                throw new AmazonClientException("ClientConfig is not of type AmazonDSQLConfig to create AmazonDSQLClient");
            }

            return awsCredentials == null ? 
                    new AmazonDSQLClient(serviceClientConfig) :
                    new AmazonDSQLClient(awsCredentials, serviceClientConfig);
        }
#pragma warning restore CA1033
#endif
        #endregion
    }
}