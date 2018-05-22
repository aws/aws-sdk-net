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

        /// <summary>
        /// Creates a new Amazon ECS cluster. By default, your account receives a <code>default</code>
        /// cluster when you launch your first container instance. However, you can create your
        /// own cluster with a unique name with the <code>CreateCluster</code> action.
        /// 
        ///  <note> 
        /// <para>
        /// When you call the <a>CreateCluster</a> API operation, Amazon ECS attempts to create
        /// the service-linked role for your account so that required resources in other AWS services
        /// can be managed on your behalf. However, if the IAM user that makes the call does not
        /// have permissions to create the service-linked role, it is not created. For more information,
        /// see <a href="http://docs.aws.amazon.com/AmazonECS/latest/developerguide/using-service-linked-roles.html">Using
        /// Service-Linked Roles for Amazon ECS</a> in the <i>Amazon Elastic Container Service
        /// Developer Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCluster service method.</param>
        /// 
        /// <returns>The response from the CreateCluster service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action, such as using an action or resource
        /// on behalf of a user that doesn't have permissions to use the action or resource, or
        /// specifying an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/CreateCluster">REST API Reference for CreateCluster Operation</seealso>
        public virtual CreateClusterResponse CreateCluster(CreateClusterRequest request)
        {
            var marshaller = CreateClusterRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/CreateCluster">REST API Reference for CreateCluster Operation</seealso>
        public virtual IAsyncResult BeginCreateCluster(CreateClusterRequest request, AsyncCallback callback, object state)
        {
            var marshaller = CreateClusterRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/CreateCluster">REST API Reference for CreateCluster Operation</seealso>
        public virtual CreateClusterResponse EndCreateCluster(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateClusterResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateService

        /// <summary>
        /// Runs and maintains a desired number of tasks from a specified task definition. If
        /// the number of tasks running in a service drops below <code>desiredCount</code>, Amazon
        /// ECS spawns another copy of the task in the specified cluster. To update an existing
        /// service, see <a>UpdateService</a>.
        /// 
        ///  
        /// <para>
        /// In addition to maintaining the desired count of tasks in your service, you can optionally
        /// run your service behind a load balancer. The load balancer distributes traffic across
        /// the tasks that are associated with the service. For more information, see <a href="http://docs.aws.amazon.com/AmazonECS/latest/developerguide/service-load-balancing.html">Service
        /// Load Balancing</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can optionally specify a deployment configuration for your service. During a deployment,
        /// the service scheduler uses the <code>minimumHealthyPercent</code> and <code>maximumPercent</code>
        /// parameters to determine the deployment strategy. The deployment is triggered by changing
        /// the task definition or the desired count of a service with an <a>UpdateService</a>
        /// operation.
        /// </para>
        ///  
        /// <para>
        /// The <code>minimumHealthyPercent</code> represents a lower limit on the number of your
        /// service's tasks that must remain in the <code>RUNNING</code> state during a deployment,
        /// as a percentage of the <code>desiredCount</code> (rounded up to the nearest integer).
        /// This parameter enables you to deploy without using additional cluster capacity. For
        /// example, if your service has a <code>desiredCount</code> of four tasks and a <code>minimumHealthyPercent</code>
        /// of 50%, the scheduler can stop two existing tasks to free up cluster capacity before
        /// starting two new tasks. Tasks for services that <i>do not</i> use a load balancer
        /// are considered healthy if they are in the <code>RUNNING</code> state. Tasks for services
        /// that <i>do</i> use a load balancer are considered healthy if they are in the <code>RUNNING</code>
        /// state and the container instance they are hosted on is reported as healthy by the
        /// load balancer. The default value for <code>minimumHealthyPercent</code> is 50% in
        /// the console and 100% for the AWS CLI, the AWS SDKs, and the APIs.
        /// </para>
        ///  
        /// <para>
        /// The <code>maximumPercent</code> parameter represents an upper limit on the number
        /// of your service's tasks that are allowed in the <code>RUNNING</code> or <code>PENDING</code>
        /// state during a deployment, as a percentage of the <code>desiredCount</code> (rounded
        /// down to the nearest integer). This parameter enables you to define the deployment
        /// batch size. For example, if your service has a <code>desiredCount</code> of four tasks
        /// and a <code>maximumPercent</code> value of 200%, the scheduler can start four new
        /// tasks before stopping the four older tasks (provided that the cluster resources required
        /// to do this are available). The default value for <code>maximumPercent</code> is 200%.
        /// </para>
        ///  
        /// <para>
        /// When the service scheduler launches new tasks, it determines task placement in your
        /// cluster using the following logic:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Determine which of the container instances in your cluster can support your service's
        /// task definition (for example, they have the required CPU, memory, ports, and container
        /// instance attributes).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// By default, the service scheduler attempts to balance tasks across Availability Zones
        /// in this manner (although you can choose a different placement strategy) with the <code>placementStrategy</code>
        /// parameter):
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Sort the valid container instances, giving priority to instances that have the fewest
        /// number of running tasks for this service in their respective Availability Zone. For
        /// example, if zone A has one running service task and zones B and C each have zero,
        /// valid container instances in either zone B or C are considered optimal for placement.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Place the new service task on a valid container instance in an optimal Availability
        /// Zone (based on the previous steps), favoring container instances with the fewest number
        /// of running tasks for this service.
        /// </para>
        ///  </li> </ul> </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateService service method.</param>
        /// 
        /// <returns>The response from the CreateService service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.AccessDeniedException">
        /// You do not have authorization to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action, such as using an action or resource
        /// on behalf of a user that doesn't have permissions to use the action or resource, or
        /// specifying an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClusterNotFoundException">
        /// The specified cluster could not be found. You can view your available clusters with
        /// <a>ListClusters</a>. Amazon ECS clusters are region-specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.PlatformTaskDefinitionIncompatibilityException">
        /// The specified platform version does not satisfy the task definition’s required capabilities.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.PlatformUnknownException">
        /// The specified platform version does not exist.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.UnsupportedFeatureException">
        /// The specified task is not supported in this region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/CreateService">REST API Reference for CreateService Operation</seealso>
        public virtual CreateServiceResponse CreateService(CreateServiceRequest request)
        {
            var marshaller = CreateServiceRequestMarshaller.Instance;
            var unmarshaller = CreateServiceResponseUnmarshaller.Instance;

            return Invoke<CreateServiceRequest,CreateServiceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateService operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateService operation on AmazonECSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateService
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/CreateService">REST API Reference for CreateService Operation</seealso>
        public virtual IAsyncResult BeginCreateService(CreateServiceRequest request, AsyncCallback callback, object state)
        {
            var marshaller = CreateServiceRequestMarshaller.Instance;
            var unmarshaller = CreateServiceResponseUnmarshaller.Instance;

            return BeginInvoke<CreateServiceRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateService operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateService.</param>
        /// 
        /// <returns>Returns a  CreateServiceResult from ECS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/CreateService">REST API Reference for CreateService Operation</seealso>
        public virtual CreateServiceResponse EndCreateService(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateServiceResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteAttributes

        /// <summary>
        /// Deletes one or more custom attributes from an Amazon ECS resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAttributes service method.</param>
        /// 
        /// <returns>The response from the DeleteAttributes service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClusterNotFoundException">
        /// The specified cluster could not be found. You can view your available clusters with
        /// <a>ListClusters</a>. Amazon ECS clusters are region-specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.TargetNotFoundException">
        /// The specified target could not be found. You can view your available container instances
        /// with <a>ListContainerInstances</a>. Amazon ECS container instances are cluster-specific
        /// and region-specific.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/DeleteAttributes">REST API Reference for DeleteAttributes Operation</seealso>
        public virtual DeleteAttributesResponse DeleteAttributes(DeleteAttributesRequest request)
        {
            var marshaller = DeleteAttributesRequestMarshaller.Instance;
            var unmarshaller = DeleteAttributesResponseUnmarshaller.Instance;

            return Invoke<DeleteAttributesRequest,DeleteAttributesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAttributes operation on AmazonECSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAttributes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/DeleteAttributes">REST API Reference for DeleteAttributes Operation</seealso>
        public virtual IAsyncResult BeginDeleteAttributes(DeleteAttributesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DeleteAttributesRequestMarshaller.Instance;
            var unmarshaller = DeleteAttributesResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteAttributesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAttributes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAttributes.</param>
        /// 
        /// <returns>Returns a  DeleteAttributesResult from ECS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/DeleteAttributes">REST API Reference for DeleteAttributes Operation</seealso>
        public virtual DeleteAttributesResponse EndDeleteAttributes(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteAttributesResponse>(asyncResult);
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
        /// These errors are usually caused by a client action, such as using an action or resource
        /// on behalf of a user that doesn't have permissions to use the action or resource, or
        /// specifying an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClusterContainsContainerInstancesException">
        /// You cannot delete a cluster that has registered container instances. You must first
        /// deregister the container instances before you can delete the cluster. For more information,
        /// see <a>DeregisterContainerInstance</a>.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClusterContainsServicesException">
        /// You cannot delete a cluster that contains services. You must first update the service
        /// to reduce its desired task count to 0 and then delete the service. For more information,
        /// see <a>UpdateService</a> and <a>DeleteService</a>.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClusterContainsTasksException">
        /// You cannot delete a cluster that has active tasks.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClusterNotFoundException">
        /// The specified cluster could not be found. You can view your available clusters with
        /// <a>ListClusters</a>. Amazon ECS clusters are region-specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/DeleteCluster">REST API Reference for DeleteCluster Operation</seealso>
        public virtual DeleteClusterResponse DeleteCluster(DeleteClusterRequest request)
        {
            var marshaller = DeleteClusterRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/DeleteCluster">REST API Reference for DeleteCluster Operation</seealso>
        public virtual IAsyncResult BeginDeleteCluster(DeleteClusterRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DeleteClusterRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/DeleteCluster">REST API Reference for DeleteCluster Operation</seealso>
        public virtual DeleteClusterResponse EndDeleteCluster(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteClusterResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteService

        /// <summary>
        /// Deletes a specified service within a cluster. You can delete a service if you have
        /// no running tasks in it and the desired task count is zero. If the service is actively
        /// maintaining tasks, you cannot delete it, and you must update the service to a desired
        /// task count of zero. For more information, see <a>UpdateService</a>.
        /// 
        ///  <note> 
        /// <para>
        /// When you delete a service, if there are still running tasks that require cleanup,
        /// the service status moves from <code>ACTIVE</code> to <code>DRAINING</code>, and the
        /// service is no longer visible in the console or in <a>ListServices</a> API operations.
        /// After the tasks have stopped, then the service status moves from <code>DRAINING</code>
        /// to <code>INACTIVE</code>. Services in the <code>DRAINING</code> or <code>INACTIVE</code>
        /// status can still be viewed with <a>DescribeServices</a> API operations. However, in
        /// the future, <code>INACTIVE</code> services may be cleaned up and purged from Amazon
        /// ECS record keeping, and <a>DescribeServices</a> API operations on those services return
        /// a <code>ServiceNotFoundException</code> error.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteService service method.</param>
        /// 
        /// <returns>The response from the DeleteService service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action, such as using an action or resource
        /// on behalf of a user that doesn't have permissions to use the action or resource, or
        /// specifying an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClusterNotFoundException">
        /// The specified cluster could not be found. You can view your available clusters with
        /// <a>ListClusters</a>. Amazon ECS clusters are region-specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServiceNotFoundException">
        /// The specified service could not be found. You can view your available services with
        /// <a>ListServices</a>. Amazon ECS services are cluster-specific and region-specific.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/DeleteService">REST API Reference for DeleteService Operation</seealso>
        public virtual DeleteServiceResponse DeleteService(DeleteServiceRequest request)
        {
            var marshaller = DeleteServiceRequestMarshaller.Instance;
            var unmarshaller = DeleteServiceResponseUnmarshaller.Instance;

            return Invoke<DeleteServiceRequest,DeleteServiceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteService operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteService operation on AmazonECSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteService
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/DeleteService">REST API Reference for DeleteService Operation</seealso>
        public virtual IAsyncResult BeginDeleteService(DeleteServiceRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DeleteServiceRequestMarshaller.Instance;
            var unmarshaller = DeleteServiceResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteServiceRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteService operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteService.</param>
        /// 
        /// <returns>Returns a  DeleteServiceResult from ECS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/DeleteService">REST API Reference for DeleteService Operation</seealso>
        public virtual DeleteServiceResponse EndDeleteService(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteServiceResponse>(asyncResult);
        }

        #endregion
        
        #region  DeregisterContainerInstance

        /// <summary>
        /// Deregisters an Amazon ECS container instance from the specified cluster. This instance
        /// is no longer available to run tasks.
        /// 
        ///  
        /// <para>
        /// If you intend to use the container instance for some other purpose after deregistration,
        /// you should stop all of the tasks running on the container instance before deregistration.
        /// That prevents any orphaned tasks from consuming resources.
        /// </para>
        ///  
        /// <para>
        /// Deregistering a container instance removes the instance from a cluster, but it does
        /// not terminate the EC2 instance; if you are finished using the instance, be sure to
        /// terminate it in the Amazon EC2 console to stop billing.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you terminate a running container instance, Amazon ECS automatically deregisters
        /// the instance from your cluster (stopped container instances or instances with disconnected
        /// agents are not automatically deregistered when terminated).
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterContainerInstance service method.</param>
        /// 
        /// <returns>The response from the DeregisterContainerInstance service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action, such as using an action or resource
        /// on behalf of a user that doesn't have permissions to use the action or resource, or
        /// specifying an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClusterNotFoundException">
        /// The specified cluster could not be found. You can view your available clusters with
        /// <a>ListClusters</a>. Amazon ECS clusters are region-specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/DeregisterContainerInstance">REST API Reference for DeregisterContainerInstance Operation</seealso>
        public virtual DeregisterContainerInstanceResponse DeregisterContainerInstance(DeregisterContainerInstanceRequest request)
        {
            var marshaller = DeregisterContainerInstanceRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/DeregisterContainerInstance">REST API Reference for DeregisterContainerInstance Operation</seealso>
        public virtual IAsyncResult BeginDeregisterContainerInstance(DeregisterContainerInstanceRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DeregisterContainerInstanceRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/DeregisterContainerInstance">REST API Reference for DeregisterContainerInstance Operation</seealso>
        public virtual DeregisterContainerInstanceResponse EndDeregisterContainerInstance(IAsyncResult asyncResult)
        {
            return EndInvoke<DeregisterContainerInstanceResponse>(asyncResult);
        }

        #endregion
        
        #region  DeregisterTaskDefinition

        /// <summary>
        /// Deregisters the specified task definition by family and revision. Upon deregistration,
        /// the task definition is marked as <code>INACTIVE</code>. Existing tasks and services
        /// that reference an <code>INACTIVE</code> task definition continue to run without disruption.
        /// Existing services that reference an <code>INACTIVE</code> task definition can still
        /// scale up or down by modifying the service's desired count.
        /// 
        ///  
        /// <para>
        /// You cannot use an <code>INACTIVE</code> task definition to run new tasks or create
        /// new services, and you cannot update an existing service to reference an <code>INACTIVE</code>
        /// task definition (although there may be up to a 10-minute window following deregistration
        /// where these restrictions have not yet taken effect).
        /// </para>
        ///  <note> 
        /// <para>
        /// At this time, <code>INACTIVE</code> task definitions remain discoverable in your account
        /// indefinitely; however, this behavior is subject to change in the future, so you should
        /// not rely on <code>INACTIVE</code> task definitions persisting beyond the lifecycle
        /// of any associated tasks and services.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterTaskDefinition service method.</param>
        /// 
        /// <returns>The response from the DeregisterTaskDefinition service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action, such as using an action or resource
        /// on behalf of a user that doesn't have permissions to use the action or resource, or
        /// specifying an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/DeregisterTaskDefinition">REST API Reference for DeregisterTaskDefinition Operation</seealso>
        public virtual DeregisterTaskDefinitionResponse DeregisterTaskDefinition(DeregisterTaskDefinitionRequest request)
        {
            var marshaller = DeregisterTaskDefinitionRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/DeregisterTaskDefinition">REST API Reference for DeregisterTaskDefinition Operation</seealso>
        public virtual IAsyncResult BeginDeregisterTaskDefinition(DeregisterTaskDefinitionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DeregisterTaskDefinitionRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/DeregisterTaskDefinition">REST API Reference for DeregisterTaskDefinition Operation</seealso>
        public virtual DeregisterTaskDefinitionResponse EndDeregisterTaskDefinition(IAsyncResult asyncResult)
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
        /// These errors are usually caused by a client action, such as using an action or resource
        /// on behalf of a user that doesn't have permissions to use the action or resource, or
        /// specifying an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/DescribeClusters">REST API Reference for DescribeClusters Operation</seealso>
        public virtual DescribeClustersResponse DescribeClusters(DescribeClustersRequest request)
        {
            var marshaller = DescribeClustersRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/DescribeClusters">REST API Reference for DescribeClusters Operation</seealso>
        public virtual IAsyncResult BeginDescribeClusters(DescribeClustersRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DescribeClustersRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/DescribeClusters">REST API Reference for DescribeClusters Operation</seealso>
        public virtual DescribeClustersResponse EndDescribeClusters(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeClustersResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeContainerInstances

        /// <summary>
        /// Describes Amazon Elastic Container Service container instances. Returns metadata about
        /// registered and remaining resources on each container instance requested.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeContainerInstances service method.</param>
        /// 
        /// <returns>The response from the DescribeContainerInstances service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action, such as using an action or resource
        /// on behalf of a user that doesn't have permissions to use the action or resource, or
        /// specifying an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClusterNotFoundException">
        /// The specified cluster could not be found. You can view your available clusters with
        /// <a>ListClusters</a>. Amazon ECS clusters are region-specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/DescribeContainerInstances">REST API Reference for DescribeContainerInstances Operation</seealso>
        public virtual DescribeContainerInstancesResponse DescribeContainerInstances(DescribeContainerInstancesRequest request)
        {
            var marshaller = DescribeContainerInstancesRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/DescribeContainerInstances">REST API Reference for DescribeContainerInstances Operation</seealso>
        public virtual IAsyncResult BeginDescribeContainerInstances(DescribeContainerInstancesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DescribeContainerInstancesRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/DescribeContainerInstances">REST API Reference for DescribeContainerInstances Operation</seealso>
        public virtual DescribeContainerInstancesResponse EndDescribeContainerInstances(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeContainerInstancesResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeServices

        /// <summary>
        /// Describes the specified services running in your cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeServices service method.</param>
        /// 
        /// <returns>The response from the DescribeServices service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action, such as using an action or resource
        /// on behalf of a user that doesn't have permissions to use the action or resource, or
        /// specifying an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClusterNotFoundException">
        /// The specified cluster could not be found. You can view your available clusters with
        /// <a>ListClusters</a>. Amazon ECS clusters are region-specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/DescribeServices">REST API Reference for DescribeServices Operation</seealso>
        public virtual DescribeServicesResponse DescribeServices(DescribeServicesRequest request)
        {
            var marshaller = DescribeServicesRequestMarshaller.Instance;
            var unmarshaller = DescribeServicesResponseUnmarshaller.Instance;

            return Invoke<DescribeServicesRequest,DescribeServicesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeServices operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeServices operation on AmazonECSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeServices
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/DescribeServices">REST API Reference for DescribeServices Operation</seealso>
        public virtual IAsyncResult BeginDescribeServices(DescribeServicesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DescribeServicesRequestMarshaller.Instance;
            var unmarshaller = DescribeServicesResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeServicesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeServices operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeServices.</param>
        /// 
        /// <returns>Returns a  DescribeServicesResult from ECS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/DescribeServices">REST API Reference for DescribeServices Operation</seealso>
        public virtual DescribeServicesResponse EndDescribeServices(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeServicesResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeTaskDefinition

        /// <summary>
        /// Describes a task definition. You can specify a <code>family</code> and <code>revision</code>
        /// to find information about a specific task definition, or you can simply specify the
        /// family to find the latest <code>ACTIVE</code> revision in that family.
        /// 
        ///  <note> 
        /// <para>
        /// You can only describe <code>INACTIVE</code> task definitions while an active task
        /// or service references them.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTaskDefinition service method.</param>
        /// 
        /// <returns>The response from the DescribeTaskDefinition service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action, such as using an action or resource
        /// on behalf of a user that doesn't have permissions to use the action or resource, or
        /// specifying an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/DescribeTaskDefinition">REST API Reference for DescribeTaskDefinition Operation</seealso>
        public virtual DescribeTaskDefinitionResponse DescribeTaskDefinition(DescribeTaskDefinitionRequest request)
        {
            var marshaller = DescribeTaskDefinitionRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/DescribeTaskDefinition">REST API Reference for DescribeTaskDefinition Operation</seealso>
        public virtual IAsyncResult BeginDescribeTaskDefinition(DescribeTaskDefinitionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DescribeTaskDefinitionRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/DescribeTaskDefinition">REST API Reference for DescribeTaskDefinition Operation</seealso>
        public virtual DescribeTaskDefinitionResponse EndDescribeTaskDefinition(IAsyncResult asyncResult)
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
        /// These errors are usually caused by a client action, such as using an action or resource
        /// on behalf of a user that doesn't have permissions to use the action or resource, or
        /// specifying an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClusterNotFoundException">
        /// The specified cluster could not be found. You can view your available clusters with
        /// <a>ListClusters</a>. Amazon ECS clusters are region-specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/DescribeTasks">REST API Reference for DescribeTasks Operation</seealso>
        public virtual DescribeTasksResponse DescribeTasks(DescribeTasksRequest request)
        {
            var marshaller = DescribeTasksRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/DescribeTasks">REST API Reference for DescribeTasks Operation</seealso>
        public virtual IAsyncResult BeginDescribeTasks(DescribeTasksRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DescribeTasksRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/DescribeTasks">REST API Reference for DescribeTasks Operation</seealso>
        public virtual DescribeTasksResponse EndDescribeTasks(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeTasksResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAttributes

        /// <summary>
        /// Lists the attributes for Amazon ECS resources within a specified target type and cluster.
        /// When you specify a target type and cluster, <code>ListAttributes</code> returns a
        /// list of attribute objects, one for each attribute on each resource. You can filter
        /// the list of results to a single attribute name to only return results that have that
        /// name. You can also filter the results by attribute name and value, for example, to
        /// see which container instances in a cluster are running a Linux AMI (<code>ecs.os-type=linux</code>).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAttributes service method.</param>
        /// 
        /// <returns>The response from the ListAttributes service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClusterNotFoundException">
        /// The specified cluster could not be found. You can view your available clusters with
        /// <a>ListClusters</a>. Amazon ECS clusters are region-specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/ListAttributes">REST API Reference for ListAttributes Operation</seealso>
        public virtual ListAttributesResponse ListAttributes(ListAttributesRequest request)
        {
            var marshaller = ListAttributesRequestMarshaller.Instance;
            var unmarshaller = ListAttributesResponseUnmarshaller.Instance;

            return Invoke<ListAttributesRequest,ListAttributesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAttributes operation on AmazonECSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAttributes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/ListAttributes">REST API Reference for ListAttributes Operation</seealso>
        public virtual IAsyncResult BeginListAttributes(ListAttributesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ListAttributesRequestMarshaller.Instance;
            var unmarshaller = ListAttributesResponseUnmarshaller.Instance;

            return BeginInvoke<ListAttributesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAttributes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAttributes.</param>
        /// 
        /// <returns>Returns a  ListAttributesResult from ECS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/ListAttributes">REST API Reference for ListAttributes Operation</seealso>
        public virtual ListAttributesResponse EndListAttributes(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAttributesResponse>(asyncResult);
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
        /// These errors are usually caused by a client action, such as using an action or resource
        /// on behalf of a user that doesn't have permissions to use the action or resource, or
        /// specifying an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/ListClusters">REST API Reference for ListClusters Operation</seealso>
        public virtual ListClustersResponse ListClusters(ListClustersRequest request)
        {
            var marshaller = ListClustersRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/ListClusters">REST API Reference for ListClusters Operation</seealso>
        public virtual IAsyncResult BeginListClusters(ListClustersRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ListClustersRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/ListClusters">REST API Reference for ListClusters Operation</seealso>
        public virtual ListClustersResponse EndListClusters(IAsyncResult asyncResult)
        {
            return EndInvoke<ListClustersResponse>(asyncResult);
        }

        #endregion
        
        #region  ListContainerInstances

        /// <summary>
        /// Returns a list of container instances in a specified cluster. You can filter the results
        /// of a <code>ListContainerInstances</code> operation with cluster query language statements
        /// inside the <code>filter</code> parameter. For more information, see <a href="http://docs.aws.amazon.com/AmazonECS/latest/developerguide/cluster-query-language.html">Cluster
        /// Query Language</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListContainerInstances service method.</param>
        /// 
        /// <returns>The response from the ListContainerInstances service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action, such as using an action or resource
        /// on behalf of a user that doesn't have permissions to use the action or resource, or
        /// specifying an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClusterNotFoundException">
        /// The specified cluster could not be found. You can view your available clusters with
        /// <a>ListClusters</a>. Amazon ECS clusters are region-specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/ListContainerInstances">REST API Reference for ListContainerInstances Operation</seealso>
        public virtual ListContainerInstancesResponse ListContainerInstances(ListContainerInstancesRequest request)
        {
            var marshaller = ListContainerInstancesRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/ListContainerInstances">REST API Reference for ListContainerInstances Operation</seealso>
        public virtual IAsyncResult BeginListContainerInstances(ListContainerInstancesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ListContainerInstancesRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/ListContainerInstances">REST API Reference for ListContainerInstances Operation</seealso>
        public virtual ListContainerInstancesResponse EndListContainerInstances(IAsyncResult asyncResult)
        {
            return EndInvoke<ListContainerInstancesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListServices

        /// <summary>
        /// Lists the services that are running in a specified cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServices service method.</param>
        /// 
        /// <returns>The response from the ListServices service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action, such as using an action or resource
        /// on behalf of a user that doesn't have permissions to use the action or resource, or
        /// specifying an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClusterNotFoundException">
        /// The specified cluster could not be found. You can view your available clusters with
        /// <a>ListClusters</a>. Amazon ECS clusters are region-specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/ListServices">REST API Reference for ListServices Operation</seealso>
        public virtual ListServicesResponse ListServices(ListServicesRequest request)
        {
            var marshaller = ListServicesRequestMarshaller.Instance;
            var unmarshaller = ListServicesResponseUnmarshaller.Instance;

            return Invoke<ListServicesRequest,ListServicesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListServices operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListServices operation on AmazonECSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListServices
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/ListServices">REST API Reference for ListServices Operation</seealso>
        public virtual IAsyncResult BeginListServices(ListServicesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ListServicesRequestMarshaller.Instance;
            var unmarshaller = ListServicesResponseUnmarshaller.Instance;

            return BeginInvoke<ListServicesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListServices operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListServices.</param>
        /// 
        /// <returns>Returns a  ListServicesResult from ECS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/ListServices">REST API Reference for ListServices Operation</seealso>
        public virtual ListServicesResponse EndListServices(IAsyncResult asyncResult)
        {
            return EndInvoke<ListServicesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTaskDefinitionFamilies

        /// <summary>
        /// Returns a list of task definition families that are registered to your account (which
        /// may include task definition families that no longer have any <code>ACTIVE</code> task
        /// definition revisions).
        /// 
        ///  
        /// <para>
        /// You can filter out task definition families that do not contain any <code>ACTIVE</code>
        /// task definition revisions by setting the <code>status</code> parameter to <code>ACTIVE</code>.
        /// You can also filter the results with the <code>familyPrefix</code> parameter.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTaskDefinitionFamilies service method.</param>
        /// 
        /// <returns>The response from the ListTaskDefinitionFamilies service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action, such as using an action or resource
        /// on behalf of a user that doesn't have permissions to use the action or resource, or
        /// specifying an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/ListTaskDefinitionFamilies">REST API Reference for ListTaskDefinitionFamilies Operation</seealso>
        public virtual ListTaskDefinitionFamiliesResponse ListTaskDefinitionFamilies(ListTaskDefinitionFamiliesRequest request)
        {
            var marshaller = ListTaskDefinitionFamiliesRequestMarshaller.Instance;
            var unmarshaller = ListTaskDefinitionFamiliesResponseUnmarshaller.Instance;

            return Invoke<ListTaskDefinitionFamiliesRequest,ListTaskDefinitionFamiliesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTaskDefinitionFamilies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTaskDefinitionFamilies operation on AmazonECSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTaskDefinitionFamilies
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/ListTaskDefinitionFamilies">REST API Reference for ListTaskDefinitionFamilies Operation</seealso>
        public virtual IAsyncResult BeginListTaskDefinitionFamilies(ListTaskDefinitionFamiliesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ListTaskDefinitionFamiliesRequestMarshaller.Instance;
            var unmarshaller = ListTaskDefinitionFamiliesResponseUnmarshaller.Instance;

            return BeginInvoke<ListTaskDefinitionFamiliesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTaskDefinitionFamilies operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTaskDefinitionFamilies.</param>
        /// 
        /// <returns>Returns a  ListTaskDefinitionFamiliesResult from ECS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/ListTaskDefinitionFamilies">REST API Reference for ListTaskDefinitionFamilies Operation</seealso>
        public virtual ListTaskDefinitionFamiliesResponse EndListTaskDefinitionFamilies(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTaskDefinitionFamiliesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTaskDefinitions

        /// <summary>
        /// Returns a list of task definitions that are registered to your account. You can filter
        /// the results by family name with the <code>familyPrefix</code> parameter or by status
        /// with the <code>status</code> parameter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTaskDefinitions service method.</param>
        /// 
        /// <returns>The response from the ListTaskDefinitions service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action, such as using an action or resource
        /// on behalf of a user that doesn't have permissions to use the action or resource, or
        /// specifying an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/ListTaskDefinitions">REST API Reference for ListTaskDefinitions Operation</seealso>
        public virtual ListTaskDefinitionsResponse ListTaskDefinitions(ListTaskDefinitionsRequest request)
        {
            var marshaller = ListTaskDefinitionsRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/ListTaskDefinitions">REST API Reference for ListTaskDefinitions Operation</seealso>
        public virtual IAsyncResult BeginListTaskDefinitions(ListTaskDefinitionsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ListTaskDefinitionsRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/ListTaskDefinitions">REST API Reference for ListTaskDefinitions Operation</seealso>
        public virtual ListTaskDefinitionsResponse EndListTaskDefinitions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTaskDefinitionsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTasks

        /// <summary>
        /// Returns a list of tasks for a specified cluster. You can filter the results by family
        /// name, by a particular container instance, or by the desired status of the task with
        /// the <code>family</code>, <code>containerInstance</code>, and <code>desiredStatus</code>
        /// parameters.
        /// 
        ///  
        /// <para>
        /// Recently stopped tasks might appear in the returned results. Currently, stopped tasks
        /// appear in the returned results for at least one hour. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTasks service method.</param>
        /// 
        /// <returns>The response from the ListTasks service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action, such as using an action or resource
        /// on behalf of a user that doesn't have permissions to use the action or resource, or
        /// specifying an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClusterNotFoundException">
        /// The specified cluster could not be found. You can view your available clusters with
        /// <a>ListClusters</a>. Amazon ECS clusters are region-specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServiceNotFoundException">
        /// The specified service could not be found. You can view your available services with
        /// <a>ListServices</a>. Amazon ECS services are cluster-specific and region-specific.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/ListTasks">REST API Reference for ListTasks Operation</seealso>
        public virtual ListTasksResponse ListTasks(ListTasksRequest request)
        {
            var marshaller = ListTasksRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/ListTasks">REST API Reference for ListTasks Operation</seealso>
        public virtual IAsyncResult BeginListTasks(ListTasksRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ListTasksRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/ListTasks">REST API Reference for ListTasks Operation</seealso>
        public virtual ListTasksResponse EndListTasks(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTasksResponse>(asyncResult);
        }

        #endregion
        
        #region  PutAttributes

        /// <summary>
        /// Create or update an attribute on an Amazon ECS resource. If the attribute does not
        /// exist, it is created. If the attribute exists, its value is replaced with the specified
        /// value. To delete an attribute, use <a>DeleteAttributes</a>. For more information,
        /// see <a href="http://docs.aws.amazon.com/AmazonECS/latest/developerguide/task-placement-constraints.html#attributes">Attributes</a>
        /// in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAttributes service method.</param>
        /// 
        /// <returns>The response from the PutAttributes service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.AttributeLimitExceededException">
        /// You can apply up to 10 custom attributes per resource. You can view the attributes
        /// of a resource with <a>ListAttributes</a>. You can remove existing attributes on a
        /// resource with <a>DeleteAttributes</a>.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClusterNotFoundException">
        /// The specified cluster could not be found. You can view your available clusters with
        /// <a>ListClusters</a>. Amazon ECS clusters are region-specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.TargetNotFoundException">
        /// The specified target could not be found. You can view your available container instances
        /// with <a>ListContainerInstances</a>. Amazon ECS container instances are cluster-specific
        /// and region-specific.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/PutAttributes">REST API Reference for PutAttributes Operation</seealso>
        public virtual PutAttributesResponse PutAttributes(PutAttributesRequest request)
        {
            var marshaller = PutAttributesRequestMarshaller.Instance;
            var unmarshaller = PutAttributesResponseUnmarshaller.Instance;

            return Invoke<PutAttributesRequest,PutAttributesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutAttributes operation on AmazonECSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutAttributes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/PutAttributes">REST API Reference for PutAttributes Operation</seealso>
        public virtual IAsyncResult BeginPutAttributes(PutAttributesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = PutAttributesRequestMarshaller.Instance;
            var unmarshaller = PutAttributesResponseUnmarshaller.Instance;

            return BeginInvoke<PutAttributesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutAttributes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutAttributes.</param>
        /// 
        /// <returns>Returns a  PutAttributesResult from ECS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/PutAttributes">REST API Reference for PutAttributes Operation</seealso>
        public virtual PutAttributesResponse EndPutAttributes(IAsyncResult asyncResult)
        {
            return EndInvoke<PutAttributesResponse>(asyncResult);
        }

        #endregion
        
        #region  RegisterTaskDefinition

        /// <summary>
        /// Registers a new task definition from the supplied <code>family</code> and <code>containerDefinitions</code>.
        /// Optionally, you can add data volumes to your containers with the <code>volumes</code>
        /// parameter. For more information about task definition parameters and defaults, see
        /// <a href="http://docs.aws.amazon.com/AmazonECS/latest/developerguide/task_defintions.html">Amazon
        /// ECS Task Definitions</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// 
        ///  
        /// <para>
        /// You can specify an IAM role for your task with the <code>taskRoleArn</code> parameter.
        /// When you specify an IAM role for a task, its containers can then use the latest versions
        /// of the AWS CLI or SDKs to make API requests to the AWS services that are specified
        /// in the IAM policy associated with the role. For more information, see <a href="http://docs.aws.amazon.com/AmazonECS/latest/developerguide/task-iam-roles.html">IAM
        /// Roles for Tasks</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can specify a Docker networking mode for the containers in your task definition
        /// with the <code>networkMode</code> parameter. The available network modes correspond
        /// to those described in <a href="https://docs.docker.com/engine/reference/run/#/network-settings">Network
        /// settings</a> in the Docker run reference. If you specify the <code>awsvpc</code> network
        /// mode, the task is allocated an Elastic Network Interface, and you must specify a <a>NetworkConfiguration</a>
        /// when you create a service or run a task with the task definition. For more information,
        /// see <a href="http://docs.aws.amazon.com/AmazonECS/latest/developerguide/task-networking.html">Task
        /// Networking</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterTaskDefinition service method.</param>
        /// 
        /// <returns>The response from the RegisterTaskDefinition service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action, such as using an action or resource
        /// on behalf of a user that doesn't have permissions to use the action or resource, or
        /// specifying an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/RegisterTaskDefinition">REST API Reference for RegisterTaskDefinition Operation</seealso>
        public virtual RegisterTaskDefinitionResponse RegisterTaskDefinition(RegisterTaskDefinitionRequest request)
        {
            var marshaller = RegisterTaskDefinitionRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/RegisterTaskDefinition">REST API Reference for RegisterTaskDefinition Operation</seealso>
        public virtual IAsyncResult BeginRegisterTaskDefinition(RegisterTaskDefinitionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = RegisterTaskDefinitionRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/RegisterTaskDefinition">REST API Reference for RegisterTaskDefinition Operation</seealso>
        public virtual RegisterTaskDefinitionResponse EndRegisterTaskDefinition(IAsyncResult asyncResult)
        {
            return EndInvoke<RegisterTaskDefinitionResponse>(asyncResult);
        }

        #endregion
        
        #region  RunTask

        /// <summary>
        /// Starts a new task using the specified task definition.
        /// 
        ///  
        /// <para>
        /// You can allow Amazon ECS to place tasks for you, or you can customize how Amazon ECS
        /// places tasks using placement constraints and placement strategies. For more information,
        /// see <a href="http://docs.aws.amazon.com/AmazonECS/latest/developerguide/scheduling_tasks.html">Scheduling
        /// Tasks</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Alternatively, you can use <a>StartTask</a> to use your own scheduler or place tasks
        /// manually on specific container instances.
        /// </para>
        ///  
        /// <para>
        /// The Amazon ECS API follows an eventual consistency model, due to the distributed nature
        /// of the system supporting the API. This means that the result of an API command you
        /// run that affects your Amazon ECS resources might not be immediately visible to all
        /// subsequent commands you run. You should keep this in mind when you carry out an API
        /// command that immediately follows a previous API command.
        /// </para>
        ///  
        /// <para>
        /// To manage eventual consistency, you can do the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Confirm the state of the resource before you run a command to modify it. Run the DescribeTasks
        /// command using an exponential backoff algorithm to ensure that you allow enough time
        /// for the previous command to propagate through the system. To do this, run the DescribeTasks
        /// command repeatedly, starting with a couple of seconds of wait time, and increasing
        /// gradually up to five minutes of wait time.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Add wait time between subsequent commands, even if the DescribeTasks command returns
        /// an accurate response. Apply an exponential backoff algorithm starting with a couple
        /// of seconds of wait time, and increase gradually up to about five minutes of wait time.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RunTask service method.</param>
        /// 
        /// <returns>The response from the RunTask service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.AccessDeniedException">
        /// You do not have authorization to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.BlockedException">
        /// Your AWS account has been blocked. <a href="http://aws.amazon.com/contact-us/">Contact
        /// AWS Support</a> for more information.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action, such as using an action or resource
        /// on behalf of a user that doesn't have permissions to use the action or resource, or
        /// specifying an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClusterNotFoundException">
        /// The specified cluster could not be found. You can view your available clusters with
        /// <a>ListClusters</a>. Amazon ECS clusters are region-specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.PlatformTaskDefinitionIncompatibilityException">
        /// The specified platform version does not satisfy the task definition’s required capabilities.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.PlatformUnknownException">
        /// The specified platform version does not exist.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.UnsupportedFeatureException">
        /// The specified task is not supported in this region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/RunTask">REST API Reference for RunTask Operation</seealso>
        public virtual RunTaskResponse RunTask(RunTaskRequest request)
        {
            var marshaller = RunTaskRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/RunTask">REST API Reference for RunTask Operation</seealso>
        public virtual IAsyncResult BeginRunTask(RunTaskRequest request, AsyncCallback callback, object state)
        {
            var marshaller = RunTaskRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/RunTask">REST API Reference for RunTask Operation</seealso>
        public virtual RunTaskResponse EndRunTask(IAsyncResult asyncResult)
        {
            return EndInvoke<RunTaskResponse>(asyncResult);
        }

        #endregion
        
        #region  StartTask

        /// <summary>
        /// Starts a new task from the specified task definition on the specified container instance
        /// or instances.
        /// 
        ///  
        /// <para>
        /// Alternatively, you can use <a>RunTask</a> to place tasks for you. For more information,
        /// see <a href="http://docs.aws.amazon.com/AmazonECS/latest/developerguide/scheduling_tasks.html">Scheduling
        /// Tasks</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartTask service method.</param>
        /// 
        /// <returns>The response from the StartTask service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action, such as using an action or resource
        /// on behalf of a user that doesn't have permissions to use the action or resource, or
        /// specifying an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClusterNotFoundException">
        /// The specified cluster could not be found. You can view your available clusters with
        /// <a>ListClusters</a>. Amazon ECS clusters are region-specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/StartTask">REST API Reference for StartTask Operation</seealso>
        public virtual StartTaskResponse StartTask(StartTaskRequest request)
        {
            var marshaller = StartTaskRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/StartTask">REST API Reference for StartTask Operation</seealso>
        public virtual IAsyncResult BeginStartTask(StartTaskRequest request, AsyncCallback callback, object state)
        {
            var marshaller = StartTaskRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/StartTask">REST API Reference for StartTask Operation</seealso>
        public virtual StartTaskResponse EndStartTask(IAsyncResult asyncResult)
        {
            return EndInvoke<StartTaskResponse>(asyncResult);
        }

        #endregion
        
        #region  StopTask

        /// <summary>
        /// Stops a running task.
        /// 
        ///  
        /// <para>
        /// When <a>StopTask</a> is called on a task, the equivalent of <code>docker stop</code>
        /// is issued to the containers running in the task. This results in a <code>SIGTERM</code>
        /// and a default 30-second timeout, after which <code>SIGKILL</code> is sent and the
        /// containers are forcibly stopped. If the container handles the <code>SIGTERM</code>
        /// gracefully and exits within 30 seconds from receiving it, no <code>SIGKILL</code>
        /// is sent.
        /// </para>
        ///  <note> 
        /// <para>
        /// The default 30-second timeout can be configured on the Amazon ECS container agent
        /// with the <code>ECS_CONTAINER_STOP_TIMEOUT</code> variable. For more information, see
        /// <a href="http://docs.aws.amazon.com/AmazonECS/latest/developerguide/ecs-agent-config.html">Amazon
        /// ECS Container Agent Configuration</a> in the <i>Amazon Elastic Container Service Developer
        /// Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopTask service method.</param>
        /// 
        /// <returns>The response from the StopTask service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action, such as using an action or resource
        /// on behalf of a user that doesn't have permissions to use the action or resource, or
        /// specifying an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClusterNotFoundException">
        /// The specified cluster could not be found. You can view your available clusters with
        /// <a>ListClusters</a>. Amazon ECS clusters are region-specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/StopTask">REST API Reference for StopTask Operation</seealso>
        public virtual StopTaskResponse StopTask(StopTaskRequest request)
        {
            var marshaller = StopTaskRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/StopTask">REST API Reference for StopTask Operation</seealso>
        public virtual IAsyncResult BeginStopTask(StopTaskRequest request, AsyncCallback callback, object state)
        {
            var marshaller = StopTaskRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/StopTask">REST API Reference for StopTask Operation</seealso>
        public virtual StopTaskResponse EndStopTask(IAsyncResult asyncResult)
        {
            return EndInvoke<StopTaskResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateContainerAgent

        /// <summary>
        /// Updates the Amazon ECS container agent on a specified container instance. Updating
        /// the Amazon ECS container agent does not interrupt running tasks or services on the
        /// container instance. The process for updating the agent differs depending on whether
        /// your container instance was launched with the Amazon ECS-optimized AMI or another
        /// operating system.
        /// 
        ///  
        /// <para>
        ///  <code>UpdateContainerAgent</code> requires the Amazon ECS-optimized AMI or Amazon
        /// Linux with the <code>ecs-init</code> service installed and running. For help updating
        /// the Amazon ECS container agent on other operating systems, see <a href="http://docs.aws.amazon.com/AmazonECS/latest/developerguide/ecs-agent-update.html#manually_update_agent">Manually
        /// Updating the Amazon ECS Container Agent</a> in the <i>Amazon Elastic Container Service
        /// Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateContainerAgent service method.</param>
        /// 
        /// <returns>The response from the UpdateContainerAgent service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action, such as using an action or resource
        /// on behalf of a user that doesn't have permissions to use the action or resource, or
        /// specifying an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClusterNotFoundException">
        /// The specified cluster could not be found. You can view your available clusters with
        /// <a>ListClusters</a>. Amazon ECS clusters are region-specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.MissingVersionException">
        /// Amazon ECS is unable to determine the current version of the Amazon ECS container
        /// agent on the container instance and does not have enough information to proceed with
        /// an update. This could be because the agent running on the container instance is an
        /// older or custom version that does not use our version information.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.NoUpdateAvailableException">
        /// There is no update available for this Amazon ECS container agent. This could be because
        /// the agent is already running the latest version, or it is so old that there is no
        /// update path to the current version.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.UpdateInProgressException">
        /// There is already a current Amazon ECS container agent update in progress on the specified
        /// container instance. If the container agent becomes disconnected while it is in a transitional
        /// stage, such as <code>PENDING</code> or <code>STAGING</code>, the update process can
        /// get stuck in that state. However, when the agent reconnects, it resumes where it stopped
        /// previously.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/UpdateContainerAgent">REST API Reference for UpdateContainerAgent Operation</seealso>
        public virtual UpdateContainerAgentResponse UpdateContainerAgent(UpdateContainerAgentRequest request)
        {
            var marshaller = UpdateContainerAgentRequestMarshaller.Instance;
            var unmarshaller = UpdateContainerAgentResponseUnmarshaller.Instance;

            return Invoke<UpdateContainerAgentRequest,UpdateContainerAgentResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateContainerAgent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateContainerAgent operation on AmazonECSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateContainerAgent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/UpdateContainerAgent">REST API Reference for UpdateContainerAgent Operation</seealso>
        public virtual IAsyncResult BeginUpdateContainerAgent(UpdateContainerAgentRequest request, AsyncCallback callback, object state)
        {
            var marshaller = UpdateContainerAgentRequestMarshaller.Instance;
            var unmarshaller = UpdateContainerAgentResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateContainerAgentRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateContainerAgent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateContainerAgent.</param>
        /// 
        /// <returns>Returns a  UpdateContainerAgentResult from ECS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/UpdateContainerAgent">REST API Reference for UpdateContainerAgent Operation</seealso>
        public virtual UpdateContainerAgentResponse EndUpdateContainerAgent(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateContainerAgentResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateContainerInstancesState

        /// <summary>
        /// Modifies the status of an Amazon ECS container instance.
        /// 
        ///  
        /// <para>
        /// You can change the status of a container instance to <code>DRAINING</code> to manually
        /// remove an instance from a cluster, for example to perform system updates, update the
        /// Docker daemon, or scale down the cluster size. 
        /// </para>
        ///  
        /// <para>
        /// When you set a container instance to <code>DRAINING</code>, Amazon ECS prevents new
        /// tasks from being scheduled for placement on the container instance and replacement
        /// service tasks are started on other container instances in the cluster if the resources
        /// are available. Service tasks on the container instance that are in the <code>PENDING</code>
        /// state are stopped immediately.
        /// </para>
        ///  
        /// <para>
        /// Service tasks on the container instance that are in the <code>RUNNING</code> state
        /// are stopped and replaced according to the service's deployment configuration parameters,
        /// <code>minimumHealthyPercent</code> and <code>maximumPercent</code>. You can change
        /// the deployment configuration of your service using <a>UpdateService</a>.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If <code>minimumHealthyPercent</code> is below 100%, the scheduler can ignore <code>desiredCount</code>
        /// temporarily during task replacement. For example, <code>desiredCount</code> is four
        /// tasks, a minimum of 50% allows the scheduler to stop two existing tasks before starting
        /// two new tasks. If the minimum is 100%, the service scheduler can't remove existing
        /// tasks until the replacement tasks are considered healthy. Tasks for services that
        /// do not use a load balancer are considered healthy if they are in the <code>RUNNING</code>
        /// state. Tasks for services that use a load balancer are considered healthy if they
        /// are in the <code>RUNNING</code> state and the container instance they are hosted on
        /// is reported as healthy by the load balancer.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <code>maximumPercent</code> parameter represents an upper limit on the number
        /// of running tasks during task replacement, which enables you to define the replacement
        /// batch size. For example, if <code>desiredCount</code> of four tasks, a maximum of
        /// 200% starts four new tasks before stopping the four tasks to be drained (provided
        /// that the cluster resources required to do this are available). If the maximum is 100%,
        /// then replacement tasks can't start until the draining tasks have stopped.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Any <code>PENDING</code> or <code>RUNNING</code> tasks that do not belong to a service
        /// are not affected; you must wait for them to finish or stop them manually.
        /// </para>
        ///  
        /// <para>
        /// A container instance has completed draining when it has no more <code>RUNNING</code>
        /// tasks. You can verify this using <a>ListTasks</a>.
        /// </para>
        ///  
        /// <para>
        /// When you set a container instance to <code>ACTIVE</code>, the Amazon ECS scheduler
        /// can begin scheduling tasks on the instance again.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateContainerInstancesState service method.</param>
        /// 
        /// <returns>The response from the UpdateContainerInstancesState service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action, such as using an action or resource
        /// on behalf of a user that doesn't have permissions to use the action or resource, or
        /// specifying an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClusterNotFoundException">
        /// The specified cluster could not be found. You can view your available clusters with
        /// <a>ListClusters</a>. Amazon ECS clusters are region-specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/UpdateContainerInstancesState">REST API Reference for UpdateContainerInstancesState Operation</seealso>
        public virtual UpdateContainerInstancesStateResponse UpdateContainerInstancesState(UpdateContainerInstancesStateRequest request)
        {
            var marshaller = UpdateContainerInstancesStateRequestMarshaller.Instance;
            var unmarshaller = UpdateContainerInstancesStateResponseUnmarshaller.Instance;

            return Invoke<UpdateContainerInstancesStateRequest,UpdateContainerInstancesStateResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateContainerInstancesState operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateContainerInstancesState operation on AmazonECSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateContainerInstancesState
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/UpdateContainerInstancesState">REST API Reference for UpdateContainerInstancesState Operation</seealso>
        public virtual IAsyncResult BeginUpdateContainerInstancesState(UpdateContainerInstancesStateRequest request, AsyncCallback callback, object state)
        {
            var marshaller = UpdateContainerInstancesStateRequestMarshaller.Instance;
            var unmarshaller = UpdateContainerInstancesStateResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateContainerInstancesStateRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateContainerInstancesState operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateContainerInstancesState.</param>
        /// 
        /// <returns>Returns a  UpdateContainerInstancesStateResult from ECS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/UpdateContainerInstancesState">REST API Reference for UpdateContainerInstancesState Operation</seealso>
        public virtual UpdateContainerInstancesStateResponse EndUpdateContainerInstancesState(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateContainerInstancesStateResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateService

        /// <summary>
        /// Modifies the desired count, deployment configuration, network configuration, or task
        /// definition used in a service.
        /// 
        ///  
        /// <para>
        /// You can add to or subtract from the number of instantiations of a task definition
        /// in a service by specifying the cluster that the service is running in and a new <code>desiredCount</code>
        /// parameter.
        /// </para>
        ///  
        /// <para>
        /// If you have updated the Docker image of your application, you can create a new task
        /// definition with that image and deploy it to your service. The service scheduler uses
        /// the minimum healthy percent and maximum percent parameters (in the service's deployment
        /// configuration) to determine the deployment strategy.
        /// </para>
        ///  <note> 
        /// <para>
        /// If your updated Docker image uses the same tag as what is in the existing task definition
        /// for your service (for example, <code>my_image:latest</code>), you do not need to create
        /// a new revision of your task definition. You can update the service using the <code>forceNewDeployment</code>
        /// option. The new tasks launched by the deployment pull the current image/tag combination
        /// from your repository when they start.
        /// </para>
        ///  </note> 
        /// <para>
        /// You can also update the deployment configuration of a service. When a deployment is
        /// triggered by updating the task definition of a service, the service scheduler uses
        /// the deployment configuration parameters, <code>minimumHealthyPercent</code> and <code>maximumPercent</code>,
        /// to determine the deployment strategy.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If <code>minimumHealthyPercent</code> is below 100%, the scheduler can ignore <code>desiredCount</code>
        /// temporarily during a deployment. For example, if <code>desiredCount</code> is four
        /// tasks, a minimum of 50% allows the scheduler to stop two existing tasks before starting
        /// two new tasks. Tasks for services that do not use a load balancer are considered healthy
        /// if they are in the <code>RUNNING</code> state. Tasks for services that use a load
        /// balancer are considered healthy if they are in the <code>RUNNING</code> state and
        /// the container instance they are hosted on is reported as healthy by the load balancer.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <code>maximumPercent</code> parameter represents an upper limit on the number
        /// of running tasks during a deployment, which enables you to define the deployment batch
        /// size. For example, if <code>desiredCount</code> is four tasks, a maximum of 200% starts
        /// four new tasks before stopping the four older tasks (provided that the cluster resources
        /// required to do this are available).
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When <a>UpdateService</a> stops a task during a deployment, the equivalent of <code>docker
        /// stop</code> is issued to the containers running in the task. This results in a <code>SIGTERM</code>
        /// and a 30-second timeout, after which <code>SIGKILL</code> is sent and the containers
        /// are forcibly stopped. If the container handles the <code>SIGTERM</code> gracefully
        /// and exits within 30 seconds from receiving it, no <code>SIGKILL</code> is sent.
        /// </para>
        ///  
        /// <para>
        /// When the service scheduler launches new tasks, it determines task placement in your
        /// cluster with the following logic:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Determine which of the container instances in your cluster can support your service's
        /// task definition (for example, they have the required CPU, memory, ports, and container
        /// instance attributes).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// By default, the service scheduler attempts to balance tasks across Availability Zones
        /// in this manner (although you can choose a different placement strategy):
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Sort the valid container instances by the fewest number of running tasks for this
        /// service in the same Availability Zone as the instance. For example, if zone A has
        /// one running service task and zones B and C each have zero, valid container instances
        /// in either zone B or C are considered optimal for placement.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Place the new service task on a valid container instance in an optimal Availability
        /// Zone (based on the previous steps), favoring container instances with the fewest number
        /// of running tasks for this service.
        /// </para>
        ///  </li> </ul> </li> </ul> 
        /// <para>
        /// When the service scheduler stops running tasks, it attempts to maintain balance across
        /// the Availability Zones in your cluster using the following logic: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Sort the container instances by the largest number of running tasks for this service
        /// in the same Availability Zone as the instance. For example, if zone A has one running
        /// service task and zones B and C each have two, container instances in either zone B
        /// or C are considered optimal for termination.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Stop the task on a container instance in an optimal Availability Zone (based on the
        /// previous steps), favoring container instances with the largest number of running tasks
        /// for this service.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateService service method.</param>
        /// 
        /// <returns>The response from the UpdateService service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.AccessDeniedException">
        /// You do not have authorization to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action, such as using an action or resource
        /// on behalf of a user that doesn't have permissions to use the action or resource, or
        /// specifying an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClusterNotFoundException">
        /// The specified cluster could not be found. You can view your available clusters with
        /// <a>ListClusters</a>. Amazon ECS clusters are region-specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.PlatformTaskDefinitionIncompatibilityException">
        /// The specified platform version does not satisfy the task definition’s required capabilities.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.PlatformUnknownException">
        /// The specified platform version does not exist.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServiceNotActiveException">
        /// The specified service is not active. You can't update a service that is inactive.
        /// If you have previously deleted a service, you can re-create it with <a>CreateService</a>.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServiceNotFoundException">
        /// The specified service could not be found. You can view your available services with
        /// <a>ListServices</a>. Amazon ECS services are cluster-specific and region-specific.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/UpdateService">REST API Reference for UpdateService Operation</seealso>
        public virtual UpdateServiceResponse UpdateService(UpdateServiceRequest request)
        {
            var marshaller = UpdateServiceRequestMarshaller.Instance;
            var unmarshaller = UpdateServiceResponseUnmarshaller.Instance;

            return Invoke<UpdateServiceRequest,UpdateServiceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateService operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateService operation on AmazonECSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateService
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/UpdateService">REST API Reference for UpdateService Operation</seealso>
        public virtual IAsyncResult BeginUpdateService(UpdateServiceRequest request, AsyncCallback callback, object state)
        {
            var marshaller = UpdateServiceRequestMarshaller.Instance;
            var unmarshaller = UpdateServiceResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateServiceRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateService operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateService.</param>
        /// 
        /// <returns>Returns a  UpdateServiceResult from ECS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/UpdateService">REST API Reference for UpdateService Operation</seealso>
        public virtual UpdateServiceResponse EndUpdateService(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateServiceResponse>(asyncResult);
        }

        #endregion
        
    }
}