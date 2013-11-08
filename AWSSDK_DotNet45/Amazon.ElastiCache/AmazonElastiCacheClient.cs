/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Threading;
using System.Threading.Tasks;

using Amazon.ElastiCache.Model;
using Amazon.ElastiCache.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.ElastiCache
{
    /// <summary>
    /// Implementation for accessing AmazonElastiCache.
    /// 
    /// Amazon ElastiCache <para>Amazon ElastiCache is a web service that makes it easier to set up, operate, and scale a distributed cache in the
    /// cloud.</para> <para>With ElastiCache, customers gain all of the benefits of a high-performance, in-memory cache with far less of the
    /// administrative burden of launching and managing a distributed cache. The service makes set-up, scaling, and cluster failure handling much
    /// simpler than in a self-managed cache deployment.</para> <para>In addition, through integration with Amazon CloudWatch, customers get
    /// enhanced visibility into the key performance statistics associated with their cache and can receive alarms if a part of their cache runs
    /// hot.</para>
    /// </summary>
	public partial class AmazonElastiCacheClient : AmazonWebServiceClient, Amazon.ElastiCache.IAmazonElastiCache
    {

        AWS4Signer signer = new AWS4Signer();

        #region Dispose

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Constructs AmazonElastiCacheClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public AmazonElastiCacheClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonElastiCacheConfig(), AuthenticationTypes.User | AuthenticationTypes.Session) { }

        /// <summary>
        /// Constructs AmazonElastiCacheClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="region">The region to connect.</param>
        public AmazonElastiCacheClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonElastiCacheConfig(){RegionEndpoint = region}, AuthenticationTypes.User | AuthenticationTypes.Session) { }

        /// <summary>
        /// Constructs AmazonElastiCacheClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="config">The AmazonElastiCache Configuration Object</param>
        public AmazonElastiCacheClient(AmazonElastiCacheConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config, AuthenticationTypes.User | AuthenticationTypes.Session) { }

        /// <summary>
        /// Constructs AmazonElastiCacheClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonElastiCacheClient(AWSCredentials credentials)
            : this(credentials, new AmazonElastiCacheConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonElastiCacheClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonElastiCacheClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonElastiCacheConfig(){RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonElastiCacheClient with AWS Credentials and an
        /// AmazonElastiCacheClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonElastiCacheClient Configuration Object</param>
        public AmazonElastiCacheClient(AWSCredentials credentials, AmazonElastiCacheConfig clientConfig)
            : base(credentials, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
        {
        }

        /// <summary>
        /// Constructs AmazonElastiCacheClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonElastiCacheClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonElastiCacheConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonElastiCacheClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonElastiCacheClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonElastiCacheConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonElastiCacheClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonElastiCacheClient Configuration object. If the config object's
        /// UseSecureStringForAwsSecretKey is false, the AWS Secret Key
        /// is stored as a clear-text string. Please use this option only
        /// if the application environment doesn't allow the use of SecureStrings.
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonElastiCacheClient Configuration Object</param>
        public AmazonElastiCacheClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonElastiCacheConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
        {
        }

        /// <summary>
        /// Constructs AmazonElastiCacheClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonElastiCacheClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonElastiCacheConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonElastiCacheClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonElastiCacheClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonElastiCacheConfig(){RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonElastiCacheClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonElastiCacheClient Configuration object. If the config object's
        /// UseSecureStringForAwsSecretKey is false, the AWS Secret Key
        /// is stored as a clear-text string. Please use this option only
        /// if the application environment doesn't allow the use of SecureStrings.
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonElastiCacheClient Configuration Object</param>
        public AmazonElastiCacheClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonElastiCacheConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
        {
        }

        #endregion

 
        /// <summary>
        /// <para>The <i>AuthorizeCacheSecurityGroupIngress</i> operation allows network ingress to a cache security group. Applications using
        /// ElastiCache must be running on Amazon EC2, and Amazon EC2 security groups are used as the authorization mechanism.</para> <para><b>NOTE:</b>
        /// You cannot authorize ingress from an Amazon EC2 security group in one Region to an ElastiCache cluster in another Region. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the
        /// AuthorizeCacheSecurityGroupIngress service method on AmazonElastiCache.</param>
        /// 
        /// <returns>The response from the AuthorizeCacheSecurityGroupIngress service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterValueException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.AuthorizationAlreadyExistsException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidCacheSecurityGroupStateException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterCombinationException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheSecurityGroupNotFoundException" />
		public AuthorizeCacheSecurityGroupIngressResponse AuthorizeCacheSecurityGroupIngress(AuthorizeCacheSecurityGroupIngressRequest request)
        {
            var task = AuthorizeCacheSecurityGroupIngressAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the AuthorizeCacheSecurityGroupIngress operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache.AuthorizeCacheSecurityGroupIngress"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AuthorizeCacheSecurityGroupIngress operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<AuthorizeCacheSecurityGroupIngressResponse> AuthorizeCacheSecurityGroupIngressAsync(AuthorizeCacheSecurityGroupIngressRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AuthorizeCacheSecurityGroupIngressRequestMarshaller();
            var unmarshaller = AuthorizeCacheSecurityGroupIngressResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, AuthorizeCacheSecurityGroupIngressRequest, AuthorizeCacheSecurityGroupIngressResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para>The <i>CreateCacheCluster</i> operation creates a new cache cluster. All nodes in the cache cluster run the same protocol-compliant
        /// cache engine software - either Memcached or Redis.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCacheCluster service method on
        /// AmazonElastiCache.</param>
        /// 
        /// <returns>The response from the CreateCacheCluster service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="T:Amazon.ElastiCache.Model.NodeQuotaForCustomerExceededException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.ClusterQuotaForCustomerExceededException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheClusterAlreadyExistsException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InsufficientCacheClusterCapacityException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.ReplicationGroupNotFoundException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterCombinationException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheParameterGroupNotFoundException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheSecurityGroupNotFoundException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.NodeQuotaForClusterExceededException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheSubnetGroupNotFoundException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidReplicationGroupStateException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterValueException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidVPCNetworkStateException" />
		public CreateCacheClusterResponse CreateCacheCluster(CreateCacheClusterRequest request)
        {
            var task = CreateCacheClusterAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the CreateCacheCluster operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache.CreateCacheCluster"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCacheCluster operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<CreateCacheClusterResponse> CreateCacheClusterAsync(CreateCacheClusterRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateCacheClusterRequestMarshaller();
            var unmarshaller = CreateCacheClusterResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, CreateCacheClusterRequest, CreateCacheClusterResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para>The <i>CreateCacheParameterGroup</i> operation creates a new cache parameter group. A cache parameter group is a collection of
        /// parameters that you apply to all of the nodes in a cache cluster.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCacheParameterGroup service
        /// method on AmazonElastiCache.</param>
        /// 
        /// <returns>The response from the CreateCacheParameterGroup service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterValueException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheParameterGroupQuotaExceededException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheParameterGroupAlreadyExistsException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterCombinationException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidCacheParameterGroupStateException" />
		public CreateCacheParameterGroupResponse CreateCacheParameterGroup(CreateCacheParameterGroupRequest request)
        {
            var task = CreateCacheParameterGroupAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the CreateCacheParameterGroup operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache.CreateCacheParameterGroup"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCacheParameterGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<CreateCacheParameterGroupResponse> CreateCacheParameterGroupAsync(CreateCacheParameterGroupRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateCacheParameterGroupRequestMarshaller();
            var unmarshaller = CreateCacheParameterGroupResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, CreateCacheParameterGroupRequest, CreateCacheParameterGroupResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para>The <i>CreateCacheSecurityGroup</i> operation creates a new cache security group. Use a cache security group to control access to one
        /// or more cache clusters.</para> <para>Cache security groups are only used when you are creating a cluster outside of an Amazon Virtual
        /// Private Cloud (VPC). If you are creating a cluster inside of a VPC, use a cache subnet group instead. For more information, see
        /// <i>CreateCacheSubnetGroup</i> .</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCacheSecurityGroup service method
        /// on AmazonElastiCache.</param>
        /// 
        /// <returns>The response from the CreateCacheSecurityGroup service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheSecurityGroupAlreadyExistsException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterValueException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheSecurityGroupQuotaExceededException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterCombinationException" />
		public CreateCacheSecurityGroupResponse CreateCacheSecurityGroup(CreateCacheSecurityGroupRequest request)
        {
            var task = CreateCacheSecurityGroupAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the CreateCacheSecurityGroup operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache.CreateCacheSecurityGroup"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCacheSecurityGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<CreateCacheSecurityGroupResponse> CreateCacheSecurityGroupAsync(CreateCacheSecurityGroupRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateCacheSecurityGroupRequestMarshaller();
            var unmarshaller = CreateCacheSecurityGroupResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, CreateCacheSecurityGroupRequest, CreateCacheSecurityGroupResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para>The <i>CreateCacheSubnetGroup</i> operation creates a new cache subnet group.</para> <para>Use this parameter only when you are
        /// creating a cluster in an Amazon Virtual Private Cloud (VPC).</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCacheSubnetGroup service method on
        /// AmazonElastiCache.</param>
        /// 
        /// <returns>The response from the CreateCacheSubnetGroup service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheSubnetGroupAlreadyExistsException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheSubnetGroupQuotaExceededException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheSubnetQuotaExceededException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidSubnetException" />
		public CreateCacheSubnetGroupResponse CreateCacheSubnetGroup(CreateCacheSubnetGroupRequest request)
        {
            var task = CreateCacheSubnetGroupAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the CreateCacheSubnetGroup operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache.CreateCacheSubnetGroup"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCacheSubnetGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<CreateCacheSubnetGroupResponse> CreateCacheSubnetGroupAsync(CreateCacheSubnetGroupRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateCacheSubnetGroupRequestMarshaller();
            var unmarshaller = CreateCacheSubnetGroupResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, CreateCacheSubnetGroupRequest, CreateCacheSubnetGroupResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para>The <i>CreateReplicationGroup</i> operation creates a replication group. A replication group is a collection of cache clusters, where
        /// one of the clusters is a read/write primary and the other clusters are read-only replicas. Writes to the primary are automatically
        /// propagated to the replicas.</para> <para>When you create a replication group, you must specify an existing cache cluster that is in the
        /// primary role. When the replication group has been successfully created, you can add one or more read replica replicas to it, up to a total
        /// of five read replicas.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateReplicationGroup service method on
        /// AmazonElastiCache.</param>
        /// 
        /// <returns>The response from the CreateReplicationGroup service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="T:Amazon.ElastiCache.Model.ReplicationGroupAlreadyExistsException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterValueException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheClusterNotFoundException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterCombinationException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidCacheClusterStateException" />
		public CreateReplicationGroupResponse CreateReplicationGroup(CreateReplicationGroupRequest request)
        {
            var task = CreateReplicationGroupAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the CreateReplicationGroup operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache.CreateReplicationGroup"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateReplicationGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<CreateReplicationGroupResponse> CreateReplicationGroupAsync(CreateReplicationGroupRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateReplicationGroupRequestMarshaller();
            var unmarshaller = CreateReplicationGroupResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, CreateReplicationGroupRequest, CreateReplicationGroupResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para>The <i>DeleteCacheCluster</i> operation deletes a previously provisioned cache cluster. <i>DeleteCacheCluster</i> deletes all
        /// associated cache nodes, node endpoints and the cache cluster itself. When you receive a successful response from this operation, Amazon
        /// ElastiCache immediately begins deleting the cache cluster; you cannot cancel or revert this operation.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCacheCluster service method on
        /// AmazonElastiCache.</param>
        /// 
        /// <returns>The response from the DeleteCacheCluster service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterValueException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheClusterNotFoundException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterCombinationException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidCacheClusterStateException" />
		public DeleteCacheClusterResponse DeleteCacheCluster(DeleteCacheClusterRequest request)
        {
            var task = DeleteCacheClusterAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCacheCluster operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache.DeleteCacheCluster"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCacheCluster operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<DeleteCacheClusterResponse> DeleteCacheClusterAsync(DeleteCacheClusterRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteCacheClusterRequestMarshaller();
            var unmarshaller = DeleteCacheClusterResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DeleteCacheClusterRequest, DeleteCacheClusterResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para>The <i>DeleteCacheParameterGroup</i> operation deletes the specified cache parameter group. You cannot delete a cache parameter group
        /// if it is associated with any cache clusters.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCacheParameterGroup service
        /// method on AmazonElastiCache.</param>
        /// 
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterValueException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterCombinationException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidCacheParameterGroupStateException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheParameterGroupNotFoundException" />
		public DeleteCacheParameterGroupResponse DeleteCacheParameterGroup(DeleteCacheParameterGroupRequest request)
        {
            var task = DeleteCacheParameterGroupAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCacheParameterGroup operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache.DeleteCacheParameterGroup"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCacheParameterGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<DeleteCacheParameterGroupResponse> DeleteCacheParameterGroupAsync(DeleteCacheParameterGroupRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteCacheParameterGroupRequestMarshaller();
            var unmarshaller = DeleteCacheParameterGroupResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DeleteCacheParameterGroupRequest, DeleteCacheParameterGroupResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para>The <i>DeleteCacheSecurityGroup</i> operation deletes a cache security group.</para> <para><b>NOTE:</b>You cannot delete a cache
        /// security group if it is associated with any cache clusters.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCacheSecurityGroup service method
        /// on AmazonElastiCache.</param>
        /// 
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterValueException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidCacheSecurityGroupStateException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterCombinationException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheSecurityGroupNotFoundException" />
		public DeleteCacheSecurityGroupResponse DeleteCacheSecurityGroup(DeleteCacheSecurityGroupRequest request)
        {
            var task = DeleteCacheSecurityGroupAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCacheSecurityGroup operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache.DeleteCacheSecurityGroup"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCacheSecurityGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<DeleteCacheSecurityGroupResponse> DeleteCacheSecurityGroupAsync(DeleteCacheSecurityGroupRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteCacheSecurityGroupRequestMarshaller();
            var unmarshaller = DeleteCacheSecurityGroupResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DeleteCacheSecurityGroupRequest, DeleteCacheSecurityGroupResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para>The <i>DeleteCacheSubnetGroup</i> operation deletes a cache subnet group.</para> <para><b>NOTE:</b>You cannot delete a cache subnet
        /// group if it is associated with any cache clusters.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCacheSubnetGroup service method on
        /// AmazonElastiCache.</param>
        /// 
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheSubnetGroupNotFoundException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheSubnetGroupInUseException" />
		public DeleteCacheSubnetGroupResponse DeleteCacheSubnetGroup(DeleteCacheSubnetGroupRequest request)
        {
            var task = DeleteCacheSubnetGroupAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCacheSubnetGroup operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache.DeleteCacheSubnetGroup"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCacheSubnetGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<DeleteCacheSubnetGroupResponse> DeleteCacheSubnetGroupAsync(DeleteCacheSubnetGroupRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteCacheSubnetGroupRequestMarshaller();
            var unmarshaller = DeleteCacheSubnetGroupResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DeleteCacheSubnetGroupRequest, DeleteCacheSubnetGroupResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para>The <i>DeleteReplicationGroup</i> operation deletes an existing replication group. <i>DeleteReplicationGroup</i> deletes the primary
        /// cache cluster and all of the read replicas in the replication group. When you receive a successful response from this operation, Amazon
        /// ElastiCache immediately begins deleting the entire replication group; you cannot cancel or revert this operation.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteReplicationGroup service method on
        /// AmazonElastiCache.</param>
        /// 
        /// <returns>The response from the DeleteReplicationGroup service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidReplicationGroupStateException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterValueException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.ReplicationGroupNotFoundException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterCombinationException" />
		public DeleteReplicationGroupResponse DeleteReplicationGroup(DeleteReplicationGroupRequest request)
        {
            var task = DeleteReplicationGroupAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the DeleteReplicationGroup operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache.DeleteReplicationGroup"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteReplicationGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<DeleteReplicationGroupResponse> DeleteReplicationGroupAsync(DeleteReplicationGroupRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteReplicationGroupRequestMarshaller();
            var unmarshaller = DeleteReplicationGroupResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DeleteReplicationGroupRequest, DeleteReplicationGroupResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para>The <i>DescribeCacheClusters</i> operation returns information about all provisioned cache clusters if no cache cluster identifier is
        /// specified, or about a specific cache cluster if a cache cluster identifier is supplied.</para> <para>By default, abbreviated information
        /// about the cache clusters(s) will be returned. You can use the optional <i>ShowDetails</i> flag to retrieve detailed information about the
        /// cache nodes associated with the cache clusters. These details include the DNS address and port for the cache node endpoint.</para> <para>If
        /// the cluster is in the CREATING state, only cluster level information will be displayed until all of the nodes are successfully
        /// provisioned.</para> <para>If the cluster is in the DELETING state, only cluster level information will be displayed.</para> <para>If cache
        /// nodes are currently being added to the cache cluster, node endpoint information and creation time for the additional nodes will not be
        /// displayed until they are completely provisioned. When the cache cluster state is <i>available</i> , the cluster is ready for use.</para>
        /// <para>If cache nodes are currently being removed from the cache cluster, no endpoint information for the removed nodes is displayed.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCacheClusters service method on
        /// AmazonElastiCache.</param>
        /// 
        /// <returns>The response from the DescribeCacheClusters service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterValueException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheClusterNotFoundException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterCombinationException" />
		public DescribeCacheClustersResponse DescribeCacheClusters(DescribeCacheClustersRequest request)
        {
            var task = DescribeCacheClustersAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCacheClusters operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache.DescribeCacheClusters"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCacheClusters operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<DescribeCacheClustersResponse> DescribeCacheClustersAsync(DescribeCacheClustersRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeCacheClustersRequestMarshaller();
            var unmarshaller = DescribeCacheClustersResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DescribeCacheClustersRequest, DescribeCacheClustersResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para>The <i>DescribeCacheClusters</i> operation returns information about all provisioned cache clusters if no cache cluster identifier is
        /// specified, or about a specific cache cluster if a cache cluster identifier is supplied.</para> <para>By default, abbreviated information
        /// about the cache clusters(s) will be returned. You can use the optional <i>ShowDetails</i> flag to retrieve detailed information about the
        /// cache nodes associated with the cache clusters. These details include the DNS address and port for the cache node endpoint.</para> <para>If
        /// the cluster is in the CREATING state, only cluster level information will be displayed until all of the nodes are successfully
        /// provisioned.</para> <para>If the cluster is in the DELETING state, only cluster level information will be displayed.</para> <para>If cache
        /// nodes are currently being added to the cache cluster, node endpoint information and creation time for the additional nodes will not be
        /// displayed until they are completely provisioned. When the cache cluster state is <i>available</i> , the cluster is ready for use.</para>
        /// <para>If cache nodes are currently being removed from the cache cluster, no endpoint information for the removed nodes is displayed.</para>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the DescribeCacheClusters service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterValueException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheClusterNotFoundException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterCombinationException" />
		public DescribeCacheClustersResponse DescribeCacheClusters()
        {
            return this.DescribeCacheClusters(new DescribeCacheClustersRequest());
        }
 
        /// <summary>
        /// <para>The <i>DescribeCacheEngineVersions</i> operation returns a list of the available cache engines and their versions.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCacheEngineVersions service
        /// method on AmazonElastiCache.</param>
        /// 
        /// <returns>The response from the DescribeCacheEngineVersions service method, as returned by AmazonElastiCache.</returns>
		public DescribeCacheEngineVersionsResponse DescribeCacheEngineVersions(DescribeCacheEngineVersionsRequest request)
        {
            var task = DescribeCacheEngineVersionsAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCacheEngineVersions operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache.DescribeCacheEngineVersions"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCacheEngineVersions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<DescribeCacheEngineVersionsResponse> DescribeCacheEngineVersionsAsync(DescribeCacheEngineVersionsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeCacheEngineVersionsRequestMarshaller();
            var unmarshaller = DescribeCacheEngineVersionsResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DescribeCacheEngineVersionsRequest, DescribeCacheEngineVersionsResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para>The <i>DescribeCacheEngineVersions</i> operation returns a list of the available cache engines and their versions.</para>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the DescribeCacheEngineVersions service method, as returned by AmazonElastiCache.</returns>
		public DescribeCacheEngineVersionsResponse DescribeCacheEngineVersions()
        {
            return this.DescribeCacheEngineVersions(new DescribeCacheEngineVersionsRequest());
        }
 
        /// <summary>
        /// <para>The <i>DescribeCacheParameterGroups</i> operation returns a list of cache parameter group descriptions. If a cache parameter group
        /// name is specified, the list will contain only the descriptions for that group.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCacheParameterGroups service
        /// method on AmazonElastiCache.</param>
        /// 
        /// <returns>The response from the DescribeCacheParameterGroups service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterValueException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterCombinationException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheParameterGroupNotFoundException" />
		public DescribeCacheParameterGroupsResponse DescribeCacheParameterGroups(DescribeCacheParameterGroupsRequest request)
        {
            var task = DescribeCacheParameterGroupsAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCacheParameterGroups operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache.DescribeCacheParameterGroups"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCacheParameterGroups operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<DescribeCacheParameterGroupsResponse> DescribeCacheParameterGroupsAsync(DescribeCacheParameterGroupsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeCacheParameterGroupsRequestMarshaller();
            var unmarshaller = DescribeCacheParameterGroupsResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DescribeCacheParameterGroupsRequest, DescribeCacheParameterGroupsResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para>The <i>DescribeCacheParameterGroups</i> operation returns a list of cache parameter group descriptions. If a cache parameter group
        /// name is specified, the list will contain only the descriptions for that group.</para>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the DescribeCacheParameterGroups service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterValueException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterCombinationException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheParameterGroupNotFoundException" />
		public DescribeCacheParameterGroupsResponse DescribeCacheParameterGroups()
        {
            return this.DescribeCacheParameterGroups(new DescribeCacheParameterGroupsRequest());
        }
 
        /// <summary>
        /// <para>The <i>DescribeCacheParameters</i> operation returns the detailed parameter list for a particular cache parameter group.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCacheParameters service method on
        /// AmazonElastiCache.</param>
        /// 
        /// <returns>The response from the DescribeCacheParameters service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterValueException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterCombinationException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheParameterGroupNotFoundException" />
		public DescribeCacheParametersResponse DescribeCacheParameters(DescribeCacheParametersRequest request)
        {
            var task = DescribeCacheParametersAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCacheParameters operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache.DescribeCacheParameters"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCacheParameters operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<DescribeCacheParametersResponse> DescribeCacheParametersAsync(DescribeCacheParametersRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeCacheParametersRequestMarshaller();
            var unmarshaller = DescribeCacheParametersResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DescribeCacheParametersRequest, DescribeCacheParametersResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para>The <i>DescribeCacheSecurityGroups</i> operation returns a list of cache security group descriptions. If a cache security group name
        /// is specified, the list will contain only the description of that group.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCacheSecurityGroups service
        /// method on AmazonElastiCache.</param>
        /// 
        /// <returns>The response from the DescribeCacheSecurityGroups service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterValueException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterCombinationException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheSecurityGroupNotFoundException" />
		public DescribeCacheSecurityGroupsResponse DescribeCacheSecurityGroups(DescribeCacheSecurityGroupsRequest request)
        {
            var task = DescribeCacheSecurityGroupsAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCacheSecurityGroups operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache.DescribeCacheSecurityGroups"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCacheSecurityGroups operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<DescribeCacheSecurityGroupsResponse> DescribeCacheSecurityGroupsAsync(DescribeCacheSecurityGroupsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeCacheSecurityGroupsRequestMarshaller();
            var unmarshaller = DescribeCacheSecurityGroupsResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DescribeCacheSecurityGroupsRequest, DescribeCacheSecurityGroupsResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para>The <i>DescribeCacheSecurityGroups</i> operation returns a list of cache security group descriptions. If a cache security group name
        /// is specified, the list will contain only the description of that group.</para>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the DescribeCacheSecurityGroups service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterValueException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterCombinationException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheSecurityGroupNotFoundException" />
		public DescribeCacheSecurityGroupsResponse DescribeCacheSecurityGroups()
        {
            return this.DescribeCacheSecurityGroups(new DescribeCacheSecurityGroupsRequest());
        }
 
        /// <summary>
        /// <para>The <i>DescribeCacheSubnetGroups</i> operation returns a list of cache subnet group descriptions. If a subnet group name is specified,
        /// the list will contain only the description of that group.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCacheSubnetGroups service
        /// method on AmazonElastiCache.</param>
        /// 
        /// <returns>The response from the DescribeCacheSubnetGroups service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheSubnetGroupNotFoundException" />
		public DescribeCacheSubnetGroupsResponse DescribeCacheSubnetGroups(DescribeCacheSubnetGroupsRequest request)
        {
            var task = DescribeCacheSubnetGroupsAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCacheSubnetGroups operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache.DescribeCacheSubnetGroups"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCacheSubnetGroups operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<DescribeCacheSubnetGroupsResponse> DescribeCacheSubnetGroupsAsync(DescribeCacheSubnetGroupsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeCacheSubnetGroupsRequestMarshaller();
            var unmarshaller = DescribeCacheSubnetGroupsResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DescribeCacheSubnetGroupsRequest, DescribeCacheSubnetGroupsResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para>The <i>DescribeCacheSubnetGroups</i> operation returns a list of cache subnet group descriptions. If a subnet group name is specified,
        /// the list will contain only the description of that group.</para>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the DescribeCacheSubnetGroups service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheSubnetGroupNotFoundException" />
		public DescribeCacheSubnetGroupsResponse DescribeCacheSubnetGroups()
        {
            return this.DescribeCacheSubnetGroups(new DescribeCacheSubnetGroupsRequest());
        }
 
        /// <summary>
        /// <para>The <i>DescribeEngineDefaultParameters</i> operation returns the default engine and system parameter information for the specified
        /// cache engine.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEngineDefaultParameters
        /// service method on AmazonElastiCache.</param>
        /// 
        /// <returns>The response from the DescribeEngineDefaultParameters service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterValueException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterCombinationException" />
		public DescribeEngineDefaultParametersResponse DescribeEngineDefaultParameters(DescribeEngineDefaultParametersRequest request)
        {
            var task = DescribeEngineDefaultParametersAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEngineDefaultParameters operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache.DescribeEngineDefaultParameters"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEngineDefaultParameters operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<DescribeEngineDefaultParametersResponse> DescribeEngineDefaultParametersAsync(DescribeEngineDefaultParametersRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeEngineDefaultParametersRequestMarshaller();
            var unmarshaller = DescribeEngineDefaultParametersResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DescribeEngineDefaultParametersRequest, DescribeEngineDefaultParametersResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para>The <i>DescribeEvents</i> operation returns events related to cache clusters, cache security groups, and cache parameter groups. You
        /// can obtain events specific to a particular cache cluster, cache security group, or cache parameter group by providing the name as a
        /// parameter.</para> <para>By default, only the events occurring within the last hour are returned; however, you can retrieve up to 14 days'
        /// worth of events if necessary.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEvents service method on
        /// AmazonElastiCache.</param>
        /// 
        /// <returns>The response from the DescribeEvents service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterValueException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterCombinationException" />
		public DescribeEventsResponse DescribeEvents(DescribeEventsRequest request)
        {
            var task = DescribeEventsAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEvents operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache.DescribeEvents"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEvents operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<DescribeEventsResponse> DescribeEventsAsync(DescribeEventsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeEventsRequestMarshaller();
            var unmarshaller = DescribeEventsResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DescribeEventsRequest, DescribeEventsResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para>The <i>DescribeEvents</i> operation returns events related to cache clusters, cache security groups, and cache parameter groups. You
        /// can obtain events specific to a particular cache cluster, cache security group, or cache parameter group by providing the name as a
        /// parameter.</para> <para>By default, only the events occurring within the last hour are returned; however, you can retrieve up to 14 days'
        /// worth of events if necessary.</para>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the DescribeEvents service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterValueException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterCombinationException" />
		public DescribeEventsResponse DescribeEvents()
        {
            return this.DescribeEvents(new DescribeEventsRequest());
        }
 
        /// <summary>
        /// <para>The <i>DescribeReplicationGroups</i> operation returns information about a particular replication group. If no identifier is
        /// specified, <i>DescribeReplicationGroups</i> returns information about all replication groups.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReplicationGroups service
        /// method on AmazonElastiCache.</param>
        /// 
        /// <returns>The response from the DescribeReplicationGroups service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterValueException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.ReplicationGroupNotFoundException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterCombinationException" />
		public DescribeReplicationGroupsResponse DescribeReplicationGroups(DescribeReplicationGroupsRequest request)
        {
            var task = DescribeReplicationGroupsAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReplicationGroups operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache.DescribeReplicationGroups"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReplicationGroups operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<DescribeReplicationGroupsResponse> DescribeReplicationGroupsAsync(DescribeReplicationGroupsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeReplicationGroupsRequestMarshaller();
            var unmarshaller = DescribeReplicationGroupsResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DescribeReplicationGroupsRequest, DescribeReplicationGroupsResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para>The <i>DescribeReplicationGroups</i> operation returns information about a particular replication group. If no identifier is
        /// specified, <i>DescribeReplicationGroups</i> returns information about all replication groups.</para>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the DescribeReplicationGroups service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterValueException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.ReplicationGroupNotFoundException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterCombinationException" />
		public DescribeReplicationGroupsResponse DescribeReplicationGroups()
        {
            return this.DescribeReplicationGroups(new DescribeReplicationGroupsRequest());
        }
 
        /// <summary>
        /// <para>The <i>DescribeReservedCacheNodes</i> operation returns information about reserved cache nodes for this account, or about a specified
        /// reserved cache node.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedCacheNodes service
        /// method on AmazonElastiCache.</param>
        /// 
        /// <returns>The response from the DescribeReservedCacheNodes service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="T:Amazon.ElastiCache.Model.ReservedCacheNodeNotFoundException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterValueException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterCombinationException" />
		public DescribeReservedCacheNodesResponse DescribeReservedCacheNodes(DescribeReservedCacheNodesRequest request)
        {
            var task = DescribeReservedCacheNodesAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReservedCacheNodes operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache.DescribeReservedCacheNodes"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedCacheNodes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<DescribeReservedCacheNodesResponse> DescribeReservedCacheNodesAsync(DescribeReservedCacheNodesRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeReservedCacheNodesRequestMarshaller();
            var unmarshaller = DescribeReservedCacheNodesResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DescribeReservedCacheNodesRequest, DescribeReservedCacheNodesResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para>The <i>DescribeReservedCacheNodes</i> operation returns information about reserved cache nodes for this account, or about a specified
        /// reserved cache node.</para>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the DescribeReservedCacheNodes service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="T:Amazon.ElastiCache.Model.ReservedCacheNodeNotFoundException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterValueException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterCombinationException" />
		public DescribeReservedCacheNodesResponse DescribeReservedCacheNodes()
        {
            return this.DescribeReservedCacheNodes(new DescribeReservedCacheNodesRequest());
        }
 
        /// <summary>
        /// <para>The <i>DescribeReservedCacheNodesOfferings</i> operation lists available reserved cache node offerings.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the
        /// DescribeReservedCacheNodesOfferings service method on AmazonElastiCache.</param>
        /// 
        /// <returns>The response from the DescribeReservedCacheNodesOfferings service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterValueException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.ReservedCacheNodesOfferingNotFoundException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterCombinationException" />
		public DescribeReservedCacheNodesOfferingsResponse DescribeReservedCacheNodesOfferings(DescribeReservedCacheNodesOfferingsRequest request)
        {
            var task = DescribeReservedCacheNodesOfferingsAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReservedCacheNodesOfferings operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache.DescribeReservedCacheNodesOfferings"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedCacheNodesOfferings operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<DescribeReservedCacheNodesOfferingsResponse> DescribeReservedCacheNodesOfferingsAsync(DescribeReservedCacheNodesOfferingsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeReservedCacheNodesOfferingsRequestMarshaller();
            var unmarshaller = DescribeReservedCacheNodesOfferingsResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DescribeReservedCacheNodesOfferingsRequest, DescribeReservedCacheNodesOfferingsResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para>The <i>DescribeReservedCacheNodesOfferings</i> operation lists available reserved cache node offerings.</para>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the DescribeReservedCacheNodesOfferings service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterValueException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.ReservedCacheNodesOfferingNotFoundException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterCombinationException" />
		public DescribeReservedCacheNodesOfferingsResponse DescribeReservedCacheNodesOfferings()
        {
            return this.DescribeReservedCacheNodesOfferings(new DescribeReservedCacheNodesOfferingsRequest());
        }
 
        /// <summary>
        /// <para>The <i>ModifyCacheCluster</i> operation modifies the settings for a cache cluster. You can use this operation to change one or more
        /// cluster configuration parameters by specifying the parameters and the new values.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyCacheCluster service method on
        /// AmazonElastiCache.</param>
        /// 
        /// <returns>The response from the ModifyCacheCluster service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="T:Amazon.ElastiCache.Model.NodeQuotaForCustomerExceededException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.NodeQuotaForClusterExceededException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterValueException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidCacheSecurityGroupStateException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidVPCNetworkStateException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheClusterNotFoundException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterCombinationException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheParameterGroupNotFoundException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidCacheClusterStateException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheSecurityGroupNotFoundException" />
		public ModifyCacheClusterResponse ModifyCacheCluster(ModifyCacheClusterRequest request)
        {
            var task = ModifyCacheClusterAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the ModifyCacheCluster operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache.ModifyCacheCluster"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyCacheCluster operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<ModifyCacheClusterResponse> ModifyCacheClusterAsync(ModifyCacheClusterRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ModifyCacheClusterRequestMarshaller();
            var unmarshaller = ModifyCacheClusterResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, ModifyCacheClusterRequest, ModifyCacheClusterResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para>The <i>ModifyCacheParameterGroup</i> operation modifies the parameters of a cache parameter group. You can modify up to 20 parameters
        /// in a single request by submitting a list parameter name and value pairs.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyCacheParameterGroup service
        /// method on AmazonElastiCache.</param>
        /// 
        /// <returns>The response from the ModifyCacheParameterGroup service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterValueException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterCombinationException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheParameterGroupNotFoundException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidCacheParameterGroupStateException" />
		public ModifyCacheParameterGroupResponse ModifyCacheParameterGroup(ModifyCacheParameterGroupRequest request)
        {
            var task = ModifyCacheParameterGroupAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the ModifyCacheParameterGroup operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache.ModifyCacheParameterGroup"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyCacheParameterGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<ModifyCacheParameterGroupResponse> ModifyCacheParameterGroupAsync(ModifyCacheParameterGroupRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ModifyCacheParameterGroupRequestMarshaller();
            var unmarshaller = ModifyCacheParameterGroupResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, ModifyCacheParameterGroupRequest, ModifyCacheParameterGroupResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para>The <i>ModifyCacheSubnetGroup</i> operation modifies an existing cache subnet group.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyCacheSubnetGroup service method on
        /// AmazonElastiCache.</param>
        /// 
        /// <returns>The response from the ModifyCacheSubnetGroup service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheSubnetGroupNotFoundException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheSubnetQuotaExceededException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidSubnetException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.SubnetInUseException" />
		public ModifyCacheSubnetGroupResponse ModifyCacheSubnetGroup(ModifyCacheSubnetGroupRequest request)
        {
            var task = ModifyCacheSubnetGroupAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the ModifyCacheSubnetGroup operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache.ModifyCacheSubnetGroup"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyCacheSubnetGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<ModifyCacheSubnetGroupResponse> ModifyCacheSubnetGroupAsync(ModifyCacheSubnetGroupRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ModifyCacheSubnetGroupRequestMarshaller();
            var unmarshaller = ModifyCacheSubnetGroupResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, ModifyCacheSubnetGroupRequest, ModifyCacheSubnetGroupResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para>The <i>ModifyReplicationGroup</i> operation modifies the settings for a replication group.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyReplicationGroup service method on
        /// AmazonElastiCache.</param>
        /// 
        /// <returns>The response from the ModifyReplicationGroup service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidReplicationGroupStateException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterValueException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidCacheSecurityGroupStateException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidVPCNetworkStateException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.ReplicationGroupNotFoundException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheClusterNotFoundException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterCombinationException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheParameterGroupNotFoundException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidCacheClusterStateException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheSecurityGroupNotFoundException" />
		public ModifyReplicationGroupResponse ModifyReplicationGroup(ModifyReplicationGroupRequest request)
        {
            var task = ModifyReplicationGroupAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the ModifyReplicationGroup operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache.ModifyReplicationGroup"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyReplicationGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<ModifyReplicationGroupResponse> ModifyReplicationGroupAsync(ModifyReplicationGroupRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ModifyReplicationGroupRequestMarshaller();
            var unmarshaller = ModifyReplicationGroupResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, ModifyReplicationGroupRequest, ModifyReplicationGroupResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para>The <i>PurchaseReservedCacheNodesOffering</i> operation allows you to purchase a reserved cache node offering.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the
        /// PurchaseReservedCacheNodesOffering service method on AmazonElastiCache.</param>
        /// 
        /// <returns>The response from the PurchaseReservedCacheNodesOffering service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterValueException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.ReservedCacheNodeQuotaExceededException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.ReservedCacheNodeAlreadyExistsException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.ReservedCacheNodesOfferingNotFoundException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterCombinationException" />
		public PurchaseReservedCacheNodesOfferingResponse PurchaseReservedCacheNodesOffering(PurchaseReservedCacheNodesOfferingRequest request)
        {
            var task = PurchaseReservedCacheNodesOfferingAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the PurchaseReservedCacheNodesOffering operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache.PurchaseReservedCacheNodesOffering"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PurchaseReservedCacheNodesOffering operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<PurchaseReservedCacheNodesOfferingResponse> PurchaseReservedCacheNodesOfferingAsync(PurchaseReservedCacheNodesOfferingRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new PurchaseReservedCacheNodesOfferingRequestMarshaller();
            var unmarshaller = PurchaseReservedCacheNodesOfferingResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, PurchaseReservedCacheNodesOfferingRequest, PurchaseReservedCacheNodesOfferingResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para>The <i>RebootCacheCluster</i> operation reboots some, or all, of the cache cluster nodes within a provisioned cache cluster. This API
        /// will apply any modified cache parameter groups to the cache cluster. The reboot action takes place as soon as possible, and results in a
        /// momentary outage to the cache cluster. During the reboot, the cache cluster status is set to REBOOTING.</para> <para>The reboot causes the
        /// contents of the cache (for each cache cluster node being rebooted) to be lost.</para> <para>When the reboot is complete, a cache cluster
        /// event is created.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RebootCacheCluster service method on
        /// AmazonElastiCache.</param>
        /// 
        /// <returns>The response from the RebootCacheCluster service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheClusterNotFoundException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidCacheClusterStateException" />
		public RebootCacheClusterResponse RebootCacheCluster(RebootCacheClusterRequest request)
        {
            var task = RebootCacheClusterAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the RebootCacheCluster operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache.RebootCacheCluster"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RebootCacheCluster operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<RebootCacheClusterResponse> RebootCacheClusterAsync(RebootCacheClusterRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RebootCacheClusterRequestMarshaller();
            var unmarshaller = RebootCacheClusterResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, RebootCacheClusterRequest, RebootCacheClusterResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para>The <i>ResetCacheParameterGroup</i> operation modifies the parameters of a cache parameter group to the engine or system default
        /// value. You can reset specific parameters by submitting a list of parameter names. To reset the entire cache parameter group, specify the
        /// <i>ResetAllParameters</i> and <i>CacheParameterGroupName</i> parameters.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResetCacheParameterGroup service method
        /// on AmazonElastiCache.</param>
        /// 
        /// <returns>The response from the ResetCacheParameterGroup service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterValueException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterCombinationException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidCacheParameterGroupStateException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheParameterGroupNotFoundException" />
		public ResetCacheParameterGroupResponse ResetCacheParameterGroup(ResetCacheParameterGroupRequest request)
        {
            var task = ResetCacheParameterGroupAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the ResetCacheParameterGroup operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache.ResetCacheParameterGroup"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResetCacheParameterGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<ResetCacheParameterGroupResponse> ResetCacheParameterGroupAsync(ResetCacheParameterGroupRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ResetCacheParameterGroupRequestMarshaller();
            var unmarshaller = ResetCacheParameterGroupResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, ResetCacheParameterGroupRequest, ResetCacheParameterGroupResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para>The <i>RevokeCacheSecurityGroupIngress</i> operation revokes ingress from a cache security group. Use this operation to disallow
        /// access from an Amazon EC2 security group that had been previously authorized.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RevokeCacheSecurityGroupIngress
        /// service method on AmazonElastiCache.</param>
        /// 
        /// <returns>The response from the RevokeCacheSecurityGroupIngress service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterValueException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidCacheSecurityGroupStateException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.AuthorizationNotFoundException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterCombinationException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheSecurityGroupNotFoundException" />
		public RevokeCacheSecurityGroupIngressResponse RevokeCacheSecurityGroupIngress(RevokeCacheSecurityGroupIngressRequest request)
        {
            var task = RevokeCacheSecurityGroupIngressAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the RevokeCacheSecurityGroupIngress operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache.RevokeCacheSecurityGroupIngress"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RevokeCacheSecurityGroupIngress operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<RevokeCacheSecurityGroupIngressResponse> RevokeCacheSecurityGroupIngressAsync(RevokeCacheSecurityGroupIngressRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RevokeCacheSecurityGroupIngressRequestMarshaller();
            var unmarshaller = RevokeCacheSecurityGroupIngressResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, RevokeCacheSecurityGroupIngressRequest, RevokeCacheSecurityGroupIngressResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
    }
}
