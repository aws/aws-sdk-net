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


        #region AuthorizeCacheSecurityGroupIngress

        /// <summary>
        /// <para>The <i>AuthorizeCacheSecurityGroupIngress</i> operation allows network ingress to a cache security group. Applications using
        /// ElastiCache must be running on Amazon EC2, and Amazon EC2 security groups are used as the authorization mechanism.</para> <para><b>NOTE:</b>
        /// You cannot authorize ingress from an Amazon EC2 security group in one Region to an ElastiCache cluster in another Region. </para>
        /// </summary>
        /// 
        /// <param name="authorizeCacheSecurityGroupIngressRequest">Container for the necessary parameters to execute the
        ///          AuthorizeCacheSecurityGroupIngress service method on AmazonElastiCache.</param>
        /// 
        /// <returns>The response from the AuthorizeCacheSecurityGroupIngress service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="InvalidParameterValueException"/>
        /// <exception cref="AuthorizationAlreadyExistsException"/>
        /// <exception cref="InvalidCacheSecurityGroupStateException"/>
        /// <exception cref="InvalidParameterCombinationException"/>
        /// <exception cref="CacheSecurityGroupNotFoundException"/>
        public AuthorizeCacheSecurityGroupIngressResponse AuthorizeCacheSecurityGroupIngress(AuthorizeCacheSecurityGroupIngressRequest authorizeCacheSecurityGroupIngressRequest)
        {
            IAsyncResult asyncResult = invokeAuthorizeCacheSecurityGroupIngress(authorizeCacheSecurityGroupIngressRequest, null, null, true);
            return EndAuthorizeCacheSecurityGroupIngress(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the AuthorizeCacheSecurityGroupIngress operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache.AuthorizeCacheSecurityGroupIngress"/>
        /// </summary>
        /// 
        /// <param name="authorizeCacheSecurityGroupIngressRequest">Container for the necessary parameters to execute the
        ///          AuthorizeCacheSecurityGroupIngress operation on AmazonElastiCache.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndAuthorizeCacheSecurityGroupIngress operation.</returns>
        public IAsyncResult BeginAuthorizeCacheSecurityGroupIngress(AuthorizeCacheSecurityGroupIngressRequest authorizeCacheSecurityGroupIngressRequest, AsyncCallback callback, object state)
        {
            return invokeAuthorizeCacheSecurityGroupIngress(authorizeCacheSecurityGroupIngressRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the AuthorizeCacheSecurityGroupIngress operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache.AuthorizeCacheSecurityGroupIngress"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAuthorizeCacheSecurityGroupIngress.</param>
        /// 
        /// <returns>Returns a CacheSecurityGroup from AmazonElastiCache.</returns>
        public AuthorizeCacheSecurityGroupIngressResponse EndAuthorizeCacheSecurityGroupIngress(IAsyncResult asyncResult)
        {
            return endOperation<AuthorizeCacheSecurityGroupIngressResponse>(asyncResult);
        }
        
        IAsyncResult invokeAuthorizeCacheSecurityGroupIngress(AuthorizeCacheSecurityGroupIngressRequest authorizeCacheSecurityGroupIngressRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new AuthorizeCacheSecurityGroupIngressRequestMarshaller().Marshall(authorizeCacheSecurityGroupIngressRequest);
            var unmarshaller = AuthorizeCacheSecurityGroupIngressResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region CreateCacheCluster

        /// <summary>
        /// <para>The <i>CreateCacheCluster</i> operation creates a new cache cluster. All nodes in the cache cluster run the same protocol-compliant
        /// cache engine software - either Memcached or Redis.</para>
        /// </summary>
        /// 
        /// <param name="createCacheClusterRequest">Container for the necessary parameters to execute the CreateCacheCluster service method on
        ///          AmazonElastiCache.</param>
        /// 
        /// <returns>The response from the CreateCacheCluster service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="NodeQuotaForCustomerExceededException"/>
        /// <exception cref="ClusterQuotaForCustomerExceededException"/>
        /// <exception cref="CacheClusterAlreadyExistsException"/>
        /// <exception cref="InsufficientCacheClusterCapacityException"/>
        /// <exception cref="ReplicationGroupNotFoundException"/>
        /// <exception cref="InvalidParameterCombinationException"/>
        /// <exception cref="CacheParameterGroupNotFoundException"/>
        /// <exception cref="CacheSecurityGroupNotFoundException"/>
        /// <exception cref="NodeQuotaForClusterExceededException"/>
        /// <exception cref="CacheSubnetGroupNotFoundException"/>
        /// <exception cref="InvalidReplicationGroupStateException"/>
        /// <exception cref="InvalidParameterValueException"/>
        /// <exception cref="InvalidVPCNetworkStateException"/>
        public CreateCacheClusterResponse CreateCacheCluster(CreateCacheClusterRequest createCacheClusterRequest)
        {
            IAsyncResult asyncResult = invokeCreateCacheCluster(createCacheClusterRequest, null, null, true);
            return EndCreateCacheCluster(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCacheCluster operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache.CreateCacheCluster"/>
        /// </summary>
        /// 
        /// <param name="createCacheClusterRequest">Container for the necessary parameters to execute the CreateCacheCluster operation on
        ///          AmazonElastiCache.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndCreateCacheCluster operation.</returns>
        public IAsyncResult BeginCreateCacheCluster(CreateCacheClusterRequest createCacheClusterRequest, AsyncCallback callback, object state)
        {
            return invokeCreateCacheCluster(createCacheClusterRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the CreateCacheCluster operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache.CreateCacheCluster"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCacheCluster.</param>
        /// 
        /// <returns>Returns a CacheCluster from AmazonElastiCache.</returns>
        public CreateCacheClusterResponse EndCreateCacheCluster(IAsyncResult asyncResult)
        {
            return endOperation<CreateCacheClusterResponse>(asyncResult);
        }
        
        IAsyncResult invokeCreateCacheCluster(CreateCacheClusterRequest createCacheClusterRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new CreateCacheClusterRequestMarshaller().Marshall(createCacheClusterRequest);
            var unmarshaller = CreateCacheClusterResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region CreateCacheParameterGroup

        /// <summary>
        /// <para>The <i>CreateCacheParameterGroup</i> operation creates a new cache parameter group. A cache parameter group is a collection of
        /// parameters that you apply to all of the nodes in a cache cluster.</para>
        /// </summary>
        /// 
        /// <param name="createCacheParameterGroupRequest">Container for the necessary parameters to execute the CreateCacheParameterGroup service
        ///          method on AmazonElastiCache.</param>
        /// 
        /// <returns>The response from the CreateCacheParameterGroup service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="InvalidParameterValueException"/>
        /// <exception cref="CacheParameterGroupQuotaExceededException"/>
        /// <exception cref="CacheParameterGroupAlreadyExistsException"/>
        /// <exception cref="InvalidParameterCombinationException"/>
        /// <exception cref="InvalidCacheParameterGroupStateException"/>
        public CreateCacheParameterGroupResponse CreateCacheParameterGroup(CreateCacheParameterGroupRequest createCacheParameterGroupRequest)
        {
            IAsyncResult asyncResult = invokeCreateCacheParameterGroup(createCacheParameterGroupRequest, null, null, true);
            return EndCreateCacheParameterGroup(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCacheParameterGroup operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache.CreateCacheParameterGroup"/>
        /// </summary>
        /// 
        /// <param name="createCacheParameterGroupRequest">Container for the necessary parameters to execute the CreateCacheParameterGroup operation on
        ///          AmazonElastiCache.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndCreateCacheParameterGroup operation.</returns>
        public IAsyncResult BeginCreateCacheParameterGroup(CreateCacheParameterGroupRequest createCacheParameterGroupRequest, AsyncCallback callback, object state)
        {
            return invokeCreateCacheParameterGroup(createCacheParameterGroupRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the CreateCacheParameterGroup operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache.CreateCacheParameterGroup"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCacheParameterGroup.</param>
        /// 
        /// <returns>Returns a CacheParameterGroup from AmazonElastiCache.</returns>
        public CreateCacheParameterGroupResponse EndCreateCacheParameterGroup(IAsyncResult asyncResult)
        {
            return endOperation<CreateCacheParameterGroupResponse>(asyncResult);
        }
        
        IAsyncResult invokeCreateCacheParameterGroup(CreateCacheParameterGroupRequest createCacheParameterGroupRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new CreateCacheParameterGroupRequestMarshaller().Marshall(createCacheParameterGroupRequest);
            var unmarshaller = CreateCacheParameterGroupResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region CreateCacheSecurityGroup

        /// <summary>
        /// <para>The <i>CreateCacheSecurityGroup</i> operation creates a new cache security group. Use a cache security group to control access to one
        /// or more cache clusters.</para> <para>Cache security groups are only used when you are creating a cluster outside of an Amazon Virtual
        /// Private Cloud (VPC). If you are creating a cluster inside of a VPC, use a cache subnet group instead. For more information, see
        /// <i>CreateCacheSubnetGroup</i> .</para>
        /// </summary>
        /// 
        /// <param name="createCacheSecurityGroupRequest">Container for the necessary parameters to execute the CreateCacheSecurityGroup service method
        ///          on AmazonElastiCache.</param>
        /// 
        /// <returns>The response from the CreateCacheSecurityGroup service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="CacheSecurityGroupAlreadyExistsException"/>
        /// <exception cref="InvalidParameterValueException"/>
        /// <exception cref="CacheSecurityGroupQuotaExceededException"/>
        /// <exception cref="InvalidParameterCombinationException"/>
        public CreateCacheSecurityGroupResponse CreateCacheSecurityGroup(CreateCacheSecurityGroupRequest createCacheSecurityGroupRequest)
        {
            IAsyncResult asyncResult = invokeCreateCacheSecurityGroup(createCacheSecurityGroupRequest, null, null, true);
            return EndCreateCacheSecurityGroup(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCacheSecurityGroup operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache.CreateCacheSecurityGroup"/>
        /// </summary>
        /// 
        /// <param name="createCacheSecurityGroupRequest">Container for the necessary parameters to execute the CreateCacheSecurityGroup operation on
        ///          AmazonElastiCache.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndCreateCacheSecurityGroup operation.</returns>
        public IAsyncResult BeginCreateCacheSecurityGroup(CreateCacheSecurityGroupRequest createCacheSecurityGroupRequest, AsyncCallback callback, object state)
        {
            return invokeCreateCacheSecurityGroup(createCacheSecurityGroupRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the CreateCacheSecurityGroup operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache.CreateCacheSecurityGroup"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCacheSecurityGroup.</param>
        /// 
        /// <returns>Returns a CacheSecurityGroup from AmazonElastiCache.</returns>
        public CreateCacheSecurityGroupResponse EndCreateCacheSecurityGroup(IAsyncResult asyncResult)
        {
            return endOperation<CreateCacheSecurityGroupResponse>(asyncResult);
        }
        
        IAsyncResult invokeCreateCacheSecurityGroup(CreateCacheSecurityGroupRequest createCacheSecurityGroupRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new CreateCacheSecurityGroupRequestMarshaller().Marshall(createCacheSecurityGroupRequest);
            var unmarshaller = CreateCacheSecurityGroupResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region CreateCacheSubnetGroup

        /// <summary>
        /// <para>The <i>CreateCacheSubnetGroup</i> operation creates a new cache subnet group.</para> <para>Use this parameter only when you are
        /// creating a cluster in an Amazon Virtual Private Cloud (VPC).</para>
        /// </summary>
        /// 
        /// <param name="createCacheSubnetGroupRequest">Container for the necessary parameters to execute the CreateCacheSubnetGroup service method on
        ///          AmazonElastiCache.</param>
        /// 
        /// <returns>The response from the CreateCacheSubnetGroup service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="CacheSubnetGroupAlreadyExistsException"/>
        /// <exception cref="CacheSubnetGroupQuotaExceededException"/>
        /// <exception cref="CacheSubnetQuotaExceededException"/>
        /// <exception cref="InvalidSubnetException"/>
        public CreateCacheSubnetGroupResponse CreateCacheSubnetGroup(CreateCacheSubnetGroupRequest createCacheSubnetGroupRequest)
        {
            IAsyncResult asyncResult = invokeCreateCacheSubnetGroup(createCacheSubnetGroupRequest, null, null, true);
            return EndCreateCacheSubnetGroup(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCacheSubnetGroup operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache.CreateCacheSubnetGroup"/>
        /// </summary>
        /// 
        /// <param name="createCacheSubnetGroupRequest">Container for the necessary parameters to execute the CreateCacheSubnetGroup operation on
        ///          AmazonElastiCache.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndCreateCacheSubnetGroup operation.</returns>
        public IAsyncResult BeginCreateCacheSubnetGroup(CreateCacheSubnetGroupRequest createCacheSubnetGroupRequest, AsyncCallback callback, object state)
        {
            return invokeCreateCacheSubnetGroup(createCacheSubnetGroupRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the CreateCacheSubnetGroup operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache.CreateCacheSubnetGroup"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCacheSubnetGroup.</param>
        /// 
        /// <returns>Returns a CacheSubnetGroup from AmazonElastiCache.</returns>
        public CreateCacheSubnetGroupResponse EndCreateCacheSubnetGroup(IAsyncResult asyncResult)
        {
            return endOperation<CreateCacheSubnetGroupResponse>(asyncResult);
        }
        
        IAsyncResult invokeCreateCacheSubnetGroup(CreateCacheSubnetGroupRequest createCacheSubnetGroupRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new CreateCacheSubnetGroupRequestMarshaller().Marshall(createCacheSubnetGroupRequest);
            var unmarshaller = CreateCacheSubnetGroupResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region CreateReplicationGroup

        /// <summary>
        /// <para>The <i>CreateReplicationGroup</i> operation creates a replication group. A replication group is a collection of cache clusters, where
        /// one of the clusters is a read/write primary and the other clusters are read-only replicas. Writes to the primary are automatically
        /// propagated to the replicas.</para> <para>When you create a replication group, you must specify an existing cache cluster that is in the
        /// primary role. When the replication group has been successfully created, you can add one or more read replica replicas to it, up to a total
        /// of five read replicas.</para>
        /// </summary>
        /// 
        /// <param name="createReplicationGroupRequest">Container for the necessary parameters to execute the CreateReplicationGroup service method on
        ///          AmazonElastiCache.</param>
        /// 
        /// <returns>The response from the CreateReplicationGroup service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="ReplicationGroupAlreadyExistsException"/>
        /// <exception cref="InvalidParameterValueException"/>
        /// <exception cref="CacheClusterNotFoundException"/>
        /// <exception cref="InvalidParameterCombinationException"/>
        /// <exception cref="InvalidCacheClusterStateException"/>
        public CreateReplicationGroupResponse CreateReplicationGroup(CreateReplicationGroupRequest createReplicationGroupRequest)
        {
            IAsyncResult asyncResult = invokeCreateReplicationGroup(createReplicationGroupRequest, null, null, true);
            return EndCreateReplicationGroup(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the CreateReplicationGroup operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache.CreateReplicationGroup"/>
        /// </summary>
        /// 
        /// <param name="createReplicationGroupRequest">Container for the necessary parameters to execute the CreateReplicationGroup operation on
        ///          AmazonElastiCache.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndCreateReplicationGroup operation.</returns>
        public IAsyncResult BeginCreateReplicationGroup(CreateReplicationGroupRequest createReplicationGroupRequest, AsyncCallback callback, object state)
        {
            return invokeCreateReplicationGroup(createReplicationGroupRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the CreateReplicationGroup operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache.CreateReplicationGroup"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateReplicationGroup.</param>
        /// 
        /// <returns>Returns a ReplicationGroup from AmazonElastiCache.</returns>
        public CreateReplicationGroupResponse EndCreateReplicationGroup(IAsyncResult asyncResult)
        {
            return endOperation<CreateReplicationGroupResponse>(asyncResult);
        }
        
        IAsyncResult invokeCreateReplicationGroup(CreateReplicationGroupRequest createReplicationGroupRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new CreateReplicationGroupRequestMarshaller().Marshall(createReplicationGroupRequest);
            var unmarshaller = CreateReplicationGroupResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DeleteCacheCluster

        /// <summary>
        /// <para>The <i>DeleteCacheCluster</i> operation deletes a previously provisioned cache cluster. <i>DeleteCacheCluster</i> deletes all
        /// associated cache nodes, node endpoints and the cache cluster itself. When you receive a successful response from this operation, Amazon
        /// ElastiCache immediately begins deleting the cache cluster; you cannot cancel or revert this operation.</para>
        /// </summary>
        /// 
        /// <param name="deleteCacheClusterRequest">Container for the necessary parameters to execute the DeleteCacheCluster service method on
        ///          AmazonElastiCache.</param>
        /// 
        /// <returns>The response from the DeleteCacheCluster service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="InvalidParameterValueException"/>
        /// <exception cref="CacheClusterNotFoundException"/>
        /// <exception cref="InvalidParameterCombinationException"/>
        /// <exception cref="InvalidCacheClusterStateException"/>
        public DeleteCacheClusterResponse DeleteCacheCluster(DeleteCacheClusterRequest deleteCacheClusterRequest)
        {
            IAsyncResult asyncResult = invokeDeleteCacheCluster(deleteCacheClusterRequest, null, null, true);
            return EndDeleteCacheCluster(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCacheCluster operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache.DeleteCacheCluster"/>
        /// </summary>
        /// 
        /// <param name="deleteCacheClusterRequest">Container for the necessary parameters to execute the DeleteCacheCluster operation on
        ///          AmazonElastiCache.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDeleteCacheCluster operation.</returns>
        public IAsyncResult BeginDeleteCacheCluster(DeleteCacheClusterRequest deleteCacheClusterRequest, AsyncCallback callback, object state)
        {
            return invokeDeleteCacheCluster(deleteCacheClusterRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteCacheCluster operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache.DeleteCacheCluster"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCacheCluster.</param>
        /// 
        /// <returns>Returns a CacheCluster from AmazonElastiCache.</returns>
        public DeleteCacheClusterResponse EndDeleteCacheCluster(IAsyncResult asyncResult)
        {
            return endOperation<DeleteCacheClusterResponse>(asyncResult);
        }
        
        IAsyncResult invokeDeleteCacheCluster(DeleteCacheClusterRequest deleteCacheClusterRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DeleteCacheClusterRequestMarshaller().Marshall(deleteCacheClusterRequest);
            var unmarshaller = DeleteCacheClusterResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DeleteCacheParameterGroup

        /// <summary>
        /// <para>The <i>DeleteCacheParameterGroup</i> operation deletes the specified cache parameter group. You cannot delete a cache parameter group
        /// if it is associated with any cache clusters.</para>
        /// </summary>
        /// 
        /// <param name="deleteCacheParameterGroupRequest">Container for the necessary parameters to execute the DeleteCacheParameterGroup service
        ///          method on AmazonElastiCache.</param>
        /// 
        /// <exception cref="InvalidParameterValueException"/>
        /// <exception cref="InvalidParameterCombinationException"/>
        /// <exception cref="InvalidCacheParameterGroupStateException"/>
        /// <exception cref="CacheParameterGroupNotFoundException"/>
        public DeleteCacheParameterGroupResponse DeleteCacheParameterGroup(DeleteCacheParameterGroupRequest deleteCacheParameterGroupRequest)
        {
            IAsyncResult asyncResult = invokeDeleteCacheParameterGroup(deleteCacheParameterGroupRequest, null, null, true);
            return EndDeleteCacheParameterGroup(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCacheParameterGroup operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache.DeleteCacheParameterGroup"/>
        /// </summary>
        /// 
        /// <param name="deleteCacheParameterGroupRequest">Container for the necessary parameters to execute the DeleteCacheParameterGroup operation on
        ///          AmazonElastiCache.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginDeleteCacheParameterGroup(DeleteCacheParameterGroupRequest deleteCacheParameterGroupRequest, AsyncCallback callback, object state)
        {
            return invokeDeleteCacheParameterGroup(deleteCacheParameterGroupRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteCacheParameterGroup operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache.DeleteCacheParameterGroup"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCacheParameterGroup.</param>
        public DeleteCacheParameterGroupResponse EndDeleteCacheParameterGroup(IAsyncResult asyncResult)
        {
            return endOperation<DeleteCacheParameterGroupResponse>(asyncResult);
        }
        
        IAsyncResult invokeDeleteCacheParameterGroup(DeleteCacheParameterGroupRequest deleteCacheParameterGroupRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DeleteCacheParameterGroupRequestMarshaller().Marshall(deleteCacheParameterGroupRequest);
            var unmarshaller = DeleteCacheParameterGroupResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DeleteCacheSecurityGroup

        /// <summary>
        /// <para>The <i>DeleteCacheSecurityGroup</i> operation deletes a cache security group.</para> <para><b>NOTE:</b>You cannot delete a cache
        /// security group if it is associated with any cache clusters.</para>
        /// </summary>
        /// 
        /// <param name="deleteCacheSecurityGroupRequest">Container for the necessary parameters to execute the DeleteCacheSecurityGroup service method
        ///          on AmazonElastiCache.</param>
        /// 
        /// <exception cref="InvalidParameterValueException"/>
        /// <exception cref="InvalidCacheSecurityGroupStateException"/>
        /// <exception cref="InvalidParameterCombinationException"/>
        /// <exception cref="CacheSecurityGroupNotFoundException"/>
        public DeleteCacheSecurityGroupResponse DeleteCacheSecurityGroup(DeleteCacheSecurityGroupRequest deleteCacheSecurityGroupRequest)
        {
            IAsyncResult asyncResult = invokeDeleteCacheSecurityGroup(deleteCacheSecurityGroupRequest, null, null, true);
            return EndDeleteCacheSecurityGroup(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCacheSecurityGroup operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache.DeleteCacheSecurityGroup"/>
        /// </summary>
        /// 
        /// <param name="deleteCacheSecurityGroupRequest">Container for the necessary parameters to execute the DeleteCacheSecurityGroup operation on
        ///          AmazonElastiCache.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginDeleteCacheSecurityGroup(DeleteCacheSecurityGroupRequest deleteCacheSecurityGroupRequest, AsyncCallback callback, object state)
        {
            return invokeDeleteCacheSecurityGroup(deleteCacheSecurityGroupRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteCacheSecurityGroup operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache.DeleteCacheSecurityGroup"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCacheSecurityGroup.</param>
        public DeleteCacheSecurityGroupResponse EndDeleteCacheSecurityGroup(IAsyncResult asyncResult)
        {
            return endOperation<DeleteCacheSecurityGroupResponse>(asyncResult);
        }
        
        IAsyncResult invokeDeleteCacheSecurityGroup(DeleteCacheSecurityGroupRequest deleteCacheSecurityGroupRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DeleteCacheSecurityGroupRequestMarshaller().Marshall(deleteCacheSecurityGroupRequest);
            var unmarshaller = DeleteCacheSecurityGroupResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DeleteCacheSubnetGroup

        /// <summary>
        /// <para>The <i>DeleteCacheSubnetGroup</i> operation deletes a cache subnet group.</para> <para><b>NOTE:</b>You cannot delete a cache subnet
        /// group if it is associated with any cache clusters.</para>
        /// </summary>
        /// 
        /// <param name="deleteCacheSubnetGroupRequest">Container for the necessary parameters to execute the DeleteCacheSubnetGroup service method on
        ///          AmazonElastiCache.</param>
        /// 
        /// <exception cref="CacheSubnetGroupNotFoundException"/>
        /// <exception cref="CacheSubnetGroupInUseException"/>
        public DeleteCacheSubnetGroupResponse DeleteCacheSubnetGroup(DeleteCacheSubnetGroupRequest deleteCacheSubnetGroupRequest)
        {
            IAsyncResult asyncResult = invokeDeleteCacheSubnetGroup(deleteCacheSubnetGroupRequest, null, null, true);
            return EndDeleteCacheSubnetGroup(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCacheSubnetGroup operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache.DeleteCacheSubnetGroup"/>
        /// </summary>
        /// 
        /// <param name="deleteCacheSubnetGroupRequest">Container for the necessary parameters to execute the DeleteCacheSubnetGroup operation on
        ///          AmazonElastiCache.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginDeleteCacheSubnetGroup(DeleteCacheSubnetGroupRequest deleteCacheSubnetGroupRequest, AsyncCallback callback, object state)
        {
            return invokeDeleteCacheSubnetGroup(deleteCacheSubnetGroupRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteCacheSubnetGroup operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache.DeleteCacheSubnetGroup"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCacheSubnetGroup.</param>
        public DeleteCacheSubnetGroupResponse EndDeleteCacheSubnetGroup(IAsyncResult asyncResult)
        {
            return endOperation<DeleteCacheSubnetGroupResponse>(asyncResult);
        }
        
        IAsyncResult invokeDeleteCacheSubnetGroup(DeleteCacheSubnetGroupRequest deleteCacheSubnetGroupRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DeleteCacheSubnetGroupRequestMarshaller().Marshall(deleteCacheSubnetGroupRequest);
            var unmarshaller = DeleteCacheSubnetGroupResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DeleteReplicationGroup

        /// <summary>
        /// <para>The <i>DeleteReplicationGroup</i> operation deletes an existing replication group. <i>DeleteReplicationGroup</i> deletes the primary
        /// cache cluster and all of the read replicas in the replication group. When you receive a successful response from this operation, Amazon
        /// ElastiCache immediately begins deleting the entire replication group; you cannot cancel or revert this operation.</para>
        /// </summary>
        /// 
        /// <param name="deleteReplicationGroupRequest">Container for the necessary parameters to execute the DeleteReplicationGroup service method on
        ///          AmazonElastiCache.</param>
        /// 
        /// <returns>The response from the DeleteReplicationGroup service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="InvalidReplicationGroupStateException"/>
        /// <exception cref="InvalidParameterValueException"/>
        /// <exception cref="ReplicationGroupNotFoundException"/>
        /// <exception cref="InvalidParameterCombinationException"/>
        public DeleteReplicationGroupResponse DeleteReplicationGroup(DeleteReplicationGroupRequest deleteReplicationGroupRequest)
        {
            IAsyncResult asyncResult = invokeDeleteReplicationGroup(deleteReplicationGroupRequest, null, null, true);
            return EndDeleteReplicationGroup(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteReplicationGroup operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache.DeleteReplicationGroup"/>
        /// </summary>
        /// 
        /// <param name="deleteReplicationGroupRequest">Container for the necessary parameters to execute the DeleteReplicationGroup operation on
        ///          AmazonElastiCache.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDeleteReplicationGroup operation.</returns>
        public IAsyncResult BeginDeleteReplicationGroup(DeleteReplicationGroupRequest deleteReplicationGroupRequest, AsyncCallback callback, object state)
        {
            return invokeDeleteReplicationGroup(deleteReplicationGroupRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteReplicationGroup operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache.DeleteReplicationGroup"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteReplicationGroup.</param>
        /// 
        /// <returns>Returns a ReplicationGroup from AmazonElastiCache.</returns>
        public DeleteReplicationGroupResponse EndDeleteReplicationGroup(IAsyncResult asyncResult)
        {
            return endOperation<DeleteReplicationGroupResponse>(asyncResult);
        }
        
        IAsyncResult invokeDeleteReplicationGroup(DeleteReplicationGroupRequest deleteReplicationGroupRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DeleteReplicationGroupRequestMarshaller().Marshall(deleteReplicationGroupRequest);
            var unmarshaller = DeleteReplicationGroupResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DescribeCacheClusters

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
        /// <param name="describeCacheClustersRequest">Container for the necessary parameters to execute the DescribeCacheClusters service method on
        ///          AmazonElastiCache.</param>
        /// 
        /// <returns>The response from the DescribeCacheClusters service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="InvalidParameterValueException"/>
        /// <exception cref="CacheClusterNotFoundException"/>
        /// <exception cref="InvalidParameterCombinationException"/>
        public DescribeCacheClustersResponse DescribeCacheClusters(DescribeCacheClustersRequest describeCacheClustersRequest)
        {
            IAsyncResult asyncResult = invokeDescribeCacheClusters(describeCacheClustersRequest, null, null, true);
            return EndDescribeCacheClusters(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCacheClusters operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache.DescribeCacheClusters"/>
        /// </summary>
        /// 
        /// <param name="describeCacheClustersRequest">Container for the necessary parameters to execute the DescribeCacheClusters operation on
        ///          AmazonElastiCache.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeCacheClusters operation.</returns>
        public IAsyncResult BeginDescribeCacheClusters(DescribeCacheClustersRequest describeCacheClustersRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeCacheClusters(describeCacheClustersRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeCacheClusters operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache.DescribeCacheClusters"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeCacheClusters.</param>
        /// 
        /// <returns>Returns a DescribeCacheClustersResult from AmazonElastiCache.</returns>
        public DescribeCacheClustersResponse EndDescribeCacheClusters(IAsyncResult asyncResult)
        {
            return endOperation<DescribeCacheClustersResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeCacheClusters(DescribeCacheClustersRequest describeCacheClustersRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeCacheClustersRequestMarshaller().Marshall(describeCacheClustersRequest);
            var unmarshaller = DescribeCacheClustersResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
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
        /// <returns>The response from the DescribeCacheClusters service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="InvalidParameterValueException"/>
        /// <exception cref="CacheClusterNotFoundException"/>
        /// <exception cref="InvalidParameterCombinationException"/>
        public DescribeCacheClustersResponse DescribeCacheClusters()
        {
            return DescribeCacheClusters(new DescribeCacheClustersRequest());
        }
        

        #endregion
    
        #region DescribeCacheEngineVersions

        /// <summary>
        /// <para>The <i>DescribeCacheEngineVersions</i> operation returns a list of the available cache engines and their versions.</para>
        /// </summary>
        /// 
        /// <param name="describeCacheEngineVersionsRequest">Container for the necessary parameters to execute the DescribeCacheEngineVersions service
        ///          method on AmazonElastiCache.</param>
        /// 
        /// <returns>The response from the DescribeCacheEngineVersions service method, as returned by AmazonElastiCache.</returns>
        /// 
        public DescribeCacheEngineVersionsResponse DescribeCacheEngineVersions(DescribeCacheEngineVersionsRequest describeCacheEngineVersionsRequest)
        {
            IAsyncResult asyncResult = invokeDescribeCacheEngineVersions(describeCacheEngineVersionsRequest, null, null, true);
            return EndDescribeCacheEngineVersions(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCacheEngineVersions operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache.DescribeCacheEngineVersions"/>
        /// </summary>
        /// 
        /// <param name="describeCacheEngineVersionsRequest">Container for the necessary parameters to execute the DescribeCacheEngineVersions operation
        ///          on AmazonElastiCache.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeCacheEngineVersions operation.</returns>
        public IAsyncResult BeginDescribeCacheEngineVersions(DescribeCacheEngineVersionsRequest describeCacheEngineVersionsRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeCacheEngineVersions(describeCacheEngineVersionsRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeCacheEngineVersions operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache.DescribeCacheEngineVersions"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeCacheEngineVersions.</param>
        /// 
        /// <returns>Returns a DescribeCacheEngineVersionsResult from AmazonElastiCache.</returns>
        public DescribeCacheEngineVersionsResponse EndDescribeCacheEngineVersions(IAsyncResult asyncResult)
        {
            return endOperation<DescribeCacheEngineVersionsResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeCacheEngineVersions(DescribeCacheEngineVersionsRequest describeCacheEngineVersionsRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeCacheEngineVersionsRequestMarshaller().Marshall(describeCacheEngineVersionsRequest);
            var unmarshaller = DescribeCacheEngineVersionsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para>The <i>DescribeCacheEngineVersions</i> operation returns a list of the available cache engines and their versions.</para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeCacheEngineVersions service method, as returned by AmazonElastiCache.</returns>
        /// 
        public DescribeCacheEngineVersionsResponse DescribeCacheEngineVersions()
        {
            return DescribeCacheEngineVersions(new DescribeCacheEngineVersionsRequest());
        }
        

        #endregion
    
        #region DescribeCacheParameterGroups

        /// <summary>
        /// <para>The <i>DescribeCacheParameterGroups</i> operation returns a list of cache parameter group descriptions. If a cache parameter group
        /// name is specified, the list will contain only the descriptions for that group.</para>
        /// </summary>
        /// 
        /// <param name="describeCacheParameterGroupsRequest">Container for the necessary parameters to execute the DescribeCacheParameterGroups service
        ///          method on AmazonElastiCache.</param>
        /// 
        /// <returns>The response from the DescribeCacheParameterGroups service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="InvalidParameterValueException"/>
        /// <exception cref="InvalidParameterCombinationException"/>
        /// <exception cref="CacheParameterGroupNotFoundException"/>
        public DescribeCacheParameterGroupsResponse DescribeCacheParameterGroups(DescribeCacheParameterGroupsRequest describeCacheParameterGroupsRequest)
        {
            IAsyncResult asyncResult = invokeDescribeCacheParameterGroups(describeCacheParameterGroupsRequest, null, null, true);
            return EndDescribeCacheParameterGroups(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCacheParameterGroups operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache.DescribeCacheParameterGroups"/>
        /// </summary>
        /// 
        /// <param name="describeCacheParameterGroupsRequest">Container for the necessary parameters to execute the DescribeCacheParameterGroups
        ///          operation on AmazonElastiCache.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeCacheParameterGroups operation.</returns>
        public IAsyncResult BeginDescribeCacheParameterGroups(DescribeCacheParameterGroupsRequest describeCacheParameterGroupsRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeCacheParameterGroups(describeCacheParameterGroupsRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeCacheParameterGroups operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache.DescribeCacheParameterGroups"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeCacheParameterGroups.</param>
        /// 
        /// <returns>Returns a DescribeCacheParameterGroupsResult from AmazonElastiCache.</returns>
        public DescribeCacheParameterGroupsResponse EndDescribeCacheParameterGroups(IAsyncResult asyncResult)
        {
            return endOperation<DescribeCacheParameterGroupsResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeCacheParameterGroups(DescribeCacheParameterGroupsRequest describeCacheParameterGroupsRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeCacheParameterGroupsRequestMarshaller().Marshall(describeCacheParameterGroupsRequest);
            var unmarshaller = DescribeCacheParameterGroupsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para>The <i>DescribeCacheParameterGroups</i> operation returns a list of cache parameter group descriptions. If a cache parameter group
        /// name is specified, the list will contain only the descriptions for that group.</para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeCacheParameterGroups service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="InvalidParameterValueException"/>
        /// <exception cref="InvalidParameterCombinationException"/>
        /// <exception cref="CacheParameterGroupNotFoundException"/>
        public DescribeCacheParameterGroupsResponse DescribeCacheParameterGroups()
        {
            return DescribeCacheParameterGroups(new DescribeCacheParameterGroupsRequest());
        }
        

        #endregion
    
        #region DescribeCacheParameters

        /// <summary>
        /// <para>The <i>DescribeCacheParameters</i> operation returns the detailed parameter list for a particular cache parameter group.</para>
        /// </summary>
        /// 
        /// <param name="describeCacheParametersRequest">Container for the necessary parameters to execute the DescribeCacheParameters service method on
        ///          AmazonElastiCache.</param>
        /// 
        /// <returns>The response from the DescribeCacheParameters service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="InvalidParameterValueException"/>
        /// <exception cref="InvalidParameterCombinationException"/>
        /// <exception cref="CacheParameterGroupNotFoundException"/>
        public DescribeCacheParametersResponse DescribeCacheParameters(DescribeCacheParametersRequest describeCacheParametersRequest)
        {
            IAsyncResult asyncResult = invokeDescribeCacheParameters(describeCacheParametersRequest, null, null, true);
            return EndDescribeCacheParameters(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCacheParameters operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache.DescribeCacheParameters"/>
        /// </summary>
        /// 
        /// <param name="describeCacheParametersRequest">Container for the necessary parameters to execute the DescribeCacheParameters operation on
        ///          AmazonElastiCache.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeCacheParameters operation.</returns>
        public IAsyncResult BeginDescribeCacheParameters(DescribeCacheParametersRequest describeCacheParametersRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeCacheParameters(describeCacheParametersRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeCacheParameters operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache.DescribeCacheParameters"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeCacheParameters.</param>
        /// 
        /// <returns>Returns a DescribeCacheParametersResult from AmazonElastiCache.</returns>
        public DescribeCacheParametersResponse EndDescribeCacheParameters(IAsyncResult asyncResult)
        {
            return endOperation<DescribeCacheParametersResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeCacheParameters(DescribeCacheParametersRequest describeCacheParametersRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeCacheParametersRequestMarshaller().Marshall(describeCacheParametersRequest);
            var unmarshaller = DescribeCacheParametersResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DescribeCacheSecurityGroups

        /// <summary>
        /// <para>The <i>DescribeCacheSecurityGroups</i> operation returns a list of cache security group descriptions. If a cache security group name
        /// is specified, the list will contain only the description of that group.</para>
        /// </summary>
        /// 
        /// <param name="describeCacheSecurityGroupsRequest">Container for the necessary parameters to execute the DescribeCacheSecurityGroups service
        ///          method on AmazonElastiCache.</param>
        /// 
        /// <returns>The response from the DescribeCacheSecurityGroups service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="InvalidParameterValueException"/>
        /// <exception cref="InvalidParameterCombinationException"/>
        /// <exception cref="CacheSecurityGroupNotFoundException"/>
        public DescribeCacheSecurityGroupsResponse DescribeCacheSecurityGroups(DescribeCacheSecurityGroupsRequest describeCacheSecurityGroupsRequest)
        {
            IAsyncResult asyncResult = invokeDescribeCacheSecurityGroups(describeCacheSecurityGroupsRequest, null, null, true);
            return EndDescribeCacheSecurityGroups(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCacheSecurityGroups operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache.DescribeCacheSecurityGroups"/>
        /// </summary>
        /// 
        /// <param name="describeCacheSecurityGroupsRequest">Container for the necessary parameters to execute the DescribeCacheSecurityGroups operation
        ///          on AmazonElastiCache.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeCacheSecurityGroups operation.</returns>
        public IAsyncResult BeginDescribeCacheSecurityGroups(DescribeCacheSecurityGroupsRequest describeCacheSecurityGroupsRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeCacheSecurityGroups(describeCacheSecurityGroupsRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeCacheSecurityGroups operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache.DescribeCacheSecurityGroups"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeCacheSecurityGroups.</param>
        /// 
        /// <returns>Returns a DescribeCacheSecurityGroupsResult from AmazonElastiCache.</returns>
        public DescribeCacheSecurityGroupsResponse EndDescribeCacheSecurityGroups(IAsyncResult asyncResult)
        {
            return endOperation<DescribeCacheSecurityGroupsResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeCacheSecurityGroups(DescribeCacheSecurityGroupsRequest describeCacheSecurityGroupsRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeCacheSecurityGroupsRequestMarshaller().Marshall(describeCacheSecurityGroupsRequest);
            var unmarshaller = DescribeCacheSecurityGroupsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para>The <i>DescribeCacheSecurityGroups</i> operation returns a list of cache security group descriptions. If a cache security group name
        /// is specified, the list will contain only the description of that group.</para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeCacheSecurityGroups service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="InvalidParameterValueException"/>
        /// <exception cref="InvalidParameterCombinationException"/>
        /// <exception cref="CacheSecurityGroupNotFoundException"/>
        public DescribeCacheSecurityGroupsResponse DescribeCacheSecurityGroups()
        {
            return DescribeCacheSecurityGroups(new DescribeCacheSecurityGroupsRequest());
        }
        

        #endregion
    
        #region DescribeCacheSubnetGroups

        /// <summary>
        /// <para>The <i>DescribeCacheSubnetGroups</i> operation returns a list of cache subnet group descriptions. If a subnet group name is specified,
        /// the list will contain only the description of that group.</para>
        /// </summary>
        /// 
        /// <param name="describeCacheSubnetGroupsRequest">Container for the necessary parameters to execute the DescribeCacheSubnetGroups service
        ///          method on AmazonElastiCache.</param>
        /// 
        /// <returns>The response from the DescribeCacheSubnetGroups service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="CacheSubnetGroupNotFoundException"/>
        public DescribeCacheSubnetGroupsResponse DescribeCacheSubnetGroups(DescribeCacheSubnetGroupsRequest describeCacheSubnetGroupsRequest)
        {
            IAsyncResult asyncResult = invokeDescribeCacheSubnetGroups(describeCacheSubnetGroupsRequest, null, null, true);
            return EndDescribeCacheSubnetGroups(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCacheSubnetGroups operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache.DescribeCacheSubnetGroups"/>
        /// </summary>
        /// 
        /// <param name="describeCacheSubnetGroupsRequest">Container for the necessary parameters to execute the DescribeCacheSubnetGroups operation on
        ///          AmazonElastiCache.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeCacheSubnetGroups operation.</returns>
        public IAsyncResult BeginDescribeCacheSubnetGroups(DescribeCacheSubnetGroupsRequest describeCacheSubnetGroupsRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeCacheSubnetGroups(describeCacheSubnetGroupsRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeCacheSubnetGroups operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache.DescribeCacheSubnetGroups"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeCacheSubnetGroups.</param>
        /// 
        /// <returns>Returns a DescribeCacheSubnetGroupsResult from AmazonElastiCache.</returns>
        public DescribeCacheSubnetGroupsResponse EndDescribeCacheSubnetGroups(IAsyncResult asyncResult)
        {
            return endOperation<DescribeCacheSubnetGroupsResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeCacheSubnetGroups(DescribeCacheSubnetGroupsRequest describeCacheSubnetGroupsRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeCacheSubnetGroupsRequestMarshaller().Marshall(describeCacheSubnetGroupsRequest);
            var unmarshaller = DescribeCacheSubnetGroupsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para>The <i>DescribeCacheSubnetGroups</i> operation returns a list of cache subnet group descriptions. If a subnet group name is specified,
        /// the list will contain only the description of that group.</para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeCacheSubnetGroups service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="CacheSubnetGroupNotFoundException"/>
        public DescribeCacheSubnetGroupsResponse DescribeCacheSubnetGroups()
        {
            return DescribeCacheSubnetGroups(new DescribeCacheSubnetGroupsRequest());
        }
        

        #endregion
    
        #region DescribeEngineDefaultParameters

        /// <summary>
        /// <para>The <i>DescribeEngineDefaultParameters</i> operation returns the default engine and system parameter information for the specified
        /// cache engine.</para>
        /// </summary>
        /// 
        /// <param name="describeEngineDefaultParametersRequest">Container for the necessary parameters to execute the DescribeEngineDefaultParameters
        ///          service method on AmazonElastiCache.</param>
        /// 
        /// <returns>The response from the DescribeEngineDefaultParameters service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="InvalidParameterValueException"/>
        /// <exception cref="InvalidParameterCombinationException"/>
        public DescribeEngineDefaultParametersResponse DescribeEngineDefaultParameters(DescribeEngineDefaultParametersRequest describeEngineDefaultParametersRequest)
        {
            IAsyncResult asyncResult = invokeDescribeEngineDefaultParameters(describeEngineDefaultParametersRequest, null, null, true);
            return EndDescribeEngineDefaultParameters(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEngineDefaultParameters operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache.DescribeEngineDefaultParameters"/>
        /// </summary>
        /// 
        /// <param name="describeEngineDefaultParametersRequest">Container for the necessary parameters to execute the DescribeEngineDefaultParameters
        ///          operation on AmazonElastiCache.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeEngineDefaultParameters operation.</returns>
        public IAsyncResult BeginDescribeEngineDefaultParameters(DescribeEngineDefaultParametersRequest describeEngineDefaultParametersRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeEngineDefaultParameters(describeEngineDefaultParametersRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeEngineDefaultParameters operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache.DescribeEngineDefaultParameters"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeEngineDefaultParameters.</param>
        /// 
        /// <returns>Returns a EngineDefaults from AmazonElastiCache.</returns>
        public DescribeEngineDefaultParametersResponse EndDescribeEngineDefaultParameters(IAsyncResult asyncResult)
        {
            return endOperation<DescribeEngineDefaultParametersResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeEngineDefaultParameters(DescribeEngineDefaultParametersRequest describeEngineDefaultParametersRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeEngineDefaultParametersRequestMarshaller().Marshall(describeEngineDefaultParametersRequest);
            var unmarshaller = DescribeEngineDefaultParametersResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DescribeEvents

        /// <summary>
        /// <para>The <i>DescribeEvents</i> operation returns events related to cache clusters, cache security groups, and cache parameter groups. You
        /// can obtain events specific to a particular cache cluster, cache security group, or cache parameter group by providing the name as a
        /// parameter.</para> <para>By default, only the events occurring within the last hour are returned; however, you can retrieve up to 14 days'
        /// worth of events if necessary.</para>
        /// </summary>
        /// 
        /// <param name="describeEventsRequest">Container for the necessary parameters to execute the DescribeEvents service method on
        ///          AmazonElastiCache.</param>
        /// 
        /// <returns>The response from the DescribeEvents service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="InvalidParameterValueException"/>
        /// <exception cref="InvalidParameterCombinationException"/>
        public DescribeEventsResponse DescribeEvents(DescribeEventsRequest describeEventsRequest)
        {
            IAsyncResult asyncResult = invokeDescribeEvents(describeEventsRequest, null, null, true);
            return EndDescribeEvents(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEvents operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache.DescribeEvents"/>
        /// </summary>
        /// 
        /// <param name="describeEventsRequest">Container for the necessary parameters to execute the DescribeEvents operation on
        ///          AmazonElastiCache.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeEvents
        ///         operation.</returns>
        public IAsyncResult BeginDescribeEvents(DescribeEventsRequest describeEventsRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeEvents(describeEventsRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeEvents operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache.DescribeEvents"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeEvents.</param>
        /// 
        /// <returns>Returns a DescribeEventsResult from AmazonElastiCache.</returns>
        public DescribeEventsResponse EndDescribeEvents(IAsyncResult asyncResult)
        {
            return endOperation<DescribeEventsResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeEvents(DescribeEventsRequest describeEventsRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeEventsRequestMarshaller().Marshall(describeEventsRequest);
            var unmarshaller = DescribeEventsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para>The <i>DescribeEvents</i> operation returns events related to cache clusters, cache security groups, and cache parameter groups. You
        /// can obtain events specific to a particular cache cluster, cache security group, or cache parameter group by providing the name as a
        /// parameter.</para> <para>By default, only the events occurring within the last hour are returned; however, you can retrieve up to 14 days'
        /// worth of events if necessary.</para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeEvents service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="InvalidParameterValueException"/>
        /// <exception cref="InvalidParameterCombinationException"/>
        public DescribeEventsResponse DescribeEvents()
        {
            return DescribeEvents(new DescribeEventsRequest());
        }
        

        #endregion
    
        #region DescribeReplicationGroups

        /// <summary>
        /// <para>The <i>DescribeReplicationGroups</i> operation returns information about a particular replication group. If no identifier is
        /// specified, <i>DescribeReplicationGroups</i> returns information about all replication groups.</para>
        /// </summary>
        /// 
        /// <param name="describeReplicationGroupsRequest">Container for the necessary parameters to execute the DescribeReplicationGroups service
        ///          method on AmazonElastiCache.</param>
        /// 
        /// <returns>The response from the DescribeReplicationGroups service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="InvalidParameterValueException"/>
        /// <exception cref="ReplicationGroupNotFoundException"/>
        /// <exception cref="InvalidParameterCombinationException"/>
        public DescribeReplicationGroupsResponse DescribeReplicationGroups(DescribeReplicationGroupsRequest describeReplicationGroupsRequest)
        {
            IAsyncResult asyncResult = invokeDescribeReplicationGroups(describeReplicationGroupsRequest, null, null, true);
            return EndDescribeReplicationGroups(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReplicationGroups operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache.DescribeReplicationGroups"/>
        /// </summary>
        /// 
        /// <param name="describeReplicationGroupsRequest">Container for the necessary parameters to execute the DescribeReplicationGroups operation on
        ///          AmazonElastiCache.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeReplicationGroups operation.</returns>
        public IAsyncResult BeginDescribeReplicationGroups(DescribeReplicationGroupsRequest describeReplicationGroupsRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeReplicationGroups(describeReplicationGroupsRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeReplicationGroups operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache.DescribeReplicationGroups"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeReplicationGroups.</param>
        /// 
        /// <returns>Returns a DescribeReplicationGroupsResult from AmazonElastiCache.</returns>
        public DescribeReplicationGroupsResponse EndDescribeReplicationGroups(IAsyncResult asyncResult)
        {
            return endOperation<DescribeReplicationGroupsResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeReplicationGroups(DescribeReplicationGroupsRequest describeReplicationGroupsRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeReplicationGroupsRequestMarshaller().Marshall(describeReplicationGroupsRequest);
            var unmarshaller = DescribeReplicationGroupsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para>The <i>DescribeReplicationGroups</i> operation returns information about a particular replication group. If no identifier is
        /// specified, <i>DescribeReplicationGroups</i> returns information about all replication groups.</para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeReplicationGroups service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="InvalidParameterValueException"/>
        /// <exception cref="ReplicationGroupNotFoundException"/>
        /// <exception cref="InvalidParameterCombinationException"/>
        public DescribeReplicationGroupsResponse DescribeReplicationGroups()
        {
            return DescribeReplicationGroups(new DescribeReplicationGroupsRequest());
        }
        

        #endregion
    
        #region DescribeReservedCacheNodes

        /// <summary>
        /// <para>The <i>DescribeReservedCacheNodes</i> operation returns information about reserved cache nodes for this account, or about a specified
        /// reserved cache node.</para>
        /// </summary>
        /// 
        /// <param name="describeReservedCacheNodesRequest">Container for the necessary parameters to execute the DescribeReservedCacheNodes service
        ///          method on AmazonElastiCache.</param>
        /// 
        /// <returns>The response from the DescribeReservedCacheNodes service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="ReservedCacheNodeNotFoundException"/>
        /// <exception cref="InvalidParameterValueException"/>
        /// <exception cref="InvalidParameterCombinationException"/>
        public DescribeReservedCacheNodesResponse DescribeReservedCacheNodes(DescribeReservedCacheNodesRequest describeReservedCacheNodesRequest)
        {
            IAsyncResult asyncResult = invokeDescribeReservedCacheNodes(describeReservedCacheNodesRequest, null, null, true);
            return EndDescribeReservedCacheNodes(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReservedCacheNodes operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache.DescribeReservedCacheNodes"/>
        /// </summary>
        /// 
        /// <param name="describeReservedCacheNodesRequest">Container for the necessary parameters to execute the DescribeReservedCacheNodes operation
        ///          on AmazonElastiCache.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeReservedCacheNodes operation.</returns>
        public IAsyncResult BeginDescribeReservedCacheNodes(DescribeReservedCacheNodesRequest describeReservedCacheNodesRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeReservedCacheNodes(describeReservedCacheNodesRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeReservedCacheNodes operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache.DescribeReservedCacheNodes"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeReservedCacheNodes.</param>
        /// 
        /// <returns>Returns a DescribeReservedCacheNodesResult from AmazonElastiCache.</returns>
        public DescribeReservedCacheNodesResponse EndDescribeReservedCacheNodes(IAsyncResult asyncResult)
        {
            return endOperation<DescribeReservedCacheNodesResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeReservedCacheNodes(DescribeReservedCacheNodesRequest describeReservedCacheNodesRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeReservedCacheNodesRequestMarshaller().Marshall(describeReservedCacheNodesRequest);
            var unmarshaller = DescribeReservedCacheNodesResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para>The <i>DescribeReservedCacheNodes</i> operation returns information about reserved cache nodes for this account, or about a specified
        /// reserved cache node.</para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeReservedCacheNodes service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="ReservedCacheNodeNotFoundException"/>
        /// <exception cref="InvalidParameterValueException"/>
        /// <exception cref="InvalidParameterCombinationException"/>
        public DescribeReservedCacheNodesResponse DescribeReservedCacheNodes()
        {
            return DescribeReservedCacheNodes(new DescribeReservedCacheNodesRequest());
        }
        

        #endregion
    
        #region DescribeReservedCacheNodesOfferings

        /// <summary>
        /// <para>The <i>DescribeReservedCacheNodesOfferings</i> operation lists available reserved cache node offerings.</para>
        /// </summary>
        /// 
        /// <param name="describeReservedCacheNodesOfferingsRequest">Container for the necessary parameters to execute the
        ///          DescribeReservedCacheNodesOfferings service method on AmazonElastiCache.</param>
        /// 
        /// <returns>The response from the DescribeReservedCacheNodesOfferings service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="InvalidParameterValueException"/>
        /// <exception cref="ReservedCacheNodesOfferingNotFoundException"/>
        /// <exception cref="InvalidParameterCombinationException"/>
        public DescribeReservedCacheNodesOfferingsResponse DescribeReservedCacheNodesOfferings(DescribeReservedCacheNodesOfferingsRequest describeReservedCacheNodesOfferingsRequest)
        {
            IAsyncResult asyncResult = invokeDescribeReservedCacheNodesOfferings(describeReservedCacheNodesOfferingsRequest, null, null, true);
            return EndDescribeReservedCacheNodesOfferings(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReservedCacheNodesOfferings operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache.DescribeReservedCacheNodesOfferings"/>
        /// </summary>
        /// 
        /// <param name="describeReservedCacheNodesOfferingsRequest">Container for the necessary parameters to execute the
        ///          DescribeReservedCacheNodesOfferings operation on AmazonElastiCache.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeReservedCacheNodesOfferings operation.</returns>
        public IAsyncResult BeginDescribeReservedCacheNodesOfferings(DescribeReservedCacheNodesOfferingsRequest describeReservedCacheNodesOfferingsRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeReservedCacheNodesOfferings(describeReservedCacheNodesOfferingsRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeReservedCacheNodesOfferings operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache.DescribeReservedCacheNodesOfferings"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeReservedCacheNodesOfferings.</param>
        /// 
        /// <returns>Returns a DescribeReservedCacheNodesOfferingsResult from AmazonElastiCache.</returns>
        public DescribeReservedCacheNodesOfferingsResponse EndDescribeReservedCacheNodesOfferings(IAsyncResult asyncResult)
        {
            return endOperation<DescribeReservedCacheNodesOfferingsResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeReservedCacheNodesOfferings(DescribeReservedCacheNodesOfferingsRequest describeReservedCacheNodesOfferingsRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeReservedCacheNodesOfferingsRequestMarshaller().Marshall(describeReservedCacheNodesOfferingsRequest);
            var unmarshaller = DescribeReservedCacheNodesOfferingsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para>The <i>DescribeReservedCacheNodesOfferings</i> operation lists available reserved cache node offerings.</para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeReservedCacheNodesOfferings service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="InvalidParameterValueException"/>
        /// <exception cref="ReservedCacheNodesOfferingNotFoundException"/>
        /// <exception cref="InvalidParameterCombinationException"/>
        public DescribeReservedCacheNodesOfferingsResponse DescribeReservedCacheNodesOfferings()
        {
            return DescribeReservedCacheNodesOfferings(new DescribeReservedCacheNodesOfferingsRequest());
        }
        

        #endregion
    
        #region ModifyCacheCluster

        /// <summary>
        /// <para>The <i>ModifyCacheCluster</i> operation modifies the settings for a cache cluster. You can use this operation to change one or more
        /// cluster configuration parameters by specifying the parameters and the new values.</para>
        /// </summary>
        /// 
        /// <param name="modifyCacheClusterRequest">Container for the necessary parameters to execute the ModifyCacheCluster service method on
        ///          AmazonElastiCache.</param>
        /// 
        /// <returns>The response from the ModifyCacheCluster service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="NodeQuotaForCustomerExceededException"/>
        /// <exception cref="NodeQuotaForClusterExceededException"/>
        /// <exception cref="InvalidParameterValueException"/>
        /// <exception cref="InvalidCacheSecurityGroupStateException"/>
        /// <exception cref="InvalidVPCNetworkStateException"/>
        /// <exception cref="CacheClusterNotFoundException"/>
        /// <exception cref="InvalidParameterCombinationException"/>
        /// <exception cref="CacheParameterGroupNotFoundException"/>
        /// <exception cref="InvalidCacheClusterStateException"/>
        /// <exception cref="CacheSecurityGroupNotFoundException"/>
        public ModifyCacheClusterResponse ModifyCacheCluster(ModifyCacheClusterRequest modifyCacheClusterRequest)
        {
            IAsyncResult asyncResult = invokeModifyCacheCluster(modifyCacheClusterRequest, null, null, true);
            return EndModifyCacheCluster(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyCacheCluster operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache.ModifyCacheCluster"/>
        /// </summary>
        /// 
        /// <param name="modifyCacheClusterRequest">Container for the necessary parameters to execute the ModifyCacheCluster operation on
        ///          AmazonElastiCache.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndModifyCacheCluster operation.</returns>
        public IAsyncResult BeginModifyCacheCluster(ModifyCacheClusterRequest modifyCacheClusterRequest, AsyncCallback callback, object state)
        {
            return invokeModifyCacheCluster(modifyCacheClusterRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the ModifyCacheCluster operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache.ModifyCacheCluster"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyCacheCluster.</param>
        /// 
        /// <returns>Returns a CacheCluster from AmazonElastiCache.</returns>
        public ModifyCacheClusterResponse EndModifyCacheCluster(IAsyncResult asyncResult)
        {
            return endOperation<ModifyCacheClusterResponse>(asyncResult);
        }
        
        IAsyncResult invokeModifyCacheCluster(ModifyCacheClusterRequest modifyCacheClusterRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ModifyCacheClusterRequestMarshaller().Marshall(modifyCacheClusterRequest);
            var unmarshaller = ModifyCacheClusterResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region ModifyCacheParameterGroup

        /// <summary>
        /// <para>The <i>ModifyCacheParameterGroup</i> operation modifies the parameters of a cache parameter group. You can modify up to 20 parameters
        /// in a single request by submitting a list parameter name and value pairs.</para>
        /// </summary>
        /// 
        /// <param name="modifyCacheParameterGroupRequest">Container for the necessary parameters to execute the ModifyCacheParameterGroup service
        ///          method on AmazonElastiCache.</param>
        /// 
        /// <returns>The response from the ModifyCacheParameterGroup service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="InvalidParameterValueException"/>
        /// <exception cref="InvalidParameterCombinationException"/>
        /// <exception cref="CacheParameterGroupNotFoundException"/>
        /// <exception cref="InvalidCacheParameterGroupStateException"/>
        public ModifyCacheParameterGroupResponse ModifyCacheParameterGroup(ModifyCacheParameterGroupRequest modifyCacheParameterGroupRequest)
        {
            IAsyncResult asyncResult = invokeModifyCacheParameterGroup(modifyCacheParameterGroupRequest, null, null, true);
            return EndModifyCacheParameterGroup(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyCacheParameterGroup operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache.ModifyCacheParameterGroup"/>
        /// </summary>
        /// 
        /// <param name="modifyCacheParameterGroupRequest">Container for the necessary parameters to execute the ModifyCacheParameterGroup operation on
        ///          AmazonElastiCache.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndModifyCacheParameterGroup operation.</returns>
        public IAsyncResult BeginModifyCacheParameterGroup(ModifyCacheParameterGroupRequest modifyCacheParameterGroupRequest, AsyncCallback callback, object state)
        {
            return invokeModifyCacheParameterGroup(modifyCacheParameterGroupRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the ModifyCacheParameterGroup operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache.ModifyCacheParameterGroup"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyCacheParameterGroup.</param>
        /// 
        /// <returns>Returns a ModifyCacheParameterGroupResult from AmazonElastiCache.</returns>
        public ModifyCacheParameterGroupResponse EndModifyCacheParameterGroup(IAsyncResult asyncResult)
        {
            return endOperation<ModifyCacheParameterGroupResponse>(asyncResult);
        }
        
        IAsyncResult invokeModifyCacheParameterGroup(ModifyCacheParameterGroupRequest modifyCacheParameterGroupRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ModifyCacheParameterGroupRequestMarshaller().Marshall(modifyCacheParameterGroupRequest);
            var unmarshaller = ModifyCacheParameterGroupResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region ModifyCacheSubnetGroup

        /// <summary>
        /// <para>The <i>ModifyCacheSubnetGroup</i> operation modifies an existing cache subnet group.</para>
        /// </summary>
        /// 
        /// <param name="modifyCacheSubnetGroupRequest">Container for the necessary parameters to execute the ModifyCacheSubnetGroup service method on
        ///          AmazonElastiCache.</param>
        /// 
        /// <returns>The response from the ModifyCacheSubnetGroup service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="CacheSubnetGroupNotFoundException"/>
        /// <exception cref="CacheSubnetQuotaExceededException"/>
        /// <exception cref="InvalidSubnetException"/>
        /// <exception cref="SubnetInUseException"/>
        public ModifyCacheSubnetGroupResponse ModifyCacheSubnetGroup(ModifyCacheSubnetGroupRequest modifyCacheSubnetGroupRequest)
        {
            IAsyncResult asyncResult = invokeModifyCacheSubnetGroup(modifyCacheSubnetGroupRequest, null, null, true);
            return EndModifyCacheSubnetGroup(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyCacheSubnetGroup operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache.ModifyCacheSubnetGroup"/>
        /// </summary>
        /// 
        /// <param name="modifyCacheSubnetGroupRequest">Container for the necessary parameters to execute the ModifyCacheSubnetGroup operation on
        ///          AmazonElastiCache.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndModifyCacheSubnetGroup operation.</returns>
        public IAsyncResult BeginModifyCacheSubnetGroup(ModifyCacheSubnetGroupRequest modifyCacheSubnetGroupRequest, AsyncCallback callback, object state)
        {
            return invokeModifyCacheSubnetGroup(modifyCacheSubnetGroupRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the ModifyCacheSubnetGroup operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache.ModifyCacheSubnetGroup"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyCacheSubnetGroup.</param>
        /// 
        /// <returns>Returns a CacheSubnetGroup from AmazonElastiCache.</returns>
        public ModifyCacheSubnetGroupResponse EndModifyCacheSubnetGroup(IAsyncResult asyncResult)
        {
            return endOperation<ModifyCacheSubnetGroupResponse>(asyncResult);
        }
        
        IAsyncResult invokeModifyCacheSubnetGroup(ModifyCacheSubnetGroupRequest modifyCacheSubnetGroupRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ModifyCacheSubnetGroupRequestMarshaller().Marshall(modifyCacheSubnetGroupRequest);
            var unmarshaller = ModifyCacheSubnetGroupResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region ModifyReplicationGroup

        /// <summary>
        /// <para>The <i>ModifyReplicationGroup</i> operation modifies the settings for a replication group.</para>
        /// </summary>
        /// 
        /// <param name="modifyReplicationGroupRequest">Container for the necessary parameters to execute the ModifyReplicationGroup service method on
        ///          AmazonElastiCache.</param>
        /// 
        /// <returns>The response from the ModifyReplicationGroup service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="InvalidReplicationGroupStateException"/>
        /// <exception cref="InvalidParameterValueException"/>
        /// <exception cref="InvalidCacheSecurityGroupStateException"/>
        /// <exception cref="InvalidVPCNetworkStateException"/>
        /// <exception cref="ReplicationGroupNotFoundException"/>
        /// <exception cref="CacheClusterNotFoundException"/>
        /// <exception cref="InvalidParameterCombinationException"/>
        /// <exception cref="CacheParameterGroupNotFoundException"/>
        /// <exception cref="InvalidCacheClusterStateException"/>
        /// <exception cref="CacheSecurityGroupNotFoundException"/>
        public ModifyReplicationGroupResponse ModifyReplicationGroup(ModifyReplicationGroupRequest modifyReplicationGroupRequest)
        {
            IAsyncResult asyncResult = invokeModifyReplicationGroup(modifyReplicationGroupRequest, null, null, true);
            return EndModifyReplicationGroup(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyReplicationGroup operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache.ModifyReplicationGroup"/>
        /// </summary>
        /// 
        /// <param name="modifyReplicationGroupRequest">Container for the necessary parameters to execute the ModifyReplicationGroup operation on
        ///          AmazonElastiCache.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndModifyReplicationGroup operation.</returns>
        public IAsyncResult BeginModifyReplicationGroup(ModifyReplicationGroupRequest modifyReplicationGroupRequest, AsyncCallback callback, object state)
        {
            return invokeModifyReplicationGroup(modifyReplicationGroupRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the ModifyReplicationGroup operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache.ModifyReplicationGroup"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyReplicationGroup.</param>
        /// 
        /// <returns>Returns a ReplicationGroup from AmazonElastiCache.</returns>
        public ModifyReplicationGroupResponse EndModifyReplicationGroup(IAsyncResult asyncResult)
        {
            return endOperation<ModifyReplicationGroupResponse>(asyncResult);
        }
        
        IAsyncResult invokeModifyReplicationGroup(ModifyReplicationGroupRequest modifyReplicationGroupRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ModifyReplicationGroupRequestMarshaller().Marshall(modifyReplicationGroupRequest);
            var unmarshaller = ModifyReplicationGroupResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region PurchaseReservedCacheNodesOffering

        /// <summary>
        /// <para>The <i>PurchaseReservedCacheNodesOffering</i> operation allows you to purchase a reserved cache node offering.</para>
        /// </summary>
        /// 
        /// <param name="purchaseReservedCacheNodesOfferingRequest">Container for the necessary parameters to execute the
        ///          PurchaseReservedCacheNodesOffering service method on AmazonElastiCache.</param>
        /// 
        /// <returns>The response from the PurchaseReservedCacheNodesOffering service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="InvalidParameterValueException"/>
        /// <exception cref="ReservedCacheNodeQuotaExceededException"/>
        /// <exception cref="ReservedCacheNodeAlreadyExistsException"/>
        /// <exception cref="ReservedCacheNodesOfferingNotFoundException"/>
        /// <exception cref="InvalidParameterCombinationException"/>
        public PurchaseReservedCacheNodesOfferingResponse PurchaseReservedCacheNodesOffering(PurchaseReservedCacheNodesOfferingRequest purchaseReservedCacheNodesOfferingRequest)
        {
            IAsyncResult asyncResult = invokePurchaseReservedCacheNodesOffering(purchaseReservedCacheNodesOfferingRequest, null, null, true);
            return EndPurchaseReservedCacheNodesOffering(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the PurchaseReservedCacheNodesOffering operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache.PurchaseReservedCacheNodesOffering"/>
        /// </summary>
        /// 
        /// <param name="purchaseReservedCacheNodesOfferingRequest">Container for the necessary parameters to execute the
        ///          PurchaseReservedCacheNodesOffering operation on AmazonElastiCache.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndPurchaseReservedCacheNodesOffering operation.</returns>
        public IAsyncResult BeginPurchaseReservedCacheNodesOffering(PurchaseReservedCacheNodesOfferingRequest purchaseReservedCacheNodesOfferingRequest, AsyncCallback callback, object state)
        {
            return invokePurchaseReservedCacheNodesOffering(purchaseReservedCacheNodesOfferingRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the PurchaseReservedCacheNodesOffering operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache.PurchaseReservedCacheNodesOffering"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPurchaseReservedCacheNodesOffering.</param>
        /// 
        /// <returns>Returns a ReservedCacheNode from AmazonElastiCache.</returns>
        public PurchaseReservedCacheNodesOfferingResponse EndPurchaseReservedCacheNodesOffering(IAsyncResult asyncResult)
        {
            return endOperation<PurchaseReservedCacheNodesOfferingResponse>(asyncResult);
        }
        
        IAsyncResult invokePurchaseReservedCacheNodesOffering(PurchaseReservedCacheNodesOfferingRequest purchaseReservedCacheNodesOfferingRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new PurchaseReservedCacheNodesOfferingRequestMarshaller().Marshall(purchaseReservedCacheNodesOfferingRequest);
            var unmarshaller = PurchaseReservedCacheNodesOfferingResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region RebootCacheCluster

        /// <summary>
        /// <para>The <i>RebootCacheCluster</i> operation reboots some, or all, of the cache cluster nodes within a provisioned cache cluster. This API
        /// will apply any modified cache parameter groups to the cache cluster. The reboot action takes place as soon as possible, and results in a
        /// momentary outage to the cache cluster. During the reboot, the cache cluster status is set to REBOOTING.</para> <para>The reboot causes the
        /// contents of the cache (for each cache cluster node being rebooted) to be lost.</para> <para>When the reboot is complete, a cache cluster
        /// event is created.</para>
        /// </summary>
        /// 
        /// <param name="rebootCacheClusterRequest">Container for the necessary parameters to execute the RebootCacheCluster service method on
        ///          AmazonElastiCache.</param>
        /// 
        /// <returns>The response from the RebootCacheCluster service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="CacheClusterNotFoundException"/>
        /// <exception cref="InvalidCacheClusterStateException"/>
        public RebootCacheClusterResponse RebootCacheCluster(RebootCacheClusterRequest rebootCacheClusterRequest)
        {
            IAsyncResult asyncResult = invokeRebootCacheCluster(rebootCacheClusterRequest, null, null, true);
            return EndRebootCacheCluster(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the RebootCacheCluster operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache.RebootCacheCluster"/>
        /// </summary>
        /// 
        /// <param name="rebootCacheClusterRequest">Container for the necessary parameters to execute the RebootCacheCluster operation on
        ///          AmazonElastiCache.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndRebootCacheCluster operation.</returns>
        public IAsyncResult BeginRebootCacheCluster(RebootCacheClusterRequest rebootCacheClusterRequest, AsyncCallback callback, object state)
        {
            return invokeRebootCacheCluster(rebootCacheClusterRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the RebootCacheCluster operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache.RebootCacheCluster"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRebootCacheCluster.</param>
        /// 
        /// <returns>Returns a CacheCluster from AmazonElastiCache.</returns>
        public RebootCacheClusterResponse EndRebootCacheCluster(IAsyncResult asyncResult)
        {
            return endOperation<RebootCacheClusterResponse>(asyncResult);
        }
        
        IAsyncResult invokeRebootCacheCluster(RebootCacheClusterRequest rebootCacheClusterRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new RebootCacheClusterRequestMarshaller().Marshall(rebootCacheClusterRequest);
            var unmarshaller = RebootCacheClusterResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region ResetCacheParameterGroup

        /// <summary>
        /// <para>The <i>ResetCacheParameterGroup</i> operation modifies the parameters of a cache parameter group to the engine or system default
        /// value. You can reset specific parameters by submitting a list of parameter names. To reset the entire cache parameter group, specify the
        /// <i>ResetAllParameters</i> and <i>CacheParameterGroupName</i> parameters.</para>
        /// </summary>
        /// 
        /// <param name="resetCacheParameterGroupRequest">Container for the necessary parameters to execute the ResetCacheParameterGroup service method
        ///          on AmazonElastiCache.</param>
        /// 
        /// <returns>The response from the ResetCacheParameterGroup service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="InvalidParameterValueException"/>
        /// <exception cref="InvalidParameterCombinationException"/>
        /// <exception cref="InvalidCacheParameterGroupStateException"/>
        /// <exception cref="CacheParameterGroupNotFoundException"/>
        public ResetCacheParameterGroupResponse ResetCacheParameterGroup(ResetCacheParameterGroupRequest resetCacheParameterGroupRequest)
        {
            IAsyncResult asyncResult = invokeResetCacheParameterGroup(resetCacheParameterGroupRequest, null, null, true);
            return EndResetCacheParameterGroup(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the ResetCacheParameterGroup operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache.ResetCacheParameterGroup"/>
        /// </summary>
        /// 
        /// <param name="resetCacheParameterGroupRequest">Container for the necessary parameters to execute the ResetCacheParameterGroup operation on
        ///          AmazonElastiCache.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndResetCacheParameterGroup operation.</returns>
        public IAsyncResult BeginResetCacheParameterGroup(ResetCacheParameterGroupRequest resetCacheParameterGroupRequest, AsyncCallback callback, object state)
        {
            return invokeResetCacheParameterGroup(resetCacheParameterGroupRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the ResetCacheParameterGroup operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache.ResetCacheParameterGroup"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginResetCacheParameterGroup.</param>
        /// 
        /// <returns>Returns a ResetCacheParameterGroupResult from AmazonElastiCache.</returns>
        public ResetCacheParameterGroupResponse EndResetCacheParameterGroup(IAsyncResult asyncResult)
        {
            return endOperation<ResetCacheParameterGroupResponse>(asyncResult);
        }
        
        IAsyncResult invokeResetCacheParameterGroup(ResetCacheParameterGroupRequest resetCacheParameterGroupRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ResetCacheParameterGroupRequestMarshaller().Marshall(resetCacheParameterGroupRequest);
            var unmarshaller = ResetCacheParameterGroupResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region RevokeCacheSecurityGroupIngress

        /// <summary>
        /// <para>The <i>RevokeCacheSecurityGroupIngress</i> operation revokes ingress from a cache security group. Use this operation to disallow
        /// access from an Amazon EC2 security group that had been previously authorized.</para>
        /// </summary>
        /// 
        /// <param name="revokeCacheSecurityGroupIngressRequest">Container for the necessary parameters to execute the RevokeCacheSecurityGroupIngress
        ///          service method on AmazonElastiCache.</param>
        /// 
        /// <returns>The response from the RevokeCacheSecurityGroupIngress service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="InvalidParameterValueException"/>
        /// <exception cref="InvalidCacheSecurityGroupStateException"/>
        /// <exception cref="AuthorizationNotFoundException"/>
        /// <exception cref="InvalidParameterCombinationException"/>
        /// <exception cref="CacheSecurityGroupNotFoundException"/>
        public RevokeCacheSecurityGroupIngressResponse RevokeCacheSecurityGroupIngress(RevokeCacheSecurityGroupIngressRequest revokeCacheSecurityGroupIngressRequest)
        {
            IAsyncResult asyncResult = invokeRevokeCacheSecurityGroupIngress(revokeCacheSecurityGroupIngressRequest, null, null, true);
            return EndRevokeCacheSecurityGroupIngress(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the RevokeCacheSecurityGroupIngress operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache.RevokeCacheSecurityGroupIngress"/>
        /// </summary>
        /// 
        /// <param name="revokeCacheSecurityGroupIngressRequest">Container for the necessary parameters to execute the RevokeCacheSecurityGroupIngress
        ///          operation on AmazonElastiCache.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndRevokeCacheSecurityGroupIngress operation.</returns>
        public IAsyncResult BeginRevokeCacheSecurityGroupIngress(RevokeCacheSecurityGroupIngressRequest revokeCacheSecurityGroupIngressRequest, AsyncCallback callback, object state)
        {
            return invokeRevokeCacheSecurityGroupIngress(revokeCacheSecurityGroupIngressRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the RevokeCacheSecurityGroupIngress operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache.RevokeCacheSecurityGroupIngress"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRevokeCacheSecurityGroupIngress.</param>
        /// 
        /// <returns>Returns a CacheSecurityGroup from AmazonElastiCache.</returns>
        public RevokeCacheSecurityGroupIngressResponse EndRevokeCacheSecurityGroupIngress(IAsyncResult asyncResult)
        {
            return endOperation<RevokeCacheSecurityGroupIngressResponse>(asyncResult);
        }
        
        IAsyncResult invokeRevokeCacheSecurityGroupIngress(RevokeCacheSecurityGroupIngressRequest revokeCacheSecurityGroupIngressRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new RevokeCacheSecurityGroupIngressRequestMarshaller().Marshall(revokeCacheSecurityGroupIngressRequest);
            var unmarshaller = RevokeCacheSecurityGroupIngressResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
    }
}
    
