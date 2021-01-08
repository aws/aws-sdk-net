/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.ECS.Model;

namespace Amazon.ECS
{
    /// <summary>
    /// Interface for accessing ECS
    ///
    /// Amazon Elastic Container Service 
    /// <para>
    /// Amazon Elastic Container Service (Amazon ECS) is a highly scalable, fast, container
    /// management service that makes it easy to run, stop, and manage Docker containers on
    /// a cluster. You can host your cluster on a serverless infrastructure that is managed
    /// by Amazon ECS by launching your services or tasks using the Fargate launch type. For
    /// more control, you can host your tasks on a cluster of Amazon Elastic Compute Cloud
    /// (Amazon EC2) instances that you manage by using the EC2 launch type. For more information
    /// about launch types, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/launch_types.html">Amazon
    /// ECS Launch Types</a>.
    /// </para>
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
    public partial interface IAmazonECS : IAmazonService, IDisposable
    {

        /// <summary>
        /// Paginators for the service
        /// </summary>
        IECSPaginatorFactory Paginators { get; }

        
        #region  CreateCapacityProvider


        /// <summary>
        /// Creates a new capacity provider. Capacity providers are associated with an Amazon
        /// ECS cluster and are used in capacity provider strategies to facilitate cluster auto
        /// scaling.
        /// 
        ///  
        /// <para>
        /// Only capacity providers using an Auto Scaling group can be created. Amazon ECS tasks
        /// on AWS Fargate use the <code>FARGATE</code> and <code>FARGATE_SPOT</code> capacity
        /// providers which are already created and available to all accounts in Regions supported
        /// by AWS Fargate.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCapacityProvider service method.</param>
        /// 
        /// <returns>The response from the CreateCapacityProvider service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action, such as using an action or resource
        /// on behalf of a user that doesn't have permissions to use the action or resource, or
        /// specifying an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.LimitExceededException">
        /// The limit for the resource has been exceeded.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/CreateCapacityProvider">REST API Reference for CreateCapacityProvider Operation</seealso>
        CreateCapacityProviderResponse CreateCapacityProvider(CreateCapacityProviderRequest request);



