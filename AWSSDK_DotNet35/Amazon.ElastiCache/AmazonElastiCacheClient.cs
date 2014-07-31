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


using System;
using System.Threading;

using Amazon.ElastiCache.Model;
using Amazon.ElastiCache.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.ElastiCache
{
    /// <summary>
    /// Implementation for accessing ElastiCache
    ///
    /// Amazon ElastiCache 
    /// <para>
    /// Amazon ElastiCache is a web service that makes it easier to set up, operate, and scale
    /// a distributed cache in the cloud.
    /// </para>
    ///  
    /// <para>
    /// With ElastiCache, customers gain all of the benefits of a high-performance, in-memory
    /// cache with far less of the administrative burden of launching and managing a distributed
    /// cache. The service makes set-up, scaling, and cluster failure handling much simpler
    /// than in a self-managed cache deployment.
    /// </para>
    ///  
    /// <para>
    /// In addition, through integration with Amazon CloudWatch, customers get enhanced visibility
    /// into the key performance statistics associated with their cache and can receive alarms
    /// if a part of their cache runs hot.
    /// </para>
    /// </summary>
    public partial class AmazonElastiCacheClient : AmazonWebServiceClient, IAmazonElastiCache
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
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
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
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="region">The region to connect.</param>
        public AmazonElastiCacheClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonElastiCacheConfig{RegionEndpoint = region}, AuthenticationTypes.User | AuthenticationTypes.Session) { }

        /// <summary>
        /// Constructs AmazonElastiCacheClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonElastiCacheClient Configuration Object</param>
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
            : this(credentials, new AmazonElastiCacheConfig{RegionEndpoint = region})
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
        /// AmazonElastiCacheClient Configuration object. 
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
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonElastiCacheConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonElastiCacheClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonElastiCacheClient Configuration object. 
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

        
        #region  AuthorizeCacheSecurityGroupIngress


        /// <summary>
        /// The <i>AuthorizeCacheSecurityGroupIngress</i> operation allows network ingress to
        /// a cache security group. Applications using ElastiCache must be running on Amazon EC2,
        /// and Amazon EC2 security groups are used as the authorization mechanism.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AuthorizeCacheSecurityGroupIngress service method.</param>
        /// 
        /// <returns>The response from the AuthorizeCacheSecurityGroupIngress service method, as returned by ElastiCache.</returns>
        /// <exception cref="AuthorizationAlreadyExistsException">
        /// The specified Amazon EC2 security group is already authorized for the specified cache
        /// security group.
        /// </exception>
        /// <exception cref="CacheSecurityGroupNotFoundException">
        /// The requested cache security group name does not refer to an existing cache security
        /// group.
        /// </exception>
        /// <exception cref="InvalidCacheSecurityGroupStateException">
        /// The current state of the cache security group does not allow deletion.
        /// </exception>
        /// <exception cref="InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        public AuthorizeCacheSecurityGroupIngressResponse AuthorizeCacheSecurityGroupIngress(AuthorizeCacheSecurityGroupIngressRequest request)
        {
            IAsyncResult asyncResult = invokeAuthorizeCacheSecurityGroupIngress(request, null, null, true);
            return EndAuthorizeCacheSecurityGroupIngress(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AuthorizeCacheSecurityGroupIngress operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AuthorizeCacheSecurityGroupIngress operation on AmazonElastiCacheClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAuthorizeCacheSecurityGroupIngress
        ///         operation.</returns>
        public IAsyncResult BeginAuthorizeCacheSecurityGroupIngress(AuthorizeCacheSecurityGroupIngressRequest request, AsyncCallback callback, object state)
        {
            return invokeAuthorizeCacheSecurityGroupIngress(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  AuthorizeCacheSecurityGroupIngress operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAuthorizeCacheSecurityGroupIngress.</param>
        /// 
        /// <returns>Returns a  AuthorizeCacheSecurityGroupIngressResult from ElastiCache.</returns>
        public  AuthorizeCacheSecurityGroupIngressResponse EndAuthorizeCacheSecurityGroupIngress(IAsyncResult asyncResult)
        {
            return endOperation< AuthorizeCacheSecurityGroupIngressResponse>(asyncResult);
        }

        IAsyncResult invokeAuthorizeCacheSecurityGroupIngress(AuthorizeCacheSecurityGroupIngressRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new AuthorizeCacheSecurityGroupIngressRequestMarshaller();
            var unmarshaller = AuthorizeCacheSecurityGroupIngressResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  CopySnapshot


        /// <summary>
        /// The <i>CopySnapshot</i> operation makes a copy of an existing snapshot.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CopySnapshot service method.</param>
        /// 
        /// <returns>The response from the CopySnapshot service method, as returned by ElastiCache.</returns>
        /// <exception cref="InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        /// <exception cref="InvalidSnapshotStateException">
        /// The current state of the snapshot does not allow the requested action to occur.
        /// </exception>
        /// <exception cref="SnapshotAlreadyExistsException">
        /// You already have a snapshot with the given name.
        /// </exception>
        /// <exception cref="SnapshotNotFoundException">
        /// The requested snapshot name does not refer to an existing snapshot.
        /// </exception>
        /// <exception cref="SnapshotQuotaExceededException">
        /// The request cannot be processed because it would exceed the maximum number of snapshots.
        /// </exception>
        public CopySnapshotResponse CopySnapshot(CopySnapshotRequest request)
        {
            IAsyncResult asyncResult = invokeCopySnapshot(request, null, null, true);
            return EndCopySnapshot(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CopySnapshot operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CopySnapshot operation on AmazonElastiCacheClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCopySnapshot
        ///         operation.</returns>
        public IAsyncResult BeginCopySnapshot(CopySnapshotRequest request, AsyncCallback callback, object state)
        {
            return invokeCopySnapshot(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  CopySnapshot operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCopySnapshot.</param>
        /// 
        /// <returns>Returns a  CopySnapshotResult from ElastiCache.</returns>
        public  CopySnapshotResponse EndCopySnapshot(IAsyncResult asyncResult)
        {
            return endOperation< CopySnapshotResponse>(asyncResult);
        }

        IAsyncResult invokeCopySnapshot(CopySnapshotRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new CopySnapshotRequestMarshaller();
            var unmarshaller = CopySnapshotResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  CreateCacheCluster


        /// <summary>
        /// The <i>CreateCacheCluster</i> operation creates a new cache cluster. All nodes in
        /// the cache cluster run the same protocol-compliant cache engine software - either Memcached
        /// or Redis.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCacheCluster service method.</param>
        /// 
        /// <returns>The response from the CreateCacheCluster service method, as returned by ElastiCache.</returns>
        /// <exception cref="CacheClusterAlreadyExistsException">
        /// You already have a cache cluster with the given identifier.
        /// </exception>
        /// <exception cref="CacheParameterGroupNotFoundException">
        /// The requested cache parameter group name does not refer to an existing cache parameter
        /// group.
        /// </exception>
        /// <exception cref="CacheSecurityGroupNotFoundException">
        /// The requested cache security group name does not refer to an existing cache security
        /// group.
        /// </exception>
        /// <exception cref="CacheSubnetGroupNotFoundException">
        /// The requested cache subnet group name does not refer to an existing cache subnet group.
        /// </exception>
        /// <exception cref="ClusterQuotaForCustomerExceededException">
        /// The request cannot be processed because it would exceed the allowed number of cache
        /// clusters per customer.
        /// </exception>
        /// <exception cref="InsufficientCacheClusterCapacityException">
        /// The requested cache node type is not available in the specified Availability Zone.
        /// </exception>
        /// <exception cref="InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        /// <exception cref="InvalidReplicationGroupStateException">
        /// The requested replication group is not in the <i>available</i> state.
        /// </exception>
        /// <exception cref="InvalidVPCNetworkStateException">
        /// The VPC network is in an invalid state.
        /// </exception>
        /// <exception cref="NodeQuotaForClusterExceededException">
        /// The request cannot be processed because it would exceed the allowed number of cache
        /// nodes in a single cache cluster.
        /// </exception>
        /// <exception cref="NodeQuotaForCustomerExceededException">
        /// The request cannot be processed because it would exceed the allowed number of cache
        /// nodes per customer.
        /// </exception>
        /// <exception cref="ReplicationGroupNotFoundException">
        /// The specified replication group does not exist.
        /// </exception>
        public CreateCacheClusterResponse CreateCacheCluster(CreateCacheClusterRequest request)
        {
            IAsyncResult asyncResult = invokeCreateCacheCluster(request, null, null, true);
            return EndCreateCacheCluster(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCacheCluster operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCacheCluster operation on AmazonElastiCacheClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateCacheCluster
        ///         operation.</returns>
        public IAsyncResult BeginCreateCacheCluster(CreateCacheClusterRequest request, AsyncCallback callback, object state)
        {
            return invokeCreateCacheCluster(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateCacheCluster operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCacheCluster.</param>
        /// 
        /// <returns>Returns a  CreateCacheClusterResult from ElastiCache.</returns>
        public  CreateCacheClusterResponse EndCreateCacheCluster(IAsyncResult asyncResult)
        {
            return endOperation< CreateCacheClusterResponse>(asyncResult);
        }

        IAsyncResult invokeCreateCacheCluster(CreateCacheClusterRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new CreateCacheClusterRequestMarshaller();
            var unmarshaller = CreateCacheClusterResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  CreateCacheParameterGroup


        /// <summary>
        /// The <i>CreateCacheParameterGroup</i> operation creates a new cache parameter group.
        /// A cache parameter group is a collection of parameters that you apply to all of the
        /// nodes in a cache cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCacheParameterGroup service method.</param>
        /// 
        /// <returns>The response from the CreateCacheParameterGroup service method, as returned by ElastiCache.</returns>
        /// <exception cref="CacheParameterGroupAlreadyExistsException">
        /// A cache parameter group with the requested name already exists.
        /// </exception>
        /// <exception cref="CacheParameterGroupQuotaExceededException">
        /// The request cannot be processed because it would exceed the maximum number of cache
        /// security groups.
        /// </exception>
        /// <exception cref="InvalidCacheParameterGroupStateException">
        /// The current state of the cache parameter group does not allow the requested action
        /// to occur.
        /// </exception>
        /// <exception cref="InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        public CreateCacheParameterGroupResponse CreateCacheParameterGroup(CreateCacheParameterGroupRequest request)
        {
            IAsyncResult asyncResult = invokeCreateCacheParameterGroup(request, null, null, true);
            return EndCreateCacheParameterGroup(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCacheParameterGroup operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCacheParameterGroup operation on AmazonElastiCacheClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateCacheParameterGroup
        ///         operation.</returns>
        public IAsyncResult BeginCreateCacheParameterGroup(CreateCacheParameterGroupRequest request, AsyncCallback callback, object state)
        {
            return invokeCreateCacheParameterGroup(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateCacheParameterGroup operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCacheParameterGroup.</param>
        /// 
        /// <returns>Returns a  CreateCacheParameterGroupResult from ElastiCache.</returns>
        public  CreateCacheParameterGroupResponse EndCreateCacheParameterGroup(IAsyncResult asyncResult)
        {
            return endOperation< CreateCacheParameterGroupResponse>(asyncResult);
        }

        IAsyncResult invokeCreateCacheParameterGroup(CreateCacheParameterGroupRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new CreateCacheParameterGroupRequestMarshaller();
            var unmarshaller = CreateCacheParameterGroupResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  CreateCacheSecurityGroup


        /// <summary>
        /// The <i>CreateCacheSecurityGroup</i> operation creates a new cache security group.
        /// Use a cache security group to control access to one or more cache clusters.
        /// 
        ///  
        /// <para>
        /// Cache security groups are only used when you are creating a cluster outside of an
        /// Amazon Virtual Private Cloud (VPC). If you are creating a cluster inside of a VPC,
        /// use a cache subnet group instead. For more information, see <i>CreateCacheSubnetGroup</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCacheSecurityGroup service method.</param>
        /// 
        /// <returns>The response from the CreateCacheSecurityGroup service method, as returned by ElastiCache.</returns>
        /// <exception cref="CacheSecurityGroupAlreadyExistsException">
        /// A cache security group with the specified name already exists.
        /// </exception>
        /// <exception cref="CacheSecurityGroupQuotaExceededException">
        /// The request cannot be processed because it would exceed the allowed number of cache
        /// security groups.
        /// </exception>
        /// <exception cref="InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        public CreateCacheSecurityGroupResponse CreateCacheSecurityGroup(CreateCacheSecurityGroupRequest request)
        {
            IAsyncResult asyncResult = invokeCreateCacheSecurityGroup(request, null, null, true);
            return EndCreateCacheSecurityGroup(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCacheSecurityGroup operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCacheSecurityGroup operation on AmazonElastiCacheClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateCacheSecurityGroup
        ///         operation.</returns>
        public IAsyncResult BeginCreateCacheSecurityGroup(CreateCacheSecurityGroupRequest request, AsyncCallback callback, object state)
        {
            return invokeCreateCacheSecurityGroup(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateCacheSecurityGroup operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCacheSecurityGroup.</param>
        /// 
        /// <returns>Returns a  CreateCacheSecurityGroupResult from ElastiCache.</returns>
        public  CreateCacheSecurityGroupResponse EndCreateCacheSecurityGroup(IAsyncResult asyncResult)
        {
            return endOperation< CreateCacheSecurityGroupResponse>(asyncResult);
        }

        IAsyncResult invokeCreateCacheSecurityGroup(CreateCacheSecurityGroupRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new CreateCacheSecurityGroupRequestMarshaller();
            var unmarshaller = CreateCacheSecurityGroupResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  CreateCacheSubnetGroup


        /// <summary>
        /// The <i>CreateCacheSubnetGroup</i> operation creates a new cache subnet group.
        /// 
        ///  
        /// <para>
        /// Use this parameter only when you are creating a cluster in an Amazon Virtual Private
        /// Cloud (VPC).
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCacheSubnetGroup service method.</param>
        /// 
        /// <returns>The response from the CreateCacheSubnetGroup service method, as returned by ElastiCache.</returns>
        /// <exception cref="CacheSubnetGroupAlreadyExistsException">
        /// The requested cache subnet group name is already in use by an existing cache subnet
        /// group.
        /// </exception>
        /// <exception cref="CacheSubnetGroupQuotaExceededException">
        /// The request cannot be processed because it would exceed the allowed number of cache
        /// subnet groups.
        /// </exception>
        /// <exception cref="CacheSubnetQuotaExceededException">
        /// The request cannot be processed because it would exceed the allowed number of subnets
        /// in a cache subnet group.
        /// </exception>
        /// <exception cref="InvalidSubnetException">
        /// An invalid subnet identifier was specified.
        /// </exception>
        public CreateCacheSubnetGroupResponse CreateCacheSubnetGroup(CreateCacheSubnetGroupRequest request)
        {
            IAsyncResult asyncResult = invokeCreateCacheSubnetGroup(request, null, null, true);
            return EndCreateCacheSubnetGroup(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCacheSubnetGroup operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCacheSubnetGroup operation on AmazonElastiCacheClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateCacheSubnetGroup
        ///         operation.</returns>
        public IAsyncResult BeginCreateCacheSubnetGroup(CreateCacheSubnetGroupRequest request, AsyncCallback callback, object state)
        {
            return invokeCreateCacheSubnetGroup(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateCacheSubnetGroup operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCacheSubnetGroup.</param>
        /// 
        /// <returns>Returns a  CreateCacheSubnetGroupResult from ElastiCache.</returns>
        public  CreateCacheSubnetGroupResponse EndCreateCacheSubnetGroup(IAsyncResult asyncResult)
        {
            return endOperation< CreateCacheSubnetGroupResponse>(asyncResult);
        }

        IAsyncResult invokeCreateCacheSubnetGroup(CreateCacheSubnetGroupRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new CreateCacheSubnetGroupRequestMarshaller();
            var unmarshaller = CreateCacheSubnetGroupResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  CreateReplicationGroup


        /// <summary>
        /// The <i>CreateReplicationGroup</i> operation creates a replication group. A replication
        /// group is a collection of cache clusters, where one of the clusters is a read/write
        /// primary and the other clusters are read-only replicas. Writes to the primary are automatically
        /// propagated to the replicas.
        /// 
        ///  
        /// <para>
        /// When you create a replication group, you must specify an existing cache cluster that
        /// is in the primary role. When the replication group has been successfully created,
        /// you can add one or more read replica replicas to it, up to a total of five read replicas.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateReplicationGroup service method.</param>
        /// 
        /// <returns>The response from the CreateReplicationGroup service method, as returned by ElastiCache.</returns>
        /// <exception cref="CacheClusterNotFoundException">
        /// The requested cache cluster ID does not refer to an existing cache cluster.
        /// </exception>
        /// <exception cref="InvalidCacheClusterStateException">
        /// The requested cache cluster is not in the <i>available</i> state.
        /// </exception>
        /// <exception cref="InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        /// <exception cref="ReplicationGroupAlreadyExistsException">
        /// The specified replication group already exists.
        /// </exception>
        public CreateReplicationGroupResponse CreateReplicationGroup(CreateReplicationGroupRequest request)
        {
            IAsyncResult asyncResult = invokeCreateReplicationGroup(request, null, null, true);
            return EndCreateReplicationGroup(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateReplicationGroup operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateReplicationGroup operation on AmazonElastiCacheClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateReplicationGroup
        ///         operation.</returns>
        public IAsyncResult BeginCreateReplicationGroup(CreateReplicationGroupRequest request, AsyncCallback callback, object state)
        {
            return invokeCreateReplicationGroup(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateReplicationGroup operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateReplicationGroup.</param>
        /// 
        /// <returns>Returns a  CreateReplicationGroupResult from ElastiCache.</returns>
        public  CreateReplicationGroupResponse EndCreateReplicationGroup(IAsyncResult asyncResult)
        {
            return endOperation< CreateReplicationGroupResponse>(asyncResult);
        }

        IAsyncResult invokeCreateReplicationGroup(CreateReplicationGroupRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new CreateReplicationGroupRequestMarshaller();
            var unmarshaller = CreateReplicationGroupResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  CreateSnapshot


        /// <summary>
        /// The <i>CreateSnapshot</i> operation creates a copy of an entire cache cluster at a
        /// specific moment in time.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSnapshot service method.</param>
        /// 
        /// <returns>The response from the CreateSnapshot service method, as returned by ElastiCache.</returns>
        /// <exception cref="CacheClusterNotFoundException">
        /// The requested cache cluster ID does not refer to an existing cache cluster.
        /// </exception>
        /// <exception cref="InvalidCacheClusterStateException">
        /// The requested cache cluster is not in the <i>available</i> state.
        /// </exception>
        /// <exception cref="InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        /// <exception cref="SnapshotAlreadyExistsException">
        /// You already have a snapshot with the given name.
        /// </exception>
        /// <exception cref="SnapshotFeatureNotSupportedException">
        /// You attempted one of the following actions:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Creating a snapshot of a Redis cache cluster running on a a <i>t1.micro</i> cache
        /// node.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Creating a snapshot of a cache cluster that is running Memcached rather than Redis.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Neither of these are supported by ElastiCache.
        /// </para>
        /// </exception>
        /// <exception cref="SnapshotQuotaExceededException">
        /// The request cannot be processed because it would exceed the maximum number of snapshots.
        /// </exception>
        public CreateSnapshotResponse CreateSnapshot(CreateSnapshotRequest request)
        {
            IAsyncResult asyncResult = invokeCreateSnapshot(request, null, null, true);
            return EndCreateSnapshot(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSnapshot operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSnapshot operation on AmazonElastiCacheClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSnapshot
        ///         operation.</returns>
        public IAsyncResult BeginCreateSnapshot(CreateSnapshotRequest request, AsyncCallback callback, object state)
        {
            return invokeCreateSnapshot(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSnapshot operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSnapshot.</param>
        /// 
        /// <returns>Returns a  CreateSnapshotResult from ElastiCache.</returns>
        public  CreateSnapshotResponse EndCreateSnapshot(IAsyncResult asyncResult)
        {
            return endOperation< CreateSnapshotResponse>(asyncResult);
        }

        IAsyncResult invokeCreateSnapshot(CreateSnapshotRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new CreateSnapshotRequestMarshaller();
            var unmarshaller = CreateSnapshotResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  DeleteCacheCluster


        /// <summary>
        /// The <i>DeleteCacheCluster</i> operation deletes a previously provisioned cache cluster.
        /// <i>DeleteCacheCluster</i> deletes all associated cache nodes, node endpoints and the
        /// cache cluster itself. When you receive a successful response from this operation,
        /// Amazon ElastiCache immediately begins deleting the cache cluster; you cannot cancel
        /// or revert this operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCacheCluster service method.</param>
        /// 
        /// <returns>The response from the DeleteCacheCluster service method, as returned by ElastiCache.</returns>
        /// <exception cref="CacheClusterNotFoundException">
        /// The requested cache cluster ID does not refer to an existing cache cluster.
        /// </exception>
        /// <exception cref="InvalidCacheClusterStateException">
        /// The requested cache cluster is not in the <i>available</i> state.
        /// </exception>
        /// <exception cref="InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        /// <exception cref="SnapshotAlreadyExistsException">
        /// You already have a snapshot with the given name.
        /// </exception>
        /// <exception cref="SnapshotFeatureNotSupportedException">
        /// You attempted one of the following actions:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Creating a snapshot of a Redis cache cluster running on a a <i>t1.micro</i> cache
        /// node.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Creating a snapshot of a cache cluster that is running Memcached rather than Redis.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Neither of these are supported by ElastiCache.
        /// </para>
        /// </exception>
        /// <exception cref="SnapshotQuotaExceededException">
        /// The request cannot be processed because it would exceed the maximum number of snapshots.
        /// </exception>
        public DeleteCacheClusterResponse DeleteCacheCluster(DeleteCacheClusterRequest request)
        {
            IAsyncResult asyncResult = invokeDeleteCacheCluster(request, null, null, true);
            return EndDeleteCacheCluster(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCacheCluster operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCacheCluster operation on AmazonElastiCacheClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteCacheCluster
        ///         operation.</returns>
        public IAsyncResult BeginDeleteCacheCluster(DeleteCacheClusterRequest request, AsyncCallback callback, object state)
        {
            return invokeDeleteCacheCluster(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteCacheCluster operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCacheCluster.</param>
        /// 
        /// <returns>Returns a  DeleteCacheClusterResult from ElastiCache.</returns>
        public  DeleteCacheClusterResponse EndDeleteCacheCluster(IAsyncResult asyncResult)
        {
            return endOperation< DeleteCacheClusterResponse>(asyncResult);
        }

        IAsyncResult invokeDeleteCacheCluster(DeleteCacheClusterRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new DeleteCacheClusterRequestMarshaller();
            var unmarshaller = DeleteCacheClusterResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  DeleteCacheParameterGroup


        /// <summary>
        /// The <i>DeleteCacheParameterGroup</i> operation deletes the specified cache parameter
        /// group. You cannot delete a cache parameter group if it is associated with any cache
        /// clusters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCacheParameterGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteCacheParameterGroup service method, as returned by ElastiCache.</returns>
        /// <exception cref="CacheParameterGroupNotFoundException">
        /// The requested cache parameter group name does not refer to an existing cache parameter
        /// group.
        /// </exception>
        /// <exception cref="InvalidCacheParameterGroupStateException">
        /// The current state of the cache parameter group does not allow the requested action
        /// to occur.
        /// </exception>
        /// <exception cref="InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        public DeleteCacheParameterGroupResponse DeleteCacheParameterGroup(DeleteCacheParameterGroupRequest request)
        {
            IAsyncResult asyncResult = invokeDeleteCacheParameterGroup(request, null, null, true);
            return EndDeleteCacheParameterGroup(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCacheParameterGroup operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCacheParameterGroup operation on AmazonElastiCacheClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteCacheParameterGroup
        ///         operation.</returns>
        public IAsyncResult BeginDeleteCacheParameterGroup(DeleteCacheParameterGroupRequest request, AsyncCallback callback, object state)
        {
            return invokeDeleteCacheParameterGroup(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteCacheParameterGroup operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCacheParameterGroup.</param>
        /// 
        /// <returns>Returns a  DeleteCacheParameterGroupResult from ElastiCache.</returns>
        public  DeleteCacheParameterGroupResponse EndDeleteCacheParameterGroup(IAsyncResult asyncResult)
        {
            return endOperation< DeleteCacheParameterGroupResponse>(asyncResult);
        }

        IAsyncResult invokeDeleteCacheParameterGroup(DeleteCacheParameterGroupRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new DeleteCacheParameterGroupRequestMarshaller();
            var unmarshaller = DeleteCacheParameterGroupResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  DeleteCacheSecurityGroup


        /// <summary>
        /// The <i>DeleteCacheSecurityGroup</i> operation deletes a cache security group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCacheSecurityGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteCacheSecurityGroup service method, as returned by ElastiCache.</returns>
        /// <exception cref="CacheSecurityGroupNotFoundException">
        /// The requested cache security group name does not refer to an existing cache security
        /// group.
        /// </exception>
        /// <exception cref="InvalidCacheSecurityGroupStateException">
        /// The current state of the cache security group does not allow deletion.
        /// </exception>
        /// <exception cref="InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        public DeleteCacheSecurityGroupResponse DeleteCacheSecurityGroup(DeleteCacheSecurityGroupRequest request)
        {
            IAsyncResult asyncResult = invokeDeleteCacheSecurityGroup(request, null, null, true);
            return EndDeleteCacheSecurityGroup(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCacheSecurityGroup operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCacheSecurityGroup operation on AmazonElastiCacheClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteCacheSecurityGroup
        ///         operation.</returns>
        public IAsyncResult BeginDeleteCacheSecurityGroup(DeleteCacheSecurityGroupRequest request, AsyncCallback callback, object state)
        {
            return invokeDeleteCacheSecurityGroup(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteCacheSecurityGroup operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCacheSecurityGroup.</param>
        /// 
        /// <returns>Returns a  DeleteCacheSecurityGroupResult from ElastiCache.</returns>
        public  DeleteCacheSecurityGroupResponse EndDeleteCacheSecurityGroup(IAsyncResult asyncResult)
        {
            return endOperation< DeleteCacheSecurityGroupResponse>(asyncResult);
        }

        IAsyncResult invokeDeleteCacheSecurityGroup(DeleteCacheSecurityGroupRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new DeleteCacheSecurityGroupRequestMarshaller();
            var unmarshaller = DeleteCacheSecurityGroupResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  DeleteCacheSubnetGroup


        /// <summary>
        /// The <i>DeleteCacheSubnetGroup</i> operation deletes a cache subnet group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCacheSubnetGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteCacheSubnetGroup service method, as returned by ElastiCache.</returns>
        /// <exception cref="CacheSubnetGroupInUseException">
        /// The requested cache subnet group is currently in use.
        /// </exception>
        /// <exception cref="CacheSubnetGroupNotFoundException">
        /// The requested cache subnet group name does not refer to an existing cache subnet group.
        /// </exception>
        public DeleteCacheSubnetGroupResponse DeleteCacheSubnetGroup(DeleteCacheSubnetGroupRequest request)
        {
            IAsyncResult asyncResult = invokeDeleteCacheSubnetGroup(request, null, null, true);
            return EndDeleteCacheSubnetGroup(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCacheSubnetGroup operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCacheSubnetGroup operation on AmazonElastiCacheClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteCacheSubnetGroup
        ///         operation.</returns>
        public IAsyncResult BeginDeleteCacheSubnetGroup(DeleteCacheSubnetGroupRequest request, AsyncCallback callback, object state)
        {
            return invokeDeleteCacheSubnetGroup(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteCacheSubnetGroup operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCacheSubnetGroup.</param>
        /// 
        /// <returns>Returns a  DeleteCacheSubnetGroupResult from ElastiCache.</returns>
        public  DeleteCacheSubnetGroupResponse EndDeleteCacheSubnetGroup(IAsyncResult asyncResult)
        {
            return endOperation< DeleteCacheSubnetGroupResponse>(asyncResult);
        }

        IAsyncResult invokeDeleteCacheSubnetGroup(DeleteCacheSubnetGroupRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new DeleteCacheSubnetGroupRequestMarshaller();
            var unmarshaller = DeleteCacheSubnetGroupResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  DeleteReplicationGroup


        /// <summary>
        /// The <i>DeleteReplicationGroup</i> operation deletes an existing replication group.
        /// By default, this operation deletes the entire replication group, including the primary
        /// cache cluster and all of the read replicas. You can optionally delete only the read
        /// replicas, while retaining the primary cache cluster.
        /// 
        ///  
        /// <para>
        /// When you receive a successful response from this operation, Amazon ElastiCache immediately
        /// begins deleting the selected resources; you cannot cancel or revert this operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteReplicationGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteReplicationGroup service method, as returned by ElastiCache.</returns>
        /// <exception cref="InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        /// <exception cref="InvalidReplicationGroupStateException">
        /// The requested replication group is not in the <i>available</i> state.
        /// </exception>
        /// <exception cref="ReplicationGroupNotFoundException">
        /// The specified replication group does not exist.
        /// </exception>
        /// <exception cref="SnapshotAlreadyExistsException">
        /// You already have a snapshot with the given name.
        /// </exception>
        /// <exception cref="SnapshotFeatureNotSupportedException">
        /// You attempted one of the following actions:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Creating a snapshot of a Redis cache cluster running on a a <i>t1.micro</i> cache
        /// node.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Creating a snapshot of a cache cluster that is running Memcached rather than Redis.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Neither of these are supported by ElastiCache.
        /// </para>
        /// </exception>
        /// <exception cref="SnapshotQuotaExceededException">
        /// The request cannot be processed because it would exceed the maximum number of snapshots.
        /// </exception>
        public DeleteReplicationGroupResponse DeleteReplicationGroup(DeleteReplicationGroupRequest request)
        {
            IAsyncResult asyncResult = invokeDeleteReplicationGroup(request, null, null, true);
            return EndDeleteReplicationGroup(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteReplicationGroup operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteReplicationGroup operation on AmazonElastiCacheClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteReplicationGroup
        ///         operation.</returns>
        public IAsyncResult BeginDeleteReplicationGroup(DeleteReplicationGroupRequest request, AsyncCallback callback, object state)
        {
            return invokeDeleteReplicationGroup(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteReplicationGroup operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteReplicationGroup.</param>
        /// 
        /// <returns>Returns a  DeleteReplicationGroupResult from ElastiCache.</returns>
        public  DeleteReplicationGroupResponse EndDeleteReplicationGroup(IAsyncResult asyncResult)
        {
            return endOperation< DeleteReplicationGroupResponse>(asyncResult);
        }

        IAsyncResult invokeDeleteReplicationGroup(DeleteReplicationGroupRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new DeleteReplicationGroupRequestMarshaller();
            var unmarshaller = DeleteReplicationGroupResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  DeleteSnapshot


        /// <summary>
        /// The <i>DeleteSnapshot</i> operation deletes an existing snapshot. When you receive
        /// a successful response from this operation, ElastiCache immediately begins deleting
        /// the snapshot; you cannot cancel or revert this operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSnapshot service method.</param>
        /// 
        /// <returns>The response from the DeleteSnapshot service method, as returned by ElastiCache.</returns>
        /// <exception cref="InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        /// <exception cref="InvalidSnapshotStateException">
        /// The current state of the snapshot does not allow the requested action to occur.
        /// </exception>
        /// <exception cref="SnapshotNotFoundException">
        /// The requested snapshot name does not refer to an existing snapshot.
        /// </exception>
        public DeleteSnapshotResponse DeleteSnapshot(DeleteSnapshotRequest request)
        {
            IAsyncResult asyncResult = invokeDeleteSnapshot(request, null, null, true);
            return EndDeleteSnapshot(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSnapshot operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSnapshot operation on AmazonElastiCacheClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSnapshot
        ///         operation.</returns>
        public IAsyncResult BeginDeleteSnapshot(DeleteSnapshotRequest request, AsyncCallback callback, object state)
        {
            return invokeDeleteSnapshot(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSnapshot operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSnapshot.</param>
        /// 
        /// <returns>Returns a  DeleteSnapshotResult from ElastiCache.</returns>
        public  DeleteSnapshotResponse EndDeleteSnapshot(IAsyncResult asyncResult)
        {
            return endOperation< DeleteSnapshotResponse>(asyncResult);
        }

        IAsyncResult invokeDeleteSnapshot(DeleteSnapshotRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new DeleteSnapshotRequestMarshaller();
            var unmarshaller = DeleteSnapshotResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  DescribeCacheClusters

        /// <summary>
        /// The <i>DescribeCacheClusters</i> operation returns information about all provisioned
        /// cache clusters if no cache cluster identifier is specified, or about a specific cache
        /// cluster if a cache cluster identifier is supplied.
        /// 
        ///  
        /// <para>
        /// By default, abbreviated information about the cache clusters(s) will be returned.
        /// You can use the optional <i>ShowDetails</i> flag to retrieve detailed information
        /// about the cache nodes associated with the cache clusters. These details include the
        /// DNS address and port for the cache node endpoint.
        /// </para>
        ///  
        /// <para>
        /// If the cluster is in the CREATING state, only cluster level information will be displayed
        /// until all of the nodes are successfully provisioned.
        /// </para>
        ///  
        /// <para>
        /// If the cluster is in the DELETING state, only cluster level information will be displayed.
        /// </para>
        ///  
        /// <para>
        /// If cache nodes are currently being added to the cache cluster, node endpoint information
        /// and creation time for the additional nodes will not be displayed until they are completely
        /// provisioned. When the cache cluster state is <i>available</i>, the cluster is ready
        /// for use.
        /// </para>
        ///  
        /// <para>
        /// If cache nodes are currently being removed from the cache cluster, no endpoint information
        /// for the removed nodes is displayed.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeCacheClusters service method, as returned by ElastiCache.</returns>
        /// <exception cref="CacheClusterNotFoundException">
        /// The requested cache cluster ID does not refer to an existing cache cluster.
        /// </exception>
        /// <exception cref="InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        public DescribeCacheClustersResponse DescribeCacheClusters()
        {
            return DescribeCacheClusters(new DescribeCacheClustersRequest());
        }

        /// <summary>
        /// The <i>DescribeCacheClusters</i> operation returns information about all provisioned
        /// cache clusters if no cache cluster identifier is specified, or about a specific cache
        /// cluster if a cache cluster identifier is supplied.
        /// 
        ///  
        /// <para>
        /// By default, abbreviated information about the cache clusters(s) will be returned.
        /// You can use the optional <i>ShowDetails</i> flag to retrieve detailed information
        /// about the cache nodes associated with the cache clusters. These details include the
        /// DNS address and port for the cache node endpoint.
        /// </para>
        ///  
        /// <para>
        /// If the cluster is in the CREATING state, only cluster level information will be displayed
        /// until all of the nodes are successfully provisioned.
        /// </para>
        ///  
        /// <para>
        /// If the cluster is in the DELETING state, only cluster level information will be displayed.
        /// </para>
        ///  
        /// <para>
        /// If cache nodes are currently being added to the cache cluster, node endpoint information
        /// and creation time for the additional nodes will not be displayed until they are completely
        /// provisioned. When the cache cluster state is <i>available</i>, the cluster is ready
        /// for use.
        /// </para>
        ///  
        /// <para>
        /// If cache nodes are currently being removed from the cache cluster, no endpoint information
        /// for the removed nodes is displayed.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCacheClusters service method.</param>
        /// 
        /// <returns>The response from the DescribeCacheClusters service method, as returned by ElastiCache.</returns>
        /// <exception cref="CacheClusterNotFoundException">
        /// The requested cache cluster ID does not refer to an existing cache cluster.
        /// </exception>
        /// <exception cref="InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        public DescribeCacheClustersResponse DescribeCacheClusters(DescribeCacheClustersRequest request)
        {
            IAsyncResult asyncResult = invokeDescribeCacheClusters(request, null, null, true);
            return EndDescribeCacheClusters(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCacheClusters operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCacheClusters operation on AmazonElastiCacheClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeCacheClusters
        ///         operation.</returns>
        public IAsyncResult BeginDescribeCacheClusters(DescribeCacheClustersRequest request, AsyncCallback callback, object state)
        {
            return invokeDescribeCacheClusters(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeCacheClusters operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeCacheClusters.</param>
        /// 
        /// <returns>Returns a  DescribeCacheClustersResult from ElastiCache.</returns>
        public  DescribeCacheClustersResponse EndDescribeCacheClusters(IAsyncResult asyncResult)
        {
            return endOperation< DescribeCacheClustersResponse>(asyncResult);
        }

        IAsyncResult invokeDescribeCacheClusters(DescribeCacheClustersRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new DescribeCacheClustersRequestMarshaller();
            var unmarshaller = DescribeCacheClustersResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  DescribeCacheEngineVersions

        /// <summary>
        /// The <i>DescribeCacheEngineVersions</i> operation returns a list of the available cache
        /// engines and their versions.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeCacheEngineVersions service method, as returned by ElastiCache.</returns>
        public DescribeCacheEngineVersionsResponse DescribeCacheEngineVersions()
        {
            return DescribeCacheEngineVersions(new DescribeCacheEngineVersionsRequest());
        }

        /// <summary>
        /// The <i>DescribeCacheEngineVersions</i> operation returns a list of the available cache
        /// engines and their versions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCacheEngineVersions service method.</param>
        /// 
        /// <returns>The response from the DescribeCacheEngineVersions service method, as returned by ElastiCache.</returns>
        public DescribeCacheEngineVersionsResponse DescribeCacheEngineVersions(DescribeCacheEngineVersionsRequest request)
        {
            IAsyncResult asyncResult = invokeDescribeCacheEngineVersions(request, null, null, true);
            return EndDescribeCacheEngineVersions(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCacheEngineVersions operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCacheEngineVersions operation on AmazonElastiCacheClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeCacheEngineVersions
        ///         operation.</returns>
        public IAsyncResult BeginDescribeCacheEngineVersions(DescribeCacheEngineVersionsRequest request, AsyncCallback callback, object state)
        {
            return invokeDescribeCacheEngineVersions(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeCacheEngineVersions operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeCacheEngineVersions.</param>
        /// 
        /// <returns>Returns a  DescribeCacheEngineVersionsResult from ElastiCache.</returns>
        public  DescribeCacheEngineVersionsResponse EndDescribeCacheEngineVersions(IAsyncResult asyncResult)
        {
            return endOperation< DescribeCacheEngineVersionsResponse>(asyncResult);
        }

        IAsyncResult invokeDescribeCacheEngineVersions(DescribeCacheEngineVersionsRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new DescribeCacheEngineVersionsRequestMarshaller();
            var unmarshaller = DescribeCacheEngineVersionsResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  DescribeCacheParameterGroups

        /// <summary>
        /// The <i>DescribeCacheParameterGroups</i> operation returns a list of cache parameter
        /// group descriptions. If a cache parameter group name is specified, the list will contain
        /// only the descriptions for that group.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeCacheParameterGroups service method, as returned by ElastiCache.</returns>
        /// <exception cref="CacheParameterGroupNotFoundException">
        /// The requested cache parameter group name does not refer to an existing cache parameter
        /// group.
        /// </exception>
        /// <exception cref="InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        public DescribeCacheParameterGroupsResponse DescribeCacheParameterGroups()
        {
            return DescribeCacheParameterGroups(new DescribeCacheParameterGroupsRequest());
        }

        /// <summary>
        /// The <i>DescribeCacheParameterGroups</i> operation returns a list of cache parameter
        /// group descriptions. If a cache parameter group name is specified, the list will contain
        /// only the descriptions for that group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCacheParameterGroups service method.</param>
        /// 
        /// <returns>The response from the DescribeCacheParameterGroups service method, as returned by ElastiCache.</returns>
        /// <exception cref="CacheParameterGroupNotFoundException">
        /// The requested cache parameter group name does not refer to an existing cache parameter
        /// group.
        /// </exception>
        /// <exception cref="InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        public DescribeCacheParameterGroupsResponse DescribeCacheParameterGroups(DescribeCacheParameterGroupsRequest request)
        {
            IAsyncResult asyncResult = invokeDescribeCacheParameterGroups(request, null, null, true);
            return EndDescribeCacheParameterGroups(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCacheParameterGroups operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCacheParameterGroups operation on AmazonElastiCacheClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeCacheParameterGroups
        ///         operation.</returns>
        public IAsyncResult BeginDescribeCacheParameterGroups(DescribeCacheParameterGroupsRequest request, AsyncCallback callback, object state)
        {
            return invokeDescribeCacheParameterGroups(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeCacheParameterGroups operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeCacheParameterGroups.</param>
        /// 
        /// <returns>Returns a  DescribeCacheParameterGroupsResult from ElastiCache.</returns>
        public  DescribeCacheParameterGroupsResponse EndDescribeCacheParameterGroups(IAsyncResult asyncResult)
        {
            return endOperation< DescribeCacheParameterGroupsResponse>(asyncResult);
        }

        IAsyncResult invokeDescribeCacheParameterGroups(DescribeCacheParameterGroupsRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new DescribeCacheParameterGroupsRequestMarshaller();
            var unmarshaller = DescribeCacheParameterGroupsResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  DescribeCacheParameters


        /// <summary>
        /// The <i>DescribeCacheParameters</i> operation returns the detailed parameter list for
        /// a particular cache parameter group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCacheParameters service method.</param>
        /// 
        /// <returns>The response from the DescribeCacheParameters service method, as returned by ElastiCache.</returns>
        /// <exception cref="CacheParameterGroupNotFoundException">
        /// The requested cache parameter group name does not refer to an existing cache parameter
        /// group.
        /// </exception>
        /// <exception cref="InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        public DescribeCacheParametersResponse DescribeCacheParameters(DescribeCacheParametersRequest request)
        {
            IAsyncResult asyncResult = invokeDescribeCacheParameters(request, null, null, true);
            return EndDescribeCacheParameters(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCacheParameters operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCacheParameters operation on AmazonElastiCacheClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeCacheParameters
        ///         operation.</returns>
        public IAsyncResult BeginDescribeCacheParameters(DescribeCacheParametersRequest request, AsyncCallback callback, object state)
        {
            return invokeDescribeCacheParameters(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeCacheParameters operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeCacheParameters.</param>
        /// 
        /// <returns>Returns a  DescribeCacheParametersResult from ElastiCache.</returns>
        public  DescribeCacheParametersResponse EndDescribeCacheParameters(IAsyncResult asyncResult)
        {
            return endOperation< DescribeCacheParametersResponse>(asyncResult);
        }

        IAsyncResult invokeDescribeCacheParameters(DescribeCacheParametersRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new DescribeCacheParametersRequestMarshaller();
            var unmarshaller = DescribeCacheParametersResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  DescribeCacheSecurityGroups

        /// <summary>
        /// The <i>DescribeCacheSecurityGroups</i> operation returns a list of cache security
        /// group descriptions. If a cache security group name is specified, the list will contain
        /// only the description of that group.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeCacheSecurityGroups service method, as returned by ElastiCache.</returns>
        /// <exception cref="CacheSecurityGroupNotFoundException">
        /// The requested cache security group name does not refer to an existing cache security
        /// group.
        /// </exception>
        /// <exception cref="InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        public DescribeCacheSecurityGroupsResponse DescribeCacheSecurityGroups()
        {
            return DescribeCacheSecurityGroups(new DescribeCacheSecurityGroupsRequest());
        }

        /// <summary>
        /// The <i>DescribeCacheSecurityGroups</i> operation returns a list of cache security
        /// group descriptions. If a cache security group name is specified, the list will contain
        /// only the description of that group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCacheSecurityGroups service method.</param>
        /// 
        /// <returns>The response from the DescribeCacheSecurityGroups service method, as returned by ElastiCache.</returns>
        /// <exception cref="CacheSecurityGroupNotFoundException">
        /// The requested cache security group name does not refer to an existing cache security
        /// group.
        /// </exception>
        /// <exception cref="InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        public DescribeCacheSecurityGroupsResponse DescribeCacheSecurityGroups(DescribeCacheSecurityGroupsRequest request)
        {
            IAsyncResult asyncResult = invokeDescribeCacheSecurityGroups(request, null, null, true);
            return EndDescribeCacheSecurityGroups(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCacheSecurityGroups operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCacheSecurityGroups operation on AmazonElastiCacheClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeCacheSecurityGroups
        ///         operation.</returns>
        public IAsyncResult BeginDescribeCacheSecurityGroups(DescribeCacheSecurityGroupsRequest request, AsyncCallback callback, object state)
        {
            return invokeDescribeCacheSecurityGroups(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeCacheSecurityGroups operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeCacheSecurityGroups.</param>
        /// 
        /// <returns>Returns a  DescribeCacheSecurityGroupsResult from ElastiCache.</returns>
        public  DescribeCacheSecurityGroupsResponse EndDescribeCacheSecurityGroups(IAsyncResult asyncResult)
        {
            return endOperation< DescribeCacheSecurityGroupsResponse>(asyncResult);
        }

        IAsyncResult invokeDescribeCacheSecurityGroups(DescribeCacheSecurityGroupsRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new DescribeCacheSecurityGroupsRequestMarshaller();
            var unmarshaller = DescribeCacheSecurityGroupsResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  DescribeCacheSubnetGroups

        /// <summary>
        /// The <i>DescribeCacheSubnetGroups</i> operation returns a list of cache subnet group
        /// descriptions. If a subnet group name is specified, the list will contain only the
        /// description of that group.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeCacheSubnetGroups service method, as returned by ElastiCache.</returns>
        /// <exception cref="CacheSubnetGroupNotFoundException">
        /// The requested cache subnet group name does not refer to an existing cache subnet group.
        /// </exception>
        public DescribeCacheSubnetGroupsResponse DescribeCacheSubnetGroups()
        {
            return DescribeCacheSubnetGroups(new DescribeCacheSubnetGroupsRequest());
        }

        /// <summary>
        /// The <i>DescribeCacheSubnetGroups</i> operation returns a list of cache subnet group
        /// descriptions. If a subnet group name is specified, the list will contain only the
        /// description of that group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCacheSubnetGroups service method.</param>
        /// 
        /// <returns>The response from the DescribeCacheSubnetGroups service method, as returned by ElastiCache.</returns>
        /// <exception cref="CacheSubnetGroupNotFoundException">
        /// The requested cache subnet group name does not refer to an existing cache subnet group.
        /// </exception>
        public DescribeCacheSubnetGroupsResponse DescribeCacheSubnetGroups(DescribeCacheSubnetGroupsRequest request)
        {
            IAsyncResult asyncResult = invokeDescribeCacheSubnetGroups(request, null, null, true);
            return EndDescribeCacheSubnetGroups(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCacheSubnetGroups operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCacheSubnetGroups operation on AmazonElastiCacheClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeCacheSubnetGroups
        ///         operation.</returns>
        public IAsyncResult BeginDescribeCacheSubnetGroups(DescribeCacheSubnetGroupsRequest request, AsyncCallback callback, object state)
        {
            return invokeDescribeCacheSubnetGroups(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeCacheSubnetGroups operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeCacheSubnetGroups.</param>
        /// 
        /// <returns>Returns a  DescribeCacheSubnetGroupsResult from ElastiCache.</returns>
        public  DescribeCacheSubnetGroupsResponse EndDescribeCacheSubnetGroups(IAsyncResult asyncResult)
        {
            return endOperation< DescribeCacheSubnetGroupsResponse>(asyncResult);
        }

        IAsyncResult invokeDescribeCacheSubnetGroups(DescribeCacheSubnetGroupsRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new DescribeCacheSubnetGroupsRequestMarshaller();
            var unmarshaller = DescribeCacheSubnetGroupsResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  DescribeEngineDefaultParameters


        /// <summary>
        /// The <i>DescribeEngineDefaultParameters</i> operation returns the default engine and
        /// system parameter information for the specified cache engine.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEngineDefaultParameters service method.</param>
        /// 
        /// <returns>The response from the DescribeEngineDefaultParameters service method, as returned by ElastiCache.</returns>
        /// <exception cref="InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        public DescribeEngineDefaultParametersResponse DescribeEngineDefaultParameters(DescribeEngineDefaultParametersRequest request)
        {
            IAsyncResult asyncResult = invokeDescribeEngineDefaultParameters(request, null, null, true);
            return EndDescribeEngineDefaultParameters(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEngineDefaultParameters operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEngineDefaultParameters operation on AmazonElastiCacheClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeEngineDefaultParameters
        ///         operation.</returns>
        public IAsyncResult BeginDescribeEngineDefaultParameters(DescribeEngineDefaultParametersRequest request, AsyncCallback callback, object state)
        {
            return invokeDescribeEngineDefaultParameters(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeEngineDefaultParameters operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeEngineDefaultParameters.</param>
        /// 
        /// <returns>Returns a  DescribeEngineDefaultParametersResult from ElastiCache.</returns>
        public  DescribeEngineDefaultParametersResponse EndDescribeEngineDefaultParameters(IAsyncResult asyncResult)
        {
            return endOperation< DescribeEngineDefaultParametersResponse>(asyncResult);
        }

        IAsyncResult invokeDescribeEngineDefaultParameters(DescribeEngineDefaultParametersRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new DescribeEngineDefaultParametersRequestMarshaller();
            var unmarshaller = DescribeEngineDefaultParametersResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  DescribeEvents

        /// <summary>
        /// The <i>DescribeEvents</i> operation returns events related to cache clusters, cache
        /// security groups, and cache parameter groups. You can obtain events specific to a particular
        /// cache cluster, cache security group, or cache parameter group by providing the name
        /// as a parameter.
        /// 
        ///  
        /// <para>
        /// By default, only the events occurring within the last hour are returned; however,
        /// you can retrieve up to 14 days' worth of events if necessary.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeEvents service method, as returned by ElastiCache.</returns>
        /// <exception cref="InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        public DescribeEventsResponse DescribeEvents()
        {
            return DescribeEvents(new DescribeEventsRequest());
        }

        /// <summary>
        /// The <i>DescribeEvents</i> operation returns events related to cache clusters, cache
        /// security groups, and cache parameter groups. You can obtain events specific to a particular
        /// cache cluster, cache security group, or cache parameter group by providing the name
        /// as a parameter.
        /// 
        ///  
        /// <para>
        /// By default, only the events occurring within the last hour are returned; however,
        /// you can retrieve up to 14 days' worth of events if necessary.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEvents service method.</param>
        /// 
        /// <returns>The response from the DescribeEvents service method, as returned by ElastiCache.</returns>
        /// <exception cref="InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        public DescribeEventsResponse DescribeEvents(DescribeEventsRequest request)
        {
            IAsyncResult asyncResult = invokeDescribeEvents(request, null, null, true);
            return EndDescribeEvents(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEvents operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEvents operation on AmazonElastiCacheClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeEvents
        ///         operation.</returns>
        public IAsyncResult BeginDescribeEvents(DescribeEventsRequest request, AsyncCallback callback, object state)
        {
            return invokeDescribeEvents(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeEvents operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeEvents.</param>
        /// 
        /// <returns>Returns a  DescribeEventsResult from ElastiCache.</returns>
        public  DescribeEventsResponse EndDescribeEvents(IAsyncResult asyncResult)
        {
            return endOperation< DescribeEventsResponse>(asyncResult);
        }

        IAsyncResult invokeDescribeEvents(DescribeEventsRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new DescribeEventsRequestMarshaller();
            var unmarshaller = DescribeEventsResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  DescribeReplicationGroups

        /// <summary>
        /// The <i>DescribeReplicationGroups</i> operation returns information about a particular
        /// replication group. If no identifier is specified, <i>DescribeReplicationGroups</i>
        /// returns information about all replication groups.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeReplicationGroups service method, as returned by ElastiCache.</returns>
        /// <exception cref="InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        /// <exception cref="ReplicationGroupNotFoundException">
        /// The specified replication group does not exist.
        /// </exception>
        public DescribeReplicationGroupsResponse DescribeReplicationGroups()
        {
            return DescribeReplicationGroups(new DescribeReplicationGroupsRequest());
        }

        /// <summary>
        /// The <i>DescribeReplicationGroups</i> operation returns information about a particular
        /// replication group. If no identifier is specified, <i>DescribeReplicationGroups</i>
        /// returns information about all replication groups.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReplicationGroups service method.</param>
        /// 
        /// <returns>The response from the DescribeReplicationGroups service method, as returned by ElastiCache.</returns>
        /// <exception cref="InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        /// <exception cref="ReplicationGroupNotFoundException">
        /// The specified replication group does not exist.
        /// </exception>
        public DescribeReplicationGroupsResponse DescribeReplicationGroups(DescribeReplicationGroupsRequest request)
        {
            IAsyncResult asyncResult = invokeDescribeReplicationGroups(request, null, null, true);
            return EndDescribeReplicationGroups(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReplicationGroups operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReplicationGroups operation on AmazonElastiCacheClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeReplicationGroups
        ///         operation.</returns>
        public IAsyncResult BeginDescribeReplicationGroups(DescribeReplicationGroupsRequest request, AsyncCallback callback, object state)
        {
            return invokeDescribeReplicationGroups(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeReplicationGroups operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeReplicationGroups.</param>
        /// 
        /// <returns>Returns a  DescribeReplicationGroupsResult from ElastiCache.</returns>
        public  DescribeReplicationGroupsResponse EndDescribeReplicationGroups(IAsyncResult asyncResult)
        {
            return endOperation< DescribeReplicationGroupsResponse>(asyncResult);
        }

        IAsyncResult invokeDescribeReplicationGroups(DescribeReplicationGroupsRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new DescribeReplicationGroupsRequestMarshaller();
            var unmarshaller = DescribeReplicationGroupsResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  DescribeReservedCacheNodes

        /// <summary>
        /// The <i>DescribeReservedCacheNodes</i> operation returns information about reserved
        /// cache nodes for this account, or about a specified reserved cache node.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeReservedCacheNodes service method, as returned by ElastiCache.</returns>
        /// <exception cref="InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        /// <exception cref="ReservedCacheNodeNotFoundException">
        /// The requested reserved cache node was not found.
        /// </exception>
        public DescribeReservedCacheNodesResponse DescribeReservedCacheNodes()
        {
            return DescribeReservedCacheNodes(new DescribeReservedCacheNodesRequest());
        }

        /// <summary>
        /// The <i>DescribeReservedCacheNodes</i> operation returns information about reserved
        /// cache nodes for this account, or about a specified reserved cache node.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedCacheNodes service method.</param>
        /// 
        /// <returns>The response from the DescribeReservedCacheNodes service method, as returned by ElastiCache.</returns>
        /// <exception cref="InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        /// <exception cref="ReservedCacheNodeNotFoundException">
        /// The requested reserved cache node was not found.
        /// </exception>
        public DescribeReservedCacheNodesResponse DescribeReservedCacheNodes(DescribeReservedCacheNodesRequest request)
        {
            IAsyncResult asyncResult = invokeDescribeReservedCacheNodes(request, null, null, true);
            return EndDescribeReservedCacheNodes(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReservedCacheNodes operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedCacheNodes operation on AmazonElastiCacheClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeReservedCacheNodes
        ///         operation.</returns>
        public IAsyncResult BeginDescribeReservedCacheNodes(DescribeReservedCacheNodesRequest request, AsyncCallback callback, object state)
        {
            return invokeDescribeReservedCacheNodes(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeReservedCacheNodes operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeReservedCacheNodes.</param>
        /// 
        /// <returns>Returns a  DescribeReservedCacheNodesResult from ElastiCache.</returns>
        public  DescribeReservedCacheNodesResponse EndDescribeReservedCacheNodes(IAsyncResult asyncResult)
        {
            return endOperation< DescribeReservedCacheNodesResponse>(asyncResult);
        }

        IAsyncResult invokeDescribeReservedCacheNodes(DescribeReservedCacheNodesRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new DescribeReservedCacheNodesRequestMarshaller();
            var unmarshaller = DescribeReservedCacheNodesResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  DescribeReservedCacheNodesOfferings

        /// <summary>
        /// The <i>DescribeReservedCacheNodesOfferings</i> operation lists available reserved
        /// cache node offerings.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeReservedCacheNodesOfferings service method, as returned by ElastiCache.</returns>
        /// <exception cref="InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        /// <exception cref="ReservedCacheNodesOfferingNotFoundException">
        /// The requested cache node offering does not exist.
        /// </exception>
        public DescribeReservedCacheNodesOfferingsResponse DescribeReservedCacheNodesOfferings()
        {
            return DescribeReservedCacheNodesOfferings(new DescribeReservedCacheNodesOfferingsRequest());
        }

        /// <summary>
        /// The <i>DescribeReservedCacheNodesOfferings</i> operation lists available reserved
        /// cache node offerings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedCacheNodesOfferings service method.</param>
        /// 
        /// <returns>The response from the DescribeReservedCacheNodesOfferings service method, as returned by ElastiCache.</returns>
        /// <exception cref="InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        /// <exception cref="ReservedCacheNodesOfferingNotFoundException">
        /// The requested cache node offering does not exist.
        /// </exception>
        public DescribeReservedCacheNodesOfferingsResponse DescribeReservedCacheNodesOfferings(DescribeReservedCacheNodesOfferingsRequest request)
        {
            IAsyncResult asyncResult = invokeDescribeReservedCacheNodesOfferings(request, null, null, true);
            return EndDescribeReservedCacheNodesOfferings(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReservedCacheNodesOfferings operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedCacheNodesOfferings operation on AmazonElastiCacheClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeReservedCacheNodesOfferings
        ///         operation.</returns>
        public IAsyncResult BeginDescribeReservedCacheNodesOfferings(DescribeReservedCacheNodesOfferingsRequest request, AsyncCallback callback, object state)
        {
            return invokeDescribeReservedCacheNodesOfferings(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeReservedCacheNodesOfferings operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeReservedCacheNodesOfferings.</param>
        /// 
        /// <returns>Returns a  DescribeReservedCacheNodesOfferingsResult from ElastiCache.</returns>
        public  DescribeReservedCacheNodesOfferingsResponse EndDescribeReservedCacheNodesOfferings(IAsyncResult asyncResult)
        {
            return endOperation< DescribeReservedCacheNodesOfferingsResponse>(asyncResult);
        }

        IAsyncResult invokeDescribeReservedCacheNodesOfferings(DescribeReservedCacheNodesOfferingsRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new DescribeReservedCacheNodesOfferingsRequestMarshaller();
            var unmarshaller = DescribeReservedCacheNodesOfferingsResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  DescribeSnapshots

        /// <summary>
        /// The <i>DescribeSnapshots</i> operation returns information about cache cluster snapshots.
        /// By default, <i>DescribeSnapshots</i> lists all of your snapshots; it can optionally
        /// describe a single snapshot, or just the snapshots associated with a particular cache
        /// cluster.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeSnapshots service method, as returned by ElastiCache.</returns>
        /// <exception cref="CacheClusterNotFoundException">
        /// The requested cache cluster ID does not refer to an existing cache cluster.
        /// </exception>
        /// <exception cref="InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        /// <exception cref="SnapshotNotFoundException">
        /// The requested snapshot name does not refer to an existing snapshot.
        /// </exception>
        public DescribeSnapshotsResponse DescribeSnapshots()
        {
            return DescribeSnapshots(new DescribeSnapshotsRequest());
        }

        /// <summary>
        /// The <i>DescribeSnapshots</i> operation returns information about cache cluster snapshots.
        /// By default, <i>DescribeSnapshots</i> lists all of your snapshots; it can optionally
        /// describe a single snapshot, or just the snapshots associated with a particular cache
        /// cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSnapshots service method.</param>
        /// 
        /// <returns>The response from the DescribeSnapshots service method, as returned by ElastiCache.</returns>
        /// <exception cref="CacheClusterNotFoundException">
        /// The requested cache cluster ID does not refer to an existing cache cluster.
        /// </exception>
        /// <exception cref="InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        /// <exception cref="SnapshotNotFoundException">
        /// The requested snapshot name does not refer to an existing snapshot.
        /// </exception>
        public DescribeSnapshotsResponse DescribeSnapshots(DescribeSnapshotsRequest request)
        {
            IAsyncResult asyncResult = invokeDescribeSnapshots(request, null, null, true);
            return EndDescribeSnapshots(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSnapshots operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSnapshots operation on AmazonElastiCacheClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeSnapshots
        ///         operation.</returns>
        public IAsyncResult BeginDescribeSnapshots(DescribeSnapshotsRequest request, AsyncCallback callback, object state)
        {
            return invokeDescribeSnapshots(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeSnapshots operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeSnapshots.</param>
        /// 
        /// <returns>Returns a  DescribeSnapshotsResult from ElastiCache.</returns>
        public  DescribeSnapshotsResponse EndDescribeSnapshots(IAsyncResult asyncResult)
        {
            return endOperation< DescribeSnapshotsResponse>(asyncResult);
        }

        IAsyncResult invokeDescribeSnapshots(DescribeSnapshotsRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new DescribeSnapshotsRequestMarshaller();
            var unmarshaller = DescribeSnapshotsResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  ModifyCacheCluster


        /// <summary>
        /// The <i>ModifyCacheCluster</i> operation modifies the settings for a cache cluster.
        /// You can use this operation to change one or more cluster configuration parameters
        /// by specifying the parameters and the new values.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyCacheCluster service method.</param>
        /// 
        /// <returns>The response from the ModifyCacheCluster service method, as returned by ElastiCache.</returns>
        /// <exception cref="CacheClusterNotFoundException">
        /// The requested cache cluster ID does not refer to an existing cache cluster.
        /// </exception>
        /// <exception cref="CacheParameterGroupNotFoundException">
        /// The requested cache parameter group name does not refer to an existing cache parameter
        /// group.
        /// </exception>
        /// <exception cref="CacheSecurityGroupNotFoundException">
        /// The requested cache security group name does not refer to an existing cache security
        /// group.
        /// </exception>
        /// <exception cref="InsufficientCacheClusterCapacityException">
        /// The requested cache node type is not available in the specified Availability Zone.
        /// </exception>
        /// <exception cref="InvalidCacheClusterStateException">
        /// The requested cache cluster is not in the <i>available</i> state.
        /// </exception>
        /// <exception cref="InvalidCacheSecurityGroupStateException">
        /// The current state of the cache security group does not allow deletion.
        /// </exception>
        /// <exception cref="InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        /// <exception cref="InvalidVPCNetworkStateException">
        /// The VPC network is in an invalid state.
        /// </exception>
        /// <exception cref="NodeQuotaForClusterExceededException">
        /// The request cannot be processed because it would exceed the allowed number of cache
        /// nodes in a single cache cluster.
        /// </exception>
        /// <exception cref="NodeQuotaForCustomerExceededException">
        /// The request cannot be processed because it would exceed the allowed number of cache
        /// nodes per customer.
        /// </exception>
        public ModifyCacheClusterResponse ModifyCacheCluster(ModifyCacheClusterRequest request)
        {
            IAsyncResult asyncResult = invokeModifyCacheCluster(request, null, null, true);
            return EndModifyCacheCluster(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyCacheCluster operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyCacheCluster operation on AmazonElastiCacheClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyCacheCluster
        ///         operation.</returns>
        public IAsyncResult BeginModifyCacheCluster(ModifyCacheClusterRequest request, AsyncCallback callback, object state)
        {
            return invokeModifyCacheCluster(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyCacheCluster operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyCacheCluster.</param>
        /// 
        /// <returns>Returns a  ModifyCacheClusterResult from ElastiCache.</returns>
        public  ModifyCacheClusterResponse EndModifyCacheCluster(IAsyncResult asyncResult)
        {
            return endOperation< ModifyCacheClusterResponse>(asyncResult);
        }

        IAsyncResult invokeModifyCacheCluster(ModifyCacheClusterRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new ModifyCacheClusterRequestMarshaller();
            var unmarshaller = ModifyCacheClusterResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  ModifyCacheParameterGroup


        /// <summary>
        /// The <i>ModifyCacheParameterGroup</i> operation modifies the parameters of a cache
        /// parameter group. You can modify up to 20 parameters in a single request by submitting
        /// a list parameter name and value pairs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyCacheParameterGroup service method.</param>
        /// 
        /// <returns>The response from the ModifyCacheParameterGroup service method, as returned by ElastiCache.</returns>
        /// <exception cref="CacheParameterGroupNotFoundException">
        /// The requested cache parameter group name does not refer to an existing cache parameter
        /// group.
        /// </exception>
        /// <exception cref="InvalidCacheParameterGroupStateException">
        /// The current state of the cache parameter group does not allow the requested action
        /// to occur.
        /// </exception>
        /// <exception cref="InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        public ModifyCacheParameterGroupResponse ModifyCacheParameterGroup(ModifyCacheParameterGroupRequest request)
        {
            IAsyncResult asyncResult = invokeModifyCacheParameterGroup(request, null, null, true);
            return EndModifyCacheParameterGroup(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyCacheParameterGroup operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyCacheParameterGroup operation on AmazonElastiCacheClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyCacheParameterGroup
        ///         operation.</returns>
        public IAsyncResult BeginModifyCacheParameterGroup(ModifyCacheParameterGroupRequest request, AsyncCallback callback, object state)
        {
            return invokeModifyCacheParameterGroup(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyCacheParameterGroup operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyCacheParameterGroup.</param>
        /// 
        /// <returns>Returns a  ModifyCacheParameterGroupResult from ElastiCache.</returns>
        public  ModifyCacheParameterGroupResponse EndModifyCacheParameterGroup(IAsyncResult asyncResult)
        {
            return endOperation< ModifyCacheParameterGroupResponse>(asyncResult);
        }

        IAsyncResult invokeModifyCacheParameterGroup(ModifyCacheParameterGroupRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new ModifyCacheParameterGroupRequestMarshaller();
            var unmarshaller = ModifyCacheParameterGroupResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  ModifyCacheSubnetGroup


        /// <summary>
        /// The <i>ModifyCacheSubnetGroup</i> operation modifies an existing cache subnet group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyCacheSubnetGroup service method.</param>
        /// 
        /// <returns>The response from the ModifyCacheSubnetGroup service method, as returned by ElastiCache.</returns>
        /// <exception cref="CacheSubnetGroupNotFoundException">
        /// The requested cache subnet group name does not refer to an existing cache subnet group.
        /// </exception>
        /// <exception cref="CacheSubnetQuotaExceededException">
        /// The request cannot be processed because it would exceed the allowed number of subnets
        /// in a cache subnet group.
        /// </exception>
        /// <exception cref="InvalidSubnetException">
        /// An invalid subnet identifier was specified.
        /// </exception>
        /// <exception cref="SubnetInUseException">
        /// The requested subnet is being used by another cache subnet group.
        /// </exception>
        public ModifyCacheSubnetGroupResponse ModifyCacheSubnetGroup(ModifyCacheSubnetGroupRequest request)
        {
            IAsyncResult asyncResult = invokeModifyCacheSubnetGroup(request, null, null, true);
            return EndModifyCacheSubnetGroup(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyCacheSubnetGroup operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyCacheSubnetGroup operation on AmazonElastiCacheClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyCacheSubnetGroup
        ///         operation.</returns>
        public IAsyncResult BeginModifyCacheSubnetGroup(ModifyCacheSubnetGroupRequest request, AsyncCallback callback, object state)
        {
            return invokeModifyCacheSubnetGroup(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyCacheSubnetGroup operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyCacheSubnetGroup.</param>
        /// 
        /// <returns>Returns a  ModifyCacheSubnetGroupResult from ElastiCache.</returns>
        public  ModifyCacheSubnetGroupResponse EndModifyCacheSubnetGroup(IAsyncResult asyncResult)
        {
            return endOperation< ModifyCacheSubnetGroupResponse>(asyncResult);
        }

        IAsyncResult invokeModifyCacheSubnetGroup(ModifyCacheSubnetGroupRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new ModifyCacheSubnetGroupRequestMarshaller();
            var unmarshaller = ModifyCacheSubnetGroupResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  ModifyReplicationGroup


        /// <summary>
        /// The <i>ModifyReplicationGroup</i> operation modifies the settings for a replication
        /// group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyReplicationGroup service method.</param>
        /// 
        /// <returns>The response from the ModifyReplicationGroup service method, as returned by ElastiCache.</returns>
        /// <exception cref="CacheClusterNotFoundException">
        /// The requested cache cluster ID does not refer to an existing cache cluster.
        /// </exception>
        /// <exception cref="CacheParameterGroupNotFoundException">
        /// The requested cache parameter group name does not refer to an existing cache parameter
        /// group.
        /// </exception>
        /// <exception cref="CacheSecurityGroupNotFoundException">
        /// The requested cache security group name does not refer to an existing cache security
        /// group.
        /// </exception>
        /// <exception cref="InvalidCacheClusterStateException">
        /// The requested cache cluster is not in the <i>available</i> state.
        /// </exception>
        /// <exception cref="InvalidCacheSecurityGroupStateException">
        /// The current state of the cache security group does not allow deletion.
        /// </exception>
        /// <exception cref="InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        /// <exception cref="InvalidReplicationGroupStateException">
        /// The requested replication group is not in the <i>available</i> state.
        /// </exception>
        /// <exception cref="InvalidVPCNetworkStateException">
        /// The VPC network is in an invalid state.
        /// </exception>
        /// <exception cref="ReplicationGroupNotFoundException">
        /// The specified replication group does not exist.
        /// </exception>
        public ModifyReplicationGroupResponse ModifyReplicationGroup(ModifyReplicationGroupRequest request)
        {
            IAsyncResult asyncResult = invokeModifyReplicationGroup(request, null, null, true);
            return EndModifyReplicationGroup(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyReplicationGroup operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyReplicationGroup operation on AmazonElastiCacheClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyReplicationGroup
        ///         operation.</returns>
        public IAsyncResult BeginModifyReplicationGroup(ModifyReplicationGroupRequest request, AsyncCallback callback, object state)
        {
            return invokeModifyReplicationGroup(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyReplicationGroup operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyReplicationGroup.</param>
        /// 
        /// <returns>Returns a  ModifyReplicationGroupResult from ElastiCache.</returns>
        public  ModifyReplicationGroupResponse EndModifyReplicationGroup(IAsyncResult asyncResult)
        {
            return endOperation< ModifyReplicationGroupResponse>(asyncResult);
        }

        IAsyncResult invokeModifyReplicationGroup(ModifyReplicationGroupRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new ModifyReplicationGroupRequestMarshaller();
            var unmarshaller = ModifyReplicationGroupResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  PurchaseReservedCacheNodesOffering


        /// <summary>
        /// The <i>PurchaseReservedCacheNodesOffering</i> operation allows you to purchase a reserved
        /// cache node offering.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PurchaseReservedCacheNodesOffering service method.</param>
        /// 
        /// <returns>The response from the PurchaseReservedCacheNodesOffering service method, as returned by ElastiCache.</returns>
        /// <exception cref="InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        /// <exception cref="ReservedCacheNodeAlreadyExistsException">
        /// You already have a reservation with the given identifier.
        /// </exception>
        /// <exception cref="ReservedCacheNodeQuotaExceededException">
        /// The request cannot be processed because it would exceed the user's cache node quota.
        /// </exception>
        /// <exception cref="ReservedCacheNodesOfferingNotFoundException">
        /// The requested cache node offering does not exist.
        /// </exception>
        public PurchaseReservedCacheNodesOfferingResponse PurchaseReservedCacheNodesOffering(PurchaseReservedCacheNodesOfferingRequest request)
        {
            IAsyncResult asyncResult = invokePurchaseReservedCacheNodesOffering(request, null, null, true);
            return EndPurchaseReservedCacheNodesOffering(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PurchaseReservedCacheNodesOffering operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PurchaseReservedCacheNodesOffering operation on AmazonElastiCacheClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPurchaseReservedCacheNodesOffering
        ///         operation.</returns>
        public IAsyncResult BeginPurchaseReservedCacheNodesOffering(PurchaseReservedCacheNodesOfferingRequest request, AsyncCallback callback, object state)
        {
            return invokePurchaseReservedCacheNodesOffering(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  PurchaseReservedCacheNodesOffering operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPurchaseReservedCacheNodesOffering.</param>
        /// 
        /// <returns>Returns a  PurchaseReservedCacheNodesOfferingResult from ElastiCache.</returns>
        public  PurchaseReservedCacheNodesOfferingResponse EndPurchaseReservedCacheNodesOffering(IAsyncResult asyncResult)
        {
            return endOperation< PurchaseReservedCacheNodesOfferingResponse>(asyncResult);
        }

        IAsyncResult invokePurchaseReservedCacheNodesOffering(PurchaseReservedCacheNodesOfferingRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new PurchaseReservedCacheNodesOfferingRequestMarshaller();
            var unmarshaller = PurchaseReservedCacheNodesOfferingResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  RebootCacheCluster


        /// <summary>
        /// The <i>RebootCacheCluster</i> operation reboots some, or all, of the cache nodes within
        /// a provisioned cache cluster. This API will apply any modified cache parameter groups
        /// to the cache cluster. The reboot action takes place as soon as possible, and results
        /// in a momentary outage to the cache cluster. During the reboot, the cache cluster status
        /// is set to REBOOTING.
        /// 
        ///  
        /// <para>
        /// The reboot causes the contents of the cache (for each cache node being rebooted) to
        /// be lost.
        /// </para>
        ///  
        /// <para>
        /// When the reboot is complete, a cache cluster event is created.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RebootCacheCluster service method.</param>
        /// 
        /// <returns>The response from the RebootCacheCluster service method, as returned by ElastiCache.</returns>
        /// <exception cref="CacheClusterNotFoundException">
        /// The requested cache cluster ID does not refer to an existing cache cluster.
        /// </exception>
        /// <exception cref="InvalidCacheClusterStateException">
        /// The requested cache cluster is not in the <i>available</i> state.
        /// </exception>
        public RebootCacheClusterResponse RebootCacheCluster(RebootCacheClusterRequest request)
        {
            IAsyncResult asyncResult = invokeRebootCacheCluster(request, null, null, true);
            return EndRebootCacheCluster(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RebootCacheCluster operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RebootCacheCluster operation on AmazonElastiCacheClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRebootCacheCluster
        ///         operation.</returns>
        public IAsyncResult BeginRebootCacheCluster(RebootCacheClusterRequest request, AsyncCallback callback, object state)
        {
            return invokeRebootCacheCluster(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  RebootCacheCluster operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRebootCacheCluster.</param>
        /// 
        /// <returns>Returns a  RebootCacheClusterResult from ElastiCache.</returns>
        public  RebootCacheClusterResponse EndRebootCacheCluster(IAsyncResult asyncResult)
        {
            return endOperation< RebootCacheClusterResponse>(asyncResult);
        }

        IAsyncResult invokeRebootCacheCluster(RebootCacheClusterRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new RebootCacheClusterRequestMarshaller();
            var unmarshaller = RebootCacheClusterResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  ResetCacheParameterGroup


        /// <summary>
        /// The <i>ResetCacheParameterGroup</i> operation modifies the parameters of a cache parameter
        /// group to the engine or system default value. You can reset specific parameters by
        /// submitting a list of parameter names. To reset the entire cache parameter group, specify
        /// the <i>ResetAllParameters</i> and <i>CacheParameterGroupName</i> parameters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResetCacheParameterGroup service method.</param>
        /// 
        /// <returns>The response from the ResetCacheParameterGroup service method, as returned by ElastiCache.</returns>
        /// <exception cref="CacheParameterGroupNotFoundException">
        /// The requested cache parameter group name does not refer to an existing cache parameter
        /// group.
        /// </exception>
        /// <exception cref="InvalidCacheParameterGroupStateException">
        /// The current state of the cache parameter group does not allow the requested action
        /// to occur.
        /// </exception>
        /// <exception cref="InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        public ResetCacheParameterGroupResponse ResetCacheParameterGroup(ResetCacheParameterGroupRequest request)
        {
            IAsyncResult asyncResult = invokeResetCacheParameterGroup(request, null, null, true);
            return EndResetCacheParameterGroup(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ResetCacheParameterGroup operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResetCacheParameterGroup operation on AmazonElastiCacheClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndResetCacheParameterGroup
        ///         operation.</returns>
        public IAsyncResult BeginResetCacheParameterGroup(ResetCacheParameterGroupRequest request, AsyncCallback callback, object state)
        {
            return invokeResetCacheParameterGroup(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  ResetCacheParameterGroup operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginResetCacheParameterGroup.</param>
        /// 
        /// <returns>Returns a  ResetCacheParameterGroupResult from ElastiCache.</returns>
        public  ResetCacheParameterGroupResponse EndResetCacheParameterGroup(IAsyncResult asyncResult)
        {
            return endOperation< ResetCacheParameterGroupResponse>(asyncResult);
        }

        IAsyncResult invokeResetCacheParameterGroup(ResetCacheParameterGroupRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new ResetCacheParameterGroupRequestMarshaller();
            var unmarshaller = ResetCacheParameterGroupResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  RevokeCacheSecurityGroupIngress


        /// <summary>
        /// The <i>RevokeCacheSecurityGroupIngress</i> operation revokes ingress from a cache
        /// security group. Use this operation to disallow access from an Amazon EC2 security
        /// group that had been previously authorized.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RevokeCacheSecurityGroupIngress service method.</param>
        /// 
        /// <returns>The response from the RevokeCacheSecurityGroupIngress service method, as returned by ElastiCache.</returns>
        /// <exception cref="AuthorizationNotFoundException">
        /// The specified Amazon EC2 security group is not authorized for the specified cache
        /// security group.
        /// </exception>
        /// <exception cref="CacheSecurityGroupNotFoundException">
        /// The requested cache security group name does not refer to an existing cache security
        /// group.
        /// </exception>
        /// <exception cref="InvalidCacheSecurityGroupStateException">
        /// The current state of the cache security group does not allow deletion.
        /// </exception>
        /// <exception cref="InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        public RevokeCacheSecurityGroupIngressResponse RevokeCacheSecurityGroupIngress(RevokeCacheSecurityGroupIngressRequest request)
        {
            IAsyncResult asyncResult = invokeRevokeCacheSecurityGroupIngress(request, null, null, true);
            return EndRevokeCacheSecurityGroupIngress(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RevokeCacheSecurityGroupIngress operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RevokeCacheSecurityGroupIngress operation on AmazonElastiCacheClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRevokeCacheSecurityGroupIngress
        ///         operation.</returns>
        public IAsyncResult BeginRevokeCacheSecurityGroupIngress(RevokeCacheSecurityGroupIngressRequest request, AsyncCallback callback, object state)
        {
            return invokeRevokeCacheSecurityGroupIngress(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  RevokeCacheSecurityGroupIngress operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRevokeCacheSecurityGroupIngress.</param>
        /// 
        /// <returns>Returns a  RevokeCacheSecurityGroupIngressResult from ElastiCache.</returns>
        public  RevokeCacheSecurityGroupIngressResponse EndRevokeCacheSecurityGroupIngress(IAsyncResult asyncResult)
        {
            return endOperation< RevokeCacheSecurityGroupIngressResponse>(asyncResult);
        }

        IAsyncResult invokeRevokeCacheSecurityGroupIngress(RevokeCacheSecurityGroupIngressRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new RevokeCacheSecurityGroupIngressRequestMarshaller();
            var unmarshaller = RevokeCacheSecurityGroupIngressResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
    }
}