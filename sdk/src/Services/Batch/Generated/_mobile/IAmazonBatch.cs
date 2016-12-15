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
        /// Initiates the asynchronous execution of the CancelJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CancelJobResponse> CancelJobAsync(CancelJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateComputeEnvironment


        /// <summary>
        /// Initiates the asynchronous execution of the CreateComputeEnvironment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateComputeEnvironment operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateComputeEnvironmentResponse> CreateComputeEnvironmentAsync(CreateComputeEnvironmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateJobQueue


        /// <summary>
        /// Initiates the asynchronous execution of the CreateJobQueue operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateJobQueue operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateJobQueueResponse> CreateJobQueueAsync(CreateJobQueueRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteComputeEnvironment


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteComputeEnvironment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteComputeEnvironment operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteComputeEnvironmentResponse> DeleteComputeEnvironmentAsync(DeleteComputeEnvironmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteJobQueue


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteJobQueue operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteJobQueue operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteJobQueueResponse> DeleteJobQueueAsync(DeleteJobQueueRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeregisterJobDefinition


        /// <summary>
        /// Initiates the asynchronous execution of the DeregisterJobDefinition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeregisterJobDefinition operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeregisterJobDefinitionResponse> DeregisterJobDefinitionAsync(DeregisterJobDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeComputeEnvironments


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeComputeEnvironments operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeComputeEnvironments operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeComputeEnvironmentsResponse> DescribeComputeEnvironmentsAsync(DescribeComputeEnvironmentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeJobDefinitions


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeJobDefinitions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeJobDefinitions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeJobDefinitionsResponse> DescribeJobDefinitionsAsync(DescribeJobDefinitionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeJobQueues


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeJobQueues operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeJobQueues operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeJobQueuesResponse> DescribeJobQueuesAsync(DescribeJobQueuesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeJobs


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeJobs operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeJobsResponse> DescribeJobsAsync(DescribeJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListJobs


        /// <summary>
        /// Initiates the asynchronous execution of the ListJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListJobs operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListJobsResponse> ListJobsAsync(ListJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RegisterJobDefinition


        /// <summary>
        /// Initiates the asynchronous execution of the RegisterJobDefinition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterJobDefinition operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<RegisterJobDefinitionResponse> RegisterJobDefinitionAsync(RegisterJobDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  SubmitJob


        /// <summary>
        /// Initiates the asynchronous execution of the SubmitJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SubmitJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<SubmitJobResponse> SubmitJobAsync(SubmitJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TerminateJob


        /// <summary>
        /// Initiates the asynchronous execution of the TerminateJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TerminateJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<TerminateJobResponse> TerminateJobAsync(TerminateJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateComputeEnvironment


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateComputeEnvironment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateComputeEnvironment operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<UpdateComputeEnvironmentResponse> UpdateComputeEnvironmentAsync(UpdateComputeEnvironmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateJobQueue


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateJobQueue operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateJobQueue operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<UpdateJobQueueResponse> UpdateJobQueueAsync(UpdateJobQueueRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}