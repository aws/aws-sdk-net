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
 * Do not modify this file. This file is generated from the pcs-2023-02-10.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.PCS.Model;
using Amazon.PCS.Model.Internal.MarshallTransformations;
using Amazon.PCS.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.PCS
{
    /// <summary>
    /// <para>Implementation for accessing PCS</para>
    ///
    /// Parallel Computing Service (PCS) is a managed service that makes it easier for you
    /// to run and scale your high performance computing (HPC) workloads, and build scientific
    /// and engineering models on Amazon Web Services using Slurm. For more information, see
    /// the <a href="https://docs.aws.amazon.com/pcs/latest/userguide">Parallel Computing
    /// Service User Guide</a>.
    /// 
    ///  
    /// <para>
    /// This reference describes the actions and data types of the service management API.
    /// You can use the Amazon Web Services SDKs to call the API actions in software, or use
    /// the Command Line Interface (CLI) to call the API actions manually. These API actions
    /// manage the service through an Amazon Web Services account.
    /// </para>
    ///  
    /// <para>
    /// The API actions operate on PCS resources. A <i>resource</i> is an entity in Amazon
    /// Web Services that you can work with. Amazon Web Services services create resources
    /// when you use the features of the service. Examples of PCS resources include clusters,
    /// compute node groups, and queues. For more information about resources in Amazon Web
    /// Services, see <a href="https://docs.aws.amazon.com/resource-explorer/latest/userguide/getting-started-terms-and-concepts.html#term-resource">Resource</a>
    /// in the <i>Resource Explorer User Guide</i>. 
    /// </para>
    ///  
    /// <para>
    /// An PCS <i>compute node</i> is an Amazon EC2 instance. You don't launch compute nodes
    /// directly. PCS uses configuration information that you provide to launch compute nodes
    /// in your Amazon Web Services account. You receive billing charges for your running
    /// compute nodes. PCS automatically terminates your compute nodes when you delete the
    /// PCS resources related to those compute nodes.
    /// </para>
    /// </summary>
    public partial class AmazonPCSClient : AmazonServiceClient, IAmazonPCS
    {
        private static IServiceMetadata serviceMetadata = new AmazonPCSMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonPCSClient with the credentials loaded from the application's
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
        public AmazonPCSClient()
            : base(new AmazonPCSConfig()) { }

        /// <summary>
        /// Constructs AmazonPCSClient with the credentials loaded from the application's
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
        public AmazonPCSClient(RegionEndpoint region)
            : base(new AmazonPCSConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonPCSClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonPCSClient Configuration Object</param>
        public AmazonPCSClient(AmazonPCSConfig config)
            : base(config) { }


        /// <summary>
        /// Constructs AmazonPCSClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonPCSClient(AWSCredentials credentials)
            : this(credentials, new AmazonPCSConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonPCSClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonPCSClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonPCSConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonPCSClient with AWS Credentials and an
        /// AmazonPCSClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonPCSClient Configuration Object</param>
        public AmazonPCSClient(AWSCredentials credentials, AmazonPCSConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonPCSClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonPCSClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonPCSConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonPCSClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonPCSClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonPCSConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonPCSClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonPCSClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonPCSClient Configuration Object</param>
        public AmazonPCSClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonPCSConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonPCSClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonPCSClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonPCSConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonPCSClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonPCSClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonPCSConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonPCSClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonPCSClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonPCSClient Configuration Object</param>
        public AmazonPCSClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonPCSConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private IPCSPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IPCSPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new PCSPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif

        #region Overrides

        /// <summary>
        /// Customizes the runtime pipeline.
        /// </summary>
        /// <param name="pipeline">Runtime pipeline for the current client.</param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonPCSEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonPCSAuthSchemeHandler());
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


        #region  CreateCluster

        internal virtual CreateClusterResponse CreateCluster(CreateClusterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateClusterResponseUnmarshaller.Instance;

            return Invoke<CreateClusterResponse>(request, options);
        }



        /// <summary>
        /// Creates a cluster in your account. PCS creates the cluster controller in a service-owned
        /// account. The cluster controller communicates with the cluster resources in your account.
        /// The subnets and security groups for the cluster must already exist before you use
        /// this API action.
        /// 
        ///  <note> 
        /// <para>
        /// It takes time for PCS to create the cluster. The cluster is in a <c>Creating</c> state
        /// until it is ready to use. There can only be 1 cluster in a <c>Creating</c> state per
        /// Amazon Web Services Region per Amazon Web Services account. <c>CreateCluster</c> fails
        /// with a <c>ServiceQuotaExceededException</c> if there is already a cluster in a <c>Creating</c>
        /// state.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateCluster service method, as returned by PCS.</returns>
        /// <exception cref="Amazon.PCS.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The launch template instance profile doesn't pass <c>iam:PassRole</c> verification.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// There is a mismatch between the account ID and cluster ID.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The cluster ID doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The EC2 instance isn't present.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than 1 operation on the same resource at the same time.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A cluster with the same name already exists.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A cluster isn't in <c>ACTIVE</c> status.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A cluster to delete is in an unstable state. For example, because it still has <c>ACTIVE</c>
        /// node groups or queues.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A queue already exists in a cluster.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.InternalServerException">
        /// PCS can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ServiceQuotaExceededException">
        /// You exceeded your service quota. Service quotas, also referred to as limits, are the
        /// maximum number of service resources or operations for your Amazon Web Services account.
        /// To learn how to increase your service quota, see <a href="https://docs.aws.amazon.com/servicequotas/latest/userguide/request-quota-increase.html">Requesting
        /// a quota increase</a> in the <i>Service Quotas User Guide</i> 
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The max number of clusters or queues has been reached for the account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The max number of compute node groups has been reached for the associated cluster.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The total of <c>maxInstances</c> across all compute node groups has been reached for
        /// associated cluster.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ThrottlingException">
        /// Your request exceeded a request rate quota. Check the resource's request rate quota
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ValidationException">
        /// The request isn't valid.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Your request contains malformed JSON or unsupported characters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The scheduler version isn't supported.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// There are networking related errors, such as network validation failure.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// AMI type is <c>CUSTOM</c> and the launch template doesn't define the AMI ID, or the
        /// AMI type is AL2 and the launch template defines the AMI.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pcs-2023-02-10/CreateCluster">REST API Reference for CreateCluster Operation</seealso>
        public virtual Task<CreateClusterResponse> CreateClusterAsync(CreateClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateClusterResponseUnmarshaller.Instance;

            return InvokeAsync<CreateClusterResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateComputeNodeGroup

        internal virtual CreateComputeNodeGroupResponse CreateComputeNodeGroup(CreateComputeNodeGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateComputeNodeGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateComputeNodeGroupResponseUnmarshaller.Instance;

            return Invoke<CreateComputeNodeGroupResponse>(request, options);
        }



        /// <summary>
        /// Creates a managed set of compute nodes. You associate a compute node group with a
        /// cluster through 1 or more PCS queues or as part of the login fleet. A compute node
        /// group includes the definition of the compute properties and lifecycle management.
        /// PCS uses the information you provide to this API action to launch compute nodes in
        /// your account. You can only specify subnets in the same Amazon VPC as your cluster.
        /// You receive billing charges for the compute nodes that PCS launches in your account.
        /// You must already have a launch template before you call this API. For more information,
        /// see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-launch-templates.html">Launch
        /// an instance from a launch template</a> in the <i>Amazon Elastic Compute Cloud User
        /// Guide for Linux Instances</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateComputeNodeGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateComputeNodeGroup service method, as returned by PCS.</returns>
        /// <exception cref="Amazon.PCS.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The launch template instance profile doesn't pass <c>iam:PassRole</c> verification.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// There is a mismatch between the account ID and cluster ID.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The cluster ID doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The EC2 instance isn't present.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than 1 operation on the same resource at the same time.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A cluster with the same name already exists.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A cluster isn't in <c>ACTIVE</c> status.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A cluster to delete is in an unstable state. For example, because it still has <c>ACTIVE</c>
        /// node groups or queues.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A queue already exists in a cluster.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.InternalServerException">
        /// PCS can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ResourceNotFoundException">
        /// The requested resource can't be found. The cluster, node group, or queue you're attempting
        /// to get, update, list, or delete doesn't exist.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ServiceQuotaExceededException">
        /// You exceeded your service quota. Service quotas, also referred to as limits, are the
        /// maximum number of service resources or operations for your Amazon Web Services account.
        /// To learn how to increase your service quota, see <a href="https://docs.aws.amazon.com/servicequotas/latest/userguide/request-quota-increase.html">Requesting
        /// a quota increase</a> in the <i>Service Quotas User Guide</i> 
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The max number of clusters or queues has been reached for the account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The max number of compute node groups has been reached for the associated cluster.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The total of <c>maxInstances</c> across all compute node groups has been reached for
        /// associated cluster.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ThrottlingException">
        /// Your request exceeded a request rate quota. Check the resource's request rate quota
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ValidationException">
        /// The request isn't valid.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Your request contains malformed JSON or unsupported characters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The scheduler version isn't supported.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// There are networking related errors, such as network validation failure.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// AMI type is <c>CUSTOM</c> and the launch template doesn't define the AMI ID, or the
        /// AMI type is AL2 and the launch template defines the AMI.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pcs-2023-02-10/CreateComputeNodeGroup">REST API Reference for CreateComputeNodeGroup Operation</seealso>
        public virtual Task<CreateComputeNodeGroupResponse> CreateComputeNodeGroupAsync(CreateComputeNodeGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateComputeNodeGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateComputeNodeGroupResponseUnmarshaller.Instance;

            return InvokeAsync<CreateComputeNodeGroupResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateQueue

        internal virtual CreateQueueResponse CreateQueue(CreateQueueRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateQueueRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateQueueResponseUnmarshaller.Instance;

            return Invoke<CreateQueueResponse>(request, options);
        }



        /// <summary>
        /// Creates a job queue. You must associate 1 or more compute node groups with the queue.
        /// You can associate 1 compute node group with multiple queues.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateQueue service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateQueue service method, as returned by PCS.</returns>
        /// <exception cref="Amazon.PCS.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The launch template instance profile doesn't pass <c>iam:PassRole</c> verification.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// There is a mismatch between the account ID and cluster ID.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The cluster ID doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The EC2 instance isn't present.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than 1 operation on the same resource at the same time.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A cluster with the same name already exists.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A cluster isn't in <c>ACTIVE</c> status.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A cluster to delete is in an unstable state. For example, because it still has <c>ACTIVE</c>
        /// node groups or queues.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A queue already exists in a cluster.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.InternalServerException">
        /// PCS can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ResourceNotFoundException">
        /// The requested resource can't be found. The cluster, node group, or queue you're attempting
        /// to get, update, list, or delete doesn't exist.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ServiceQuotaExceededException">
        /// You exceeded your service quota. Service quotas, also referred to as limits, are the
        /// maximum number of service resources or operations for your Amazon Web Services account.
        /// To learn how to increase your service quota, see <a href="https://docs.aws.amazon.com/servicequotas/latest/userguide/request-quota-increase.html">Requesting
        /// a quota increase</a> in the <i>Service Quotas User Guide</i> 
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The max number of clusters or queues has been reached for the account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The max number of compute node groups has been reached for the associated cluster.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The total of <c>maxInstances</c> across all compute node groups has been reached for
        /// associated cluster.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ThrottlingException">
        /// Your request exceeded a request rate quota. Check the resource's request rate quota
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ValidationException">
        /// The request isn't valid.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Your request contains malformed JSON or unsupported characters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The scheduler version isn't supported.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// There are networking related errors, such as network validation failure.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// AMI type is <c>CUSTOM</c> and the launch template doesn't define the AMI ID, or the
        /// AMI type is AL2 and the launch template defines the AMI.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pcs-2023-02-10/CreateQueue">REST API Reference for CreateQueue Operation</seealso>
        public virtual Task<CreateQueueResponse> CreateQueueAsync(CreateQueueRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateQueueRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateQueueResponseUnmarshaller.Instance;

            return InvokeAsync<CreateQueueResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteCluster

        internal virtual DeleteClusterResponse DeleteCluster(DeleteClusterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteClusterResponseUnmarshaller.Instance;

            return Invoke<DeleteClusterResponse>(request, options);
        }



        /// <summary>
        /// Deletes a cluster and all its linked resources. You must delete all queues and compute
        /// node groups associated with the cluster before you can delete the cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteCluster service method, as returned by PCS.</returns>
        /// <exception cref="Amazon.PCS.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The launch template instance profile doesn't pass <c>iam:PassRole</c> verification.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// There is a mismatch between the account ID and cluster ID.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The cluster ID doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The EC2 instance isn't present.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than 1 operation on the same resource at the same time.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A cluster with the same name already exists.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A cluster isn't in <c>ACTIVE</c> status.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A cluster to delete is in an unstable state. For example, because it still has <c>ACTIVE</c>
        /// node groups or queues.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A queue already exists in a cluster.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.InternalServerException">
        /// PCS can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ResourceNotFoundException">
        /// The requested resource can't be found. The cluster, node group, or queue you're attempting
        /// to get, update, list, or delete doesn't exist.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ThrottlingException">
        /// Your request exceeded a request rate quota. Check the resource's request rate quota
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ValidationException">
        /// The request isn't valid.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Your request contains malformed JSON or unsupported characters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The scheduler version isn't supported.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// There are networking related errors, such as network validation failure.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// AMI type is <c>CUSTOM</c> and the launch template doesn't define the AMI ID, or the
        /// AMI type is AL2 and the launch template defines the AMI.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pcs-2023-02-10/DeleteCluster">REST API Reference for DeleteCluster Operation</seealso>
        public virtual Task<DeleteClusterResponse> DeleteClusterAsync(DeleteClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteClusterResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteClusterResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteComputeNodeGroup

        internal virtual DeleteComputeNodeGroupResponse DeleteComputeNodeGroup(DeleteComputeNodeGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteComputeNodeGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteComputeNodeGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteComputeNodeGroupResponse>(request, options);
        }



        /// <summary>
        /// Deletes a compute node group. You must delete all queues associated with the compute
        /// node group first.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteComputeNodeGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteComputeNodeGroup service method, as returned by PCS.</returns>
        /// <exception cref="Amazon.PCS.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The launch template instance profile doesn't pass <c>iam:PassRole</c> verification.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// There is a mismatch between the account ID and cluster ID.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The cluster ID doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The EC2 instance isn't present.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than 1 operation on the same resource at the same time.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A cluster with the same name already exists.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A cluster isn't in <c>ACTIVE</c> status.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A cluster to delete is in an unstable state. For example, because it still has <c>ACTIVE</c>
        /// node groups or queues.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A queue already exists in a cluster.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.InternalServerException">
        /// PCS can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ResourceNotFoundException">
        /// The requested resource can't be found. The cluster, node group, or queue you're attempting
        /// to get, update, list, or delete doesn't exist.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ThrottlingException">
        /// Your request exceeded a request rate quota. Check the resource's request rate quota
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ValidationException">
        /// The request isn't valid.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Your request contains malformed JSON or unsupported characters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The scheduler version isn't supported.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// There are networking related errors, such as network validation failure.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// AMI type is <c>CUSTOM</c> and the launch template doesn't define the AMI ID, or the
        /// AMI type is AL2 and the launch template defines the AMI.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pcs-2023-02-10/DeleteComputeNodeGroup">REST API Reference for DeleteComputeNodeGroup Operation</seealso>
        public virtual Task<DeleteComputeNodeGroupResponse> DeleteComputeNodeGroupAsync(DeleteComputeNodeGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteComputeNodeGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteComputeNodeGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteComputeNodeGroupResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteQueue

        internal virtual DeleteQueueResponse DeleteQueue(DeleteQueueRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteQueueRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteQueueResponseUnmarshaller.Instance;

            return Invoke<DeleteQueueResponse>(request, options);
        }



        /// <summary>
        /// Deletes a job queue. If the compute node group associated with this queue isn't associated
        /// with any other queues, PCS terminates all the compute nodes for this queue.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteQueue service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteQueue service method, as returned by PCS.</returns>
        /// <exception cref="Amazon.PCS.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The launch template instance profile doesn't pass <c>iam:PassRole</c> verification.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// There is a mismatch between the account ID and cluster ID.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The cluster ID doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The EC2 instance isn't present.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than 1 operation on the same resource at the same time.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A cluster with the same name already exists.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A cluster isn't in <c>ACTIVE</c> status.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A cluster to delete is in an unstable state. For example, because it still has <c>ACTIVE</c>
        /// node groups or queues.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A queue already exists in a cluster.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.InternalServerException">
        /// PCS can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ResourceNotFoundException">
        /// The requested resource can't be found. The cluster, node group, or queue you're attempting
        /// to get, update, list, or delete doesn't exist.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ThrottlingException">
        /// Your request exceeded a request rate quota. Check the resource's request rate quota
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ValidationException">
        /// The request isn't valid.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Your request contains malformed JSON or unsupported characters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The scheduler version isn't supported.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// There are networking related errors, such as network validation failure.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// AMI type is <c>CUSTOM</c> and the launch template doesn't define the AMI ID, or the
        /// AMI type is AL2 and the launch template defines the AMI.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pcs-2023-02-10/DeleteQueue">REST API Reference for DeleteQueue Operation</seealso>
        public virtual Task<DeleteQueueResponse> DeleteQueueAsync(DeleteQueueRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteQueueRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteQueueResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteQueueResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetCluster

        internal virtual GetClusterResponse GetCluster(GetClusterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetClusterResponseUnmarshaller.Instance;

            return Invoke<GetClusterResponse>(request, options);
        }



        /// <summary>
        /// Returns detailed information about a running cluster in your account. This API action
        /// provides networking information, endpoint information for communication with the scheduler,
        /// and provisioning status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCluster service method, as returned by PCS.</returns>
        /// <exception cref="Amazon.PCS.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The launch template instance profile doesn't pass <c>iam:PassRole</c> verification.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// There is a mismatch between the account ID and cluster ID.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The cluster ID doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The EC2 instance isn't present.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than 1 operation on the same resource at the same time.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A cluster with the same name already exists.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A cluster isn't in <c>ACTIVE</c> status.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A cluster to delete is in an unstable state. For example, because it still has <c>ACTIVE</c>
        /// node groups or queues.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A queue already exists in a cluster.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.InternalServerException">
        /// PCS can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ResourceNotFoundException">
        /// The requested resource can't be found. The cluster, node group, or queue you're attempting
        /// to get, update, list, or delete doesn't exist.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ThrottlingException">
        /// Your request exceeded a request rate quota. Check the resource's request rate quota
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ValidationException">
        /// The request isn't valid.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Your request contains malformed JSON or unsupported characters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The scheduler version isn't supported.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// There are networking related errors, such as network validation failure.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// AMI type is <c>CUSTOM</c> and the launch template doesn't define the AMI ID, or the
        /// AMI type is AL2 and the launch template defines the AMI.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pcs-2023-02-10/GetCluster">REST API Reference for GetCluster Operation</seealso>
        public virtual Task<GetClusterResponse> GetClusterAsync(GetClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetClusterResponseUnmarshaller.Instance;

            return InvokeAsync<GetClusterResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetComputeNodeGroup

        internal virtual GetComputeNodeGroupResponse GetComputeNodeGroup(GetComputeNodeGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetComputeNodeGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetComputeNodeGroupResponseUnmarshaller.Instance;

            return Invoke<GetComputeNodeGroupResponse>(request, options);
        }



        /// <summary>
        /// Returns detailed information about a compute node group. This API action provides
        /// networking information, EC2 instance type, compute node group status, and scheduler
        /// (such as Slurm) configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetComputeNodeGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetComputeNodeGroup service method, as returned by PCS.</returns>
        /// <exception cref="Amazon.PCS.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The launch template instance profile doesn't pass <c>iam:PassRole</c> verification.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// There is a mismatch between the account ID and cluster ID.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The cluster ID doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The EC2 instance isn't present.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than 1 operation on the same resource at the same time.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A cluster with the same name already exists.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A cluster isn't in <c>ACTIVE</c> status.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A cluster to delete is in an unstable state. For example, because it still has <c>ACTIVE</c>
        /// node groups or queues.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A queue already exists in a cluster.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.InternalServerException">
        /// PCS can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ResourceNotFoundException">
        /// The requested resource can't be found. The cluster, node group, or queue you're attempting
        /// to get, update, list, or delete doesn't exist.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ThrottlingException">
        /// Your request exceeded a request rate quota. Check the resource's request rate quota
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ValidationException">
        /// The request isn't valid.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Your request contains malformed JSON or unsupported characters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The scheduler version isn't supported.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// There are networking related errors, such as network validation failure.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// AMI type is <c>CUSTOM</c> and the launch template doesn't define the AMI ID, or the
        /// AMI type is AL2 and the launch template defines the AMI.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pcs-2023-02-10/GetComputeNodeGroup">REST API Reference for GetComputeNodeGroup Operation</seealso>
        public virtual Task<GetComputeNodeGroupResponse> GetComputeNodeGroupAsync(GetComputeNodeGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetComputeNodeGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetComputeNodeGroupResponseUnmarshaller.Instance;

            return InvokeAsync<GetComputeNodeGroupResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetQueue

        internal virtual GetQueueResponse GetQueue(GetQueueRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetQueueRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetQueueResponseUnmarshaller.Instance;

            return Invoke<GetQueueResponse>(request, options);
        }



        /// <summary>
        /// Returns detailed information about a queue. The information includes the compute node
        /// groups that the queue uses to schedule jobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetQueue service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetQueue service method, as returned by PCS.</returns>
        /// <exception cref="Amazon.PCS.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The launch template instance profile doesn't pass <c>iam:PassRole</c> verification.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// There is a mismatch between the account ID and cluster ID.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The cluster ID doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The EC2 instance isn't present.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than 1 operation on the same resource at the same time.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A cluster with the same name already exists.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A cluster isn't in <c>ACTIVE</c> status.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A cluster to delete is in an unstable state. For example, because it still has <c>ACTIVE</c>
        /// node groups or queues.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A queue already exists in a cluster.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.InternalServerException">
        /// PCS can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ResourceNotFoundException">
        /// The requested resource can't be found. The cluster, node group, or queue you're attempting
        /// to get, update, list, or delete doesn't exist.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ThrottlingException">
        /// Your request exceeded a request rate quota. Check the resource's request rate quota
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ValidationException">
        /// The request isn't valid.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Your request contains malformed JSON or unsupported characters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The scheduler version isn't supported.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// There are networking related errors, such as network validation failure.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// AMI type is <c>CUSTOM</c> and the launch template doesn't define the AMI ID, or the
        /// AMI type is AL2 and the launch template defines the AMI.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pcs-2023-02-10/GetQueue">REST API Reference for GetQueue Operation</seealso>
        public virtual Task<GetQueueResponse> GetQueueAsync(GetQueueRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetQueueRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetQueueResponseUnmarshaller.Instance;

            return InvokeAsync<GetQueueResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListClusters

        internal virtual ListClustersResponse ListClusters(ListClustersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListClustersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListClustersResponseUnmarshaller.Instance;

            return Invoke<ListClustersResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of running clusters in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListClusters service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListClusters service method, as returned by PCS.</returns>
        /// <exception cref="Amazon.PCS.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The launch template instance profile doesn't pass <c>iam:PassRole</c> verification.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// There is a mismatch between the account ID and cluster ID.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The cluster ID doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The EC2 instance isn't present.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than 1 operation on the same resource at the same time.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A cluster with the same name already exists.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A cluster isn't in <c>ACTIVE</c> status.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A cluster to delete is in an unstable state. For example, because it still has <c>ACTIVE</c>
        /// node groups or queues.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A queue already exists in a cluster.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.InternalServerException">
        /// PCS can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ResourceNotFoundException">
        /// The requested resource can't be found. The cluster, node group, or queue you're attempting
        /// to get, update, list, or delete doesn't exist.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ThrottlingException">
        /// Your request exceeded a request rate quota. Check the resource's request rate quota
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ValidationException">
        /// The request isn't valid.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Your request contains malformed JSON or unsupported characters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The scheduler version isn't supported.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// There are networking related errors, such as network validation failure.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// AMI type is <c>CUSTOM</c> and the launch template doesn't define the AMI ID, or the
        /// AMI type is AL2 and the launch template defines the AMI.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pcs-2023-02-10/ListClusters">REST API Reference for ListClusters Operation</seealso>
        public virtual Task<ListClustersResponse> ListClustersAsync(ListClustersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListClustersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListClustersResponseUnmarshaller.Instance;

            return InvokeAsync<ListClustersResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListComputeNodeGroups

        internal virtual ListComputeNodeGroupsResponse ListComputeNodeGroups(ListComputeNodeGroupsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListComputeNodeGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListComputeNodeGroupsResponseUnmarshaller.Instance;

            return Invoke<ListComputeNodeGroupsResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of all compute node groups associated with a cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListComputeNodeGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListComputeNodeGroups service method, as returned by PCS.</returns>
        /// <exception cref="Amazon.PCS.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The launch template instance profile doesn't pass <c>iam:PassRole</c> verification.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// There is a mismatch between the account ID and cluster ID.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The cluster ID doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The EC2 instance isn't present.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than 1 operation on the same resource at the same time.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A cluster with the same name already exists.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A cluster isn't in <c>ACTIVE</c> status.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A cluster to delete is in an unstable state. For example, because it still has <c>ACTIVE</c>
        /// node groups or queues.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A queue already exists in a cluster.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.InternalServerException">
        /// PCS can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ResourceNotFoundException">
        /// The requested resource can't be found. The cluster, node group, or queue you're attempting
        /// to get, update, list, or delete doesn't exist.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ThrottlingException">
        /// Your request exceeded a request rate quota. Check the resource's request rate quota
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ValidationException">
        /// The request isn't valid.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Your request contains malformed JSON or unsupported characters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The scheduler version isn't supported.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// There are networking related errors, such as network validation failure.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// AMI type is <c>CUSTOM</c> and the launch template doesn't define the AMI ID, or the
        /// AMI type is AL2 and the launch template defines the AMI.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pcs-2023-02-10/ListComputeNodeGroups">REST API Reference for ListComputeNodeGroups Operation</seealso>
        public virtual Task<ListComputeNodeGroupsResponse> ListComputeNodeGroupsAsync(ListComputeNodeGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListComputeNodeGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListComputeNodeGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<ListComputeNodeGroupsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListQueues

        internal virtual ListQueuesResponse ListQueues(ListQueuesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListQueuesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListQueuesResponseUnmarshaller.Instance;

            return Invoke<ListQueuesResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of all queues associated with a cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListQueues service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListQueues service method, as returned by PCS.</returns>
        /// <exception cref="Amazon.PCS.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The launch template instance profile doesn't pass <c>iam:PassRole</c> verification.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// There is a mismatch between the account ID and cluster ID.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The cluster ID doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The EC2 instance isn't present.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than 1 operation on the same resource at the same time.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A cluster with the same name already exists.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A cluster isn't in <c>ACTIVE</c> status.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A cluster to delete is in an unstable state. For example, because it still has <c>ACTIVE</c>
        /// node groups or queues.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A queue already exists in a cluster.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.InternalServerException">
        /// PCS can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ResourceNotFoundException">
        /// The requested resource can't be found. The cluster, node group, or queue you're attempting
        /// to get, update, list, or delete doesn't exist.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ThrottlingException">
        /// Your request exceeded a request rate quota. Check the resource's request rate quota
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ValidationException">
        /// The request isn't valid.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Your request contains malformed JSON or unsupported characters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The scheduler version isn't supported.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// There are networking related errors, such as network validation failure.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// AMI type is <c>CUSTOM</c> and the launch template doesn't define the AMI ID, or the
        /// AMI type is AL2 and the launch template defines the AMI.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pcs-2023-02-10/ListQueues">REST API Reference for ListQueues Operation</seealso>
        public virtual Task<ListQueuesResponse> ListQueuesAsync(ListQueuesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListQueuesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListQueuesResponseUnmarshaller.Instance;

            return InvokeAsync<ListQueuesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListTagsForResource

        internal virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of all tags on an PCS resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by PCS.</returns>
        /// <exception cref="Amazon.PCS.Model.ResourceNotFoundException">
        /// The requested resource can't be found. The cluster, node group, or queue you're attempting
        /// to get, update, list, or delete doesn't exist.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pcs-2023-02-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  RegisterComputeNodeGroupInstance

        internal virtual RegisterComputeNodeGroupInstanceResponse RegisterComputeNodeGroupInstance(RegisterComputeNodeGroupInstanceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RegisterComputeNodeGroupInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterComputeNodeGroupInstanceResponseUnmarshaller.Instance;

            return Invoke<RegisterComputeNodeGroupInstanceResponse>(request, options);
        }



        /// <summary>
        /// <important> 
        /// <para>
        /// This API action isn't intended for you to use.
        /// 
        ///  </important> 
        /// <para>
        /// PCS uses this API action to register the compute nodes it launches in your account.
        /// </para>
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterComputeNodeGroupInstance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RegisterComputeNodeGroupInstance service method, as returned by PCS.</returns>
        /// <exception cref="Amazon.PCS.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The launch template instance profile doesn't pass <c>iam:PassRole</c> verification.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// There is a mismatch between the account ID and cluster ID.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The cluster ID doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The EC2 instance isn't present.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.InternalServerException">
        /// PCS can't process your request right now. Try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pcs-2023-02-10/RegisterComputeNodeGroupInstance">REST API Reference for RegisterComputeNodeGroupInstance Operation</seealso>
        public virtual Task<RegisterComputeNodeGroupInstanceResponse> RegisterComputeNodeGroupInstanceAsync(RegisterComputeNodeGroupInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RegisterComputeNodeGroupInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterComputeNodeGroupInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<RegisterComputeNodeGroupInstanceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  TagResource

        internal virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }



        /// <summary>
        /// Adds or edits tags on an PCS resource. Each tag consists of a tag key and a tag value.
        /// The tag key and tag value are case-sensitive strings. The tag value can be an empty
        /// (null) string. To add a tag, specify a new tag key and a tag value. To edit a tag,
        /// specify an existing tag key and a new tag value.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by PCS.</returns>
        /// <exception cref="Amazon.PCS.Model.ResourceNotFoundException">
        /// The requested resource can't be found. The cluster, node group, or queue you're attempting
        /// to get, update, list, or delete doesn't exist.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ServiceQuotaExceededException">
        /// You exceeded your service quota. Service quotas, also referred to as limits, are the
        /// maximum number of service resources or operations for your Amazon Web Services account.
        /// To learn how to increase your service quota, see <a href="https://docs.aws.amazon.com/servicequotas/latest/userguide/request-quota-increase.html">Requesting
        /// a quota increase</a> in the <i>Service Quotas User Guide</i> 
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The max number of clusters or queues has been reached for the account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The max number of compute node groups has been reached for the associated cluster.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The total of <c>maxInstances</c> across all compute node groups has been reached for
        /// associated cluster.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pcs-2023-02-10/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UntagResource

        internal virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }



        /// <summary>
        /// Deletes tags from an PCS resource. To delete a tag, specify the tag key and the Amazon
        /// Resource Name (ARN) of the PCS resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by PCS.</returns>
        /// <exception cref="Amazon.PCS.Model.ResourceNotFoundException">
        /// The requested resource can't be found. The cluster, node group, or queue you're attempting
        /// to get, update, list, or delete doesn't exist.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pcs-2023-02-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateComputeNodeGroup

        internal virtual UpdateComputeNodeGroupResponse UpdateComputeNodeGroup(UpdateComputeNodeGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateComputeNodeGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateComputeNodeGroupResponseUnmarshaller.Instance;

            return Invoke<UpdateComputeNodeGroupResponse>(request, options);
        }



        /// <summary>
        /// Updates a compute node group. You can update many of the fields related to your compute
        /// node group including the configurations for networking, compute nodes, and settings
        /// specific to your scheduler (such as Slurm).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateComputeNodeGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateComputeNodeGroup service method, as returned by PCS.</returns>
        /// <exception cref="Amazon.PCS.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The launch template instance profile doesn't pass <c>iam:PassRole</c> verification.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// There is a mismatch between the account ID and cluster ID.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The cluster ID doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The EC2 instance isn't present.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than 1 operation on the same resource at the same time.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A cluster with the same name already exists.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A cluster isn't in <c>ACTIVE</c> status.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A cluster to delete is in an unstable state. For example, because it still has <c>ACTIVE</c>
        /// node groups or queues.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A queue already exists in a cluster.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.InternalServerException">
        /// PCS can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ResourceNotFoundException">
        /// The requested resource can't be found. The cluster, node group, or queue you're attempting
        /// to get, update, list, or delete doesn't exist.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ServiceQuotaExceededException">
        /// You exceeded your service quota. Service quotas, also referred to as limits, are the
        /// maximum number of service resources or operations for your Amazon Web Services account.
        /// To learn how to increase your service quota, see <a href="https://docs.aws.amazon.com/servicequotas/latest/userguide/request-quota-increase.html">Requesting
        /// a quota increase</a> in the <i>Service Quotas User Guide</i> 
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The max number of clusters or queues has been reached for the account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The max number of compute node groups has been reached for the associated cluster.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The total of <c>maxInstances</c> across all compute node groups has been reached for
        /// associated cluster.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ThrottlingException">
        /// Your request exceeded a request rate quota. Check the resource's request rate quota
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ValidationException">
        /// The request isn't valid.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Your request contains malformed JSON or unsupported characters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The scheduler version isn't supported.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// There are networking related errors, such as network validation failure.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// AMI type is <c>CUSTOM</c> and the launch template doesn't define the AMI ID, or the
        /// AMI type is AL2 and the launch template defines the AMI.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pcs-2023-02-10/UpdateComputeNodeGroup">REST API Reference for UpdateComputeNodeGroup Operation</seealso>
        public virtual Task<UpdateComputeNodeGroupResponse> UpdateComputeNodeGroupAsync(UpdateComputeNodeGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateComputeNodeGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateComputeNodeGroupResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateComputeNodeGroupResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateQueue

        internal virtual UpdateQueueResponse UpdateQueue(UpdateQueueRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateQueueRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateQueueResponseUnmarshaller.Instance;

            return Invoke<UpdateQueueResponse>(request, options);
        }



        /// <summary>
        /// Updates the compute node group configuration of a queue. Use this API to change the
        /// compute node groups that the queue can send jobs to.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateQueue service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateQueue service method, as returned by PCS.</returns>
        /// <exception cref="Amazon.PCS.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The launch template instance profile doesn't pass <c>iam:PassRole</c> verification.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// There is a mismatch between the account ID and cluster ID.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The cluster ID doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The EC2 instance isn't present.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than 1 operation on the same resource at the same time.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A cluster with the same name already exists.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A cluster isn't in <c>ACTIVE</c> status.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A cluster to delete is in an unstable state. For example, because it still has <c>ACTIVE</c>
        /// node groups or queues.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A queue already exists in a cluster.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.InternalServerException">
        /// PCS can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ResourceNotFoundException">
        /// The requested resource can't be found. The cluster, node group, or queue you're attempting
        /// to get, update, list, or delete doesn't exist.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ServiceQuotaExceededException">
        /// You exceeded your service quota. Service quotas, also referred to as limits, are the
        /// maximum number of service resources or operations for your Amazon Web Services account.
        /// To learn how to increase your service quota, see <a href="https://docs.aws.amazon.com/servicequotas/latest/userguide/request-quota-increase.html">Requesting
        /// a quota increase</a> in the <i>Service Quotas User Guide</i> 
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The max number of clusters or queues has been reached for the account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The max number of compute node groups has been reached for the associated cluster.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The total of <c>maxInstances</c> across all compute node groups has been reached for
        /// associated cluster.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ThrottlingException">
        /// Your request exceeded a request rate quota. Check the resource's request rate quota
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ValidationException">
        /// The request isn't valid.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Your request contains malformed JSON or unsupported characters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The scheduler version isn't supported.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// There are networking related errors, such as network validation failure.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// AMI type is <c>CUSTOM</c> and the launch template doesn't define the AMI ID, or the
        /// AMI type is AL2 and the launch template defines the AMI.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pcs-2023-02-10/UpdateQueue">REST API Reference for UpdateQueue Operation</seealso>
        public virtual Task<UpdateQueueResponse> UpdateQueueAsync(UpdateQueueRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateQueueRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateQueueResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateQueueResponse>(request, options, cancellationToken);
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
            var parameters = new ServiceOperationEndpointParameters(request);
            return Config.DetermineServiceOperationEndpoint(parameters);
        }

        #endregion

    }
}