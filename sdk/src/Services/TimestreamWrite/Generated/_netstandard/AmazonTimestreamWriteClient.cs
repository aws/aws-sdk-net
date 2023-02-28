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
 * Do not modify this file. This file is generated from the timestream-write-2018-11-01.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.TimestreamWrite.Model;
using Amazon.TimestreamWrite.Model.Internal.MarshallTransformations;
using Amazon.TimestreamWrite.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.TimestreamWrite
{
    /// <summary>
    /// Implementation for accessing TimestreamWrite
    ///
    /// Amazon Timestream Write 
    /// <para>
    /// Amazon Timestream is a fast, scalable, fully managed time-series database service
    /// that makes it easy to store and analyze trillions of time-series data points per day.
    /// With Timestream, you can easily store and analyze IoT sensor data to derive insights
    /// from your IoT applications. You can analyze industrial telemetry to streamline equipment
    /// management and maintenance. You can also store and analyze log data and metrics to
    /// improve the performance and availability of your applications. 
    /// </para>
    ///  
    /// <para>
    /// Timestream is built from the ground up to effectively ingest, process, and store time-series
    /// data. It organizes data to optimize query processing. It automatically scales based
    /// on the volume of data ingested and on the query volume to ensure you receive optimal
    /// performance while inserting and querying data. As your data grows over time, Timestream’s
    /// adaptive query processing engine spans across storage tiers to provide fast analysis
    /// while reducing costs.
    /// </para>
    /// </summary>
    public partial class AmazonTimestreamWriteClient : AmazonServiceClient, IAmazonTimestreamWrite
    {
        private static IServiceMetadata serviceMetadata = new AmazonTimestreamWriteMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonTimestreamWriteClient with the credentials loaded from the application's
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
        public AmazonTimestreamWriteClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonTimestreamWriteConfig()) { }

        /// <summary>
        /// Constructs AmazonTimestreamWriteClient with the credentials loaded from the application's
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
        public AmazonTimestreamWriteClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonTimestreamWriteConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonTimestreamWriteClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonTimestreamWriteClient Configuration Object</param>
        public AmazonTimestreamWriteClient(AmazonTimestreamWriteConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }


        /// <summary>
        /// Constructs AmazonTimestreamWriteClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonTimestreamWriteClient(AWSCredentials credentials)
            : this(credentials, new AmazonTimestreamWriteConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonTimestreamWriteClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonTimestreamWriteClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonTimestreamWriteConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonTimestreamWriteClient with AWS Credentials and an
        /// AmazonTimestreamWriteClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonTimestreamWriteClient Configuration Object</param>
        public AmazonTimestreamWriteClient(AWSCredentials credentials, AmazonTimestreamWriteConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonTimestreamWriteClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonTimestreamWriteClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonTimestreamWriteConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonTimestreamWriteClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonTimestreamWriteClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonTimestreamWriteConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonTimestreamWriteClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonTimestreamWriteClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonTimestreamWriteClient Configuration Object</param>
        public AmazonTimestreamWriteClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonTimestreamWriteConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonTimestreamWriteClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonTimestreamWriteClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonTimestreamWriteConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonTimestreamWriteClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonTimestreamWriteClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonTimestreamWriteConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonTimestreamWriteClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonTimestreamWriteClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonTimestreamWriteClient Configuration Object</param>
        public AmazonTimestreamWriteClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonTimestreamWriteConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private ITimestreamWritePaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public ITimestreamWritePaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new TimestreamWritePaginatorFactory(this);
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
        /// Customizes the runtime pipeline.
        /// </summary>
        /// <param name="pipeline">Runtime pipeline for the current client.</param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonTimestreamWriteEndpointResolver());
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

        #region  EndpointOperation Override

        protected override IEnumerable<DiscoveryEndpointBase> EndpointOperation(EndpointOperationContextBase context)
        {
            return EndpointDiscoveryResolver.ResolveEndpoints(context, () =>
            {
                var request = new DescribeEndpointsRequest
                {
                };
                                
                var response = DescribeEndpoints(request);
                if(response.HttpStatusCode != HttpStatusCode.OK || response.Endpoints == null)
                {
                    return null;
                }

                var endpoints = new List<DiscoveryEndpointBase>();
                foreach(var endpoint in response.Endpoints)
                {
                    endpoints.Add(new DiscoveryEndpoint(endpoint.Address, endpoint.CachePeriodInMinutes));
                }
            
                return endpoints;
            });
        }

        #endregion

        #region  CreateBatchLoadTask

        internal virtual CreateBatchLoadTaskResponse CreateBatchLoadTask(CreateBatchLoadTaskRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateBatchLoadTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBatchLoadTaskResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = CreateBatchLoadTaskEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;

            return Invoke<CreateBatchLoadTaskResponse>(request, options);
        }



        /// <summary>
        /// Creates a new Timestream batch load task. A batch load task processes data from a
        /// CSV source in an S3 location and writes to a Timestream table. A mapping from source
        /// to target is defined in a batch load task. Errors and events are written to a report
        /// at an S3 location. For the report, if the KMS key is not specified, the batch load
        /// task will be encrypted with a Timestream managed KMS key located in your account.
        /// For more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#aws-managed-cmk">Amazon
        /// Web Services managed keys</a>. <a href="https://docs.aws.amazon.com/timestream/latest/developerguide/ts-limits.html">Service
        /// quotas apply</a>. For details, see <a href="https://docs.aws.amazon.com/timestream/latest/developerguide/code-samples.create-batch-load.html">code
        /// sample</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBatchLoadTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateBatchLoadTask service method, as returned by TimestreamWrite.</returns>
        /// <exception cref="Amazon.TimestreamWrite.Model.AccessDeniedException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ConflictException">
        /// Timestream was unable to process this request because it contains resource that already
        /// exists.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.InternalServerException">
        /// Timestream was unable to fully process this request because of an internal server
        /// error.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.InvalidEndpointException">
        /// The requested endpoint was not valid.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ServiceQuotaExceededException">
        /// The instance quota of resource exceeded for this account.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ThrottlingException">
        /// Too many requests were made by a user and they exceeded the service quotas. The request
        /// was throttled.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ValidationException">
        /// An invalid or malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-write-2018-11-01/CreateBatchLoadTask">REST API Reference for CreateBatchLoadTask Operation</seealso>
        public virtual Task<CreateBatchLoadTaskResponse> CreateBatchLoadTaskAsync(CreateBatchLoadTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateBatchLoadTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBatchLoadTaskResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = CreateBatchLoadTaskEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;

            return InvokeAsync<CreateBatchLoadTaskResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateDatabase

        internal virtual CreateDatabaseResponse CreateDatabase(CreateDatabaseRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDatabaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDatabaseResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = CreateDatabaseEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;

            return Invoke<CreateDatabaseResponse>(request, options);
        }



        /// <summary>
        /// Creates a new Timestream database. If the KMS key is not specified, the database will
        /// be encrypted with a Timestream managed KMS key located in your account. For more information,
        /// see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#aws-managed-cmk">Amazon
        /// Web Services managed keys</a>. <a href="https://docs.aws.amazon.com/timestream/latest/developerguide/ts-limits.html">Service
        /// quotas apply</a>. For details, see <a href="https://docs.aws.amazon.com/timestream/latest/developerguide/code-samples.create-db.html">code
        /// sample</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDatabase service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDatabase service method, as returned by TimestreamWrite.</returns>
        /// <exception cref="Amazon.TimestreamWrite.Model.AccessDeniedException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ConflictException">
        /// Timestream was unable to process this request because it contains resource that already
        /// exists.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.InternalServerException">
        /// Timestream was unable to fully process this request because of an internal server
        /// error.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.InvalidEndpointException">
        /// The requested endpoint was not valid.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ServiceQuotaExceededException">
        /// The instance quota of resource exceeded for this account.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ThrottlingException">
        /// Too many requests were made by a user and they exceeded the service quotas. The request
        /// was throttled.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ValidationException">
        /// An invalid or malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-write-2018-11-01/CreateDatabase">REST API Reference for CreateDatabase Operation</seealso>
        public virtual Task<CreateDatabaseResponse> CreateDatabaseAsync(CreateDatabaseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDatabaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDatabaseResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = CreateDatabaseEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;

            return InvokeAsync<CreateDatabaseResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateTable

        internal virtual CreateTableResponse CreateTable(CreateTableRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTableResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = CreateTableEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;

            return Invoke<CreateTableResponse>(request, options);
        }



        /// <summary>
        /// Adds a new table to an existing database in your account. In an Amazon Web Services
        /// account, table names must be at least unique within each Region if they are in the
        /// same database. You might have identical table names in the same Region if the tables
        /// are in separate databases. While creating the table, you must specify the table name,
        /// database name, and the retention properties. <a href="https://docs.aws.amazon.com/timestream/latest/developerguide/ts-limits.html">Service
        /// quotas apply</a>. See <a href="https://docs.aws.amazon.com/timestream/latest/developerguide/code-samples.create-table.html">code
        /// sample</a> for details.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTable service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateTable service method, as returned by TimestreamWrite.</returns>
        /// <exception cref="Amazon.TimestreamWrite.Model.AccessDeniedException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ConflictException">
        /// Timestream was unable to process this request because it contains resource that already
        /// exists.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.InternalServerException">
        /// Timestream was unable to fully process this request because of an internal server
        /// error.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.InvalidEndpointException">
        /// The requested endpoint was not valid.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ServiceQuotaExceededException">
        /// The instance quota of resource exceeded for this account.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ThrottlingException">
        /// Too many requests were made by a user and they exceeded the service quotas. The request
        /// was throttled.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ValidationException">
        /// An invalid or malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-write-2018-11-01/CreateTable">REST API Reference for CreateTable Operation</seealso>
        public virtual Task<CreateTableResponse> CreateTableAsync(CreateTableRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTableResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = CreateTableEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;

            return InvokeAsync<CreateTableResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteDatabase

        internal virtual DeleteDatabaseResponse DeleteDatabase(DeleteDatabaseRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDatabaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDatabaseResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = DeleteDatabaseEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;

            return Invoke<DeleteDatabaseResponse>(request, options);
        }



        /// <summary>
        /// Deletes a given Timestream database. <i>This is an irreversible operation. After a
        /// database is deleted, the time-series data from its tables cannot be recovered.</i>
        /// 
        /// 
        ///  <note> 
        /// <para>
        /// All tables in the database must be deleted first, or a ValidationException error will
        /// be thrown. 
        /// </para>
        ///  
        /// <para>
        /// Due to the nature of distributed retries, the operation can return either success
        /// or a ResourceNotFoundException. Clients should consider them equivalent.
        /// </para>
        ///  </note> 
        /// <para>
        /// See <a href="https://docs.aws.amazon.com/timestream/latest/developerguide/code-samples.delete-db.html">code
        /// sample</a> for details.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDatabase service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDatabase service method, as returned by TimestreamWrite.</returns>
        /// <exception cref="Amazon.TimestreamWrite.Model.AccessDeniedException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.InternalServerException">
        /// Timestream was unable to fully process this request because of an internal server
        /// error.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.InvalidEndpointException">
        /// The requested endpoint was not valid.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ThrottlingException">
        /// Too many requests were made by a user and they exceeded the service quotas. The request
        /// was throttled.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ValidationException">
        /// An invalid or malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-write-2018-11-01/DeleteDatabase">REST API Reference for DeleteDatabase Operation</seealso>
        public virtual Task<DeleteDatabaseResponse> DeleteDatabaseAsync(DeleteDatabaseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDatabaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDatabaseResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = DeleteDatabaseEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;

            return InvokeAsync<DeleteDatabaseResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteTable

        internal virtual DeleteTableResponse DeleteTable(DeleteTableRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTableResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = DeleteTableEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;

            return Invoke<DeleteTableResponse>(request, options);
        }



        /// <summary>
        /// Deletes a given Timestream table. This is an irreversible operation. After a Timestream
        /// database table is deleted, the time-series data stored in the table cannot be recovered.
        /// 
        /// 
        ///  <note> 
        /// <para>
        /// Due to the nature of distributed retries, the operation can return either success
        /// or a ResourceNotFoundException. Clients should consider them equivalent.
        /// </para>
        ///  </note> 
        /// <para>
        /// See <a href="https://docs.aws.amazon.com/timestream/latest/developerguide/code-samples.delete-table.html">code
        /// sample</a> for details.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTable service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTable service method, as returned by TimestreamWrite.</returns>
        /// <exception cref="Amazon.TimestreamWrite.Model.AccessDeniedException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.InternalServerException">
        /// Timestream was unable to fully process this request because of an internal server
        /// error.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.InvalidEndpointException">
        /// The requested endpoint was not valid.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ThrottlingException">
        /// Too many requests were made by a user and they exceeded the service quotas. The request
        /// was throttled.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ValidationException">
        /// An invalid or malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-write-2018-11-01/DeleteTable">REST API Reference for DeleteTable Operation</seealso>
        public virtual Task<DeleteTableResponse> DeleteTableAsync(DeleteTableRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTableResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = DeleteTableEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;

            return InvokeAsync<DeleteTableResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeBatchLoadTask

        internal virtual DescribeBatchLoadTaskResponse DescribeBatchLoadTask(DescribeBatchLoadTaskRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeBatchLoadTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeBatchLoadTaskResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = DescribeBatchLoadTaskEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;

            return Invoke<DescribeBatchLoadTaskResponse>(request, options);
        }



        /// <summary>
        /// Returns information about the batch load task, including configurations, mappings,
        /// progress, and other details. <a href="https://docs.aws.amazon.com/timestream/latest/developerguide/ts-limits.html">Service
        /// quotas apply</a>. See <a href="https://docs.aws.amazon.com/timestream/latest/developerguide/code-samples.describe-batch-load.html">code
        /// sample</a> for details.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeBatchLoadTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeBatchLoadTask service method, as returned by TimestreamWrite.</returns>
        /// <exception cref="Amazon.TimestreamWrite.Model.AccessDeniedException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.InternalServerException">
        /// Timestream was unable to fully process this request because of an internal server
        /// error.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.InvalidEndpointException">
        /// The requested endpoint was not valid.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ThrottlingException">
        /// Too many requests were made by a user and they exceeded the service quotas. The request
        /// was throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-write-2018-11-01/DescribeBatchLoadTask">REST API Reference for DescribeBatchLoadTask Operation</seealso>
        public virtual Task<DescribeBatchLoadTaskResponse> DescribeBatchLoadTaskAsync(DescribeBatchLoadTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeBatchLoadTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeBatchLoadTaskResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = DescribeBatchLoadTaskEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;

            return InvokeAsync<DescribeBatchLoadTaskResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeDatabase

        internal virtual DescribeDatabaseResponse DescribeDatabase(DescribeDatabaseRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDatabaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDatabaseResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = DescribeDatabaseEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;

            return Invoke<DescribeDatabaseResponse>(request, options);
        }



        /// <summary>
        /// Returns information about the database, including the database name, time that the
        /// database was created, and the total number of tables found within the database. <a
        /// href="https://docs.aws.amazon.com/timestream/latest/developerguide/ts-limits.html">Service
        /// quotas apply</a>. See <a href="https://docs.aws.amazon.com/timestream/latest/developerguide/code-samples.describe-db.html">code
        /// sample</a> for details.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDatabase service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDatabase service method, as returned by TimestreamWrite.</returns>
        /// <exception cref="Amazon.TimestreamWrite.Model.AccessDeniedException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.InternalServerException">
        /// Timestream was unable to fully process this request because of an internal server
        /// error.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.InvalidEndpointException">
        /// The requested endpoint was not valid.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ThrottlingException">
        /// Too many requests were made by a user and they exceeded the service quotas. The request
        /// was throttled.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ValidationException">
        /// An invalid or malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-write-2018-11-01/DescribeDatabase">REST API Reference for DescribeDatabase Operation</seealso>
        public virtual Task<DescribeDatabaseResponse> DescribeDatabaseAsync(DescribeDatabaseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDatabaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDatabaseResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = DescribeDatabaseEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;

            return InvokeAsync<DescribeDatabaseResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeEndpoints

        internal virtual DescribeEndpointsResponse DescribeEndpoints(DescribeEndpointsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEndpointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEndpointsResponseUnmarshaller.Instance;

            return Invoke<DescribeEndpointsResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of available endpoints to make Timestream API calls against. This API
        /// operation is available through both the Write and Query APIs.
        /// 
        ///  
        /// <para>
        /// Because the Timestream SDKs are designed to transparently work with the service’s
        /// architecture, including the management and mapping of the service endpoints, <i>we
        /// don't recommend that you use this API operation unless</i>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You are using <a href="https://docs.aws.amazon.com/timestream/latest/developerguide/VPCEndpoints">VPC
        /// endpoints (Amazon Web Services PrivateLink) with Timestream</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your application uses a programming language that does not yet have SDK support
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You require better control over the client-side implementation
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For detailed information on how and when to use and implement DescribeEndpoints, see
        /// <a href="https://docs.aws.amazon.com/timestream/latest/developerguide/Using.API.html#Using-API.endpoint-discovery">The
        /// Endpoint Discovery Pattern</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEndpoints service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeEndpoints service method, as returned by TimestreamWrite.</returns>
        /// <exception cref="Amazon.TimestreamWrite.Model.InternalServerException">
        /// Timestream was unable to fully process this request because of an internal server
        /// error.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ThrottlingException">
        /// Too many requests were made by a user and they exceeded the service quotas. The request
        /// was throttled.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ValidationException">
        /// An invalid or malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-write-2018-11-01/DescribeEndpoints">REST API Reference for DescribeEndpoints Operation</seealso>
        public virtual Task<DescribeEndpointsResponse> DescribeEndpointsAsync(DescribeEndpointsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEndpointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEndpointsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeEndpointsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeTable

        internal virtual DescribeTableResponse DescribeTable(DescribeTableRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTableResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = DescribeTableEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;

            return Invoke<DescribeTableResponse>(request, options);
        }



        /// <summary>
        /// Returns information about the table, including the table name, database name, retention
        /// duration of the memory store and the magnetic store. <a href="https://docs.aws.amazon.com/timestream/latest/developerguide/ts-limits.html">Service
        /// quotas apply</a>. See <a href="https://docs.aws.amazon.com/timestream/latest/developerguide/code-samples.describe-table.html">code
        /// sample</a> for details.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTable service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeTable service method, as returned by TimestreamWrite.</returns>
        /// <exception cref="Amazon.TimestreamWrite.Model.AccessDeniedException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.InternalServerException">
        /// Timestream was unable to fully process this request because of an internal server
        /// error.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.InvalidEndpointException">
        /// The requested endpoint was not valid.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ThrottlingException">
        /// Too many requests were made by a user and they exceeded the service quotas. The request
        /// was throttled.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ValidationException">
        /// An invalid or malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-write-2018-11-01/DescribeTable">REST API Reference for DescribeTable Operation</seealso>
        public virtual Task<DescribeTableResponse> DescribeTableAsync(DescribeTableRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTableResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = DescribeTableEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;

            return InvokeAsync<DescribeTableResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListBatchLoadTasks

        internal virtual ListBatchLoadTasksResponse ListBatchLoadTasks(ListBatchLoadTasksRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListBatchLoadTasksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBatchLoadTasksResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = ListBatchLoadTasksEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;

            return Invoke<ListBatchLoadTasksResponse>(request, options);
        }



        /// <summary>
        /// Provides a list of batch load tasks, along with the name, status, when the task is
        /// resumable until, and other details. See <a href="https://docs.aws.amazon.com/timestream/latest/developerguide/code-samples.list-batch-load-tasks.html">code
        /// sample</a> for details.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBatchLoadTasks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListBatchLoadTasks service method, as returned by TimestreamWrite.</returns>
        /// <exception cref="Amazon.TimestreamWrite.Model.AccessDeniedException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.InternalServerException">
        /// Timestream was unable to fully process this request because of an internal server
        /// error.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.InvalidEndpointException">
        /// The requested endpoint was not valid.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ThrottlingException">
        /// Too many requests were made by a user and they exceeded the service quotas. The request
        /// was throttled.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ValidationException">
        /// An invalid or malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-write-2018-11-01/ListBatchLoadTasks">REST API Reference for ListBatchLoadTasks Operation</seealso>
        public virtual Task<ListBatchLoadTasksResponse> ListBatchLoadTasksAsync(ListBatchLoadTasksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListBatchLoadTasksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBatchLoadTasksResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = ListBatchLoadTasksEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;

            return InvokeAsync<ListBatchLoadTasksResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListDatabases

        internal virtual ListDatabasesResponse ListDatabases(ListDatabasesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDatabasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDatabasesResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = ListDatabasesEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;

            return Invoke<ListDatabasesResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of your Timestream databases. <a href="https://docs.aws.amazon.com/timestream/latest/developerguide/ts-limits.html">Service
        /// quotas apply</a>. See <a href="https://docs.aws.amazon.com/timestream/latest/developerguide/code-samples.list-db.html">code
        /// sample</a> for details.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDatabases service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDatabases service method, as returned by TimestreamWrite.</returns>
        /// <exception cref="Amazon.TimestreamWrite.Model.AccessDeniedException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.InternalServerException">
        /// Timestream was unable to fully process this request because of an internal server
        /// error.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.InvalidEndpointException">
        /// The requested endpoint was not valid.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ThrottlingException">
        /// Too many requests were made by a user and they exceeded the service quotas. The request
        /// was throttled.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ValidationException">
        /// An invalid or malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-write-2018-11-01/ListDatabases">REST API Reference for ListDatabases Operation</seealso>
        public virtual Task<ListDatabasesResponse> ListDatabasesAsync(ListDatabasesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDatabasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDatabasesResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = ListDatabasesEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;

            return InvokeAsync<ListDatabasesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTables

        internal virtual ListTablesResponse ListTables(ListTablesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTablesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTablesResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = ListTablesEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;

            return Invoke<ListTablesResponse>(request, options);
        }



        /// <summary>
        /// Provides a list of tables, along with the name, status, and retention properties of
        /// each table. See <a href="https://docs.aws.amazon.com/timestream/latest/developerguide/code-samples.list-table.html">code
        /// sample</a> for details.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTables service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTables service method, as returned by TimestreamWrite.</returns>
        /// <exception cref="Amazon.TimestreamWrite.Model.AccessDeniedException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.InternalServerException">
        /// Timestream was unable to fully process this request because of an internal server
        /// error.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.InvalidEndpointException">
        /// The requested endpoint was not valid.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ThrottlingException">
        /// Too many requests were made by a user and they exceeded the service quotas. The request
        /// was throttled.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ValidationException">
        /// An invalid or malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-write-2018-11-01/ListTables">REST API Reference for ListTables Operation</seealso>
        public virtual Task<ListTablesResponse> ListTablesAsync(ListTablesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTablesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTablesResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = ListTablesEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;

            return InvokeAsync<ListTablesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForResource

        internal virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = ListTagsForResourceEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }



        /// <summary>
        /// Lists all tags on a Timestream resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by TimestreamWrite.</returns>
        /// <exception cref="Amazon.TimestreamWrite.Model.InvalidEndpointException">
        /// The requested endpoint was not valid.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ThrottlingException">
        /// Too many requests were made by a user and they exceeded the service quotas. The request
        /// was throttled.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ValidationException">
        /// An invalid or malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-write-2018-11-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = ListTagsForResourceEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ResumeBatchLoadTask

        internal virtual ResumeBatchLoadTaskResponse ResumeBatchLoadTask(ResumeBatchLoadTaskRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ResumeBatchLoadTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResumeBatchLoadTaskResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = ResumeBatchLoadTaskEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;

            return Invoke<ResumeBatchLoadTaskResponse>(request, options);
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResumeBatchLoadTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ResumeBatchLoadTask service method, as returned by TimestreamWrite.</returns>
        /// <exception cref="Amazon.TimestreamWrite.Model.AccessDeniedException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.InternalServerException">
        /// Timestream was unable to fully process this request because of an internal server
        /// error.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.InvalidEndpointException">
        /// The requested endpoint was not valid.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ThrottlingException">
        /// Too many requests were made by a user and they exceeded the service quotas. The request
        /// was throttled.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ValidationException">
        /// An invalid or malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-write-2018-11-01/ResumeBatchLoadTask">REST API Reference for ResumeBatchLoadTask Operation</seealso>
        public virtual Task<ResumeBatchLoadTaskResponse> ResumeBatchLoadTaskAsync(ResumeBatchLoadTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ResumeBatchLoadTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResumeBatchLoadTaskResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = ResumeBatchLoadTaskEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;

            return InvokeAsync<ResumeBatchLoadTaskResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TagResource

        internal virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = TagResourceEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;

            return Invoke<TagResourceResponse>(request, options);
        }



        /// <summary>
        /// Associates a set of tags with a Timestream resource. You can then activate these
        /// user-defined tags so that they appear on the Billing and Cost Management console for
        /// cost allocation tracking.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by TimestreamWrite.</returns>
        /// <exception cref="Amazon.TimestreamWrite.Model.InvalidEndpointException">
        /// The requested endpoint was not valid.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ServiceQuotaExceededException">
        /// The instance quota of resource exceeded for this account.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ThrottlingException">
        /// Too many requests were made by a user and they exceeded the service quotas. The request
        /// was throttled.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ValidationException">
        /// An invalid or malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-write-2018-11-01/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = TagResourceEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;

            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UntagResource

        internal virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = UntagResourceEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;

            return Invoke<UntagResourceResponse>(request, options);
        }



        /// <summary>
        /// Removes the association of tags from a Timestream resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by TimestreamWrite.</returns>
        /// <exception cref="Amazon.TimestreamWrite.Model.InvalidEndpointException">
        /// The requested endpoint was not valid.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ServiceQuotaExceededException">
        /// The instance quota of resource exceeded for this account.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ThrottlingException">
        /// Too many requests were made by a user and they exceeded the service quotas. The request
        /// was throttled.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ValidationException">
        /// An invalid or malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-write-2018-11-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = UntagResourceEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateDatabase

        internal virtual UpdateDatabaseResponse UpdateDatabase(UpdateDatabaseRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDatabaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDatabaseResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = UpdateDatabaseEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;

            return Invoke<UpdateDatabaseResponse>(request, options);
        }



        /// <summary>
        /// Modifies the KMS key for an existing database. While updating the database, you must
        /// specify the database name and the identifier of the new KMS key to be used (<code>KmsKeyId</code>).
        /// If there are any concurrent <code>UpdateDatabase</code> requests, first writer wins.
        /// 
        /// 
        ///  
        /// <para>
        /// See <a href="https://docs.aws.amazon.com/timestream/latest/developerguide/code-samples.update-db.html">code
        /// sample</a> for details.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDatabase service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDatabase service method, as returned by TimestreamWrite.</returns>
        /// <exception cref="Amazon.TimestreamWrite.Model.AccessDeniedException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.InternalServerException">
        /// Timestream was unable to fully process this request because of an internal server
        /// error.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.InvalidEndpointException">
        /// The requested endpoint was not valid.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ServiceQuotaExceededException">
        /// The instance quota of resource exceeded for this account.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ThrottlingException">
        /// Too many requests were made by a user and they exceeded the service quotas. The request
        /// was throttled.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ValidationException">
        /// An invalid or malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-write-2018-11-01/UpdateDatabase">REST API Reference for UpdateDatabase Operation</seealso>
        public virtual Task<UpdateDatabaseResponse> UpdateDatabaseAsync(UpdateDatabaseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDatabaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDatabaseResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = UpdateDatabaseEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;

            return InvokeAsync<UpdateDatabaseResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateTable

        internal virtual UpdateTableResponse UpdateTable(UpdateTableRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTableResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = UpdateTableEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;

            return Invoke<UpdateTableResponse>(request, options);
        }



        /// <summary>
        /// Modifies the retention duration of the memory store and magnetic store for your Timestream
        /// table. Note that the change in retention duration takes effect immediately. For example,
        /// if the retention period of the memory store was initially set to 2 hours and then
        /// changed to 24 hours, the memory store will be capable of holding 24 hours of data,
        /// but will be populated with 24 hours of data 22 hours after this change was made. Timestream
        /// does not retrieve data from the magnetic store to populate the memory store. 
        /// 
        ///  
        /// <para>
        /// See <a href="https://docs.aws.amazon.com/timestream/latest/developerguide/code-samples.update-table.html">code
        /// sample</a> for details.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTable service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateTable service method, as returned by TimestreamWrite.</returns>
        /// <exception cref="Amazon.TimestreamWrite.Model.AccessDeniedException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.InternalServerException">
        /// Timestream was unable to fully process this request because of an internal server
        /// error.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.InvalidEndpointException">
        /// The requested endpoint was not valid.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ThrottlingException">
        /// Too many requests were made by a user and they exceeded the service quotas. The request
        /// was throttled.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ValidationException">
        /// An invalid or malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-write-2018-11-01/UpdateTable">REST API Reference for UpdateTable Operation</seealso>
        public virtual Task<UpdateTableResponse> UpdateTableAsync(UpdateTableRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTableResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = UpdateTableEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;

            return InvokeAsync<UpdateTableResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  WriteRecords

        internal virtual WriteRecordsResponse WriteRecords(WriteRecordsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = WriteRecordsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = WriteRecordsResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = WriteRecordsEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;

            return Invoke<WriteRecordsResponse>(request, options);
        }



        /// <summary>
        /// Enables you to write your time-series data into Timestream. You can specify a single
        /// data point or a batch of data points to be inserted into the system. Timestream offers
        /// you a flexible schema that auto detects the column names and data types for your Timestream
        /// tables based on the dimension names and data types of the data points you specify
        /// when invoking writes into the database. 
        /// 
        ///  
        /// <para>
        /// Timestream supports eventual consistency read semantics. This means that when you
        /// query data immediately after writing a batch of data into Timestream, the query results
        /// might not reflect the results of a recently completed write operation. The results
        /// may also include some stale data. If you repeat the query request after a short time,
        /// the results should return the latest data. <a href="https://docs.aws.amazon.com/timestream/latest/developerguide/ts-limits.html">Service
        /// quotas apply</a>. 
        /// </para>
        ///  
        /// <para>
        /// See <a href="https://docs.aws.amazon.com/timestream/latest/developerguide/code-samples.write.html">code
        /// sample</a> for details.
        /// </para>
        ///  
        /// <para>
        ///  <b>Upserts</b> 
        /// </para>
        ///  
        /// <para>
        /// You can use the <code>Version</code> parameter in a <code>WriteRecords</code> request
        /// to update data points. Timestream tracks a version number with each record. <code>Version</code>
        /// defaults to <code>1</code> when it's not specified for the record in the request.
        /// Timestream updates an existing record’s measure value along with its <code>Version</code>
        /// when it receives a write request with a higher <code>Version</code> number for that
        /// record. When it receives an update request where the measure value is the same as
        /// that of the existing record, Timestream still updates <code>Version</code>, if it
        /// is greater than the existing value of <code>Version</code>. You can update a data
        /// point as many times as desired, as long as the value of <code>Version</code> continuously
        /// increases. 
        /// </para>
        ///  
        /// <para>
        ///  For example, suppose you write a new record without indicating <code>Version</code>
        /// in the request. Timestream stores this record, and set <code>Version</code> to <code>1</code>.
        /// Now, suppose you try to update this record with a <code>WriteRecords</code> request
        /// of the same record with a different measure value but, like before, do not provide
        /// <code>Version</code>. In this case, Timestream will reject this update with a <code>RejectedRecordsException</code>
        /// since the updated record’s version is not greater than the existing value of Version.
        /// 
        /// </para>
        ///  
        /// <para>
        /// However, if you were to resend the update request with <code>Version</code> set to
        /// <code>2</code>, Timestream would then succeed in updating the record’s value, and
        /// the <code>Version</code> would be set to <code>2</code>. Next, suppose you sent a
        /// <code>WriteRecords</code> request with this same record and an identical measure value,
        /// but with <code>Version</code> set to <code>3</code>. In this case, Timestream would
        /// only update <code>Version</code> to <code>3</code>. Any further updates would need
        /// to send a version number greater than <code>3</code>, or the update requests would
        /// receive a <code>RejectedRecordsException</code>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the WriteRecords service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the WriteRecords service method, as returned by TimestreamWrite.</returns>
        /// <exception cref="Amazon.TimestreamWrite.Model.AccessDeniedException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.InternalServerException">
        /// Timestream was unable to fully process this request because of an internal server
        /// error.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.InvalidEndpointException">
        /// The requested endpoint was not valid.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.RejectedRecordsException">
        /// WriteRecords would throw this exception in the following cases: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Records with duplicate data where there are multiple records with the same dimensions,
        /// timestamps, and measure names but: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Measure values are different
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Version is not present in the request <i>or</i> the value of version in the new record
        /// is equal to or lower than the existing value
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  In this case, if Timestream rejects data, the <code>ExistingVersion</code> field
        /// in the <code>RejectedRecords</code> response will indicate the current record’s version.
        /// To force an update, you can resend the request with a version for the record set to
        /// a value greater than the <code>ExistingVersion</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  Records with timestamps that lie outside the retention duration of the memory store.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  Records with dimensions or measures that exceed the Timestream defined limits. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  For more information, see <a href="https://docs.aws.amazon.com/timestream/latest/developerguide/ts-limits.html">Quotas</a>
        /// in the Amazon Timestream Developer Guide. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ThrottlingException">
        /// Too many requests were made by a user and they exceeded the service quotas. The request
        /// was throttled.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ValidationException">
        /// An invalid or malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-write-2018-11-01/WriteRecords">REST API Reference for WriteRecords Operation</seealso>
        public virtual Task<WriteRecordsResponse> WriteRecordsAsync(WriteRecordsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = WriteRecordsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = WriteRecordsResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = WriteRecordsEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;

            return InvokeAsync<WriteRecordsResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}