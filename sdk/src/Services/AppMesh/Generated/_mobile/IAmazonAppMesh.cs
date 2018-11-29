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
 * Do not modify this file. This file is generated from the appmesh-2018-10-01.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.AppMesh.Model;

namespace Amazon.AppMesh
{
    /// <summary>
    /// Interface for accessing AppMesh
    ///
    /// AWS App Mesh is a service mesh based on the Envoy proxy that makes it easy to monitor
    /// and         control containerized microservices. App Mesh standardizes how your microservices
    ///         communicate, giving you end-to-end visibility and helping to ensure high-availability
    /// for         your applications.
    /// 
    ///          
    /// <para>
    /// App Mesh gives you consistent visibility and network traffic controls for every  
    ///       microservice in an application. You can use App Mesh with Amazon ECS       
    ///  (using the Amazon EC2 launch type), Amazon EKS, and Kubernetes on AWS.
    /// </para>
    ///          <note>            
    /// <para>
    /// App Mesh supports containerized microservice applications that use service discovery
    ///            naming for their components. To use App Mesh, you must have a containerized
    /// application            running on Amazon EC2 instances, hosted in either Amazon ECS,
    /// Amazon EKS, or Kubernetes on AWS. For            more information about service discovery
    /// on Amazon ECS, see <a href="http://docs.aws.amazon.com/AmazonECS/latest/developerguideservice-discovery.html">Service
    /// Discovery</a> in the               <i>Amazon Elastic Container Service Developer Guide</i>.
    /// Kubernetes <code>kube-dns</code> is supported.            For more information, see
    /// <a href="https://kubernetes.io/docs/concepts/services-networking/dns-pod-service/">DNS
    ///               for Services and Pods</a> in the Kubernetes documentation.
    /// </para>
    ///          </note>
    /// </summary>
    public partial interface IAmazonAppMesh : IAmazonService, IDisposable
    {
                
        #region  CreateMesh


        /// <summary>
        /// Initiates the asynchronous execution of the CreateMesh operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateMesh operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2018-10-01/CreateMesh">REST API Reference for CreateMesh Operation</seealso>
        Task<CreateMeshResponse> CreateMeshAsync(CreateMeshRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateRoute


        /// <summary>
        /// Initiates the asynchronous execution of the CreateRoute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRoute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2018-10-01/CreateRoute">REST API Reference for CreateRoute Operation</seealso>
        Task<CreateRouteResponse> CreateRouteAsync(CreateRouteRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateVirtualNode


        /// <summary>
        /// Initiates the asynchronous execution of the CreateVirtualNode operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateVirtualNode operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2018-10-01/CreateVirtualNode">REST API Reference for CreateVirtualNode Operation</seealso>
        Task<CreateVirtualNodeResponse> CreateVirtualNodeAsync(CreateVirtualNodeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateVirtualRouter


        /// <summary>
        /// Initiates the asynchronous execution of the CreateVirtualRouter operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateVirtualRouter operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2018-10-01/CreateVirtualRouter">REST API Reference for CreateVirtualRouter Operation</seealso>
        Task<CreateVirtualRouterResponse> CreateVirtualRouterAsync(CreateVirtualRouterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteMesh


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteMesh operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteMesh operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2018-10-01/DeleteMesh">REST API Reference for DeleteMesh Operation</seealso>
        Task<DeleteMeshResponse> DeleteMeshAsync(DeleteMeshRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteRoute


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRoute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRoute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2018-10-01/DeleteRoute">REST API Reference for DeleteRoute Operation</seealso>
        Task<DeleteRouteResponse> DeleteRouteAsync(DeleteRouteRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteVirtualNode


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVirtualNode operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVirtualNode operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2018-10-01/DeleteVirtualNode">REST API Reference for DeleteVirtualNode Operation</seealso>
        Task<DeleteVirtualNodeResponse> DeleteVirtualNodeAsync(DeleteVirtualNodeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteVirtualRouter


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVirtualRouter operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVirtualRouter operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2018-10-01/DeleteVirtualRouter">REST API Reference for DeleteVirtualRouter Operation</seealso>
        Task<DeleteVirtualRouterResponse> DeleteVirtualRouterAsync(DeleteVirtualRouterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeMesh


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeMesh operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeMesh operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2018-10-01/DescribeMesh">REST API Reference for DescribeMesh Operation</seealso>
        Task<DescribeMeshResponse> DescribeMeshAsync(DescribeMeshRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeRoute


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeRoute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeRoute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2018-10-01/DescribeRoute">REST API Reference for DescribeRoute Operation</seealso>
        Task<DescribeRouteResponse> DescribeRouteAsync(DescribeRouteRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeVirtualNode


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVirtualNode operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVirtualNode operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2018-10-01/DescribeVirtualNode">REST API Reference for DescribeVirtualNode Operation</seealso>
        Task<DescribeVirtualNodeResponse> DescribeVirtualNodeAsync(DescribeVirtualNodeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeVirtualRouter


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVirtualRouter operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVirtualRouter operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2018-10-01/DescribeVirtualRouter">REST API Reference for DescribeVirtualRouter Operation</seealso>
        Task<DescribeVirtualRouterResponse> DescribeVirtualRouterAsync(DescribeVirtualRouterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListMeshes


        /// <summary>
        /// Initiates the asynchronous execution of the ListMeshes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMeshes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2018-10-01/ListMeshes">REST API Reference for ListMeshes Operation</seealso>
        Task<ListMeshesResponse> ListMeshesAsync(ListMeshesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListRoutes


        /// <summary>
        /// Initiates the asynchronous execution of the ListRoutes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRoutes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2018-10-01/ListRoutes">REST API Reference for ListRoutes Operation</seealso>
        Task<ListRoutesResponse> ListRoutesAsync(ListRoutesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListVirtualNodes


        /// <summary>
        /// Initiates the asynchronous execution of the ListVirtualNodes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListVirtualNodes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2018-10-01/ListVirtualNodes">REST API Reference for ListVirtualNodes Operation</seealso>
        Task<ListVirtualNodesResponse> ListVirtualNodesAsync(ListVirtualNodesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListVirtualRouters


        /// <summary>
        /// Initiates the asynchronous execution of the ListVirtualRouters operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListVirtualRouters operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2018-10-01/ListVirtualRouters">REST API Reference for ListVirtualRouters Operation</seealso>
        Task<ListVirtualRoutersResponse> ListVirtualRoutersAsync(ListVirtualRoutersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateRoute


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateRoute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateRoute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2018-10-01/UpdateRoute">REST API Reference for UpdateRoute Operation</seealso>
        Task<UpdateRouteResponse> UpdateRouteAsync(UpdateRouteRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateVirtualNode


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateVirtualNode operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateVirtualNode operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2018-10-01/UpdateVirtualNode">REST API Reference for UpdateVirtualNode Operation</seealso>
        Task<UpdateVirtualNodeResponse> UpdateVirtualNodeAsync(UpdateVirtualNodeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateVirtualRouter


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateVirtualRouter operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateVirtualRouter operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2018-10-01/UpdateVirtualRouter">REST API Reference for UpdateVirtualRouter Operation</seealso>
        Task<UpdateVirtualRouterResponse> UpdateVirtualRouterAsync(UpdateVirtualRouterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}