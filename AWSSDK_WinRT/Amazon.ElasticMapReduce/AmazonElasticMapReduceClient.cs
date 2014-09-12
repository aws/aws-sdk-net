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

/*
 * Do not modify this file. This file is generated from the elasticmapreduce-2009-03-31.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.ElasticMapReduce.Model;
using Amazon.ElasticMapReduce.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.ElasticMapReduce
{
    /// <summary>
    /// Implementation for accessing ElasticMapReduce
    ///
    /// This is the <i>Amazon Elastic MapReduce API Reference</i>. This guide provides descriptions
    /// and         samples of the Amazon Elastic MapReduce APIs.
    /// 
    ///       
    /// <para>
    /// Amazon Elastic MapReduce (Amazon EMR) is a web service that makes it easy to process
    /// large amounts of         data efficiently. Amazon EMR uses Hadoop processing combined
    /// with several AWS         products to do tasks such as web indexing, data mining, log
    /// file analysis, machine         learning, scientific simulation, and data warehousing.
    /// </para>
    /// </summary>
    public partial class AmazonElasticMapReduceClient : AmazonServiceClient, IAmazonElasticMapReduce
    {
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonElasticMapReduceClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonElasticMapReduceClient(AWSCredentials credentials)
            : this(credentials, new AmazonElasticMapReduceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonElasticMapReduceClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonElasticMapReduceClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonElasticMapReduceConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonElasticMapReduceClient with AWS Credentials and an
        /// AmazonElasticMapReduceClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonElasticMapReduceClient Configuration Object</param>
        public AmazonElasticMapReduceClient(AWSCredentials credentials, AmazonElasticMapReduceConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonElasticMapReduceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonElasticMapReduceClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonElasticMapReduceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonElasticMapReduceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonElasticMapReduceClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonElasticMapReduceConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonElasticMapReduceClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonElasticMapReduceClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonElasticMapReduceClient Configuration Object</param>
        public AmazonElasticMapReduceClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonElasticMapReduceConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonElasticMapReduceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonElasticMapReduceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonElasticMapReduceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonElasticMapReduceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonElasticMapReduceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonElasticMapReduceConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonElasticMapReduceClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonElasticMapReduceClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonElasticMapReduceClient Configuration Object</param>
        public AmazonElasticMapReduceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonElasticMapReduceConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides

        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        } 


        #endregion

        #region Dispose

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion

        
        #region  AddInstanceGroups

        internal AddInstanceGroupsResponse AddInstanceGroups(AddInstanceGroupsRequest request)
        {
            var marshaller = new AddInstanceGroupsRequestMarshaller();
            var unmarshaller = AddInstanceGroupsResponseUnmarshaller.Instance;

            return Invoke<AddInstanceGroupsRequest,AddInstanceGroupsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AddInstanceGroups operation.
        /// <seealso cref="Amazon.ElasticMapReduce.IAmazonElasticMapReduce"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddInstanceGroups operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<AddInstanceGroupsResponse> AddInstanceGroupsAsync(AddInstanceGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AddInstanceGroupsRequestMarshaller();
            var unmarshaller = AddInstanceGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<AddInstanceGroupsRequest,AddInstanceGroupsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  AddJobFlowSteps

        internal AddJobFlowStepsResponse AddJobFlowSteps(AddJobFlowStepsRequest request)
        {
            var marshaller = new AddJobFlowStepsRequestMarshaller();
            var unmarshaller = AddJobFlowStepsResponseUnmarshaller.Instance;

            return Invoke<AddJobFlowStepsRequest,AddJobFlowStepsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AddJobFlowSteps operation.
        /// <seealso cref="Amazon.ElasticMapReduce.IAmazonElasticMapReduce"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddJobFlowSteps operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<AddJobFlowStepsResponse> AddJobFlowStepsAsync(AddJobFlowStepsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AddJobFlowStepsRequestMarshaller();
            var unmarshaller = AddJobFlowStepsResponseUnmarshaller.Instance;

            return InvokeAsync<AddJobFlowStepsRequest,AddJobFlowStepsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  AddTags

        internal AddTagsResponse AddTags(AddTagsRequest request)
        {
            var marshaller = new AddTagsRequestMarshaller();
            var unmarshaller = AddTagsResponseUnmarshaller.Instance;

            return Invoke<AddTagsRequest,AddTagsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AddTags operation.
        /// <seealso cref="Amazon.ElasticMapReduce.IAmazonElasticMapReduce"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddTags operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<AddTagsResponse> AddTagsAsync(AddTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AddTagsRequestMarshaller();
            var unmarshaller = AddTagsResponseUnmarshaller.Instance;

            return InvokeAsync<AddTagsRequest,AddTagsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeCluster

        internal DescribeClusterResponse DescribeCluster()
        {
            return DescribeCluster(new DescribeClusterRequest());
        }
        internal DescribeClusterResponse DescribeCluster(DescribeClusterRequest request)
        {
            var marshaller = new DescribeClusterRequestMarshaller();
            var unmarshaller = DescribeClusterResponseUnmarshaller.Instance;

            return Invoke<DescribeClusterRequest,DescribeClusterResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCluster operation.
        /// <seealso cref="Amazon.ElasticMapReduce.IAmazonElasticMapReduce"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCluster operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeClusterResponse> DescribeClusterAsync(DescribeClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeClusterRequestMarshaller();
            var unmarshaller = DescribeClusterResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeClusterRequest,DescribeClusterResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeJobFlows

        internal DescribeJobFlowsResponse DescribeJobFlows()
        {
            return DescribeJobFlows(new DescribeJobFlowsRequest());
        }
        internal DescribeJobFlowsResponse DescribeJobFlows(DescribeJobFlowsRequest request)
        {
            var marshaller = new DescribeJobFlowsRequestMarshaller();
            var unmarshaller = DescribeJobFlowsResponseUnmarshaller.Instance;

            return Invoke<DescribeJobFlowsRequest,DescribeJobFlowsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeJobFlows operation.
        /// <seealso cref="Amazon.ElasticMapReduce.IAmazonElasticMapReduce"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeJobFlows operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeJobFlowsResponse> DescribeJobFlowsAsync(DescribeJobFlowsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeJobFlowsRequestMarshaller();
            var unmarshaller = DescribeJobFlowsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeJobFlowsRequest,DescribeJobFlowsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeStep

        internal DescribeStepResponse DescribeStep()
        {
            return DescribeStep(new DescribeStepRequest());
        }
        internal DescribeStepResponse DescribeStep(DescribeStepRequest request)
        {
            var marshaller = new DescribeStepRequestMarshaller();
            var unmarshaller = DescribeStepResponseUnmarshaller.Instance;

            return Invoke<DescribeStepRequest,DescribeStepResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeStep operation.
        /// <seealso cref="Amazon.ElasticMapReduce.IAmazonElasticMapReduce"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeStep operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeStepResponse> DescribeStepAsync(DescribeStepRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeStepRequestMarshaller();
            var unmarshaller = DescribeStepResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeStepRequest,DescribeStepResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListBootstrapActions

        internal ListBootstrapActionsResponse ListBootstrapActions()
        {
            return ListBootstrapActions(new ListBootstrapActionsRequest());
        }
        internal ListBootstrapActionsResponse ListBootstrapActions(ListBootstrapActionsRequest request)
        {
            var marshaller = new ListBootstrapActionsRequestMarshaller();
            var unmarshaller = ListBootstrapActionsResponseUnmarshaller.Instance;

            return Invoke<ListBootstrapActionsRequest,ListBootstrapActionsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListBootstrapActions operation.
        /// <seealso cref="Amazon.ElasticMapReduce.IAmazonElasticMapReduce"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListBootstrapActions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ListBootstrapActionsResponse> ListBootstrapActionsAsync(ListBootstrapActionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListBootstrapActionsRequestMarshaller();
            var unmarshaller = ListBootstrapActionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListBootstrapActionsRequest,ListBootstrapActionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListClusters

        internal ListClustersResponse ListClusters()
        {
            return ListClusters(new ListClustersRequest());
        }
        internal ListClustersResponse ListClusters(ListClustersRequest request)
        {
            var marshaller = new ListClustersRequestMarshaller();
            var unmarshaller = ListClustersResponseUnmarshaller.Instance;

            return Invoke<ListClustersRequest,ListClustersResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListClusters operation.
        /// <seealso cref="Amazon.ElasticMapReduce.IAmazonElasticMapReduce"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListClusters operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ListClustersResponse> ListClustersAsync(ListClustersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListClustersRequestMarshaller();
            var unmarshaller = ListClustersResponseUnmarshaller.Instance;

            return InvokeAsync<ListClustersRequest,ListClustersResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListInstanceGroups

        internal ListInstanceGroupsResponse ListInstanceGroups()
        {
            return ListInstanceGroups(new ListInstanceGroupsRequest());
        }
        internal ListInstanceGroupsResponse ListInstanceGroups(ListInstanceGroupsRequest request)
        {
            var marshaller = new ListInstanceGroupsRequestMarshaller();
            var unmarshaller = ListInstanceGroupsResponseUnmarshaller.Instance;

            return Invoke<ListInstanceGroupsRequest,ListInstanceGroupsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListInstanceGroups operation.
        /// <seealso cref="Amazon.ElasticMapReduce.IAmazonElasticMapReduce"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListInstanceGroups operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ListInstanceGroupsResponse> ListInstanceGroupsAsync(ListInstanceGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListInstanceGroupsRequestMarshaller();
            var unmarshaller = ListInstanceGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<ListInstanceGroupsRequest,ListInstanceGroupsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListInstances

        internal ListInstancesResponse ListInstances()
        {
            return ListInstances(new ListInstancesRequest());
        }
        internal ListInstancesResponse ListInstances(ListInstancesRequest request)
        {
            var marshaller = new ListInstancesRequestMarshaller();
            var unmarshaller = ListInstancesResponseUnmarshaller.Instance;

            return Invoke<ListInstancesRequest,ListInstancesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListInstances operation.
        /// <seealso cref="Amazon.ElasticMapReduce.IAmazonElasticMapReduce"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ListInstancesResponse> ListInstancesAsync(ListInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListInstancesRequestMarshaller();
            var unmarshaller = ListInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<ListInstancesRequest,ListInstancesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListSteps

        internal ListStepsResponse ListSteps()
        {
            return ListSteps(new ListStepsRequest());
        }
        internal ListStepsResponse ListSteps(ListStepsRequest request)
        {
            var marshaller = new ListStepsRequestMarshaller();
            var unmarshaller = ListStepsResponseUnmarshaller.Instance;

            return Invoke<ListStepsRequest,ListStepsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListSteps operation.
        /// <seealso cref="Amazon.ElasticMapReduce.IAmazonElasticMapReduce"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSteps operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ListStepsResponse> ListStepsAsync(ListStepsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListStepsRequestMarshaller();
            var unmarshaller = ListStepsResponseUnmarshaller.Instance;

            return InvokeAsync<ListStepsRequest,ListStepsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ModifyInstanceGroups

        internal ModifyInstanceGroupsResponse ModifyInstanceGroups(ModifyInstanceGroupsRequest request)
        {
            var marshaller = new ModifyInstanceGroupsRequestMarshaller();
            var unmarshaller = ModifyInstanceGroupsResponseUnmarshaller.Instance;

            return Invoke<ModifyInstanceGroupsRequest,ModifyInstanceGroupsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyInstanceGroups operation.
        /// <seealso cref="Amazon.ElasticMapReduce.IAmazonElasticMapReduce"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyInstanceGroups operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ModifyInstanceGroupsResponse> ModifyInstanceGroupsAsync(ModifyInstanceGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ModifyInstanceGroupsRequestMarshaller();
            var unmarshaller = ModifyInstanceGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyInstanceGroupsRequest,ModifyInstanceGroupsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RemoveTags

        internal RemoveTagsResponse RemoveTags(RemoveTagsRequest request)
        {
            var marshaller = new RemoveTagsRequestMarshaller();
            var unmarshaller = RemoveTagsResponseUnmarshaller.Instance;

            return Invoke<RemoveTagsRequest,RemoveTagsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RemoveTags operation.
        /// <seealso cref="Amazon.ElasticMapReduce.IAmazonElasticMapReduce"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveTags operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<RemoveTagsResponse> RemoveTagsAsync(RemoveTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RemoveTagsRequestMarshaller();
            var unmarshaller = RemoveTagsResponseUnmarshaller.Instance;

            return InvokeAsync<RemoveTagsRequest,RemoveTagsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RunJobFlow

        internal RunJobFlowResponse RunJobFlow(RunJobFlowRequest request)
        {
            var marshaller = new RunJobFlowRequestMarshaller();
            var unmarshaller = RunJobFlowResponseUnmarshaller.Instance;

            return Invoke<RunJobFlowRequest,RunJobFlowResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RunJobFlow operation.
        /// <seealso cref="Amazon.ElasticMapReduce.IAmazonElasticMapReduce"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RunJobFlow operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<RunJobFlowResponse> RunJobFlowAsync(RunJobFlowRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RunJobFlowRequestMarshaller();
            var unmarshaller = RunJobFlowResponseUnmarshaller.Instance;

            return InvokeAsync<RunJobFlowRequest,RunJobFlowResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  SetTerminationProtection

        internal SetTerminationProtectionResponse SetTerminationProtection(SetTerminationProtectionRequest request)
        {
            var marshaller = new SetTerminationProtectionRequestMarshaller();
            var unmarshaller = SetTerminationProtectionResponseUnmarshaller.Instance;

            return Invoke<SetTerminationProtectionRequest,SetTerminationProtectionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SetTerminationProtection operation.
        /// <seealso cref="Amazon.ElasticMapReduce.IAmazonElasticMapReduce"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetTerminationProtection operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<SetTerminationProtectionResponse> SetTerminationProtectionAsync(SetTerminationProtectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new SetTerminationProtectionRequestMarshaller();
            var unmarshaller = SetTerminationProtectionResponseUnmarshaller.Instance;

            return InvokeAsync<SetTerminationProtectionRequest,SetTerminationProtectionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  SetVisibleToAllUsers

        internal SetVisibleToAllUsersResponse SetVisibleToAllUsers(SetVisibleToAllUsersRequest request)
        {
            var marshaller = new SetVisibleToAllUsersRequestMarshaller();
            var unmarshaller = SetVisibleToAllUsersResponseUnmarshaller.Instance;

            return Invoke<SetVisibleToAllUsersRequest,SetVisibleToAllUsersResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SetVisibleToAllUsers operation.
        /// <seealso cref="Amazon.ElasticMapReduce.IAmazonElasticMapReduce"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetVisibleToAllUsers operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<SetVisibleToAllUsersResponse> SetVisibleToAllUsersAsync(SetVisibleToAllUsersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new SetVisibleToAllUsersRequestMarshaller();
            var unmarshaller = SetVisibleToAllUsersResponseUnmarshaller.Instance;

            return InvokeAsync<SetVisibleToAllUsersRequest,SetVisibleToAllUsersResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  TerminateJobFlows

        internal TerminateJobFlowsResponse TerminateJobFlows(TerminateJobFlowsRequest request)
        {
            var marshaller = new TerminateJobFlowsRequestMarshaller();
            var unmarshaller = TerminateJobFlowsResponseUnmarshaller.Instance;

            return Invoke<TerminateJobFlowsRequest,TerminateJobFlowsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the TerminateJobFlows operation.
        /// <seealso cref="Amazon.ElasticMapReduce.IAmazonElasticMapReduce"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TerminateJobFlows operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<TerminateJobFlowsResponse> TerminateJobFlowsAsync(TerminateJobFlowsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new TerminateJobFlowsRequestMarshaller();
            var unmarshaller = TerminateJobFlowsResponseUnmarshaller.Instance;

            return InvokeAsync<TerminateJobFlowsRequest,TerminateJobFlowsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
    }
}