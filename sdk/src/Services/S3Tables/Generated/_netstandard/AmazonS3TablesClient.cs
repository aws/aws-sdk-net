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
 * Do not modify this file. This file is generated from the s3tables-2018-05-10.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.S3Tables.Model;
using Amazon.S3Tables.Model.Internal.MarshallTransformations;
using Amazon.S3Tables.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.S3Tables
{
    /// <summary>
    /// <para>Implementation for accessing S3Tables</para>
    ///
    /// An Amazon S3 table represents a structured dataset consisting of tabular data in <a
    /// href="https://parquet.apache.org/docs/">Apache Parquet</a> format and related metadata.
    /// This data is stored inside an S3 table as a subresource. All tables in a table bucket
    /// are stored in the <a href="https://iceberg.apache.org/docs/latest/">Apache Iceberg</a>
    /// table format. Through integration with the <a href="https://docs.aws.amazon.com/https:/docs.aws.amazon.com/glue/latest/dg/catalog-and-crawler.html">Amazon
    /// Web Services Glue Data Catalog</a> you can interact with your tables using Amazon
    /// Web Services analytics services, such as <a href="https://docs.aws.amazon.com/https:/docs.aws.amazon.com/athena/">Amazon
    /// Athena</a> and <a href="https://docs.aws.amazon.com/https:/docs.aws.amazon.com/redshift/">Amazon
    /// Redshift</a>. Amazon S3 manages maintenance of your tables through automatic file
    /// compaction and snapshot management. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-tables-buckets.html">Amazon
    /// S3 table buckets</a>.
    /// </summary>
    public partial class AmazonS3TablesClient : AmazonServiceClient, IAmazonS3Tables
    {
        private static IServiceMetadata serviceMetadata = new AmazonS3TablesMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonS3TablesClient with the credentials loaded from the application's
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
        public AmazonS3TablesClient()
            : base(new AmazonS3TablesConfig()) { }

        /// <summary>
        /// Constructs AmazonS3TablesClient with the credentials loaded from the application's
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
        public AmazonS3TablesClient(RegionEndpoint region)
            : base(new AmazonS3TablesConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonS3TablesClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonS3TablesClient Configuration Object</param>
        public AmazonS3TablesClient(AmazonS3TablesConfig config)
            : base(config) { }


        /// <summary>
        /// Constructs AmazonS3TablesClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonS3TablesClient(AWSCredentials credentials)
            : this(credentials, new AmazonS3TablesConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonS3TablesClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonS3TablesClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonS3TablesConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonS3TablesClient with AWS Credentials and an
        /// AmazonS3TablesClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonS3TablesClient Configuration Object</param>
        public AmazonS3TablesClient(AWSCredentials credentials, AmazonS3TablesConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonS3TablesClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonS3TablesClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonS3TablesConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonS3TablesClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonS3TablesClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonS3TablesConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonS3TablesClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonS3TablesClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonS3TablesClient Configuration Object</param>
        public AmazonS3TablesClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonS3TablesConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonS3TablesClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonS3TablesClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonS3TablesConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonS3TablesClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonS3TablesClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonS3TablesConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonS3TablesClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonS3TablesClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonS3TablesClient Configuration Object</param>
        public AmazonS3TablesClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonS3TablesConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private IS3TablesPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IS3TablesPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new S3TablesPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif

        #region Overrides

        /// <summary>
        /// Customizes the runtime pipeline.
        /// </summary>
        /// <param name="pipeline">Runtime pipeline for the current client.</param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonS3TablesEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonS3TablesAuthSchemeHandler());
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


        #region  CreateNamespace

        internal virtual CreateNamespaceResponse CreateNamespace(CreateNamespaceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateNamespaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateNamespaceResponseUnmarshaller.Instance;

            return Invoke<CreateNamespaceResponse>(request, options);
        }



        /// <summary>
        /// Creates a namespace. A namespace is a logical grouping of tables within your table
        /// bucket, which you can use to organize tables. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-tables-namespace-create.html">Create
        /// a namespace</a> in the <i>Amazon Simple Storage Service User Guide</i>.
        /// 
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3tables:CreateNamespace</c> permission to use this operation.
        /// 
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateNamespace service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateNamespace service method, as returned by S3Tables.</returns>
        /// <exception cref="Amazon.S3Tables.Model.BadRequestException">
        /// The request is invalid or malformed.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ConflictException">
        /// The request failed because there is a conflict with a previous write. You can retry
        /// the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ForbiddenException">
        /// The caller isn't authorized to make the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.InternalServerErrorException">
        /// The request failed due to an internal server error.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.NotFoundException">
        /// The request was rejected because the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.TooManyRequestsException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/CreateNamespace">REST API Reference for CreateNamespace Operation</seealso>
        public virtual Task<CreateNamespaceResponse> CreateNamespaceAsync(CreateNamespaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateNamespaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateNamespaceResponseUnmarshaller.Instance;

            return InvokeAsync<CreateNamespaceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateTable

        internal virtual CreateTableResponse CreateTable(CreateTableRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTableResponseUnmarshaller.Instance;

            return Invoke<CreateTableResponse>(request, options);
        }



        /// <summary>
        /// Creates a new table associated with the given namespace in a table bucket. For more
        /// information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-tables-create.html">Creating
        /// an Amazon S3 table</a> in the <i>Amazon Simple Storage Service User Guide</i>.
        /// 
        ///  <dl> <dt>Permissions</dt> <dd> <ul> <li> 
        /// <para>
        /// You must have the <c>s3tables:CreateTable</c> permission to use this operation. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you use this operation with the optional <c>metadata</c> request parameter you
        /// must have the <c>s3tables:PutTableData</c> permission. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you use this operation with the optional <c>encryptionConfiguration</c> request
        /// parameter you must have the <c>s3tables:PutTableEncryption</c> permission. 
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// Additionally, If you choose SSE-KMS encryption you must grant the S3 Tables maintenance
        /// principal access to your KMS key. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-tables-kms-permissions.html">Permissions
        /// requirements for S3 Tables SSE-KMS encryption</a>. 
        /// </para>
        ///  </note> </dd> </dl>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTable service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateTable service method, as returned by S3Tables.</returns>
        /// <exception cref="Amazon.S3Tables.Model.BadRequestException">
        /// The request is invalid or malformed.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ConflictException">
        /// The request failed because there is a conflict with a previous write. You can retry
        /// the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ForbiddenException">
        /// The caller isn't authorized to make the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.InternalServerErrorException">
        /// The request failed due to an internal server error.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.NotFoundException">
        /// The request was rejected because the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.TooManyRequestsException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/CreateTable">REST API Reference for CreateTable Operation</seealso>
        public virtual Task<CreateTableResponse> CreateTableAsync(CreateTableRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTableResponseUnmarshaller.Instance;

            return InvokeAsync<CreateTableResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateTableBucket

        internal virtual CreateTableBucketResponse CreateTableBucket(CreateTableBucketRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateTableBucketRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTableBucketResponseUnmarshaller.Instance;

            return Invoke<CreateTableBucketResponse>(request, options);
        }



        /// <summary>
        /// Creates a table bucket. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-tables-buckets-create.html">Creating
        /// a table bucket</a> in the <i>Amazon Simple Storage Service User Guide</i>.
        /// 
        ///  <dl> <dt>Permissions</dt> <dd> <ul> <li> 
        /// <para>
        /// You must have the <c>s3tables:CreateTableBucket</c> permission to use this operation.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you use this operation with the optional <c>encryptionConfiguration</c> parameter
        /// you must have the <c>s3tables:PutTableBucketEncryption</c> permission.
        /// </para>
        ///  </li> </ul> </dd> </dl>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTableBucket service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateTableBucket service method, as returned by S3Tables.</returns>
        /// <exception cref="Amazon.S3Tables.Model.BadRequestException">
        /// The request is invalid or malformed.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ConflictException">
        /// The request failed because there is a conflict with a previous write. You can retry
        /// the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ForbiddenException">
        /// The caller isn't authorized to make the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.InternalServerErrorException">
        /// The request failed due to an internal server error.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.NotFoundException">
        /// The request was rejected because the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.TooManyRequestsException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/CreateTableBucket">REST API Reference for CreateTableBucket Operation</seealso>
        public virtual Task<CreateTableBucketResponse> CreateTableBucketAsync(CreateTableBucketRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateTableBucketRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTableBucketResponseUnmarshaller.Instance;

            return InvokeAsync<CreateTableBucketResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteNamespace

        internal virtual DeleteNamespaceResponse DeleteNamespace(DeleteNamespaceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteNamespaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteNamespaceResponseUnmarshaller.Instance;

            return Invoke<DeleteNamespaceResponse>(request, options);
        }



        /// <summary>
        /// Deletes a namespace. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-tables-namespace-delete.html">Delete
        /// a namespace</a> in the <i>Amazon Simple Storage Service User Guide</i>.
        /// 
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3tables:DeleteNamespace</c> permission to use this operation.
        /// 
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteNamespace service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteNamespace service method, as returned by S3Tables.</returns>
        /// <exception cref="Amazon.S3Tables.Model.BadRequestException">
        /// The request is invalid or malformed.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ConflictException">
        /// The request failed because there is a conflict with a previous write. You can retry
        /// the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ForbiddenException">
        /// The caller isn't authorized to make the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.InternalServerErrorException">
        /// The request failed due to an internal server error.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.NotFoundException">
        /// The request was rejected because the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.TooManyRequestsException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/DeleteNamespace">REST API Reference for DeleteNamespace Operation</seealso>
        public virtual Task<DeleteNamespaceResponse> DeleteNamespaceAsync(DeleteNamespaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteNamespaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteNamespaceResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteNamespaceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteTable

        internal virtual DeleteTableResponse DeleteTable(DeleteTableRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTableResponseUnmarshaller.Instance;

            return Invoke<DeleteTableResponse>(request, options);
        }



        /// <summary>
        /// Deletes a table. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-tables-delete.html">Deleting
        /// an Amazon S3 table</a> in the <i>Amazon Simple Storage Service User Guide</i>.
        /// 
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3tables:DeleteTable</c> permission to use this operation. 
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTable service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTable service method, as returned by S3Tables.</returns>
        /// <exception cref="Amazon.S3Tables.Model.BadRequestException">
        /// The request is invalid or malformed.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ConflictException">
        /// The request failed because there is a conflict with a previous write. You can retry
        /// the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ForbiddenException">
        /// The caller isn't authorized to make the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.InternalServerErrorException">
        /// The request failed due to an internal server error.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.NotFoundException">
        /// The request was rejected because the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.TooManyRequestsException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/DeleteTable">REST API Reference for DeleteTable Operation</seealso>
        public virtual Task<DeleteTableResponse> DeleteTableAsync(DeleteTableRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTableResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteTableResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteTableBucket

        internal virtual DeleteTableBucketResponse DeleteTableBucket(DeleteTableBucketRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteTableBucketRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTableBucketResponseUnmarshaller.Instance;

            return Invoke<DeleteTableBucketResponse>(request, options);
        }



        /// <summary>
        /// Deletes a table bucket. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-tables-buckets-delete.html">Deleting
        /// a table bucket</a> in the <i>Amazon Simple Storage Service User Guide</i>.
        /// 
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3tables:DeleteTableBucket</c> permission to use this operation.
        /// 
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTableBucket service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTableBucket service method, as returned by S3Tables.</returns>
        /// <exception cref="Amazon.S3Tables.Model.BadRequestException">
        /// The request is invalid or malformed.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ConflictException">
        /// The request failed because there is a conflict with a previous write. You can retry
        /// the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ForbiddenException">
        /// The caller isn't authorized to make the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.InternalServerErrorException">
        /// The request failed due to an internal server error.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.NotFoundException">
        /// The request was rejected because the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.TooManyRequestsException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/DeleteTableBucket">REST API Reference for DeleteTableBucket Operation</seealso>
        public virtual Task<DeleteTableBucketResponse> DeleteTableBucketAsync(DeleteTableBucketRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteTableBucketRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTableBucketResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteTableBucketResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteTableBucketEncryption

        internal virtual DeleteTableBucketEncryptionResponse DeleteTableBucketEncryption(DeleteTableBucketEncryptionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteTableBucketEncryptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTableBucketEncryptionResponseUnmarshaller.Instance;

            return Invoke<DeleteTableBucketEncryptionResponse>(request, options);
        }



        /// <summary>
        /// Deletes the encryption configuration for a table bucket.
        /// 
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3tables:DeleteTableBucketEncryption</c> permission to use this
        /// operation.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTableBucketEncryption service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTableBucketEncryption service method, as returned by S3Tables.</returns>
        /// <exception cref="Amazon.S3Tables.Model.BadRequestException">
        /// The request is invalid or malformed.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ConflictException">
        /// The request failed because there is a conflict with a previous write. You can retry
        /// the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ForbiddenException">
        /// The caller isn't authorized to make the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.InternalServerErrorException">
        /// The request failed due to an internal server error.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.NotFoundException">
        /// The request was rejected because the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.TooManyRequestsException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/DeleteTableBucketEncryption">REST API Reference for DeleteTableBucketEncryption Operation</seealso>
        public virtual Task<DeleteTableBucketEncryptionResponse> DeleteTableBucketEncryptionAsync(DeleteTableBucketEncryptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteTableBucketEncryptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTableBucketEncryptionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteTableBucketEncryptionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteTableBucketPolicy

        internal virtual DeleteTableBucketPolicyResponse DeleteTableBucketPolicy(DeleteTableBucketPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteTableBucketPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTableBucketPolicyResponseUnmarshaller.Instance;

            return Invoke<DeleteTableBucketPolicyResponse>(request, options);
        }



        /// <summary>
        /// Deletes a table bucket policy. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-tables-bucket-policy.html#table-bucket-policy-delete">Deleting
        /// a table bucket policy</a> in the <i>Amazon Simple Storage Service User Guide</i>.
        /// 
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3tables:DeleteTableBucketPolicy</c> permission to use this operation.
        /// 
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTableBucketPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTableBucketPolicy service method, as returned by S3Tables.</returns>
        /// <exception cref="Amazon.S3Tables.Model.BadRequestException">
        /// The request is invalid or malformed.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ConflictException">
        /// The request failed because there is a conflict with a previous write. You can retry
        /// the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ForbiddenException">
        /// The caller isn't authorized to make the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.InternalServerErrorException">
        /// The request failed due to an internal server error.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.NotFoundException">
        /// The request was rejected because the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.TooManyRequestsException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/DeleteTableBucketPolicy">REST API Reference for DeleteTableBucketPolicy Operation</seealso>
        public virtual Task<DeleteTableBucketPolicyResponse> DeleteTableBucketPolicyAsync(DeleteTableBucketPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteTableBucketPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTableBucketPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteTableBucketPolicyResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteTablePolicy

        internal virtual DeleteTablePolicyResponse DeleteTablePolicy(DeleteTablePolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteTablePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTablePolicyResponseUnmarshaller.Instance;

            return Invoke<DeleteTablePolicyResponse>(request, options);
        }



        /// <summary>
        /// Deletes a table policy. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-tables-table-policy.html#table-policy-delete">Deleting
        /// a table policy</a> in the <i>Amazon Simple Storage Service User Guide</i>.
        /// 
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3tables:DeleteTablePolicy</c> permission to use this operation.
        /// 
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTablePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTablePolicy service method, as returned by S3Tables.</returns>
        /// <exception cref="Amazon.S3Tables.Model.BadRequestException">
        /// The request is invalid or malformed.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ConflictException">
        /// The request failed because there is a conflict with a previous write. You can retry
        /// the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ForbiddenException">
        /// The caller isn't authorized to make the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.InternalServerErrorException">
        /// The request failed due to an internal server error.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.NotFoundException">
        /// The request was rejected because the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.TooManyRequestsException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/DeleteTablePolicy">REST API Reference for DeleteTablePolicy Operation</seealso>
        public virtual Task<DeleteTablePolicyResponse> DeleteTablePolicyAsync(DeleteTablePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteTablePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTablePolicyResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteTablePolicyResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetNamespace

        internal virtual GetNamespaceResponse GetNamespace(GetNamespaceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetNamespaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetNamespaceResponseUnmarshaller.Instance;

            return Invoke<GetNamespaceResponse>(request, options);
        }



        /// <summary>
        /// Gets details about a namespace. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-tables-namespace.html">Table
        /// namespaces</a> in the <i>Amazon Simple Storage Service User Guide</i>.
        /// 
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3tables:GetNamespace</c> permission to use this operation. 
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetNamespace service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetNamespace service method, as returned by S3Tables.</returns>
        /// <exception cref="Amazon.S3Tables.Model.AccessDeniedException">
        /// The action cannot be performed because you do not have the required permission.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.BadRequestException">
        /// The request is invalid or malformed.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ConflictException">
        /// The request failed because there is a conflict with a previous write. You can retry
        /// the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ForbiddenException">
        /// The caller isn't authorized to make the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.InternalServerErrorException">
        /// The request failed due to an internal server error.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.NotFoundException">
        /// The request was rejected because the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.TooManyRequestsException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/GetNamespace">REST API Reference for GetNamespace Operation</seealso>
        public virtual Task<GetNamespaceResponse> GetNamespaceAsync(GetNamespaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetNamespaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetNamespaceResponseUnmarshaller.Instance;

            return InvokeAsync<GetNamespaceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetTable

        internal virtual GetTableResponse GetTable(GetTableRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTableResponseUnmarshaller.Instance;

            return Invoke<GetTableResponse>(request, options);
        }



        /// <summary>
        /// Gets details about a table. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-tables-tables.html">S3
        /// Tables</a> in the <i>Amazon Simple Storage Service User Guide</i>.
        /// 
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3tables:GetTable</c> permission to use this operation. 
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTable service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTable service method, as returned by S3Tables.</returns>
        /// <exception cref="Amazon.S3Tables.Model.AccessDeniedException">
        /// The action cannot be performed because you do not have the required permission.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.BadRequestException">
        /// The request is invalid or malformed.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ConflictException">
        /// The request failed because there is a conflict with a previous write. You can retry
        /// the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ForbiddenException">
        /// The caller isn't authorized to make the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.InternalServerErrorException">
        /// The request failed due to an internal server error.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.NotFoundException">
        /// The request was rejected because the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.TooManyRequestsException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/GetTable">REST API Reference for GetTable Operation</seealso>
        public virtual Task<GetTableResponse> GetTableAsync(GetTableRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTableResponseUnmarshaller.Instance;

            return InvokeAsync<GetTableResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetTableBucket

        internal virtual GetTableBucketResponse GetTableBucket(GetTableBucketRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTableBucketRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTableBucketResponseUnmarshaller.Instance;

            return Invoke<GetTableBucketResponse>(request, options);
        }



        /// <summary>
        /// Gets details on a table bucket. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-tables-buckets-details.html">Viewing
        /// details about an Amazon S3 table bucket</a> in the <i>Amazon Simple Storage Service
        /// User Guide</i>.
        /// 
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3tables:GetTableBucket</c> permission to use this operation.
        /// 
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTableBucket service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTableBucket service method, as returned by S3Tables.</returns>
        /// <exception cref="Amazon.S3Tables.Model.AccessDeniedException">
        /// The action cannot be performed because you do not have the required permission.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.BadRequestException">
        /// The request is invalid or malformed.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ConflictException">
        /// The request failed because there is a conflict with a previous write. You can retry
        /// the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ForbiddenException">
        /// The caller isn't authorized to make the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.InternalServerErrorException">
        /// The request failed due to an internal server error.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.NotFoundException">
        /// The request was rejected because the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.TooManyRequestsException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/GetTableBucket">REST API Reference for GetTableBucket Operation</seealso>
        public virtual Task<GetTableBucketResponse> GetTableBucketAsync(GetTableBucketRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTableBucketRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTableBucketResponseUnmarshaller.Instance;

            return InvokeAsync<GetTableBucketResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetTableBucketEncryption

        internal virtual GetTableBucketEncryptionResponse GetTableBucketEncryption(GetTableBucketEncryptionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTableBucketEncryptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTableBucketEncryptionResponseUnmarshaller.Instance;

            return Invoke<GetTableBucketEncryptionResponse>(request, options);
        }



        /// <summary>
        /// Gets the encryption configuration for a table bucket.
        /// 
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3tables:GetTableBucketEncryption</c> permission to use this
        /// operation.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTableBucketEncryption service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTableBucketEncryption service method, as returned by S3Tables.</returns>
        /// <exception cref="Amazon.S3Tables.Model.AccessDeniedException">
        /// The action cannot be performed because you do not have the required permission.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.BadRequestException">
        /// The request is invalid or malformed.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ForbiddenException">
        /// The caller isn't authorized to make the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.InternalServerErrorException">
        /// The request failed due to an internal server error.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.NotFoundException">
        /// The request was rejected because the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.TooManyRequestsException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/GetTableBucketEncryption">REST API Reference for GetTableBucketEncryption Operation</seealso>
        public virtual Task<GetTableBucketEncryptionResponse> GetTableBucketEncryptionAsync(GetTableBucketEncryptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTableBucketEncryptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTableBucketEncryptionResponseUnmarshaller.Instance;

            return InvokeAsync<GetTableBucketEncryptionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetTableBucketMaintenanceConfiguration

        internal virtual GetTableBucketMaintenanceConfigurationResponse GetTableBucketMaintenanceConfiguration(GetTableBucketMaintenanceConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTableBucketMaintenanceConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTableBucketMaintenanceConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetTableBucketMaintenanceConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Gets details about a maintenance configuration for a given table bucket. For more
        /// information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-table-buckets-maintenance.html">Amazon
        /// S3 table bucket maintenance</a> in the <i>Amazon Simple Storage Service User Guide</i>.
        /// 
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3tables:GetTableBucketMaintenanceConfiguration</c> permission
        /// to use this operation. 
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTableBucketMaintenanceConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTableBucketMaintenanceConfiguration service method, as returned by S3Tables.</returns>
        /// <exception cref="Amazon.S3Tables.Model.BadRequestException">
        /// The request is invalid or malformed.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ConflictException">
        /// The request failed because there is a conflict with a previous write. You can retry
        /// the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ForbiddenException">
        /// The caller isn't authorized to make the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.InternalServerErrorException">
        /// The request failed due to an internal server error.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.NotFoundException">
        /// The request was rejected because the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.TooManyRequestsException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/GetTableBucketMaintenanceConfiguration">REST API Reference for GetTableBucketMaintenanceConfiguration Operation</seealso>
        public virtual Task<GetTableBucketMaintenanceConfigurationResponse> GetTableBucketMaintenanceConfigurationAsync(GetTableBucketMaintenanceConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTableBucketMaintenanceConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTableBucketMaintenanceConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<GetTableBucketMaintenanceConfigurationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetTableBucketPolicy

        internal virtual GetTableBucketPolicyResponse GetTableBucketPolicy(GetTableBucketPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTableBucketPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTableBucketPolicyResponseUnmarshaller.Instance;

            return Invoke<GetTableBucketPolicyResponse>(request, options);
        }



        /// <summary>
        /// Gets details about a table bucket policy. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-tables-bucket-policy.html#table-bucket-policy-get">Viewing
        /// a table bucket policy</a> in the <i>Amazon Simple Storage Service User Guide</i>.
        /// 
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3tables:GetTableBucketPolicy</c> permission to use this operation.
        /// 
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTableBucketPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTableBucketPolicy service method, as returned by S3Tables.</returns>
        /// <exception cref="Amazon.S3Tables.Model.BadRequestException">
        /// The request is invalid or malformed.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ConflictException">
        /// The request failed because there is a conflict with a previous write. You can retry
        /// the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ForbiddenException">
        /// The caller isn't authorized to make the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.InternalServerErrorException">
        /// The request failed due to an internal server error.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.NotFoundException">
        /// The request was rejected because the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.TooManyRequestsException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/GetTableBucketPolicy">REST API Reference for GetTableBucketPolicy Operation</seealso>
        public virtual Task<GetTableBucketPolicyResponse> GetTableBucketPolicyAsync(GetTableBucketPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTableBucketPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTableBucketPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<GetTableBucketPolicyResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetTableEncryption

        internal virtual GetTableEncryptionResponse GetTableEncryption(GetTableEncryptionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTableEncryptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTableEncryptionResponseUnmarshaller.Instance;

            return Invoke<GetTableEncryptionResponse>(request, options);
        }



        /// <summary>
        /// Gets the encryption configuration for a table.
        /// 
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3tables:GetTableEncryption</c> permission to use this operation.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTableEncryption service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTableEncryption service method, as returned by S3Tables.</returns>
        /// <exception cref="Amazon.S3Tables.Model.AccessDeniedException">
        /// The action cannot be performed because you do not have the required permission.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.BadRequestException">
        /// The request is invalid or malformed.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ForbiddenException">
        /// The caller isn't authorized to make the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.InternalServerErrorException">
        /// The request failed due to an internal server error.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.NotFoundException">
        /// The request was rejected because the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.TooManyRequestsException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/GetTableEncryption">REST API Reference for GetTableEncryption Operation</seealso>
        public virtual Task<GetTableEncryptionResponse> GetTableEncryptionAsync(GetTableEncryptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTableEncryptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTableEncryptionResponseUnmarshaller.Instance;

            return InvokeAsync<GetTableEncryptionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetTableMaintenanceConfiguration

        internal virtual GetTableMaintenanceConfigurationResponse GetTableMaintenanceConfiguration(GetTableMaintenanceConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTableMaintenanceConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTableMaintenanceConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetTableMaintenanceConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Gets details about the maintenance configuration of a table. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-tables-maintenance.html">S3
        /// Tables maintenance</a> in the <i>Amazon Simple Storage Service User Guide</i>.
        /// 
        ///  <dl> <dt>Permissions</dt> <dd> <ul> <li> 
        /// <para>
        /// You must have the <c>s3tables:GetTableMaintenanceConfiguration</c> permission to use
        /// this operation. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You must have the <c>s3tables:GetTableData</c> permission to use set the compaction
        /// strategy to <c>sort</c> or <c>zorder</c>.
        /// </para>
        ///  </li> </ul> </dd> </dl>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTableMaintenanceConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTableMaintenanceConfiguration service method, as returned by S3Tables.</returns>
        /// <exception cref="Amazon.S3Tables.Model.BadRequestException">
        /// The request is invalid or malformed.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ConflictException">
        /// The request failed because there is a conflict with a previous write. You can retry
        /// the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ForbiddenException">
        /// The caller isn't authorized to make the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.InternalServerErrorException">
        /// The request failed due to an internal server error.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.NotFoundException">
        /// The request was rejected because the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.TooManyRequestsException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/GetTableMaintenanceConfiguration">REST API Reference for GetTableMaintenanceConfiguration Operation</seealso>
        public virtual Task<GetTableMaintenanceConfigurationResponse> GetTableMaintenanceConfigurationAsync(GetTableMaintenanceConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTableMaintenanceConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTableMaintenanceConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<GetTableMaintenanceConfigurationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetTableMaintenanceJobStatus

        internal virtual GetTableMaintenanceJobStatusResponse GetTableMaintenanceJobStatus(GetTableMaintenanceJobStatusRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTableMaintenanceJobStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTableMaintenanceJobStatusResponseUnmarshaller.Instance;

            return Invoke<GetTableMaintenanceJobStatusResponse>(request, options);
        }



        /// <summary>
        /// Gets the status of a maintenance job for a table. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-tables-maintenance.html">S3
        /// Tables maintenance</a> in the <i>Amazon Simple Storage Service User Guide</i>.
        /// 
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3tables:GetTableMaintenanceJobStatus</c> permission to use this
        /// operation. 
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTableMaintenanceJobStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTableMaintenanceJobStatus service method, as returned by S3Tables.</returns>
        /// <exception cref="Amazon.S3Tables.Model.BadRequestException">
        /// The request is invalid or malformed.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ConflictException">
        /// The request failed because there is a conflict with a previous write. You can retry
        /// the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ForbiddenException">
        /// The caller isn't authorized to make the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.InternalServerErrorException">
        /// The request failed due to an internal server error.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.NotFoundException">
        /// The request was rejected because the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.TooManyRequestsException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/GetTableMaintenanceJobStatus">REST API Reference for GetTableMaintenanceJobStatus Operation</seealso>
        public virtual Task<GetTableMaintenanceJobStatusResponse> GetTableMaintenanceJobStatusAsync(GetTableMaintenanceJobStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTableMaintenanceJobStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTableMaintenanceJobStatusResponseUnmarshaller.Instance;

            return InvokeAsync<GetTableMaintenanceJobStatusResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetTableMetadataLocation

        internal virtual GetTableMetadataLocationResponse GetTableMetadataLocation(GetTableMetadataLocationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTableMetadataLocationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTableMetadataLocationResponseUnmarshaller.Instance;

            return Invoke<GetTableMetadataLocationResponse>(request, options);
        }



        /// <summary>
        /// Gets the location of the table metadata.
        /// 
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3tables:GetTableMetadataLocation</c> permission to use this
        /// operation. 
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTableMetadataLocation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTableMetadataLocation service method, as returned by S3Tables.</returns>
        /// <exception cref="Amazon.S3Tables.Model.BadRequestException">
        /// The request is invalid or malformed.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ConflictException">
        /// The request failed because there is a conflict with a previous write. You can retry
        /// the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ForbiddenException">
        /// The caller isn't authorized to make the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.InternalServerErrorException">
        /// The request failed due to an internal server error.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.NotFoundException">
        /// The request was rejected because the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.TooManyRequestsException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/GetTableMetadataLocation">REST API Reference for GetTableMetadataLocation Operation</seealso>
        public virtual Task<GetTableMetadataLocationResponse> GetTableMetadataLocationAsync(GetTableMetadataLocationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTableMetadataLocationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTableMetadataLocationResponseUnmarshaller.Instance;

            return InvokeAsync<GetTableMetadataLocationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetTablePolicy

        internal virtual GetTablePolicyResponse GetTablePolicy(GetTablePolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTablePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTablePolicyResponseUnmarshaller.Instance;

            return Invoke<GetTablePolicyResponse>(request, options);
        }



        /// <summary>
        /// Gets details about a table policy. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-tables-table-policy.html#table-policy-get">Viewing
        /// a table policy</a> in the <i>Amazon Simple Storage Service User Guide</i>.
        /// 
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3tables:GetTablePolicy</c> permission to use this operation.
        /// 
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTablePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTablePolicy service method, as returned by S3Tables.</returns>
        /// <exception cref="Amazon.S3Tables.Model.BadRequestException">
        /// The request is invalid or malformed.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ConflictException">
        /// The request failed because there is a conflict with a previous write. You can retry
        /// the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ForbiddenException">
        /// The caller isn't authorized to make the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.InternalServerErrorException">
        /// The request failed due to an internal server error.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.NotFoundException">
        /// The request was rejected because the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.TooManyRequestsException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/GetTablePolicy">REST API Reference for GetTablePolicy Operation</seealso>
        public virtual Task<GetTablePolicyResponse> GetTablePolicyAsync(GetTablePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTablePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTablePolicyResponseUnmarshaller.Instance;

            return InvokeAsync<GetTablePolicyResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListNamespaces

        internal virtual ListNamespacesResponse ListNamespaces(ListNamespacesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListNamespacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListNamespacesResponseUnmarshaller.Instance;

            return Invoke<ListNamespacesResponse>(request, options);
        }



        /// <summary>
        /// Lists the namespaces within a table bucket. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-tables-namespace.html">Table
        /// namespaces</a> in the <i>Amazon Simple Storage Service User Guide</i>.
        /// 
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3tables:ListNamespaces</c> permission to use this operation.
        /// 
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNamespaces service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListNamespaces service method, as returned by S3Tables.</returns>
        /// <exception cref="Amazon.S3Tables.Model.AccessDeniedException">
        /// The action cannot be performed because you do not have the required permission.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.BadRequestException">
        /// The request is invalid or malformed.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ConflictException">
        /// The request failed because there is a conflict with a previous write. You can retry
        /// the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ForbiddenException">
        /// The caller isn't authorized to make the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.InternalServerErrorException">
        /// The request failed due to an internal server error.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.NotFoundException">
        /// The request was rejected because the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.TooManyRequestsException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/ListNamespaces">REST API Reference for ListNamespaces Operation</seealso>
        public virtual Task<ListNamespacesResponse> ListNamespacesAsync(ListNamespacesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListNamespacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListNamespacesResponseUnmarshaller.Instance;

            return InvokeAsync<ListNamespacesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListTableBuckets

        internal virtual ListTableBucketsResponse ListTableBuckets(ListTableBucketsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTableBucketsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTableBucketsResponseUnmarshaller.Instance;

            return Invoke<ListTableBucketsResponse>(request, options);
        }



        /// <summary>
        /// Lists table buckets for your account. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-tables-buckets.html">S3
        /// Table buckets</a> in the <i>Amazon Simple Storage Service User Guide</i>.
        /// 
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3tables:ListTableBuckets</c> permission to use this operation.
        /// 
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTableBuckets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTableBuckets service method, as returned by S3Tables.</returns>
        /// <exception cref="Amazon.S3Tables.Model.AccessDeniedException">
        /// The action cannot be performed because you do not have the required permission.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.BadRequestException">
        /// The request is invalid or malformed.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ConflictException">
        /// The request failed because there is a conflict with a previous write. You can retry
        /// the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ForbiddenException">
        /// The caller isn't authorized to make the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.InternalServerErrorException">
        /// The request failed due to an internal server error.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.NotFoundException">
        /// The request was rejected because the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.TooManyRequestsException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/ListTableBuckets">REST API Reference for ListTableBuckets Operation</seealso>
        public virtual Task<ListTableBucketsResponse> ListTableBucketsAsync(ListTableBucketsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTableBucketsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTableBucketsResponseUnmarshaller.Instance;

            return InvokeAsync<ListTableBucketsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListTables

        internal virtual ListTablesResponse ListTables(ListTablesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTablesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTablesResponseUnmarshaller.Instance;

            return Invoke<ListTablesResponse>(request, options);
        }



        /// <summary>
        /// List tables in the given table bucket. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-tables-tables.html">S3
        /// Tables</a> in the <i>Amazon Simple Storage Service User Guide</i>.
        /// 
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3tables:ListTables</c> permission to use this operation. 
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTables service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTables service method, as returned by S3Tables.</returns>
        /// <exception cref="Amazon.S3Tables.Model.BadRequestException">
        /// The request is invalid or malformed.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ConflictException">
        /// The request failed because there is a conflict with a previous write. You can retry
        /// the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ForbiddenException">
        /// The caller isn't authorized to make the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.InternalServerErrorException">
        /// The request failed due to an internal server error.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.NotFoundException">
        /// The request was rejected because the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.TooManyRequestsException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/ListTables">REST API Reference for ListTables Operation</seealso>
        public virtual Task<ListTablesResponse> ListTablesAsync(ListTablesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTablesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTablesResponseUnmarshaller.Instance;

            return InvokeAsync<ListTablesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  PutTableBucketEncryption

        internal virtual PutTableBucketEncryptionResponse PutTableBucketEncryption(PutTableBucketEncryptionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutTableBucketEncryptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutTableBucketEncryptionResponseUnmarshaller.Instance;

            return Invoke<PutTableBucketEncryptionResponse>(request, options);
        }



        /// <summary>
        /// Sets the encryption configuration for a table bucket.
        /// 
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3tables:PutTableBucketEncryption</c> permission to use this
        /// operation.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you choose SSE-KMS encryption you must grant the S3 Tables maintenance principal
        /// access to your KMS key. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-tables-kms-permissions.html">Permissions
        /// requirements for S3 Tables SSE-KMS encryption</a> in the <i>Amazon Simple Storage
        /// Service User Guide</i>.
        /// </para>
        ///  </note> </dd> </dl>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutTableBucketEncryption service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutTableBucketEncryption service method, as returned by S3Tables.</returns>
        /// <exception cref="Amazon.S3Tables.Model.BadRequestException">
        /// The request is invalid or malformed.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ConflictException">
        /// The request failed because there is a conflict with a previous write. You can retry
        /// the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ForbiddenException">
        /// The caller isn't authorized to make the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.InternalServerErrorException">
        /// The request failed due to an internal server error.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.NotFoundException">
        /// The request was rejected because the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.TooManyRequestsException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/PutTableBucketEncryption">REST API Reference for PutTableBucketEncryption Operation</seealso>
        public virtual Task<PutTableBucketEncryptionResponse> PutTableBucketEncryptionAsync(PutTableBucketEncryptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutTableBucketEncryptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutTableBucketEncryptionResponseUnmarshaller.Instance;

            return InvokeAsync<PutTableBucketEncryptionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  PutTableBucketMaintenanceConfiguration

        internal virtual PutTableBucketMaintenanceConfigurationResponse PutTableBucketMaintenanceConfiguration(PutTableBucketMaintenanceConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutTableBucketMaintenanceConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutTableBucketMaintenanceConfigurationResponseUnmarshaller.Instance;

            return Invoke<PutTableBucketMaintenanceConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Creates a new maintenance configuration or replaces an existing maintenance configuration
        /// for a table bucket. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-table-buckets-maintenance.html">Amazon
        /// S3 table bucket maintenance</a> in the <i>Amazon Simple Storage Service User Guide</i>.
        /// 
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3tables:PutTableBucketMaintenanceConfiguration</c> permission
        /// to use this operation. 
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutTableBucketMaintenanceConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutTableBucketMaintenanceConfiguration service method, as returned by S3Tables.</returns>
        /// <exception cref="Amazon.S3Tables.Model.BadRequestException">
        /// The request is invalid or malformed.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ConflictException">
        /// The request failed because there is a conflict with a previous write. You can retry
        /// the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ForbiddenException">
        /// The caller isn't authorized to make the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.InternalServerErrorException">
        /// The request failed due to an internal server error.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.NotFoundException">
        /// The request was rejected because the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.TooManyRequestsException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/PutTableBucketMaintenanceConfiguration">REST API Reference for PutTableBucketMaintenanceConfiguration Operation</seealso>
        public virtual Task<PutTableBucketMaintenanceConfigurationResponse> PutTableBucketMaintenanceConfigurationAsync(PutTableBucketMaintenanceConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutTableBucketMaintenanceConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutTableBucketMaintenanceConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<PutTableBucketMaintenanceConfigurationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  PutTableBucketPolicy

        internal virtual PutTableBucketPolicyResponse PutTableBucketPolicy(PutTableBucketPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutTableBucketPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutTableBucketPolicyResponseUnmarshaller.Instance;

            return Invoke<PutTableBucketPolicyResponse>(request, options);
        }



        /// <summary>
        /// Creates a new maintenance configuration or replaces an existing table bucket policy
        /// for a table bucket. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-tables-bucket-policy.html#table-bucket-policy-add">Adding
        /// a table bucket policy</a> in the <i>Amazon Simple Storage Service User Guide</i>.
        /// 
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3tables:PutTableBucketPolicy</c> permission to use this operation.
        /// 
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutTableBucketPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutTableBucketPolicy service method, as returned by S3Tables.</returns>
        /// <exception cref="Amazon.S3Tables.Model.BadRequestException">
        /// The request is invalid or malformed.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ConflictException">
        /// The request failed because there is a conflict with a previous write. You can retry
        /// the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ForbiddenException">
        /// The caller isn't authorized to make the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.InternalServerErrorException">
        /// The request failed due to an internal server error.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.NotFoundException">
        /// The request was rejected because the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.TooManyRequestsException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/PutTableBucketPolicy">REST API Reference for PutTableBucketPolicy Operation</seealso>
        public virtual Task<PutTableBucketPolicyResponse> PutTableBucketPolicyAsync(PutTableBucketPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutTableBucketPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutTableBucketPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<PutTableBucketPolicyResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  PutTableMaintenanceConfiguration

        internal virtual PutTableMaintenanceConfigurationResponse PutTableMaintenanceConfiguration(PutTableMaintenanceConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutTableMaintenanceConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutTableMaintenanceConfigurationResponseUnmarshaller.Instance;

            return Invoke<PutTableMaintenanceConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Creates a new maintenance configuration or replaces an existing maintenance configuration
        /// for a table. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-tables-maintenance.html">S3
        /// Tables maintenance</a> in the <i>Amazon Simple Storage Service User Guide</i>.
        /// 
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3tables:PutTableMaintenanceConfiguration</c> permission to use
        /// this operation. 
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutTableMaintenanceConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutTableMaintenanceConfiguration service method, as returned by S3Tables.</returns>
        /// <exception cref="Amazon.S3Tables.Model.BadRequestException">
        /// The request is invalid or malformed.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ConflictException">
        /// The request failed because there is a conflict with a previous write. You can retry
        /// the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ForbiddenException">
        /// The caller isn't authorized to make the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.InternalServerErrorException">
        /// The request failed due to an internal server error.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.NotFoundException">
        /// The request was rejected because the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.TooManyRequestsException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/PutTableMaintenanceConfiguration">REST API Reference for PutTableMaintenanceConfiguration Operation</seealso>
        public virtual Task<PutTableMaintenanceConfigurationResponse> PutTableMaintenanceConfigurationAsync(PutTableMaintenanceConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutTableMaintenanceConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutTableMaintenanceConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<PutTableMaintenanceConfigurationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  PutTablePolicy

        internal virtual PutTablePolicyResponse PutTablePolicy(PutTablePolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutTablePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutTablePolicyResponseUnmarshaller.Instance;

            return Invoke<PutTablePolicyResponse>(request, options);
        }



        /// <summary>
        /// Creates a new maintenance configuration or replaces an existing table policy for a
        /// table. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-tables-table-policy.html#table-policy-add">Adding
        /// a table policy</a> in the <i>Amazon Simple Storage Service User Guide</i>. 
        /// 
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3tables:PutTablePolicy</c> permission to use this operation.
        /// 
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutTablePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutTablePolicy service method, as returned by S3Tables.</returns>
        /// <exception cref="Amazon.S3Tables.Model.BadRequestException">
        /// The request is invalid or malformed.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ConflictException">
        /// The request failed because there is a conflict with a previous write. You can retry
        /// the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ForbiddenException">
        /// The caller isn't authorized to make the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.InternalServerErrorException">
        /// The request failed due to an internal server error.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.NotFoundException">
        /// The request was rejected because the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.TooManyRequestsException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/PutTablePolicy">REST API Reference for PutTablePolicy Operation</seealso>
        public virtual Task<PutTablePolicyResponse> PutTablePolicyAsync(PutTablePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutTablePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutTablePolicyResponseUnmarshaller.Instance;

            return InvokeAsync<PutTablePolicyResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  RenameTable

        internal virtual RenameTableResponse RenameTable(RenameTableRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RenameTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RenameTableResponseUnmarshaller.Instance;

            return Invoke<RenameTableResponse>(request, options);
        }



        /// <summary>
        /// Renames a table or a namespace. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-tables-tables.html">S3
        /// Tables</a> in the <i>Amazon Simple Storage Service User Guide</i>.
        /// 
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3tables:RenameTable</c> permission to use this operation. 
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RenameTable service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RenameTable service method, as returned by S3Tables.</returns>
        /// <exception cref="Amazon.S3Tables.Model.BadRequestException">
        /// The request is invalid or malformed.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ConflictException">
        /// The request failed because there is a conflict with a previous write. You can retry
        /// the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ForbiddenException">
        /// The caller isn't authorized to make the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.InternalServerErrorException">
        /// The request failed due to an internal server error.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.NotFoundException">
        /// The request was rejected because the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.TooManyRequestsException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/RenameTable">REST API Reference for RenameTable Operation</seealso>
        public virtual Task<RenameTableResponse> RenameTableAsync(RenameTableRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RenameTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RenameTableResponseUnmarshaller.Instance;

            return InvokeAsync<RenameTableResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateTableMetadataLocation

        internal virtual UpdateTableMetadataLocationResponse UpdateTableMetadataLocation(UpdateTableMetadataLocationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateTableMetadataLocationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTableMetadataLocationResponseUnmarshaller.Instance;

            return Invoke<UpdateTableMetadataLocationResponse>(request, options);
        }



        /// <summary>
        /// Updates the metadata location for a table. The metadata location of a table must be
        /// an S3 URI that begins with the table's warehouse location. The metadata location for
        /// an Apache Iceberg table must end with <c>.metadata.json</c>, or if the metadata file
        /// is Gzip-compressed, <c>.metadata.json.gz</c>.
        /// 
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3tables:UpdateTableMetadataLocation</c> permission to use this
        /// operation. 
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTableMetadataLocation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateTableMetadataLocation service method, as returned by S3Tables.</returns>
        /// <exception cref="Amazon.S3Tables.Model.BadRequestException">
        /// The request is invalid or malformed.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ConflictException">
        /// The request failed because there is a conflict with a previous write. You can retry
        /// the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ForbiddenException">
        /// The caller isn't authorized to make the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.InternalServerErrorException">
        /// The request failed due to an internal server error.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.NotFoundException">
        /// The request was rejected because the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.TooManyRequestsException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/UpdateTableMetadataLocation">REST API Reference for UpdateTableMetadataLocation Operation</seealso>
        public virtual Task<UpdateTableMetadataLocationResponse> UpdateTableMetadataLocationAsync(UpdateTableMetadataLocationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateTableMetadataLocationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTableMetadataLocationResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateTableMetadataLocationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        public Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request)
        {
            var parameters = new ServiceOperationEndpointParameters(request);
            return Config.DetermineServiceOperationEndpoint(parameters);
        }

        #endregion

    }
}