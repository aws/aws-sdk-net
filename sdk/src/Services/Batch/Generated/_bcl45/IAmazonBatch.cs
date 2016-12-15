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
 * Do not modify this file. This file is generated from the batch-2016-08-10.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.Batch.Model;

namespace Amazon.Batch
{
    /// <summary>
    /// Interface for accessing Batch
    ///
    /// AWS Batch enables you to run batch computing workloads on the AWS Cloud. Batch computing
    /// is a common way for developers, scientists, and engineers to access large amounts
    /// of compute resources, and AWS Batch removes the undifferentiated heavy lifting of
    /// configuring and managing the required infrastructure. AWS Batch will be familiar to
    /// users of traditional batch computing software. This service can efficiently provision
    /// resources in response to jobs submitted in order to eliminate capacity constraints,
    /// reduce compute costs, and deliver results quickly.
    /// 
    ///  
    /// <para>
    /// As a fully managed service, AWS Batch enables developers, scientists, and engineers
    /// to run batch computing workloads of any scale. AWS Batch automatically provisions
    /// compute resources and optimizes the workload distribution based on the quantity and
    /// scale of the workloads. With AWS Batch, there is no need to install or manage batch
    /// computing software, which allows you to focus on analyzing results and solving problems.
    /// AWS Batch reduces operational complexities, saves time, and reduces costs, which makes
    /// it easy for developers, scientists, and engineers to run their batch jobs in the AWS
    /// Cloud.
    /// </para>
    /// </summary>
    public partial interface IAmazonBatch : IAmazonService, IDisposable
    {

        
        #region  CancelJob


        /// <summary>
        /// Cancels jobs in an AWS Batch job queue. Jobs that are in the <code>SUBMITTED</code>,
        /// <code>PENDING</code>, or <code>RUNNABLE</code> state are cancelled. Jobs that have
        /// progressed to <code>STARTING</code> or <code>RUNNING</code> are not cancelled (but
        /// the API operation still succeeds, even if no jobs are cancelled); these jobs must
        /// be terminated with the <a>TerminateJob</a> operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelJob service method.</param>
        /// 
        /// <returns>The response from the CancelJob service method, as returned by Batch.</returns>
        /// <exception cref="Amazon.Batch.Model.ClientException">
        /// These errors are usually caused by a client action, such as using an action or resource
        /// on behalf of a user that doesn't have permission to use the action or resource, or
        /// specifying an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.Batch.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        CancelJobResponse CancelJob(CancelJobRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CancelJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CancelJobResponse> CancelJobAsync(CancelJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateComputeEnvironment


        /// <summary>
        /// Creates an AWS Batch compute environment. You can create <code>MANAGED</code> or <code>UNMANAGED</code>compute
        /// environments.
        /// 
        ///  
        /// <para>
        /// In a managed compute environment, AWS Batch manages the compute resources within the
        /// environment, based on the compute resources that you specify. Instances launched into
        /// a managed compute environment use the latest Amazon ECS-optimized AMI. You can choose
        /// to use Amazon EC2 On-Demand instances in your managed compute environment, or you
        /// can use Amazon EC2 Spot instances that only launch when the Spot bid price is below
        /// a specified percentage of the On-Demand price.
        /// </para>
        ///  
        /// <para>
        /// In an unmanaged compute environment, you can manage your own compute resources. This
        /// provides more compute resource configuration options, such as using a custom AMI,
        /// but you must ensure that your AMI meets the Amazon ECS container instance AMI specification.
        /// For more information, see <a href="http://docs.aws.amazon.com/AmazonECS/latest/developerguide/container_instance_AMIs.html">Container
        /// Instance AMIs</a> in the <i>Amazon EC2 Container Service Developer Guide</i>. After
        /// you have created your unmanaged compute environment, you can use the <a>DescribeComputeEnvironments</a>
        /// operation to find the Amazon ECS cluster that is associated with it and then manually
        /// launch your container instances into that Amazon ECS cluster. For more information,
        /// see <a href="http://docs.aws.amazon.com/AmazonECS/latest/developerguide/launch_container_instance.html">Launching
        /// an Amazon ECS Container Instance</a> in the <i>Amazon EC2 Container Service Developer
        /// Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateComputeEnvironment service method.</param>
        /// 
        /// <returns>The response from the CreateComputeEnvironment service method, as returned by Batch.</returns>
        /// <exception cref="Amazon.Batch.Model.ClientException">
        /// These errors are usually caused by a client action, such as using an action or resource
        /// on behalf of a user that doesn't have permission to use the action or resource, or
        /// specifying an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.Batch.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        CreateComputeEnvironmentResponse CreateComputeEnvironment(CreateComputeEnvironmentRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreateComputeEnvironment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateComputeEnvironment operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateComputeEnvironmentResponse> CreateComputeEnvironmentAsync(CreateComputeEnvironmentRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateJobQueue


