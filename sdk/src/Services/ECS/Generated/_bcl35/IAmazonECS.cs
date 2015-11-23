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
        /// <param name="request">Container for the necessary parameters to execute the CreateCluster operation on AmazonECSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateCluster
        ///         operation.</returns>
        IAsyncResult BeginCreateCluster(CreateClusterRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateCluster operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCluster.</param>
        /// 
        /// <returns>Returns a  CreateClusterResult from ECS.</returns>
        CreateClusterResponse EndCreateCluster(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the CreateService operation on AmazonECSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateService
        ///         operation.</returns>
        IAsyncResult BeginCreateService(CreateServiceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateService operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateService.</param>
        /// 
        /// <returns>Returns a  CreateServiceResult from ECS.</returns>
        CreateServiceResponse EndCreateService(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the DeleteCluster operation on AmazonECSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteCluster
        ///         operation.</returns>
        IAsyncResult BeginDeleteCluster(DeleteClusterRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteCluster operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCluster.</param>
        /// 
        /// <returns>Returns a  DeleteClusterResult from ECS.</returns>
        DeleteClusterResponse EndDeleteCluster(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the DeleteService operation on AmazonECSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteService
        ///         operation.</returns>
        IAsyncResult BeginDeleteService(DeleteServiceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteService operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteService.</param>
        /// 
        /// <returns>Returns a  DeleteServiceResult from ECS.</returns>
        DeleteServiceResponse EndDeleteService(IAsyncResult asyncResult);

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
        /// When you terminate a container instance, it is automatically deregistered from your
        /// cluster.
        /// </para>
        /// </note>
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
        /// <param name="request">Container for the necessary parameters to execute the DeregisterContainerInstance operation on AmazonECSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeregisterContainerInstance
        ///         operation.</returns>
        IAsyncResult BeginDeregisterContainerInstance(DeregisterContainerInstanceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeregisterContainerInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeregisterContainerInstance.</param>
        /// 
        /// <returns>Returns a  DeregisterContainerInstanceResult from ECS.</returns>
        DeregisterContainerInstanceResponse EndDeregisterContainerInstance(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the DeregisterTaskDefinition operation on AmazonECSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeregisterTaskDefinition
        ///         operation.</returns>
        IAsyncResult BeginDeregisterTaskDefinition(DeregisterTaskDefinitionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeregisterTaskDefinition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeregisterTaskDefinition.</param>
        /// 
        /// <returns>Returns a  DeregisterTaskDefinitionResult from ECS.</returns>
        DeregisterTaskDefinitionResponse EndDeregisterTaskDefinition(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusters operation on AmazonECSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeClusters
        ///         operation.</returns>
        IAsyncResult BeginDescribeClusters(DescribeClustersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeClusters operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeClusters.</param>
        /// 
        /// <returns>Returns a  DescribeClustersResult from ECS.</returns>
        DescribeClustersResponse EndDescribeClusters(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the DescribeContainerInstances operation on AmazonECSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeContainerInstances
        ///         operation.</returns>
        IAsyncResult BeginDescribeContainerInstances(DescribeContainerInstancesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeContainerInstances operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeContainerInstances.</param>
        /// 
        /// <returns>Returns a  DescribeContainerInstancesResult from ECS.</returns>
        DescribeContainerInstancesResponse EndDescribeContainerInstances(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the DescribeServices operation on AmazonECSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeServices
        ///         operation.</returns>
        IAsyncResult BeginDescribeServices(DescribeServicesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeServices operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeServices.</param>
        /// 
        /// <returns>Returns a  DescribeServicesResult from ECS.</returns>
        DescribeServicesResponse EndDescribeServices(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the DescribeTaskDefinition operation on AmazonECSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeTaskDefinition
        ///         operation.</returns>
        IAsyncResult BeginDescribeTaskDefinition(DescribeTaskDefinitionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeTaskDefinition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeTaskDefinition.</param>
        /// 
        /// <returns>Returns a  DescribeTaskDefinitionResult from ECS.</returns>
        DescribeTaskDefinitionResponse EndDescribeTaskDefinition(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the DescribeTasks operation on AmazonECSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeTasks
        ///         operation.</returns>
        IAsyncResult BeginDescribeTasks(DescribeTasksRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeTasks operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeTasks.</param>
        /// 
        /// <returns>Returns a  DescribeTasksResult from ECS.</returns>
        DescribeTasksResponse EndDescribeTasks(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the ListClusters operation on AmazonECSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListClusters
        ///         operation.</returns>
        IAsyncResult BeginListClusters(ListClustersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListClusters operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListClusters.</param>
        /// 
        /// <returns>Returns a  ListClustersResult from ECS.</returns>
        ListClustersResponse EndListClusters(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the ListContainerInstances operation on AmazonECSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListContainerInstances
        ///         operation.</returns>
        IAsyncResult BeginListContainerInstances(ListContainerInstancesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListContainerInstances operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListContainerInstances.</param>
        /// 
        /// <returns>Returns a  ListContainerInstancesResult from ECS.</returns>
        ListContainerInstancesResponse EndListContainerInstances(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the ListServices operation on AmazonECSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListServices
        ///         operation.</returns>
        IAsyncResult BeginListServices(ListServicesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListServices operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListServices.</param>
        /// 
        /// <returns>Returns a  ListServicesResult from ECS.</returns>
        ListServicesResponse EndListServices(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTaskDefinitionFamilies


        /// <summary>
        /// Returns a list of task definition families that are registered to your account (which
        /// may include task definition families that no longer have any <code>ACTIVE</code> task
        /// definitions). You can filter the results with the <code>familyPrefix</code> parameter.
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
        /// <param name="request">Container for the necessary parameters to execute the ListTaskDefinitionFamilies operation on AmazonECSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTaskDefinitionFamilies
        ///         operation.</returns>
        IAsyncResult BeginListTaskDefinitionFamilies(ListTaskDefinitionFamiliesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTaskDefinitionFamilies operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTaskDefinitionFamilies.</param>
        /// 
        /// <returns>Returns a  ListTaskDefinitionFamiliesResult from ECS.</returns>
        ListTaskDefinitionFamiliesResponse EndListTaskDefinitionFamilies(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the ListTaskDefinitions operation on AmazonECSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTaskDefinitions
        ///         operation.</returns>
        IAsyncResult BeginListTaskDefinitions(ListTaskDefinitionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTaskDefinitions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTaskDefinitions.</param>
        /// 
        /// <returns>Returns a  ListTaskDefinitionsResult from ECS.</returns>
        ListTaskDefinitionsResponse EndListTaskDefinitions(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTasks


        /// <summary>
        /// Returns a list of tasks for a specified cluster. You can filter the results by family
        /// name, by a particular container instance, or by the desired status of the task with
        /// the <code>family</code>, <code>containerInstance</code>, and <code>desiredStatus</code>
        /// parameters.
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
        /// <param name="request">Container for the necessary parameters to execute the ListTasks operation on AmazonECSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTasks
        ///         operation.</returns>
        IAsyncResult BeginListTasks(ListTasksRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTasks operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTasks.</param>
        /// 
        /// <returns>Returns a  ListTasksResult from ECS.</returns>
        ListTasksResponse EndListTasks(IAsyncResult asyncResult);

        #endregion
        
        #region  RegisterTaskDefinition


        /// <summary>
        /// Registers a new task definition from the supplied <code>family</code> and <code>containerDefinitions</code>.
        /// Optionally, you can add data volumes to your containers with the <code>volumes</code>
        /// parameter. For more information about task definition parameters and defaults, see
        /// <a href="http://docs.aws.amazon.com/AmazonECS/latest/developerguide/task_defintions.html">Amazon
        /// ECS Task Definitions</a> in the <i>Amazon EC2 Container Service Developer Guide</i>.
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
        /// <param name="request">Container for the necessary parameters to execute the RegisterTaskDefinition operation on AmazonECSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRegisterTaskDefinition
        ///         operation.</returns>
        IAsyncResult BeginRegisterTaskDefinition(RegisterTaskDefinitionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RegisterTaskDefinition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRegisterTaskDefinition.</param>
        /// 
        /// <returns>Returns a  RegisterTaskDefinitionResult from ECS.</returns>
        RegisterTaskDefinitionResponse EndRegisterTaskDefinition(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the RunTask operation on AmazonECSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRunTask
        ///         operation.</returns>
        IAsyncResult BeginRunTask(RunTaskRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RunTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRunTask.</param>
        /// 
        /// <returns>Returns a  RunTaskResult from ECS.</returns>
        RunTaskResponse EndRunTask(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the StartTask operation on AmazonECSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartTask
        ///         operation.</returns>
        IAsyncResult BeginStartTask(StartTaskRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartTask.</param>
        /// 
        /// <returns>Returns a  StartTaskResult from ECS.</returns>
        StartTaskResponse EndStartTask(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the StopTask operation on AmazonECSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopTask
        ///         operation.</returns>
        IAsyncResult BeginStopTask(StopTaskRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StopTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopTask.</param>
        /// 
        /// <returns>Returns a  StopTaskResult from ECS.</returns>
        StopTaskResponse EndStopTask(IAsyncResult asyncResult);

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
        /// <code>UpdateContainerAgent</code> requires the Amazon ECS-optimized AMI or Amazon
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
        /// <param name="request">Container for the necessary parameters to execute the UpdateContainerAgent operation on AmazonECSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateContainerAgent
        ///         operation.</returns>
        IAsyncResult BeginUpdateContainerAgent(UpdateContainerAgentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateContainerAgent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateContainerAgent.</param>
        /// 
        /// <returns>Returns a  UpdateContainerAgentResult from ECS.</returns>
        UpdateContainerAgentResponse EndUpdateContainerAgent(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateService


        /// <summary>
        /// Modify the desired count or task definition used in a service.
        /// 
        ///  
        /// <para>
        /// You can add to or subtract from the number of instantiations of a task definition
        /// in a service by specifying the cluster that the service is running in and a new <code>desiredCount</code>
        /// parameter.
        /// </para>
        ///  
        /// <para>
        /// You can use <code>UpdateService</code> to modify your task definition and deploy a
        /// new version of your service, one task at a time. If you modify the task definition
        /// with <code>UpdateService</code>, Amazon ECS spawns a task with the new version of
        /// the task definition and then stops an old task after the new version is running. Because
        /// <code>UpdateService</code> starts a new version of the task before stopping an old
        /// version, your cluster must have capacity to support one more instantiation of the
        /// task when <code>UpdateService</code> is run. If your cluster cannot support another
        /// instantiation of the task used in your service, you can reduce the desired count of
        /// your service by one before modifying the task definition.
        /// </para>
        ///  
        /// <para>
        /// When <a>UpdateService</a> replaces a task during an update, the equivalent of <code>docker
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
        /// <param name="request">Container for the necessary parameters to execute the UpdateService operation on AmazonECSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateService
        ///         operation.</returns>
        IAsyncResult BeginUpdateService(UpdateServiceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateService operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateService.</param>
        /// 
        /// <returns>Returns a  UpdateServiceResult from ECS.</returns>
        UpdateServiceResponse EndUpdateService(IAsyncResult asyncResult);

        #endregion
        
    }
}