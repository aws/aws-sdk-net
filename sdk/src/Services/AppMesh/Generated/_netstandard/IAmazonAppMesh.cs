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
 * Do not modify this file. This file is generated from the appmesh-2019-01-25.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.AppMesh.Model;

#pragma warning disable CS1570
namespace Amazon.AppMesh
{
    /// <summary>
    /// <para>Interface for accessing AppMesh</para>
    ///
    /// App Mesh is a service mesh based on the Envoy proxy that makes it easy to monitor
    /// and control microservices. App Mesh standardizes how your microservices communicate,
    /// giving you end-to-end visibility and helping to ensure high availability for your
    /// applications.
    /// 
    ///  
    /// <para>
    /// App Mesh gives you consistent visibility and network traffic controls for every microservice
    /// in an application. You can use App Mesh with Amazon Web Services Fargate, Amazon ECS,
    /// Amazon EKS, Kubernetes on Amazon Web Services, and Amazon EC2.
    /// </para>
    ///  <note> 
    /// <para>
    /// App Mesh supports microservice applications that use service discovery naming for
    /// their components. For more information about service discovery on Amazon ECS, see
    /// <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/service-discovery.html">Service
    /// Discovery</a> in the <i>Amazon Elastic Container Service Developer Guide</i>. Kubernetes
    /// <c>kube-dns</c> and <c>coredns</c> are supported. For more information, see <a href="https://kubernetes.io/docs/concepts/services-networking/dns-pod-service/">DNS
    /// for Services and Pods</a> in the Kubernetes documentation.
    /// </para>
    ///  </note>
    /// </summary>
    public partial interface IAmazonAppMesh : IAmazonService, IDisposable
    {
#if AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IAppMeshPaginatorFactory Paginators { get; }
#endif
                
        #region  CreateGatewayRoute