        /// <summary>
        /// Creates an AWS Batch job queue. When you create a job queue, you associate one or
        /// more compute environments to the queue and assign an order of preference for the compute
        /// environments.
        /// 
        ///  
        /// <para>
        /// You also set a priority to the job queue that determines the order in which the AWS
        /// Batch scheduler places jobs onto its associated compute environments. For example,
        /// if a compute environment is associated with more than one job queue, the job queue
        /// with a higher priority is given preference for scheduling jobs to that compute environment.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateJobQueue service method.</param>
        /// 
        /// <returns>The response from the CreateJobQueue service method, as returned by Batch.</returns>
        /// <exception cref="Amazon.Batch.Model.ClientException">
        /// These errors are usually caused by a client action, such as using an action or resource
        /// on behalf of a user that doesn't have permission to use the action or resource, or
        /// specifying an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.Batch.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        CreateJobQueueResponse CreateJobQueue(CreateJobQueueRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreateJobQueue operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateJobQueue operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateJobQueueResponse> CreateJobQueueAsync(CreateJobQueueRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteComputeEnvironment


        /// <summary>
        /// Deletes an AWS Batch compute environment.
        /// 
        ///  
        /// <para>
        /// Before you can delete a compute environment, you must set its state to <code>DISABLED</code>
        /// with the <a>UpdateComputeEnvironment</a> API operation and disassociate it from any
        /// job queues with the <a>UpdateJobQueue</a> API operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteComputeEnvironment service method.</param>
        /// 
        /// <returns>The response from the DeleteComputeEnvironment service method, as returned by Batch.</returns>
        /// <exception cref="Amazon.Batch.Model.ClientException">
        /// These errors are usually caused by a client action, such as using an action or resource
        /// on behalf of a user that doesn't have permission to use the action or resource, or
        /// specifying an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.Batch.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        DeleteComputeEnvironmentResponse DeleteComputeEnvironment(DeleteComputeEnvironmentRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteComputeEnvironment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteComputeEnvironment operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteComputeEnvironmentResponse> DeleteComputeEnvironmentAsync(DeleteComputeEnvironmentRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteJobQueue


        /// <summary>
        /// Deletes the specified job queue. You must first disable submissions for a queue with
        /// the <a>UpdateJobQueue</a> operation and terminate any jobs that have not completed
        /// with the <a>TerminateJob</a>.
        /// 
        ///  
        /// <para>
        /// It is not necessary to disassociate compute environments from a queue before submitting
        /// a <code>DeleteJobQueue</code> request. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteJobQueue service method.</param>
        /// 
        /// <returns>The response from the DeleteJobQueue service method, as returned by Batch.</returns>
        /// <exception cref="Amazon.Batch.Model.ClientException">
        /// These errors are usually caused by a client action, such as using an action or resource
        /// on behalf of a user that doesn't have permission to use the action or resource, or
        /// specifying an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.Batch.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        DeleteJobQueueResponse DeleteJobQueue(DeleteJobQueueRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteJobQueue operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteJobQueue operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteJobQueueResponse> DeleteJobQueueAsync(DeleteJobQueueRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeregisterJobDefinition


        /// <summary>
        /// Deregisters an AWS Batch job definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterJobDefinition service method.</param>
        /// 
        /// <returns>The response from the DeregisterJobDefinition service method, as returned by Batch.</returns>
        /// <exception cref="Amazon.Batch.Model.ClientException">
        /// These errors are usually caused by a client action, such as using an action or resource
        /// on behalf of a user that doesn't have permission to use the action or resource, or
        /// specifying an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.Batch.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        DeregisterJobDefinitionResponse DeregisterJobDefinition(DeregisterJobDefinitionRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeregisterJobDefinition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeregisterJobDefinition operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeregisterJobDefinitionResponse> DeregisterJobDefinitionAsync(DeregisterJobDefinitionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeComputeEnvironments


        /// <summary>
        /// Describes one or more of your compute environments.
        /// 
        ///  
        /// <para>
        /// If you are using an unmanaged compute environment, you can use the <code>DescribeComputeEnvironment</code>
        /// operation to determine the <code>ecsClusterArn</code> that you should launch your
        /// Amazon ECS container instances into.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeComputeEnvironments service method.</param>
        /// 
        /// <returns>The response from the DescribeComputeEnvironments service method, as returned by Batch.</returns>
        /// <exception cref="Amazon.Batch.Model.ClientException">
        /// These errors are usually caused by a client action, such as using an action or resource
        /// on behalf of a user that doesn't have permission to use the action or resource, or
        /// specifying an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.Batch.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        DescribeComputeEnvironmentsResponse DescribeComputeEnvironments(DescribeComputeEnvironmentsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeComputeEnvironments operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeComputeEnvironments operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeComputeEnvironmentsResponse> DescribeComputeEnvironmentsAsync(DescribeComputeEnvironmentsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeJobDefinitions


