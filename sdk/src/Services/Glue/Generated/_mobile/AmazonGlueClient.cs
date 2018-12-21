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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.Glue.Model;
using Amazon.Glue.Model.Internal.MarshallTransformations;
using Amazon.Glue.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Glue
{
    /// <summary>
    /// Implementation for accessing Glue
    ///
    /// AWS Glue 
    /// <para>
    /// Defines the public endpoint for the AWS Glue service.
    /// </para>
    /// </summary>
    public partial class AmazonGlueClient : AmazonServiceClient, IAmazonGlue
    {
        private static IServiceMetadata serviceMetadata = new AmazonGlueMetadata();
        
        #region Constructors

#if CORECLR
    
        /// <summary>
        /// Constructs AmazonGlueClient with the credentials loaded from the application's
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
        public AmazonGlueClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonGlueConfig()) { }

        /// <summary>
        /// Constructs AmazonGlueClient with the credentials loaded from the application's
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
        public AmazonGlueClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonGlueConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonGlueClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonGlueClient Configuration Object</param>
        public AmazonGlueClient(AmazonGlueConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

#endif

        /// <summary>
        /// Constructs AmazonGlueClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonGlueClient(AWSCredentials credentials)
            : this(credentials, new AmazonGlueConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonGlueClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonGlueClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonGlueConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonGlueClient with AWS Credentials and an
        /// AmazonGlueClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonGlueClient Configuration Object</param>
        public AmazonGlueClient(AWSCredentials credentials, AmazonGlueConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonGlueClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonGlueClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonGlueConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonGlueClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonGlueClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonGlueConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonGlueClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonGlueClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonGlueClient Configuration Object</param>
        public AmazonGlueClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonGlueConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonGlueClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonGlueClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonGlueConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonGlueClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonGlueClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonGlueConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonGlueClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonGlueClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonGlueClient Configuration Object</param>
        public AmazonGlueClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonGlueConfig clientConfig)
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


        #region  BatchCreatePartition

        internal virtual BatchCreatePartitionResponse BatchCreatePartition(BatchCreatePartitionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchCreatePartitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchCreatePartitionResponseUnmarshaller.Instance;

            return Invoke<BatchCreatePartitionResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the BatchCreatePartition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchCreatePartition operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/BatchCreatePartition">REST API Reference for BatchCreatePartition Operation</seealso>
        public virtual Task<BatchCreatePartitionResponse> BatchCreatePartitionAsync(BatchCreatePartitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchCreatePartitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchCreatePartitionResponseUnmarshaller.Instance;

            return InvokeAsync<BatchCreatePartitionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  BatchDeleteConnection

        internal virtual BatchDeleteConnectionResponse BatchDeleteConnection(BatchDeleteConnectionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchDeleteConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDeleteConnectionResponseUnmarshaller.Instance;

            return Invoke<BatchDeleteConnectionResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the BatchDeleteConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteConnection operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/BatchDeleteConnection">REST API Reference for BatchDeleteConnection Operation</seealso>
        public virtual Task<BatchDeleteConnectionResponse> BatchDeleteConnectionAsync(BatchDeleteConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchDeleteConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDeleteConnectionResponseUnmarshaller.Instance;

            return InvokeAsync<BatchDeleteConnectionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  BatchDeletePartition

        internal virtual BatchDeletePartitionResponse BatchDeletePartition(BatchDeletePartitionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchDeletePartitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDeletePartitionResponseUnmarshaller.Instance;

            return Invoke<BatchDeletePartitionResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the BatchDeletePartition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchDeletePartition operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/BatchDeletePartition">REST API Reference for BatchDeletePartition Operation</seealso>
        public virtual Task<BatchDeletePartitionResponse> BatchDeletePartitionAsync(BatchDeletePartitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchDeletePartitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDeletePartitionResponseUnmarshaller.Instance;

            return InvokeAsync<BatchDeletePartitionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  BatchDeleteTable

        internal virtual BatchDeleteTableResponse BatchDeleteTable(BatchDeleteTableRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchDeleteTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDeleteTableResponseUnmarshaller.Instance;

            return Invoke<BatchDeleteTableResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the BatchDeleteTable operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteTable operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/BatchDeleteTable">REST API Reference for BatchDeleteTable Operation</seealso>
        public virtual Task<BatchDeleteTableResponse> BatchDeleteTableAsync(BatchDeleteTableRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchDeleteTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDeleteTableResponseUnmarshaller.Instance;

            return InvokeAsync<BatchDeleteTableResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  BatchDeleteTableVersion

        internal virtual BatchDeleteTableVersionResponse BatchDeleteTableVersion(BatchDeleteTableVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchDeleteTableVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDeleteTableVersionResponseUnmarshaller.Instance;

            return Invoke<BatchDeleteTableVersionResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the BatchDeleteTableVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteTableVersion operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/BatchDeleteTableVersion">REST API Reference for BatchDeleteTableVersion Operation</seealso>
        public virtual Task<BatchDeleteTableVersionResponse> BatchDeleteTableVersionAsync(BatchDeleteTableVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchDeleteTableVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDeleteTableVersionResponseUnmarshaller.Instance;

            return InvokeAsync<BatchDeleteTableVersionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  BatchGetPartition

        internal virtual BatchGetPartitionResponse BatchGetPartition(BatchGetPartitionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchGetPartitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetPartitionResponseUnmarshaller.Instance;

            return Invoke<BatchGetPartitionResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the BatchGetPartition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchGetPartition operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/BatchGetPartition">REST API Reference for BatchGetPartition Operation</seealso>
        public virtual Task<BatchGetPartitionResponse> BatchGetPartitionAsync(BatchGetPartitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchGetPartitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetPartitionResponseUnmarshaller.Instance;

            return InvokeAsync<BatchGetPartitionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  BatchStopJobRun

        internal virtual BatchStopJobRunResponse BatchStopJobRun(BatchStopJobRunRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchStopJobRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchStopJobRunResponseUnmarshaller.Instance;

            return Invoke<BatchStopJobRunResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the BatchStopJobRun operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchStopJobRun operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/BatchStopJobRun">REST API Reference for BatchStopJobRun Operation</seealso>
        public virtual Task<BatchStopJobRunResponse> BatchStopJobRunAsync(BatchStopJobRunRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchStopJobRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchStopJobRunResponseUnmarshaller.Instance;

            return InvokeAsync<BatchStopJobRunResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateClassifier

        internal virtual CreateClassifierResponse CreateClassifier(CreateClassifierRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateClassifierRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateClassifierResponseUnmarshaller.Instance;

            return Invoke<CreateClassifierResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateClassifier operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateClassifier operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CreateClassifier">REST API Reference for CreateClassifier Operation</seealso>
        public virtual Task<CreateClassifierResponse> CreateClassifierAsync(CreateClassifierRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateClassifierRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateClassifierResponseUnmarshaller.Instance;

            return InvokeAsync<CreateClassifierResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateConnection

        internal virtual CreateConnectionResponse CreateConnection(CreateConnectionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConnectionResponseUnmarshaller.Instance;

            return Invoke<CreateConnectionResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateConnection operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CreateConnection">REST API Reference for CreateConnection Operation</seealso>
        public virtual Task<CreateConnectionResponse> CreateConnectionAsync(CreateConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConnectionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateConnectionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateCrawler

        internal virtual CreateCrawlerResponse CreateCrawler(CreateCrawlerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateCrawlerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCrawlerResponseUnmarshaller.Instance;

            return Invoke<CreateCrawlerResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateCrawler operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCrawler operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CreateCrawler">REST API Reference for CreateCrawler Operation</seealso>
        public virtual Task<CreateCrawlerResponse> CreateCrawlerAsync(CreateCrawlerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateCrawlerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCrawlerResponseUnmarshaller.Instance;

            return InvokeAsync<CreateCrawlerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateDatabase

        internal virtual CreateDatabaseResponse CreateDatabase(CreateDatabaseRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDatabaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDatabaseResponseUnmarshaller.Instance;

            return Invoke<CreateDatabaseResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateDatabase operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDatabase operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CreateDatabase">REST API Reference for CreateDatabase Operation</seealso>
        public virtual Task<CreateDatabaseResponse> CreateDatabaseAsync(CreateDatabaseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDatabaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDatabaseResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDatabaseResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateDevEndpoint

        internal virtual CreateDevEndpointResponse CreateDevEndpoint(CreateDevEndpointRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDevEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDevEndpointResponseUnmarshaller.Instance;

            return Invoke<CreateDevEndpointResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateDevEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDevEndpoint operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CreateDevEndpoint">REST API Reference for CreateDevEndpoint Operation</seealso>
        public virtual Task<CreateDevEndpointResponse> CreateDevEndpointAsync(CreateDevEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDevEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDevEndpointResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDevEndpointResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateJob

        internal virtual CreateJobResponse CreateJob(CreateJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateJobResponseUnmarshaller.Instance;

            return Invoke<CreateJobResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CreateJob">REST API Reference for CreateJob Operation</seealso>
        public virtual Task<CreateJobResponse> CreateJobAsync(CreateJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateJobResponseUnmarshaller.Instance;

            return InvokeAsync<CreateJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreatePartition

        internal virtual CreatePartitionResponse CreatePartition(CreatePartitionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePartitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePartitionResponseUnmarshaller.Instance;

            return Invoke<CreatePartitionResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreatePartition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePartition operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CreatePartition">REST API Reference for CreatePartition Operation</seealso>
        public virtual Task<CreatePartitionResponse> CreatePartitionAsync(CreatePartitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePartitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePartitionResponseUnmarshaller.Instance;

            return InvokeAsync<CreatePartitionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateScript

        internal virtual CreateScriptResponse CreateScript(CreateScriptRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateScriptRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateScriptResponseUnmarshaller.Instance;

            return Invoke<CreateScriptResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateScript operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateScript operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CreateScript">REST API Reference for CreateScript Operation</seealso>
        public virtual Task<CreateScriptResponse> CreateScriptAsync(CreateScriptRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateScriptRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateScriptResponseUnmarshaller.Instance;

            return InvokeAsync<CreateScriptResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateSecurityConfiguration

        internal virtual CreateSecurityConfigurationResponse CreateSecurityConfiguration(CreateSecurityConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSecurityConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSecurityConfigurationResponseUnmarshaller.Instance;

            return Invoke<CreateSecurityConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateSecurityConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSecurityConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CreateSecurityConfiguration">REST API Reference for CreateSecurityConfiguration Operation</seealso>
        public virtual Task<CreateSecurityConfigurationResponse> CreateSecurityConfigurationAsync(CreateSecurityConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSecurityConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSecurityConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<CreateSecurityConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateTable

        internal virtual CreateTableResponse CreateTable(CreateTableRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTableResponseUnmarshaller.Instance;

            return Invoke<CreateTableResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateTable operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTable operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CreateTable">REST API Reference for CreateTable Operation</seealso>
        public virtual Task<CreateTableResponse> CreateTableAsync(CreateTableRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTableResponseUnmarshaller.Instance;

            return InvokeAsync<CreateTableResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateTrigger

        internal virtual CreateTriggerResponse CreateTrigger(CreateTriggerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTriggerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTriggerResponseUnmarshaller.Instance;

            return Invoke<CreateTriggerResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateTrigger operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTrigger operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CreateTrigger">REST API Reference for CreateTrigger Operation</seealso>
        public virtual Task<CreateTriggerResponse> CreateTriggerAsync(CreateTriggerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTriggerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTriggerResponseUnmarshaller.Instance;

            return InvokeAsync<CreateTriggerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateUserDefinedFunction

        internal virtual CreateUserDefinedFunctionResponse CreateUserDefinedFunction(CreateUserDefinedFunctionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateUserDefinedFunctionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateUserDefinedFunctionResponseUnmarshaller.Instance;

            return Invoke<CreateUserDefinedFunctionResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateUserDefinedFunction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateUserDefinedFunction operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CreateUserDefinedFunction">REST API Reference for CreateUserDefinedFunction Operation</seealso>
        public virtual Task<CreateUserDefinedFunctionResponse> CreateUserDefinedFunctionAsync(CreateUserDefinedFunctionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateUserDefinedFunctionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateUserDefinedFunctionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateUserDefinedFunctionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteClassifier

        internal virtual DeleteClassifierResponse DeleteClassifier(DeleteClassifierRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteClassifierRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteClassifierResponseUnmarshaller.Instance;

            return Invoke<DeleteClassifierResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteClassifier operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteClassifier operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteClassifier">REST API Reference for DeleteClassifier Operation</seealso>
        public virtual Task<DeleteClassifierResponse> DeleteClassifierAsync(DeleteClassifierRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteClassifierRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteClassifierResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteClassifierResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteConnection

        internal virtual DeleteConnectionResponse DeleteConnection(DeleteConnectionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConnectionResponseUnmarshaller.Instance;

            return Invoke<DeleteConnectionResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteConnection operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteConnection">REST API Reference for DeleteConnection Operation</seealso>
        public virtual Task<DeleteConnectionResponse> DeleteConnectionAsync(DeleteConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConnectionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteConnectionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteCrawler

        internal virtual DeleteCrawlerResponse DeleteCrawler(DeleteCrawlerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCrawlerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCrawlerResponseUnmarshaller.Instance;

            return Invoke<DeleteCrawlerResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCrawler operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCrawler operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteCrawler">REST API Reference for DeleteCrawler Operation</seealso>
        public virtual Task<DeleteCrawlerResponse> DeleteCrawlerAsync(DeleteCrawlerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCrawlerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCrawlerResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteCrawlerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteDatabase

        internal virtual DeleteDatabaseResponse DeleteDatabase(DeleteDatabaseRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDatabaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDatabaseResponseUnmarshaller.Instance;

            return Invoke<DeleteDatabaseResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDatabase operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDatabase operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteDatabase">REST API Reference for DeleteDatabase Operation</seealso>
        public virtual Task<DeleteDatabaseResponse> DeleteDatabaseAsync(DeleteDatabaseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDatabaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDatabaseResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDatabaseResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteDevEndpoint

        internal virtual DeleteDevEndpointResponse DeleteDevEndpoint(DeleteDevEndpointRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDevEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDevEndpointResponseUnmarshaller.Instance;

            return Invoke<DeleteDevEndpointResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDevEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDevEndpoint operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteDevEndpoint">REST API Reference for DeleteDevEndpoint Operation</seealso>
        public virtual Task<DeleteDevEndpointResponse> DeleteDevEndpointAsync(DeleteDevEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDevEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDevEndpointResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDevEndpointResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteJob

        internal virtual DeleteJobResponse DeleteJob(DeleteJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteJobResponseUnmarshaller.Instance;

            return Invoke<DeleteJobResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteJob">REST API Reference for DeleteJob Operation</seealso>
        public virtual Task<DeleteJobResponse> DeleteJobAsync(DeleteJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteJobResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeletePartition

        internal virtual DeletePartitionResponse DeletePartition(DeletePartitionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePartitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePartitionResponseUnmarshaller.Instance;

            return Invoke<DeletePartitionResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeletePartition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePartition operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeletePartition">REST API Reference for DeletePartition Operation</seealso>
        public virtual Task<DeletePartitionResponse> DeletePartitionAsync(DeletePartitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePartitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePartitionResponseUnmarshaller.Instance;

            return InvokeAsync<DeletePartitionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteResourcePolicy

        internal virtual DeleteResourcePolicyResponse DeleteResourcePolicy(DeleteResourcePolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteResourcePolicyResponseUnmarshaller.Instance;

            return Invoke<DeleteResourcePolicyResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourcePolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteResourcePolicy">REST API Reference for DeleteResourcePolicy Operation</seealso>
        public virtual Task<DeleteResourcePolicyResponse> DeleteResourcePolicyAsync(DeleteResourcePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteResourcePolicyResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteResourcePolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteSecurityConfiguration

        internal virtual DeleteSecurityConfigurationResponse DeleteSecurityConfiguration(DeleteSecurityConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSecurityConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSecurityConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteSecurityConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSecurityConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSecurityConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteSecurityConfiguration">REST API Reference for DeleteSecurityConfiguration Operation</seealso>
        public virtual Task<DeleteSecurityConfigurationResponse> DeleteSecurityConfigurationAsync(DeleteSecurityConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSecurityConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSecurityConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteSecurityConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteTable

        internal virtual DeleteTableResponse DeleteTable(DeleteTableRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTableResponseUnmarshaller.Instance;

            return Invoke<DeleteTableResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTable operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTable operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteTable">REST API Reference for DeleteTable Operation</seealso>
        public virtual Task<DeleteTableResponse> DeleteTableAsync(DeleteTableRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTableResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteTableResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteTableVersion

        internal virtual DeleteTableVersionResponse DeleteTableVersion(DeleteTableVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTableVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTableVersionResponseUnmarshaller.Instance;

            return Invoke<DeleteTableVersionResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTableVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTableVersion operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteTableVersion">REST API Reference for DeleteTableVersion Operation</seealso>
        public virtual Task<DeleteTableVersionResponse> DeleteTableVersionAsync(DeleteTableVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTableVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTableVersionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteTableVersionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteTrigger

        internal virtual DeleteTriggerResponse DeleteTrigger(DeleteTriggerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTriggerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTriggerResponseUnmarshaller.Instance;

            return Invoke<DeleteTriggerResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTrigger operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTrigger operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteTrigger">REST API Reference for DeleteTrigger Operation</seealso>
        public virtual Task<DeleteTriggerResponse> DeleteTriggerAsync(DeleteTriggerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTriggerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTriggerResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteTriggerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteUserDefinedFunction

        internal virtual DeleteUserDefinedFunctionResponse DeleteUserDefinedFunction(DeleteUserDefinedFunctionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteUserDefinedFunctionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteUserDefinedFunctionResponseUnmarshaller.Instance;

            return Invoke<DeleteUserDefinedFunctionResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteUserDefinedFunction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteUserDefinedFunction operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteUserDefinedFunction">REST API Reference for DeleteUserDefinedFunction Operation</seealso>
        public virtual Task<DeleteUserDefinedFunctionResponse> DeleteUserDefinedFunctionAsync(DeleteUserDefinedFunctionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteUserDefinedFunctionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteUserDefinedFunctionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteUserDefinedFunctionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetCatalogImportStatus

        internal virtual GetCatalogImportStatusResponse GetCatalogImportStatus(GetCatalogImportStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCatalogImportStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCatalogImportStatusResponseUnmarshaller.Instance;

            return Invoke<GetCatalogImportStatusResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetCatalogImportStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCatalogImportStatus operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetCatalogImportStatus">REST API Reference for GetCatalogImportStatus Operation</seealso>
        public virtual Task<GetCatalogImportStatusResponse> GetCatalogImportStatusAsync(GetCatalogImportStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCatalogImportStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCatalogImportStatusResponseUnmarshaller.Instance;

            return InvokeAsync<GetCatalogImportStatusResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetClassifier

        internal virtual GetClassifierResponse GetClassifier(GetClassifierRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetClassifierRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetClassifierResponseUnmarshaller.Instance;

            return Invoke<GetClassifierResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetClassifier operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetClassifier operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetClassifier">REST API Reference for GetClassifier Operation</seealso>
        public virtual Task<GetClassifierResponse> GetClassifierAsync(GetClassifierRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetClassifierRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetClassifierResponseUnmarshaller.Instance;

            return InvokeAsync<GetClassifierResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetClassifiers

        internal virtual GetClassifiersResponse GetClassifiers(GetClassifiersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetClassifiersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetClassifiersResponseUnmarshaller.Instance;

            return Invoke<GetClassifiersResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetClassifiers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetClassifiers operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetClassifiers">REST API Reference for GetClassifiers Operation</seealso>
        public virtual Task<GetClassifiersResponse> GetClassifiersAsync(GetClassifiersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetClassifiersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetClassifiersResponseUnmarshaller.Instance;

            return InvokeAsync<GetClassifiersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetConnection

        internal virtual GetConnectionResponse GetConnection(GetConnectionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConnectionResponseUnmarshaller.Instance;

            return Invoke<GetConnectionResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetConnection operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetConnection">REST API Reference for GetConnection Operation</seealso>
        public virtual Task<GetConnectionResponse> GetConnectionAsync(GetConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConnectionResponseUnmarshaller.Instance;

            return InvokeAsync<GetConnectionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetConnections

        internal virtual GetConnectionsResponse GetConnections(GetConnectionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetConnectionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConnectionsResponseUnmarshaller.Instance;

            return Invoke<GetConnectionsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetConnections operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetConnections operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetConnections">REST API Reference for GetConnections Operation</seealso>
        public virtual Task<GetConnectionsResponse> GetConnectionsAsync(GetConnectionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetConnectionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConnectionsResponseUnmarshaller.Instance;

            return InvokeAsync<GetConnectionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetCrawler

        internal virtual GetCrawlerResponse GetCrawler(GetCrawlerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCrawlerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCrawlerResponseUnmarshaller.Instance;

            return Invoke<GetCrawlerResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetCrawler operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCrawler operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetCrawler">REST API Reference for GetCrawler Operation</seealso>
        public virtual Task<GetCrawlerResponse> GetCrawlerAsync(GetCrawlerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCrawlerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCrawlerResponseUnmarshaller.Instance;

            return InvokeAsync<GetCrawlerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetCrawlerMetrics

        internal virtual GetCrawlerMetricsResponse GetCrawlerMetrics(GetCrawlerMetricsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCrawlerMetricsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCrawlerMetricsResponseUnmarshaller.Instance;

            return Invoke<GetCrawlerMetricsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetCrawlerMetrics operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCrawlerMetrics operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetCrawlerMetrics">REST API Reference for GetCrawlerMetrics Operation</seealso>
        public virtual Task<GetCrawlerMetricsResponse> GetCrawlerMetricsAsync(GetCrawlerMetricsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCrawlerMetricsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCrawlerMetricsResponseUnmarshaller.Instance;

            return InvokeAsync<GetCrawlerMetricsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetCrawlers

        internal virtual GetCrawlersResponse GetCrawlers(GetCrawlersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCrawlersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCrawlersResponseUnmarshaller.Instance;

            return Invoke<GetCrawlersResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetCrawlers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCrawlers operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetCrawlers">REST API Reference for GetCrawlers Operation</seealso>
        public virtual Task<GetCrawlersResponse> GetCrawlersAsync(GetCrawlersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCrawlersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCrawlersResponseUnmarshaller.Instance;

            return InvokeAsync<GetCrawlersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetDatabase

        internal virtual GetDatabaseResponse GetDatabase(GetDatabaseRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDatabaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDatabaseResponseUnmarshaller.Instance;

            return Invoke<GetDatabaseResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetDatabase operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDatabase operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetDatabase">REST API Reference for GetDatabase Operation</seealso>
        public virtual Task<GetDatabaseResponse> GetDatabaseAsync(GetDatabaseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDatabaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDatabaseResponseUnmarshaller.Instance;

            return InvokeAsync<GetDatabaseResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetDatabases

        internal virtual GetDatabasesResponse GetDatabases(GetDatabasesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDatabasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDatabasesResponseUnmarshaller.Instance;

            return Invoke<GetDatabasesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetDatabases operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDatabases operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetDatabases">REST API Reference for GetDatabases Operation</seealso>
        public virtual Task<GetDatabasesResponse> GetDatabasesAsync(GetDatabasesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDatabasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDatabasesResponseUnmarshaller.Instance;

            return InvokeAsync<GetDatabasesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetDataCatalogEncryptionSettings

        internal virtual GetDataCatalogEncryptionSettingsResponse GetDataCatalogEncryptionSettings(GetDataCatalogEncryptionSettingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDataCatalogEncryptionSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDataCatalogEncryptionSettingsResponseUnmarshaller.Instance;

            return Invoke<GetDataCatalogEncryptionSettingsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetDataCatalogEncryptionSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDataCatalogEncryptionSettings operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetDataCatalogEncryptionSettings">REST API Reference for GetDataCatalogEncryptionSettings Operation</seealso>
        public virtual Task<GetDataCatalogEncryptionSettingsResponse> GetDataCatalogEncryptionSettingsAsync(GetDataCatalogEncryptionSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDataCatalogEncryptionSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDataCatalogEncryptionSettingsResponseUnmarshaller.Instance;

            return InvokeAsync<GetDataCatalogEncryptionSettingsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetDataflowGraph

        internal virtual GetDataflowGraphResponse GetDataflowGraph(GetDataflowGraphRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDataflowGraphRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDataflowGraphResponseUnmarshaller.Instance;

            return Invoke<GetDataflowGraphResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetDataflowGraph operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDataflowGraph operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetDataflowGraph">REST API Reference for GetDataflowGraph Operation</seealso>
        public virtual Task<GetDataflowGraphResponse> GetDataflowGraphAsync(GetDataflowGraphRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDataflowGraphRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDataflowGraphResponseUnmarshaller.Instance;

            return InvokeAsync<GetDataflowGraphResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetDevEndpoint

        internal virtual GetDevEndpointResponse GetDevEndpoint(GetDevEndpointRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDevEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDevEndpointResponseUnmarshaller.Instance;

            return Invoke<GetDevEndpointResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetDevEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDevEndpoint operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetDevEndpoint">REST API Reference for GetDevEndpoint Operation</seealso>
        public virtual Task<GetDevEndpointResponse> GetDevEndpointAsync(GetDevEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDevEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDevEndpointResponseUnmarshaller.Instance;

            return InvokeAsync<GetDevEndpointResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetDevEndpoints

        internal virtual GetDevEndpointsResponse GetDevEndpoints(GetDevEndpointsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDevEndpointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDevEndpointsResponseUnmarshaller.Instance;

            return Invoke<GetDevEndpointsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetDevEndpoints operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDevEndpoints operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetDevEndpoints">REST API Reference for GetDevEndpoints Operation</seealso>
        public virtual Task<GetDevEndpointsResponse> GetDevEndpointsAsync(GetDevEndpointsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDevEndpointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDevEndpointsResponseUnmarshaller.Instance;

            return InvokeAsync<GetDevEndpointsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetJob

        internal virtual GetJobResponse GetJob(GetJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetJobResponseUnmarshaller.Instance;

            return Invoke<GetJobResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetJob">REST API Reference for GetJob Operation</seealso>
        public virtual Task<GetJobResponse> GetJobAsync(GetJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetJobResponseUnmarshaller.Instance;

            return InvokeAsync<GetJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetJobRun

        internal virtual GetJobRunResponse GetJobRun(GetJobRunRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetJobRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetJobRunResponseUnmarshaller.Instance;

            return Invoke<GetJobRunResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetJobRun operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetJobRun operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetJobRun">REST API Reference for GetJobRun Operation</seealso>
        public virtual Task<GetJobRunResponse> GetJobRunAsync(GetJobRunRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetJobRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetJobRunResponseUnmarshaller.Instance;

            return InvokeAsync<GetJobRunResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetJobRuns

        internal virtual GetJobRunsResponse GetJobRuns(GetJobRunsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetJobRunsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetJobRunsResponseUnmarshaller.Instance;

            return Invoke<GetJobRunsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetJobRuns operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetJobRuns operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetJobRuns">REST API Reference for GetJobRuns Operation</seealso>
        public virtual Task<GetJobRunsResponse> GetJobRunsAsync(GetJobRunsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetJobRunsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetJobRunsResponseUnmarshaller.Instance;

            return InvokeAsync<GetJobRunsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetJobs

        internal virtual GetJobsResponse GetJobs(GetJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetJobsResponseUnmarshaller.Instance;

            return Invoke<GetJobsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetJobs operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetJobs">REST API Reference for GetJobs Operation</seealso>
        public virtual Task<GetJobsResponse> GetJobsAsync(GetJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetJobsResponseUnmarshaller.Instance;

            return InvokeAsync<GetJobsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetMapping

        internal virtual GetMappingResponse GetMapping(GetMappingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMappingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMappingResponseUnmarshaller.Instance;

            return Invoke<GetMappingResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetMapping operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMapping operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetMapping">REST API Reference for GetMapping Operation</seealso>
        public virtual Task<GetMappingResponse> GetMappingAsync(GetMappingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMappingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMappingResponseUnmarshaller.Instance;

            return InvokeAsync<GetMappingResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetPartition

        internal virtual GetPartitionResponse GetPartition(GetPartitionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPartitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPartitionResponseUnmarshaller.Instance;

            return Invoke<GetPartitionResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetPartition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPartition operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetPartition">REST API Reference for GetPartition Operation</seealso>
        public virtual Task<GetPartitionResponse> GetPartitionAsync(GetPartitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPartitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPartitionResponseUnmarshaller.Instance;

            return InvokeAsync<GetPartitionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetPartitions

        internal virtual GetPartitionsResponse GetPartitions(GetPartitionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPartitionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPartitionsResponseUnmarshaller.Instance;

            return Invoke<GetPartitionsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetPartitions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPartitions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetPartitions">REST API Reference for GetPartitions Operation</seealso>
        public virtual Task<GetPartitionsResponse> GetPartitionsAsync(GetPartitionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPartitionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPartitionsResponseUnmarshaller.Instance;

            return InvokeAsync<GetPartitionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetPlan

        internal virtual GetPlanResponse GetPlan(GetPlanRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPlanResponseUnmarshaller.Instance;

            return Invoke<GetPlanResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetPlan operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPlan operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetPlan">REST API Reference for GetPlan Operation</seealso>
        public virtual Task<GetPlanResponse> GetPlanAsync(GetPlanRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPlanResponseUnmarshaller.Instance;

            return InvokeAsync<GetPlanResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetResourcePolicy

        internal virtual GetResourcePolicyResponse GetResourcePolicy(GetResourcePolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourcePolicyResponseUnmarshaller.Instance;

            return Invoke<GetResourcePolicyResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetResourcePolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetResourcePolicy">REST API Reference for GetResourcePolicy Operation</seealso>
        public virtual Task<GetResourcePolicyResponse> GetResourcePolicyAsync(GetResourcePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourcePolicyResponseUnmarshaller.Instance;

            return InvokeAsync<GetResourcePolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetSecurityConfiguration

        internal virtual GetSecurityConfigurationResponse GetSecurityConfiguration(GetSecurityConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSecurityConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSecurityConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetSecurityConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetSecurityConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSecurityConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetSecurityConfiguration">REST API Reference for GetSecurityConfiguration Operation</seealso>
        public virtual Task<GetSecurityConfigurationResponse> GetSecurityConfigurationAsync(GetSecurityConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSecurityConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSecurityConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<GetSecurityConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetSecurityConfigurations

        internal virtual GetSecurityConfigurationsResponse GetSecurityConfigurations(GetSecurityConfigurationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSecurityConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSecurityConfigurationsResponseUnmarshaller.Instance;

            return Invoke<GetSecurityConfigurationsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetSecurityConfigurations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSecurityConfigurations operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetSecurityConfigurations">REST API Reference for GetSecurityConfigurations Operation</seealso>
        public virtual Task<GetSecurityConfigurationsResponse> GetSecurityConfigurationsAsync(GetSecurityConfigurationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSecurityConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSecurityConfigurationsResponseUnmarshaller.Instance;

            return InvokeAsync<GetSecurityConfigurationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetTable

        internal virtual GetTableResponse GetTable(GetTableRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTableResponseUnmarshaller.Instance;

            return Invoke<GetTableResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetTable operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTable operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetTable">REST API Reference for GetTable Operation</seealso>
        public virtual Task<GetTableResponse> GetTableAsync(GetTableRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTableResponseUnmarshaller.Instance;

            return InvokeAsync<GetTableResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetTables

        internal virtual GetTablesResponse GetTables(GetTablesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTablesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTablesResponseUnmarshaller.Instance;

            return Invoke<GetTablesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetTables operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTables operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetTables">REST API Reference for GetTables Operation</seealso>
        public virtual Task<GetTablesResponse> GetTablesAsync(GetTablesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTablesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTablesResponseUnmarshaller.Instance;

            return InvokeAsync<GetTablesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetTableVersion

        internal virtual GetTableVersionResponse GetTableVersion(GetTableVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTableVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTableVersionResponseUnmarshaller.Instance;

            return Invoke<GetTableVersionResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetTableVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTableVersion operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetTableVersion">REST API Reference for GetTableVersion Operation</seealso>
        public virtual Task<GetTableVersionResponse> GetTableVersionAsync(GetTableVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTableVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTableVersionResponseUnmarshaller.Instance;

            return InvokeAsync<GetTableVersionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetTableVersions

        internal virtual GetTableVersionsResponse GetTableVersions(GetTableVersionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTableVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTableVersionsResponseUnmarshaller.Instance;

            return Invoke<GetTableVersionsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetTableVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTableVersions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetTableVersions">REST API Reference for GetTableVersions Operation</seealso>
        public virtual Task<GetTableVersionsResponse> GetTableVersionsAsync(GetTableVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTableVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTableVersionsResponseUnmarshaller.Instance;

            return InvokeAsync<GetTableVersionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetTrigger

        internal virtual GetTriggerResponse GetTrigger(GetTriggerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTriggerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTriggerResponseUnmarshaller.Instance;

            return Invoke<GetTriggerResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetTrigger operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTrigger operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetTrigger">REST API Reference for GetTrigger Operation</seealso>
        public virtual Task<GetTriggerResponse> GetTriggerAsync(GetTriggerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTriggerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTriggerResponseUnmarshaller.Instance;

            return InvokeAsync<GetTriggerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetTriggers

        internal virtual GetTriggersResponse GetTriggers(GetTriggersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTriggersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTriggersResponseUnmarshaller.Instance;

            return Invoke<GetTriggersResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetTriggers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTriggers operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetTriggers">REST API Reference for GetTriggers Operation</seealso>
        public virtual Task<GetTriggersResponse> GetTriggersAsync(GetTriggersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTriggersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTriggersResponseUnmarshaller.Instance;

            return InvokeAsync<GetTriggersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetUserDefinedFunction

        internal virtual GetUserDefinedFunctionResponse GetUserDefinedFunction(GetUserDefinedFunctionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetUserDefinedFunctionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetUserDefinedFunctionResponseUnmarshaller.Instance;

            return Invoke<GetUserDefinedFunctionResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetUserDefinedFunction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetUserDefinedFunction operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetUserDefinedFunction">REST API Reference for GetUserDefinedFunction Operation</seealso>
        public virtual Task<GetUserDefinedFunctionResponse> GetUserDefinedFunctionAsync(GetUserDefinedFunctionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetUserDefinedFunctionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetUserDefinedFunctionResponseUnmarshaller.Instance;

            return InvokeAsync<GetUserDefinedFunctionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetUserDefinedFunctions

        internal virtual GetUserDefinedFunctionsResponse GetUserDefinedFunctions(GetUserDefinedFunctionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetUserDefinedFunctionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetUserDefinedFunctionsResponseUnmarshaller.Instance;

            return Invoke<GetUserDefinedFunctionsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetUserDefinedFunctions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetUserDefinedFunctions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetUserDefinedFunctions">REST API Reference for GetUserDefinedFunctions Operation</seealso>
        public virtual Task<GetUserDefinedFunctionsResponse> GetUserDefinedFunctionsAsync(GetUserDefinedFunctionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetUserDefinedFunctionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetUserDefinedFunctionsResponseUnmarshaller.Instance;

            return InvokeAsync<GetUserDefinedFunctionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ImportCatalogToGlue

        internal virtual ImportCatalogToGlueResponse ImportCatalogToGlue(ImportCatalogToGlueRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ImportCatalogToGlueRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportCatalogToGlueResponseUnmarshaller.Instance;

            return Invoke<ImportCatalogToGlueResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ImportCatalogToGlue operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ImportCatalogToGlue operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/ImportCatalogToGlue">REST API Reference for ImportCatalogToGlue Operation</seealso>
        public virtual Task<ImportCatalogToGlueResponse> ImportCatalogToGlueAsync(ImportCatalogToGlueRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ImportCatalogToGlueRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportCatalogToGlueResponseUnmarshaller.Instance;

            return InvokeAsync<ImportCatalogToGlueResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutDataCatalogEncryptionSettings

        internal virtual PutDataCatalogEncryptionSettingsResponse PutDataCatalogEncryptionSettings(PutDataCatalogEncryptionSettingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutDataCatalogEncryptionSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutDataCatalogEncryptionSettingsResponseUnmarshaller.Instance;

            return Invoke<PutDataCatalogEncryptionSettingsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PutDataCatalogEncryptionSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutDataCatalogEncryptionSettings operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/PutDataCatalogEncryptionSettings">REST API Reference for PutDataCatalogEncryptionSettings Operation</seealso>
        public virtual Task<PutDataCatalogEncryptionSettingsResponse> PutDataCatalogEncryptionSettingsAsync(PutDataCatalogEncryptionSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutDataCatalogEncryptionSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutDataCatalogEncryptionSettingsResponseUnmarshaller.Instance;

            return InvokeAsync<PutDataCatalogEncryptionSettingsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutResourcePolicy

        internal virtual PutResourcePolicyResponse PutResourcePolicy(PutResourcePolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutResourcePolicyResponseUnmarshaller.Instance;

            return Invoke<PutResourcePolicyResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PutResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutResourcePolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/PutResourcePolicy">REST API Reference for PutResourcePolicy Operation</seealso>
        public virtual Task<PutResourcePolicyResponse> PutResourcePolicyAsync(PutResourcePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutResourcePolicyResponseUnmarshaller.Instance;

            return InvokeAsync<PutResourcePolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ResetJobBookmark

        internal virtual ResetJobBookmarkResponse ResetJobBookmark(ResetJobBookmarkRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ResetJobBookmarkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResetJobBookmarkResponseUnmarshaller.Instance;

            return Invoke<ResetJobBookmarkResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ResetJobBookmark operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResetJobBookmark operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/ResetJobBookmark">REST API Reference for ResetJobBookmark Operation</seealso>
        public virtual Task<ResetJobBookmarkResponse> ResetJobBookmarkAsync(ResetJobBookmarkRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ResetJobBookmarkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResetJobBookmarkResponseUnmarshaller.Instance;

            return InvokeAsync<ResetJobBookmarkResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartCrawler

        internal virtual StartCrawlerResponse StartCrawler(StartCrawlerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartCrawlerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartCrawlerResponseUnmarshaller.Instance;

            return Invoke<StartCrawlerResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the StartCrawler operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartCrawler operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/StartCrawler">REST API Reference for StartCrawler Operation</seealso>
        public virtual Task<StartCrawlerResponse> StartCrawlerAsync(StartCrawlerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartCrawlerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartCrawlerResponseUnmarshaller.Instance;

            return InvokeAsync<StartCrawlerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartCrawlerSchedule

        internal virtual StartCrawlerScheduleResponse StartCrawlerSchedule(StartCrawlerScheduleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartCrawlerScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartCrawlerScheduleResponseUnmarshaller.Instance;

            return Invoke<StartCrawlerScheduleResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the StartCrawlerSchedule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartCrawlerSchedule operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/StartCrawlerSchedule">REST API Reference for StartCrawlerSchedule Operation</seealso>
        public virtual Task<StartCrawlerScheduleResponse> StartCrawlerScheduleAsync(StartCrawlerScheduleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartCrawlerScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartCrawlerScheduleResponseUnmarshaller.Instance;

            return InvokeAsync<StartCrawlerScheduleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartJobRun

        internal virtual StartJobRunResponse StartJobRun(StartJobRunRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartJobRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartJobRunResponseUnmarshaller.Instance;

            return Invoke<StartJobRunResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the StartJobRun operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartJobRun operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/StartJobRun">REST API Reference for StartJobRun Operation</seealso>
        public virtual Task<StartJobRunResponse> StartJobRunAsync(StartJobRunRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartJobRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartJobRunResponseUnmarshaller.Instance;

            return InvokeAsync<StartJobRunResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartTrigger

        internal virtual StartTriggerResponse StartTrigger(StartTriggerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartTriggerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartTriggerResponseUnmarshaller.Instance;

            return Invoke<StartTriggerResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the StartTrigger operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartTrigger operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/StartTrigger">REST API Reference for StartTrigger Operation</seealso>
        public virtual Task<StartTriggerResponse> StartTriggerAsync(StartTriggerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartTriggerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartTriggerResponseUnmarshaller.Instance;

            return InvokeAsync<StartTriggerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StopCrawler

        internal virtual StopCrawlerResponse StopCrawler(StopCrawlerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopCrawlerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopCrawlerResponseUnmarshaller.Instance;

            return Invoke<StopCrawlerResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the StopCrawler operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopCrawler operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/StopCrawler">REST API Reference for StopCrawler Operation</seealso>
        public virtual Task<StopCrawlerResponse> StopCrawlerAsync(StopCrawlerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopCrawlerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopCrawlerResponseUnmarshaller.Instance;

            return InvokeAsync<StopCrawlerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StopCrawlerSchedule

        internal virtual StopCrawlerScheduleResponse StopCrawlerSchedule(StopCrawlerScheduleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopCrawlerScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopCrawlerScheduleResponseUnmarshaller.Instance;

            return Invoke<StopCrawlerScheduleResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the StopCrawlerSchedule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopCrawlerSchedule operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/StopCrawlerSchedule">REST API Reference for StopCrawlerSchedule Operation</seealso>
        public virtual Task<StopCrawlerScheduleResponse> StopCrawlerScheduleAsync(StopCrawlerScheduleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopCrawlerScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopCrawlerScheduleResponseUnmarshaller.Instance;

            return InvokeAsync<StopCrawlerScheduleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StopTrigger

        internal virtual StopTriggerResponse StopTrigger(StopTriggerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopTriggerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopTriggerResponseUnmarshaller.Instance;

            return Invoke<StopTriggerResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the StopTrigger operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopTrigger operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/StopTrigger">REST API Reference for StopTrigger Operation</seealso>
        public virtual Task<StopTriggerResponse> StopTriggerAsync(StopTriggerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopTriggerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopTriggerResponseUnmarshaller.Instance;

            return InvokeAsync<StopTriggerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateClassifier

        internal virtual UpdateClassifierResponse UpdateClassifier(UpdateClassifierRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateClassifierRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateClassifierResponseUnmarshaller.Instance;

            return Invoke<UpdateClassifierResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateClassifier operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateClassifier operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UpdateClassifier">REST API Reference for UpdateClassifier Operation</seealso>
        public virtual Task<UpdateClassifierResponse> UpdateClassifierAsync(UpdateClassifierRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateClassifierRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateClassifierResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateClassifierResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateConnection

        internal virtual UpdateConnectionResponse UpdateConnection(UpdateConnectionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateConnectionResponseUnmarshaller.Instance;

            return Invoke<UpdateConnectionResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateConnection operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UpdateConnection">REST API Reference for UpdateConnection Operation</seealso>
        public virtual Task<UpdateConnectionResponse> UpdateConnectionAsync(UpdateConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateConnectionResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateConnectionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateCrawler

        internal virtual UpdateCrawlerResponse UpdateCrawler(UpdateCrawlerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateCrawlerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCrawlerResponseUnmarshaller.Instance;

            return Invoke<UpdateCrawlerResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateCrawler operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateCrawler operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UpdateCrawler">REST API Reference for UpdateCrawler Operation</seealso>
        public virtual Task<UpdateCrawlerResponse> UpdateCrawlerAsync(UpdateCrawlerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateCrawlerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCrawlerResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateCrawlerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateCrawlerSchedule

        internal virtual UpdateCrawlerScheduleResponse UpdateCrawlerSchedule(UpdateCrawlerScheduleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateCrawlerScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCrawlerScheduleResponseUnmarshaller.Instance;

            return Invoke<UpdateCrawlerScheduleResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateCrawlerSchedule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateCrawlerSchedule operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UpdateCrawlerSchedule">REST API Reference for UpdateCrawlerSchedule Operation</seealso>
        public virtual Task<UpdateCrawlerScheduleResponse> UpdateCrawlerScheduleAsync(UpdateCrawlerScheduleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateCrawlerScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCrawlerScheduleResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateCrawlerScheduleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateDatabase

        internal virtual UpdateDatabaseResponse UpdateDatabase(UpdateDatabaseRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDatabaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDatabaseResponseUnmarshaller.Instance;

            return Invoke<UpdateDatabaseResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDatabase operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDatabase operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UpdateDatabase">REST API Reference for UpdateDatabase Operation</seealso>
        public virtual Task<UpdateDatabaseResponse> UpdateDatabaseAsync(UpdateDatabaseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDatabaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDatabaseResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateDatabaseResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateDevEndpoint

        internal virtual UpdateDevEndpointResponse UpdateDevEndpoint(UpdateDevEndpointRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDevEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDevEndpointResponseUnmarshaller.Instance;

            return Invoke<UpdateDevEndpointResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDevEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDevEndpoint operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UpdateDevEndpoint">REST API Reference for UpdateDevEndpoint Operation</seealso>
        public virtual Task<UpdateDevEndpointResponse> UpdateDevEndpointAsync(UpdateDevEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDevEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDevEndpointResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateDevEndpointResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateJob

        internal virtual UpdateJobResponse UpdateJob(UpdateJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateJobResponseUnmarshaller.Instance;

            return Invoke<UpdateJobResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UpdateJob">REST API Reference for UpdateJob Operation</seealso>
        public virtual Task<UpdateJobResponse> UpdateJobAsync(UpdateJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateJobResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdatePartition

        internal virtual UpdatePartitionResponse UpdatePartition(UpdatePartitionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdatePartitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePartitionResponseUnmarshaller.Instance;

            return Invoke<UpdatePartitionResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdatePartition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdatePartition operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UpdatePartition">REST API Reference for UpdatePartition Operation</seealso>
        public virtual Task<UpdatePartitionResponse> UpdatePartitionAsync(UpdatePartitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdatePartitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePartitionResponseUnmarshaller.Instance;

            return InvokeAsync<UpdatePartitionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateTable

        internal virtual UpdateTableResponse UpdateTable(UpdateTableRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTableResponseUnmarshaller.Instance;

            return Invoke<UpdateTableResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateTable operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateTable operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UpdateTable">REST API Reference for UpdateTable Operation</seealso>
        public virtual Task<UpdateTableResponse> UpdateTableAsync(UpdateTableRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTableResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateTableResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateTrigger

        internal virtual UpdateTriggerResponse UpdateTrigger(UpdateTriggerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateTriggerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTriggerResponseUnmarshaller.Instance;

            return Invoke<UpdateTriggerResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateTrigger operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateTrigger operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UpdateTrigger">REST API Reference for UpdateTrigger Operation</seealso>
        public virtual Task<UpdateTriggerResponse> UpdateTriggerAsync(UpdateTriggerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateTriggerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTriggerResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateTriggerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateUserDefinedFunction

        internal virtual UpdateUserDefinedFunctionResponse UpdateUserDefinedFunction(UpdateUserDefinedFunctionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateUserDefinedFunctionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateUserDefinedFunctionResponseUnmarshaller.Instance;

            return Invoke<UpdateUserDefinedFunctionResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateUserDefinedFunction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateUserDefinedFunction operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UpdateUserDefinedFunction">REST API Reference for UpdateUserDefinedFunction Operation</seealso>
        public virtual Task<UpdateUserDefinedFunctionResponse> UpdateUserDefinedFunctionAsync(UpdateUserDefinedFunctionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateUserDefinedFunctionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateUserDefinedFunctionResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateUserDefinedFunctionResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}