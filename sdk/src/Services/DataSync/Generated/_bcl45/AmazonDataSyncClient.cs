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
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.DataSync.Model;
using Amazon.DataSync.Model.Internal.MarshallTransformations;
using Amazon.DataSync.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.DataSync
{
    /// <summary>
    /// Implementation for accessing DataSync
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
    public partial class AmazonDataSyncClient : AmazonServiceClient, IAmazonDataSync
    {
        private static IServiceMetadata serviceMetadata = new AmazonDataSyncMetadata();
        #region Constructors

        /// <summary>
        /// Constructs AmazonDataSyncClient with the credentials loaded from the application's
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
        public AmazonDataSyncClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonDataSyncConfig()) { }

        /// <summary>
        /// Constructs AmazonDataSyncClient with the credentials loaded from the application's
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
        public AmazonDataSyncClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonDataSyncConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonDataSyncClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonDataSyncClient Configuration Object</param>
        public AmazonDataSyncClient(AmazonDataSyncConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonDataSyncClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonDataSyncClient(AWSCredentials credentials)
            : this(credentials, new AmazonDataSyncConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonDataSyncClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonDataSyncClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonDataSyncConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonDataSyncClient with AWS Credentials and an
        /// AmazonDataSyncClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonDataSyncClient Configuration Object</param>
        public AmazonDataSyncClient(AWSCredentials credentials, AmazonDataSyncConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonDataSyncClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonDataSyncClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonDataSyncConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonDataSyncClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonDataSyncClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonDataSyncConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonDataSyncClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonDataSyncClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonDataSyncClient Configuration Object</param>
        public AmazonDataSyncClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonDataSyncConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonDataSyncClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonDataSyncClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonDataSyncConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonDataSyncClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonDataSyncClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonDataSyncConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonDataSyncClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonDataSyncClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonDataSyncClient Configuration Object</param>
        public AmazonDataSyncClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonDataSyncConfig clientConfig)
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

        /// <summary>
        /// Capture metadata for the service.
        /// </summary>
        protected override IServiceMetadata ServiceMetadata
        {
            get
            {
                return serviceMetadata;
            }
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
        public virtual CancelTaskExecutionResponse CancelTaskExecution(CancelTaskExecutionRequest request)
        {
            var marshaller = CancelTaskExecutionRequestMarshaller.Instance;
            var unmarshaller = CancelTaskExecutionResponseUnmarshaller.Instance;

            return Invoke<CancelTaskExecutionRequest,CancelTaskExecutionResponse>(request, marshaller, unmarshaller);
        }

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
        public virtual Task<CancelTaskExecutionResponse> CancelTaskExecutionAsync(CancelTaskExecutionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CancelTaskExecutionRequestMarshaller.Instance;
            var unmarshaller = CancelTaskExecutionResponseUnmarshaller.Instance;

            return InvokeAsync<CancelTaskExecutionRequest,CancelTaskExecutionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public virtual CreateAgentResponse CreateAgent(CreateAgentRequest request)
        {
            var marshaller = CreateAgentRequestMarshaller.Instance;
            var unmarshaller = CreateAgentResponseUnmarshaller.Instance;

            return Invoke<CreateAgentRequest,CreateAgentResponse>(request, marshaller, unmarshaller);
        }

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
        public virtual Task<CreateAgentResponse> CreateAgentAsync(CreateAgentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateAgentRequestMarshaller.Instance;
            var unmarshaller = CreateAgentResponseUnmarshaller.Instance;

            return InvokeAsync<CreateAgentRequest,CreateAgentResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public virtual CreateLocationEfsResponse CreateLocationEfs(CreateLocationEfsRequest request)
        {
            var marshaller = CreateLocationEfsRequestMarshaller.Instance;
            var unmarshaller = CreateLocationEfsResponseUnmarshaller.Instance;

            return Invoke<CreateLocationEfsRequest,CreateLocationEfsResponse>(request, marshaller, unmarshaller);
        }

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
        public virtual Task<CreateLocationEfsResponse> CreateLocationEfsAsync(CreateLocationEfsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateLocationEfsRequestMarshaller.Instance;
            var unmarshaller = CreateLocationEfsResponseUnmarshaller.Instance;

            return InvokeAsync<CreateLocationEfsRequest,CreateLocationEfsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public virtual CreateLocationNfsResponse CreateLocationNfs(CreateLocationNfsRequest request)
        {
            var marshaller = CreateLocationNfsRequestMarshaller.Instance;
            var unmarshaller = CreateLocationNfsResponseUnmarshaller.Instance;

            return Invoke<CreateLocationNfsRequest,CreateLocationNfsResponse>(request, marshaller, unmarshaller);
        }

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
        public virtual Task<CreateLocationNfsResponse> CreateLocationNfsAsync(CreateLocationNfsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateLocationNfsRequestMarshaller.Instance;
            var unmarshaller = CreateLocationNfsResponseUnmarshaller.Instance;

            return InvokeAsync<CreateLocationNfsRequest,CreateLocationNfsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public virtual CreateLocationS3Response CreateLocationS3(CreateLocationS3Request request)
        {
            var marshaller = CreateLocationS3RequestMarshaller.Instance;
            var unmarshaller = CreateLocationS3ResponseUnmarshaller.Instance;

            return Invoke<CreateLocationS3Request,CreateLocationS3Response>(request, marshaller, unmarshaller);
        }

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
        public virtual Task<CreateLocationS3Response> CreateLocationS3Async(CreateLocationS3Request request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateLocationS3RequestMarshaller.Instance;
            var unmarshaller = CreateLocationS3ResponseUnmarshaller.Instance;

            return InvokeAsync<CreateLocationS3Request,CreateLocationS3Response>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public virtual CreateTaskResponse CreateTask(CreateTaskRequest request)
        {
            var marshaller = CreateTaskRequestMarshaller.Instance;
            var unmarshaller = CreateTaskResponseUnmarshaller.Instance;

            return Invoke<CreateTaskRequest,CreateTaskResponse>(request, marshaller, unmarshaller);
        }

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
        public virtual Task<CreateTaskResponse> CreateTaskAsync(CreateTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateTaskRequestMarshaller.Instance;
            var unmarshaller = CreateTaskResponseUnmarshaller.Instance;

            return InvokeAsync<CreateTaskRequest,CreateTaskResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public virtual DeleteAgentResponse DeleteAgent(DeleteAgentRequest request)
        {
            var marshaller = DeleteAgentRequestMarshaller.Instance;
            var unmarshaller = DeleteAgentResponseUnmarshaller.Instance;

            return Invoke<DeleteAgentRequest,DeleteAgentResponse>(request, marshaller, unmarshaller);
        }

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
        public virtual Task<DeleteAgentResponse> DeleteAgentAsync(DeleteAgentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteAgentRequestMarshaller.Instance;
            var unmarshaller = DeleteAgentResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAgentRequest,DeleteAgentResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public virtual DeleteLocationResponse DeleteLocation(DeleteLocationRequest request)
        {
            var marshaller = DeleteLocationRequestMarshaller.Instance;
            var unmarshaller = DeleteLocationResponseUnmarshaller.Instance;

            return Invoke<DeleteLocationRequest,DeleteLocationResponse>(request, marshaller, unmarshaller);
        }

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
        public virtual Task<DeleteLocationResponse> DeleteLocationAsync(DeleteLocationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteLocationRequestMarshaller.Instance;
            var unmarshaller = DeleteLocationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteLocationRequest,DeleteLocationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public virtual DeleteTaskResponse DeleteTask(DeleteTaskRequest request)
        {
            var marshaller = DeleteTaskRequestMarshaller.Instance;
            var unmarshaller = DeleteTaskResponseUnmarshaller.Instance;

            return Invoke<DeleteTaskRequest,DeleteTaskResponse>(request, marshaller, unmarshaller);
        }

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
        public virtual Task<DeleteTaskResponse> DeleteTaskAsync(DeleteTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteTaskRequestMarshaller.Instance;
            var unmarshaller = DeleteTaskResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteTaskRequest,DeleteTaskResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public virtual DescribeAgentResponse DescribeAgent(DescribeAgentRequest request)
        {
            var marshaller = DescribeAgentRequestMarshaller.Instance;
            var unmarshaller = DescribeAgentResponseUnmarshaller.Instance;

            return Invoke<DescribeAgentRequest,DescribeAgentResponse>(request, marshaller, unmarshaller);
        }

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
        public virtual Task<DescribeAgentResponse> DescribeAgentAsync(DescribeAgentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeAgentRequestMarshaller.Instance;
            var unmarshaller = DescribeAgentResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAgentRequest,DescribeAgentResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public virtual DescribeLocationEfsResponse DescribeLocationEfs(DescribeLocationEfsRequest request)
        {
            var marshaller = DescribeLocationEfsRequestMarshaller.Instance;
            var unmarshaller = DescribeLocationEfsResponseUnmarshaller.Instance;

            return Invoke<DescribeLocationEfsRequest,DescribeLocationEfsResponse>(request, marshaller, unmarshaller);
        }

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
        public virtual Task<DescribeLocationEfsResponse> DescribeLocationEfsAsync(DescribeLocationEfsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeLocationEfsRequestMarshaller.Instance;
            var unmarshaller = DescribeLocationEfsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeLocationEfsRequest,DescribeLocationEfsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public virtual DescribeLocationNfsResponse DescribeLocationNfs(DescribeLocationNfsRequest request)
        {
            var marshaller = DescribeLocationNfsRequestMarshaller.Instance;
            var unmarshaller = DescribeLocationNfsResponseUnmarshaller.Instance;

            return Invoke<DescribeLocationNfsRequest,DescribeLocationNfsResponse>(request, marshaller, unmarshaller);
        }

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
        public virtual Task<DescribeLocationNfsResponse> DescribeLocationNfsAsync(DescribeLocationNfsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeLocationNfsRequestMarshaller.Instance;
            var unmarshaller = DescribeLocationNfsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeLocationNfsRequest,DescribeLocationNfsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public virtual DescribeLocationS3Response DescribeLocationS3(DescribeLocationS3Request request)
        {
            var marshaller = DescribeLocationS3RequestMarshaller.Instance;
            var unmarshaller = DescribeLocationS3ResponseUnmarshaller.Instance;

            return Invoke<DescribeLocationS3Request,DescribeLocationS3Response>(request, marshaller, unmarshaller);
        }

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
        public virtual Task<DescribeLocationS3Response> DescribeLocationS3Async(DescribeLocationS3Request request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeLocationS3RequestMarshaller.Instance;
            var unmarshaller = DescribeLocationS3ResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeLocationS3Request,DescribeLocationS3Response>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public virtual DescribeTaskResponse DescribeTask(DescribeTaskRequest request)
        {
            var marshaller = DescribeTaskRequestMarshaller.Instance;
            var unmarshaller = DescribeTaskResponseUnmarshaller.Instance;

            return Invoke<DescribeTaskRequest,DescribeTaskResponse>(request, marshaller, unmarshaller);
        }

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
        public virtual Task<DescribeTaskResponse> DescribeTaskAsync(DescribeTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeTaskRequestMarshaller.Instance;
            var unmarshaller = DescribeTaskResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeTaskRequest,DescribeTaskResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public virtual DescribeTaskExecutionResponse DescribeTaskExecution(DescribeTaskExecutionRequest request)
        {
            var marshaller = DescribeTaskExecutionRequestMarshaller.Instance;
            var unmarshaller = DescribeTaskExecutionResponseUnmarshaller.Instance;

            return Invoke<DescribeTaskExecutionRequest,DescribeTaskExecutionResponse>(request, marshaller, unmarshaller);
        }

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
        public virtual Task<DescribeTaskExecutionResponse> DescribeTaskExecutionAsync(DescribeTaskExecutionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeTaskExecutionRequestMarshaller.Instance;
            var unmarshaller = DescribeTaskExecutionResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeTaskExecutionRequest,DescribeTaskExecutionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public virtual ListAgentsResponse ListAgents(ListAgentsRequest request)
        {
            var marshaller = ListAgentsRequestMarshaller.Instance;
            var unmarshaller = ListAgentsResponseUnmarshaller.Instance;

            return Invoke<ListAgentsRequest,ListAgentsResponse>(request, marshaller, unmarshaller);
        }

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
        public virtual Task<ListAgentsResponse> ListAgentsAsync(ListAgentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListAgentsRequestMarshaller.Instance;
            var unmarshaller = ListAgentsResponseUnmarshaller.Instance;

            return InvokeAsync<ListAgentsRequest,ListAgentsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public virtual ListLocationsResponse ListLocations(ListLocationsRequest request)
        {
            var marshaller = ListLocationsRequestMarshaller.Instance;
            var unmarshaller = ListLocationsResponseUnmarshaller.Instance;

            return Invoke<ListLocationsRequest,ListLocationsResponse>(request, marshaller, unmarshaller);
        }

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
        public virtual Task<ListLocationsResponse> ListLocationsAsync(ListLocationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListLocationsRequestMarshaller.Instance;
            var unmarshaller = ListLocationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListLocationsRequest,ListLocationsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var marshaller = ListTagsForResourceRequestMarshaller.Instance;
            var unmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceRequest,ListTagsForResourceResponse>(request, marshaller, unmarshaller);
        }

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
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListTagsForResourceRequestMarshaller.Instance;
            var unmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceRequest,ListTagsForResourceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public virtual ListTaskExecutionsResponse ListTaskExecutions(ListTaskExecutionsRequest request)
        {
            var marshaller = ListTaskExecutionsRequestMarshaller.Instance;
            var unmarshaller = ListTaskExecutionsResponseUnmarshaller.Instance;

            return Invoke<ListTaskExecutionsRequest,ListTaskExecutionsResponse>(request, marshaller, unmarshaller);
        }

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
        public virtual Task<ListTaskExecutionsResponse> ListTaskExecutionsAsync(ListTaskExecutionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListTaskExecutionsRequestMarshaller.Instance;
            var unmarshaller = ListTaskExecutionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListTaskExecutionsRequest,ListTaskExecutionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        /// <param name="request">Container for the necessary parameters to execute the ListTasks operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/ListTasks">REST API Reference for ListTasks Operation</seealso>
        public virtual Task<ListTasksResponse> ListTasksAsync(ListTasksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListTasksRequestMarshaller.Instance;
            var unmarshaller = ListTasksResponseUnmarshaller.Instance;

            return InvokeAsync<ListTasksRequest,ListTasksResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public virtual StartTaskExecutionResponse StartTaskExecution(StartTaskExecutionRequest request)
        {
            var marshaller = StartTaskExecutionRequestMarshaller.Instance;
            var unmarshaller = StartTaskExecutionResponseUnmarshaller.Instance;

            return Invoke<StartTaskExecutionRequest,StartTaskExecutionResponse>(request, marshaller, unmarshaller);
        }

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
        public virtual Task<StartTaskExecutionResponse> StartTaskExecutionAsync(StartTaskExecutionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = StartTaskExecutionRequestMarshaller.Instance;
            var unmarshaller = StartTaskExecutionResponseUnmarshaller.Instance;

            return InvokeAsync<StartTaskExecutionRequest,StartTaskExecutionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var marshaller = TagResourceRequestMarshaller.Instance;
            var unmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceRequest,TagResourceResponse>(request, marshaller, unmarshaller);
        }

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
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = TagResourceRequestMarshaller.Instance;
            var unmarshaller = TagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<TagResourceRequest,TagResourceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var marshaller = UntagResourceRequestMarshaller.Instance;
            var unmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceRequest,UntagResourceResponse>(request, marshaller, unmarshaller);
        }

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
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UntagResourceRequestMarshaller.Instance;
            var unmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceRequest,UntagResourceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public virtual UpdateAgentResponse UpdateAgent(UpdateAgentRequest request)
        {
            var marshaller = UpdateAgentRequestMarshaller.Instance;
            var unmarshaller = UpdateAgentResponseUnmarshaller.Instance;

            return Invoke<UpdateAgentRequest,UpdateAgentResponse>(request, marshaller, unmarshaller);
        }

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
        public virtual Task<UpdateAgentResponse> UpdateAgentAsync(UpdateAgentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateAgentRequestMarshaller.Instance;
            var unmarshaller = UpdateAgentResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateAgentRequest,UpdateAgentResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public virtual UpdateTaskResponse UpdateTask(UpdateTaskRequest request)
        {
            var marshaller = UpdateTaskRequestMarshaller.Instance;
            var unmarshaller = UpdateTaskResponseUnmarshaller.Instance;

            return Invoke<UpdateTaskRequest,UpdateTaskResponse>(request, marshaller, unmarshaller);
        }

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
        public virtual Task<UpdateTaskResponse> UpdateTaskAsync(UpdateTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateTaskRequestMarshaller.Instance;
            var unmarshaller = UpdateTaskResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateTaskRequest,UpdateTaskResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
    }
}