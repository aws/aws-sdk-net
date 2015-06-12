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
 * Do not modify this file. This file is generated from the ecs-2014-11-13.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.ECS.Model;
using Amazon.ECS.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.ECS
{
    /// <summary>
    /// Implementation for accessing ECS
    ///
    /// <para>
    /// Amazon EC2 Container Service (Amazon ECS) is a highly scalable, fast, container management
    /// service that makes it easy to run, stop, and manage Docker containers on a cluster
    /// of Amazon EC2 instances. Amazon ECS lets you launch and stop container-enabled applications
    /// with simple API calls, allows you to get the state of your cluster from a centralized
    /// service, and gives you access to many familiar Amazon EC2 features like security groups,
    /// Amazon EBS volumes, and IAM roles.
    /// </para>
    ///  
    /// <para>
    /// You can use Amazon ECS to schedule the placement of containers across your cluster
    /// based on your resource needs, isolation policies, and availability requirements. Amazon
    /// EC2 Container Service eliminates the need for you to operate your own cluster management
    /// and configuration management systems or worry about scaling your management infrastructure.
    /// </para>
    /// </summary>
    public partial class AmazonECSClient : AmazonServiceClient, IAmazonECS
    {
        
        #region Constructors

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

        
        #region  CreateCluster

        internal CreateClusterResponse CreateCluster(CreateClusterRequest request)
        {
            var marshaller = new CreateClusterRequestMarshaller();
            var unmarshaller = CreateClusterResponseUnmarshaller.Instance;

            return Invoke<CreateClusterRequest,CreateClusterResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCluster operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateClusterResponse> CreateClusterAsync(CreateClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateClusterRequestMarshaller();
            var unmarshaller = CreateClusterResponseUnmarshaller.Instance;

            return InvokeAsync<CreateClusterRequest,CreateClusterResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateService

        internal CreateServiceResponse CreateService(CreateServiceRequest request)
        {
            var marshaller = new CreateServiceRequestMarshaller();
            var unmarshaller = CreateServiceResponseUnmarshaller.Instance;

            return Invoke<CreateServiceRequest,CreateServiceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateService operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateService operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateServiceResponse> CreateServiceAsync(CreateServiceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateServiceRequestMarshaller();
            var unmarshaller = CreateServiceResponseUnmarshaller.Instance;

            return InvokeAsync<CreateServiceRequest,CreateServiceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteCluster

        internal DeleteClusterResponse DeleteCluster(DeleteClusterRequest request)
        {
            var marshaller = new DeleteClusterRequestMarshaller();
            var unmarshaller = DeleteClusterResponseUnmarshaller.Instance;

            return Invoke<DeleteClusterRequest,DeleteClusterResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCluster operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteClusterResponse> DeleteClusterAsync(DeleteClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteClusterRequestMarshaller();
            var unmarshaller = DeleteClusterResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteClusterRequest,DeleteClusterResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteService

        internal DeleteServiceResponse DeleteService(DeleteServiceRequest request)
        {
            var marshaller = new DeleteServiceRequestMarshaller();
            var unmarshaller = DeleteServiceResponseUnmarshaller.Instance;

            return Invoke<DeleteServiceRequest,DeleteServiceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteService operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteService operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteServiceResponse> DeleteServiceAsync(DeleteServiceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteServiceRequestMarshaller();
            var unmarshaller = DeleteServiceResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteServiceRequest,DeleteServiceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeregisterContainerInstance

        internal DeregisterContainerInstanceResponse DeregisterContainerInstance(DeregisterContainerInstanceRequest request)
        {
            var marshaller = new DeregisterContainerInstanceRequestMarshaller();
            var unmarshaller = DeregisterContainerInstanceResponseUnmarshaller.Instance;

            return Invoke<DeregisterContainerInstanceRequest,DeregisterContainerInstanceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeregisterContainerInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeregisterContainerInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeregisterContainerInstanceResponse> DeregisterContainerInstanceAsync(DeregisterContainerInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeregisterContainerInstanceRequestMarshaller();
            var unmarshaller = DeregisterContainerInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<DeregisterContainerInstanceRequest,DeregisterContainerInstanceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeregisterTaskDefinition

        internal DeregisterTaskDefinitionResponse DeregisterTaskDefinition(DeregisterTaskDefinitionRequest request)
        {
            var marshaller = new DeregisterTaskDefinitionRequestMarshaller();
            var unmarshaller = DeregisterTaskDefinitionResponseUnmarshaller.Instance;

            return Invoke<DeregisterTaskDefinitionRequest,DeregisterTaskDefinitionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeregisterTaskDefinition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeregisterTaskDefinition operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeregisterTaskDefinitionResponse> DeregisterTaskDefinitionAsync(DeregisterTaskDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeregisterTaskDefinitionRequestMarshaller();
            var unmarshaller = DeregisterTaskDefinitionResponseUnmarshaller.Instance;

            return InvokeAsync<DeregisterTaskDefinitionRequest,DeregisterTaskDefinitionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeClusters

        internal DescribeClustersResponse DescribeClusters(DescribeClustersRequest request)
        {
            var marshaller = new DescribeClustersRequestMarshaller();
            var unmarshaller = DescribeClustersResponseUnmarshaller.Instance;

            return Invoke<DescribeClustersRequest,DescribeClustersResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeClusters operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusters operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeClustersResponse> DescribeClustersAsync(DescribeClustersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeClustersRequestMarshaller();
            var unmarshaller = DescribeClustersResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeClustersRequest,DescribeClustersResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeContainerInstances

        internal DescribeContainerInstancesResponse DescribeContainerInstances(DescribeContainerInstancesRequest request)
        {
            var marshaller = new DescribeContainerInstancesRequestMarshaller();
            var unmarshaller = DescribeContainerInstancesResponseUnmarshaller.Instance;

            return Invoke<DescribeContainerInstancesRequest,DescribeContainerInstancesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeContainerInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeContainerInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeContainerInstancesResponse> DescribeContainerInstancesAsync(DescribeContainerInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeContainerInstancesRequestMarshaller();
            var unmarshaller = DescribeContainerInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeContainerInstancesRequest,DescribeContainerInstancesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeServices

        internal DescribeServicesResponse DescribeServices(DescribeServicesRequest request)
        {
            var marshaller = new DescribeServicesRequestMarshaller();
            var unmarshaller = DescribeServicesResponseUnmarshaller.Instance;

            return Invoke<DescribeServicesRequest,DescribeServicesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeServices operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeServices operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeServicesResponse> DescribeServicesAsync(DescribeServicesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeServicesRequestMarshaller();
            var unmarshaller = DescribeServicesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeServicesRequest,DescribeServicesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeTaskDefinition

        internal DescribeTaskDefinitionResponse DescribeTaskDefinition(DescribeTaskDefinitionRequest request)
        {
            var marshaller = new DescribeTaskDefinitionRequestMarshaller();
            var unmarshaller = DescribeTaskDefinitionResponseUnmarshaller.Instance;

            return Invoke<DescribeTaskDefinitionRequest,DescribeTaskDefinitionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTaskDefinition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTaskDefinition operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeTaskDefinitionResponse> DescribeTaskDefinitionAsync(DescribeTaskDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeTaskDefinitionRequestMarshaller();
            var unmarshaller = DescribeTaskDefinitionResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeTaskDefinitionRequest,DescribeTaskDefinitionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeTasks

        internal DescribeTasksResponse DescribeTasks(DescribeTasksRequest request)
        {
            var marshaller = new DescribeTasksRequestMarshaller();
            var unmarshaller = DescribeTasksResponseUnmarshaller.Instance;

            return Invoke<DescribeTasksRequest,DescribeTasksResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTasks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTasks operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeTasksResponse> DescribeTasksAsync(DescribeTasksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeTasksRequestMarshaller();
            var unmarshaller = DescribeTasksResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeTasksRequest,DescribeTasksResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListClusters

        internal ListClustersResponse ListClusters(ListClustersRequest request)
        {
            var marshaller = new ListClustersRequestMarshaller();
            var unmarshaller = ListClustersResponseUnmarshaller.Instance;

            return Invoke<ListClustersRequest,ListClustersResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListClusters operation.
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
        
        #region  ListContainerInstances

        internal ListContainerInstancesResponse ListContainerInstances(ListContainerInstancesRequest request)
        {
            var marshaller = new ListContainerInstancesRequestMarshaller();
            var unmarshaller = ListContainerInstancesResponseUnmarshaller.Instance;

            return Invoke<ListContainerInstancesRequest,ListContainerInstancesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListContainerInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListContainerInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ListContainerInstancesResponse> ListContainerInstancesAsync(ListContainerInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListContainerInstancesRequestMarshaller();
            var unmarshaller = ListContainerInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<ListContainerInstancesRequest,ListContainerInstancesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListServices

        internal ListServicesResponse ListServices(ListServicesRequest request)
        {
            var marshaller = new ListServicesRequestMarshaller();
            var unmarshaller = ListServicesResponseUnmarshaller.Instance;

            return Invoke<ListServicesRequest,ListServicesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListServices operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListServices operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ListServicesResponse> ListServicesAsync(ListServicesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListServicesRequestMarshaller();
            var unmarshaller = ListServicesResponseUnmarshaller.Instance;

            return InvokeAsync<ListServicesRequest,ListServicesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListTaskDefinitionFamilies

        internal ListTaskDefinitionFamiliesResponse ListTaskDefinitionFamilies(ListTaskDefinitionFamiliesRequest request)
        {
            var marshaller = new ListTaskDefinitionFamiliesRequestMarshaller();
            var unmarshaller = ListTaskDefinitionFamiliesResponseUnmarshaller.Instance;

            return Invoke<ListTaskDefinitionFamiliesRequest,ListTaskDefinitionFamiliesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTaskDefinitionFamilies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTaskDefinitionFamilies operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ListTaskDefinitionFamiliesResponse> ListTaskDefinitionFamiliesAsync(ListTaskDefinitionFamiliesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListTaskDefinitionFamiliesRequestMarshaller();
            var unmarshaller = ListTaskDefinitionFamiliesResponseUnmarshaller.Instance;

            return InvokeAsync<ListTaskDefinitionFamiliesRequest,ListTaskDefinitionFamiliesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListTaskDefinitions

        internal ListTaskDefinitionsResponse ListTaskDefinitions(ListTaskDefinitionsRequest request)
        {
            var marshaller = new ListTaskDefinitionsRequestMarshaller();
            var unmarshaller = ListTaskDefinitionsResponseUnmarshaller.Instance;

            return Invoke<ListTaskDefinitionsRequest,ListTaskDefinitionsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTaskDefinitions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTaskDefinitions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ListTaskDefinitionsResponse> ListTaskDefinitionsAsync(ListTaskDefinitionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListTaskDefinitionsRequestMarshaller();
            var unmarshaller = ListTaskDefinitionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListTaskDefinitionsRequest,ListTaskDefinitionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListTasks

        internal ListTasksResponse ListTasks(ListTasksRequest request)
        {
            var marshaller = new ListTasksRequestMarshaller();
            var unmarshaller = ListTasksResponseUnmarshaller.Instance;

            return Invoke<ListTasksRequest,ListTasksResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTasks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTasks operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ListTasksResponse> ListTasksAsync(ListTasksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListTasksRequestMarshaller();
            var unmarshaller = ListTasksResponseUnmarshaller.Instance;

            return InvokeAsync<ListTasksRequest,ListTasksResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RegisterTaskDefinition

        internal RegisterTaskDefinitionResponse RegisterTaskDefinition(RegisterTaskDefinitionRequest request)
        {
            var marshaller = new RegisterTaskDefinitionRequestMarshaller();
            var unmarshaller = RegisterTaskDefinitionResponseUnmarshaller.Instance;

            return Invoke<RegisterTaskDefinitionRequest,RegisterTaskDefinitionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RegisterTaskDefinition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterTaskDefinition operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<RegisterTaskDefinitionResponse> RegisterTaskDefinitionAsync(RegisterTaskDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RegisterTaskDefinitionRequestMarshaller();
            var unmarshaller = RegisterTaskDefinitionResponseUnmarshaller.Instance;

            return InvokeAsync<RegisterTaskDefinitionRequest,RegisterTaskDefinitionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RunTask

        internal RunTaskResponse RunTask(RunTaskRequest request)
        {
            var marshaller = new RunTaskRequestMarshaller();
            var unmarshaller = RunTaskResponseUnmarshaller.Instance;

            return Invoke<RunTaskRequest,RunTaskResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RunTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RunTask operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<RunTaskResponse> RunTaskAsync(RunTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RunTaskRequestMarshaller();
            var unmarshaller = RunTaskResponseUnmarshaller.Instance;

            return InvokeAsync<RunTaskRequest,RunTaskResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  StartTask

        internal StartTaskResponse StartTask(StartTaskRequest request)
        {
            var marshaller = new StartTaskRequestMarshaller();
            var unmarshaller = StartTaskResponseUnmarshaller.Instance;

            return Invoke<StartTaskRequest,StartTaskResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartTask operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<StartTaskResponse> StartTaskAsync(StartTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new StartTaskRequestMarshaller();
            var unmarshaller = StartTaskResponseUnmarshaller.Instance;

            return InvokeAsync<StartTaskRequest,StartTaskResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  StopTask

        internal StopTaskResponse StopTask(StopTaskRequest request)
        {
            var marshaller = new StopTaskRequestMarshaller();
            var unmarshaller = StopTaskResponseUnmarshaller.Instance;

            return Invoke<StopTaskRequest,StopTaskResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StopTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopTask operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<StopTaskResponse> StopTaskAsync(StopTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new StopTaskRequestMarshaller();
            var unmarshaller = StopTaskResponseUnmarshaller.Instance;

            return InvokeAsync<StopTaskRequest,StopTaskResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateContainerAgent

        internal UpdateContainerAgentResponse UpdateContainerAgent(UpdateContainerAgentRequest request)
        {
            var marshaller = new UpdateContainerAgentRequestMarshaller();
            var unmarshaller = UpdateContainerAgentResponseUnmarshaller.Instance;

            return Invoke<UpdateContainerAgentRequest,UpdateContainerAgentResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateContainerAgent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateContainerAgent operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<UpdateContainerAgentResponse> UpdateContainerAgentAsync(UpdateContainerAgentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateContainerAgentRequestMarshaller();
            var unmarshaller = UpdateContainerAgentResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateContainerAgentRequest,UpdateContainerAgentResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateService

        internal UpdateServiceResponse UpdateService(UpdateServiceRequest request)
        {
            var marshaller = new UpdateServiceRequestMarshaller();
            var unmarshaller = UpdateServiceResponseUnmarshaller.Instance;

            return Invoke<UpdateServiceRequest,UpdateServiceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateService operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateService operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<UpdateServiceResponse> UpdateServiceAsync(UpdateServiceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateServiceRequestMarshaller();
            var unmarshaller = UpdateServiceResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateServiceRequest,UpdateServiceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
    }
}