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
using System.Collections.Generic;
using System.Net;

using Amazon.S3Tables.Model;
using Amazon.S3Tables.Model.Internal.MarshallTransformations;
using Amazon.S3Tables.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

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

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
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
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonS3TablesConfig()) { }

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
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonS3TablesConfig{RegionEndpoint = region}) { }

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
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}
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

        #region Overrides

        
        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        }

        /// <summary>
        /// Customize the pipeline
        /// </summary>
        /// <param name="pipeline"></param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonS3TablesEndpointResolver());
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
        public virtual CreateNamespaceResponse CreateNamespace(CreateNamespaceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateNamespaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateNamespaceResponseUnmarshaller.Instance;

            return Invoke<CreateNamespaceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateNamespace operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateNamespace operation on AmazonS3TablesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateNamespace
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/CreateNamespace">REST API Reference for CreateNamespace Operation</seealso>
        public virtual IAsyncResult BeginCreateNamespace(CreateNamespaceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateNamespaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateNamespaceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateNamespace operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateNamespace.</param>
        /// 
        /// <returns>Returns a  CreateNamespaceResult from S3Tables.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/CreateNamespace">REST API Reference for CreateNamespace Operation</seealso>
        public virtual CreateNamespaceResponse EndCreateNamespace(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateNamespaceResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateTable

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
        public virtual CreateTableResponse CreateTable(CreateTableRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTableResponseUnmarshaller.Instance;

            return Invoke<CreateTableResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateTable operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTable operation on AmazonS3TablesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateTable
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/CreateTable">REST API Reference for CreateTable Operation</seealso>
        public virtual IAsyncResult BeginCreateTable(CreateTableRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTableResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateTable operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateTable.</param>
        /// 
        /// <returns>Returns a  CreateTableResult from S3Tables.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/CreateTable">REST API Reference for CreateTable Operation</seealso>
        public virtual CreateTableResponse EndCreateTable(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateTableResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateTableBucket

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
        public virtual CreateTableBucketResponse CreateTableBucket(CreateTableBucketRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateTableBucketRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTableBucketResponseUnmarshaller.Instance;

            return Invoke<CreateTableBucketResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateTableBucket operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTableBucket operation on AmazonS3TablesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateTableBucket
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/CreateTableBucket">REST API Reference for CreateTableBucket Operation</seealso>
        public virtual IAsyncResult BeginCreateTableBucket(CreateTableBucketRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateTableBucketRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTableBucketResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateTableBucket operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateTableBucket.</param>
        /// 
        /// <returns>Returns a  CreateTableBucketResult from S3Tables.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/CreateTableBucket">REST API Reference for CreateTableBucket Operation</seealso>
        public virtual CreateTableBucketResponse EndCreateTableBucket(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateTableBucketResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteNamespace

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
        public virtual DeleteNamespaceResponse DeleteNamespace(DeleteNamespaceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteNamespaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteNamespaceResponseUnmarshaller.Instance;

            return Invoke<DeleteNamespaceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteNamespace operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteNamespace operation on AmazonS3TablesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteNamespace
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/DeleteNamespace">REST API Reference for DeleteNamespace Operation</seealso>
        public virtual IAsyncResult BeginDeleteNamespace(DeleteNamespaceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteNamespaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteNamespaceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteNamespace operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteNamespace.</param>
        /// 
        /// <returns>Returns a  DeleteNamespaceResult from S3Tables.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/DeleteNamespace">REST API Reference for DeleteNamespace Operation</seealso>
        public virtual DeleteNamespaceResponse EndDeleteNamespace(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteNamespaceResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteTable

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
        public virtual DeleteTableResponse DeleteTable(DeleteTableRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTableResponseUnmarshaller.Instance;

            return Invoke<DeleteTableResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTable operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTable operation on AmazonS3TablesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteTable
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/DeleteTable">REST API Reference for DeleteTable Operation</seealso>
        public virtual IAsyncResult BeginDeleteTable(DeleteTableRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTableResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteTable operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteTable.</param>
        /// 
        /// <returns>Returns a  DeleteTableResult from S3Tables.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/DeleteTable">REST API Reference for DeleteTable Operation</seealso>
        public virtual DeleteTableResponse EndDeleteTable(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteTableResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteTableBucket

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
        public virtual DeleteTableBucketResponse DeleteTableBucket(DeleteTableBucketRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteTableBucketRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTableBucketResponseUnmarshaller.Instance;

            return Invoke<DeleteTableBucketResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTableBucket operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTableBucket operation on AmazonS3TablesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteTableBucket
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/DeleteTableBucket">REST API Reference for DeleteTableBucket Operation</seealso>
        public virtual IAsyncResult BeginDeleteTableBucket(DeleteTableBucketRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteTableBucketRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTableBucketResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteTableBucket operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteTableBucket.</param>
        /// 
        /// <returns>Returns a  DeleteTableBucketResult from S3Tables.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/DeleteTableBucket">REST API Reference for DeleteTableBucket Operation</seealso>
        public virtual DeleteTableBucketResponse EndDeleteTableBucket(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteTableBucketResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteTableBucketEncryption

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
        public virtual DeleteTableBucketEncryptionResponse DeleteTableBucketEncryption(DeleteTableBucketEncryptionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteTableBucketEncryptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTableBucketEncryptionResponseUnmarshaller.Instance;

            return Invoke<DeleteTableBucketEncryptionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTableBucketEncryption operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTableBucketEncryption operation on AmazonS3TablesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteTableBucketEncryption
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/DeleteTableBucketEncryption">REST API Reference for DeleteTableBucketEncryption Operation</seealso>
        public virtual IAsyncResult BeginDeleteTableBucketEncryption(DeleteTableBucketEncryptionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteTableBucketEncryptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTableBucketEncryptionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteTableBucketEncryption operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteTableBucketEncryption.</param>
        /// 
        /// <returns>Returns a  DeleteTableBucketEncryptionResult from S3Tables.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/DeleteTableBucketEncryption">REST API Reference for DeleteTableBucketEncryption Operation</seealso>
        public virtual DeleteTableBucketEncryptionResponse EndDeleteTableBucketEncryption(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteTableBucketEncryptionResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteTableBucketPolicy

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
        public virtual DeleteTableBucketPolicyResponse DeleteTableBucketPolicy(DeleteTableBucketPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteTableBucketPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTableBucketPolicyResponseUnmarshaller.Instance;

            return Invoke<DeleteTableBucketPolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTableBucketPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTableBucketPolicy operation on AmazonS3TablesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteTableBucketPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/DeleteTableBucketPolicy">REST API Reference for DeleteTableBucketPolicy Operation</seealso>
        public virtual IAsyncResult BeginDeleteTableBucketPolicy(DeleteTableBucketPolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteTableBucketPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTableBucketPolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteTableBucketPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteTableBucketPolicy.</param>
        /// 
        /// <returns>Returns a  DeleteTableBucketPolicyResult from S3Tables.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/DeleteTableBucketPolicy">REST API Reference for DeleteTableBucketPolicy Operation</seealso>
        public virtual DeleteTableBucketPolicyResponse EndDeleteTableBucketPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteTableBucketPolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteTablePolicy

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
        public virtual DeleteTablePolicyResponse DeleteTablePolicy(DeleteTablePolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteTablePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTablePolicyResponseUnmarshaller.Instance;

            return Invoke<DeleteTablePolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTablePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTablePolicy operation on AmazonS3TablesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteTablePolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/DeleteTablePolicy">REST API Reference for DeleteTablePolicy Operation</seealso>
        public virtual IAsyncResult BeginDeleteTablePolicy(DeleteTablePolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteTablePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTablePolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteTablePolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteTablePolicy.</param>
        /// 
        /// <returns>Returns a  DeleteTablePolicyResult from S3Tables.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/DeleteTablePolicy">REST API Reference for DeleteTablePolicy Operation</seealso>
        public virtual DeleteTablePolicyResponse EndDeleteTablePolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteTablePolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  GetNamespace

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
        public virtual GetNamespaceResponse GetNamespace(GetNamespaceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetNamespaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetNamespaceResponseUnmarshaller.Instance;

            return Invoke<GetNamespaceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetNamespace operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetNamespace operation on AmazonS3TablesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetNamespace
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/GetNamespace">REST API Reference for GetNamespace Operation</seealso>
        public virtual IAsyncResult BeginGetNamespace(GetNamespaceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetNamespaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetNamespaceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetNamespace operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetNamespace.</param>
        /// 
        /// <returns>Returns a  GetNamespaceResult from S3Tables.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/GetNamespace">REST API Reference for GetNamespace Operation</seealso>
        public virtual GetNamespaceResponse EndGetNamespace(IAsyncResult asyncResult)
        {
            return EndInvoke<GetNamespaceResponse>(asyncResult);
        }

        #endregion
        
        #region  GetTable

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
        public virtual GetTableResponse GetTable(GetTableRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTableResponseUnmarshaller.Instance;

            return Invoke<GetTableResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetTable operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTable operation on AmazonS3TablesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTable
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/GetTable">REST API Reference for GetTable Operation</seealso>
        public virtual IAsyncResult BeginGetTable(GetTableRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTableResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetTable operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTable.</param>
        /// 
        /// <returns>Returns a  GetTableResult from S3Tables.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/GetTable">REST API Reference for GetTable Operation</seealso>
        public virtual GetTableResponse EndGetTable(IAsyncResult asyncResult)
        {
            return EndInvoke<GetTableResponse>(asyncResult);
        }

        #endregion
        
        #region  GetTableBucket

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
        public virtual GetTableBucketResponse GetTableBucket(GetTableBucketRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTableBucketRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTableBucketResponseUnmarshaller.Instance;

            return Invoke<GetTableBucketResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetTableBucket operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTableBucket operation on AmazonS3TablesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTableBucket
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/GetTableBucket">REST API Reference for GetTableBucket Operation</seealso>
        public virtual IAsyncResult BeginGetTableBucket(GetTableBucketRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTableBucketRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTableBucketResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetTableBucket operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTableBucket.</param>
        /// 
        /// <returns>Returns a  GetTableBucketResult from S3Tables.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/GetTableBucket">REST API Reference for GetTableBucket Operation</seealso>
        public virtual GetTableBucketResponse EndGetTableBucket(IAsyncResult asyncResult)
        {
            return EndInvoke<GetTableBucketResponse>(asyncResult);
        }

        #endregion
        
        #region  GetTableBucketEncryption

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
        public virtual GetTableBucketEncryptionResponse GetTableBucketEncryption(GetTableBucketEncryptionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTableBucketEncryptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTableBucketEncryptionResponseUnmarshaller.Instance;

            return Invoke<GetTableBucketEncryptionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetTableBucketEncryption operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTableBucketEncryption operation on AmazonS3TablesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTableBucketEncryption
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/GetTableBucketEncryption">REST API Reference for GetTableBucketEncryption Operation</seealso>
        public virtual IAsyncResult BeginGetTableBucketEncryption(GetTableBucketEncryptionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTableBucketEncryptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTableBucketEncryptionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetTableBucketEncryption operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTableBucketEncryption.</param>
        /// 
        /// <returns>Returns a  GetTableBucketEncryptionResult from S3Tables.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/GetTableBucketEncryption">REST API Reference for GetTableBucketEncryption Operation</seealso>
        public virtual GetTableBucketEncryptionResponse EndGetTableBucketEncryption(IAsyncResult asyncResult)
        {
            return EndInvoke<GetTableBucketEncryptionResponse>(asyncResult);
        }

        #endregion
        
        #region  GetTableBucketMaintenanceConfiguration

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
        public virtual GetTableBucketMaintenanceConfigurationResponse GetTableBucketMaintenanceConfiguration(GetTableBucketMaintenanceConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTableBucketMaintenanceConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTableBucketMaintenanceConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetTableBucketMaintenanceConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetTableBucketMaintenanceConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTableBucketMaintenanceConfiguration operation on AmazonS3TablesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTableBucketMaintenanceConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/GetTableBucketMaintenanceConfiguration">REST API Reference for GetTableBucketMaintenanceConfiguration Operation</seealso>
        public virtual IAsyncResult BeginGetTableBucketMaintenanceConfiguration(GetTableBucketMaintenanceConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTableBucketMaintenanceConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTableBucketMaintenanceConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetTableBucketMaintenanceConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTableBucketMaintenanceConfiguration.</param>
        /// 
        /// <returns>Returns a  GetTableBucketMaintenanceConfigurationResult from S3Tables.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/GetTableBucketMaintenanceConfiguration">REST API Reference for GetTableBucketMaintenanceConfiguration Operation</seealso>
        public virtual GetTableBucketMaintenanceConfigurationResponse EndGetTableBucketMaintenanceConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<GetTableBucketMaintenanceConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  GetTableBucketPolicy

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
        public virtual GetTableBucketPolicyResponse GetTableBucketPolicy(GetTableBucketPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTableBucketPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTableBucketPolicyResponseUnmarshaller.Instance;

            return Invoke<GetTableBucketPolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetTableBucketPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTableBucketPolicy operation on AmazonS3TablesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTableBucketPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/GetTableBucketPolicy">REST API Reference for GetTableBucketPolicy Operation</seealso>
        public virtual IAsyncResult BeginGetTableBucketPolicy(GetTableBucketPolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTableBucketPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTableBucketPolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetTableBucketPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTableBucketPolicy.</param>
        /// 
        /// <returns>Returns a  GetTableBucketPolicyResult from S3Tables.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/GetTableBucketPolicy">REST API Reference for GetTableBucketPolicy Operation</seealso>
        public virtual GetTableBucketPolicyResponse EndGetTableBucketPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<GetTableBucketPolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  GetTableEncryption

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
        public virtual GetTableEncryptionResponse GetTableEncryption(GetTableEncryptionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTableEncryptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTableEncryptionResponseUnmarshaller.Instance;

            return Invoke<GetTableEncryptionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetTableEncryption operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTableEncryption operation on AmazonS3TablesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTableEncryption
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/GetTableEncryption">REST API Reference for GetTableEncryption Operation</seealso>
        public virtual IAsyncResult BeginGetTableEncryption(GetTableEncryptionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTableEncryptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTableEncryptionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetTableEncryption operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTableEncryption.</param>
        /// 
        /// <returns>Returns a  GetTableEncryptionResult from S3Tables.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/GetTableEncryption">REST API Reference for GetTableEncryption Operation</seealso>
        public virtual GetTableEncryptionResponse EndGetTableEncryption(IAsyncResult asyncResult)
        {
            return EndInvoke<GetTableEncryptionResponse>(asyncResult);
        }

        #endregion
        
        #region  GetTableMaintenanceConfiguration

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
        public virtual GetTableMaintenanceConfigurationResponse GetTableMaintenanceConfiguration(GetTableMaintenanceConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTableMaintenanceConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTableMaintenanceConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetTableMaintenanceConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetTableMaintenanceConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTableMaintenanceConfiguration operation on AmazonS3TablesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTableMaintenanceConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/GetTableMaintenanceConfiguration">REST API Reference for GetTableMaintenanceConfiguration Operation</seealso>
        public virtual IAsyncResult BeginGetTableMaintenanceConfiguration(GetTableMaintenanceConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTableMaintenanceConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTableMaintenanceConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetTableMaintenanceConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTableMaintenanceConfiguration.</param>
        /// 
        /// <returns>Returns a  GetTableMaintenanceConfigurationResult from S3Tables.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/GetTableMaintenanceConfiguration">REST API Reference for GetTableMaintenanceConfiguration Operation</seealso>
        public virtual GetTableMaintenanceConfigurationResponse EndGetTableMaintenanceConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<GetTableMaintenanceConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  GetTableMaintenanceJobStatus

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
        public virtual GetTableMaintenanceJobStatusResponse GetTableMaintenanceJobStatus(GetTableMaintenanceJobStatusRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTableMaintenanceJobStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTableMaintenanceJobStatusResponseUnmarshaller.Instance;

            return Invoke<GetTableMaintenanceJobStatusResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetTableMaintenanceJobStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTableMaintenanceJobStatus operation on AmazonS3TablesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTableMaintenanceJobStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/GetTableMaintenanceJobStatus">REST API Reference for GetTableMaintenanceJobStatus Operation</seealso>
        public virtual IAsyncResult BeginGetTableMaintenanceJobStatus(GetTableMaintenanceJobStatusRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTableMaintenanceJobStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTableMaintenanceJobStatusResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetTableMaintenanceJobStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTableMaintenanceJobStatus.</param>
        /// 
        /// <returns>Returns a  GetTableMaintenanceJobStatusResult from S3Tables.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/GetTableMaintenanceJobStatus">REST API Reference for GetTableMaintenanceJobStatus Operation</seealso>
        public virtual GetTableMaintenanceJobStatusResponse EndGetTableMaintenanceJobStatus(IAsyncResult asyncResult)
        {
            return EndInvoke<GetTableMaintenanceJobStatusResponse>(asyncResult);
        }

        #endregion
        
        #region  GetTableMetadataLocation

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
        public virtual GetTableMetadataLocationResponse GetTableMetadataLocation(GetTableMetadataLocationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTableMetadataLocationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTableMetadataLocationResponseUnmarshaller.Instance;

            return Invoke<GetTableMetadataLocationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetTableMetadataLocation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTableMetadataLocation operation on AmazonS3TablesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTableMetadataLocation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/GetTableMetadataLocation">REST API Reference for GetTableMetadataLocation Operation</seealso>
        public virtual IAsyncResult BeginGetTableMetadataLocation(GetTableMetadataLocationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTableMetadataLocationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTableMetadataLocationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetTableMetadataLocation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTableMetadataLocation.</param>
        /// 
        /// <returns>Returns a  GetTableMetadataLocationResult from S3Tables.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/GetTableMetadataLocation">REST API Reference for GetTableMetadataLocation Operation</seealso>
        public virtual GetTableMetadataLocationResponse EndGetTableMetadataLocation(IAsyncResult asyncResult)
        {
            return EndInvoke<GetTableMetadataLocationResponse>(asyncResult);
        }

        #endregion
        
        #region  GetTablePolicy

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
        public virtual GetTablePolicyResponse GetTablePolicy(GetTablePolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTablePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTablePolicyResponseUnmarshaller.Instance;

            return Invoke<GetTablePolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetTablePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTablePolicy operation on AmazonS3TablesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTablePolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/GetTablePolicy">REST API Reference for GetTablePolicy Operation</seealso>
        public virtual IAsyncResult BeginGetTablePolicy(GetTablePolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTablePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTablePolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetTablePolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTablePolicy.</param>
        /// 
        /// <returns>Returns a  GetTablePolicyResult from S3Tables.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/GetTablePolicy">REST API Reference for GetTablePolicy Operation</seealso>
        public virtual GetTablePolicyResponse EndGetTablePolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<GetTablePolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  ListNamespaces

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
        public virtual ListNamespacesResponse ListNamespaces(ListNamespacesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListNamespacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListNamespacesResponseUnmarshaller.Instance;

            return Invoke<ListNamespacesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListNamespaces operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListNamespaces operation on AmazonS3TablesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListNamespaces
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/ListNamespaces">REST API Reference for ListNamespaces Operation</seealso>
        public virtual IAsyncResult BeginListNamespaces(ListNamespacesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListNamespacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListNamespacesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListNamespaces operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListNamespaces.</param>
        /// 
        /// <returns>Returns a  ListNamespacesResult from S3Tables.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/ListNamespaces">REST API Reference for ListNamespaces Operation</seealso>
        public virtual ListNamespacesResponse EndListNamespaces(IAsyncResult asyncResult)
        {
            return EndInvoke<ListNamespacesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTableBuckets

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
        public virtual ListTableBucketsResponse ListTableBuckets(ListTableBucketsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTableBucketsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTableBucketsResponseUnmarshaller.Instance;

            return Invoke<ListTableBucketsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTableBuckets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTableBuckets operation on AmazonS3TablesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTableBuckets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/ListTableBuckets">REST API Reference for ListTableBuckets Operation</seealso>
        public virtual IAsyncResult BeginListTableBuckets(ListTableBucketsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTableBucketsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTableBucketsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTableBuckets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTableBuckets.</param>
        /// 
        /// <returns>Returns a  ListTableBucketsResult from S3Tables.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/ListTableBuckets">REST API Reference for ListTableBuckets Operation</seealso>
        public virtual ListTableBucketsResponse EndListTableBuckets(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTableBucketsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTables

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
        public virtual ListTablesResponse ListTables(ListTablesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTablesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTablesResponseUnmarshaller.Instance;

            return Invoke<ListTablesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTables operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTables operation on AmazonS3TablesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTables
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/ListTables">REST API Reference for ListTables Operation</seealso>
        public virtual IAsyncResult BeginListTables(ListTablesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTablesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTablesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTables operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTables.</param>
        /// 
        /// <returns>Returns a  ListTablesResult from S3Tables.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/ListTables">REST API Reference for ListTables Operation</seealso>
        public virtual ListTablesResponse EndListTables(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTablesResponse>(asyncResult);
        }

        #endregion
        
        #region  PutTableBucketEncryption

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
        public virtual PutTableBucketEncryptionResponse PutTableBucketEncryption(PutTableBucketEncryptionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutTableBucketEncryptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutTableBucketEncryptionResponseUnmarshaller.Instance;

            return Invoke<PutTableBucketEncryptionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutTableBucketEncryption operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutTableBucketEncryption operation on AmazonS3TablesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutTableBucketEncryption
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/PutTableBucketEncryption">REST API Reference for PutTableBucketEncryption Operation</seealso>
        public virtual IAsyncResult BeginPutTableBucketEncryption(PutTableBucketEncryptionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutTableBucketEncryptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutTableBucketEncryptionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutTableBucketEncryption operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutTableBucketEncryption.</param>
        /// 
        /// <returns>Returns a  PutTableBucketEncryptionResult from S3Tables.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/PutTableBucketEncryption">REST API Reference for PutTableBucketEncryption Operation</seealso>
        public virtual PutTableBucketEncryptionResponse EndPutTableBucketEncryption(IAsyncResult asyncResult)
        {
            return EndInvoke<PutTableBucketEncryptionResponse>(asyncResult);
        }

        #endregion
        
        #region  PutTableBucketMaintenanceConfiguration

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
        public virtual PutTableBucketMaintenanceConfigurationResponse PutTableBucketMaintenanceConfiguration(PutTableBucketMaintenanceConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutTableBucketMaintenanceConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutTableBucketMaintenanceConfigurationResponseUnmarshaller.Instance;

            return Invoke<PutTableBucketMaintenanceConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutTableBucketMaintenanceConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutTableBucketMaintenanceConfiguration operation on AmazonS3TablesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutTableBucketMaintenanceConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/PutTableBucketMaintenanceConfiguration">REST API Reference for PutTableBucketMaintenanceConfiguration Operation</seealso>
        public virtual IAsyncResult BeginPutTableBucketMaintenanceConfiguration(PutTableBucketMaintenanceConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutTableBucketMaintenanceConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutTableBucketMaintenanceConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutTableBucketMaintenanceConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutTableBucketMaintenanceConfiguration.</param>
        /// 
        /// <returns>Returns a  PutTableBucketMaintenanceConfigurationResult from S3Tables.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/PutTableBucketMaintenanceConfiguration">REST API Reference for PutTableBucketMaintenanceConfiguration Operation</seealso>
        public virtual PutTableBucketMaintenanceConfigurationResponse EndPutTableBucketMaintenanceConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<PutTableBucketMaintenanceConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  PutTableBucketPolicy

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
        public virtual PutTableBucketPolicyResponse PutTableBucketPolicy(PutTableBucketPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutTableBucketPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutTableBucketPolicyResponseUnmarshaller.Instance;

            return Invoke<PutTableBucketPolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutTableBucketPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutTableBucketPolicy operation on AmazonS3TablesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutTableBucketPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/PutTableBucketPolicy">REST API Reference for PutTableBucketPolicy Operation</seealso>
        public virtual IAsyncResult BeginPutTableBucketPolicy(PutTableBucketPolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutTableBucketPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutTableBucketPolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutTableBucketPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutTableBucketPolicy.</param>
        /// 
        /// <returns>Returns a  PutTableBucketPolicyResult from S3Tables.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/PutTableBucketPolicy">REST API Reference for PutTableBucketPolicy Operation</seealso>
        public virtual PutTableBucketPolicyResponse EndPutTableBucketPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<PutTableBucketPolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  PutTableMaintenanceConfiguration

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
        public virtual PutTableMaintenanceConfigurationResponse PutTableMaintenanceConfiguration(PutTableMaintenanceConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutTableMaintenanceConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutTableMaintenanceConfigurationResponseUnmarshaller.Instance;

            return Invoke<PutTableMaintenanceConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutTableMaintenanceConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutTableMaintenanceConfiguration operation on AmazonS3TablesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutTableMaintenanceConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/PutTableMaintenanceConfiguration">REST API Reference for PutTableMaintenanceConfiguration Operation</seealso>
        public virtual IAsyncResult BeginPutTableMaintenanceConfiguration(PutTableMaintenanceConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutTableMaintenanceConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutTableMaintenanceConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutTableMaintenanceConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutTableMaintenanceConfiguration.</param>
        /// 
        /// <returns>Returns a  PutTableMaintenanceConfigurationResult from S3Tables.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/PutTableMaintenanceConfiguration">REST API Reference for PutTableMaintenanceConfiguration Operation</seealso>
        public virtual PutTableMaintenanceConfigurationResponse EndPutTableMaintenanceConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<PutTableMaintenanceConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  PutTablePolicy

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
        public virtual PutTablePolicyResponse PutTablePolicy(PutTablePolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutTablePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutTablePolicyResponseUnmarshaller.Instance;

            return Invoke<PutTablePolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutTablePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutTablePolicy operation on AmazonS3TablesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutTablePolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/PutTablePolicy">REST API Reference for PutTablePolicy Operation</seealso>
        public virtual IAsyncResult BeginPutTablePolicy(PutTablePolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutTablePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutTablePolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutTablePolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutTablePolicy.</param>
        /// 
        /// <returns>Returns a  PutTablePolicyResult from S3Tables.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/PutTablePolicy">REST API Reference for PutTablePolicy Operation</seealso>
        public virtual PutTablePolicyResponse EndPutTablePolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<PutTablePolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  RenameTable

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
        public virtual RenameTableResponse RenameTable(RenameTableRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RenameTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RenameTableResponseUnmarshaller.Instance;

            return Invoke<RenameTableResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RenameTable operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RenameTable operation on AmazonS3TablesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRenameTable
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/RenameTable">REST API Reference for RenameTable Operation</seealso>
        public virtual IAsyncResult BeginRenameTable(RenameTableRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RenameTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RenameTableResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RenameTable operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRenameTable.</param>
        /// 
        /// <returns>Returns a  RenameTableResult from S3Tables.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/RenameTable">REST API Reference for RenameTable Operation</seealso>
        public virtual RenameTableResponse EndRenameTable(IAsyncResult asyncResult)
        {
            return EndInvoke<RenameTableResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateTableMetadataLocation

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
        public virtual UpdateTableMetadataLocationResponse UpdateTableMetadataLocation(UpdateTableMetadataLocationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateTableMetadataLocationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTableMetadataLocationResponseUnmarshaller.Instance;

            return Invoke<UpdateTableMetadataLocationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateTableMetadataLocation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateTableMetadataLocation operation on AmazonS3TablesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateTableMetadataLocation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/UpdateTableMetadataLocation">REST API Reference for UpdateTableMetadataLocation Operation</seealso>
        public virtual IAsyncResult BeginUpdateTableMetadataLocation(UpdateTableMetadataLocationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateTableMetadataLocationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTableMetadataLocationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateTableMetadataLocation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateTableMetadataLocation.</param>
        /// 
        /// <returns>Returns a  UpdateTableMetadataLocationResult from S3Tables.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/UpdateTableMetadataLocation">REST API Reference for UpdateTableMetadataLocation Operation</seealso>
        public virtual UpdateTableMetadataLocationResponse EndUpdateTableMetadataLocation(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateTableMetadataLocationResponse>(asyncResult);
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
            var requestContext = new Amazon.Runtime.Internal.RequestContext(false, CreateSigner())
            {
                ClientConfig = Config,
                OriginalRequest = request,
                Request = new Amazon.Runtime.Internal.DefaultRequest(request, ServiceMetadata.ServiceId)
            };

            var executionContext = new Amazon.Runtime.Internal.ExecutionContext(requestContext, null);
            var resolver = new AmazonS3TablesEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}