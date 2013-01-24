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
    /// Amazon ElastiCache <para> Amazon ElastiCache is a web service that makes it easier to set up, operate, and scale a distributed cache in the
    /// cloud. </para> <para> With Amazon ElastiCache, customers gain all of the benefits of a high-performance, in-memory cache with far less of
    /// the administrative burden of launching and managing a distributed cache. The service makes set-up, scaling, and cluster failure handling
    /// much simpler than in a self-managed cache deployment. </para> <para> In addition, through integration with Amazon CloudWatch, customers get
    /// enhanced visibility into the key performance statistics associated with their cache and can receive alarms if a part of their cache runs
    /// hot. </para>
    /// </summary>
    public class AmazonElastiCacheClient : AmazonWebServiceClient, AmazonElastiCache
    {
    
        AbstractAWSSigner signer = new QueryStringSigner();

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
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonElastiCacheConfig(), true, AuthenticationTypes.User | AuthenticationTypes.Session) { }

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
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonElastiCacheConfig(){RegionEndpoint = region}, true, AuthenticationTypes.User | AuthenticationTypes.Session) { }

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
            : base(FallbackCredentialsFactory.GetCredentials(), config, true, AuthenticationTypes.User | AuthenticationTypes.Session) { }

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
            : base(credentials, clientConfig, false, AuthenticationTypes.User | AuthenticationTypes.Session)
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
   
        #region AuthorizeCacheSecurityGroupIngress

        /// <summary>
        /// <para> Authorizes ingress to a CacheSecurityGroup using EC2 Security Groups as authorization (therefore the application using the cache must
        /// be running on EC2 clusters). This API requires the following parameters: EC2SecurityGroupName and EC2SecurityGroupOwnerId. </para>
        /// <para><b>NOTE:</b> You cannot authorize ingress from an EC2 security group in one Region to an Amazon Cache Cluster in another. </para>
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
        /// <seealso cref="Amazon.ElastiCache.AmazonElastiCache.AuthorizeCacheSecurityGroupIngress"/>
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
        /// <seealso cref="Amazon.ElastiCache.AmazonElastiCache.AuthorizeCacheSecurityGroupIngress"/>
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
    
        #region CreateCacheSubnetGroup

        /// <summary>
        /// <para> Creates a new Cache Subnet Group. </para>
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
        /// <seealso cref="Amazon.ElastiCache.AmazonElastiCache.CreateCacheSubnetGroup"/>
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
        /// <seealso cref="Amazon.ElastiCache.AmazonElastiCache.CreateCacheSubnetGroup"/>
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
    
        #region PurchaseReservedCacheNodesOffering

        /// <summary>
        /// <para> Purchases a reserved Cache Node offering. </para>
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
        /// <seealso cref="Amazon.ElastiCache.AmazonElastiCache.PurchaseReservedCacheNodesOffering"/>
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
        /// <seealso cref="Amazon.ElastiCache.AmazonElastiCache.PurchaseReservedCacheNodesOffering"/>
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
        /// <para> Reboots some (or all) of the cache cluster nodes within a previously provisioned ElastiCache cluster. This API results in the
        /// application of modified CacheParameterGroup parameters to the cache cluster. This action is taken as soon as possible, and results in a
        /// momentary outage to the cache cluster during which the cache cluster status is set to rebooting. During that momentary outage, the contents
        /// of the cache (for each cache cluster node being rebooted) are lost. A CacheCluster event is created when the reboot is completed. </para>
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
        /// <seealso cref="Amazon.ElastiCache.AmazonElastiCache.RebootCacheCluster"/>
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
        /// <seealso cref="Amazon.ElastiCache.AmazonElastiCache.RebootCacheCluster"/>
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
    
        #region RevokeCacheSecurityGroupIngress

        /// <summary>
        /// <para> Revokes ingress from a CacheSecurityGroup for previously authorized EC2 Security Groups. </para>
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
        /// <seealso cref="Amazon.ElastiCache.AmazonElastiCache.RevokeCacheSecurityGroupIngress"/>
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
        /// <seealso cref="Amazon.ElastiCache.AmazonElastiCache.RevokeCacheSecurityGroupIngress"/>
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
    
        #region DescribeCacheSubnetGroups

        /// <summary>
        /// <para> Returns a list of CacheSubnetGroup descriptions. If a CacheSubnetGroupName is specified, the list will contain only the description
        /// of the specified Cache Subnet Group. </para>
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
        /// <seealso cref="Amazon.ElastiCache.AmazonElastiCache.DescribeCacheSubnetGroups"/>
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
        /// <seealso cref="Amazon.ElastiCache.AmazonElastiCache.DescribeCacheSubnetGroups"/>
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
        /// <para> Returns a list of CacheSubnetGroup descriptions. If a CacheSubnetGroupName is specified, the list will contain only the description
        /// of the specified Cache Subnet Group. </para>
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
    
        #region CreateCacheSecurityGroup

        /// <summary>
        /// <para> Creates a new Cache Security Group. Cache Security groups control access to one or more Cache Clusters. </para> <para> Only use cache
        /// security groups when you are creating a cluster outside of an Amazon Virtual Private Cloud (VPC). Inside of a VPC, use VPC security groups.
        /// </para>
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
        /// <seealso cref="Amazon.ElastiCache.AmazonElastiCache.CreateCacheSecurityGroup"/>
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
        /// <seealso cref="Amazon.ElastiCache.AmazonElastiCache.CreateCacheSecurityGroup"/>
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
    
        #region CreateCacheCluster

        /// <summary>
        /// <para> Creates a new Cache Cluster. </para>
        /// </summary>
        /// 
        /// <param name="createCacheClusterRequest">Container for the necessary parameters to execute the CreateCacheCluster service method on
        ///          AmazonElastiCache.</param>
        /// 
        /// <returns>The response from the CreateCacheCluster service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="NodeQuotaForCustomerExceededException"/>
        /// <exception cref="NodeQuotaForClusterExceededException"/>
        /// <exception cref="CacheSubnetGroupNotFoundException"/>
        /// <exception cref="InvalidParameterValueException"/>
        /// <exception cref="ClusterQuotaForCustomerExceededException"/>
        /// <exception cref="CacheClusterAlreadyExistsException"/>
        /// <exception cref="InvalidVPCNetworkStateException"/>
        /// <exception cref="InsufficientCacheClusterCapacityException"/>
        /// <exception cref="InvalidParameterCombinationException"/>
        /// <exception cref="CacheParameterGroupNotFoundException"/>
        /// <exception cref="CacheSecurityGroupNotFoundException"/>
        public CreateCacheClusterResponse CreateCacheCluster(CreateCacheClusterRequest createCacheClusterRequest)
        {
            IAsyncResult asyncResult = invokeCreateCacheCluster(createCacheClusterRequest, null, null, true);
            return EndCreateCacheCluster(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCacheCluster operation.
        /// <seealso cref="Amazon.ElastiCache.AmazonElastiCache.CreateCacheCluster"/>
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
        /// <seealso cref="Amazon.ElastiCache.AmazonElastiCache.CreateCacheCluster"/>
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
    
        #region DescribeEvents

        /// <summary>
        /// <para> Returns events related to Cache Clusters, Cache Security Groups, and Cache Parameter Groups for the past 14 days. Events specific to
        /// a particular Cache Cluster, Cache Security Group, or Cache Parameter Group can be obtained by providing the name as a parameter. By default,
        /// the past hour of events are returned. </para>
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
        /// <seealso cref="Amazon.ElastiCache.AmazonElastiCache.DescribeEvents"/>
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
        /// <seealso cref="Amazon.ElastiCache.AmazonElastiCache.DescribeEvents"/>
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
        /// <para> Returns events related to Cache Clusters, Cache Security Groups, and Cache Parameter Groups for the past 14 days. Events specific to
        /// a particular Cache Cluster, Cache Security Group, or Cache Parameter Group can be obtained by providing the name as a parameter. By default,
        /// the past hour of events are returned. </para>
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
    
        #region DescribeReservedCacheNodes

        /// <summary>
        /// <para> Returns information about reserved Cache Nodes for this account, or about a specified reserved Cache Node. </para>
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
        /// <seealso cref="Amazon.ElastiCache.AmazonElastiCache.DescribeReservedCacheNodes"/>
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
        /// <seealso cref="Amazon.ElastiCache.AmazonElastiCache.DescribeReservedCacheNodes"/>
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
        /// <para> Returns information about reserved Cache Nodes for this account, or about a specified reserved Cache Node. </para>
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
    
        #region DescribeCacheEngineVersions

        /// <summary>
        /// <para> Returns a list of the available cache engines and their versions. </para>
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
        /// <seealso cref="Amazon.ElastiCache.AmazonElastiCache.DescribeCacheEngineVersions"/>
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
        /// <seealso cref="Amazon.ElastiCache.AmazonElastiCache.DescribeCacheEngineVersions"/>
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
        /// <para> Returns a list of the available cache engines and their versions. </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeCacheEngineVersions service method, as returned by AmazonElastiCache.</returns>
        /// 
        public DescribeCacheEngineVersionsResponse DescribeCacheEngineVersions()
        {
            return DescribeCacheEngineVersions(new DescribeCacheEngineVersionsRequest());
        }
        

        #endregion
    
        #region DeleteCacheParameterGroup

        /// <summary>
        /// <para> Deletes the specified CacheParameterGroup. The CacheParameterGroup cannot be deleted if it is associated with any cache clusters.
        /// </para>
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
        /// <seealso cref="Amazon.ElastiCache.AmazonElastiCache.DeleteCacheParameterGroup"/>
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
        /// <seealso cref="Amazon.ElastiCache.AmazonElastiCache.DeleteCacheParameterGroup"/>
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
    
        #region ModifyCacheParameterGroup

        /// <summary>
        /// <para> Modifies the parameters of a CacheParameterGroup. To modify more than one parameter, submit a list of ParameterName and
        /// ParameterValue parameters. A maximum of 20 parameters can be modified in a single request. </para>
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
        /// <seealso cref="Amazon.ElastiCache.AmazonElastiCache.ModifyCacheParameterGroup"/>
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
        /// <seealso cref="Amazon.ElastiCache.AmazonElastiCache.ModifyCacheParameterGroup"/>
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
    
        #region DescribeEngineDefaultParameters

        /// <summary>
        /// <para> Returns the default engine and system parameter information for the specified cache engine. </para>
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
        /// <seealso cref="Amazon.ElastiCache.AmazonElastiCache.DescribeEngineDefaultParameters"/>
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
        /// <seealso cref="Amazon.ElastiCache.AmazonElastiCache.DescribeEngineDefaultParameters"/>
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
    
        #region DeleteCacheSubnetGroup

        /// <summary>
        /// <para> Deletes a Cache Subnet Group. </para> <para><b>NOTE:</b>The specified Cache Subnet Group must not be associated with any Cache
        /// Clusters.</para>
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
        /// <seealso cref="Amazon.ElastiCache.AmazonElastiCache.DeleteCacheSubnetGroup"/>
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
        /// <seealso cref="Amazon.ElastiCache.AmazonElastiCache.DeleteCacheSubnetGroup"/>
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
    
        #region CreateCacheParameterGroup

        /// <summary>
        /// <para> Creates a new Cache Parameter Group. Cache Parameter groups control the parameters for a Cache Cluster.</para>
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
        /// <seealso cref="Amazon.ElastiCache.AmazonElastiCache.CreateCacheParameterGroup"/>
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
        /// <seealso cref="Amazon.ElastiCache.AmazonElastiCache.CreateCacheParameterGroup"/>
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
    
        #region DescribeCacheSecurityGroups

        /// <summary>
        /// <para> Returns a list of CacheSecurityGroup descriptions. If a CacheSecurityGroupName is specified, the list will contain only the
        /// description of the specified CacheSecurityGroup. </para>
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
        /// <seealso cref="Amazon.ElastiCache.AmazonElastiCache.DescribeCacheSecurityGroups"/>
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
        /// <seealso cref="Amazon.ElastiCache.AmazonElastiCache.DescribeCacheSecurityGroups"/>
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
        /// <para> Returns a list of CacheSecurityGroup descriptions. If a CacheSecurityGroupName is specified, the list will contain only the
        /// description of the specified CacheSecurityGroup. </para>
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
    
        #region DescribeCacheParameterGroups

        /// <summary>
        /// <para> Returns a list of CacheParameterGroup descriptions. If a CacheParameterGroupName is specified, the list will contain only the
        /// descriptions of the specified CacheParameterGroup. </para>
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
        /// <seealso cref="Amazon.ElastiCache.AmazonElastiCache.DescribeCacheParameterGroups"/>
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
        /// <seealso cref="Amazon.ElastiCache.AmazonElastiCache.DescribeCacheParameterGroups"/>
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
        /// <para> Returns a list of CacheParameterGroup descriptions. If a CacheParameterGroupName is specified, the list will contain only the
        /// descriptions of the specified CacheParameterGroup. </para>
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
    
        #region DescribeCacheClusters

        /// <summary>
        /// <para> Returns information about all provisioned Cache Clusters if no Cache Cluster identifier is specified, or about a specific Cache
        /// Cluster if a Cache Cluster identifier is supplied. </para> <para> Cluster information will be returned by default. An optional
        /// <i>ShowDetails</i> flag can be used to retrieve detailed information about the Cache Nodes associated with the Cache Cluster. Details
        /// include the DNS address and port for the Cache Node endpoint. </para> <para> If the cluster is in the CREATING state, only cluster level
        /// information will be displayed until all of the nodes are successfully provisioned. </para> <para> If the cluster is in the DELETING state,
        /// only cluster level information will be displayed. </para> <para> While adding Cache Nodes, node endpoint information and creation time for
        /// the additional nodes will not be displayed until they are completely provisioned. The cluster lifecycle tells the customer when new nodes
        /// are AVAILABLE. </para> <para> While removing existing Cache Nodes from an cluster, endpoint information for the removed nodes will not be
        /// displayed. </para> <para>DescribeCacheClusters supports pagination.</para>
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
        /// <seealso cref="Amazon.ElastiCache.AmazonElastiCache.DescribeCacheClusters"/>
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
        /// <seealso cref="Amazon.ElastiCache.AmazonElastiCache.DescribeCacheClusters"/>
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
        /// <para> Returns information about all provisioned Cache Clusters if no Cache Cluster identifier is specified, or about a specific Cache
        /// Cluster if a Cache Cluster identifier is supplied. </para> <para> Cluster information will be returned by default. An optional
        /// <i>ShowDetails</i> flag can be used to retrieve detailed information about the Cache Nodes associated with the Cache Cluster. Details
        /// include the DNS address and port for the Cache Node endpoint. </para> <para> If the cluster is in the CREATING state, only cluster level
        /// information will be displayed until all of the nodes are successfully provisioned. </para> <para> If the cluster is in the DELETING state,
        /// only cluster level information will be displayed. </para> <para> While adding Cache Nodes, node endpoint information and creation time for
        /// the additional nodes will not be displayed until they are completely provisioned. The cluster lifecycle tells the customer when new nodes
        /// are AVAILABLE. </para> <para> While removing existing Cache Nodes from an cluster, endpoint information for the removed nodes will not be
        /// displayed. </para> <para>DescribeCacheClusters supports pagination.</para>
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
    
        #region ResetCacheParameterGroup

        /// <summary>
        /// <para> Modifies the parameters of a CacheParameterGroup to the engine or system default value. To reset specific parameters submit a list of
        /// the parameter names. To reset the entire CacheParameterGroup, specify the CacheParameterGroup name and ResetAllParameters parameters.
        /// </para>
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
        /// <seealso cref="Amazon.ElastiCache.AmazonElastiCache.ResetCacheParameterGroup"/>
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
        /// <seealso cref="Amazon.ElastiCache.AmazonElastiCache.ResetCacheParameterGroup"/>
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
    
        #region DeleteCacheSecurityGroup

        /// <summary>
        /// <para> Deletes a Cache Security Group. </para> <para><b>NOTE:</b>The specified Cache Security Group must not be associated with any Cache
        /// Clusters.</para>
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
        /// <seealso cref="Amazon.ElastiCache.AmazonElastiCache.DeleteCacheSecurityGroup"/>
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
        /// <seealso cref="Amazon.ElastiCache.AmazonElastiCache.DeleteCacheSecurityGroup"/>
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
    
        #region ModifyCacheCluster

        /// <summary>
        /// <para> Modifies the Cache Cluster settings. You can change one or more Cache Cluster configuration parameters by specifying the parameters
        /// and the new values in the request. </para>
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
        /// <seealso cref="Amazon.ElastiCache.AmazonElastiCache.ModifyCacheCluster"/>
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
        /// <seealso cref="Amazon.ElastiCache.AmazonElastiCache.ModifyCacheCluster"/>
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
    
        #region DeleteCacheCluster

        /// <summary>
        /// <para> Deletes a previously provisioned Cache Cluster. A successful response from the web service indicates the request was received
        /// correctly. This action cannot be canceled or reverted. DeleteCacheCluster deletes all associated Cache Nodes, node endpoints and the Cache
        /// Cluster itself. </para>
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
        /// <seealso cref="Amazon.ElastiCache.AmazonElastiCache.DeleteCacheCluster"/>
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
        /// <seealso cref="Amazon.ElastiCache.AmazonElastiCache.DeleteCacheCluster"/>
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
    
        #region DescribeReservedCacheNodesOfferings

        /// <summary>
        /// <para> Lists available reserved Cache Node offerings. </para>
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
        /// <seealso cref="Amazon.ElastiCache.AmazonElastiCache.DescribeReservedCacheNodesOfferings"/>
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
        /// <seealso cref="Amazon.ElastiCache.AmazonElastiCache.DescribeReservedCacheNodesOfferings"/>
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
        /// <para> Lists available reserved Cache Node offerings. </para>
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
    
        #region DescribeCacheParameters

        /// <summary>
        /// <para> Returns the detailed parameter list for a particular CacheParameterGroup. </para>
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
        /// <seealso cref="Amazon.ElastiCache.AmazonElastiCache.DescribeCacheParameters"/>
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
        /// <seealso cref="Amazon.ElastiCache.AmazonElastiCache.DescribeCacheParameters"/>
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
    
        #region ModifyCacheSubnetGroup

        /// <summary>
        /// <para> Modifies an existing Cache Subnet Group. </para>
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
        /// <seealso cref="Amazon.ElastiCache.AmazonElastiCache.ModifyCacheSubnetGroup"/>
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
        /// <seealso cref="Amazon.ElastiCache.AmazonElastiCache.ModifyCacheSubnetGroup"/>
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
    
    }
}
    
