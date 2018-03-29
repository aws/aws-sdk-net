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
    /// Amazon Elastic Container Service (Amazon ECS) is a highly scalable, fast, container
    /// management service that makes it easy to run, stop, and manage Docker containers on
    /// a cluster. You can host your cluster on a serverless infrastructure that is managed
    /// by Amazon ECS by launching your services or tasks using the Fargate launch type. For
    /// more control, you can host your tasks on a cluster of Amazon Elastic Compute Cloud
    /// (Amazon EC2) instances that you manage by using the EC2 launch type. For more information
    /// about launch types, see <a href="http://docs.aws.amazon.com/AmazonECS/latest/developerguide/launch_types.html">Amazon
    /// ECS Launch Types</a>.
    /// 
    ///  
    /// <para>
    /// Amazon ECS lets you launch and stop container-based applications with simple API calls,
    /// allows you to get the state of your cluster from a centralized service, and gives
    /// you access to many familiar Amazon EC2 features.
    /// </para>
    ///  
    /// <para>
    /// You can use Amazon ECS to schedule the placement of containers across your cluster
    /// based on your resource needs, isolation policies, and availability requirements. Amazon
    /// ECS eliminates the need for you to operate your own cluster management and configuration
    /// management systems or worry about scaling your management infrastructure.
    /// </para>
    /// </summary>
    public partial class AmazonECSClient : AmazonServiceClient, IAmazonECS
    {
        
        #region Constructors

#if CORECLR
    
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

#endif

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

        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
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
            var marshaller = CreateClusterRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/CreateCluster">REST API Reference for CreateCluster Operation</seealso>
        public virtual Task<CreateClusterResponse> CreateClusterAsync(CreateClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateClusterRequestMarshaller.Instance;
            var unmarshaller = CreateClusterResponseUnmarshaller.Instance;

            return InvokeAsync<CreateClusterRequest,CreateClusterResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateService

        internal virtual CreateServiceResponse CreateService(CreateServiceRequest request)
        {
            var marshaller = CreateServiceRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/CreateService">REST API Reference for CreateService Operation</seealso>
        public virtual Task<CreateServiceResponse> CreateServiceAsync(CreateServiceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateServiceRequestMarshaller.Instance;
            var unmarshaller = CreateServiceResponseUnmarshaller.Instance;

            return InvokeAsync<CreateServiceRequest,CreateServiceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteAttributes

        internal virtual DeleteAttributesResponse DeleteAttributes(DeleteAttributesRequest request)
        {
            var marshaller = DeleteAttributesRequestMarshaller.Instance;
            var unmarshaller = DeleteAttributesResponseUnmarshaller.Instance;

            return Invoke<DeleteAttributesRequest,DeleteAttributesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAttributes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/DeleteAttributes">REST API Reference for DeleteAttributes Operation</seealso>
        public virtual Task<DeleteAttributesResponse> DeleteAttributesAsync(DeleteAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteAttributesRequestMarshaller.Instance;
            var unmarshaller = DeleteAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAttributesRequest,DeleteAttributesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteCluster

        internal virtual DeleteClusterResponse DeleteCluster(DeleteClusterRequest request)
        {
            var marshaller = DeleteClusterRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/DeleteCluster">REST API Reference for DeleteCluster Operation</seealso>
        public virtual Task<DeleteClusterResponse> DeleteClusterAsync(DeleteClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteClusterRequestMarshaller.Instance;
            var unmarshaller = DeleteClusterResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteClusterRequest,DeleteClusterResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteService

        internal virtual DeleteServiceResponse DeleteService(DeleteServiceRequest request)
        {
            var marshaller = DeleteServiceRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/DeleteService">REST API Reference for DeleteService Operation</seealso>
        public virtual Task<DeleteServiceResponse> DeleteServiceAsync(DeleteServiceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteServiceRequestMarshaller.Instance;
            var unmarshaller = DeleteServiceResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteServiceRequest,DeleteServiceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeregisterContainerInstance

        internal virtual DeregisterContainerInstanceResponse DeregisterContainerInstance(DeregisterContainerInstanceRequest request)
        {
            var marshaller = DeregisterContainerInstanceRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/DeregisterContainerInstance">REST API Reference for DeregisterContainerInstance Operation</seealso>
        public virtual Task<DeregisterContainerInstanceResponse> DeregisterContainerInstanceAsync(DeregisterContainerInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeregisterContainerInstanceRequestMarshaller.Instance;
            var unmarshaller = DeregisterContainerInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<DeregisterContainerInstanceRequest,DeregisterContainerInstanceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeregisterTaskDefinition

        internal virtual DeregisterTaskDefinitionResponse DeregisterTaskDefinition(DeregisterTaskDefinitionRequest request)
        {
            var marshaller = DeregisterTaskDefinitionRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/DeregisterTaskDefinition">REST API Reference for DeregisterTaskDefinition Operation</seealso>
        public virtual Task<DeregisterTaskDefinitionResponse> DeregisterTaskDefinitionAsync(DeregisterTaskDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeregisterTaskDefinitionRequestMarshaller.Instance;
            var unmarshaller = DeregisterTaskDefinitionResponseUnmarshaller.Instance;

            return InvokeAsync<DeregisterTaskDefinitionRequest,DeregisterTaskDefinitionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeClusters

        internal virtual DescribeClustersResponse DescribeClusters(DescribeClustersRequest request)
        {
            var marshaller = DescribeClustersRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/DescribeClusters">REST API Reference for DescribeClusters Operation</seealso>
        public virtual Task<DescribeClustersResponse> DescribeClustersAsync(DescribeClustersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeClustersRequestMarshaller.Instance;
            var unmarshaller = DescribeClustersResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeClustersRequest,DescribeClustersResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeContainerInstances

        internal virtual DescribeContainerInstancesResponse DescribeContainerInstances(DescribeContainerInstancesRequest request)
        {
            var marshaller = DescribeContainerInstancesRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/DescribeContainerInstances">REST API Reference for DescribeContainerInstances Operation</seealso>
        public virtual Task<DescribeContainerInstancesResponse> DescribeContainerInstancesAsync(DescribeContainerInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeContainerInstancesRequestMarshaller.Instance;
            var unmarshaller = DescribeContainerInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeContainerInstancesRequest,DescribeContainerInstancesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeServices

        internal virtual DescribeServicesResponse DescribeServices(DescribeServicesRequest request)
        {
            var marshaller = DescribeServicesRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/DescribeServices">REST API Reference for DescribeServices Operation</seealso>
        public virtual Task<DescribeServicesResponse> DescribeServicesAsync(DescribeServicesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeServicesRequestMarshaller.Instance;
            var unmarshaller = DescribeServicesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeServicesRequest,DescribeServicesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeTaskDefinition

        internal virtual DescribeTaskDefinitionResponse DescribeTaskDefinition(DescribeTaskDefinitionRequest request)
        {
            var marshaller = DescribeTaskDefinitionRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/DescribeTaskDefinition">REST API Reference for DescribeTaskDefinition Operation</seealso>
        public virtual Task<DescribeTaskDefinitionResponse> DescribeTaskDefinitionAsync(DescribeTaskDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeTaskDefinitionRequestMarshaller.Instance;
            var unmarshaller = DescribeTaskDefinitionResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeTaskDefinitionRequest,DescribeTaskDefinitionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeTasks

        internal virtual DescribeTasksResponse DescribeTasks(DescribeTasksRequest request)
        {
            var marshaller = DescribeTasksRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/DescribeTasks">REST API Reference for DescribeTasks Operation</seealso>
        public virtual Task<DescribeTasksResponse> DescribeTasksAsync(DescribeTasksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeTasksRequestMarshaller.Instance;
            var unmarshaller = DescribeTasksResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeTasksRequest,DescribeTasksResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListAttributes

        internal virtual ListAttributesResponse ListAttributes(ListAttributesRequest request)
        {
            var marshaller = ListAttributesRequestMarshaller.Instance;
            var unmarshaller = ListAttributesResponseUnmarshaller.Instance;

            return Invoke<ListAttributesRequest,ListAttributesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAttributes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/ListAttributes">REST API Reference for ListAttributes Operation</seealso>
        public virtual Task<ListAttributesResponse> ListAttributesAsync(ListAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListAttributesRequestMarshaller.Instance;
            var unmarshaller = ListAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<ListAttributesRequest,ListAttributesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListClusters

        internal virtual ListClustersResponse ListClusters(ListClustersRequest request)
        {
            var marshaller = ListClustersRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/ListClusters">REST API Reference for ListClusters Operation</seealso>
        public virtual Task<ListClustersResponse> ListClustersAsync(ListClustersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListClustersRequestMarshaller.Instance;
            var unmarshaller = ListClustersResponseUnmarshaller.Instance;

            return InvokeAsync<ListClustersRequest,ListClustersResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListContainerInstances

        internal virtual ListContainerInstancesResponse ListContainerInstances(ListContainerInstancesRequest request)
        {
            var marshaller = ListContainerInstancesRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/ListContainerInstances">REST API Reference for ListContainerInstances Operation</seealso>
        public virtual Task<ListContainerInstancesResponse> ListContainerInstancesAsync(ListContainerInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListContainerInstancesRequestMarshaller.Instance;
            var unmarshaller = ListContainerInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<ListContainerInstancesRequest,ListContainerInstancesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListServices

        internal virtual ListServicesResponse ListServices(ListServicesRequest request)
        {
            var marshaller = ListServicesRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/ListServices">REST API Reference for ListServices Operation</seealso>
        public virtual Task<ListServicesResponse> ListServicesAsync(ListServicesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListServicesRequestMarshaller.Instance;
            var unmarshaller = ListServicesResponseUnmarshaller.Instance;

            return InvokeAsync<ListServicesRequest,ListServicesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListTaskDefinitionFamilies

        internal virtual ListTaskDefinitionFamiliesResponse ListTaskDefinitionFamilies(ListTaskDefinitionFamiliesRequest request)
        {
            var marshaller = ListTaskDefinitionFamiliesRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/ListTaskDefinitionFamilies">REST API Reference for ListTaskDefinitionFamilies Operation</seealso>
        public virtual Task<ListTaskDefinitionFamiliesResponse> ListTaskDefinitionFamiliesAsync(ListTaskDefinitionFamiliesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListTaskDefinitionFamiliesRequestMarshaller.Instance;
            var unmarshaller = ListTaskDefinitionFamiliesResponseUnmarshaller.Instance;

            return InvokeAsync<ListTaskDefinitionFamiliesRequest,ListTaskDefinitionFamiliesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListTaskDefinitions

        internal virtual ListTaskDefinitionsResponse ListTaskDefinitions(ListTaskDefinitionsRequest request)
        {
            var marshaller = ListTaskDefinitionsRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/ListTaskDefinitions">REST API Reference for ListTaskDefinitions Operation</seealso>
        public virtual Task<ListTaskDefinitionsResponse> ListTaskDefinitionsAsync(ListTaskDefinitionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListTaskDefinitionsRequestMarshaller.Instance;
            var unmarshaller = ListTaskDefinitionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListTaskDefinitionsRequest,ListTaskDefinitionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListTasks

        internal virtual ListTasksResponse ListTasks(ListTasksRequest request)
        {
            var marshaller = ListTasksRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/ListTasks">REST API Reference for ListTasks Operation</seealso>
        public virtual Task<ListTasksResponse> ListTasksAsync(ListTasksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListTasksRequestMarshaller.Instance;
            var unmarshaller = ListTasksResponseUnmarshaller.Instance;

            return InvokeAsync<ListTasksRequest,ListTasksResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PutAttributes

        internal virtual PutAttributesResponse PutAttributes(PutAttributesRequest request)
        {
            var marshaller = PutAttributesRequestMarshaller.Instance;
            var unmarshaller = PutAttributesResponseUnmarshaller.Instance;

            return Invoke<PutAttributesRequest,PutAttributesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PutAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutAttributes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/PutAttributes">REST API Reference for PutAttributes Operation</seealso>
        public virtual Task<PutAttributesResponse> PutAttributesAsync(PutAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = PutAttributesRequestMarshaller.Instance;
            var unmarshaller = PutAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<PutAttributesRequest,PutAttributesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RegisterTaskDefinition

        internal virtual RegisterTaskDefinitionResponse RegisterTaskDefinition(RegisterTaskDefinitionRequest request)
        {
            var marshaller = RegisterTaskDefinitionRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/RegisterTaskDefinition">REST API Reference for RegisterTaskDefinition Operation</seealso>
        public virtual Task<RegisterTaskDefinitionResponse> RegisterTaskDefinitionAsync(RegisterTaskDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = RegisterTaskDefinitionRequestMarshaller.Instance;
            var unmarshaller = RegisterTaskDefinitionResponseUnmarshaller.Instance;

            return InvokeAsync<RegisterTaskDefinitionRequest,RegisterTaskDefinitionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RunTask

        internal virtual RunTaskResponse RunTask(RunTaskRequest request)
        {
            var marshaller = RunTaskRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/RunTask">REST API Reference for RunTask Operation</seealso>
        public virtual Task<RunTaskResponse> RunTaskAsync(RunTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = RunTaskRequestMarshaller.Instance;
            var unmarshaller = RunTaskResponseUnmarshaller.Instance;

            return InvokeAsync<RunTaskRequest,RunTaskResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  StartTask

        internal virtual StartTaskResponse StartTask(StartTaskRequest request)
        {
            var marshaller = StartTaskRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/StartTask">REST API Reference for StartTask Operation</seealso>
        public virtual Task<StartTaskResponse> StartTaskAsync(StartTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = StartTaskRequestMarshaller.Instance;
            var unmarshaller = StartTaskResponseUnmarshaller.Instance;

            return InvokeAsync<StartTaskRequest,StartTaskResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  StopTask

        internal virtual StopTaskResponse StopTask(StopTaskRequest request)
        {
            var marshaller = StopTaskRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/StopTask">REST API Reference for StopTask Operation</seealso>
        public virtual Task<StopTaskResponse> StopTaskAsync(StopTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = StopTaskRequestMarshaller.Instance;
            var unmarshaller = StopTaskResponseUnmarshaller.Instance;

            return InvokeAsync<StopTaskRequest,StopTaskResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateContainerAgent

        internal virtual UpdateContainerAgentResponse UpdateContainerAgent(UpdateContainerAgentRequest request)
        {
            var marshaller = UpdateContainerAgentRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/UpdateContainerAgent">REST API Reference for UpdateContainerAgent Operation</seealso>
        public virtual Task<UpdateContainerAgentResponse> UpdateContainerAgentAsync(UpdateContainerAgentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateContainerAgentRequestMarshaller.Instance;
            var unmarshaller = UpdateContainerAgentResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateContainerAgentRequest,UpdateContainerAgentResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateContainerInstancesState

        internal virtual UpdateContainerInstancesStateResponse UpdateContainerInstancesState(UpdateContainerInstancesStateRequest request)
        {
            var marshaller = UpdateContainerInstancesStateRequestMarshaller.Instance;
            var unmarshaller = UpdateContainerInstancesStateResponseUnmarshaller.Instance;

            return Invoke<UpdateContainerInstancesStateRequest,UpdateContainerInstancesStateResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateContainerInstancesState operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateContainerInstancesState operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/UpdateContainerInstancesState">REST API Reference for UpdateContainerInstancesState Operation</seealso>
        public virtual Task<UpdateContainerInstancesStateResponse> UpdateContainerInstancesStateAsync(UpdateContainerInstancesStateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateContainerInstancesStateRequestMarshaller.Instance;
            var unmarshaller = UpdateContainerInstancesStateResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateContainerInstancesStateRequest,UpdateContainerInstancesStateResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateService

        internal virtual UpdateServiceResponse UpdateService(UpdateServiceRequest request)
        {
            var marshaller = UpdateServiceRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/UpdateService">REST API Reference for UpdateService Operation</seealso>
        public virtual Task<UpdateServiceResponse> UpdateServiceAsync(UpdateServiceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateServiceRequestMarshaller.Instance;
            var unmarshaller = UpdateServiceResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateServiceRequest,UpdateServiceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
    }
}