        /// <summary>
        /// Describes a list of job definitions. You can specify a <code>status</code> (such as
        /// <code>ACTIVE</code>) to only return job definitions that match that status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeJobDefinitions service method.</param>
        /// 
        /// <returns>The response from the DescribeJobDefinitions service method, as returned by Batch.</returns>
        /// <exception cref="Amazon.Batch.Model.ClientException">
        /// These errors are usually caused by a client action, such as using an action or resource
        /// on behalf of a user that doesn't have permission to use the action or resource, or
        /// specifying an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.Batch.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        DescribeJobDefinitionsResponse DescribeJobDefinitions(DescribeJobDefinitionsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeJobDefinitions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeJobDefinitions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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
        /// These errors are usually caused by a client action, such as using an action or resource
        /// on behalf of a user that doesn't have permission to use the action or resource, or
        /// specifying an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.Batch.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        DescribeJobQueuesResponse DescribeJobQueues(DescribeJobQueuesRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeJobQueues operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeJobQueues operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeJobQueuesResponse> DescribeJobQueuesAsync(DescribeJobQueuesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeJobs


        /// <summary>
        /// Describes a list of AWS Batch jobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeJobs service method.</param>
        /// 
        /// <returns>The response from the DescribeJobs service method, as returned by Batch.</returns>
        /// <exception cref="Amazon.Batch.Model.ClientException">
        /// These errors are usually caused by a client action, such as using an action or resource
        /// on behalf of a user that doesn't have permission to use the action or resource, or
        /// specifying an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.Batch.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        DescribeJobsResponse DescribeJobs(DescribeJobsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeJobs operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeJobsResponse> DescribeJobsAsync(DescribeJobsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListJobs


        /// <summary>
        /// Returns a list of task jobs for a specified job queue. You can filter the results
        /// by job status with the <code>jobStatus</code> parameter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListJobs service method.</param>
        /// 
        /// <returns>The response from the ListJobs service method, as returned by Batch.</returns>
        /// <exception cref="Amazon.Batch.Model.ClientException">
        /// These errors are usually caused by a client action, such as using an action or resource
        /// on behalf of a user that doesn't have permission to use the action or resource, or
        /// specifying an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.Batch.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        ListJobsResponse ListJobs(ListJobsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ListJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListJobs operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListJobsResponse> ListJobsAsync(ListJobsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RegisterJobDefinition


        /// <summary>
        /// Registers an AWS Batch job definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterJobDefinition service method.</param>
        /// 
        /// <returns>The response from the RegisterJobDefinition service method, as returned by Batch.</returns>
        /// <exception cref="Amazon.Batch.Model.ClientException">
        /// These errors are usually caused by a client action, such as using an action or resource
        /// on behalf of a user that doesn't have permission to use the action or resource, or
        /// specifying an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.Batch.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        RegisterJobDefinitionResponse RegisterJobDefinition(RegisterJobDefinitionRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the RegisterJobDefinition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterJobDefinition operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<RegisterJobDefinitionResponse> RegisterJobDefinitionAsync(RegisterJobDefinitionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  SubmitJob


        /// <summary>
        /// Submits an AWS Batch job from a job definition. Parameters specified during <a>SubmitJob</a>
        /// override parameters defined in the job definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SubmitJob service method.</param>
        /// 
        /// <returns>The response from the SubmitJob service method, as returned by Batch.</returns>
        /// <exception cref="Amazon.Batch.Model.ClientException">
        /// These errors are usually caused by a client action, such as using an action or resource
        /// on behalf of a user that doesn't have permission to use the action or resource, or
        /// specifying an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.Batch.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        SubmitJobResponse SubmitJob(SubmitJobRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the SubmitJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SubmitJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<SubmitJobResponse> SubmitJobAsync(SubmitJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  TerminateJob


        /// <summary>
        /// Terminates jobs in a job queue. Jobs that are in the <code>STARTING</code> or <code>RUNNING</code>
        /// state are terminated, which causes them to transition to <code>FAILED</code>. Jobs
        /// that have not progressed to the <code>STARTING</code> state are cancelled.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TerminateJob service method.</param>
        /// 
        /// <returns>The response from the TerminateJob service method, as returned by Batch.</returns>
        /// <exception cref="Amazon.Batch.Model.ClientException">
        /// These errors are usually caused by a client action, such as using an action or resource
        /// on behalf of a user that doesn't have permission to use the action or resource, or
        /// specifying an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.Batch.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        TerminateJobResponse TerminateJob(TerminateJobRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the TerminateJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TerminateJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<TerminateJobResponse> TerminateJobAsync(TerminateJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateComputeEnvironment


        /// <summary>
        /// Updates an AWS Batch compute environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateComputeEnvironment service method.</param>
        /// 
        /// <returns>The response from the UpdateComputeEnvironment service method, as returned by Batch.</returns>
        /// <exception cref="Amazon.Batch.Model.ClientException">
        /// These errors are usually caused by a client action, such as using an action or resource
        /// on behalf of a user that doesn't have permission to use the action or resource, or
        /// specifying an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.Batch.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        UpdateComputeEnvironmentResponse UpdateComputeEnvironment(UpdateComputeEnvironmentRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateComputeEnvironment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateComputeEnvironment operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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
        /// These errors are usually caused by a client action, such as using an action or resource
        /// on behalf of a user that doesn't have permission to use the action or resource, or
        /// specifying an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.Batch.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        UpdateJobQueueResponse UpdateJobQueue(UpdateJobQueueRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateJobQueue operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateJobQueue operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<UpdateJobQueueResponse> UpdateJobQueueAsync(UpdateJobQueueRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}