        /// <summary>
        /// Creates a gateway route.
        /// 
        ///  
        /// <para>
        /// A gateway route is attached to a virtual gateway and routes traffic to an existing
        /// virtual service. If a route matches a request, it can distribute traffic to a target
        /// virtual service.
        /// </para>
        ///  
        /// <para>
        /// For more information about gateway routes, see <a href="https://docs.aws.amazon.com/app-mesh/latest/userguide/gateway-routes.html">Gateway
        /// routes</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGatewayRoute service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateGatewayRoute service method, as returned by AppMesh.</returns>
        /// <exception cref="Amazon.AppMesh.Model.BadRequestException">
        /// The request syntax was malformed. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ConflictException">
        /// The request contains a client token that was used for a previous update resource call
        /// with different specifications. Try the request again with a new client token.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ForbiddenException">
        /// You don't have permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.InternalServerErrorException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.LimitExceededException">
        /// You have exceeded a service limit for your account. For more information, see <a href="https://docs.aws.amazon.com/app-mesh/latest/userguide/service-quotas.html">Service
        /// Limits</a> in the <i>App Mesh User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.NotFoundException">
        /// The specified resource doesn't exist. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the service.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.TooManyRequestsException">
        /// The maximum request rate permitted by the App Mesh APIs has been exceeded for your
        /// account. For best results, use an increasing or variable sleep interval between requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2019-01-25/CreateGatewayRoute">REST API Reference for CreateGatewayRoute Operation</seealso>
        Task<CreateGatewayRouteResponse> CreateGatewayRouteAsync(CreateGatewayRouteRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateMesh



        /// <summary>
        /// Creates a service mesh.
        /// 
        ///  
        /// <para>
        ///  A service mesh is a logical boundary for network traffic between services that are
        /// represented by resources within the mesh. After you create your service mesh, you
        /// can create virtual services, virtual nodes, virtual routers, and routes to distribute
        /// traffic between the applications in your mesh.
        /// </para>
        ///  
        /// <para>
        /// For more information about service meshes, see <a href="https://docs.aws.amazon.com/app-mesh/latest/userguide/meshes.html">Service
        /// meshes</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMesh service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateMesh service method, as returned by AppMesh.</returns>
        /// <exception cref="Amazon.AppMesh.Model.BadRequestException">
        /// The request syntax was malformed. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ConflictException">
        /// The request contains a client token that was used for a previous update resource call
        /// with different specifications. Try the request again with a new client token.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ForbiddenException">
        /// You don't have permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.InternalServerErrorException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.LimitExceededException">
        /// You have exceeded a service limit for your account. For more information, see <a href="https://docs.aws.amazon.com/app-mesh/latest/userguide/service-quotas.html">Service
        /// Limits</a> in the <i>App Mesh User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.NotFoundException">
        /// The specified resource doesn't exist. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the service.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.TooManyRequestsException">
        /// The maximum request rate permitted by the App Mesh APIs has been exceeded for your
        /// account. For best results, use an increasing or variable sleep interval between requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2019-01-25/CreateMesh">REST API Reference for CreateMesh Operation</seealso>
        Task<CreateMeshResponse> CreateMeshAsync(CreateMeshRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateRoute



        /// <summary>
        /// Creates a route that is associated with a virtual router.
        /// 
        ///  
        /// <para>
        ///  You can route several different protocols and define a retry policy for a route.
        /// Traffic can be routed to one or more virtual nodes.
        /// </para>
        ///  
        /// <para>
        /// For more information about routes, see <a href="https://docs.aws.amazon.com/app-mesh/latest/userguide/routes.html">Routes</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRoute service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateRoute service method, as returned by AppMesh.</returns>
        /// <exception cref="Amazon.AppMesh.Model.BadRequestException">
        /// The request syntax was malformed. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ConflictException">
        /// The request contains a client token that was used for a previous update resource call
        /// with different specifications. Try the request again with a new client token.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ForbiddenException">
        /// You don't have permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.InternalServerErrorException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.LimitExceededException">
        /// You have exceeded a service limit for your account. For more information, see <a href="https://docs.aws.amazon.com/app-mesh/latest/userguide/service-quotas.html">Service
        /// Limits</a> in the <i>App Mesh User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.NotFoundException">
        /// The specified resource doesn't exist. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the service.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.TooManyRequestsException">
        /// The maximum request rate permitted by the App Mesh APIs has been exceeded for your
        /// account. For best results, use an increasing or variable sleep interval between requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2019-01-25/CreateRoute">REST API Reference for CreateRoute Operation</seealso>
        Task<CreateRouteResponse> CreateRouteAsync(CreateRouteRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateVirtualGateway



        /// <summary>
        /// Creates a virtual gateway.
        /// 
        ///  
        /// <para>
        /// A virtual gateway allows resources outside your mesh to communicate to resources that
        /// are inside your mesh. The virtual gateway represents an Envoy proxy running in an
        /// Amazon ECS task, in a Kubernetes service, or on an Amazon EC2 instance. Unlike a virtual
        /// node, which represents an Envoy running with an application, a virtual gateway represents
        /// Envoy deployed by itself.
        /// </para>
        ///  
        /// <para>
        /// For more information about virtual gateways, see <a href="https://docs.aws.amazon.com/app-mesh/latest/userguide/virtual_gateways.html">Virtual
        /// gateways</a>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVirtualGateway service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateVirtualGateway service method, as returned by AppMesh.</returns>
        /// <exception cref="Amazon.AppMesh.Model.BadRequestException">
        /// The request syntax was malformed. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ConflictException">
        /// The request contains a client token that was used for a previous update resource call
        /// with different specifications. Try the request again with a new client token.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ForbiddenException">
        /// You don't have permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.InternalServerErrorException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.LimitExceededException">
        /// You have exceeded a service limit for your account. For more information, see <a href="https://docs.aws.amazon.com/app-mesh/latest/userguide/service-quotas.html">Service
        /// Limits</a> in the <i>App Mesh User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.NotFoundException">
        /// The specified resource doesn't exist. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the service.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.TooManyRequestsException">
        /// The maximum request rate permitted by the App Mesh APIs has been exceeded for your
        /// account. For best results, use an increasing or variable sleep interval between requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2019-01-25/CreateVirtualGateway">REST API Reference for CreateVirtualGateway Operation</seealso>
        Task<CreateVirtualGatewayResponse> CreateVirtualGatewayAsync(CreateVirtualGatewayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateVirtualNode



        /// <summary>
        /// Creates a virtual node within a service mesh.
        /// 
        ///  
        /// <para>
        ///  A virtual node acts as a logical pointer to a particular task group, such as an Amazon
        /// ECS service or a Kubernetes deployment. When you create a virtual node, you can specify
        /// the service discovery information for your task group, and whether the proxy running
        /// in a task group will communicate with other proxies using Transport Layer Security
        /// (TLS).
        /// </para>
        ///  
        /// <para>
        /// You define a <c>listener</c> for any inbound traffic that your virtual node expects.
        /// Any virtual service that your virtual node expects to communicate to is specified
        /// as a <c>backend</c>.
        /// </para>
        ///  
        /// <para>
        /// The response metadata for your new virtual node contains the <c>arn</c> that is associated
        /// with the virtual node. Set this value to the full ARN; for example, <c>arn:aws:appmesh:us-west-2:123456789012:myMesh/default/virtualNode/myApp</c>)
        /// as the <c>APPMESH_RESOURCE_ARN</c> environment variable for your task group's Envoy
        /// proxy container in your task definition or pod spec. This is then mapped to the <c>node.id</c>
        /// and <c>node.cluster</c> Envoy parameters.
        /// </para>
        ///  <note> 
        /// <para>
        /// By default, App Mesh uses the name of the resource you specified in <c>APPMESH_RESOURCE_ARN</c>
        /// when Envoy is referring to itself in metrics and traces. You can override this behavior
        /// by setting the <c>APPMESH_RESOURCE_CLUSTER</c> environment variable with your own
        /// name.
        /// </para>
        ///  </note> 
        /// <para>
        /// For more information about virtual nodes, see <a href="https://docs.aws.amazon.com/app-mesh/latest/userguide/virtual_nodes.html">Virtual
        /// nodes</a>. You must be using <c>1.15.0</c> or later of the Envoy image when setting
        /// these variables. For more information aboutApp Mesh Envoy variables, see <a href="https://docs.aws.amazon.com/app-mesh/latest/userguide/envoy.html">Envoy
        /// image</a> in the App Mesh User Guide.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVirtualNode service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateVirtualNode service method, as returned by AppMesh.</returns>
        /// <exception cref="Amazon.AppMesh.Model.BadRequestException">
        /// The request syntax was malformed. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ConflictException">
        /// The request contains a client token that was used for a previous update resource call
        /// with different specifications. Try the request again with a new client token.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ForbiddenException">
        /// You don't have permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.InternalServerErrorException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.LimitExceededException">
        /// You have exceeded a service limit for your account. For more information, see <a href="https://docs.aws.amazon.com/app-mesh/latest/userguide/service-quotas.html">Service
        /// Limits</a> in the <i>App Mesh User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.NotFoundException">
        /// The specified resource doesn't exist. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the service.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.TooManyRequestsException">
        /// The maximum request rate permitted by the App Mesh APIs has been exceeded for your
        /// account. For best results, use an increasing or variable sleep interval between requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2019-01-25/CreateVirtualNode">REST API Reference for CreateVirtualNode Operation</seealso>
        Task<CreateVirtualNodeResponse> CreateVirtualNodeAsync(CreateVirtualNodeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateVirtualRouter



        /// <summary>
        /// Creates a virtual router within a service mesh.
        /// 
        ///  
        /// <para>
        /// Specify a <c>listener</c> for any inbound traffic that your virtual router receives.
        /// Create a virtual router for each protocol and port that you need to route. Virtual
        /// routers handle traffic for one or more virtual services within your mesh. After you
        /// create your virtual router, create and associate routes for your virtual router that
        /// direct incoming requests to different virtual nodes.
        /// </para>
        ///  
        /// <para>
        /// For more information about virtual routers, see <a href="https://docs.aws.amazon.com/app-mesh/latest/userguide/virtual_routers.html">Virtual
        /// routers</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVirtualRouter service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateVirtualRouter service method, as returned by AppMesh.</returns>
        /// <exception cref="Amazon.AppMesh.Model.BadRequestException">
        /// The request syntax was malformed. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ConflictException">
        /// The request contains a client token that was used for a previous update resource call
        /// with different specifications. Try the request again with a new client token.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ForbiddenException">
        /// You don't have permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.InternalServerErrorException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.LimitExceededException">
        /// You have exceeded a service limit for your account. For more information, see <a href="https://docs.aws.amazon.com/app-mesh/latest/userguide/service-quotas.html">Service
        /// Limits</a> in the <i>App Mesh User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.NotFoundException">
        /// The specified resource doesn't exist. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the service.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.TooManyRequestsException">
        /// The maximum request rate permitted by the App Mesh APIs has been exceeded for your
        /// account. For best results, use an increasing or variable sleep interval between requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2019-01-25/CreateVirtualRouter">REST API Reference for CreateVirtualRouter Operation</seealso>
        Task<CreateVirtualRouterResponse> CreateVirtualRouterAsync(CreateVirtualRouterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateVirtualService



        /// <summary>
        /// Creates a virtual service within a service mesh.
        /// 
        ///  
        /// <para>
        /// A virtual service is an abstraction of a real service that is provided by a virtual
        /// node directly or indirectly by means of a virtual router. Dependent services call
        /// your virtual service by its <c>virtualServiceName</c>, and those requests are routed
        /// to the virtual node or virtual router that is specified as the provider for the virtual
        /// service.
        /// </para>
        ///  
        /// <para>
        /// For more information about virtual services, see <a href="https://docs.aws.amazon.com/app-mesh/latest/userguide/virtual_services.html">Virtual
        /// services</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVirtualService service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateVirtualService service method, as returned by AppMesh.</returns>
        /// <exception cref="Amazon.AppMesh.Model.BadRequestException">
        /// The request syntax was malformed. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ConflictException">
        /// The request contains a client token that was used for a previous update resource call
        /// with different specifications. Try the request again with a new client token.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ForbiddenException">
        /// You don't have permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.InternalServerErrorException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.LimitExceededException">
        /// You have exceeded a service limit for your account. For more information, see <a href="https://docs.aws.amazon.com/app-mesh/latest/userguide/service-quotas.html">Service
        /// Limits</a> in the <i>App Mesh User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.NotFoundException">
        /// The specified resource doesn't exist. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the service.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.TooManyRequestsException">
        /// The maximum request rate permitted by the App Mesh APIs has been exceeded for your
        /// account. For best results, use an increasing or variable sleep interval between requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2019-01-25/CreateVirtualService">REST API Reference for CreateVirtualService Operation</seealso>
        Task<CreateVirtualServiceResponse> CreateVirtualServiceAsync(CreateVirtualServiceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteGatewayRoute



        /// <summary>
        /// Deletes an existing gateway route.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGatewayRoute service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteGatewayRoute service method, as returned by AppMesh.</returns>
        /// <exception cref="Amazon.AppMesh.Model.BadRequestException">
        /// The request syntax was malformed. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ForbiddenException">
        /// You don't have permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.InternalServerErrorException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.NotFoundException">
        /// The specified resource doesn't exist. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ResourceInUseException">
        /// You can't delete the specified resource because it's in use or required by another
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the service.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.TooManyRequestsException">
        /// The maximum request rate permitted by the App Mesh APIs has been exceeded for your
        /// account. For best results, use an increasing or variable sleep interval between requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2019-01-25/DeleteGatewayRoute">REST API Reference for DeleteGatewayRoute Operation</seealso>
        Task<DeleteGatewayRouteResponse> DeleteGatewayRouteAsync(DeleteGatewayRouteRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteMesh



        /// <summary>
        /// Deletes an existing service mesh.
        /// 
        ///  
        /// <para>
        /// You must delete all resources (virtual services, routes, virtual routers, and virtual
        /// nodes) in the service mesh before you can delete the mesh itself.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMesh service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteMesh service method, as returned by AppMesh.</returns>
        /// <exception cref="Amazon.AppMesh.Model.BadRequestException">
        /// The request syntax was malformed. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ForbiddenException">
        /// You don't have permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.InternalServerErrorException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.NotFoundException">
        /// The specified resource doesn't exist. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ResourceInUseException">
        /// You can't delete the specified resource because it's in use or required by another
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the service.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.TooManyRequestsException">
        /// The maximum request rate permitted by the App Mesh APIs has been exceeded for your
        /// account. For best results, use an increasing or variable sleep interval between requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2019-01-25/DeleteMesh">REST API Reference for DeleteMesh Operation</seealso>
        Task<DeleteMeshResponse> DeleteMeshAsync(DeleteMeshRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteRoute



        /// <summary>
        /// Deletes an existing route.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRoute service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteRoute service method, as returned by AppMesh.</returns>
        /// <exception cref="Amazon.AppMesh.Model.BadRequestException">
        /// The request syntax was malformed. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ForbiddenException">
        /// You don't have permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.InternalServerErrorException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.NotFoundException">
        /// The specified resource doesn't exist. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ResourceInUseException">
        /// You can't delete the specified resource because it's in use or required by another
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the service.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.TooManyRequestsException">
        /// The maximum request rate permitted by the App Mesh APIs has been exceeded for your
        /// account. For best results, use an increasing or variable sleep interval between requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2019-01-25/DeleteRoute">REST API Reference for DeleteRoute Operation</seealso>
        Task<DeleteRouteResponse> DeleteRouteAsync(DeleteRouteRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteVirtualGateway



        /// <summary>
        /// Deletes an existing virtual gateway. You cannot delete a virtual gateway if any gateway
        /// routes are associated to it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVirtualGateway service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteVirtualGateway service method, as returned by AppMesh.</returns>
        /// <exception cref="Amazon.AppMesh.Model.BadRequestException">
        /// The request syntax was malformed. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ForbiddenException">
        /// You don't have permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.InternalServerErrorException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.NotFoundException">
        /// The specified resource doesn't exist. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ResourceInUseException">
        /// You can't delete the specified resource because it's in use or required by another
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the service.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.TooManyRequestsException">
        /// The maximum request rate permitted by the App Mesh APIs has been exceeded for your
        /// account. For best results, use an increasing or variable sleep interval between requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2019-01-25/DeleteVirtualGateway">REST API Reference for DeleteVirtualGateway Operation</seealso>
        Task<DeleteVirtualGatewayResponse> DeleteVirtualGatewayAsync(DeleteVirtualGatewayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteVirtualNode



        /// <summary>
        /// Deletes an existing virtual node.
        /// 
        ///  
        /// <para>
        /// You must delete any virtual services that list a virtual node as a service provider
        /// before you can delete the virtual node itself.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVirtualNode service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteVirtualNode service method, as returned by AppMesh.</returns>
        /// <exception cref="Amazon.AppMesh.Model.BadRequestException">
        /// The request syntax was malformed. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ForbiddenException">
        /// You don't have permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.InternalServerErrorException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.NotFoundException">
        /// The specified resource doesn't exist. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ResourceInUseException">
        /// You can't delete the specified resource because it's in use or required by another
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the service.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.TooManyRequestsException">
        /// The maximum request rate permitted by the App Mesh APIs has been exceeded for your
        /// account. For best results, use an increasing or variable sleep interval between requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2019-01-25/DeleteVirtualNode">REST API Reference for DeleteVirtualNode Operation</seealso>
        Task<DeleteVirtualNodeResponse> DeleteVirtualNodeAsync(DeleteVirtualNodeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteVirtualRouter



        /// <summary>
        /// Deletes an existing virtual router.
        /// 
        ///  
        /// <para>
        /// You must delete any routes associated with the virtual router before you can delete
        /// the router itself.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVirtualRouter service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteVirtualRouter service method, as returned by AppMesh.</returns>
        /// <exception cref="Amazon.AppMesh.Model.BadRequestException">
        /// The request syntax was malformed. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ForbiddenException">
        /// You don't have permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.InternalServerErrorException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.NotFoundException">
        /// The specified resource doesn't exist. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ResourceInUseException">
        /// You can't delete the specified resource because it's in use or required by another
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the service.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.TooManyRequestsException">
        /// The maximum request rate permitted by the App Mesh APIs has been exceeded for your
        /// account. For best results, use an increasing or variable sleep interval between requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2019-01-25/DeleteVirtualRouter">REST API Reference for DeleteVirtualRouter Operation</seealso>
        Task<DeleteVirtualRouterResponse> DeleteVirtualRouterAsync(DeleteVirtualRouterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteVirtualService



        /// <summary>
        /// Deletes an existing virtual service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVirtualService service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteVirtualService service method, as returned by AppMesh.</returns>
        /// <exception cref="Amazon.AppMesh.Model.BadRequestException">
        /// The request syntax was malformed. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ForbiddenException">
        /// You don't have permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.InternalServerErrorException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.NotFoundException">
        /// The specified resource doesn't exist. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ResourceInUseException">
        /// You can't delete the specified resource because it's in use or required by another
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the service.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.TooManyRequestsException">
        /// The maximum request rate permitted by the App Mesh APIs has been exceeded for your
        /// account. For best results, use an increasing or variable sleep interval between requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2019-01-25/DeleteVirtualService">REST API Reference for DeleteVirtualService Operation</seealso>
        Task<DeleteVirtualServiceResponse> DeleteVirtualServiceAsync(DeleteVirtualServiceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeGatewayRoute



        /// <summary>
        /// Describes an existing gateway route.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeGatewayRoute service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeGatewayRoute service method, as returned by AppMesh.</returns>
        /// <exception cref="Amazon.AppMesh.Model.BadRequestException">
        /// The request syntax was malformed. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ForbiddenException">
        /// You don't have permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.InternalServerErrorException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.NotFoundException">
        /// The specified resource doesn't exist. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the service.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.TooManyRequestsException">
        /// The maximum request rate permitted by the App Mesh APIs has been exceeded for your
        /// account. For best results, use an increasing or variable sleep interval between requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2019-01-25/DescribeGatewayRoute">REST API Reference for DescribeGatewayRoute Operation</seealso>
        Task<DescribeGatewayRouteResponse> DescribeGatewayRouteAsync(DescribeGatewayRouteRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeMesh



        /// <summary>
        /// Describes an existing service mesh.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeMesh service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeMesh service method, as returned by AppMesh.</returns>
        /// <exception cref="Amazon.AppMesh.Model.BadRequestException">
        /// The request syntax was malformed. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ForbiddenException">
        /// You don't have permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.InternalServerErrorException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.NotFoundException">
        /// The specified resource doesn't exist. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the service.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.TooManyRequestsException">
        /// The maximum request rate permitted by the App Mesh APIs has been exceeded for your
        /// account. For best results, use an increasing or variable sleep interval between requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2019-01-25/DescribeMesh">REST API Reference for DescribeMesh Operation</seealso>
        Task<DescribeMeshResponse> DescribeMeshAsync(DescribeMeshRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeRoute



        /// <summary>
        /// Describes an existing route.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRoute service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeRoute service method, as returned by AppMesh.</returns>
        /// <exception cref="Amazon.AppMesh.Model.BadRequestException">
        /// The request syntax was malformed. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ForbiddenException">
        /// You don't have permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.InternalServerErrorException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.NotFoundException">
        /// The specified resource doesn't exist. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the service.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.TooManyRequestsException">
        /// The maximum request rate permitted by the App Mesh APIs has been exceeded for your
        /// account. For best results, use an increasing or variable sleep interval between requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2019-01-25/DescribeRoute">REST API Reference for DescribeRoute Operation</seealso>
        Task<DescribeRouteResponse> DescribeRouteAsync(DescribeRouteRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeVirtualGateway



        /// <summary>
        /// Describes an existing virtual gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVirtualGateway service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeVirtualGateway service method, as returned by AppMesh.</returns>
        /// <exception cref="Amazon.AppMesh.Model.BadRequestException">
        /// The request syntax was malformed. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ForbiddenException">
        /// You don't have permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.InternalServerErrorException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.NotFoundException">
        /// The specified resource doesn't exist. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the service.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.TooManyRequestsException">
        /// The maximum request rate permitted by the App Mesh APIs has been exceeded for your
        /// account. For best results, use an increasing or variable sleep interval between requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2019-01-25/DescribeVirtualGateway">REST API Reference for DescribeVirtualGateway Operation</seealso>
        Task<DescribeVirtualGatewayResponse> DescribeVirtualGatewayAsync(DescribeVirtualGatewayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeVirtualNode



        /// <summary>
        /// Describes an existing virtual node.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVirtualNode service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeVirtualNode service method, as returned by AppMesh.</returns>
        /// <exception cref="Amazon.AppMesh.Model.BadRequestException">
        /// The request syntax was malformed. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ForbiddenException">
        /// You don't have permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.InternalServerErrorException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.NotFoundException">
        /// The specified resource doesn't exist. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the service.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.TooManyRequestsException">
        /// The maximum request rate permitted by the App Mesh APIs has been exceeded for your
        /// account. For best results, use an increasing or variable sleep interval between requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2019-01-25/DescribeVirtualNode">REST API Reference for DescribeVirtualNode Operation</seealso>
        Task<DescribeVirtualNodeResponse> DescribeVirtualNodeAsync(DescribeVirtualNodeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeVirtualRouter



        /// <summary>
        /// Describes an existing virtual router.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVirtualRouter service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeVirtualRouter service method, as returned by AppMesh.</returns>
        /// <exception cref="Amazon.AppMesh.Model.BadRequestException">
        /// The request syntax was malformed. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ForbiddenException">
        /// You don't have permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.InternalServerErrorException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.NotFoundException">
        /// The specified resource doesn't exist. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the service.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.TooManyRequestsException">
        /// The maximum request rate permitted by the App Mesh APIs has been exceeded for your
        /// account. For best results, use an increasing or variable sleep interval between requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2019-01-25/DescribeVirtualRouter">REST API Reference for DescribeVirtualRouter Operation</seealso>
        Task<DescribeVirtualRouterResponse> DescribeVirtualRouterAsync(DescribeVirtualRouterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeVirtualService



        /// <summary>
        /// Describes an existing virtual service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVirtualService service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeVirtualService service method, as returned by AppMesh.</returns>
        /// <exception cref="Amazon.AppMesh.Model.BadRequestException">
        /// The request syntax was malformed. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ForbiddenException">
        /// You don't have permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.InternalServerErrorException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.NotFoundException">
        /// The specified resource doesn't exist. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the service.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.TooManyRequestsException">
        /// The maximum request rate permitted by the App Mesh APIs has been exceeded for your
        /// account. For best results, use an increasing or variable sleep interval between requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2019-01-25/DescribeVirtualService">REST API Reference for DescribeVirtualService Operation</seealso>
        Task<DescribeVirtualServiceResponse> DescribeVirtualServiceAsync(DescribeVirtualServiceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListGatewayRoutes



        /// <summary>
        /// Returns a list of existing gateway routes that are associated to a virtual gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGatewayRoutes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListGatewayRoutes service method, as returned by AppMesh.</returns>
        /// <exception cref="Amazon.AppMesh.Model.BadRequestException">
        /// The request syntax was malformed. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ForbiddenException">
        /// You don't have permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.InternalServerErrorException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.NotFoundException">
        /// The specified resource doesn't exist. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the service.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.TooManyRequestsException">
        /// The maximum request rate permitted by the App Mesh APIs has been exceeded for your
        /// account. For best results, use an increasing or variable sleep interval between requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2019-01-25/ListGatewayRoutes">REST API Reference for ListGatewayRoutes Operation</seealso>
        Task<ListGatewayRoutesResponse> ListGatewayRoutesAsync(ListGatewayRoutesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListMeshes



        /// <summary>
        /// Returns a list of existing service meshes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMeshes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListMeshes service method, as returned by AppMesh.</returns>
        /// <exception cref="Amazon.AppMesh.Model.BadRequestException">
        /// The request syntax was malformed. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ForbiddenException">
        /// You don't have permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.InternalServerErrorException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.NotFoundException">
        /// The specified resource doesn't exist. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the service.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.TooManyRequestsException">
        /// The maximum request rate permitted by the App Mesh APIs has been exceeded for your
        /// account. For best results, use an increasing or variable sleep interval between requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2019-01-25/ListMeshes">REST API Reference for ListMeshes Operation</seealso>
        Task<ListMeshesResponse> ListMeshesAsync(ListMeshesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListRoutes



        /// <summary>
        /// Returns a list of existing routes in a service mesh.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRoutes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRoutes service method, as returned by AppMesh.</returns>
        /// <exception cref="Amazon.AppMesh.Model.BadRequestException">
        /// The request syntax was malformed. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ForbiddenException">
        /// You don't have permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.InternalServerErrorException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.NotFoundException">
        /// The specified resource doesn't exist. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the service.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.TooManyRequestsException">
        /// The maximum request rate permitted by the App Mesh APIs has been exceeded for your
        /// account. For best results, use an increasing or variable sleep interval between requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2019-01-25/ListRoutes">REST API Reference for ListRoutes Operation</seealso>
        Task<ListRoutesResponse> ListRoutesAsync(ListRoutesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTagsForResource



        /// <summary>
        /// List the tags for an App Mesh resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by AppMesh.</returns>
        /// <exception cref="Amazon.AppMesh.Model.BadRequestException">
        /// The request syntax was malformed. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ForbiddenException">
        /// You don't have permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.InternalServerErrorException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.NotFoundException">
        /// The specified resource doesn't exist. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the service.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.TooManyRequestsException">
        /// The maximum request rate permitted by the App Mesh APIs has been exceeded for your
        /// account. For best results, use an increasing or variable sleep interval between requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2019-01-25/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListVirtualGateways



        /// <summary>
        /// Returns a list of existing virtual gateways in a service mesh.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVirtualGateways service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListVirtualGateways service method, as returned by AppMesh.</returns>
        /// <exception cref="Amazon.AppMesh.Model.BadRequestException">
        /// The request syntax was malformed. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ForbiddenException">
        /// You don't have permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.InternalServerErrorException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.NotFoundException">
        /// The specified resource doesn't exist. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the service.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.TooManyRequestsException">
        /// The maximum request rate permitted by the App Mesh APIs has been exceeded for your
        /// account. For best results, use an increasing or variable sleep interval between requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2019-01-25/ListVirtualGateways">REST API Reference for ListVirtualGateways Operation</seealso>
        Task<ListVirtualGatewaysResponse> ListVirtualGatewaysAsync(ListVirtualGatewaysRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListVirtualNodes



        /// <summary>
        /// Returns a list of existing virtual nodes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVirtualNodes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListVirtualNodes service method, as returned by AppMesh.</returns>
        /// <exception cref="Amazon.AppMesh.Model.BadRequestException">
        /// The request syntax was malformed. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ForbiddenException">
        /// You don't have permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.InternalServerErrorException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.NotFoundException">
        /// The specified resource doesn't exist. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the service.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.TooManyRequestsException">
        /// The maximum request rate permitted by the App Mesh APIs has been exceeded for your
        /// account. For best results, use an increasing or variable sleep interval between requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2019-01-25/ListVirtualNodes">REST API Reference for ListVirtualNodes Operation</seealso>
        Task<ListVirtualNodesResponse> ListVirtualNodesAsync(ListVirtualNodesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListVirtualRouters



        /// <summary>
        /// Returns a list of existing virtual routers in a service mesh.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVirtualRouters service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListVirtualRouters service method, as returned by AppMesh.</returns>
        /// <exception cref="Amazon.AppMesh.Model.BadRequestException">
        /// The request syntax was malformed. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ForbiddenException">
        /// You don't have permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.InternalServerErrorException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.NotFoundException">
        /// The specified resource doesn't exist. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the service.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.TooManyRequestsException">
        /// The maximum request rate permitted by the App Mesh APIs has been exceeded for your
        /// account. For best results, use an increasing or variable sleep interval between requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2019-01-25/ListVirtualRouters">REST API Reference for ListVirtualRouters Operation</seealso>
        Task<ListVirtualRoutersResponse> ListVirtualRoutersAsync(ListVirtualRoutersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListVirtualServices



        /// <summary>
        /// Returns a list of existing virtual services in a service mesh.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVirtualServices service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListVirtualServices service method, as returned by AppMesh.</returns>
        /// <exception cref="Amazon.AppMesh.Model.BadRequestException">
        /// The request syntax was malformed. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ForbiddenException">
        /// You don't have permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.InternalServerErrorException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.NotFoundException">
        /// The specified resource doesn't exist. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the service.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.TooManyRequestsException">
        /// The maximum request rate permitted by the App Mesh APIs has been exceeded for your
        /// account. For best results, use an increasing or variable sleep interval between requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2019-01-25/ListVirtualServices">REST API Reference for ListVirtualServices Operation</seealso>
        Task<ListVirtualServicesResponse> ListVirtualServicesAsync(ListVirtualServicesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TagResource



        /// <summary>
        /// Associates the specified tags to a resource with the specified <c>resourceArn</c>.
        /// If existing tags on a resource aren't specified in the request parameters, they aren't
        /// changed. When a resource is deleted, the tags associated with that resource are also
        /// deleted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by AppMesh.</returns>
        /// <exception cref="Amazon.AppMesh.Model.BadRequestException">
        /// The request syntax was malformed. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ForbiddenException">
        /// You don't have permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.InternalServerErrorException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.NotFoundException">
        /// The specified resource doesn't exist. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the service.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.TooManyRequestsException">
        /// The maximum request rate permitted by the App Mesh APIs has been exceeded for your
        /// account. For best results, use an increasing or variable sleep interval between requests.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.TooManyTagsException">
        /// The request exceeds the maximum allowed number of tags allowed per resource. The current
        /// limit is 50 user tags per resource. You must reduce the number of tags in the request.
        /// None of the tags in this request were applied.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2019-01-25/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UntagResource



        /// <summary>
        /// Deletes specified tags from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by AppMesh.</returns>
        /// <exception cref="Amazon.AppMesh.Model.BadRequestException">
        /// The request syntax was malformed. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ForbiddenException">
        /// You don't have permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.InternalServerErrorException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.NotFoundException">
        /// The specified resource doesn't exist. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the service.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.TooManyRequestsException">
        /// The maximum request rate permitted by the App Mesh APIs has been exceeded for your
        /// account. For best results, use an increasing or variable sleep interval between requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2019-01-25/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateGatewayRoute



        /// <summary>
        /// Updates an existing gateway route that is associated to a specified virtual gateway
        /// in a service mesh.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGatewayRoute service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateGatewayRoute service method, as returned by AppMesh.</returns>
        /// <exception cref="Amazon.AppMesh.Model.BadRequestException">
        /// The request syntax was malformed. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ConflictException">
        /// The request contains a client token that was used for a previous update resource call
        /// with different specifications. Try the request again with a new client token.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ForbiddenException">
        /// You don't have permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.InternalServerErrorException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.LimitExceededException">
        /// You have exceeded a service limit for your account. For more information, see <a href="https://docs.aws.amazon.com/app-mesh/latest/userguide/service-quotas.html">Service
        /// Limits</a> in the <i>App Mesh User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.NotFoundException">
        /// The specified resource doesn't exist. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the service.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.TooManyRequestsException">
        /// The maximum request rate permitted by the App Mesh APIs has been exceeded for your
        /// account. For best results, use an increasing or variable sleep interval between requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2019-01-25/UpdateGatewayRoute">REST API Reference for UpdateGatewayRoute Operation</seealso>
        Task<UpdateGatewayRouteResponse> UpdateGatewayRouteAsync(UpdateGatewayRouteRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateMesh



        /// <summary>
        /// Updates an existing service mesh.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMesh service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateMesh service method, as returned by AppMesh.</returns>
        /// <exception cref="Amazon.AppMesh.Model.BadRequestException">
        /// The request syntax was malformed. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ConflictException">
        /// The request contains a client token that was used for a previous update resource call
        /// with different specifications. Try the request again with a new client token.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ForbiddenException">
        /// You don't have permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.InternalServerErrorException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.NotFoundException">
        /// The specified resource doesn't exist. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the service.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.TooManyRequestsException">
        /// The maximum request rate permitted by the App Mesh APIs has been exceeded for your
        /// account. For best results, use an increasing or variable sleep interval between requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2019-01-25/UpdateMesh">REST API Reference for UpdateMesh Operation</seealso>
        Task<UpdateMeshResponse> UpdateMeshAsync(UpdateMeshRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateRoute



        /// <summary>
        /// Updates an existing route for a specified service mesh and virtual router.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRoute service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateRoute service method, as returned by AppMesh.</returns>
        /// <exception cref="Amazon.AppMesh.Model.BadRequestException">
        /// The request syntax was malformed. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ConflictException">
        /// The request contains a client token that was used for a previous update resource call
        /// with different specifications. Try the request again with a new client token.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ForbiddenException">
        /// You don't have permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.InternalServerErrorException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.LimitExceededException">
        /// You have exceeded a service limit for your account. For more information, see <a href="https://docs.aws.amazon.com/app-mesh/latest/userguide/service-quotas.html">Service
        /// Limits</a> in the <i>App Mesh User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.NotFoundException">
        /// The specified resource doesn't exist. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the service.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.TooManyRequestsException">
        /// The maximum request rate permitted by the App Mesh APIs has been exceeded for your
        /// account. For best results, use an increasing or variable sleep interval between requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2019-01-25/UpdateRoute">REST API Reference for UpdateRoute Operation</seealso>
        Task<UpdateRouteResponse> UpdateRouteAsync(UpdateRouteRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateVirtualGateway



        /// <summary>
        /// Updates an existing virtual gateway in a specified service mesh.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateVirtualGateway service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateVirtualGateway service method, as returned by AppMesh.</returns>
        /// <exception cref="Amazon.AppMesh.Model.BadRequestException">
        /// The request syntax was malformed. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ConflictException">
        /// The request contains a client token that was used for a previous update resource call
        /// with different specifications. Try the request again with a new client token.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ForbiddenException">
        /// You don't have permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.InternalServerErrorException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.LimitExceededException">
        /// You have exceeded a service limit for your account. For more information, see <a href="https://docs.aws.amazon.com/app-mesh/latest/userguide/service-quotas.html">Service
        /// Limits</a> in the <i>App Mesh User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.NotFoundException">
        /// The specified resource doesn't exist. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the service.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.TooManyRequestsException">
        /// The maximum request rate permitted by the App Mesh APIs has been exceeded for your
        /// account. For best results, use an increasing or variable sleep interval between requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2019-01-25/UpdateVirtualGateway">REST API Reference for UpdateVirtualGateway Operation</seealso>
        Task<UpdateVirtualGatewayResponse> UpdateVirtualGatewayAsync(UpdateVirtualGatewayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateVirtualNode



        /// <summary>
        /// Updates an existing virtual node in a specified service mesh.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateVirtualNode service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateVirtualNode service method, as returned by AppMesh.</returns>
        /// <exception cref="Amazon.AppMesh.Model.BadRequestException">
        /// The request syntax was malformed. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ConflictException">
        /// The request contains a client token that was used for a previous update resource call
        /// with different specifications. Try the request again with a new client token.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ForbiddenException">
        /// You don't have permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.InternalServerErrorException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.LimitExceededException">
        /// You have exceeded a service limit for your account. For more information, see <a href="https://docs.aws.amazon.com/app-mesh/latest/userguide/service-quotas.html">Service
        /// Limits</a> in the <i>App Mesh User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.NotFoundException">
        /// The specified resource doesn't exist. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the service.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.TooManyRequestsException">
        /// The maximum request rate permitted by the App Mesh APIs has been exceeded for your
        /// account. For best results, use an increasing or variable sleep interval between requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2019-01-25/UpdateVirtualNode">REST API Reference for UpdateVirtualNode Operation</seealso>
        Task<UpdateVirtualNodeResponse> UpdateVirtualNodeAsync(UpdateVirtualNodeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateVirtualRouter



        /// <summary>
        /// Updates an existing virtual router in a specified service mesh.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateVirtualRouter service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateVirtualRouter service method, as returned by AppMesh.</returns>
        /// <exception cref="Amazon.AppMesh.Model.BadRequestException">
        /// The request syntax was malformed. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ConflictException">
        /// The request contains a client token that was used for a previous update resource call
        /// with different specifications. Try the request again with a new client token.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ForbiddenException">
        /// You don't have permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.InternalServerErrorException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.LimitExceededException">
        /// You have exceeded a service limit for your account. For more information, see <a href="https://docs.aws.amazon.com/app-mesh/latest/userguide/service-quotas.html">Service
        /// Limits</a> in the <i>App Mesh User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.NotFoundException">
        /// The specified resource doesn't exist. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the service.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.TooManyRequestsException">
        /// The maximum request rate permitted by the App Mesh APIs has been exceeded for your
        /// account. For best results, use an increasing or variable sleep interval between requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2019-01-25/UpdateVirtualRouter">REST API Reference for UpdateVirtualRouter Operation</seealso>
        Task<UpdateVirtualRouterResponse> UpdateVirtualRouterAsync(UpdateVirtualRouterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateVirtualService



        /// <summary>
        /// Updates an existing virtual service in a specified service mesh.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateVirtualService service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateVirtualService service method, as returned by AppMesh.</returns>
        /// <exception cref="Amazon.AppMesh.Model.BadRequestException">
        /// The request syntax was malformed. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ConflictException">
        /// The request contains a client token that was used for a previous update resource call
        /// with different specifications. Try the request again with a new client token.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ForbiddenException">
        /// You don't have permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.InternalServerErrorException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.LimitExceededException">
        /// You have exceeded a service limit for your account. For more information, see <a href="https://docs.aws.amazon.com/app-mesh/latest/userguide/service-quotas.html">Service
        /// Limits</a> in the <i>App Mesh User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.NotFoundException">
        /// The specified resource doesn't exist. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the service.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.TooManyRequestsException">
        /// The maximum request rate permitted by the App Mesh APIs has been exceeded for your
        /// account. For best results, use an increasing or variable sleep interval between requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2019-01-25/UpdateVirtualService">REST API Reference for UpdateVirtualService Operation</seealso>
        Task<UpdateVirtualServiceResponse> UpdateVirtualServiceAsync(UpdateVirtualServiceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        [System.Diagnostics.CodeAnalysis.DynamicDependency(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties, typeof(AmazonAppMeshConfig))]
        static ClientConfig IAmazonService.CreateDefaultClientConfig() => new AmazonAppMeshConfig();

        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("AssemblyLoadTrimming", "IL2026:RequiresUnreferencedCode",
    Justification = "This suppression is here to ignore the warnings caused by CognitoSync. See justification in IAmazonService.")]
        static IAmazonService IAmazonService.CreateDefaultServiceClient(AWSCredentials awsCredentials, ClientConfig clientConfig)
        {
            var serviceClientConfig = clientConfig as AmazonAppMeshConfig;
            if (serviceClientConfig == null)
            {
                throw new AmazonClientException("ClientConfig is not of type AmazonAppMeshConfig to create AmazonAppMeshClient");
            }

            return awsCredentials == null ? 
                    new AmazonAppMeshClient(serviceClientConfig) :
                    new AmazonAppMeshClient(awsCredentials, serviceClientConfig);
        }
#pragma warning restore CA1033
#endif
        #endregion
    }
}