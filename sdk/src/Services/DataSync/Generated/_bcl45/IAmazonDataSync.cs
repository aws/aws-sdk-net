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
 * Do not modify this file. This file is generated from the datasync-2018-11-09.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.DataSync.Model;

namespace Amazon.DataSync
{
    /// <summary>
    /// Interface for accessing DataSync
    ///
    /// AWS DataSync 
    /// <para>
    /// AWS DataSync is a managed data transfer service that makes it simpler for you to automate
    /// moving data between on-premises storage and Amazon Simple Storage Service (Amazon
    /// S3) or Amazon Elastic File System (Amazon EFS). 
    /// </para>
    ///  
    /// <para>
    /// This API interface reference for AWS DataSync contains documentation for a programming
    /// interface that you can use to manage AWS DataSync.
    /// </para>
    /// </summary>
    public partial interface IAmazonDataSync : IAmazonService, IDisposable
    {

        
        #region  CancelTaskExecution


        /// <summary>
        /// Cancels execution of a task. 
        /// 
        ///  
        /// <para>
        /// When you cancel a task execution, the transfer of some files are abruptly interrupted.
        /// The contents of files that are transferred to the destination might be incomplete
        /// or inconsistent with the source files. However, if you start a new task execution
        /// on the same task and you allow the task execution to complete, file content on the
        /// destination is complete and consistent. This applies to other unexpected failures
        /// that interrupt a task execution. In all of these cases, AWS DataSync successfully
        /// complete the transfer when you start the next task execution. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelTaskExecution service method.</param>
        /// 
        /// <returns>The response from the CancelTaskExecution service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/CancelTaskExecution">REST API Reference for CancelTaskExecution Operation</seealso>
        CancelTaskExecutionResponse CancelTaskExecution(CancelTaskExecutionRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CancelTaskExecution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelTaskExecution operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/CancelTaskExecution">REST API Reference for CancelTaskExecution Operation</seealso>
        Task<CancelTaskExecutionResponse> CancelTaskExecutionAsync(CancelTaskExecutionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateAgent


        /// <summary>
        /// Activates an AWS DataSync agent that you have deployed on your host. The activation
        /// process associates your agent with your account. In the activation process, you specify
        /// information such as the AWS Region that you want to activate the agent in. You activate
        /// the agent in the AWS Region where your target locations (in Amazon S3 or Amazon EFS)
        /// reside. Your tasks are created in this AWS Region. 
        /// 
        ///  
        /// <para>
        /// You can use an agent for more than one location. If a task uses multiple agents, all
        /// of them need to have status AVAILABLE for the task to run. If you use multiple agents
        /// for a source location, the status of all the agents must be AVAILABLE for the task
        /// to run. For more information, see <a href="https://docs.aws.amazon.com/sync-service/latest/userguide/working-with-sync-agents.html#activating-sync-agent">Activating
        /// a Sync Agent</a> in the <i>AWS DataSync User Guide.</i> 
        /// </para>
        ///  
        /// <para>
        /// Agents are automatically updated by AWS on a regular basis, using a mechanism that
        /// ensures minimal interruption to your tasks.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAgent service method.</param>
        /// 
        /// <returns>The response from the CreateAgent service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/CreateAgent">REST API Reference for CreateAgent Operation</seealso>
        CreateAgentResponse CreateAgent(CreateAgentRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreateAgent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAgent operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/CreateAgent">REST API Reference for CreateAgent Operation</seealso>
        Task<CreateAgentResponse> CreateAgentAsync(CreateAgentRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateLocationEfs


        /// <summary>
        /// Creates an endpoint for an Amazon EFS file system.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLocationEfs service method.</param>
        /// 
        /// <returns>The response from the CreateLocationEfs service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/CreateLocationEfs">REST API Reference for CreateLocationEfs Operation</seealso>
        CreateLocationEfsResponse CreateLocationEfs(CreateLocationEfsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreateLocationEfs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLocationEfs operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/CreateLocationEfs">REST API Reference for CreateLocationEfs Operation</seealso>
        Task<CreateLocationEfsResponse> CreateLocationEfsAsync(CreateLocationEfsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateLocationNfs


        /// <summary>
        /// Creates an endpoint for a Network File System (NFS) file system.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLocationNfs service method.</param>
        /// 
        /// <returns>The response from the CreateLocationNfs service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/CreateLocationNfs">REST API Reference for CreateLocationNfs Operation</seealso>
        CreateLocationNfsResponse CreateLocationNfs(CreateLocationNfsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreateLocationNfs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLocationNfs operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/CreateLocationNfs">REST API Reference for CreateLocationNfs Operation</seealso>
        Task<CreateLocationNfsResponse> CreateLocationNfsAsync(CreateLocationNfsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateLocationS3


        /// <summary>
        /// Creates an endpoint for an Amazon S3 bucket.
        /// 
        ///  
        /// <para>
        /// For AWS DataSync to access a destination S3 bucket, it needs an AWS Identity and Access
        /// Management (IAM) role that has the required permissions. You can set up the required
        /// permissions by creating an IAM policy that grants the required permissions and attaching
        /// the policy to the role. An example of such a policy is shown in the examples section.
        /// For more information, see <a href="https://docs.aws.amazon.com/sync-service/latest/userguide/configuring-s3-locations.html">Configuring
        /// Amazon S3 Location Settings</a> in the <i>AWS DataSync User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLocationS3 service method.</param>
        /// 
        /// <returns>The response from the CreateLocationS3 service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/CreateLocationS3">REST API Reference for CreateLocationS3 Operation</seealso>
        CreateLocationS3Response CreateLocationS3(CreateLocationS3Request request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreateLocationS3 operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLocationS3 operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/CreateLocationS3">REST API Reference for CreateLocationS3 Operation</seealso>
        Task<CreateLocationS3Response> CreateLocationS3Async(CreateLocationS3Request request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateTask


        /// <summary>
        /// Creates a task. A task is a set of two locations (source and destination) and a set
        /// of default <code>OverrideOptions</code> that you use to control the behavior of a
        /// task. If you don't specify default values for <code>Options</code> when you create
        /// a task, AWS DataSync populates them with safe service defaults.
        /// 
        ///  
        /// <para>
        /// When you initially create a task, it enters the INITIALIZING status and then the CREATING
        /// status. In CREATING status, AWS DataSync attempts to mount the source Network File
        /// System (NFS) location. The task transitions to the AVAILABLE status without waiting
        /// for the destination location to mount. Instead, AWS DataSync mounts a destination
        /// before every task execution and then unmounts it after every task execution. 
        /// </para>
        ///  
        /// <para>
        /// If an agent that is associated with a source (NFS) location goes offline, the task
        /// transitions to the UNAVAILABLE status. If the status of the task remains in the CREATING
        /// status for more than a few minutes, it means that your agent might be having trouble
        /// mounting the source NFS file system. Check the task's <code>ErrorCode</code> and <code>ErrorDetail</code>.
        /// Mount issues are often caused by either a misconfigured firewall or a mistyped NFS
        /// server host name.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTask service method.</param>
        /// 
        /// <returns>The response from the CreateTask service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/CreateTask">REST API Reference for CreateTask Operation</seealso>
        CreateTaskResponse CreateTask(CreateTaskRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreateTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTask operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/CreateTask">REST API Reference for CreateTask Operation</seealso>
        Task<CreateTaskResponse> CreateTaskAsync(CreateTaskRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteAgent


        /// <summary>
        /// Deletes an agent. To specify which agent to delete, use the Amazon Resource Name (ARN)
        /// of the agent in your request. The operation disassociates the agent from your AWS
        /// account. However, it doesn't delete the agent virtual machine (VM) from your on-premises
        /// environment.
        /// 
        ///  <note> 
        /// <para>
        /// After you delete an agent, you can't reactivate it and you longer pay software charges
        /// for it.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAgent service method.</param>
        /// 
        /// <returns>The response from the DeleteAgent service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DeleteAgent">REST API Reference for DeleteAgent Operation</seealso>
        DeleteAgentResponse DeleteAgent(DeleteAgentRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAgent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAgent operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DeleteAgent">REST API Reference for DeleteAgent Operation</seealso>
        Task<DeleteAgentResponse> DeleteAgentAsync(DeleteAgentRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteLocation


        /// <summary>
        /// Deletes the configuration of a location used by AWS DataSync.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLocation service method.</param>
        /// 
        /// <returns>The response from the DeleteLocation service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DeleteLocation">REST API Reference for DeleteLocation Operation</seealso>
        DeleteLocationResponse DeleteLocation(DeleteLocationRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLocation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLocation operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DeleteLocation">REST API Reference for DeleteLocation Operation</seealso>
        Task<DeleteLocationResponse> DeleteLocationAsync(DeleteLocationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteTask


        /// <summary>
        /// Deletes a task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTask service method.</param>
        /// 
        /// <returns>The response from the DeleteTask service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DeleteTask">REST API Reference for DeleteTask Operation</seealso>
        DeleteTaskResponse DeleteTask(DeleteTaskRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTask operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DeleteTask">REST API Reference for DeleteTask Operation</seealso>
        Task<DeleteTaskResponse> DeleteTaskAsync(DeleteTaskRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeAgent


        /// <summary>
        /// Returns metadata such as the name, the network interfaces, and the status (that is,
        /// whether the agent is running or not) for an agent. To specify which agent to describe,
        /// use the Amazon Resource Name (ARN) of the agent in your request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAgent service method.</param>
        /// 
        /// <returns>The response from the DescribeAgent service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeAgent">REST API Reference for DescribeAgent Operation</seealso>
        DescribeAgentResponse DescribeAgent(DescribeAgentRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAgent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAgent operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeAgent">REST API Reference for DescribeAgent Operation</seealso>
        Task<DescribeAgentResponse> DescribeAgentAsync(DescribeAgentRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeLocationEfs


        /// <summary>
        /// Returns metadata, such as the path information about an Amazon EFS location.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLocationEfs service method.</param>
        /// 
        /// <returns>The response from the DescribeLocationEfs service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeLocationEfs">REST API Reference for DescribeLocationEfs Operation</seealso>
        DescribeLocationEfsResponse DescribeLocationEfs(DescribeLocationEfsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLocationEfs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLocationEfs operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeLocationEfs">REST API Reference for DescribeLocationEfs Operation</seealso>
        Task<DescribeLocationEfsResponse> DescribeLocationEfsAsync(DescribeLocationEfsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeLocationNfs


        /// <summary>
        /// Returns metadata, such as the path information, about a NFS location.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLocationNfs service method.</param>
        /// 
        /// <returns>The response from the DescribeLocationNfs service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeLocationNfs">REST API Reference for DescribeLocationNfs Operation</seealso>
        DescribeLocationNfsResponse DescribeLocationNfs(DescribeLocationNfsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLocationNfs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLocationNfs operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeLocationNfs">REST API Reference for DescribeLocationNfs Operation</seealso>
        Task<DescribeLocationNfsResponse> DescribeLocationNfsAsync(DescribeLocationNfsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeLocationS3


        /// <summary>
        /// Returns metadata, such as bucket name, about an Amazon S3 bucket location.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLocationS3 service method.</param>
        /// 
        /// <returns>The response from the DescribeLocationS3 service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeLocationS3">REST API Reference for DescribeLocationS3 Operation</seealso>
        DescribeLocationS3Response DescribeLocationS3(DescribeLocationS3Request request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLocationS3 operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLocationS3 operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeLocationS3">REST API Reference for DescribeLocationS3 Operation</seealso>
        Task<DescribeLocationS3Response> DescribeLocationS3Async(DescribeLocationS3Request request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeTask


        /// <summary>
        /// Returns metadata about a task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTask service method.</param>
        /// 
        /// <returns>The response from the DescribeTask service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeTask">REST API Reference for DescribeTask Operation</seealso>
        DescribeTaskResponse DescribeTask(DescribeTaskRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTask operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeTask">REST API Reference for DescribeTask Operation</seealso>
        Task<DescribeTaskResponse> DescribeTaskAsync(DescribeTaskRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeTaskExecution


        /// <summary>
        /// Returns detailed metadata about a task that is being executed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTaskExecution service method.</param>
        /// 
        /// <returns>The response from the DescribeTaskExecution service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeTaskExecution">REST API Reference for DescribeTaskExecution Operation</seealso>
        DescribeTaskExecutionResponse DescribeTaskExecution(DescribeTaskExecutionRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTaskExecution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTaskExecution operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeTaskExecution">REST API Reference for DescribeTaskExecution Operation</seealso>
        Task<DescribeTaskExecutionResponse> DescribeTaskExecutionAsync(DescribeTaskExecutionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListAgents


        /// <summary>
        /// Returns a list of agents owned by an AWS account in the AWS Region specified in the
        /// request. The returned list is ordered by agent Amazon Resource Name (ARN).
        /// 
        ///  
        /// <para>
        /// By default, this operation returns a maximum of 100 agents. This operation supports
        /// pagination that enables you to optionally reduce the number of agents returned in
        /// a response.
        /// </para>
        ///  
        /// <para>
        /// If you have more agents than are returned in a response (that is, the response returns
        /// only a truncated list of your agents), the response contains a marker that you can
        /// specify in your next request to fetch the next page of agents.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAgents service method.</param>
        /// 
        /// <returns>The response from the ListAgents service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/ListAgents">REST API Reference for ListAgents Operation</seealso>
        ListAgentsResponse ListAgents(ListAgentsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ListAgents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAgents operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/ListAgents">REST API Reference for ListAgents Operation</seealso>
        Task<ListAgentsResponse> ListAgentsAsync(ListAgentsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListLocations


        /// <summary>
        /// Returns a lists of source and destination locations.
        /// 
        ///  
        /// <para>
        /// If you have more locations than are returned in a response (that is, the response
        /// returns only a truncated list of your agents), the response contains a token that
        /// you can specify in your next request to fetch the next page of locations.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLocations service method.</param>
        /// 
        /// <returns>The response from the ListLocations service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/ListLocations">REST API Reference for ListLocations Operation</seealso>
        ListLocationsResponse ListLocations(ListLocationsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ListLocations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListLocations operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/ListLocations">REST API Reference for ListLocations Operation</seealso>
        Task<ListLocationsResponse> ListLocationsAsync(ListLocationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Returns all the tags associated with a specified resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTaskExecutions


        /// <summary>
        /// Returns a list of executed tasks.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTaskExecutions service method.</param>
        /// 
        /// <returns>The response from the ListTaskExecutions service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/ListTaskExecutions">REST API Reference for ListTaskExecutions Operation</seealso>
        ListTaskExecutionsResponse ListTaskExecutions(ListTaskExecutionsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ListTaskExecutions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTaskExecutions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/ListTaskExecutions">REST API Reference for ListTaskExecutions Operation</seealso>
        Task<ListTaskExecutionsResponse> ListTaskExecutionsAsync(ListTaskExecutionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTasks


        /// <summary>
        /// Returns a list of all the tasks.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTasks service method.</param>
        /// 
        /// <returns>The response from the ListTasks service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/ListTasks">REST API Reference for ListTasks Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/ListTasks">REST API Reference for ListTasks Operation</seealso>
        Task<ListTasksResponse> ListTasksAsync(ListTasksRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StartTaskExecution


        /// <summary>
        /// Starts a specific invocation of a task. A <code>TaskExecution</code> value represents
        /// an individual run of a task. Each task can have at most one <code>TaskExecution</code>
        /// at a time.
        /// 
        ///  
        /// <para>
        ///  <code>TaskExecution</code> has the following transition phases: INITIALIZING | PREPARING
        /// | TRANSFERRING | VERIFYING | SUCCESS/FAILURE. 
        /// </para>
        ///  
        /// <para>
        /// For detailed information, see <i>Task Execution</i> in <a href="https://docs.aws.amazon.com/sync-service/latest/userguide/how-awssync-works.html#terminology">Components
        /// and Terminology</a> in the <i>AWS DataSync User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartTaskExecution service method.</param>
        /// 
        /// <returns>The response from the StartTaskExecution service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/StartTaskExecution">REST API Reference for StartTaskExecution Operation</seealso>
        StartTaskExecutionResponse StartTaskExecution(StartTaskExecutionRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the StartTaskExecution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartTaskExecution operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/StartTaskExecution">REST API Reference for StartTaskExecution Operation</seealso>
        Task<StartTaskExecutionResponse> StartTaskExecutionAsync(StartTaskExecutionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Applies a key-value pair to an AWS resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes a tag from an AWS resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateAgent


        /// <summary>
        /// Updates the name of an agent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAgent service method.</param>
        /// 
        /// <returns>The response from the UpdateAgent service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/UpdateAgent">REST API Reference for UpdateAgent Operation</seealso>
        UpdateAgentResponse UpdateAgent(UpdateAgentRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAgent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAgent operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/UpdateAgent">REST API Reference for UpdateAgent Operation</seealso>
        Task<UpdateAgentResponse> UpdateAgentAsync(UpdateAgentRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateTask


        /// <summary>
        /// Updates the metadata associated with a task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTask service method.</param>
        /// 
        /// <returns>The response from the UpdateTask service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/UpdateTask">REST API Reference for UpdateTask Operation</seealso>
        UpdateTaskResponse UpdateTask(UpdateTaskRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateTask operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/UpdateTask">REST API Reference for UpdateTask Operation</seealso>
        Task<UpdateTaskResponse> UpdateTaskAsync(UpdateTaskRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}