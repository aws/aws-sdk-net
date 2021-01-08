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
#if NETSTANDARD13
    [Obsolete("Support for .NET Standard 1.3 is in maintenance mode and will only receive critical bug fixes and security patches. Visit https://docs.aws.amazon.com/sdk-for-net/v3/developer-guide/migration-from-net-standard-1-3.html for further details.")]
#endif
    public partial class AmazonGlueClient : AmazonServiceClient, IAmazonGlue
    {
        private static IServiceMetadata serviceMetadata = new AmazonGlueMetadata();
        
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
#if AWS_ASYNC_ENUMERABLES_API
        private IGluePaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IGluePaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new GluePaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif

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
        /// Creates one or more partitions in a batch operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchCreatePartition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchCreatePartition service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.AlreadyExistsException">
        /// A resource to be created or added already exists.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.GlueEncryptionException">
        /// An encryption operation failed.
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
        /// Deletes a list of connection definitions from the Data Catalog.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteConnection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchDeleteConnection service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
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
        /// Deletes one or more partitions in a batch operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDeletePartition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// Deletes multiple tables at once.
        /// 
        ///  <note> 
        /// <para>
        /// After completing this operation, you no longer have access to the table versions and
        /// partitions that belong to the deleted table. AWS Glue deletes these "orphaned" resources
        /// asynchronously in a timely manner, at the discretion of the service.
        /// </para>
        ///  
        /// <para>
        /// To ensure the immediate deletion of all related resources, before calling <code>BatchDeleteTable</code>,
        /// use <code>DeleteTableVersion</code> or <code>BatchDeleteTableVersion</code>, and <code>DeletePartition</code>
        /// or <code>BatchDeletePartition</code>, to delete any resources that belong to the table.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteTable service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// Deletes a specified batch of versions of a table.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteTableVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<BatchDeleteTableVersionResponse> BatchDeleteTableVersionAsync(BatchDeleteTableVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchDeleteTableVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDeleteTableVersionResponseUnmarshaller.Instance;

            return InvokeAsync<BatchDeleteTableVersionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  BatchGetCrawlers

        internal virtual BatchGetCrawlersResponse BatchGetCrawlers(BatchGetCrawlersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchGetCrawlersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetCrawlersResponseUnmarshaller.Instance;

            return Invoke<BatchGetCrawlersResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of resource metadata for a given list of crawler names. After calling
        /// the <code>ListCrawlers</code> operation, you can call this operation to access the
        /// data to which you have been granted permissions. This operation supports all IAM permissions,
        /// including permission conditions that uses tags.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetCrawlers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchGetCrawlers service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/BatchGetCrawlers">REST API Reference for BatchGetCrawlers Operation</seealso>
        public virtual Task<BatchGetCrawlersResponse> BatchGetCrawlersAsync(BatchGetCrawlersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchGetCrawlersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetCrawlersResponseUnmarshaller.Instance;

            return InvokeAsync<BatchGetCrawlersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  BatchGetDevEndpoints

        internal virtual BatchGetDevEndpointsResponse BatchGetDevEndpoints(BatchGetDevEndpointsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchGetDevEndpointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetDevEndpointsResponseUnmarshaller.Instance;

            return Invoke<BatchGetDevEndpointsResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of resource metadata for a given list of development endpoint names.
        /// After calling the <code>ListDevEndpoints</code> operation, you can call this operation
        /// to access the data to which you have been granted permissions. This operation supports
        /// all IAM permissions, including permission conditions that uses tags.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetDevEndpoints service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchGetDevEndpoints service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.AccessDeniedException">
        /// Access to a resource was denied.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/BatchGetDevEndpoints">REST API Reference for BatchGetDevEndpoints Operation</seealso>
        public virtual Task<BatchGetDevEndpointsResponse> BatchGetDevEndpointsAsync(BatchGetDevEndpointsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchGetDevEndpointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetDevEndpointsResponseUnmarshaller.Instance;

            return InvokeAsync<BatchGetDevEndpointsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  BatchGetJobs

        internal virtual BatchGetJobsResponse BatchGetJobs(BatchGetJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchGetJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetJobsResponseUnmarshaller.Instance;

            return Invoke<BatchGetJobsResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of resource metadata for a given list of job names. After calling the
        /// <code>ListJobs</code> operation, you can call this operation to access the data to
        /// which you have been granted permissions. This operation supports all IAM permissions,
        /// including permission conditions that uses tags.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchGetJobs service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/BatchGetJobs">REST API Reference for BatchGetJobs Operation</seealso>
        public virtual Task<BatchGetJobsResponse> BatchGetJobsAsync(BatchGetJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchGetJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetJobsResponseUnmarshaller.Instance;

            return InvokeAsync<BatchGetJobsResponse>(request, options, cancellationToken);
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
        /// Retrieves partitions in a batch request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetPartition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchGetPartition service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.GlueEncryptionException">
        /// An encryption operation failed.
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
        public virtual Task<BatchGetPartitionResponse> BatchGetPartitionAsync(BatchGetPartitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchGetPartitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetPartitionResponseUnmarshaller.Instance;

            return InvokeAsync<BatchGetPartitionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  BatchGetTriggers

        internal virtual BatchGetTriggersResponse BatchGetTriggers(BatchGetTriggersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchGetTriggersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetTriggersResponseUnmarshaller.Instance;

            return Invoke<BatchGetTriggersResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of resource metadata for a given list of trigger names. After calling
        /// the <code>ListTriggers</code> operation, you can call this operation to access the
        /// data to which you have been granted permissions. This operation supports all IAM permissions,
        /// including permission conditions that uses tags.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetTriggers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchGetTriggers service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/BatchGetTriggers">REST API Reference for BatchGetTriggers Operation</seealso>
        public virtual Task<BatchGetTriggersResponse> BatchGetTriggersAsync(BatchGetTriggersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchGetTriggersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetTriggersResponseUnmarshaller.Instance;

            return InvokeAsync<BatchGetTriggersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  BatchGetWorkflows

        internal virtual BatchGetWorkflowsResponse BatchGetWorkflows(BatchGetWorkflowsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchGetWorkflowsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetWorkflowsResponseUnmarshaller.Instance;

            return Invoke<BatchGetWorkflowsResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of resource metadata for a given list of workflow names. After calling
        /// the <code>ListWorkflows</code> operation, you can call this operation to access the
        /// data to which you have been granted permissions. This operation supports all IAM permissions,
        /// including permission conditions that uses tags.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetWorkflows service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchGetWorkflows service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/BatchGetWorkflows">REST API Reference for BatchGetWorkflows Operation</seealso>
        public virtual Task<BatchGetWorkflowsResponse> BatchGetWorkflowsAsync(BatchGetWorkflowsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchGetWorkflowsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetWorkflowsResponseUnmarshaller.Instance;

            return InvokeAsync<BatchGetWorkflowsResponse>(request, options, cancellationToken);
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
        /// Stops one or more job runs for a specified job definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchStopJobRun service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<BatchStopJobRunResponse> BatchStopJobRunAsync(BatchStopJobRunRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchStopJobRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchStopJobRunResponseUnmarshaller.Instance;

            return InvokeAsync<BatchStopJobRunResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  BatchUpdatePartition

        internal virtual BatchUpdatePartitionResponse BatchUpdatePartition(BatchUpdatePartitionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchUpdatePartitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchUpdatePartitionResponseUnmarshaller.Instance;

            return Invoke<BatchUpdatePartitionResponse>(request, options);
        }



        /// <summary>
        /// Updates one or more partitions in a batch operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchUpdatePartition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchUpdatePartition service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.GlueEncryptionException">
        /// An encryption operation failed.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/BatchUpdatePartition">REST API Reference for BatchUpdatePartition Operation</seealso>
        public virtual Task<BatchUpdatePartitionResponse> BatchUpdatePartitionAsync(BatchUpdatePartitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchUpdatePartitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchUpdatePartitionResponseUnmarshaller.Instance;

            return InvokeAsync<BatchUpdatePartitionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CancelMLTaskRun

        internal virtual CancelMLTaskRunResponse CancelMLTaskRun(CancelMLTaskRunRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelMLTaskRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelMLTaskRunResponseUnmarshaller.Instance;

            return Invoke<CancelMLTaskRunResponse>(request, options);
        }



        /// <summary>
        /// Cancels (stops) a task run. Machine learning task runs are asynchronous tasks that
        /// AWS Glue runs on your behalf as part of various machine learning workflows. You can
        /// cancel a machine learning task run at any time by calling <code>CancelMLTaskRun</code>
        /// with a task run's parent transform's <code>TransformID</code> and the task run's <code>TaskRunId</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelMLTaskRun service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelMLTaskRun service method, as returned by Glue.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CancelMLTaskRun">REST API Reference for CancelMLTaskRun Operation</seealso>
        public virtual Task<CancelMLTaskRunResponse> CancelMLTaskRunAsync(CancelMLTaskRunRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelMLTaskRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelMLTaskRunResponseUnmarshaller.Instance;

            return InvokeAsync<CancelMLTaskRunResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CheckSchemaVersionValidity

        internal virtual CheckSchemaVersionValidityResponse CheckSchemaVersionValidity(CheckSchemaVersionValidityRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CheckSchemaVersionValidityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CheckSchemaVersionValidityResponseUnmarshaller.Instance;

            return Invoke<CheckSchemaVersionValidityResponse>(request, options);
        }



        /// <summary>
        /// Validates the supplied schema. This call has no side effects, it simply validates
        /// using the supplied schema using <code>DataFormat</code> as the format. Since it does
        /// not take a schema set name, no compatibility checks are performed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CheckSchemaVersionValidity service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CheckSchemaVersionValidity service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.AccessDeniedException">
        /// Access to a resource was denied.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CheckSchemaVersionValidity">REST API Reference for CheckSchemaVersionValidity Operation</seealso>
        public virtual Task<CheckSchemaVersionValidityResponse> CheckSchemaVersionValidityAsync(CheckSchemaVersionValidityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CheckSchemaVersionValidityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CheckSchemaVersionValidityResponseUnmarshaller.Instance;

            return InvokeAsync<CheckSchemaVersionValidityResponse>(request, options, cancellationToken);
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
        /// Creates a classifier in the user's account. This can be a <code>GrokClassifier</code>,
        /// an <code>XMLClassifier</code>, a <code>JsonClassifier</code>, or a <code>CsvClassifier</code>,
        /// depending on which field of the request is present.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateClassifier service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// Creates a connection definition in the Data Catalog.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConnection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateConnection service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.AlreadyExistsException">
        /// A resource to be created or added already exists.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.GlueEncryptionException">
        /// An encryption operation failed.
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
        /// Creates a new crawler with specified targets, role, configuration, and optional schedule.
        /// At least one crawl target must be specified, in the <code>s3Targets</code> field,
        /// the <code>jdbcTargets</code> field, or the <code>DynamoDBTargets</code> field.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCrawler service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// Creates a new database in a Data Catalog.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDatabase service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDatabase service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.AlreadyExistsException">
        /// A resource to be created or added already exists.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.GlueEncryptionException">
        /// An encryption operation failed.
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
        /// Creates a new development endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDevEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// Creates a new job definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<CreateJobResponse> CreateJobAsync(CreateJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateJobResponseUnmarshaller.Instance;

            return InvokeAsync<CreateJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateMLTransform

        internal virtual CreateMLTransformResponse CreateMLTransform(CreateMLTransformRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateMLTransformRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMLTransformResponseUnmarshaller.Instance;

            return Invoke<CreateMLTransformResponse>(request, options);
        }



        /// <summary>
        /// Creates an AWS Glue machine learning transform. This operation creates the transform
        /// and all the necessary parameters to train it.
        /// 
        ///  
        /// <para>
        /// Call this operation as the first step in the process of using a machine learning transform
        /// (such as the <code>FindMatches</code> transform) for deduplicating data. You can provide
        /// an optional <code>Description</code>, in addition to the parameters that you want
        /// to use for your algorithm.
        /// </para>
        ///  
        /// <para>
        /// You must also specify certain parameters for the tasks that AWS Glue runs on your
        /// behalf as part of learning from your data and creating a high-quality machine learning
        /// transform. These parameters include <code>Role</code>, and optionally, <code>AllocatedCapacity</code>,
        /// <code>Timeout</code>, and <code>MaxRetries</code>. For more information, see <a href="https://docs.aws.amazon.com/glue/latest/dg/aws-glue-api-jobs-job.html">Jobs</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMLTransform service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateMLTransform service method, as returned by Glue.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CreateMLTransform">REST API Reference for CreateMLTransform Operation</seealso>
        public virtual Task<CreateMLTransformResponse> CreateMLTransformAsync(CreateMLTransformRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateMLTransformRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMLTransformResponseUnmarshaller.Instance;

            return InvokeAsync<CreateMLTransformResponse>(request, options, cancellationToken);
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
        /// Creates a new partition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePartition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreatePartition service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.AlreadyExistsException">
        /// A resource to be created or added already exists.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.GlueEncryptionException">
        /// An encryption operation failed.
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
        public virtual Task<CreatePartitionResponse> CreatePartitionAsync(CreatePartitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePartitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePartitionResponseUnmarshaller.Instance;

            return InvokeAsync<CreatePartitionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreatePartitionIndex

        internal virtual CreatePartitionIndexResponse CreatePartitionIndex(CreatePartitionIndexRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePartitionIndexRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePartitionIndexResponseUnmarshaller.Instance;

            return Invoke<CreatePartitionIndexResponse>(request, options);
        }



        /// <summary>
        /// Creates a specified partition index in an existing table.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePartitionIndex service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreatePartitionIndex service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.AlreadyExistsException">
        /// A resource to be created or added already exists.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.GlueEncryptionException">
        /// An encryption operation failed.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CreatePartitionIndex">REST API Reference for CreatePartitionIndex Operation</seealso>
        public virtual Task<CreatePartitionIndexResponse> CreatePartitionIndexAsync(CreatePartitionIndexRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePartitionIndexRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePartitionIndexResponseUnmarshaller.Instance;

            return InvokeAsync<CreatePartitionIndexResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateRegistry

        internal virtual CreateRegistryResponse CreateRegistry(CreateRegistryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateRegistryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRegistryResponseUnmarshaller.Instance;

            return Invoke<CreateRegistryResponse>(request, options);
        }



        /// <summary>
        /// Creates a new registry which may be used to hold a collection of schemas.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRegistry service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateRegistry service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.AccessDeniedException">
        /// Access to a resource was denied.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.AlreadyExistsException">
        /// A resource to be created or added already exists.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.ResourceNumberLimitExceededException">
        /// A resource numerical limit was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CreateRegistry">REST API Reference for CreateRegistry Operation</seealso>
        public virtual Task<CreateRegistryResponse> CreateRegistryAsync(CreateRegistryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateRegistryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRegistryResponseUnmarshaller.Instance;

            return InvokeAsync<CreateRegistryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateSchema

        internal virtual CreateSchemaResponse CreateSchema(CreateSchemaRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSchemaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSchemaResponseUnmarshaller.Instance;

            return Invoke<CreateSchemaResponse>(request, options);
        }



        /// <summary>
        /// Creates a new schema set and registers the schema definition. Returns an error if
        /// the schema set already exists without actually registering the version.
        /// 
        ///  
        /// <para>
        /// When the schema set is created, a version checkpoint will be set to the first version.
        /// Compatibility mode "DISABLED" restricts any additional schema versions from being
        /// added after the first schema version. For all other compatibility modes, validation
        /// of compatibility settings will be applied only from the second version onwards when
        /// the <code>RegisterSchemaVersion</code> API is used.
        /// </para>
        ///  
        /// <para>
        /// When this API is called without a <code>RegistryId</code>, this will create an entry
        /// for a "default-registry" in the registry database tables, if it is not already present.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSchema service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSchema service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.AccessDeniedException">
        /// Access to a resource was denied.
        /// </exception>
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
        /// <exception cref="Amazon.Glue.Model.ResourceNumberLimitExceededException">
        /// A resource numerical limit was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CreateSchema">REST API Reference for CreateSchema Operation</seealso>
        public virtual Task<CreateSchemaResponse> CreateSchemaAsync(CreateSchemaRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSchemaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSchemaResponseUnmarshaller.Instance;

            return InvokeAsync<CreateSchemaResponse>(request, options, cancellationToken);
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
        /// Transforms a directed acyclic graph (DAG) into code.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateScript service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// Creates a new security configuration. A security configuration is a set of security
        /// properties that can be used by AWS Glue. You can use a security configuration to encrypt
        /// data at rest. For information about using security configurations in AWS Glue, see
        /// <a href="https://docs.aws.amazon.com/glue/latest/dg/encryption-security-configuration.html">Encrypting
        /// Data Written by Crawlers, Jobs, and Development Endpoints</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSecurityConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSecurityConfiguration service method, as returned by Glue.</returns>
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
        /// Creates a new table definition in the Data Catalog.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTable service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateTable service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.AlreadyExistsException">
        /// A resource to be created or added already exists.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.GlueEncryptionException">
        /// An encryption operation failed.
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
        /// Creates a new trigger.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTrigger service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateTrigger service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.AlreadyExistsException">
        /// A resource to be created or added already exists.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.ConcurrentModificationException">
        /// Two processes are trying to modify a resource simultaneously.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
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
        /// Creates a new function definition in the Data Catalog.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateUserDefinedFunction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateUserDefinedFunction service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.AlreadyExistsException">
        /// A resource to be created or added already exists.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.GlueEncryptionException">
        /// An encryption operation failed.
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
        public virtual Task<CreateUserDefinedFunctionResponse> CreateUserDefinedFunctionAsync(CreateUserDefinedFunctionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateUserDefinedFunctionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateUserDefinedFunctionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateUserDefinedFunctionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateWorkflow

        internal virtual CreateWorkflowResponse CreateWorkflow(CreateWorkflowRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateWorkflowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWorkflowResponseUnmarshaller.Instance;

            return Invoke<CreateWorkflowResponse>(request, options);
        }



        /// <summary>
        /// Creates a new workflow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkflow service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateWorkflow service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.AlreadyExistsException">
        /// A resource to be created or added already exists.
        /// </exception>
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
        /// <exception cref="Amazon.Glue.Model.ResourceNumberLimitExceededException">
        /// A resource numerical limit was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CreateWorkflow">REST API Reference for CreateWorkflow Operation</seealso>
        public virtual Task<CreateWorkflowResponse> CreateWorkflowAsync(CreateWorkflowRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateWorkflowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWorkflowResponseUnmarshaller.Instance;

            return InvokeAsync<CreateWorkflowResponse>(request, options, cancellationToken);
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
        /// Removes a classifier from the Data Catalog.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteClassifier service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteClassifier service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteClassifier">REST API Reference for DeleteClassifier Operation</seealso>
        public virtual Task<DeleteClassifierResponse> DeleteClassifierAsync(DeleteClassifierRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteClassifierRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteClassifierResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteClassifierResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteColumnStatisticsForPartition

        internal virtual DeleteColumnStatisticsForPartitionResponse DeleteColumnStatisticsForPartition(DeleteColumnStatisticsForPartitionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteColumnStatisticsForPartitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteColumnStatisticsForPartitionResponseUnmarshaller.Instance;

            return Invoke<DeleteColumnStatisticsForPartitionResponse>(request, options);
        }



        /// <summary>
        /// Delete the partition column statistics of a column.
        /// 
        ///  
        /// <para>
        /// The Identity and Access Management (IAM) permission required for this operation is
        /// <code>DeletePartition</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteColumnStatisticsForPartition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteColumnStatisticsForPartition service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.GlueEncryptionException">
        /// An encryption operation failed.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteColumnStatisticsForPartition">REST API Reference for DeleteColumnStatisticsForPartition Operation</seealso>
        public virtual Task<DeleteColumnStatisticsForPartitionResponse> DeleteColumnStatisticsForPartitionAsync(DeleteColumnStatisticsForPartitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteColumnStatisticsForPartitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteColumnStatisticsForPartitionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteColumnStatisticsForPartitionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteColumnStatisticsForTable

        internal virtual DeleteColumnStatisticsForTableResponse DeleteColumnStatisticsForTable(DeleteColumnStatisticsForTableRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteColumnStatisticsForTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteColumnStatisticsForTableResponseUnmarshaller.Instance;

            return Invoke<DeleteColumnStatisticsForTableResponse>(request, options);
        }



        /// <summary>
        /// Retrieves table statistics of columns.
        /// 
        ///  
        /// <para>
        /// The Identity and Access Management (IAM) permission required for this operation is
        /// <code>DeleteTable</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteColumnStatisticsForTable service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteColumnStatisticsForTable service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.GlueEncryptionException">
        /// An encryption operation failed.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteColumnStatisticsForTable">REST API Reference for DeleteColumnStatisticsForTable Operation</seealso>
        public virtual Task<DeleteColumnStatisticsForTableResponse> DeleteColumnStatisticsForTableAsync(DeleteColumnStatisticsForTableRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteColumnStatisticsForTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteColumnStatisticsForTableResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteColumnStatisticsForTableResponse>(request, options, cancellationToken);
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
        /// Deletes a connection from the Data Catalog.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConnection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteConnection service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
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
        /// Removes a specified crawler from the AWS Glue Data Catalog, unless the crawler state
        /// is <code>RUNNING</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCrawler service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// Removes a specified database from a Data Catalog.
        /// 
        ///  <note> 
        /// <para>
        /// After completing this operation, you no longer have access to the tables (and all
        /// table versions and partitions that might belong to the tables) and the user-defined
        /// functions in the deleted database. AWS Glue deletes these "orphaned" resources asynchronously
        /// in a timely manner, at the discretion of the service.
        /// </para>
        ///  
        /// <para>
        /// To ensure the immediate deletion of all related resources, before calling <code>DeleteDatabase</code>,
        /// use <code>DeleteTableVersion</code> or <code>BatchDeleteTableVersion</code>, <code>DeletePartition</code>
        /// or <code>BatchDeletePartition</code>, <code>DeleteUserDefinedFunction</code>, and
        /// <code>DeleteTable</code> or <code>BatchDeleteTable</code>, to delete any resources
        /// that belong to the database.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDatabase service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// Deletes a specified development endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDevEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// Deletes a specified job definition. If the job definition is not found, no exception
        /// is thrown.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DeleteJobResponse> DeleteJobAsync(DeleteJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteJobResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteMLTransform

        internal virtual DeleteMLTransformResponse DeleteMLTransform(DeleteMLTransformRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteMLTransformRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMLTransformResponseUnmarshaller.Instance;

            return Invoke<DeleteMLTransformResponse>(request, options);
        }



        /// <summary>
        /// Deletes an AWS Glue machine learning transform. Machine learning transforms are a
        /// special type of transform that use machine learning to learn the details of the transformation
        /// to be performed by learning from examples provided by humans. These transformations
        /// are then saved by AWS Glue. If you no longer need a transform, you can delete it by
        /// calling <code>DeleteMLTransforms</code>. However, any AWS Glue jobs that still reference
        /// the deleted transform will no longer succeed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMLTransform service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteMLTransform service method, as returned by Glue.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteMLTransform">REST API Reference for DeleteMLTransform Operation</seealso>
        public virtual Task<DeleteMLTransformResponse> DeleteMLTransformAsync(DeleteMLTransformRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteMLTransformRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMLTransformResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteMLTransformResponse>(request, options, cancellationToken);
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
        /// Deletes a specified partition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePartition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DeletePartitionResponse> DeletePartitionAsync(DeletePartitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePartitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePartitionResponseUnmarshaller.Instance;

            return InvokeAsync<DeletePartitionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeletePartitionIndex

        internal virtual DeletePartitionIndexResponse DeletePartitionIndex(DeletePartitionIndexRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePartitionIndexRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePartitionIndexResponseUnmarshaller.Instance;

            return Invoke<DeletePartitionIndexResponse>(request, options);
        }



        /// <summary>
        /// Deletes a specified partition index from an existing table.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePartitionIndex service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeletePartitionIndex service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.ConflictException">
        /// The <code>CreatePartitions</code> API was called on a table that has indexes enabled.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.GlueEncryptionException">
        /// An encryption operation failed.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeletePartitionIndex">REST API Reference for DeletePartitionIndex Operation</seealso>
        public virtual Task<DeletePartitionIndexResponse> DeletePartitionIndexAsync(DeletePartitionIndexRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePartitionIndexRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePartitionIndexResponseUnmarshaller.Instance;

            return InvokeAsync<DeletePartitionIndexResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteRegistry

        internal virtual DeleteRegistryResponse DeleteRegistry(DeleteRegistryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRegistryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRegistryResponseUnmarshaller.Instance;

            return Invoke<DeleteRegistryResponse>(request, options);
        }



        /// <summary>
        /// Delete the entire registry including schema and all of its versions. To get the status
        /// of the delete operation, you can call the <code>GetRegistry</code> API after the asynchronous
        /// call. Deleting a registry will disable all online operations for the registry such
        /// as the <code>UpdateRegistry</code>, <code>CreateSchema</code>, <code>UpdateSchema</code>,
        /// and <code>RegisterSchemaVersion</code> APIs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRegistry service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteRegistry service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.AccessDeniedException">
        /// Access to a resource was denied.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.ConcurrentModificationException">
        /// Two processes are trying to modify a resource simultaneously.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteRegistry">REST API Reference for DeleteRegistry Operation</seealso>
        public virtual Task<DeleteRegistryResponse> DeleteRegistryAsync(DeleteRegistryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRegistryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRegistryResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteRegistryResponse>(request, options, cancellationToken);
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
        /// Deletes a specified policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourcePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteResourcePolicy service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.ConditionCheckFailureException">
        /// A specified condition was not satisfied.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteResourcePolicy">REST API Reference for DeleteResourcePolicy Operation</seealso>
        public virtual Task<DeleteResourcePolicyResponse> DeleteResourcePolicyAsync(DeleteResourcePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteResourcePolicyResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteResourcePolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteSchema

        internal virtual DeleteSchemaResponse DeleteSchema(DeleteSchemaRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSchemaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSchemaResponseUnmarshaller.Instance;

            return Invoke<DeleteSchemaResponse>(request, options);
        }



        /// <summary>
        /// Deletes the entire schema set, including the schema set and all of its versions. To
        /// get the status of the delete operation, you can call <code>GetSchema</code> API after
        /// the asynchronous call. Deleting a registry will disable all online operations for
        /// the schema, such as the <code>GetSchemaByDefinition</code>, and <code>RegisterSchemaVersion</code>
        /// APIs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSchema service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSchema service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.AccessDeniedException">
        /// Access to a resource was denied.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.ConcurrentModificationException">
        /// Two processes are trying to modify a resource simultaneously.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteSchema">REST API Reference for DeleteSchema Operation</seealso>
        public virtual Task<DeleteSchemaResponse> DeleteSchemaAsync(DeleteSchemaRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSchemaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSchemaResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteSchemaResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteSchemaVersions

        internal virtual DeleteSchemaVersionsResponse DeleteSchemaVersions(DeleteSchemaVersionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSchemaVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSchemaVersionsResponseUnmarshaller.Instance;

            return Invoke<DeleteSchemaVersionsResponse>(request, options);
        }



        /// <summary>
        /// Remove versions from the specified schema. A version number or range may be supplied.
        /// If the compatibility mode forbids deleting of a version that is necessary, such as
        /// BACKWARDS_FULL, an error is returned. Calling the <code>GetSchemaVersions</code> API
        /// after this call will list the status of the deleted versions.
        /// 
        ///  
        /// <para>
        /// When the range of version numbers contain check pointed version, the API will return
        /// a 409 conflict and will not proceed with the deletion. You have to remove the checkpoint
        /// first using the <code>DeleteSchemaCheckpoint</code> API before using this API.
        /// </para>
        ///  
        /// <para>
        /// You cannot use the <code>DeleteSchemaVersions</code> API to delete the first schema
        /// version in the schema set. The first schema version can only be deleted by the <code>DeleteSchema</code>
        /// API. This operation will also delete the attached <code>SchemaVersionMetadata</code>
        /// under the schema versions. Hard deletes will be enforced on the database.
        /// </para>
        ///  
        /// <para>
        /// If the compatibility mode forbids deleting of a version that is necessary, such as
        /// BACKWARDS_FULL, an error is returned.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSchemaVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSchemaVersions service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.AccessDeniedException">
        /// Access to a resource was denied.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.ConcurrentModificationException">
        /// Two processes are trying to modify a resource simultaneously.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteSchemaVersions">REST API Reference for DeleteSchemaVersions Operation</seealso>
        public virtual Task<DeleteSchemaVersionsResponse> DeleteSchemaVersionsAsync(DeleteSchemaVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSchemaVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSchemaVersionsResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteSchemaVersionsResponse>(request, options, cancellationToken);
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
        /// Deletes a specified security configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSecurityConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSecurityConfiguration service method, as returned by Glue.</returns>
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
        /// Removes a table definition from the Data Catalog.
        /// 
        ///  <note> 
        /// <para>
        /// After completing this operation, you no longer have access to the table versions and
        /// partitions that belong to the deleted table. AWS Glue deletes these "orphaned" resources
        /// asynchronously in a timely manner, at the discretion of the service.
        /// </para>
        ///  
        /// <para>
        /// To ensure the immediate deletion of all related resources, before calling <code>DeleteTable</code>,
        /// use <code>DeleteTableVersion</code> or <code>BatchDeleteTableVersion</code>, and <code>DeletePartition</code>
        /// or <code>BatchDeletePartition</code>, to delete any resources that belong to the table.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTable service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// Deletes a specified version of a table.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTableVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// Deletes a specified trigger. If the trigger is not found, no exception is thrown.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTrigger service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// Deletes an existing function definition from the Data Catalog.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteUserDefinedFunction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DeleteUserDefinedFunctionResponse> DeleteUserDefinedFunctionAsync(DeleteUserDefinedFunctionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteUserDefinedFunctionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteUserDefinedFunctionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteUserDefinedFunctionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteWorkflow

        internal virtual DeleteWorkflowResponse DeleteWorkflow(DeleteWorkflowRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteWorkflowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWorkflowResponseUnmarshaller.Instance;

            return Invoke<DeleteWorkflowResponse>(request, options);
        }



        /// <summary>
        /// Deletes a workflow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkflow service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteWorkflow service method, as returned by Glue.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteWorkflow">REST API Reference for DeleteWorkflow Operation</seealso>
        public virtual Task<DeleteWorkflowResponse> DeleteWorkflowAsync(DeleteWorkflowRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteWorkflowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWorkflowResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteWorkflowResponse>(request, options, cancellationToken);
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
        /// Retrieves the status of a migration operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCatalogImportStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCatalogImportStatus service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
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
        /// Retrieve a classifier by name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetClassifier service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetClassifier service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
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
        /// Lists all classifier objects in the Data Catalog.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetClassifiers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetClassifiers service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetClassifiers">REST API Reference for GetClassifiers Operation</seealso>
        public virtual Task<GetClassifiersResponse> GetClassifiersAsync(GetClassifiersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetClassifiersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetClassifiersResponseUnmarshaller.Instance;

            return InvokeAsync<GetClassifiersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetColumnStatisticsForPartition

        internal virtual GetColumnStatisticsForPartitionResponse GetColumnStatisticsForPartition(GetColumnStatisticsForPartitionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetColumnStatisticsForPartitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetColumnStatisticsForPartitionResponseUnmarshaller.Instance;

            return Invoke<GetColumnStatisticsForPartitionResponse>(request, options);
        }



        /// <summary>
        /// Retrieves partition statistics of columns.
        /// 
        ///  
        /// <para>
        /// The Identity and Access Management (IAM) permission required for this operation is
        /// <code>GetPartition</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetColumnStatisticsForPartition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetColumnStatisticsForPartition service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.GlueEncryptionException">
        /// An encryption operation failed.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetColumnStatisticsForPartition">REST API Reference for GetColumnStatisticsForPartition Operation</seealso>
        public virtual Task<GetColumnStatisticsForPartitionResponse> GetColumnStatisticsForPartitionAsync(GetColumnStatisticsForPartitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetColumnStatisticsForPartitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetColumnStatisticsForPartitionResponseUnmarshaller.Instance;

            return InvokeAsync<GetColumnStatisticsForPartitionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetColumnStatisticsForTable

        internal virtual GetColumnStatisticsForTableResponse GetColumnStatisticsForTable(GetColumnStatisticsForTableRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetColumnStatisticsForTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetColumnStatisticsForTableResponseUnmarshaller.Instance;

            return Invoke<GetColumnStatisticsForTableResponse>(request, options);
        }



        /// <summary>
        /// Retrieves table statistics of columns.
        /// 
        ///  
        /// <para>
        /// The Identity and Access Management (IAM) permission required for this operation is
        /// <code>GetTable</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetColumnStatisticsForTable service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetColumnStatisticsForTable service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.GlueEncryptionException">
        /// An encryption operation failed.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetColumnStatisticsForTable">REST API Reference for GetColumnStatisticsForTable Operation</seealso>
        public virtual Task<GetColumnStatisticsForTableResponse> GetColumnStatisticsForTableAsync(GetColumnStatisticsForTableRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetColumnStatisticsForTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetColumnStatisticsForTableResponseUnmarshaller.Instance;

            return InvokeAsync<GetColumnStatisticsForTableResponse>(request, options, cancellationToken);
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
        /// Retrieves a connection definition from the Data Catalog.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConnection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetConnection service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.GlueEncryptionException">
        /// An encryption operation failed.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
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
        /// Retrieves a list of connection definitions from the Data Catalog.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConnections service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetConnections service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.GlueEncryptionException">
        /// An encryption operation failed.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
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
        /// Retrieves metadata for a specified crawler.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCrawler service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCrawler service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
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
        /// Retrieves metrics about specified crawlers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCrawlerMetrics service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCrawlerMetrics service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
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
        /// Retrieves metadata for all crawlers defined in the customer account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCrawlers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCrawlers service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
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
        /// Retrieves the definition of a specified database.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDatabase service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDatabase service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.GlueEncryptionException">
        /// An encryption operation failed.
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
        /// Retrieves all databases defined in a given Data Catalog.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDatabases service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDatabases service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.GlueEncryptionException">
        /// An encryption operation failed.
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
        /// Retrieves the security configuration for a specified catalog.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDataCatalogEncryptionSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDataCatalogEncryptionSettings service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
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
        /// Transforms a Python script into a directed acyclic graph (DAG).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDataflowGraph service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// Retrieves information about a specified development endpoint.
        /// 
        ///  <note> 
        /// <para>
        /// When you create a development endpoint in a virtual private cloud (VPC), AWS Glue
        /// returns only a private IP address, and the public IP address field is not populated.
        /// When you create a non-VPC development endpoint, AWS Glue returns only a public IP
        /// address.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDevEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// Retrieves all the development endpoints in this AWS account.
        /// 
        ///  <note> 
        /// <para>
        /// When you create a development endpoint in a virtual private cloud (VPC), AWS Glue
        /// returns only a private IP address and the public IP address field is not populated.
        /// When you create a non-VPC development endpoint, AWS Glue returns only a public IP
        /// address.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDevEndpoints service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// Retrieves an existing job definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetJobResponse> GetJobAsync(GetJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetJobResponseUnmarshaller.Instance;

            return InvokeAsync<GetJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetJobBookmark

        internal virtual GetJobBookmarkResponse GetJobBookmark(GetJobBookmarkRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetJobBookmarkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetJobBookmarkResponseUnmarshaller.Instance;

            return Invoke<GetJobBookmarkResponse>(request, options);
        }



        /// <summary>
        /// Returns information on a job bookmark entry.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetJobBookmark service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetJobBookmark service method, as returned by Glue.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetJobBookmark">REST API Reference for GetJobBookmark Operation</seealso>
        public virtual Task<GetJobBookmarkResponse> GetJobBookmarkAsync(GetJobBookmarkRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetJobBookmarkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetJobBookmarkResponseUnmarshaller.Instance;

            return InvokeAsync<GetJobBookmarkResponse>(request, options, cancellationToken);
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
        /// Retrieves the metadata for a given job run.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetJobRun service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// Retrieves metadata for all runs of a given job definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetJobRuns service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// Retrieves all current job definitions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// Creates mappings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMapping service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetMappingResponse> GetMappingAsync(GetMappingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMappingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMappingResponseUnmarshaller.Instance;

            return InvokeAsync<GetMappingResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetMLTaskRun

        internal virtual GetMLTaskRunResponse GetMLTaskRun(GetMLTaskRunRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMLTaskRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMLTaskRunResponseUnmarshaller.Instance;

            return Invoke<GetMLTaskRunResponse>(request, options);
        }



        /// <summary>
        /// Gets details for a specific task run on a machine learning transform. Machine learning
        /// task runs are asynchronous tasks that AWS Glue runs on your behalf as part of various
        /// machine learning workflows. You can check the stats of any task run by calling <code>GetMLTaskRun</code>
        /// with the <code>TaskRunID</code> and its parent transform's <code>TransformID</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMLTaskRun service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetMLTaskRun service method, as returned by Glue.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetMLTaskRun">REST API Reference for GetMLTaskRun Operation</seealso>
        public virtual Task<GetMLTaskRunResponse> GetMLTaskRunAsync(GetMLTaskRunRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMLTaskRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMLTaskRunResponseUnmarshaller.Instance;

            return InvokeAsync<GetMLTaskRunResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetMLTaskRuns

        internal virtual GetMLTaskRunsResponse GetMLTaskRuns(GetMLTaskRunsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMLTaskRunsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMLTaskRunsResponseUnmarshaller.Instance;

            return Invoke<GetMLTaskRunsResponse>(request, options);
        }



        /// <summary>
        /// Gets a list of runs for a machine learning transform. Machine learning task runs are
        /// asynchronous tasks that AWS Glue runs on your behalf as part of various machine learning
        /// workflows. You can get a sortable, filterable list of machine learning task runs by
        /// calling <code>GetMLTaskRuns</code> with their parent transform's <code>TransformID</code>
        /// and other optional parameters as documented in this section.
        /// 
        ///  
        /// <para>
        /// This operation returns a list of historic runs and must be paginated.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMLTaskRuns service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetMLTaskRuns service method, as returned by Glue.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetMLTaskRuns">REST API Reference for GetMLTaskRuns Operation</seealso>
        public virtual Task<GetMLTaskRunsResponse> GetMLTaskRunsAsync(GetMLTaskRunsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMLTaskRunsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMLTaskRunsResponseUnmarshaller.Instance;

            return InvokeAsync<GetMLTaskRunsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetMLTransform

        internal virtual GetMLTransformResponse GetMLTransform(GetMLTransformRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMLTransformRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMLTransformResponseUnmarshaller.Instance;

            return Invoke<GetMLTransformResponse>(request, options);
        }



        /// <summary>
        /// Gets an AWS Glue machine learning transform artifact and all its corresponding metadata.
        /// Machine learning transforms are a special type of transform that use machine learning
        /// to learn the details of the transformation to be performed by learning from examples
        /// provided by humans. These transformations are then saved by AWS Glue. You can retrieve
        /// their metadata by calling <code>GetMLTransform</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMLTransform service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetMLTransform service method, as returned by Glue.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetMLTransform">REST API Reference for GetMLTransform Operation</seealso>
        public virtual Task<GetMLTransformResponse> GetMLTransformAsync(GetMLTransformRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMLTransformRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMLTransformResponseUnmarshaller.Instance;

            return InvokeAsync<GetMLTransformResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetMLTransforms

        internal virtual GetMLTransformsResponse GetMLTransforms(GetMLTransformsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMLTransformsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMLTransformsResponseUnmarshaller.Instance;

            return Invoke<GetMLTransformsResponse>(request, options);
        }



        /// <summary>
        /// Gets a sortable, filterable list of existing AWS Glue machine learning transforms.
        /// Machine learning transforms are a special type of transform that use machine learning
        /// to learn the details of the transformation to be performed by learning from examples
        /// provided by humans. These transformations are then saved by AWS Glue, and you can
        /// retrieve their metadata by calling <code>GetMLTransforms</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMLTransforms service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetMLTransforms service method, as returned by Glue.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetMLTransforms">REST API Reference for GetMLTransforms Operation</seealso>
        public virtual Task<GetMLTransformsResponse> GetMLTransformsAsync(GetMLTransformsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMLTransformsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMLTransformsResponseUnmarshaller.Instance;

            return InvokeAsync<GetMLTransformsResponse>(request, options, cancellationToken);
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
        /// Retrieves information about a specified partition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPartition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetPartition service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.GlueEncryptionException">
        /// An encryption operation failed.
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
        public virtual Task<GetPartitionResponse> GetPartitionAsync(GetPartitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPartitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPartitionResponseUnmarshaller.Instance;

            return InvokeAsync<GetPartitionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetPartitionIndexes

        internal virtual GetPartitionIndexesResponse GetPartitionIndexes(GetPartitionIndexesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPartitionIndexesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPartitionIndexesResponseUnmarshaller.Instance;

            return Invoke<GetPartitionIndexesResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the partition indexes associated with a table.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPartitionIndexes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetPartitionIndexes service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.ConflictException">
        /// The <code>CreatePartitions</code> API was called on a table that has indexes enabled.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetPartitionIndexes">REST API Reference for GetPartitionIndexes Operation</seealso>
        public virtual Task<GetPartitionIndexesResponse> GetPartitionIndexesAsync(GetPartitionIndexesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPartitionIndexesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPartitionIndexesResponseUnmarshaller.Instance;

            return InvokeAsync<GetPartitionIndexesResponse>(request, options, cancellationToken);
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
        /// Retrieves information about the partitions in a table.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPartitions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetPartitions service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.GlueEncryptionException">
        /// An encryption operation failed.
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
        /// Gets code to perform a specified mapping.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPlan service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetPlanResponse> GetPlanAsync(GetPlanRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPlanResponseUnmarshaller.Instance;

            return InvokeAsync<GetPlanResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetRegistry

        internal virtual GetRegistryResponse GetRegistry(GetRegistryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRegistryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRegistryResponseUnmarshaller.Instance;

            return Invoke<GetRegistryResponse>(request, options);
        }



        /// <summary>
        /// Describes the specified registry in detail.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRegistry service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetRegistry service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.AccessDeniedException">
        /// Access to a resource was denied.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetRegistry">REST API Reference for GetRegistry Operation</seealso>
        public virtual Task<GetRegistryResponse> GetRegistryAsync(GetRegistryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRegistryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRegistryResponseUnmarshaller.Instance;

            return InvokeAsync<GetRegistryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetResourcePolicies

        internal virtual GetResourcePoliciesResponse GetResourcePolicies(GetResourcePoliciesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetResourcePoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourcePoliciesResponseUnmarshaller.Instance;

            return Invoke<GetResourcePoliciesResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the security configurations for the resource policies set on individual
        /// resources, and also the account-level policy.
        /// 
        ///  
        /// <para>
        /// This operation also returns the Data Catalog resource policy. However, if you enabled
        /// metadata encryption in Data Catalog settings, and you do not have permission on the
        /// AWS KMS key, the operation can't return the Data Catalog resource policy.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourcePolicies service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetResourcePolicies service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.GlueEncryptionException">
        /// An encryption operation failed.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetResourcePolicies">REST API Reference for GetResourcePolicies Operation</seealso>
        public virtual Task<GetResourcePoliciesResponse> GetResourcePoliciesAsync(GetResourcePoliciesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetResourcePoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourcePoliciesResponseUnmarshaller.Instance;

            return InvokeAsync<GetResourcePoliciesResponse>(request, options, cancellationToken);
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
        /// Retrieves a specified resource policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourcePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetResourcePolicy service method, as returned by Glue.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetResourcePolicy">REST API Reference for GetResourcePolicy Operation</seealso>
        public virtual Task<GetResourcePolicyResponse> GetResourcePolicyAsync(GetResourcePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourcePolicyResponseUnmarshaller.Instance;

            return InvokeAsync<GetResourcePolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetSchema

        internal virtual GetSchemaResponse GetSchema(GetSchemaRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSchemaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSchemaResponseUnmarshaller.Instance;

            return Invoke<GetSchemaResponse>(request, options);
        }



        /// <summary>
        /// Describes the specified schema in detail.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSchema service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSchema service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.AccessDeniedException">
        /// Access to a resource was denied.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetSchema">REST API Reference for GetSchema Operation</seealso>
        public virtual Task<GetSchemaResponse> GetSchemaAsync(GetSchemaRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSchemaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSchemaResponseUnmarshaller.Instance;

            return InvokeAsync<GetSchemaResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetSchemaByDefinition

        internal virtual GetSchemaByDefinitionResponse GetSchemaByDefinition(GetSchemaByDefinitionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSchemaByDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSchemaByDefinitionResponseUnmarshaller.Instance;

            return Invoke<GetSchemaByDefinitionResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a schema by the <code>SchemaDefinition</code>. The schema definition is
        /// sent to the Schema Registry, canonicalized, and hashed. If the hash is matched within
        /// the scope of the <code>SchemaName</code> or ARN (or the default registry, if none
        /// is supplied), that schema’s metadata is returned. Otherwise, a 404 or NotFound error
        /// is returned. Schema versions in <code>Deleted</code> statuses will not be included
        /// in the results.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSchemaByDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSchemaByDefinition service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.AccessDeniedException">
        /// Access to a resource was denied.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetSchemaByDefinition">REST API Reference for GetSchemaByDefinition Operation</seealso>
        public virtual Task<GetSchemaByDefinitionResponse> GetSchemaByDefinitionAsync(GetSchemaByDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSchemaByDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSchemaByDefinitionResponseUnmarshaller.Instance;

            return InvokeAsync<GetSchemaByDefinitionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetSchemaVersion

        internal virtual GetSchemaVersionResponse GetSchemaVersion(GetSchemaVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSchemaVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSchemaVersionResponseUnmarshaller.Instance;

            return Invoke<GetSchemaVersionResponse>(request, options);
        }



        /// <summary>
        /// Get the specified schema by its unique ID assigned when a version of the schema is
        /// created or registered. Schema versions in Deleted status will not be included in the
        /// results.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSchemaVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSchemaVersion service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.AccessDeniedException">
        /// Access to a resource was denied.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetSchemaVersion">REST API Reference for GetSchemaVersion Operation</seealso>
        public virtual Task<GetSchemaVersionResponse> GetSchemaVersionAsync(GetSchemaVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSchemaVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSchemaVersionResponseUnmarshaller.Instance;

            return InvokeAsync<GetSchemaVersionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetSchemaVersionsDiff

        internal virtual GetSchemaVersionsDiffResponse GetSchemaVersionsDiff(GetSchemaVersionsDiffRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSchemaVersionsDiffRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSchemaVersionsDiffResponseUnmarshaller.Instance;

            return Invoke<GetSchemaVersionsDiffResponse>(request, options);
        }



        /// <summary>
        /// Fetches the schema version difference in the specified difference type between two
        /// stored schema versions in the Schema Registry.
        /// 
        ///  
        /// <para>
        /// This API allows you to compare two schema versions between two schema definitions
        /// under the same schema.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSchemaVersionsDiff service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSchemaVersionsDiff service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.AccessDeniedException">
        /// Access to a resource was denied.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetSchemaVersionsDiff">REST API Reference for GetSchemaVersionsDiff Operation</seealso>
        public virtual Task<GetSchemaVersionsDiffResponse> GetSchemaVersionsDiffAsync(GetSchemaVersionsDiffRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSchemaVersionsDiffRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSchemaVersionsDiffResponseUnmarshaller.Instance;

            return InvokeAsync<GetSchemaVersionsDiffResponse>(request, options, cancellationToken);
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
        /// Retrieves a specified security configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSecurityConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSecurityConfiguration service method, as returned by Glue.</returns>
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
        /// Retrieves a list of all security configurations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSecurityConfigurations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSecurityConfigurations service method, as returned by Glue.</returns>
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
        /// Retrieves the <code>Table</code> definition in a Data Catalog for a specified table.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTable service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTable service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.GlueEncryptionException">
        /// An encryption operation failed.
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
        /// Retrieves the definitions of some or all of the tables in a given <code>Database</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTables service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTables service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.GlueEncryptionException">
        /// An encryption operation failed.
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
        /// Retrieves a specified version of a table.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTableVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTableVersion service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.GlueEncryptionException">
        /// An encryption operation failed.
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
        /// Retrieves a list of strings that identify available versions of a specified table.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTableVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTableVersions service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.GlueEncryptionException">
        /// An encryption operation failed.
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
        public virtual Task<GetTableVersionsResponse> GetTableVersionsAsync(GetTableVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTableVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTableVersionsResponseUnmarshaller.Instance;

            return InvokeAsync<GetTableVersionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetTags

        internal virtual GetTagsResponse GetTags(GetTagsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTagsResponseUnmarshaller.Instance;

            return Invoke<GetTagsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a list of tags associated with a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTags service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTags service method, as returned by Glue.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetTags">REST API Reference for GetTags Operation</seealso>
        public virtual Task<GetTagsResponse> GetTagsAsync(GetTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTagsResponseUnmarshaller.Instance;

            return InvokeAsync<GetTagsResponse>(request, options, cancellationToken);
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
        /// Retrieves the definition of a trigger.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTrigger service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// Gets all the triggers associated with a job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTriggers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// Retrieves a specified function definition from the Data Catalog.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUserDefinedFunction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetUserDefinedFunction service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.GlueEncryptionException">
        /// An encryption operation failed.
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
        /// Retrieves multiple function definitions from the Data Catalog.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUserDefinedFunctions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetUserDefinedFunctions service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.GlueEncryptionException">
        /// An encryption operation failed.
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
        public virtual Task<GetUserDefinedFunctionsResponse> GetUserDefinedFunctionsAsync(GetUserDefinedFunctionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetUserDefinedFunctionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetUserDefinedFunctionsResponseUnmarshaller.Instance;

            return InvokeAsync<GetUserDefinedFunctionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetWorkflow

        internal virtual GetWorkflowResponse GetWorkflow(GetWorkflowRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetWorkflowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWorkflowResponseUnmarshaller.Instance;

            return Invoke<GetWorkflowResponse>(request, options);
        }



        /// <summary>
        /// Retrieves resource metadata for a workflow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWorkflow service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetWorkflow service method, as returned by Glue.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetWorkflow">REST API Reference for GetWorkflow Operation</seealso>
        public virtual Task<GetWorkflowResponse> GetWorkflowAsync(GetWorkflowRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetWorkflowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWorkflowResponseUnmarshaller.Instance;

            return InvokeAsync<GetWorkflowResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetWorkflowRun

        internal virtual GetWorkflowRunResponse GetWorkflowRun(GetWorkflowRunRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetWorkflowRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWorkflowRunResponseUnmarshaller.Instance;

            return Invoke<GetWorkflowRunResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the metadata for a given workflow run.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWorkflowRun service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetWorkflowRun service method, as returned by Glue.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetWorkflowRun">REST API Reference for GetWorkflowRun Operation</seealso>
        public virtual Task<GetWorkflowRunResponse> GetWorkflowRunAsync(GetWorkflowRunRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetWorkflowRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWorkflowRunResponseUnmarshaller.Instance;

            return InvokeAsync<GetWorkflowRunResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetWorkflowRunProperties

        internal virtual GetWorkflowRunPropertiesResponse GetWorkflowRunProperties(GetWorkflowRunPropertiesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetWorkflowRunPropertiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWorkflowRunPropertiesResponseUnmarshaller.Instance;

            return Invoke<GetWorkflowRunPropertiesResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the workflow run properties which were set during the run.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWorkflowRunProperties service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetWorkflowRunProperties service method, as returned by Glue.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetWorkflowRunProperties">REST API Reference for GetWorkflowRunProperties Operation</seealso>
        public virtual Task<GetWorkflowRunPropertiesResponse> GetWorkflowRunPropertiesAsync(GetWorkflowRunPropertiesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetWorkflowRunPropertiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWorkflowRunPropertiesResponseUnmarshaller.Instance;

            return InvokeAsync<GetWorkflowRunPropertiesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetWorkflowRuns

        internal virtual GetWorkflowRunsResponse GetWorkflowRuns(GetWorkflowRunsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetWorkflowRunsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWorkflowRunsResponseUnmarshaller.Instance;

            return Invoke<GetWorkflowRunsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves metadata for all runs of a given workflow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWorkflowRuns service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetWorkflowRuns service method, as returned by Glue.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetWorkflowRuns">REST API Reference for GetWorkflowRuns Operation</seealso>
        public virtual Task<GetWorkflowRunsResponse> GetWorkflowRunsAsync(GetWorkflowRunsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetWorkflowRunsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWorkflowRunsResponseUnmarshaller.Instance;

            return InvokeAsync<GetWorkflowRunsResponse>(request, options, cancellationToken);
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
        /// Imports an existing Amazon Athena Data Catalog to AWS Glue
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportCatalogToGlue service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ImportCatalogToGlue service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/ImportCatalogToGlue">REST API Reference for ImportCatalogToGlue Operation</seealso>
        public virtual Task<ImportCatalogToGlueResponse> ImportCatalogToGlueAsync(ImportCatalogToGlueRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ImportCatalogToGlueRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportCatalogToGlueResponseUnmarshaller.Instance;

            return InvokeAsync<ImportCatalogToGlueResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListCrawlers

        internal virtual ListCrawlersResponse ListCrawlers(ListCrawlersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCrawlersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCrawlersResponseUnmarshaller.Instance;

            return Invoke<ListCrawlersResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the names of all crawler resources in this AWS account, or the resources
        /// with the specified tag. This operation allows you to see which resources are available
        /// in your account, and their names.
        /// 
        ///  
        /// <para>
        /// This operation takes the optional <code>Tags</code> field, which you can use as a
        /// filter on the response so that tagged resources can be retrieved as a group. If you
        /// choose to use tags filtering, only resources with the tag are retrieved.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCrawlers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCrawlers service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/ListCrawlers">REST API Reference for ListCrawlers Operation</seealso>
        public virtual Task<ListCrawlersResponse> ListCrawlersAsync(ListCrawlersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCrawlersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCrawlersResponseUnmarshaller.Instance;

            return InvokeAsync<ListCrawlersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListDevEndpoints

        internal virtual ListDevEndpointsResponse ListDevEndpoints(ListDevEndpointsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDevEndpointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDevEndpointsResponseUnmarshaller.Instance;

            return Invoke<ListDevEndpointsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the names of all <code>DevEndpoint</code> resources in this AWS account,
        /// or the resources with the specified tag. This operation allows you to see which resources
        /// are available in your account, and their names.
        /// 
        ///  
        /// <para>
        /// This operation takes the optional <code>Tags</code> field, which you can use as a
        /// filter on the response so that tagged resources can be retrieved as a group. If you
        /// choose to use tags filtering, only resources with the tag are retrieved.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDevEndpoints service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDevEndpoints service method, as returned by Glue.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/ListDevEndpoints">REST API Reference for ListDevEndpoints Operation</seealso>
        public virtual Task<ListDevEndpointsResponse> ListDevEndpointsAsync(ListDevEndpointsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDevEndpointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDevEndpointsResponseUnmarshaller.Instance;

            return InvokeAsync<ListDevEndpointsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListJobs

        internal virtual ListJobsResponse ListJobs(ListJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListJobsResponseUnmarshaller.Instance;

            return Invoke<ListJobsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the names of all job resources in this AWS account, or the resources with
        /// the specified tag. This operation allows you to see which resources are available
        /// in your account, and their names.
        /// 
        ///  
        /// <para>
        /// This operation takes the optional <code>Tags</code> field, which you can use as a
        /// filter on the response so that tagged resources can be retrieved as a group. If you
        /// choose to use tags filtering, only resources with the tag are retrieved.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListJobs service method, as returned by Glue.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/ListJobs">REST API Reference for ListJobs Operation</seealso>
        public virtual Task<ListJobsResponse> ListJobsAsync(ListJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListJobsResponseUnmarshaller.Instance;

            return InvokeAsync<ListJobsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListMLTransforms

        internal virtual ListMLTransformsResponse ListMLTransforms(ListMLTransformsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListMLTransformsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMLTransformsResponseUnmarshaller.Instance;

            return Invoke<ListMLTransformsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a sortable, filterable list of existing AWS Glue machine learning transforms
        /// in this AWS account, or the resources with the specified tag. This operation takes
        /// the optional <code>Tags</code> field, which you can use as a filter of the responses
        /// so that tagged resources can be retrieved as a group. If you choose to use tag filtering,
        /// only resources with the tags are retrieved.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMLTransforms service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListMLTransforms service method, as returned by Glue.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/ListMLTransforms">REST API Reference for ListMLTransforms Operation</seealso>
        public virtual Task<ListMLTransformsResponse> ListMLTransformsAsync(ListMLTransformsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListMLTransformsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMLTransformsResponseUnmarshaller.Instance;

            return InvokeAsync<ListMLTransformsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListRegistries

        internal virtual ListRegistriesResponse ListRegistries(ListRegistriesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRegistriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRegistriesResponseUnmarshaller.Instance;

            return Invoke<ListRegistriesResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of registries that you have created, with minimal registry information.
        /// Registries in the <code>Deleting</code> status will not be included in the results.
        /// Empty results will be returned if there are no registries available.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRegistries service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRegistries service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.AccessDeniedException">
        /// Access to a resource was denied.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/ListRegistries">REST API Reference for ListRegistries Operation</seealso>
        public virtual Task<ListRegistriesResponse> ListRegistriesAsync(ListRegistriesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRegistriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRegistriesResponseUnmarshaller.Instance;

            return InvokeAsync<ListRegistriesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListSchemas

        internal virtual ListSchemasResponse ListSchemas(ListSchemasRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSchemasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSchemasResponseUnmarshaller.Instance;

            return Invoke<ListSchemasResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of schemas with minimal details. Schemas in Deleting status will not
        /// be included in the results. Empty results will be returned if there are no schemas
        /// available.
        /// 
        ///  
        /// <para>
        /// When the <code>RegistryId</code> is not provided, all the schemas across registries
        /// will be part of the API response.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSchemas service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSchemas service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.AccessDeniedException">
        /// Access to a resource was denied.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/ListSchemas">REST API Reference for ListSchemas Operation</seealso>
        public virtual Task<ListSchemasResponse> ListSchemasAsync(ListSchemasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSchemasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSchemasResponseUnmarshaller.Instance;

            return InvokeAsync<ListSchemasResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListSchemaVersions

        internal virtual ListSchemaVersionsResponse ListSchemaVersions(ListSchemaVersionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSchemaVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSchemaVersionsResponseUnmarshaller.Instance;

            return Invoke<ListSchemaVersionsResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of schema versions that you have created, with minimal information.
        /// Schema versions in Deleted status will not be included in the results. Empty results
        /// will be returned if there are no schema versions available.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSchemaVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSchemaVersions service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.AccessDeniedException">
        /// Access to a resource was denied.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/ListSchemaVersions">REST API Reference for ListSchemaVersions Operation</seealso>
        public virtual Task<ListSchemaVersionsResponse> ListSchemaVersionsAsync(ListSchemaVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSchemaVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSchemaVersionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListSchemaVersionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTriggers

        internal virtual ListTriggersResponse ListTriggers(ListTriggersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTriggersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTriggersResponseUnmarshaller.Instance;

            return Invoke<ListTriggersResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the names of all trigger resources in this AWS account, or the resources
        /// with the specified tag. This operation allows you to see which resources are available
        /// in your account, and their names.
        /// 
        ///  
        /// <para>
        /// This operation takes the optional <code>Tags</code> field, which you can use as a
        /// filter on the response so that tagged resources can be retrieved as a group. If you
        /// choose to use tags filtering, only resources with the tag are retrieved.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTriggers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTriggers service method, as returned by Glue.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/ListTriggers">REST API Reference for ListTriggers Operation</seealso>
        public virtual Task<ListTriggersResponse> ListTriggersAsync(ListTriggersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTriggersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTriggersResponseUnmarshaller.Instance;

            return InvokeAsync<ListTriggersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListWorkflows

        internal virtual ListWorkflowsResponse ListWorkflows(ListWorkflowsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListWorkflowsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWorkflowsResponseUnmarshaller.Instance;

            return Invoke<ListWorkflowsResponse>(request, options);
        }



        /// <summary>
        /// Lists names of workflows created in the account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorkflows service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListWorkflows service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/ListWorkflows">REST API Reference for ListWorkflows Operation</seealso>
        public virtual Task<ListWorkflowsResponse> ListWorkflowsAsync(ListWorkflowsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListWorkflowsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWorkflowsResponseUnmarshaller.Instance;

            return InvokeAsync<ListWorkflowsResponse>(request, options, cancellationToken);
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
        /// Sets the security configuration for a specified catalog. After the configuration has
        /// been set, the specified encryption is applied to every catalog write thereafter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutDataCatalogEncryptionSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutDataCatalogEncryptionSettings service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
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
        /// Sets the Data Catalog resource policy for access control.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutResourcePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutResourcePolicy service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.ConditionCheckFailureException">
        /// A specified condition was not satisfied.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/PutResourcePolicy">REST API Reference for PutResourcePolicy Operation</seealso>
        public virtual Task<PutResourcePolicyResponse> PutResourcePolicyAsync(PutResourcePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutResourcePolicyResponseUnmarshaller.Instance;

            return InvokeAsync<PutResourcePolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutSchemaVersionMetadata

        internal virtual PutSchemaVersionMetadataResponse PutSchemaVersionMetadata(PutSchemaVersionMetadataRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutSchemaVersionMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutSchemaVersionMetadataResponseUnmarshaller.Instance;

            return Invoke<PutSchemaVersionMetadataResponse>(request, options);
        }



        /// <summary>
        /// Puts the metadata key value pair for a specified schema version ID. A maximum of 10
        /// key value pairs will be allowed per schema version. They can be added over one or
        /// more calls.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutSchemaVersionMetadata service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutSchemaVersionMetadata service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.AccessDeniedException">
        /// Access to a resource was denied.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.AlreadyExistsException">
        /// A resource to be created or added already exists.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.ResourceNumberLimitExceededException">
        /// A resource numerical limit was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/PutSchemaVersionMetadata">REST API Reference for PutSchemaVersionMetadata Operation</seealso>
        public virtual Task<PutSchemaVersionMetadataResponse> PutSchemaVersionMetadataAsync(PutSchemaVersionMetadataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutSchemaVersionMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutSchemaVersionMetadataResponseUnmarshaller.Instance;

            return InvokeAsync<PutSchemaVersionMetadataResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutWorkflowRunProperties

        internal virtual PutWorkflowRunPropertiesResponse PutWorkflowRunProperties(PutWorkflowRunPropertiesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutWorkflowRunPropertiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutWorkflowRunPropertiesResponseUnmarshaller.Instance;

            return Invoke<PutWorkflowRunPropertiesResponse>(request, options);
        }



        /// <summary>
        /// Puts the specified workflow run properties for the given workflow run. If a property
        /// already exists for the specified run, then it overrides the value otherwise adds the
        /// property to existing properties.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutWorkflowRunProperties service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutWorkflowRunProperties service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.AlreadyExistsException">
        /// A resource to be created or added already exists.
        /// </exception>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/PutWorkflowRunProperties">REST API Reference for PutWorkflowRunProperties Operation</seealso>
        public virtual Task<PutWorkflowRunPropertiesResponse> PutWorkflowRunPropertiesAsync(PutWorkflowRunPropertiesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutWorkflowRunPropertiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutWorkflowRunPropertiesResponseUnmarshaller.Instance;

            return InvokeAsync<PutWorkflowRunPropertiesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  QuerySchemaVersionMetadata

        internal virtual QuerySchemaVersionMetadataResponse QuerySchemaVersionMetadata(QuerySchemaVersionMetadataRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = QuerySchemaVersionMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = QuerySchemaVersionMetadataResponseUnmarshaller.Instance;

            return Invoke<QuerySchemaVersionMetadataResponse>(request, options);
        }



        /// <summary>
        /// Queries for the schema version metadata information.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the QuerySchemaVersionMetadata service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the QuerySchemaVersionMetadata service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.AccessDeniedException">
        /// Access to a resource was denied.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/QuerySchemaVersionMetadata">REST API Reference for QuerySchemaVersionMetadata Operation</seealso>
        public virtual Task<QuerySchemaVersionMetadataResponse> QuerySchemaVersionMetadataAsync(QuerySchemaVersionMetadataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = QuerySchemaVersionMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = QuerySchemaVersionMetadataResponseUnmarshaller.Instance;

            return InvokeAsync<QuerySchemaVersionMetadataResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RegisterSchemaVersion

        internal virtual RegisterSchemaVersionResponse RegisterSchemaVersion(RegisterSchemaVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterSchemaVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterSchemaVersionResponseUnmarshaller.Instance;

            return Invoke<RegisterSchemaVersionResponse>(request, options);
        }



        /// <summary>
        /// Adds a new version to the existing schema. Returns an error if new version of schema
        /// does not meet the compatibility requirements of the schema set. This API will not
        /// create a new schema set and will return a 404 error if the schema set is not already
        /// present in the Schema Registry.
        /// 
        ///  
        /// <para>
        /// If this is the first schema definition to be registered in the Schema Registry, this
        /// API will store the schema version and return immediately. Otherwise, this call has
        /// the potential to run longer than other operations due to compatibility modes. You
        /// can call the <code>GetSchemaVersion</code> API with the <code>SchemaVersionId</code>
        /// to check compatibility modes.
        /// </para>
        ///  
        /// <para>
        /// If the same schema definition is already stored in Schema Registry as a version, the
        /// schema ID of the existing schema is returned to the caller.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterSchemaVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RegisterSchemaVersion service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.AccessDeniedException">
        /// Access to a resource was denied.
        /// </exception>
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
        /// <exception cref="Amazon.Glue.Model.ResourceNumberLimitExceededException">
        /// A resource numerical limit was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/RegisterSchemaVersion">REST API Reference for RegisterSchemaVersion Operation</seealso>
        public virtual Task<RegisterSchemaVersionResponse> RegisterSchemaVersionAsync(RegisterSchemaVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterSchemaVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterSchemaVersionResponseUnmarshaller.Instance;

            return InvokeAsync<RegisterSchemaVersionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RemoveSchemaVersionMetadata

        internal virtual RemoveSchemaVersionMetadataResponse RemoveSchemaVersionMetadata(RemoveSchemaVersionMetadataRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveSchemaVersionMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveSchemaVersionMetadataResponseUnmarshaller.Instance;

            return Invoke<RemoveSchemaVersionMetadataResponse>(request, options);
        }



        /// <summary>
        /// Removes a key value pair from the schema version metadata for the specified schema
        /// version ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveSchemaVersionMetadata service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RemoveSchemaVersionMetadata service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.AccessDeniedException">
        /// Access to a resource was denied.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/RemoveSchemaVersionMetadata">REST API Reference for RemoveSchemaVersionMetadata Operation</seealso>
        public virtual Task<RemoveSchemaVersionMetadataResponse> RemoveSchemaVersionMetadataAsync(RemoveSchemaVersionMetadataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveSchemaVersionMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveSchemaVersionMetadataResponseUnmarshaller.Instance;

            return InvokeAsync<RemoveSchemaVersionMetadataResponse>(request, options, cancellationToken);
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
        /// Resets a bookmark entry.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResetJobBookmark service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ResetJobBookmarkResponse> ResetJobBookmarkAsync(ResetJobBookmarkRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ResetJobBookmarkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResetJobBookmarkResponseUnmarshaller.Instance;

            return InvokeAsync<ResetJobBookmarkResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ResumeWorkflowRun

        internal virtual ResumeWorkflowRunResponse ResumeWorkflowRun(ResumeWorkflowRunRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ResumeWorkflowRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResumeWorkflowRunResponseUnmarshaller.Instance;

            return Invoke<ResumeWorkflowRunResponse>(request, options);
        }



        /// <summary>
        /// Restarts selected nodes of a previous partially completed workflow run and resumes
        /// the workflow run. The selected nodes and all nodes that are downstream from the selected
        /// nodes are run.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResumeWorkflowRun service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ResumeWorkflowRun service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.ConcurrentRunsExceededException">
        /// Too many jobs are being run concurrently.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.IllegalWorkflowStateException">
        /// The workflow is in an invalid state to perform a requested operation.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/ResumeWorkflowRun">REST API Reference for ResumeWorkflowRun Operation</seealso>
        public virtual Task<ResumeWorkflowRunResponse> ResumeWorkflowRunAsync(ResumeWorkflowRunRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ResumeWorkflowRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResumeWorkflowRunResponseUnmarshaller.Instance;

            return InvokeAsync<ResumeWorkflowRunResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SearchTables

        internal virtual SearchTablesResponse SearchTables(SearchTablesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchTablesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchTablesResponseUnmarshaller.Instance;

            return Invoke<SearchTablesResponse>(request, options);
        }



        /// <summary>
        /// Searches a set of tables based on properties in the table metadata as well as on the
        /// parent database. You can search against text or filter conditions. 
        /// 
        ///  
        /// <para>
        /// You can only get tables that you have access to based on the security policies defined
        /// in Lake Formation. You need at least a read-only access to the table for it to be
        /// returned. If you do not have access to all the columns in the table, these columns
        /// will not be searched against when returning the list of tables back to you. If you
        /// have access to the columns but not the data in the columns, those columns and the
        /// associated metadata for those columns will be included in the search. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchTables service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SearchTables service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/SearchTables">REST API Reference for SearchTables Operation</seealso>
        public virtual Task<SearchTablesResponse> SearchTablesAsync(SearchTablesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchTablesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchTablesResponseUnmarshaller.Instance;

            return InvokeAsync<SearchTablesResponse>(request, options, cancellationToken);
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
        /// Starts a crawl using the specified crawler, regardless of what is scheduled. If the
        /// crawler is already running, returns a <a href="https://docs.aws.amazon.com/glue/latest/dg/aws-glue-api-exceptions.html#aws-glue-api-exceptions-CrawlerRunningException">CrawlerRunningException</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartCrawler service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// Changes the schedule state of the specified crawler to <code>SCHEDULED</code>, unless
        /// the crawler is already running or the schedule state is already <code>SCHEDULED</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartCrawlerSchedule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<StartCrawlerScheduleResponse> StartCrawlerScheduleAsync(StartCrawlerScheduleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartCrawlerScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartCrawlerScheduleResponseUnmarshaller.Instance;

            return InvokeAsync<StartCrawlerScheduleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartExportLabelsTaskRun

        internal virtual StartExportLabelsTaskRunResponse StartExportLabelsTaskRun(StartExportLabelsTaskRunRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartExportLabelsTaskRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartExportLabelsTaskRunResponseUnmarshaller.Instance;

            return Invoke<StartExportLabelsTaskRunResponse>(request, options);
        }



        /// <summary>
        /// Begins an asynchronous task to export all labeled data for a particular transform.
        /// This task is the only label-related API call that is not part of the typical active
        /// learning workflow. You typically use <code>StartExportLabelsTaskRun</code> when you
        /// want to work with all of your existing labels at the same time, such as when you want
        /// to remove or change labels that were previously submitted as truth. This API operation
        /// accepts the <code>TransformId</code> whose labels you want to export and an Amazon
        /// Simple Storage Service (Amazon S3) path to export the labels to. The operation returns
        /// a <code>TaskRunId</code>. You can check on the status of your task run by calling
        /// the <code>GetMLTaskRun</code> API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartExportLabelsTaskRun service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartExportLabelsTaskRun service method, as returned by Glue.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/StartExportLabelsTaskRun">REST API Reference for StartExportLabelsTaskRun Operation</seealso>
        public virtual Task<StartExportLabelsTaskRunResponse> StartExportLabelsTaskRunAsync(StartExportLabelsTaskRunRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartExportLabelsTaskRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartExportLabelsTaskRunResponseUnmarshaller.Instance;

            return InvokeAsync<StartExportLabelsTaskRunResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartImportLabelsTaskRun

        internal virtual StartImportLabelsTaskRunResponse StartImportLabelsTaskRun(StartImportLabelsTaskRunRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartImportLabelsTaskRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartImportLabelsTaskRunResponseUnmarshaller.Instance;

            return Invoke<StartImportLabelsTaskRunResponse>(request, options);
        }



        /// <summary>
        /// Enables you to provide additional labels (examples of truth) to be used to teach the
        /// machine learning transform and improve its quality. This API operation is generally
        /// used as part of the active learning workflow that starts with the <code>StartMLLabelingSetGenerationTaskRun</code>
        /// call and that ultimately results in improving the quality of your machine learning
        /// transform. 
        /// 
        ///  
        /// <para>
        /// After the <code>StartMLLabelingSetGenerationTaskRun</code> finishes, AWS Glue machine
        /// learning will have generated a series of questions for humans to answer. (Answering
        /// these questions is often called 'labeling' in the machine learning workflows). In
        /// the case of the <code>FindMatches</code> transform, these questions are of the form,
        /// “What is the correct way to group these rows together into groups composed entirely
        /// of matching records?” After the labeling process is finished, users upload their answers/labels
        /// with a call to <code>StartImportLabelsTaskRun</code>. After <code>StartImportLabelsTaskRun</code>
        /// finishes, all future runs of the machine learning transform use the new and improved
        /// labels and perform a higher-quality transformation.
        /// </para>
        ///  
        /// <para>
        /// By default, <code>StartMLLabelingSetGenerationTaskRun</code> continually learns from
        /// and combines all labels that you upload unless you set <code>Replace</code> to true.
        /// If you set <code>Replace</code> to true, <code>StartImportLabelsTaskRun</code> deletes
        /// and forgets all previously uploaded labels and learns only from the exact set that
        /// you upload. Replacing labels can be helpful if you realize that you previously uploaded
        /// incorrect labels, and you believe that they are having a negative effect on your transform
        /// quality.
        /// </para>
        ///  
        /// <para>
        /// You can check on the status of your task run by calling the <code>GetMLTaskRun</code>
        /// operation. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartImportLabelsTaskRun service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartImportLabelsTaskRun service method, as returned by Glue.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/StartImportLabelsTaskRun">REST API Reference for StartImportLabelsTaskRun Operation</seealso>
        public virtual Task<StartImportLabelsTaskRunResponse> StartImportLabelsTaskRunAsync(StartImportLabelsTaskRunRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartImportLabelsTaskRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartImportLabelsTaskRunResponseUnmarshaller.Instance;

            return InvokeAsync<StartImportLabelsTaskRunResponse>(request, options, cancellationToken);
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
        /// Starts a job run using a job definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartJobRun service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<StartJobRunResponse> StartJobRunAsync(StartJobRunRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartJobRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartJobRunResponseUnmarshaller.Instance;

            return InvokeAsync<StartJobRunResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartMLEvaluationTaskRun

        internal virtual StartMLEvaluationTaskRunResponse StartMLEvaluationTaskRun(StartMLEvaluationTaskRunRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartMLEvaluationTaskRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartMLEvaluationTaskRunResponseUnmarshaller.Instance;

            return Invoke<StartMLEvaluationTaskRunResponse>(request, options);
        }



        /// <summary>
        /// Starts a task to estimate the quality of the transform. 
        /// 
        ///  
        /// <para>
        /// When you provide label sets as examples of truth, AWS Glue machine learning uses some
        /// of those examples to learn from them. The rest of the labels are used as a test to
        /// estimate quality.
        /// </para>
        ///  
        /// <para>
        /// Returns a unique identifier for the run. You can call <code>GetMLTaskRun</code> to
        /// get more information about the stats of the <code>EvaluationTaskRun</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartMLEvaluationTaskRun service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartMLEvaluationTaskRun service method, as returned by Glue.</returns>
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
        /// <exception cref="Amazon.Glue.Model.MLTransformNotReadyException">
        /// The machine learning transform is not ready to run.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/StartMLEvaluationTaskRun">REST API Reference for StartMLEvaluationTaskRun Operation</seealso>
        public virtual Task<StartMLEvaluationTaskRunResponse> StartMLEvaluationTaskRunAsync(StartMLEvaluationTaskRunRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartMLEvaluationTaskRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartMLEvaluationTaskRunResponseUnmarshaller.Instance;

            return InvokeAsync<StartMLEvaluationTaskRunResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartMLLabelingSetGenerationTaskRun

        internal virtual StartMLLabelingSetGenerationTaskRunResponse StartMLLabelingSetGenerationTaskRun(StartMLLabelingSetGenerationTaskRunRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartMLLabelingSetGenerationTaskRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartMLLabelingSetGenerationTaskRunResponseUnmarshaller.Instance;

            return Invoke<StartMLLabelingSetGenerationTaskRunResponse>(request, options);
        }



        /// <summary>
        /// Starts the active learning workflow for your machine learning transform to improve
        /// the transform's quality by generating label sets and adding labels.
        /// 
        ///  
        /// <para>
        /// When the <code>StartMLLabelingSetGenerationTaskRun</code> finishes, AWS Glue will
        /// have generated a "labeling set" or a set of questions for humans to answer.
        /// </para>
        ///  
        /// <para>
        /// In the case of the <code>FindMatches</code> transform, these questions are of the
        /// form, “What is the correct way to group these rows together into groups composed entirely
        /// of matching records?” 
        /// </para>
        ///  
        /// <para>
        /// After the labeling process is finished, you can upload your labels with a call to
        /// <code>StartImportLabelsTaskRun</code>. After <code>StartImportLabelsTaskRun</code>
        /// finishes, all future runs of the machine learning transform will use the new and improved
        /// labels and perform a higher-quality transformation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartMLLabelingSetGenerationTaskRun service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartMLLabelingSetGenerationTaskRun service method, as returned by Glue.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/StartMLLabelingSetGenerationTaskRun">REST API Reference for StartMLLabelingSetGenerationTaskRun Operation</seealso>
        public virtual Task<StartMLLabelingSetGenerationTaskRunResponse> StartMLLabelingSetGenerationTaskRunAsync(StartMLLabelingSetGenerationTaskRunRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartMLLabelingSetGenerationTaskRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartMLLabelingSetGenerationTaskRunResponseUnmarshaller.Instance;

            return InvokeAsync<StartMLLabelingSetGenerationTaskRunResponse>(request, options, cancellationToken);
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
        /// Starts an existing trigger. See <a href="https://docs.aws.amazon.com/glue/latest/dg/trigger-job.html">Triggering
        /// Jobs</a> for information about how different types of trigger are started.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartTrigger service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<StartTriggerResponse> StartTriggerAsync(StartTriggerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartTriggerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartTriggerResponseUnmarshaller.Instance;

            return InvokeAsync<StartTriggerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartWorkflowRun

        internal virtual StartWorkflowRunResponse StartWorkflowRun(StartWorkflowRunRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartWorkflowRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartWorkflowRunResponseUnmarshaller.Instance;

            return Invoke<StartWorkflowRunResponse>(request, options);
        }



        /// <summary>
        /// Starts a new run of the specified workflow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartWorkflowRun service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartWorkflowRun service method, as returned by Glue.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/StartWorkflowRun">REST API Reference for StartWorkflowRun Operation</seealso>
        public virtual Task<StartWorkflowRunResponse> StartWorkflowRunAsync(StartWorkflowRunRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartWorkflowRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartWorkflowRunResponseUnmarshaller.Instance;

            return InvokeAsync<StartWorkflowRunResponse>(request, options, cancellationToken);
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
        /// If the specified crawler is running, stops the crawl.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopCrawler service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// Sets the schedule state of the specified crawler to <code>NOT_SCHEDULED</code>, but
        /// does not stop the crawler if it is already running.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopCrawlerSchedule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// Stops a specified trigger.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopTrigger service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<StopTriggerResponse> StopTriggerAsync(StopTriggerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopTriggerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopTriggerResponseUnmarshaller.Instance;

            return InvokeAsync<StopTriggerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StopWorkflowRun

        internal virtual StopWorkflowRunResponse StopWorkflowRun(StopWorkflowRunRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopWorkflowRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopWorkflowRunResponseUnmarshaller.Instance;

            return Invoke<StopWorkflowRunResponse>(request, options);
        }



        /// <summary>
        /// Stops the execution of the specified workflow run.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopWorkflowRun service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopWorkflowRun service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.IllegalWorkflowStateException">
        /// The workflow is in an invalid state to perform a requested operation.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/StopWorkflowRun">REST API Reference for StopWorkflowRun Operation</seealso>
        public virtual Task<StopWorkflowRunResponse> StopWorkflowRunAsync(StopWorkflowRunRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopWorkflowRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopWorkflowRunResponseUnmarshaller.Instance;

            return InvokeAsync<StopWorkflowRunResponse>(request, options, cancellationToken);
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
        /// Adds tags to a resource. A tag is a label you can assign to an AWS resource. In AWS
        /// Glue, you can tag only certain resources. For information about what resources you
        /// can tag, see <a href="https://docs.aws.amazon.com/glue/latest/dg/monitor-tags.html">AWS
        /// Tags in AWS Glue</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Glue.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// Removes tags from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Glue.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
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
        /// Modifies an existing classifier (a <code>GrokClassifier</code>, an <code>XMLClassifier</code>,
        /// a <code>JsonClassifier</code>, or a <code>CsvClassifier</code>, depending on which
        /// field is present).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateClassifier service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UpdateClassifierResponse> UpdateClassifierAsync(UpdateClassifierRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateClassifierRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateClassifierResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateClassifierResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateColumnStatisticsForPartition

        internal virtual UpdateColumnStatisticsForPartitionResponse UpdateColumnStatisticsForPartition(UpdateColumnStatisticsForPartitionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateColumnStatisticsForPartitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateColumnStatisticsForPartitionResponseUnmarshaller.Instance;

            return Invoke<UpdateColumnStatisticsForPartitionResponse>(request, options);
        }



        /// <summary>
        /// Creates or updates partition statistics of columns.
        /// 
        ///  
        /// <para>
        /// The Identity and Access Management (IAM) permission required for this operation is
        /// <code>UpdatePartition</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateColumnStatisticsForPartition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateColumnStatisticsForPartition service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.GlueEncryptionException">
        /// An encryption operation failed.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UpdateColumnStatisticsForPartition">REST API Reference for UpdateColumnStatisticsForPartition Operation</seealso>
        public virtual Task<UpdateColumnStatisticsForPartitionResponse> UpdateColumnStatisticsForPartitionAsync(UpdateColumnStatisticsForPartitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateColumnStatisticsForPartitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateColumnStatisticsForPartitionResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateColumnStatisticsForPartitionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateColumnStatisticsForTable

        internal virtual UpdateColumnStatisticsForTableResponse UpdateColumnStatisticsForTable(UpdateColumnStatisticsForTableRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateColumnStatisticsForTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateColumnStatisticsForTableResponseUnmarshaller.Instance;

            return Invoke<UpdateColumnStatisticsForTableResponse>(request, options);
        }



        /// <summary>
        /// Creates or updates table statistics of columns.
        /// 
        ///  
        /// <para>
        /// The Identity and Access Management (IAM) permission required for this operation is
        /// <code>UpdateTable</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateColumnStatisticsForTable service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateColumnStatisticsForTable service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.GlueEncryptionException">
        /// An encryption operation failed.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UpdateColumnStatisticsForTable">REST API Reference for UpdateColumnStatisticsForTable Operation</seealso>
        public virtual Task<UpdateColumnStatisticsForTableResponse> UpdateColumnStatisticsForTableAsync(UpdateColumnStatisticsForTableRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateColumnStatisticsForTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateColumnStatisticsForTableResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateColumnStatisticsForTableResponse>(request, options, cancellationToken);
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
        /// Updates a connection definition in the Data Catalog.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateConnection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateConnection service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.GlueEncryptionException">
        /// An encryption operation failed.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
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
        /// Updates a crawler. If a crawler is running, you must stop it using <code>StopCrawler</code>
        /// before updating it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCrawler service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// Updates the schedule of a crawler using a <code>cron</code> expression.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCrawlerSchedule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// Updates an existing database definition in a Data Catalog.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDatabase service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDatabase service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.GlueEncryptionException">
        /// An encryption operation failed.
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
        /// Updates a specified development endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDevEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// Updates an existing job definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UpdateJobResponse> UpdateJobAsync(UpdateJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateJobResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateMLTransform

        internal virtual UpdateMLTransformResponse UpdateMLTransform(UpdateMLTransformRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateMLTransformRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateMLTransformResponseUnmarshaller.Instance;

            return Invoke<UpdateMLTransformResponse>(request, options);
        }



        /// <summary>
        /// Updates an existing machine learning transform. Call this operation to tune the algorithm
        /// parameters to achieve better results.
        /// 
        ///  
        /// <para>
        /// After calling this operation, you can call the <code>StartMLEvaluationTaskRun</code>
        /// operation to assess how well your new parameters achieved your goals (such as improving
        /// the quality of your machine learning transform, or making it more cost-effective).
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMLTransform service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateMLTransform service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.AccessDeniedException">
        /// Access to a resource was denied.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UpdateMLTransform">REST API Reference for UpdateMLTransform Operation</seealso>
        public virtual Task<UpdateMLTransformResponse> UpdateMLTransformAsync(UpdateMLTransformRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateMLTransformRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateMLTransformResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateMLTransformResponse>(request, options, cancellationToken);
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
        /// Updates a partition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePartition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdatePartition service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.GlueEncryptionException">
        /// An encryption operation failed.
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
        public virtual Task<UpdatePartitionResponse> UpdatePartitionAsync(UpdatePartitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdatePartitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePartitionResponseUnmarshaller.Instance;

            return InvokeAsync<UpdatePartitionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateRegistry

        internal virtual UpdateRegistryResponse UpdateRegistry(UpdateRegistryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateRegistryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRegistryResponseUnmarshaller.Instance;

            return Invoke<UpdateRegistryResponse>(request, options);
        }



        /// <summary>
        /// Updates an existing registry which is used to hold a collection of schemas. The updated
        /// properties relate to the registry, and do not modify any of the schemas within the
        /// registry.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRegistry service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateRegistry service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.AccessDeniedException">
        /// Access to a resource was denied.
        /// </exception>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UpdateRegistry">REST API Reference for UpdateRegistry Operation</seealso>
        public virtual Task<UpdateRegistryResponse> UpdateRegistryAsync(UpdateRegistryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateRegistryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRegistryResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateRegistryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateSchema

        internal virtual UpdateSchemaResponse UpdateSchema(UpdateSchemaRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSchemaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSchemaResponseUnmarshaller.Instance;

            return Invoke<UpdateSchemaResponse>(request, options);
        }



        /// <summary>
        /// Updates the description, compatibility setting, or version checkpoint for a schema
        /// set.
        /// 
        ///  
        /// <para>
        /// For updating the compatibility setting, the call will not validate compatibility for
        /// the entire set of schema versions with the new compatibility setting. If the value
        /// for <code>Compatibility</code> is provided, the <code>VersionNumber</code> (a checkpoint)
        /// is also required. The API will validate the checkpoint version number for consistency.
        /// </para>
        ///  
        /// <para>
        /// If the value for the <code>VersionNumber</code> (checkpoint) is provided, <code>Compatibility</code>
        /// is optional and this can be used to set/reset a checkpoint for the schema.
        /// </para>
        ///  
        /// <para>
        /// This update will happen only if the schema is in the AVAILABLE state.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSchema service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateSchema service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.AccessDeniedException">
        /// Access to a resource was denied.
        /// </exception>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UpdateSchema">REST API Reference for UpdateSchema Operation</seealso>
        public virtual Task<UpdateSchemaResponse> UpdateSchemaAsync(UpdateSchemaRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSchemaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSchemaResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateSchemaResponse>(request, options, cancellationToken);
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
        /// Updates a metadata table in the Data Catalog.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTable service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateTable service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.ConcurrentModificationException">
        /// Two processes are trying to modify a resource simultaneously.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.GlueEncryptionException">
        /// An encryption operation failed.
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
        /// Updates a trigger definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTrigger service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// Updates an existing function definition in the Data Catalog.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateUserDefinedFunction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateUserDefinedFunction service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.GlueEncryptionException">
        /// An encryption operation failed.
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
        public virtual Task<UpdateUserDefinedFunctionResponse> UpdateUserDefinedFunctionAsync(UpdateUserDefinedFunctionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateUserDefinedFunctionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateUserDefinedFunctionResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateUserDefinedFunctionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateWorkflow

        internal virtual UpdateWorkflowResponse UpdateWorkflow(UpdateWorkflowRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateWorkflowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateWorkflowResponseUnmarshaller.Instance;

            return Invoke<UpdateWorkflowResponse>(request, options);
        }



        /// <summary>
        /// Updates an existing workflow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorkflow service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateWorkflow service method, as returned by Glue.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UpdateWorkflow">REST API Reference for UpdateWorkflow Operation</seealso>
        public virtual Task<UpdateWorkflowResponse> UpdateWorkflowAsync(UpdateWorkflowRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateWorkflowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateWorkflowResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateWorkflowResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}