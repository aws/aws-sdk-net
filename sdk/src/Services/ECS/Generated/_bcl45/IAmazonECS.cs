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
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.ECS.Model;

namespace Amazon.ECS
{
    /// <summary>
    /// Interface for accessing ECS
    ///
    /// Amazon EC2 Container Service (Amazon ECS) is a highly scalable, fast, container management
    /// service that makes it easy to run, stop, and manage Docker containers on a cluster
    /// of EC2 instances. Amazon ECS lets you launch and stop container-enabled applications
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
    public partial interface IAmazonECS : IDisposable
    {

        
        #region  CreateCluster


        /// <summary>
        /// Creates a new Amazon ECS cluster. By default, your account receives a <code>default</code>
        /// cluster when you launch your first container instance. However, you can create your
        /// own cluster with a unique name with the <code>CreateCluster</code> action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCluster service method.</param>
        /// 
        /// <returns>The response from the CreateCluster service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action, such as using an action or resource
        /// on behalf of a user that doesn't have permission to use the action or resource, or
        /// specifying an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        CreateClusterResponse CreateCluster(CreateClusterRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreateCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCluster operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateClusterResponse> CreateClusterAsync(CreateClusterRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateService


        /// <summary>
        /// Runs and maintains a desired number of tasks from a specified task definition. If
        /// the number of tasks running in a service drops below <code>desiredCount</code>, Amazon
        /// ECS spawns another instantiation of the task in the specified cluster. To update an
        /// existing service, see <a>UpdateService</a>.
        /// 
        ///  
        /// <para>
        /// In addition to maintaining the desired count of tasks in your service, you can optionally
        /// run your service behind a load balancer. The load balancer distributes traffic across
        /// the tasks that are associated with the service. For more information, see <a href="http://docs.aws.amazon.com/AmazonECS/latest/developerguide/service-load-balancing.html">Service
        /// Load Balancing</a> in the <i>Amazon EC2 Container Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can optionally specify a deployment configuration for your service. During a deployment
        /// (which is triggered by changing the task definition of a service with an <a>UpdateService</a>
        /// operation), the service scheduler uses the <code>minimumHealthyPercent</code> and
        /// <code>maximumPercent</code> parameters to determine the deployment strategy.
        /// </para>
        ///  
        /// <para>
        /// If the <code>minimumHealthyPercent</code> is below 100%, the scheduler can ignore
        /// the <code>desiredCount</code> temporarily during a deployment. For example, if your
        /// service has a <code>desiredCount</code> of four tasks, a <code>minimumHealthyPercent</code>
        /// of 50% allows the scheduler to stop two existing tasks before starting two new tasks.
        /// Tasks for services that <i>do not</i> use a load balancer are considered healthy if
        /// they are in the <code>RUNNING</code> state; tasks for services that <i>do</i> use
        /// a load balancer are considered healthy if they are in the <code>RUNNING</code> state
        /// and the container instance it is hosted on is reported as healthy by the load balancer.
        /// The default value for <code>minimumHealthyPercent</code> is 50% in the console and
        /// 100% for the AWS CLI, the AWS SDKs, and the APIs.
        /// </para>
        ///  
        /// <para>
        /// The <code>maximumPercent</code> parameter represents an upper limit on the number
        /// of running tasks during a deployment, which enables you to define the deployment batch
        /// size. For example, if your service has a <code>desiredCount</code> of four tasks,
        /// a <code>maximumPercent</code> value of 200% starts four new tasks before stopping
        /// the four older tasks (provided that the cluster resources required to do this are
        /// available). The default value for <code>maximumPercent</code> is 200%.
        /// </para>
        ///  
        /// <para>
        /// When the service scheduler launches new tasks, it attempts to balance them across
        /// the Availability Zones in your cluster with the following logic:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Determine which of the container instances in your cluster can support your service's
        /// task definition (for example, they have the required CPU, memory, ports, and container
        /// instance attributes).
        /// </para>
        ///  </li> <li> 
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
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateService service method.</param>
        /// 
        /// <returns>The response from the CreateService service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action, such as using an action or resource
        /// on behalf of a user that doesn't have permission to use the action or resource, or
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
        CreateServiceResponse CreateService(CreateServiceRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreateService operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateService operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateServiceResponse> CreateServiceAsync(CreateServiceRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// on behalf of a user that doesn't have permission to use the action or resource, or
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
        DeleteClusterResponse DeleteCluster(DeleteClusterRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCluster operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteClusterResponse> DeleteClusterAsync(DeleteClusterRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// status can still be viewed with <a>DescribeServices</a> API operations; however, in
        /// the future, <code>INACTIVE</code> services may be cleaned up and purged from Amazon
        /// ECS record keeping, and <a>DescribeServices</a> API operations on those services will
        /// return a <code>ServiceNotFoundException</code> error.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteService service method.</param>
        /// 
        /// <returns>The response from the DeleteService service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action, such as using an action or resource
        /// on behalf of a user that doesn't have permission to use the action or resource, or
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
        DeleteServiceResponse DeleteService(DeleteServiceRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteService operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteService operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteServiceResponse> DeleteServiceAsync(DeleteServiceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeregisterContainerInstance


        /// <summary>
        /// Deregisters an Amazon ECS container instance from the specified cluster. This instance
        /// is no longer available to run tasks.
        /// 
        ///  
        /// <para>
        /// If you intend to use the container instance for some other purpose after deregistration,
        /// you should stop all of the tasks running on the container instance before deregistration
        /// to avoid any orphaned tasks from consuming resources.
        /// </para>
        ///  
        /// <para>
        /// Deregistering a container instance removes the instance from a cluster, but it does
        /// not terminate the EC2 instance; if you are finished using the instance, be sure to
        /// terminate it in the Amazon EC2 console to stop billing.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you terminate a running container instance with a connected Amazon ECS container
        /// agent, the agent automatically deregisters the instance from your cluster (stopped
        /// container instances or instances with disconnected agents are not automatically deregistered
        /// when terminated).
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterContainerInstance service method.</param>
        /// 
        /// <returns>The response from the DeregisterContainerInstance service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action, such as using an action or resource
        /// on behalf of a user that doesn't have permission to use the action or resource, or
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
        DeregisterContainerInstanceResponse DeregisterContainerInstance(DeregisterContainerInstanceRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeregisterContainerInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeregisterContainerInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeregisterContainerInstanceResponse> DeregisterContainerInstanceAsync(DeregisterContainerInstanceRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// task definition (although there may be up to a 10 minute window following deregistration
        /// where these restrictions have not yet taken effect).
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterTaskDefinition service method.</param>
        /// 
        /// <returns>The response from the DeregisterTaskDefinition service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action, such as using an action or resource
        /// on behalf of a user that doesn't have permission to use the action or resource, or
        /// specifying an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        DeregisterTaskDefinitionResponse DeregisterTaskDefinition(DeregisterTaskDefinitionRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeregisterTaskDefinition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeregisterTaskDefinition operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeregisterTaskDefinitionResponse> DeregisterTaskDefinitionAsync(DeregisterTaskDefinitionRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// on behalf of a user that doesn't have permission to use the action or resource, or
        /// specifying an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        DescribeClustersResponse DescribeClusters(DescribeClustersRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeClusters operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusters operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeClustersResponse> DescribeClustersAsync(DescribeClustersRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// These errors are usually caused by a client action, such as using an action or resource
        /// on behalf of a user that doesn't have permission to use the action or resource, or
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
        DescribeContainerInstancesResponse DescribeContainerInstances(DescribeContainerInstancesRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeContainerInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeContainerInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeContainerInstancesResponse> DescribeContainerInstancesAsync(DescribeContainerInstancesRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// on behalf of a user that doesn't have permission to use the action or resource, or
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
        DescribeServicesResponse DescribeServices(DescribeServicesRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeServices operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeServices operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeServicesResponse> DescribeServicesAsync(DescribeServicesRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// on behalf of a user that doesn't have permission to use the action or resource, or
        /// specifying an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        DescribeTaskDefinitionResponse DescribeTaskDefinition(DescribeTaskDefinitionRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTaskDefinition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTaskDefinition operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeTaskDefinitionResponse> DescribeTaskDefinitionAsync(DescribeTaskDefinitionRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// on behalf of a user that doesn't have permission to use the action or resource, or
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
        DescribeTasksResponse DescribeTasks(DescribeTasksRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTasks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTasks operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeTasksResponse> DescribeTasksAsync(DescribeTasksRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// on behalf of a user that doesn't have permission to use the action or resource, or
        /// specifying an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        ListClustersResponse ListClusters(ListClustersRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ListClusters operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListClusters operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListClustersResponse> ListClustersAsync(ListClustersRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListContainerInstances


        /// <summary>
        /// Returns a list of container instances in a specified cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListContainerInstances service method.</param>
        /// 
        /// <returns>The response from the ListContainerInstances service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action, such as using an action or resource
        /// on behalf of a user that doesn't have permission to use the action or resource, or
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
        ListContainerInstancesResponse ListContainerInstances(ListContainerInstancesRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ListContainerInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListContainerInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListContainerInstancesResponse> ListContainerInstancesAsync(ListContainerInstancesRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// on behalf of a user that doesn't have permission to use the action or resource, or
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
        ListServicesResponse ListServices(ListServicesRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ListServices operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListServices operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListServicesResponse> ListServicesAsync(ListServicesRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// on behalf of a user that doesn't have permission to use the action or resource, or
        /// specifying an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        ListTaskDefinitionFamiliesResponse ListTaskDefinitionFamilies(ListTaskDefinitionFamiliesRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ListTaskDefinitionFamilies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTaskDefinitionFamilies operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListTaskDefinitionFamiliesResponse> ListTaskDefinitionFamiliesAsync(ListTaskDefinitionFamiliesRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// on behalf of a user that doesn't have permission to use the action or resource, or
        /// specifying an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        ListTaskDefinitionsResponse ListTaskDefinitions(ListTaskDefinitionsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ListTaskDefinitions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTaskDefinitions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListTaskDefinitionsResponse> ListTaskDefinitionsAsync(ListTaskDefinitionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Recently-stopped tasks might appear in the returned results. Currently, stopped tasks
        /// appear in the returned results for at least one hour. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTasks service method.</param>
        /// 
        /// <returns>The response from the ListTasks service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action, such as using an action or resource
        /// on behalf of a user that doesn't have permission to use the action or resource, or
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
        ListTasksResponse ListTasks(ListTasksRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ListTasks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTasks operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListTasksResponse> ListTasksAsync(ListTasksRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RegisterTaskDefinition


        /// <summary>
        /// Registers a new task definition from the supplied <code>family</code> and <code>containerDefinitions</code>.
        /// Optionally, you can add data volumes to your containers with the <code>volumes</code>
        /// parameter. For more information about task definition parameters and defaults, see
        /// <a href="http://docs.aws.amazon.com/AmazonECS/latest/developerguide/task_defintions.html">Amazon
        /// ECS Task Definitions</a> in the <i>Amazon EC2 Container Service Developer Guide</i>.
        /// 
        ///  
        /// <para>
        /// You can specify an IAM role for your task with the <code>taskRoleArn</code> parameter.
        /// When you specify an IAM role for a task, its containers can then use the latest versions
        /// of the AWS CLI or SDKs to make API requests to the AWS services that are specified
        /// in the IAM policy associated with the role. For more information, see <a href="http://docs.aws.amazon.com/AmazonECS/latest/developerguide/task-iam-roles.html">IAM
        /// Roles for Tasks</a> in the <i>Amazon EC2 Container Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can specify a Docker networking mode for the containers in your task definition
        /// with the <code>networkMode</code> parameter. The available network modes correspond
        /// to those described in <a href="https://docs.docker.com/engine/reference/run/#/network-settings">Network
        /// settings</a> in the Docker run reference.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterTaskDefinition service method.</param>
        /// 
        /// <returns>The response from the RegisterTaskDefinition service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action, such as using an action or resource
        /// on behalf of a user that doesn't have permission to use the action or resource, or
        /// specifying an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        RegisterTaskDefinitionResponse RegisterTaskDefinition(RegisterTaskDefinitionRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the RegisterTaskDefinition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterTaskDefinition operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<RegisterTaskDefinitionResponse> RegisterTaskDefinitionAsync(RegisterTaskDefinitionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RunTask


        /// <summary>
        /// Start a task using random placement and the default Amazon ECS scheduler. To use your
        /// own scheduler or place a task on a specific container instance, use <code>StartTask</code>
        /// instead.
        /// 
        ///  <important> 
        /// <para>
        /// The <code>count</code> parameter is limited to 10 tasks per call.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RunTask service method.</param>
        /// 
        /// <returns>The response from the RunTask service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action, such as using an action or resource
        /// on behalf of a user that doesn't have permission to use the action or resource, or
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
        RunTaskResponse RunTask(RunTaskRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the RunTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RunTask operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<RunTaskResponse> RunTaskAsync(RunTaskRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StartTask


        /// <summary>
        /// Starts a new task from the specified task definition on the specified container instance
        /// or instances. To use the default Amazon ECS scheduler to place your task, use <code>RunTask</code>
        /// instead.
        /// 
        ///  <important> 
        /// <para>
        /// The list of container instances to start tasks on is limited to 10.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartTask service method.</param>
        /// 
        /// <returns>The response from the StartTask service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action, such as using an action or resource
        /// on behalf of a user that doesn't have permission to use the action or resource, or
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
        StartTaskResponse StartTask(StartTaskRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the StartTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartTask operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<StartTaskResponse> StartTaskAsync(StartTaskRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StopTask


        /// <summary>
        /// Stops a running task.
        /// 
        ///  
        /// <para>
        /// When <a>StopTask</a> is called on a task, the equivalent of <code>docker stop</code>
        /// is issued to the containers running in the task. This results in a <code>SIGTERM</code>
        /// and a 30-second timeout, after which <code>SIGKILL</code> is sent and the containers
        /// are forcibly stopped. If the container handles the <code>SIGTERM</code> gracefully
        /// and exits within 30 seconds from receiving it, no <code>SIGKILL</code> is sent.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopTask service method.</param>
        /// 
        /// <returns>The response from the StopTask service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action, such as using an action or resource
        /// on behalf of a user that doesn't have permission to use the action or resource, or
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
        StopTaskResponse StopTask(StopTaskRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the StopTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopTask operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<StopTaskResponse> StopTaskAsync(StopTaskRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Updating the Amazon ECS Container Agent</a> in the <i>Amazon EC2 Container Service
        /// Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateContainerAgent service method.</param>
        /// 
        /// <returns>The response from the UpdateContainerAgent service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action, such as using an action or resource
        /// on behalf of a user that doesn't have permission to use the action or resource, or
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
        UpdateContainerAgentResponse UpdateContainerAgent(UpdateContainerAgentRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateContainerAgent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateContainerAgent operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<UpdateContainerAgentResponse> UpdateContainerAgentAsync(UpdateContainerAgentRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateService


        /// <summary>
        /// Modifies the desired count, deployment configuration, or task definition used in a
        /// service.
        /// 
        ///  
        /// <para>
        /// You can add to or subtract from the number of instantiations of a task definition
        /// in a service by specifying the cluster that the service is running in and a new <code>desiredCount</code>
        /// parameter.
        /// </para>
        ///  
        /// <para>
        /// You can use <a>UpdateService</a> to modify your task definition and deploy a new version
        /// of your service.
        /// </para>
        ///  
        /// <para>
        /// You can also update the deployment configuration of a service. When a deployment is
        /// triggered by updating the task definition of a service, the service scheduler uses
        /// the deployment configuration parameters, <code>minimumHealthyPercent</code> and <code>maximumPercent</code>,
        /// to determine the deployment strategy.
        /// </para>
        ///  
        /// <para>
        /// If the <code>minimumHealthyPercent</code> is below 100%, the scheduler can ignore
        /// the <code>desiredCount</code> temporarily during a deployment. For example, if your
        /// service has a <code>desiredCount</code> of four tasks, a <code>minimumHealthyPercent</code>
        /// of 50% allows the scheduler to stop two existing tasks before starting two new tasks.
        /// Tasks for services that <i>do not</i> use a load balancer are considered healthy if
        /// they are in the <code>RUNNING</code> state; tasks for services that <i>do</i> use
        /// a load balancer are considered healthy if they are in the <code>RUNNING</code> state
        /// and the container instance it is hosted on is reported as healthy by the load balancer.
        /// </para>
        ///  
        /// <para>
        /// The <code>maximumPercent</code> parameter represents an upper limit on the number
        /// of running tasks during a deployment, which enables you to define the deployment batch
        /// size. For example, if your service has a <code>desiredCount</code> of four tasks,
        /// a <code>maximumPercent</code> value of 200% starts four new tasks before stopping
        /// the four older tasks (provided that the cluster resources required to do this are
        /// available).
        /// </para>
        ///  
        /// <para>
        /// When <a>UpdateService</a> stops a task during a deployment, the equivalent of <code>docker
        /// stop</code> is issued to the containers running in the task. This results in a <code>SIGTERM</code>
        /// and a 30-second timeout, after which <code>SIGKILL</code> is sent and the containers
        /// are forcibly stopped. If the container handles the <code>SIGTERM</code> gracefully
        /// and exits within 30 seconds from receiving it, no <code>SIGKILL</code> is sent.
        /// </para>
        ///  
        /// <para>
        /// When the service scheduler launches new tasks, it attempts to balance them across
        /// the Availability Zones in your cluster with the following logic:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Determine which of the container instances in your cluster can support your service's
        /// task definition (for example, they have the required CPU, memory, ports, and container
        /// instance attributes).
        /// </para>
        ///  </li> <li> 
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
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateService service method.</param>
        /// 
        /// <returns>The response from the UpdateService service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action, such as using an action or resource
        /// on behalf of a user that doesn't have permission to use the action or resource, or
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
        /// <exception cref="Amazon.ECS.Model.ServiceNotActiveException">
        /// The specified service is not active. You cannot update a service that is not active.
        /// If you have previously deleted a service, you can re-create it with <a>CreateService</a>.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServiceNotFoundException">
        /// The specified service could not be found. You can view your available services with
        /// <a>ListServices</a>. Amazon ECS services are cluster-specific and region-specific.
        /// </exception>
        UpdateServiceResponse UpdateService(UpdateServiceRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateService operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateService operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<UpdateServiceResponse> UpdateServiceAsync(UpdateServiceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}