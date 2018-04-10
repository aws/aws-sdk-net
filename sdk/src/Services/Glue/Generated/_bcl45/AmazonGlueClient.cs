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
    /// AWS Glue 
    /// <para>
    /// Defines the public endpoint for the AWS Glue service.
    /// </para>
    /// </summary>
    public partial class AmazonGlueClient : AmazonServiceClient, IAmazonGlue
    {
        #region Constructors

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


        /// <summary>
        /// Creates one or more partitions in a batch operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchCreatePartition service method.</param>
        /// 
        /// <returns>The response from the BatchCreatePartition service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.AlreadyExistsException">
        /// A resource to be created or added already exists.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.ResourceNumberLimitExceededException">
        /// A resource numerical limit was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/BatchCreatePartition">REST API Reference for BatchCreatePartition Operation</seealso>
        public virtual BatchCreatePartitionResponse BatchCreatePartition(BatchCreatePartitionRequest request)
        {
            var marshaller = BatchCreatePartitionRequestMarshaller.Instance;
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
        public virtual Task<BatchCreatePartitionResponse> BatchCreatePartitionAsync(BatchCreatePartitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = BatchCreatePartitionRequestMarshaller.Instance;
            var unmarshaller = BatchCreatePartitionResponseUnmarshaller.Instance;

            return InvokeAsync<BatchCreatePartitionRequest,BatchCreatePartitionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  BatchDeleteConnection


        /// <summary>
        /// Deletes a list of connection definitions from the Data Catalog.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteConnection service method.</param>
        /// 
        /// <returns>The response from the BatchDeleteConnection service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/BatchDeleteConnection">REST API Reference for BatchDeleteConnection Operation</seealso>
        public virtual BatchDeleteConnectionResponse BatchDeleteConnection(BatchDeleteConnectionRequest request)
        {
            var marshaller = BatchDeleteConnectionRequestMarshaller.Instance;
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
        public virtual Task<BatchDeleteConnectionResponse> BatchDeleteConnectionAsync(BatchDeleteConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = BatchDeleteConnectionRequestMarshaller.Instance;
            var unmarshaller = BatchDeleteConnectionResponseUnmarshaller.Instance;

            return InvokeAsync<BatchDeleteConnectionRequest,BatchDeleteConnectionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  BatchDeletePartition


        /// <summary>
        /// Deletes one or more partitions in a batch operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDeletePartition service method.</param>
        /// 
        /// <returns>The response from the BatchDeletePartition service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/BatchDeletePartition">REST API Reference for BatchDeletePartition Operation</seealso>
        public virtual BatchDeletePartitionResponse BatchDeletePartition(BatchDeletePartitionRequest request)
        {
            var marshaller = BatchDeletePartitionRequestMarshaller.Instance;
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
        public virtual Task<BatchDeletePartitionResponse> BatchDeletePartitionAsync(BatchDeletePartitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = BatchDeletePartitionRequestMarshaller.Instance;
            var unmarshaller = BatchDeletePartitionResponseUnmarshaller.Instance;

            return InvokeAsync<BatchDeletePartitionRequest,BatchDeletePartitionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  BatchDeleteTable


        /// <summary>
        /// Deletes multiple tables at once.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteTable service method.</param>
        /// 
        /// <returns>The response from the BatchDeleteTable service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/BatchDeleteTable">REST API Reference for BatchDeleteTable Operation</seealso>
        public virtual BatchDeleteTableResponse BatchDeleteTable(BatchDeleteTableRequest request)
        {
            var marshaller = BatchDeleteTableRequestMarshaller.Instance;
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
        public virtual Task<BatchDeleteTableResponse> BatchDeleteTableAsync(BatchDeleteTableRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = BatchDeleteTableRequestMarshaller.Instance;
            var unmarshaller = BatchDeleteTableResponseUnmarshaller.Instance;

            return InvokeAsync<BatchDeleteTableRequest,BatchDeleteTableResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  BatchDeleteTableVersion


        /// <summary>
        /// Deletes a specified batch of versions of a table.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteTableVersion service method.</param>
        /// 
        /// <returns>The response from the BatchDeleteTableVersion service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/BatchDeleteTableVersion">REST API Reference for BatchDeleteTableVersion Operation</seealso>
        public virtual BatchDeleteTableVersionResponse BatchDeleteTableVersion(BatchDeleteTableVersionRequest request)
        {
            var marshaller = BatchDeleteTableVersionRequestMarshaller.Instance;
            var unmarshaller = BatchDeleteTableVersionResponseUnmarshaller.Instance;

            return Invoke<BatchDeleteTableVersionRequest,BatchDeleteTableVersionResponse>(request, marshaller, unmarshaller);
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
            var marshaller = BatchDeleteTableVersionRequestMarshaller.Instance;
            var unmarshaller = BatchDeleteTableVersionResponseUnmarshaller.Instance;

            return InvokeAsync<BatchDeleteTableVersionRequest,BatchDeleteTableVersionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  BatchGetPartition


        /// <summary>
        /// Retrieves partitions in a batch request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetPartition service method.</param>
        /// 
        /// <returns>The response from the BatchGetPartition service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/BatchGetPartition">REST API Reference for BatchGetPartition Operation</seealso>
        public virtual BatchGetPartitionResponse BatchGetPartition(BatchGetPartitionRequest request)
        {
            var marshaller = BatchGetPartitionRequestMarshaller.Instance;
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
        public virtual Task<BatchGetPartitionResponse> BatchGetPartitionAsync(BatchGetPartitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = BatchGetPartitionRequestMarshaller.Instance;
            var unmarshaller = BatchGetPartitionResponseUnmarshaller.Instance;

            return InvokeAsync<BatchGetPartitionRequest,BatchGetPartitionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  BatchStopJobRun


        /// <summary>
        /// Stops one or more job runs for a specified job definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchStopJobRun service method.</param>
        /// 
        /// <returns>The response from the BatchStopJobRun service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/BatchStopJobRun">REST API Reference for BatchStopJobRun Operation</seealso>
        public virtual BatchStopJobRunResponse BatchStopJobRun(BatchStopJobRunRequest request)
        {
            var marshaller = BatchStopJobRunRequestMarshaller.Instance;
            var unmarshaller = BatchStopJobRunResponseUnmarshaller.Instance;

            return Invoke<BatchStopJobRunRequest,BatchStopJobRunResponse>(request, marshaller, unmarshaller);
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
            var marshaller = BatchStopJobRunRequestMarshaller.Instance;
            var unmarshaller = BatchStopJobRunResponseUnmarshaller.Instance;

            return InvokeAsync<BatchStopJobRunRequest,BatchStopJobRunResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateClassifier


        /// <summary>
        /// Creates a classifier in the user's account. This may be a <code>GrokClassifier</code>,
        /// an <code>XMLClassifier</code>, or abbrev <code>JsonClassifier</code>, depending on
        /// which field of the request is present.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateClassifier service method.</param>
        /// 
        /// <returns>The response from the CreateClassifier service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.AlreadyExistsException">
        /// A resource to be created or added already exists.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CreateClassifier">REST API Reference for CreateClassifier Operation</seealso>
        public virtual CreateClassifierResponse CreateClassifier(CreateClassifierRequest request)
        {
            var marshaller = CreateClassifierRequestMarshaller.Instance;
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
        public virtual Task<CreateClassifierResponse> CreateClassifierAsync(CreateClassifierRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateClassifierRequestMarshaller.Instance;
            var unmarshaller = CreateClassifierResponseUnmarshaller.Instance;

            return InvokeAsync<CreateClassifierRequest,CreateClassifierResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateConnection


        /// <summary>
        /// Creates a connection definition in the Data Catalog.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConnection service method.</param>
        /// 
        /// <returns>The response from the CreateConnection service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.AlreadyExistsException">
        /// A resource to be created or added already exists.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.ResourceNumberLimitExceededException">
        /// A resource numerical limit was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CreateConnection">REST API Reference for CreateConnection Operation</seealso>
        public virtual CreateConnectionResponse CreateConnection(CreateConnectionRequest request)
        {
            var marshaller = CreateConnectionRequestMarshaller.Instance;
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
        public virtual Task<CreateConnectionResponse> CreateConnectionAsync(CreateConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateConnectionRequestMarshaller.Instance;
            var unmarshaller = CreateConnectionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateConnectionRequest,CreateConnectionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateCrawler


        /// <summary>
        /// Creates a new crawler with specified targets, role, configuration, and optional schedule.
        /// At least one crawl target must be specified, in either the <i>s3Targets</i> or the
        /// <i>jdbcTargets</i> field.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCrawler service method.</param>
        /// 
        /// <returns>The response from the CreateCrawler service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.AlreadyExistsException">
        /// A resource to be created or added already exists.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.ResourceNumberLimitExceededException">
        /// A resource numerical limit was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CreateCrawler">REST API Reference for CreateCrawler Operation</seealso>
        public virtual CreateCrawlerResponse CreateCrawler(CreateCrawlerRequest request)
        {
            var marshaller = CreateCrawlerRequestMarshaller.Instance;
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
        public virtual Task<CreateCrawlerResponse> CreateCrawlerAsync(CreateCrawlerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateCrawlerRequestMarshaller.Instance;
            var unmarshaller = CreateCrawlerResponseUnmarshaller.Instance;

            return InvokeAsync<CreateCrawlerRequest,CreateCrawlerResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateDatabase


        /// <summary>
        /// Creates a new database in a Data Catalog.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDatabase service method.</param>
        /// 
        /// <returns>The response from the CreateDatabase service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.AlreadyExistsException">
        /// A resource to be created or added already exists.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.ResourceNumberLimitExceededException">
        /// A resource numerical limit was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CreateDatabase">REST API Reference for CreateDatabase Operation</seealso>
        public virtual CreateDatabaseResponse CreateDatabase(CreateDatabaseRequest request)
        {
            var marshaller = CreateDatabaseRequestMarshaller.Instance;
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
        public virtual Task<CreateDatabaseResponse> CreateDatabaseAsync(CreateDatabaseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateDatabaseRequestMarshaller.Instance;
            var unmarshaller = CreateDatabaseResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDatabaseRequest,CreateDatabaseResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateDevEndpoint


        /// <summary>
        /// Creates a new DevEndpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDevEndpoint service method.</param>
        /// 
        /// <returns>The response from the CreateDevEndpoint service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.AccessDeniedException">
        /// Access to a resource was denied.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.AlreadyExistsException">
        /// A resource to be created or added already exists.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.IdempotentParameterMismatchException">
        /// The same unique identifier was associated with two different records.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.ResourceNumberLimitExceededException">
        /// A resource numerical limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.ValidationException">
        /// A value could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CreateDevEndpoint">REST API Reference for CreateDevEndpoint Operation</seealso>
        public virtual CreateDevEndpointResponse CreateDevEndpoint(CreateDevEndpointRequest request)
        {
            var marshaller = CreateDevEndpointRequestMarshaller.Instance;
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
        public virtual Task<CreateDevEndpointResponse> CreateDevEndpointAsync(CreateDevEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateDevEndpointRequestMarshaller.Instance;
            var unmarshaller = CreateDevEndpointResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDevEndpointRequest,CreateDevEndpointResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateJob


        /// <summary>
        /// Creates a new job definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateJob service method.</param>
        /// 
        /// <returns>The response from the CreateJob service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.AlreadyExistsException">
        /// A resource to be created or added already exists.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.ConcurrentModificationException">
        /// Two processes are trying to modify a resource simultaneously.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.IdempotentParameterMismatchException">
        /// The same unique identifier was associated with two different records.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.ResourceNumberLimitExceededException">
        /// A resource numerical limit was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CreateJob">REST API Reference for CreateJob Operation</seealso>
        public virtual CreateJobResponse CreateJob(CreateJobRequest request)
        {
            var marshaller = CreateJobRequestMarshaller.Instance;
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
        public virtual Task<CreateJobResponse> CreateJobAsync(CreateJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateJobRequestMarshaller.Instance;
            var unmarshaller = CreateJobResponseUnmarshaller.Instance;

            return InvokeAsync<CreateJobRequest,CreateJobResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreatePartition


        /// <summary>
        /// Creates a new partition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePartition service method.</param>
        /// 
        /// <returns>The response from the CreatePartition service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.AlreadyExistsException">
        /// A resource to be created or added already exists.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.ResourceNumberLimitExceededException">
        /// A resource numerical limit was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CreatePartition">REST API Reference for CreatePartition Operation</seealso>
        public virtual CreatePartitionResponse CreatePartition(CreatePartitionRequest request)
        {
            var marshaller = CreatePartitionRequestMarshaller.Instance;
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
        public virtual Task<CreatePartitionResponse> CreatePartitionAsync(CreatePartitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreatePartitionRequestMarshaller.Instance;
            var unmarshaller = CreatePartitionResponseUnmarshaller.Instance;

            return InvokeAsync<CreatePartitionRequest,CreatePartitionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateScript


        /// <summary>
        /// Transforms a directed acyclic graph (DAG) into code.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateScript service method.</param>
        /// 
        /// <returns>The response from the CreateScript service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CreateScript">REST API Reference for CreateScript Operation</seealso>
        public virtual CreateScriptResponse CreateScript(CreateScriptRequest request)
        {
            var marshaller = CreateScriptRequestMarshaller.Instance;
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
        public virtual Task<CreateScriptResponse> CreateScriptAsync(CreateScriptRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateScriptRequestMarshaller.Instance;
            var unmarshaller = CreateScriptResponseUnmarshaller.Instance;

            return InvokeAsync<CreateScriptRequest,CreateScriptResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateTable


        /// <summary>
        /// Creates a new table definition in the Data Catalog.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTable service method.</param>
        /// 
        /// <returns>The response from the CreateTable service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.AlreadyExistsException">
        /// A resource to be created or added already exists.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.ResourceNumberLimitExceededException">
        /// A resource numerical limit was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CreateTable">REST API Reference for CreateTable Operation</seealso>
        public virtual CreateTableResponse CreateTable(CreateTableRequest request)
        {
            var marshaller = CreateTableRequestMarshaller.Instance;
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
        public virtual Task<CreateTableResponse> CreateTableAsync(CreateTableRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateTableRequestMarshaller.Instance;
            var unmarshaller = CreateTableResponseUnmarshaller.Instance;

            return InvokeAsync<CreateTableRequest,CreateTableResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateTrigger


        /// <summary>
        /// Creates a new trigger.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTrigger service method.</param>
        /// 
        /// <returns>The response from the CreateTrigger service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.AlreadyExistsException">
        /// A resource to be created or added already exists.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.ConcurrentModificationException">
        /// Two processes are trying to modify a resource simultaneously.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.IdempotentParameterMismatchException">
        /// The same unique identifier was associated with two different records.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.ResourceNumberLimitExceededException">
        /// A resource numerical limit was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CreateTrigger">REST API Reference for CreateTrigger Operation</seealso>
        public virtual CreateTriggerResponse CreateTrigger(CreateTriggerRequest request)
        {
            var marshaller = CreateTriggerRequestMarshaller.Instance;
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
        public virtual Task<CreateTriggerResponse> CreateTriggerAsync(CreateTriggerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateTriggerRequestMarshaller.Instance;
            var unmarshaller = CreateTriggerResponseUnmarshaller.Instance;

            return InvokeAsync<CreateTriggerRequest,CreateTriggerResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateUserDefinedFunction


        /// <summary>
        /// Creates a new function definition in the Data Catalog.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateUserDefinedFunction service method.</param>
        /// 
        /// <returns>The response from the CreateUserDefinedFunction service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.AlreadyExistsException">
        /// A resource to be created or added already exists.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.ResourceNumberLimitExceededException">
        /// A resource numerical limit was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CreateUserDefinedFunction">REST API Reference for CreateUserDefinedFunction Operation</seealso>
        public virtual CreateUserDefinedFunctionResponse CreateUserDefinedFunction(CreateUserDefinedFunctionRequest request)
        {
            var marshaller = CreateUserDefinedFunctionRequestMarshaller.Instance;
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
        public virtual Task<CreateUserDefinedFunctionResponse> CreateUserDefinedFunctionAsync(CreateUserDefinedFunctionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateUserDefinedFunctionRequestMarshaller.Instance;
            var unmarshaller = CreateUserDefinedFunctionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateUserDefinedFunctionRequest,CreateUserDefinedFunctionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteClassifier


        /// <summary>
        /// Removes a classifier from the Data Catalog.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteClassifier service method.</param>
        /// 
        /// <returns>The response from the DeleteClassifier service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteClassifier">REST API Reference for DeleteClassifier Operation</seealso>
        public virtual DeleteClassifierResponse DeleteClassifier(DeleteClassifierRequest request)
        {
            var marshaller = DeleteClassifierRequestMarshaller.Instance;
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
        public virtual Task<DeleteClassifierResponse> DeleteClassifierAsync(DeleteClassifierRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteClassifierRequestMarshaller.Instance;
            var unmarshaller = DeleteClassifierResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteClassifierRequest,DeleteClassifierResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteConnection


        /// <summary>
        /// Deletes a connection from the Data Catalog.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConnection service method.</param>
        /// 
        /// <returns>The response from the DeleteConnection service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteConnection">REST API Reference for DeleteConnection Operation</seealso>
        public virtual DeleteConnectionResponse DeleteConnection(DeleteConnectionRequest request)
        {
            var marshaller = DeleteConnectionRequestMarshaller.Instance;
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
        public virtual Task<DeleteConnectionResponse> DeleteConnectionAsync(DeleteConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteConnectionRequestMarshaller.Instance;
            var unmarshaller = DeleteConnectionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteConnectionRequest,DeleteConnectionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteCrawler


        /// <summary>
        /// Removes a specified crawler from the Data Catalog, unless the crawler state is <code>RUNNING</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCrawler service method.</param>
        /// 
        /// <returns>The response from the DeleteCrawler service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.CrawlerRunningException">
        /// The operation cannot be performed because the crawler is already running.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.SchedulerTransitioningException">
        /// The specified scheduler is transitioning.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteCrawler">REST API Reference for DeleteCrawler Operation</seealso>
        public virtual DeleteCrawlerResponse DeleteCrawler(DeleteCrawlerRequest request)
        {
            var marshaller = DeleteCrawlerRequestMarshaller.Instance;
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
        public virtual Task<DeleteCrawlerResponse> DeleteCrawlerAsync(DeleteCrawlerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteCrawlerRequestMarshaller.Instance;
            var unmarshaller = DeleteCrawlerResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteCrawlerRequest,DeleteCrawlerResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteDatabase


        /// <summary>
        /// Removes a specified Database from a Data Catalog.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDatabase service method.</param>
        /// 
        /// <returns>The response from the DeleteDatabase service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteDatabase">REST API Reference for DeleteDatabase Operation</seealso>
        public virtual DeleteDatabaseResponse DeleteDatabase(DeleteDatabaseRequest request)
        {
            var marshaller = DeleteDatabaseRequestMarshaller.Instance;
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
        public virtual Task<DeleteDatabaseResponse> DeleteDatabaseAsync(DeleteDatabaseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteDatabaseRequestMarshaller.Instance;
            var unmarshaller = DeleteDatabaseResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDatabaseRequest,DeleteDatabaseResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteDevEndpoint


        /// <summary>
        /// Deletes a specified DevEndpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDevEndpoint service method.</param>
        /// 
        /// <returns>The response from the DeleteDevEndpoint service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteDevEndpoint">REST API Reference for DeleteDevEndpoint Operation</seealso>
        public virtual DeleteDevEndpointResponse DeleteDevEndpoint(DeleteDevEndpointRequest request)
        {
            var marshaller = DeleteDevEndpointRequestMarshaller.Instance;
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
        public virtual Task<DeleteDevEndpointResponse> DeleteDevEndpointAsync(DeleteDevEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteDevEndpointRequestMarshaller.Instance;
            var unmarshaller = DeleteDevEndpointResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDevEndpointRequest,DeleteDevEndpointResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteJob


        /// <summary>
        /// Deletes a specified job definition. If the job definition is not found, no exception
        /// is thrown.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteJob service method.</param>
        /// 
        /// <returns>The response from the DeleteJob service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteJob">REST API Reference for DeleteJob Operation</seealso>
        public virtual DeleteJobResponse DeleteJob(DeleteJobRequest request)
        {
            var marshaller = DeleteJobRequestMarshaller.Instance;
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
        public virtual Task<DeleteJobResponse> DeleteJobAsync(DeleteJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteJobRequestMarshaller.Instance;
            var unmarshaller = DeleteJobResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteJobRequest,DeleteJobResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeletePartition


        /// <summary>
        /// Deletes a specified partition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePartition service method.</param>
        /// 
        /// <returns>The response from the DeletePartition service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeletePartition">REST API Reference for DeletePartition Operation</seealso>
        public virtual DeletePartitionResponse DeletePartition(DeletePartitionRequest request)
        {
            var marshaller = DeletePartitionRequestMarshaller.Instance;
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
        public virtual Task<DeletePartitionResponse> DeletePartitionAsync(DeletePartitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeletePartitionRequestMarshaller.Instance;
            var unmarshaller = DeletePartitionResponseUnmarshaller.Instance;

            return InvokeAsync<DeletePartitionRequest,DeletePartitionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteTable


        /// <summary>
        /// Removes a table definition from the Data Catalog.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTable service method.</param>
        /// 
        /// <returns>The response from the DeleteTable service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteTable">REST API Reference for DeleteTable Operation</seealso>
        public virtual DeleteTableResponse DeleteTable(DeleteTableRequest request)
        {
            var marshaller = DeleteTableRequestMarshaller.Instance;
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
        public virtual Task<DeleteTableResponse> DeleteTableAsync(DeleteTableRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteTableRequestMarshaller.Instance;
            var unmarshaller = DeleteTableResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteTableRequest,DeleteTableResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteTableVersion


        /// <summary>
        /// Deletes a specified version of a table.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTableVersion service method.</param>
        /// 
        /// <returns>The response from the DeleteTableVersion service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteTableVersion">REST API Reference for DeleteTableVersion Operation</seealso>
        public virtual DeleteTableVersionResponse DeleteTableVersion(DeleteTableVersionRequest request)
        {
            var marshaller = DeleteTableVersionRequestMarshaller.Instance;
            var unmarshaller = DeleteTableVersionResponseUnmarshaller.Instance;

            return Invoke<DeleteTableVersionRequest,DeleteTableVersionResponse>(request, marshaller, unmarshaller);
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
            var marshaller = DeleteTableVersionRequestMarshaller.Instance;
            var unmarshaller = DeleteTableVersionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteTableVersionRequest,DeleteTableVersionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteTrigger


        /// <summary>
        /// Deletes a specified trigger. If the trigger is not found, no exception is thrown.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTrigger service method.</param>
        /// 
        /// <returns>The response from the DeleteTrigger service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.ConcurrentModificationException">
        /// Two processes are trying to modify a resource simultaneously.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteTrigger">REST API Reference for DeleteTrigger Operation</seealso>
        public virtual DeleteTriggerResponse DeleteTrigger(DeleteTriggerRequest request)
        {
            var marshaller = DeleteTriggerRequestMarshaller.Instance;
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
        public virtual Task<DeleteTriggerResponse> DeleteTriggerAsync(DeleteTriggerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteTriggerRequestMarshaller.Instance;
            var unmarshaller = DeleteTriggerResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteTriggerRequest,DeleteTriggerResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteUserDefinedFunction


        /// <summary>
        /// Deletes an existing function definition from the Data Catalog.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteUserDefinedFunction service method.</param>
        /// 
        /// <returns>The response from the DeleteUserDefinedFunction service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteUserDefinedFunction">REST API Reference for DeleteUserDefinedFunction Operation</seealso>
        public virtual DeleteUserDefinedFunctionResponse DeleteUserDefinedFunction(DeleteUserDefinedFunctionRequest request)
        {
            var marshaller = DeleteUserDefinedFunctionRequestMarshaller.Instance;
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
        public virtual Task<DeleteUserDefinedFunctionResponse> DeleteUserDefinedFunctionAsync(DeleteUserDefinedFunctionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteUserDefinedFunctionRequestMarshaller.Instance;
            var unmarshaller = DeleteUserDefinedFunctionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteUserDefinedFunctionRequest,DeleteUserDefinedFunctionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetCatalogImportStatus


        /// <summary>
        /// Retrieves the status of a migration operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCatalogImportStatus service method.</param>
        /// 
        /// <returns>The response from the GetCatalogImportStatus service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetCatalogImportStatus">REST API Reference for GetCatalogImportStatus Operation</seealso>
        public virtual GetCatalogImportStatusResponse GetCatalogImportStatus(GetCatalogImportStatusRequest request)
        {
            var marshaller = GetCatalogImportStatusRequestMarshaller.Instance;
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
        public virtual Task<GetCatalogImportStatusResponse> GetCatalogImportStatusAsync(GetCatalogImportStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetCatalogImportStatusRequestMarshaller.Instance;
            var unmarshaller = GetCatalogImportStatusResponseUnmarshaller.Instance;

            return InvokeAsync<GetCatalogImportStatusRequest,GetCatalogImportStatusResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetClassifier


        /// <summary>
        /// Retrieve a classifier by name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetClassifier service method.</param>
        /// 
        /// <returns>The response from the GetClassifier service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetClassifier">REST API Reference for GetClassifier Operation</seealso>
        public virtual GetClassifierResponse GetClassifier(GetClassifierRequest request)
        {
            var marshaller = GetClassifierRequestMarshaller.Instance;
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
        public virtual Task<GetClassifierResponse> GetClassifierAsync(GetClassifierRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetClassifierRequestMarshaller.Instance;
            var unmarshaller = GetClassifierResponseUnmarshaller.Instance;

            return InvokeAsync<GetClassifierRequest,GetClassifierResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetClassifiers


        /// <summary>
        /// Lists all classifier objects in the Data Catalog.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetClassifiers service method.</param>
        /// 
        /// <returns>The response from the GetClassifiers service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetClassifiers">REST API Reference for GetClassifiers Operation</seealso>
        public virtual GetClassifiersResponse GetClassifiers(GetClassifiersRequest request)
        {
            var marshaller = GetClassifiersRequestMarshaller.Instance;
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
        public virtual Task<GetClassifiersResponse> GetClassifiersAsync(GetClassifiersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetClassifiersRequestMarshaller.Instance;
            var unmarshaller = GetClassifiersResponseUnmarshaller.Instance;

            return InvokeAsync<GetClassifiersRequest,GetClassifiersResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetConnection


        /// <summary>
        /// Retrieves a connection definition from the Data Catalog.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConnection service method.</param>
        /// 
        /// <returns>The response from the GetConnection service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetConnection">REST API Reference for GetConnection Operation</seealso>
        public virtual GetConnectionResponse GetConnection(GetConnectionRequest request)
        {
            var marshaller = GetConnectionRequestMarshaller.Instance;
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
        public virtual Task<GetConnectionResponse> GetConnectionAsync(GetConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetConnectionRequestMarshaller.Instance;
            var unmarshaller = GetConnectionResponseUnmarshaller.Instance;

            return InvokeAsync<GetConnectionRequest,GetConnectionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetConnections


        /// <summary>
        /// Retrieves a list of connection definitions from the Data Catalog.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConnections service method.</param>
        /// 
        /// <returns>The response from the GetConnections service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetConnections">REST API Reference for GetConnections Operation</seealso>
        public virtual GetConnectionsResponse GetConnections(GetConnectionsRequest request)
        {
            var marshaller = GetConnectionsRequestMarshaller.Instance;
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
        public virtual Task<GetConnectionsResponse> GetConnectionsAsync(GetConnectionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetConnectionsRequestMarshaller.Instance;
            var unmarshaller = GetConnectionsResponseUnmarshaller.Instance;

            return InvokeAsync<GetConnectionsRequest,GetConnectionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetCrawler


        /// <summary>
        /// Retrieves metadata for a specified crawler.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCrawler service method.</param>
        /// 
        /// <returns>The response from the GetCrawler service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetCrawler">REST API Reference for GetCrawler Operation</seealso>
        public virtual GetCrawlerResponse GetCrawler(GetCrawlerRequest request)
        {
            var marshaller = GetCrawlerRequestMarshaller.Instance;
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
        public virtual Task<GetCrawlerResponse> GetCrawlerAsync(GetCrawlerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetCrawlerRequestMarshaller.Instance;
            var unmarshaller = GetCrawlerResponseUnmarshaller.Instance;

            return InvokeAsync<GetCrawlerRequest,GetCrawlerResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetCrawlerMetrics


        /// <summary>
        /// Retrieves metrics about specified crawlers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCrawlerMetrics service method.</param>
        /// 
        /// <returns>The response from the GetCrawlerMetrics service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetCrawlerMetrics">REST API Reference for GetCrawlerMetrics Operation</seealso>
        public virtual GetCrawlerMetricsResponse GetCrawlerMetrics(GetCrawlerMetricsRequest request)
        {
            var marshaller = GetCrawlerMetricsRequestMarshaller.Instance;
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
        public virtual Task<GetCrawlerMetricsResponse> GetCrawlerMetricsAsync(GetCrawlerMetricsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetCrawlerMetricsRequestMarshaller.Instance;
            var unmarshaller = GetCrawlerMetricsResponseUnmarshaller.Instance;

            return InvokeAsync<GetCrawlerMetricsRequest,GetCrawlerMetricsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetCrawlers


        /// <summary>
        /// Retrieves metadata for all crawlers defined in the customer account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCrawlers service method.</param>
        /// 
        /// <returns>The response from the GetCrawlers service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetCrawlers">REST API Reference for GetCrawlers Operation</seealso>
        public virtual GetCrawlersResponse GetCrawlers(GetCrawlersRequest request)
        {
            var marshaller = GetCrawlersRequestMarshaller.Instance;
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
        public virtual Task<GetCrawlersResponse> GetCrawlersAsync(GetCrawlersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetCrawlersRequestMarshaller.Instance;
            var unmarshaller = GetCrawlersResponseUnmarshaller.Instance;

            return InvokeAsync<GetCrawlersRequest,GetCrawlersResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetDatabase


        /// <summary>
        /// Retrieves the definition of a specified database.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDatabase service method.</param>
        /// 
        /// <returns>The response from the GetDatabase service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetDatabase">REST API Reference for GetDatabase Operation</seealso>
        public virtual GetDatabaseResponse GetDatabase(GetDatabaseRequest request)
        {
            var marshaller = GetDatabaseRequestMarshaller.Instance;
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
        public virtual Task<GetDatabaseResponse> GetDatabaseAsync(GetDatabaseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetDatabaseRequestMarshaller.Instance;
            var unmarshaller = GetDatabaseResponseUnmarshaller.Instance;

            return InvokeAsync<GetDatabaseRequest,GetDatabaseResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetDatabases


        /// <summary>
        /// Retrieves all Databases defined in a given Data Catalog.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDatabases service method.</param>
        /// 
        /// <returns>The response from the GetDatabases service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetDatabases">REST API Reference for GetDatabases Operation</seealso>
        public virtual GetDatabasesResponse GetDatabases(GetDatabasesRequest request)
        {
            var marshaller = GetDatabasesRequestMarshaller.Instance;
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
        public virtual Task<GetDatabasesResponse> GetDatabasesAsync(GetDatabasesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetDatabasesRequestMarshaller.Instance;
            var unmarshaller = GetDatabasesResponseUnmarshaller.Instance;

            return InvokeAsync<GetDatabasesRequest,GetDatabasesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetDataflowGraph


        /// <summary>
        /// Transforms a Python script into a directed acyclic graph (DAG).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDataflowGraph service method.</param>
        /// 
        /// <returns>The response from the GetDataflowGraph service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetDataflowGraph">REST API Reference for GetDataflowGraph Operation</seealso>
        public virtual GetDataflowGraphResponse GetDataflowGraph(GetDataflowGraphRequest request)
        {
            var marshaller = GetDataflowGraphRequestMarshaller.Instance;
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
        public virtual Task<GetDataflowGraphResponse> GetDataflowGraphAsync(GetDataflowGraphRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetDataflowGraphRequestMarshaller.Instance;
            var unmarshaller = GetDataflowGraphResponseUnmarshaller.Instance;

            return InvokeAsync<GetDataflowGraphRequest,GetDataflowGraphResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetDevEndpoint


        /// <summary>
        /// Retrieves information about a specified DevEndpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDevEndpoint service method.</param>
        /// 
        /// <returns>The response from the GetDevEndpoint service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetDevEndpoint">REST API Reference for GetDevEndpoint Operation</seealso>
        public virtual GetDevEndpointResponse GetDevEndpoint(GetDevEndpointRequest request)
        {
            var marshaller = GetDevEndpointRequestMarshaller.Instance;
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
        public virtual Task<GetDevEndpointResponse> GetDevEndpointAsync(GetDevEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetDevEndpointRequestMarshaller.Instance;
            var unmarshaller = GetDevEndpointResponseUnmarshaller.Instance;

            return InvokeAsync<GetDevEndpointRequest,GetDevEndpointResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetDevEndpoints


        /// <summary>
        /// Retrieves all the DevEndpoints in this AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDevEndpoints service method.</param>
        /// 
        /// <returns>The response from the GetDevEndpoints service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetDevEndpoints">REST API Reference for GetDevEndpoints Operation</seealso>
        public virtual GetDevEndpointsResponse GetDevEndpoints(GetDevEndpointsRequest request)
        {
            var marshaller = GetDevEndpointsRequestMarshaller.Instance;
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
        public virtual Task<GetDevEndpointsResponse> GetDevEndpointsAsync(GetDevEndpointsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetDevEndpointsRequestMarshaller.Instance;
            var unmarshaller = GetDevEndpointsResponseUnmarshaller.Instance;

            return InvokeAsync<GetDevEndpointsRequest,GetDevEndpointsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetJob


        /// <summary>
        /// Retrieves an existing job definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetJob service method.</param>
        /// 
        /// <returns>The response from the GetJob service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetJob">REST API Reference for GetJob Operation</seealso>
        public virtual GetJobResponse GetJob(GetJobRequest request)
        {
            var marshaller = GetJobRequestMarshaller.Instance;
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
        public virtual Task<GetJobResponse> GetJobAsync(GetJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetJobRequestMarshaller.Instance;
            var unmarshaller = GetJobResponseUnmarshaller.Instance;

            return InvokeAsync<GetJobRequest,GetJobResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetJobRun


        /// <summary>
        /// Retrieves the metadata for a given job run.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetJobRun service method.</param>
        /// 
        /// <returns>The response from the GetJobRun service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetJobRun">REST API Reference for GetJobRun Operation</seealso>
        public virtual GetJobRunResponse GetJobRun(GetJobRunRequest request)
        {
            var marshaller = GetJobRunRequestMarshaller.Instance;
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
        public virtual Task<GetJobRunResponse> GetJobRunAsync(GetJobRunRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetJobRunRequestMarshaller.Instance;
            var unmarshaller = GetJobRunResponseUnmarshaller.Instance;

            return InvokeAsync<GetJobRunRequest,GetJobRunResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetJobRuns


        /// <summary>
        /// Retrieves metadata for all runs of a given job definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetJobRuns service method.</param>
        /// 
        /// <returns>The response from the GetJobRuns service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetJobRuns">REST API Reference for GetJobRuns Operation</seealso>
        public virtual GetJobRunsResponse GetJobRuns(GetJobRunsRequest request)
        {
            var marshaller = GetJobRunsRequestMarshaller.Instance;
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
        public virtual Task<GetJobRunsResponse> GetJobRunsAsync(GetJobRunsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetJobRunsRequestMarshaller.Instance;
            var unmarshaller = GetJobRunsResponseUnmarshaller.Instance;

            return InvokeAsync<GetJobRunsRequest,GetJobRunsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetJobs


        /// <summary>
        /// Retrieves all current job definitions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetJobs service method.</param>
        /// 
        /// <returns>The response from the GetJobs service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetJobs">REST API Reference for GetJobs Operation</seealso>
        public virtual GetJobsResponse GetJobs(GetJobsRequest request)
        {
            var marshaller = GetJobsRequestMarshaller.Instance;
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
        public virtual Task<GetJobsResponse> GetJobsAsync(GetJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetJobsRequestMarshaller.Instance;
            var unmarshaller = GetJobsResponseUnmarshaller.Instance;

            return InvokeAsync<GetJobsRequest,GetJobsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetMapping


        /// <summary>
        /// Creates mappings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMapping service method.</param>
        /// 
        /// <returns>The response from the GetMapping service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetMapping">REST API Reference for GetMapping Operation</seealso>
        public virtual GetMappingResponse GetMapping(GetMappingRequest request)
        {
            var marshaller = GetMappingRequestMarshaller.Instance;
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
        public virtual Task<GetMappingResponse> GetMappingAsync(GetMappingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetMappingRequestMarshaller.Instance;
            var unmarshaller = GetMappingResponseUnmarshaller.Instance;

            return InvokeAsync<GetMappingRequest,GetMappingResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetPartition


        /// <summary>
        /// Retrieves information about a specified partition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPartition service method.</param>
        /// 
        /// <returns>The response from the GetPartition service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetPartition">REST API Reference for GetPartition Operation</seealso>
        public virtual GetPartitionResponse GetPartition(GetPartitionRequest request)
        {
            var marshaller = GetPartitionRequestMarshaller.Instance;
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
        public virtual Task<GetPartitionResponse> GetPartitionAsync(GetPartitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetPartitionRequestMarshaller.Instance;
            var unmarshaller = GetPartitionResponseUnmarshaller.Instance;

            return InvokeAsync<GetPartitionRequest,GetPartitionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetPartitions


        /// <summary>
        /// Retrieves information about the partitions in a table.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPartitions service method.</param>
        /// 
        /// <returns>The response from the GetPartitions service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetPartitions">REST API Reference for GetPartitions Operation</seealso>
        public virtual GetPartitionsResponse GetPartitions(GetPartitionsRequest request)
        {
            var marshaller = GetPartitionsRequestMarshaller.Instance;
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
        public virtual Task<GetPartitionsResponse> GetPartitionsAsync(GetPartitionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetPartitionsRequestMarshaller.Instance;
            var unmarshaller = GetPartitionsResponseUnmarshaller.Instance;

            return InvokeAsync<GetPartitionsRequest,GetPartitionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetPlan


        /// <summary>
        /// Gets code to perform a specified mapping.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPlan service method.</param>
        /// 
        /// <returns>The response from the GetPlan service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetPlan">REST API Reference for GetPlan Operation</seealso>
        public virtual GetPlanResponse GetPlan(GetPlanRequest request)
        {
            var marshaller = GetPlanRequestMarshaller.Instance;
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
        public virtual Task<GetPlanResponse> GetPlanAsync(GetPlanRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetPlanRequestMarshaller.Instance;
            var unmarshaller = GetPlanResponseUnmarshaller.Instance;

            return InvokeAsync<GetPlanRequest,GetPlanResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetTable


        /// <summary>
        /// Retrieves the <code>Table</code> definition in a Data Catalog for a specified table.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTable service method.</param>
        /// 
        /// <returns>The response from the GetTable service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetTable">REST API Reference for GetTable Operation</seealso>
        public virtual GetTableResponse GetTable(GetTableRequest request)
        {
            var marshaller = GetTableRequestMarshaller.Instance;
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
        public virtual Task<GetTableResponse> GetTableAsync(GetTableRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetTableRequestMarshaller.Instance;
            var unmarshaller = GetTableResponseUnmarshaller.Instance;

            return InvokeAsync<GetTableRequest,GetTableResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetTables


        /// <summary>
        /// Retrieves the definitions of some or all of the tables in a given <code>Database</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTables service method.</param>
        /// 
        /// <returns>The response from the GetTables service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetTables">REST API Reference for GetTables Operation</seealso>
        public virtual GetTablesResponse GetTables(GetTablesRequest request)
        {
            var marshaller = GetTablesRequestMarshaller.Instance;
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
        public virtual Task<GetTablesResponse> GetTablesAsync(GetTablesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetTablesRequestMarshaller.Instance;
            var unmarshaller = GetTablesResponseUnmarshaller.Instance;

            return InvokeAsync<GetTablesRequest,GetTablesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetTableVersion


        /// <summary>
        /// Retrieves a specified version of a table.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTableVersion service method.</param>
        /// 
        /// <returns>The response from the GetTableVersion service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetTableVersion">REST API Reference for GetTableVersion Operation</seealso>
        public virtual GetTableVersionResponse GetTableVersion(GetTableVersionRequest request)
        {
            var marshaller = GetTableVersionRequestMarshaller.Instance;
            var unmarshaller = GetTableVersionResponseUnmarshaller.Instance;

            return Invoke<GetTableVersionRequest,GetTableVersionResponse>(request, marshaller, unmarshaller);
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
            var marshaller = GetTableVersionRequestMarshaller.Instance;
            var unmarshaller = GetTableVersionResponseUnmarshaller.Instance;

            return InvokeAsync<GetTableVersionRequest,GetTableVersionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetTableVersions


        /// <summary>
        /// Retrieves a list of strings that identify available versions of a specified table.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTableVersions service method.</param>
        /// 
        /// <returns>The response from the GetTableVersions service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetTableVersions">REST API Reference for GetTableVersions Operation</seealso>
        public virtual GetTableVersionsResponse GetTableVersions(GetTableVersionsRequest request)
        {
            var marshaller = GetTableVersionsRequestMarshaller.Instance;
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
        public virtual Task<GetTableVersionsResponse> GetTableVersionsAsync(GetTableVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetTableVersionsRequestMarshaller.Instance;
            var unmarshaller = GetTableVersionsResponseUnmarshaller.Instance;

            return InvokeAsync<GetTableVersionsRequest,GetTableVersionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetTrigger


        /// <summary>
        /// Retrieves the definition of a trigger.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTrigger service method.</param>
        /// 
        /// <returns>The response from the GetTrigger service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetTrigger">REST API Reference for GetTrigger Operation</seealso>
        public virtual GetTriggerResponse GetTrigger(GetTriggerRequest request)
        {
            var marshaller = GetTriggerRequestMarshaller.Instance;
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
        public virtual Task<GetTriggerResponse> GetTriggerAsync(GetTriggerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetTriggerRequestMarshaller.Instance;
            var unmarshaller = GetTriggerResponseUnmarshaller.Instance;

            return InvokeAsync<GetTriggerRequest,GetTriggerResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetTriggers


        /// <summary>
        /// Gets all the triggers associated with a job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTriggers service method.</param>
        /// 
        /// <returns>The response from the GetTriggers service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetTriggers">REST API Reference for GetTriggers Operation</seealso>
        public virtual GetTriggersResponse GetTriggers(GetTriggersRequest request)
        {
            var marshaller = GetTriggersRequestMarshaller.Instance;
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
        public virtual Task<GetTriggersResponse> GetTriggersAsync(GetTriggersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetTriggersRequestMarshaller.Instance;
            var unmarshaller = GetTriggersResponseUnmarshaller.Instance;

            return InvokeAsync<GetTriggersRequest,GetTriggersResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetUserDefinedFunction


        /// <summary>
        /// Retrieves a specified function definition from the Data Catalog.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUserDefinedFunction service method.</param>
        /// 
        /// <returns>The response from the GetUserDefinedFunction service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetUserDefinedFunction">REST API Reference for GetUserDefinedFunction Operation</seealso>
        public virtual GetUserDefinedFunctionResponse GetUserDefinedFunction(GetUserDefinedFunctionRequest request)
        {
            var marshaller = GetUserDefinedFunctionRequestMarshaller.Instance;
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
        public virtual Task<GetUserDefinedFunctionResponse> GetUserDefinedFunctionAsync(GetUserDefinedFunctionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetUserDefinedFunctionRequestMarshaller.Instance;
            var unmarshaller = GetUserDefinedFunctionResponseUnmarshaller.Instance;

            return InvokeAsync<GetUserDefinedFunctionRequest,GetUserDefinedFunctionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetUserDefinedFunctions


        /// <summary>
        /// Retrieves a multiple function definitions from the Data Catalog.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUserDefinedFunctions service method.</param>
        /// 
        /// <returns>The response from the GetUserDefinedFunctions service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetUserDefinedFunctions">REST API Reference for GetUserDefinedFunctions Operation</seealso>
        public virtual GetUserDefinedFunctionsResponse GetUserDefinedFunctions(GetUserDefinedFunctionsRequest request)
        {
            var marshaller = GetUserDefinedFunctionsRequestMarshaller.Instance;
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
        public virtual Task<GetUserDefinedFunctionsResponse> GetUserDefinedFunctionsAsync(GetUserDefinedFunctionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetUserDefinedFunctionsRequestMarshaller.Instance;
            var unmarshaller = GetUserDefinedFunctionsResponseUnmarshaller.Instance;

            return InvokeAsync<GetUserDefinedFunctionsRequest,GetUserDefinedFunctionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ImportCatalogToGlue


        /// <summary>
        /// Imports an existing Athena Data Catalog to AWS Glue
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportCatalogToGlue service method.</param>
        /// 
        /// <returns>The response from the ImportCatalogToGlue service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/ImportCatalogToGlue">REST API Reference for ImportCatalogToGlue Operation</seealso>
        public virtual ImportCatalogToGlueResponse ImportCatalogToGlue(ImportCatalogToGlueRequest request)
        {
            var marshaller = ImportCatalogToGlueRequestMarshaller.Instance;
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
        public virtual Task<ImportCatalogToGlueResponse> ImportCatalogToGlueAsync(ImportCatalogToGlueRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ImportCatalogToGlueRequestMarshaller.Instance;
            var unmarshaller = ImportCatalogToGlueResponseUnmarshaller.Instance;

            return InvokeAsync<ImportCatalogToGlueRequest,ImportCatalogToGlueResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ResetJobBookmark


        /// <summary>
        /// Resets a bookmark entry.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResetJobBookmark service method.</param>
        /// 
        /// <returns>The response from the ResetJobBookmark service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/ResetJobBookmark">REST API Reference for ResetJobBookmark Operation</seealso>
        public virtual ResetJobBookmarkResponse ResetJobBookmark(ResetJobBookmarkRequest request)
        {
            var marshaller = ResetJobBookmarkRequestMarshaller.Instance;
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
        public virtual Task<ResetJobBookmarkResponse> ResetJobBookmarkAsync(ResetJobBookmarkRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ResetJobBookmarkRequestMarshaller.Instance;
            var unmarshaller = ResetJobBookmarkResponseUnmarshaller.Instance;

            return InvokeAsync<ResetJobBookmarkRequest,ResetJobBookmarkResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  StartCrawler


        /// <summary>
        /// Starts a crawl using the specified crawler, regardless of what is scheduled. If the
        /// crawler is already running, does nothing.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartCrawler service method.</param>
        /// 
        /// <returns>The response from the StartCrawler service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.CrawlerRunningException">
        /// The operation cannot be performed because the crawler is already running.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/StartCrawler">REST API Reference for StartCrawler Operation</seealso>
        public virtual StartCrawlerResponse StartCrawler(StartCrawlerRequest request)
        {
            var marshaller = StartCrawlerRequestMarshaller.Instance;
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
        public virtual Task<StartCrawlerResponse> StartCrawlerAsync(StartCrawlerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = StartCrawlerRequestMarshaller.Instance;
            var unmarshaller = StartCrawlerResponseUnmarshaller.Instance;

            return InvokeAsync<StartCrawlerRequest,StartCrawlerResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  StartCrawlerSchedule


        /// <summary>
        /// Changes the schedule state of the specified crawler to <code>SCHEDULED</code>, unless
        /// the crawler is already running or the schedule state is already <code>SCHEDULED</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartCrawlerSchedule service method.</param>
        /// 
        /// <returns>The response from the StartCrawlerSchedule service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.NoScheduleException">
        /// There is no applicable schedule.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.SchedulerRunningException">
        /// The specified scheduler is already running.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.SchedulerTransitioningException">
        /// The specified scheduler is transitioning.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/StartCrawlerSchedule">REST API Reference for StartCrawlerSchedule Operation</seealso>
        public virtual StartCrawlerScheduleResponse StartCrawlerSchedule(StartCrawlerScheduleRequest request)
        {
            var marshaller = StartCrawlerScheduleRequestMarshaller.Instance;
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
        public virtual Task<StartCrawlerScheduleResponse> StartCrawlerScheduleAsync(StartCrawlerScheduleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = StartCrawlerScheduleRequestMarshaller.Instance;
            var unmarshaller = StartCrawlerScheduleResponseUnmarshaller.Instance;

            return InvokeAsync<StartCrawlerScheduleRequest,StartCrawlerScheduleResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  StartJobRun


        /// <summary>
        /// Starts a job run using a job definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartJobRun service method.</param>
        /// 
        /// <returns>The response from the StartJobRun service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.ConcurrentRunsExceededException">
        /// Too many jobs are being run concurrently.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.ResourceNumberLimitExceededException">
        /// A resource numerical limit was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/StartJobRun">REST API Reference for StartJobRun Operation</seealso>
        public virtual StartJobRunResponse StartJobRun(StartJobRunRequest request)
        {
            var marshaller = StartJobRunRequestMarshaller.Instance;
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
        public virtual Task<StartJobRunResponse> StartJobRunAsync(StartJobRunRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = StartJobRunRequestMarshaller.Instance;
            var unmarshaller = StartJobRunResponseUnmarshaller.Instance;

            return InvokeAsync<StartJobRunRequest,StartJobRunResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  StartTrigger


        /// <summary>
        /// Starts an existing trigger. See <a href="http://docs.aws.amazon.com/glue/latest/dg/trigger-job.html">Triggering
        /// Jobs</a> for information about how different types of trigger are started.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartTrigger service method.</param>
        /// 
        /// <returns>The response from the StartTrigger service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.ConcurrentRunsExceededException">
        /// Too many jobs are being run concurrently.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.ResourceNumberLimitExceededException">
        /// A resource numerical limit was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/StartTrigger">REST API Reference for StartTrigger Operation</seealso>
        public virtual StartTriggerResponse StartTrigger(StartTriggerRequest request)
        {
            var marshaller = StartTriggerRequestMarshaller.Instance;
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
        public virtual Task<StartTriggerResponse> StartTriggerAsync(StartTriggerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = StartTriggerRequestMarshaller.Instance;
            var unmarshaller = StartTriggerResponseUnmarshaller.Instance;

            return InvokeAsync<StartTriggerRequest,StartTriggerResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  StopCrawler


        /// <summary>
        /// If the specified crawler is running, stops the crawl.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopCrawler service method.</param>
        /// 
        /// <returns>The response from the StopCrawler service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.CrawlerNotRunningException">
        /// The specified crawler is not running.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.CrawlerStoppingException">
        /// The specified crawler is stopping.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/StopCrawler">REST API Reference for StopCrawler Operation</seealso>
        public virtual StopCrawlerResponse StopCrawler(StopCrawlerRequest request)
        {
            var marshaller = StopCrawlerRequestMarshaller.Instance;
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
        public virtual Task<StopCrawlerResponse> StopCrawlerAsync(StopCrawlerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = StopCrawlerRequestMarshaller.Instance;
            var unmarshaller = StopCrawlerResponseUnmarshaller.Instance;

            return InvokeAsync<StopCrawlerRequest,StopCrawlerResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  StopCrawlerSchedule


        /// <summary>
        /// Sets the schedule state of the specified crawler to <code>NOT_SCHEDULED</code>, but
        /// does not stop the crawler if it is already running.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopCrawlerSchedule service method.</param>
        /// 
        /// <returns>The response from the StopCrawlerSchedule service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.SchedulerNotRunningException">
        /// The specified scheduler is not running.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.SchedulerTransitioningException">
        /// The specified scheduler is transitioning.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/StopCrawlerSchedule">REST API Reference for StopCrawlerSchedule Operation</seealso>
        public virtual StopCrawlerScheduleResponse StopCrawlerSchedule(StopCrawlerScheduleRequest request)
        {
            var marshaller = StopCrawlerScheduleRequestMarshaller.Instance;
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
        public virtual Task<StopCrawlerScheduleResponse> StopCrawlerScheduleAsync(StopCrawlerScheduleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = StopCrawlerScheduleRequestMarshaller.Instance;
            var unmarshaller = StopCrawlerScheduleResponseUnmarshaller.Instance;

            return InvokeAsync<StopCrawlerScheduleRequest,StopCrawlerScheduleResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  StopTrigger


        /// <summary>
        /// Stops a specified trigger.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopTrigger service method.</param>
        /// 
        /// <returns>The response from the StopTrigger service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.ConcurrentModificationException">
        /// Two processes are trying to modify a resource simultaneously.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/StopTrigger">REST API Reference for StopTrigger Operation</seealso>
        public virtual StopTriggerResponse StopTrigger(StopTriggerRequest request)
        {
            var marshaller = StopTriggerRequestMarshaller.Instance;
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
        public virtual Task<StopTriggerResponse> StopTriggerAsync(StopTriggerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = StopTriggerRequestMarshaller.Instance;
            var unmarshaller = StopTriggerResponseUnmarshaller.Instance;

            return InvokeAsync<StopTriggerRequest,StopTriggerResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateClassifier


        /// <summary>
        /// Modifies an existing classifier (a <code>GrokClassifier</code>, <code>XMLClassifier</code>,
        /// or <code>JsonClassifier</code>, depending on which field is present).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateClassifier service method.</param>
        /// 
        /// <returns>The response from the UpdateClassifier service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.VersionMismatchException">
        /// There was a version conflict.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UpdateClassifier">REST API Reference for UpdateClassifier Operation</seealso>
        public virtual UpdateClassifierResponse UpdateClassifier(UpdateClassifierRequest request)
        {
            var marshaller = UpdateClassifierRequestMarshaller.Instance;
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
        public virtual Task<UpdateClassifierResponse> UpdateClassifierAsync(UpdateClassifierRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateClassifierRequestMarshaller.Instance;
            var unmarshaller = UpdateClassifierResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateClassifierRequest,UpdateClassifierResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateConnection


        /// <summary>
        /// Updates a connection definition in the Data Catalog.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateConnection service method.</param>
        /// 
        /// <returns>The response from the UpdateConnection service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UpdateConnection">REST API Reference for UpdateConnection Operation</seealso>
        public virtual UpdateConnectionResponse UpdateConnection(UpdateConnectionRequest request)
        {
            var marshaller = UpdateConnectionRequestMarshaller.Instance;
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
        public virtual Task<UpdateConnectionResponse> UpdateConnectionAsync(UpdateConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateConnectionRequestMarshaller.Instance;
            var unmarshaller = UpdateConnectionResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateConnectionRequest,UpdateConnectionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateCrawler


        /// <summary>
        /// Updates a crawler. If a crawler is running, you must stop it using <code>StopCrawler</code>
        /// before updating it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCrawler service method.</param>
        /// 
        /// <returns>The response from the UpdateCrawler service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.CrawlerRunningException">
        /// The operation cannot be performed because the crawler is already running.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.VersionMismatchException">
        /// There was a version conflict.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UpdateCrawler">REST API Reference for UpdateCrawler Operation</seealso>
        public virtual UpdateCrawlerResponse UpdateCrawler(UpdateCrawlerRequest request)
        {
            var marshaller = UpdateCrawlerRequestMarshaller.Instance;
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
        public virtual Task<UpdateCrawlerResponse> UpdateCrawlerAsync(UpdateCrawlerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateCrawlerRequestMarshaller.Instance;
            var unmarshaller = UpdateCrawlerResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateCrawlerRequest,UpdateCrawlerResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateCrawlerSchedule


        /// <summary>
        /// Updates the schedule of a crawler using a <code>cron</code> expression.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCrawlerSchedule service method.</param>
        /// 
        /// <returns>The response from the UpdateCrawlerSchedule service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.SchedulerTransitioningException">
        /// The specified scheduler is transitioning.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.VersionMismatchException">
        /// There was a version conflict.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UpdateCrawlerSchedule">REST API Reference for UpdateCrawlerSchedule Operation</seealso>
        public virtual UpdateCrawlerScheduleResponse UpdateCrawlerSchedule(UpdateCrawlerScheduleRequest request)
        {
            var marshaller = UpdateCrawlerScheduleRequestMarshaller.Instance;
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
        public virtual Task<UpdateCrawlerScheduleResponse> UpdateCrawlerScheduleAsync(UpdateCrawlerScheduleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateCrawlerScheduleRequestMarshaller.Instance;
            var unmarshaller = UpdateCrawlerScheduleResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateCrawlerScheduleRequest,UpdateCrawlerScheduleResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateDatabase


        /// <summary>
        /// Updates an existing database definition in a Data Catalog.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDatabase service method.</param>
        /// 
        /// <returns>The response from the UpdateDatabase service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UpdateDatabase">REST API Reference for UpdateDatabase Operation</seealso>
        public virtual UpdateDatabaseResponse UpdateDatabase(UpdateDatabaseRequest request)
        {
            var marshaller = UpdateDatabaseRequestMarshaller.Instance;
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
        public virtual Task<UpdateDatabaseResponse> UpdateDatabaseAsync(UpdateDatabaseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateDatabaseRequestMarshaller.Instance;
            var unmarshaller = UpdateDatabaseResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateDatabaseRequest,UpdateDatabaseResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateDevEndpoint


        /// <summary>
        /// Updates a specified DevEndpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDevEndpoint service method.</param>
        /// 
        /// <returns>The response from the UpdateDevEndpoint service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.ValidationException">
        /// A value could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UpdateDevEndpoint">REST API Reference for UpdateDevEndpoint Operation</seealso>
        public virtual UpdateDevEndpointResponse UpdateDevEndpoint(UpdateDevEndpointRequest request)
        {
            var marshaller = UpdateDevEndpointRequestMarshaller.Instance;
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
        public virtual Task<UpdateDevEndpointResponse> UpdateDevEndpointAsync(UpdateDevEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateDevEndpointRequestMarshaller.Instance;
            var unmarshaller = UpdateDevEndpointResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateDevEndpointRequest,UpdateDevEndpointResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateJob


        /// <summary>
        /// Updates an existing job definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateJob service method.</param>
        /// 
        /// <returns>The response from the UpdateJob service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.ConcurrentModificationException">
        /// Two processes are trying to modify a resource simultaneously.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UpdateJob">REST API Reference for UpdateJob Operation</seealso>
        public virtual UpdateJobResponse UpdateJob(UpdateJobRequest request)
        {
            var marshaller = UpdateJobRequestMarshaller.Instance;
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
        public virtual Task<UpdateJobResponse> UpdateJobAsync(UpdateJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateJobRequestMarshaller.Instance;
            var unmarshaller = UpdateJobResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateJobRequest,UpdateJobResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdatePartition


        /// <summary>
        /// Updates a partition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePartition service method.</param>
        /// 
        /// <returns>The response from the UpdatePartition service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UpdatePartition">REST API Reference for UpdatePartition Operation</seealso>
        public virtual UpdatePartitionResponse UpdatePartition(UpdatePartitionRequest request)
        {
            var marshaller = UpdatePartitionRequestMarshaller.Instance;
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
        public virtual Task<UpdatePartitionResponse> UpdatePartitionAsync(UpdatePartitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdatePartitionRequestMarshaller.Instance;
            var unmarshaller = UpdatePartitionResponseUnmarshaller.Instance;

            return InvokeAsync<UpdatePartitionRequest,UpdatePartitionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateTable


        /// <summary>
        /// Updates a metadata table in the Data Catalog.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTable service method.</param>
        /// 
        /// <returns>The response from the UpdateTable service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.ConcurrentModificationException">
        /// Two processes are trying to modify a resource simultaneously.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.ResourceNumberLimitExceededException">
        /// A resource numerical limit was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UpdateTable">REST API Reference for UpdateTable Operation</seealso>
        public virtual UpdateTableResponse UpdateTable(UpdateTableRequest request)
        {
            var marshaller = UpdateTableRequestMarshaller.Instance;
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
        public virtual Task<UpdateTableResponse> UpdateTableAsync(UpdateTableRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateTableRequestMarshaller.Instance;
            var unmarshaller = UpdateTableResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateTableRequest,UpdateTableResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateTrigger


        /// <summary>
        /// Updates a trigger definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTrigger service method.</param>
        /// 
        /// <returns>The response from the UpdateTrigger service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.ConcurrentModificationException">
        /// Two processes are trying to modify a resource simultaneously.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UpdateTrigger">REST API Reference for UpdateTrigger Operation</seealso>
        public virtual UpdateTriggerResponse UpdateTrigger(UpdateTriggerRequest request)
        {
            var marshaller = UpdateTriggerRequestMarshaller.Instance;
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
        public virtual Task<UpdateTriggerResponse> UpdateTriggerAsync(UpdateTriggerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateTriggerRequestMarshaller.Instance;
            var unmarshaller = UpdateTriggerResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateTriggerRequest,UpdateTriggerResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateUserDefinedFunction


        /// <summary>
        /// Updates an existing function definition in the Data Catalog.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateUserDefinedFunction service method.</param>
        /// 
        /// <returns>The response from the UpdateUserDefinedFunction service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UpdateUserDefinedFunction">REST API Reference for UpdateUserDefinedFunction Operation</seealso>
        public virtual UpdateUserDefinedFunctionResponse UpdateUserDefinedFunction(UpdateUserDefinedFunctionRequest request)
        {
            var marshaller = UpdateUserDefinedFunctionRequestMarshaller.Instance;
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
        public virtual Task<UpdateUserDefinedFunctionResponse> UpdateUserDefinedFunctionAsync(UpdateUserDefinedFunctionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateUserDefinedFunctionRequestMarshaller.Instance;
            var unmarshaller = UpdateUserDefinedFunctionResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateUserDefinedFunctionRequest,UpdateUserDefinedFunctionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
    }
}