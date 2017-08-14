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

using Amazon.Glue.Model;
using Amazon.Glue.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Glue
{
    /// <summary>
    /// Implementation for accessing Glue
    ///
    /// Defines service operations used by the GlueFrontendService
    /// </summary>
    public partial class AmazonGlueClient : AmazonServiceClient, IAmazonGlue
    {
        
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

        internal BatchCreatePartitionResponse BatchCreatePartition(BatchCreatePartitionRequest request)
        {
            var marshaller = new BatchCreatePartitionRequestMarshaller();
            var unmarshaller = BatchCreatePartitionResponseUnmarshaller.Instance;

            return Invoke<BatchCreatePartitionRequest,BatchCreatePartitionResponse>(request, marshaller, unmarshaller);
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
        public Task<BatchCreatePartitionResponse> BatchCreatePartitionAsync(BatchCreatePartitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new BatchCreatePartitionRequestMarshaller();
            var unmarshaller = BatchCreatePartitionResponseUnmarshaller.Instance;

            return InvokeAsync<BatchCreatePartitionRequest,BatchCreatePartitionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  BatchDeleteConnection

        internal BatchDeleteConnectionResponse BatchDeleteConnection(BatchDeleteConnectionRequest request)
        {
            var marshaller = new BatchDeleteConnectionRequestMarshaller();
            var unmarshaller = BatchDeleteConnectionResponseUnmarshaller.Instance;

            return Invoke<BatchDeleteConnectionRequest,BatchDeleteConnectionResponse>(request, marshaller, unmarshaller);
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
        public Task<BatchDeleteConnectionResponse> BatchDeleteConnectionAsync(BatchDeleteConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new BatchDeleteConnectionRequestMarshaller();
            var unmarshaller = BatchDeleteConnectionResponseUnmarshaller.Instance;

            return InvokeAsync<BatchDeleteConnectionRequest,BatchDeleteConnectionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  BatchDeletePartition

        internal BatchDeletePartitionResponse BatchDeletePartition(BatchDeletePartitionRequest request)
        {
            var marshaller = new BatchDeletePartitionRequestMarshaller();
            var unmarshaller = BatchDeletePartitionResponseUnmarshaller.Instance;

            return Invoke<BatchDeletePartitionRequest,BatchDeletePartitionResponse>(request, marshaller, unmarshaller);
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
        public Task<BatchDeletePartitionResponse> BatchDeletePartitionAsync(BatchDeletePartitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new BatchDeletePartitionRequestMarshaller();
            var unmarshaller = BatchDeletePartitionResponseUnmarshaller.Instance;

            return InvokeAsync<BatchDeletePartitionRequest,BatchDeletePartitionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  BatchDeleteTable

        internal BatchDeleteTableResponse BatchDeleteTable(BatchDeleteTableRequest request)
        {
            var marshaller = new BatchDeleteTableRequestMarshaller();
            var unmarshaller = BatchDeleteTableResponseUnmarshaller.Instance;

            return Invoke<BatchDeleteTableRequest,BatchDeleteTableResponse>(request, marshaller, unmarshaller);
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
        public Task<BatchDeleteTableResponse> BatchDeleteTableAsync(BatchDeleteTableRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new BatchDeleteTableRequestMarshaller();
            var unmarshaller = BatchDeleteTableResponseUnmarshaller.Instance;

            return InvokeAsync<BatchDeleteTableRequest,BatchDeleteTableResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  BatchGetPartition

        internal BatchGetPartitionResponse BatchGetPartition(BatchGetPartitionRequest request)
        {
            var marshaller = new BatchGetPartitionRequestMarshaller();
            var unmarshaller = BatchGetPartitionResponseUnmarshaller.Instance;

            return Invoke<BatchGetPartitionRequest,BatchGetPartitionResponse>(request, marshaller, unmarshaller);
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
        public Task<BatchGetPartitionResponse> BatchGetPartitionAsync(BatchGetPartitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new BatchGetPartitionRequestMarshaller();
            var unmarshaller = BatchGetPartitionResponseUnmarshaller.Instance;

            return InvokeAsync<BatchGetPartitionRequest,BatchGetPartitionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateClassifier

        internal CreateClassifierResponse CreateClassifier(CreateClassifierRequest request)
        {
            var marshaller = new CreateClassifierRequestMarshaller();
            var unmarshaller = CreateClassifierResponseUnmarshaller.Instance;

            return Invoke<CreateClassifierRequest,CreateClassifierResponse>(request, marshaller, unmarshaller);
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
        public Task<CreateClassifierResponse> CreateClassifierAsync(CreateClassifierRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateClassifierRequestMarshaller();
            var unmarshaller = CreateClassifierResponseUnmarshaller.Instance;

            return InvokeAsync<CreateClassifierRequest,CreateClassifierResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateConnection

        internal CreateConnectionResponse CreateConnection(CreateConnectionRequest request)
        {
            var marshaller = new CreateConnectionRequestMarshaller();
            var unmarshaller = CreateConnectionResponseUnmarshaller.Instance;

            return Invoke<CreateConnectionRequest,CreateConnectionResponse>(request, marshaller, unmarshaller);
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
        public Task<CreateConnectionResponse> CreateConnectionAsync(CreateConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateConnectionRequestMarshaller();
            var unmarshaller = CreateConnectionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateConnectionRequest,CreateConnectionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateCrawler

        internal CreateCrawlerResponse CreateCrawler(CreateCrawlerRequest request)
        {
            var marshaller = new CreateCrawlerRequestMarshaller();
            var unmarshaller = CreateCrawlerResponseUnmarshaller.Instance;

            return Invoke<CreateCrawlerRequest,CreateCrawlerResponse>(request, marshaller, unmarshaller);
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
        public Task<CreateCrawlerResponse> CreateCrawlerAsync(CreateCrawlerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateCrawlerRequestMarshaller();
            var unmarshaller = CreateCrawlerResponseUnmarshaller.Instance;

            return InvokeAsync<CreateCrawlerRequest,CreateCrawlerResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateDatabase

        internal CreateDatabaseResponse CreateDatabase(CreateDatabaseRequest request)
        {
            var marshaller = new CreateDatabaseRequestMarshaller();
            var unmarshaller = CreateDatabaseResponseUnmarshaller.Instance;

            return Invoke<CreateDatabaseRequest,CreateDatabaseResponse>(request, marshaller, unmarshaller);
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
        public Task<CreateDatabaseResponse> CreateDatabaseAsync(CreateDatabaseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateDatabaseRequestMarshaller();
            var unmarshaller = CreateDatabaseResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDatabaseRequest,CreateDatabaseResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateDevEndpoint

        internal CreateDevEndpointResponse CreateDevEndpoint(CreateDevEndpointRequest request)
        {
            var marshaller = new CreateDevEndpointRequestMarshaller();
            var unmarshaller = CreateDevEndpointResponseUnmarshaller.Instance;

            return Invoke<CreateDevEndpointRequest,CreateDevEndpointResponse>(request, marshaller, unmarshaller);
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
        public Task<CreateDevEndpointResponse> CreateDevEndpointAsync(CreateDevEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateDevEndpointRequestMarshaller();
            var unmarshaller = CreateDevEndpointResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDevEndpointRequest,CreateDevEndpointResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateJob

        internal CreateJobResponse CreateJob(CreateJobRequest request)
        {
            var marshaller = new CreateJobRequestMarshaller();
            var unmarshaller = CreateJobResponseUnmarshaller.Instance;

            return Invoke<CreateJobRequest,CreateJobResponse>(request, marshaller, unmarshaller);
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
        public Task<CreateJobResponse> CreateJobAsync(CreateJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateJobRequestMarshaller();
            var unmarshaller = CreateJobResponseUnmarshaller.Instance;

            return InvokeAsync<CreateJobRequest,CreateJobResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreatePartition

        internal CreatePartitionResponse CreatePartition(CreatePartitionRequest request)
        {
            var marshaller = new CreatePartitionRequestMarshaller();
            var unmarshaller = CreatePartitionResponseUnmarshaller.Instance;

            return Invoke<CreatePartitionRequest,CreatePartitionResponse>(request, marshaller, unmarshaller);
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
        public Task<CreatePartitionResponse> CreatePartitionAsync(CreatePartitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreatePartitionRequestMarshaller();
            var unmarshaller = CreatePartitionResponseUnmarshaller.Instance;

            return InvokeAsync<CreatePartitionRequest,CreatePartitionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateScript

        internal CreateScriptResponse CreateScript(CreateScriptRequest request)
        {
            var marshaller = new CreateScriptRequestMarshaller();
            var unmarshaller = CreateScriptResponseUnmarshaller.Instance;

            return Invoke<CreateScriptRequest,CreateScriptResponse>(request, marshaller, unmarshaller);
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
        public Task<CreateScriptResponse> CreateScriptAsync(CreateScriptRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateScriptRequestMarshaller();
            var unmarshaller = CreateScriptResponseUnmarshaller.Instance;

            return InvokeAsync<CreateScriptRequest,CreateScriptResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateTable

        internal CreateTableResponse CreateTable(CreateTableRequest request)
        {
            var marshaller = new CreateTableRequestMarshaller();
            var unmarshaller = CreateTableResponseUnmarshaller.Instance;

            return Invoke<CreateTableRequest,CreateTableResponse>(request, marshaller, unmarshaller);
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
        public Task<CreateTableResponse> CreateTableAsync(CreateTableRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateTableRequestMarshaller();
            var unmarshaller = CreateTableResponseUnmarshaller.Instance;

            return InvokeAsync<CreateTableRequest,CreateTableResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateTrigger

        internal CreateTriggerResponse CreateTrigger(CreateTriggerRequest request)
        {
            var marshaller = new CreateTriggerRequestMarshaller();
            var unmarshaller = CreateTriggerResponseUnmarshaller.Instance;

            return Invoke<CreateTriggerRequest,CreateTriggerResponse>(request, marshaller, unmarshaller);
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
        public Task<CreateTriggerResponse> CreateTriggerAsync(CreateTriggerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateTriggerRequestMarshaller();
            var unmarshaller = CreateTriggerResponseUnmarshaller.Instance;

            return InvokeAsync<CreateTriggerRequest,CreateTriggerResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateUserDefinedFunction

        internal CreateUserDefinedFunctionResponse CreateUserDefinedFunction(CreateUserDefinedFunctionRequest request)
        {
            var marshaller = new CreateUserDefinedFunctionRequestMarshaller();
            var unmarshaller = CreateUserDefinedFunctionResponseUnmarshaller.Instance;

            return Invoke<CreateUserDefinedFunctionRequest,CreateUserDefinedFunctionResponse>(request, marshaller, unmarshaller);
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
        public Task<CreateUserDefinedFunctionResponse> CreateUserDefinedFunctionAsync(CreateUserDefinedFunctionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateUserDefinedFunctionRequestMarshaller();
            var unmarshaller = CreateUserDefinedFunctionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateUserDefinedFunctionRequest,CreateUserDefinedFunctionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteClassifier

        internal DeleteClassifierResponse DeleteClassifier(DeleteClassifierRequest request)
        {
            var marshaller = new DeleteClassifierRequestMarshaller();
            var unmarshaller = DeleteClassifierResponseUnmarshaller.Instance;

            return Invoke<DeleteClassifierRequest,DeleteClassifierResponse>(request, marshaller, unmarshaller);
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
        public Task<DeleteClassifierResponse> DeleteClassifierAsync(DeleteClassifierRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteClassifierRequestMarshaller();
            var unmarshaller = DeleteClassifierResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteClassifierRequest,DeleteClassifierResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteConnection

        internal DeleteConnectionResponse DeleteConnection(DeleteConnectionRequest request)
        {
            var marshaller = new DeleteConnectionRequestMarshaller();
            var unmarshaller = DeleteConnectionResponseUnmarshaller.Instance;

            return Invoke<DeleteConnectionRequest,DeleteConnectionResponse>(request, marshaller, unmarshaller);
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
        public Task<DeleteConnectionResponse> DeleteConnectionAsync(DeleteConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteConnectionRequestMarshaller();
            var unmarshaller = DeleteConnectionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteConnectionRequest,DeleteConnectionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteCrawler

        internal DeleteCrawlerResponse DeleteCrawler(DeleteCrawlerRequest request)
        {
            var marshaller = new DeleteCrawlerRequestMarshaller();
            var unmarshaller = DeleteCrawlerResponseUnmarshaller.Instance;

            return Invoke<DeleteCrawlerRequest,DeleteCrawlerResponse>(request, marshaller, unmarshaller);
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
        public Task<DeleteCrawlerResponse> DeleteCrawlerAsync(DeleteCrawlerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteCrawlerRequestMarshaller();
            var unmarshaller = DeleteCrawlerResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteCrawlerRequest,DeleteCrawlerResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteDatabase

        internal DeleteDatabaseResponse DeleteDatabase(DeleteDatabaseRequest request)
        {
            var marshaller = new DeleteDatabaseRequestMarshaller();
            var unmarshaller = DeleteDatabaseResponseUnmarshaller.Instance;

            return Invoke<DeleteDatabaseRequest,DeleteDatabaseResponse>(request, marshaller, unmarshaller);
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
        public Task<DeleteDatabaseResponse> DeleteDatabaseAsync(DeleteDatabaseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteDatabaseRequestMarshaller();
            var unmarshaller = DeleteDatabaseResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDatabaseRequest,DeleteDatabaseResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteDevEndpoint

        internal DeleteDevEndpointResponse DeleteDevEndpoint(DeleteDevEndpointRequest request)
        {
            var marshaller = new DeleteDevEndpointRequestMarshaller();
            var unmarshaller = DeleteDevEndpointResponseUnmarshaller.Instance;

            return Invoke<DeleteDevEndpointRequest,DeleteDevEndpointResponse>(request, marshaller, unmarshaller);
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
        public Task<DeleteDevEndpointResponse> DeleteDevEndpointAsync(DeleteDevEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteDevEndpointRequestMarshaller();
            var unmarshaller = DeleteDevEndpointResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDevEndpointRequest,DeleteDevEndpointResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteJob

        internal DeleteJobResponse DeleteJob(DeleteJobRequest request)
        {
            var marshaller = new DeleteJobRequestMarshaller();
            var unmarshaller = DeleteJobResponseUnmarshaller.Instance;

            return Invoke<DeleteJobRequest,DeleteJobResponse>(request, marshaller, unmarshaller);
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
        public Task<DeleteJobResponse> DeleteJobAsync(DeleteJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteJobRequestMarshaller();
            var unmarshaller = DeleteJobResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteJobRequest,DeleteJobResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeletePartition

        internal DeletePartitionResponse DeletePartition(DeletePartitionRequest request)
        {
            var marshaller = new DeletePartitionRequestMarshaller();
            var unmarshaller = DeletePartitionResponseUnmarshaller.Instance;

            return Invoke<DeletePartitionRequest,DeletePartitionResponse>(request, marshaller, unmarshaller);
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
        public Task<DeletePartitionResponse> DeletePartitionAsync(DeletePartitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeletePartitionRequestMarshaller();
            var unmarshaller = DeletePartitionResponseUnmarshaller.Instance;

            return InvokeAsync<DeletePartitionRequest,DeletePartitionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteTable

        internal DeleteTableResponse DeleteTable(DeleteTableRequest request)
        {
            var marshaller = new DeleteTableRequestMarshaller();
            var unmarshaller = DeleteTableResponseUnmarshaller.Instance;

            return Invoke<DeleteTableRequest,DeleteTableResponse>(request, marshaller, unmarshaller);
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
        public Task<DeleteTableResponse> DeleteTableAsync(DeleteTableRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteTableRequestMarshaller();
            var unmarshaller = DeleteTableResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteTableRequest,DeleteTableResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteTrigger

        internal DeleteTriggerResponse DeleteTrigger(DeleteTriggerRequest request)
        {
            var marshaller = new DeleteTriggerRequestMarshaller();
            var unmarshaller = DeleteTriggerResponseUnmarshaller.Instance;

            return Invoke<DeleteTriggerRequest,DeleteTriggerResponse>(request, marshaller, unmarshaller);
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
        public Task<DeleteTriggerResponse> DeleteTriggerAsync(DeleteTriggerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteTriggerRequestMarshaller();
            var unmarshaller = DeleteTriggerResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteTriggerRequest,DeleteTriggerResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteUserDefinedFunction

        internal DeleteUserDefinedFunctionResponse DeleteUserDefinedFunction(DeleteUserDefinedFunctionRequest request)
        {
            var marshaller = new DeleteUserDefinedFunctionRequestMarshaller();
            var unmarshaller = DeleteUserDefinedFunctionResponseUnmarshaller.Instance;

            return Invoke<DeleteUserDefinedFunctionRequest,DeleteUserDefinedFunctionResponse>(request, marshaller, unmarshaller);
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
        public Task<DeleteUserDefinedFunctionResponse> DeleteUserDefinedFunctionAsync(DeleteUserDefinedFunctionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteUserDefinedFunctionRequestMarshaller();
            var unmarshaller = DeleteUserDefinedFunctionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteUserDefinedFunctionRequest,DeleteUserDefinedFunctionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetCatalogImportStatus

        internal GetCatalogImportStatusResponse GetCatalogImportStatus(GetCatalogImportStatusRequest request)
        {
            var marshaller = new GetCatalogImportStatusRequestMarshaller();
            var unmarshaller = GetCatalogImportStatusResponseUnmarshaller.Instance;

            return Invoke<GetCatalogImportStatusRequest,GetCatalogImportStatusResponse>(request, marshaller, unmarshaller);
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
        public Task<GetCatalogImportStatusResponse> GetCatalogImportStatusAsync(GetCatalogImportStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetCatalogImportStatusRequestMarshaller();
            var unmarshaller = GetCatalogImportStatusResponseUnmarshaller.Instance;

            return InvokeAsync<GetCatalogImportStatusRequest,GetCatalogImportStatusResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetClassifier

        internal GetClassifierResponse GetClassifier(GetClassifierRequest request)
        {
            var marshaller = new GetClassifierRequestMarshaller();
            var unmarshaller = GetClassifierResponseUnmarshaller.Instance;

            return Invoke<GetClassifierRequest,GetClassifierResponse>(request, marshaller, unmarshaller);
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
        public Task<GetClassifierResponse> GetClassifierAsync(GetClassifierRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetClassifierRequestMarshaller();
            var unmarshaller = GetClassifierResponseUnmarshaller.Instance;

            return InvokeAsync<GetClassifierRequest,GetClassifierResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetClassifiers

        internal GetClassifiersResponse GetClassifiers(GetClassifiersRequest request)
        {
            var marshaller = new GetClassifiersRequestMarshaller();
            var unmarshaller = GetClassifiersResponseUnmarshaller.Instance;

            return Invoke<GetClassifiersRequest,GetClassifiersResponse>(request, marshaller, unmarshaller);
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
        public Task<GetClassifiersResponse> GetClassifiersAsync(GetClassifiersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetClassifiersRequestMarshaller();
            var unmarshaller = GetClassifiersResponseUnmarshaller.Instance;

            return InvokeAsync<GetClassifiersRequest,GetClassifiersResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetConnection

        internal GetConnectionResponse GetConnection(GetConnectionRequest request)
        {
            var marshaller = new GetConnectionRequestMarshaller();
            var unmarshaller = GetConnectionResponseUnmarshaller.Instance;

            return Invoke<GetConnectionRequest,GetConnectionResponse>(request, marshaller, unmarshaller);
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
        public Task<GetConnectionResponse> GetConnectionAsync(GetConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetConnectionRequestMarshaller();
            var unmarshaller = GetConnectionResponseUnmarshaller.Instance;

            return InvokeAsync<GetConnectionRequest,GetConnectionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetConnections

        internal GetConnectionsResponse GetConnections(GetConnectionsRequest request)
        {
            var marshaller = new GetConnectionsRequestMarshaller();
            var unmarshaller = GetConnectionsResponseUnmarshaller.Instance;

            return Invoke<GetConnectionsRequest,GetConnectionsResponse>(request, marshaller, unmarshaller);
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
        public Task<GetConnectionsResponse> GetConnectionsAsync(GetConnectionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetConnectionsRequestMarshaller();
            var unmarshaller = GetConnectionsResponseUnmarshaller.Instance;

            return InvokeAsync<GetConnectionsRequest,GetConnectionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetCrawler

        internal GetCrawlerResponse GetCrawler(GetCrawlerRequest request)
        {
            var marshaller = new GetCrawlerRequestMarshaller();
            var unmarshaller = GetCrawlerResponseUnmarshaller.Instance;

            return Invoke<GetCrawlerRequest,GetCrawlerResponse>(request, marshaller, unmarshaller);
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
        public Task<GetCrawlerResponse> GetCrawlerAsync(GetCrawlerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetCrawlerRequestMarshaller();
            var unmarshaller = GetCrawlerResponseUnmarshaller.Instance;

            return InvokeAsync<GetCrawlerRequest,GetCrawlerResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetCrawlerMetrics

        internal GetCrawlerMetricsResponse GetCrawlerMetrics(GetCrawlerMetricsRequest request)
        {
            var marshaller = new GetCrawlerMetricsRequestMarshaller();
            var unmarshaller = GetCrawlerMetricsResponseUnmarshaller.Instance;

            return Invoke<GetCrawlerMetricsRequest,GetCrawlerMetricsResponse>(request, marshaller, unmarshaller);
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
        public Task<GetCrawlerMetricsResponse> GetCrawlerMetricsAsync(GetCrawlerMetricsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetCrawlerMetricsRequestMarshaller();
            var unmarshaller = GetCrawlerMetricsResponseUnmarshaller.Instance;

            return InvokeAsync<GetCrawlerMetricsRequest,GetCrawlerMetricsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetCrawlers

        internal GetCrawlersResponse GetCrawlers(GetCrawlersRequest request)
        {
            var marshaller = new GetCrawlersRequestMarshaller();
            var unmarshaller = GetCrawlersResponseUnmarshaller.Instance;

            return Invoke<GetCrawlersRequest,GetCrawlersResponse>(request, marshaller, unmarshaller);
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
        public Task<GetCrawlersResponse> GetCrawlersAsync(GetCrawlersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetCrawlersRequestMarshaller();
            var unmarshaller = GetCrawlersResponseUnmarshaller.Instance;

            return InvokeAsync<GetCrawlersRequest,GetCrawlersResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetDatabase

        internal GetDatabaseResponse GetDatabase(GetDatabaseRequest request)
        {
            var marshaller = new GetDatabaseRequestMarshaller();
            var unmarshaller = GetDatabaseResponseUnmarshaller.Instance;

            return Invoke<GetDatabaseRequest,GetDatabaseResponse>(request, marshaller, unmarshaller);
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
        public Task<GetDatabaseResponse> GetDatabaseAsync(GetDatabaseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetDatabaseRequestMarshaller();
            var unmarshaller = GetDatabaseResponseUnmarshaller.Instance;

            return InvokeAsync<GetDatabaseRequest,GetDatabaseResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetDatabases

        internal GetDatabasesResponse GetDatabases(GetDatabasesRequest request)
        {
            var marshaller = new GetDatabasesRequestMarshaller();
            var unmarshaller = GetDatabasesResponseUnmarshaller.Instance;

            return Invoke<GetDatabasesRequest,GetDatabasesResponse>(request, marshaller, unmarshaller);
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
        public Task<GetDatabasesResponse> GetDatabasesAsync(GetDatabasesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetDatabasesRequestMarshaller();
            var unmarshaller = GetDatabasesResponseUnmarshaller.Instance;

            return InvokeAsync<GetDatabasesRequest,GetDatabasesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetDataflowGraph

        internal GetDataflowGraphResponse GetDataflowGraph(GetDataflowGraphRequest request)
        {
            var marshaller = new GetDataflowGraphRequestMarshaller();
            var unmarshaller = GetDataflowGraphResponseUnmarshaller.Instance;

            return Invoke<GetDataflowGraphRequest,GetDataflowGraphResponse>(request, marshaller, unmarshaller);
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
        public Task<GetDataflowGraphResponse> GetDataflowGraphAsync(GetDataflowGraphRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetDataflowGraphRequestMarshaller();
            var unmarshaller = GetDataflowGraphResponseUnmarshaller.Instance;

            return InvokeAsync<GetDataflowGraphRequest,GetDataflowGraphResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetDevEndpoint

        internal GetDevEndpointResponse GetDevEndpoint(GetDevEndpointRequest request)
        {
            var marshaller = new GetDevEndpointRequestMarshaller();
            var unmarshaller = GetDevEndpointResponseUnmarshaller.Instance;

            return Invoke<GetDevEndpointRequest,GetDevEndpointResponse>(request, marshaller, unmarshaller);
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
        public Task<GetDevEndpointResponse> GetDevEndpointAsync(GetDevEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetDevEndpointRequestMarshaller();
            var unmarshaller = GetDevEndpointResponseUnmarshaller.Instance;

            return InvokeAsync<GetDevEndpointRequest,GetDevEndpointResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetDevEndpoints

        internal GetDevEndpointsResponse GetDevEndpoints(GetDevEndpointsRequest request)
        {
            var marshaller = new GetDevEndpointsRequestMarshaller();
            var unmarshaller = GetDevEndpointsResponseUnmarshaller.Instance;

            return Invoke<GetDevEndpointsRequest,GetDevEndpointsResponse>(request, marshaller, unmarshaller);
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
        public Task<GetDevEndpointsResponse> GetDevEndpointsAsync(GetDevEndpointsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetDevEndpointsRequestMarshaller();
            var unmarshaller = GetDevEndpointsResponseUnmarshaller.Instance;

            return InvokeAsync<GetDevEndpointsRequest,GetDevEndpointsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetJob

        internal GetJobResponse GetJob(GetJobRequest request)
        {
            var marshaller = new GetJobRequestMarshaller();
            var unmarshaller = GetJobResponseUnmarshaller.Instance;

            return Invoke<GetJobRequest,GetJobResponse>(request, marshaller, unmarshaller);
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
        public Task<GetJobResponse> GetJobAsync(GetJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetJobRequestMarshaller();
            var unmarshaller = GetJobResponseUnmarshaller.Instance;

            return InvokeAsync<GetJobRequest,GetJobResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetJobRun

        internal GetJobRunResponse GetJobRun(GetJobRunRequest request)
        {
            var marshaller = new GetJobRunRequestMarshaller();
            var unmarshaller = GetJobRunResponseUnmarshaller.Instance;

            return Invoke<GetJobRunRequest,GetJobRunResponse>(request, marshaller, unmarshaller);
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
        public Task<GetJobRunResponse> GetJobRunAsync(GetJobRunRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetJobRunRequestMarshaller();
            var unmarshaller = GetJobRunResponseUnmarshaller.Instance;

            return InvokeAsync<GetJobRunRequest,GetJobRunResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetJobRuns

        internal GetJobRunsResponse GetJobRuns(GetJobRunsRequest request)
        {
            var marshaller = new GetJobRunsRequestMarshaller();
            var unmarshaller = GetJobRunsResponseUnmarshaller.Instance;

            return Invoke<GetJobRunsRequest,GetJobRunsResponse>(request, marshaller, unmarshaller);
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
        public Task<GetJobRunsResponse> GetJobRunsAsync(GetJobRunsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetJobRunsRequestMarshaller();
            var unmarshaller = GetJobRunsResponseUnmarshaller.Instance;

            return InvokeAsync<GetJobRunsRequest,GetJobRunsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetJobs

        internal GetJobsResponse GetJobs(GetJobsRequest request)
        {
            var marshaller = new GetJobsRequestMarshaller();
            var unmarshaller = GetJobsResponseUnmarshaller.Instance;

            return Invoke<GetJobsRequest,GetJobsResponse>(request, marshaller, unmarshaller);
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
        public Task<GetJobsResponse> GetJobsAsync(GetJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetJobsRequestMarshaller();
            var unmarshaller = GetJobsResponseUnmarshaller.Instance;

            return InvokeAsync<GetJobsRequest,GetJobsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetMapping

        internal GetMappingResponse GetMapping(GetMappingRequest request)
        {
            var marshaller = new GetMappingRequestMarshaller();
            var unmarshaller = GetMappingResponseUnmarshaller.Instance;

            return Invoke<GetMappingRequest,GetMappingResponse>(request, marshaller, unmarshaller);
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
        public Task<GetMappingResponse> GetMappingAsync(GetMappingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetMappingRequestMarshaller();
            var unmarshaller = GetMappingResponseUnmarshaller.Instance;

            return InvokeAsync<GetMappingRequest,GetMappingResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetPartition

        internal GetPartitionResponse GetPartition(GetPartitionRequest request)
        {
            var marshaller = new GetPartitionRequestMarshaller();
            var unmarshaller = GetPartitionResponseUnmarshaller.Instance;

            return Invoke<GetPartitionRequest,GetPartitionResponse>(request, marshaller, unmarshaller);
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
        public Task<GetPartitionResponse> GetPartitionAsync(GetPartitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetPartitionRequestMarshaller();
            var unmarshaller = GetPartitionResponseUnmarshaller.Instance;

            return InvokeAsync<GetPartitionRequest,GetPartitionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetPartitions

        internal GetPartitionsResponse GetPartitions(GetPartitionsRequest request)
        {
            var marshaller = new GetPartitionsRequestMarshaller();
            var unmarshaller = GetPartitionsResponseUnmarshaller.Instance;

            return Invoke<GetPartitionsRequest,GetPartitionsResponse>(request, marshaller, unmarshaller);
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
        public Task<GetPartitionsResponse> GetPartitionsAsync(GetPartitionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetPartitionsRequestMarshaller();
            var unmarshaller = GetPartitionsResponseUnmarshaller.Instance;

            return InvokeAsync<GetPartitionsRequest,GetPartitionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetPlan

        internal GetPlanResponse GetPlan(GetPlanRequest request)
        {
            var marshaller = new GetPlanRequestMarshaller();
            var unmarshaller = GetPlanResponseUnmarshaller.Instance;

            return Invoke<GetPlanRequest,GetPlanResponse>(request, marshaller, unmarshaller);
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
        public Task<GetPlanResponse> GetPlanAsync(GetPlanRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetPlanRequestMarshaller();
            var unmarshaller = GetPlanResponseUnmarshaller.Instance;

            return InvokeAsync<GetPlanRequest,GetPlanResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetTable

        internal GetTableResponse GetTable(GetTableRequest request)
        {
            var marshaller = new GetTableRequestMarshaller();
            var unmarshaller = GetTableResponseUnmarshaller.Instance;

            return Invoke<GetTableRequest,GetTableResponse>(request, marshaller, unmarshaller);
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
        public Task<GetTableResponse> GetTableAsync(GetTableRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetTableRequestMarshaller();
            var unmarshaller = GetTableResponseUnmarshaller.Instance;

            return InvokeAsync<GetTableRequest,GetTableResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetTables

        internal GetTablesResponse GetTables(GetTablesRequest request)
        {
            var marshaller = new GetTablesRequestMarshaller();
            var unmarshaller = GetTablesResponseUnmarshaller.Instance;

            return Invoke<GetTablesRequest,GetTablesResponse>(request, marshaller, unmarshaller);
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
        public Task<GetTablesResponse> GetTablesAsync(GetTablesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetTablesRequestMarshaller();
            var unmarshaller = GetTablesResponseUnmarshaller.Instance;

            return InvokeAsync<GetTablesRequest,GetTablesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetTableVersions

        internal GetTableVersionsResponse GetTableVersions(GetTableVersionsRequest request)
        {
            var marshaller = new GetTableVersionsRequestMarshaller();
            var unmarshaller = GetTableVersionsResponseUnmarshaller.Instance;

            return Invoke<GetTableVersionsRequest,GetTableVersionsResponse>(request, marshaller, unmarshaller);
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
        public Task<GetTableVersionsResponse> GetTableVersionsAsync(GetTableVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetTableVersionsRequestMarshaller();
            var unmarshaller = GetTableVersionsResponseUnmarshaller.Instance;

            return InvokeAsync<GetTableVersionsRequest,GetTableVersionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetTrigger

        internal GetTriggerResponse GetTrigger(GetTriggerRequest request)
        {
            var marshaller = new GetTriggerRequestMarshaller();
            var unmarshaller = GetTriggerResponseUnmarshaller.Instance;

            return Invoke<GetTriggerRequest,GetTriggerResponse>(request, marshaller, unmarshaller);
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
        public Task<GetTriggerResponse> GetTriggerAsync(GetTriggerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetTriggerRequestMarshaller();
            var unmarshaller = GetTriggerResponseUnmarshaller.Instance;

            return InvokeAsync<GetTriggerRequest,GetTriggerResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetTriggers

        internal GetTriggersResponse GetTriggers(GetTriggersRequest request)
        {
            var marshaller = new GetTriggersRequestMarshaller();
            var unmarshaller = GetTriggersResponseUnmarshaller.Instance;

            return Invoke<GetTriggersRequest,GetTriggersResponse>(request, marshaller, unmarshaller);
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
        public Task<GetTriggersResponse> GetTriggersAsync(GetTriggersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetTriggersRequestMarshaller();
            var unmarshaller = GetTriggersResponseUnmarshaller.Instance;

            return InvokeAsync<GetTriggersRequest,GetTriggersResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetUserDefinedFunction

        internal GetUserDefinedFunctionResponse GetUserDefinedFunction(GetUserDefinedFunctionRequest request)
        {
            var marshaller = new GetUserDefinedFunctionRequestMarshaller();
            var unmarshaller = GetUserDefinedFunctionResponseUnmarshaller.Instance;

            return Invoke<GetUserDefinedFunctionRequest,GetUserDefinedFunctionResponse>(request, marshaller, unmarshaller);
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
        public Task<GetUserDefinedFunctionResponse> GetUserDefinedFunctionAsync(GetUserDefinedFunctionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetUserDefinedFunctionRequestMarshaller();
            var unmarshaller = GetUserDefinedFunctionResponseUnmarshaller.Instance;

            return InvokeAsync<GetUserDefinedFunctionRequest,GetUserDefinedFunctionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetUserDefinedFunctions

        internal GetUserDefinedFunctionsResponse GetUserDefinedFunctions(GetUserDefinedFunctionsRequest request)
        {
            var marshaller = new GetUserDefinedFunctionsRequestMarshaller();
            var unmarshaller = GetUserDefinedFunctionsResponseUnmarshaller.Instance;

            return Invoke<GetUserDefinedFunctionsRequest,GetUserDefinedFunctionsResponse>(request, marshaller, unmarshaller);
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
        public Task<GetUserDefinedFunctionsResponse> GetUserDefinedFunctionsAsync(GetUserDefinedFunctionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetUserDefinedFunctionsRequestMarshaller();
            var unmarshaller = GetUserDefinedFunctionsResponseUnmarshaller.Instance;

            return InvokeAsync<GetUserDefinedFunctionsRequest,GetUserDefinedFunctionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ImportCatalogToGlue

        internal ImportCatalogToGlueResponse ImportCatalogToGlue(ImportCatalogToGlueRequest request)
        {
            var marshaller = new ImportCatalogToGlueRequestMarshaller();
            var unmarshaller = ImportCatalogToGlueResponseUnmarshaller.Instance;

            return Invoke<ImportCatalogToGlueRequest,ImportCatalogToGlueResponse>(request, marshaller, unmarshaller);
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
        public Task<ImportCatalogToGlueResponse> ImportCatalogToGlueAsync(ImportCatalogToGlueRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ImportCatalogToGlueRequestMarshaller();
            var unmarshaller = ImportCatalogToGlueResponseUnmarshaller.Instance;

            return InvokeAsync<ImportCatalogToGlueRequest,ImportCatalogToGlueResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ResetJobBookmark

        internal ResetJobBookmarkResponse ResetJobBookmark(ResetJobBookmarkRequest request)
        {
            var marshaller = new ResetJobBookmarkRequestMarshaller();
            var unmarshaller = ResetJobBookmarkResponseUnmarshaller.Instance;

            return Invoke<ResetJobBookmarkRequest,ResetJobBookmarkResponse>(request, marshaller, unmarshaller);
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
        public Task<ResetJobBookmarkResponse> ResetJobBookmarkAsync(ResetJobBookmarkRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ResetJobBookmarkRequestMarshaller();
            var unmarshaller = ResetJobBookmarkResponseUnmarshaller.Instance;

            return InvokeAsync<ResetJobBookmarkRequest,ResetJobBookmarkResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  StartCrawler

        internal StartCrawlerResponse StartCrawler(StartCrawlerRequest request)
        {
            var marshaller = new StartCrawlerRequestMarshaller();
            var unmarshaller = StartCrawlerResponseUnmarshaller.Instance;

            return Invoke<StartCrawlerRequest,StartCrawlerResponse>(request, marshaller, unmarshaller);
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
        public Task<StartCrawlerResponse> StartCrawlerAsync(StartCrawlerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new StartCrawlerRequestMarshaller();
            var unmarshaller = StartCrawlerResponseUnmarshaller.Instance;

            return InvokeAsync<StartCrawlerRequest,StartCrawlerResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  StartCrawlerSchedule

        internal StartCrawlerScheduleResponse StartCrawlerSchedule(StartCrawlerScheduleRequest request)
        {
            var marshaller = new StartCrawlerScheduleRequestMarshaller();
            var unmarshaller = StartCrawlerScheduleResponseUnmarshaller.Instance;

            return Invoke<StartCrawlerScheduleRequest,StartCrawlerScheduleResponse>(request, marshaller, unmarshaller);
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
        public Task<StartCrawlerScheduleResponse> StartCrawlerScheduleAsync(StartCrawlerScheduleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new StartCrawlerScheduleRequestMarshaller();
            var unmarshaller = StartCrawlerScheduleResponseUnmarshaller.Instance;

            return InvokeAsync<StartCrawlerScheduleRequest,StartCrawlerScheduleResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  StartJobRun

        internal StartJobRunResponse StartJobRun(StartJobRunRequest request)
        {
            var marshaller = new StartJobRunRequestMarshaller();
            var unmarshaller = StartJobRunResponseUnmarshaller.Instance;

            return Invoke<StartJobRunRequest,StartJobRunResponse>(request, marshaller, unmarshaller);
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
        public Task<StartJobRunResponse> StartJobRunAsync(StartJobRunRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new StartJobRunRequestMarshaller();
            var unmarshaller = StartJobRunResponseUnmarshaller.Instance;

            return InvokeAsync<StartJobRunRequest,StartJobRunResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  StartTrigger

        internal StartTriggerResponse StartTrigger(StartTriggerRequest request)
        {
            var marshaller = new StartTriggerRequestMarshaller();
            var unmarshaller = StartTriggerResponseUnmarshaller.Instance;

            return Invoke<StartTriggerRequest,StartTriggerResponse>(request, marshaller, unmarshaller);
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
        public Task<StartTriggerResponse> StartTriggerAsync(StartTriggerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new StartTriggerRequestMarshaller();
            var unmarshaller = StartTriggerResponseUnmarshaller.Instance;

            return InvokeAsync<StartTriggerRequest,StartTriggerResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  StopCrawler

        internal StopCrawlerResponse StopCrawler(StopCrawlerRequest request)
        {
            var marshaller = new StopCrawlerRequestMarshaller();
            var unmarshaller = StopCrawlerResponseUnmarshaller.Instance;

            return Invoke<StopCrawlerRequest,StopCrawlerResponse>(request, marshaller, unmarshaller);
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
        public Task<StopCrawlerResponse> StopCrawlerAsync(StopCrawlerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new StopCrawlerRequestMarshaller();
            var unmarshaller = StopCrawlerResponseUnmarshaller.Instance;

            return InvokeAsync<StopCrawlerRequest,StopCrawlerResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  StopCrawlerSchedule

        internal StopCrawlerScheduleResponse StopCrawlerSchedule(StopCrawlerScheduleRequest request)
        {
            var marshaller = new StopCrawlerScheduleRequestMarshaller();
            var unmarshaller = StopCrawlerScheduleResponseUnmarshaller.Instance;

            return Invoke<StopCrawlerScheduleRequest,StopCrawlerScheduleResponse>(request, marshaller, unmarshaller);
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
        public Task<StopCrawlerScheduleResponse> StopCrawlerScheduleAsync(StopCrawlerScheduleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new StopCrawlerScheduleRequestMarshaller();
            var unmarshaller = StopCrawlerScheduleResponseUnmarshaller.Instance;

            return InvokeAsync<StopCrawlerScheduleRequest,StopCrawlerScheduleResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  StopTrigger

        internal StopTriggerResponse StopTrigger(StopTriggerRequest request)
        {
            var marshaller = new StopTriggerRequestMarshaller();
            var unmarshaller = StopTriggerResponseUnmarshaller.Instance;

            return Invoke<StopTriggerRequest,StopTriggerResponse>(request, marshaller, unmarshaller);
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
        public Task<StopTriggerResponse> StopTriggerAsync(StopTriggerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new StopTriggerRequestMarshaller();
            var unmarshaller = StopTriggerResponseUnmarshaller.Instance;

            return InvokeAsync<StopTriggerRequest,StopTriggerResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateClassifier

        internal UpdateClassifierResponse UpdateClassifier(UpdateClassifierRequest request)
        {
            var marshaller = new UpdateClassifierRequestMarshaller();
            var unmarshaller = UpdateClassifierResponseUnmarshaller.Instance;

            return Invoke<UpdateClassifierRequest,UpdateClassifierResponse>(request, marshaller, unmarshaller);
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
        public Task<UpdateClassifierResponse> UpdateClassifierAsync(UpdateClassifierRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateClassifierRequestMarshaller();
            var unmarshaller = UpdateClassifierResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateClassifierRequest,UpdateClassifierResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateConnection

        internal UpdateConnectionResponse UpdateConnection(UpdateConnectionRequest request)
        {
            var marshaller = new UpdateConnectionRequestMarshaller();
            var unmarshaller = UpdateConnectionResponseUnmarshaller.Instance;

            return Invoke<UpdateConnectionRequest,UpdateConnectionResponse>(request, marshaller, unmarshaller);
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
        public Task<UpdateConnectionResponse> UpdateConnectionAsync(UpdateConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateConnectionRequestMarshaller();
            var unmarshaller = UpdateConnectionResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateConnectionRequest,UpdateConnectionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateCrawler

        internal UpdateCrawlerResponse UpdateCrawler(UpdateCrawlerRequest request)
        {
            var marshaller = new UpdateCrawlerRequestMarshaller();
            var unmarshaller = UpdateCrawlerResponseUnmarshaller.Instance;

            return Invoke<UpdateCrawlerRequest,UpdateCrawlerResponse>(request, marshaller, unmarshaller);
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
        public Task<UpdateCrawlerResponse> UpdateCrawlerAsync(UpdateCrawlerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateCrawlerRequestMarshaller();
            var unmarshaller = UpdateCrawlerResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateCrawlerRequest,UpdateCrawlerResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateCrawlerSchedule

        internal UpdateCrawlerScheduleResponse UpdateCrawlerSchedule(UpdateCrawlerScheduleRequest request)
        {
            var marshaller = new UpdateCrawlerScheduleRequestMarshaller();
            var unmarshaller = UpdateCrawlerScheduleResponseUnmarshaller.Instance;

            return Invoke<UpdateCrawlerScheduleRequest,UpdateCrawlerScheduleResponse>(request, marshaller, unmarshaller);
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
        public Task<UpdateCrawlerScheduleResponse> UpdateCrawlerScheduleAsync(UpdateCrawlerScheduleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateCrawlerScheduleRequestMarshaller();
            var unmarshaller = UpdateCrawlerScheduleResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateCrawlerScheduleRequest,UpdateCrawlerScheduleResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateDatabase

        internal UpdateDatabaseResponse UpdateDatabase(UpdateDatabaseRequest request)
        {
            var marshaller = new UpdateDatabaseRequestMarshaller();
            var unmarshaller = UpdateDatabaseResponseUnmarshaller.Instance;

            return Invoke<UpdateDatabaseRequest,UpdateDatabaseResponse>(request, marshaller, unmarshaller);
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
        public Task<UpdateDatabaseResponse> UpdateDatabaseAsync(UpdateDatabaseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateDatabaseRequestMarshaller();
            var unmarshaller = UpdateDatabaseResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateDatabaseRequest,UpdateDatabaseResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateDevEndpoint

        internal UpdateDevEndpointResponse UpdateDevEndpoint(UpdateDevEndpointRequest request)
        {
            var marshaller = new UpdateDevEndpointRequestMarshaller();
            var unmarshaller = UpdateDevEndpointResponseUnmarshaller.Instance;

            return Invoke<UpdateDevEndpointRequest,UpdateDevEndpointResponse>(request, marshaller, unmarshaller);
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
        public Task<UpdateDevEndpointResponse> UpdateDevEndpointAsync(UpdateDevEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateDevEndpointRequestMarshaller();
            var unmarshaller = UpdateDevEndpointResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateDevEndpointRequest,UpdateDevEndpointResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateJob

        internal UpdateJobResponse UpdateJob(UpdateJobRequest request)
        {
            var marshaller = new UpdateJobRequestMarshaller();
            var unmarshaller = UpdateJobResponseUnmarshaller.Instance;

            return Invoke<UpdateJobRequest,UpdateJobResponse>(request, marshaller, unmarshaller);
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
        public Task<UpdateJobResponse> UpdateJobAsync(UpdateJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateJobRequestMarshaller();
            var unmarshaller = UpdateJobResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateJobRequest,UpdateJobResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdatePartition

        internal UpdatePartitionResponse UpdatePartition(UpdatePartitionRequest request)
        {
            var marshaller = new UpdatePartitionRequestMarshaller();
            var unmarshaller = UpdatePartitionResponseUnmarshaller.Instance;

            return Invoke<UpdatePartitionRequest,UpdatePartitionResponse>(request, marshaller, unmarshaller);
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
        public Task<UpdatePartitionResponse> UpdatePartitionAsync(UpdatePartitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdatePartitionRequestMarshaller();
            var unmarshaller = UpdatePartitionResponseUnmarshaller.Instance;

            return InvokeAsync<UpdatePartitionRequest,UpdatePartitionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateTable

        internal UpdateTableResponse UpdateTable(UpdateTableRequest request)
        {
            var marshaller = new UpdateTableRequestMarshaller();
            var unmarshaller = UpdateTableResponseUnmarshaller.Instance;

            return Invoke<UpdateTableRequest,UpdateTableResponse>(request, marshaller, unmarshaller);
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
        public Task<UpdateTableResponse> UpdateTableAsync(UpdateTableRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateTableRequestMarshaller();
            var unmarshaller = UpdateTableResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateTableRequest,UpdateTableResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateTrigger

        internal UpdateTriggerResponse UpdateTrigger(UpdateTriggerRequest request)
        {
            var marshaller = new UpdateTriggerRequestMarshaller();
            var unmarshaller = UpdateTriggerResponseUnmarshaller.Instance;

            return Invoke<UpdateTriggerRequest,UpdateTriggerResponse>(request, marshaller, unmarshaller);
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
        public Task<UpdateTriggerResponse> UpdateTriggerAsync(UpdateTriggerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateTriggerRequestMarshaller();
            var unmarshaller = UpdateTriggerResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateTriggerRequest,UpdateTriggerResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateUserDefinedFunction

        internal UpdateUserDefinedFunctionResponse UpdateUserDefinedFunction(UpdateUserDefinedFunctionRequest request)
        {
            var marshaller = new UpdateUserDefinedFunctionRequestMarshaller();
            var unmarshaller = UpdateUserDefinedFunctionResponseUnmarshaller.Instance;

            return Invoke<UpdateUserDefinedFunctionRequest,UpdateUserDefinedFunctionResponse>(request, marshaller, unmarshaller);
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
        public Task<UpdateUserDefinedFunctionResponse> UpdateUserDefinedFunctionAsync(UpdateUserDefinedFunctionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateUserDefinedFunctionRequestMarshaller();
            var unmarshaller = UpdateUserDefinedFunctionResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateUserDefinedFunctionRequest,UpdateUserDefinedFunctionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
    }
}