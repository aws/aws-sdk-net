/*
 * Copyright 2010-2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.ElastiCache.Model;
using Amazon.ElastiCache.Model.Transform;
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

        /// <summary>
        /// Constructs AmazonElastiCacheClient with the credentials defined in the App.config.
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
            : base(new EnvironmentAWSCredentials(), new AmazonElastiCacheConfig(), true, AuthenticationTypes.User) { }

        /// <summary>
        /// Constructs AmazonElastiCacheClient with the credentials defined in the App.config.
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
        /// <param name="config">The AmazonElasticBeanstalkClient Configuration Object</param>
        public AmazonElastiCacheClient(AmazonElastiCacheConfig config)
            : base(new EnvironmentAWSCredentials(), config, true, AuthenticationTypes.User) { }

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
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }
        
   

         /// <summary>
         /// <para> Returns the default engine and system parameter information for the specified cache engine. </para>
         /// </summary>
         /// 
         /// <param name="describeEngineDefaultParametersRequest">Container for the necessary parameters to execute the DescribeEngineDefaultParameters
         ///           service method on AmazonElastiCache.</param>
         /// 
         /// <returns>The response from the DescribeEngineDefaultParameters service method, as returned by AmazonElastiCache.</returns>
         /// 
         /// <exception cref="InvalidParameterValueException"/>
         /// <exception cref="InvalidParameterCombinationException"/>
        public DescribeEngineDefaultParametersResponse DescribeEngineDefaultParameters(DescribeEngineDefaultParametersRequest describeEngineDefaultParametersRequest) 
        {           
            IRequest<DescribeEngineDefaultParametersRequest> request = new DescribeEngineDefaultParametersRequestMarshaller().Marshall(describeEngineDefaultParametersRequest);
            DescribeEngineDefaultParametersResponse response = Invoke<DescribeEngineDefaultParametersRequest, DescribeEngineDefaultParametersResponse> (request, this.signer, DescribeEngineDefaultParametersResponseUnmarshaller.GetInstance());
            return response;
        }
        

         /// <summary>
         /// <para> Modifies the parameters of a CacheParameterGroup. To modify more than one parameter, submit a list of ParameterName and
         /// ParameterValue parameters. A maximum of 20 parameters can be modified in a single request. </para>
         /// </summary>
         /// 
         /// <param name="modifyCacheParameterGroupRequest">Container for the necessary parameters to execute the ModifyCacheParameterGroup service
         ///           method on AmazonElastiCache.</param>
         /// 
         /// <returns>The response from the ModifyCacheParameterGroup service method, as returned by AmazonElastiCache.</returns>
         /// 
         /// <exception cref="InvalidParameterValueException"/>
         /// <exception cref="InvalidParameterCombinationException"/>
         /// <exception cref="CacheParameterGroupNotFoundException"/>
         /// <exception cref="InvalidCacheParameterGroupStateException"/>
        public ModifyCacheParameterGroupResponse ModifyCacheParameterGroup(ModifyCacheParameterGroupRequest modifyCacheParameterGroupRequest) 
        {           
            IRequest<ModifyCacheParameterGroupRequest> request = new ModifyCacheParameterGroupRequestMarshaller().Marshall(modifyCacheParameterGroupRequest);
            ModifyCacheParameterGroupResponse response = Invoke<ModifyCacheParameterGroupRequest, ModifyCacheParameterGroupResponse> (request, this.signer, ModifyCacheParameterGroupResponseUnmarshaller.GetInstance());
            return response;
        }
        

         /// <summary>
         /// <para> Creates a new Cache Cluster. </para>
         /// </summary>
         /// 
         /// <param name="createCacheClusterRequest">Container for the necessary parameters to execute the CreateCacheCluster service method on
         ///           AmazonElastiCache.</param>
         /// 
         /// <returns>The response from the CreateCacheCluster service method, as returned by AmazonElastiCache.</returns>
         /// 
         /// <exception cref="NodeQuotaForCustomerExceededException"/>
         /// <exception cref="NodeQuotaForClusterExceededException"/>
         /// <exception cref="InvalidParameterValueException"/>
         /// <exception cref="ClusterQuotaForCustomerExceededException"/>
         /// <exception cref="CacheClusterAlreadyExistsException"/>
         /// <exception cref="InsufficientCacheClusterCapacityException"/>
         /// <exception cref="InvalidParameterCombinationException"/>
         /// <exception cref="CacheParameterGroupNotFoundException"/>
         /// <exception cref="CacheSecurityGroupNotFoundException"/>
        public CreateCacheClusterResponse CreateCacheCluster(CreateCacheClusterRequest createCacheClusterRequest) 
        {           
            IRequest<CreateCacheClusterRequest> request = new CreateCacheClusterRequestMarshaller().Marshall(createCacheClusterRequest);
            CreateCacheClusterResponse response = Invoke<CreateCacheClusterRequest, CreateCacheClusterResponse> (request, this.signer, CreateCacheClusterResponseUnmarshaller.GetInstance());
            return response;
        }
        

         /// <summary>
         /// <para> Authorizes ingress to a CacheSecurityGroup using EC2 Security Groups as authorization (therefore the application using the cache must
         /// be running on EC2 clusters). This API requires the following parameters: EC2SecurityGroupName and EC2SecurityGroupOwnerId. </para>
         /// <para><b>NOTE:</b> You cannot authorize ingress from an EC2 security group in one Region to an Amazon Cache Cluster in another. </para>
         /// </summary>
         /// 
         /// <param name="authorizeCacheSecurityGroupIngressRequest">Container for the necessary parameters to execute the
         ///           AuthorizeCacheSecurityGroupIngress service method on AmazonElastiCache.</param>
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
            IRequest<AuthorizeCacheSecurityGroupIngressRequest> request = new AuthorizeCacheSecurityGroupIngressRequestMarshaller().Marshall(authorizeCacheSecurityGroupIngressRequest);
            AuthorizeCacheSecurityGroupIngressResponse response = Invoke<AuthorizeCacheSecurityGroupIngressRequest, AuthorizeCacheSecurityGroupIngressResponse> (request, this.signer, AuthorizeCacheSecurityGroupIngressResponseUnmarshaller.GetInstance());
            return response;
        }
        

         /// <summary>
         /// <para> Creates a new Cache Security Group. Cache Security groups control access to one or more Cache Clusters. </para>
         /// </summary>
         /// 
         /// <param name="createCacheSecurityGroupRequest">Container for the necessary parameters to execute the CreateCacheSecurityGroup service method
         ///           on AmazonElastiCache.</param>
         /// 
         /// <returns>The response from the CreateCacheSecurityGroup service method, as returned by AmazonElastiCache.</returns>
         /// 
         /// <exception cref="CacheSecurityGroupAlreadyExistsException"/>
         /// <exception cref="InvalidParameterValueException"/>
         /// <exception cref="CacheSecurityGroupQuotaExceededException"/>
         /// <exception cref="InvalidParameterCombinationException"/>
        public CreateCacheSecurityGroupResponse CreateCacheSecurityGroup(CreateCacheSecurityGroupRequest createCacheSecurityGroupRequest) 
        {           
            IRequest<CreateCacheSecurityGroupRequest> request = new CreateCacheSecurityGroupRequestMarshaller().Marshall(createCacheSecurityGroupRequest);
            CreateCacheSecurityGroupResponse response = Invoke<CreateCacheSecurityGroupRequest, CreateCacheSecurityGroupResponse> (request, this.signer, CreateCacheSecurityGroupResponseUnmarshaller.GetInstance());
            return response;
        }
        

         /// <summary>
         /// <para> Deletes a previously provisioned Cache Cluster. A successful response from the web service indicates the request was received
         /// correctly. This action cannot be canceled or reverted. DeleteCacheCluster deletes all associated Cache Nodes, node endpoints and the Cache
         /// Cluster itself. </para>
         /// </summary>
         /// 
         /// <param name="deleteCacheClusterRequest">Container for the necessary parameters to execute the DeleteCacheCluster service method on
         ///           AmazonElastiCache.</param>
         /// 
         /// <returns>The response from the DeleteCacheCluster service method, as returned by AmazonElastiCache.</returns>
         /// 
         /// <exception cref="InvalidParameterValueException"/>
         /// <exception cref="CacheClusterNotFoundException"/>
         /// <exception cref="InvalidParameterCombinationException"/>
         /// <exception cref="InvalidCacheClusterStateException"/>
        public DeleteCacheClusterResponse DeleteCacheCluster(DeleteCacheClusterRequest deleteCacheClusterRequest) 
        {           
            IRequest<DeleteCacheClusterRequest> request = new DeleteCacheClusterRequestMarshaller().Marshall(deleteCacheClusterRequest);
            DeleteCacheClusterResponse response = Invoke<DeleteCacheClusterRequest, DeleteCacheClusterResponse> (request, this.signer, DeleteCacheClusterResponseUnmarshaller.GetInstance());
            return response;
        }
        

         /// <summary>
         /// <para> Returns a list of CacheSecurityGroup descriptions. If a CacheSecurityGroupName is specified, the list will contain only the
         /// description of the specified CacheSecurityGroup. </para>
         /// </summary>
         /// 
         /// <param name="describeCacheSecurityGroupsRequest">Container for the necessary parameters to execute the DescribeCacheSecurityGroups service
         ///           method on AmazonElastiCache.</param>
         /// 
         /// <returns>The response from the DescribeCacheSecurityGroups service method, as returned by AmazonElastiCache.</returns>
         /// 
         /// <exception cref="InvalidParameterValueException"/>
         /// <exception cref="InvalidParameterCombinationException"/>
         /// <exception cref="CacheSecurityGroupNotFoundException"/>
        public DescribeCacheSecurityGroupsResponse DescribeCacheSecurityGroups(DescribeCacheSecurityGroupsRequest describeCacheSecurityGroupsRequest) 
        {           
            IRequest<DescribeCacheSecurityGroupsRequest> request = new DescribeCacheSecurityGroupsRequestMarshaller().Marshall(describeCacheSecurityGroupsRequest);
            DescribeCacheSecurityGroupsResponse response = Invoke<DescribeCacheSecurityGroupsRequest, DescribeCacheSecurityGroupsResponse> (request, this.signer, DescribeCacheSecurityGroupsResponseUnmarshaller.GetInstance());
            return response;
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
        

         /// <summary>
         /// <para> Returns a list of CacheParameterGroup descriptions. If a CacheParameterGroupName is specified, the list will contain only the
         /// descriptions of the specified CacheParameterGroup. </para>
         /// </summary>
         /// 
         /// <param name="describeCacheParameterGroupsRequest">Container for the necessary parameters to execute the DescribeCacheParameterGroups service
         ///           method on AmazonElastiCache.</param>
         /// 
         /// <returns>The response from the DescribeCacheParameterGroups service method, as returned by AmazonElastiCache.</returns>
         /// 
         /// <exception cref="InvalidParameterValueException"/>
         /// <exception cref="InvalidParameterCombinationException"/>
         /// <exception cref="CacheParameterGroupNotFoundException"/>
        public DescribeCacheParameterGroupsResponse DescribeCacheParameterGroups(DescribeCacheParameterGroupsRequest describeCacheParameterGroupsRequest) 
        {           
            IRequest<DescribeCacheParameterGroupsRequest> request = new DescribeCacheParameterGroupsRequestMarshaller().Marshall(describeCacheParameterGroupsRequest);
            DescribeCacheParameterGroupsResponse response = Invoke<DescribeCacheParameterGroupsRequest, DescribeCacheParameterGroupsResponse> (request, this.signer, DescribeCacheParameterGroupsResponseUnmarshaller.GetInstance());
            return response;
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
        

         /// <summary>
         /// <para> Returns the detailed parameter list for a particular CacheParameterGroup. </para>
         /// </summary>
         /// 
         /// <param name="describeCacheParametersRequest">Container for the necessary parameters to execute the DescribeCacheParameters service method on
         ///           AmazonElastiCache.</param>
         /// 
         /// <returns>The response from the DescribeCacheParameters service method, as returned by AmazonElastiCache.</returns>
         /// 
         /// <exception cref="InvalidParameterValueException"/>
         /// <exception cref="InvalidParameterCombinationException"/>
         /// <exception cref="CacheParameterGroupNotFoundException"/>
        public DescribeCacheParametersResponse DescribeCacheParameters(DescribeCacheParametersRequest describeCacheParametersRequest) 
        {           
            IRequest<DescribeCacheParametersRequest> request = new DescribeCacheParametersRequestMarshaller().Marshall(describeCacheParametersRequest);
            DescribeCacheParametersResponse response = Invoke<DescribeCacheParametersRequest, DescribeCacheParametersResponse> (request, this.signer, DescribeCacheParametersResponseUnmarshaller.GetInstance());
            return response;
        }
        

         /// <summary>
         /// <para> Returns events related to Cache Clusters, Cache Security Groups, and Cache Parameter Groups for the past 14 days. Events specific to
         /// a particular Cache Cluster, Cache Security Group, or Cache Parameter Group can be obtained by providing the name as a parameter. By default,
         /// the past hour of events are returned. </para>
         /// </summary>
         /// 
         /// <param name="describeEventsRequest">Container for the necessary parameters to execute the DescribeEvents service method on
         ///           AmazonElastiCache.</param>
         /// 
         /// <returns>The response from the DescribeEvents service method, as returned by AmazonElastiCache.</returns>
         /// 
         /// <exception cref="InvalidParameterValueException"/>
         /// <exception cref="InvalidParameterCombinationException"/>
        public DescribeEventsResponse DescribeEvents(DescribeEventsRequest describeEventsRequest) 
        {           
            IRequest<DescribeEventsRequest> request = new DescribeEventsRequestMarshaller().Marshall(describeEventsRequest);
            DescribeEventsResponse response = Invoke<DescribeEventsRequest, DescribeEventsResponse> (request, this.signer, DescribeEventsResponseUnmarshaller.GetInstance());
            return response;
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
        

         /// <summary>
         /// <para> Modifies the Cache Cluster settings. You can change one or more Cache Cluster configuration parameters by specifying the parameters
         /// and the new values in the request. </para>
         /// </summary>
         /// 
         /// <param name="modifyCacheClusterRequest">Container for the necessary parameters to execute the ModifyCacheCluster service method on
         ///           AmazonElastiCache.</param>
         /// 
         /// <returns>The response from the ModifyCacheCluster service method, as returned by AmazonElastiCache.</returns>
         /// 
         /// <exception cref="NodeQuotaForCustomerExceededException"/>
         /// <exception cref="NodeQuotaForClusterExceededException"/>
         /// <exception cref="InvalidParameterValueException"/>
         /// <exception cref="InvalidCacheSecurityGroupStateException"/>
         /// <exception cref="CacheClusterNotFoundException"/>
         /// <exception cref="InvalidParameterCombinationException"/>
         /// <exception cref="CacheParameterGroupNotFoundException"/>
         /// <exception cref="InvalidCacheClusterStateException"/>
         /// <exception cref="CacheSecurityGroupNotFoundException"/>
        public ModifyCacheClusterResponse ModifyCacheCluster(ModifyCacheClusterRequest modifyCacheClusterRequest) 
        {           
            IRequest<ModifyCacheClusterRequest> request = new ModifyCacheClusterRequestMarshaller().Marshall(modifyCacheClusterRequest);
            ModifyCacheClusterResponse response = Invoke<ModifyCacheClusterRequest, ModifyCacheClusterResponse> (request, this.signer, ModifyCacheClusterResponseUnmarshaller.GetInstance());
            return response;
        }
        

         /// <summary>
         /// <para> Modifies the parameters of a CacheParameterGroup to the engine or system default value. To reset specific parameters submit a list of
         /// the parameter names. To reset the entire CacheParameterGroup, specify the CacheParameterGroup name and ResetAllParameters parameters.
         /// </para>
         /// </summary>
         /// 
         /// <param name="resetCacheParameterGroupRequest">Container for the necessary parameters to execute the ResetCacheParameterGroup service method
         ///           on AmazonElastiCache.</param>
         /// 
         /// <returns>The response from the ResetCacheParameterGroup service method, as returned by AmazonElastiCache.</returns>
         /// 
         /// <exception cref="InvalidParameterValueException"/>
         /// <exception cref="InvalidParameterCombinationException"/>
         /// <exception cref="InvalidCacheParameterGroupStateException"/>
         /// <exception cref="CacheParameterGroupNotFoundException"/>
        public ResetCacheParameterGroupResponse ResetCacheParameterGroup(ResetCacheParameterGroupRequest resetCacheParameterGroupRequest) 
        {           
            IRequest<ResetCacheParameterGroupRequest> request = new ResetCacheParameterGroupRequestMarshaller().Marshall(resetCacheParameterGroupRequest);
            ResetCacheParameterGroupResponse response = Invoke<ResetCacheParameterGroupRequest, ResetCacheParameterGroupResponse> (request, this.signer, ResetCacheParameterGroupResponseUnmarshaller.GetInstance());
            return response;
        }
        

         /// <summary>
         /// <para> Deletes the specified CacheParameterGroup. The CacheParameterGroup cannot be deleted if it is associated with any cache clusters.
         /// </para>
         /// </summary>
         /// 
         /// <param name="deleteCacheParameterGroupRequest">Container for the necessary parameters to execute the DeleteCacheParameterGroup service
         ///           method on AmazonElastiCache.</param>
         /// 
         /// <exception cref="InvalidParameterValueException"/>
         /// <exception cref="InvalidParameterCombinationException"/>
         /// <exception cref="InvalidCacheParameterGroupStateException"/>
         /// <exception cref="CacheParameterGroupNotFoundException"/>
        public DeleteCacheParameterGroupResponse DeleteCacheParameterGroup(DeleteCacheParameterGroupRequest deleteCacheParameterGroupRequest) 
        {           
            IRequest<DeleteCacheParameterGroupRequest> request = new DeleteCacheParameterGroupRequestMarshaller().Marshall(deleteCacheParameterGroupRequest);
            DeleteCacheParameterGroupResponse response = Invoke<DeleteCacheParameterGroupRequest, DeleteCacheParameterGroupResponse> (request, this.signer, DeleteCacheParameterGroupResponseUnmarshaller.GetInstance());
            return response;
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
         /// <param name="describeCacheClustersRequest">Container for the necessary parameters to execute the DescribeCacheClusters service method on
         ///           AmazonElastiCache.</param>
         /// 
         /// <returns>The response from the DescribeCacheClusters service method, as returned by AmazonElastiCache.</returns>
         /// 
         /// <exception cref="InvalidParameterValueException"/>
         /// <exception cref="CacheClusterNotFoundException"/>
         /// <exception cref="InvalidParameterCombinationException"/>
        public DescribeCacheClustersResponse DescribeCacheClusters(DescribeCacheClustersRequest describeCacheClustersRequest) 
        {           
            IRequest<DescribeCacheClustersRequest> request = new DescribeCacheClustersRequestMarshaller().Marshall(describeCacheClustersRequest);
            DescribeCacheClustersResponse response = Invoke<DescribeCacheClustersRequest, DescribeCacheClustersResponse> (request, this.signer, DescribeCacheClustersResponseUnmarshaller.GetInstance());
            return response;
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
        

         /// <summary>
         /// <para> Deletes a Cache Security Group. </para> <para><b>NOTE:</b>The specified Cache Security Group must not be associated with any Cache
         /// Clusters.</para>
         /// </summary>
         /// 
         /// <param name="deleteCacheSecurityGroupRequest">Container for the necessary parameters to execute the DeleteCacheSecurityGroup service method
         ///           on AmazonElastiCache.</param>
         /// 
         /// <exception cref="InvalidParameterValueException"/>
         /// <exception cref="InvalidCacheSecurityGroupStateException"/>
         /// <exception cref="InvalidParameterCombinationException"/>
         /// <exception cref="CacheSecurityGroupNotFoundException"/>
        public DeleteCacheSecurityGroupResponse DeleteCacheSecurityGroup(DeleteCacheSecurityGroupRequest deleteCacheSecurityGroupRequest) 
        {           
            IRequest<DeleteCacheSecurityGroupRequest> request = new DeleteCacheSecurityGroupRequestMarshaller().Marshall(deleteCacheSecurityGroupRequest);
            DeleteCacheSecurityGroupResponse response = Invoke<DeleteCacheSecurityGroupRequest, DeleteCacheSecurityGroupResponse> (request, this.signer, DeleteCacheSecurityGroupResponseUnmarshaller.GetInstance());
            return response;
        }
        

         /// <summary>
         /// <para> Creates a new Cache Parameter Group. Cache Parameter groups control the parameters for a Cache Cluster.</para>
         /// </summary>
         /// 
         /// <param name="createCacheParameterGroupRequest">Container for the necessary parameters to execute the CreateCacheParameterGroup service
         ///           method on AmazonElastiCache.</param>
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
            IRequest<CreateCacheParameterGroupRequest> request = new CreateCacheParameterGroupRequestMarshaller().Marshall(createCacheParameterGroupRequest);
            CreateCacheParameterGroupResponse response = Invoke<CreateCacheParameterGroupRequest, CreateCacheParameterGroupResponse> (request, this.signer, CreateCacheParameterGroupResponseUnmarshaller.GetInstance());
            return response;
        }
        

         /// <summary>
         /// <para> Reboots some (or all) of the cache cluster nodes within a previously provisioned ElastiCache cluster. This API results in the
         /// application of modified CacheParameterGroup parameters to the cache cluster. This action is taken as soon as possible, and results in a
         /// momentary outage to the cache cluster during which the cache cluster status is set to rebooting. During that momentary outage, the contents
         /// of the cache (for each cache cluster node being rebooted) are lost. A CacheCluster event is created when the reboot is completed. </para>
         /// </summary>
         /// 
         /// <param name="rebootCacheClusterRequest">Container for the necessary parameters to execute the RebootCacheCluster service method on
         ///           AmazonElastiCache.</param>
         /// 
         /// <returns>The response from the RebootCacheCluster service method, as returned by AmazonElastiCache.</returns>
         /// 
         /// <exception cref="CacheClusterNotFoundException"/>
         /// <exception cref="InvalidCacheClusterStateException"/>
        public RebootCacheClusterResponse RebootCacheCluster(RebootCacheClusterRequest rebootCacheClusterRequest) 
        {           
            IRequest<RebootCacheClusterRequest> request = new RebootCacheClusterRequestMarshaller().Marshall(rebootCacheClusterRequest);
            RebootCacheClusterResponse response = Invoke<RebootCacheClusterRequest, RebootCacheClusterResponse> (request, this.signer, RebootCacheClusterResponseUnmarshaller.GetInstance());
            return response;
        }
        

         /// <summary>
         /// <para> Revokes ingress from a CacheSecurityGroup for previously authorized EC2 Security Groups. </para>
         /// </summary>
         /// 
         /// <param name="revokeCacheSecurityGroupIngressRequest">Container for the necessary parameters to execute the RevokeCacheSecurityGroupIngress
         ///           service method on AmazonElastiCache.</param>
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
            IRequest<RevokeCacheSecurityGroupIngressRequest> request = new RevokeCacheSecurityGroupIngressRequestMarshaller().Marshall(revokeCacheSecurityGroupIngressRequest);
            RevokeCacheSecurityGroupIngressResponse response = Invoke<RevokeCacheSecurityGroupIngressRequest, RevokeCacheSecurityGroupIngressResponse> (request, this.signer, RevokeCacheSecurityGroupIngressResponseUnmarshaller.GetInstance());
            return response;
        }
        
    }
}   
    