        /// <summary>
        /// Creates a new capacity provider. Capacity providers are associated with an Amazon
        /// ECS cluster and are used in capacity provider strategies to facilitate cluster auto
        /// scaling.
        /// 
        ///  
        /// <para>
        /// Only capacity providers using an Auto Scaling group can be created. Amazon ECS tasks
        /// on AWS Fargate use the <code>FARGATE</code> and <code>FARGATE_SPOT</code> capacity
        /// providers which are already created and available to all accounts in Regions supported
        /// by AWS Fargate.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCapacityProvider service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateCapacityProvider service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action, such as using an action or resource
        /// on behalf of a user that doesn't have permissions to use the action or resource, or
        /// specifying an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.LimitExceededException">
        /// The limit for the resource has been exceeded.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/CreateCapacityProvider">REST API Reference for CreateCapacityProvider Operation</seealso>
        Task<CreateCapacityProviderResponse> CreateCapacityProviderAsync(CreateCapacityProviderRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// the Amazon ECS service-linked role for your account so that required resources in
        /// other AWS services can be managed on your behalf. However, if the IAM user that makes
        /// the call does not have permissions to create the service-linked role, it is not created.
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/using-service-linked-roles.html">Using
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
        CreateClusterResponse CreateCluster(CreateClusterRequest request);



        /// <summary>
        /// Creates a new Amazon ECS cluster. By default, your account receives a <code>default</code>
        /// cluster when you launch your first container instance. However, you can create your
        /// own cluster with a unique name with the <code>CreateCluster</code> action.
        /// 
        ///  <note> 
        /// <para>
        /// When you call the <a>CreateCluster</a> API operation, Amazon ECS attempts to create
        /// the Amazon ECS service-linked role for your account so that required resources in
        /// other AWS services can be managed on your behalf. However, if the IAM user that makes
        /// the call does not have permissions to create the service-linked role, it is not created.
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/using-service-linked-roles.html">Using
        /// Service-Linked Roles for Amazon ECS</a> in the <i>Amazon Elastic Container Service
        /// Developer Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateClusterResponse> CreateClusterAsync(CreateClusterRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateService


        /// <summary>
        /// Runs and maintains a desired number of tasks from a specified task definition. If
        /// the number of tasks running in a service drops below the <code>desiredCount</code>,
        /// Amazon ECS runs another copy of the task in the specified cluster. To update an existing
        /// service, see the UpdateService action.
        /// 
        ///  
        /// <para>
        /// In addition to maintaining the desired count of tasks in your service, you can optionally
        /// run your service behind one or more load balancers. The load balancers distribute
        /// traffic across the tasks that are associated with the service. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/service-load-balancing.html">Service
        /// Load Balancing</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Tasks for services that <i>do not</i> use a load balancer are considered healthy if
        /// they're in the <code>RUNNING</code> state. Tasks for services that <i>do</i> use a
        /// load balancer are considered healthy if they're in the <code>RUNNING</code> state
        /// and the container instance that they're hosted on is reported as healthy by the load
        /// balancer.
        /// </para>
        ///  
        /// <para>
        /// There are two service scheduler strategies available:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>REPLICA</code> - The replica scheduling strategy places and maintains the desired
        /// number of tasks across your cluster. By default, the service scheduler spreads tasks
        /// across Availability Zones. You can use task placement strategies and constraints to
        /// customize task placement decisions. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/ecs_services.html">Service
        /// Scheduler Concepts</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DAEMON</code> - The daemon scheduling strategy deploys exactly one task on
        /// each active container instance that meets all of the task placement constraints that
        /// you specify in your cluster. The service scheduler also evaluates the task placement
        /// constraints for running tasks and will stop tasks that do not meet the placement constraints.
        /// When using this strategy, you don't need to specify a desired number of tasks, a task
        /// placement strategy, or use Service Auto Scaling policies. For more information, see
        /// <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/ecs_services.html">Service
        /// Scheduler Concepts</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You can optionally specify a deployment configuration for your service. The deployment
        /// is triggered by changing properties, such as the task definition or the desired count
        /// of a service, with an <a>UpdateService</a> operation. The default value for a replica
        /// service for <code>minimumHealthyPercent</code> is 100%. The default value for a daemon
        /// service for <code>minimumHealthyPercent</code> is 0%.
        /// </para>
        ///  
        /// <para>
        /// If a service is using the <code>ECS</code> deployment controller, the minimum healthy
        /// percent represents a lower limit on the number of tasks in a service that must remain
        /// in the <code>RUNNING</code> state during a deployment, as a percentage of the desired
        /// number of tasks (rounded up to the nearest integer), and while any container instances
        /// are in the <code>DRAINING</code> state if the service contains tasks using the EC2
        /// launch type. This parameter enables you to deploy without using additional cluster
        /// capacity. For example, if your service has a desired number of four tasks and a minimum
        /// healthy percent of 50%, the scheduler might stop two existing tasks to free up cluster
        /// capacity before starting two new tasks. Tasks for services that <i>do not</i> use
        /// a load balancer are considered healthy if they're in the <code>RUNNING</code> state.
        /// Tasks for services that <i>do</i> use a load balancer are considered healthy if they're
        /// in the <code>RUNNING</code> state and they're reported as healthy by the load balancer.
        /// The default value for minimum healthy percent is 100%.
        /// </para>
        ///  
        /// <para>
        /// If a service is using the <code>ECS</code> deployment controller, the <b>maximum percent</b>
        /// parameter represents an upper limit on the number of tasks in a service that are allowed
        /// in the <code>RUNNING</code> or <code>PENDING</code> state during a deployment, as
        /// a percentage of the desired number of tasks (rounded down to the nearest integer),
        /// and while any container instances are in the <code>DRAINING</code> state if the service
        /// contains tasks using the EC2 launch type. This parameter enables you to define the
        /// deployment batch size. For example, if your service has a desired number of four tasks
        /// and a maximum percent value of 200%, the scheduler may start four new tasks before
        /// stopping the four older tasks (provided that the cluster resources required to do
        /// this are available). The default value for maximum percent is 200%.
        /// </para>
        ///  
        /// <para>
        /// If a service is using either the <code>CODE_DEPLOY</code> or <code>EXTERNAL</code>
        /// deployment controller types and tasks that use the EC2 launch type, the <b>minimum
        /// healthy percent</b> and <b>maximum percent</b> values are used only to define the
        /// lower and upper limit on the number of the tasks in the service that remain in the
        /// <code>RUNNING</code> state while the container instances are in the <code>DRAINING</code>
        /// state. If the tasks in the service use the Fargate launch type, the minimum healthy
        /// percent and maximum percent values aren't used, although they're currently visible
        /// when describing your service.
        /// </para>
        ///  
        /// <para>
        /// When creating a service that uses the <code>EXTERNAL</code> deployment controller,
        /// you can specify only parameters that aren't controlled at the task set level. The
        /// only required parameter is the service name. You control your services using the <a>CreateTaskSet</a>
        /// operation. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/deployment-types.html">Amazon
        /// ECS Deployment Types</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
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
        /// <a>ListClusters</a>. Amazon ECS clusters are Region-specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.PlatformTaskDefinitionIncompatibilityException">
        /// The specified platform version does not satisfy the task definition's required capabilities.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.PlatformUnknownException">
        /// The specified platform version does not exist.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.UnsupportedFeatureException">
        /// The specified task is not supported in this Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/CreateService">REST API Reference for CreateService Operation</seealso>
        CreateServiceResponse CreateService(CreateServiceRequest request);



        /// <summary>
        /// Runs and maintains a desired number of tasks from a specified task definition. If
        /// the number of tasks running in a service drops below the <code>desiredCount</code>,
        /// Amazon ECS runs another copy of the task in the specified cluster. To update an existing
        /// service, see the UpdateService action.
        /// 
        ///  
        /// <para>
        /// In addition to maintaining the desired count of tasks in your service, you can optionally
        /// run your service behind one or more load balancers. The load balancers distribute
        /// traffic across the tasks that are associated with the service. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/service-load-balancing.html">Service
        /// Load Balancing</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Tasks for services that <i>do not</i> use a load balancer are considered healthy if
        /// they're in the <code>RUNNING</code> state. Tasks for services that <i>do</i> use a
        /// load balancer are considered healthy if they're in the <code>RUNNING</code> state
        /// and the container instance that they're hosted on is reported as healthy by the load
        /// balancer.
        /// </para>
        ///  
        /// <para>
        /// There are two service scheduler strategies available:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>REPLICA</code> - The replica scheduling strategy places and maintains the desired
        /// number of tasks across your cluster. By default, the service scheduler spreads tasks
        /// across Availability Zones. You can use task placement strategies and constraints to
        /// customize task placement decisions. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/ecs_services.html">Service
        /// Scheduler Concepts</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DAEMON</code> - The daemon scheduling strategy deploys exactly one task on
        /// each active container instance that meets all of the task placement constraints that
        /// you specify in your cluster. The service scheduler also evaluates the task placement
        /// constraints for running tasks and will stop tasks that do not meet the placement constraints.
        /// When using this strategy, you don't need to specify a desired number of tasks, a task
        /// placement strategy, or use Service Auto Scaling policies. For more information, see
        /// <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/ecs_services.html">Service
        /// Scheduler Concepts</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You can optionally specify a deployment configuration for your service. The deployment
        /// is triggered by changing properties, such as the task definition or the desired count
        /// of a service, with an <a>UpdateService</a> operation. The default value for a replica
        /// service for <code>minimumHealthyPercent</code> is 100%. The default value for a daemon
        /// service for <code>minimumHealthyPercent</code> is 0%.
        /// </para>
        ///  
        /// <para>
        /// If a service is using the <code>ECS</code> deployment controller, the minimum healthy
        /// percent represents a lower limit on the number of tasks in a service that must remain
        /// in the <code>RUNNING</code> state during a deployment, as a percentage of the desired
        /// number of tasks (rounded up to the nearest integer), and while any container instances
        /// are in the <code>DRAINING</code> state if the service contains tasks using the EC2
        /// launch type. This parameter enables you to deploy without using additional cluster
        /// capacity. For example, if your service has a desired number of four tasks and a minimum
        /// healthy percent of 50%, the scheduler might stop two existing tasks to free up cluster
        /// capacity before starting two new tasks. Tasks for services that <i>do not</i> use
        /// a load balancer are considered healthy if they're in the <code>RUNNING</code> state.
        /// Tasks for services that <i>do</i> use a load balancer are considered healthy if they're
        /// in the <code>RUNNING</code> state and they're reported as healthy by the load balancer.
        /// The default value for minimum healthy percent is 100%.
        /// </para>
        ///  
        /// <para>
        /// If a service is using the <code>ECS</code> deployment controller, the <b>maximum percent</b>
        /// parameter represents an upper limit on the number of tasks in a service that are allowed
        /// in the <code>RUNNING</code> or <code>PENDING</code> state during a deployment, as
        /// a percentage of the desired number of tasks (rounded down to the nearest integer),
        /// and while any container instances are in the <code>DRAINING</code> state if the service
        /// contains tasks using the EC2 launch type. This parameter enables you to define the
        /// deployment batch size. For example, if your service has a desired number of four tasks
        /// and a maximum percent value of 200%, the scheduler may start four new tasks before
        /// stopping the four older tasks (provided that the cluster resources required to do
        /// this are available). The default value for maximum percent is 200%.
        /// </para>
        ///  
        /// <para>
        /// If a service is using either the <code>CODE_DEPLOY</code> or <code>EXTERNAL</code>
        /// deployment controller types and tasks that use the EC2 launch type, the <b>minimum
        /// healthy percent</b> and <b>maximum percent</b> values are used only to define the
        /// lower and upper limit on the number of the tasks in the service that remain in the
        /// <code>RUNNING</code> state while the container instances are in the <code>DRAINING</code>
        /// state. If the tasks in the service use the Fargate launch type, the minimum healthy
        /// percent and maximum percent values aren't used, although they're currently visible
        /// when describing your service.
        /// </para>
        ///  
        /// <para>
        /// When creating a service that uses the <code>EXTERNAL</code> deployment controller,
        /// you can specify only parameters that aren't controlled at the task set level. The
        /// only required parameter is the service name. You control your services using the <a>CreateTaskSet</a>
        /// operation. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/deployment-types.html">Amazon
        /// ECS Deployment Types</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// <a>ListClusters</a>. Amazon ECS clusters are Region-specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.PlatformTaskDefinitionIncompatibilityException">
        /// The specified platform version does not satisfy the task definition's required capabilities.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.PlatformUnknownException">
        /// The specified platform version does not exist.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.UnsupportedFeatureException">
        /// The specified task is not supported in this Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/CreateService">REST API Reference for CreateService Operation</seealso>
        Task<CreateServiceResponse> CreateServiceAsync(CreateServiceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateTaskSet


        /// <summary>
        /// Create a task set in the specified cluster and service. This is used when a service
        /// uses the <code>EXTERNAL</code> deployment controller type. For more information, see
        /// <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/deployment-types.html">Amazon
        /// ECS Deployment Types</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTaskSet service method.</param>
        /// 
        /// <returns>The response from the CreateTaskSet service method, as returned by ECS.</returns>
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
        /// <a>ListClusters</a>. Amazon ECS clusters are Region-specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.PlatformTaskDefinitionIncompatibilityException">
        /// The specified platform version does not satisfy the task definition's required capabilities.
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
        /// <a>ListServices</a>. Amazon ECS services are cluster-specific and Region-specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.UnsupportedFeatureException">
        /// The specified task is not supported in this Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/CreateTaskSet">REST API Reference for CreateTaskSet Operation</seealso>
        CreateTaskSetResponse CreateTaskSet(CreateTaskSetRequest request);



        /// <summary>
        /// Create a task set in the specified cluster and service. This is used when a service
        /// uses the <code>EXTERNAL</code> deployment controller type. For more information, see
        /// <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/deployment-types.html">Amazon
        /// ECS Deployment Types</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTaskSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateTaskSet service method, as returned by ECS.</returns>
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
        /// <a>ListClusters</a>. Amazon ECS clusters are Region-specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.PlatformTaskDefinitionIncompatibilityException">
        /// The specified platform version does not satisfy the task definition's required capabilities.
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
        /// <a>ListServices</a>. Amazon ECS services are cluster-specific and Region-specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.UnsupportedFeatureException">
        /// The specified task is not supported in this Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/CreateTaskSet">REST API Reference for CreateTaskSet Operation</seealso>
        Task<CreateTaskSetResponse> CreateTaskSetAsync(CreateTaskSetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteAccountSetting


        /// <summary>
        /// Disables an account setting for a specified IAM user, IAM role, or the root user for
        /// an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccountSetting service method.</param>
        /// 
        /// <returns>The response from the DeleteAccountSetting service method, as returned by ECS.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/DeleteAccountSetting">REST API Reference for DeleteAccountSetting Operation</seealso>
        DeleteAccountSettingResponse DeleteAccountSetting(DeleteAccountSettingRequest request);



        /// <summary>
        /// Disables an account setting for a specified IAM user, IAM role, or the root user for
        /// an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccountSetting service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAccountSetting service method, as returned by ECS.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/DeleteAccountSetting">REST API Reference for DeleteAccountSetting Operation</seealso>
        Task<DeleteAccountSettingResponse> DeleteAccountSettingAsync(DeleteAccountSettingRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <a>ListClusters</a>. Amazon ECS clusters are Region-specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.TargetNotFoundException">
        /// The specified target could not be found. You can view your available container instances
        /// with <a>ListContainerInstances</a>. Amazon ECS container instances are cluster-specific
        /// and Region-specific.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/DeleteAttributes">REST API Reference for DeleteAttributes Operation</seealso>
        DeleteAttributesResponse DeleteAttributes(DeleteAttributesRequest request);



        /// <summary>
        /// Deletes one or more custom attributes from an Amazon ECS resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAttributes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAttributes service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClusterNotFoundException">
        /// The specified cluster could not be found. You can view your available clusters with
        /// <a>ListClusters</a>. Amazon ECS clusters are Region-specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.TargetNotFoundException">
        /// The specified target could not be found. You can view your available container instances
        /// with <a>ListContainerInstances</a>. Amazon ECS container instances are cluster-specific
        /// and Region-specific.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/DeleteAttributes">REST API Reference for DeleteAttributes Operation</seealso>
        Task<DeleteAttributesResponse> DeleteAttributesAsync(DeleteAttributesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteCapacityProvider


        /// <summary>
        /// Deletes the specified capacity provider.
        /// 
        ///  <note> 
        /// <para>
        /// The <code>FARGATE</code> and <code>FARGATE_SPOT</code> capacity providers are reserved
        /// and cannot be deleted. You can disassociate them from a cluster using either the <a>PutClusterCapacityProviders</a>
        /// API or by deleting the cluster.
        /// </para>
        ///  </note> 
        /// <para>
        /// Prior to a capacity provider being deleted, the capacity provider must be removed
        /// from the capacity provider strategy from all services. The <a>UpdateService</a> API
        /// can be used to remove a capacity provider from a service's capacity provider strategy.
        /// When updating a service, the <code>forceNewDeployment</code> option can be used to
        /// ensure that any tasks using the Amazon EC2 instance capacity provided by the capacity
        /// provider are transitioned to use the capacity from the remaining capacity providers.
        /// Only capacity providers that are not associated with a cluster can be deleted. To
        /// remove a capacity provider from a cluster, you can either use <a>PutClusterCapacityProviders</a>
        /// or delete the cluster.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCapacityProvider service method.</param>
        /// 
        /// <returns>The response from the DeleteCapacityProvider service method, as returned by ECS.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/DeleteCapacityProvider">REST API Reference for DeleteCapacityProvider Operation</seealso>
        DeleteCapacityProviderResponse DeleteCapacityProvider(DeleteCapacityProviderRequest request);



        /// <summary>
        /// Deletes the specified capacity provider.
        /// 
        ///  <note> 
        /// <para>
        /// The <code>FARGATE</code> and <code>FARGATE_SPOT</code> capacity providers are reserved
        /// and cannot be deleted. You can disassociate them from a cluster using either the <a>PutClusterCapacityProviders</a>
        /// API or by deleting the cluster.
        /// </para>
        ///  </note> 
        /// <para>
        /// Prior to a capacity provider being deleted, the capacity provider must be removed
        /// from the capacity provider strategy from all services. The <a>UpdateService</a> API
        /// can be used to remove a capacity provider from a service's capacity provider strategy.
        /// When updating a service, the <code>forceNewDeployment</code> option can be used to
        /// ensure that any tasks using the Amazon EC2 instance capacity provided by the capacity
        /// provider are transitioned to use the capacity from the remaining capacity providers.
        /// Only capacity providers that are not associated with a cluster can be deleted. To
        /// remove a capacity provider from a cluster, you can either use <a>PutClusterCapacityProviders</a>
        /// or delete the cluster.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCapacityProvider service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteCapacityProvider service method, as returned by ECS.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/DeleteCapacityProvider">REST API Reference for DeleteCapacityProvider Operation</seealso>
        Task<DeleteCapacityProviderResponse> DeleteCapacityProviderAsync(DeleteCapacityProviderRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteCluster


        /// <summary>
        /// Deletes the specified cluster. The cluster will transition to the <code>INACTIVE</code>
        /// state. Clusters with an <code>INACTIVE</code> status may remain discoverable in your
        /// account for a period of time. However, this behavior is subject to change in the future,
        /// so you should not rely on <code>INACTIVE</code> clusters persisting.
        /// 
        ///  
        /// <para>
        /// You must deregister all container instances from this cluster before you may delete
        /// it. You can list the container instances in a cluster with <a>ListContainerInstances</a>
        /// and deregister them with <a>DeregisterContainerInstance</a>.
        /// </para>
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
        /// You cannot delete a cluster that has registered container instances. First, deregister
        /// the container instances before you can delete the cluster. For more information, see
        /// <a>DeregisterContainerInstance</a>.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClusterContainsServicesException">
        /// You cannot delete a cluster that contains services. First, update the service to reduce
        /// its desired task count to 0 and then delete the service. For more information, see
        /// <a>UpdateService</a> and <a>DeleteService</a>.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClusterContainsTasksException">
        /// You cannot delete a cluster that has active tasks.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClusterNotFoundException">
        /// The specified cluster could not be found. You can view your available clusters with
        /// <a>ListClusters</a>. Amazon ECS clusters are Region-specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/DeleteCluster">REST API Reference for DeleteCluster Operation</seealso>
        DeleteClusterResponse DeleteCluster(DeleteClusterRequest request);



        /// <summary>
        /// Deletes the specified cluster. The cluster will transition to the <code>INACTIVE</code>
        /// state. Clusters with an <code>INACTIVE</code> status may remain discoverable in your
        /// account for a period of time. However, this behavior is subject to change in the future,
        /// so you should not rely on <code>INACTIVE</code> clusters persisting.
        /// 
        ///  
        /// <para>
        /// You must deregister all container instances from this cluster before you may delete
        /// it. You can list the container instances in a cluster with <a>ListContainerInstances</a>
        /// and deregister them with <a>DeregisterContainerInstance</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteCluster service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action, such as using an action or resource
        /// on behalf of a user that doesn't have permissions to use the action or resource, or
        /// specifying an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClusterContainsContainerInstancesException">
        /// You cannot delete a cluster that has registered container instances. First, deregister
        /// the container instances before you can delete the cluster. For more information, see
        /// <a>DeregisterContainerInstance</a>.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClusterContainsServicesException">
        /// You cannot delete a cluster that contains services. First, update the service to reduce
        /// its desired task count to 0 and then delete the service. For more information, see
        /// <a>UpdateService</a> and <a>DeleteService</a>.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClusterContainsTasksException">
        /// You cannot delete a cluster that has active tasks.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClusterNotFoundException">
        /// The specified cluster could not be found. You can view your available clusters with
        /// <a>ListClusters</a>. Amazon ECS clusters are Region-specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/DeleteCluster">REST API Reference for DeleteCluster Operation</seealso>
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
        /// service is no longer visible in the console or in the <a>ListServices</a> API operation.
        /// After all tasks have transitioned to either <code>STOPPING</code> or <code>STOPPED</code>
        /// status, the service status moves from <code>DRAINING</code> to <code>INACTIVE</code>.
        /// Services in the <code>DRAINING</code> or <code>INACTIVE</code> status can still be
        /// viewed with the <a>DescribeServices</a> API operation. However, in the future, <code>INACTIVE</code>
        /// services may be cleaned up and purged from Amazon ECS record keeping, and <a>DescribeServices</a>
        /// calls on those services return a <code>ServiceNotFoundException</code> error.
        /// </para>
        ///  </note> <important> 
        /// <para>
        /// If you attempt to create a new service with the same name as an existing service in
        /// either <code>ACTIVE</code> or <code>DRAINING</code> status, you receive an error.
        /// </para>
        ///  </important>
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
        /// <a>ListClusters</a>. Amazon ECS clusters are Region-specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServiceNotFoundException">
        /// The specified service could not be found. You can view your available services with
        /// <a>ListServices</a>. Amazon ECS services are cluster-specific and Region-specific.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/DeleteService">REST API Reference for DeleteService Operation</seealso>
        DeleteServiceResponse DeleteService(DeleteServiceRequest request);



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
        /// service is no longer visible in the console or in the <a>ListServices</a> API operation.
        /// After all tasks have transitioned to either <code>STOPPING</code> or <code>STOPPED</code>
        /// status, the service status moves from <code>DRAINING</code> to <code>INACTIVE</code>.
        /// Services in the <code>DRAINING</code> or <code>INACTIVE</code> status can still be
        /// viewed with the <a>DescribeServices</a> API operation. However, in the future, <code>INACTIVE</code>
        /// services may be cleaned up and purged from Amazon ECS record keeping, and <a>DescribeServices</a>
        /// calls on those services return a <code>ServiceNotFoundException</code> error.
        /// </para>
        ///  </note> <important> 
        /// <para>
        /// If you attempt to create a new service with the same name as an existing service in
        /// either <code>ACTIVE</code> or <code>DRAINING</code> status, you receive an error.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteService service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteService service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action, such as using an action or resource
        /// on behalf of a user that doesn't have permissions to use the action or resource, or
        /// specifying an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClusterNotFoundException">
        /// The specified cluster could not be found. You can view your available clusters with
        /// <a>ListClusters</a>. Amazon ECS clusters are Region-specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServiceNotFoundException">
        /// The specified service could not be found. You can view your available services with
        /// <a>ListServices</a>. Amazon ECS services are cluster-specific and Region-specific.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/DeleteService">REST API Reference for DeleteService Operation</seealso>
        Task<DeleteServiceResponse> DeleteServiceAsync(DeleteServiceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteTaskSet


        /// <summary>
        /// Deletes a specified task set within a service. This is used when a service uses the
        /// <code>EXTERNAL</code> deployment controller type. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/deployment-types.html">Amazon
        /// ECS Deployment Types</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTaskSet service method.</param>
        /// 
        /// <returns>The response from the DeleteTaskSet service method, as returned by ECS.</returns>
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
        /// <a>ListClusters</a>. Amazon ECS clusters are Region-specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
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
        /// <a>ListServices</a>. Amazon ECS services are cluster-specific and Region-specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.TaskSetNotFoundException">
        /// The specified task set could not be found. You can view your available task sets with
        /// <a>DescribeTaskSets</a>. Task sets are specific to each cluster, service and Region.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.UnsupportedFeatureException">
        /// The specified task is not supported in this Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/DeleteTaskSet">REST API Reference for DeleteTaskSet Operation</seealso>
        DeleteTaskSetResponse DeleteTaskSet(DeleteTaskSetRequest request);



        /// <summary>
        /// Deletes a specified task set within a service. This is used when a service uses the
        /// <code>EXTERNAL</code> deployment controller type. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/deployment-types.html">Amazon
        /// ECS Deployment Types</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTaskSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTaskSet service method, as returned by ECS.</returns>
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
        /// <a>ListClusters</a>. Amazon ECS clusters are Region-specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
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
        /// <a>ListServices</a>. Amazon ECS services are cluster-specific and Region-specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.TaskSetNotFoundException">
        /// The specified task set could not be found. You can view your available task sets with
        /// <a>DescribeTaskSets</a>. Task sets are specific to each cluster, service and Region.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.UnsupportedFeatureException">
        /// The specified task is not supported in this Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/DeleteTaskSet">REST API Reference for DeleteTaskSet Operation</seealso>
        Task<DeleteTaskSetResponse> DeleteTaskSetAsync(DeleteTaskSetRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// not terminate the EC2 instance. If you are finished using the instance, be sure to
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
        /// <a>ListClusters</a>. Amazon ECS clusters are Region-specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/DeregisterContainerInstance">REST API Reference for DeregisterContainerInstance Operation</seealso>
        DeregisterContainerInstanceResponse DeregisterContainerInstance(DeregisterContainerInstanceRequest request);



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
        /// not terminate the EC2 instance. If you are finished using the instance, be sure to
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeregisterContainerInstance service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action, such as using an action or resource
        /// on behalf of a user that doesn't have permissions to use the action or resource, or
        /// specifying an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClusterNotFoundException">
        /// The specified cluster could not be found. You can view your available clusters with
        /// <a>ListClusters</a>. Amazon ECS clusters are Region-specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/DeregisterContainerInstance">REST API Reference for DeregisterContainerInstance Operation</seealso>
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
        /// task definition. However, there may be up to a 10-minute window following deregistration
        /// where these restrictions have not yet taken effect.
        /// </para>
        ///  <note> 
        /// <para>
        /// At this time, <code>INACTIVE</code> task definitions remain discoverable in your account
        /// indefinitely. However, this behavior is subject to change in the future, so you should
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
        DeregisterTaskDefinitionResponse DeregisterTaskDefinition(DeregisterTaskDefinitionRequest request);



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
        /// task definition. However, there may be up to a 10-minute window following deregistration
        /// where these restrictions have not yet taken effect.
        /// </para>
        ///  <note> 
        /// <para>
        /// At this time, <code>INACTIVE</code> task definitions remain discoverable in your account
        /// indefinitely. However, this behavior is subject to change in the future, so you should
        /// not rely on <code>INACTIVE</code> task definitions persisting beyond the lifecycle
        /// of any associated tasks and services.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterTaskDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeregisterTaskDefinitionResponse> DeregisterTaskDefinitionAsync(DeregisterTaskDefinitionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeCapacityProviders


        /// <summary>
        /// Describes one or more of your capacity providers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCapacityProviders service method.</param>
        /// 
        /// <returns>The response from the DescribeCapacityProviders service method, as returned by ECS.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/DescribeCapacityProviders">REST API Reference for DescribeCapacityProviders Operation</seealso>
        DescribeCapacityProvidersResponse DescribeCapacityProviders(DescribeCapacityProvidersRequest request);



        /// <summary>
        /// Describes one or more of your capacity providers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCapacityProviders service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeCapacityProviders service method, as returned by ECS.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/DescribeCapacityProviders">REST API Reference for DescribeCapacityProviders Operation</seealso>
        Task<DescribeCapacityProvidersResponse> DescribeCapacityProvidersAsync(DescribeCapacityProvidersRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DescribeClustersResponse DescribeClusters(DescribeClustersRequest request);



        /// <summary>
        /// Describes one or more of your clusters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusters service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DescribeClustersResponse> DescribeClustersAsync(DescribeClustersRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <a>ListClusters</a>. Amazon ECS clusters are Region-specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/DescribeContainerInstances">REST API Reference for DescribeContainerInstances Operation</seealso>
        DescribeContainerInstancesResponse DescribeContainerInstances(DescribeContainerInstancesRequest request);



        /// <summary>
        /// Describes Amazon Elastic Container Service container instances. Returns metadata about
        /// registered and remaining resources on each container instance requested.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeContainerInstances service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeContainerInstances service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action, such as using an action or resource
        /// on behalf of a user that doesn't have permissions to use the action or resource, or
        /// specifying an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClusterNotFoundException">
        /// The specified cluster could not be found. You can view your available clusters with
        /// <a>ListClusters</a>. Amazon ECS clusters are Region-specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/DescribeContainerInstances">REST API Reference for DescribeContainerInstances Operation</seealso>
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
        /// on behalf of a user that doesn't have permissions to use the action or resource, or
        /// specifying an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClusterNotFoundException">
        /// The specified cluster could not be found. You can view your available clusters with
        /// <a>ListClusters</a>. Amazon ECS clusters are Region-specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/DescribeServices">REST API Reference for DescribeServices Operation</seealso>
        DescribeServicesResponse DescribeServices(DescribeServicesRequest request);



        /// <summary>
        /// Describes the specified services running in your cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeServices service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeServices service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action, such as using an action or resource
        /// on behalf of a user that doesn't have permissions to use the action or resource, or
        /// specifying an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClusterNotFoundException">
        /// The specified cluster could not be found. You can view your available clusters with
        /// <a>ListClusters</a>. Amazon ECS clusters are Region-specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/DescribeServices">REST API Reference for DescribeServices Operation</seealso>
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
        DescribeTaskDefinitionResponse DescribeTaskDefinition(DescribeTaskDefinitionRequest request);



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// on behalf of a user that doesn't have permissions to use the action or resource, or
        /// specifying an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClusterNotFoundException">
        /// The specified cluster could not be found. You can view your available clusters with
        /// <a>ListClusters</a>. Amazon ECS clusters are Region-specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/DescribeTasks">REST API Reference for DescribeTasks Operation</seealso>
        DescribeTasksResponse DescribeTasks(DescribeTasksRequest request);



        /// <summary>
        /// Describes a specified task or tasks.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTasks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeTasks service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action, such as using an action or resource
        /// on behalf of a user that doesn't have permissions to use the action or resource, or
        /// specifying an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClusterNotFoundException">
        /// The specified cluster could not be found. You can view your available clusters with
        /// <a>ListClusters</a>. Amazon ECS clusters are Region-specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/DescribeTasks">REST API Reference for DescribeTasks Operation</seealso>
        Task<DescribeTasksResponse> DescribeTasksAsync(DescribeTasksRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeTaskSets


        /// <summary>
        /// Describes the task sets in the specified cluster and service. This is used when a
        /// service uses the <code>EXTERNAL</code> deployment controller type. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/deployment-types.html">Amazon
        /// ECS Deployment Types</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTaskSets service method.</param>
        /// 
        /// <returns>The response from the DescribeTaskSets service method, as returned by ECS.</returns>
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
        /// <a>ListClusters</a>. Amazon ECS clusters are Region-specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
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
        /// <a>ListServices</a>. Amazon ECS services are cluster-specific and Region-specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.UnsupportedFeatureException">
        /// The specified task is not supported in this Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/DescribeTaskSets">REST API Reference for DescribeTaskSets Operation</seealso>
        DescribeTaskSetsResponse DescribeTaskSets(DescribeTaskSetsRequest request);



        /// <summary>
        /// Describes the task sets in the specified cluster and service. This is used when a
        /// service uses the <code>EXTERNAL</code> deployment controller type. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/deployment-types.html">Amazon
        /// ECS Deployment Types</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTaskSets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeTaskSets service method, as returned by ECS.</returns>
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
        /// <a>ListClusters</a>. Amazon ECS clusters are Region-specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
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
        /// <a>ListServices</a>. Amazon ECS services are cluster-specific and Region-specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.UnsupportedFeatureException">
        /// The specified task is not supported in this Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/DescribeTaskSets">REST API Reference for DescribeTaskSets Operation</seealso>
        Task<DescribeTaskSetsResponse> DescribeTaskSetsAsync(DescribeTaskSetsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListAccountSettings


        /// <summary>
        /// Lists the account settings for a specified principal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAccountSettings service method.</param>
        /// 
        /// <returns>The response from the ListAccountSettings service method, as returned by ECS.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/ListAccountSettings">REST API Reference for ListAccountSettings Operation</seealso>
        ListAccountSettingsResponse ListAccountSettings(ListAccountSettingsRequest request);



        /// <summary>
        /// Lists the account settings for a specified principal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAccountSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAccountSettings service method, as returned by ECS.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/ListAccountSettings">REST API Reference for ListAccountSettings Operation</seealso>
        Task<ListAccountSettingsResponse> ListAccountSettingsAsync(ListAccountSettingsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <a>ListClusters</a>. Amazon ECS clusters are Region-specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/ListAttributes">REST API Reference for ListAttributes Operation</seealso>
        ListAttributesResponse ListAttributes(ListAttributesRequest request);



        /// <summary>
        /// Lists the attributes for Amazon ECS resources within a specified target type and cluster.
        /// When you specify a target type and cluster, <code>ListAttributes</code> returns a
        /// list of attribute objects, one for each attribute on each resource. You can filter
        /// the list of results to a single attribute name to only return results that have that
        /// name. You can also filter the results by attribute name and value, for example, to
        /// see which container instances in a cluster are running a Linux AMI (<code>ecs.os-type=linux</code>).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAttributes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAttributes service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClusterNotFoundException">
        /// The specified cluster could not be found. You can view your available clusters with
        /// <a>ListClusters</a>. Amazon ECS clusters are Region-specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/ListAttributes">REST API Reference for ListAttributes Operation</seealso>
        Task<ListAttributesResponse> ListAttributesAsync(ListAttributesRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        ListClustersResponse ListClusters(ListClustersRequest request);



        /// <summary>
        /// Returns a list of existing clusters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListClusters service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListClustersResponse> ListClustersAsync(ListClustersRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListContainerInstances


        /// <summary>
        /// Returns a list of container instances in a specified cluster. You can filter the results
        /// of a <code>ListContainerInstances</code> operation with cluster query language statements
        /// inside the <code>filter</code> parameter. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/cluster-query-language.html">Cluster
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
        /// <a>ListClusters</a>. Amazon ECS clusters are Region-specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/ListContainerInstances">REST API Reference for ListContainerInstances Operation</seealso>
        ListContainerInstancesResponse ListContainerInstances(ListContainerInstancesRequest request);



        /// <summary>
        /// Returns a list of container instances in a specified cluster. You can filter the results
        /// of a <code>ListContainerInstances</code> operation with cluster query language statements
        /// inside the <code>filter</code> parameter. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/cluster-query-language.html">Cluster
        /// Query Language</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListContainerInstances service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListContainerInstances service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action, such as using an action or resource
        /// on behalf of a user that doesn't have permissions to use the action or resource, or
        /// specifying an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClusterNotFoundException">
        /// The specified cluster could not be found. You can view your available clusters with
        /// <a>ListClusters</a>. Amazon ECS clusters are Region-specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/ListContainerInstances">REST API Reference for ListContainerInstances Operation</seealso>
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
        /// on behalf of a user that doesn't have permissions to use the action or resource, or
        /// specifying an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClusterNotFoundException">
        /// The specified cluster could not be found. You can view your available clusters with
        /// <a>ListClusters</a>. Amazon ECS clusters are Region-specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/ListServices">REST API Reference for ListServices Operation</seealso>
        ListServicesResponse ListServices(ListServicesRequest request);



        /// <summary>
        /// Lists the services that are running in a specified cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServices service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListServices service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action, such as using an action or resource
        /// on behalf of a user that doesn't have permissions to use the action or resource, or
        /// specifying an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClusterNotFoundException">
        /// The specified cluster could not be found. You can view your available clusters with
        /// <a>ListClusters</a>. Amazon ECS clusters are Region-specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/ListServices">REST API Reference for ListServices Operation</seealso>
        Task<ListServicesResponse> ListServicesAsync(ListServicesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// List the tags for an Amazon ECS resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action, such as using an action or resource
        /// on behalf of a user that doesn't have permissions to use the action or resource, or
        /// specifying an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClusterNotFoundException">
        /// The specified cluster could not be found. You can view your available clusters with
        /// <a>ListClusters</a>. Amazon ECS clusters are Region-specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);



        /// <summary>
        /// List the tags for an Amazon ECS resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action, such as using an action or resource
        /// on behalf of a user that doesn't have permissions to use the action or resource, or
        /// specifying an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClusterNotFoundException">
        /// The specified cluster could not be found. You can view your available clusters with
        /// <a>ListClusters</a>. Amazon ECS clusters are Region-specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        ListTaskDefinitionFamiliesResponse ListTaskDefinitionFamilies(ListTaskDefinitionFamiliesRequest request);



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        ListTaskDefinitionsResponse ListTaskDefinitions(ListTaskDefinitionsRequest request);



        /// <summary>
        /// Returns a list of task definitions that are registered to your account. You can filter
        /// the results by family name with the <code>familyPrefix</code> parameter or by status
        /// with the <code>status</code> parameter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTaskDefinitions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// <a>ListClusters</a>. Amazon ECS clusters are Region-specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServiceNotFoundException">
        /// The specified service could not be found. You can view your available services with
        /// <a>ListServices</a>. Amazon ECS services are cluster-specific and Region-specific.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/ListTasks">REST API Reference for ListTasks Operation</seealso>
        ListTasksResponse ListTasks(ListTasksRequest request);



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTasks service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action, such as using an action or resource
        /// on behalf of a user that doesn't have permissions to use the action or resource, or
        /// specifying an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClusterNotFoundException">
        /// The specified cluster could not be found. You can view your available clusters with
        /// <a>ListClusters</a>. Amazon ECS clusters are Region-specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServiceNotFoundException">
        /// The specified service could not be found. You can view your available services with
        /// <a>ListServices</a>. Amazon ECS services are cluster-specific and Region-specific.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/ListTasks">REST API Reference for ListTasks Operation</seealso>
        Task<ListTasksResponse> ListTasksAsync(ListTasksRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutAccountSetting


        /// <summary>
        /// Modifies an account setting. Account settings are set on a per-Region basis.
        /// 
        ///  
        /// <para>
        /// If you change the account setting for the root user, the default settings for all
        /// of the IAM users and roles for which no individual account setting has been specified
        /// are reset. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/ecs-account-settings.html">Account
        /// Settings</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// When <code>serviceLongArnFormat</code>, <code>taskLongArnFormat</code>, or <code>containerInstanceLongArnFormat</code>
        /// are specified, the Amazon Resource Name (ARN) and resource ID format of the resource
        /// type for a specified IAM user, IAM role, or the root user for an account is affected.
        /// The opt-in and opt-out account setting must be set for each Amazon ECS resource separately.
        /// The ARN and resource ID format of a resource will be defined by the opt-in status
        /// of the IAM user or role that created the resource. You must enable this setting to
        /// use Amazon ECS features such as resource tagging.
        /// </para>
        ///  
        /// <para>
        /// When <code>awsvpcTrunking</code> is specified, the elastic network interface (ENI)
        /// limit for any new container instances that support the feature is changed. If <code>awsvpcTrunking</code>
        /// is enabled, any new container instances that support the feature are launched have
        /// the increased ENI limits available to them. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/container-instance-eni.html">Elastic
        /// Network Interface Trunking</a> in the <i>Amazon Elastic Container Service Developer
        /// Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// When <code>containerInsights</code> is specified, the default setting indicating whether
        /// CloudWatch Container Insights is enabled for your clusters is changed. If <code>containerInsights</code>
        /// is enabled, any new clusters that are created will have Container Insights enabled
        /// unless you disable it during cluster creation. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/cloudwatch-container-insights.html">CloudWatch
        /// Container Insights</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAccountSetting service method.</param>
        /// 
        /// <returns>The response from the PutAccountSetting service method, as returned by ECS.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/PutAccountSetting">REST API Reference for PutAccountSetting Operation</seealso>
        PutAccountSettingResponse PutAccountSetting(PutAccountSettingRequest request);



        /// <summary>
        /// Modifies an account setting. Account settings are set on a per-Region basis.
        /// 
        ///  
        /// <para>
        /// If you change the account setting for the root user, the default settings for all
        /// of the IAM users and roles for which no individual account setting has been specified
        /// are reset. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/ecs-account-settings.html">Account
        /// Settings</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// When <code>serviceLongArnFormat</code>, <code>taskLongArnFormat</code>, or <code>containerInstanceLongArnFormat</code>
        /// are specified, the Amazon Resource Name (ARN) and resource ID format of the resource
        /// type for a specified IAM user, IAM role, or the root user for an account is affected.
        /// The opt-in and opt-out account setting must be set for each Amazon ECS resource separately.
        /// The ARN and resource ID format of a resource will be defined by the opt-in status
        /// of the IAM user or role that created the resource. You must enable this setting to
        /// use Amazon ECS features such as resource tagging.
        /// </para>
        ///  
        /// <para>
        /// When <code>awsvpcTrunking</code> is specified, the elastic network interface (ENI)
        /// limit for any new container instances that support the feature is changed. If <code>awsvpcTrunking</code>
        /// is enabled, any new container instances that support the feature are launched have
        /// the increased ENI limits available to them. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/container-instance-eni.html">Elastic
        /// Network Interface Trunking</a> in the <i>Amazon Elastic Container Service Developer
        /// Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// When <code>containerInsights</code> is specified, the default setting indicating whether
        /// CloudWatch Container Insights is enabled for your clusters is changed. If <code>containerInsights</code>
        /// is enabled, any new clusters that are created will have Container Insights enabled
        /// unless you disable it during cluster creation. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/cloudwatch-container-insights.html">CloudWatch
        /// Container Insights</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAccountSetting service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutAccountSetting service method, as returned by ECS.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/PutAccountSetting">REST API Reference for PutAccountSetting Operation</seealso>
        Task<PutAccountSettingResponse> PutAccountSettingAsync(PutAccountSettingRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutAccountSettingDefault


        /// <summary>
        /// Modifies an account setting for all IAM users on an account for whom no individual
        /// account setting has been specified. Account settings are set on a per-Region basis.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAccountSettingDefault service method.</param>
        /// 
        /// <returns>The response from the PutAccountSettingDefault service method, as returned by ECS.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/PutAccountSettingDefault">REST API Reference for PutAccountSettingDefault Operation</seealso>
        PutAccountSettingDefaultResponse PutAccountSettingDefault(PutAccountSettingDefaultRequest request);



        /// <summary>
        /// Modifies an account setting for all IAM users on an account for whom no individual
        /// account setting has been specified. Account settings are set on a per-Region basis.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAccountSettingDefault service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutAccountSettingDefault service method, as returned by ECS.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/PutAccountSettingDefault">REST API Reference for PutAccountSettingDefault Operation</seealso>
        Task<PutAccountSettingDefaultResponse> PutAccountSettingDefaultAsync(PutAccountSettingDefaultRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutAttributes


        /// <summary>
        /// Create or update an attribute on an Amazon ECS resource. If the attribute does not
        /// exist, it is created. If the attribute exists, its value is replaced with the specified
        /// value. To delete an attribute, use <a>DeleteAttributes</a>. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/task-placement-constraints.html#attributes">Attributes</a>
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
        /// <a>ListClusters</a>. Amazon ECS clusters are Region-specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.TargetNotFoundException">
        /// The specified target could not be found. You can view your available container instances
        /// with <a>ListContainerInstances</a>. Amazon ECS container instances are cluster-specific
        /// and Region-specific.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/PutAttributes">REST API Reference for PutAttributes Operation</seealso>
        PutAttributesResponse PutAttributes(PutAttributesRequest request);



        /// <summary>
        /// Create or update an attribute on an Amazon ECS resource. If the attribute does not
        /// exist, it is created. If the attribute exists, its value is replaced with the specified
        /// value. To delete an attribute, use <a>DeleteAttributes</a>. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/task-placement-constraints.html#attributes">Attributes</a>
        /// in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAttributes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutAttributes service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.AttributeLimitExceededException">
        /// You can apply up to 10 custom attributes per resource. You can view the attributes
        /// of a resource with <a>ListAttributes</a>. You can remove existing attributes on a
        /// resource with <a>DeleteAttributes</a>.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClusterNotFoundException">
        /// The specified cluster could not be found. You can view your available clusters with
        /// <a>ListClusters</a>. Amazon ECS clusters are Region-specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.TargetNotFoundException">
        /// The specified target could not be found. You can view your available container instances
        /// with <a>ListContainerInstances</a>. Amazon ECS container instances are cluster-specific
        /// and Region-specific.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/PutAttributes">REST API Reference for PutAttributes Operation</seealso>
        Task<PutAttributesResponse> PutAttributesAsync(PutAttributesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutClusterCapacityProviders


        /// <summary>
        /// Modifies the available capacity providers and the default capacity provider strategy
        /// for a cluster.
        /// 
        ///  
        /// <para>
        /// You must specify both the available capacity providers and a default capacity provider
        /// strategy for the cluster. If the specified cluster has existing capacity providers
        /// associated with it, you must specify all existing capacity providers in addition to
        /// any new ones you want to add. Any existing capacity providers associated with a cluster
        /// that are omitted from a <a>PutClusterCapacityProviders</a> API call will be disassociated
        /// with the cluster. You can only disassociate an existing capacity provider from a cluster
        /// if it's not being used by any existing tasks.
        /// </para>
        ///  
        /// <para>
        /// When creating a service or running a task on a cluster, if no capacity provider or
        /// launch type is specified, then the cluster's default capacity provider strategy is
        /// used. It is recommended to define a default capacity provider strategy for your cluster,
        /// however you may specify an empty array (<code>[]</code>) to bypass defining a default
        /// strategy.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutClusterCapacityProviders service method.</param>
        /// 
        /// <returns>The response from the PutClusterCapacityProviders service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action, such as using an action or resource
        /// on behalf of a user that doesn't have permissions to use the action or resource, or
        /// specifying an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClusterNotFoundException">
        /// The specified cluster could not be found. You can view your available clusters with
        /// <a>ListClusters</a>. Amazon ECS clusters are Region-specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ResourceInUseException">
        /// The specified resource is in-use and cannot be removed.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/PutClusterCapacityProviders">REST API Reference for PutClusterCapacityProviders Operation</seealso>
        PutClusterCapacityProvidersResponse PutClusterCapacityProviders(PutClusterCapacityProvidersRequest request);



        /// <summary>
        /// Modifies the available capacity providers and the default capacity provider strategy
        /// for a cluster.
        /// 
        ///  
        /// <para>
        /// You must specify both the available capacity providers and a default capacity provider
        /// strategy for the cluster. If the specified cluster has existing capacity providers
        /// associated with it, you must specify all existing capacity providers in addition to
        /// any new ones you want to add. Any existing capacity providers associated with a cluster
        /// that are omitted from a <a>PutClusterCapacityProviders</a> API call will be disassociated
        /// with the cluster. You can only disassociate an existing capacity provider from a cluster
        /// if it's not being used by any existing tasks.
        /// </para>
        ///  
        /// <para>
        /// When creating a service or running a task on a cluster, if no capacity provider or
        /// launch type is specified, then the cluster's default capacity provider strategy is
        /// used. It is recommended to define a default capacity provider strategy for your cluster,
        /// however you may specify an empty array (<code>[]</code>) to bypass defining a default
        /// strategy.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutClusterCapacityProviders service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutClusterCapacityProviders service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action, such as using an action or resource
        /// on behalf of a user that doesn't have permissions to use the action or resource, or
        /// specifying an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClusterNotFoundException">
        /// The specified cluster could not be found. You can view your available clusters with
        /// <a>ListClusters</a>. Amazon ECS clusters are Region-specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ResourceInUseException">
        /// The specified resource is in-use and cannot be removed.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/PutClusterCapacityProviders">REST API Reference for PutClusterCapacityProviders Operation</seealso>
        Task<PutClusterCapacityProvidersResponse> PutClusterCapacityProvidersAsync(PutClusterCapacityProvidersRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RegisterTaskDefinition


        /// <summary>
        /// Registers a new task definition from the supplied <code>family</code> and <code>containerDefinitions</code>.
        /// Optionally, you can add data volumes to your containers with the <code>volumes</code>
        /// parameter. For more information about task definition parameters and defaults, see
        /// <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/task_defintions.html">Amazon
        /// ECS Task Definitions</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// 
        ///  
        /// <para>
        /// You can specify an IAM role for your task with the <code>taskRoleArn</code> parameter.
        /// When you specify an IAM role for a task, its containers can then use the latest versions
        /// of the AWS CLI or SDKs to make API requests to the AWS services that are specified
        /// in the IAM policy associated with the role. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/task-iam-roles.html">IAM
        /// Roles for Tasks</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can specify a Docker networking mode for the containers in your task definition
        /// with the <code>networkMode</code> parameter. The available network modes correspond
        /// to those described in <a href="https://docs.docker.com/engine/reference/run/#/network-settings">Network
        /// settings</a> in the Docker run reference. If you specify the <code>awsvpc</code> network
        /// mode, the task is allocated an elastic network interface, and you must specify a <a>NetworkConfiguration</a>
        /// when you create a service or run a task with the task definition. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/task-networking.html">Task
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
        RegisterTaskDefinitionResponse RegisterTaskDefinition(RegisterTaskDefinitionRequest request);



        /// <summary>
        /// Registers a new task definition from the supplied <code>family</code> and <code>containerDefinitions</code>.
        /// Optionally, you can add data volumes to your containers with the <code>volumes</code>
        /// parameter. For more information about task definition parameters and defaults, see
        /// <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/task_defintions.html">Amazon
        /// ECS Task Definitions</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// 
        ///  
        /// <para>
        /// You can specify an IAM role for your task with the <code>taskRoleArn</code> parameter.
        /// When you specify an IAM role for a task, its containers can then use the latest versions
        /// of the AWS CLI or SDKs to make API requests to the AWS services that are specified
        /// in the IAM policy associated with the role. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/task-iam-roles.html">IAM
        /// Roles for Tasks</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can specify a Docker networking mode for the containers in your task definition
        /// with the <code>networkMode</code> parameter. The available network modes correspond
        /// to those described in <a href="https://docs.docker.com/engine/reference/run/#/network-settings">Network
        /// settings</a> in the Docker run reference. If you specify the <code>awsvpc</code> network
        /// mode, the task is allocated an elastic network interface, and you must specify a <a>NetworkConfiguration</a>
        /// when you create a service or run a task with the task definition. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/task-networking.html">Task
        /// Networking</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterTaskDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<RegisterTaskDefinitionResponse> RegisterTaskDefinitionAsync(RegisterTaskDefinitionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RunTask


        /// <summary>
        /// Starts a new task using the specified task definition.
        /// 
        ///  
        /// <para>
        /// You can allow Amazon ECS to place tasks for you, or you can customize how Amazon ECS
        /// places tasks using placement constraints and placement strategies. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/scheduling_tasks.html">Scheduling
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
        /// subsequent commands you run. Keep this in mind when you carry out an API command that
        /// immediately follows a previous API command.
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
        /// command repeatedly, starting with a couple of seconds of wait time and increasing
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
        /// Your AWS account has been blocked. For more information, contact <a href="http://aws.amazon.com/contact-us/">AWS
        /// Support</a>.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action, such as using an action or resource
        /// on behalf of a user that doesn't have permissions to use the action or resource, or
        /// specifying an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClusterNotFoundException">
        /// The specified cluster could not be found. You can view your available clusters with
        /// <a>ListClusters</a>. Amazon ECS clusters are Region-specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.PlatformTaskDefinitionIncompatibilityException">
        /// The specified platform version does not satisfy the task definition's required capabilities.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.PlatformUnknownException">
        /// The specified platform version does not exist.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.UnsupportedFeatureException">
        /// The specified task is not supported in this Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/RunTask">REST API Reference for RunTask Operation</seealso>
        RunTaskResponse RunTask(RunTaskRequest request);



        /// <summary>
        /// Starts a new task using the specified task definition.
        /// 
        ///  
        /// <para>
        /// You can allow Amazon ECS to place tasks for you, or you can customize how Amazon ECS
        /// places tasks using placement constraints and placement strategies. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/scheduling_tasks.html">Scheduling
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
        /// subsequent commands you run. Keep this in mind when you carry out an API command that
        /// immediately follows a previous API command.
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
        /// command repeatedly, starting with a couple of seconds of wait time and increasing
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RunTask service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.AccessDeniedException">
        /// You do not have authorization to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.BlockedException">
        /// Your AWS account has been blocked. For more information, contact <a href="http://aws.amazon.com/contact-us/">AWS
        /// Support</a>.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action, such as using an action or resource
        /// on behalf of a user that doesn't have permissions to use the action or resource, or
        /// specifying an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClusterNotFoundException">
        /// The specified cluster could not be found. You can view your available clusters with
        /// <a>ListClusters</a>. Amazon ECS clusters are Region-specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.PlatformTaskDefinitionIncompatibilityException">
        /// The specified platform version does not satisfy the task definition's required capabilities.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.PlatformUnknownException">
        /// The specified platform version does not exist.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.UnsupportedFeatureException">
        /// The specified task is not supported in this Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/RunTask">REST API Reference for RunTask Operation</seealso>
        Task<RunTaskResponse> RunTaskAsync(RunTaskRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StartTask


        /// <summary>
        /// Starts a new task from the specified task definition on the specified container instance
        /// or instances.
        /// 
        ///  
        /// <para>
        /// Alternatively, you can use <a>RunTask</a> to place tasks for you. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/scheduling_tasks.html">Scheduling
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
        /// <a>ListClusters</a>. Amazon ECS clusters are Region-specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/StartTask">REST API Reference for StartTask Operation</seealso>
        StartTaskResponse StartTask(StartTaskRequest request);



        /// <summary>
        /// Starts a new task from the specified task definition on the specified container instance
        /// or instances.
        /// 
        ///  
        /// <para>
        /// Alternatively, you can use <a>RunTask</a> to place tasks for you. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/scheduling_tasks.html">Scheduling
        /// Tasks</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartTask service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action, such as using an action or resource
        /// on behalf of a user that doesn't have permissions to use the action or resource, or
        /// specifying an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClusterNotFoundException">
        /// The specified cluster could not be found. You can view your available clusters with
        /// <a>ListClusters</a>. Amazon ECS clusters are Region-specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/StartTask">REST API Reference for StartTask Operation</seealso>
        Task<StartTaskResponse> StartTaskAsync(StartTaskRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StopTask


        /// <summary>
        /// Stops a running task. Any tags associated with the task will be deleted.
        /// 
        ///  
        /// <para>
        /// When <a>StopTask</a> is called on a task, the equivalent of <code>docker stop</code>
        /// is issued to the containers running in the task. This results in a <code>SIGTERM</code>
        /// value and a default 30-second timeout, after which the <code>SIGKILL</code> value
        /// is sent and the containers are forcibly stopped. If the container handles the <code>SIGTERM</code>
        /// value gracefully and exits within 30 seconds from receiving it, no <code>SIGKILL</code>
        /// value is sent.
        /// </para>
        ///  <note> 
        /// <para>
        /// The default 30-second timeout can be configured on the Amazon ECS container agent
        /// with the <code>ECS_CONTAINER_STOP_TIMEOUT</code> variable. For more information, see
        /// <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/ecs-agent-config.html">Amazon
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
        /// <a>ListClusters</a>. Amazon ECS clusters are Region-specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/StopTask">REST API Reference for StopTask Operation</seealso>
        StopTaskResponse StopTask(StopTaskRequest request);



        /// <summary>
        /// Stops a running task. Any tags associated with the task will be deleted.
        /// 
        ///  
        /// <para>
        /// When <a>StopTask</a> is called on a task, the equivalent of <code>docker stop</code>
        /// is issued to the containers running in the task. This results in a <code>SIGTERM</code>
        /// value and a default 30-second timeout, after which the <code>SIGKILL</code> value
        /// is sent and the containers are forcibly stopped. If the container handles the <code>SIGTERM</code>
        /// value gracefully and exits within 30 seconds from receiving it, no <code>SIGKILL</code>
        /// value is sent.
        /// </para>
        ///  <note> 
        /// <para>
        /// The default 30-second timeout can be configured on the Amazon ECS container agent
        /// with the <code>ECS_CONTAINER_STOP_TIMEOUT</code> variable. For more information, see
        /// <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/ecs-agent-config.html">Amazon
        /// ECS Container Agent Configuration</a> in the <i>Amazon Elastic Container Service Developer
        /// Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopTask service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action, such as using an action or resource
        /// on behalf of a user that doesn't have permissions to use the action or resource, or
        /// specifying an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClusterNotFoundException">
        /// The specified cluster could not be found. You can view your available clusters with
        /// <a>ListClusters</a>. Amazon ECS clusters are Region-specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/StopTask">REST API Reference for StopTask Operation</seealso>
        Task<StopTaskResponse> StopTaskAsync(StopTaskRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  SubmitAttachmentStateChanges


        /// <summary>
        /// <note> 
        /// <para>
        /// This action is only used by the Amazon ECS agent, and it is not intended for use outside
        /// of the agent.
        /// </para>
        ///  </note> 
        /// <para>
        /// Sent to acknowledge that an attachment changed states.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SubmitAttachmentStateChanges service method.</param>
        /// 
        /// <returns>The response from the SubmitAttachmentStateChanges service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.AccessDeniedException">
        /// You do not have authorization to perform the requested action.
        /// </exception>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/SubmitAttachmentStateChanges">REST API Reference for SubmitAttachmentStateChanges Operation</seealso>
        SubmitAttachmentStateChangesResponse SubmitAttachmentStateChanges(SubmitAttachmentStateChangesRequest request);



        /// <summary>
        /// <note> 
        /// <para>
        /// This action is only used by the Amazon ECS agent, and it is not intended for use outside
        /// of the agent.
        /// </para>
        ///  </note> 
        /// <para>
        /// Sent to acknowledge that an attachment changed states.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SubmitAttachmentStateChanges service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SubmitAttachmentStateChanges service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.AccessDeniedException">
        /// You do not have authorization to perform the requested action.
        /// </exception>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/SubmitAttachmentStateChanges">REST API Reference for SubmitAttachmentStateChanges Operation</seealso>
        Task<SubmitAttachmentStateChangesResponse> SubmitAttachmentStateChangesAsync(SubmitAttachmentStateChangesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Associates the specified tags to a resource with the specified <code>resourceArn</code>.
        /// If existing tags on a resource are not specified in the request parameters, they are
        /// not changed. When a resource is deleted, the tags associated with that resource are
        /// deleted as well.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action, such as using an action or resource
        /// on behalf of a user that doesn't have permissions to use the action or resource, or
        /// specifying an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClusterNotFoundException">
        /// The specified cluster could not be found. You can view your available clusters with
        /// <a>ListClusters</a>. Amazon ECS clusters are Region-specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);



        /// <summary>
        /// Associates the specified tags to a resource with the specified <code>resourceArn</code>.
        /// If existing tags on a resource are not specified in the request parameters, they are
        /// not changed. When a resource is deleted, the tags associated with that resource are
        /// deleted as well.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action, such as using an action or resource
        /// on behalf of a user that doesn't have permissions to use the action or resource, or
        /// specifying an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClusterNotFoundException">
        /// The specified cluster could not be found. You can view your available clusters with
        /// <a>ListClusters</a>. Amazon ECS clusters are Region-specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Deletes specified tags from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action, such as using an action or resource
        /// on behalf of a user that doesn't have permissions to use the action or resource, or
        /// specifying an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClusterNotFoundException">
        /// The specified cluster could not be found. You can view your available clusters with
        /// <a>ListClusters</a>. Amazon ECS clusters are Region-specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);



        /// <summary>
        /// Deletes specified tags from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action, such as using an action or resource
        /// on behalf of a user that doesn't have permissions to use the action or resource, or
        /// specifying an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClusterNotFoundException">
        /// The specified cluster could not be found. You can view your available clusters with
        /// <a>ListClusters</a>. Amazon ECS clusters are Region-specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateCapacityProvider


        /// <summary>
        /// Modifies the parameters for a capacity provider.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCapacityProvider service method.</param>
        /// 
        /// <returns>The response from the UpdateCapacityProvider service method, as returned by ECS.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/UpdateCapacityProvider">REST API Reference for UpdateCapacityProvider Operation</seealso>
        UpdateCapacityProviderResponse UpdateCapacityProvider(UpdateCapacityProviderRequest request);



        /// <summary>
        /// Modifies the parameters for a capacity provider.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCapacityProvider service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateCapacityProvider service method, as returned by ECS.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/UpdateCapacityProvider">REST API Reference for UpdateCapacityProvider Operation</seealso>
        Task<UpdateCapacityProviderResponse> UpdateCapacityProviderAsync(UpdateCapacityProviderRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateClusterSettings


        /// <summary>
        /// Modifies the settings to use for a cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateClusterSettings service method.</param>
        /// 
        /// <returns>The response from the UpdateClusterSettings service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action, such as using an action or resource
        /// on behalf of a user that doesn't have permissions to use the action or resource, or
        /// specifying an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClusterNotFoundException">
        /// The specified cluster could not be found. You can view your available clusters with
        /// <a>ListClusters</a>. Amazon ECS clusters are Region-specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/UpdateClusterSettings">REST API Reference for UpdateClusterSettings Operation</seealso>
        UpdateClusterSettingsResponse UpdateClusterSettings(UpdateClusterSettingsRequest request);



        /// <summary>
        /// Modifies the settings to use for a cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateClusterSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateClusterSettings service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action, such as using an action or resource
        /// on behalf of a user that doesn't have permissions to use the action or resource, or
        /// specifying an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClusterNotFoundException">
        /// The specified cluster could not be found. You can view your available clusters with
        /// <a>ListClusters</a>. Amazon ECS clusters are Region-specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/UpdateClusterSettings">REST API Reference for UpdateClusterSettings Operation</seealso>
        Task<UpdateClusterSettingsResponse> UpdateClusterSettingsAsync(UpdateClusterSettingsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// the Amazon ECS container agent on other operating systems, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/ecs-agent-update.html#manually_update_agent">Manually
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
        /// <a>ListClusters</a>. Amazon ECS clusters are Region-specific.
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
        UpdateContainerAgentResponse UpdateContainerAgent(UpdateContainerAgentRequest request);



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
        /// the Amazon ECS container agent on other operating systems, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/ecs-agent-update.html#manually_update_agent">Manually
        /// Updating the Amazon ECS Container Agent</a> in the <i>Amazon Elastic Container Service
        /// Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateContainerAgent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateContainerAgent service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action, such as using an action or resource
        /// on behalf of a user that doesn't have permissions to use the action or resource, or
        /// specifying an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClusterNotFoundException">
        /// The specified cluster could not be found. You can view your available clusters with
        /// <a>ListClusters</a>. Amazon ECS clusters are Region-specific.
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
        Task<UpdateContainerAgentResponse> UpdateContainerAgentAsync(UpdateContainerAgentRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateContainerInstancesState


        /// <summary>
        /// Modifies the status of an Amazon ECS container instance.
        /// 
        ///  
        /// <para>
        /// Once a container instance has reached an <code>ACTIVE</code> state, you can change
        /// the status of a container instance to <code>DRAINING</code> to manually remove an
        /// instance from a cluster, for example to perform system updates, update the Docker
        /// daemon, or scale down the cluster size.
        /// </para>
        ///  <important> 
        /// <para>
        /// A container instance cannot be changed to <code>DRAINING</code> until it has reached
        /// an <code>ACTIVE</code> status. If the instance is in any other status, an error will
        /// be received.
        /// </para>
        ///  </important> 
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
        /// batch size. For example, if <code>desiredCount</code> is four tasks, a maximum of
        /// 200% starts four new tasks before stopping the four tasks to be drained, provided
        /// that the cluster resources required to do this are available. If the maximum is 100%,
        /// then replacement tasks can't start until the draining tasks have stopped.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Any <code>PENDING</code> or <code>RUNNING</code> tasks that do not belong to a service
        /// are not affected. You must wait for them to finish or stop them manually.
        /// </para>
        ///  
        /// <para>
        /// A container instance has completed draining when it has no more <code>RUNNING</code>
        /// tasks. You can verify this using <a>ListTasks</a>.
        /// </para>
        ///  
        /// <para>
        /// When a container instance has been drained, you can set a container instance to <code>ACTIVE</code>
        /// status and once it has reached that status the Amazon ECS scheduler can begin scheduling
        /// tasks on the instance again.
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
        /// <a>ListClusters</a>. Amazon ECS clusters are Region-specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/UpdateContainerInstancesState">REST API Reference for UpdateContainerInstancesState Operation</seealso>
        UpdateContainerInstancesStateResponse UpdateContainerInstancesState(UpdateContainerInstancesStateRequest request);



        /// <summary>
        /// Modifies the status of an Amazon ECS container instance.
        /// 
        ///  
        /// <para>
        /// Once a container instance has reached an <code>ACTIVE</code> state, you can change
        /// the status of a container instance to <code>DRAINING</code> to manually remove an
        /// instance from a cluster, for example to perform system updates, update the Docker
        /// daemon, or scale down the cluster size.
        /// </para>
        ///  <important> 
        /// <para>
        /// A container instance cannot be changed to <code>DRAINING</code> until it has reached
        /// an <code>ACTIVE</code> status. If the instance is in any other status, an error will
        /// be received.
        /// </para>
        ///  </important> 
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
        /// batch size. For example, if <code>desiredCount</code> is four tasks, a maximum of
        /// 200% starts four new tasks before stopping the four tasks to be drained, provided
        /// that the cluster resources required to do this are available. If the maximum is 100%,
        /// then replacement tasks can't start until the draining tasks have stopped.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Any <code>PENDING</code> or <code>RUNNING</code> tasks that do not belong to a service
        /// are not affected. You must wait for them to finish or stop them manually.
        /// </para>
        ///  
        /// <para>
        /// A container instance has completed draining when it has no more <code>RUNNING</code>
        /// tasks. You can verify this using <a>ListTasks</a>.
        /// </para>
        ///  
        /// <para>
        /// When a container instance has been drained, you can set a container instance to <code>ACTIVE</code>
        /// status and once it has reached that status the Amazon ECS scheduler can begin scheduling
        /// tasks on the instance again.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateContainerInstancesState service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateContainerInstancesState service method, as returned by ECS.</returns>
        /// <exception cref="Amazon.ECS.Model.ClientException">
        /// These errors are usually caused by a client action, such as using an action or resource
        /// on behalf of a user that doesn't have permissions to use the action or resource, or
        /// specifying an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ClusterNotFoundException">
        /// The specified cluster could not be found. You can view your available clusters with
        /// <a>ListClusters</a>. Amazon ECS clusters are Region-specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/UpdateContainerInstancesState">REST API Reference for UpdateContainerInstancesState Operation</seealso>
        Task<UpdateContainerInstancesStateResponse> UpdateContainerInstancesStateAsync(UpdateContainerInstancesStateRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateService


        /// <summary>
        /// <important> 
        /// <para>
        /// Updating the task placement strategies and constraints on an Amazon ECS service remains
        /// in preview and is a Beta Service as defined by and subject to the Beta Service Participation
        /// Service Terms located at <a href="https://aws.amazon.com/service-terms">https://aws.amazon.com/service-terms</a>
        /// ("Beta Terms"). These Beta Terms apply to your participation in this preview.
        /// </para>
        ///  </important> 
        /// <para>
        /// Modifies the parameters of a service.
        /// </para>
        ///  
        /// <para>
        /// For services using the rolling update (<code>ECS</code>) deployment controller, the
        /// desired count, deployment configuration, network configuration, task placement constraints
        /// and strategies, or task definition used can be updated.
        /// </para>
        ///  
        /// <para>
        /// For services using the blue/green (<code>CODE_DEPLOY</code>) deployment controller,
        /// only the desired count, deployment configuration, task placement constraints and strategies,
        /// and health check grace period can be updated using this API. If the network configuration,
        /// platform version, or task definition need to be updated, a new AWS CodeDeploy deployment
        /// should be created. For more information, see <a href="https://docs.aws.amazon.com/codedeploy/latest/APIReference/API_CreateDeployment.html">CreateDeployment</a>
        /// in the <i>AWS CodeDeploy API Reference</i>.
        /// </para>
        ///  
        /// <para>
        /// For services using an external deployment controller, you can update only the desired
        /// count, task placement constraints and strategies, and health check grace period using
        /// this API. If the launch type, load balancer, network configuration, platform version,
        /// or task definition need to be updated, you should create a new task set. For more
        /// information, see <a>CreateTaskSet</a>.
        /// </para>
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
        /// <a>ListClusters</a>. Amazon ECS clusters are Region-specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.PlatformTaskDefinitionIncompatibilityException">
        /// The specified platform version does not satisfy the task definition's required capabilities.
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
        /// <a>ListServices</a>. Amazon ECS services are cluster-specific and Region-specific.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/UpdateService">REST API Reference for UpdateService Operation</seealso>
        UpdateServiceResponse UpdateService(UpdateServiceRequest request);



        /// <summary>
        /// <important> 
        /// <para>
        /// Updating the task placement strategies and constraints on an Amazon ECS service remains
        /// in preview and is a Beta Service as defined by and subject to the Beta Service Participation
        /// Service Terms located at <a href="https://aws.amazon.com/service-terms">https://aws.amazon.com/service-terms</a>
        /// ("Beta Terms"). These Beta Terms apply to your participation in this preview.
        /// </para>
        ///  </important> 
        /// <para>
        /// Modifies the parameters of a service.
        /// </para>
        ///  
        /// <para>
        /// For services using the rolling update (<code>ECS</code>) deployment controller, the
        /// desired count, deployment configuration, network configuration, task placement constraints
        /// and strategies, or task definition used can be updated.
        /// </para>
        ///  
        /// <para>
        /// For services using the blue/green (<code>CODE_DEPLOY</code>) deployment controller,
        /// only the desired count, deployment configuration, task placement constraints and strategies,
        /// and health check grace period can be updated using this API. If the network configuration,
        /// platform version, or task definition need to be updated, a new AWS CodeDeploy deployment
        /// should be created. For more information, see <a href="https://docs.aws.amazon.com/codedeploy/latest/APIReference/API_CreateDeployment.html">CreateDeployment</a>
        /// in the <i>AWS CodeDeploy API Reference</i>.
        /// </para>
        ///  
        /// <para>
        /// For services using an external deployment controller, you can update only the desired
        /// count, task placement constraints and strategies, and health check grace period using
        /// this API. If the launch type, load balancer, network configuration, platform version,
        /// or task definition need to be updated, you should create a new task set. For more
        /// information, see <a>CreateTaskSet</a>.
        /// </para>
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// <a>ListClusters</a>. Amazon ECS clusters are Region-specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.PlatformTaskDefinitionIncompatibilityException">
        /// The specified platform version does not satisfy the task definition's required capabilities.
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
        /// <a>ListServices</a>. Amazon ECS services are cluster-specific and Region-specific.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/UpdateService">REST API Reference for UpdateService Operation</seealso>
        Task<UpdateServiceResponse> UpdateServiceAsync(UpdateServiceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateServicePrimaryTaskSet


        /// <summary>
        /// Modifies which task set in a service is the primary task set. Any parameters that
        /// are updated on the primary task set in a service will transition to the service. This
        /// is used when a service uses the <code>EXTERNAL</code> deployment controller type.
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/deployment-types.html">Amazon
        /// ECS Deployment Types</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateServicePrimaryTaskSet service method.</param>
        /// 
        /// <returns>The response from the UpdateServicePrimaryTaskSet service method, as returned by ECS.</returns>
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
        /// <a>ListClusters</a>. Amazon ECS clusters are Region-specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
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
        /// <a>ListServices</a>. Amazon ECS services are cluster-specific and Region-specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.TaskSetNotFoundException">
        /// The specified task set could not be found. You can view your available task sets with
        /// <a>DescribeTaskSets</a>. Task sets are specific to each cluster, service and Region.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.UnsupportedFeatureException">
        /// The specified task is not supported in this Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/UpdateServicePrimaryTaskSet">REST API Reference for UpdateServicePrimaryTaskSet Operation</seealso>
        UpdateServicePrimaryTaskSetResponse UpdateServicePrimaryTaskSet(UpdateServicePrimaryTaskSetRequest request);



        /// <summary>
        /// Modifies which task set in a service is the primary task set. Any parameters that
        /// are updated on the primary task set in a service will transition to the service. This
        /// is used when a service uses the <code>EXTERNAL</code> deployment controller type.
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/deployment-types.html">Amazon
        /// ECS Deployment Types</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateServicePrimaryTaskSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateServicePrimaryTaskSet service method, as returned by ECS.</returns>
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
        /// <a>ListClusters</a>. Amazon ECS clusters are Region-specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
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
        /// <a>ListServices</a>. Amazon ECS services are cluster-specific and Region-specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.TaskSetNotFoundException">
        /// The specified task set could not be found. You can view your available task sets with
        /// <a>DescribeTaskSets</a>. Task sets are specific to each cluster, service and Region.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.UnsupportedFeatureException">
        /// The specified task is not supported in this Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/UpdateServicePrimaryTaskSet">REST API Reference for UpdateServicePrimaryTaskSet Operation</seealso>
        Task<UpdateServicePrimaryTaskSetResponse> UpdateServicePrimaryTaskSetAsync(UpdateServicePrimaryTaskSetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateTaskSet


        /// <summary>
        /// Modifies a task set. This is used when a service uses the <code>EXTERNAL</code> deployment
        /// controller type. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/deployment-types.html">Amazon
        /// ECS Deployment Types</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTaskSet service method.</param>
        /// 
        /// <returns>The response from the UpdateTaskSet service method, as returned by ECS.</returns>
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
        /// <a>ListClusters</a>. Amazon ECS clusters are Region-specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
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
        /// <a>ListServices</a>. Amazon ECS services are cluster-specific and Region-specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.TaskSetNotFoundException">
        /// The specified task set could not be found. You can view your available task sets with
        /// <a>DescribeTaskSets</a>. Task sets are specific to each cluster, service and Region.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.UnsupportedFeatureException">
        /// The specified task is not supported in this Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/UpdateTaskSet">REST API Reference for UpdateTaskSet Operation</seealso>
        UpdateTaskSetResponse UpdateTaskSet(UpdateTaskSetRequest request);



        /// <summary>
        /// Modifies a task set. This is used when a service uses the <code>EXTERNAL</code> deployment
        /// controller type. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/deployment-types.html">Amazon
        /// ECS Deployment Types</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTaskSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateTaskSet service method, as returned by ECS.</returns>
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
        /// <a>ListClusters</a>. Amazon ECS clusters are Region-specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
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
        /// <a>ListServices</a>. Amazon ECS services are cluster-specific and Region-specific.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.TaskSetNotFoundException">
        /// The specified task set could not be found. You can view your available task sets with
        /// <a>DescribeTaskSets</a>. Task sets are specific to each cluster, service and Region.
        /// </exception>
        /// <exception cref="Amazon.ECS.Model.UnsupportedFeatureException">
        /// The specified task is not supported in this Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecs-2014-11-13/UpdateTaskSet">REST API Reference for UpdateTaskSet Operation</seealso>
        Task<UpdateTaskSetResponse> UpdateTaskSetAsync(UpdateTaskSetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}