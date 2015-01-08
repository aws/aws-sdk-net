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
        /// <param name="request">Container for the necessary parameters to execute the CreateCluster operation on AmazonECSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateCluster
        ///         operation.</returns>
        public IAsyncResult BeginCreateCluster(CreateClusterRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CreateClusterRequestMarshaller();
            var unmarshaller = CreateClusterResponseUnmarshaller.Instance;

            return BeginInvoke<CreateClusterRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateCluster operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCluster.</param>
        /// 
        /// <returns>Returns a  CreateClusterResult from ECS.</returns>
        public  CreateClusterResponse EndCreateCluster(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateClusterResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the DeleteCluster operation on AmazonECSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteCluster
        ///         operation.</returns>
        public IAsyncResult BeginDeleteCluster(DeleteClusterRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteClusterRequestMarshaller();
            var unmarshaller = DeleteClusterResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteClusterRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteCluster operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCluster.</param>
        /// 
        /// <returns>Returns a  DeleteClusterResult from ECS.</returns>
        public  DeleteClusterResponse EndDeleteCluster(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteClusterResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the DeregisterContainerInstance operation on AmazonECSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeregisterContainerInstance
        ///         operation.</returns>
        public IAsyncResult BeginDeregisterContainerInstance(DeregisterContainerInstanceRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeregisterContainerInstanceRequestMarshaller();
            var unmarshaller = DeregisterContainerInstanceResponseUnmarshaller.Instance;

            return BeginInvoke<DeregisterContainerInstanceRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeregisterContainerInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeregisterContainerInstance.</param>
        /// 
        /// <returns>Returns a  DeregisterContainerInstanceResult from ECS.</returns>
        public  DeregisterContainerInstanceResponse EndDeregisterContainerInstance(IAsyncResult asyncResult)
        {
            return EndInvoke<DeregisterContainerInstanceResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the DeregisterTaskDefinition operation on AmazonECSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeregisterTaskDefinition
        ///         operation.</returns>
        public IAsyncResult BeginDeregisterTaskDefinition(DeregisterTaskDefinitionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeregisterTaskDefinitionRequestMarshaller();
            var unmarshaller = DeregisterTaskDefinitionResponseUnmarshaller.Instance;

            return BeginInvoke<DeregisterTaskDefinitionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeregisterTaskDefinition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeregisterTaskDefinition.</param>
        /// 
        /// <returns>Returns a  DeregisterTaskDefinitionResult from ECS.</returns>
        public  DeregisterTaskDefinitionResponse EndDeregisterTaskDefinition(IAsyncResult asyncResult)
        {
            return EndInvoke<DeregisterTaskDefinitionResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusters operation on AmazonECSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeClusters
        ///         operation.</returns>
        public IAsyncResult BeginDescribeClusters(DescribeClustersRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeClustersRequestMarshaller();
            var unmarshaller = DescribeClustersResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeClustersRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeClusters operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeClusters.</param>
        /// 
        /// <returns>Returns a  DescribeClustersResult from ECS.</returns>
        public  DescribeClustersResponse EndDescribeClusters(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeClustersResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeContainerInstances operation on AmazonECSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeContainerInstances
        ///         operation.</returns>
        public IAsyncResult BeginDescribeContainerInstances(DescribeContainerInstancesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeContainerInstancesRequestMarshaller();
            var unmarshaller = DescribeContainerInstancesResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeContainerInstancesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeContainerInstances operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeContainerInstances.</param>
        /// 
        /// <returns>Returns a  DescribeContainerInstancesResult from ECS.</returns>
        public  DescribeContainerInstancesResponse EndDescribeContainerInstances(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeContainerInstancesResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeTaskDefinition operation on AmazonECSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeTaskDefinition
        ///         operation.</returns>
        public IAsyncResult BeginDescribeTaskDefinition(DescribeTaskDefinitionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeTaskDefinitionRequestMarshaller();
            var unmarshaller = DescribeTaskDefinitionResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeTaskDefinitionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeTaskDefinition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeTaskDefinition.</param>
        /// 
        /// <returns>Returns a  DescribeTaskDefinitionResult from ECS.</returns>
        public  DescribeTaskDefinitionResponse EndDescribeTaskDefinition(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeTaskDefinitionResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeTasks operation on AmazonECSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeTasks
        ///         operation.</returns>
        public IAsyncResult BeginDescribeTasks(DescribeTasksRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeTasksRequestMarshaller();
            var unmarshaller = DescribeTasksResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeTasksRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeTasks operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeTasks.</param>
        /// 
        /// <returns>Returns a  DescribeTasksResult from ECS.</returns>
        public  DescribeTasksResponse EndDescribeTasks(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeTasksResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the ListClusters operation on AmazonECSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListClusters
        ///         operation.</returns>
        public IAsyncResult BeginListClusters(ListClustersRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListClustersRequestMarshaller();
            var unmarshaller = ListClustersResponseUnmarshaller.Instance;

            return BeginInvoke<ListClustersRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListClusters operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListClusters.</param>
        /// 
        /// <returns>Returns a  ListClustersResult from ECS.</returns>
        public  ListClustersResponse EndListClusters(IAsyncResult asyncResult)
        {
            return EndInvoke<ListClustersResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the ListContainerInstances operation on AmazonECSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListContainerInstances
        ///         operation.</returns>
        public IAsyncResult BeginListContainerInstances(ListContainerInstancesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListContainerInstancesRequestMarshaller();
            var unmarshaller = ListContainerInstancesResponseUnmarshaller.Instance;

            return BeginInvoke<ListContainerInstancesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListContainerInstances operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListContainerInstances.</param>
        /// 
        /// <returns>Returns a  ListContainerInstancesResult from ECS.</returns>
        public  ListContainerInstancesResponse EndListContainerInstances(IAsyncResult asyncResult)
        {
            return EndInvoke<ListContainerInstancesResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the ListTaskDefinitions operation on AmazonECSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTaskDefinitions
        ///         operation.</returns>
        public IAsyncResult BeginListTaskDefinitions(ListTaskDefinitionsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListTaskDefinitionsRequestMarshaller();
            var unmarshaller = ListTaskDefinitionsResponseUnmarshaller.Instance;

            return BeginInvoke<ListTaskDefinitionsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTaskDefinitions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTaskDefinitions.</param>
        /// 
        /// <returns>Returns a  ListTaskDefinitionsResult from ECS.</returns>
        public  ListTaskDefinitionsResponse EndListTaskDefinitions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTaskDefinitionsResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the ListTasks operation on AmazonECSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTasks
        ///         operation.</returns>
        public IAsyncResult BeginListTasks(ListTasksRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListTasksRequestMarshaller();
            var unmarshaller = ListTasksResponseUnmarshaller.Instance;

            return BeginInvoke<ListTasksRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTasks operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTasks.</param>
        /// 
        /// <returns>Returns a  ListTasksResult from ECS.</returns>
        public  ListTasksResponse EndListTasks(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTasksResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the RegisterTaskDefinition operation on AmazonECSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRegisterTaskDefinition
        ///         operation.</returns>
        public IAsyncResult BeginRegisterTaskDefinition(RegisterTaskDefinitionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new RegisterTaskDefinitionRequestMarshaller();
            var unmarshaller = RegisterTaskDefinitionResponseUnmarshaller.Instance;

            return BeginInvoke<RegisterTaskDefinitionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RegisterTaskDefinition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRegisterTaskDefinition.</param>
        /// 
        /// <returns>Returns a  RegisterTaskDefinitionResult from ECS.</returns>
        public  RegisterTaskDefinitionResponse EndRegisterTaskDefinition(IAsyncResult asyncResult)
        {
            return EndInvoke<RegisterTaskDefinitionResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the RunTask operation on AmazonECSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRunTask
        ///         operation.</returns>
        public IAsyncResult BeginRunTask(RunTaskRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new RunTaskRequestMarshaller();
            var unmarshaller = RunTaskResponseUnmarshaller.Instance;

            return BeginInvoke<RunTaskRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RunTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRunTask.</param>
        /// 
        /// <returns>Returns a  RunTaskResult from ECS.</returns>
        public  RunTaskResponse EndRunTask(IAsyncResult asyncResult)
        {
            return EndInvoke<RunTaskResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the StartTask operation on AmazonECSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartTask
        ///         operation.</returns>
        public IAsyncResult BeginStartTask(StartTaskRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new StartTaskRequestMarshaller();
            var unmarshaller = StartTaskResponseUnmarshaller.Instance;

            return BeginInvoke<StartTaskRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartTask.</param>
        /// 
        /// <returns>Returns a  StartTaskResult from ECS.</returns>
        public  StartTaskResponse EndStartTask(IAsyncResult asyncResult)
        {
            return EndInvoke<StartTaskResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the StopTask operation on AmazonECSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopTask
        ///         operation.</returns>
        public IAsyncResult BeginStopTask(StopTaskRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new StopTaskRequestMarshaller();
            var unmarshaller = StopTaskResponseUnmarshaller.Instance;

            return BeginInvoke<StopTaskRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StopTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopTask.</param>
        /// 
        /// <returns>Returns a  StopTaskResult from ECS.</returns>
        public  StopTaskResponse EndStopTask(IAsyncResult asyncResult)
        {
            return EndInvoke<StopTaskResponse>(asyncResult);
        }

        #endregion
        
    }
}