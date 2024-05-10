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
 * Do not modify this file. This file is generated from the batch-2016-08-10.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.Batch.Model;

#pragma warning disable CS1570
namespace Amazon.Batch
{
    /// <summary>
    /// <para>Interface for accessing Batch</para>
    ///
    /// Batch 
    /// <para>
    /// Using Batch, you can run batch computing workloads on the Amazon Web Services Cloud.
    /// Batch computing is a common means for developers, scientists, and engineers to access
    /// large amounts of compute resources. Batch uses the advantages of the batch computing
    /// to remove the undifferentiated heavy lifting of configuring and managing required
    /// infrastructure. At the same time, it also adopts a familiar batch computing software
    /// approach. You can use Batch to efficiently provision resources, and work toward eliminating
    /// capacity constraints, reducing your overall compute costs, and delivering results
    /// more quickly.
    /// </para>
    ///  
    /// <para>
    /// As a fully managed service, Batch can run batch computing workloads of any scale.
    /// Batch automatically provisions compute resources and optimizes workload distribution
    /// based on the quantity and scale of your specific workloads. With Batch, there's no
    /// need to install or manage batch computing software. This means that you can focus
    /// on analyzing results and solving your specific problems instead.
    /// </para>
    /// </summary>
    public partial interface IAmazonBatch : IAmazonService, IDisposable
    {

        /// <summary>
        /// Paginators for the service
        /// </summary>
        IBatchPaginatorFactory Paginators { get; }

        
        #region  CancelJob


        /// <summary>
        /// Cancels a job in an Batch job queue. Jobs that are in the <c>SUBMITTED</c> or <c>PENDING</c>
        /// are canceled. A job in<c>RUNNABLE</c> remains in <c>RUNNABLE</c> until it reaches
        /// the head of the job queue. Then the job status is updated to <c>FAILED</c>.
        /// 
        ///  <note> 
        /// <para>
        /// A <c>PENDING</c> job is canceled after all dependency jobs are completed. Therefore,
        /// it may take longer than expected to cancel a job in <c>PENDING</c> status.
        /// </para>
        ///  
        /// <para>
        /// When you try to cancel an array parent job in <c>PENDING</c>, Batch attempts to cancel
        /// all child jobs. The array parent job is canceled when all child jobs are completed.
        /// </para>
        ///  </note> 
        /// <para>
        /// Jobs that progressed to the <c>STARTING</c> or <c>RUNNING</c> state aren't canceled.
        /// However, the API operation still succeeds, even if no job is canceled. These jobs
        /// must be terminated with the <a>TerminateJob</a> operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelJob service method.</param>
        /// 
        /// <returns>The response from the CancelJob service method, as returned by Batch.</returns>
        /// <exception cref="Amazon.Batch.Model.ClientException">
        /// These errors are usually caused by a client action. One example cause is using an
        /// action or resource on behalf of a user that doesn't have permissions to use the action
        /// or resource. Another cause is specifying an identifier that's not valid.
        /// </exception>
        /// <exception cref="Amazon.Batch.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/CancelJob">REST API Reference for CancelJob Operation</seealso>
        CancelJobResponse CancelJob(CancelJobRequest request);



