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
using System.Collections.Generic;
using System.Net;

using Amazon.AppMesh.Model;
using Amazon.AppMesh.Model.Internal.MarshallTransformations;
using Amazon.AppMesh.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

#pragma warning disable CS1570
namespace Amazon.AppMesh
{
    /// <summary>
    /// <para>Implementation for accessing AppMesh</para>
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
    public partial class AmazonAppMeshClient : AmazonServiceClient, IAmazonAppMesh
    {
        private static IServiceMetadata serviceMetadata = new AmazonAppMeshMetadata();

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        private IAppMeshPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IAppMeshPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new AppMeshPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif
        #region Constructors

        /// <summary>
        /// Constructs AmazonAppMeshClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public AmazonAppMeshClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonAppMeshConfig()) { }

        /// <summary>
        /// Constructs AmazonAppMeshClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="region">The region to connect.</param>
        public AmazonAppMeshClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonAppMeshConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonAppMeshClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="config">The AmazonAppMeshClient Configuration Object</param>
        public AmazonAppMeshClient(AmazonAppMeshConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}
        /// <summary>
        /// Constructs AmazonAppMeshClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonAppMeshClient(AWSCredentials credentials)
            : this(credentials, new AmazonAppMeshConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAppMeshClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAppMeshClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonAppMeshConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonAppMeshClient with AWS Credentials and an
        /// AmazonAppMeshClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonAppMeshClient Configuration Object</param>
        public AmazonAppMeshClient(AWSCredentials credentials, AmazonAppMeshConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonAppMeshClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonAppMeshClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonAppMeshConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAppMeshClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAppMeshClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonAppMeshConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonAppMeshClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonAppMeshClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonAppMeshClient Configuration Object</param>
        public AmazonAppMeshClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonAppMeshConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonAppMeshClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonAppMeshClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonAppMeshConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAppMeshClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAppMeshClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonAppMeshConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonAppMeshClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonAppMeshClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonAppMeshClient Configuration Object</param>
        public AmazonAppMeshClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonAppMeshConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides

        
        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        }

        /// <summary>
        /// Customize the pipeline
        /// </summary>
        /// <param name="pipeline"></param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonAppMeshEndpointResolver());
        }
        /// <summary>
        /// Capture metadata for the service.
        /// </summary>
        protected override IServiceMetadata ServiceMetadata
        {
            get
            {
                return serviceMetadata;
            }
        }

        #endregion

        #region Dispose

