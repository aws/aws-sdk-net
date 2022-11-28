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
 * Do not modify this file. This file is generated from the ecs-2014-11-13.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.ECS.Model;
using Amazon.ECS.Model.Internal.MarshallTransformations;
using Amazon.ECS.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.ECS
{
    /// <summary>
    /// Implementation for accessing ECS
    ///
    /// Amazon Elastic Container Service 
    /// <para>
    /// Amazon Elastic Container Service (Amazon ECS) is a highly scalable, fast, container
    /// management service. It makes it easy to run, stop, and manage Docker containers. You
    /// can host your cluster on a serverless infrastructure that's managed by Amazon ECS
    /// by launching your services or tasks on Fargate. For more control, you can host your
    /// tasks on a cluster of Amazon Elastic Compute Cloud (Amazon EC2) or External (on-premises)
    /// instances that you manage.
    /// </para>
    ///  
    /// <para>
    /// Amazon ECS makes it easy to launch and stop container-based applications with simple
    /// API calls. This makes it easy to get the state of your cluster from a centralized
    /// service, and gives you access to many familiar Amazon EC2 features.
    /// </para>
    ///  
    /// <para>
    /// You can use Amazon ECS to schedule the placement of containers across your cluster
    /// based on your resource needs, isolation policies, and availability requirements. With
    /// Amazon ECS, you don't need to operate your own cluster management and configuration
    /// management systems. You also don't need to worry about scaling your management infrastructure.
    /// </para>
    /// </summary>
    public partial class AmazonECSClient : AmazonServiceClient, IAmazonECS
    {
        private static IServiceMetadata serviceMetadata = new AmazonECSMetadata();
        private IECSPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IECSPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new ECSPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
        #region Constructors

        /// <summary>
        /// Constructs AmazonECSClient with the credentials loaded from the application's
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
        public AmazonECSClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonECSConfig()) { }

        /// <summary>
        /// Constructs AmazonECSClient with the credentials loaded from the application's
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
        public AmazonECSClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonECSConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonECSClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonECSClient Configuration Object</param>
        public AmazonECSClient(AmazonECSConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonECSClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonECSClient(AWSCredentials credentials)
            : this(credentials, new AmazonECSConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonECSClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonECSClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonECSConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonECSClient with AWS Credentials and an
        /// AmazonECSClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonECSClient Configuration Object</param>
        public AmazonECSClient(AWSCredentials credentials, AmazonECSConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonECSClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonECSClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonECSConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonECSClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonECSClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonECSConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonECSClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonECSClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonECSClient Configuration Object</param>
        public AmazonECSClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonECSConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonECSClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonECSClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonECSConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonECSClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonECSClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonECSConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonECSClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonECSClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonECSClient Configuration Object</param>
        public AmazonECSClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonECSConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonECSEndpointResolver());
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


        #region  CreateCapacityProvider


        /// <summary>
        /// Creates a new capacity provider. Capacity providers are associated with an Amazon
        /// ECS cluster and are used in capacity provider strategies to facilitate cluster auto
        /// scaling.
        /// 
        ///  
        /// <para>
        /// Only capacity providers that use an Auto Scaling group can be created. Amazon ECS
        /// tasks on Fargate use the <code>FARGATE</code> and <code>FARGATE_SPOT</code> capacity
        /// providers. These providers are available to all accounts in the Amazon Web Services
        /// Regions that Fargate supports.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCapacityProvider service method.</param>
        /// 
        /// <returns>The response from the CreateCapacityProvider service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action. This client action might be using
        /// an action or resource on behalf of a user that doesn't have permissions to use the
        /// action or resource,. Or, it might be specifying an identifier that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter isn't valid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.LimitExceededException">
        /// The limit for the resource was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.UpdateInProgressException">
        /// There's already a current Amazon ECS container agent update in progress on the container
        /// instance that's specified. If the container agent becomes disconnected while it's
        /// in a transitional stage, such as <code>PENDING</code> or <code>STAGING</code>, the
        /// update process can get stuck in that state. However, when the agent reconnects, it
        /// resumes where it stopped previously.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/CreateCapacityProvider">REST API Reference for CreateCapacityProvider Operation</seealso>
        public virtual CreateCapacityProviderResponse CreateCapacityProvider(CreateCapacityProviderRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateCapacityProviderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCapacityProviderResponseUnmarshaller.Instance;

            return Invoke<CreateCapacityProviderResponse>(request, options);
        }


        /// <summary>
        /// Creates a new capacity provider. Capacity providers are associated with an Amazon
        /// ECS cluster and are used in capacity provider strategies to facilitate cluster auto
        /// scaling.
        /// 
        ///  
        /// <para>
        /// Only capacity providers that use an Auto Scaling group can be created. Amazon ECS
        /// tasks on Fargate use the <code>FARGATE</code> and <code>FARGATE_SPOT</code> capacity
        /// providers. These providers are available to all accounts in the Amazon Web Services
        /// Regions that Fargate supports.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCapacityProvider service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateCapacityProvider service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action. This client action might be using
        /// an action or resource on behalf of a user that doesn't have permissions to use the
        /// action or resource,. Or, it might be specifying an identifier that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter isn't valid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.LimitExceededException">
        /// The limit for the resource was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.UpdateInProgressException">
        /// There's already a current Amazon ECS container agent update in progress on the container
        /// instance that's specified. If the container agent becomes disconnected while it's
        /// in a transitional stage, such as <code>PENDING</code> or <code>STAGING</code>, the
        /// update process can get stuck in that state. However, when the agent reconnects, it
        /// resumes where it stopped previously.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/CreateCapacityProvider">REST API Reference for CreateCapacityProvider Operation</seealso>
        public virtual Task<CreateCapacityProviderResponse> CreateCapacityProviderAsync(CreateCapacityProviderRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateCapacityProviderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCapacityProviderResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateCapacityProviderResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateCluster


        /// <summary>
        /// Creates a new Amazon ECS cluster. By default, your account receives a <code>default</code>
        /// cluster when you launch your first container instance. However, you can create your
        /// own cluster with a unique name with the <code>CreateCluster</code> action.
        /// 
        ///  <note> 
        /// <para>
        /// When you call the <a>CreateCluster</a> API operation, Amazon ECS attempts to create
        /// the Amazon ECS service-linked role for your account. This is so that it can manage
        /// required resources in other Amazon Web Services services on your behalf. However,
        /// if the IAM user that makes the call doesn't have permissions to create the service-linked
        /// role, it isn't created. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/using-service-linked-roles.html">Using
        /// service-linked roles for Amazon ECS</a> in the <i>Amazon Elastic Container Service
        /// Developer Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCluster service method.</param>
        /// 
        /// <returns>The response from the CreateCluster service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action. This client action might be using
        /// an action or resource on behalf of a user that doesn't have permissions to use the
        /// action or resource,. Or, it might be specifying an identifier that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter isn't valid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/CreateCluster">REST API Reference for CreateCluster Operation</seealso>
        public virtual CreateClusterResponse CreateCluster(CreateClusterRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateClusterResponseUnmarshaller.Instance;

            return Invoke<CreateClusterResponse>(request, options);
        }


        /// <summary>
        /// Creates a new Amazon ECS cluster. By default, your account receives a <code>default</code>
        /// cluster when you launch your first container instance. However, you can create your
        /// own cluster with a unique name with the <code>CreateCluster</code> action.
        /// 
        ///  <note> 
        /// <para>
        /// When you call the <a>CreateCluster</a> API operation, Amazon ECS attempts to create
        /// the Amazon ECS service-linked role for your account. This is so that it can manage
        /// required resources in other Amazon Web Services services on your behalf. However,
        /// if the IAM user that makes the call doesn't have permissions to create the service-linked
        /// role, it isn't created. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/using-service-linked-roles.html">Using
        /// service-linked roles for Amazon ECS</a> in the <i>Amazon Elastic Container Service
        /// Developer Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateCluster service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action. This client action might be using
        /// an action or resource on behalf of a user that doesn't have permissions to use the
        /// action or resource,. Or, it might be specifying an identifier that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter isn't valid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/CreateCluster">REST API Reference for CreateCluster Operation</seealso>
        public virtual Task<CreateClusterResponse> CreateClusterAsync(CreateClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateClusterResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateClusterResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateService


        /// <summary>
        /// Runs and maintains your desired number of tasks from a specified task definition.
        /// If the number of tasks running in a service drops below the <code>desiredCount</code>,
        /// Amazon ECS runs another copy of the task in the specified cluster. To update an existing
        /// service, see the <a>UpdateService</a> action.
        /// 
        ///  
        /// <para>
        /// In addition to maintaining the desired count of tasks in your service, you can optionally
        /// run your service behind one or more load balancers. The load balancers distribute
        /// traffic across the tasks that are associated with the service. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/service-load-balancing.html">Service
        /// load balancing</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Tasks for services that don't use a load balancer are considered healthy if they're
        /// in the <code>RUNNING</code> state. Tasks for services that use a load balancer are
        /// considered healthy if they're in the <code>RUNNING</code> state and are reported as
        /// healthy by the load balancer.
        /// </para>
        ///  
        /// <para>
        /// There are two service scheduler strategies available:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>REPLICA</code> - The replica scheduling strategy places and maintains your
        /// desired number of tasks across your cluster. By default, the service scheduler spreads
        /// tasks across Availability Zones. You can use task placement strategies and constraints
        /// to customize task placement decisions. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/ecs_services.html">Service
        /// scheduler concepts</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DAEMON</code> - The daemon scheduling strategy deploys exactly one task on
        /// each active container instance that meets all of the task placement constraints that
        /// you specify in your cluster. The service scheduler also evaluates the task placement
        /// constraints for running tasks. It also stops tasks that don't meet the placement constraints.
        /// When using this strategy, you don't need to specify a desired number of tasks, a task
        /// placement strategy, or use Service Auto Scaling policies. For more information, see
        /// <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/ecs_services.html">Service
        /// scheduler concepts</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You can optionally specify a deployment configuration for your service. The deployment
        /// is initiated by changing properties. For example, the deployment might be initiated
        /// by the task definition or by your desired count of a service. This is done with an
        /// <a>UpdateService</a> operation. The default value for a replica service for <code>minimumHealthyPercent</code>
        /// is 100%. The default value for a daemon service for <code>minimumHealthyPercent</code>
        /// is 0%.
        /// </para>
        ///  
        /// <para>
        /// If a service uses the <code>ECS</code> deployment controller, the minimum healthy
        /// percent represents a lower limit on the number of tasks in a service that must remain
        /// in the <code>RUNNING</code> state during a deployment. Specifically, it represents
        /// it as a percentage of your desired number of tasks (rounded up to the nearest integer).
        /// This happens when any of your container instances are in the <code>DRAINING</code>
        /// state if the service contains tasks using the EC2 launch type. Using this parameter,
        /// you can deploy without using additional cluster capacity. For example, if you set
        /// your service to have desired number of four tasks and a minimum healthy percent of
        /// 50%, the scheduler might stop two existing tasks to free up cluster capacity before
        /// starting two new tasks. If they're in the <code>RUNNING</code> state, tasks for services
        /// that don't use a load balancer are considered healthy . If they're in the <code>RUNNING</code>
        /// state and reported as healthy by the load balancer, tasks for services that <i>do</i>
        /// use a load balancer are considered healthy . The default value for minimum healthy
        /// percent is 100%.
        /// </para>
        ///  
        /// <para>
        /// If a service uses the <code>ECS</code> deployment controller, the <b>maximum percent</b>
        /// parameter represents an upper limit on the number of tasks in a service that are allowed
        /// in the <code>RUNNING</code> or <code>PENDING</code> state during a deployment. Specifically,
        /// it represents it as a percentage of the desired number of tasks (rounded down to the
        /// nearest integer). This happens when any of your container instances are in the <code>DRAINING</code>
        /// state if the service contains tasks using the EC2 launch type. Using this parameter,
        /// you can define the deployment batch size. For example, if your service has a desired
        /// number of four tasks and a maximum percent value of 200%, the scheduler may start
        /// four new tasks before stopping the four older tasks (provided that the cluster resources
        /// required to do this are available). The default value for maximum percent is 200%.
        /// </para>
        ///  
        /// <para>
        /// If a service uses either the <code>CODE_DEPLOY</code> or <code>EXTERNAL</code> deployment
        /// controller types and tasks that use the EC2 launch type, the <b>minimum healthy percent</b>
        /// and <b>maximum percent</b> values are used only to define the lower and upper limit
        /// on the number of the tasks in the service that remain in the <code>RUNNING</code>
        /// state. This is while the container instances are in the <code>DRAINING</code> state.
        /// If the tasks in the service use the Fargate launch type, the minimum healthy percent
        /// and maximum percent values aren't used. This is the case even if they're currently
        /// visible when describing your service.
        /// </para>
        ///  
        /// <para>
        /// When creating a service that uses the <code>EXTERNAL</code> deployment controller,
        /// you can specify only parameters that aren't controlled at the task set level. The
        /// only required parameter is the service name. You control your services using the <a>CreateTaskSet</a>
        /// operation. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/deployment-types.html">Amazon
        /// ECS deployment types</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// When the service scheduler launches new tasks, it determines task placement. For information
        /// about task placement and task placement strategies, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/task-placement.html">Amazon
        /// ECS task placement</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateService service method.</param>
        /// 
        /// <returns>The response from the CreateService service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.AccessDeniedException">
        /// You don't have authorization to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action. This client action might be using
        /// an action or resource on behalf of a user that doesn't have permissions to use the
        /// action or resource,. Or, it might be specifying an identifier that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClusterNotFoundException">
        /// The specified cluster wasn't found. You can view your available clusters with <a>ListClusters</a>.
        /// Amazon ECS clusters are Region specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter isn't valid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.NamespaceNotFoundException">
        /// The specified namespace wasn't found.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.PlatformTaskDefinitionIncompatibilityException">
        /// The specified platform version doesn't satisfy the required capabilities of the task
        /// definition.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.PlatformUnknownException">
        /// The specified platform version doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.UnsupportedFeatureException">
        /// The specified task isn't supported in this Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/CreateService">REST API Reference for CreateService Operation</seealso>
        public virtual CreateServiceResponse CreateService(CreateServiceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateServiceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateServiceResponseUnmarshaller.Instance;

            return Invoke<CreateServiceResponse>(request, options);
        }


        /// <summary>
        /// Runs and maintains your desired number of tasks from a specified task definition.
        /// If the number of tasks running in a service drops below the <code>desiredCount</code>,
        /// Amazon ECS runs another copy of the task in the specified cluster. To update an existing
        /// service, see the <a>UpdateService</a> action.
        /// 
        ///  
        /// <para>
        /// In addition to maintaining the desired count of tasks in your service, you can optionally
        /// run your service behind one or more load balancers. The load balancers distribute
        /// traffic across the tasks that are associated with the service. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/service-load-balancing.html">Service
        /// load balancing</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Tasks for services that don't use a load balancer are considered healthy if they're
        /// in the <code>RUNNING</code> state. Tasks for services that use a load balancer are
        /// considered healthy if they're in the <code>RUNNING</code> state and are reported as
        /// healthy by the load balancer.
        /// </para>
        ///  
        /// <para>
        /// There are two service scheduler strategies available:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>REPLICA</code> - The replica scheduling strategy places and maintains your
        /// desired number of tasks across your cluster. By default, the service scheduler spreads
        /// tasks across Availability Zones. You can use task placement strategies and constraints
        /// to customize task placement decisions. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/ecs_services.html">Service
        /// scheduler concepts</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DAEMON</code> - The daemon scheduling strategy deploys exactly one task on
        /// each active container instance that meets all of the task placement constraints that
        /// you specify in your cluster. The service scheduler also evaluates the task placement
        /// constraints for running tasks. It also stops tasks that don't meet the placement constraints.
        /// When using this strategy, you don't need to specify a desired number of tasks, a task
        /// placement strategy, or use Service Auto Scaling policies. For more information, see
        /// <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/ecs_services.html">Service
        /// scheduler concepts</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You can optionally specify a deployment configuration for your service. The deployment
        /// is initiated by changing properties. For example, the deployment might be initiated
        /// by the task definition or by your desired count of a service. This is done with an
        /// <a>UpdateService</a> operation. The default value for a replica service for <code>minimumHealthyPercent</code>
        /// is 100%. The default value for a daemon service for <code>minimumHealthyPercent</code>
        /// is 0%.
        /// </para>
        ///  
        /// <para>
        /// If a service uses the <code>ECS</code> deployment controller, the minimum healthy
        /// percent represents a lower limit on the number of tasks in a service that must remain
        /// in the <code>RUNNING</code> state during a deployment. Specifically, it represents
        /// it as a percentage of your desired number of tasks (rounded up to the nearest integer).
        /// This happens when any of your container instances are in the <code>DRAINING</code>
        /// state if the service contains tasks using the EC2 launch type. Using this parameter,
        /// you can deploy without using additional cluster capacity. For example, if you set
        /// your service to have desired number of four tasks and a minimum healthy percent of
        /// 50%, the scheduler might stop two existing tasks to free up cluster capacity before
        /// starting two new tasks. If they're in the <code>RUNNING</code> state, tasks for services
        /// that don't use a load balancer are considered healthy . If they're in the <code>RUNNING</code>
        /// state and reported as healthy by the load balancer, tasks for services that <i>do</i>
        /// use a load balancer are considered healthy . The default value for minimum healthy
        /// percent is 100%.
        /// </para>
        ///  
        /// <para>
        /// If a service uses the <code>ECS</code> deployment controller, the <b>maximum percent</b>
        /// parameter represents an upper limit on the number of tasks in a service that are allowed
        /// in the <code>RUNNING</code> or <code>PENDING</code> state during a deployment. Specifically,
        /// it represents it as a percentage of the desired number of tasks (rounded down to the
        /// nearest integer). This happens when any of your container instances are in the <code>DRAINING</code>
        /// state if the service contains tasks using the EC2 launch type. Using this parameter,
        /// you can define the deployment batch size. For example, if your service has a desired
        /// number of four tasks and a maximum percent value of 200%, the scheduler may start
        /// four new tasks before stopping the four older tasks (provided that the cluster resources
        /// required to do this are available). The default value for maximum percent is 200%.
        /// </para>
        ///  
        /// <para>
        /// If a service uses either the <code>CODE_DEPLOY</code> or <code>EXTERNAL</code> deployment
        /// controller types and tasks that use the EC2 launch type, the <b>minimum healthy percent</b>
        /// and <b>maximum percent</b> values are used only to define the lower and upper limit
        /// on the number of the tasks in the service that remain in the <code>RUNNING</code>
        /// state. This is while the container instances are in the <code>DRAINING</code> state.
        /// If the tasks in the service use the Fargate launch type, the minimum healthy percent
        /// and maximum percent values aren't used. This is the case even if they're currently
        /// visible when describing your service.
        /// </para>
        ///  
        /// <para>
        /// When creating a service that uses the <code>EXTERNAL</code> deployment controller,
        /// you can specify only parameters that aren't controlled at the task set level. The
        /// only required parameter is the service name. You control your services using the <a>CreateTaskSet</a>
        /// operation. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/deployment-types.html">Amazon
        /// ECS deployment types</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// When the service scheduler launches new tasks, it determines task placement. For information
        /// about task placement and task placement strategies, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/task-placement.html">Amazon
        /// ECS task placement</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateService service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateService service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.AccessDeniedException">
        /// You don't have authorization to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action. This client action might be using
        /// an action or resource on behalf of a user that doesn't have permissions to use the
        /// action or resource,. Or, it might be specifying an identifier that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClusterNotFoundException">
        /// The specified cluster wasn't found. You can view your available clusters with <a>ListClusters</a>.
        /// Amazon ECS clusters are Region specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter isn't valid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.NamespaceNotFoundException">
        /// The specified namespace wasn't found.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.PlatformTaskDefinitionIncompatibilityException">
        /// The specified platform version doesn't satisfy the required capabilities of the task
        /// definition.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.PlatformUnknownException">
        /// The specified platform version doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.UnsupportedFeatureException">
        /// The specified task isn't supported in this Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/CreateService">REST API Reference for CreateService Operation</seealso>
        public virtual Task<CreateServiceResponse> CreateServiceAsync(CreateServiceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateServiceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateServiceResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateServiceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateTaskSet


        /// <summary>
        /// Create a task set in the specified cluster and service. This is used when a service
        /// uses the <code>EXTERNAL</code> deployment controller type. For more information, see
        /// <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/deployment-types.html">Amazon
        /// ECS deployment types</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTaskSet service method.</param>
        /// 
        /// <returns>The response from the CreateTaskSet service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.AccessDeniedException">
        /// You don't have authorization to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action. This client action might be using
        /// an action or resource on behalf of a user that doesn't have permissions to use the
        /// action or resource,. Or, it might be specifying an identifier that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClusterNotFoundException">
        /// The specified cluster wasn't found. You can view your available clusters with <a>ListClusters</a>.
        /// Amazon ECS clusters are Region specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter isn't valid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.NamespaceNotFoundException">
        /// The specified namespace wasn't found.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.PlatformTaskDefinitionIncompatibilityException">
        /// The specified platform version doesn't satisfy the required capabilities of the task
        /// definition.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.PlatformUnknownException">
        /// The specified platform version doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServiceNotActiveException">
        /// The specified service isn't active. You can't update a service that's inactive. If
        /// you have previously deleted a service, you can re-create it with <a>CreateService</a>.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServiceNotFoundException">
        /// The specified service wasn't found. You can view your available services with <a>ListServices</a>.
        /// Amazon ECS services are cluster specific and Region specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.UnsupportedFeatureException">
        /// The specified task isn't supported in this Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/CreateTaskSet">REST API Reference for CreateTaskSet Operation</seealso>
        public virtual CreateTaskSetResponse CreateTaskSet(CreateTaskSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTaskSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTaskSetResponseUnmarshaller.Instance;

            return Invoke<CreateTaskSetResponse>(request, options);
        }


        /// <summary>
        /// Create a task set in the specified cluster and service. This is used when a service
        /// uses the <code>EXTERNAL</code> deployment controller type. For more information, see
        /// <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/deployment-types.html">Amazon
        /// ECS deployment types</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTaskSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateTaskSet service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.AccessDeniedException">
        /// You don't have authorization to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action. This client action might be using
        /// an action or resource on behalf of a user that doesn't have permissions to use the
        /// action or resource,. Or, it might be specifying an identifier that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClusterNotFoundException">
        /// The specified cluster wasn't found. You can view your available clusters with <a>ListClusters</a>.
        /// Amazon ECS clusters are Region specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter isn't valid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.NamespaceNotFoundException">
        /// The specified namespace wasn't found.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.PlatformTaskDefinitionIncompatibilityException">
        /// The specified platform version doesn't satisfy the required capabilities of the task
        /// definition.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.PlatformUnknownException">
        /// The specified platform version doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServiceNotActiveException">
        /// The specified service isn't active. You can't update a service that's inactive. If
        /// you have previously deleted a service, you can re-create it with <a>CreateService</a>.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServiceNotFoundException">
        /// The specified service wasn't found. You can view your available services with <a>ListServices</a>.
        /// Amazon ECS services are cluster specific and Region specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.UnsupportedFeatureException">
        /// The specified task isn't supported in this Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/CreateTaskSet">REST API Reference for CreateTaskSet Operation</seealso>
        public virtual Task<CreateTaskSetResponse> CreateTaskSetAsync(CreateTaskSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTaskSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTaskSetResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateTaskSetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteAccountSetting


        /// <summary>
        /// Disables an account setting for a specified IAM user, IAM role, or the root user for
        /// an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccountSetting service method.</param>
        /// 
        /// <returns>The response from the DeleteAccountSetting service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action. This client action might be using
        /// an action or resource on behalf of a user that doesn't have permissions to use the
        /// action or resource,. Or, it might be specifying an identifier that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter isn't valid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/DeleteAccountSetting">REST API Reference for DeleteAccountSetting Operation</seealso>
        public virtual DeleteAccountSettingResponse DeleteAccountSetting(DeleteAccountSettingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAccountSettingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAccountSettingResponseUnmarshaller.Instance;

            return Invoke<DeleteAccountSettingResponse>(request, options);
        }


        /// <summary>
        /// Disables an account setting for a specified IAM user, IAM role, or the root user for
        /// an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccountSetting service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAccountSetting service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action. This client action might be using
        /// an action or resource on behalf of a user that doesn't have permissions to use the
        /// action or resource,. Or, it might be specifying an identifier that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter isn't valid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/DeleteAccountSetting">REST API Reference for DeleteAccountSetting Operation</seealso>
        public virtual Task<DeleteAccountSettingResponse> DeleteAccountSettingAsync(DeleteAccountSettingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAccountSettingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAccountSettingResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteAccountSettingResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteAttributes


        /// <summary>
        /// Deletes one or more custom attributes from an Amazon ECS resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAttributes service method.</param>
        /// 
        /// <returns>The response from the DeleteAttributes service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClusterNotFoundException">
        /// The specified cluster wasn't found. You can view your available clusters with <a>ListClusters</a>.
        /// Amazon ECS clusters are Region specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter isn't valid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.TargetNotFoundException">
        /// The specified target wasn't found. You can view your available container instances
        /// with <a>ListContainerInstances</a>. Amazon ECS container instances are cluster-specific
        /// and Region-specific.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/DeleteAttributes">REST API Reference for DeleteAttributes Operation</seealso>
        public virtual DeleteAttributesResponse DeleteAttributes(DeleteAttributesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAttributesResponseUnmarshaller.Instance;

            return Invoke<DeleteAttributesResponse>(request, options);
        }


        /// <summary>
        /// Deletes one or more custom attributes from an Amazon ECS resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAttributes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAttributes service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClusterNotFoundException">
        /// The specified cluster wasn't found. You can view your available clusters with <a>ListClusters</a>.
        /// Amazon ECS clusters are Region specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter isn't valid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.TargetNotFoundException">
        /// The specified target wasn't found. You can view your available container instances
        /// with <a>ListContainerInstances</a>. Amazon ECS container instances are cluster-specific
        /// and Region-specific.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/DeleteAttributes">REST API Reference for DeleteAttributes Operation</seealso>
        public virtual Task<DeleteAttributesResponse> DeleteAttributesAsync(DeleteAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAttributesResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteAttributesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteCapacityProvider


        /// <summary>
        /// Deletes the specified capacity provider.
        /// 
        ///  <note> 
        /// <para>
        /// The <code>FARGATE</code> and <code>FARGATE_SPOT</code> capacity providers are reserved
        /// and can't be deleted. You can disassociate them from a cluster using either the <a>PutClusterCapacityProviders</a>
        /// API or by deleting the cluster.
        /// </para>
        ///  </note> 
        /// <para>
        /// Prior to a capacity provider being deleted, the capacity provider must be removed
        /// from the capacity provider strategy from all services. The <a>UpdateService</a> API
        /// can be used to remove a capacity provider from a service's capacity provider strategy.
        /// When updating a service, the <code>forceNewDeployment</code> option can be used to
        /// ensure that any tasks using the Amazon EC2 instance capacity provided by the capacity
        /// provider are transitioned to use the capacity from the remaining capacity providers.
        /// Only capacity providers that aren't associated with a cluster can be deleted. To remove
        /// a capacity provider from a cluster, you can either use <a>PutClusterCapacityProviders</a>
        /// or delete the cluster.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCapacityProvider service method.</param>
        /// 
        /// <returns>The response from the DeleteCapacityProvider service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action. This client action might be using
        /// an action or resource on behalf of a user that doesn't have permissions to use the
        /// action or resource,. Or, it might be specifying an identifier that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter isn't valid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/DeleteCapacityProvider">REST API Reference for DeleteCapacityProvider Operation</seealso>
        public virtual DeleteCapacityProviderResponse DeleteCapacityProvider(DeleteCapacityProviderRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCapacityProviderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCapacityProviderResponseUnmarshaller.Instance;

            return Invoke<DeleteCapacityProviderResponse>(request, options);
        }


        /// <summary>
        /// Deletes the specified capacity provider.
        /// 
        ///  <note> 
        /// <para>
        /// The <code>FARGATE</code> and <code>FARGATE_SPOT</code> capacity providers are reserved
        /// and can't be deleted. You can disassociate them from a cluster using either the <a>PutClusterCapacityProviders</a>
        /// API or by deleting the cluster.
        /// </para>
        ///  </note> 
        /// <para>
        /// Prior to a capacity provider being deleted, the capacity provider must be removed
        /// from the capacity provider strategy from all services. The <a>UpdateService</a> API
        /// can be used to remove a capacity provider from a service's capacity provider strategy.
        /// When updating a service, the <code>forceNewDeployment</code> option can be used to
        /// ensure that any tasks using the Amazon EC2 instance capacity provided by the capacity
        /// provider are transitioned to use the capacity from the remaining capacity providers.
        /// Only capacity providers that aren't associated with a cluster can be deleted. To remove
        /// a capacity provider from a cluster, you can either use <a>PutClusterCapacityProviders</a>
        /// or delete the cluster.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCapacityProvider service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteCapacityProvider service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action. This client action might be using
        /// an action or resource on behalf of a user that doesn't have permissions to use the
        /// action or resource,. Or, it might be specifying an identifier that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter isn't valid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/DeleteCapacityProvider">REST API Reference for DeleteCapacityProvider Operation</seealso>
        public virtual Task<DeleteCapacityProviderResponse> DeleteCapacityProviderAsync(DeleteCapacityProviderRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCapacityProviderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCapacityProviderResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteCapacityProviderResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteCluster


        /// <summary>
        /// Deletes the specified cluster. The cluster transitions to the <code>INACTIVE</code>
        /// state. Clusters with an <code>INACTIVE</code> status might remain discoverable in
        /// your account for a period of time. However, this behavior is subject to change in
        /// the future. We don't recommend that you rely on <code>INACTIVE</code> clusters persisting.
        /// 
        ///  
        /// <para>
        /// You must deregister all container instances from this cluster before you may delete
        /// it. You can list the container instances in a cluster with <a>ListContainerInstances</a>
        /// and deregister them with <a>DeregisterContainerInstance</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCluster service method.</param>
        /// 
        /// <returns>The response from the DeleteCluster service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action. This client action might be using
        /// an action or resource on behalf of a user that doesn't have permissions to use the
        /// action or resource,. Or, it might be specifying an identifier that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClusterContainsContainerInstancesException">
        /// You can't delete a cluster that has registered container instances. First, deregister
        /// the container instances before you can delete the cluster. For more information, see
        /// <a>DeregisterContainerInstance</a>.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClusterContainsServicesException">
        /// You can't delete a cluster that contains services. First, update the service to reduce
        /// its desired task count to 0, and then delete the service. For more information, see
        /// <a>UpdateService</a> and <a>DeleteService</a>.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClusterContainsTasksException">
        /// You can't delete a cluster that has active tasks.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClusterNotFoundException">
        /// The specified cluster wasn't found. You can view your available clusters with <a>ListClusters</a>.
        /// Amazon ECS clusters are Region specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter isn't valid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.UpdateInProgressException">
        /// There's already a current Amazon ECS container agent update in progress on the container
        /// instance that's specified. If the container agent becomes disconnected while it's
        /// in a transitional stage, such as <code>PENDING</code> or <code>STAGING</code>, the
        /// update process can get stuck in that state. However, when the agent reconnects, it
        /// resumes where it stopped previously.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/DeleteCluster">REST API Reference for DeleteCluster Operation</seealso>
        public virtual DeleteClusterResponse DeleteCluster(DeleteClusterRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteClusterResponseUnmarshaller.Instance;

            return Invoke<DeleteClusterResponse>(request, options);
        }


        /// <summary>
        /// Deletes the specified cluster. The cluster transitions to the <code>INACTIVE</code>
        /// state. Clusters with an <code>INACTIVE</code> status might remain discoverable in
        /// your account for a period of time. However, this behavior is subject to change in
        /// the future. We don't recommend that you rely on <code>INACTIVE</code> clusters persisting.
        /// 
        ///  
        /// <para>
        /// You must deregister all container instances from this cluster before you may delete
        /// it. You can list the container instances in a cluster with <a>ListContainerInstances</a>
        /// and deregister them with <a>DeregisterContainerInstance</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteCluster service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action. This client action might be using
        /// an action or resource on behalf of a user that doesn't have permissions to use the
        /// action or resource,. Or, it might be specifying an identifier that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClusterContainsContainerInstancesException">
        /// You can't delete a cluster that has registered container instances. First, deregister
        /// the container instances before you can delete the cluster. For more information, see
        /// <a>DeregisterContainerInstance</a>.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClusterContainsServicesException">
        /// You can't delete a cluster that contains services. First, update the service to reduce
        /// its desired task count to 0, and then delete the service. For more information, see
        /// <a>UpdateService</a> and <a>DeleteService</a>.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClusterContainsTasksException">
        /// You can't delete a cluster that has active tasks.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClusterNotFoundException">
        /// The specified cluster wasn't found. You can view your available clusters with <a>ListClusters</a>.
        /// Amazon ECS clusters are Region specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter isn't valid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.UpdateInProgressException">
        /// There's already a current Amazon ECS container agent update in progress on the container
        /// instance that's specified. If the container agent becomes disconnected while it's
        /// in a transitional stage, such as <code>PENDING</code> or <code>STAGING</code>, the
        /// update process can get stuck in that state. However, when the agent reconnects, it
        /// resumes where it stopped previously.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/DeleteCluster">REST API Reference for DeleteCluster Operation</seealso>
        public virtual Task<DeleteClusterResponse> DeleteClusterAsync(DeleteClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteClusterResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteClusterResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteService


        /// <summary>
        /// Deletes a specified service within a cluster. You can delete a service if you have
        /// no running tasks in it and the desired task count is zero. If the service is actively
        /// maintaining tasks, you can't delete it, and you must update the service to a desired
        /// task count of zero. For more information, see <a>UpdateService</a>.
        /// 
        ///  <note> 
        /// <para>
        /// When you delete a service, if there are still running tasks that require cleanup,
        /// the service status moves from <code>ACTIVE</code> to <code>DRAINING</code>, and the
        /// service is no longer visible in the console or in the <a>ListServices</a> API operation.
        /// After all tasks have transitioned to either <code>STOPPING</code> or <code>STOPPED</code>
        /// status, the service status moves from <code>DRAINING</code> to <code>INACTIVE</code>.
        /// Services in the <code>DRAINING</code> or <code>INACTIVE</code> status can still be
        /// viewed with the <a>DescribeServices</a> API operation. However, in the future, <code>INACTIVE</code>
        /// services may be cleaned up and purged from Amazon ECS record keeping, and <a>DescribeServices</a>
        /// calls on those services return a <code>ServiceNotFoundException</code> error.
        /// </para>
        ///  </note> <important> 
        /// <para>
        /// If you attempt to create a new service with the same name as an existing service in
        /// either <code>ACTIVE</code> or <code>DRAINING</code> status, you receive an error.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteService service method.</param>
        /// 
        /// <returns>The response from the DeleteService service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action. This client action might be using
        /// an action or resource on behalf of a user that doesn't have permissions to use the
        /// action or resource,. Or, it might be specifying an identifier that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClusterNotFoundException">
        /// The specified cluster wasn't found. You can view your available clusters with <a>ListClusters</a>.
        /// Amazon ECS clusters are Region specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter isn't valid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServiceNotFoundException">
        /// The specified service wasn't found. You can view your available services with <a>ListServices</a>.
        /// Amazon ECS services are cluster specific and Region specific.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/DeleteService">REST API Reference for DeleteService Operation</seealso>
        public virtual DeleteServiceResponse DeleteService(DeleteServiceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteServiceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteServiceResponseUnmarshaller.Instance;

            return Invoke<DeleteServiceResponse>(request, options);
        }


        /// <summary>
        /// Deletes a specified service within a cluster. You can delete a service if you have
        /// no running tasks in it and the desired task count is zero. If the service is actively
        /// maintaining tasks, you can't delete it, and you must update the service to a desired
        /// task count of zero. For more information, see <a>UpdateService</a>.
        /// 
        ///  <note> 
        /// <para>
        /// When you delete a service, if there are still running tasks that require cleanup,
        /// the service status moves from <code>ACTIVE</code> to <code>DRAINING</code>, and the
        /// service is no longer visible in the console or in the <a>ListServices</a> API operation.
        /// After all tasks have transitioned to either <code>STOPPING</code> or <code>STOPPED</code>
        /// status, the service status moves from <code>DRAINING</code> to <code>INACTIVE</code>.
        /// Services in the <code>DRAINING</code> or <code>INACTIVE</code> status can still be
        /// viewed with the <a>DescribeServices</a> API operation. However, in the future, <code>INACTIVE</code>
        /// services may be cleaned up and purged from Amazon ECS record keeping, and <a>DescribeServices</a>
        /// calls on those services return a <code>ServiceNotFoundException</code> error.
        /// </para>
        ///  </note> <important> 
        /// <para>
        /// If you attempt to create a new service with the same name as an existing service in
        /// either <code>ACTIVE</code> or <code>DRAINING</code> status, you receive an error.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteService service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteService service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action. This client action might be using
        /// an action or resource on behalf of a user that doesn't have permissions to use the
        /// action or resource,. Or, it might be specifying an identifier that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClusterNotFoundException">
        /// The specified cluster wasn't found. You can view your available clusters with <a>ListClusters</a>.
        /// Amazon ECS clusters are Region specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter isn't valid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServiceNotFoundException">
        /// The specified service wasn't found. You can view your available services with <a>ListServices</a>.
        /// Amazon ECS services are cluster specific and Region specific.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/DeleteService">REST API Reference for DeleteService Operation</seealso>
        public virtual Task<DeleteServiceResponse> DeleteServiceAsync(DeleteServiceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteServiceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteServiceResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteServiceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteTaskSet


        /// <summary>
        /// Deletes a specified task set within a service. This is used when a service uses the
        /// <code>EXTERNAL</code> deployment controller type. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/deployment-types.html">Amazon
        /// ECS deployment types</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTaskSet service method.</param>
        /// 
        /// <returns>The response from the DeleteTaskSet service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.AccessDeniedException">
        /// You don't have authorization to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action. This client action might be using
        /// an action or resource on behalf of a user that doesn't have permissions to use the
        /// action or resource,. Or, it might be specifying an identifier that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClusterNotFoundException">
        /// The specified cluster wasn't found. You can view your available clusters with <a>ListClusters</a>.
        /// Amazon ECS clusters are Region specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter isn't valid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServiceNotActiveException">
        /// The specified service isn't active. You can't update a service that's inactive. If
        /// you have previously deleted a service, you can re-create it with <a>CreateService</a>.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServiceNotFoundException">
        /// The specified service wasn't found. You can view your available services with <a>ListServices</a>.
        /// Amazon ECS services are cluster specific and Region specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.TaskSetNotFoundException">
        /// The specified task set wasn't found. You can view your available task sets with <a>DescribeTaskSets</a>.
        /// Task sets are specific to each cluster, service and Region.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.UnsupportedFeatureException">
        /// The specified task isn't supported in this Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/DeleteTaskSet">REST API Reference for DeleteTaskSet Operation</seealso>
        public virtual DeleteTaskSetResponse DeleteTaskSet(DeleteTaskSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTaskSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTaskSetResponseUnmarshaller.Instance;

            return Invoke<DeleteTaskSetResponse>(request, options);
        }


        /// <summary>
        /// Deletes a specified task set within a service. This is used when a service uses the
        /// <code>EXTERNAL</code> deployment controller type. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/deployment-types.html">Amazon
        /// ECS deployment types</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTaskSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTaskSet service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.AccessDeniedException">
        /// You don't have authorization to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action. This client action might be using
        /// an action or resource on behalf of a user that doesn't have permissions to use the
        /// action or resource,. Or, it might be specifying an identifier that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClusterNotFoundException">
        /// The specified cluster wasn't found. You can view your available clusters with <a>ListClusters</a>.
        /// Amazon ECS clusters are Region specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter isn't valid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServiceNotActiveException">
        /// The specified service isn't active. You can't update a service that's inactive. If
        /// you have previously deleted a service, you can re-create it with <a>CreateService</a>.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServiceNotFoundException">
        /// The specified service wasn't found. You can view your available services with <a>ListServices</a>.
        /// Amazon ECS services are cluster specific and Region specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.TaskSetNotFoundException">
        /// The specified task set wasn't found. You can view your available task sets with <a>DescribeTaskSets</a>.
        /// Task sets are specific to each cluster, service and Region.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.UnsupportedFeatureException">
        /// The specified task isn't supported in this Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/DeleteTaskSet">REST API Reference for DeleteTaskSet Operation</seealso>
        public virtual Task<DeleteTaskSetResponse> DeleteTaskSetAsync(DeleteTaskSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTaskSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTaskSetResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteTaskSetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeregisterContainerInstance


        /// <summary>
        /// Deregisters an Amazon ECS container instance from the specified cluster. This instance
        /// is no longer available to run tasks.
        /// 
        ///  
        /// <para>
        /// If you intend to use the container instance for some other purpose after deregistration,
        /// we recommend that you stop all of the tasks running on the container instance before
        /// deregistration. That prevents any orphaned tasks from consuming resources.
        /// </para>
        ///  
        /// <para>
        /// Deregistering a container instance removes the instance from a cluster, but it doesn't
        /// terminate the EC2 instance. If you are finished using the instance, be sure to terminate
        /// it in the Amazon EC2 console to stop billing.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you terminate a running container instance, Amazon ECS automatically deregisters
        /// the instance from your cluster (stopped container instances or instances with disconnected
        /// agents aren't automatically deregistered when terminated).
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterContainerInstance service method.</param>
        /// 
        /// <returns>The response from the DeregisterContainerInstance service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action. This client action might be using
        /// an action or resource on behalf of a user that doesn't have permissions to use the
        /// action or resource,. Or, it might be specifying an identifier that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClusterNotFoundException">
        /// The specified cluster wasn't found. You can view your available clusters with <a>ListClusters</a>.
        /// Amazon ECS clusters are Region specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter isn't valid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/DeregisterContainerInstance">REST API Reference for DeregisterContainerInstance Operation</seealso>
        public virtual DeregisterContainerInstanceResponse DeregisterContainerInstance(DeregisterContainerInstanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeregisterContainerInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterContainerInstanceResponseUnmarshaller.Instance;

            return Invoke<DeregisterContainerInstanceResponse>(request, options);
        }


        /// <summary>
        /// Deregisters an Amazon ECS container instance from the specified cluster. This instance
        /// is no longer available to run tasks.
        /// 
        ///  
        /// <para>
        /// If you intend to use the container instance for some other purpose after deregistration,
        /// we recommend that you stop all of the tasks running on the container instance before
        /// deregistration. That prevents any orphaned tasks from consuming resources.
        /// </para>
        ///  
        /// <para>
        /// Deregistering a container instance removes the instance from a cluster, but it doesn't
        /// terminate the EC2 instance. If you are finished using the instance, be sure to terminate
        /// it in the Amazon EC2 console to stop billing.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you terminate a running container instance, Amazon ECS automatically deregisters
        /// the instance from your cluster (stopped container instances or instances with disconnected
        /// agents aren't automatically deregistered when terminated).
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterContainerInstance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeregisterContainerInstance service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action. This client action might be using
        /// an action or resource on behalf of a user that doesn't have permissions to use the
        /// action or resource,. Or, it might be specifying an identifier that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClusterNotFoundException">
        /// The specified cluster wasn't found. You can view your available clusters with <a>ListClusters</a>.
        /// Amazon ECS clusters are Region specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter isn't valid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/DeregisterContainerInstance">REST API Reference for DeregisterContainerInstance Operation</seealso>
        public virtual Task<DeregisterContainerInstanceResponse> DeregisterContainerInstanceAsync(DeregisterContainerInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeregisterContainerInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterContainerInstanceResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeregisterContainerInstanceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeregisterTaskDefinition


        /// <summary>
        /// Deregisters the specified task definition by family and revision. Upon deregistration,
        /// the task definition is marked as <code>INACTIVE</code>. Existing tasks and services
        /// that reference an <code>INACTIVE</code> task definition continue to run without disruption.
        /// Existing services that reference an <code>INACTIVE</code> task definition can still
        /// scale up or down by modifying the service's desired count.
        /// 
        ///  
        /// <para>
        /// You can't use an <code>INACTIVE</code> task definition to run new tasks or create
        /// new services, and you can't update an existing service to reference an <code>INACTIVE</code>
        /// task definition. However, there may be up to a 10-minute window following deregistration
        /// where these restrictions have not yet taken effect.
        /// </para>
        ///  <note> 
        /// <para>
        /// At this time, <code>INACTIVE</code> task definitions remain discoverable in your account
        /// indefinitely. However, this behavior is subject to change in the future. We don't
        /// recommend that you rely on <code>INACTIVE</code> task definitions persisting beyond
        /// the lifecycle of any associated tasks and services.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterTaskDefinition service method.</param>
        /// 
        /// <returns>The response from the DeregisterTaskDefinition service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action. This client action might be using
        /// an action or resource on behalf of a user that doesn't have permissions to use the
        /// action or resource,. Or, it might be specifying an identifier that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter isn't valid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/DeregisterTaskDefinition">REST API Reference for DeregisterTaskDefinition Operation</seealso>
        public virtual DeregisterTaskDefinitionResponse DeregisterTaskDefinition(DeregisterTaskDefinitionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeregisterTaskDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterTaskDefinitionResponseUnmarshaller.Instance;

            return Invoke<DeregisterTaskDefinitionResponse>(request, options);
        }


        /// <summary>
        /// Deregisters the specified task definition by family and revision. Upon deregistration,
        /// the task definition is marked as <code>INACTIVE</code>. Existing tasks and services
        /// that reference an <code>INACTIVE</code> task definition continue to run without disruption.
        /// Existing services that reference an <code>INACTIVE</code> task definition can still
        /// scale up or down by modifying the service's desired count.
        /// 
        ///  
        /// <para>
        /// You can't use an <code>INACTIVE</code> task definition to run new tasks or create
        /// new services, and you can't update an existing service to reference an <code>INACTIVE</code>
        /// task definition. However, there may be up to a 10-minute window following deregistration
        /// where these restrictions have not yet taken effect.
        /// </para>
        ///  <note> 
        /// <para>
        /// At this time, <code>INACTIVE</code> task definitions remain discoverable in your account
        /// indefinitely. However, this behavior is subject to change in the future. We don't
        /// recommend that you rely on <code>INACTIVE</code> task definitions persisting beyond
        /// the lifecycle of any associated tasks and services.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterTaskDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeregisterTaskDefinition service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action. This client action might be using
        /// an action or resource on behalf of a user that doesn't have permissions to use the
        /// action or resource,. Or, it might be specifying an identifier that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter isn't valid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/DeregisterTaskDefinition">REST API Reference for DeregisterTaskDefinition Operation</seealso>
        public virtual Task<DeregisterTaskDefinitionResponse> DeregisterTaskDefinitionAsync(DeregisterTaskDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeregisterTaskDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterTaskDefinitionResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeregisterTaskDefinitionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeCapacityProviders


        /// <summary>
        /// Describes one or more of your capacity providers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCapacityProviders service method.</param>
        /// 
        /// <returns>The response from the DescribeCapacityProviders service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action. This client action might be using
        /// an action or resource on behalf of a user that doesn't have permissions to use the
        /// action or resource,. Or, it might be specifying an identifier that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter isn't valid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/DescribeCapacityProviders">REST API Reference for DescribeCapacityProviders Operation</seealso>
        public virtual DescribeCapacityProvidersResponse DescribeCapacityProviders(DescribeCapacityProvidersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeCapacityProvidersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCapacityProvidersResponseUnmarshaller.Instance;

            return Invoke<DescribeCapacityProvidersResponse>(request, options);
        }


        /// <summary>
        /// Describes one or more of your capacity providers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCapacityProviders service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeCapacityProviders service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action. This client action might be using
        /// an action or resource on behalf of a user that doesn't have permissions to use the
        /// action or resource,. Or, it might be specifying an identifier that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter isn't valid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/DescribeCapacityProviders">REST API Reference for DescribeCapacityProviders Operation</seealso>
        public virtual Task<DescribeCapacityProvidersResponse> DescribeCapacityProvidersAsync(DescribeCapacityProvidersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeCapacityProvidersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCapacityProvidersResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeCapacityProvidersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeClusters


        /// <summary>
        /// Describes one or more of your clusters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusters service method.</param>
        /// 
        /// <returns>The response from the DescribeClusters service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action. This client action might be using
        /// an action or resource on behalf of a user that doesn't have permissions to use the
        /// action or resource,. Or, it might be specifying an identifier that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter isn't valid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/DescribeClusters">REST API Reference for DescribeClusters Operation</seealso>
        public virtual DescribeClustersResponse DescribeClusters(DescribeClustersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeClustersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeClustersResponseUnmarshaller.Instance;

            return Invoke<DescribeClustersResponse>(request, options);
        }


        /// <summary>
        /// Describes one or more of your clusters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusters service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeClusters service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action. This client action might be using
        /// an action or resource on behalf of a user that doesn't have permissions to use the
        /// action or resource,. Or, it might be specifying an identifier that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter isn't valid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/DescribeClusters">REST API Reference for DescribeClusters Operation</seealso>
        public virtual Task<DescribeClustersResponse> DescribeClustersAsync(DescribeClustersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeClustersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeClustersResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeClustersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeContainerInstances


        /// <summary>
        /// Describes one or more container instances. Returns metadata about each container instance
        /// requested.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeContainerInstances service method.</param>
        /// 
        /// <returns>The response from the DescribeContainerInstances service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action. This client action might be using
        /// an action or resource on behalf of a user that doesn't have permissions to use the
        /// action or resource,. Or, it might be specifying an identifier that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClusterNotFoundException">
        /// The specified cluster wasn't found. You can view your available clusters with <a>ListClusters</a>.
        /// Amazon ECS clusters are Region specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter isn't valid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/DescribeContainerInstances">REST API Reference for DescribeContainerInstances Operation</seealso>
        public virtual DescribeContainerInstancesResponse DescribeContainerInstances(DescribeContainerInstancesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeContainerInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeContainerInstancesResponseUnmarshaller.Instance;

            return Invoke<DescribeContainerInstancesResponse>(request, options);
        }


        /// <summary>
        /// Describes one or more container instances. Returns metadata about each container instance
        /// requested.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeContainerInstances service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeContainerInstances service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action. This client action might be using
        /// an action or resource on behalf of a user that doesn't have permissions to use the
        /// action or resource,. Or, it might be specifying an identifier that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClusterNotFoundException">
        /// The specified cluster wasn't found. You can view your available clusters with <a>ListClusters</a>.
        /// Amazon ECS clusters are Region specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter isn't valid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/DescribeContainerInstances">REST API Reference for DescribeContainerInstances Operation</seealso>
        public virtual Task<DescribeContainerInstancesResponse> DescribeContainerInstancesAsync(DescribeContainerInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeContainerInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeContainerInstancesResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeContainerInstancesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeServices


        /// <summary>
        /// Describes the specified services running in your cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeServices service method.</param>
        /// 
        /// <returns>The response from the DescribeServices service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action. This client action might be using
        /// an action or resource on behalf of a user that doesn't have permissions to use the
        /// action or resource,. Or, it might be specifying an identifier that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClusterNotFoundException">
        /// The specified cluster wasn't found. You can view your available clusters with <a>ListClusters</a>.
        /// Amazon ECS clusters are Region specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter isn't valid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/DescribeServices">REST API Reference for DescribeServices Operation</seealso>
        public virtual DescribeServicesResponse DescribeServices(DescribeServicesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeServicesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeServicesResponseUnmarshaller.Instance;

            return Invoke<DescribeServicesResponse>(request, options);
        }


        /// <summary>
        /// Describes the specified services running in your cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeServices service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeServices service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action. This client action might be using
        /// an action or resource on behalf of a user that doesn't have permissions to use the
        /// action or resource,. Or, it might be specifying an identifier that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClusterNotFoundException">
        /// The specified cluster wasn't found. You can view your available clusters with <a>ListClusters</a>.
        /// Amazon ECS clusters are Region specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter isn't valid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/DescribeServices">REST API Reference for DescribeServices Operation</seealso>
        public virtual Task<DescribeServicesResponse> DescribeServicesAsync(DescribeServicesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeServicesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeServicesResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeServicesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeTaskDefinition


        /// <summary>
        /// Describes a task definition. You can specify a <code>family</code> and <code>revision</code>
        /// to find information about a specific task definition, or you can simply specify the
        /// family to find the latest <code>ACTIVE</code> revision in that family.
        /// 
        ///  <note> 
        /// <para>
        /// You can only describe <code>INACTIVE</code> task definitions while an active task
        /// or service references them.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTaskDefinition service method.</param>
        /// 
        /// <returns>The response from the DescribeTaskDefinition service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action. This client action might be using
        /// an action or resource on behalf of a user that doesn't have permissions to use the
        /// action or resource,. Or, it might be specifying an identifier that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter isn't valid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/DescribeTaskDefinition">REST API Reference for DescribeTaskDefinition Operation</seealso>
        public virtual DescribeTaskDefinitionResponse DescribeTaskDefinition(DescribeTaskDefinitionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTaskDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTaskDefinitionResponseUnmarshaller.Instance;

            return Invoke<DescribeTaskDefinitionResponse>(request, options);
        }


        /// <summary>
        /// Describes a task definition. You can specify a <code>family</code> and <code>revision</code>
        /// to find information about a specific task definition, or you can simply specify the
        /// family to find the latest <code>ACTIVE</code> revision in that family.
        /// 
        ///  <note> 
        /// <para>
        /// You can only describe <code>INACTIVE</code> task definitions while an active task
        /// or service references them.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTaskDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeTaskDefinition service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action. This client action might be using
        /// an action or resource on behalf of a user that doesn't have permissions to use the
        /// action or resource,. Or, it might be specifying an identifier that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter isn't valid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/DescribeTaskDefinition">REST API Reference for DescribeTaskDefinition Operation</seealso>
        public virtual Task<DescribeTaskDefinitionResponse> DescribeTaskDefinitionAsync(DescribeTaskDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTaskDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTaskDefinitionResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeTaskDefinitionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeTasks


        /// <summary>
        /// Describes a specified task or tasks.
        /// 
        ///  
        /// <para>
        /// Currently, stopped tasks appear in the returned results for at least one hour.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTasks service method.</param>
        /// 
        /// <returns>The response from the DescribeTasks service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action. This client action might be using
        /// an action or resource on behalf of a user that doesn't have permissions to use the
        /// action or resource,. Or, it might be specifying an identifier that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClusterNotFoundException">
        /// The specified cluster wasn't found. You can view your available clusters with <a>ListClusters</a>.
        /// Amazon ECS clusters are Region specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter isn't valid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/DescribeTasks">REST API Reference for DescribeTasks Operation</seealso>
        public virtual DescribeTasksResponse DescribeTasks(DescribeTasksRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTasksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTasksResponseUnmarshaller.Instance;

            return Invoke<DescribeTasksResponse>(request, options);
        }


        /// <summary>
        /// Describes a specified task or tasks.
        /// 
        ///  
        /// <para>
        /// Currently, stopped tasks appear in the returned results for at least one hour.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTasks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeTasks service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action. This client action might be using
        /// an action or resource on behalf of a user that doesn't have permissions to use the
        /// action or resource,. Or, it might be specifying an identifier that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClusterNotFoundException">
        /// The specified cluster wasn't found. You can view your available clusters with <a>ListClusters</a>.
        /// Amazon ECS clusters are Region specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter isn't valid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/DescribeTasks">REST API Reference for DescribeTasks Operation</seealso>
        public virtual Task<DescribeTasksResponse> DescribeTasksAsync(DescribeTasksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTasksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTasksResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeTasksResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeTaskSets


        /// <summary>
        /// Describes the task sets in the specified cluster and service. This is used when a
        /// service uses the <code>EXTERNAL</code> deployment controller type. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/deployment-types.html">Amazon
        /// ECS Deployment Types</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTaskSets service method.</param>
        /// 
        /// <returns>The response from the DescribeTaskSets service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.AccessDeniedException">
        /// You don't have authorization to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action. This client action might be using
        /// an action or resource on behalf of a user that doesn't have permissions to use the
        /// action or resource,. Or, it might be specifying an identifier that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClusterNotFoundException">
        /// The specified cluster wasn't found. You can view your available clusters with <a>ListClusters</a>.
        /// Amazon ECS clusters are Region specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter isn't valid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServiceNotActiveException">
        /// The specified service isn't active. You can't update a service that's inactive. If
        /// you have previously deleted a service, you can re-create it with <a>CreateService</a>.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServiceNotFoundException">
        /// The specified service wasn't found. You can view your available services with <a>ListServices</a>.
        /// Amazon ECS services are cluster specific and Region specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.UnsupportedFeatureException">
        /// The specified task isn't supported in this Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/DescribeTaskSets">REST API Reference for DescribeTaskSets Operation</seealso>
        public virtual DescribeTaskSetsResponse DescribeTaskSets(DescribeTaskSetsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTaskSetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTaskSetsResponseUnmarshaller.Instance;

            return Invoke<DescribeTaskSetsResponse>(request, options);
        }


        /// <summary>
        /// Describes the task sets in the specified cluster and service. This is used when a
        /// service uses the <code>EXTERNAL</code> deployment controller type. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/deployment-types.html">Amazon
        /// ECS Deployment Types</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTaskSets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeTaskSets service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.AccessDeniedException">
        /// You don't have authorization to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action. This client action might be using
        /// an action or resource on behalf of a user that doesn't have permissions to use the
        /// action or resource,. Or, it might be specifying an identifier that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClusterNotFoundException">
        /// The specified cluster wasn't found. You can view your available clusters with <a>ListClusters</a>.
        /// Amazon ECS clusters are Region specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter isn't valid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServiceNotActiveException">
        /// The specified service isn't active. You can't update a service that's inactive. If
        /// you have previously deleted a service, you can re-create it with <a>CreateService</a>.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServiceNotFoundException">
        /// The specified service wasn't found. You can view your available services with <a>ListServices</a>.
        /// Amazon ECS services are cluster specific and Region specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.UnsupportedFeatureException">
        /// The specified task isn't supported in this Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/DescribeTaskSets">REST API Reference for DescribeTaskSets Operation</seealso>
        public virtual Task<DescribeTaskSetsResponse> DescribeTaskSetsAsync(DescribeTaskSetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTaskSetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTaskSetsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeTaskSetsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ExecuteCommand


        /// <summary>
        /// Runs a command remotely on a container within a task.
        /// 
        ///  
        /// <para>
        /// If you use a condition key in your IAM policy to refine the conditions for the policy
        /// statement, for example limit the actions to a specific cluster, you receive an <code>AccessDeniedException</code>
        /// when there is a mismatch between the condition key value and the corresponding parameter
        /// value.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExecuteCommand service method.</param>
        /// 
        /// <returns>The response from the ExecuteCommand service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.AccessDeniedException">
        /// You don't have authorization to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action. This client action might be using
        /// an action or resource on behalf of a user that doesn't have permissions to use the
        /// action or resource,. Or, it might be specifying an identifier that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClusterNotFoundException">
        /// The specified cluster wasn't found. You can view your available clusters with <a>ListClusters</a>.
        /// Amazon ECS clusters are Region specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter isn't valid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.TargetNotConnectedException">
        /// The execute command cannot run. This error can be caused by any of the following configuration
        /// issues:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Incorrect IAM permissions
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The SSM agent is not installed or is not running
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  There is an interface Amazon VPC endpoint for Amazon ECS, but there is not one for
        /// for Systems Manager Session Manager
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For information about how to troubleshoot the issues, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/ecs-exec.html">Troubleshooting
        /// issues with ECS Exec</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/ExecuteCommand">REST API Reference for ExecuteCommand Operation</seealso>
        public virtual ExecuteCommandResponse ExecuteCommand(ExecuteCommandRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExecuteCommandRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExecuteCommandResponseUnmarshaller.Instance;

            return Invoke<ExecuteCommandResponse>(request, options);
        }


        /// <summary>
        /// Runs a command remotely on a container within a task.
        /// 
        ///  
        /// <para>
        /// If you use a condition key in your IAM policy to refine the conditions for the policy
        /// statement, for example limit the actions to a specific cluster, you receive an <code>AccessDeniedException</code>
        /// when there is a mismatch between the condition key value and the corresponding parameter
        /// value.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExecuteCommand service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ExecuteCommand service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.AccessDeniedException">
        /// You don't have authorization to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action. This client action might be using
        /// an action or resource on behalf of a user that doesn't have permissions to use the
        /// action or resource,. Or, it might be specifying an identifier that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClusterNotFoundException">
        /// The specified cluster wasn't found. You can view your available clusters with <a>ListClusters</a>.
        /// Amazon ECS clusters are Region specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter isn't valid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.TargetNotConnectedException">
        /// The execute command cannot run. This error can be caused by any of the following configuration
        /// issues:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Incorrect IAM permissions
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The SSM agent is not installed or is not running
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  There is an interface Amazon VPC endpoint for Amazon ECS, but there is not one for
        /// for Systems Manager Session Manager
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For information about how to troubleshoot the issues, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/ecs-exec.html">Troubleshooting
        /// issues with ECS Exec</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/ExecuteCommand">REST API Reference for ExecuteCommand Operation</seealso>
        public virtual Task<ExecuteCommandResponse> ExecuteCommandAsync(ExecuteCommandRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExecuteCommandRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExecuteCommandResponseUnmarshaller.Instance;
            
            return InvokeAsync<ExecuteCommandResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetTaskProtection


        /// <summary>
        /// Retrieves the protection status of tasks in an Amazon ECS service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTaskProtection service method.</param>
        /// 
        /// <returns>The response from the GetTaskProtection service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.AccessDeniedException">
        /// You don't have authorization to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action. This client action might be using
        /// an action or resource on behalf of a user that doesn't have permissions to use the
        /// action or resource,. Or, it might be specifying an identifier that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClusterNotFoundException">
        /// The specified cluster wasn't found. You can view your available clusters with <a>ListClusters</a>.
        /// Amazon ECS clusters are Region specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter isn't valid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ResourceNotFoundException">
        /// The specified resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.UnsupportedFeatureException">
        /// The specified task isn't supported in this Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/GetTaskProtection">REST API Reference for GetTaskProtection Operation</seealso>
        public virtual GetTaskProtectionResponse GetTaskProtection(GetTaskProtectionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTaskProtectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTaskProtectionResponseUnmarshaller.Instance;

            return Invoke<GetTaskProtectionResponse>(request, options);
        }


        /// <summary>
        /// Retrieves the protection status of tasks in an Amazon ECS service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTaskProtection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTaskProtection service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.AccessDeniedException">
        /// You don't have authorization to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action. This client action might be using
        /// an action or resource on behalf of a user that doesn't have permissions to use the
        /// action or resource,. Or, it might be specifying an identifier that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClusterNotFoundException">
        /// The specified cluster wasn't found. You can view your available clusters with <a>ListClusters</a>.
        /// Amazon ECS clusters are Region specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter isn't valid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ResourceNotFoundException">
        /// The specified resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.UnsupportedFeatureException">
        /// The specified task isn't supported in this Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/GetTaskProtection">REST API Reference for GetTaskProtection Operation</seealso>
        public virtual Task<GetTaskProtectionResponse> GetTaskProtectionAsync(GetTaskProtectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTaskProtectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTaskProtectionResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetTaskProtectionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListAccountSettings


        /// <summary>
        /// Lists the account settings for a specified principal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAccountSettings service method.</param>
        /// 
        /// <returns>The response from the ListAccountSettings service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action. This client action might be using
        /// an action or resource on behalf of a user that doesn't have permissions to use the
        /// action or resource,. Or, it might be specifying an identifier that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter isn't valid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/ListAccountSettings">REST API Reference for ListAccountSettings Operation</seealso>
        public virtual ListAccountSettingsResponse ListAccountSettings(ListAccountSettingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAccountSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAccountSettingsResponseUnmarshaller.Instance;

            return Invoke<ListAccountSettingsResponse>(request, options);
        }


        /// <summary>
        /// Lists the account settings for a specified principal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAccountSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAccountSettings service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action. This client action might be using
        /// an action or resource on behalf of a user that doesn't have permissions to use the
        /// action or resource,. Or, it might be specifying an identifier that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter isn't valid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/ListAccountSettings">REST API Reference for ListAccountSettings Operation</seealso>
        public virtual Task<ListAccountSettingsResponse> ListAccountSettingsAsync(ListAccountSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAccountSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAccountSettingsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListAccountSettingsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListAttributes


        /// <summary>
        /// Lists the attributes for Amazon ECS resources within a specified target type and cluster.
        /// When you specify a target type and cluster, <code>ListAttributes</code> returns a
        /// list of attribute objects, one for each attribute on each resource. You can filter
        /// the list of results to a single attribute name to only return results that have that
        /// name. You can also filter the results by attribute name and value. You can do this,
        /// for example, to see which container instances in a cluster are running a Linux AMI
        /// (<code>ecs.os-type=linux</code>).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAttributes service method.</param>
        /// 
        /// <returns>The response from the ListAttributes service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClusterNotFoundException">
        /// The specified cluster wasn't found. You can view your available clusters with <a>ListClusters</a>.
        /// Amazon ECS clusters are Region specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter isn't valid. Review the available parameters for the API request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/ListAttributes">REST API Reference for ListAttributes Operation</seealso>
        public virtual ListAttributesResponse ListAttributes(ListAttributesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAttributesResponseUnmarshaller.Instance;

            return Invoke<ListAttributesResponse>(request, options);
        }


        /// <summary>
        /// Lists the attributes for Amazon ECS resources within a specified target type and cluster.
        /// When you specify a target type and cluster, <code>ListAttributes</code> returns a
        /// list of attribute objects, one for each attribute on each resource. You can filter
        /// the list of results to a single attribute name to only return results that have that
        /// name. You can also filter the results by attribute name and value. You can do this,
        /// for example, to see which container instances in a cluster are running a Linux AMI
        /// (<code>ecs.os-type=linux</code>).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAttributes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAttributes service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClusterNotFoundException">
        /// The specified cluster wasn't found. You can view your available clusters with <a>ListClusters</a>.
        /// Amazon ECS clusters are Region specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter isn't valid. Review the available parameters for the API request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/ListAttributes">REST API Reference for ListAttributes Operation</seealso>
        public virtual Task<ListAttributesResponse> ListAttributesAsync(ListAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAttributesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListAttributesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListClusters


        /// <summary>
        /// Returns a list of existing clusters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListClusters service method.</param>
        /// 
        /// <returns>The response from the ListClusters service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action. This client action might be using
        /// an action or resource on behalf of a user that doesn't have permissions to use the
        /// action or resource,. Or, it might be specifying an identifier that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter isn't valid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/ListClusters">REST API Reference for ListClusters Operation</seealso>
        public virtual ListClustersResponse ListClusters(ListClustersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListClustersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListClustersResponseUnmarshaller.Instance;

            return Invoke<ListClustersResponse>(request, options);
        }


        /// <summary>
        /// Returns a list of existing clusters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListClusters service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListClusters service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action. This client action might be using
        /// an action or resource on behalf of a user that doesn't have permissions to use the
        /// action or resource,. Or, it might be specifying an identifier that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter isn't valid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/ListClusters">REST API Reference for ListClusters Operation</seealso>
        public virtual Task<ListClustersResponse> ListClustersAsync(ListClustersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListClustersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListClustersResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListClustersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListContainerInstances


        /// <summary>
        /// Returns a list of container instances in a specified cluster. You can filter the results
        /// of a <code>ListContainerInstances</code> operation with cluster query language statements
        /// inside the <code>filter</code> parameter. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/cluster-query-language.html">Cluster
        /// Query Language</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListContainerInstances service method.</param>
        /// 
        /// <returns>The response from the ListContainerInstances service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action. This client action might be using
        /// an action or resource on behalf of a user that doesn't have permissions to use the
        /// action or resource,. Or, it might be specifying an identifier that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClusterNotFoundException">
        /// The specified cluster wasn't found. You can view your available clusters with <a>ListClusters</a>.
        /// Amazon ECS clusters are Region specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter isn't valid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/ListContainerInstances">REST API Reference for ListContainerInstances Operation</seealso>
        public virtual ListContainerInstancesResponse ListContainerInstances(ListContainerInstancesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListContainerInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListContainerInstancesResponseUnmarshaller.Instance;

            return Invoke<ListContainerInstancesResponse>(request, options);
        }


        /// <summary>
        /// Returns a list of container instances in a specified cluster. You can filter the results
        /// of a <code>ListContainerInstances</code> operation with cluster query language statements
        /// inside the <code>filter</code> parameter. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/cluster-query-language.html">Cluster
        /// Query Language</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListContainerInstances service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListContainerInstances service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action. This client action might be using
        /// an action or resource on behalf of a user that doesn't have permissions to use the
        /// action or resource,. Or, it might be specifying an identifier that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClusterNotFoundException">
        /// The specified cluster wasn't found. You can view your available clusters with <a>ListClusters</a>.
        /// Amazon ECS clusters are Region specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter isn't valid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/ListContainerInstances">REST API Reference for ListContainerInstances Operation</seealso>
        public virtual Task<ListContainerInstancesResponse> ListContainerInstancesAsync(ListContainerInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListContainerInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListContainerInstancesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListContainerInstancesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListServices


        /// <summary>
        /// Returns a list of services. You can filter the results by cluster, launch type, and
        /// scheduling strategy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServices service method.</param>
        /// 
        /// <returns>The response from the ListServices service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action. This client action might be using
        /// an action or resource on behalf of a user that doesn't have permissions to use the
        /// action or resource,. Or, it might be specifying an identifier that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClusterNotFoundException">
        /// The specified cluster wasn't found. You can view your available clusters with <a>ListClusters</a>.
        /// Amazon ECS clusters are Region specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter isn't valid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/ListServices">REST API Reference for ListServices Operation</seealso>
        public virtual ListServicesResponse ListServices(ListServicesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListServicesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListServicesResponseUnmarshaller.Instance;

            return Invoke<ListServicesResponse>(request, options);
        }


        /// <summary>
        /// Returns a list of services. You can filter the results by cluster, launch type, and
        /// scheduling strategy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServices service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListServices service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action. This client action might be using
        /// an action or resource on behalf of a user that doesn't have permissions to use the
        /// action or resource,. Or, it might be specifying an identifier that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClusterNotFoundException">
        /// The specified cluster wasn't found. You can view your available clusters with <a>ListClusters</a>.
        /// Amazon ECS clusters are Region specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter isn't valid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/ListServices">REST API Reference for ListServices Operation</seealso>
        public virtual Task<ListServicesResponse> ListServicesAsync(ListServicesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListServicesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListServicesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListServicesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListServicesByNamespace


        /// <summary>
        /// This operation lists all of the services that are associated with a Cloud Map namespace.
        /// This list might include services in different clusters. In contrast, <code>ListServices</code>
        /// can only list services in one cluster at a time. If you need to filter the list of
        /// services in a single cluster by various parameters, use <code>ListServices</code>.
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/service-connect.html">Service
        /// Connect</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServicesByNamespace service method.</param>
        /// 
        /// <returns>The response from the ListServicesByNamespace service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action. This client action might be using
        /// an action or resource on behalf of a user that doesn't have permissions to use the
        /// action or resource,. Or, it might be specifying an identifier that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter isn't valid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.NamespaceNotFoundException">
        /// The specified namespace wasn't found.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/ListServicesByNamespace">REST API Reference for ListServicesByNamespace Operation</seealso>
        public virtual ListServicesByNamespaceResponse ListServicesByNamespace(ListServicesByNamespaceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListServicesByNamespaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListServicesByNamespaceResponseUnmarshaller.Instance;

            return Invoke<ListServicesByNamespaceResponse>(request, options);
        }


        /// <summary>
        /// This operation lists all of the services that are associated with a Cloud Map namespace.
        /// This list might include services in different clusters. In contrast, <code>ListServices</code>
        /// can only list services in one cluster at a time. If you need to filter the list of
        /// services in a single cluster by various parameters, use <code>ListServices</code>.
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/service-connect.html">Service
        /// Connect</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServicesByNamespace service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListServicesByNamespace service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action. This client action might be using
        /// an action or resource on behalf of a user that doesn't have permissions to use the
        /// action or resource,. Or, it might be specifying an identifier that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter isn't valid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.NamespaceNotFoundException">
        /// The specified namespace wasn't found.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/ListServicesByNamespace">REST API Reference for ListServicesByNamespace Operation</seealso>
        public virtual Task<ListServicesByNamespaceResponse> ListServicesByNamespaceAsync(ListServicesByNamespaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListServicesByNamespaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListServicesByNamespaceResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListServicesByNamespaceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// List the tags for an Amazon ECS resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action. This client action might be using
        /// an action or resource on behalf of a user that doesn't have permissions to use the
        /// action or resource,. Or, it might be specifying an identifier that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClusterNotFoundException">
        /// The specified cluster wasn't found. You can view your available clusters with <a>ListClusters</a>.
        /// Amazon ECS clusters are Region specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter isn't valid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }


        /// <summary>
        /// List the tags for an Amazon ECS resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action. This client action might be using
        /// an action or resource on behalf of a user that doesn't have permissions to use the
        /// action or resource,. Or, it might be specifying an identifier that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClusterNotFoundException">
        /// The specified cluster wasn't found. You can view your available clusters with <a>ListClusters</a>.
        /// Amazon ECS clusters are Region specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter isn't valid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTaskDefinitionFamilies


        /// <summary>
        /// Returns a list of task definition families that are registered to your account. This
        /// list includes task definition families that no longer have any <code>ACTIVE</code>
        /// task definition revisions.
        /// 
        ///  
        /// <para>
        /// You can filter out task definition families that don't contain any <code>ACTIVE</code>
        /// task definition revisions by setting the <code>status</code> parameter to <code>ACTIVE</code>.
        /// You can also filter the results with the <code>familyPrefix</code> parameter.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTaskDefinitionFamilies service method.</param>
        /// 
        /// <returns>The response from the ListTaskDefinitionFamilies service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action. This client action might be using
        /// an action or resource on behalf of a user that doesn't have permissions to use the
        /// action or resource,. Or, it might be specifying an identifier that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter isn't valid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/ListTaskDefinitionFamilies">REST API Reference for ListTaskDefinitionFamilies Operation</seealso>
        public virtual ListTaskDefinitionFamiliesResponse ListTaskDefinitionFamilies(ListTaskDefinitionFamiliesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTaskDefinitionFamiliesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTaskDefinitionFamiliesResponseUnmarshaller.Instance;

            return Invoke<ListTaskDefinitionFamiliesResponse>(request, options);
        }


        /// <summary>
        /// Returns a list of task definition families that are registered to your account. This
        /// list includes task definition families that no longer have any <code>ACTIVE</code>
        /// task definition revisions.
        /// 
        ///  
        /// <para>
        /// You can filter out task definition families that don't contain any <code>ACTIVE</code>
        /// task definition revisions by setting the <code>status</code> parameter to <code>ACTIVE</code>.
        /// You can also filter the results with the <code>familyPrefix</code> parameter.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTaskDefinitionFamilies service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTaskDefinitionFamilies service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action. This client action might be using
        /// an action or resource on behalf of a user that doesn't have permissions to use the
        /// action or resource,. Or, it might be specifying an identifier that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter isn't valid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/ListTaskDefinitionFamilies">REST API Reference for ListTaskDefinitionFamilies Operation</seealso>
        public virtual Task<ListTaskDefinitionFamiliesResponse> ListTaskDefinitionFamiliesAsync(ListTaskDefinitionFamiliesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTaskDefinitionFamiliesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTaskDefinitionFamiliesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListTaskDefinitionFamiliesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTaskDefinitions


        /// <summary>
        /// Returns a list of task definitions that are registered to your account. You can filter
        /// the results by family name with the <code>familyPrefix</code> parameter or by status
        /// with the <code>status</code> parameter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTaskDefinitions service method.</param>
        /// 
        /// <returns>The response from the ListTaskDefinitions service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action. This client action might be using
        /// an action or resource on behalf of a user that doesn't have permissions to use the
        /// action or resource,. Or, it might be specifying an identifier that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter isn't valid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/ListTaskDefinitions">REST API Reference for ListTaskDefinitions Operation</seealso>
        public virtual ListTaskDefinitionsResponse ListTaskDefinitions(ListTaskDefinitionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTaskDefinitionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTaskDefinitionsResponseUnmarshaller.Instance;

            return Invoke<ListTaskDefinitionsResponse>(request, options);
        }


        /// <summary>
        /// Returns a list of task definitions that are registered to your account. You can filter
        /// the results by family name with the <code>familyPrefix</code> parameter or by status
        /// with the <code>status</code> parameter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTaskDefinitions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTaskDefinitions service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action. This client action might be using
        /// an action or resource on behalf of a user that doesn't have permissions to use the
        /// action or resource,. Or, it might be specifying an identifier that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter isn't valid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/ListTaskDefinitions">REST API Reference for ListTaskDefinitions Operation</seealso>
        public virtual Task<ListTaskDefinitionsResponse> ListTaskDefinitionsAsync(ListTaskDefinitionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTaskDefinitionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTaskDefinitionsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListTaskDefinitionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTasks


        /// <summary>
        /// Returns a list of tasks. You can filter the results by cluster, task definition family,
        /// container instance, launch type, what IAM principal started the task, or by the desired
        /// status of the task.
        /// 
        ///  
        /// <para>
        /// Recently stopped tasks might appear in the returned results. Currently, stopped tasks
        /// appear in the returned results for at least one hour.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTasks service method.</param>
        /// 
        /// <returns>The response from the ListTasks service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action. This client action might be using
        /// an action or resource on behalf of a user that doesn't have permissions to use the
        /// action or resource,. Or, it might be specifying an identifier that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClusterNotFoundException">
        /// The specified cluster wasn't found. You can view your available clusters with <a>ListClusters</a>.
        /// Amazon ECS clusters are Region specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter isn't valid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServiceNotFoundException">
        /// The specified service wasn't found. You can view your available services with <a>ListServices</a>.
        /// Amazon ECS services are cluster specific and Region specific.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/ListTasks">REST API Reference for ListTasks Operation</seealso>
        public virtual ListTasksResponse ListTasks(ListTasksRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTasksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTasksResponseUnmarshaller.Instance;

            return Invoke<ListTasksResponse>(request, options);
        }


        /// <summary>
        /// Returns a list of tasks. You can filter the results by cluster, task definition family,
        /// container instance, launch type, what IAM principal started the task, or by the desired
        /// status of the task.
        /// 
        ///  
        /// <para>
        /// Recently stopped tasks might appear in the returned results. Currently, stopped tasks
        /// appear in the returned results for at least one hour.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTasks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTasks service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action. This client action might be using
        /// an action or resource on behalf of a user that doesn't have permissions to use the
        /// action or resource,. Or, it might be specifying an identifier that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClusterNotFoundException">
        /// The specified cluster wasn't found. You can view your available clusters with <a>ListClusters</a>.
        /// Amazon ECS clusters are Region specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter isn't valid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServiceNotFoundException">
        /// The specified service wasn't found. You can view your available services with <a>ListServices</a>.
        /// Amazon ECS services are cluster specific and Region specific.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/ListTasks">REST API Reference for ListTasks Operation</seealso>
        public virtual Task<ListTasksResponse> ListTasksAsync(ListTasksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTasksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTasksResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListTasksResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutAccountSetting


        /// <summary>
        /// Modifies an account setting. Account settings are set on a per-Region basis.
        /// 
        ///  
        /// <para>
        /// If you change the account setting for the root user, the default settings for all
        /// of the IAM users and roles that no individual account setting was specified are reset
        /// for. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/ecs-account-settings.html">Account
        /// Settings</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// When <code>serviceLongArnFormat</code>, <code>taskLongArnFormat</code>, or <code>containerInstanceLongArnFormat</code>
        /// are specified, the Amazon Resource Name (ARN) and resource ID format of the resource
        /// type for a specified IAM user, IAM role, or the root user for an account is affected.
        /// The opt-in and opt-out account setting must be set for each Amazon ECS resource separately.
        /// The ARN and resource ID format of a resource is defined by the opt-in status of the
        /// IAM user or role that created the resource. You must turn on this setting to use Amazon
        /// ECS features such as resource tagging.
        /// </para>
        ///  
        /// <para>
        /// When <code>awsvpcTrunking</code> is specified, the elastic network interface (ENI)
        /// limit for any new container instances that support the feature is changed. If <code>awsvpcTrunking</code>
        /// is enabled, any new container instances that support the feature are launched have
        /// the increased ENI limits available to them. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/container-instance-eni.html">Elastic
        /// Network Interface Trunking</a> in the <i>Amazon Elastic Container Service Developer
        /// Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// When <code>containerInsights</code> is specified, the default setting indicating whether
        /// CloudWatch Container Insights is enabled for your clusters is changed. If <code>containerInsights</code>
        /// is enabled, any new clusters that are created will have Container Insights enabled
        /// unless you disable it during cluster creation. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/cloudwatch-container-insights.html">CloudWatch
        /// Container Insights</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAccountSetting service method.</param>
        /// 
        /// <returns>The response from the PutAccountSetting service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action. This client action might be using
        /// an action or resource on behalf of a user that doesn't have permissions to use the
        /// action or resource,. Or, it might be specifying an identifier that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter isn't valid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/PutAccountSetting">REST API Reference for PutAccountSetting Operation</seealso>
        public virtual PutAccountSettingResponse PutAccountSetting(PutAccountSettingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutAccountSettingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutAccountSettingResponseUnmarshaller.Instance;

            return Invoke<PutAccountSettingResponse>(request, options);
        }


        /// <summary>
        /// Modifies an account setting. Account settings are set on a per-Region basis.
        /// 
        ///  
        /// <para>
        /// If you change the account setting for the root user, the default settings for all
        /// of the IAM users and roles that no individual account setting was specified are reset
        /// for. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/ecs-account-settings.html">Account
        /// Settings</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// When <code>serviceLongArnFormat</code>, <code>taskLongArnFormat</code>, or <code>containerInstanceLongArnFormat</code>
        /// are specified, the Amazon Resource Name (ARN) and resource ID format of the resource
        /// type for a specified IAM user, IAM role, or the root user for an account is affected.
        /// The opt-in and opt-out account setting must be set for each Amazon ECS resource separately.
        /// The ARN and resource ID format of a resource is defined by the opt-in status of the
        /// IAM user or role that created the resource. You must turn on this setting to use Amazon
        /// ECS features such as resource tagging.
        /// </para>
        ///  
        /// <para>
        /// When <code>awsvpcTrunking</code> is specified, the elastic network interface (ENI)
        /// limit for any new container instances that support the feature is changed. If <code>awsvpcTrunking</code>
        /// is enabled, any new container instances that support the feature are launched have
        /// the increased ENI limits available to them. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/container-instance-eni.html">Elastic
        /// Network Interface Trunking</a> in the <i>Amazon Elastic Container Service Developer
        /// Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// When <code>containerInsights</code> is specified, the default setting indicating whether
        /// CloudWatch Container Insights is enabled for your clusters is changed. If <code>containerInsights</code>
        /// is enabled, any new clusters that are created will have Container Insights enabled
        /// unless you disable it during cluster creation. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/cloudwatch-container-insights.html">CloudWatch
        /// Container Insights</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAccountSetting service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutAccountSetting service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action. This client action might be using
        /// an action or resource on behalf of a user that doesn't have permissions to use the
        /// action or resource,. Or, it might be specifying an identifier that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter isn't valid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/PutAccountSetting">REST API Reference for PutAccountSetting Operation</seealso>
        public virtual Task<PutAccountSettingResponse> PutAccountSettingAsync(PutAccountSettingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutAccountSettingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutAccountSettingResponseUnmarshaller.Instance;
            
            return InvokeAsync<PutAccountSettingResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutAccountSettingDefault


        /// <summary>
        /// Modifies an account setting for all IAM users on an account for whom no individual
        /// account setting has been specified. Account settings are set on a per-Region basis.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAccountSettingDefault service method.</param>
        /// 
        /// <returns>The response from the PutAccountSettingDefault service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action. This client action might be using
        /// an action or resource on behalf of a user that doesn't have permissions to use the
        /// action or resource,. Or, it might be specifying an identifier that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter isn't valid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/PutAccountSettingDefault">REST API Reference for PutAccountSettingDefault Operation</seealso>
        public virtual PutAccountSettingDefaultResponse PutAccountSettingDefault(PutAccountSettingDefaultRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutAccountSettingDefaultRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutAccountSettingDefaultResponseUnmarshaller.Instance;

            return Invoke<PutAccountSettingDefaultResponse>(request, options);
        }


        /// <summary>
        /// Modifies an account setting for all IAM users on an account for whom no individual
        /// account setting has been specified. Account settings are set on a per-Region basis.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAccountSettingDefault service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutAccountSettingDefault service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action. This client action might be using
        /// an action or resource on behalf of a user that doesn't have permissions to use the
        /// action or resource,. Or, it might be specifying an identifier that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter isn't valid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/PutAccountSettingDefault">REST API Reference for PutAccountSettingDefault Operation</seealso>
        public virtual Task<PutAccountSettingDefaultResponse> PutAccountSettingDefaultAsync(PutAccountSettingDefaultRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutAccountSettingDefaultRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutAccountSettingDefaultResponseUnmarshaller.Instance;
            
            return InvokeAsync<PutAccountSettingDefaultResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutAttributes


        /// <summary>
        /// Create or update an attribute on an Amazon ECS resource. If the attribute doesn't
        /// exist, it's created. If the attribute exists, its value is replaced with the specified
        /// value. To delete an attribute, use <a>DeleteAttributes</a>. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/task-placement-constraints.html#attributes">Attributes</a>
        /// in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAttributes service method.</param>
        /// 
        /// <returns>The response from the PutAttributes service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.AttributeLimitExceededException">
        /// You can apply up to 10 custom attributes for each resource. You can view the attributes
        /// of a resource with <a>ListAttributes</a>. You can remove existing attributes on a
        /// resource with <a>DeleteAttributes</a>.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClusterNotFoundException">
        /// The specified cluster wasn't found. You can view your available clusters with <a>ListClusters</a>.
        /// Amazon ECS clusters are Region specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter isn't valid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.TargetNotFoundException">
        /// The specified target wasn't found. You can view your available container instances
        /// with <a>ListContainerInstances</a>. Amazon ECS container instances are cluster-specific
        /// and Region-specific.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/PutAttributes">REST API Reference for PutAttributes Operation</seealso>
        public virtual PutAttributesResponse PutAttributes(PutAttributesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutAttributesResponseUnmarshaller.Instance;

            return Invoke<PutAttributesResponse>(request, options);
        }


        /// <summary>
        /// Create or update an attribute on an Amazon ECS resource. If the attribute doesn't
        /// exist, it's created. If the attribute exists, its value is replaced with the specified
        /// value. To delete an attribute, use <a>DeleteAttributes</a>. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/task-placement-constraints.html#attributes">Attributes</a>
        /// in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAttributes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutAttributes service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.AttributeLimitExceededException">
        /// You can apply up to 10 custom attributes for each resource. You can view the attributes
        /// of a resource with <a>ListAttributes</a>. You can remove existing attributes on a
        /// resource with <a>DeleteAttributes</a>.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClusterNotFoundException">
        /// The specified cluster wasn't found. You can view your available clusters with <a>ListClusters</a>.
        /// Amazon ECS clusters are Region specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter isn't valid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.TargetNotFoundException">
        /// The specified target wasn't found. You can view your available container instances
        /// with <a>ListContainerInstances</a>. Amazon ECS container instances are cluster-specific
        /// and Region-specific.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/PutAttributes">REST API Reference for PutAttributes Operation</seealso>
        public virtual Task<PutAttributesResponse> PutAttributesAsync(PutAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutAttributesResponseUnmarshaller.Instance;
            
            return InvokeAsync<PutAttributesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutClusterCapacityProviders


        /// <summary>
        /// Modifies the available capacity providers and the default capacity provider strategy
        /// for a cluster.
        /// 
        ///  
        /// <para>
        /// You must specify both the available capacity providers and a default capacity provider
        /// strategy for the cluster. If the specified cluster has existing capacity providers
        /// associated with it, you must specify all existing capacity providers in addition to
        /// any new ones you want to add. Any existing capacity providers that are associated
        /// with a cluster that are omitted from a <a>PutClusterCapacityProviders</a> API call
        /// will be disassociated with the cluster. You can only disassociate an existing capacity
        /// provider from a cluster if it's not being used by any existing tasks.
        /// </para>
        ///  
        /// <para>
        /// When creating a service or running a task on a cluster, if no capacity provider or
        /// launch type is specified, then the cluster's default capacity provider strategy is
        /// used. We recommend that you define a default capacity provider strategy for your cluster.
        /// However, you must specify an empty array (<code>[]</code>) to bypass defining a default
        /// strategy.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutClusterCapacityProviders service method.</param>
        /// 
        /// <returns>The response from the PutClusterCapacityProviders service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action. This client action might be using
        /// an action or resource on behalf of a user that doesn't have permissions to use the
        /// action or resource,. Or, it might be specifying an identifier that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClusterNotFoundException">
        /// The specified cluster wasn't found. You can view your available clusters with <a>ListClusters</a>.
        /// Amazon ECS clusters are Region specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter isn't valid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ResourceInUseException">
        /// The specified resource is in-use and can't be removed.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.UpdateInProgressException">
        /// There's already a current Amazon ECS container agent update in progress on the container
        /// instance that's specified. If the container agent becomes disconnected while it's
        /// in a transitional stage, such as <code>PENDING</code> or <code>STAGING</code>, the
        /// update process can get stuck in that state. However, when the agent reconnects, it
        /// resumes where it stopped previously.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/PutClusterCapacityProviders">REST API Reference for PutClusterCapacityProviders Operation</seealso>
        public virtual PutClusterCapacityProvidersResponse PutClusterCapacityProviders(PutClusterCapacityProvidersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutClusterCapacityProvidersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutClusterCapacityProvidersResponseUnmarshaller.Instance;

            return Invoke<PutClusterCapacityProvidersResponse>(request, options);
        }


        /// <summary>
        /// Modifies the available capacity providers and the default capacity provider strategy
        /// for a cluster.
        /// 
        ///  
        /// <para>
        /// You must specify both the available capacity providers and a default capacity provider
        /// strategy for the cluster. If the specified cluster has existing capacity providers
        /// associated with it, you must specify all existing capacity providers in addition to
        /// any new ones you want to add. Any existing capacity providers that are associated
        /// with a cluster that are omitted from a <a>PutClusterCapacityProviders</a> API call
        /// will be disassociated with the cluster. You can only disassociate an existing capacity
        /// provider from a cluster if it's not being used by any existing tasks.
        /// </para>
        ///  
        /// <para>
        /// When creating a service or running a task on a cluster, if no capacity provider or
        /// launch type is specified, then the cluster's default capacity provider strategy is
        /// used. We recommend that you define a default capacity provider strategy for your cluster.
        /// However, you must specify an empty array (<code>[]</code>) to bypass defining a default
        /// strategy.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutClusterCapacityProviders service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutClusterCapacityProviders service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action. This client action might be using
        /// an action or resource on behalf of a user that doesn't have permissions to use the
        /// action or resource,. Or, it might be specifying an identifier that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClusterNotFoundException">
        /// The specified cluster wasn't found. You can view your available clusters with <a>ListClusters</a>.
        /// Amazon ECS clusters are Region specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter isn't valid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ResourceInUseException">
        /// The specified resource is in-use and can't be removed.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.UpdateInProgressException">
        /// There's already a current Amazon ECS container agent update in progress on the container
        /// instance that's specified. If the container agent becomes disconnected while it's
        /// in a transitional stage, such as <code>PENDING</code> or <code>STAGING</code>, the
        /// update process can get stuck in that state. However, when the agent reconnects, it
        /// resumes where it stopped previously.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/PutClusterCapacityProviders">REST API Reference for PutClusterCapacityProviders Operation</seealso>
        public virtual Task<PutClusterCapacityProvidersResponse> PutClusterCapacityProvidersAsync(PutClusterCapacityProvidersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutClusterCapacityProvidersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutClusterCapacityProvidersResponseUnmarshaller.Instance;
            
            return InvokeAsync<PutClusterCapacityProvidersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RegisterTaskDefinition


        /// <summary>
        /// Registers a new task definition from the supplied <code>family</code> and <code>containerDefinitions</code>.
        /// Optionally, you can add data volumes to your containers with the <code>volumes</code>
        /// parameter. For more information about task definition parameters and defaults, see
        /// <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/task_defintions.html">Amazon
        /// ECS Task Definitions</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// 
        ///  
        /// <para>
        /// You can specify an IAM role for your task with the <code>taskRoleArn</code> parameter.
        /// When you specify an IAM role for a task, its containers can then use the latest versions
        /// of the CLI or SDKs to make API requests to the Amazon Web Services services that are
        /// specified in the IAM policy that's associated with the role. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/task-iam-roles.html">IAM
        /// Roles for Tasks</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can specify a Docker networking mode for the containers in your task definition
        /// with the <code>networkMode</code> parameter. The available network modes correspond
        /// to those described in <a href="https://docs.docker.com/engine/reference/run/#/network-settings">Network
        /// settings</a> in the Docker run reference. If you specify the <code>awsvpc</code> network
        /// mode, the task is allocated an elastic network interface, and you must specify a <a>NetworkConfiguration</a>
        /// when you create a service or run a task with the task definition. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/task-networking.html">Task
        /// Networking</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterTaskDefinition service method.</param>
        /// 
        /// <returns>The response from the RegisterTaskDefinition service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action. This client action might be using
        /// an action or resource on behalf of a user that doesn't have permissions to use the
        /// action or resource,. Or, it might be specifying an identifier that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter isn't valid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/RegisterTaskDefinition">REST API Reference for RegisterTaskDefinition Operation</seealso>
        public virtual RegisterTaskDefinitionResponse RegisterTaskDefinition(RegisterTaskDefinitionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterTaskDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterTaskDefinitionResponseUnmarshaller.Instance;

            return Invoke<RegisterTaskDefinitionResponse>(request, options);
        }


        /// <summary>
        /// Registers a new task definition from the supplied <code>family</code> and <code>containerDefinitions</code>.
        /// Optionally, you can add data volumes to your containers with the <code>volumes</code>
        /// parameter. For more information about task definition parameters and defaults, see
        /// <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/task_defintions.html">Amazon
        /// ECS Task Definitions</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// 
        ///  
        /// <para>
        /// You can specify an IAM role for your task with the <code>taskRoleArn</code> parameter.
        /// When you specify an IAM role for a task, its containers can then use the latest versions
        /// of the CLI or SDKs to make API requests to the Amazon Web Services services that are
        /// specified in the IAM policy that's associated with the role. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/task-iam-roles.html">IAM
        /// Roles for Tasks</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can specify a Docker networking mode for the containers in your task definition
        /// with the <code>networkMode</code> parameter. The available network modes correspond
        /// to those described in <a href="https://docs.docker.com/engine/reference/run/#/network-settings">Network
        /// settings</a> in the Docker run reference. If you specify the <code>awsvpc</code> network
        /// mode, the task is allocated an elastic network interface, and you must specify a <a>NetworkConfiguration</a>
        /// when you create a service or run a task with the task definition. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/task-networking.html">Task
        /// Networking</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterTaskDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RegisterTaskDefinition service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action. This client action might be using
        /// an action or resource on behalf of a user that doesn't have permissions to use the
        /// action or resource,. Or, it might be specifying an identifier that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter isn't valid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/RegisterTaskDefinition">REST API Reference for RegisterTaskDefinition Operation</seealso>
        public virtual Task<RegisterTaskDefinitionResponse> RegisterTaskDefinitionAsync(RegisterTaskDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterTaskDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterTaskDefinitionResponseUnmarshaller.Instance;
            
            return InvokeAsync<RegisterTaskDefinitionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RunTask


        /// <summary>
        /// Starts a new task using the specified task definition.
        /// 
        ///  
        /// <para>
        /// You can allow Amazon ECS to place tasks for you, or you can customize how Amazon ECS
        /// places tasks using placement constraints and placement strategies. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/scheduling_tasks.html">Scheduling
        /// Tasks</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Alternatively, you can use <a>StartTask</a> to use your own scheduler or place tasks
        /// manually on specific container instances.
        /// </para>
        ///  
        /// <para>
        /// The Amazon ECS API follows an eventual consistency model. This is because of the distributed
        /// nature of the system supporting the API. This means that the result of an API command
        /// you run that affects your Amazon ECS resources might not be immediately visible to
        /// all subsequent commands you run. Keep this in mind when you carry out an API command
        /// that immediately follows a previous API command.
        /// </para>
        ///  
        /// <para>
        /// To manage eventual consistency, you can do the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Confirm the state of the resource before you run a command to modify it. Run the DescribeTasks
        /// command using an exponential backoff algorithm to ensure that you allow enough time
        /// for the previous command to propagate through the system. To do this, run the DescribeTasks
        /// command repeatedly, starting with a couple of seconds of wait time and increasing
        /// gradually up to five minutes of wait time.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Add wait time between subsequent commands, even if the DescribeTasks command returns
        /// an accurate response. Apply an exponential backoff algorithm starting with a couple
        /// of seconds of wait time, and increase gradually up to about five minutes of wait time.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RunTask service method.</param>
        /// 
        /// <returns>The response from the RunTask service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.AccessDeniedException">
        /// You don't have authorization to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.BlockedException">
        /// Your Amazon Web Services account was blocked. For more information, contact <a href="http://aws.amazon.com/contact-us/">
        /// Amazon Web Services Support</a>.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action. This client action might be using
        /// an action or resource on behalf of a user that doesn't have permissions to use the
        /// action or resource,. Or, it might be specifying an identifier that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClusterNotFoundException">
        /// The specified cluster wasn't found. You can view your available clusters with <a>ListClusters</a>.
        /// Amazon ECS clusters are Region specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter isn't valid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.PlatformTaskDefinitionIncompatibilityException">
        /// The specified platform version doesn't satisfy the required capabilities of the task
        /// definition.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.PlatformUnknownException">
        /// The specified platform version doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.UnsupportedFeatureException">
        /// The specified task isn't supported in this Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/RunTask">REST API Reference for RunTask Operation</seealso>
        public virtual RunTaskResponse RunTask(RunTaskRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RunTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RunTaskResponseUnmarshaller.Instance;

            return Invoke<RunTaskResponse>(request, options);
        }


        /// <summary>
        /// Starts a new task using the specified task definition.
        /// 
        ///  
        /// <para>
        /// You can allow Amazon ECS to place tasks for you, or you can customize how Amazon ECS
        /// places tasks using placement constraints and placement strategies. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/scheduling_tasks.html">Scheduling
        /// Tasks</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Alternatively, you can use <a>StartTask</a> to use your own scheduler or place tasks
        /// manually on specific container instances.
        /// </para>
        ///  
        /// <para>
        /// The Amazon ECS API follows an eventual consistency model. This is because of the distributed
        /// nature of the system supporting the API. This means that the result of an API command
        /// you run that affects your Amazon ECS resources might not be immediately visible to
        /// all subsequent commands you run. Keep this in mind when you carry out an API command
        /// that immediately follows a previous API command.
        /// </para>
        ///  
        /// <para>
        /// To manage eventual consistency, you can do the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Confirm the state of the resource before you run a command to modify it. Run the DescribeTasks
        /// command using an exponential backoff algorithm to ensure that you allow enough time
        /// for the previous command to propagate through the system. To do this, run the DescribeTasks
        /// command repeatedly, starting with a couple of seconds of wait time and increasing
        /// gradually up to five minutes of wait time.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Add wait time between subsequent commands, even if the DescribeTasks command returns
        /// an accurate response. Apply an exponential backoff algorithm starting with a couple
        /// of seconds of wait time, and increase gradually up to about five minutes of wait time.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RunTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RunTask service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.AccessDeniedException">
        /// You don't have authorization to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.BlockedException">
        /// Your Amazon Web Services account was blocked. For more information, contact <a href="http://aws.amazon.com/contact-us/">
        /// Amazon Web Services Support</a>.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action. This client action might be using
        /// an action or resource on behalf of a user that doesn't have permissions to use the
        /// action or resource,. Or, it might be specifying an identifier that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClusterNotFoundException">
        /// The specified cluster wasn't found. You can view your available clusters with <a>ListClusters</a>.
        /// Amazon ECS clusters are Region specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter isn't valid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.PlatformTaskDefinitionIncompatibilityException">
        /// The specified platform version doesn't satisfy the required capabilities of the task
        /// definition.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.PlatformUnknownException">
        /// The specified platform version doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.UnsupportedFeatureException">
        /// The specified task isn't supported in this Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/RunTask">REST API Reference for RunTask Operation</seealso>
        public virtual Task<RunTaskResponse> RunTaskAsync(RunTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RunTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RunTaskResponseUnmarshaller.Instance;
            
            return InvokeAsync<RunTaskResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartTask


        /// <summary>
        /// Starts a new task from the specified task definition on the specified container instance
        /// or instances.
        /// 
        ///  
        /// <para>
        /// Alternatively, you can use <a>RunTask</a> to place tasks for you. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/scheduling_tasks.html">Scheduling
        /// Tasks</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartTask service method.</param>
        /// 
        /// <returns>The response from the StartTask service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action. This client action might be using
        /// an action or resource on behalf of a user that doesn't have permissions to use the
        /// action or resource,. Or, it might be specifying an identifier that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClusterNotFoundException">
        /// The specified cluster wasn't found. You can view your available clusters with <a>ListClusters</a>.
        /// Amazon ECS clusters are Region specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter isn't valid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/StartTask">REST API Reference for StartTask Operation</seealso>
        public virtual StartTaskResponse StartTask(StartTaskRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartTaskResponseUnmarshaller.Instance;

            return Invoke<StartTaskResponse>(request, options);
        }


        /// <summary>
        /// Starts a new task from the specified task definition on the specified container instance
        /// or instances.
        /// 
        ///  
        /// <para>
        /// Alternatively, you can use <a>RunTask</a> to place tasks for you. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/scheduling_tasks.html">Scheduling
        /// Tasks</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartTask service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action. This client action might be using
        /// an action or resource on behalf of a user that doesn't have permissions to use the
        /// action or resource,. Or, it might be specifying an identifier that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClusterNotFoundException">
        /// The specified cluster wasn't found. You can view your available clusters with <a>ListClusters</a>.
        /// Amazon ECS clusters are Region specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter isn't valid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/StartTask">REST API Reference for StartTask Operation</seealso>
        public virtual Task<StartTaskResponse> StartTaskAsync(StartTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartTaskResponseUnmarshaller.Instance;
            
            return InvokeAsync<StartTaskResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StopTask


        /// <summary>
        /// Stops a running task. Any tags associated with the task will be deleted.
        /// 
        ///  
        /// <para>
        /// When <a>StopTask</a> is called on a task, the equivalent of <code>docker stop</code>
        /// is issued to the containers running in the task. This results in a <code>SIGTERM</code>
        /// value and a default 30-second timeout, after which the <code>SIGKILL</code> value
        /// is sent and the containers are forcibly stopped. If the container handles the <code>SIGTERM</code>
        /// value gracefully and exits within 30 seconds from receiving it, no <code>SIGKILL</code>
        /// value is sent.
        /// </para>
        ///  <note> 
        /// <para>
        /// The default 30-second timeout can be configured on the Amazon ECS container agent
        /// with the <code>ECS_CONTAINER_STOP_TIMEOUT</code> variable. For more information, see
        /// <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/ecs-agent-config.html">Amazon
        /// ECS Container Agent Configuration</a> in the <i>Amazon Elastic Container Service Developer
        /// Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopTask service method.</param>
        /// 
        /// <returns>The response from the StopTask service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action. This client action might be using
        /// an action or resource on behalf of a user that doesn't have permissions to use the
        /// action or resource,. Or, it might be specifying an identifier that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClusterNotFoundException">
        /// The specified cluster wasn't found. You can view your available clusters with <a>ListClusters</a>.
        /// Amazon ECS clusters are Region specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter isn't valid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/StopTask">REST API Reference for StopTask Operation</seealso>
        public virtual StopTaskResponse StopTask(StopTaskRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopTaskResponseUnmarshaller.Instance;

            return Invoke<StopTaskResponse>(request, options);
        }


        /// <summary>
        /// Stops a running task. Any tags associated with the task will be deleted.
        /// 
        ///  
        /// <para>
        /// When <a>StopTask</a> is called on a task, the equivalent of <code>docker stop</code>
        /// is issued to the containers running in the task. This results in a <code>SIGTERM</code>
        /// value and a default 30-second timeout, after which the <code>SIGKILL</code> value
        /// is sent and the containers are forcibly stopped. If the container handles the <code>SIGTERM</code>
        /// value gracefully and exits within 30 seconds from receiving it, no <code>SIGKILL</code>
        /// value is sent.
        /// </para>
        ///  <note> 
        /// <para>
        /// The default 30-second timeout can be configured on the Amazon ECS container agent
        /// with the <code>ECS_CONTAINER_STOP_TIMEOUT</code> variable. For more information, see
        /// <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/ecs-agent-config.html">Amazon
        /// ECS Container Agent Configuration</a> in the <i>Amazon Elastic Container Service Developer
        /// Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopTask service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action. This client action might be using
        /// an action or resource on behalf of a user that doesn't have permissions to use the
        /// action or resource,. Or, it might be specifying an identifier that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClusterNotFoundException">
        /// The specified cluster wasn't found. You can view your available clusters with <a>ListClusters</a>.
        /// Amazon ECS clusters are Region specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter isn't valid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/StopTask">REST API Reference for StopTask Operation</seealso>
        public virtual Task<StopTaskResponse> StopTaskAsync(StopTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopTaskResponseUnmarshaller.Instance;
            
            return InvokeAsync<StopTaskResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SubmitAttachmentStateChanges


        /// <summary>
        /// <note> 
        /// <para>
        /// This action is only used by the Amazon ECS agent, and it is not intended for use outside
        /// of the agent.
        /// </para>
        ///  </note> 
        /// <para>
        /// Sent to acknowledge that an attachment changed states.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SubmitAttachmentStateChanges service method.</param>
        /// 
        /// <returns>The response from the SubmitAttachmentStateChanges service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.AccessDeniedException">
        /// You don't have authorization to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action. This client action might be using
        /// an action or resource on behalf of a user that doesn't have permissions to use the
        /// action or resource,. Or, it might be specifying an identifier that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter isn't valid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/SubmitAttachmentStateChanges">REST API Reference for SubmitAttachmentStateChanges Operation</seealso>
        public virtual SubmitAttachmentStateChangesResponse SubmitAttachmentStateChanges(SubmitAttachmentStateChangesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SubmitAttachmentStateChangesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SubmitAttachmentStateChangesResponseUnmarshaller.Instance;

            return Invoke<SubmitAttachmentStateChangesResponse>(request, options);
        }


        /// <summary>
        /// <note> 
        /// <para>
        /// This action is only used by the Amazon ECS agent, and it is not intended for use outside
        /// of the agent.
        /// </para>
        ///  </note> 
        /// <para>
        /// Sent to acknowledge that an attachment changed states.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SubmitAttachmentStateChanges service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SubmitAttachmentStateChanges service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.AccessDeniedException">
        /// You don't have authorization to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action. This client action might be using
        /// an action or resource on behalf of a user that doesn't have permissions to use the
        /// action or resource,. Or, it might be specifying an identifier that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter isn't valid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/SubmitAttachmentStateChanges">REST API Reference for SubmitAttachmentStateChanges Operation</seealso>
        public virtual Task<SubmitAttachmentStateChangesResponse> SubmitAttachmentStateChangesAsync(SubmitAttachmentStateChangesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SubmitAttachmentStateChangesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SubmitAttachmentStateChangesResponseUnmarshaller.Instance;
            
            return InvokeAsync<SubmitAttachmentStateChangesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Associates the specified tags to a resource with the specified <code>resourceArn</code>.
        /// If existing tags on a resource aren't specified in the request parameters, they aren't
        /// changed. When a resource is deleted, the tags that are associated with that resource
        /// are deleted as well.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action. This client action might be using
        /// an action or resource on behalf of a user that doesn't have permissions to use the
        /// action or resource,. Or, it might be specifying an identifier that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClusterNotFoundException">
        /// The specified cluster wasn't found. You can view your available clusters with <a>ListClusters</a>.
        /// Amazon ECS clusters are Region specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter isn't valid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ResourceNotFoundException">
        /// The specified resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }


        /// <summary>
        /// Associates the specified tags to a resource with the specified <code>resourceArn</code>.
        /// If existing tags on a resource aren't specified in the request parameters, they aren't
        /// changed. When a resource is deleted, the tags that are associated with that resource
        /// are deleted as well.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action. This client action might be using
        /// an action or resource on behalf of a user that doesn't have permissions to use the
        /// action or resource,. Or, it might be specifying an identifier that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClusterNotFoundException">
        /// The specified cluster wasn't found. You can view your available clusters with <a>ListClusters</a>.
        /// Amazon ECS clusters are Region specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter isn't valid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ResourceNotFoundException">
        /// The specified resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Deletes specified tags from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action. This client action might be using
        /// an action or resource on behalf of a user that doesn't have permissions to use the
        /// action or resource,. Or, it might be specifying an identifier that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClusterNotFoundException">
        /// The specified cluster wasn't found. You can view your available clusters with <a>ListClusters</a>.
        /// Amazon ECS clusters are Region specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter isn't valid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ResourceNotFoundException">
        /// The specified resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }


        /// <summary>
        /// Deletes specified tags from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action. This client action might be using
        /// an action or resource on behalf of a user that doesn't have permissions to use the
        /// action or resource,. Or, it might be specifying an identifier that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClusterNotFoundException">
        /// The specified cluster wasn't found. You can view your available clusters with <a>ListClusters</a>.
        /// Amazon ECS clusters are Region specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter isn't valid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ResourceNotFoundException">
        /// The specified resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateCapacityProvider


        /// <summary>
        /// Modifies the parameters for a capacity provider.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCapacityProvider service method.</param>
        /// 
        /// <returns>The response from the UpdateCapacityProvider service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action. This client action might be using
        /// an action or resource on behalf of a user that doesn't have permissions to use the
        /// action or resource,. Or, it might be specifying an identifier that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter isn't valid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/UpdateCapacityProvider">REST API Reference for UpdateCapacityProvider Operation</seealso>
        public virtual UpdateCapacityProviderResponse UpdateCapacityProvider(UpdateCapacityProviderRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateCapacityProviderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCapacityProviderResponseUnmarshaller.Instance;

            return Invoke<UpdateCapacityProviderResponse>(request, options);
        }


        /// <summary>
        /// Modifies the parameters for a capacity provider.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCapacityProvider service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateCapacityProvider service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action. This client action might be using
        /// an action or resource on behalf of a user that doesn't have permissions to use the
        /// action or resource,. Or, it might be specifying an identifier that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter isn't valid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/UpdateCapacityProvider">REST API Reference for UpdateCapacityProvider Operation</seealso>
        public virtual Task<UpdateCapacityProviderResponse> UpdateCapacityProviderAsync(UpdateCapacityProviderRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateCapacityProviderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCapacityProviderResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateCapacityProviderResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateCluster


        /// <summary>
        /// Updates the cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCluster service method.</param>
        /// 
        /// <returns>The response from the UpdateCluster service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action. This client action might be using
        /// an action or resource on behalf of a user that doesn't have permissions to use the
        /// action or resource,. Or, it might be specifying an identifier that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClusterNotFoundException">
        /// The specified cluster wasn't found. You can view your available clusters with <a>ListClusters</a>.
        /// Amazon ECS clusters are Region specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter isn't valid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/UpdateCluster">REST API Reference for UpdateCluster Operation</seealso>
        public virtual UpdateClusterResponse UpdateCluster(UpdateClusterRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateClusterResponseUnmarshaller.Instance;

            return Invoke<UpdateClusterResponse>(request, options);
        }


        /// <summary>
        /// Updates the cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateCluster service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action. This client action might be using
        /// an action or resource on behalf of a user that doesn't have permissions to use the
        /// action or resource,. Or, it might be specifying an identifier that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClusterNotFoundException">
        /// The specified cluster wasn't found. You can view your available clusters with <a>ListClusters</a>.
        /// Amazon ECS clusters are Region specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter isn't valid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/UpdateCluster">REST API Reference for UpdateCluster Operation</seealso>
        public virtual Task<UpdateClusterResponse> UpdateClusterAsync(UpdateClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateClusterResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateClusterResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateClusterSettings


        /// <summary>
        /// Modifies the settings to use for a cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateClusterSettings service method.</param>
        /// 
        /// <returns>The response from the UpdateClusterSettings service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action. This client action might be using
        /// an action or resource on behalf of a user that doesn't have permissions to use the
        /// action or resource,. Or, it might be specifying an identifier that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClusterNotFoundException">
        /// The specified cluster wasn't found. You can view your available clusters with <a>ListClusters</a>.
        /// Amazon ECS clusters are Region specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter isn't valid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/UpdateClusterSettings">REST API Reference for UpdateClusterSettings Operation</seealso>
        public virtual UpdateClusterSettingsResponse UpdateClusterSettings(UpdateClusterSettingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateClusterSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateClusterSettingsResponseUnmarshaller.Instance;

            return Invoke<UpdateClusterSettingsResponse>(request, options);
        }


        /// <summary>
        /// Modifies the settings to use for a cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateClusterSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateClusterSettings service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action. This client action might be using
        /// an action or resource on behalf of a user that doesn't have permissions to use the
        /// action or resource,. Or, it might be specifying an identifier that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClusterNotFoundException">
        /// The specified cluster wasn't found. You can view your available clusters with <a>ListClusters</a>.
        /// Amazon ECS clusters are Region specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter isn't valid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/UpdateClusterSettings">REST API Reference for UpdateClusterSettings Operation</seealso>
        public virtual Task<UpdateClusterSettingsResponse> UpdateClusterSettingsAsync(UpdateClusterSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateClusterSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateClusterSettingsResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateClusterSettingsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateContainerAgent


        /// <summary>
        /// Updates the Amazon ECS container agent on a specified container instance. Updating
        /// the Amazon ECS container agent doesn't interrupt running tasks or services on the
        /// container instance. The process for updating the agent differs depending on whether
        /// your container instance was launched with the Amazon ECS-optimized AMI or another
        /// operating system.
        /// 
        ///  <note> 
        /// <para>
        /// The <code>UpdateContainerAgent</code> API isn't supported for container instances
        /// using the Amazon ECS-optimized Amazon Linux 2 (arm64) AMI. To update the container
        /// agent, you can update the <code>ecs-init</code> package. This updates the agent. For
        /// more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/agent-update-ecs-ami.html">Updating
        /// the Amazon ECS container agent</a> in the <i>Amazon Elastic Container Service Developer
        /// Guide</i>.
        /// </para>
        ///  </note> <note> 
        /// <para>
        /// Agent updates with the <code>UpdateContainerAgent</code> API operation do not apply
        /// to Windows container instances. We recommend that you launch new container instances
        /// to update the agent version in your Windows clusters.
        /// </para>
        ///  </note> 
        /// <para>
        /// The <code>UpdateContainerAgent</code> API requires an Amazon ECS-optimized AMI or
        /// Amazon Linux AMI with the <code>ecs-init</code> service installed and running. For
        /// help updating the Amazon ECS container agent on other operating systems, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/ecs-agent-update.html#manually_update_agent">Manually
        /// updating the Amazon ECS container agent</a> in the <i>Amazon Elastic Container Service
        /// Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateContainerAgent service method.</param>
        /// 
        /// <returns>The response from the UpdateContainerAgent service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action. This client action might be using
        /// an action or resource on behalf of a user that doesn't have permissions to use the
        /// action or resource,. Or, it might be specifying an identifier that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClusterNotFoundException">
        /// The specified cluster wasn't found. You can view your available clusters with <a>ListClusters</a>.
        /// Amazon ECS clusters are Region specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter isn't valid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.MissingVersionException">
        /// Amazon ECS can't determine the current version of the Amazon ECS container agent on
        /// the container instance and doesn't have enough information to proceed with an update.
        /// This could be because the agent running on the container instance is a previous or
        /// custom version that doesn't use our version information.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.NoUpdateAvailableException">
        /// There's no update available for this Amazon ECS container agent. This might be because
        /// the agent is already running the latest version or because it's so old that there's
        /// no update path to the current version.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.UpdateInProgressException">
        /// There's already a current Amazon ECS container agent update in progress on the container
        /// instance that's specified. If the container agent becomes disconnected while it's
        /// in a transitional stage, such as <code>PENDING</code> or <code>STAGING</code>, the
        /// update process can get stuck in that state. However, when the agent reconnects, it
        /// resumes where it stopped previously.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/UpdateContainerAgent">REST API Reference for UpdateContainerAgent Operation</seealso>
        public virtual UpdateContainerAgentResponse UpdateContainerAgent(UpdateContainerAgentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateContainerAgentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateContainerAgentResponseUnmarshaller.Instance;

            return Invoke<UpdateContainerAgentResponse>(request, options);
        }


        /// <summary>
        /// Updates the Amazon ECS container agent on a specified container instance. Updating
        /// the Amazon ECS container agent doesn't interrupt running tasks or services on the
        /// container instance. The process for updating the agent differs depending on whether
        /// your container instance was launched with the Amazon ECS-optimized AMI or another
        /// operating system.
        /// 
        ///  <note> 
        /// <para>
        /// The <code>UpdateContainerAgent</code> API isn't supported for container instances
        /// using the Amazon ECS-optimized Amazon Linux 2 (arm64) AMI. To update the container
        /// agent, you can update the <code>ecs-init</code> package. This updates the agent. For
        /// more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/agent-update-ecs-ami.html">Updating
        /// the Amazon ECS container agent</a> in the <i>Amazon Elastic Container Service Developer
        /// Guide</i>.
        /// </para>
        ///  </note> <note> 
        /// <para>
        /// Agent updates with the <code>UpdateContainerAgent</code> API operation do not apply
        /// to Windows container instances. We recommend that you launch new container instances
        /// to update the agent version in your Windows clusters.
        /// </para>
        ///  </note> 
        /// <para>
        /// The <code>UpdateContainerAgent</code> API requires an Amazon ECS-optimized AMI or
        /// Amazon Linux AMI with the <code>ecs-init</code> service installed and running. For
        /// help updating the Amazon ECS container agent on other operating systems, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/ecs-agent-update.html#manually_update_agent">Manually
        /// updating the Amazon ECS container agent</a> in the <i>Amazon Elastic Container Service
        /// Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateContainerAgent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateContainerAgent service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action. This client action might be using
        /// an action or resource on behalf of a user that doesn't have permissions to use the
        /// action or resource,. Or, it might be specifying an identifier that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClusterNotFoundException">
        /// The specified cluster wasn't found. You can view your available clusters with <a>ListClusters</a>.
        /// Amazon ECS clusters are Region specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter isn't valid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.MissingVersionException">
        /// Amazon ECS can't determine the current version of the Amazon ECS container agent on
        /// the container instance and doesn't have enough information to proceed with an update.
        /// This could be because the agent running on the container instance is a previous or
        /// custom version that doesn't use our version information.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.NoUpdateAvailableException">
        /// There's no update available for this Amazon ECS container agent. This might be because
        /// the agent is already running the latest version or because it's so old that there's
        /// no update path to the current version.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.UpdateInProgressException">
        /// There's already a current Amazon ECS container agent update in progress on the container
        /// instance that's specified. If the container agent becomes disconnected while it's
        /// in a transitional stage, such as <code>PENDING</code> or <code>STAGING</code>, the
        /// update process can get stuck in that state. However, when the agent reconnects, it
        /// resumes where it stopped previously.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/UpdateContainerAgent">REST API Reference for UpdateContainerAgent Operation</seealso>
        public virtual Task<UpdateContainerAgentResponse> UpdateContainerAgentAsync(UpdateContainerAgentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateContainerAgentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateContainerAgentResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateContainerAgentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateContainerInstancesState


        /// <summary>
        /// Modifies the status of an Amazon ECS container instance.
        /// 
        ///  
        /// <para>
        /// Once a container instance has reached an <code>ACTIVE</code> state, you can change
        /// the status of a container instance to <code>DRAINING</code> to manually remove an
        /// instance from a cluster, for example to perform system updates, update the Docker
        /// daemon, or scale down the cluster size.
        /// </para>
        ///  <important> 
        /// <para>
        /// A container instance can't be changed to <code>DRAINING</code> until it has reached
        /// an <code>ACTIVE</code> status. If the instance is in any other status, an error will
        /// be received.
        /// </para>
        ///  </important> 
        /// <para>
        /// When you set a container instance to <code>DRAINING</code>, Amazon ECS prevents new
        /// tasks from being scheduled for placement on the container instance and replacement
        /// service tasks are started on other container instances in the cluster if the resources
        /// are available. Service tasks on the container instance that are in the <code>PENDING</code>
        /// state are stopped immediately.
        /// </para>
        ///  
        /// <para>
        /// Service tasks on the container instance that are in the <code>RUNNING</code> state
        /// are stopped and replaced according to the service's deployment configuration parameters,
        /// <code>minimumHealthyPercent</code> and <code>maximumPercent</code>. You can change
        /// the deployment configuration of your service using <a>UpdateService</a>.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If <code>minimumHealthyPercent</code> is below 100%, the scheduler can ignore <code>desiredCount</code>
        /// temporarily during task replacement. For example, <code>desiredCount</code> is four
        /// tasks, a minimum of 50% allows the scheduler to stop two existing tasks before starting
        /// two new tasks. If the minimum is 100%, the service scheduler can't remove existing
        /// tasks until the replacement tasks are considered healthy. Tasks for services that
        /// do not use a load balancer are considered healthy if they're in the <code>RUNNING</code>
        /// state. Tasks for services that use a load balancer are considered healthy if they're
        /// in the <code>RUNNING</code> state and are reported as healthy by the load balancer.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <code>maximumPercent</code> parameter represents an upper limit on the number
        /// of running tasks during task replacement. You can use this to define the replacement
        /// batch size. For example, if <code>desiredCount</code> is four tasks, a maximum of
        /// 200% starts four new tasks before stopping the four tasks to be drained, provided
        /// that the cluster resources required to do this are available. If the maximum is 100%,
        /// then replacement tasks can't start until the draining tasks have stopped.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Any <code>PENDING</code> or <code>RUNNING</code> tasks that do not belong to a service
        /// aren't affected. You must wait for them to finish or stop them manually.
        /// </para>
        ///  
        /// <para>
        /// A container instance has completed draining when it has no more <code>RUNNING</code>
        /// tasks. You can verify this using <a>ListTasks</a>.
        /// </para>
        ///  
        /// <para>
        /// When a container instance has been drained, you can set a container instance to <code>ACTIVE</code>
        /// status and once it has reached that status the Amazon ECS scheduler can begin scheduling
        /// tasks on the instance again.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateContainerInstancesState service method.</param>
        /// 
        /// <returns>The response from the UpdateContainerInstancesState service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action. This client action might be using
        /// an action or resource on behalf of a user that doesn't have permissions to use the
        /// action or resource,. Or, it might be specifying an identifier that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClusterNotFoundException">
        /// The specified cluster wasn't found. You can view your available clusters with <a>ListClusters</a>.
        /// Amazon ECS clusters are Region specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter isn't valid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/UpdateContainerInstancesState">REST API Reference for UpdateContainerInstancesState Operation</seealso>
        public virtual UpdateContainerInstancesStateResponse UpdateContainerInstancesState(UpdateContainerInstancesStateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateContainerInstancesStateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateContainerInstancesStateResponseUnmarshaller.Instance;

            return Invoke<UpdateContainerInstancesStateResponse>(request, options);
        }


        /// <summary>
        /// Modifies the status of an Amazon ECS container instance.
        /// 
        ///  
        /// <para>
        /// Once a container instance has reached an <code>ACTIVE</code> state, you can change
        /// the status of a container instance to <code>DRAINING</code> to manually remove an
        /// instance from a cluster, for example to perform system updates, update the Docker
        /// daemon, or scale down the cluster size.
        /// </para>
        ///  <important> 
        /// <para>
        /// A container instance can't be changed to <code>DRAINING</code> until it has reached
        /// an <code>ACTIVE</code> status. If the instance is in any other status, an error will
        /// be received.
        /// </para>
        ///  </important> 
        /// <para>
        /// When you set a container instance to <code>DRAINING</code>, Amazon ECS prevents new
        /// tasks from being scheduled for placement on the container instance and replacement
        /// service tasks are started on other container instances in the cluster if the resources
        /// are available. Service tasks on the container instance that are in the <code>PENDING</code>
        /// state are stopped immediately.
        /// </para>
        ///  
        /// <para>
        /// Service tasks on the container instance that are in the <code>RUNNING</code> state
        /// are stopped and replaced according to the service's deployment configuration parameters,
        /// <code>minimumHealthyPercent</code> and <code>maximumPercent</code>. You can change
        /// the deployment configuration of your service using <a>UpdateService</a>.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If <code>minimumHealthyPercent</code> is below 100%, the scheduler can ignore <code>desiredCount</code>
        /// temporarily during task replacement. For example, <code>desiredCount</code> is four
        /// tasks, a minimum of 50% allows the scheduler to stop two existing tasks before starting
        /// two new tasks. If the minimum is 100%, the service scheduler can't remove existing
        /// tasks until the replacement tasks are considered healthy. Tasks for services that
        /// do not use a load balancer are considered healthy if they're in the <code>RUNNING</code>
        /// state. Tasks for services that use a load balancer are considered healthy if they're
        /// in the <code>RUNNING</code> state and are reported as healthy by the load balancer.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <code>maximumPercent</code> parameter represents an upper limit on the number
        /// of running tasks during task replacement. You can use this to define the replacement
        /// batch size. For example, if <code>desiredCount</code> is four tasks, a maximum of
        /// 200% starts four new tasks before stopping the four tasks to be drained, provided
        /// that the cluster resources required to do this are available. If the maximum is 100%,
        /// then replacement tasks can't start until the draining tasks have stopped.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Any <code>PENDING</code> or <code>RUNNING</code> tasks that do not belong to a service
        /// aren't affected. You must wait for them to finish or stop them manually.
        /// </para>
        ///  
        /// <para>
        /// A container instance has completed draining when it has no more <code>RUNNING</code>
        /// tasks. You can verify this using <a>ListTasks</a>.
        /// </para>
        ///  
        /// <para>
        /// When a container instance has been drained, you can set a container instance to <code>ACTIVE</code>
        /// status and once it has reached that status the Amazon ECS scheduler can begin scheduling
        /// tasks on the instance again.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateContainerInstancesState service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateContainerInstancesState service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action. This client action might be using
        /// an action or resource on behalf of a user that doesn't have permissions to use the
        /// action or resource,. Or, it might be specifying an identifier that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClusterNotFoundException">
        /// The specified cluster wasn't found. You can view your available clusters with <a>ListClusters</a>.
        /// Amazon ECS clusters are Region specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter isn't valid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/UpdateContainerInstancesState">REST API Reference for UpdateContainerInstancesState Operation</seealso>
        public virtual Task<UpdateContainerInstancesStateResponse> UpdateContainerInstancesStateAsync(UpdateContainerInstancesStateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateContainerInstancesStateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateContainerInstancesStateResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateContainerInstancesStateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateService


        /// <summary>
        /// Modifies the parameters of a service.
        /// 
        ///  
        /// <para>
        /// For services using the rolling update (<code>ECS</code>) you can update the desired
        /// count, deployment configuration, network configuration, load balancers, service registries,
        /// enable ECS managed tags option, propagate tags option, task placement constraints
        /// and strategies, and task definition. When you update any of these parameters, Amazon
        /// ECS starts new tasks with the new configuration. 
        /// </para>
        ///  
        /// <para>
        /// For services using the blue/green (<code>CODE_DEPLOY</code>) deployment controller,
        /// only the desired count, deployment configuration, health check grace period, task
        /// placement constraints and strategies, enable ECS managed tags option, and propagate
        /// tags can be updated using this API. If the network configuration, platform version,
        /// task definition, or load balancer need to be updated, create a new CodeDeploy deployment.
        /// For more information, see <a href="https://docs.aws.amazon.com/codedeploy/latest/APIReference/API_CreateDeployment.html">CreateDeployment</a>
        /// in the <i>CodeDeploy API Reference</i>.
        /// </para>
        ///  
        /// <para>
        /// For services using an external deployment controller, you can update only the desired
        /// count, task placement constraints and strategies, health check grace period, enable
        /// ECS managed tags option, and propagate tags option, using this API. If the launch
        /// type, load balancer, network configuration, platform version, or task definition need
        /// to be updated, create a new task set For more information, see <a>CreateTaskSet</a>.
        /// </para>
        ///  
        /// <para>
        /// You can add to or subtract from the number of instantiations of a task definition
        /// in a service by specifying the cluster that the service is running in and a new <code>desiredCount</code>
        /// parameter.
        /// </para>
        ///  
        /// <para>
        /// If you have updated the Docker image of your application, you can create a new task
        /// definition with that image and deploy it to your service. The service scheduler uses
        /// the minimum healthy percent and maximum percent parameters (in the service's deployment
        /// configuration) to determine the deployment strategy.
        /// </para>
        ///  <note> 
        /// <para>
        /// If your updated Docker image uses the same tag as what is in the existing task definition
        /// for your service (for example, <code>my_image:latest</code>), you don't need to create
        /// a new revision of your task definition. You can update the service using the <code>forceNewDeployment</code>
        /// option. The new tasks launched by the deployment pull the current image/tag combination
        /// from your repository when they start.
        /// </para>
        ///  </note> 
        /// <para>
        /// You can also update the deployment configuration of a service. When a deployment is
        /// triggered by updating the task definition of a service, the service scheduler uses
        /// the deployment configuration parameters, <code>minimumHealthyPercent</code> and <code>maximumPercent</code>,
        /// to determine the deployment strategy.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If <code>minimumHealthyPercent</code> is below 100%, the scheduler can ignore <code>desiredCount</code>
        /// temporarily during a deployment. For example, if <code>desiredCount</code> is four
        /// tasks, a minimum of 50% allows the scheduler to stop two existing tasks before starting
        /// two new tasks. Tasks for services that don't use a load balancer are considered healthy
        /// if they're in the <code>RUNNING</code> state. Tasks for services that use a load balancer
        /// are considered healthy if they're in the <code>RUNNING</code> state and are reported
        /// as healthy by the load balancer.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <code>maximumPercent</code> parameter represents an upper limit on the number
        /// of running tasks during a deployment. You can use it to define the deployment batch
        /// size. For example, if <code>desiredCount</code> is four tasks, a maximum of 200% starts
        /// four new tasks before stopping the four older tasks (provided that the cluster resources
        /// required to do this are available).
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When <a>UpdateService</a> stops a task during a deployment, the equivalent of <code>docker
        /// stop</code> is issued to the containers running in the task. This results in a <code>SIGTERM</code>
        /// and a 30-second timeout. After this, <code>SIGKILL</code> is sent and the containers
        /// are forcibly stopped. If the container handles the <code>SIGTERM</code> gracefully
        /// and exits within 30 seconds from receiving it, no <code>SIGKILL</code> is sent.
        /// </para>
        ///  
        /// <para>
        /// When the service scheduler launches new tasks, it determines task placement in your
        /// cluster with the following logic.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Determine which of the container instances in your cluster can support your service's
        /// task definition. For example, they have the required CPU, memory, ports, and container
        /// instance attributes.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// By default, the service scheduler attempts to balance tasks across Availability Zones
        /// in this manner even though you can choose a different placement strategy.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Sort the valid container instances by the fewest number of running tasks for this
        /// service in the same Availability Zone as the instance. For example, if zone A has
        /// one running service task and zones B and C each have zero, valid container instances
        /// in either zone B or C are considered optimal for placement.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Place the new service task on a valid container instance in an optimal Availability
        /// Zone (based on the previous steps), favoring container instances with the fewest number
        /// of running tasks for this service.
        /// </para>
        ///  </li> </ul> </li> </ul> 
        /// <para>
        /// When the service scheduler stops running tasks, it attempts to maintain balance across
        /// the Availability Zones in your cluster using the following logic: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Sort the container instances by the largest number of running tasks for this service
        /// in the same Availability Zone as the instance. For example, if zone A has one running
        /// service task and zones B and C each have two, container instances in either zone B
        /// or C are considered optimal for termination.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Stop the task on a container instance in an optimal Availability Zone (based on the
        /// previous steps), favoring container instances with the largest number of running tasks
        /// for this service.
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// You must have a service-linked role when you update any of the following service properties.
        /// If you specified a custom IAM role when you created the service, Amazon ECS automatically
        /// replaces the <a href="https://docs.aws.amazon.com/AmazonECS/latest/APIReference/API_Service.html#ECS-Type-Service-roleArn">roleARN</a>
        /// associated with the service with the ARN of your service-linked role. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/using-service-linked-roles.html">Service-linked
        /// roles</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>loadBalancers,</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>serviceRegistries</code> 
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateService service method.</param>
        /// 
        /// <returns>The response from the UpdateService service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.AccessDeniedException">
        /// You don't have authorization to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action. This client action might be using
        /// an action or resource on behalf of a user that doesn't have permissions to use the
        /// action or resource,. Or, it might be specifying an identifier that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClusterNotFoundException">
        /// The specified cluster wasn't found. You can view your available clusters with <a>ListClusters</a>.
        /// Amazon ECS clusters are Region specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter isn't valid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.NamespaceNotFoundException">
        /// The specified namespace wasn't found.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.PlatformTaskDefinitionIncompatibilityException">
        /// The specified platform version doesn't satisfy the required capabilities of the task
        /// definition.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.PlatformUnknownException">
        /// The specified platform version doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServiceNotActiveException">
        /// The specified service isn't active. You can't update a service that's inactive. If
        /// you have previously deleted a service, you can re-create it with <a>CreateService</a>.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServiceNotFoundException">
        /// The specified service wasn't found. You can view your available services with <a>ListServices</a>.
        /// Amazon ECS services are cluster specific and Region specific.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/UpdateService">REST API Reference for UpdateService Operation</seealso>
        public virtual UpdateServiceResponse UpdateService(UpdateServiceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateServiceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateServiceResponseUnmarshaller.Instance;

            return Invoke<UpdateServiceResponse>(request, options);
        }


        /// <summary>
        /// Modifies the parameters of a service.
        /// 
        ///  
        /// <para>
        /// For services using the rolling update (<code>ECS</code>) you can update the desired
        /// count, deployment configuration, network configuration, load balancers, service registries,
        /// enable ECS managed tags option, propagate tags option, task placement constraints
        /// and strategies, and task definition. When you update any of these parameters, Amazon
        /// ECS starts new tasks with the new configuration. 
        /// </para>
        ///  
        /// <para>
        /// For services using the blue/green (<code>CODE_DEPLOY</code>) deployment controller,
        /// only the desired count, deployment configuration, health check grace period, task
        /// placement constraints and strategies, enable ECS managed tags option, and propagate
        /// tags can be updated using this API. If the network configuration, platform version,
        /// task definition, or load balancer need to be updated, create a new CodeDeploy deployment.
        /// For more information, see <a href="https://docs.aws.amazon.com/codedeploy/latest/APIReference/API_CreateDeployment.html">CreateDeployment</a>
        /// in the <i>CodeDeploy API Reference</i>.
        /// </para>
        ///  
        /// <para>
        /// For services using an external deployment controller, you can update only the desired
        /// count, task placement constraints and strategies, health check grace period, enable
        /// ECS managed tags option, and propagate tags option, using this API. If the launch
        /// type, load balancer, network configuration, platform version, or task definition need
        /// to be updated, create a new task set For more information, see <a>CreateTaskSet</a>.
        /// </para>
        ///  
        /// <para>
        /// You can add to or subtract from the number of instantiations of a task definition
        /// in a service by specifying the cluster that the service is running in and a new <code>desiredCount</code>
        /// parameter.
        /// </para>
        ///  
        /// <para>
        /// If you have updated the Docker image of your application, you can create a new task
        /// definition with that image and deploy it to your service. The service scheduler uses
        /// the minimum healthy percent and maximum percent parameters (in the service's deployment
        /// configuration) to determine the deployment strategy.
        /// </para>
        ///  <note> 
        /// <para>
        /// If your updated Docker image uses the same tag as what is in the existing task definition
        /// for your service (for example, <code>my_image:latest</code>), you don't need to create
        /// a new revision of your task definition. You can update the service using the <code>forceNewDeployment</code>
        /// option. The new tasks launched by the deployment pull the current image/tag combination
        /// from your repository when they start.
        /// </para>
        ///  </note> 
        /// <para>
        /// You can also update the deployment configuration of a service. When a deployment is
        /// triggered by updating the task definition of a service, the service scheduler uses
        /// the deployment configuration parameters, <code>minimumHealthyPercent</code> and <code>maximumPercent</code>,
        /// to determine the deployment strategy.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If <code>minimumHealthyPercent</code> is below 100%, the scheduler can ignore <code>desiredCount</code>
        /// temporarily during a deployment. For example, if <code>desiredCount</code> is four
        /// tasks, a minimum of 50% allows the scheduler to stop two existing tasks before starting
        /// two new tasks. Tasks for services that don't use a load balancer are considered healthy
        /// if they're in the <code>RUNNING</code> state. Tasks for services that use a load balancer
        /// are considered healthy if they're in the <code>RUNNING</code> state and are reported
        /// as healthy by the load balancer.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <code>maximumPercent</code> parameter represents an upper limit on the number
        /// of running tasks during a deployment. You can use it to define the deployment batch
        /// size. For example, if <code>desiredCount</code> is four tasks, a maximum of 200% starts
        /// four new tasks before stopping the four older tasks (provided that the cluster resources
        /// required to do this are available).
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When <a>UpdateService</a> stops a task during a deployment, the equivalent of <code>docker
        /// stop</code> is issued to the containers running in the task. This results in a <code>SIGTERM</code>
        /// and a 30-second timeout. After this, <code>SIGKILL</code> is sent and the containers
        /// are forcibly stopped. If the container handles the <code>SIGTERM</code> gracefully
        /// and exits within 30 seconds from receiving it, no <code>SIGKILL</code> is sent.
        /// </para>
        ///  
        /// <para>
        /// When the service scheduler launches new tasks, it determines task placement in your
        /// cluster with the following logic.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Determine which of the container instances in your cluster can support your service's
        /// task definition. For example, they have the required CPU, memory, ports, and container
        /// instance attributes.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// By default, the service scheduler attempts to balance tasks across Availability Zones
        /// in this manner even though you can choose a different placement strategy.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Sort the valid container instances by the fewest number of running tasks for this
        /// service in the same Availability Zone as the instance. For example, if zone A has
        /// one running service task and zones B and C each have zero, valid container instances
        /// in either zone B or C are considered optimal for placement.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Place the new service task on a valid container instance in an optimal Availability
        /// Zone (based on the previous steps), favoring container instances with the fewest number
        /// of running tasks for this service.
        /// </para>
        ///  </li> </ul> </li> </ul> 
        /// <para>
        /// When the service scheduler stops running tasks, it attempts to maintain balance across
        /// the Availability Zones in your cluster using the following logic: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Sort the container instances by the largest number of running tasks for this service
        /// in the same Availability Zone as the instance. For example, if zone A has one running
        /// service task and zones B and C each have two, container instances in either zone B
        /// or C are considered optimal for termination.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Stop the task on a container instance in an optimal Availability Zone (based on the
        /// previous steps), favoring container instances with the largest number of running tasks
        /// for this service.
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// You must have a service-linked role when you update any of the following service properties.
        /// If you specified a custom IAM role when you created the service, Amazon ECS automatically
        /// replaces the <a href="https://docs.aws.amazon.com/AmazonECS/latest/APIReference/API_Service.html#ECS-Type-Service-roleArn">roleARN</a>
        /// associated with the service with the ARN of your service-linked role. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/using-service-linked-roles.html">Service-linked
        /// roles</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>loadBalancers,</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>serviceRegistries</code> 
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateService service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateService service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.AccessDeniedException">
        /// You don't have authorization to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action. This client action might be using
        /// an action or resource on behalf of a user that doesn't have permissions to use the
        /// action or resource,. Or, it might be specifying an identifier that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClusterNotFoundException">
        /// The specified cluster wasn't found. You can view your available clusters with <a>ListClusters</a>.
        /// Amazon ECS clusters are Region specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter isn't valid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.NamespaceNotFoundException">
        /// The specified namespace wasn't found.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.PlatformTaskDefinitionIncompatibilityException">
        /// The specified platform version doesn't satisfy the required capabilities of the task
        /// definition.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.PlatformUnknownException">
        /// The specified platform version doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServiceNotActiveException">
        /// The specified service isn't active. You can't update a service that's inactive. If
        /// you have previously deleted a service, you can re-create it with <a>CreateService</a>.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServiceNotFoundException">
        /// The specified service wasn't found. You can view your available services with <a>ListServices</a>.
        /// Amazon ECS services are cluster specific and Region specific.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/UpdateService">REST API Reference for UpdateService Operation</seealso>
        public virtual Task<UpdateServiceResponse> UpdateServiceAsync(UpdateServiceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateServiceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateServiceResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateServiceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateServicePrimaryTaskSet


        /// <summary>
        /// Modifies which task set in a service is the primary task set. Any parameters that
        /// are updated on the primary task set in a service will transition to the service. This
        /// is used when a service uses the <code>EXTERNAL</code> deployment controller type.
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/deployment-types.html">Amazon
        /// ECS Deployment Types</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateServicePrimaryTaskSet service method.</param>
        /// 
        /// <returns>The response from the UpdateServicePrimaryTaskSet service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.AccessDeniedException">
        /// You don't have authorization to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action. This client action might be using
        /// an action or resource on behalf of a user that doesn't have permissions to use the
        /// action or resource,. Or, it might be specifying an identifier that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClusterNotFoundException">
        /// The specified cluster wasn't found. You can view your available clusters with <a>ListClusters</a>.
        /// Amazon ECS clusters are Region specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter isn't valid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServiceNotActiveException">
        /// The specified service isn't active. You can't update a service that's inactive. If
        /// you have previously deleted a service, you can re-create it with <a>CreateService</a>.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServiceNotFoundException">
        /// The specified service wasn't found. You can view your available services with <a>ListServices</a>.
        /// Amazon ECS services are cluster specific and Region specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.TaskSetNotFoundException">
        /// The specified task set wasn't found. You can view your available task sets with <a>DescribeTaskSets</a>.
        /// Task sets are specific to each cluster, service and Region.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.UnsupportedFeatureException">
        /// The specified task isn't supported in this Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/UpdateServicePrimaryTaskSet">REST API Reference for UpdateServicePrimaryTaskSet Operation</seealso>
        public virtual UpdateServicePrimaryTaskSetResponse UpdateServicePrimaryTaskSet(UpdateServicePrimaryTaskSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateServicePrimaryTaskSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateServicePrimaryTaskSetResponseUnmarshaller.Instance;

            return Invoke<UpdateServicePrimaryTaskSetResponse>(request, options);
        }


        /// <summary>
        /// Modifies which task set in a service is the primary task set. Any parameters that
        /// are updated on the primary task set in a service will transition to the service. This
        /// is used when a service uses the <code>EXTERNAL</code> deployment controller type.
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/deployment-types.html">Amazon
        /// ECS Deployment Types</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateServicePrimaryTaskSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateServicePrimaryTaskSet service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.AccessDeniedException">
        /// You don't have authorization to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action. This client action might be using
        /// an action or resource on behalf of a user that doesn't have permissions to use the
        /// action or resource,. Or, it might be specifying an identifier that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClusterNotFoundException">
        /// The specified cluster wasn't found. You can view your available clusters with <a>ListClusters</a>.
        /// Amazon ECS clusters are Region specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter isn't valid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServiceNotActiveException">
        /// The specified service isn't active. You can't update a service that's inactive. If
        /// you have previously deleted a service, you can re-create it with <a>CreateService</a>.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServiceNotFoundException">
        /// The specified service wasn't found. You can view your available services with <a>ListServices</a>.
        /// Amazon ECS services are cluster specific and Region specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.TaskSetNotFoundException">
        /// The specified task set wasn't found. You can view your available task sets with <a>DescribeTaskSets</a>.
        /// Task sets are specific to each cluster, service and Region.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.UnsupportedFeatureException">
        /// The specified task isn't supported in this Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/UpdateServicePrimaryTaskSet">REST API Reference for UpdateServicePrimaryTaskSet Operation</seealso>
        public virtual Task<UpdateServicePrimaryTaskSetResponse> UpdateServicePrimaryTaskSetAsync(UpdateServicePrimaryTaskSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateServicePrimaryTaskSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateServicePrimaryTaskSetResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateServicePrimaryTaskSetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateTaskProtection


        /// <summary>
        /// Updates the protection status of a task. You can set <code>protectionEnabled</code>
        /// to <code>true</code> to protect your task from termination during scale-in events
        /// from <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/service-auto-scaling.html">Service
        /// Autoscaling</a> or <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/deployment-types.html">deployments</a>.
        /// 
        ///  
        /// <para>
        /// Task-protection, by default, expires after 2 hours at which point Amazon ECS unsets
        /// the <code>protectionEnabled</code> property making the task eligible for termination
        /// by a subsequent scale-in event.
        /// </para>
        ///  
        /// <para>
        /// You can specify a custom expiration period for task protection from 1 minute to up
        /// to 2,880 minutes (48 hours). To specify the custom expiration period, set the <code>expiresInMinutes</code>
        /// property. The <code>expiresInMinutes</code> property is always reset when you invoke
        /// this operation for a task that already has <code>protectionEnabled</code> set to <code>true</code>.
        /// You can keep extending the protection expiration period of a task by invoking this
        /// operation repeatedly.
        /// </para>
        ///  
        /// <para>
        /// To learn more about Amazon ECS task protection, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/task-scale-in-protection.html">Task
        /// scale-in protection</a> in the <i> <i>Amazon Elastic Container Service Developer Guide</i>
        /// </i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// This operation is only supported for tasks belonging to an Amazon ECS service. Invoking
        /// this operation for a standalone task will result in an <code>TASK_NOT_VALID</code>
        /// failure. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/api_failures_messages.html">API
        /// failure reasons</a>.
        /// </para>
        ///  </note> <important> 
        /// <para>
        /// If you prefer to set task protection from within the container, we recommend using
        /// the <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/task-scale-in-protection-endpoint.html">Task
        /// scale-in protection endpoint</a>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTaskProtection service method.</param>
        /// 
        /// <returns>The response from the UpdateTaskProtection service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.AccessDeniedException">
        /// You don't have authorization to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action. This client action might be using
        /// an action or resource on behalf of a user that doesn't have permissions to use the
        /// action or resource,. Or, it might be specifying an identifier that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClusterNotFoundException">
        /// The specified cluster wasn't found. You can view your available clusters with <a>ListClusters</a>.
        /// Amazon ECS clusters are Region specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter isn't valid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ResourceNotFoundException">
        /// The specified resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.UnsupportedFeatureException">
        /// The specified task isn't supported in this Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/UpdateTaskProtection">REST API Reference for UpdateTaskProtection Operation</seealso>
        public virtual UpdateTaskProtectionResponse UpdateTaskProtection(UpdateTaskProtectionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateTaskProtectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTaskProtectionResponseUnmarshaller.Instance;

            return Invoke<UpdateTaskProtectionResponse>(request, options);
        }


        /// <summary>
        /// Updates the protection status of a task. You can set <code>protectionEnabled</code>
        /// to <code>true</code> to protect your task from termination during scale-in events
        /// from <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/service-auto-scaling.html">Service
        /// Autoscaling</a> or <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/deployment-types.html">deployments</a>.
        /// 
        ///  
        /// <para>
        /// Task-protection, by default, expires after 2 hours at which point Amazon ECS unsets
        /// the <code>protectionEnabled</code> property making the task eligible for termination
        /// by a subsequent scale-in event.
        /// </para>
        ///  
        /// <para>
        /// You can specify a custom expiration period for task protection from 1 minute to up
        /// to 2,880 minutes (48 hours). To specify the custom expiration period, set the <code>expiresInMinutes</code>
        /// property. The <code>expiresInMinutes</code> property is always reset when you invoke
        /// this operation for a task that already has <code>protectionEnabled</code> set to <code>true</code>.
        /// You can keep extending the protection expiration period of a task by invoking this
        /// operation repeatedly.
        /// </para>
        ///  
        /// <para>
        /// To learn more about Amazon ECS task protection, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/task-scale-in-protection.html">Task
        /// scale-in protection</a> in the <i> <i>Amazon Elastic Container Service Developer Guide</i>
        /// </i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// This operation is only supported for tasks belonging to an Amazon ECS service. Invoking
        /// this operation for a standalone task will result in an <code>TASK_NOT_VALID</code>
        /// failure. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/api_failures_messages.html">API
        /// failure reasons</a>.
        /// </para>
        ///  </note> <important> 
        /// <para>
        /// If you prefer to set task protection from within the container, we recommend using
        /// the <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/task-scale-in-protection-endpoint.html">Task
        /// scale-in protection endpoint</a>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTaskProtection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateTaskProtection service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.AccessDeniedException">
        /// You don't have authorization to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action. This client action might be using
        /// an action or resource on behalf of a user that doesn't have permissions to use the
        /// action or resource,. Or, it might be specifying an identifier that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClusterNotFoundException">
        /// The specified cluster wasn't found. You can view your available clusters with <a>ListClusters</a>.
        /// Amazon ECS clusters are Region specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter isn't valid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ResourceNotFoundException">
        /// The specified resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.UnsupportedFeatureException">
        /// The specified task isn't supported in this Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/UpdateTaskProtection">REST API Reference for UpdateTaskProtection Operation</seealso>
        public virtual Task<UpdateTaskProtectionResponse> UpdateTaskProtectionAsync(UpdateTaskProtectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateTaskProtectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTaskProtectionResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateTaskProtectionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateTaskSet


        /// <summary>
        /// Modifies a task set. This is used when a service uses the <code>EXTERNAL</code> deployment
        /// controller type. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/deployment-types.html">Amazon
        /// ECS Deployment Types</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTaskSet service method.</param>
        /// 
        /// <returns>The response from the UpdateTaskSet service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.AccessDeniedException">
        /// You don't have authorization to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action. This client action might be using
        /// an action or resource on behalf of a user that doesn't have permissions to use the
        /// action or resource,. Or, it might be specifying an identifier that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClusterNotFoundException">
        /// The specified cluster wasn't found. You can view your available clusters with <a>ListClusters</a>.
        /// Amazon ECS clusters are Region specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter isn't valid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServiceNotActiveException">
        /// The specified service isn't active. You can't update a service that's inactive. If
        /// you have previously deleted a service, you can re-create it with <a>CreateService</a>.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServiceNotFoundException">
        /// The specified service wasn't found. You can view your available services with <a>ListServices</a>.
        /// Amazon ECS services are cluster specific and Region specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.TaskSetNotFoundException">
        /// The specified task set wasn't found. You can view your available task sets with <a>DescribeTaskSets</a>.
        /// Task sets are specific to each cluster, service and Region.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.UnsupportedFeatureException">
        /// The specified task isn't supported in this Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/UpdateTaskSet">REST API Reference for UpdateTaskSet Operation</seealso>
        public virtual UpdateTaskSetResponse UpdateTaskSet(UpdateTaskSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateTaskSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTaskSetResponseUnmarshaller.Instance;

            return Invoke<UpdateTaskSetResponse>(request, options);
        }


        /// <summary>
        /// Modifies a task set. This is used when a service uses the <code>EXTERNAL</code> deployment
        /// controller type. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/deployment-types.html">Amazon
        /// ECS Deployment Types</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTaskSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateTaskSet service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.AccessDeniedException">
        /// You don't have authorization to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action. This client action might be using
        /// an action or resource on behalf of a user that doesn't have permissions to use the
        /// action or resource,. Or, it might be specifying an identifier that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClusterNotFoundException">
        /// The specified cluster wasn't found. You can view your available clusters with <a>ListClusters</a>.
        /// Amazon ECS clusters are Region specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter isn't valid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServiceNotActiveException">
        /// The specified service isn't active. You can't update a service that's inactive. If
        /// you have previously deleted a service, you can re-create it with <a>CreateService</a>.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServiceNotFoundException">
        /// The specified service wasn't found. You can view your available services with <a>ListServices</a>.
        /// Amazon ECS services are cluster specific and Region specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.TaskSetNotFoundException">
        /// The specified task set wasn't found. You can view your available task sets with <a>DescribeTaskSets</a>.
        /// Task sets are specific to each cluster, service and Region.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.UnsupportedFeatureException">
        /// The specified task isn't supported in this Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/UpdateTaskSet">REST API Reference for UpdateTaskSet Operation</seealso>
        public virtual Task<UpdateTaskSetResponse> UpdateTaskSetAsync(UpdateTaskSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateTaskSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTaskSetResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateTaskSetResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}