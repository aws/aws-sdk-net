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
 * Do not modify this file. This file is generated from the memorydb-2021-01-01.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.MemoryDB.Model;
using Amazon.MemoryDB.Model.Internal.MarshallTransformations;
using Amazon.MemoryDB.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.MemoryDB
{
    /// <summary>
    /// Implementation for accessing MemoryDB
    ///
    /// MemoryDB for Redis is a fully managed, Redis-compatible, in-memory database that delivers
    /// ultra-fast performance and Multi-AZ durability for modern applications built using
    /// microservices architectures. MemoryDB stores the entire database in-memory, enabling
    /// low latency and high throughput data access. It is compatible with Redis, a popular
    /// open source data store, enabling you to leverage Redis’ flexible and friendly data
    /// structures, APIs, and commands.
    /// </summary>
    public partial class AmazonMemoryDBClient : AmazonServiceClient, IAmazonMemoryDB
    {
        private static IServiceMetadata serviceMetadata = new AmazonMemoryDBMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonMemoryDBClient with the credentials loaded from the application's
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
        public AmazonMemoryDBClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonMemoryDBConfig()) { }

        /// <summary>
        /// Constructs AmazonMemoryDBClient with the credentials loaded from the application's
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
        public AmazonMemoryDBClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonMemoryDBConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonMemoryDBClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonMemoryDBClient Configuration Object</param>
        public AmazonMemoryDBClient(AmazonMemoryDBConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }


        /// <summary>
        /// Constructs AmazonMemoryDBClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonMemoryDBClient(AWSCredentials credentials)
            : this(credentials, new AmazonMemoryDBConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonMemoryDBClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonMemoryDBClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonMemoryDBConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonMemoryDBClient with AWS Credentials and an
        /// AmazonMemoryDBClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonMemoryDBClient Configuration Object</param>
        public AmazonMemoryDBClient(AWSCredentials credentials, AmazonMemoryDBConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonMemoryDBClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonMemoryDBClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonMemoryDBConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonMemoryDBClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonMemoryDBClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonMemoryDBConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonMemoryDBClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonMemoryDBClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonMemoryDBClient Configuration Object</param>
        public AmazonMemoryDBClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonMemoryDBConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonMemoryDBClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonMemoryDBClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonMemoryDBConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonMemoryDBClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonMemoryDBClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonMemoryDBConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonMemoryDBClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonMemoryDBClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonMemoryDBClient Configuration Object</param>
        public AmazonMemoryDBClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonMemoryDBConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private IMemoryDBPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IMemoryDBPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new MemoryDBPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif

        #region Overrides

        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        } 

        /// <summary>
        /// Customizes the runtime pipeline.
        /// </summary>
        /// <param name="pipeline">Runtime pipeline for the current client.</param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonMemoryDBEndpointResolver());
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


        #region  BatchUpdateCluster

        internal virtual BatchUpdateClusterResponse BatchUpdateCluster(BatchUpdateClusterRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchUpdateClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchUpdateClusterResponseUnmarshaller.Instance;

            return Invoke<BatchUpdateClusterResponse>(request, options);
        }



        /// <summary>
        /// Apply the service update to a list of clusters supplied. For more information on service
        /// updates and applying them, see <a href="https://docs.aws.amazon.com/MemoryDB/latest/devguide/managing-updates.html#applying-updates">Applying
        /// the service updates</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchUpdateCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchUpdateCluster service method, as returned by MemoryDB.</returns>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidParameterValueException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.ServiceUpdateNotFoundException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/BatchUpdateCluster">REST API Reference for BatchUpdateCluster Operation</seealso>
        public virtual Task<BatchUpdateClusterResponse> BatchUpdateClusterAsync(BatchUpdateClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchUpdateClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchUpdateClusterResponseUnmarshaller.Instance;

            return InvokeAsync<BatchUpdateClusterResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CopySnapshot

        internal virtual CopySnapshotResponse CopySnapshot(CopySnapshotRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CopySnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CopySnapshotResponseUnmarshaller.Instance;

            return Invoke<CopySnapshotResponse>(request, options);
        }



        /// <summary>
        /// Makes a copy of an existing snapshot.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CopySnapshot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CopySnapshot service method, as returned by MemoryDB.</returns>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidParameterCombinationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidParameterValueException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidSnapshotStateException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.ServiceLinkedRoleNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.SnapshotAlreadyExistsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.SnapshotNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.SnapshotQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.TagQuotaPerResourceExceededException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/CopySnapshot">REST API Reference for CopySnapshot Operation</seealso>
        public virtual Task<CopySnapshotResponse> CopySnapshotAsync(CopySnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CopySnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CopySnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<CopySnapshotResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateACL

        internal virtual CreateACLResponse CreateACL(CreateACLRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateACLRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateACLResponseUnmarshaller.Instance;

            return Invoke<CreateACLResponse>(request, options);
        }



        /// <summary>
        /// Creates an Access Control List. For more information, see <a href="https://docs.aws.amazon.com/MemoryDB/latest/devguide/clusters.acls.html">Authenticating
        /// users with Access Contol Lists (ACLs)</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateACL service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateACL service method, as returned by MemoryDB.</returns>
        /// <exception cref="Amazon.MemoryDB.Model.ACLAlreadyExistsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.ACLQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.DefaultUserRequiredException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.DuplicateUserNameException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidParameterValueException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.TagQuotaPerResourceExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.UserNotFoundException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/CreateACL">REST API Reference for CreateACL Operation</seealso>
        public virtual Task<CreateACLResponse> CreateACLAsync(CreateACLRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateACLRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateACLResponseUnmarshaller.Instance;

            return InvokeAsync<CreateACLResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateCluster

        internal virtual CreateClusterResponse CreateCluster(CreateClusterRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateClusterResponseUnmarshaller.Instance;

            return Invoke<CreateClusterResponse>(request, options);
        }



        /// <summary>
        /// Creates a cluster. All nodes in the cluster run the same protocol-compliant engine
        /// software.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateCluster service method, as returned by MemoryDB.</returns>
        /// <exception cref="Amazon.MemoryDB.Model.ACLNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.ClusterAlreadyExistsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.ClusterQuotaForCustomerExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.InsufficientClusterCapacityException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidACLStateException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidCredentialsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidParameterCombinationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidParameterValueException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidVPCNetworkStateException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.NodeQuotaForClusterExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.NodeQuotaForCustomerExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.ParameterGroupNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.ServiceLinkedRoleNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.ShardsPerClusterQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.SubnetGroupNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.TagQuotaPerResourceExceededException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/CreateCluster">REST API Reference for CreateCluster Operation</seealso>
        public virtual Task<CreateClusterResponse> CreateClusterAsync(CreateClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateClusterResponseUnmarshaller.Instance;

            return InvokeAsync<CreateClusterResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateParameterGroup

        internal virtual CreateParameterGroupResponse CreateParameterGroup(CreateParameterGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateParameterGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateParameterGroupResponseUnmarshaller.Instance;

            return Invoke<CreateParameterGroupResponse>(request, options);
        }



        /// <summary>
        /// Creates a new MemoryDB parameter group. A parameter group is a collection of parameters
        /// and their values that are applied to all of the nodes in any cluster. For more information,
        /// see <a href="https://docs.aws.amazon.com/MemoryDB/latest/devguide/parametergroups.html">Configuring
        /// engine parameters using parameter groups</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateParameterGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateParameterGroup service method, as returned by MemoryDB.</returns>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidParameterCombinationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidParameterGroupStateException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidParameterValueException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.ParameterGroupAlreadyExistsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.ParameterGroupQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.ServiceLinkedRoleNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.TagQuotaPerResourceExceededException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/CreateParameterGroup">REST API Reference for CreateParameterGroup Operation</seealso>
        public virtual Task<CreateParameterGroupResponse> CreateParameterGroupAsync(CreateParameterGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateParameterGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateParameterGroupResponseUnmarshaller.Instance;

            return InvokeAsync<CreateParameterGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateSnapshot

        internal virtual CreateSnapshotResponse CreateSnapshot(CreateSnapshotRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSnapshotResponseUnmarshaller.Instance;

            return Invoke<CreateSnapshotResponse>(request, options);
        }



        /// <summary>
        /// Creates a copy of an entire cluster at a specific moment in time.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSnapshot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSnapshot service method, as returned by MemoryDB.</returns>
        /// <exception cref="Amazon.MemoryDB.Model.ClusterNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidClusterStateException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidParameterCombinationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidParameterValueException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.ServiceLinkedRoleNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.SnapshotAlreadyExistsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.SnapshotQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.TagQuotaPerResourceExceededException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/CreateSnapshot">REST API Reference for CreateSnapshot Operation</seealso>
        public virtual Task<CreateSnapshotResponse> CreateSnapshotAsync(CreateSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<CreateSnapshotResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateSubnetGroup

        internal virtual CreateSubnetGroupResponse CreateSubnetGroup(CreateSubnetGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSubnetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSubnetGroupResponseUnmarshaller.Instance;

            return Invoke<CreateSubnetGroupResponse>(request, options);
        }



        /// <summary>
        /// Creates a subnet group. A subnet group is a collection of subnets (typically private)
        /// that you can designate for your clusters running in an Amazon Virtual Private Cloud
        /// (VPC) environment. When you create a cluster in an Amazon VPC, you must specify a
        /// subnet group. MemoryDB uses that subnet group to choose a subnet and IP addresses
        /// within that subnet to associate with your nodes. For more information, see <a href="https://docs.aws.amazon.com/MemoryDB/latest/devguide/subnetgroups.html">Subnets
        /// and subnet groups</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSubnetGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSubnetGroup service method, as returned by MemoryDB.</returns>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidSubnetException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.ServiceLinkedRoleNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.SubnetGroupAlreadyExistsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.SubnetGroupQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.SubnetNotAllowedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.SubnetQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.TagQuotaPerResourceExceededException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/CreateSubnetGroup">REST API Reference for CreateSubnetGroup Operation</seealso>
        public virtual Task<CreateSubnetGroupResponse> CreateSubnetGroupAsync(CreateSubnetGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSubnetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSubnetGroupResponseUnmarshaller.Instance;

            return InvokeAsync<CreateSubnetGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateUser

        internal virtual CreateUserResponse CreateUser(CreateUserRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateUserResponseUnmarshaller.Instance;

            return Invoke<CreateUserResponse>(request, options);
        }



        /// <summary>
        /// Creates a MemoryDB user. For more information, see <a href="https://docs.aws.amazon.com/MemoryDB/latest/devguide/clusters.acls.html">Authenticating
        /// users with Access Contol Lists (ACLs)</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateUser service method, as returned by MemoryDB.</returns>
        /// <exception cref="Amazon.MemoryDB.Model.DuplicateUserNameException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidParameterCombinationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidParameterValueException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.TagQuotaPerResourceExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.UserAlreadyExistsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.UserQuotaExceededException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/CreateUser">REST API Reference for CreateUser Operation</seealso>
        public virtual Task<CreateUserResponse> CreateUserAsync(CreateUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateUserResponseUnmarshaller.Instance;

            return InvokeAsync<CreateUserResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteACL

        internal virtual DeleteACLResponse DeleteACL(DeleteACLRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteACLRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteACLResponseUnmarshaller.Instance;

            return Invoke<DeleteACLResponse>(request, options);
        }



        /// <summary>
        /// Deletes an Access Control List. The ACL must first be disassociated from the cluster
        /// before it can be deleted. For more information, see <a href="https://docs.aws.amazon.com/MemoryDB/latest/devguide/clusters.acls.html">Authenticating
        /// users with Access Contol Lists (ACLs)</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteACL service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteACL service method, as returned by MemoryDB.</returns>
        /// <exception cref="Amazon.MemoryDB.Model.ACLNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidACLStateException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidParameterValueException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/DeleteACL">REST API Reference for DeleteACL Operation</seealso>
        public virtual Task<DeleteACLResponse> DeleteACLAsync(DeleteACLRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteACLRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteACLResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteACLResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteCluster

        internal virtual DeleteClusterResponse DeleteCluster(DeleteClusterRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteClusterResponseUnmarshaller.Instance;

            return Invoke<DeleteClusterResponse>(request, options);
        }



        /// <summary>
        /// Deletes a cluster. It also deletes all associated nodes and node endpoints
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteCluster service method, as returned by MemoryDB.</returns>
        /// <exception cref="Amazon.MemoryDB.Model.ClusterNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidClusterStateException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidParameterCombinationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidParameterValueException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.ServiceLinkedRoleNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.SnapshotAlreadyExistsException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/DeleteCluster">REST API Reference for DeleteCluster Operation</seealso>
        public virtual Task<DeleteClusterResponse> DeleteClusterAsync(DeleteClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteClusterResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteClusterResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteParameterGroup

        internal virtual DeleteParameterGroupResponse DeleteParameterGroup(DeleteParameterGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteParameterGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteParameterGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteParameterGroupResponse>(request, options);
        }



        /// <summary>
        /// Deletes the specified parameter group. You cannot delete a parameter group if it is
        /// associated with any clusters. You cannot delete the default parameter groups in your
        /// account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteParameterGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteParameterGroup service method, as returned by MemoryDB.</returns>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidParameterCombinationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidParameterGroupStateException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidParameterValueException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.ParameterGroupNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.ServiceLinkedRoleNotFoundException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/DeleteParameterGroup">REST API Reference for DeleteParameterGroup Operation</seealso>
        public virtual Task<DeleteParameterGroupResponse> DeleteParameterGroupAsync(DeleteParameterGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteParameterGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteParameterGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteParameterGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteSnapshot

        internal virtual DeleteSnapshotResponse DeleteSnapshot(DeleteSnapshotRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSnapshotResponseUnmarshaller.Instance;

            return Invoke<DeleteSnapshotResponse>(request, options);
        }



        /// <summary>
        /// Deletes an existing snapshot. When you receive a successful response from this operation,
        /// MemoryDB immediately begins deleting the snapshot; you cannot cancel or revert this
        /// operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSnapshot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSnapshot service method, as returned by MemoryDB.</returns>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidParameterCombinationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidParameterValueException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidSnapshotStateException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.ServiceLinkedRoleNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.SnapshotNotFoundException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/DeleteSnapshot">REST API Reference for DeleteSnapshot Operation</seealso>
        public virtual Task<DeleteSnapshotResponse> DeleteSnapshotAsync(DeleteSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteSnapshotResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteSubnetGroup

        internal virtual DeleteSubnetGroupResponse DeleteSubnetGroup(DeleteSubnetGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSubnetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSubnetGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteSubnetGroupResponse>(request, options);
        }



        /// <summary>
        /// Deletes a subnet group. You cannot delete a default subnet group or one that is associated
        /// with any clusters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSubnetGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSubnetGroup service method, as returned by MemoryDB.</returns>
        /// <exception cref="Amazon.MemoryDB.Model.ServiceLinkedRoleNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.SubnetGroupInUseException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.SubnetGroupNotFoundException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/DeleteSubnetGroup">REST API Reference for DeleteSubnetGroup Operation</seealso>
        public virtual Task<DeleteSubnetGroupResponse> DeleteSubnetGroupAsync(DeleteSubnetGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSubnetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSubnetGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteSubnetGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteUser

        internal virtual DeleteUserResponse DeleteUser(DeleteUserRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteUserResponseUnmarshaller.Instance;

            return Invoke<DeleteUserResponse>(request, options);
        }



        /// <summary>
        /// Deletes a user. The user will be removed from all ACLs and in turn removed from all
        /// clusters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteUser service method, as returned by MemoryDB.</returns>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidParameterValueException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidUserStateException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.UserNotFoundException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/DeleteUser">REST API Reference for DeleteUser Operation</seealso>
        public virtual Task<DeleteUserResponse> DeleteUserAsync(DeleteUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteUserResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteUserResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeACLs

        internal virtual DescribeACLsResponse DescribeACLs(DescribeACLsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeACLsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeACLsResponseUnmarshaller.Instance;

            return Invoke<DescribeACLsResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of ACLs
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeACLs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeACLs service method, as returned by MemoryDB.</returns>
        /// <exception cref="Amazon.MemoryDB.Model.ACLNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidParameterCombinationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/DescribeACLs">REST API Reference for DescribeACLs Operation</seealso>
        public virtual Task<DescribeACLsResponse> DescribeACLsAsync(DescribeACLsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeACLsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeACLsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeACLsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeClusters

        internal virtual DescribeClustersResponse DescribeClusters(DescribeClustersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeClustersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeClustersResponseUnmarshaller.Instance;

            return Invoke<DescribeClustersResponse>(request, options);
        }



        /// <summary>
        /// Returns information about all provisioned clusters if no cluster identifier is specified,
        /// or about a specific cluster if a cluster name is supplied.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusters service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeClusters service method, as returned by MemoryDB.</returns>
        /// <exception cref="Amazon.MemoryDB.Model.ClusterNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidParameterCombinationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidParameterValueException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.ServiceLinkedRoleNotFoundException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/DescribeClusters">REST API Reference for DescribeClusters Operation</seealso>
        public virtual Task<DescribeClustersResponse> DescribeClustersAsync(DescribeClustersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeClustersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeClustersResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeClustersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeEngineVersions

        internal virtual DescribeEngineVersionsResponse DescribeEngineVersions(DescribeEngineVersionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEngineVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEngineVersionsResponseUnmarshaller.Instance;

            return Invoke<DescribeEngineVersionsResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of the available Redis engine versions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEngineVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeEngineVersions service method, as returned by MemoryDB.</returns>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidParameterCombinationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidParameterValueException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.ServiceLinkedRoleNotFoundException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/DescribeEngineVersions">REST API Reference for DescribeEngineVersions Operation</seealso>
        public virtual Task<DescribeEngineVersionsResponse> DescribeEngineVersionsAsync(DescribeEngineVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEngineVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEngineVersionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeEngineVersionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeEvents

        internal virtual DescribeEventsResponse DescribeEvents(DescribeEventsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEventsResponseUnmarshaller.Instance;

            return Invoke<DescribeEventsResponse>(request, options);
        }



        /// <summary>
        /// Returns events related to clusters, security groups, and parameter groups. You can
        /// obtain events specific to a particular cluster, security group, or parameter group
        /// by providing the name as a parameter. By default, only the events occurring within
        /// the last hour are returned; however, you can retrieve up to 14 days' worth of events
        /// if necessary.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEvents service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeEvents service method, as returned by MemoryDB.</returns>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidParameterCombinationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidParameterValueException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.ServiceLinkedRoleNotFoundException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/DescribeEvents">REST API Reference for DescribeEvents Operation</seealso>
        public virtual Task<DescribeEventsResponse> DescribeEventsAsync(DescribeEventsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEventsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeEventsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeParameterGroups

        internal virtual DescribeParameterGroupsResponse DescribeParameterGroups(DescribeParameterGroupsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeParameterGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeParameterGroupsResponseUnmarshaller.Instance;

            return Invoke<DescribeParameterGroupsResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of parameter group descriptions. If a parameter group name is specified,
        /// the list contains only the descriptions for that group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeParameterGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeParameterGroups service method, as returned by MemoryDB.</returns>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidParameterCombinationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidParameterValueException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.ParameterGroupNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.ServiceLinkedRoleNotFoundException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/DescribeParameterGroups">REST API Reference for DescribeParameterGroups Operation</seealso>
        public virtual Task<DescribeParameterGroupsResponse> DescribeParameterGroupsAsync(DescribeParameterGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeParameterGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeParameterGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeParameterGroupsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeParameters

        internal virtual DescribeParametersResponse DescribeParameters(DescribeParametersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeParametersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeParametersResponseUnmarshaller.Instance;

            return Invoke<DescribeParametersResponse>(request, options);
        }



        /// <summary>
        /// Returns the detailed parameter list for a particular parameter group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeParameters service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeParameters service method, as returned by MemoryDB.</returns>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidParameterCombinationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidParameterValueException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.ParameterGroupNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.ServiceLinkedRoleNotFoundException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/DescribeParameters">REST API Reference for DescribeParameters Operation</seealso>
        public virtual Task<DescribeParametersResponse> DescribeParametersAsync(DescribeParametersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeParametersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeParametersResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeParametersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeReservedNodes

        internal virtual DescribeReservedNodesResponse DescribeReservedNodes(DescribeReservedNodesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeReservedNodesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReservedNodesResponseUnmarshaller.Instance;

            return Invoke<DescribeReservedNodesResponse>(request, options);
        }



        /// <summary>
        /// Returns information about reserved nodes for this account, or about a specified reserved
        /// node.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedNodes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeReservedNodes service method, as returned by MemoryDB.</returns>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidParameterCombinationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidParameterValueException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.ReservedNodeNotFoundException">
        /// The requested node does not exist.
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.ServiceLinkedRoleNotFoundException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/DescribeReservedNodes">REST API Reference for DescribeReservedNodes Operation</seealso>
        public virtual Task<DescribeReservedNodesResponse> DescribeReservedNodesAsync(DescribeReservedNodesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeReservedNodesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReservedNodesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeReservedNodesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeReservedNodesOfferings

        internal virtual DescribeReservedNodesOfferingsResponse DescribeReservedNodesOfferings(DescribeReservedNodesOfferingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeReservedNodesOfferingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReservedNodesOfferingsResponseUnmarshaller.Instance;

            return Invoke<DescribeReservedNodesOfferingsResponse>(request, options);
        }



        /// <summary>
        /// Lists available reserved node offerings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedNodesOfferings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeReservedNodesOfferings service method, as returned by MemoryDB.</returns>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidParameterCombinationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidParameterValueException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.ReservedNodesOfferingNotFoundException">
        /// The requested node offering does not exist.
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.ServiceLinkedRoleNotFoundException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/DescribeReservedNodesOfferings">REST API Reference for DescribeReservedNodesOfferings Operation</seealso>
        public virtual Task<DescribeReservedNodesOfferingsResponse> DescribeReservedNodesOfferingsAsync(DescribeReservedNodesOfferingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeReservedNodesOfferingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReservedNodesOfferingsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeReservedNodesOfferingsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeServiceUpdates

        internal virtual DescribeServiceUpdatesResponse DescribeServiceUpdates(DescribeServiceUpdatesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeServiceUpdatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeServiceUpdatesResponseUnmarshaller.Instance;

            return Invoke<DescribeServiceUpdatesResponse>(request, options);
        }



        /// <summary>
        /// Returns details of the service updates
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeServiceUpdates service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeServiceUpdates service method, as returned by MemoryDB.</returns>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidParameterCombinationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidParameterValueException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/DescribeServiceUpdates">REST API Reference for DescribeServiceUpdates Operation</seealso>
        public virtual Task<DescribeServiceUpdatesResponse> DescribeServiceUpdatesAsync(DescribeServiceUpdatesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeServiceUpdatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeServiceUpdatesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeServiceUpdatesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeSnapshots

        internal virtual DescribeSnapshotsResponse DescribeSnapshots(DescribeSnapshotsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSnapshotsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSnapshotsResponseUnmarshaller.Instance;

            return Invoke<DescribeSnapshotsResponse>(request, options);
        }



        /// <summary>
        /// Returns information about cluster snapshots. By default, DescribeSnapshots lists all
        /// of your snapshots; it can optionally describe a single snapshot, or just the snapshots
        /// associated with a particular cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSnapshots service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeSnapshots service method, as returned by MemoryDB.</returns>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidParameterCombinationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidParameterValueException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.ServiceLinkedRoleNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.SnapshotNotFoundException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/DescribeSnapshots">REST API Reference for DescribeSnapshots Operation</seealso>
        public virtual Task<DescribeSnapshotsResponse> DescribeSnapshotsAsync(DescribeSnapshotsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSnapshotsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSnapshotsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeSnapshotsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeSubnetGroups

        internal virtual DescribeSubnetGroupsResponse DescribeSubnetGroups(DescribeSubnetGroupsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSubnetGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSubnetGroupsResponseUnmarshaller.Instance;

            return Invoke<DescribeSubnetGroupsResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of subnet group descriptions. If a subnet group name is specified,
        /// the list contains only the description of that group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSubnetGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeSubnetGroups service method, as returned by MemoryDB.</returns>
        /// <exception cref="Amazon.MemoryDB.Model.ServiceLinkedRoleNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.SubnetGroupNotFoundException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/DescribeSubnetGroups">REST API Reference for DescribeSubnetGroups Operation</seealso>
        public virtual Task<DescribeSubnetGroupsResponse> DescribeSubnetGroupsAsync(DescribeSubnetGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSubnetGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSubnetGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeSubnetGroupsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeUsers

        internal virtual DescribeUsersResponse DescribeUsers(DescribeUsersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeUsersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeUsersResponseUnmarshaller.Instance;

            return Invoke<DescribeUsersResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of users.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeUsers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeUsers service method, as returned by MemoryDB.</returns>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidParameterCombinationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.UserNotFoundException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/DescribeUsers">REST API Reference for DescribeUsers Operation</seealso>
        public virtual Task<DescribeUsersResponse> DescribeUsersAsync(DescribeUsersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeUsersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeUsersResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeUsersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  FailoverShard

        internal virtual FailoverShardResponse FailoverShard(FailoverShardRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = FailoverShardRequestMarshaller.Instance;
            options.ResponseUnmarshaller = FailoverShardResponseUnmarshaller.Instance;

            return Invoke<FailoverShardResponse>(request, options);
        }



        /// <summary>
        /// Used to failover a shard. This API is designed for testing the behavior of your application
        /// in case of MemoryDB failover. It is not designed to be used as a production-level
        /// tool for initiating a failover to overcome a problem you may have with the cluster.
        /// Moreover, in certain conditions such as large scale operational events, Amazon may
        /// block this API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the FailoverShard service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the FailoverShard service method, as returned by MemoryDB.</returns>
        /// <exception cref="Amazon.MemoryDB.Model.APICallRateForCustomerExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.ClusterNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidClusterStateException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidKMSKeyException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidParameterCombinationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidParameterValueException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.ShardNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.TestFailoverNotAvailableException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/FailoverShard">REST API Reference for FailoverShard Operation</seealso>
        public virtual Task<FailoverShardResponse> FailoverShardAsync(FailoverShardRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = FailoverShardRequestMarshaller.Instance;
            options.ResponseUnmarshaller = FailoverShardResponseUnmarshaller.Instance;

            return InvokeAsync<FailoverShardResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListAllowedNodeTypeUpdates

        internal virtual ListAllowedNodeTypeUpdatesResponse ListAllowedNodeTypeUpdates(ListAllowedNodeTypeUpdatesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAllowedNodeTypeUpdatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAllowedNodeTypeUpdatesResponseUnmarshaller.Instance;

            return Invoke<ListAllowedNodeTypeUpdatesResponse>(request, options);
        }



        /// <summary>
        /// Lists all available node types that you can scale to from your cluster's current node
        /// type. When you use the UpdateCluster operation to scale your cluster, the value of
        /// the NodeType parameter must be one of the node types returned by this operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAllowedNodeTypeUpdates service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAllowedNodeTypeUpdates service method, as returned by MemoryDB.</returns>
        /// <exception cref="Amazon.MemoryDB.Model.ClusterNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidParameterCombinationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidParameterValueException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.ServiceLinkedRoleNotFoundException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/ListAllowedNodeTypeUpdates">REST API Reference for ListAllowedNodeTypeUpdates Operation</seealso>
        public virtual Task<ListAllowedNodeTypeUpdatesResponse> ListAllowedNodeTypeUpdatesAsync(ListAllowedNodeTypeUpdatesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAllowedNodeTypeUpdatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAllowedNodeTypeUpdatesResponseUnmarshaller.Instance;

            return InvokeAsync<ListAllowedNodeTypeUpdatesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTags

        internal virtual ListTagsResponse ListTags(ListTagsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsResponseUnmarshaller.Instance;

            return Invoke<ListTagsResponse>(request, options);
        }



        /// <summary>
        /// Lists all tags currently on a named resource. A tag is a key-value pair where the
        /// key and value are case-sensitive. You can use tags to categorize and track your MemoryDB
        /// resources. For more information, see <a href="https://docs.aws.amazon.com/MemoryDB/latest/devguide/Tagging-Resources.html">Tagging
        /// your MemoryDB resources</a>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTags service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTags service method, as returned by MemoryDB.</returns>
        /// <exception cref="Amazon.MemoryDB.Model.ACLNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.ClusterNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidARNException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidClusterStateException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.ParameterGroupNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.ServiceLinkedRoleNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.SnapshotNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.SubnetGroupNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.UserNotFoundException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/ListTags">REST API Reference for ListTags Operation</seealso>
        public virtual Task<ListTagsResponse> ListTagsAsync(ListTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PurchaseReservedNodesOffering

        internal virtual PurchaseReservedNodesOfferingResponse PurchaseReservedNodesOffering(PurchaseReservedNodesOfferingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PurchaseReservedNodesOfferingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PurchaseReservedNodesOfferingResponseUnmarshaller.Instance;

            return Invoke<PurchaseReservedNodesOfferingResponse>(request, options);
        }



        /// <summary>
        /// Allows you to purchase a reserved node offering. Reserved nodes are not eligible for
        /// cancellation and are non-refundable.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PurchaseReservedNodesOffering service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PurchaseReservedNodesOffering service method, as returned by MemoryDB.</returns>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidParameterCombinationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidParameterValueException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.ReservedNodeAlreadyExistsException">
        /// You already have a reservation with the given identifier.
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.ReservedNodeQuotaExceededException">
        /// The request cannot be processed because it would exceed the user's node quota.
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.ReservedNodesOfferingNotFoundException">
        /// The requested node offering does not exist.
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.ServiceLinkedRoleNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.TagQuotaPerResourceExceededException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/PurchaseReservedNodesOffering">REST API Reference for PurchaseReservedNodesOffering Operation</seealso>
        public virtual Task<PurchaseReservedNodesOfferingResponse> PurchaseReservedNodesOfferingAsync(PurchaseReservedNodesOfferingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PurchaseReservedNodesOfferingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PurchaseReservedNodesOfferingResponseUnmarshaller.Instance;

            return InvokeAsync<PurchaseReservedNodesOfferingResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ResetParameterGroup

        internal virtual ResetParameterGroupResponse ResetParameterGroup(ResetParameterGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ResetParameterGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResetParameterGroupResponseUnmarshaller.Instance;

            return Invoke<ResetParameterGroupResponse>(request, options);
        }



        /// <summary>
        /// Modifies the parameters of a parameter group to the engine or system default value.
        /// You can reset specific parameters by submitting a list of parameter names. To reset
        /// the entire parameter group, specify the AllParameters and ParameterGroupName parameters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResetParameterGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ResetParameterGroup service method, as returned by MemoryDB.</returns>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidParameterCombinationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidParameterGroupStateException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidParameterValueException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.ParameterGroupNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.ServiceLinkedRoleNotFoundException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/ResetParameterGroup">REST API Reference for ResetParameterGroup Operation</seealso>
        public virtual Task<ResetParameterGroupResponse> ResetParameterGroupAsync(ResetParameterGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ResetParameterGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResetParameterGroupResponseUnmarshaller.Instance;

            return InvokeAsync<ResetParameterGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TagResource

        internal virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }



        /// <summary>
        /// A tag is a key-value pair where the key and value are case-sensitive. You can use
        /// tags to categorize and track all your MemoryDB resources. When you add or remove tags
        /// on clusters, those actions will be replicated to all nodes in the cluster. For more
        /// information, see <a href="https://docs.aws.amazon.com/MemoryDB/latest/devguide/iam.resourcelevelpermissions.html">Resource-level
        /// permissions</a>.
        /// 
        ///  
        /// <para>
        /// For example, you can use cost-allocation tags to your MemoryDB resources, Amazon generates
        /// a cost allocation report as a comma-separated value (CSV) file with your usage and
        /// costs aggregated by your tags. You can apply tags that represent business categories
        /// (such as cost centers, application names, or owners) to organize your costs across
        /// multiple services. For more information, see <a href="https://docs.aws.amazon.com/MemoryDB/latest/devguide/tagging.html">Using
        /// Cost Allocation Tags</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by MemoryDB.</returns>
        /// <exception cref="Amazon.MemoryDB.Model.ACLNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.ClusterNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidARNException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidClusterStateException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.ParameterGroupNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.ServiceLinkedRoleNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.SnapshotNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.SubnetGroupNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.TagQuotaPerResourceExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.UserNotFoundException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UntagResource

        internal virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }



        /// <summary>
        /// Use this operation to remove tags on a resource
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by MemoryDB.</returns>
        /// <exception cref="Amazon.MemoryDB.Model.ACLNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.ClusterNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidARNException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidClusterStateException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.ParameterGroupNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.ServiceLinkedRoleNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.SnapshotNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.SubnetGroupNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.TagNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.UserNotFoundException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateACL

        internal virtual UpdateACLResponse UpdateACL(UpdateACLRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateACLRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateACLResponseUnmarshaller.Instance;

            return Invoke<UpdateACLResponse>(request, options);
        }



        /// <summary>
        /// Changes the list of users that belong to the Access Control List.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateACL service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateACL service method, as returned by MemoryDB.</returns>
        /// <exception cref="Amazon.MemoryDB.Model.ACLNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.DefaultUserRequiredException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.DuplicateUserNameException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidACLStateException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidParameterCombinationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidParameterValueException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.UserNotFoundException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/UpdateACL">REST API Reference for UpdateACL Operation</seealso>
        public virtual Task<UpdateACLResponse> UpdateACLAsync(UpdateACLRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateACLRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateACLResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateACLResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateCluster

        internal virtual UpdateClusterResponse UpdateCluster(UpdateClusterRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateClusterResponseUnmarshaller.Instance;

            return Invoke<UpdateClusterResponse>(request, options);
        }



        /// <summary>
        /// Modifies the settings for a cluster. You can use this operation to change one or more
        /// cluster configuration settings by specifying the settings and the new values.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateCluster service method, as returned by MemoryDB.</returns>
        /// <exception cref="Amazon.MemoryDB.Model.ACLNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.ClusterNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.ClusterQuotaForCustomerExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidACLStateException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidClusterStateException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidKMSKeyException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidNodeStateException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidParameterCombinationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidParameterValueException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidVPCNetworkStateException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.NodeQuotaForClusterExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.NodeQuotaForCustomerExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.NoOperationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.ParameterGroupNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.ServiceLinkedRoleNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.ShardsPerClusterQuotaExceededException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/UpdateCluster">REST API Reference for UpdateCluster Operation</seealso>
        public virtual Task<UpdateClusterResponse> UpdateClusterAsync(UpdateClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateClusterResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateClusterResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateParameterGroup

        internal virtual UpdateParameterGroupResponse UpdateParameterGroup(UpdateParameterGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateParameterGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateParameterGroupResponseUnmarshaller.Instance;

            return Invoke<UpdateParameterGroupResponse>(request, options);
        }



        /// <summary>
        /// Updates the parameters of a parameter group. You can modify up to 20 parameters in
        /// a single request by submitting a list parameter name and value pairs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateParameterGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateParameterGroup service method, as returned by MemoryDB.</returns>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidParameterCombinationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidParameterGroupStateException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidParameterValueException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.ParameterGroupNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.ServiceLinkedRoleNotFoundException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/UpdateParameterGroup">REST API Reference for UpdateParameterGroup Operation</seealso>
        public virtual Task<UpdateParameterGroupResponse> UpdateParameterGroupAsync(UpdateParameterGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateParameterGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateParameterGroupResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateParameterGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateSubnetGroup

        internal virtual UpdateSubnetGroupResponse UpdateSubnetGroup(UpdateSubnetGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSubnetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSubnetGroupResponseUnmarshaller.Instance;

            return Invoke<UpdateSubnetGroupResponse>(request, options);
        }



        /// <summary>
        /// Updates a subnet group. For more information, see <a href="https://docs.aws.amazon.com/MemoryDB/latest/devguide/ubnetGroups.Modifying.html">Updating
        /// a subnet group</a>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSubnetGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateSubnetGroup service method, as returned by MemoryDB.</returns>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidSubnetException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.ServiceLinkedRoleNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.SubnetGroupNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.SubnetInUseException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.SubnetNotAllowedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.SubnetQuotaExceededException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/UpdateSubnetGroup">REST API Reference for UpdateSubnetGroup Operation</seealso>
        public virtual Task<UpdateSubnetGroupResponse> UpdateSubnetGroupAsync(UpdateSubnetGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSubnetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSubnetGroupResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateSubnetGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateUser

        internal virtual UpdateUserResponse UpdateUser(UpdateUserRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateUserResponseUnmarshaller.Instance;

            return Invoke<UpdateUserResponse>(request, options);
        }



        /// <summary>
        /// Changes user password(s) and/or access string.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateUser service method, as returned by MemoryDB.</returns>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidParameterCombinationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidParameterValueException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidUserStateException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.UserNotFoundException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/UpdateUser">REST API Reference for UpdateUser Operation</seealso>
        public virtual Task<UpdateUserResponse> UpdateUserAsync(UpdateUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateUserResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateUserResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}