        /// <summary>
        /// Disposes the service client.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion


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
        public virtual CreateGatewayRouteResponse CreateGatewayRoute(CreateGatewayRouteRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateGatewayRouteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGatewayRouteResponseUnmarshaller.Instance;

            return Invoke<CreateGatewayRouteResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateGatewayRoute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateGatewayRoute operation on AmazonAppMeshClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateGatewayRoute
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2019-01-25/CreateGatewayRoute">REST API Reference for CreateGatewayRoute Operation</seealso>
        public virtual IAsyncResult BeginCreateGatewayRoute(CreateGatewayRouteRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateGatewayRouteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGatewayRouteResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateGatewayRoute operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateGatewayRoute.</param>
        /// 
        /// <returns>Returns a  CreateGatewayRouteResult from AppMesh.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2019-01-25/CreateGatewayRoute">REST API Reference for CreateGatewayRoute Operation</seealso>
        public virtual CreateGatewayRouteResponse EndCreateGatewayRoute(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateGatewayRouteResponse>(asyncResult);
        }

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
        public virtual CreateMeshResponse CreateMesh(CreateMeshRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateMeshRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMeshResponseUnmarshaller.Instance;

            return Invoke<CreateMeshResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateMesh operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateMesh operation on AmazonAppMeshClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateMesh
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2019-01-25/CreateMesh">REST API Reference for CreateMesh Operation</seealso>
        public virtual IAsyncResult BeginCreateMesh(CreateMeshRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateMeshRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMeshResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateMesh operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateMesh.</param>
        /// 
        /// <returns>Returns a  CreateMeshResult from AppMesh.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2019-01-25/CreateMesh">REST API Reference for CreateMesh Operation</seealso>
        public virtual CreateMeshResponse EndCreateMesh(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateMeshResponse>(asyncResult);
        }

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
        public virtual CreateRouteResponse CreateRoute(CreateRouteRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateRouteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRouteResponseUnmarshaller.Instance;

            return Invoke<CreateRouteResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateRoute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRoute operation on AmazonAppMeshClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateRoute
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2019-01-25/CreateRoute">REST API Reference for CreateRoute Operation</seealso>
        public virtual IAsyncResult BeginCreateRoute(CreateRouteRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateRouteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRouteResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateRoute operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateRoute.</param>
        /// 
        /// <returns>Returns a  CreateRouteResult from AppMesh.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2019-01-25/CreateRoute">REST API Reference for CreateRoute Operation</seealso>
        public virtual CreateRouteResponse EndCreateRoute(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateRouteResponse>(asyncResult);
        }

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
        public virtual CreateVirtualGatewayResponse CreateVirtualGateway(CreateVirtualGatewayRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateVirtualGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVirtualGatewayResponseUnmarshaller.Instance;

            return Invoke<CreateVirtualGatewayResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateVirtualGateway operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateVirtualGateway operation on AmazonAppMeshClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateVirtualGateway
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2019-01-25/CreateVirtualGateway">REST API Reference for CreateVirtualGateway Operation</seealso>
        public virtual IAsyncResult BeginCreateVirtualGateway(CreateVirtualGatewayRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateVirtualGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVirtualGatewayResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateVirtualGateway operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateVirtualGateway.</param>
        /// 
        /// <returns>Returns a  CreateVirtualGatewayResult from AppMesh.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2019-01-25/CreateVirtualGateway">REST API Reference for CreateVirtualGateway Operation</seealso>
        public virtual CreateVirtualGatewayResponse EndCreateVirtualGateway(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateVirtualGatewayResponse>(asyncResult);
        }

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
        public virtual CreateVirtualNodeResponse CreateVirtualNode(CreateVirtualNodeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateVirtualNodeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVirtualNodeResponseUnmarshaller.Instance;

            return Invoke<CreateVirtualNodeResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateVirtualNode operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateVirtualNode operation on AmazonAppMeshClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateVirtualNode
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2019-01-25/CreateVirtualNode">REST API Reference for CreateVirtualNode Operation</seealso>
        public virtual IAsyncResult BeginCreateVirtualNode(CreateVirtualNodeRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateVirtualNodeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVirtualNodeResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateVirtualNode operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateVirtualNode.</param>
        /// 
        /// <returns>Returns a  CreateVirtualNodeResult from AppMesh.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2019-01-25/CreateVirtualNode">REST API Reference for CreateVirtualNode Operation</seealso>
        public virtual CreateVirtualNodeResponse EndCreateVirtualNode(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateVirtualNodeResponse>(asyncResult);
        }

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
        public virtual CreateVirtualRouterResponse CreateVirtualRouter(CreateVirtualRouterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateVirtualRouterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVirtualRouterResponseUnmarshaller.Instance;

            return Invoke<CreateVirtualRouterResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateVirtualRouter operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateVirtualRouter operation on AmazonAppMeshClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateVirtualRouter
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2019-01-25/CreateVirtualRouter">REST API Reference for CreateVirtualRouter Operation</seealso>
        public virtual IAsyncResult BeginCreateVirtualRouter(CreateVirtualRouterRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateVirtualRouterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVirtualRouterResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateVirtualRouter operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateVirtualRouter.</param>
        /// 
        /// <returns>Returns a  CreateVirtualRouterResult from AppMesh.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2019-01-25/CreateVirtualRouter">REST API Reference for CreateVirtualRouter Operation</seealso>
        public virtual CreateVirtualRouterResponse EndCreateVirtualRouter(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateVirtualRouterResponse>(asyncResult);
        }

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
        public virtual CreateVirtualServiceResponse CreateVirtualService(CreateVirtualServiceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateVirtualServiceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVirtualServiceResponseUnmarshaller.Instance;

            return Invoke<CreateVirtualServiceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateVirtualService operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateVirtualService operation on AmazonAppMeshClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateVirtualService
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2019-01-25/CreateVirtualService">REST API Reference for CreateVirtualService Operation</seealso>
        public virtual IAsyncResult BeginCreateVirtualService(CreateVirtualServiceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateVirtualServiceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVirtualServiceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateVirtualService operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateVirtualService.</param>
        /// 
        /// <returns>Returns a  CreateVirtualServiceResult from AppMesh.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2019-01-25/CreateVirtualService">REST API Reference for CreateVirtualService Operation</seealso>
        public virtual CreateVirtualServiceResponse EndCreateVirtualService(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateVirtualServiceResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteGatewayRoute

        /// <summary>
        /// Deletes an existing gateway route.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGatewayRoute service method.</param>
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
        public virtual DeleteGatewayRouteResponse DeleteGatewayRoute(DeleteGatewayRouteRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteGatewayRouteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGatewayRouteResponseUnmarshaller.Instance;

            return Invoke<DeleteGatewayRouteResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteGatewayRoute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteGatewayRoute operation on AmazonAppMeshClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteGatewayRoute
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2019-01-25/DeleteGatewayRoute">REST API Reference for DeleteGatewayRoute Operation</seealso>
        public virtual IAsyncResult BeginDeleteGatewayRoute(DeleteGatewayRouteRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteGatewayRouteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGatewayRouteResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteGatewayRoute operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteGatewayRoute.</param>
        /// 
        /// <returns>Returns a  DeleteGatewayRouteResult from AppMesh.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2019-01-25/DeleteGatewayRoute">REST API Reference for DeleteGatewayRoute Operation</seealso>
        public virtual DeleteGatewayRouteResponse EndDeleteGatewayRoute(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteGatewayRouteResponse>(asyncResult);
        }

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
        public virtual DeleteMeshResponse DeleteMesh(DeleteMeshRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteMeshRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMeshResponseUnmarshaller.Instance;

            return Invoke<DeleteMeshResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteMesh operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteMesh operation on AmazonAppMeshClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteMesh
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2019-01-25/DeleteMesh">REST API Reference for DeleteMesh Operation</seealso>
        public virtual IAsyncResult BeginDeleteMesh(DeleteMeshRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteMeshRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMeshResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteMesh operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteMesh.</param>
        /// 
        /// <returns>Returns a  DeleteMeshResult from AppMesh.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2019-01-25/DeleteMesh">REST API Reference for DeleteMesh Operation</seealso>
        public virtual DeleteMeshResponse EndDeleteMesh(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteMeshResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteRoute

        /// <summary>
        /// Deletes an existing route.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRoute service method.</param>
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
        public virtual DeleteRouteResponse DeleteRoute(DeleteRouteRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteRouteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRouteResponseUnmarshaller.Instance;

            return Invoke<DeleteRouteResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRoute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRoute operation on AmazonAppMeshClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteRoute
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2019-01-25/DeleteRoute">REST API Reference for DeleteRoute Operation</seealso>
        public virtual IAsyncResult BeginDeleteRoute(DeleteRouteRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteRouteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRouteResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteRoute operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRoute.</param>
        /// 
        /// <returns>Returns a  DeleteRouteResult from AppMesh.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2019-01-25/DeleteRoute">REST API Reference for DeleteRoute Operation</seealso>
        public virtual DeleteRouteResponse EndDeleteRoute(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteRouteResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteVirtualGateway

        /// <summary>
        /// Deletes an existing virtual gateway. You cannot delete a virtual gateway if any gateway
        /// routes are associated to it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVirtualGateway service method.</param>
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
        public virtual DeleteVirtualGatewayResponse DeleteVirtualGateway(DeleteVirtualGatewayRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteVirtualGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVirtualGatewayResponseUnmarshaller.Instance;

            return Invoke<DeleteVirtualGatewayResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVirtualGateway operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVirtualGateway operation on AmazonAppMeshClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteVirtualGateway
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2019-01-25/DeleteVirtualGateway">REST API Reference for DeleteVirtualGateway Operation</seealso>
        public virtual IAsyncResult BeginDeleteVirtualGateway(DeleteVirtualGatewayRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteVirtualGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVirtualGatewayResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteVirtualGateway operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteVirtualGateway.</param>
        /// 
        /// <returns>Returns a  DeleteVirtualGatewayResult from AppMesh.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2019-01-25/DeleteVirtualGateway">REST API Reference for DeleteVirtualGateway Operation</seealso>
        public virtual DeleteVirtualGatewayResponse EndDeleteVirtualGateway(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteVirtualGatewayResponse>(asyncResult);
        }

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
        public virtual DeleteVirtualNodeResponse DeleteVirtualNode(DeleteVirtualNodeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteVirtualNodeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVirtualNodeResponseUnmarshaller.Instance;

            return Invoke<DeleteVirtualNodeResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVirtualNode operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVirtualNode operation on AmazonAppMeshClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteVirtualNode
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2019-01-25/DeleteVirtualNode">REST API Reference for DeleteVirtualNode Operation</seealso>
        public virtual IAsyncResult BeginDeleteVirtualNode(DeleteVirtualNodeRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteVirtualNodeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVirtualNodeResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteVirtualNode operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteVirtualNode.</param>
        /// 
        /// <returns>Returns a  DeleteVirtualNodeResult from AppMesh.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2019-01-25/DeleteVirtualNode">REST API Reference for DeleteVirtualNode Operation</seealso>
        public virtual DeleteVirtualNodeResponse EndDeleteVirtualNode(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteVirtualNodeResponse>(asyncResult);
        }

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
        public virtual DeleteVirtualRouterResponse DeleteVirtualRouter(DeleteVirtualRouterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteVirtualRouterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVirtualRouterResponseUnmarshaller.Instance;

            return Invoke<DeleteVirtualRouterResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVirtualRouter operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVirtualRouter operation on AmazonAppMeshClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteVirtualRouter
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2019-01-25/DeleteVirtualRouter">REST API Reference for DeleteVirtualRouter Operation</seealso>
        public virtual IAsyncResult BeginDeleteVirtualRouter(DeleteVirtualRouterRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteVirtualRouterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVirtualRouterResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteVirtualRouter operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteVirtualRouter.</param>
        /// 
        /// <returns>Returns a  DeleteVirtualRouterResult from AppMesh.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2019-01-25/DeleteVirtualRouter">REST API Reference for DeleteVirtualRouter Operation</seealso>
        public virtual DeleteVirtualRouterResponse EndDeleteVirtualRouter(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteVirtualRouterResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteVirtualService

        /// <summary>
        /// Deletes an existing virtual service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVirtualService service method.</param>
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
        public virtual DeleteVirtualServiceResponse DeleteVirtualService(DeleteVirtualServiceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteVirtualServiceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVirtualServiceResponseUnmarshaller.Instance;

            return Invoke<DeleteVirtualServiceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVirtualService operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVirtualService operation on AmazonAppMeshClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteVirtualService
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2019-01-25/DeleteVirtualService">REST API Reference for DeleteVirtualService Operation</seealso>
        public virtual IAsyncResult BeginDeleteVirtualService(DeleteVirtualServiceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteVirtualServiceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVirtualServiceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteVirtualService operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteVirtualService.</param>
        /// 
        /// <returns>Returns a  DeleteVirtualServiceResult from AppMesh.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2019-01-25/DeleteVirtualService">REST API Reference for DeleteVirtualService Operation</seealso>
        public virtual DeleteVirtualServiceResponse EndDeleteVirtualService(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteVirtualServiceResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeGatewayRoute

        /// <summary>
        /// Describes an existing gateway route.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeGatewayRoute service method.</param>
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
        public virtual DescribeGatewayRouteResponse DescribeGatewayRoute(DescribeGatewayRouteRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeGatewayRouteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeGatewayRouteResponseUnmarshaller.Instance;

            return Invoke<DescribeGatewayRouteResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeGatewayRoute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeGatewayRoute operation on AmazonAppMeshClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeGatewayRoute
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2019-01-25/DescribeGatewayRoute">REST API Reference for DescribeGatewayRoute Operation</seealso>
        public virtual IAsyncResult BeginDescribeGatewayRoute(DescribeGatewayRouteRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeGatewayRouteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeGatewayRouteResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeGatewayRoute operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeGatewayRoute.</param>
        /// 
        /// <returns>Returns a  DescribeGatewayRouteResult from AppMesh.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2019-01-25/DescribeGatewayRoute">REST API Reference for DescribeGatewayRoute Operation</seealso>
        public virtual DescribeGatewayRouteResponse EndDescribeGatewayRoute(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeGatewayRouteResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeMesh

        /// <summary>
        /// Describes an existing service mesh.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeMesh service method.</param>
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
        public virtual DescribeMeshResponse DescribeMesh(DescribeMeshRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeMeshRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeMeshResponseUnmarshaller.Instance;

            return Invoke<DescribeMeshResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeMesh operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeMesh operation on AmazonAppMeshClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeMesh
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2019-01-25/DescribeMesh">REST API Reference for DescribeMesh Operation</seealso>
        public virtual IAsyncResult BeginDescribeMesh(DescribeMeshRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeMeshRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeMeshResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeMesh operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeMesh.</param>
        /// 
        /// <returns>Returns a  DescribeMeshResult from AppMesh.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2019-01-25/DescribeMesh">REST API Reference for DescribeMesh Operation</seealso>
        public virtual DescribeMeshResponse EndDescribeMesh(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeMeshResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeRoute

        /// <summary>
        /// Describes an existing route.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRoute service method.</param>
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
        public virtual DescribeRouteResponse DescribeRoute(DescribeRouteRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeRouteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRouteResponseUnmarshaller.Instance;

            return Invoke<DescribeRouteResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeRoute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeRoute operation on AmazonAppMeshClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeRoute
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2019-01-25/DescribeRoute">REST API Reference for DescribeRoute Operation</seealso>
        public virtual IAsyncResult BeginDescribeRoute(DescribeRouteRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeRouteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRouteResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeRoute operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeRoute.</param>
        /// 
        /// <returns>Returns a  DescribeRouteResult from AppMesh.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2019-01-25/DescribeRoute">REST API Reference for DescribeRoute Operation</seealso>
        public virtual DescribeRouteResponse EndDescribeRoute(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeRouteResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeVirtualGateway

        /// <summary>
        /// Describes an existing virtual gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVirtualGateway service method.</param>
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
        public virtual DescribeVirtualGatewayResponse DescribeVirtualGateway(DescribeVirtualGatewayRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeVirtualGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeVirtualGatewayResponseUnmarshaller.Instance;

            return Invoke<DescribeVirtualGatewayResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVirtualGateway operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVirtualGateway operation on AmazonAppMeshClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeVirtualGateway
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2019-01-25/DescribeVirtualGateway">REST API Reference for DescribeVirtualGateway Operation</seealso>
        public virtual IAsyncResult BeginDescribeVirtualGateway(DescribeVirtualGatewayRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeVirtualGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeVirtualGatewayResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeVirtualGateway operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeVirtualGateway.</param>
        /// 
        /// <returns>Returns a  DescribeVirtualGatewayResult from AppMesh.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2019-01-25/DescribeVirtualGateway">REST API Reference for DescribeVirtualGateway Operation</seealso>
        public virtual DescribeVirtualGatewayResponse EndDescribeVirtualGateway(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeVirtualGatewayResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeVirtualNode

        /// <summary>
        /// Describes an existing virtual node.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVirtualNode service method.</param>
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
        public virtual DescribeVirtualNodeResponse DescribeVirtualNode(DescribeVirtualNodeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeVirtualNodeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeVirtualNodeResponseUnmarshaller.Instance;

            return Invoke<DescribeVirtualNodeResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVirtualNode operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVirtualNode operation on AmazonAppMeshClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeVirtualNode
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2019-01-25/DescribeVirtualNode">REST API Reference for DescribeVirtualNode Operation</seealso>
        public virtual IAsyncResult BeginDescribeVirtualNode(DescribeVirtualNodeRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeVirtualNodeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeVirtualNodeResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeVirtualNode operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeVirtualNode.</param>
        /// 
        /// <returns>Returns a  DescribeVirtualNodeResult from AppMesh.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2019-01-25/DescribeVirtualNode">REST API Reference for DescribeVirtualNode Operation</seealso>
        public virtual DescribeVirtualNodeResponse EndDescribeVirtualNode(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeVirtualNodeResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeVirtualRouter

        /// <summary>
        /// Describes an existing virtual router.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVirtualRouter service method.</param>
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
        public virtual DescribeVirtualRouterResponse DescribeVirtualRouter(DescribeVirtualRouterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeVirtualRouterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeVirtualRouterResponseUnmarshaller.Instance;

            return Invoke<DescribeVirtualRouterResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVirtualRouter operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVirtualRouter operation on AmazonAppMeshClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeVirtualRouter
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2019-01-25/DescribeVirtualRouter">REST API Reference for DescribeVirtualRouter Operation</seealso>
        public virtual IAsyncResult BeginDescribeVirtualRouter(DescribeVirtualRouterRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeVirtualRouterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeVirtualRouterResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeVirtualRouter operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeVirtualRouter.</param>
        /// 
        /// <returns>Returns a  DescribeVirtualRouterResult from AppMesh.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2019-01-25/DescribeVirtualRouter">REST API Reference for DescribeVirtualRouter Operation</seealso>
        public virtual DescribeVirtualRouterResponse EndDescribeVirtualRouter(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeVirtualRouterResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeVirtualService

        /// <summary>
        /// Describes an existing virtual service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVirtualService service method.</param>
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
        public virtual DescribeVirtualServiceResponse DescribeVirtualService(DescribeVirtualServiceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeVirtualServiceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeVirtualServiceResponseUnmarshaller.Instance;

            return Invoke<DescribeVirtualServiceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVirtualService operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVirtualService operation on AmazonAppMeshClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeVirtualService
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2019-01-25/DescribeVirtualService">REST API Reference for DescribeVirtualService Operation</seealso>
        public virtual IAsyncResult BeginDescribeVirtualService(DescribeVirtualServiceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeVirtualServiceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeVirtualServiceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeVirtualService operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeVirtualService.</param>
        /// 
        /// <returns>Returns a  DescribeVirtualServiceResult from AppMesh.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2019-01-25/DescribeVirtualService">REST API Reference for DescribeVirtualService Operation</seealso>
        public virtual DescribeVirtualServiceResponse EndDescribeVirtualService(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeVirtualServiceResponse>(asyncResult);
        }

        #endregion
        
        #region  ListGatewayRoutes

        /// <summary>
        /// Returns a list of existing gateway routes that are associated to a virtual gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGatewayRoutes service method.</param>
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
        public virtual ListGatewayRoutesResponse ListGatewayRoutes(ListGatewayRoutesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListGatewayRoutesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGatewayRoutesResponseUnmarshaller.Instance;

            return Invoke<ListGatewayRoutesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListGatewayRoutes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListGatewayRoutes operation on AmazonAppMeshClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListGatewayRoutes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2019-01-25/ListGatewayRoutes">REST API Reference for ListGatewayRoutes Operation</seealso>
        public virtual IAsyncResult BeginListGatewayRoutes(ListGatewayRoutesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListGatewayRoutesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGatewayRoutesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListGatewayRoutes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListGatewayRoutes.</param>
        /// 
        /// <returns>Returns a  ListGatewayRoutesResult from AppMesh.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2019-01-25/ListGatewayRoutes">REST API Reference for ListGatewayRoutes Operation</seealso>
        public virtual ListGatewayRoutesResponse EndListGatewayRoutes(IAsyncResult asyncResult)
        {
            return EndInvoke<ListGatewayRoutesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListMeshes

        /// <summary>
        /// Returns a list of existing service meshes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMeshes service method.</param>
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
        public virtual ListMeshesResponse ListMeshes(ListMeshesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListMeshesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMeshesResponseUnmarshaller.Instance;

            return Invoke<ListMeshesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListMeshes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMeshes operation on AmazonAppMeshClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListMeshes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2019-01-25/ListMeshes">REST API Reference for ListMeshes Operation</seealso>
        public virtual IAsyncResult BeginListMeshes(ListMeshesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListMeshesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMeshesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListMeshes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListMeshes.</param>
        /// 
        /// <returns>Returns a  ListMeshesResult from AppMesh.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2019-01-25/ListMeshes">REST API Reference for ListMeshes Operation</seealso>
        public virtual ListMeshesResponse EndListMeshes(IAsyncResult asyncResult)
        {
            return EndInvoke<ListMeshesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListRoutes

        /// <summary>
        /// Returns a list of existing routes in a service mesh.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRoutes service method.</param>
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
        public virtual ListRoutesResponse ListRoutes(ListRoutesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRoutesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRoutesResponseUnmarshaller.Instance;

            return Invoke<ListRoutesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListRoutes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRoutes operation on AmazonAppMeshClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRoutes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2019-01-25/ListRoutes">REST API Reference for ListRoutes Operation</seealso>
        public virtual IAsyncResult BeginListRoutes(ListRoutesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRoutesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRoutesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListRoutes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRoutes.</param>
        /// 
        /// <returns>Returns a  ListRoutesResult from AppMesh.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2019-01-25/ListRoutes">REST API Reference for ListRoutes Operation</seealso>
        public virtual ListRoutesResponse EndListRoutes(IAsyncResult asyncResult)
        {
            return EndInvoke<ListRoutesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// List the tags for an App Mesh resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
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
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonAppMeshClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2019-01-25/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from AppMesh.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2019-01-25/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  ListVirtualGateways

        /// <summary>
        /// Returns a list of existing virtual gateways in a service mesh.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVirtualGateways service method.</param>
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
        public virtual ListVirtualGatewaysResponse ListVirtualGateways(ListVirtualGatewaysRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListVirtualGatewaysRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListVirtualGatewaysResponseUnmarshaller.Instance;

            return Invoke<ListVirtualGatewaysResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListVirtualGateways operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListVirtualGateways operation on AmazonAppMeshClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListVirtualGateways
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2019-01-25/ListVirtualGateways">REST API Reference for ListVirtualGateways Operation</seealso>
        public virtual IAsyncResult BeginListVirtualGateways(ListVirtualGatewaysRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListVirtualGatewaysRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListVirtualGatewaysResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListVirtualGateways operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListVirtualGateways.</param>
        /// 
        /// <returns>Returns a  ListVirtualGatewaysResult from AppMesh.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2019-01-25/ListVirtualGateways">REST API Reference for ListVirtualGateways Operation</seealso>
        public virtual ListVirtualGatewaysResponse EndListVirtualGateways(IAsyncResult asyncResult)
        {
            return EndInvoke<ListVirtualGatewaysResponse>(asyncResult);
        }

        #endregion
        
        #region  ListVirtualNodes

        /// <summary>
        /// Returns a list of existing virtual nodes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVirtualNodes service method.</param>
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
        public virtual ListVirtualNodesResponse ListVirtualNodes(ListVirtualNodesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListVirtualNodesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListVirtualNodesResponseUnmarshaller.Instance;

            return Invoke<ListVirtualNodesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListVirtualNodes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListVirtualNodes operation on AmazonAppMeshClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListVirtualNodes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2019-01-25/ListVirtualNodes">REST API Reference for ListVirtualNodes Operation</seealso>
        public virtual IAsyncResult BeginListVirtualNodes(ListVirtualNodesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListVirtualNodesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListVirtualNodesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListVirtualNodes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListVirtualNodes.</param>
        /// 
        /// <returns>Returns a  ListVirtualNodesResult from AppMesh.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2019-01-25/ListVirtualNodes">REST API Reference for ListVirtualNodes Operation</seealso>
        public virtual ListVirtualNodesResponse EndListVirtualNodes(IAsyncResult asyncResult)
        {
            return EndInvoke<ListVirtualNodesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListVirtualRouters

        /// <summary>
        /// Returns a list of existing virtual routers in a service mesh.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVirtualRouters service method.</param>
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
        public virtual ListVirtualRoutersResponse ListVirtualRouters(ListVirtualRoutersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListVirtualRoutersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListVirtualRoutersResponseUnmarshaller.Instance;

            return Invoke<ListVirtualRoutersResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListVirtualRouters operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListVirtualRouters operation on AmazonAppMeshClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListVirtualRouters
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2019-01-25/ListVirtualRouters">REST API Reference for ListVirtualRouters Operation</seealso>
        public virtual IAsyncResult BeginListVirtualRouters(ListVirtualRoutersRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListVirtualRoutersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListVirtualRoutersResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListVirtualRouters operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListVirtualRouters.</param>
        /// 
        /// <returns>Returns a  ListVirtualRoutersResult from AppMesh.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2019-01-25/ListVirtualRouters">REST API Reference for ListVirtualRouters Operation</seealso>
        public virtual ListVirtualRoutersResponse EndListVirtualRouters(IAsyncResult asyncResult)
        {
            return EndInvoke<ListVirtualRoutersResponse>(asyncResult);
        }

        #endregion
        
        #region  ListVirtualServices

        /// <summary>
        /// Returns a list of existing virtual services in a service mesh.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVirtualServices service method.</param>
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
        public virtual ListVirtualServicesResponse ListVirtualServices(ListVirtualServicesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListVirtualServicesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListVirtualServicesResponseUnmarshaller.Instance;

            return Invoke<ListVirtualServicesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListVirtualServices operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListVirtualServices operation on AmazonAppMeshClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListVirtualServices
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2019-01-25/ListVirtualServices">REST API Reference for ListVirtualServices Operation</seealso>
        public virtual IAsyncResult BeginListVirtualServices(ListVirtualServicesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListVirtualServicesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListVirtualServicesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListVirtualServices operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListVirtualServices.</param>
        /// 
        /// <returns>Returns a  ListVirtualServicesResult from AppMesh.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2019-01-25/ListVirtualServices">REST API Reference for ListVirtualServices Operation</seealso>
        public virtual ListVirtualServicesResponse EndListVirtualServices(IAsyncResult asyncResult)
        {
            return EndInvoke<ListVirtualServicesResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// Associates the specified tags to a resource with the specified <c>resourceArn</c>.
        /// If existing tags on a resource aren't specified in the request parameters, they aren't
        /// changed. When a resource is deleted, the tags associated with that resource are also
        /// deleted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
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
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonAppMeshClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2019-01-25/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from AppMesh.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2019-01-25/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// Deletes specified tags from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
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
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonAppMeshClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2019-01-25/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from AppMesh.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2019-01-25/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateGatewayRoute

        /// <summary>
        /// Updates an existing gateway route that is associated to a specified virtual gateway
        /// in a service mesh.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGatewayRoute service method.</param>
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
        public virtual UpdateGatewayRouteResponse UpdateGatewayRoute(UpdateGatewayRouteRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateGatewayRouteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGatewayRouteResponseUnmarshaller.Instance;

            return Invoke<UpdateGatewayRouteResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateGatewayRoute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateGatewayRoute operation on AmazonAppMeshClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateGatewayRoute
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2019-01-25/UpdateGatewayRoute">REST API Reference for UpdateGatewayRoute Operation</seealso>
        public virtual IAsyncResult BeginUpdateGatewayRoute(UpdateGatewayRouteRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateGatewayRouteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGatewayRouteResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateGatewayRoute operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateGatewayRoute.</param>
        /// 
        /// <returns>Returns a  UpdateGatewayRouteResult from AppMesh.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2019-01-25/UpdateGatewayRoute">REST API Reference for UpdateGatewayRoute Operation</seealso>
        public virtual UpdateGatewayRouteResponse EndUpdateGatewayRoute(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateGatewayRouteResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateMesh

        /// <summary>
        /// Updates an existing service mesh.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMesh service method.</param>
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
        public virtual UpdateMeshResponse UpdateMesh(UpdateMeshRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateMeshRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateMeshResponseUnmarshaller.Instance;

            return Invoke<UpdateMeshResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateMesh operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateMesh operation on AmazonAppMeshClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateMesh
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2019-01-25/UpdateMesh">REST API Reference for UpdateMesh Operation</seealso>
        public virtual IAsyncResult BeginUpdateMesh(UpdateMeshRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateMeshRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateMeshResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateMesh operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateMesh.</param>
        /// 
        /// <returns>Returns a  UpdateMeshResult from AppMesh.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2019-01-25/UpdateMesh">REST API Reference for UpdateMesh Operation</seealso>
        public virtual UpdateMeshResponse EndUpdateMesh(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateMeshResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateRoute

        /// <summary>
        /// Updates an existing route for a specified service mesh and virtual router.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRoute service method.</param>
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
        public virtual UpdateRouteResponse UpdateRoute(UpdateRouteRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateRouteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRouteResponseUnmarshaller.Instance;

            return Invoke<UpdateRouteResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateRoute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateRoute operation on AmazonAppMeshClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateRoute
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2019-01-25/UpdateRoute">REST API Reference for UpdateRoute Operation</seealso>
        public virtual IAsyncResult BeginUpdateRoute(UpdateRouteRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateRouteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRouteResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateRoute operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateRoute.</param>
        /// 
        /// <returns>Returns a  UpdateRouteResult from AppMesh.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2019-01-25/UpdateRoute">REST API Reference for UpdateRoute Operation</seealso>
        public virtual UpdateRouteResponse EndUpdateRoute(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateRouteResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateVirtualGateway

        /// <summary>
        /// Updates an existing virtual gateway in a specified service mesh.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateVirtualGateway service method.</param>
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
        public virtual UpdateVirtualGatewayResponse UpdateVirtualGateway(UpdateVirtualGatewayRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateVirtualGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateVirtualGatewayResponseUnmarshaller.Instance;

            return Invoke<UpdateVirtualGatewayResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateVirtualGateway operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateVirtualGateway operation on AmazonAppMeshClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateVirtualGateway
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2019-01-25/UpdateVirtualGateway">REST API Reference for UpdateVirtualGateway Operation</seealso>
        public virtual IAsyncResult BeginUpdateVirtualGateway(UpdateVirtualGatewayRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateVirtualGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateVirtualGatewayResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateVirtualGateway operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateVirtualGateway.</param>
        /// 
        /// <returns>Returns a  UpdateVirtualGatewayResult from AppMesh.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2019-01-25/UpdateVirtualGateway">REST API Reference for UpdateVirtualGateway Operation</seealso>
        public virtual UpdateVirtualGatewayResponse EndUpdateVirtualGateway(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateVirtualGatewayResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateVirtualNode

        /// <summary>
        /// Updates an existing virtual node in a specified service mesh.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateVirtualNode service method.</param>
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
        public virtual UpdateVirtualNodeResponse UpdateVirtualNode(UpdateVirtualNodeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateVirtualNodeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateVirtualNodeResponseUnmarshaller.Instance;

            return Invoke<UpdateVirtualNodeResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateVirtualNode operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateVirtualNode operation on AmazonAppMeshClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateVirtualNode
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2019-01-25/UpdateVirtualNode">REST API Reference for UpdateVirtualNode Operation</seealso>
        public virtual IAsyncResult BeginUpdateVirtualNode(UpdateVirtualNodeRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateVirtualNodeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateVirtualNodeResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateVirtualNode operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateVirtualNode.</param>
        /// 
        /// <returns>Returns a  UpdateVirtualNodeResult from AppMesh.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2019-01-25/UpdateVirtualNode">REST API Reference for UpdateVirtualNode Operation</seealso>
        public virtual UpdateVirtualNodeResponse EndUpdateVirtualNode(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateVirtualNodeResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateVirtualRouter

        /// <summary>
        /// Updates an existing virtual router in a specified service mesh.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateVirtualRouter service method.</param>
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
        public virtual UpdateVirtualRouterResponse UpdateVirtualRouter(UpdateVirtualRouterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateVirtualRouterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateVirtualRouterResponseUnmarshaller.Instance;

            return Invoke<UpdateVirtualRouterResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateVirtualRouter operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateVirtualRouter operation on AmazonAppMeshClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateVirtualRouter
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2019-01-25/UpdateVirtualRouter">REST API Reference for UpdateVirtualRouter Operation</seealso>
        public virtual IAsyncResult BeginUpdateVirtualRouter(UpdateVirtualRouterRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateVirtualRouterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateVirtualRouterResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateVirtualRouter operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateVirtualRouter.</param>
        /// 
        /// <returns>Returns a  UpdateVirtualRouterResult from AppMesh.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2019-01-25/UpdateVirtualRouter">REST API Reference for UpdateVirtualRouter Operation</seealso>
        public virtual UpdateVirtualRouterResponse EndUpdateVirtualRouter(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateVirtualRouterResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateVirtualService

        /// <summary>
        /// Updates an existing virtual service in a specified service mesh.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateVirtualService service method.</param>
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
        public virtual UpdateVirtualServiceResponse UpdateVirtualService(UpdateVirtualServiceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateVirtualServiceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateVirtualServiceResponseUnmarshaller.Instance;

            return Invoke<UpdateVirtualServiceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateVirtualService operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateVirtualService operation on AmazonAppMeshClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateVirtualService
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2019-01-25/UpdateVirtualService">REST API Reference for UpdateVirtualService Operation</seealso>
        public virtual IAsyncResult BeginUpdateVirtualService(UpdateVirtualServiceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateVirtualServiceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateVirtualServiceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateVirtualService operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateVirtualService.</param>
        /// 
        /// <returns>Returns a  UpdateVirtualServiceResult from AppMesh.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2019-01-25/UpdateVirtualService">REST API Reference for UpdateVirtualService Operation</seealso>
        public virtual UpdateVirtualServiceResponse EndUpdateVirtualService(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateVirtualServiceResponse>(asyncResult);
        }

        #endregion
        
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        public Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request)
        {
            var requestContext = new Amazon.Runtime.Internal.RequestContext(false, CreateSigner())
            {
                ClientConfig = Config,
                OriginalRequest = request,
                Request = new Amazon.Runtime.Internal.DefaultRequest(request, ServiceMetadata.ServiceId)
            };

            var executionContext = new Amazon.Runtime.Internal.ExecutionContext(requestContext, null);
            var resolver = new AmazonAppMeshEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}