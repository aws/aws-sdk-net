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
        /// <param name="request">Container for the necessary parameters to execute the CancelJob operation on AmazonBatchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelJob
        ///         operation.</returns>
        IAsyncResult BeginCancelJob(CancelJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CancelJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelJob.</param>
        /// 
        /// <returns>Returns a  CancelJobResult from Batch.</returns>
        CancelJobResponse EndCancelJob(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the CreateComputeEnvironment operation on AmazonBatchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateComputeEnvironment
        ///         operation.</returns>
        IAsyncResult BeginCreateComputeEnvironment(CreateComputeEnvironmentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateComputeEnvironment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateComputeEnvironment.</param>
        /// 
        /// <returns>Returns a  CreateComputeEnvironmentResult from Batch.</returns>
        CreateComputeEnvironmentResponse EndCreateComputeEnvironment(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the CreateJobQueue operation on AmazonBatchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateJobQueue
        ///         operation.</returns>
        IAsyncResult BeginCreateJobQueue(CreateJobQueueRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateJobQueue operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateJobQueue.</param>
        /// 
        /// <returns>Returns a  CreateJobQueueResult from Batch.</returns>
        CreateJobQueueResponse EndCreateJobQueue(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the DeleteComputeEnvironment operation on AmazonBatchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteComputeEnvironment
        ///         operation.</returns>
        IAsyncResult BeginDeleteComputeEnvironment(DeleteComputeEnvironmentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteComputeEnvironment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteComputeEnvironment.</param>
        /// 
        /// <returns>Returns a  DeleteComputeEnvironmentResult from Batch.</returns>
        DeleteComputeEnvironmentResponse EndDeleteComputeEnvironment(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the DeleteJobQueue operation on AmazonBatchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteJobQueue
        ///         operation.</returns>
        IAsyncResult BeginDeleteJobQueue(DeleteJobQueueRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteJobQueue operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteJobQueue.</param>
        /// 
        /// <returns>Returns a  DeleteJobQueueResult from Batch.</returns>
        DeleteJobQueueResponse EndDeleteJobQueue(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the DeregisterJobDefinition operation on AmazonBatchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeregisterJobDefinition
        ///         operation.</returns>
        IAsyncResult BeginDeregisterJobDefinition(DeregisterJobDefinitionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeregisterJobDefinition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeregisterJobDefinition.</param>
        /// 
        /// <returns>Returns a  DeregisterJobDefinitionResult from Batch.</returns>
        DeregisterJobDefinitionResponse EndDeregisterJobDefinition(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the DescribeComputeEnvironments operation on AmazonBatchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeComputeEnvironments
        ///         operation.</returns>
        IAsyncResult BeginDescribeComputeEnvironments(DescribeComputeEnvironmentsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeComputeEnvironments operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeComputeEnvironments.</param>
        /// 
        /// <returns>Returns a  DescribeComputeEnvironmentsResult from Batch.</returns>
        DescribeComputeEnvironmentsResponse EndDescribeComputeEnvironments(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the DescribeJobDefinitions operation on AmazonBatchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeJobDefinitions
        ///         operation.</returns>
        IAsyncResult BeginDescribeJobDefinitions(DescribeJobDefinitionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeJobDefinitions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeJobDefinitions.</param>
        /// 
        /// <returns>Returns a  DescribeJobDefinitionsResult from Batch.</returns>
        DescribeJobDefinitionsResponse EndDescribeJobDefinitions(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the DescribeJobQueues operation on AmazonBatchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeJobQueues
        ///         operation.</returns>
        IAsyncResult BeginDescribeJobQueues(DescribeJobQueuesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeJobQueues operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeJobQueues.</param>
        /// 
        /// <returns>Returns a  DescribeJobQueuesResult from Batch.</returns>
        DescribeJobQueuesResponse EndDescribeJobQueues(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the DescribeJobs operation on AmazonBatchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeJobs
        ///         operation.</returns>
        IAsyncResult BeginDescribeJobs(DescribeJobsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeJobs.</param>
        /// 
        /// <returns>Returns a  DescribeJobsResult from Batch.</returns>
        DescribeJobsResponse EndDescribeJobs(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the ListJobs operation on AmazonBatchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListJobs
        ///         operation.</returns>
        IAsyncResult BeginListJobs(ListJobsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListJobs.</param>
        /// 
        /// <returns>Returns a  ListJobsResult from Batch.</returns>
        ListJobsResponse EndListJobs(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the RegisterJobDefinition operation on AmazonBatchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRegisterJobDefinition
        ///         operation.</returns>
        IAsyncResult BeginRegisterJobDefinition(RegisterJobDefinitionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RegisterJobDefinition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRegisterJobDefinition.</param>
        /// 
        /// <returns>Returns a  RegisterJobDefinitionResult from Batch.</returns>
        RegisterJobDefinitionResponse EndRegisterJobDefinition(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the SubmitJob operation on AmazonBatchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSubmitJob
        ///         operation.</returns>
        IAsyncResult BeginSubmitJob(SubmitJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SubmitJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSubmitJob.</param>
        /// 
        /// <returns>Returns a  SubmitJobResult from Batch.</returns>
        SubmitJobResponse EndSubmitJob(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the TerminateJob operation on AmazonBatchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTerminateJob
        ///         operation.</returns>
        IAsyncResult BeginTerminateJob(TerminateJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TerminateJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTerminateJob.</param>
        /// 
        /// <returns>Returns a  TerminateJobResult from Batch.</returns>
        TerminateJobResponse EndTerminateJob(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the UpdateComputeEnvironment operation on AmazonBatchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateComputeEnvironment
        ///         operation.</returns>
        IAsyncResult BeginUpdateComputeEnvironment(UpdateComputeEnvironmentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateComputeEnvironment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateComputeEnvironment.</param>
        /// 
        /// <returns>Returns a  UpdateComputeEnvironmentResult from Batch.</returns>
        UpdateComputeEnvironmentResponse EndUpdateComputeEnvironment(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the UpdateJobQueue operation on AmazonBatchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateJobQueue
        ///         operation.</returns>
        IAsyncResult BeginUpdateJobQueue(UpdateJobQueueRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateJobQueue operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateJobQueue.</param>
        /// 
        /// <returns>Returns a  UpdateJobQueueResult from Batch.</returns>
        UpdateJobQueueResponse EndUpdateJobQueue(IAsyncResult asyncResult);

        #endregion
        
    }
}