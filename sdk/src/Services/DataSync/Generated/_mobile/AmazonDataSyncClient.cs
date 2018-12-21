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
using System.Net;

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

#if CORECLR
    
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

#endif

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

        internal virtual CancelTaskExecutionResponse CancelTaskExecution(CancelTaskExecutionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelTaskExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelTaskExecutionResponseUnmarshaller.Instance;

            return Invoke<CancelTaskExecutionResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelTaskExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelTaskExecutionResponseUnmarshaller.Instance;

            return InvokeAsync<CancelTaskExecutionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateAgent

        internal virtual CreateAgentResponse CreateAgent(CreateAgentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAgentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAgentResponseUnmarshaller.Instance;

            return Invoke<CreateAgentResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAgentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAgentResponseUnmarshaller.Instance;

            return InvokeAsync<CreateAgentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateLocationEfs

        internal virtual CreateLocationEfsResponse CreateLocationEfs(CreateLocationEfsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLocationEfsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLocationEfsResponseUnmarshaller.Instance;

            return Invoke<CreateLocationEfsResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLocationEfsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLocationEfsResponseUnmarshaller.Instance;

            return InvokeAsync<CreateLocationEfsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateLocationNfs

        internal virtual CreateLocationNfsResponse CreateLocationNfs(CreateLocationNfsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLocationNfsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLocationNfsResponseUnmarshaller.Instance;

            return Invoke<CreateLocationNfsResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLocationNfsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLocationNfsResponseUnmarshaller.Instance;

            return InvokeAsync<CreateLocationNfsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateLocationS3

        internal virtual CreateLocationS3Response CreateLocationS3(CreateLocationS3Request request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLocationS3RequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLocationS3ResponseUnmarshaller.Instance;

            return Invoke<CreateLocationS3Response>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLocationS3RequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLocationS3ResponseUnmarshaller.Instance;

            return InvokeAsync<CreateLocationS3Response>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateTask

        internal virtual CreateTaskResponse CreateTask(CreateTaskRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTaskResponseUnmarshaller.Instance;

            return Invoke<CreateTaskResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTaskResponseUnmarshaller.Instance;

            return InvokeAsync<CreateTaskResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteAgent

        internal virtual DeleteAgentResponse DeleteAgent(DeleteAgentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAgentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAgentResponseUnmarshaller.Instance;

            return Invoke<DeleteAgentResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAgentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAgentResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAgentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteLocation

        internal virtual DeleteLocationResponse DeleteLocation(DeleteLocationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteLocationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLocationResponseUnmarshaller.Instance;

            return Invoke<DeleteLocationResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteLocationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLocationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteLocationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteTask

        internal virtual DeleteTaskResponse DeleteTask(DeleteTaskRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTaskResponseUnmarshaller.Instance;

            return Invoke<DeleteTaskResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTaskResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteTaskResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeAgent

        internal virtual DescribeAgentResponse DescribeAgent(DescribeAgentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAgentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAgentResponseUnmarshaller.Instance;

            return Invoke<DescribeAgentResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAgentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAgentResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAgentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeLocationEfs

        internal virtual DescribeLocationEfsResponse DescribeLocationEfs(DescribeLocationEfsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLocationEfsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLocationEfsResponseUnmarshaller.Instance;

            return Invoke<DescribeLocationEfsResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLocationEfsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLocationEfsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeLocationEfsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeLocationNfs

        internal virtual DescribeLocationNfsResponse DescribeLocationNfs(DescribeLocationNfsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLocationNfsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLocationNfsResponseUnmarshaller.Instance;

            return Invoke<DescribeLocationNfsResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLocationNfsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLocationNfsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeLocationNfsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeLocationS3

        internal virtual DescribeLocationS3Response DescribeLocationS3(DescribeLocationS3Request request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLocationS3RequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLocationS3ResponseUnmarshaller.Instance;

            return Invoke<DescribeLocationS3Response>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLocationS3RequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLocationS3ResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeLocationS3Response>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeTask

        internal virtual DescribeTaskResponse DescribeTask(DescribeTaskRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTaskResponseUnmarshaller.Instance;

            return Invoke<DescribeTaskResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTaskResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeTaskResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeTaskExecution

        internal virtual DescribeTaskExecutionResponse DescribeTaskExecution(DescribeTaskExecutionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTaskExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTaskExecutionResponseUnmarshaller.Instance;

            return Invoke<DescribeTaskExecutionResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTaskExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTaskExecutionResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeTaskExecutionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListAgents

        internal virtual ListAgentsResponse ListAgents(ListAgentsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAgentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAgentsResponseUnmarshaller.Instance;

            return Invoke<ListAgentsResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAgentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAgentsResponseUnmarshaller.Instance;

            return InvokeAsync<ListAgentsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListLocations

        internal virtual ListLocationsResponse ListLocations(ListLocationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListLocationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLocationsResponseUnmarshaller.Instance;

            return Invoke<ListLocationsResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = ListLocationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLocationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListLocationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForResource

        internal virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTaskExecutions

        internal virtual ListTaskExecutionsResponse ListTaskExecutions(ListTaskExecutionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTaskExecutionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTaskExecutionsResponseUnmarshaller.Instance;

            return Invoke<ListTaskExecutionsResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTaskExecutionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTaskExecutionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListTaskExecutionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTasks

        internal virtual ListTasksResponse ListTasks(ListTasksRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTasksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTasksResponseUnmarshaller.Instance;

            return Invoke<ListTasksResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTasksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTasksResponseUnmarshaller.Instance;

            return InvokeAsync<ListTasksResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartTaskExecution

        internal virtual StartTaskExecutionResponse StartTaskExecution(StartTaskExecutionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartTaskExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartTaskExecutionResponseUnmarshaller.Instance;

            return Invoke<StartTaskExecutionResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = StartTaskExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartTaskExecutionResponseUnmarshaller.Instance;

            return InvokeAsync<StartTaskExecutionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TagResource

        internal virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UntagResource

        internal virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateAgent

        internal virtual UpdateAgentResponse UpdateAgent(UpdateAgentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAgentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAgentResponseUnmarshaller.Instance;

            return Invoke<UpdateAgentResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAgentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAgentResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateAgentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateTask

        internal virtual UpdateTaskResponse UpdateTask(UpdateTaskRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTaskResponseUnmarshaller.Instance;

            return Invoke<UpdateTaskResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTaskResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateTaskResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}