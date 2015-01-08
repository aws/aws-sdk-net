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
    /// Amazon EC2 Container Service (Amazon ECS) is a highly scalable, fast, container management
    /// service that makes it easy to run, stop, and manage Docker containers on a cluster
    /// of Amazon EC2 instances. Amazon ECS lets you launch and stop container-enabled applications
    /// with simple API calls, allows you to get the state of your cluster from a centralized
    /// service, and gives you access to many familiar Amazon EC2 features like security groups,
    /// Amazon EBS volumes, and IAM roles.
    /// 
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

        /// <summary>
        /// Creates a new Amazon ECS cluster. By default, your account will receive a <code>default</code>
        /// cluster when you launch your first container instance. However, you can create your
        /// own cluster with a unique name with the <code>CreateCluster</code> action.
        /// 
        ///  <important> 
        /// <para>
        /// During the preview, each account is limited to two clusters.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCluster service method.</param>
        /// 
        /// <returns>The response from the CreateCluster service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by something the client did, such as use an action
        /// or resource on behalf of a user that doesn't have permission to use the action or
        /// resource, or specify an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        public CreateClusterResponse CreateCluster(CreateClusterRequest request)
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
        
        #region  DeleteCluster

        /// <summary>
        /// Deletes the specified cluster. You must deregister all container instances from this
        /// cluster before you may delete it. You can list the container instances in a cluster
        /// with <a>ListContainerInstances</a> and deregister them with <a>DeregisterContainerInstance</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCluster service method.</param>
        /// 
        /// <returns>The response from the DeleteCluster service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by something the client did, such as use an action
        /// or resource on behalf of a user that doesn't have permission to use the action or
        /// resource, or specify an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        public DeleteClusterResponse DeleteCluster(DeleteClusterRequest request)
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
        
        #region  DeregisterContainerInstance

        /// <summary>
        /// Deregisters an Amazon ECS container instance from the specified cluster. This instance
        /// will no longer be available to run tasks.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterContainerInstance service method.</param>
        /// 
        /// <returns>The response from the DeregisterContainerInstance service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by something the client did, such as use an action
        /// or resource on behalf of a user that doesn't have permission to use the action or
        /// resource, or specify an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        public DeregisterContainerInstanceResponse DeregisterContainerInstance(DeregisterContainerInstanceRequest request)
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

        /// <summary>
        /// Deregisters the specified task definition. You will no longer be able to run tasks
        /// from this definition after deregistration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterTaskDefinition service method.</param>
        /// 
        /// <returns>The response from the DeregisterTaskDefinition service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by something the client did, such as use an action
        /// or resource on behalf of a user that doesn't have permission to use the action or
        /// resource, or specify an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        public DeregisterTaskDefinitionResponse DeregisterTaskDefinition(DeregisterTaskDefinitionRequest request)
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

        /// <summary>
        /// Describes one or more of your clusters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusters service method.</param>
        /// 
        /// <returns>The response from the DescribeClusters service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by something the client did, such as use an action
        /// or resource on behalf of a user that doesn't have permission to use the action or
        /// resource, or specify an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        public DescribeClustersResponse DescribeClusters(DescribeClustersRequest request)
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

        /// <summary>
        /// Describes Amazon EC2 Container Service container instances. Returns metadata about
        /// registered and remaining resources on each container instance requested.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeContainerInstances service method.</param>
        /// 
        /// <returns>The response from the DescribeContainerInstances service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by something the client did, such as use an action
        /// or resource on behalf of a user that doesn't have permission to use the action or
        /// resource, or specify an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        public DescribeContainerInstancesResponse DescribeContainerInstances(DescribeContainerInstancesRequest request)
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
        
        #region  DescribeTaskDefinition

        /// <summary>
        /// Describes a task definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTaskDefinition service method.</param>
        /// 
        /// <returns>The response from the DescribeTaskDefinition service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by something the client did, such as use an action
        /// or resource on behalf of a user that doesn't have permission to use the action or
        /// resource, or specify an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        public DescribeTaskDefinitionResponse DescribeTaskDefinition(DescribeTaskDefinitionRequest request)
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

        /// <summary>
        /// Describes a specified task or tasks.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTasks service method.</param>
        /// 
        /// <returns>The response from the DescribeTasks service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by something the client did, such as use an action
        /// or resource on behalf of a user that doesn't have permission to use the action or
        /// resource, or specify an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        public DescribeTasksResponse DescribeTasks(DescribeTasksRequest request)
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

        /// <summary>
        /// Returns a list of existing clusters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListClusters service method.</param>
        /// 
        /// <returns>The response from the ListClusters service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by something the client did, such as use an action
        /// or resource on behalf of a user that doesn't have permission to use the action or
        /// resource, or specify an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        public ListClustersResponse ListClusters(ListClustersRequest request)
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

        /// <summary>
        /// Returns a list of container instances in a specified cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListContainerInstances service method.</param>
        /// 
        /// <returns>The response from the ListContainerInstances service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by something the client did, such as use an action
        /// or resource on behalf of a user that doesn't have permission to use the action or
        /// resource, or specify an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        public ListContainerInstancesResponse ListContainerInstances(ListContainerInstancesRequest request)
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
        
        #region  ListTaskDefinitions

        /// <summary>
        /// Returns a list of task definitions that are registered to your account. You can filter
        /// the results by family name with the <code>familyPrefix</code> parameter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTaskDefinitions service method.</param>
        /// 
        /// <returns>The response from the ListTaskDefinitions service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by something the client did, such as use an action
        /// or resource on behalf of a user that doesn't have permission to use the action or
        /// resource, or specify an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        public ListTaskDefinitionsResponse ListTaskDefinitions(ListTaskDefinitionsRequest request)
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

        /// <summary>
        /// Returns a list of tasks for a specified cluster. You can filter the results by family
        /// name or by a particular container instance with the <code>family</code> and <code>containerInstance</code>
        /// parameters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTasks service method.</param>
        /// 
        /// <returns>The response from the ListTasks service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by something the client did, such as use an action
        /// or resource on behalf of a user that doesn't have permission to use the action or
        /// resource, or specify an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        public ListTasksResponse ListTasks(ListTasksRequest request)
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

        /// <summary>
        /// Registers a new task definition from the supplied <code>family</code> and <code>containerDefinitions</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterTaskDefinition service method.</param>
        /// 
        /// <returns>The response from the RegisterTaskDefinition service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by something the client did, such as use an action
        /// or resource on behalf of a user that doesn't have permission to use the action or
        /// resource, or specify an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        public RegisterTaskDefinitionResponse RegisterTaskDefinition(RegisterTaskDefinitionRequest request)
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

        /// <summary>
        /// Start a task using random placement and the default Amazon ECS scheduler. If you want
        /// to use your own scheduler or place a task on a specific container instance, use <code>StartTask</code>
        /// instead.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RunTask service method.</param>
        /// 
        /// <returns>The response from the RunTask service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by something the client did, such as use an action
        /// or resource on behalf of a user that doesn't have permission to use the action or
        /// resource, or specify an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        public RunTaskResponse RunTask(RunTaskRequest request)
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

        /// <summary>
        /// Starts a new task from the specified task definition on the specified container instance
        /// or instances. If you want to use the default Amazon ECS scheduler to place your task,
        /// use <code>RunTask</code> instead.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartTask service method.</param>
        /// 
        /// <returns>The response from the StartTask service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by something the client did, such as use an action
        /// or resource on behalf of a user that doesn't have permission to use the action or
        /// resource, or specify an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        public StartTaskResponse StartTask(StartTaskRequest request)
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

        /// <summary>
        /// Stops a running task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopTask service method.</param>
        /// 
        /// <returns>The response from the StopTask service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by something the client did, such as use an action
        /// or resource on behalf of a user that doesn't have permission to use the action or
        /// resource, or specify an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        public StopTaskResponse StopTask(StopTaskRequest request)
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
        
    }
}