        /// <summary>
        /// Cancels a job in an Batch job queue. Jobs that are in the <c>SUBMITTED</c> or <c>PENDING</c>
        /// are canceled. A job in<c>RUNNABLE</c> remains in <c>RUNNABLE</c> until it reaches
        /// the head of the job queue. Then the job status is updated to <c>FAILED</c>.
        /// 
        ///  <note> 
        /// <para>
        /// A <c>PENDING</c> job is canceled after all dependency jobs are completed. Therefore,
        /// it may take longer than expected to cancel a job in <c>PENDING</c> status.
        /// </para>
        ///  
        /// <para>
        /// When you try to cancel an array parent job in <c>PENDING</c>, Batch attempts to cancel
        /// all child jobs. The array parent job is canceled when all child jobs are completed.
        /// </para>
        ///  </note> 
        /// <para>
        /// Jobs that progressed to the <c>STARTING</c> or <c>RUNNING</c> state aren't canceled.
        /// However, the API operation still succeeds, even if no job is canceled. These jobs
        /// must be terminated with the <a>TerminateJob</a> operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelJob service method, as returned by Batch.</returns>
        /// <exception cref="Amazon.Batch.Model.ClientException">
        /// These errors are usually caused by a client action. One example cause is using an
        /// action or resource on behalf of a user that doesn't have permissions to use the action
        /// or resource. Another cause is specifying an identifier that's not valid.
        /// </exception>
        /// <exception cref="Amazon.Batch.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/CancelJob">REST API Reference for CancelJob Operation</seealso>
        Task<CancelJobResponse> CancelJobAsync(CancelJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateComputeEnvironment


        /// <summary>
        /// Creates an Batch compute environment. You can create <c>MANAGED</c> or <c>UNMANAGED</c>
        /// compute environments. <c>MANAGED</c> compute environments can use Amazon EC2 or Fargate
        /// resources. <c>UNMANAGED</c> compute environments can only use EC2 resources.
        /// 
        ///  
        /// <para>
        /// In a managed compute environment, Batch manages the capacity and instance types of
        /// the compute resources within the environment. This is based on the compute resource
        /// specification that you define or the <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-launch-templates.html">launch
        /// template</a> that you specify when you create the compute environment. Either, you
        /// can choose to use EC2 On-Demand Instances and EC2 Spot Instances. Or, you can use
        /// Fargate and Fargate Spot capacity in your managed compute environment. You can optionally
        /// set a maximum price so that Spot Instances only launch when the Spot Instance price
        /// is less than a specified percentage of the On-Demand price.
        /// </para>
        ///  <note> 
        /// <para>
        /// Multi-node parallel jobs aren't supported on Spot Instances.
        /// </para>
        ///  </note> 
        /// <para>
        /// In an unmanaged compute environment, you can manage your own EC2 compute resources
        /// and have flexibility with how you configure your compute resources. For example, you
        /// can use custom AMIs. However, you must verify that each of your AMIs meet the Amazon
        /// ECS container instance AMI specification. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/container_instance_AMIs.html">container
        /// instance AMIs</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// After you created your unmanaged compute environment, you can use the <a>DescribeComputeEnvironments</a>
        /// operation to find the Amazon ECS cluster that's associated with it. Then, launch your
        /// container instances into that Amazon ECS cluster. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/launch_container_instance.html">Launching
        /// an Amazon ECS container instance</a> in the <i>Amazon Elastic Container Service Developer
        /// Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// To create a compute environment that uses EKS resources, the caller must have permissions
        /// to call <c>eks:DescribeCluster</c>.
        /// </para>
        ///  </note> <note> 
        /// <para>
        /// Batch doesn't automatically upgrade the AMIs in a compute environment after it's created.
        /// For example, it also doesn't update the AMIs in your compute environment when a newer
        /// version of the Amazon ECS optimized AMI is available. You're responsible for the management
        /// of the guest operating system. This includes any updates and security patches. You're
        /// also responsible for any additional application software or utilities that you install
        /// on the compute resources. There are two ways to use a new AMI for your Batch jobs.
        /// The original method is to complete these steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Create a new compute environment with the new AMI.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Add the compute environment to an existing job queue.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Remove the earlier compute environment from your job queue.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Delete the earlier compute environment.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// In April 2022, Batch added enhanced support for updating compute environments. For
        /// more information, see <a href="https://docs.aws.amazon.com/batch/latest/userguide/updating-compute-environments.html">Updating
        /// compute environments</a>. To use the enhanced updating of compute environments to
        /// update AMIs, follow these rules:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Either don't set the service role (<c>serviceRole</c>) parameter or set it to the
        /// <b>AWSBatchServiceRole</b> service-linked role.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Set the allocation strategy (<c>allocationStrategy</c>) parameter to <c>BEST_FIT_PROGRESSIVE</c>,
        /// <c>SPOT_CAPACITY_OPTIMIZED</c>, or <c>SPOT_PRICE_CAPACITY_OPTIMIZED</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Set the update to latest image version (<c>updateToLatestImageVersion</c>) parameter
        /// to <c>true</c>. The <c>updateToLatestImageVersion</c> parameter is used when you update
        /// a compute environment. This parameter is ignored when you create a compute environment.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Don't specify an AMI ID in <c>imageId</c>, <c>imageIdOverride</c> (in <a href="https://docs.aws.amazon.com/batch/latest/APIReference/API_Ec2Configuration.html">
        /// <c>ec2Configuration</c> </a>), or in the launch template (<c>launchTemplate</c>).
        /// In that case, Batch selects the latest Amazon ECS optimized AMI that's supported by
        /// Batch at the time the infrastructure update is initiated. Alternatively, you can specify
        /// the AMI ID in the <c>imageId</c> or <c>imageIdOverride</c> parameters, or the launch
        /// template identified by the <c>LaunchTemplate</c> properties. Changing any of these
        /// properties starts an infrastructure update. If the AMI ID is specified in the launch
        /// template, it can't be replaced by specifying an AMI ID in either the <c>imageId</c>
        /// or <c>imageIdOverride</c> parameters. It can only be replaced by specifying a different
        /// launch template, or if the launch template version is set to <c>$Default</c> or <c>$Latest</c>,
        /// by setting either a new default version for the launch template (if <c>$Default</c>)
        /// or by adding a new version to the launch template (if <c>$Latest</c>).
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If these rules are followed, any update that starts an infrastructure update causes
        /// the AMI ID to be re-selected. If the <c>version</c> setting in the launch template
        /// (<c>launchTemplate</c>) is set to <c>$Latest</c> or <c>$Default</c>, the latest or
        /// default version of the launch template is evaluated up at the time of the infrastructure
        /// update, even if the <c>launchTemplate</c> wasn't updated.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateComputeEnvironment service method.</param>
        /// 
        /// <returns>The response from the CreateComputeEnvironment service method, as returned by Batch.</returns>
        /// <exception cref="Amazon.Batch.Model.ClientException">
        /// These errors are usually caused by a client action. One example cause is using an
        /// action or resource on behalf of a user that doesn't have permissions to use the action
        /// or resource. Another cause is specifying an identifier that's not valid.
        /// </exception>
        /// <exception cref="Amazon.Batch.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/CreateComputeEnvironment">REST API Reference for CreateComputeEnvironment Operation</seealso>
        CreateComputeEnvironmentResponse CreateComputeEnvironment(CreateComputeEnvironmentRequest request);



        /// <summary>
        /// Creates an Batch compute environment. You can create <c>MANAGED</c> or <c>UNMANAGED</c>
        /// compute environments. <c>MANAGED</c> compute environments can use Amazon EC2 or Fargate
        /// resources. <c>UNMANAGED</c> compute environments can only use EC2 resources.
        /// 
        ///  
        /// <para>
        /// In a managed compute environment, Batch manages the capacity and instance types of
        /// the compute resources within the environment. This is based on the compute resource
        /// specification that you define or the <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-launch-templates.html">launch
        /// template</a> that you specify when you create the compute environment. Either, you
        /// can choose to use EC2 On-Demand Instances and EC2 Spot Instances. Or, you can use
        /// Fargate and Fargate Spot capacity in your managed compute environment. You can optionally
        /// set a maximum price so that Spot Instances only launch when the Spot Instance price
        /// is less than a specified percentage of the On-Demand price.
        /// </para>
        ///  <note> 
        /// <para>
        /// Multi-node parallel jobs aren't supported on Spot Instances.
        /// </para>
        ///  </note> 
        /// <para>
        /// In an unmanaged compute environment, you can manage your own EC2 compute resources
        /// and have flexibility with how you configure your compute resources. For example, you
        /// can use custom AMIs. However, you must verify that each of your AMIs meet the Amazon
        /// ECS container instance AMI specification. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/container_instance_AMIs.html">container
        /// instance AMIs</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// After you created your unmanaged compute environment, you can use the <a>DescribeComputeEnvironments</a>
        /// operation to find the Amazon ECS cluster that's associated with it. Then, launch your
        /// container instances into that Amazon ECS cluster. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/launch_container_instance.html">Launching
        /// an Amazon ECS container instance</a> in the <i>Amazon Elastic Container Service Developer
        /// Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// To create a compute environment that uses EKS resources, the caller must have permissions
        /// to call <c>eks:DescribeCluster</c>.
        /// </para>
        ///  </note> <note> 
        /// <para>
        /// Batch doesn't automatically upgrade the AMIs in a compute environment after it's created.
        /// For example, it also doesn't update the AMIs in your compute environment when a newer
        /// version of the Amazon ECS optimized AMI is available. You're responsible for the management
        /// of the guest operating system. This includes any updates and security patches. You're
        /// also responsible for any additional application software or utilities that you install
        /// on the compute resources. There are two ways to use a new AMI for your Batch jobs.
        /// The original method is to complete these steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Create a new compute environment with the new AMI.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Add the compute environment to an existing job queue.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Remove the earlier compute environment from your job queue.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Delete the earlier compute environment.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// In April 2022, Batch added enhanced support for updating compute environments. For
        /// more information, see <a href="https://docs.aws.amazon.com/batch/latest/userguide/updating-compute-environments.html">Updating
        /// compute environments</a>. To use the enhanced updating of compute environments to
        /// update AMIs, follow these rules:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Either don't set the service role (<c>serviceRole</c>) parameter or set it to the
        /// <b>AWSBatchServiceRole</b> service-linked role.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Set the allocation strategy (<c>allocationStrategy</c>) parameter to <c>BEST_FIT_PROGRESSIVE</c>,
        /// <c>SPOT_CAPACITY_OPTIMIZED</c>, or <c>SPOT_PRICE_CAPACITY_OPTIMIZED</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Set the update to latest image version (<c>updateToLatestImageVersion</c>) parameter
        /// to <c>true</c>. The <c>updateToLatestImageVersion</c> parameter is used when you update
        /// a compute environment. This parameter is ignored when you create a compute environment.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Don't specify an AMI ID in <c>imageId</c>, <c>imageIdOverride</c> (in <a href="https://docs.aws.amazon.com/batch/latest/APIReference/API_Ec2Configuration.html">
        /// <c>ec2Configuration</c> </a>), or in the launch template (<c>launchTemplate</c>).
        /// In that case, Batch selects the latest Amazon ECS optimized AMI that's supported by
        /// Batch at the time the infrastructure update is initiated. Alternatively, you can specify
        /// the AMI ID in the <c>imageId</c> or <c>imageIdOverride</c> parameters, or the launch
        /// template identified by the <c>LaunchTemplate</c> properties. Changing any of these
        /// properties starts an infrastructure update. If the AMI ID is specified in the launch
        /// template, it can't be replaced by specifying an AMI ID in either the <c>imageId</c>
        /// or <c>imageIdOverride</c> parameters. It can only be replaced by specifying a different
        /// launch template, or if the launch template version is set to <c>$Default</c> or <c>$Latest</c>,
        /// by setting either a new default version for the launch template (if <c>$Default</c>)
        /// or by adding a new version to the launch template (if <c>$Latest</c>).
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If these rules are followed, any update that starts an infrastructure update causes
        /// the AMI ID to be re-selected. If the <c>version</c> setting in the launch template
        /// (<c>launchTemplate</c>) is set to <c>$Latest</c> or <c>$Default</c>, the latest or
        /// default version of the launch template is evaluated up at the time of the infrastructure
        /// update, even if the <c>launchTemplate</c> wasn't updated.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateComputeEnvironment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateComputeEnvironment service method, as returned by Batch.</returns>
        /// <exception cref="Amazon.Batch.Model.ClientException">
        /// These errors are usually caused by a client action. One example cause is using an
        /// action or resource on behalf of a user that doesn't have permissions to use the action
        /// or resource. Another cause is specifying an identifier that's not valid.
        /// </exception>
        /// <exception cref="Amazon.Batch.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/CreateComputeEnvironment">REST API Reference for CreateComputeEnvironment Operation</seealso>
        Task<CreateComputeEnvironmentResponse> CreateComputeEnvironmentAsync(CreateComputeEnvironmentRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateJobQueue


        /// <summary>
        /// Creates an Batch job queue. When you create a job queue, you associate one or more
        /// compute environments to the queue and assign an order of preference for the compute
        /// environments.
        /// 
        ///  
        /// <para>
        /// You also set a priority to the job queue that determines the order that the Batch
        /// scheduler places jobs onto its associated compute environments. For example, if a
        /// compute environment is associated with more than one job queue, the job queue with
        /// a higher priority is given preference for scheduling jobs to that compute environment.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateJobQueue service method.</param>
        /// 
        /// <returns>The response from the CreateJobQueue service method, as returned by Batch.</returns>
        /// <exception cref="Amazon.Batch.Model.ClientException">
        /// These errors are usually caused by a client action. One example cause is using an
        /// action or resource on behalf of a user that doesn't have permissions to use the action
        /// or resource. Another cause is specifying an identifier that's not valid.
        /// </exception>
        /// <exception cref="Amazon.Batch.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/CreateJobQueue">REST API Reference for CreateJobQueue Operation</seealso>
        CreateJobQueueResponse CreateJobQueue(CreateJobQueueRequest request);



        /// <summary>
        /// Creates an Batch job queue. When you create a job queue, you associate one or more
        /// compute environments to the queue and assign an order of preference for the compute
        /// environments.
        /// 
        ///  
        /// <para>
        /// You also set a priority to the job queue that determines the order that the Batch
        /// scheduler places jobs onto its associated compute environments. For example, if a
        /// compute environment is associated with more than one job queue, the job queue with
        /// a higher priority is given preference for scheduling jobs to that compute environment.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateJobQueue service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateJobQueue service method, as returned by Batch.</returns>
        /// <exception cref="Amazon.Batch.Model.ClientException">
        /// These errors are usually caused by a client action. One example cause is using an
        /// action or resource on behalf of a user that doesn't have permissions to use the action
        /// or resource. Another cause is specifying an identifier that's not valid.
        /// </exception>
        /// <exception cref="Amazon.Batch.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/CreateJobQueue">REST API Reference for CreateJobQueue Operation</seealso>
        Task<CreateJobQueueResponse> CreateJobQueueAsync(CreateJobQueueRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateSchedulingPolicy


        /// <summary>
        /// Creates an Batch scheduling policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSchedulingPolicy service method.</param>
        /// 
        /// <returns>The response from the CreateSchedulingPolicy service method, as returned by Batch.</returns>
        /// <exception cref="Amazon.Batch.Model.ClientException">
        /// These errors are usually caused by a client action. One example cause is using an
        /// action or resource on behalf of a user that doesn't have permissions to use the action
        /// or resource. Another cause is specifying an identifier that's not valid.
        /// </exception>
        /// <exception cref="Amazon.Batch.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/CreateSchedulingPolicy">REST API Reference for CreateSchedulingPolicy Operation</seealso>
        CreateSchedulingPolicyResponse CreateSchedulingPolicy(CreateSchedulingPolicyRequest request);



        /// <summary>
        /// Creates an Batch scheduling policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSchedulingPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSchedulingPolicy service method, as returned by Batch.</returns>
        /// <exception cref="Amazon.Batch.Model.ClientException">
        /// These errors are usually caused by a client action. One example cause is using an
        /// action or resource on behalf of a user that doesn't have permissions to use the action
        /// or resource. Another cause is specifying an identifier that's not valid.
        /// </exception>
        /// <exception cref="Amazon.Batch.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/CreateSchedulingPolicy">REST API Reference for CreateSchedulingPolicy Operation</seealso>
        Task<CreateSchedulingPolicyResponse> CreateSchedulingPolicyAsync(CreateSchedulingPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteComputeEnvironment


        /// <summary>
        /// Deletes an Batch compute environment.
        /// 
        ///  
        /// <para>
        /// Before you can delete a compute environment, you must set its state to <c>DISABLED</c>
        /// with the <a>UpdateComputeEnvironment</a> API operation and disassociate it from any
        /// job queues with the <a>UpdateJobQueue</a> API operation. Compute environments that
        /// use Fargate resources must terminate all active jobs on that compute environment before
        /// deleting the compute environment. If this isn't done, the compute environment enters
        /// an invalid state.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteComputeEnvironment service method.</param>
        /// 
        /// <returns>The response from the DeleteComputeEnvironment service method, as returned by Batch.</returns>
        /// <exception cref="Amazon.Batch.Model.ClientException">
        /// These errors are usually caused by a client action. One example cause is using an
        /// action or resource on behalf of a user that doesn't have permissions to use the action
        /// or resource. Another cause is specifying an identifier that's not valid.
        /// </exception>
        /// <exception cref="Amazon.Batch.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/DeleteComputeEnvironment">REST API Reference for DeleteComputeEnvironment Operation</seealso>
        DeleteComputeEnvironmentResponse DeleteComputeEnvironment(DeleteComputeEnvironmentRequest request);



        /// <summary>
        /// Deletes an Batch compute environment.
        /// 
        ///  
        /// <para>
        /// Before you can delete a compute environment, you must set its state to <c>DISABLED</c>
        /// with the <a>UpdateComputeEnvironment</a> API operation and disassociate it from any
        /// job queues with the <a>UpdateJobQueue</a> API operation. Compute environments that
        /// use Fargate resources must terminate all active jobs on that compute environment before
        /// deleting the compute environment. If this isn't done, the compute environment enters
        /// an invalid state.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteComputeEnvironment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteComputeEnvironment service method, as returned by Batch.</returns>
        /// <exception cref="Amazon.Batch.Model.ClientException">
        /// These errors are usually caused by a client action. One example cause is using an
        /// action or resource on behalf of a user that doesn't have permissions to use the action
        /// or resource. Another cause is specifying an identifier that's not valid.
        /// </exception>
        /// <exception cref="Amazon.Batch.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/DeleteComputeEnvironment">REST API Reference for DeleteComputeEnvironment Operation</seealso>
        Task<DeleteComputeEnvironmentResponse> DeleteComputeEnvironmentAsync(DeleteComputeEnvironmentRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteJobQueue


        /// <summary>
        /// Deletes the specified job queue. You must first disable submissions for a queue with
        /// the <a>UpdateJobQueue</a> operation. All jobs in the queue are eventually terminated
        /// when you delete a job queue. The jobs are terminated at a rate of about 16 jobs each
        /// second.
        /// 
        ///  
        /// <para>
        /// It's not necessary to disassociate compute environments from a queue before submitting
        /// a <c>DeleteJobQueue</c> request.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteJobQueue service method.</param>
        /// 
        /// <returns>The response from the DeleteJobQueue service method, as returned by Batch.</returns>
        /// <exception cref="Amazon.Batch.Model.ClientException">
        /// These errors are usually caused by a client action. One example cause is using an
        /// action or resource on behalf of a user that doesn't have permissions to use the action
        /// or resource. Another cause is specifying an identifier that's not valid.
        /// </exception>
        /// <exception cref="Amazon.Batch.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/DeleteJobQueue">REST API Reference for DeleteJobQueue Operation</seealso>
        DeleteJobQueueResponse DeleteJobQueue(DeleteJobQueueRequest request);



        /// <summary>
        /// Deletes the specified job queue. You must first disable submissions for a queue with
        /// the <a>UpdateJobQueue</a> operation. All jobs in the queue are eventually terminated
        /// when you delete a job queue. The jobs are terminated at a rate of about 16 jobs each
        /// second.
        /// 
        ///  
        /// <para>
        /// It's not necessary to disassociate compute environments from a queue before submitting
        /// a <c>DeleteJobQueue</c> request.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteJobQueue service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteJobQueue service method, as returned by Batch.</returns>
        /// <exception cref="Amazon.Batch.Model.ClientException">
        /// These errors are usually caused by a client action. One example cause is using an
        /// action or resource on behalf of a user that doesn't have permissions to use the action
        /// or resource. Another cause is specifying an identifier that's not valid.
        /// </exception>
        /// <exception cref="Amazon.Batch.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/DeleteJobQueue">REST API Reference for DeleteJobQueue Operation</seealso>
        Task<DeleteJobQueueResponse> DeleteJobQueueAsync(DeleteJobQueueRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteSchedulingPolicy


        /// <summary>
        /// Deletes the specified scheduling policy.
        /// 
        ///  
        /// <para>
        /// You can't delete a scheduling policy that's used in any job queues.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSchedulingPolicy service method.</param>
        /// 
        /// <returns>The response from the DeleteSchedulingPolicy service method, as returned by Batch.</returns>
        /// <exception cref="Amazon.Batch.Model.ClientException">
        /// These errors are usually caused by a client action. One example cause is using an
        /// action or resource on behalf of a user that doesn't have permissions to use the action
        /// or resource. Another cause is specifying an identifier that's not valid.
        /// </exception>
        /// <exception cref="Amazon.Batch.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/DeleteSchedulingPolicy">REST API Reference for DeleteSchedulingPolicy Operation</seealso>
        DeleteSchedulingPolicyResponse DeleteSchedulingPolicy(DeleteSchedulingPolicyRequest request);



        /// <summary>
        /// Deletes the specified scheduling policy.
        /// 
        ///  
        /// <para>
        /// You can't delete a scheduling policy that's used in any job queues.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSchedulingPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSchedulingPolicy service method, as returned by Batch.</returns>
        /// <exception cref="Amazon.Batch.Model.ClientException">
        /// These errors are usually caused by a client action. One example cause is using an
        /// action or resource on behalf of a user that doesn't have permissions to use the action
        /// or resource. Another cause is specifying an identifier that's not valid.
        /// </exception>
        /// <exception cref="Amazon.Batch.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/DeleteSchedulingPolicy">REST API Reference for DeleteSchedulingPolicy Operation</seealso>
        Task<DeleteSchedulingPolicyResponse> DeleteSchedulingPolicyAsync(DeleteSchedulingPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeregisterJobDefinition


        /// <summary>
        /// Deregisters an Batch job definition. Job definitions are permanently deleted after
        /// 180 days.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterJobDefinition service method.</param>
        /// 
        /// <returns>The response from the DeregisterJobDefinition service method, as returned by Batch.</returns>
        /// <exception cref="Amazon.Batch.Model.ClientException">
        /// These errors are usually caused by a client action. One example cause is using an
        /// action or resource on behalf of a user that doesn't have permissions to use the action
        /// or resource. Another cause is specifying an identifier that's not valid.
        /// </exception>
        /// <exception cref="Amazon.Batch.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/DeregisterJobDefinition">REST API Reference for DeregisterJobDefinition Operation</seealso>
        DeregisterJobDefinitionResponse DeregisterJobDefinition(DeregisterJobDefinitionRequest request);



        /// <summary>
        /// Deregisters an Batch job definition. Job definitions are permanently deleted after
        /// 180 days.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterJobDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeregisterJobDefinition service method, as returned by Batch.</returns>
        /// <exception cref="Amazon.Batch.Model.ClientException">
        /// These errors are usually caused by a client action. One example cause is using an
        /// action or resource on behalf of a user that doesn't have permissions to use the action
        /// or resource. Another cause is specifying an identifier that's not valid.
        /// </exception>
        /// <exception cref="Amazon.Batch.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/DeregisterJobDefinition">REST API Reference for DeregisterJobDefinition Operation</seealso>
        Task<DeregisterJobDefinitionResponse> DeregisterJobDefinitionAsync(DeregisterJobDefinitionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeComputeEnvironments


        /// <summary>
        /// Describes one or more of your compute environments.
        /// 
        ///  
        /// <para>
        /// If you're using an unmanaged compute environment, you can use the <c>DescribeComputeEnvironment</c>
        /// operation to determine the <c>ecsClusterArn</c> that you launch your Amazon ECS container
        /// instances into.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeComputeEnvironments service method.</param>
        /// 
        /// <returns>The response from the DescribeComputeEnvironments service method, as returned by Batch.</returns>
        /// <exception cref="Amazon.Batch.Model.ClientException">
        /// These errors are usually caused by a client action. One example cause is using an
        /// action or resource on behalf of a user that doesn't have permissions to use the action
        /// or resource. Another cause is specifying an identifier that's not valid.
        /// </exception>
        /// <exception cref="Amazon.Batch.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/DescribeComputeEnvironments">REST API Reference for DescribeComputeEnvironments Operation</seealso>
        DescribeComputeEnvironmentsResponse DescribeComputeEnvironments(DescribeComputeEnvironmentsRequest request);



        /// <summary>
        /// Describes one or more of your compute environments.
        /// 
        ///  
        /// <para>
        /// If you're using an unmanaged compute environment, you can use the <c>DescribeComputeEnvironment</c>
        /// operation to determine the <c>ecsClusterArn</c> that you launch your Amazon ECS container
        /// instances into.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeComputeEnvironments service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeComputeEnvironments service method, as returned by Batch.</returns>
        /// <exception cref="Amazon.Batch.Model.ClientException">
        /// These errors are usually caused by a client action. One example cause is using an
        /// action or resource on behalf of a user that doesn't have permissions to use the action
        /// or resource. Another cause is specifying an identifier that's not valid.
        /// </exception>
        /// <exception cref="Amazon.Batch.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/DescribeComputeEnvironments">REST API Reference for DescribeComputeEnvironments Operation</seealso>
        Task<DescribeComputeEnvironmentsResponse> DescribeComputeEnvironmentsAsync(DescribeComputeEnvironmentsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeJobDefinitions


        /// <summary>
        /// Describes a list of job definitions. You can specify a <c>status</c> (such as <c>ACTIVE</c>)
        /// to only return job definitions that match that status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeJobDefinitions service method.</param>
        /// 
        /// <returns>The response from the DescribeJobDefinitions service method, as returned by Batch.</returns>
        /// <exception cref="Amazon.Batch.Model.ClientException">
        /// These errors are usually caused by a client action. One example cause is using an
        /// action or resource on behalf of a user that doesn't have permissions to use the action
        /// or resource. Another cause is specifying an identifier that's not valid.
        /// </exception>
        /// <exception cref="Amazon.Batch.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/DescribeJobDefinitions">REST API Reference for DescribeJobDefinitions Operation</seealso>
        DescribeJobDefinitionsResponse DescribeJobDefinitions(DescribeJobDefinitionsRequest request);



        /// <summary>
        /// Describes a list of job definitions. You can specify a <c>status</c> (such as <c>ACTIVE</c>)
        /// to only return job definitions that match that status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeJobDefinitions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeJobDefinitions service method, as returned by Batch.</returns>
        /// <exception cref="Amazon.Batch.Model.ClientException">
        /// These errors are usually caused by a client action. One example cause is using an
        /// action or resource on behalf of a user that doesn't have permissions to use the action
        /// or resource. Another cause is specifying an identifier that's not valid.
        /// </exception>
        /// <exception cref="Amazon.Batch.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/DescribeJobDefinitions">REST API Reference for DescribeJobDefinitions Operation</seealso>
        Task<DescribeJobDefinitionsResponse> DescribeJobDefinitionsAsync(DescribeJobDefinitionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeJobQueues


        /// <summary>
        /// Describes one or more of your job queues.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeJobQueues service method.</param>
        /// 
        /// <returns>The response from the DescribeJobQueues service method, as returned by Batch.</returns>
        /// <exception cref="Amazon.Batch.Model.ClientException">
        /// These errors are usually caused by a client action. One example cause is using an
        /// action or resource on behalf of a user that doesn't have permissions to use the action
        /// or resource. Another cause is specifying an identifier that's not valid.
        /// </exception>
        /// <exception cref="Amazon.Batch.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/DescribeJobQueues">REST API Reference for DescribeJobQueues Operation</seealso>
        DescribeJobQueuesResponse DescribeJobQueues(DescribeJobQueuesRequest request);



        /// <summary>
        /// Describes one or more of your job queues.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeJobQueues service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeJobQueues service method, as returned by Batch.</returns>
        /// <exception cref="Amazon.Batch.Model.ClientException">
        /// These errors are usually caused by a client action. One example cause is using an
        /// action or resource on behalf of a user that doesn't have permissions to use the action
        /// or resource. Another cause is specifying an identifier that's not valid.
        /// </exception>
        /// <exception cref="Amazon.Batch.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/DescribeJobQueues">REST API Reference for DescribeJobQueues Operation</seealso>
        Task<DescribeJobQueuesResponse> DescribeJobQueuesAsync(DescribeJobQueuesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeJobs


        /// <summary>
        /// Describes a list of Batch jobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeJobs service method.</param>
        /// 
        /// <returns>The response from the DescribeJobs service method, as returned by Batch.</returns>
        /// <exception cref="Amazon.Batch.Model.ClientException">
        /// These errors are usually caused by a client action. One example cause is using an
        /// action or resource on behalf of a user that doesn't have permissions to use the action
        /// or resource. Another cause is specifying an identifier that's not valid.
        /// </exception>
        /// <exception cref="Amazon.Batch.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/DescribeJobs">REST API Reference for DescribeJobs Operation</seealso>
        DescribeJobsResponse DescribeJobs(DescribeJobsRequest request);



        /// <summary>
        /// Describes a list of Batch jobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeJobs service method, as returned by Batch.</returns>
        /// <exception cref="Amazon.Batch.Model.ClientException">
        /// These errors are usually caused by a client action. One example cause is using an
        /// action or resource on behalf of a user that doesn't have permissions to use the action
        /// or resource. Another cause is specifying an identifier that's not valid.
        /// </exception>
        /// <exception cref="Amazon.Batch.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/DescribeJobs">REST API Reference for DescribeJobs Operation</seealso>
        Task<DescribeJobsResponse> DescribeJobsAsync(DescribeJobsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeSchedulingPolicies


        /// <summary>
        /// Describes one or more of your scheduling policies.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSchedulingPolicies service method.</param>
        /// 
        /// <returns>The response from the DescribeSchedulingPolicies service method, as returned by Batch.</returns>
        /// <exception cref="Amazon.Batch.Model.ClientException">
        /// These errors are usually caused by a client action. One example cause is using an
        /// action or resource on behalf of a user that doesn't have permissions to use the action
        /// or resource. Another cause is specifying an identifier that's not valid.
        /// </exception>
        /// <exception cref="Amazon.Batch.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/DescribeSchedulingPolicies">REST API Reference for DescribeSchedulingPolicies Operation</seealso>
        DescribeSchedulingPoliciesResponse DescribeSchedulingPolicies(DescribeSchedulingPoliciesRequest request);



        /// <summary>
        /// Describes one or more of your scheduling policies.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSchedulingPolicies service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeSchedulingPolicies service method, as returned by Batch.</returns>
        /// <exception cref="Amazon.Batch.Model.ClientException">
        /// These errors are usually caused by a client action. One example cause is using an
        /// action or resource on behalf of a user that doesn't have permissions to use the action
        /// or resource. Another cause is specifying an identifier that's not valid.
        /// </exception>
        /// <exception cref="Amazon.Batch.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/DescribeSchedulingPolicies">REST API Reference for DescribeSchedulingPolicies Operation</seealso>
        Task<DescribeSchedulingPoliciesResponse> DescribeSchedulingPoliciesAsync(DescribeSchedulingPoliciesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListJobs


        /// <summary>
        /// Returns a list of Batch jobs.
        /// 
        ///  
        /// <para>
        /// You must specify only one of the following items:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A job queue ID to return a list of jobs in that job queue
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A multi-node parallel job ID to return a list of nodes for that job
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An array job ID to return a list of the children for that job
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You can filter the results by job status with the <c>jobStatus</c> parameter. If you
        /// don't specify a status, only <c>RUNNING</c> jobs are returned.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListJobs service method.</param>
        /// 
        /// <returns>The response from the ListJobs service method, as returned by Batch.</returns>
        /// <exception cref="Amazon.Batch.Model.ClientException">
        /// These errors are usually caused by a client action. One example cause is using an
        /// action or resource on behalf of a user that doesn't have permissions to use the action
        /// or resource. Another cause is specifying an identifier that's not valid.
        /// </exception>
        /// <exception cref="Amazon.Batch.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/ListJobs">REST API Reference for ListJobs Operation</seealso>
        ListJobsResponse ListJobs(ListJobsRequest request);



        /// <summary>
        /// Returns a list of Batch jobs.
        /// 
        ///  
        /// <para>
        /// You must specify only one of the following items:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A job queue ID to return a list of jobs in that job queue
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A multi-node parallel job ID to return a list of nodes for that job
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An array job ID to return a list of the children for that job
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You can filter the results by job status with the <c>jobStatus</c> parameter. If you
        /// don't specify a status, only <c>RUNNING</c> jobs are returned.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListJobs service method, as returned by Batch.</returns>
        /// <exception cref="Amazon.Batch.Model.ClientException">
        /// These errors are usually caused by a client action. One example cause is using an
        /// action or resource on behalf of a user that doesn't have permissions to use the action
        /// or resource. Another cause is specifying an identifier that's not valid.
        /// </exception>
        /// <exception cref="Amazon.Batch.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/ListJobs">REST API Reference for ListJobs Operation</seealso>
        Task<ListJobsResponse> ListJobsAsync(ListJobsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListSchedulingPolicies


        /// <summary>
        /// Returns a list of Batch scheduling policies.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSchedulingPolicies service method.</param>
        /// 
        /// <returns>The response from the ListSchedulingPolicies service method, as returned by Batch.</returns>
        /// <exception cref="Amazon.Batch.Model.ClientException">
        /// These errors are usually caused by a client action. One example cause is using an
        /// action or resource on behalf of a user that doesn't have permissions to use the action
        /// or resource. Another cause is specifying an identifier that's not valid.
        /// </exception>
        /// <exception cref="Amazon.Batch.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/ListSchedulingPolicies">REST API Reference for ListSchedulingPolicies Operation</seealso>
        ListSchedulingPoliciesResponse ListSchedulingPolicies(ListSchedulingPoliciesRequest request);



        /// <summary>
        /// Returns a list of Batch scheduling policies.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSchedulingPolicies service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSchedulingPolicies service method, as returned by Batch.</returns>
        /// <exception cref="Amazon.Batch.Model.ClientException">
        /// These errors are usually caused by a client action. One example cause is using an
        /// action or resource on behalf of a user that doesn't have permissions to use the action
        /// or resource. Another cause is specifying an identifier that's not valid.
        /// </exception>
        /// <exception cref="Amazon.Batch.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/ListSchedulingPolicies">REST API Reference for ListSchedulingPolicies Operation</seealso>
        Task<ListSchedulingPoliciesResponse> ListSchedulingPoliciesAsync(ListSchedulingPoliciesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists the tags for an Batch resource. Batch resources that support tags are compute
        /// environments, jobs, job definitions, job queues, and scheduling policies. ARNs for
        /// child jobs of array and multi-node parallel (MNP) jobs aren't supported.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Batch.</returns>
        /// <exception cref="Amazon.Batch.Model.ClientException">
        /// These errors are usually caused by a client action. One example cause is using an
        /// action or resource on behalf of a user that doesn't have permissions to use the action
        /// or resource. Another cause is specifying an identifier that's not valid.
        /// </exception>
        /// <exception cref="Amazon.Batch.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);



        /// <summary>
        /// Lists the tags for an Batch resource. Batch resources that support tags are compute
        /// environments, jobs, job definitions, job queues, and scheduling policies. ARNs for
        /// child jobs of array and multi-node parallel (MNP) jobs aren't supported.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Batch.</returns>
        /// <exception cref="Amazon.Batch.Model.ClientException">
        /// These errors are usually caused by a client action. One example cause is using an
        /// action or resource on behalf of a user that doesn't have permissions to use the action
        /// or resource. Another cause is specifying an identifier that's not valid.
        /// </exception>
        /// <exception cref="Amazon.Batch.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RegisterJobDefinition


        /// <summary>
        /// Registers an Batch job definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterJobDefinition service method.</param>
        /// 
        /// <returns>The response from the RegisterJobDefinition service method, as returned by Batch.</returns>
        /// <exception cref="Amazon.Batch.Model.ClientException">
        /// These errors are usually caused by a client action. One example cause is using an
        /// action or resource on behalf of a user that doesn't have permissions to use the action
        /// or resource. Another cause is specifying an identifier that's not valid.
        /// </exception>
        /// <exception cref="Amazon.Batch.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/RegisterJobDefinition">REST API Reference for RegisterJobDefinition Operation</seealso>
        RegisterJobDefinitionResponse RegisterJobDefinition(RegisterJobDefinitionRequest request);



        /// <summary>
        /// Registers an Batch job definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterJobDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RegisterJobDefinition service method, as returned by Batch.</returns>
        /// <exception cref="Amazon.Batch.Model.ClientException">
        /// These errors are usually caused by a client action. One example cause is using an
        /// action or resource on behalf of a user that doesn't have permissions to use the action
        /// or resource. Another cause is specifying an identifier that's not valid.
        /// </exception>
        /// <exception cref="Amazon.Batch.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/RegisterJobDefinition">REST API Reference for RegisterJobDefinition Operation</seealso>
        Task<RegisterJobDefinitionResponse> RegisterJobDefinitionAsync(RegisterJobDefinitionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  SubmitJob


        /// <summary>
        /// Submits an Batch job from a job definition. Parameters that are specified during <a>SubmitJob</a>
        /// override parameters defined in the job definition. vCPU and memory requirements that
        /// are specified in the <c>resourceRequirements</c> objects in the job definition are
        /// the exception. They can't be overridden this way using the <c>memory</c> and <c>vcpus</c>
        /// parameters. Rather, you must specify updates to job definition parameters in a <c>resourceRequirements</c>
        /// object that's included in the <c>containerOverrides</c> parameter.
        /// 
        ///  <note> 
        /// <para>
        /// Job queues with a scheduling policy are limited to 500 active fair share identifiers
        /// at a time. 
        /// </para>
        ///  </note> <important> 
        /// <para>
        /// Jobs that run on Fargate resources can't be guaranteed to run for more than 14 days.
        /// This is because, after 14 days, Fargate resources might become unavailable and job
        /// might be terminated.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SubmitJob service method.</param>
        /// 
        /// <returns>The response from the SubmitJob service method, as returned by Batch.</returns>
        /// <exception cref="Amazon.Batch.Model.ClientException">
        /// These errors are usually caused by a client action. One example cause is using an
        /// action or resource on behalf of a user that doesn't have permissions to use the action
        /// or resource. Another cause is specifying an identifier that's not valid.
        /// </exception>
        /// <exception cref="Amazon.Batch.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/SubmitJob">REST API Reference for SubmitJob Operation</seealso>
        SubmitJobResponse SubmitJob(SubmitJobRequest request);



        /// <summary>
        /// Submits an Batch job from a job definition. Parameters that are specified during <a>SubmitJob</a>
        /// override parameters defined in the job definition. vCPU and memory requirements that
        /// are specified in the <c>resourceRequirements</c> objects in the job definition are
        /// the exception. They can't be overridden this way using the <c>memory</c> and <c>vcpus</c>
        /// parameters. Rather, you must specify updates to job definition parameters in a <c>resourceRequirements</c>
        /// object that's included in the <c>containerOverrides</c> parameter.
        /// 
        ///  <note> 
        /// <para>
        /// Job queues with a scheduling policy are limited to 500 active fair share identifiers
        /// at a time. 
        /// </para>
        ///  </note> <important> 
        /// <para>
        /// Jobs that run on Fargate resources can't be guaranteed to run for more than 14 days.
        /// This is because, after 14 days, Fargate resources might become unavailable and job
        /// might be terminated.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SubmitJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SubmitJob service method, as returned by Batch.</returns>
        /// <exception cref="Amazon.Batch.Model.ClientException">
        /// These errors are usually caused by a client action. One example cause is using an
        /// action or resource on behalf of a user that doesn't have permissions to use the action
        /// or resource. Another cause is specifying an identifier that's not valid.
        /// </exception>
        /// <exception cref="Amazon.Batch.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/SubmitJob">REST API Reference for SubmitJob Operation</seealso>
        Task<SubmitJobResponse> SubmitJobAsync(SubmitJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Associates the specified tags to a resource with the specified <c>resourceArn</c>.
        /// If existing tags on a resource aren't specified in the request parameters, they aren't
        /// changed. When a resource is deleted, the tags that are associated with that resource
        /// are deleted as well. Batch resources that support tags are compute environments, jobs,
        /// job definitions, job queues, and scheduling policies. ARNs for child jobs of array
        /// and multi-node parallel (MNP) jobs aren't supported.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Batch.</returns>
        /// <exception cref="Amazon.Batch.Model.ClientException">
        /// These errors are usually caused by a client action. One example cause is using an
        /// action or resource on behalf of a user that doesn't have permissions to use the action
        /// or resource. Another cause is specifying an identifier that's not valid.
        /// </exception>
        /// <exception cref="Amazon.Batch.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);



        /// <summary>
        /// Associates the specified tags to a resource with the specified <c>resourceArn</c>.
        /// If existing tags on a resource aren't specified in the request parameters, they aren't
        /// changed. When a resource is deleted, the tags that are associated with that resource
        /// are deleted as well. Batch resources that support tags are compute environments, jobs,
        /// job definitions, job queues, and scheduling policies. ARNs for child jobs of array
        /// and multi-node parallel (MNP) jobs aren't supported.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Batch.</returns>
        /// <exception cref="Amazon.Batch.Model.ClientException">
        /// These errors are usually caused by a client action. One example cause is using an
        /// action or resource on behalf of a user that doesn't have permissions to use the action
        /// or resource. Another cause is specifying an identifier that's not valid.
        /// </exception>
        /// <exception cref="Amazon.Batch.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  TerminateJob


        /// <summary>
        /// Terminates a job in a job queue. Jobs that are in the <c>STARTING</c> or <c>RUNNING</c>
        /// state are terminated, which causes them to transition to <c>FAILED</c>. Jobs that
        /// have not progressed to the <c>STARTING</c> state are cancelled.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TerminateJob service method.</param>
        /// 
        /// <returns>The response from the TerminateJob service method, as returned by Batch.</returns>
        /// <exception cref="Amazon.Batch.Model.ClientException">
        /// These errors are usually caused by a client action. One example cause is using an
        /// action or resource on behalf of a user that doesn't have permissions to use the action
        /// or resource. Another cause is specifying an identifier that's not valid.
        /// </exception>
        /// <exception cref="Amazon.Batch.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/TerminateJob">REST API Reference for TerminateJob Operation</seealso>
        TerminateJobResponse TerminateJob(TerminateJobRequest request);



        /// <summary>
        /// Terminates a job in a job queue. Jobs that are in the <c>STARTING</c> or <c>RUNNING</c>
        /// state are terminated, which causes them to transition to <c>FAILED</c>. Jobs that
        /// have not progressed to the <c>STARTING</c> state are cancelled.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TerminateJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TerminateJob service method, as returned by Batch.</returns>
        /// <exception cref="Amazon.Batch.Model.ClientException">
        /// These errors are usually caused by a client action. One example cause is using an
        /// action or resource on behalf of a user that doesn't have permissions to use the action
        /// or resource. Another cause is specifying an identifier that's not valid.
        /// </exception>
        /// <exception cref="Amazon.Batch.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/TerminateJob">REST API Reference for TerminateJob Operation</seealso>
        Task<TerminateJobResponse> TerminateJobAsync(TerminateJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Deletes specified tags from an Batch resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Batch.</returns>
        /// <exception cref="Amazon.Batch.Model.ClientException">
        /// These errors are usually caused by a client action. One example cause is using an
        /// action or resource on behalf of a user that doesn't have permissions to use the action
        /// or resource. Another cause is specifying an identifier that's not valid.
        /// </exception>
        /// <exception cref="Amazon.Batch.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);



        /// <summary>
        /// Deletes specified tags from an Batch resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Batch.</returns>
        /// <exception cref="Amazon.Batch.Model.ClientException">
        /// These errors are usually caused by a client action. One example cause is using an
        /// action or resource on behalf of a user that doesn't have permissions to use the action
        /// or resource. Another cause is specifying an identifier that's not valid.
        /// </exception>
        /// <exception cref="Amazon.Batch.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateComputeEnvironment


        /// <summary>
        /// Updates an Batch compute environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateComputeEnvironment service method.</param>
        /// 
        /// <returns>The response from the UpdateComputeEnvironment service method, as returned by Batch.</returns>
        /// <exception cref="Amazon.Batch.Model.ClientException">
        /// These errors are usually caused by a client action. One example cause is using an
        /// action or resource on behalf of a user that doesn't have permissions to use the action
        /// or resource. Another cause is specifying an identifier that's not valid.
        /// </exception>
        /// <exception cref="Amazon.Batch.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/UpdateComputeEnvironment">REST API Reference for UpdateComputeEnvironment Operation</seealso>
        UpdateComputeEnvironmentResponse UpdateComputeEnvironment(UpdateComputeEnvironmentRequest request);



        /// <summary>
        /// Updates an Batch compute environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateComputeEnvironment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateComputeEnvironment service method, as returned by Batch.</returns>
        /// <exception cref="Amazon.Batch.Model.ClientException">
        /// These errors are usually caused by a client action. One example cause is using an
        /// action or resource on behalf of a user that doesn't have permissions to use the action
        /// or resource. Another cause is specifying an identifier that's not valid.
        /// </exception>
        /// <exception cref="Amazon.Batch.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/UpdateComputeEnvironment">REST API Reference for UpdateComputeEnvironment Operation</seealso>
        Task<UpdateComputeEnvironmentResponse> UpdateComputeEnvironmentAsync(UpdateComputeEnvironmentRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateJobQueue


        /// <summary>
        /// Updates a job queue.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateJobQueue service method.</param>
        /// 
        /// <returns>The response from the UpdateJobQueue service method, as returned by Batch.</returns>
        /// <exception cref="Amazon.Batch.Model.ClientException">
        /// These errors are usually caused by a client action. One example cause is using an
        /// action or resource on behalf of a user that doesn't have permissions to use the action
        /// or resource. Another cause is specifying an identifier that's not valid.
        /// </exception>
        /// <exception cref="Amazon.Batch.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/UpdateJobQueue">REST API Reference for UpdateJobQueue Operation</seealso>
        UpdateJobQueueResponse UpdateJobQueue(UpdateJobQueueRequest request);



        /// <summary>
        /// Updates a job queue.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateJobQueue service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateJobQueue service method, as returned by Batch.</returns>
        /// <exception cref="Amazon.Batch.Model.ClientException">
        /// These errors are usually caused by a client action. One example cause is using an
        /// action or resource on behalf of a user that doesn't have permissions to use the action
        /// or resource. Another cause is specifying an identifier that's not valid.
        /// </exception>
        /// <exception cref="Amazon.Batch.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/UpdateJobQueue">REST API Reference for UpdateJobQueue Operation</seealso>
        Task<UpdateJobQueueResponse> UpdateJobQueueAsync(UpdateJobQueueRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateSchedulingPolicy


        /// <summary>
        /// Updates a scheduling policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSchedulingPolicy service method.</param>
        /// 
        /// <returns>The response from the UpdateSchedulingPolicy service method, as returned by Batch.</returns>
        /// <exception cref="Amazon.Batch.Model.ClientException">
        /// These errors are usually caused by a client action. One example cause is using an
        /// action or resource on behalf of a user that doesn't have permissions to use the action
        /// or resource. Another cause is specifying an identifier that's not valid.
        /// </exception>
        /// <exception cref="Amazon.Batch.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/UpdateSchedulingPolicy">REST API Reference for UpdateSchedulingPolicy Operation</seealso>
        UpdateSchedulingPolicyResponse UpdateSchedulingPolicy(UpdateSchedulingPolicyRequest request);



        /// <summary>
        /// Updates a scheduling policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSchedulingPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateSchedulingPolicy service method, as returned by Batch.</returns>
        /// <exception cref="Amazon.Batch.Model.ClientException">
        /// These errors are usually caused by a client action. One example cause is using an
        /// action or resource on behalf of a user that doesn't have permissions to use the action
        /// or resource. Another cause is specifying an identifier that's not valid.
        /// </exception>
        /// <exception cref="Amazon.Batch.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/UpdateSchedulingPolicy">REST API Reference for UpdateSchedulingPolicy Operation</seealso>
        Task<UpdateSchedulingPolicyResponse> UpdateSchedulingPolicyAsync(UpdateSchedulingPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request);
        
        #endregion

    }
}